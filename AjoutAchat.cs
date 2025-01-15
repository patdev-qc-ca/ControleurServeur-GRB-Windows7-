using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
#pragma warning disable CS0169
namespace ControleurServeur
{
    internal  class AjoutAchat : Form
    {
      #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public AjoutAchat() : base()
        {
            InitializeComponent();
            if (DateTime.Today.Month >= 10) { txtNo.Text = Droite(DateTime.Today.AddYears(1).Year.ToString(), 1); }
            else { txtNo.Text = Droite(DateTime.Today.Year.ToString(), 1); }

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
        internal TextBox txtNo;
        internal Button cmdAnnuler;
        internal Button cmdOK;
        internal Label Label32;
        internal Label Label31;
        internal Label Label30;
        internal Label Label29;
        internal Label Label22;
        internal Label Label8;
        internal Label Label28;
        internal Label Label27;
        internal Label Label26;
        internal Label Label16;
        internal Label Label25;
        internal Label Label24;
        internal Label Label23;
        internal Label Label21;
        internal Label Label20;
        internal Label Label19;
        internal Label Label18;
        internal Label Label17;
        internal Label Label15;
        internal Label Label14;
        internal Label Label13;
        internal Label Label12;
        internal Label Label11;
        internal Label Label10;
        internal Label Label9;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label lblNo;
        internal Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNo = new System.Windows.Forms.TextBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // txtNo
            // 
            this.txtNo.AcceptsReturn = true;
            this.txtNo.BackColor = System.Drawing.Color.Black;
            this.txtNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.ForeColor = System.Drawing.Color.White;
            this.txtNo.Location = new System.Drawing.Point(116, 97);
            this.txtNo.MaxLength = 2;
            this.txtNo.Name = "txtNo";
            this.txtNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNo.Size = new System.Drawing.Size(25, 22);
            this.txtNo.TabIndex = 2;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(318, 323);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            this.cmdAnnuler.TabIndex = 28;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(247, 323);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(65, 25);
            this.cmdOK.TabIndex = 29;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // Label32
            // 
            this.Label32.BackColor = System.Drawing.Color.Black;
            this.Label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.Color.White;
            this.Label32.Location = new System.Drawing.Point(172, 153);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(209, 17);
            this.Label32.TabIndex = 35;
            this.Label32.Text = "Entretien et réparation de bâtisse";
            // 
            // Label31
            // 
            this.Label31.BackColor = System.Drawing.Color.Black;
            this.Label31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.ForeColor = System.Drawing.Color.White;
            this.Label31.Location = new System.Drawing.Point(148, 153);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label31.Size = new System.Drawing.Size(17, 17);
            this.Label31.TabIndex = 34;
            this.Label31.Text = "-->";
            this.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.BackColor = System.Drawing.Color.Black;
            this.Label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.ForeColor = System.Drawing.Color.White;
            this.Label30.Location = new System.Drawing.Point(116, 154);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label30.Size = new System.Drawing.Size(21, 16);
            this.Label30.TabIndex = 33;
            this.Label30.Text = "76";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Black;
            this.Label29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ForeColor = System.Drawing.Color.White;
            this.Label29.Location = new System.Drawing.Point(116, 138);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label29.Size = new System.Drawing.Size(21, 16);
            this.Label29.TabIndex = 32;
            this.Label29.Text = "60";
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.Black;
            this.Label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(148, 137);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(17, 17);
            this.Label22.TabIndex = 31;
            this.Label22.Text = "-->";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(172, 137);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(145, 17);
            this.Label8.TabIndex = 30;
            this.Label8.Text = "Petits outils && fourniture";
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.Black;
            this.Label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.Color.White;
            this.Label28.Location = new System.Drawing.Point(148, 201);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(17, 17);
            this.Label28.TabIndex = 14;
            this.Label28.Text = "-->";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.Black;
            this.Label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.White;
            this.Label27.Location = new System.Drawing.Point(172, 201);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(209, 17);
            this.Label27.TabIndex = 15;
            this.Label27.Text = "Formation";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.Color.Black;
            this.Label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.Color.White;
            this.Label26.Location = new System.Drawing.Point(116, 202);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(21, 16);
            this.Label26.TabIndex = 13;
            this.Label26.Text = "83";
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Black;
            this.Label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(148, 265);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(17, 17);
            this.Label16.TabIndex = 26;
            this.Label16.Text = "-->";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.Color.Black;
            this.Label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(116, 186);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(21, 16);
            this.Label25.TabIndex = 10;
            this.Label25.Text = "82";
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.Black;
            this.Label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(172, 185);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(209, 17);
            this.Label24.TabIndex = 12;
            this.Label24.Text = "Entretien et réparation de véhicules";
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.Black;
            this.Label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.White;
            this.Label23.Location = new System.Drawing.Point(172, 265);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(145, 17);
            this.Label23.TabIndex = 27;
            this.Label23.Text = "Équipement && outillage";
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.Black;
            this.Label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(172, 249);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(137, 17);
            this.Label21.TabIndex = 24;
            this.Label21.Text = "Équipement de bureau";
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.Black;
            this.Label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(172, 233);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(57, 17);
            this.Label20.TabIndex = 21;
            this.Label20.Text = "Bâtiment";
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.Black;
            this.Label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(172, 217);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(97, 17);
            this.Label19.TabIndex = 18;
            this.Label19.Text = "Logiciel interne";
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Black;
            this.Label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(172, 169);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(137, 17);
            this.Label18.TabIndex = 9;
            this.Label18.Text = "Réparation outils GRB";
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.Black;
            this.Label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(172, 121);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(105, 17);
            this.Label17.TabIndex = 6;
            this.Label17.Text = "Stocks plancher";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Black;
            this.Label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(148, 249);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(17, 17);
            this.Label15.TabIndex = 23;
            this.Label15.Text = "-->";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Black;
            this.Label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(148, 233);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(17, 17);
            this.Label14.TabIndex = 20;
            this.Label14.Text = "-->";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Black;
            this.Label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(148, 217);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(17, 17);
            this.Label13.TabIndex = 17;
            this.Label13.Text = "-->";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Black;
            this.Label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(148, 185);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(17, 17);
            this.Label12.TabIndex = 11;
            this.Label12.Text = "-->";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Black;
            this.Label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(148, 169);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(17, 17);
            this.Label11.TabIndex = 8;
            this.Label11.Text = "-->";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Black;
            this.Label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(148, 121);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(17, 17);
            this.Label10.TabIndex = 5;
            this.Label10.Text = "-->";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Black;
            this.Label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(116, 266);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(21, 16);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "99";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(116, 250);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(21, 16);
            this.Label7.TabIndex = 22;
            this.Label7.Text = "97";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(116, 234);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(21, 16);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "95";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(116, 218);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(21, 16);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "85";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(116, 170);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(21, 16);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "80";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(52, 121);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(86, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Mois(01 à 12)";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(116, 81);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(25, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "XX";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.Black;
            this.lblNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(35, 97);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNo.Size = new System.Drawing.Size(77, 22);
            this.lblNo.TabIndex = 3;
            this.lblNo.Text = "33000  -";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(52, 53);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(253, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Quelle est le numéro du type d\'achat ?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AjoutAchat
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(395, 360);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Label32);
            this.Controls.Add(this.Label31);
            this.Controls.Add(this.Label30);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjoutAchat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.AjoutAchat";
            this.Load += new System.EventHandler(this.AjoutAchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ACHAT m_objAchat= new ACHAT();
        private ACHAT g_objAchatElec = new ACHAT();
        private ACHAT g_objAchatMec = new ACHAT();
        private EnumCatalogue eCatalogue;
        public AjoutAchat(EnumCatalogue eCatalogue)
        {
            eCatalogue = eCatalogue;
            Afficher(eCatalogue);
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_objAchat.m_sNoAchat = string.Empty;
                m_objAchat.m_bAnnuler = true;
                Close();
                return;
            }
            catch (Exception ex)
            {

                AfficherErreur("AjoutAchat", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int iNo;
                if (string.IsNullOrEmpty(txtNo.Text))
                {
                    MessageBox.Show("Le numéro est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Strings.Len(txtNo.Text) == 1)
                {
                    MessageBox.Show("Le numéro doit absolument avoir 2 chiffres!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumeric(txtNo.Text))
                {
                    iNo = int.Parse(txtNo.Text);
                }
                else
                {
                    MessageBox.Show("Numéro non numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (iNo <= 12 & iNo >= 1)
                {
                    if (iNo != System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Today))
                    {
                        MessageBox.Show("Mois invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (iNo != 60 & iNo != 76 & iNo != 80 & iNo != 82 & iNo != 83 & iNo != 85 & iNo != 95 & iNo != 97 & iNo != 98 & iNo != 99)
                {
                    MessageBox.Show("Numéro invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m_objAchat.m_sNoAchat = Strings.Replace(lblNo.Text, " ", string.Empty) + txtNo.Text;
                m_objAchat.m_bAnnuler = false;
                Close();
                return;
            }
            catch (Exception ex)
            {

                AfficherErreur("AjoutAchat", "cmdOK_Click", ex);
            }
        }
        public void Afficher(EnumCatalogue eCatalogue)
        {
            try
            {
                if (eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    lblNo.Text = "E" + Droite(DateTime.Today.Year.ToString(), 1) + "3000  -  ";
                    m_objAchat = g_objAchatElec;
                }
                else
                {
                    lblNo.Text = "M" + Droite(DateTime.Today.Year.ToString(), 1) + "3000 - ";
                    m_objAchat = g_objAchatMec;
                }
                Show();
                return;
            }
            catch (Exception ex)
            {

                AfficherErreur("AjoutAchat", "Afficher", ex);
            }
        }

        private void AjoutAchat_Load(object sender, EventArgs e)
        {
            if (DateTime.Today.Month > 9) { txtNo.Text = Droite($"0{DateTime.Today.Month}",2); }
        }
    }
}