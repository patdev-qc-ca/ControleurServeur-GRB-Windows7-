using ADODB;
using Stripe.Climate;
using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControleurServeur
{
    public class ViewFeuilleTemps : Form
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
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTotalHeures = new System.Windows.Forms.Label();
            lblTitre = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblTotalKM = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblDatePrint = new System.Windows.Forms.ToolStripStatusLabel();
            lblGrandTotalKM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(6, 1);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(832, 69);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Solution GRB Inc.";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(910, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblTotalHeures
            // 
            lblTotalHeures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblTotalHeures.AutoSize = true;
            lblTotalHeures.BackColor = System.Drawing.Color.White;
            lblTotalHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalHeures.Location = new System.Drawing.Point(861, 122);
            lblTotalHeures.Name = "lblTotalHeures";
            lblTotalHeures.Size = new System.Drawing.Size(110, 16);
            lblTotalHeures.TabIndex = 563;
            lblTotalHeures.Text = "lblTotalHeures";
            lblTotalHeures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(28, 79);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(108, 13);
            lblTitre.TabIndex = 520;
            lblTitre.Text = "FEUILLE DE TEMPS";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = System.Drawing.Color.White;
            lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNom.Location = new System.Drawing.Point(301, 98);
            lblNom.MinimumSize = new System.Drawing.Size(60, 19);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(84, 25);
            lblNom.TabIndex = 526;
            lblNom.Text = "lblNom";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.Location = new System.Drawing.Point(861, 79);
            lblDate.MinimumSize = new System.Drawing.Size(60, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(60, 19);
            lblDate.TabIndex = 532;
            lblDate.Text = "lblDate";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalKM
            // 
            lblTotalKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblTotalKM.AutoSize = true;
            lblTotalKM.BackColor = System.Drawing.Color.White;
            lblTotalKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalKM.Location = new System.Drawing.Point(946, 98);
            lblTotalKM.Name = "lblTotalKM";
            lblTotalKM.Size = new System.Drawing.Size(97, 16);
            lblTotalKM.TabIndex = 547;
            lblTotalKM.Text = "Nombre de KM";
            // 
            // listView1
            // 
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(0, 141);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1086, 602);
            listView1.TabIndex = 564;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblDatePrint});
            statusStrip1.Location = new System.Drawing.Point(0, 746);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1086, 22);
            statusStrip1.TabIndex = 565;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDatePrint
            // 
            lblDatePrint.Name = "lblDatePrint";
            lblDatePrint.Size = new System.Drawing.Size(1071, 17);
            lblDatePrint.Spring = true;
            lblDatePrint.Text = "lblDatePrint";
            lblDatePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrandTotalKM
            // 
            lblGrandTotalKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblGrandTotalKM.AutoSize = true;
            lblGrandTotalKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotalKM.Location = new System.Drawing.Point(1049, 98);
            lblGrandTotalKM.Name = "lblGrandTotalKM";
            lblGrandTotalKM.Size = new System.Drawing.Size(15, 16);
            lblGrandTotalKM.TabIndex = 566;
            lblGrandTotalKM.Text = "0";
            // 
            // ViewFeuilleTemps
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1086, 768);
            Controls.Add(lblGrandTotalKM);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(lblTotalHeures);
            Controls.Add(lblTitre);
            Controls.Add(lblNom);
            Controls.Add(lblDate);
            Controls.Add(lblTotalKM);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFeuilleTemps";
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
        internal static Label lblTotalHeures;
        internal static Label lblTitre;
        internal static Label lblNom;
        internal static Label lblDate;
        internal static ListView listView1;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblDatePrint;
        internal static Label lblGrandTotalKM;
        internal static Label lblTotalKM;
        internal static ADODB.Recordset DataSource;
        internal static string[] NomJourSemaine = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
        /* configuration par défaut des cellules de la liste */
        string[] colones = { "Journée", "Projet", "Description", "Client", "Commentaire", "Date", "Début", "Fin", "Total", "NbreKM", "Type" };
        int[] TaillesColones = { 60, 70, 150, 150, 150, 70, 40, 40, 40, 25, 150 };
        HorizontalAlignment[] alignement = { HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Right, HorizontalAlignment.Right, HorizontalAlignment.Left, HorizontalAlignment.Center, HorizontalAlignment.Left };
        public ViewFeuilleTemps()
        {
            InitializeComponent();
            InitFormulaire(this, new EventArgs());
            GetPunchData(Program.m_datDebut, Program.m_datFin, int.Parse(Conteneur.idNoEmploye.Text));
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = $"Feuille de temps pour {Conteneur.idNomEmploye} [{Conteneur.idNomSemaine}]";
            lblNom.Text = Program.IdNomEmploye;
            lblDate.Text = Conteneur.idNomSemaine.Text;
            listView1.Columns.Clear();
            for (int x = 0; x < colones.Length; x++)
            {
                listView1.Columns.Add(colones[x]);
                listView1.Columns[x].Width = TaillesColones[x];
                listView1.Columns[x].TextAlign = alignement[x];
            }
            lblDatePrint.Text = $"{NomJourSemaine[(int)DateTime.Now.DayOfWeek]}, le {DateTime.Today.ToLongDateString()} à {DateTime.Now.ToLongTimeString()}";
        }

        internal static void GetPunchData(string debut, string fin, int utilisateur)
        {
            Recordset rd = new Recordset();
            listView1.Items.Clear();
            rd.Open($" SELECT NOPROJET, '' AS 'DESCRIPTION', [DBO].[CLIENT].NOMCLIENT, [DBO].[PUNCH].COMMENTAIRE," +
                $"DATE, HEUREDÉBUT, HEUREFIN, DATEDIFF(MINUTE, HEUREDÉBUT, HEUREFIN) AS 'TOTAL', NBREKM, TYPE FROM PUNCH " +
                $"JOIN[DBO].[CLIENT] ON [DBO].[CLIENT].IDCLIENT = [DBO].[PUNCH].NOCLIENT " +
                $"WHERE NOEMPLOYE= '{utilisateur}' AND DATE BETWEEN '{debut}' AND '{fin}' " +
                $"ORDER BY DATE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            double heureSemaine = 0d;
            int km = 0;
            while (!rd.EOF)
            {
                Recordset rd1 = new Recordset();
                //selection automatique du type de projet
                if (Program.Gauche($"{rd.Fields[0].Value}".ToUpper(), 1) == "E")
                {
                    rd1.Open($"SELECT [DESCRIPTION] FROM [DBO].[PROJETELEC] WHERE IDPROJET='{rd.Fields[0].Value}'", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                }
                else
                {
                    rd1.Open($"SELECT [DESCRIPTION] FROM [DBO].[PROJETMEC] WHERE IDPROJET='{rd.Fields[0].Value}'", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                }
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, NomJourSemaine[(int)DateTime.Parse($"{rd.Fields[4].Value}").DayOfWeek]));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd1.Fields[0].Value}"));
                rd1.Close();
                rd1 = null;
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
               heureSemaine += double.Parse($"{rd.Fields[7].Value}");
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, Math.Round((double.Parse($"{rd.Fields[7].Value}") ) / 60, 2).ToString()));
                itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                itm.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            lblGrandTotalKM.Text = km.ToString();
            lblTotalHeures.Text = "Nombre d'heure cette semaine: " + Math.Round(heureSemaine / 60, 2).ToString();
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
                printDocument1.DefaultPageSettings.Landscape = ControleurServeur.Program.isLandscape; //pour le mode paysage
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