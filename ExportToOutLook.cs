using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ExportToOutLook : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ExportToOutLook() : base()
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
        internal static ToolTip ToolTip1;
        internal static Label lblnbre;
        internal static Label lblEtatOutlook;
        internal static GroupBox fraEtatOutlook;
        internal static CheckBox ckFRS;
        internal static CheckBox ckClient;
        internal static CheckBox ckContact;
        internal static Button CancelButton_Renamed;
        internal static Button OKButton;
        internal static Label Label4;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraEtatOutlook = new System.Windows.Forms.GroupBox();
            lblnbre = new System.Windows.Forms.Label();
            lblEtatOutlook = new System.Windows.Forms.Label();
            ckFRS = new System.Windows.Forms.CheckBox();
            ckClient = new System.Windows.Forms.CheckBox();
            ckContact = new System.Windows.Forms.CheckBox();
            CancelButton_Renamed = new System.Windows.Forms.Button();
            OKButton = new System.Windows.Forms.Button();
            Label4 = new System.Windows.Forms.Label();
            fraEtatOutlook.SuspendLayout();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//fraEtatOutlook
            fraEtatOutlook.BackColor = System.Drawing.Color.Black;
            fraEtatOutlook.Controls.Add(lblnbre);
            fraEtatOutlook.Controls.Add(lblEtatOutlook);
            fraEtatOutlook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraEtatOutlook.ForeColor = System.Drawing.Color.White;
            fraEtatOutlook.Location = new System.Drawing.Point(61, 94);
            fraEtatOutlook.Name = "fraEtatOutlook";
            fraEtatOutlook.Padding = new System.Windows.Forms.Padding(0);
            fraEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraEtatOutlook.Size = new System.Drawing.Size(377, 153);
            fraEtatOutlook.TabIndex = 9;
            fraEtatOutlook.TabStop = false;
            fraEtatOutlook.Text = "Tranfert en cours";
            fraEtatOutlook.Visible = false;//lblnbre
            lblnbre.BackColor = System.Drawing.Color.Black;
            lblnbre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblnbre.ForeColor = System.Drawing.Color.White;
            lblnbre.Location = new System.Drawing.Point(16, 112);
            lblnbre.Name = "lblnbre";
            lblnbre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblnbre.Size = new System.Drawing.Size(345, 25);
            lblnbre.TabIndex = 11;
            lblnbre.Text = "Label5";
            lblnbre.TextAlign = System.Drawing.ContentAlignment.TopCenter;//lblEtatOutlook
            lblEtatOutlook.BackColor = System.Drawing.Color.Black;
            lblEtatOutlook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEtatOutlook.ForeColor = System.Drawing.Color.White;
            lblEtatOutlook.Location = new System.Drawing.Point(16, 40);
            lblEtatOutlook.Name = "lblEtatOutlook";
            lblEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblEtatOutlook.Size = new System.Drawing.Size(345, 57);
            lblEtatOutlook.TabIndex = 10;
            lblEtatOutlook.Text = "export data";
            lblEtatOutlook.TextAlign = System.Drawing.ContentAlignment.TopCenter;//ckFRS
            ckFRS.AutoSize = true;
            ckFRS.BackColor = System.Drawing.Color.Black;
            ckFRS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ckFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ckFRS.ForeColor = System.Drawing.Color.White;
            ckFRS.Location = new System.Drawing.Point(61, 206);
            ckFRS.Name = "ckFRS";
            ckFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ckFRS.Size = new System.Drawing.Size(148, 18);
            ckFRS.TabIndex = 4;
            ckFRS.Text = "Exporter les Fournisseurs";
            ckFRS.UseVisualStyleBackColor = true;//ckClient
            ckClient.AutoSize = true;
            ckClient.BackColor = System.Drawing.Color.Black;
            ckClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ckClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ckClient.ForeColor = System.Drawing.Color.White;
            ckClient.Location = new System.Drawing.Point(61, 174);
            ckClient.Name = "ckClient";
            ckClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ckClient.Size = new System.Drawing.Size(116, 18);
            ckClient.TabIndex = 3;
            ckClient.Text = "Exporter les Clients";
            ckClient.UseVisualStyleBackColor = true;//ckContact
            ckContact.AutoSize = true;
            ckContact.BackColor = System.Drawing.Color.Black;
            ckContact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ckContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ckContact.ForeColor = System.Drawing.Color.White;
            ckContact.Location = new System.Drawing.Point(61, 142);
            ckContact.Name = "ckContact";
            ckContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ckContact.Size = new System.Drawing.Size(127, 18);
            ckContact.TabIndex = 2;
            ckContact.Text = "Exporter les Contacts";
            ckContact.UseVisualStyleBackColor = true;//CancelButton_Renamed
            CancelButton_Renamed.BackColor = System.Drawing.Color.Black;
            CancelButton_Renamed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CancelButton_Renamed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CancelButton_Renamed.ForeColor = System.Drawing.Color.White;
            CancelButton_Renamed.Location = new System.Drawing.Point(349, 262);
            CancelButton_Renamed.Name = "CancelButton_Renamed";
            CancelButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CancelButton_Renamed.Size = new System.Drawing.Size(81, 25);
            CancelButton_Renamed.TabIndex = 1;
            CancelButton_Renamed.Text = "&Fermer";
            CancelButton_Renamed.UseVisualStyleBackColor = true;
            CancelButton_Renamed.Click += new System.EventHandler(CancelButton_Renamed_Click);//OKButton
            OKButton.BackColor = System.Drawing.Color.Black;
            OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            OKButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OKButton.ForeColor = System.Drawing.Color.White;
            OKButton.Location = new System.Drawing.Point(261, 262);
            OKButton.Name = "OKButton";
            OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            OKButton.Size = new System.Drawing.Size(81, 25);
            OKButton.TabIndex = 0;
            OKButton.Text = "&Exécuter";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += new System.EventHandler(OKButton_Click);//Label4
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(61, 94);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(353, 41);
            Label4.TabIndex = 8;
            Label4.Text = "Choisir les listes à exporter.";//ExportToOutLook
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(509, 326);
            Controls.Add(fraEtatOutlook);
            Controls.Add(ckFRS);
            Controls.Add(ckClient);
            Controls.Add(ckContact);
            Controls.Add(CancelButton_Renamed);
            Controls.Add(OKButton);
            Controls.Add(Label4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(184, 250);
            Name = "ExportToOutLook";
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
            Load += new System.EventHandler(ExportToOutLook_Load);
            fraEtatOutlook.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
        {
            Close();
        }
        private void ExportToOutLook_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            ckClient.Checked = false;
            ckContact.Checked = false;
            ckFRS.Checked = false;
        }
        private void OKButton_Click(object eventSender, EventArgs eventArgs)
        {
            if ((int)ckContact.CheckState == 1)
            {
                // export les contacts
                if (VerifierSiBesoinExport("SELECT * FROM Contact", "Contacts GRB"))
                {
                    SupprimerContactExchange("Contacts GRB", "contacts");
                    ExportContactExchange("SELECT * FROM Contact", "Contacts GRB");
                }
            }
            if ((int)ckClient.CheckState == 1)
            {
                // export les clients
                if (VerifierSiBesoinExport("SELECT * FROM Client", "Clients GRB"))
                {
                    SupprimerContactExchange("Clients GRB", "clients");
                    ExportClientExchange("SELECT * FROM Client", "Clients GRB");
                }
            }
            if ((int)ckFRS.CheckState == 1)
            {
                // export les fournisseurs
                if (VerifierSiBesoinExport("SELECT * FROM Fournisseur", "Fournisseurs GRB"))
                {
                    SupprimerContactExchange("Fournisseurs GRB", "fournisseurs");
                    ExportFournisseursExchange("SELECT * FROM Fournisseur", "Fournisseurs GRB");
                }
            }
            MessageBox.Show("Exportation des données réussi.");
        }
        private bool VerifierSiBesoinExport(string strQuery, string strFolder)
        {
            bool VerifierSiBesoinExportRet = default;
            VerifierSiBesoinExportRet = false;
            int dummie;
            Microsoft.Office.Interop.Outlook.Application otlApp;
            Microsoft.Office.Interop.Outlook.ContactItem otlContact;
            Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
            var bDejaOuvert = default(bool);
            string[] sNom;
            ADODB.Recordset rstContact;
            int i;
            int Y;
            Cursor.Current = Cursors.WaitCursor;
            lblEtatOutlook.Text = "Validation ..";
            lblnbre.Text = "Vérifier si nous avons besoin de faire l'exportation.";
            fraEtatOutlook.Visible = true;
            rstContact = new Recordset();
            rstContact.Open(strQuery, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            i = 0;
            rstContact.MoveFirst();
            while (!rstContact.EOF)
            {
                i++;
                rstContact.MoveNext();
            }
            Y = 0;
            otlApp = OuvrirOutlook(ref bDejaOuvert);
            folContact = GetFolder(otlApp, strFolder);
            Y = (int)folContact.Items.Count;
            dummie = (int)MessageBox.Show("Nous avons " + i + " records dans GRB et " + Y + " records dans Outlook." + '\r' + '\r' + "Désirez-vous toujours faire l'exportation dans Outlook?", "Exportation dans Outlook", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dummie == (int)DialogResult.Yes)
            {
                VerifierSiBesoinExportRet = true;
            }
            else
            {
                VerifierSiBesoinExportRet = false;
            }
            rstContact.Close();
            rstContact = null;
            if (bDejaOuvert == false)
            {
                otlApp.Quit();
            }
            otlApp = null;
            Cursor.Current = Cursors.Default;
            fraEtatOutlook.Visible = false;
            Application.DoEvents();
            rstContact.Close();
            rstContact = null;
            return VerifierSiBesoinExportRet;
        }
        private object ExportContactExchange(string strQuery, string strFolder)
        {
            Microsoft.Office.Interop.Outlook.Application otlApp;
            Microsoft.Office.Interop.Outlook.ContactItem otlContact;
            Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
            var bDejaOuvert = default(bool);
            string[] sNom;
            ADODB.Recordset rstContact;
            int i;
            Cursor.Current = Cursors.WaitCursor;
            rstContact = new Recordset();
            rstContact.Open(strQuery, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            i = 0;
            rstContact.MoveFirst();
            while (!rstContact.EOF)
            {
                i = (int)(i + 1);
                rstContact.MoveNext();
            }
            lblEtatOutlook.Text = "Ajout dans Outlook ..";
            lblnbre.Text = "Nombre de contact restant à transférer : " + i;
            fraEtatOutlook.Visible = true;
            otlApp = OuvrirOutlook(ref bDejaOuvert);
            folContact = GetFolder(otlApp, strFolder);
            rstContact.MoveFirst();
            while (!rstContact.EOF)
            {
                otlContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                otlContact.User1 = (string)(rstContact.Fields["IDContact"].Value.Value);
                if (!(rstContact.Fields["NomContact"].Value.Value is DBNull))
                {
                    sNom = $"{rstContact.Fields["NomContact"].Value.Value}".Trim().Split(' ');
                    switch (Information.UBound(sNom))
                    {
                        case 0:
                            {
                                otlContact.FirstName = sNom[0];
                                break;
                            }
                        case 1:
                            {
                                otlContact.FirstName = sNom[0];
                                otlContact.LastName = sNom[1];
                                break;
                            }
                        case 2:
                            {
                                otlContact.FirstName = sNom[0];
                                otlContact.MiddleName = sNom[1];
                                otlContact.LastName = sNom[2];
                                break;
                            }
                    }
                }
                otlContact.Title = "";
                if (!(rstContact.Fields["Compagnie"].Value is DBNull))
                {
                    otlContact.CompanyName = (string)(rstContact.Fields["Compagnie"].Value);
                }
                if (Conversions.ToBoolean(Operators.OrObject(!(rstContact.Fields["Titre"].Value is DBNull), !Operators.ConditionalCompareObjectEqual(rstContact.Fields["Titre"].Value, "", false))))
                {
                    otlContact.JobTitle = (string)(rstContact.Fields["Titre"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["Telephonne"].Value, "(___) ___-____", false)))
                {
                    if (!(rstContact.Fields["NoPoste"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim((string)(rstContact.Fields["NoPoste"].Value))))
                        {
                            otlContact.BusinessTelephoneNumber = (string)(Operators.ConcatenateObject(Operators.ConcatenateObject(rstContact.Fields["Telephonne"].Value, " Ext : "), rstContact.Fields["NoPoste"].Value));
                        }
                        else
                        {
                            otlContact.BusinessTelephoneNumber = (string)(rstContact.Fields["Telephonne"].Value);
                        }
                    }
                    else
                    {
                        otlContact.BusinessTelephoneNumber = (string)(rstContact.Fields["Telephonne"].Value);
                    }
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["Fax"].Value, "(___) ___-____", false)))
                {
                    otlContact.BusinessFaxNumber = (string)(rstContact.Fields["Fax"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["Cellulaire"].Value, "(___) ___-____", false)))
                {
                    otlContact.MobileTelephoneNumber = (string)(rstContact.Fields["Cellulaire"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["Pagette"].Value, "(___) ___-____", false)))
                {
                    otlContact.PagerNumber = (string)(rstContact.Fields["Pagette"].Value);
                }
                ///a274:
                ///a
                if (Conversions.ToBoolean(Operators.AndObject(!(rstContact.Fields["E-mail"].Value is DBNull), !Operators.ConditionalCompareObjectEqual(rstContact.Fields["E-mail"].Value, "", false))))
                {
                    otlContact.Email1Address = (string)(rstContact.Fields["E-mail"].Value);
                    ///a276:
                    ///a
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["TelDomicile"].Value, "(___) ___-____", false)))
                {
                    otlContact.HomeTelephoneNumber = (string)(rstContact.Fields["TelDomicile"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContact.Fields["Commentaire"].Value, "", false)))
                {
                    otlContact.Body = (string)(rstContact.Fields["Commentaire"].Value);
                }
                ///a309:
                ///a
                otlContact.Save();
                rstContact.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                ///a311:
                ///a
                rstContact.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                ///a312:
                ///a
                rstContact.Fields["EntryIDOutlook"].Value = otlContact.EntryID;
                ///a313:
                ///a
                rstContact.Update();
                rstContact.MoveNext();
                ///a316:
                ///a
                i = (int)(i - 1);
                ///a317:
                ///a
                lblnbre.Text = "Nombre de contact restant à transférer : " + i;
                ///a318:
                ///a
                Refresh();
                ///a319:
                ///a
            }
            rstContact.Close();
            rstContact = null;
            if (bDejaOuvert == false)
            {
                otlApp.Quit();
            }
            ///a341:
            ///a//Object otlApp peut ne pas etre détruit avant la mise en corbeille
            otlApp = null;
            ///a342:
            ///a
            Cursor.Current = Cursors.Default;
            ///a343:
            ///a
            fraEtatOutlook.Visible = false;
            Application.DoEvents();
            rstContact = null;
            fraEtatOutlook.Visible = false;
            return default;
        }
        private object ExportClientExchange(string strQuery, string strFolder)
        {
            Microsoft.Office.Interop.Outlook.Application otlApp;
            Microsoft.Office.Interop.Outlook.ContactItem otlClient;
            Microsoft.Office.Interop.Outlook.MAPIFolder folClient;
            var bDejaOuvert = default(bool);
            string[] sNom;
            ADODB.Recordset rstClient;
            ///a36:
            ///a
            int i;
            ///a37:
            ///a
            Cursor.Current = Cursors.WaitCursor;
            rstClient = new Recordset();
            ///a41:
            ///a
            rstClient.Open(strQuery, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            ///a42:
            ///a
            i = 0;
            ///a43:
            ///a
            rstClient.MoveFirst();
            ///a46:
            ///a
            while (!rstClient.EOF)
            {
                ///a47:
                ///a
                i = (int)(i + 1);
                ///a48:
                ///a
                rstClient.MoveNext();
                return default;
            }
            lblEtatOutlook.Text = "Ajout des clients dans Outlook ..";
            lblnbre.Text = "Nombre de client restant à transférer : " + i;
            fraEtatOutlook.Visible = true;
            otlApp = OuvrirOutlook(ref bDejaOuvert);
            folClient = GetFolder(otlApp, strFolder);
            rstClient.MoveFirst();
            while (!rstClient.EOF)
            {
                otlClient = (Microsoft.Office.Interop.Outlook.ContactItem)folClient.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                otlClient.User1 = (string)(rstClient.Fields["IDClient"].Value);
                if (!(rstClient.Fields["NomClient"].Value is DBNull))
                {
                    ///a132:
                    ///a
                    otlClient.CompanyName = (string)(rstClient.Fields["NomClient"].Value);
                    ///a133:
                    ///a
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstClient.Fields["Telephonne"].Value, "(___) ___-____", false)))
                {
                    otlClient.BusinessTelephoneNumber = (string)(rstClient.Fields["Telephonne"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstClient.Fields["Fax"].Value, "(___) ___-____", false)))
                {
                    otlClient.BusinessFaxNumber = (string)(rstClient.Fields["Fax"].Value);
                }
                ///a164:
                ///a
                if (!(rstClient.Fields["Email"].Value is DBNull))
                {
                    otlClient.Email1Address = (string)(rstClient.Fields["Email"].Value);
                    ///a166:
                    ///a
                }
                ///a169:
                ///a
                if (!(rstClient.Fields["AdresseLiv"].Value is DBNull))
                {
                    otlClient.BusinessAddressStreet = (string)(rstClient.Fields["AdresseLiv"].Value);
                    ///a171:
                    ///a
                }
                ///a174:
                ///a
                if (!(rstClient.Fields["VilleLiv"].Value is DBNull))
                {
                    otlClient.BusinessAddressCity = (string)(rstClient.Fields["VilleLiv"].Value);
                    ///a176:
                    ///a
                }
                ///a179:
                ///a
                if (!(rstClient.Fields["Prov/EtatLiv"].Value is DBNull))
                {
                    otlClient.BusinessAddressState = (string)(rstClient.Fields["Prov/EtatLiv"].Value);
                    ///a181:
                    ///a
                }
                ///a184:
                ///a
                if (!(rstClient.Fields["PaysLiv"].Value is DBNull))
                {
                    otlClient.BusinessAddressCountry = (string)(rstClient.Fields["PaysLiv"].Value);
                    ///a186:
                    ///a
                }
                ///a189:
                ///a
                if (!(rstClient.Fields["CodePostalLiv"].Value is DBNull))
                {
                    otlClient.BusinessAddressPostalCode = (string)(rstClient.Fields["CodePostalLiv"].Value);
                    ///a191:
                    ///a
                }
                ///a194:
                ///a
                if (!(rstClient.Fields["Commentaire"].Value is DBNull))
                {
                    otlClient.Body = (string)(rstClient.Fields["Commentaire"].Value);
                    ///a196:
                    ///a
                }
                ///a199:
                ///a
                if (!(rstClient.Fields["SiteWeb"].Value is DBNull))
                {
                    otlClient.WebPage = (string)(rstClient.Fields["SiteWeb"].Value);
                    ///a201:
                    ///a
                }
                ///a309:
                ///a
                otlClient.Save();
                rstClient.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                ///a311:
                ///a
                rstClient.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                ///a312:
                ///a
                rstClient.Fields["EntryIDOutlook"].Value = otlClient.EntryID;
                ///a313:
                ///a
                rstClient.Update();
                rstClient.MoveNext();
                ///a316:
                ///a
                i = (int)(i - 1);
                ///a317:
                ///a
                lblnbre.Text = "Nombre de client restant à transférer : " + i;
                ///a318:
                ///a
                Refresh();
                ///a319:
                ///a
            }
            rstClient.Close();//Object rstClient peut ne pas etre détruit avant la mise en corbeille
            rstClient = null;
            if (bDejaOuvert == false)
            {
                otlApp.Quit();
            }
            ///a341:
            ///a//Object otlApp peut ne pas etre détruit avant la mise en corbeille
            otlApp = null;
            ///a342:
            ///a
            Cursor.Current = Cursors.Default;
            ///a343:
            ///a
            fraEtatOutlook.Visible = false;
            Application.DoEvents();
            rstClient.Close();
            ///a357:
            ///a//Object rstClient peut ne pas etre détruit avant la mise en corbeille
            rstClient = null;
            fraEtatOutlook.Visible = false;
            return rstClient;
        }
        private object ExportFournisseursExchange(string strQuery, string strFolder)
        {
            Microsoft.Office.Interop.Outlook.Application otlApp;
            Microsoft.Office.Interop.Outlook.ContactItem otlFRS;
            Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
            var bDejaOuvert = default(bool);
            string[] sNom;
            ADODB.Recordset rstFRS;
            ///a36:
            ///a
            int i;
            ///a37:
            ///a
            Cursor.Current = Cursors.WaitCursor;
            rstFRS = new Recordset();
            ///a41:
            ///a
            rstFRS.Open(strQuery, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            ///a42:
            ///a
            i = 0;
            ///a43:
            ///a
            rstFRS.MoveFirst();
            ///a46:
            ///a
            while (!rstFRS.EOF)
            {
                ///a47:
                ///a
                i = (int)(i + 1);
                ///a48:
                ///a
                rstFRS.MoveNext();

                ///a
            }
            lblEtatOutlook.Text = "Ajout des fournisseurs dans Outlook ..";
            lblnbre.Text = "Nombre de fournisseur restant à transférer : " + i;
            fraEtatOutlook.Visible = true;
            otlApp = OuvrirOutlook(ref bDejaOuvert);
            folFRS = GetFolder(otlApp, strFolder);
            rstFRS.MoveFirst();
            while (!rstFRS.EOF)
            {
                otlFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                otlFRS.User1 = (string)(rstFRS.Fields["IDFRS"].Value);
                ///a
                if (!(rstFRS.Fields["NomFournisseur"].Value is DBNull))
                {
                    ///a132:
                    ///a
                    otlFRS.CompanyName = (string)(rstFRS.Fields["NomFournisseur"].Value);
                    ///a133:
                    ///a
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstFRS.Fields["Telephonne"].Value, "(___) ___-____", false)))
                {
                    otlFRS.BusinessTelephoneNumber = (string)(rstFRS.Fields["Telephonne"].Value);
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstFRS.Fields["Fax"].Value, "(___) ___-____", false)))
                {
                    otlFRS.BusinessFaxNumber = (string)(rstFRS.Fields["Fax"].Value);
                }
                ///a164:
                ///a
                if (!(rstFRS.Fields["E-mail"].Value is DBNull))
                {
                    otlFRS.Email1Address = (string)(rstFRS.Fields["E-mail"].Value);
                    ///a166:
                    ///a
                }
                ///a169:
                ///a
                if (!(rstFRS.Fields["Adresse"].Value is DBNull))
                {
                    otlFRS.BusinessAddressStreet = (string)(rstFRS.Fields["Adresse"].Value);
                    ///a171:
                    ///a
                }
                ///a174:
                ///a
                if (!(rstFRS.Fields["Ville"].Value is DBNull))
                {
                    otlFRS.BusinessAddressCity = (string)(rstFRS.Fields["Ville"].Value);
                    ///a176:
                    ///a
                }
                ///a179:
                ///a
                if (!(rstFRS.Fields["Prov/Etat"].Value is DBNull))
                {
                    otlFRS.BusinessAddressState = (string)(rstFRS.Fields["Prov/Etat"].Value);
                    ///a181:
                    ///a
                }
                ///a184:
                ///a
                if (!(rstFRS.Fields["Pays"].Value is DBNull))
                {
                    otlFRS.BusinessAddressCountry = (string)(rstFRS.Fields["Pays"].Value);
                    ///a186:
                    ///a
                }
                ///a189:
                ///a
                if (!(rstFRS.Fields["CodePostal"].Value is DBNull))
                {
                    otlFRS.BusinessAddressPostalCode = (string)(rstFRS.Fields["CodePostal"].Value);
                    ///a191:
                    ///a
                }
                ///a194:
                ///a
                if (!(rstFRS.Fields["Commentaire"].Value is DBNull))
                {
                    otlFRS.Body = (string)(rstFRS.Fields["Commentaire"].Value);
                    ///a196:
                    ///a
                }
                ///a199:
                ///a
                if (!(rstFRS.Fields["SiteWeb"].Value is DBNull))
                {
                    otlFRS.WebPage = (string)(rstFRS.Fields["SiteWeb"].Value);
                    ///a201:
                    ///a
                }
                ///a309:
                ///a
                otlFRS.Save();
                rstFRS.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                ///a311:
                ///a
                rstFRS.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                ///a312:
                ///a
                rstFRS.Fields["EntryIDOutlook"].Value = otlFRS.EntryID;
                ///a313:
                ///a
                rstFRS.Update();
                rstFRS.MoveNext();
                ///a316:
                ///a
                i = (int)(i - 1);
                ///a317:
                ///a
                lblnbre.Text = "Nombre de fournisseur restant à transférer : " + i;
                ///a318:
                ///a
                Refresh();
                ///a319:
                ///a
            }
            rstFRS.Close();
            rstFRS = null;
            if (bDejaOuvert == false)
            {
                otlApp.Quit();
            }
            ///a341:
            ///a//Object otlApp peut ne pas etre détruit avant la mise en corbeille
            otlApp = null;
            ///a342:
            ///a
            Cursor.Current = Cursors.Default;
            ///a343:
            ///a
            fraEtatOutlook.Visible = false;
            Application.DoEvents();
            rstFRS.Close();
            rstFRS = null;
            fraEtatOutlook.Visible = false;
            return default;
        }
        private object SupprimerContactExchange(string strFolder, string strName)
        {
            Microsoft.Office.Interop.Outlook.Application otlApp;
            Microsoft.Office.Interop.Outlook.ContactItem otlContact;
            Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
            var bDejaOuvert = default(bool);
            ///a26:
            ///a
            int i;
            ///a28:
            ///a
            Cursor.Current = Cursors.WaitCursor;
            lblEtatOutlook.Text = "Suppression des " + strName + " dans Outlook ..";
            fraEtatOutlook.Visible = true;
            otlApp = OuvrirOutlook(ref bDejaOuvert);
            folContact = GetFolder(otlApp, strFolder);
            ///a47:
            ///a
            i = (int)folContact.Items.Count;
            ///a48:
            ///a
            while (!(folContact.Items.Count == 0))
            {
                otlContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.GetFirst();
                ///a54:
                ///a
                otlContact.Delete();
                i = (int)(i - 1);
                ///a57:
                ///a
                lblnbre.Text = i + " " + strName + " restant à supprimer.";
                ///a58:
                ///a
                Refresh();
            }
            if (bDejaOuvert == false)
            {
                otlApp.Quit();
            }
            //Object otlApp peut ne pas etre détruit avant la mise en corbeille
            otlApp = null;
            ///a87:
            ///a
            Cursor.Current = Cursors.Default;
            fraEtatOutlook.Visible = false;
            Application.DoEvents();
            fraEtatOutlook.Visible = false;
            return default;
        }
    }
}