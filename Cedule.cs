using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Diagnostics;
using ControleurServeur;
using System.Security.Cryptography;

namespace ControleurServeur
{
    public class Cedule : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Cedule() : base()
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
        internal static  MonthCalendar mvwSelection;
        internal ComboBox cmbfinprojet;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_1_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_1_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_1_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_2_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_2_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_2_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_3_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_3_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_3_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_3;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_4_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_4_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_4_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_4;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_5_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_5_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_5_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_5;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_6_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_6_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_6_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_6;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_7_ColumnHeader_1;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_7_ColumnHeader_2;
        internal static  System.Windows.Forms.ColumnHeader __lstjoursemaine_7_ColumnHeader_3;
        internal System.Windows.Forms.ListView _lstjoursemaine_7;
        internal System.Windows.Forms.Label _lbljour_6;
        internal System.Windows.Forms.Label _lbljour_5;
        internal System.Windows.Forms.Label _lbljour_4;
        internal System.Windows.Forms.Label _lbljour_3;
        internal System.Windows.Forms.Label _lbljour_2;
        internal System.Windows.Forms.Label _lbljour_1;
        internal System.Windows.Forms.Label _lbljour_0;
        internal System.Windows.Forms.Label _lbljourstr_6;
        internal System.Windows.Forms.Label _lbljourstr_5;
        internal System.Windows.Forms.Label _lbljourstr_4;
        internal System.Windows.Forms.Label _lbljourstr_3;
        internal System.Windows.Forms.Label _lbljourstr_2;
        internal System.Windows.Forms.Label _lbljourstr_1;
        internal System.Windows.Forms.Label _lbljourstr_0;
        internal System.Windows.Forms.Button cmdAjouterAlarme;
        internal static  MonthCalendar mvwChoixDate;
        internal System.Windows.Forms.Button cmdCopier;
        internal System.Windows.Forms.Button cmdAjouterCédule;
        internal System.Windows.Forms.Button cmdsupprimer;
        internal System.Windows.Forms.ListView Lstjour;
        internal System.Windows.Forms.Button cmdEnregistrerAlarme;
        internal System.Windows.Forms.Button cmdAnnulerAlarme;
        internal System.Windows.Forms.TextBox txtMessage;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button cmdRafraichir;
        internal System.Windows.Forms.Button cmdRechercher;
        internal System.Windows.Forms.CheckBox chkfin;
        internal System.Windows.Forms.Button cmdtransport;
        internal System.Windows.Forms.Button cmdAnnulerCédule;
        internal System.Windows.Forms.Button cmdEnregistrerCédule;
        internal ComboBox cmbtransport;
        internal ComboBox cmbclient;
        internal GroupBox frasemaine;
        internal GroupBox fraliste;
        internal MaskedTextBox mskHeure;
        internal GroupBox fraAlarme;
        internal ComboBox cmbheurefin;
        internal ComboBox cmbheuredébut;
        internal ComboBox cmbemployé;
        internal System.Windows.Forms.Label lblprojet;
        internal System.Windows.Forms.Label lbltransport;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal GroupBox frajour;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label11;
        internal ColumnHeader _Lstjour_ColumnHeader_1;
        internal ColumnHeader _Lstjour_ColumnHeader_2;
        internal ColumnHeader _Lstjour_ColumnHeader_3;
        internal ColumnHeader _Lstjour_ColumnHeader_4;
        internal ColumnHeader _Lstjour_ColumnHeader_5;
        private MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button lblDateCedule;
        internal ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ComboBox cmbSelectCedule;
        internal ColumnHeader _Lstjour_ColumnHeader_6;

