using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewFacturation : Form
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFacturation));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblHeuresFacturees = new System.Windows.Forms.Label();
            lblHeuresNonFacturees = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblTitreNumero = new System.Windows.Forms.Label();
            lblNumero = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lblDateDebut = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            lblDateFin = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            Label20 = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(12, 22);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(151, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Facturation";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(638, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblHeuresFacturees
            // 
            lblHeuresFacturees.AutoSize = true;
            lblHeuresFacturees.BackColor = System.Drawing.Color.White;
            lblHeuresFacturees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresFacturees.Location = new System.Drawing.Point(717, 1048);
            lblHeuresFacturees.Name = "lblHeuresFacturees";
            lblHeuresFacturees.Size = new System.Drawing.Size(116, 13);
            lblHeuresFacturees.TabIndex = 563;
            lblHeuresFacturees.Text = "lblHeuresFacturees";
            // 
            // lblHeuresNonFacturees
            // 
            lblHeuresNonFacturees.AutoSize = true;
            lblHeuresNonFacturees.BackColor = System.Drawing.Color.White;
            lblHeuresNonFacturees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresNonFacturees.Location = new System.Drawing.Point(717, 1067);
            lblHeuresNonFacturees.Name = "lblHeuresNonFacturees";
            lblHeuresNonFacturees.Size = new System.Drawing.Size(139, 13);
            lblHeuresNonFacturees.TabIndex = 565;
            lblHeuresNonFacturees.Text = "lblHeuresNonFacturees";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Location = new System.Drawing.Point(298, 9);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(43, 13);
            lblClient.TabIndex = 522;
            lblClient.Text = "lblClient";
            // 
            // lblTitreNumero
            // 
            lblTitreNumero.AutoSize = true;
            lblTitreNumero.BackColor = System.Drawing.Color.White;
            lblTitreNumero.Location = new System.Drawing.Point(181, 26);
            lblTitreNumero.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreNumero.Name = "lblTitreNumero";
            lblTitreNumero.Size = new System.Drawing.Size(116, 19);
            lblTitreNumero.TabIndex = 525;
            lblTitreNumero.Text = "Numéro de soumission:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = System.Drawing.Color.White;
            lblNumero.Location = new System.Drawing.Point(298, 26);
            lblNumero.MinimumSize = new System.Drawing.Size(60, 19);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(60, 19);
            lblNumero.TabIndex = 526;
            lblNumero.Text = "lblNumero";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(180, 45);
            Label6.MinimumSize = new System.Drawing.Size(60, 19);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(78, 19);
            Label6.TabIndex = 527;
            Label6.Text = "Date de début:";
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.BackColor = System.Drawing.Color.White;
            lblDateDebut.Location = new System.Drawing.Point(298, 45);
            lblDateDebut.MinimumSize = new System.Drawing.Size(60, 19);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new System.Drawing.Size(69, 19);
            lblDateDebut.TabIndex = 528;
            lblDateDebut.Text = "lblDateDebut";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(180, 64);
            Label8.MinimumSize = new System.Drawing.Size(60, 19);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(62, 19);
            Label8.TabIndex = 531;
            Label8.Text = "Date de fin:";
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.BackColor = System.Drawing.Color.White;
            lblDateFin.Location = new System.Drawing.Point(298, 64);
            lblDateFin.MinimumSize = new System.Drawing.Size(60, 19);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new System.Drawing.Size(60, 19);
            lblDateFin.TabIndex = 532;
            lblDateFin.Text = "lblDateFin";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(181, 8);
            Label12.MinimumSize = new System.Drawing.Size(60, 19);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 19);
            Label12.TabIndex = 533;
            Label12.Text = "Client";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(565, 1086);
            Label17.Name = "Label17";
            Label17.Size = new System.Drawing.Size(37, 13);
            Label17.TabIndex = 554;
            Label17.Text = "Total: ";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(565, 1067);
            Label19.Name = "Label19";
            Label19.Size = new System.Drawing.Size(148, 13);
            Label19.TabIndex = 559;
            Label19.Text = "Total d\'heures non facturées: ";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.BackColor = System.Drawing.Color.White;
            Label20.Location = new System.Drawing.Point(565, 1048);
            Label20.Name = "Label20";
            Label20.Size = new System.Drawing.Size(127, 13);
            Label20.TabIndex = 560;
            Label20.Text = "Total d\'heures facturées: ";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = System.Drawing.Color.White;
            lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotal.Location = new System.Drawing.Point(717, 1086);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(83, 13);
            lblGrandTotal.TabIndex = 569;
            lblGrandTotal.Text = "lblGrandTotal";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblDate});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 586;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(803, 17);
            lblDate.Spring = true;
            lblDate.Text = "lblDate";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(12, 90);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(794, 943);
            listView1.TabIndex = 587;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // ViewFacturation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(listView1);
            Controls.Add(statusStrip1);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblHeuresFacturees);
            Controls.Add(lblHeuresNonFacturees);
            Controls.Add(lblClient);
            Controls.Add(lblTitreNumero);
            Controls.Add(lblNumero);
            Controls.Add(Label6);
            Controls.Add(lblDateDebut);
            Controls.Add(Label8);
            Controls.Add(lblDateFin);
            Controls.Add(Label12);
            Controls.Add(Label17);
            Controls.Add(Label19);
            Controls.Add(Label20);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFacturation";
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label lblHeuresFacturees;
        internal static Label lblHeuresNonFacturees;
        internal static Label lblClient;
        internal static Label lblTitreNumero;
        internal static Label lblNumero;
        internal static Label Label6;
        internal static Label lblDateDebut;
        internal static Label Label8;
        internal static Label lblDateFin;
        internal static Label Label12;
        internal static Label Label17;
        internal static Label Label19;
        internal static Label Label20;
        internal static Label lblGrandTotal;
        internal static ListView listView1;
        internal static ToolStripStatusLabel lblDate;
        internal static StatusStrip statusStrip1;

        public ViewFacturation()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Today.ToLongDateString();
            listView1.Columns.Clear();
            listView1.Columns.Add("Date");
            listView1.Columns.Add("Qui");
            listView1.Columns.Add("Type de travaux");
            listView1.Columns.Add("De");
            listView1.Columns.Add("À");
            listView1.Columns.Add("Total");
            listView1.Columns.Add("Facturé");
            listView1.Columns.Add("#Facture");
        }
        public ViewFacturation(bool teste)
        {
            InitializeComponent();
            listView1.Columns.Clear();
            listView1.Columns.Add("Date");
            listView1.Columns.Add("Qui");
            listView1.Columns.Add("Type de travaux");
            listView1.Columns.Add("De");
            listView1.Columns.Add("À");
            listView1.Columns.Add("Total");
            listView1.Columns.Add("Facturé");
            listView1.Columns.Add("#Facture");
            if (teste == true) 
            {
                string[] colones = { "DATE", "QUI", "DESCRIPTION", "DE", "A", "TOTAL", "FACTURÉ", "NO FACT." };
                int hfact = 0;
                int hNonFact = 0;
                Recordset rd = new Recordset();
                rd.Open("SELECT CLIENT.NOMCLIENT, DATE, HEUREDÉBUT, HEUREFIN, [DBO].[PUNCH].COMMENTAIRE, FACTURÉ, NOFACTURE, KM, NBREKM, [DBO].[PUNCH].TYPE," +
                    " DATEOUVERTURE, DATEFERMETURE, RAISONFERMETURE, OUVERT, VERROUILLÉ, [DBO].[PROJSOUM].TYPE, DESCRIPTION,EMPLOYÉS.INITIALE " +
                    ", DATEDIFF(MINUTE,HEUREDÉBUT,HEUREFIN) AS 'TOTAL' FROM [DBO].[PROJSOUM] " +
                    "JOIN PUNCH ON PUNCH.NOPROJET=PROJSOUM.IDPROJSOUM " +
                    "JOIN EMPLOYÉS ON PUNCH.NOEMPLOYE = EMPLOYÉS.NOEMPLOYE " +
                    "JOIN CLIENT ON PROJSOUM.NOCLIENT=CLIENT.IDCLIENT " +
                    "WHERE IDPROJSOUM='E44001-01' " +
                    "ORDER BY PUNCH.DATE,PUNCH.HEUREDÉBUT,PUNCH.NOEMPLOYE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                if (!rd.EOF) 
                {
                    lblClient.Text = $"{rd.Fields[0].Value}";
                    lblDate.Text = DateTime.Today.ToLongDateString();
                    lblDateDebut.Text = $"{rd.Fields[10].Value}";
                    lblDateFin.Text = $"{rd.Fields[11].Value}";
                    lblNumero.Text = "44001-01";
                }
                while (!rd.EOF)
                {
                    if ((bool)rd.Fields[5].Value == true) { hfact+=(int)rd.Fields[18].Value; } else { hNonFact=(int)rd.Fields[18].Value; }
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[17].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, Math.Round((decimal)rd.Fields[18].Value/60,2).ToString()));
                    if ((bool)rd.Fields[5].Value == true)
                    {
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"Oui"));
                    }
                    else
                    {
                        itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"Non"));
                    }
                    itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                    rd.MoveNext();
                }
                lblHeuresFacturees.Text = hfact.ToString();
                lblHeuresNonFacturees.Text = hNonFact.ToString();
                lblGrandTotal.Text = (hfact + hNonFact).ToString();
            }
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.DefaultPageSettings.Color = false;
                printDocument1.DefaultPageSettings.Landscape = !ControleurServeur.Program.isLandscape; //pour le mode paysage
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.PrinterSettings.Copies = 1;
                printDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(ImpressionFormulaire);
                Graphics myGraphics = CreateGraphics();
                Size s = Size;
                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);
                memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
                    PrintPreviewDialog1.ClientSize = new System.Drawing.Size(300, 400);
                    PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
                    PrintPreviewDialog1.Name = Text;
                    PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(250, 375);
                    PrintPreviewDialog1.UseAntiAlias = true;
                    PrintPreviewDialog1.Document = printDocument1;
                    Text = "Impression sur " + printDialog1.PrinterSettings.PrinterName;
                    if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
