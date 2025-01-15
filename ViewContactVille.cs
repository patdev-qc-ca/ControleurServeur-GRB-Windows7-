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
namespace ControleurServeur
{
    public class ViewContactVille : Form
    {
        private string txtVille;
        internal ListView listView1;
        internal ColumnHeader Compagnie;
        internal ColumnHeader NomContact;
        internal ColumnHeader Téléphone;
        internal ColumnHeader Poste;
        internal ColumnHeader Pagette;
        internal ColumnHeader Cellulaire;
        internal ColumnHeader Fax;
        internal ColumnHeader EMail;
        internal PictureBox pictureBox1;
        internal Label ViewTitre;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal ToolStripStatusLabel toolStripStatusLabel2;
        Recordset rd = new Recordset();
        string[] colones = { "VILLE", "COMPAGNIE", "CONTACT", "TELEPHONNE", "FAX", "E-MAIL", "ADRESSE", "PROV", "PAYS", "CODEPOSTAL" };
        int[] lrgColones = { 110, 180, 150, 90, 90, 120, 90, 90, 90, 90 };
        private void EnumContactParVille()
        {
            listView1.Items.Clear();
            if (!string.IsNullOrEmpty(txtVille))
            {
                rd.Open($"SELECT DISTINCT  VILLELIV,COMPAGNIE,NOMCONTACT , TELEPHONNE,[FAX],EMAIL, ADRESSELIV,  [PROV/ETATLIV], " +
                    $"PAYSLIV, CODEPOSTALLIV FROM[DBO].[CLIENT] WHERE VILLELIV LIKE '%{txtVille}%' AND SUPPRIMÉ = 0 ORDER BY ADRESSELIV",
                    Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rd.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                    itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                    itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                    rd.MoveNext();
                }
                rd.Close();
                rd.Open($"SELECT Ville, NomFournisseur,Rep,Telephonne, Fax, [E-mail], Adresse, [Prov/Etat], Pays, CodePostal FROM[DBO].[FOURNISSEUR] WHERE VILLE LIKE  '%{txtVille}%'  AND SUPPRIMÉ=0", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rd.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.ForeColor = Color.BlueViolet;
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                    itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                    itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                    rd.MoveNext();
                }
                rd.Close();
                rd = null;
            }
            return;
        }
        public ViewContactVille() => InitializeComponent();
        public ViewContactVille(string txtVille)
        {
            InitializeComponent();
            txtVille = txtVille;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContactVille));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Compagnie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Téléphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pagette = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cellulaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewTitre = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Compagnie,
            this.NomContact,
            this.Téléphone,
            this.Poste,
            this.Pagette,
            this.Cellulaire,
            this.Fax,
            this.EMail});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1128, 696);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 418;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Compagnie
            // 
            this.Compagnie.Text = "Compagnie";
            this.Compagnie.Width = 301;
            // 
            // NomContact
            // 
            this.NomContact.Text = "Nom du contact";
            this.NomContact.Width = 164;
            // 
            // Téléphone
            // 
            this.Téléphone.Text = "Téléphone";
            this.Téléphone.Width = 110;
            // 
            // Poste
            // 
            this.Poste.Text = "Poste";
            // 
            // Pagette
            // 
            this.Pagette.Text = "Pagette";
            this.Pagette.Width = 110;
            // 
            // Cellulaire
            // 
            this.Cellulaire.Text = "Cellulaire";
            this.Cellulaire.Width = 110;
            // 
            // Fax
            // 
            this.Fax.Text = "Fax";
            this.Fax.Width = 110;
            // 
            // EMail
            // 
            this.EMail.Text = "E-Mail";
            this.EMail.Width = 246;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(966, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 69);
            this.pictureBox1.TabIndex = 421;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewTitre
            // 
            this.ViewTitre.AutoSize = true;
            this.ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTitre.Location = new System.Drawing.Point(10, 9);
            this.ViewTitre.Name = "ViewTitre";
            this.ViewTitre.Size = new System.Drawing.Size(196, 36);
            this.ViewTitre.TabIndex = 419;
            this.ViewTitre.Tag = "";
            this.ViewTitre.Text = "Contacts / ville";
            this.ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 773);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 420;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1065, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel2.Text = "Page 1 sur 1";
            // 
            // ViewContactVille
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 795);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewTitre);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewContactVille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ViewContactVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void ViewContactVille_Load(object sender, EventArgs e)
        {
            ViewTitre.Text = "Liste des contats situé à " + txtVille;
            listView1.Columns.Clear();
            for (int x = 0; x < colones.Length; x++)
            {
                listView1.Columns.Add(colones[x]);
                listView1.Columns[x].Width = lrgColones[x];
            }
            EnumContactParVille();
            int nbPage = (listView1.Items.Count % 40);
            toolStripStatusLabel1.Text = "Il y a " + listView1.Items.Count + " contacts corespondants au critère " + txtVille;
            toolStripStatusLabel2.Text = "Page 1/" + nbPage;
            if (listView1.Items.Count > 26)
            {
                if (MessageBox.Show("Il y a " + listView1.Items.Count + " contacts dans la liste \nCe qui représente " + nbPage + " pages\nPréférez vous l'exporter vers Excel?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        string sChamps;
                        int r;
                        Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add();
                        Microsoft.Office.Interop.Excel.Worksheet oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
                        oXLApp.Visible = false;
                        oXLApp.ActiveSheet.Range("a2").Select();
                        {
                            var withBlock = oXLApp.ActiveWindow;
                            withBlock.FreezePanes = false;
                            withBlock.ScrollRow = 1;
                            withBlock.ScrollColumn = 1;
                            withBlock.FreezePanes = true;
                            withBlock.ScrollRow = 2;
                        }
                        oXLSheet.get_Range("A1: J1").Font.Bold = true;
                        oXLSheet.get_Range("A:J").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
                        oXLSheet.get_Range("A1:J1").set_Value(value: colones); // PWE 2024
                        r = 1;
                        for (int x = 0; x < listView1.Items.Count; x++)
                        {
                            r++;
                            oXLSheet.Cells[r, 1] = listView1.Items[x].SubItems[0].Text;
                            oXLSheet.Cells[r, 2] = listView1.Items[x].SubItems[1].Text;
                            oXLSheet.Cells[r, 3] = listView1.Items[x].SubItems[2].Text;
                            oXLSheet.Cells[r, 4] = listView1.Items[x].SubItems[3].Text;
                            oXLSheet.Cells[r, 5] = listView1.Items[x].SubItems[4].Text;
                            oXLSheet.Cells[r, 6] = listView1.Items[x].SubItems[5].Text;
                            oXLSheet.Cells[r, 7] = listView1.Items[x].SubItems[6].Text;
                            oXLSheet.Cells[r, 8] = listView1.Items[x].SubItems[7].Text;
                            oXLSheet.Cells[r, 9] = listView1.Items[x].SubItems[8].Text;
                            oXLSheet.Cells[r, 10] = listView1.Items[x].SubItems[9].Text;
                        }
                        oXLSheet.Name = "Recherche pour " + txtVille;
                        oXLApp.Visible = true;
                        oXLBook.SaveAs(Filename: $"{Program.RootExcel}recerche pour {txtVille}");
                        oXLBook.Save();
                        oXLApp.Quit();
                    }
                    catch (Exception ex)
                    {
                        Program.AfficherErreur("InventaireElec", "cmdExport_Click", ex); return;
                    }
                }
            }
        }
    }
}