        //        internal static System.Windows.Forms.Microsoft.VisualBasic.Compatibility.VB6.LabelArray lbljour;
        //        internal static System.Windows.Forms.Microsoft.VisualBasic.Compatibility.VB6.LabelArray lbljourstr;
        //        internal static System.Windows.Forms.Microsoft.VisualBasic.Compatibility.VB6.ListViewArray lstjoursemaine;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbfinprojet = new System.Windows.Forms.ComboBox();
            frasemaine = new System.Windows.Forms.GroupBox();
            _lstjoursemaine_1 = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            _lstjoursemaine_2 = new System.Windows.Forms.ListView();
            _lstjoursemaine_3 = new System.Windows.Forms.ListView();
            _lstjoursemaine_4 = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            _lstjoursemaine_5 = new System.Windows.Forms.ListView();
            _lstjoursemaine_6 = new System.Windows.Forms.ListView();
            _lstjoursemaine_7 = new System.Windows.Forms.ListView();
            _lbljour_6 = new System.Windows.Forms.Label();
            _lbljour_5 = new System.Windows.Forms.Label();
            _lbljour_4 = new System.Windows.Forms.Label();
            _lbljour_3 = new System.Windows.Forms.Label();
            _lbljour_2 = new System.Windows.Forms.Label();
            _lbljour_1 = new System.Windows.Forms.Label();
            _lbljour_0 = new System.Windows.Forms.Label();
            _lbljourstr_6 = new System.Windows.Forms.Label();
            _lbljourstr_5 = new System.Windows.Forms.Label();
            _lbljourstr_4 = new System.Windows.Forms.Label();
            _lbljourstr_3 = new System.Windows.Forms.Label();
            _lbljourstr_2 = new System.Windows.Forms.Label();
            _lbljourstr_1 = new System.Windows.Forms.Label();
            _lbljourstr_0 = new System.Windows.Forms.Label();
            fraliste = new System.Windows.Forms.GroupBox();
            cmdAjouterAlarme = new System.Windows.Forms.Button();
            cmdCopier = new System.Windows.Forms.Button();
            cmdAjouterCédule = new System.Windows.Forms.Button();
            cmdsupprimer = new System.Windows.Forms.Button();
            Lstjour = new System.Windows.Forms.ListView();
            _Lstjour_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _Lstjour_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _Lstjour_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _Lstjour_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _Lstjour_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _Lstjour_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            cmdAnnulerAlarme = new System.Windows.Forms.Button();
            cmdEnregistrerAlarme = new System.Windows.Forms.Button();
            fraAlarme = new System.Windows.Forms.GroupBox();
            cmbSelectCedule = new System.Windows.Forms.ComboBox();
            txtMessage = new System.Windows.Forms.TextBox();
            mskHeure = new System.Windows.Forms.MaskedTextBox();
            Label9 = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            lblprojet = new System.Windows.Forms.Label();
            frajour = new System.Windows.Forms.GroupBox();
            lblDateCedule = new System.Windows.Forms.Button();
            cmdRafraichir = new System.Windows.Forms.Button();
            cmdRechercher = new System.Windows.Forms.Button();
            chkfin = new System.Windows.Forms.CheckBox();
            cmbclient = new System.Windows.Forms.ComboBox();
            cmdtransport = new System.Windows.Forms.Button();
            cmbtransport = new System.Windows.Forms.ComboBox();
            cmdAnnulerCédule = new System.Windows.Forms.Button();
            cmdEnregistrerCédule = new System.Windows.Forms.Button();
            cmbheurefin = new System.Windows.Forms.ComboBox();
            cmbheuredébut = new System.Windows.Forms.ComboBox();
            cmbemployé = new System.Windows.Forms.ComboBox();
            lbltransport = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            frasemaine.SuspendLayout();
            fraliste.SuspendLayout();
            fraAlarme.SuspendLayout();
            frajour.SuspendLayout();
            SuspendLayout();
            // 
            // cmbfinprojet
            // 
            cmbfinprojet.BackColor = System.Drawing.Color.Black;
            cmbfinprojet.ForeColor = System.Drawing.Color.White;
            cmbfinprojet.Location = new System.Drawing.Point(389, 4);
            cmbfinprojet.Name = "cmbfinprojet";
            cmbfinprojet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbfinprojet.Size = new System.Drawing.Size(319, 22);
            cmbfinprojet.TabIndex = 1;
            cmbfinprojet.Text = "Aucune entée";
            // 
            // frasemaine
            // 
            frasemaine.BackColor = System.Drawing.Color.Black;
            frasemaine.Controls.Add(_lstjoursemaine_1);
            frasemaine.Controls.Add(_lstjoursemaine_2);
            frasemaine.Controls.Add(_lstjoursemaine_3);
            frasemaine.Controls.Add(_lstjoursemaine_4);
            frasemaine.Controls.Add(_lstjoursemaine_5);
            frasemaine.Controls.Add(_lstjoursemaine_6);
            frasemaine.Controls.Add(_lstjoursemaine_7);
            frasemaine.Controls.Add(_lbljour_6);
            frasemaine.Controls.Add(_lbljour_5);
            frasemaine.Controls.Add(_lbljour_4);
            frasemaine.Controls.Add(_lbljour_3);
            frasemaine.Controls.Add(_lbljour_2);
            frasemaine.Controls.Add(_lbljour_1);
            frasemaine.Controls.Add(_lbljour_0);
            frasemaine.Controls.Add(_lbljourstr_6);
            frasemaine.Controls.Add(_lbljourstr_5);
            frasemaine.Controls.Add(_lbljourstr_4);
            frasemaine.Controls.Add(_lbljourstr_3);
            frasemaine.Controls.Add(_lbljourstr_2);
            frasemaine.Controls.Add(_lbljourstr_1);
            frasemaine.Controls.Add(_lbljourstr_0);
            frasemaine.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frasemaine.ForeColor = System.Drawing.Color.White;
            frasemaine.Location = new System.Drawing.Point(12, 350);
            frasemaine.Name = "frasemaine";
            frasemaine.Padding = new System.Windows.Forms.Padding(0);
            frasemaine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            frasemaine.Size = new System.Drawing.Size(946, 195);
            frasemaine.TabIndex = 40;
            frasemaine.TabStop = false;
            // 
            // _lstjoursemaine_1
            // 
            _lstjoursemaine_1.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader2,
            columnHeader3});
            _lstjoursemaine_1.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_1.FullRowSelect = true;
            _lstjoursemaine_1.GridLines = true;
            _lstjoursemaine_1.HideSelection = false;
            _lstjoursemaine_1.Location = new System.Drawing.Point(0, 48);
            _lstjoursemaine_1.Name = "_lstjoursemaine_1";
            _lstjoursemaine_1.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_1.TabIndex = 55;
            _lstjoursemaine_1.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Qui";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "horraire";
            // 
            // _lstjoursemaine_2
            // 
            _lstjoursemaine_2.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_2.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_2.FullRowSelect = true;
            _lstjoursemaine_2.GridLines = true;
            _lstjoursemaine_2.HideSelection = false;
            _lstjoursemaine_2.Location = new System.Drawing.Point(135, 48);
            _lstjoursemaine_2.Name = "_lstjoursemaine_2";
            _lstjoursemaine_2.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_2.TabIndex = 56;
            _lstjoursemaine_2.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_2.View = System.Windows.Forms.View.Details;
            // 
            // _lstjoursemaine_3
            // 
            _lstjoursemaine_3.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_3.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_3.FullRowSelect = true;
            _lstjoursemaine_3.GridLines = true;
            _lstjoursemaine_3.HideSelection = false;
            _lstjoursemaine_3.Location = new System.Drawing.Point(271, 48);
            _lstjoursemaine_3.Name = "_lstjoursemaine_3";
            _lstjoursemaine_3.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_3.TabIndex = 57;
            _lstjoursemaine_3.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_3.View = System.Windows.Forms.View.Details;
            // 
            // _lstjoursemaine_4
            // 
            _lstjoursemaine_4.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader4,
            columnHeader5});
            _lstjoursemaine_4.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_4.FullRowSelect = true;
            _lstjoursemaine_4.GridLines = true;
            _lstjoursemaine_4.HideSelection = false;
            _lstjoursemaine_4.Location = new System.Drawing.Point(406, 48);
            _lstjoursemaine_4.Name = "_lstjoursemaine_4";
            _lstjoursemaine_4.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_4.TabIndex = 58;
            _lstjoursemaine_4.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "qui";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Horraire";
            // 
            // _lstjoursemaine_5
            // 
            _lstjoursemaine_5.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_5.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_5.FullRowSelect = true;
            _lstjoursemaine_5.GridLines = true;
            _lstjoursemaine_5.HideSelection = false;
            _lstjoursemaine_5.Location = new System.Drawing.Point(539, 48);
            _lstjoursemaine_5.Name = "_lstjoursemaine_5";
            _lstjoursemaine_5.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_5.TabIndex = 59;
            _lstjoursemaine_5.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_5.View = System.Windows.Forms.View.Details;
            // 
            // _lstjoursemaine_6
            // 
            _lstjoursemaine_6.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_6.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_6.FullRowSelect = true;
            _lstjoursemaine_6.GridLines = true;
            _lstjoursemaine_6.HideSelection = false;
            _lstjoursemaine_6.Location = new System.Drawing.Point(674, 48);
            _lstjoursemaine_6.Name = "_lstjoursemaine_6";
            _lstjoursemaine_6.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_6.TabIndex = 60;
            _lstjoursemaine_6.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_6.View = System.Windows.Forms.View.Details;
            // 
            // _lstjoursemaine_7
            // 
            _lstjoursemaine_7.BackColor = System.Drawing.Color.Black;
            _lstjoursemaine_7.ForeColor = System.Drawing.Color.AliceBlue;
            _lstjoursemaine_7.FullRowSelect = true;
            _lstjoursemaine_7.GridLines = true;
            _lstjoursemaine_7.HideSelection = false;
            _lstjoursemaine_7.Location = new System.Drawing.Point(809, 48);
            _lstjoursemaine_7.Name = "_lstjoursemaine_7";
            _lstjoursemaine_7.Size = new System.Drawing.Size(129, 127);
            _lstjoursemaine_7.TabIndex = 61;
            _lstjoursemaine_7.UseCompatibleStateImageBehavior = false;
            _lstjoursemaine_7.View = System.Windows.Forms.View.Details;
            // 
            // _lbljour_6
            // 
            _lbljour_6.AutoSize = true;
            _lbljour_6.BackColor = System.Drawing.Color.Black;
            _lbljour_6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_6.ForeColor = System.Drawing.Color.White;
            _lbljour_6.Location = new System.Drawing.Point(840, 24);
            _lbljour_6.Name = "_lbljour_6";
            _lbljour_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_6.Size = new System.Drawing.Size(0, 14);
            _lbljour_6.TabIndex = 53;
            // 
            // _lbljour_5
            // 
            _lbljour_5.AutoSize = true;
            _lbljour_5.BackColor = System.Drawing.Color.Black;
            _lbljour_5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_5.ForeColor = System.Drawing.Color.White;
            _lbljour_5.Location = new System.Drawing.Point(709, 24);
            _lbljour_5.Name = "_lbljour_5";
            _lbljour_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_5.Size = new System.Drawing.Size(0, 14);
            _lbljour_5.TabIndex = 51;
            // 
            // _lbljour_4
            // 
            _lbljour_4.AutoSize = true;
            _lbljour_4.BackColor = System.Drawing.Color.Black;
            _lbljour_4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_4.ForeColor = System.Drawing.Color.White;
            _lbljour_4.Location = new System.Drawing.Point(571, 24);
            _lbljour_4.Name = "_lbljour_4";
            _lbljour_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_4.Size = new System.Drawing.Size(0, 14);
            _lbljour_4.TabIndex = 49;
            // 
            // _lbljour_3
            // 
            _lbljour_3.AutoSize = true;
            _lbljour_3.BackColor = System.Drawing.Color.Black;
            _lbljour_3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_3.ForeColor = System.Drawing.Color.White;
            _lbljour_3.Location = new System.Drawing.Point(439, 24);
            _lbljour_3.Name = "_lbljour_3";
            _lbljour_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_3.Size = new System.Drawing.Size(0, 14);
            _lbljour_3.TabIndex = 47;
            // 
            // _lbljour_2
            // 
            _lbljour_2.AutoSize = true;
            _lbljour_2.BackColor = System.Drawing.Color.Black;
            _lbljour_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_2.ForeColor = System.Drawing.Color.White;
            _lbljour_2.Location = new System.Drawing.Point(306, 24);
            _lbljour_2.Name = "_lbljour_2";
            _lbljour_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_2.Size = new System.Drawing.Size(0, 14);
            _lbljour_2.TabIndex = 46;
            // 
            // _lbljour_1
            // 
            _lbljour_1.AutoSize = true;
            _lbljour_1.BackColor = System.Drawing.Color.Black;
            _lbljour_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_1.ForeColor = System.Drawing.Color.White;
            _lbljour_1.Location = new System.Drawing.Point(166, 24);
            _lbljour_1.Name = "_lbljour_1";
            _lbljour_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_1.Size = new System.Drawing.Size(0, 14);
            _lbljour_1.TabIndex = 43;
            // 
            // _lbljour_0
            // 
            _lbljour_0.AutoSize = true;
            _lbljour_0.BackColor = System.Drawing.Color.Black;
            _lbljour_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljour_0.ForeColor = System.Drawing.Color.White;
            _lbljour_0.Location = new System.Drawing.Point(35, 24);
            _lbljour_0.Name = "_lbljour_0";
            _lbljour_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljour_0.Size = new System.Drawing.Size(0, 14);
            _lbljour_0.TabIndex = 42;
            // 
            // _lbljourstr_6
            // 
            _lbljourstr_6.AutoSize = true;
            _lbljourstr_6.BackColor = System.Drawing.Color.Black;
            _lbljourstr_6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_6.ForeColor = System.Drawing.Color.White;
            _lbljourstr_6.Location = new System.Drawing.Point(809, 24);
            _lbljourstr_6.Name = "_lbljourstr_6";
            _lbljourstr_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_6.Size = new System.Drawing.Size(31, 14);
            _lbljourstr_6.TabIndex = 54;
            _lbljourstr_6.Text = "Sam";
            // 
            // _lbljourstr_5
            // 
            _lbljourstr_5.AutoSize = true;
            _lbljourstr_5.BackColor = System.Drawing.Color.Black;
            _lbljourstr_5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_5.ForeColor = System.Drawing.Color.White;
            _lbljourstr_5.Location = new System.Drawing.Point(677, 24);
            _lbljourstr_5.Name = "_lbljourstr_5";
            _lbljourstr_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_5.Size = new System.Drawing.Size(28, 14);
            _lbljourstr_5.TabIndex = 52;
            _lbljourstr_5.Text = "Ven";
            // 
            // _lbljourstr_4
            // 
            _lbljourstr_4.AutoSize = true;
            _lbljourstr_4.BackColor = System.Drawing.Color.Black;
            _lbljourstr_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_4.ForeColor = System.Drawing.Color.White;
            _lbljourstr_4.Location = new System.Drawing.Point(542, 24);
            _lbljourstr_4.Name = "_lbljourstr_4";
            _lbljourstr_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_4.Size = new System.Drawing.Size(27, 14);
            _lbljourstr_4.TabIndex = 50;
            _lbljourstr_4.Text = "Jeu";
            // 
            // _lbljourstr_3
            // 
            _lbljourstr_3.AutoSize = true;
            _lbljourstr_3.BackColor = System.Drawing.Color.Black;
            _lbljourstr_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_3.ForeColor = System.Drawing.Color.White;
            _lbljourstr_3.Location = new System.Drawing.Point(409, 24);
            _lbljourstr_3.Name = "_lbljourstr_3";
            _lbljourstr_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_3.Size = new System.Drawing.Size(29, 14);
            _lbljourstr_3.TabIndex = 48;
            _lbljourstr_3.Text = "Mer";
            // 
            // _lbljourstr_2
            // 
            _lbljourstr_2.AutoSize = true;
            _lbljourstr_2.BackColor = System.Drawing.Color.Black;
            _lbljourstr_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_2.ForeColor = System.Drawing.Color.White;
            _lbljourstr_2.Location = new System.Drawing.Point(274, 24);
            _lbljourstr_2.Name = "_lbljourstr_2";
            _lbljourstr_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_2.Size = new System.Drawing.Size(28, 14);
            _lbljourstr_2.TabIndex = 45;
            _lbljourstr_2.Text = "Mar";
            // 
            // _lbljourstr_1
            // 
            _lbljourstr_1.AutoSize = true;
            _lbljourstr_1.BackColor = System.Drawing.Color.Black;
            _lbljourstr_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_1.ForeColor = System.Drawing.Color.White;
            _lbljourstr_1.Location = new System.Drawing.Point(138, 24);
            _lbljourstr_1.Name = "_lbljourstr_1";
            _lbljourstr_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_1.Size = new System.Drawing.Size(28, 14);
            _lbljourstr_1.TabIndex = 44;
            _lbljourstr_1.Text = "Lun";
            // 
            // _lbljourstr_0
            // 
            _lbljourstr_0.AutoSize = true;
            _lbljourstr_0.BackColor = System.Drawing.Color.Black;
            _lbljourstr_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lbljourstr_0.ForeColor = System.Drawing.Color.White;
            _lbljourstr_0.Location = new System.Drawing.Point(3, 24);
            _lbljourstr_0.Name = "_lbljourstr_0";
            _lbljourstr_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _lbljourstr_0.Size = new System.Drawing.Size(28, 14);
            _lbljourstr_0.TabIndex = 41;
            _lbljourstr_0.Text = "Dim";
            // 
            // fraliste
            // 
            fraliste.BackColor = System.Drawing.Color.Black;
            fraliste.Controls.Add(cmdAjouterAlarme);
            fraliste.Controls.Add(cmdCopier);
            fraliste.Controls.Add(cmdAjouterCédule);
            fraliste.Controls.Add(cmdsupprimer);
            fraliste.Controls.Add(Lstjour);
            fraliste.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraliste.ForeColor = System.Drawing.Color.White;
            fraliste.Location = new System.Drawing.Point(234, 32);
            fraliste.Name = "fraliste";
            fraliste.Padding = new System.Windows.Forms.Padding(0);
            fraliste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraliste.Size = new System.Drawing.Size(715, 297);
            fraliste.TabIndex = 2;
            fraliste.TabStop = false;
            // 
            // cmdAjouterAlarme
            // 
            cmdAjouterAlarme.AutoSize = true;
            cmdAjouterAlarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdAjouterAlarme.BackColor = System.Drawing.Color.Black;
            cmdAjouterAlarme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAjouterAlarme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAjouterAlarme.ForeColor = System.Drawing.Color.White;
            cmdAjouterAlarme.Location = new System.Drawing.Point(119, 263);
            cmdAjouterAlarme.Name = "cmdAjouterAlarme";
            cmdAjouterAlarme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouterAlarme.Size = new System.Drawing.Size(90, 26);
            cmdAjouterAlarme.TabIndex = 10;
            cmdAjouterAlarme.Text = "Ajouter Alarme";
            cmdAjouterAlarme.UseVisualStyleBackColor = true;
            cmdAjouterAlarme.Click += new System.EventHandler(cmdAjouterAlarme_Click);
            cmdAjouterAlarme.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdAjouterAlarme_MouseUp);
            // 
            // cmdCopier
            // 
            cmdCopier.AutoSize = true;
            cmdCopier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdCopier.BackColor = System.Drawing.Color.Black;
            cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCopier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCopier.ForeColor = System.Drawing.Color.White;
            cmdCopier.Location = new System.Drawing.Point(415, 263);
            cmdCopier.Name = "cmdCopier";
            cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCopier.Size = new System.Drawing.Size(50, 26);
            cmdCopier.TabIndex = 13;
            cmdCopier.Text = "Copier";
            cmdCopier.UseVisualStyleBackColor = true;
            cmdCopier.Click += new System.EventHandler(cmdCopier_Click);
            cmdCopier.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdCopier_MouseUp);
            // 
            // cmdAjouterCédule
            // 
            cmdAjouterCédule.AutoSize = true;
            cmdAjouterCédule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdAjouterCédule.BackColor = System.Drawing.Color.Black;
            cmdAjouterCédule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAjouterCédule.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAjouterCédule.ForeColor = System.Drawing.Color.White;
            cmdAjouterCédule.Location = new System.Drawing.Point(223, 263);
            cmdAjouterCédule.Name = "cmdAjouterCédule";
            cmdAjouterCédule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouterCédule.Size = new System.Drawing.Size(90, 26);
            cmdAjouterCédule.TabIndex = 11;
            cmdAjouterCédule.Text = "Ajouter Cedule";
            cmdAjouterCédule.UseVisualStyleBackColor = true;
            cmdAjouterCédule.Click += new System.EventHandler(cmdAjouterCédule_Click);
            cmdAjouterCédule.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdAjouterCédule_MouseUp);
            // 
            // cmdsupprimer
            // 
            cmdsupprimer.AutoSize = true;
            cmdsupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdsupprimer.BackColor = System.Drawing.Color.Black;
            cmdsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdsupprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdsupprimer.ForeColor = System.Drawing.Color.White;
            cmdsupprimer.Location = new System.Drawing.Point(327, 263);
            cmdsupprimer.Name = "cmdsupprimer";
            cmdsupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdsupprimer.Size = new System.Drawing.Size(68, 26);
            cmdsupprimer.TabIndex = 12;
            cmdsupprimer.Text = "Supprimer";
            cmdsupprimer.UseVisualStyleBackColor = true;
            cmdsupprimer.Click += new System.EventHandler(cmdsupprimer_Click);
            cmdsupprimer.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdsupprimer_MouseUp);
            // 
            // Lstjour
            // 
            Lstjour.BackColor = System.Drawing.Color.Black;
            Lstjour.CheckBoxes = true;
            Lstjour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _Lstjour_ColumnHeader_1,
            _Lstjour_ColumnHeader_2,
            _Lstjour_ColumnHeader_3,
            _Lstjour_ColumnHeader_4,
            _Lstjour_ColumnHeader_5,
            _Lstjour_ColumnHeader_6,
            columnHeader1});
            Lstjour.ForeColor = System.Drawing.Color.White;
            Lstjour.FullRowSelect = true;
            Lstjour.GridLines = true;
            Lstjour.HideSelection = false;
            Lstjour.Location = new System.Drawing.Point(13, 16);
            Lstjour.Name = "Lstjour";
            Lstjour.Size = new System.Drawing.Size(687, 242);
            Lstjour.TabIndex = 8;
            Lstjour.UseCompatibleStateImageBehavior = false;
            Lstjour.View = System.Windows.Forms.View.Details;
            Lstjour.Click += new System.EventHandler(Lstjour_Click);
            Lstjour.DoubleClick += new System.EventHandler(Lstjour_DoubleClick);
            Lstjour.KeyDown += new System.Windows.Forms.KeyEventHandler(Lstjour_KeyDown);
            // 
            // _Lstjour_ColumnHeader_1
            // 
            _Lstjour_ColumnHeader_1.Text = "N~";
            _Lstjour_ColumnHeader_1.Width = 80;
            // 
            // _Lstjour_ColumnHeader_2
            // 
            _Lstjour_ColumnHeader_2.Text = "nom";
            // 
            // _Lstjour_ColumnHeader_3
            // 
            _Lstjour_ColumnHeader_3.Text = "début";
            _Lstjour_ColumnHeader_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            _Lstjour_ColumnHeader_3.Width = 40;
            // 
            // _Lstjour_ColumnHeader_4
            // 
            _Lstjour_ColumnHeader_4.Text = "fin";
            _Lstjour_ColumnHeader_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            _Lstjour_ColumnHeader_4.Width = 40;
            // 
            // _Lstjour_ColumnHeader_5
            // 
            _Lstjour_ColumnHeader_5.Text = "client";
            _Lstjour_ColumnHeader_5.Width = 260;
            // 
            // _Lstjour_ColumnHeader_6
            // 
            _Lstjour_ColumnHeader_6.Text = "Tansport";
            _Lstjour_ColumnHeader_6.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdAnnulerAlarme
            // 
            cmdAnnulerAlarme.AutoSize = true;
            cmdAnnulerAlarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdAnnulerAlarme.BackColor = System.Drawing.Color.Black;
            cmdAnnulerAlarme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerAlarme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnulerAlarme.ForeColor = System.Drawing.Color.White;
            cmdAnnulerAlarme.Location = new System.Drawing.Point(625, 254);
            cmdAnnulerAlarme.Name = "cmdAnnulerAlarme";
            cmdAnnulerAlarme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerAlarme.Size = new System.Drawing.Size(57, 26);
            cmdAnnulerAlarme.TabIndex = 38;
            cmdAnnulerAlarme.Text = "Annuler";
            cmdAnnulerAlarme.UseVisualStyleBackColor = true;
            cmdAnnulerAlarme.Click += new System.EventHandler(cmdAnnulerAlarme_Click);
            cmdAnnulerAlarme.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdAnnulerAlarme_MouseUp);
            // 
            // cmdEnregistrerAlarme
            // 
            cmdEnregistrerAlarme.AutoSize = true;
            cmdEnregistrerAlarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdEnregistrerAlarme.BackColor = System.Drawing.Color.Black;
            cmdEnregistrerAlarme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdEnregistrerAlarme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdEnregistrerAlarme.ForeColor = System.Drawing.Color.White;
            cmdEnregistrerAlarme.Location = new System.Drawing.Point(547, 254);
            cmdEnregistrerAlarme.Name = "cmdEnregistrerAlarme";
            cmdEnregistrerAlarme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnregistrerAlarme.Size = new System.Drawing.Size(72, 26);
            cmdEnregistrerAlarme.TabIndex = 37;
            cmdEnregistrerAlarme.Text = "Enregistrer";
            cmdEnregistrerAlarme.UseVisualStyleBackColor = true;
            cmdEnregistrerAlarme.Click += new System.EventHandler(cmdEnregistrerAlarme_Click);
            cmdEnregistrerAlarme.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdEnregistrerAlarme_MouseUp);
            // 
            // fraAlarme
            // 
            fraAlarme.BackColor = System.Drawing.Color.Black;
            fraAlarme.Controls.Add(cmbSelectCedule);
            fraAlarme.Controls.Add(cmdAnnulerAlarme);
            fraAlarme.Controls.Add(txtMessage);
            fraAlarme.Controls.Add(cmdEnregistrerAlarme);
            fraAlarme.Controls.Add(mskHeure);
            fraAlarme.Controls.Add(Label9);
            fraAlarme.Controls.Add(Label7);
            fraAlarme.Controls.Add(lblprojet);
            fraAlarme.Cursor = System.Windows.Forms.Cursors.IBeam;
            fraAlarme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraAlarme.ForeColor = System.Drawing.Color.White;
            fraAlarme.Location = new System.Drawing.Point(243, 32);
            fraAlarme.Name = "fraAlarme";
            fraAlarme.Padding = new System.Windows.Forms.Padding(0);
            fraAlarme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraAlarme.Size = new System.Drawing.Size(711, 297);
            fraAlarme.TabIndex = 32;
            fraAlarme.TabStop = false;
            fraAlarme.Visible = false;
            // 
            // cmbSelectCedule
            // 
            cmbSelectCedule.FormattingEnabled = true;
            cmbSelectCedule.Location = new System.Drawing.Point(80, 217);
            cmbSelectCedule.Name = "cmbSelectCedule";
            cmbSelectCedule.Size = new System.Drawing.Size(392, 22);
            cmbSelectCedule.TabIndex = 39;
            // 
            // txtMessage
            // 
            txtMessage.AcceptsReturn = true;
            txtMessage.BackColor = System.Drawing.Color.Black;
            txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMessage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtMessage.ForeColor = System.Drawing.Color.AliceBlue;
            txtMessage.Location = new System.Drawing.Point(80, 64);
            txtMessage.MaxLength = 0;
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtMessage.Size = new System.Drawing.Size(402, 127);
            txtMessage.TabIndex = 35;
            // 
            // mskHeure
            // 
            mskHeure.AllowPromptAsInput = false;
            mskHeure.BackColor = System.Drawing.Color.Black;
            mskHeure.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskHeure.ForeColor = System.Drawing.Color.White;
            mskHeure.Location = new System.Drawing.Point(80, 32);
            mskHeure.Name = "mskHeure";
            mskHeure.Size = new System.Drawing.Size(73, 20);
            mskHeure.TabIndex = 34;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label9.Location = new System.Drawing.Point(24, 64);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(57, 14);
            Label9.TabIndex = 36;
            Label9.Text = "Message :";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7.Location = new System.Drawing.Point(24, 32);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(42, 14);
            Label7.TabIndex = 33;
            Label7.Text = "Heure :";
            // 
            // lblprojet
            // 
            lblprojet.AutoSize = true;
            lblprojet.BackColor = System.Drawing.Color.Black;
            lblprojet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblprojet.ForeColor = System.Drawing.Color.White;
            lblprojet.Location = new System.Drawing.Point(9, 220);
            lblprojet.Name = "lblprojet";
            lblprojet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblprojet.Size = new System.Drawing.Size(72, 14);
            lblprojet.TabIndex = 22;
            lblprojet.Text = "Quelle cédule";
            // 
            // frajour
            // 
            frajour.BackColor = System.Drawing.Color.Black;
            frajour.Controls.Add(lblDateCedule);
            frajour.Controls.Add(cmdRafraichir);
            frajour.Controls.Add(cmdRechercher);
            frajour.Controls.Add(chkfin);
            frajour.Controls.Add(cmbclient);
            frajour.Controls.Add(cmdtransport);
            frajour.Controls.Add(cmbtransport);
            frajour.Controls.Add(cmdAnnulerCédule);
            frajour.Controls.Add(cmdEnregistrerCédule);
            frajour.Controls.Add(cmbheurefin);
            frajour.Controls.Add(cmbheuredébut);
            frajour.Controls.Add(cmbemployé);
            frajour.Controls.Add(lbltransport);
            frajour.Controls.Add(Label5);
            frajour.Controls.Add(Label4);
            frajour.Controls.Add(Label3);
            frajour.Controls.Add(Label2);
            frajour.Controls.Add(Label1);
            frajour.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frajour.ForeColor = System.Drawing.Color.White;
            frajour.Location = new System.Drawing.Point(243, 32);
            frajour.Name = "frajour";
            frajour.Padding = new System.Windows.Forms.Padding(0);
            frajour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            frajour.Size = new System.Drawing.Size(711, 297);
            frajour.TabIndex = 14;
            frajour.TabStop = false;
            frajour.Visible = false;
            // 
            // lblDateCedule
            // 
            lblDateCedule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lblDateCedule.ForeColor = System.Drawing.Color.LightSteelBlue;
            lblDateCedule.Location = new System.Drawing.Point(72, 68);
            lblDateCedule.Name = "lblDateCedule";
            lblDateCedule.Size = new System.Drawing.Size(113, 23);
            lblDateCedule.TabIndex = 65;
            lblDateCedule.Text = "lblDateCedule";
            lblDateCedule.UseVisualStyleBackColor = true;
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.AutoSize = true;
            cmdRafraichir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRafraichir.BackColor = System.Drawing.Color.Black;
            cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRafraichir.ForeColor = System.Drawing.Color.White;
            cmdRafraichir.Location = new System.Drawing.Point(312, 208);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(66, 26);
            cmdRafraichir.TabIndex = 64;
            cmdRafraichir.Text = "Rafraîchir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            cmdRafraichir.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdRafraichir_MouseUp);
            // 
            // cmdRechercher
            // 
            cmdRechercher.AutoSize = true;
            cmdRechercher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRechercher.BackColor = System.Drawing.Color.Black;
            cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercher.ForeColor = System.Drawing.Color.White;
            cmdRechercher.Location = new System.Drawing.Point(232, 208);
            cmdRechercher.Name = "cmdRechercher";
            cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercher.Size = new System.Drawing.Size(76, 26);
            cmdRechercher.TabIndex = 63;
            cmdRechercher.Text = "Rechercher";
            cmdRechercher.UseVisualStyleBackColor = true;
            cmdRechercher.Click += new System.EventHandler(cmdRechercher_Click);
            cmdRechercher.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdRechercher_MouseUp);
            // 
            // chkfin
            // 
            chkfin.AutoSize = true;
            chkfin.BackColor = System.Drawing.Color.Black;
            chkfin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkfin.ForeColor = System.Drawing.Color.White;
            chkfin.Location = new System.Drawing.Point(301, 112);
            chkfin.Name = "chkfin";
            chkfin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkfin.Size = new System.Drawing.Size(78, 18);
            chkfin.TabIndex = 27;
            chkfin.Text = "Fin Projet";
            chkfin.UseVisualStyleBackColor = true;
            chkfin.CheckStateChanged += new System.EventHandler(chkfin_CheckStateChanged);
            chkfin.MouseUp += new System.Windows.Forms.MouseEventHandler(chkfin_MouseUp);
            // 
            // cmbclient
            // 
            cmbclient.BackColor = System.Drawing.Color.Black;
            cmbclient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbclient.ForeColor = System.Drawing.Color.White;
            cmbclient.Location = new System.Drawing.Point(72, 152);
            cmbclient.Name = "cmbclient";
            cmbclient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbclient.Size = new System.Drawing.Size(313, 22);
            cmbclient.TabIndex = 28;
            // 
            // cmdtransport
            // 
            cmdtransport.AutoSize = true;
            cmdtransport.BackColor = System.Drawing.Color.Black;
            cmdtransport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdtransport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdtransport.ForeColor = System.Drawing.Color.White;
            cmdtransport.Location = new System.Drawing.Point(222, 109);
            cmdtransport.Name = "cmdtransport";
            cmdtransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdtransport.Size = new System.Drawing.Size(70, 26);
            cmdtransport.TabIndex = 26;
            cmdtransport.Text = "Parcourir";
            cmdtransport.UseVisualStyleBackColor = true;
            cmdtransport.Click += new System.EventHandler(cmdTransport_Click);
            cmdtransport.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdtransport_MouseUp);
            // 
            // cmbtransport
            // 
            cmbtransport.BackColor = System.Drawing.Color.Black;
            cmbtransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbtransport.ForeColor = System.Drawing.Color.White;
            cmbtransport.Location = new System.Drawing.Point(72, 112);
            cmbtransport.Name = "cmbtransport";
            cmbtransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbtransport.Size = new System.Drawing.Size(145, 22);
            cmbtransport.Sorted = true;
            cmbtransport.TabIndex = 25;
            cmbtransport.Text = "cmbtransport";
            // 
            // cmdAnnulerCédule
            // 
            cmdAnnulerCédule.AutoSize = true;
            cmdAnnulerCédule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdAnnulerCédule.BackColor = System.Drawing.Color.Black;
            cmdAnnulerCédule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerCédule.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnulerCédule.ForeColor = System.Drawing.Color.White;
            cmdAnnulerCédule.Location = new System.Drawing.Point(448, 264);
            cmdAnnulerCédule.Name = "cmdAnnulerCédule";
            cmdAnnulerCédule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerCédule.Size = new System.Drawing.Size(57, 26);
            cmdAnnulerCédule.TabIndex = 31;
            cmdAnnulerCédule.Text = "Annuler";
            cmdAnnulerCédule.UseVisualStyleBackColor = true;
            cmdAnnulerCédule.Click += new System.EventHandler(cmdAnnulerCédule_Click);
            cmdAnnulerCédule.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdAnnulerCédule_MouseUp);
            // 
            // cmdEnregistrerCédule
            // 
            cmdEnregistrerCédule.AutoSize = true;
            cmdEnregistrerCédule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdEnregistrerCédule.BackColor = System.Drawing.Color.Black;
            cmdEnregistrerCédule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdEnregistrerCédule.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdEnregistrerCédule.ForeColor = System.Drawing.Color.White;
            cmdEnregistrerCédule.Location = new System.Drawing.Point(372, 264);
            cmdEnregistrerCédule.Name = "cmdEnregistrerCédule";
            cmdEnregistrerCédule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnregistrerCédule.Size = new System.Drawing.Size(72, 26);
            cmdEnregistrerCédule.TabIndex = 30;
            cmdEnregistrerCédule.Text = "Enregistrer";
            cmdEnregistrerCédule.UseVisualStyleBackColor = true;
            cmdEnregistrerCédule.Click += new System.EventHandler(cmdEnregistrerCédule_Click);
            cmdEnregistrerCédule.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdEnregistrerCédule_MouseUp);
            // 
            // cmbheurefin
            // 
            cmbheurefin.BackColor = System.Drawing.Color.Black;
            cmbheurefin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbheurefin.ForeColor = System.Drawing.Color.White;
            cmbheurefin.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            cmbheurefin.Location = new System.Drawing.Point(304, 69);
            cmbheurefin.Name = "cmbheurefin";
            cmbheurefin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbheurefin.Size = new System.Drawing.Size(73, 22);
            cmbheurefin.TabIndex = 21;
            // 
            // cmbheuredébut
            // 
            cmbheuredébut.BackColor = System.Drawing.Color.Black;
            cmbheuredébut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbheuredébut.ForeColor = System.Drawing.Color.White;
            cmbheuredébut.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            cmbheuredébut.Location = new System.Drawing.Point(208, 69);
            cmbheuredébut.Name = "cmbheuredébut";
            cmbheuredébut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbheuredébut.Size = new System.Drawing.Size(73, 22);
            cmbheuredébut.TabIndex = 18;
            // 
            // cmbemployé
            // 
            cmbemployé.BackColor = System.Drawing.Color.Black;
            cmbemployé.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbemployé.ForeColor = System.Drawing.Color.White;
            cmbemployé.Location = new System.Drawing.Point(72, 24);
            cmbemployé.Name = "cmbemployé";
            cmbemployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbemployé.Size = new System.Drawing.Size(241, 22);
            cmbemployé.TabIndex = 16;
            // 
            // lbltransport
            // 
            lbltransport.BackColor = System.Drawing.Color.Black;
            lbltransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltransport.ForeColor = System.Drawing.Color.White;
            lbltransport.Location = new System.Drawing.Point(16, 112);
            lbltransport.Name = "lbltransport";
            lbltransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lbltransport.Size = new System.Drawing.Size(73, 17);
            lbltransport.TabIndex = 23;
            lbltransport.Text = "Transport";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(288, 73);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(13, 14);
            Label5.TabIndex = 20;
            Label5.Text = "à";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(191, 73);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(19, 14);
            Label4.TabIndex = 19;
            Label4.Text = "de";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(16, 152);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(33, 14);
            Label3.TabIndex = 29;
            Label3.Text = "Client";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(16, 72);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(40, 14);
            Label2.TabIndex = 17;
            Label2.Text = "Cédulé";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(16, 24);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(47, 14);
            Label1.TabIndex = 15;
            Label1.Text = "Employé";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(286, 9);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(90, 14);
            Label6.TabIndex = 0;
            Label6.Text = "Fin des projets";
            // 
            // Label11
            // 
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(368, 358);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(41, 17);
            Label11.TabIndex = 62;
            Label11.Text = "Mar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = System.Drawing.Color.Black;
            monthCalendar1.ForeColor = System.Drawing.Color.White;
            monthCalendar1.Location = new System.Drawing.Point(5, 72);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 63;
            monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(monthCalendar1_DateSelected);
            // 
            // Cedule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(963, 549);
            Controls.Add(monthCalendar1);
            Controls.Add(fraliste);
            Controls.Add(cmbfinprojet);
            Controls.Add(frasemaine);
            Controls.Add(fraAlarme);
            Controls.Add(frajour);
            Controls.Add(Label6);
            Controls.Add(Label11);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Location = new System.Drawing.Point(3, 22);
            Name = "Cedule";
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
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(Cedule_FormClosed);
            Load += new System.EventHandler(Cedule_Load);
            Resize += new System.EventHandler(Cédule_Resize);
            frasemaine.ResumeLayout(false);
            frasemaine.PerformLayout();
            fraliste.ResumeLayout(false);
            fraliste.PerformLayout();
            fraAlarme.ResumeLayout(false);
            fraAlarme.PerformLayout();
            frajour.ResumeLayout(false);
            frajour.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private const int I_LVW_JOUR_NO = 0;
        private const int I_LVW_JOUR_NOM = 1;
        private const int I_LVW_JOUR_DEBUT = 2;
        private const int I_LVW_JOUR_FIN = 3;
        private const int I_LVW_JOUR_CLIENT = 4;
        private const int I_LVW_JOUR_TRANSPORT = 5;
        private const int I_LVW_SEMAINE_NO = 0;
        private const int I_LVW_SEMAINE_NOM = 1;
        private const int I_LVW_SEMAINE_HEURE = 2;
        private DateTime m_datDateChoisie;
        private bool m_bModeAjouter;
        private bool m_bMonthViewHasFocus;
        [Obsolete]
        private void chkfin_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    if (chkfin.Checked)
                    {
                        chkfin.CheckState = CheckState.Unchecked;
                    }
                    else
                    {
                        chkfin.CheckState = CheckState.Checked;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "chkfin_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdAjouterAlarme_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAjouterAlarme_Click(cmdAjouterAlarme, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAjouterAlarme_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdAjouterCédule_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAjouterCédule_Click(cmdAjouterCédule, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAjouterCédule_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdAnnulerAlarme_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAnnulerAlarme_Click(cmdAnnulerAlarme, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAnnulerAlarme_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdAnnulerCédule_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAnnulerCédule_Click(cmdAnnulerCédule, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAnnulerCédule_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdCopier_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdCopier_Click(cmdCopier, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdCopier_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdEnregistrerAlarme_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdEnregistrerAlarme_Click(cmdEnregistrerAlarme, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdEnregistrerAlarme_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdEnregistrerCédule_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdEnregistrerCédule_Click(cmdEnregistrerCédule, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdEnregistrerCédule_MouseUp", ex);
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirListerClient();
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdRafraichir_Click", ex);
            }
        }
        [Obsolete]
        private void cmdRafraichir_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdRafraichir_Click(cmdRafraichir, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdRafraichir_MouseUp", ex);
            }
        }
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstClient;
                string sRecherche;
                sRecherche = Interaction.InputBox("Quel est le texte à rechercher ?");
                if (!string.IsNullOrEmpty(sRecherche))
                {
                    rstClient = new Recordset();
                    rstClient.Open("SELECT * FROM Client WHERE  NomClient like'%" + sRecherche + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    cmbclient.Items.Clear();
                    while (!rstClient.EOF)
                    {
                        cmbclient.Items.Add(rstClient.Fields["NomClient"].Value);
                        rstClient.MoveNext();
                    }
                    rstClient.Close();
                    // Object rstClient peut ne pas etre détruit avant la mise en corbeille
                    rstClient = null;
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdRechercher_Click", ex);
            }
        }
        [Obsolete]
        private void cmdRechercher_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdRechercher_Click(cmdRechercher, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdRechercher_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdsupprimer_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdsupprimer_Click(cmdsupprimer, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdSupprimer_MouseUp", ex);
            }
        }
        [Obsolete]
        private void cmdtransport_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {

            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdTransport_Click(cmdtransport, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdTransport_MouseUp", ex);
            }
        }
        private void Cédule_Resize(object eventSender, EventArgs eventArgs)
        {
            try
            {
                frasemaine.Refresh();
                frajour.Refresh();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "Form_Resize", ex);
            }
        }
        private void chkfin_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkfin.CheckState == CheckState.Unchecked)
                {
                    AfficherTransport();
                }
                else
                {
                    AfficherProjet();
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "chkfin_Click", ex);
            }
        }
        private void AfficherTransport()
        {
            try
            {
                lblprojet.Visible = false;
                cmbtransport.Visible = true;
                cmdtransport.Visible = true;
                lbltransport.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "AfficherTransport", ex);
            }
        }
        private void AfficherProjet()
        {
            try
            {
                lblprojet.Visible = true;
                cmbtransport.Visible = false;
                cmdtransport.Visible = false;
                lbltransport.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "AfficherProjet", ex);
            }
        }
        [Obsolete]
        private void cmdAjouterCédule_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                m_bModeAjouter = true;
                fraliste.Visible = false;
                fraAlarme.Visible = false;
                frajour.Visible = true;
                cmbemployé.Text = string.Empty;
                var loopTo = (int)(cmbheuredébut.Items.Count - 1);
                for (X = 0; X <= loopTo; X++)
                {
                    if (cmbheuredébut.Items[X].ToString() == "8:00")
                    {
                        cmbheuredébut.SelectedIndex = X;
                        break;
                    }
                }
                var loopTo1 = (int)(cmbheurefin.Items.Count - 1);
                for (X = 0; X <= loopTo1; X++)
                {
                    if (cmbheurefin.Items[X].ToString() == "17:00")
                    {
                        cmbheurefin.SelectedIndex = X;
                        break;
                    }
                }
                cmbtransport.Text = string.Empty;
                cmbclient.Text = string.Empty;
                chkfin.CheckState = CheckState.Unchecked;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAjouter_Click", ex);
            }
        }
        private void cmdAjouterAlarme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bModeAjouter = true;
                mskHeure.Text = "";
                txtMessage.Text = "";
                fraliste.Visible = false;
                fraAlarme.Visible = true;
                frajour.Visible = false;
                mskHeure.Text = "";
                m_bMonthViewHasFocus = false;
                cmbSelectCedule.Items.Clear();
                for(int a= 0  ; a<Lstjour.Items.Count; a++)
                {
                    cmbSelectCedule.Items.Add($"{Lstjour.Items[a].SubItems[0].Text} - {Lstjour.Items[a].SubItems[1].Text} - {Lstjour.Items[a].SubItems[4].Text}");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAjouter_Click", ex);
            }
        }
        private void cmdAnnulerAlarme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraliste.Visible = true;
                fraAlarme.Visible = false;
                frajour.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAnnulerAlarme_Click", ex);
            }
        }
        private void cmdAnnulerCédule_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraliste.Visible = true;
                fraAlarme.Visible = false;
                frajour.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdAnnuler_Click", ex);
            }
        }
        private void CopierAlarme(DateTime datDate)
        {
            try
            {
                string sDate;
                ADODB.Recordset rstAlarme;
                ADODB.Recordset rstCopieAlarme;
                int X;
                sDate = ConvertDate(datDate);
                if (!string.IsNullOrEmpty(sDate))
                {
                    datDate = DateAndTime.DateSerial(int.Parse(Gauche(sDate, 4)),
int.Parse(sDate.Substring(6, 2)),
int.Parse(Droite(sDate, 2)));
                    var loopTo = (int)Lstjour.Items.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        if (Lstjour.Items[X].Selected == true)
                        {
                            rstAlarme = new Recordset();
                            rstCopieAlarme = new Recordset();
                            rstAlarme.Open("SELECT * FROM Alarmes WHERE IDAlarme = " + Lstjour.Items[(int)X].Text + " ORDER BY Initiale", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstCopieAlarme.Open("SELECT * FROM Alarmes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstCopieAlarme.AddNew();
                            rstCopieAlarme.Fields["Initiale"].Value = rstAlarme.Fields["Initiale"].Value;
                            rstCopieAlarme.Fields["Date"].Value = sDate;
                            rstCopieAlarme.Fields["Heure"].Value = rstAlarme.Fields["Heure"].Value;
                            rstCopieAlarme.Fields["JourSemaine"].Value = DateAndTime.Weekday(datDate);
                            rstCopieAlarme.Fields["Type"].Value = "C";
                            rstCopieAlarme.Update();
                            fraliste.Visible = true;
                            fraAlarme.Visible = false;
                            frajour.Visible = false;
                            rstAlarme.Close();
                            rstAlarme = null;
                            rstCopieAlarme.Close();
                            rstCopieAlarme = null;
                        }
                    }
                    RemplirFinProjet();
                    RemplirListerJour();
                    RemplirListerSemaine();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "CopierCedule", ex);
            }
        }
        private void CopierCédule(DateTime datDate)
        {
            try
            {
                string sDate;
                ADODB.Recordset rstCédule;
                ADODB.Recordset rstCopieCédule;
                int X;
                sDate = ConvertDate(datDate);
                if (!string.IsNullOrEmpty(sDate))
                {
                    datDate = DateAndTime.DateSerial(int.Parse(Gauche(sDate, 4)), int.Parse(sDate.Substring(6, 2)), int.Parse(Droite(sDate, 2)));
                    var loopTo = (int)Lstjour.Items.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        if (Lstjour.Items[X].Selected == true)
                        {
                            rstCédule = new Recordset();
                            rstCopieCédule = new Recordset();
                            rstCédule.Open("SELECT * FROM cédule WHERE noenreg = " + Lstjour.Items[(int)X].Text + " ORDER BY initiale", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstCopieCédule.Open("SELECT * FROM cédule", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstCopieCédule.AddNew();
                            rstCopieCédule.Fields["initiale"].Value = rstCédule.Fields["initiale"].Value;
                            rstCopieCédule.Fields["date_cedulé"].Value = sDate;
                            rstCopieCédule.Fields["heure_début"].Value = rstCédule.Fields["heure_début"].Value;
                            rstCopieCédule.Fields["heure_fin"].Value = rstCédule.Fields["heure_fin"].Value;
                            rstCopieCédule.Fields["Client"].Value = rstCédule.Fields["Client"].Value;
                            rstCopieCédule.Fields["joursemaine"].Value = DateAndTime.Weekday(datDate);
                            rstCopieCédule.Fields["finprojet"].Value = rstCédule.Fields["finprojet"].Value;
                            rstCopieCédule.Fields["transport"].Value = rstCédule.Fields["transport"].Value;
                            rstCopieCédule.Update();
                            fraliste.Visible = true;
                            frajour.Visible = false;
                            rstCédule.Close();
                            rstCédule = null;
                            rstCopieCédule.Close();
                            rstCopieCédule = null;
                        }
                    }
                    RemplirFinProjet();
                    RemplirListerJour();
                    RemplirListerSemaine();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "CopierCedule", ex);
            }
        }
        private void cmdCopier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Lstjour.Items.Count > 0)
                {
                    mvwChoixDate.SetDate(mvwSelection.SelectionStart);
                    mvwChoixDate.Visible = true;
                    mvwChoixDate.Focus();
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdCopier_Click", ex);
            }
        }
        private void cmdEnregistrerAlarme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAlarme;
                int iNoEmploye;
                if (!string.IsNullOrEmpty(mskHeure.Text))
                {
                    if (Information.IsDate(mskHeure.Text))
                    {
                        if (!string.IsNullOrEmpty(txtMessage.Text))
                        {
                            rstAlarme = new Recordset();
                            if (m_bModeAjouter == true)
                            {
                                rstAlarme.Open("SELECT * FROM Alarmes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                m_bModeAjouter = false;
                                rstAlarme.AddNew();
                            }
                            else
                            {
                                rstAlarme.Open("SELECT * FROM Alarmes WHERE IDAlarme = " + Lstjour.FocusedItem.Text, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            }
                            rstAlarme.Fields["NoEmploye"].Value = IdNoEmploye;
                            rstAlarme.Fields["Date"].Value = ConvertDate(m_datDateChoisie);
                            rstAlarme.Fields["Heure"].Value = mskHeure.Text;
                            rstAlarme.Fields["Message"].Value = txtMessage.Text;
                            rstAlarme.Fields["JourSemaine"].Value = DateAndTime.Weekday(m_datDateChoisie);
                            rstAlarme.Fields["Initiale"].Value = Conteneur.idInitiales.Text;
                            rstAlarme.Fields["TypeCédule"].Value = "C";
                            if (cmbSelectCedule.Text != "")
                            {
                                rstAlarme.Fields["IDCédule"].Value = int.Parse(cmbSelectCedule.Text.Split('-')[0]);
                            }
                            else
                            {
                                rstAlarme.Fields["IDCédule"].Value = 0;
                            }

                            fraliste.Visible = true;
                            fraAlarme.Visible = false;
                            frajour.Visible = false;
                            rstAlarme.Update();
                            rstAlarme.Close();
                            rstAlarme = null;
                            RemplirFinProjet();
                            RemplirListerJour();
                            RemplirListerSemaine();
                        }
                        else
                        {
                            MessageBox.Show("Il n'y a pas de message à afficher!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'heure est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("L'heure est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdEnregistrerAlarme_Click", ex);
            }
        }
        [Obsolete]
        private void cmdEnregistrerCédule_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstCédule;
                ADODB.Recordset rstEmployé;
                if (cmbemployé.SelectedIndex != -1)
                {
                    rstCédule = new Recordset();
                    rstEmployé = new Recordset();
                    if (m_bModeAjouter == true)
                    {
                        rstCédule.Open("SELECT * FROM cédule", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        m_bModeAjouter = false;
                        rstCédule.AddNew();
                    }
                    else
                    {
                        rstCédule.Open("SELECT * FROM cédule WHERE noenreg = " + Lstjour.Items[Lstjour.FocusedItem.Index].Text + " ORDER BY initiale", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    rstEmployé.Open($"SELECT initiale FROM employés WHERE employe = '{cmbemployé.Items[cmbemployé.SelectedIndex].ToString()}'" , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstCédule.Fields["initiale"].Value = rstEmployé.Fields["initiale"].Value;
                    rstEmployé.Close();
                    rstEmployé = null;
                    rstCédule.Fields["date_cedulé"].Value = ConvertDate(m_datDateChoisie);
                    if (string.IsNullOrEmpty(cmbheuredébut.Text))
                    {
                        rstCédule.Fields["heure_début"].Value = " ";
                    }
                    else
                    {
                        rstCédule.Fields["heure_début"].Value = cmbheuredébut.Text;
                    }
                    if (string.IsNullOrEmpty(cmbheurefin.Text))
                    {
                        rstCédule.Fields["heure_fin"].Value = " ";
                    }
                    else
                    {
                        rstCédule.Fields["heure_fin"].Value = cmbheurefin.Text;
                    }
                    if (string.IsNullOrEmpty(cmbclient.Text))
                    {
                        rstCédule.Fields["CLIENT"].Value = " ";
                    }
                    else
                    {
                        rstCédule.Fields["CLIENT"].Value = cmbclient.Text;
                    }
                    rstCédule.Fields["joursemaine"].Value = DateAndTime.Weekday(m_datDateChoisie);
                    rstCédule.Fields["finprojet"].Value = chkfin.CheckState;
                    if (chkfin.CheckState == CheckState.Unchecked)
                    {
                        if (string.IsNullOrEmpty(cmbtransport.Text))
                        {
                            rstCédule.Fields["transport"].Value = " ";
                        }
                        else
                        {
                            rstCédule.Fields["transport"].Value = cmbtransport.Text;
                        }
                    }
                    else if (string.IsNullOrEmpty(cmbtransport.Text))
                    {
                        rstCédule.Fields["transport"].Value = " ";
                    }
                    else
                    {
                        rstCédule.Fields["transport"].Value = cmbtransport.Text;
                    }
                    rstCédule.Update();
                    fraliste.Visible = true;
                    fraAlarme.Visible = false;
                    frajour.Visible = false;
                    rstCédule.Close();
                    rstCédule = null;
                    RemplirFinProjet();
                    RemplirListerJour();
                    RemplirListerSemaine();
                }
                else
                {
                    MessageBox.Show("Aucun employé de sélectionné!");
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdEnregistrerCédule_Click", ex);
            }
        }
        private void cmdsupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                if (Lstjour.Items.Count > 0)
                {
                    if (MessageBox.Show("Voulez-vous supprimer ce(ces) rendez-vous?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var loopTo = (int)Lstjour.Items.Count;
                        for (X = 1; X <= loopTo; X++)
                        {
                            if (Lstjour.Items[X].Selected == true)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Lstjour.Items[X].Tag, "A", false)))
                                {
                                    UpdateSQL("DELETE FROM Alarmes WHERE IDAlarme = " + Lstjour.Items[X].Text);
                                }
                                else
                                {
                                    UpdateSQL("DELETE FROM Cédule WHERE noenreg = " + Lstjour.Items[X].Text);
                                }
                            }
                        }
                        RemplirFinProjet();
                        RemplirListerJour();
                        RemplirListerSemaine();
                    }
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdSupprimer_Click", ex);
            }
        }
        [Obsolete]
        private void cmdTransport_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstTransport;
                string sTransport;
                int X;
                sTransport = cmbtransport.Text;
                if (!string.IsNullOrEmpty(cmbtransport.Text))
                {
                    if (ComboContient(cmbtransport, sTransport))
                    {
                        if (MessageBox.Show("Voulez-vous supprimer le transport " + cmbtransport.Text + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateSQL("DELETE FROM transport WHERE transport = '" + cmbtransport.Text.Replace("'", "''") + "'");
                        }
                        else if (MessageBox.Show("Voulez-vous ajouter un transport?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sTransport = Interaction.InputBox("Veuillez entrer son nom!");
                            if (!string.IsNullOrEmpty(sTransport))
                            {
                                if (!ComboContient(cmbtransport, sTransport))
                                {
                                    rstTransport = new Recordset();
                                    rstTransport.Open("SELECT * FROM Transport", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    rstTransport.AddNew();
                                    rstTransport.Fields["transport"].Value = sTransport;
                                    rstTransport.Update();
                                    rstTransport.Close();
                                    rstTransport = null;
                                }
                                else
                                {
                                    MessageBox.Show("Ce transport existe déjà!");
                                }
                            }
                        }
                    }
                    else if (MessageBox.Show("Voulez-vous ajouter un transport?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sTransport = Interaction.InputBox("Veuillez entrer son nom!");
                        if (!string.IsNullOrEmpty(sTransport))
                        {
                            if (!ComboContient(cmbtransport, sTransport))
                            {
                                rstTransport = new Recordset();
                                rstTransport.Open("SELECT * FROM transport", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                rstTransport.AddNew();
                                rstTransport.Fields["transport"].Value = sTransport;
                                rstTransport.Update();
                                rstTransport.Close();
                                rstTransport = null;
                            }
                            else
                            {
                                MessageBox.Show("Ce transport existe déjà!");
                            }
                        }
                    }
                }
                else if (MessageBox.Show("Voulez-vous ajouter un transport?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sTransport = Interaction.InputBox("Veuillez entrer son nom!");
                    if (!string.IsNullOrEmpty(sTransport))
                    {
                        if (!ComboContient(cmbtransport, sTransport))
                        {
                            rstTransport = new Recordset();
                            rstTransport.Open("SELECT * FROM transport", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstTransport.AddNew();
                            rstTransport.Fields["transport"].Value = sTransport;
                            rstTransport.Update();
                            rstTransport.Close();
                            rstTransport = null;
                        }
                        else
                        {
                            MessageBox.Show("Ce transport existe déjà!");
                        }
                    }
                }
                RemplirTransport();
                var loopTo = (int)(cmbtransport.Items.Count - 1);
                for (X = 0; X <= loopTo; X++)
                {
                    if ((cmbtransport.Items[X].ToString() ?? "") == (sTransport ?? ""))
                    {
                        cmbtransport.SelectedIndex = X;
                        break;
                    }
                }
                if (cmbtransport.SelectedIndex == -1)
                {
                    cmbtransport.SelectedIndex = 0;
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "cmdtransport_Click", ex);
            }
        }
        private void Cedule_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            InitialiserListViewJourSemaine();
            InitListerCedules();
            m_datDateChoisie = DateTime.Today;
            int decalage = GetDecallage(m_datDateChoisie);
            _lbljour_0.Text = m_datDateChoisie.AddDays(0 + decalage).ToShortDateString();
            _lbljour_1.Text = m_datDateChoisie.AddDays(1 + decalage).ToShortDateString();
            _lbljour_2.Text = m_datDateChoisie.AddDays(2 + decalage).ToShortDateString();
            _lbljour_3.Text = m_datDateChoisie.AddDays(3 + decalage).ToShortDateString();
            _lbljour_4.Text = m_datDateChoisie.AddDays(4 + decalage).ToShortDateString();
            _lbljour_5.Text = m_datDateChoisie.AddDays(5 + decalage).ToShortDateString();
            _lbljour_6.Text = m_datDateChoisie.AddDays(6 + decalage).ToShortDateString();
            m_datDebut = _lbljour_0.Text;
            m_datFin = _lbljour_6.Text;
            g_bCeduleOuverte = true;
            RemplirListerEmployé();
            DispatchToDays();
            try
            {
/*                RemplirFinProjet();
                RemplirTransport();
                RemplirListerClient();
                RemplirListerSemaine();*/
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "Form_Load", ex);
            }
        }

        private void InitialiserListViewJourSemaine()
        {
            _lstjoursemaine_1.Columns.Clear(); _lstjoursemaine_1.Columns.Add("Qui"); _lstjoursemaine_1.Columns.Add("Plage");
            _lstjoursemaine_2.Columns.Clear(); _lstjoursemaine_2.Columns.Add("Qui"); _lstjoursemaine_2.Columns.Add("Plage");
            _lstjoursemaine_3.Columns.Clear(); _lstjoursemaine_3.Columns.Add("Qui"); _lstjoursemaine_3.Columns.Add("Plage");
            _lstjoursemaine_4.Columns.Clear(); _lstjoursemaine_4.Columns.Add("Qui"); _lstjoursemaine_4.Columns.Add("Plage");
            _lstjoursemaine_5.Columns.Clear(); _lstjoursemaine_5.Columns.Add("Qui"); _lstjoursemaine_5.Columns.Add("Plage");
            _lstjoursemaine_6.Columns.Clear(); _lstjoursemaine_6.Columns.Add("Qui"); _lstjoursemaine_6.Columns.Add("Plage");
            _lstjoursemaine_7.Columns.Clear(); _lstjoursemaine_7.Columns.Add("Qui"); _lstjoursemaine_7.Columns.Add("Plage");
        }
        private void InitListerCedules()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            Lstjour.Items.Clear();
            for(int a= 0  ; a< Lstjour.Columns.Count; a++) { Lstjour.Columns[a].Text=Lstjour.Columns[a].Text.ToUpper(); } //harmonise le look des entetes du tableau tout en caps
            SqlLinkODBC(rst, "autogrb", "SELECT *  FROM [DBO].[Cédule]");
            while (!rst.EOF)
            {
                ListViewItem itmCedule = Lstjour.Items.Add(string.Empty);
                itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["noenreg"].Value}"));
                itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["Initiale"].Value}"));
                itmCedule.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["heure_début"].Value}"));
                itmCedule.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["heure_fin"].Value}"));
                itmCedule.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["CLIENT"].Value}"));
                itmCedule.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["transport"].Value}"));
                itmCedule.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rst.Fields["date_cedulé"].Value}"));
                if ((int)rst.Fields["finprojet"].Value == 1)
                {
                    itmCedule.Checked = true;
                    cmbfinprojet.Items.Add($"{$"{rst.Fields["client"].Value}".Trim()}    {rst.Fields["date_cedulé"].Value}");
                }
                if (cmbfinprojet.Items.Count > 0) cmbfinprojet.SelectedIndex = 0;
                rst.MoveNext();
            }
            rst.Close();
        }

        private void DispatchToDays()
        {
            if (Lstjour.Items.Count > 0)
            {
                for (int a = 0; a < Lstjour.Items.Count; a++)
                {

                    if (_lbljour_0.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_1.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_1.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_2.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} -{Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_2.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_3.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_3.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_4.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_4.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_5.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_5.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_6.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                    if (_lbljour_6.Text == Lstjour.Items[a].SubItems[6].Text)
                    {
                        ListViewItem itmCedule = _lstjoursemaine_7.Items.Add(string.Empty);
                        itmCedule.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Lstjour.Items[a].SubItems[1].Text));
                        itmCedule.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{Lstjour.Items[a].SubItems[2].Text} - {Lstjour.Items[a].SubItems[3].Text}"));
                    }
                }
            }
        }
        private void RemplirFinProjet()
        {
            try
            {
                ADODB.Recordset rstCedule;
                rstCedule = new Recordset();
                rstCedule.Open("SELECT DATE_CEDULÉ, TRANSPORT FROM CÉDULE WHERE FINPROJET = 1 ORDER BY DATE_CEDULÉ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbfinprojet.Items.Clear();
                if (rstCedule.RecordCount < 1) { MessageBox.Show("Aucun enregistrement n'a été trouvé dans la table des cédules", Application.ProductName + ".SQL.Table.Null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                while (!rstCedule.EOF)
                {
                    cmbfinprojet.Items.Add($"{$"{rstCedule.Fields["transport"].Value}".Trim()}    { rstCedule.Fields["date_cedulé"].Value}" );
                    rstCedule.MoveNext();
                }
                rstCedule.Close();
                rstCedule = null;
                if (cmbfinprojet.Items.Count > 0) { cmbfinprojet.SelectedIndex = 0; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirFinProjet", ex);
            }
        }
        private void RemplirTransport()
        {
            ADODB.Recordset rstTransport = new ADODB.Recordset();
            rstTransport.Open("SELECT * FROM TRANSPORT ORDER BY TRANSPORT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            cmbtransport.Items.Clear();
            try
            {
                while (!rstTransport.EOF)
                {
                    cmbtransport.Items.Add(rstTransport.Fields["transport"].Value);
                    rstTransport.MoveNext();
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirTransport", ex);
            }
            rstTransport.Close();
            rstTransport = null;
            return;
        }
        private void RemplirListerEmployé()
        {
            try
            {
                cmbemployé.Items.Clear();
                foreach (DB_Employe p in Employes)
                {
                    cmbemployé.Items.Add(p.Employes);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerEmployé", ex);
            }
        }
        private void RemplirListerClient()
        {
            try
            {
                cmbclient.Items.Clear();
                foreach (ListItem p in clients)
                {
                    cmbclient.Items.Add(p);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerClient", ex);
            }
        }
        public void RemplirListerJour()
        {
            try
            {
                ADODB.Recordset rstCédule = new ADODB.Recordset();
                ListViewItem itmCedule = default(ListViewItem);
                Lstjour.Items.Clear();
                rstCédule.Open("SELECT * FROM CÉDULE WHERE DATE_CEDULÉ = '" + ConvertDate(m_datDateChoisie) + "' ORDER BY INITIALE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstCédule.RecordCount < 1) { MessageBox.Show("Aucun enregistrement n'a été trouvé dans la table des cédules", Application.ProductName + ".SQL.Table.Null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                while (!rstCédule.EOF)
                {
                    itmCedule = Lstjour.Items.Add(string.Empty);
                    itmCedule.Text = (string)(rstCédule.Fields["noenreg"].Value);
                    itmCedule.Tag = "C";
                    if (!(rstCédule.Fields["Initiale"].Value is DBNull))
                    {
                        if (itmCedule.SubItems.Count > I_LVW_JOUR_NOM)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_NOM].Text = (string)(rstCédule.Fields["Initiale"].Value);
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_NOM, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["Initiale"].Value)));
                        }
                    }
                    else if (itmCedule.SubItems.Count > I_LVW_JOUR_NOM)
                    {
                        itmCedule.SubItems[I_LVW_JOUR_NOM].Text = "";
                    }
                    else
                    {
                        itmCedule.SubItems.Insert(I_LVW_JOUR_NOM, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    if (!(rstCédule.Fields["heure_début"].Value is DBNull))
                    {
                        if (itmCedule.SubItems.Count > I_LVW_JOUR_DEBUT)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_DEBUT].Text = (string)(rstCédule.Fields["heure_début"].Value);
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_DEBUT, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["heure_début"].Value)));
                        }
                    }
                    else if (itmCedule.SubItems.Count > I_LVW_JOUR_DEBUT)
                    {
                        itmCedule.SubItems[I_LVW_JOUR_DEBUT].Text = "";
                    }
                    else
                    {
                        itmCedule.SubItems.Insert(I_LVW_JOUR_DEBUT, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    if (!(rstCédule.Fields["heure_fin"].Value is DBNull))
                    {
                        if (itmCedule.SubItems.Count > I_LVW_JOUR_FIN)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_FIN].Text = (string)(rstCédule.Fields["heure_fin"].Value);
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_FIN, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["heure_fin"].Value)));
                        }
                    }
                    else if (itmCedule.SubItems.Count > I_LVW_JOUR_FIN)
                    {
                        itmCedule.SubItems[I_LVW_JOUR_FIN].Text = "";
                    }
                    else
                    {
                        itmCedule.SubItems.Insert(I_LVW_JOUR_FIN, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    if (!(rstCédule.Fields["CLIENT"].Value is DBNull))
                    {
                        if (itmCedule.SubItems.Count > I_LVW_JOUR_CLIENT)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_CLIENT].Text = (string)(rstCédule.Fields["CLIENT"].Value);
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_CLIENT, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["CLIENT"].Value)));
                        }
                    }
                    else if (itmCedule.SubItems.Count > I_LVW_JOUR_CLIENT)
                    {
                        itmCedule.SubItems[I_LVW_JOUR_CLIENT].Text = "";
                    }
                    else
                    {
                        itmCedule.SubItems.Insert(I_LVW_JOUR_CLIENT, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstCédule.Fields["finprojet"].Value, 0, false)))
                    {
                        if (!(rstCédule.Fields["transport"].Value is DBNull))
                        {
                            if (itmCedule.SubItems.Count > I_LVW_JOUR_TRANSPORT)
                            {
                                itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].Text = (string)(rstCédule.Fields["transport"].Value);
                            }
                            else
                            {
                                itmCedule.SubItems.Insert(I_LVW_JOUR_TRANSPORT, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["transport"].Value)));
                            }
                        }
                        else if (itmCedule.SubItems.Count > I_LVW_JOUR_TRANSPORT)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].Text = "";
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_TRANSPORT, new ListViewItem.ListViewSubItem(null, ""));
                        }
                        itmCedule.SubItems[I_LVW_JOUR_NOM].ForeColor = COLOR_BLEU;
                        itmCedule.SubItems[I_LVW_JOUR_DEBUT].ForeColor = COLOR_BLEU;
                        itmCedule.SubItems[I_LVW_JOUR_FIN].ForeColor = COLOR_BLEU;
                        itmCedule.SubItems[I_LVW_JOUR_CLIENT].ForeColor = COLOR_BLEU;
                        itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].ForeColor = COLOR_BLEU;
                    }
                    else
                    {
                        if (!(rstCédule.Fields["transport"].Value is DBNull))
                        {
                            if (itmCedule.SubItems.Count > I_LVW_JOUR_TRANSPORT)
                            {
                                itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].Text = (string)(Operators.AddObject("Fin ", rstCédule.Fields["transport"].Value));
                            }
                            else
                            {
                                itmCedule.SubItems.Insert(I_LVW_JOUR_TRANSPORT, new ListViewItem.ListViewSubItem(null, (string)(Operators.AddObject("Fin ", rstCédule.Fields["transport"].Value))));
                            }
                        }
                        else if (itmCedule.SubItems.Count > I_LVW_JOUR_TRANSPORT)
                        {
                            itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].Text = "Fin";
                        }
                        else
                        {
                            itmCedule.SubItems.Insert(I_LVW_JOUR_TRANSPORT, new ListViewItem.ListViewSubItem(null, "Fin"));
                        }
                        itmCedule.SubItems[I_LVW_JOUR_NOM].ForeColor = COLOR_ROUGE;
                        itmCedule.SubItems[I_LVW_JOUR_DEBUT].ForeColor = COLOR_ROUGE;
                        itmCedule.SubItems[I_LVW_JOUR_FIN].ForeColor = COLOR_ROUGE;
                        itmCedule.SubItems[I_LVW_JOUR_CLIENT].ForeColor = COLOR_ROUGE;
                        itmCedule.SubItems[I_LVW_JOUR_TRANSPORT].ForeColor = COLOR_ROUGE;
                    }
                    rstCédule.MoveNext();
                }
                rstCédule.Close();
                rstCédule = null;
                RemplirListerJourAlarme();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerJour", ex);
            }
        }
        public void RemplirListerSemaine()
        {
            try
            {
                ADODB.Recordset rstCédule;
                int iJourSemaine;
                DateTime datPremiereDate;
                DateTime datDerniereDate;
                string sHeureDebutFin;
                ListViewItem itmSemaine = Lstjour.Items.Add(string.Empty);
                _lstjoursemaine_1.Items.Clear();
                _lstjoursemaine_2.Items.Clear();
                _lstjoursemaine_3.Items.Clear();
                _lstjoursemaine_4.Items.Clear();
                _lstjoursemaine_5.Items.Clear();
                _lstjoursemaine_6.Items.Clear();
                _lstjoursemaine_7.Items.Clear();
                iJourSemaine = (int)DateAndTime.Weekday(m_datDateChoisie);
                datPremiereDate = m_datDateChoisie;
                datDerniereDate = m_datDateChoisie;
                while (!(DateAndTime.Weekday(datPremiereDate) == 1)) datPremiereDate = DateTime.FromOADate(datPremiereDate.ToOADate() - 1d);
                while (!(DateAndTime.Weekday(datDerniereDate) == 7)) datDerniereDate = DateTime.FromOADate(datDerniereDate.ToOADate() + 1d);
                rstCédule = new Recordset();
                rstCédule.Open("SELECT * FROM cédule WHERE date_cedulé between '" + datDerniereDate.ToShortDateString() + "' AND '" + datPremiereDate.ToShortDateString() + "' ORDER BY initiale", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                _lbljour_0.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate())).ToString();
                _lbljour_1.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 1)).ToString();
                _lbljour_2.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 2)).ToString();
                _lbljour_3.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 3)).ToString();
                _lbljour_4.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 4)).ToString();
                _lbljour_5.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 5)).ToString();
                _lbljour_6.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 6)).ToString();
                while (!rstCédule.EOF)
                {
                    switch (int.Parse(rstCédule.Fields["joursemaine"].Value))
                    {
                        case 0: { itmSemaine = _lstjoursemaine_1.Items.Add(string.Empty); } break;
                        case 1: { itmSemaine = _lstjoursemaine_2.Items.Add(string.Empty); } break;
                        case 2: { itmSemaine = _lstjoursemaine_3.Items.Add(string.Empty); } break;
                        case 3: { itmSemaine = _lstjoursemaine_4.Items.Add(string.Empty); } break;
                        case 4: { itmSemaine = _lstjoursemaine_5.Items.Add(string.Empty); } break;
                        case 5: { itmSemaine = _lstjoursemaine_6.Items.Add(string.Empty); } break;
                        case 6: { itmSemaine = _lstjoursemaine_7.Items.Add(string.Empty); } break;
                    }
                    itmSemaine.Text = (string)(rstCédule.Fields["noenreg"].Value);
                    if ((bool)rstCédule.Fields["finprojet"].Value == true)
                    {
                        if (!(rstCédule.Fields["Initiale"].Value is DBNull))
                        {
                            if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_NOM)
                            {
                                itmSemaine.SubItems[I_LVW_SEMAINE_NOM].Text = (string)(rstCédule.Fields["Initiale"].Value);
                            }
                            else
                            {
                                itmSemaine.SubItems.Insert(I_LVW_SEMAINE_NOM, new ListViewItem.ListViewSubItem(null, (string)(rstCédule.Fields["Initiale"].Value)));
                            }
                        }
                        else if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_NOM)
                        {
                            itmSemaine.SubItems[I_LVW_SEMAINE_NOM].Text = "";
                        }
                        else
                        {
                            itmSemaine.SubItems.Insert(I_LVW_SEMAINE_NOM, new ListViewItem.ListViewSubItem(null, ""));
                        }
                        if (!(rstCédule.Fields["heure_début"].Value is DBNull))
                        {
                            sHeureDebutFin = Strings.Trim((string)(Operators.AddObject(rstCédule.Fields["heure_début"].Value, "-")));
                        }
                        else
                        {
                            sHeureDebutFin = "-";
                        }
                        if (!(rstCédule.Fields["heure_fin"].Value is DBNull))
                        {
                            sHeureDebutFin = (string)(Operators.AddObject(sHeureDebutFin, rstCédule.Fields["heure_fin"].Value));
                        }
                        else
                        {
                            sHeureDebutFin = sHeureDebutFin + " ";
                        }
                        if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_HEURE)
                        {
                            itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].Text = sHeureDebutFin;
                        }
                        else
                        {
                            itmSemaine.SubItems.Insert(I_LVW_SEMAINE_HEURE, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
                        }
                        itmSemaine.SubItems[I_LVW_SEMAINE_NOM].ForeColor = COLOR_ROSE;
                        itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].ForeColor = COLOR_ROSE;
                    }
                    else
                    {
                        if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_NOM)
                        {
                            itmSemaine.SubItems[I_LVW_SEMAINE_NOM].Text = "Fin";
                        }
                        else
                        {
                            itmSemaine.SubItems.Insert(I_LVW_SEMAINE_NOM, new ListViewItem.ListViewSubItem(null, "Fin"));
                        }
                        if (!(rstCédule.Fields["transport"].Value is DBNull))
                        {
                            sHeureDebutFin = (string)(rstCédule.Fields["transport"].Value);
                        }
                        else
                        {
                            sHeureDebutFin = " ";
                        }
                        if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_HEURE)
                        {
                            itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].Text = sHeureDebutFin;
                        }
                        else
                        {
                            itmSemaine.SubItems.Insert(I_LVW_SEMAINE_HEURE, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
                        }
                        itmSemaine.SubItems[I_LVW_SEMAINE_NOM].ForeColor = COLOR_ROUGE;
                        itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].ForeColor = COLOR_ROUGE;
                    }
                    rstCédule.MoveNext();
                }
                rstCédule.Close();
                rstCédule = null;
                RemplirListerSemaineAlarme();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerSemaine", ex);
            }
        }
        private void RemplirListerJourAlarme()
        {
            try
            {
                ADODB.Recordset rstAlarme;
                ADODB.Recordset rstEmploye;
                int iNoEmploye;
                ListViewItem itmAlarme = Lstjour.Items.Add(string.Empty);
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT * FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoEmploye = int.Parse(rstEmploye.Fields["NoEmploye"].Value);
                rstEmploye.Close();
                rstEmploye = null;
                rstAlarme = new Recordset();
                rstAlarme.Open("SELECT * FROM Alarmes WHERE Date = '" + ConvertDate(m_datDateChoisie) + "' AND NoEmploye = " + iNoEmploye + " AND TypeCédule = 'C' ORDER BY Date, Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAlarme.EOF)
                {
                    itmAlarme = Lstjour.Items.Add(string.Empty);
                    itmAlarme.Text = (string)(rstAlarme.Fields["IDAlarme"].Value);
                    itmAlarme.Tag = "A";
                    if (itmAlarme.SubItems.Count > I_LVW_JOUR_NOM)
                    {
                        itmAlarme.SubItems[I_LVW_JOUR_NOM].Text = Conteneur.idInitiales.Text;
                    }
                    else
                    {
                        itmAlarme.SubItems.Insert(I_LVW_JOUR_NOM, new ListViewItem.ListViewSubItem((ListViewItem)null, Conteneur.idInitiales.Text));
                    }
                    if (!(rstAlarme.Fields["Heure"].Value is DBNull))
                    {
                        if (itmAlarme.SubItems.Count > I_LVW_JOUR_DEBUT)
                        {
                            itmAlarme.SubItems[I_LVW_JOUR_DEBUT].Text = (string)(rstAlarme.Fields["Heure"].Value);
                        }
                        else
                        {
                            itmAlarme.SubItems.Insert(I_LVW_JOUR_DEBUT, new ListViewItem.ListViewSubItem(null, (string)(rstAlarme.Fields["Heure"].Value)));
                        }
                    }
                    else if (itmAlarme.SubItems.Count > I_LVW_JOUR_DEBUT)
                    {
                        itmAlarme.SubItems[I_LVW_JOUR_DEBUT].Text = "";
                    }
                    else
                    {
                        itmAlarme.SubItems.Insert(I_LVW_JOUR_DEBUT, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    itmAlarme.SubItems[I_LVW_JOUR_NOM].ForeColor = COLOR_BLEU;
                    itmAlarme.SubItems[I_LVW_JOUR_DEBUT].ForeColor = COLOR_BLEU;
                    rstAlarme.MoveNext();
                }
                rstAlarme.Close();
                rstAlarme = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerJourAlarme", ex);
            }
        }
        private void RemplirListerSemaineAlarme()
        {
            try
            {
                ADODB.Recordset rstAlarme;
                ADODB.Recordset rstEmploye;
                int iNoEmploye;
                int iJourSemaine;
                DateTime datPremiereDate;
                DateTime datDerniereDate;
                ListViewItem itmSemaine = Lstjour.Items.Add(string.Empty);
                iJourSemaine = (int)DateAndTime.Weekday(m_datDateChoisie);
                datPremiereDate = m_datDateChoisie;
                datDerniereDate = m_datDateChoisie;
                while (!(DateAndTime.Weekday(datPremiereDate) == 1))
                    datPremiereDate = DateTime.FromOADate(datPremiereDate.ToOADate() - 1d);
                while (!(DateAndTime.Weekday(datDerniereDate) == 7))
                    datDerniereDate = DateTime.FromOADate(datDerniereDate.ToOADate() + 1d);
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT * FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoEmploye = int.Parse($"{rstEmploye.Fields["NoEmploye"].Value}");
                rstEmploye.Close();
                rstEmploye = null;
                rstAlarme = new Recordset();
                rstAlarme.Open("SELECT * FROM Alarmes WHERE Date BETWEEN '" + ConvertDate(datPremiereDate) + "' AND '" + ConvertDate(datDerniereDate) + "' AND NoEmploye = " + iNoEmploye + " AND TypeCédule = 'C' ORDER BY Date, Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                _lbljour_0.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 0)).ToString();
                _lbljour_1.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 1)).ToString();
                _lbljour_2.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 2)).ToString();
                _lbljour_3.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 3)).ToString();
                _lbljour_4.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 4)).ToString();
                _lbljour_5.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 5)).ToString();
                _lbljour_6.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.FromOADate(datPremiereDate.ToOADate() + 6)).ToString();
                _lstjoursemaine_1.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 0);
                _lstjoursemaine_2.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 1);
                _lstjoursemaine_3.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 2);
                _lstjoursemaine_4.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 3);
                _lstjoursemaine_5.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 4);
                _lstjoursemaine_6.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 5);
                _lstjoursemaine_7.Tag = DateTime.FromOADate(datPremiereDate.ToOADate() + 6);
                while (!rstAlarme.EOF)
                {
                    switch (int.Parse($"{rstAlarme.Fields["JourSemaine"].Value}"))
                    {
                        case 0: { itmSemaine = _lstjoursemaine_1.Items.Add(string.Empty); } break;
                        case 1: { itmSemaine = _lstjoursemaine_2.Items.Add(string.Empty); } break;
                        case 2: { itmSemaine = _lstjoursemaine_3.Items.Add(string.Empty); } break;
                        case 3: { itmSemaine = _lstjoursemaine_4.Items.Add(string.Empty); } break;
                        case 4: { itmSemaine = _lstjoursemaine_5.Items.Add(string.Empty); } break;
                        case 5: { itmSemaine = _lstjoursemaine_6.Items.Add(string.Empty); } break;
                        case 6: { itmSemaine = _lstjoursemaine_7.Items.Add(string.Empty); } break;
                    }
                    itmSemaine.Text = $"{rstAlarme.Fields["IDAlarme"].Value}";
                    if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_NOM)
                    {
                        itmSemaine.SubItems[I_LVW_SEMAINE_NOM].Text = Conteneur.idInitiales.Text;
                    }
                    else
                    {
                        itmSemaine.SubItems.Insert(I_LVW_SEMAINE_NOM, new ListViewItem.ListViewSubItem((ListViewItem)null, Conteneur.idInitiales.Text));
                    }
                    if (itmSemaine.SubItems.Count > I_LVW_SEMAINE_HEURE)
                    {
                        itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].Text = $"{rstAlarme.Fields["Heure"].Value}";
                    }
                    else
                    {
                        itmSemaine.SubItems.Insert(I_LVW_SEMAINE_HEURE, new ListViewItem.ListViewSubItem(null, $"{rstAlarme.Fields["Heure"].Value}"));
                    }
                    itmSemaine.SubItems[I_LVW_SEMAINE_NOM].ForeColor = COLOR_BLEU;
                    itmSemaine.SubItems[I_LVW_SEMAINE_HEURE].ForeColor = COLOR_BLEU;
                    rstAlarme.MoveNext();
                }
                rstAlarme.Close();
                rstAlarme = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "RemplirListerSemaineAlarme", ex);
            }
        }
        private void Cedule_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                g_bCeduleOuverte = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "Form_Unload", ex);
            }
        }
        [Obsolete]
        private void Lstjour_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstCédule;
                ADODB.Recordset rstAlarme;
                ADODB.Recordset rstEmployé;
                int X;
                m_bModeAjouter = false;
                if (Lstjour.Items.Count > 0)
                {
                    fraliste.Visible = false;
                    if (Lstjour.FocusedItem.Tag== "C")
                    {
                        frajour.Visible = true;
                        fraAlarme.Visible = false;
                        rstCédule = new Recordset();
                        rstEmployé = new Recordset();
                        rstCédule.Open("SELECT * FROM cédule WHERE noenreg = " + Lstjour.FocusedItem.Text + " ORDER BY initiale", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstEmployé.Open($"SELECT * FROM employés WHERE initiale = '{rstCédule.Fields["initiale"].Value}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstEmployé.EOF)
                        {
                            var loopTo = (int)(cmbemployé.Items.Count - 1);
                            for (X = 0; X <= loopTo; X++)
                            {
                                if (cmbemployé.Items[X].ToString() == IdNomEmploye)
                                {
                                    cmbemployé.SelectedIndex = X;
                                    break;
                                }
                            }
                            cmbheuredébut.Text = (string)(rstCédule.Fields["heure_début"].Value);
                            cmbheurefin.Text = (string)(rstCédule.Fields["heure_fin"].Value);
                            if (rstCédule.Fields["CLIENT"].Value is DBNull)
                            {
                                cmbclient.Text = " ";
                            }
                            else
                            {
                                cmbclient.Text = (string)(rstCédule.Fields["CLIENT"].Value);
                            }
                            chkfin.CheckState = (CheckState)int.Parse(rstCédule.Fields["finprojet"].Value);
                            if (rstCédule.Fields["transport"].Value is DBNull)
                            {
                                cmbtransport.Text = " ";
                            }
                            else
                            {
                                cmbtransport.Text = (string)(rstCédule.Fields["transport"].Value);
                            }
                            if (rstCédule.Fields["transport"].Value is DBNull)
                            {
                                cmbtransport.Text = " ";
                            }
                            else
                            {
                                cmbtransport.Text = (string)(rstCédule.Fields["transport"].Value);
                            }
                            if (chkfin.CheckState == CheckState.Unchecked)
                            {
                                AfficherTransport();
                            }
                            else
                            {
                                AfficherProjet();
                            }
                        }
                        rstCédule.Close();
                        rstCédule = null;
                        rstEmployé.Close();
                        rstEmployé = null;
                    }
                    else
                    {
                        frajour.Visible = false;
                        fraAlarme.Visible = true;
                        mskHeure.Text = "";
                        txtMessage.Text = "";
                        rstAlarme = new Recordset();
                        rstAlarme.Open("SELECT * FROM Alarmes WHERE IDAlarme = " + Lstjour.FocusedItem.Text + " ORDER BY NoEmploye", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        mskHeure.Text = (string)(rstAlarme.Fields["Heure"].Value);
                        txtMessage.Text = (string)(rstAlarme.Fields["Message"].Value);
                        rstAlarme.Close();
                        rstAlarme = null;
                    }
                }
                else
                {
                    fraliste.Visible = true;
                    frajour.Visible = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "Lstjour_DblClick", ex);
            }
        }
        private void Lstjour_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (Lstjour.Items.Count > 0)
                {
                    if (eventArgs.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Voulez-vous supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Lstjour.FocusedItem.Tag, "A", false)))
                            {
                                UpdateSQL("DELETE FROM Alarmes WHERE IDAlarme = " + Lstjour.FocusedItem.Text);
                            }
                            else
                            {
                                UpdateSQL("DELETE FROM Cédule WHERE noenreg = " + Lstjour.FocusedItem.Text);
                            }
                            RemplirFinProjet();
                            RemplirListerJour();
                            RemplirListerSemaine();
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "Lstjour_KeyDown", ex);
            }
        }

        private void mvwChoixDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Lstjour.FocusedItem.Tag, "A", false)))
                {
                    CopierAlarme(mvwChoixDate.SelectionStart);
                }
                else
                {
                    CopierCédule(mvwChoixDate.SelectionStart);
                } ((dynamic)mvwChoixDate).Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "mvwChoixDate_DateClick", ex);
            }
        }
        private void AfficherDate()
        {
            try
            {
                m_datDateChoisie = mvwSelection.SelectionStart;
                RemplirListerJour();
                RemplirListerSemaine();
                if ((DateTime)_lbljour_0.Tag == m_datDateChoisie) { _lstjoursemaine_1.BackColor = Color.Gray; } else { _lstjoursemaine_1.BackColor = Color.White; }
                if ((DateTime)_lbljour_1.Tag == m_datDateChoisie) { _lstjoursemaine_2.BackColor = Color.Gray; } else { _lstjoursemaine_2.BackColor = Color.White; }
                if ((DateTime)_lbljour_2.Tag == m_datDateChoisie) { _lstjoursemaine_3.BackColor = Color.Gray; } else { _lstjoursemaine_3.BackColor = Color.White; }
                if ((DateTime)_lbljour_3.Tag == m_datDateChoisie) { _lstjoursemaine_4.BackColor = Color.Gray; } else { _lstjoursemaine_4.BackColor = Color.White; }
                if ((DateTime)_lbljour_4.Tag == m_datDateChoisie) { _lstjoursemaine_5.BackColor = Color.Gray; } else { _lstjoursemaine_5.BackColor = Color.White; }
                if ((DateTime)_lbljour_5.Tag == m_datDateChoisie) { _lstjoursemaine_6.BackColor = Color.Gray; } else { _lstjoursemaine_6.BackColor = Color.White; }
                if ((DateTime)_lbljour_6.Tag == m_datDateChoisie) { _lstjoursemaine_7.BackColor = Color.Gray; } else { _lstjoursemaine_7.BackColor = Color.White; }
                fraliste.Visible = true;
                fraAlarme.Visible = false;
                frajour.Visible = false;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "AfficherDate", ex);
            }
        }
        private void mvwSelection_SelChange(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (mvwSelection.SelectionStart!= DateTime.Today)
                {
                    AfficherDate();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Cedule", "mvwSelection_SelChange", ex);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Text = "Cédule => Nouvelle date sélectionnée " + monthCalendar1.SelectionStart.ToLongDateString();
            lblDateCedule.Text = monthCalendar1.SelectionStart.ToLongDateString();
            m_datDateChoisie = monthCalendar1.SelectionStart;
        }

        private void Lstjour_Click(object sender, EventArgs e)
        {
            ListViewItem it = Lstjour.SelectedItems[0];
            MessageBox.Show($"{Lstjour.Columns[0].Text}={it.SubItems[0].Text}\n" +
                $"{Lstjour.Columns[1].Text}={it.SubItems[1].Text}\n"+
                $"{Lstjour.Columns[2].Text}={it.SubItems[2].Text}\n"+
                $"{Lstjour.Columns[3].Text}={it.SubItems[3].Text}\n"+
                $"{Lstjour.Columns[4].Text}={it.SubItems[4].Text}\n"+
                $"{Lstjour.Columns[5].Text}={it.SubItems[5].Text}\n" +
                $"{Lstjour.Columns[6].Text}={it.SubItems[6].Text}\n"
                , Application.ProductName + ".Cédule.Détails", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}