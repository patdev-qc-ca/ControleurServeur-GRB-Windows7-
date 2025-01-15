using ADODB;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ControleurServeur.Program;
#pragma warning disable CS0414
namespace ControleurServeur
{
    public class BilanReception : Form
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
            listView1 = new System.Windows.Forms.ListView();
            IDProjet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NomClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NomContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DateCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            creer_par = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            total_piece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            IdSoumission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Manufacturier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PrixListe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Escompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PrixNet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PrixTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DateR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NoSequenciel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NomFournisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            TotalElec = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            TotalMec = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            GrandTotal = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // listView1
            listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            listView1.BackColor = System.Drawing.Color.Black;
            listView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            IDProjet,
            NomClient,
            NomContact,
            description,
            DateCommande,
            creer_par,
            total_piece,
            IdSoumission,
            Quantite,
            Manufacturier,
            PrixListe,
            Escompte,
            PrixNet,
            PrixTotal,
            DateR,
            NoSequenciel,
            NomFournisseur});
            listView1.Font = new System.Drawing.Font("Calibri", 8.25F);
            listView1.ForeColor = System.Drawing.Color.White;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(0, 80);
            listView1.Name = "listView1";
            listView1.ShowItemToolTips = true;
            listView1.Size = new System.Drawing.Size(1436, 615);
            listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // IDProjet
            IDProjet.Text = "Projet";
            // NomClient
            NomClient.Text = "NomClient";
            NomClient.Width = 100;
            // NomContact
            NomContact.Text = "NomContact";
            NomContact.Width = 100;
            // description
            description.Text = "Description";
            // DateCommande
            DateCommande.DisplayIndex = 15;
            DateCommande.Text = "Date commandé";
            // creer_par
            creer_par.Text = "Créé par";
            creer_par.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // total_piece
            total_piece.DisplayIndex = 12;
            total_piece.Text = "Total Piece";
            // IdSoumission
            IdSoumission.DisplayIndex = 6;
            IdSoumission.Text = "Soumission";
            // Quantite
            Quantite.DisplayIndex = 7;
            Quantite.Text = "Quantité";
            Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // Manufacturier
            Manufacturier.DisplayIndex = 8;
            Manufacturier.Text = "Manufacturier";
            // PrixListe
            PrixListe.DisplayIndex = 9;
            PrixListe.Text = "Prix Liste";
            // Escompte
            Escompte.DisplayIndex = 10;
            Escompte.Text = "Escompte";
            Escompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // PrixNet
            PrixNet.DisplayIndex = 11;
            PrixNet.Text = "Prix net";
            PrixNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // PrixTotal
            PrixTotal.Text = "Prix Total";
            PrixTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // DateR
            DateR.Text = "Date réception";
            // NoSequenciel
            NoSequenciel.DisplayIndex = 16;
            NoSequenciel.Text = "# Séquentiel";
            NoSequenciel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            NoSequenciel.Width = 111;
            // NomFournisseur
            NomFournisseur.DisplayIndex = 4;
            NomFournisseur.Text = "Fournisseur";
            // button1
            button1.AutoSize = true;
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(1106, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 25);
            button1.TabIndex = 14;
            button1.Text = "Exporter vers Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click_1);
            // label4
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(1252, 3);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 13);
            label4.TabIndex = 13;
            label4.Text = "Total électique";
            // TotalElec
            TotalElec.BackColor = System.Drawing.Color.Black;
            TotalElec.ForeColor = System.Drawing.Color.White;
            TotalElec.Location = new System.Drawing.Point(1344, 0);
            TotalElec.Name = "TotalElec";
            TotalElec.Size = new System.Drawing.Size(86, 20);
            TotalElec.TabIndex = 12;
            // label3
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1252, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 13);
            label3.TabIndex = 11;
            label3.Text = "Total mécanique";
            // TotalMec
            TotalMec.BackColor = System.Drawing.Color.Black;
            TotalMec.ForeColor = System.Drawing.Color.Aqua;
            TotalMec.Location = new System.Drawing.Point(1344, 21);
            TotalMec.Name = "TotalMec";
            TotalMec.Size = new System.Drawing.Size(86, 20);
            TotalMec.TabIndex = 10;
            // label2
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1252, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 9;
            label2.Text = "GrandTotal";
            // GrandTotal
            GrandTotal.BackColor = System.Drawing.Color.Black;
            GrandTotal.ForeColor = System.Drawing.Color.Magenta;
            GrandTotal.Location = new System.Drawing.Point(1344, 42);
            GrandTotal.Name = "GrandTotal";
            GrandTotal.Size = new System.Drawing.Size(86, 20);
            GrandTotal.TabIndex = 8;
            // panel1
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(503, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(418, 71);
            panel1.TabIndex = 15;
            // button2
            button2.Location = new System.Drawing.Point(314, 41);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.ForeColor = System.Drawing.Color.Coral;
            button2.TabIndex = 5;
            button2.Text = "Procéder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // dateTimePicker2
            dateTimePicker2.Location = new System.Drawing.Point(88, 44);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);
            // label6
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(59, 46);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(22, 13);
            label6.TabIndex = 3;
            label6.Text = "au:";
            // dateTimePicker1
            dateTimePicker1.Location = new System.Drawing.Point(88, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            // label5
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(59, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(22, 13);
            label5.TabIndex = 1;
            label5.Text = "du:";
            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 0;
            label1.Text = "Période a couvrir";
            // panel2
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label7);
            panel2.Location = new System.Drawing.Point(192, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(305, 71);
            panel2.TabIndex = 16;
            // comboBox1
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(125, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(168, 21);
            comboBox1.TabIndex = 3;
            // radioButton2
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(7, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(111, 17);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "1 projet spécifique";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
            // radioButton1
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(7, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(99, 17);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tous les projets";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
            // label7
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(4, 4);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(77, 13);
            label7.TabIndex = 0;
            label7.Text = "Options projets";
            // BilanReception
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1436, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TotalElec);
            Controls.Add(label3);
            Controls.Add(TotalMec);
            Controls.Add(label2);
            Controls.Add(GrandTotal);
            Controls.Add(listView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "BilanReception";
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
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(BilanReception_FormClosing);
            Load += new System.EventHandler(BilanReception_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
        }
        #endregion
        internal static ListView listView1;
        internal static ColumnHeader IDProjet;
        internal static ColumnHeader NomClient;
        internal static ColumnHeader NomContact;
        internal static ColumnHeader description;
        internal static ColumnHeader DateR;
        internal static ColumnHeader creer_par;
        internal static ColumnHeader total_piece;
        internal static ColumnHeader PrixTotal;
        internal static ColumnHeader IdSoumission;
        internal static ColumnHeader Quantite;
        internal static ColumnHeader Manufacturier;
        internal static ColumnHeader PrixListe;
        internal static ColumnHeader Escompte;
        internal static ColumnHeader PrixNet;
        internal static ColumnHeader DateCommande;
        internal static ColumnHeader NoSequenciel;
        internal static ColumnHeader NomFournisseur;
        internal static Button button1;
        internal static Label label4;
        internal static TextBox TotalElec;
        internal static Label label3;
        internal static TextBox TotalMec;
        internal static Label label2;
        internal static TextBox GrandTotal;
        private Panel panel1;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        Microsoft.Office.Interop.Excel.Application oXLApp; // Declare the object variables
        Microsoft.Office.Interop.Excel.Workbook oXLBook;
        Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
        public BilanReception() => InitializeComponent();
        private void RechercherNumerosProjets()
        {
            string debut = Gauche(DateTime.Today.AddMonths(-1).ToShortDateString(), 7);
            Text = $"Bilan réception du {debut}-01 au {debut}-31";
            MessageBox.Show("Période: " + debut + "-01 au " + debut + "-31", $"Bilan réception {NomMois[DateTime.Today.AddMonths(-1).Month]} {DateTime.Today.AddMonths(-1).Year}");
            double totalElec = 0d;
            double totalMec = 0d;
            double Total = 0d;
            listView1.Columns.Clear();
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"SELECT [DBO].[PROJETELEC].IDPROJET,[DBO].[PROJETELEC].[DESCRIPTION], [DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE', " + $"DESC_FR, MANUFACT, PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION, PRIXORIGINE, DATERÉCEPTION, " + $"DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, NOMCOMMANDE, NOSÉQUENTIEL, DEVISE,[NOMFOURNISSEUR],[REP]," + $"[NOMCLIENT] FROM[DBO].[INVENTAIREELEC] " + $"JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREELEC].NOITEM " + $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + $"JOIN[DBO].[PROJETELEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETELEC].IDPROJET " + $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETELEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + $"WHERE DATECOMMANDE BETWEEN '{debut}-01' AND  '{debut}-31' ORDER BY DATECOMMANDE, IDPROJET ASC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            listView1.Items.Clear();
            if (!rd.EOF)
            {
                for (int a = 0; a < rd.Fields.Count; a++) { listView1.Columns.Add(rd.Fields[a].Name); }
            }
            else return;
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty); totalElec += double.Parse($"{rd.Fields["Prix_total"].Value}"); for (int a = 0; a < rd.Fields.Count; a++) { itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}")); }
                rd.MoveNext();
            }
            TotalElec.Text = Math.Round(totalElec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalElec;
            rd.Close();
            rd.Open($"SELECT [DBO].[PROJETMEC].IDPROJET,[DBO].[PROJETMEC].[DESCRIPTION], " + $"[DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE', DESC_FR, MANUFACT, " + $"PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION," + $"PRIXORIGINE, DATERÉCEPTION, DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, " + $"NOMCOMMANDE, NOSÉQUENTIEL,DEVISE,[NOMFOURNISSEUR],[REP],[NOMCLIENT] FROM[DBO].[INVENTAIREMEC] " + $"JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREMEC].NOITEM " + $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + $"JOIN[DBO].[PROJETMEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETMEC].IDPROJET " + $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETMEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + $"WHERE DATECOMMANDE BETWEEN '{debut}-01' AND '{debut}-31'ORDER BY DATECOMMANDE, IDPROJET ASC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty); totalMec += double.Parse($"{rd.Fields["Prix_total"].Value}"); for (int a = 0; a < rd.Fields.Count; a++) { itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}")); }
                rd.MoveNext();
            }
            TotalMec.Text = Math.Round(totalMec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalMec;
            GrandTotal.Text = Math.Round(Total, 2).ToString().PadRight(2, '0') + "$";
            rd.Close();
            rd = null;
            return;
        }
        private void RechercherNumerosProjets(string debut, string fin)
        {
            double totalElec = 0d;
            double totalMec = 0d;
            double Total = 0d;
            Text = $"Bilan réception du {debut} au {fin}";
            listView1.Columns.Clear();
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"SELECT [DBO].[PROJETELEC].IDPROJET,[DBO].[PROJETELEC].[DESCRIPTION], [DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE', " + $"DESC_FR, MANUFACT, PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION, PRIXORIGINE, DATERÉCEPTION, " + $"DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, NOMCOMMANDE, NOSÉQUENTIEL, DEVISE,[NOMFOURNISSEUR],[REP]," + $"[NOMCLIENT] FROM[DBO].[INVENTAIREELEC] " + $"JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREELEC].NOITEM " + $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + $"JOIN[DBO].[PROJETELEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETELEC].IDPROJET " + $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETELEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + $"WHERE DATECOMMANDE BETWEEN '{debut}' AND  '{fin}' ORDER BY DATECOMMANDE, IDPROJET ASC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            listView1.Items.Clear();
            if (!rd.EOF)
            {
                for (int a = 0; a < rd.Fields.Count; a++) { listView1.Columns.Add(rd.Fields[a].Name); }
            }
            else return;
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty); totalElec += double.Parse($"{rd.Fields["Prix_total"].Value}"); for (int a = 0; a < rd.Fields.Count; a++) { itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}")); }
                rd.MoveNext();
            }
            TotalElec.Text = Math.Round(totalElec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalElec;
            rd.Close();
            rd.Open($"SELECT [DBO].[PROJETMEC].IDPROJET,[DBO].[PROJETMEC].[DESCRIPTION], " + $"[DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE', DESC_FR, MANUFACT, " + $"PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION," + $"PRIXORIGINE, DATERÉCEPTION, DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, " + $"NOMCOMMANDE, NOSÉQUENTIEL,DEVISE,[NOMFOURNISSEUR],[REP],[NOMCLIENT] FROM[DBO].[INVENTAIREMEC] " + $"JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREMEC].NOITEM " + $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + $"JOIN[DBO].[PROJETMEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETMEC].IDPROJET " + $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETMEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + $"WHERE DATECOMMANDE BETWEEN '{debut}' AND '{fin}'ORDER BY DATECOMMANDE, IDPROJET ASC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty); totalMec += double.Parse($"{rd.Fields["Prix_total"].Value}"); for (int a = 0; a < rd.Fields.Count; a++) { itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}")); }
                rd.MoveNext();
            }
            TotalMec.Text = Math.Round(totalMec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalMec;
            GrandTotal.Text = Math.Round(Total, 2).ToString().PadRight(2, '0') + "$";
            rd.Close();
            rd = null;
            return;
        }
        private void RechercherNumerosProjets(string debut, string fin, string noProjet)
        {
            double totalElec = 0d;
            double totalMec = 0d;
            double Total = 0d;
            Text = $"Bilan réception du {debut} au {fin} pour {noProjet}";
            listView1.Columns.Clear();
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"SELECT [DBO].[PROJETELEC].IDPROJET,[DBO].[PROJETELEC].[DESCRIPTION], [DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE', " +
                $"DESC_FR, MANUFACT, PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION, PRIXORIGINE, DATERÉCEPTION, " + 
                $"DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, NOMCOMMANDE, NOSÉQUENTIEL, DEVISE,[NOMFOURNISSEUR],[REP]," + 
                $"[NOMCLIENT] FROM[DBO].[INVENTAIREELEC] " + 
                $"JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREELEC].NOITEM " + 
                $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + 
                $"JOIN[DBO].[PROJETELEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETELEC].IDPROJET " + 
                $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETELEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + 
                $"WHERE DATECOMMANDE BETWEEN '{debut}' AND  '{fin}' AND [DBO].[PROJETELEC].IDPROJET='E{Droite(noProjet, 8)}'" + $"ORDER BY DATECOMMANDE, IDPROJET ASC", 
                odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            listView1.Items.Clear();
            if (!rd.EOF)
            {
                for (int a = 0; a < rd.Fields.Count; a++)
                {
                    listView1.Columns.Add(rd.Fields[a].Name);
                }
            }
            else return;

            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                totalElec += double.Parse($"{rd.Fields["Prix_total"].Value}");
                for (int a = 0;a < rd.Fields.Count;a++)
                {
                    itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}"));
                }
                rd.MoveNext();
            }
            TotalElec.Text = Math.Round(totalElec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalElec;
            rd.Close();
            rd.Open($"SELECT [DBO].[PROJETMEC].IDPROJET,[DBO].[PROJETMEC].[DESCRIPTION],[DBO].[PROJET_PIECES].NOENREG, IDSECTION, NUMITEM, QTÉ AS 'QTÉINVENTAIRE'," +
                $" DESC_FR, MANUFACT, " + $"PRIX_LIST, [DBO].[PROJET_PIECES].ESCOMPTE, PRIX_NET, PRIX_TOTAL, PROFIT_ARGENT, SOUSSECTION," + $"PRIXORIGINE, DATERÉCEPTION," +
                $" DATECOMMANDE, DATEREQUISE, MANUFACT, NUMÉROLIGNE, FACTURATION, " + $"NOMCOMMANDE, NOSÉQUENTIEL,DEVISE,[NOMFOURNISSEUR],[REP],[NOMCLIENT] FROM[DBO].[INVENTAIREMEC]" +
                $" JOIN[DBO].[PROJET_PIECES] ON[DBO].[PROJET_PIECES].NUMITEM =[DBO].[INVENTAIREMEC].NOITEM " + 
                $"JOIN[DBO].[FOURNISSEUR] ON[DBO].[PROJET_PIECES].IDFRS =[DBO].[FOURNISSEUR].[IDFRS] " + 
                $"JOIN[DBO].[PROJETMEC]ON[DBO].[PROJET_PIECES].IDPROJET =[DBO].[PROJETMEC].IDPROJET " +
                $"JOIN[DBO].[CLIENT] ON[DBO].[PROJETMEC].IDCLIENT =[DBO].[CLIENT].IDCLIENT " + 
                $"WHERE DATECOMMANDE BETWEEN '{debut}' AND '{fin}' AND [DBO].[PROJETMEC].IDPROJET='M{Droite(noProjet, 8)}' " + $"ORDER BY DATECOMMANDE, IDPROJET ASC",
                odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                totalMec += double.Parse($"{rd.Fields["Prix_total"].Value}");
                for (int a = 0;
                a < rd.Fields.Count;
                a++)
                {
                    itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[a].Value}"));
                }
                rd.MoveNext();
            }
            TotalMec.Text = Math.Round(totalMec, 2).ToString().PadRight(2, '0') + "$";
            Total += totalMec;
            GrandTotal.Text = Math.Round(Total, 2).ToString().PadRight(2, '0') + "$";
            rd.Close();
            rd = null;
            return;

        }
        private void UpdateDatas(ListViewItem it, string v1, string v2, string v3)
        {
            ADODB.Recordset rsClient = new ADODB.Recordset();
            ADODB.Recordset rsContact = new ADODB.Recordset();
            ADODB.Recordset rsfournisseur = new ADODB.Recordset();
            if (it.SubItems.Count >= 16)
            {
                rsClient.Open($"select [NomClient] FROM [DBO].[Client] where [IDClient]='{v1}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!rsClient.EOF) { it.SubItems[1].Text = rsClient.Fields[0].Value; }
                rsContact.Open($"select [NomContact] FROM [DBO].[contact] where [IDContact]='{v2}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!rsContact.EOF) { it.SubItems[2].Text = rsContact.Fields[0].Value; }
                rsfournisseur.Open($"select [NomFournisseur] FROM [DBO].[Fournisseur] where [IDFRS]='{v3}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!rsfournisseur.EOF) { it.SubItems[16].Text = rsfournisseur.Fields[0].Value; }
            }
            else { MessageBox.Show($"Il y a un problème avec le nombre de champs dans la rangée demandée , il n 'y en a que {it.SubItems.Count} alors que ce module est configuré pour 16++", "BilanRéception.UpdateDatas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            rsClient.Close();
            rsContact.Close();
            rsfournisseur.Close();
        }
        private void BilanReception_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddMonths(-1).AddDays(-DateTime.Today.Day);
            dateTimePicker2.Value = DateTime.Today;
            comboBox1.Enabled = radioButton2.Checked;
            if (dateTimePicker1.Value < dateTimePicker2.Value) { RemplirComboProjet(); }
        }
        private void RemplirComboProjet()
        {
            Recordset rd = new Recordset();
            comboBox1.Items.Clear();
            rd.Open($"select distinct Right(idprojet,8),[creer],[description] from [dbo].[ProjetMec] " + $"WHERE CREER BETWEEN '{dateTimePicker1.Value.ToShortDateString()}" + $"'AND '{dateTimePicker2.Value.ToShortDateString()}' ORDER BY RIGHT(IDPROJET, 8)", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            if (rd.EOF) { MessageBox.Show("Pas de projet trouvé pour la période " + dateTimePicker1.Text + " au " + dateTimePicker2.Text, Application.ProductName + "." + Name); return; }
            while (!rd.EOF)
            {
                comboBox1.Items.Add(rd.Fields[0].Value); rd.MoveNext();
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            rd.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int r;
                oXLApp = new Microsoft.Office.Interop.Excel.Application();
                oXLBook = oXLApp.Workbooks.Add();
                oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
                oXLApp.Visible = false;
                Conteneur.txtStatus.Text = "Transfert vers Excel de " + Text;
                oXLSheet.get_Range("A:Z").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
                oXLSheet.Cells[1, 1] = "Projet: " + comboBox1.Text;
                oXLSheet.Cells[1, 2] = Text;
                oXLSheet.Cells[1, 4] = "Total électrique";
                oXLSheet.Cells[1, 5] = TotalElec.Text;
                oXLSheet.get_Range("E1:E1").Font.Color = COLOR_MAGENTA;
                oXLSheet.Cells[1, 6] = "Total mécanique";
                oXLSheet.Cells[1, 7] = TotalMec.Text;
                oXLSheet.Cells[1, 8] = "Grand Total:";
                oXLSheet.Cells[1, 9] = GrandTotal.Text;
                oXLSheet.get_Range("A1: AB1").Font.Bold = true;
                oXLSheet.get_Range("A2: AB2").set_Value(value: new object[] { "IDPROJET", "description", "NOENREG", "IDSECTION", "NUMITEM", "QTÉINVENTAIRE", "DESC_FR", 
                    "MANUFACT", "PRIX_LIST", "ESCOMPTE", "PRIX_NET", "PRIX_TOTAL", "PROFIT_ARGENT", "SOUSSECTION", "PRIXORIGINE", "DATERÉCEPTION", "DATECOMMANDE", "DATEREQUISE",
                    "MANUFACT", "NUMÉROLIGNE", "FACTURATION", "NOMCOMMANDE", "NOSÉQUENTIEL", "DEVISE", "NOMFOURNISSEUR", "REP", "NOMCLIENT " });
                for (int a = 0;a < listView1.Items.Count;a++)
                {
                    for (int b = 0;b < listView1.Items[a].SubItems.Count;b++)
                    {
                        oXLSheet.Cells[a + 3, b + 1] = listView1.Items[a].SubItems[b].Text;
                        Conteneur.txtStatus.Text = $"Écriture de la cellule [{a},{b}]";
                    }
                }
                oXLSheet.get_Range("A:AC").Columns.AutoFit();
                oXLSheet.Name = GetNomMois(DateTime.Today.Month - 1) + DateTime.Today.Year;
                oXLApp.Visible = true;
                oXLSheet.SaveAs(Filename: Text + ".xlsx");
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "cmdexport_Click", ex);
            }
        }
        /// <summary>
        /// ne pas oublier de fermer excel quand on quitte le formulaire
        /// </summary>
        private void BilanReception_FormClosing(object sender, FormClosingEventArgs e) {if(oXLApp!=null)oXLApp.Quit(); }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            TotalElec.Text = "0.00";
            TotalMec.Text = "0.00";
            GrandTotal.Text = "0.00";
            if (radioButton2.Checked)
            {
                RechercherNumerosProjets(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), comboBox1.Text);
            }
            else
            {
                RechercherNumerosProjets(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            }
            if (listView1.Items.Count > 1)
            {
                listView1.ForeColor = COLOR_BLEU;
                for (int x = 0;
                x < listView1.Items.Count;
                x++)
                {
                    if (x % 2 == 0)
                    {
                        listView1.Items[x].BackColor = COLOR_BLANC;
                    }
                    else
                    {
                        listView1.Items[x].BackColor = System.Drawing.Color.Gainsboro;
                    }
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => RemplirComboProjet();
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) => RemplirComboProjet();
        private void radioButton1_CheckedChanged(object sender, EventArgs e) => comboBox1.Enabled = false;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
    }
}