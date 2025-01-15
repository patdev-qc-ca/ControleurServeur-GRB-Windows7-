using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;

namespace ControleurServeur
{
    public partial class WizzardRapport : Form
    {
        public int m_iNoClient;
        public int m_iNoClient2;
        public int m_iNoContact;
        public int m_iNoGRB;
        public int m_iNoFRS;
        public int m_iNoFRS2;
        private bool m_bSelectAll;
        private string m_sFaxClientFRS;
        private string m_sFaxContact;
        private string m_sTelClientFRS;
        private string m_sTelContact;
        public WizzardRapport()
        {
            InitializeComponent();
        }
        private void AfficherControles()
        {
            cmbClient.Visible = false;
            cmbClient2.Visible = false;
            cmbContact.Visible = false;
            cmbContactFRS.Visible = false;
            cmbFournisseur.Visible = false;
            cmbFournisseur2.Visible = false;
            cmbGRB.Visible = false;
            cmdMsg.Visible = false;
            cmdRechercherClient.Visible = false;
            cmdRechercherClient2.Visible = false;
            cmdRechercherFRS.Visible = false;
            cmdRechercherFRS2.Visible = false;
            lblClient.Visible = false;
            lblClient2.Visible = false;
            lblContact.Visible = false;
            lblContactFRS.Visible = false;
            lblDate.Visible = false;
            lblDateCommande.Visible = false;
            lblDateDue.Visible = false;
            lblDateLivraison.Visible = false;
            lblDateTravaux.Visible = false;
            lblDe.Visible = false;
            lblFormatHeurePrevue.Visible = false;
            lblFournisseur.Visible = false;
            lblFournisseur2.Visible = false;
            lblGRB.Visible = false;
            lblHeureTravaux.Visible = false;
            lblNoCommande.Visible = false;
            lblNomProjet.Visible = false;
            lblNoProjet.Visible = false;
            lblNoSoumission.Visible = false;
            lblObjet.Visible = false;
            lblPage.Visible = false;
            lblProjetClient.Visible = false;
            lblTransport.Visible = false;
            mskDate.Visible = false;
            mskDateCommande.Visible = false;
            mskDateDue.Visible = false;
            mskDateLivraison.Visible = false;
            mskDateTravaux.Visible = false;
            mskHeureTravaux.Visible = false;
            txtDe.Visible = false;
            txtMsg.Visible = false;
            txtNoCommande.Visible = false;
            txtNomProjet.Visible = false;
            txtNoProjet.Visible = false;
            txtNoSoumission.Visible = false;
            txtObjet.Visible = false;
            txtPage.Visible = false;
            txtProjetClient.Visible = false;
            txtTransport.Visible = false;
            if (chkProblemes.Checked)
            {
                lblGRB.Visible = true;
                cmbGRB.Visible = true;
                lblNoProjet.Visible = true;
                txtNoProjet.Visible = true;
                lblNoSoumission.Visible = true;
                txtNoSoumission.Visible = true;
            }
            if (ChkClient.Checked | ChkFourn.Checked)
            {
                lblDateDue.Visible = true;
                mskDateDue.Visible = true;
            }
            if (ChkBonTravail.Checked | chkBonLivraison.Checked | ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
            {
                cmbClient.Visible = true;
                lblClient.Visible = true;
                cmdRechercherClient.Visible = true;
                cmbContact.Visible = true;
                lblContact.Visible = true;
                txtNoProjet.Visible = true;
                lblNoProjet.Visible = true;
            }
            if (ChkBonTravail.Checked | chkBonLivraison.Checked)
            {
                txtNoCommande.Visible = true;
                lblNoCommande.Visible = true;
            }
            if (ChkBonTravail.Checked)
            {
                cmbGRB.Visible = true;
                lblGRB.Visible = true;
                mskDateCommande.Visible = true;
                lblDateCommande.Visible = true;
                mskDateTravaux.Visible = true;
                lblDateTravaux.Visible = true;
                mskHeureTravaux.Visible = true;
                lblHeureTravaux.Visible = true;
                lblFormatHeurePrevue.Visible = true;
            }
            if (chkBonLivraison.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
            {
                cmbFournisseur.Visible = true;
                lblFournisseur.Visible = true;
                cmbContactFRS.Visible = true;
                lblContactFRS.Visible = true;
                cmdRechercherFRS.Visible = true;
            }
            if (chkBonLivraison.Checked)
            {
                cmbClient2.Visible = true;
                lblClient2.Visible = true;
                cmbFournisseur2.Visible = true;
                lblFournisseur2.Visible = true;
                cmdRechercherClient2.Visible = true;
                cmdRechercherFRS2.Visible = true;
                txtTransport.Visible = true;
                lblTransport.Visible = true;
                mskDateLivraison.Visible = true;
                lblDateLivraison.Visible = true;
            }
            if (ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
            {
                txtNoSoumission.Visible = true;
                lblNoSoumission.Visible = true;
            }
            if (ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked)
            {
                txtNomProjet.Visible = true;
                lblNomProjet.Visible = true;
                mskDate.Visible = true;
                lblDate.Visible = true;
                txtProjetClient.Visible = true;
                lblProjetClient.Visible = true;
            }
            if (chkFaxFrancais.Checked | chkFaxAnglais.Checked)
            {
                txtPage.Visible = true;
                lblPage.Visible = true;
                txtDe.Visible = true;
                lblDe.Visible = true;
                cmdMsg.Visible = true;
                txtObjet.Visible = true;
                lblObjet.Visible = true;
            }
        }
        private void RemplirComboClient(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                rstClient.Open($"SELECT NOMCLIENT, IDCLIENT FROM CLIENT WHERE NOMCLIENT LIKE '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient.Items.Clear();
                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add($"{rstClient.Fields["idclient"].Value}-{rstClient.Fields["nomclient"].Value}");
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboClient", ex); }
        }
        private void RemplirComboClient2(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstClient;
                rstClient = new Recordset();
                rstClient.Open($"SELECT NOMCLIENT, IDCLIENT FROM CLIENT WHERE NOMCLIENT LIKE '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient2.Items.Clear();
                while (!rstClient.EOF)
                {
                    cmbClient2.Items.Add($"{rstClient.Fields["idclient"].Value}-{rstClient.Fields["nomclient"].Value}");
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboClient2", ex); }
        }
         private void RemplirComboContact()
        {
            try
            {
                ADODB.Recordset rstContact;
                rstContact = new Recordset();
                if (m_iNoClient > 0)
                { rstContact.Open("SELECT Contact.IDContact, Contact.NomContact, ContactClient.NoClient FROM Contact " + "INNER JOIN ContactClient ON Contact.IDContact = ContactClient.NoContact WHERE ContactClient.noclient = '" + m_iNoClient + "' " + "ORDER BY contact.NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else
                { rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE Supprimé = 0 ORDER BY Nomcontact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                cmbContact.Items.Clear();
                while (!rstContact.EOF)
                {
                    if (!(rstContact.Fields["NomContact"].Value is DBNull))
                    {
                        cmbContact.Items.Add($"{rstContact.Fields["IDContact"].Value}-{rstContact.Fields["NomContact"].Value}"); rstContact.MoveNext();
                    }
                }
                rstContact.Close();
                rstContact = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboContact", ex); }
        }
        private void RemplirComboContactFRS()
        {
            try
            {
                ADODB.Recordset rstContactFRS;
                ADODB.Recordset rstContact;
                if (m_iNoFRS > 0)
                {
                    rstContactFRS = new Recordset();
                    rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else { return; }
                cmbContactFRS.Items.Clear();
                rstContact = new Recordset();
                while (!rstContactFRS.EOF)
                {
                    rstContact.Open($"SELECT NomContact, IDContact FROM Contact WHERE IDContact = {rstContactFRS.Fields["NoContact"].Value}",  odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                        cmbContactFRS.Items.Add($"{rstContact.Fields["IDContact"].Value}-{rstContact.Fields["NomContact"].Value}");
                    }
                    rstContact.Close();
                    rstContactFRS.MoveNext();
                }
                rstContact = null;
                rstContactFRS.Close();
                rstContactFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboContactFRS", ex); }
        }        private void RemplirComboFRS(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                rstFournisseur.Open($"SELECT NomFournisseur, IDFRS FROM Fournisseur WHERE NomFournisseur like '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbFournisseur.Items.Clear();
                while (!rstFournisseur.EOF)
                {
                    cmbFournisseur.Items.Add($"{rstFournisseur.Fields["IDFRS"].Value}-{rstFournisseur.Fields["NomFournisseur"].Value}");
                    rstFournisseur.MoveNext();
                }
                rstFournisseur.Close();
                rstFournisseur = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboFRS", ex); }
        }
        private void RemplirComboFRS2(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                rstFournisseur.Open($"SELECT NomFournisseur, IDFRS FROM Fournisseur WHERE NomFournisseur like '%{sRecherche.Replace("'", "''")}%'  AND Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbFournisseur2.Items.Clear();
                while (!rstFournisseur.EOF)
                {
                    cmbFournisseur2.Items.Add($"{rstFournisseur.Fields["IDFRS"].Value}-{rstFournisseur.Fields["NomFournisseur"].Value}");
                    rstFournisseur.MoveNext();
                }
                rstFournisseur.Close();
                rstFournisseur = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboFRS2", ex); }
        }
 
        private void RemplirComboGRB()
        {
            try
            {
                ADODB.Recordset rstContactGRB;
                rstContactGRB = new Recordset();
                rstContactGRB.Open("SELECT employe, noEmploye FROM employés WHERE actif=1 ORDER BY employe", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbGRB.Items.Clear();
                while (!rstContactGRB.EOF)
                {
                    cmbGRB.Items.Add($"{rstContactGRB.Fields["noEmploye"].Value}-{rstContactGRB.Fields["Employe"].Value}");
                    rstContactGRB.MoveNext();
                }
                rstContactGRB.Close();
                rstContactGRB = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboGRB", ex); }
        }
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGRB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskDateDue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mskDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mskDateCommande_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mskDateTravaux_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbClient2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskDateLivraison_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdRechercherClient2_Click(object sender, EventArgs e)
        {

        }

        private void cmdRechercherClient_Click(object sender, EventArgs e)
        {

        }

        private void cmbFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdRechercherFRS_Click(object sender, EventArgs e)
        {

        }

        private void cmbContactFRS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFournisseur2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdRechercherFRS2_Click(object sender, EventArgs e)
        {

        }

        private void cmdReport_Click(object sender, EventArgs e)
        {

        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rapport2_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;

                m_iNoClient = 0;
                m_iNoClient2 = 0;
                m_iNoContact = 0;
                m_iNoFRS = 0;
                m_iNoGRB = 0;
                RemplirComboClient(string.Empty);
                RemplirComboClient2(string.Empty);
                RemplirComboContact();
                RemplirComboGRB();
                RemplirComboFRS(string.Empty);
                RemplirComboFRS2(string.Empty);
                AfficherControles();
                Cursor.Current = Cursors.Default;
                mskDate.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today) + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Today), 2) + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.Today), 2);

            }

        private void chkBonLivraison_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkBonLivraison_Click", ex); }
        }
        private void chkBonTravail_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkBonTravail_Click", ex); }
        }
        private void chkClient_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkClient_Click", ex); }
        }
        private void chkFourn_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFourn_Click", ex); }
        }
        private void chkConcept_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkConcept_Click", ex); }
        }
        private void chkProblemes_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkProblemes_Click", ex); }
        }
        private void chkProg_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkProg_Click", ex); }
        }
        private void chkFabFermMéca_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFabFermMéca_Click", ex); }
        }
        private void chkFabFerm_CheckedChanged(object eventSender, EventArgs e)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFabFerm_Click", ex); }
        }
        private void cmdMsg_Click(object sender, EventArgs e)
        {

        }

        private void chkFaxAnglais_CheckedChanged(object sender, EventArgs e)
        {
           if (m_bSelectAll == false) { AfficherControles(); }
                return;
        }
        private void chkFaxFrancais_CheckedChanged(object sender, EventArgs e)
        {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;

        }


        private void ChkFinFab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkFabFerm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkFabFermMéca_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkProg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkConcept_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkFourn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkClient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkBonTravail_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
