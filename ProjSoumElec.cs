using ADODB;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic;
using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Application = System.Windows.Forms.Application;
using Exception = System.Exception;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace ControleurServeur
{
    public partial class ProjSoumElec : Form
    {

        private const string S_PAS_SOUS_SECTION = "PAS DE SOUS-SECTION";
        private const int I_COL_SOUM_QUANTITE = 0;
        private const int I_COL_SOUM_PIECE = 1;
        private const int I_COL_SOUM_DESCR = 2;
        private const int I_COL_SOUM_MANUFACT = 3;
        private const int I_COL_SOUM_PRIX_LIST = 4;
        private const int I_COL_SOUM_ESCOMPTE = 5;
        private const int I_COL_SOUM_PRIX_NET = 6;
        private const int I_COL_SOUM_DISTRIB = 7;
        private const int I_COL_SOUM_TEMPS = 8;
        private const int I_COL_SOUM_MONTAGE = 9;
        private const int I_COL_SOUM_TOTAL = 10;
        private const int I_COL_SOUM_PROFIT = 11;
        private const int I_COL_SOUM_COMMENTAIRE = 12;
        private const int I_COL_SOUM_ID = 13;
        private const int I_COL_SOUM_FACTURATION = 14;
        private const int I_COL_SOUM_DATE_COMMANDE = 15;
        private const int I_COL_SOUM_DATE_REQUISE = 16;
        private const int I_COL_SOUM_NOM_COMMANDE = 17;
        private const int I_COL_SOUM_NO_SEQUENTIEL = 18;
        private const int I_COL_SOUM_PROVENANCE = 19;
        private const int I_COL_SOUMISSION_PROV = 13;
        private const int I_COL_SOUM_SP_QUANTITE = 0;
        private const int I_COL_SOUM_SP_PIECE = 1;
        private const int I_COL_SOUM_SP_DESCR = 2;
        private const int I_COL_SOUM_SP_MANUFACT = 3;
        private const int I_COL_SOUM_SP_DISTRIB = 4;
        private const int I_COL_SOUM_SP_TEMPS = 5;
        private const int I_COL_SOUM_SP_MONTAGE = 6;
        private const int I_COL_SOUM_SP_COMMENTAIRE = 7;
        private const int I_COL_SOUM_SP_ID = 8;
        private const int I_COL_SOUM_SP_DATE_COMMANDE = 9;
        private const int I_COL_SOUM_SP_DATE_REQUISE = 10;
        private const int I_COL_SOUM_SP_NOM_COMMANDE = 11;
        private const int I_COL_SOUM_SP_NO_SEQUENTIEL = 12;
        private const int I_COL_SOUM_SP_PROVENANCE = 13;
        private const int I_COL_SOUMISSION_SP_PROV = 8;
        private const int I_COL_PIECES_PIECE_GRB = 0;
        private const int I_COL_PIECES_NO_ITEM = 1;
        private const int I_COL_PIECES_MANUFACT = 2;
        private const int I_COL_PIECES_DESCR_FR = 3;
        private const int I_COL_PIECES_DESCR_EN = 4;
        private const int I_COL_RECH_PIECE_GRB = 0;
        private const int I_COL_RECH_NO_ITEM = 1;
        private const int I_COL_RECH_CATEGORIE = 2;
        private const int I_COL_RECH_MANUFACT = 3;
        private const int I_COL_RECH_DESCR_FR = 4;
        private const int I_COL_RECH_DESCR_EN = 5;
        private const int I_COL_FRS_FRS = 0;
        private const int I_COL_FRS_PERS_RESS = 1;
        private const int I_COL_FRS_DATE = 2;
        private const int I_COL_FRS_ENTRER_PAR = 3;
        private const int I_COL_FRS_VALIDE = 4;
        private const int I_COL_FRS_PRIX_LIST = 5;
        private const int I_COL_FRS_ESCOMPTE = 6;
        private const int I_COL_FRS_PRIX_NET = 7;
        private const int I_COL_FRS_PRIX_SP = 8;
        private const int I_COL_FRS_QUOTER = 9;
        private const int I_COL_FRS_STOCK = 10;
        private const int I_COL_MODIF_EMPLOYE = 0;
        private const int I_COL_MODIF_DATE = 1;
        private const int I_COL_MODIF_HEURE = 2;
        private const int I_COL_MODIF_MONTANT = 3;
        private const int I_COL_SUPP_EMPLOYE = 0;
        private const int I_COL_SUPP_DATE = 1;
        private const int I_COL_SUPP_HEURE = 2;
        private const int I_COL_SUPP_QTE = 3;
        private const int I_COL_SUPP_NO_ITEM = 4;
        private const int I_TRANS_FAB_GRANBY = 0;
        private const int I_TRANS_CLIENT = 1;
        private const int I_IDX_FS_DIX_MOINS = 1;
        private const int I_IDX_FS_DIX = 2;
        private const int I_IDX_FS_QUINZE = 3;
        private const int I_IDX_FS_VINGT = 4;
        private const int I_IDX_FS_VINGT_CINQ = 5;
        private const int I_IDX_FS_CINQUANTE = 6;
        private const int I_IDX_FS_CENT = 7;
        private const int I_IDX_SOUMISSION = 0;
        private const int I_IDX_PROJET = 1;
        private const int I_CMB_OUVERT = 0;
        private const int I_CMB_TOUS = 1;
        private const int I_CMB_PIECE_GRB = 0;
        private const int I_CMB_PIECE = 1;
        private const int I_CMB_FABRICANT = 2;
        private const int I_CMB_DESCR_FR = 3;
        private const int I_CMB_DESCR_EN = 4;
        internal static bool m_bComboChoix;
        internal EnumType m_eType;
        internal static bool m_bRecherchePiece;
        internal static bool m_bChangementFRS;
        internal static bool m_bPieceInutile;
        internal static bool m_bEnregistrement;
        internal static EnumLangage m_eLangage;
        internal static EnumMode m_eMode;
        internal static bool m_bModeAffichage;
        internal static bool m_bExtra;
        internal static string sNomClient;
        internal static string sNomContact;
        internal static string sNumero;
        internal static string sTransport;
        internal static string m_sTauxHebergement1 = "0";
        internal static string m_sTauxHebergement2 = "0";
        internal static string m_sTauxRepas = "0";
        internal static string m_sTauxTransport = "0";
        internal static string m_sTauxUniteMobile = "0";
        internal static string m_sTauxDessin = "0";
        internal static string m_sTauxFabrication = "0";
        internal static string m_sTauxAssemblage = "0";
        internal static string m_sTauxProgInterface = "0";
        internal static string m_sTauxProgAutomate = "0";
        internal static string m_sTauxProgRobot = "0";
        internal static string m_sTauxVision = "0";
        internal static string m_sTauxTest = "0";
        internal static string m_sTauxInstallation = "0";
        internal static string m_sTauxMiseService = "0";
        internal static string m_sTauxFormation = "0";
        internal static string m_sTauxGestion = "0";
        internal static string m_sTauxShipping = "0";
        internal static bool m_bSansTemps;
        internal static dynamic m_sLiaison;
        internal static bool m_bDroitPrix;
        internal static dynamic m_sProfit;
        internal static dynamic m_sCommission;
        internal static dynamic m_sImprevue;
        internal static string m_sTempsDessin = "0";
        internal static string m_sTempsFabrication = "0";
        internal static string m_sTempsAssemblage = "0";
        internal static string m_sTempsProgInterface = "0";
        internal static string m_sTempsProgAutomate = "0";
        internal static string m_sTempsVision = "0";
        internal static string m_sTempsProgRobot = "0";
        internal static string m_sTempsTest = "0";
        internal static string m_sTempsInstallation = "0";
        internal static string m_sTempsMiseService = "0";
        internal static string m_sTempsFormation = "0";
        internal static string m_sTempsGestion = "0";
        internal static string m_sTempsShipping = "0";
        internal static string m_sNbrePersonne = "1";
        internal static string m_sTempsHebergement = "0";
        internal static string m_sTempsRepas = "0";
        internal static string m_sTempsTransport = "0";
        internal static string m_sTempsUniteMobile = "0";
        internal static string m_sPrixEmballage = "0";
        private string Titre;
        string[] EntetesLvwSoumission = { "QUANTITE","PIECE","DESCR","MANUFACT","PRIX_LIST","ESCOMPTE","PRIX_NET","DISTRIB","TEMPS","MONTAGE","TOTAL","PROFIT","COMMENTAIRE","ID",
            "FACTURATION","DATE_COMMANDE","DATE_REQUISE","NOM_COMMANDE","NO_SEQUENTIEL","PROVENANCE"};
        private bool m_bMonthViewHasFocus;
        private string m_sSousSection;
        private bool m_bModeAjout;
        private sbyte dblQuantite;
        private Color lColor;
        private string sSousSection;
        private int iIndexSection;
        private int iIndexSelection;
        private string m_sAncienProjSoum;
        private bool m_bSupprimer;
        private bool m_bMauvaisPrix;
        private object txtChoix;
        private bool m_bModintProj;
        private bool m_bModintSoum;
        private bool m_bModintBonCommande;
        private bool bTrigger;
        private string m_sTri;
        private int m_iCol;
        private List<String> m_collQteSupp;
        private List<String> m_collNoItemSupp;
        private List<String> m_collDateSupp;
        private List<String> m_collHeureSupp;
        private int m_iNbreCopie;
        private CopiePiece[] m_arr_tyCopie;
        internal static bool m_bTransfertJobCancel;
        internal static bool m_bResize;
        internal static bool bFlag;
        internal static bool bOuvert;
        internal static bool m_bChangementChoix;
        internal static bool m_bModintFournisseurBC;
        internal static bool m_bAnnulerChemin;
        internal static string m_sChemin;

        public ProjSoumElec()
        {
            InitializeComponent();
        }
        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e) => RemplirComboContacts();
        private void cmbTri_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cmbPieces_SelectedIndexChanged(object sender, EventArgs e) => RemplirListViewPieces();
        private void cmbChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoix.Text == "Projet")
            {
                m_eType = EnumType.TYPE_PROJET;
                if (cmbOuvertFerme.Text == "") ListerProjets(-1);
                if (cmbOuvertFerme.Text == "Fermés") ListerProjets(0);
                if (cmbOuvertFerme.Text == "Ouverts") ListerProjets(1);
            }
            if (cmbChoix.Text == "Soumission")
            {
                m_eType = EnumType.TYPE_SOUMISSION;
                ListerSoumissions();
            }
        }
        private void ListerSoumissions()
        {
            ADODB.Recordset rstProjSoum = new Recordset();
            ADODB.Recordset rstSection = new Recordset();
            ADODB.Recordset rstFRS = new Recordset();
            ListViewItem itmProjSoum;
            bool bPremierEnr;
            var iOrdreSection = default(bool);
            var sSousSection = default(string);
            string sSection;
            Color lColor;
            lvwSoumission.Items.Clear();
            bPremierEnr = true;
            rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + cmbProjSoum.Text + "' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (m_eLangage == EnumLangage.ANGLAIS) { sSection = "NomSectionEN"; } else { sSection = "NomSectionFR"; } while (!rstProjSoum.EOF)
            {
                itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                if (bPremierEnr == true)
                {
                    iOrdreSection = rstProjSoum.Fields["OrdreSection"].Value;
                    sSousSection = rstProjSoum.Fields["SousSection"].Value;
                    rstSection.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstProjSoum.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!(rstSection.Fields[sSection].Value is DBNull))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstSection.Fields[sSection].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstSection.Fields[sSection].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    ValeurParDefaut(itmProjSoum);
                    rstSection.Close();
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                    itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                    ValeurParDefaut(itmProjSoum);
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    bPremierEnr = false;
                }
                else
                if (iOrdreSection != rstProjSoum.Fields["OrdreSection"].Value)
                {
                    iOrdreSection = rstProjSoum.Fields["OrdreSection"].Value;
                    rstSection.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstProjSoum.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!(rstSection.Fields[sSection].Value is DBNull))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstSection.Fields[sSection].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstSection.Fields[sSection].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    ValeurParDefaut(itmProjSoum);
                    rstSection.Close();
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    sSousSection = rstProjSoum.Fields["SousSection"].Value;
                    if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["SousSection"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["SousSection"].Value)); }
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                    ValeurParDefaut(itmProjSoum);
                    itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                }
                else
                if (sSousSection != rstProjSoum.Fields["SousSection"].Value)
                {
                    sSousSection = rstProjSoum.Fields["SousSection"].Value;
                    if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
                    ValeurParDefaut(itmProjSoum);
                    itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                }
                if (rstProjSoum.Fields["IDFRS"].Value == 0 & rstProjSoum.Fields["NumItem"].Value != "Texte" & rstProjSoum.Fields["NumItem"].Value != "Text")
                {
                    lColor = COLOR_MAGENTA;
                }
                else
                {
                    lColor = COLOR_NOIR;
                }
                itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                if (rstProjSoum.Fields["Visible"].Value == true) { itmProjSoum.Checked = true; } else { itmProjSoum.Checked = false; }
                if (!(rstProjSoum.Fields["Qté"].Value is DBNull)) { itmProjSoum.Text = rstProjSoum.Fields["Qté"].Value; } else { itmProjSoum.Text = string.Empty; }
                if (rstProjSoum.Fields["Quoté"].Value == true)
                {
                    itmProjSoum.Text = itmProjSoum.Text + "*";
                    itmProjSoum.ForeColor = COLOR_VERT;
                    if (!(rstProjSoum.Fields["NumItem"].Value is DBNull))
                    {
                        if (rstProjSoum.Fields["NumItem"].Value == "Texte" | rstProjSoum.Fields["NumItem"].Value == "Text")
                        {
                            if (m_eLangage == EnumLangage.ANGLAIS)
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = "Text"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Text")); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = "Texte"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Texte")); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstProjSoum.Fields["NumItem"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["NumItem"].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    itmProjSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
                    itmProjSoum.SubItems[I_COL_SOUM_PIECE].Tag = rstProjSoum.Fields["SousSection"].Value;
                    if (itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text == "Texte" | itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text == "Text")
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_FR"].Value)); }
                    }
                    else
                    if (m_eLangage == EnumLangage.ANGLAIS)
                    {
                        if (!(rstProjSoum.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_EN"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_EN"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstProjSoum.Fields["DESC_FR"].Value is DBNull)) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                    }
                    else
                    {
                        if (!(rstProjSoum.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_FR"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstProjSoum.Fields["DESC_EN"].Value is DBNull)) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = rstProjSoum.Fields["DESC_EN"].Value; } else { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                    }
                    itmProjSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
                    //Fabricant
                    if (!(rstProjSoum.Fields["Manufact"].Value is DBNull))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = rstProjSoum.Fields["Manufact"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Manufact"].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
                    itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                    if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_List"].Value)))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = rstProjSoum.Fields["Prix_list"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Prix_list"].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor;
                    itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = rstProjSoum.Fields["PrixOrigine"].Value;
                    if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Escompte"].Value)))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = rstProjSoum.Fields["Escompte"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Escompte"].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor;
                    //Prix net
                    if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_net"].Value)))
                    {
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = rstProjSoum.Fields["Prix_net"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Prix_net"].Value)); }
                    }
                    else
                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor;
                    //Fournisseur
                    if (!(rstProjSoum.Fields["IDFRS"].Value is DBNull) & rstProjSoum.Fields["IDFRS"].Value > 0)
                    {
                        if (itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                        {
                            rstFRS.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstProjSoum.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            //On affiche le nom dans la colonne     
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Text = rstFRS.Fields["NomFournisseur"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, rstFRS.Fields["NomFournisseur"].Value)); }
                            itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
                            //On affiche l'Id dans le tag     itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = rstProjSoum.Fields["IDFRS"].Value;     rstFRS.Close(); }
                        }
                        else
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = 0.ToString();
                        }
                        //Temps
                        if (!(rstProjSoum.Fields["Temps"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmProjSoum.SubItems[I_COL_SOUM_TEMPS].Text = rstProjSoum.Fields["Temps"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Temps"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmProjSoum.SubItems[I_COL_SOUM_TEMPS].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor;
                        //Montage
                        if (!(rstProjSoum.Fields["Temps_total"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].Text = rstProjSoum.Fields["Temps_total"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Temps_total"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor;
                        //Prix total
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_total"].Value)))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(rstProjSoum.Fields["Prix_total"].Value, 2) + "$"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(rstProjSoum.Fields["Prix_total"].Value, 2) + "$")); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
                        //Profit
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Profit_argent"].Value)))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(rstProjSoum.Fields["Profit_Argent"].Value, 2) + "$"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(rstProjSoum.Fields["Profit_Argent"].Value, 2) + "$")); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor;
                        if (!(rstProjSoum.Fields["Commentaire"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = rstProjSoum.Fields["Commentaire"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Commentaire"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = lColor;
                        rstProjSoum.MoveNext();
                        lvwSoumission.Refresh();
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    //Object rstFRS
                    rstFRS = default;
                    //Object rstSection
                    rstSection = default;
                    return;
                }
            }
        }
        private void ListerProjets(int ouvert)
        {
            ADODB.Recordset rstProjSoum;
            cmbProjSoum.Items.Clear();
            rstProjSoum = new Recordset();
            string sql = "SELECT IDProjet FROM ProjetElec INNER JOIN ProjSoum ON ProjetElec.IDProjet = ProjSoum.IDProjSoum ";
            switch (ouvert)
            {
                case 0: { sql += "WHERE Ouvert = 0 ORDER BY IDProjet DESC"; } break;
                case 1: { sql += "WHERE Ouvert = 1 ORDER BY IDProjet DESC"; } break;
                default: { sql += "ORDER BY IDProjet DESC"; } break;
            }
            rstProjSoum.Open(sql, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rstProjSoum.EOF)
            {
                cmbProjSoum.Items.Add(rstProjSoum.Fields["IDProjet"].Value);
                rstProjSoum.MoveNext();
            }
            rstProjSoum.Close();
            rstProjSoum = default;
            if (cmbProjSoum.Items.Count > 0) cmbProjSoum.SelectedIndex = 0;
        }
        private int RechercherProjSoum(string text)
        {
            for (int X = 0; X < cmbProjSoum.Items.Count; X++)
            {
                cmbProjSoum.SelectedIndex = X;

                if ((cmbProjSoum.Text ?? "") == (text ?? ""))
                {
                    return X;
                }
            }
            return -1;
        }
        private void cmbProjSoum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rstProjSoum = default(ADODB.Recordset);
            ADODB.Recordset rstOuvert;
            short X;
            var bTrouve = default(bool);
            Cursor.Current = Cursors.WaitCursor;
            m_bRecherchePiece = false;
            m_bChangementFRS = false;
            m_bPieceInutile = false;
            if (!string.IsNullOrEmpty(cmbProjSoum.Text))
            {
                sNumero = txtNoProjSoum.Text;
                txtNoProjSoum.Text = cmbProjSoum.Text;
                InitialiserVariables(txtNoProjSoum.Text);
                GetClientProjet(cmbProjSoum.Text);
                if (m_bEnregistrement == false)
                {
                    m_eLangage = EnumLangage.FRANCAIS;
                    cmdAnglaisFrancais.Text = "Anglais";
                }
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (rstProjSoum.Fields["Modification"].Value == true & $"{rstProjSoum.Fields["Par"].Value}" == IdNoEmploye.ToString())
                {
                    cmdReset.Visible = true;
                }
                if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                {
                    txtNoSoumission.Text = rstProjSoum.Fields["IDSoumission"].Value;
                }
                else
                {
                    txtNoSoumission.Text = "Pas de soumission disponible";

                }

                InitialiserTempsTaux();
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (VerifierSiDejaProjet() == false)
                    {
                        cmdCreerProjet.Visible = true;
                    }
                    else
                    {
                        cmdCreerProjet.Visible = false;
                    }
                }
                RemplirProjSoum();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstOuvert = new Recordset();
                    rstOuvert.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstOuvert.Fields["Ouvert"].Value == true)
                    {
                        m_bModeAffichage = false;
                        CalculerPrix();
                        m_bModeAffichage = true;
                        rstProjSoum.Fields["total_Commission"].Value = txtCommission.Text;
                        rstProjSoum.Fields["Total_Profit"].Value = txtProfit.Text;
                        rstProjSoum.Fields["PrixTotal"].Value = txtPrixTotal.Text;
                        rstProjSoum.Fields["Total_piece"].Value = txtTotalPieces.Text;
                        rstProjSoum.Fields["total_imprevue"].Value = txtImprevus.Text;
                        rstProjSoum.Fields["Total_Temps"].Value = txtTotalTemps.Text;
                        rstProjSoum.Update();
                    }
                }
                rstProjSoum.Close();
                sNomClient = txtClient.Text;
                sNomContact = txtContact.Text;
                sTransport = txtTransport.Text;
                for (X = 0; X <= (short)(cmbClient.Items.Count - 1); X++)
                {
                    if (cmbClient.Items[X].ToString() == (sNomClient ?? ""))
                    {
                        cmbClient.SelectedIndex = X;
                        bTrouve = true; break;
                    }
                }
                if (bTrouve == false)
                {
                    RemplirComboClients(string.Empty);
                    for (X = 0; X < cmbClient.Items.Count; X++)
                    {
                        if (cmbClient.Items[X].ToString() == (sNomClient ?? ""))
                        {
                            cmbClient.SelectedIndex = X;
                            break;
                        }
                    }
                }
                for (X = 0; X <= (short)(cmbContact.Items.Count - 1); X++)
                {
                    if (cmbContact.Items[X].ToString() == (sNomContact ?? ""))
                    {
                        cmbContact.SelectedIndex = X; break;
                    }
                }
                for (X = 0; X <= (short)(cmbTransport.Items.Count - 1); X++)
                {
                    if (cmbTransport.Items[X].ToString() == (sTransport ?? ""))
                    {
                        cmbTransport.SelectedIndex = X; break;
                    }
                }
                // Text = Titre + $"[Projet:{rstProjSoum.Fields["Projet"].Value}] [Soumission:{rstProjSoum.Fields["IDSoumission"].Value}] [Client:{rstProjSoum.Fields["IDClient"].Value}] [Contact:{rstProjSoum.Fields["IDContact"].Value}] ";
            }
            CalculerPrixReception();
            if (m_eType == EnumType.TYPE_PROJET)
            {
                rstProjSoum.CursorLocation = CursorLocationEnum.adUseServer;
                rstProjSoum.Open("SELECT PrixRéception FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjSoum.Fields["PrixRéception"].Value = txtPrixReception.Text;
                rstProjSoum.Update();
                rstProjSoum.Close();
            }
            if (m_bSansTemps == true)
            {
                tmrTemps.Enabled = true;
            }
            else
            {
                tmrTemps.Enabled = false;
                lblPasTemps.Visible = false;
            }
            rstProjSoum = default;
            Cursor.Current = Cursors.Default;
        }
        private void GetClientProjet(string text)
        {
            if (string.IsNullOrEmpty(text)) return; //evite de planter un DBNull Value lors du lancement de la liste
            Recordset rstClient = new Recordset();
            rstClient.Open($"SELECT TRIM([NOMCLIENT]),TRIM([COMPAGNIE]),[IDCLIENT],[NomContact] FROM PROJSOUM JOIN CLIENT ON CLIENT.IDCLIENT= PROJSOUM.NOCLIENT WHERE IDPROJSOUM='{text}'", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            cmbClient.Items.Clear();
            if (!rstClient.EOF)
            {
                if (rstClient.Fields[0].Value != rstClient.Fields[1].Value) //si le nom de la compagnie n'est pas celui du client
                {
                    cmbClient.Text = $"{rstClient.Fields[0].Value}[{rstClient.Fields[1].Value}]-{rstClient.Fields[2].Value}";
                }
                else
                {
                    cmbClient.Text = $"{rstClient.Fields[0].Value}-{rstClient.Fields[2].Value}";
                }
                Text = Titre + " " + cmbClient.Text.Split('-')[0];
                if (rstClient.Fields[3].Value is DBNull)
                {
                    cmbContact.Text = "Pas de contact assigné";
                }
                else
                {
                    cmbContact.Text = $"{rstClient.Fields[3].Value}";
                    cmbContact.Items.Add(cmbContact.Text);
                }
                rstClient.MoveNext();
            }
            rstClient.Close();
            rstClient = null;
        }
        private void CalculerPrixReception()
        {
            var dblPrixReception = default(double);
            ListViewItem itmProjet;
            if (m_bDroitPrix == true)
            {
                for (int X = 0; X <= lvwSoumission.Items.Count; X++)
                {
                    itmProjet = lvwSoumission.Items[X];
                    if (itmProjet.Tag != "")
                    {
                        if (!string.IsNullOrEmpty(itmProjet.SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            if (itmProjet.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmProjet.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                            {
                                if (itmProjet.SubItems[I_COL_SOUM_PIECE].ForeColor != COLOR_GRIS)
                                {
                                    if (itmProjet.SubItems[I_COL_SOUM_FACTURATION].Tag != "")
                                    {
                                        dblPrixReception = Math.Round(dblPrixReception + double.Parse(itmProjet.SubItems[I_COL_SOUM_PRIX_NET].Text) *
                                            double.Parse(Strings.Replace((string)itmProjet.SubItems[I_COL_SOUM_FACTURATION].Tag, "*", "")), 2);
                                    }
                                    else
                                    {
                                        dblPrixReception = Math.Round(dblPrixReception, 2);
                                    }
                                }
                                else
                                if (itmProjet.SubItems[I_COL_SOUM_PIECE].ForeColor == COLOR_ROUGE)
                                {
                                    dblPrixReception = Math.Round(dblPrixReception - double.Parse(itmProjet.SubItems[I_COL_SOUM_PRIX_NET].Text) *
                                        double.Parse(Strings.Replace(Strings.Replace(itmProjet.Text, "-", ""), "*", "")), 2);
                                }
                            }
                        }
                    }
                }
                txtPrixReception.Text = dblPrixReception.ToString();
            }
            else { txtPrixReception.Text = ""; }
        }
        private void RemplirComboClients(string sRecherche)
        {
            ADODB.Recordset rstClient = new Recordset();
            cmbClient.Items.Clear();
            rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE  NomClient like '%" + sRecherche.Replace("'", "''") + "%' AND Supprimé = 0", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rstClient.EOF)
            {
                cmbClient.Items.Add($"{rstClient.Fields["NomClient"].Value} - {rstClient.Fields["IDClient"].Value}");
                rstClient.MoveNext();
            }
            rstClient.Close();
            rstClient = default;
        }
        private void CalculerPrix()
        {
            var dblPrixPieces = default(double);
            double dblPrixTotal;
            double dblCommission;
            double dblTotalTemps;
            var dblProfit = default(double);
            double dblTotalManuel;
            double dblTotalImprevue;
            double dblGrandTotal;
            double dblTotalDessin;
            double dblTotalFabrication;
            double dblTotalAssemblage;
            double dblTotalProgInterface;
            double dblTotalProgAutomate;
            double dblTotalProgRobot;
            double dblTotalVision;
            double dblTotalTest;
            double dblTotalInstallation;
            double dblTotalMiseService;
            double dblTotalFormation;
            double dblTotalGestion;
            double dblTotalShipping;
            var dblHebergement = default(double);
            double dblRepas;
            double dblTransport;
            double dblUniteMobile;
            double dblPrixEmballage;
            double dblTotalResteTemps;
            var bDemande = default(bool);
            int iNbrePersonne;
            if (m_bModeAffichage == false)
            {
                for (int X = 0; X < lvwSoumission.Items.Count; X++)
                {
                    //Si ce n'est pas une section
                    if (lvwSoumission.Items[X].Tag != string.Empty)
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text) & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Text")
                        {
                            if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_DISTRIB].Text))
                            {
                                //On additionne le prix total
                                if (IsNumeric(lvwSoumission.Items[X].SubItems[I_COL_SOUM_TOTAL].Text) & IsNumeric(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text))
                                {
                                    dblPrixPieces = dblPrixPieces + double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text);
                                }
                                else
                                {
                                    MessageBox.Show("La pièce " + lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text + " a un prix non numérique!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                if (IsNumeric(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text)) == true)
                                {
                                    dblProfit = dblProfit + double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text);
                                }
                            }
                            else
                            {
                                bDemande = true;
                            }
                        }
                    }
                }
                dblTotalDessin = double.Parse(m_sTempsDessin) * double.Parse(m_sTauxDessin);
                if (m_bSansTemps == false)
                {
                    dblTotalFabrication = double.Parse(m_sTempsFabrication) * double.Parse(m_sTauxFabrication);
                }
                else
                {
                    dblTotalFabrication = 0d;
                }
                dblTotalAssemblage = double.Parse(m_sTempsAssemblage) * double.Parse(m_sTauxAssemblage);
                dblTotalProgInterface = double.Parse(m_sTempsProgInterface) * double.Parse(m_sTauxProgInterface);
                dblTotalProgAutomate = double.Parse(m_sTempsProgAutomate) * double.Parse(m_sTauxProgAutomate);
                dblTotalProgRobot = double.Parse(m_sTempsProgRobot) * double.Parse(m_sTauxProgRobot);
                dblTotalVision = double.Parse(m_sTempsVision) * double.Parse(m_sTauxVision);
                dblTotalTest = double.Parse(m_sTempsTest) * double.Parse(m_sTauxTest);
                dblTotalInstallation = double.Parse(m_sTempsInstallation) * double.Parse(m_sTauxInstallation);
                dblTotalMiseService = double.Parse(m_sTempsMiseService) * double.Parse(m_sTauxMiseService);
                dblTotalFormation = double.Parse(m_sTempsFormation) * double.Parse(m_sTauxFormation);
                dblTotalGestion = double.Parse(m_sTempsGestion) * double.Parse(m_sTauxGestion);
                dblTotalShipping = double.Parse(m_sTempsShipping) * double.Parse(m_sTauxShipping);
                dblTotalTemps = dblTotalDessin + dblTotalFabrication + dblTotalAssemblage + dblTotalProgInterface + dblTotalProgAutomate
                    + dblTotalProgRobot + dblTotalVision + dblTotalTest + dblTotalInstallation + dblTotalMiseService + dblTotalFormation + dblTotalGestion + dblTotalShipping;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    dblHebergement = 0d;
                    dblRepas = 0d;
                    dblTransport = 0d;
                    dblUniteMobile = 0d;
                }
                else
                {
                    iNbrePersonne = int.Parse(m_sNbrePersonne);
                    while (iNbrePersonne > 0)
                    {
                        if (iNbrePersonne >= 2) { dblHebergement = dblHebergement + double.Parse(m_sTempsHebergement) * double.Parse(m_sTauxHebergement2); iNbrePersonne -= 2; } else { dblHebergement = dblHebergement + double.Parse(m_sTempsHebergement) * double.Parse(m_sTauxHebergement1); iNbrePersonne--; }
                    }
                    dblRepas = double.Parse(m_sTempsRepas) * double.Parse(m_sTauxRepas) * double.Parse(m_sNbrePersonne);
                    dblTransport = double.Parse(m_sTempsTransport) * double.Parse(m_sTauxTransport);
                    dblUniteMobile = double.Parse(m_sTempsUniteMobile) * double.Parse(m_sTauxUniteMobile);
                }
                if (IsNumeric(m_sPrixEmballage)) { dblPrixEmballage = double.Parse(m_sPrixEmballage); } else { dblPrixEmballage = 0d; }
                dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                if (IsNumeric(txtPrixManuel.Text)) { dblTotalManuel = double.Parse(txtPrixManuel.Text); } else { dblTotalManuel = 0d; }
                dblTotalImprevue = (dblPrixPieces + dblProfit) * double.Parse(m_sImprevue);
                dblPrixTotal = dblPrixPieces + dblProfit + dblTotalTemps + dblTotalImprevue + dblTotalManuel + dblTotalResteTemps;
                dblCommission = dblPrixTotal * double.Parse(m_sCommission);
                dblGrandTotal = dblPrixTotal + dblCommission;
                txtTotalPieces.Text = Math.Round(dblPrixPieces, 2).ToString() + "$";
                txtTotalTemps.Text = Math.Round(dblTotalTemps, 2).ToString() + "$";
                txtPrixTotal.Text = Math.Round(dblGrandTotal, 2).ToString() + "$";
                if (bDemande == true)
                {
                    txtPrixTotal.ForeColor = COLOR_JAUNE;
                }
                else
                {
                    txtPrixTotal.ForeColor = COLOR_ROUGE;
                }
                txtImprevus.Text = Math.Round(dblTotalImprevue, 2).ToString() + "$";
                txtCommission.Text = Math.Round(dblCommission, 2).ToString() + "$";
                txtProfit.Text = Math.Round(dblProfit, 2).ToString() + "$";
            }
            else
            {
                for (int X = 0; X < lvwSoumission.Items.Count; X++)
                {
                    if (lvwSoumission.Items[X].Tag != string.Empty)
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text) & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Text")
                        {
                            if (m_bDroitPrix == true)
                            {
                                if (string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_DISTRIB].Text))
                                {
                                    bDemande = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (bDemande == true)
                {
                    txtPrixTotal.ForeColor = COLOR_JAUNE;
                }
                else
                {
                    txtPrixTotal.ForeColor = COLOR_ROUGE;
                }
            }
        }
        private void RemplirProjSoum()
        {
            ADODB.Recordset rstProjSoum = new Recordset();
            ADODB.Recordset rstSoum = new Recordset();
            ADODB.Recordset rstClient = new Recordset();
            ADODB.Recordset rstContact = new Recordset();
            if (m_eType == EnumType.TYPE_PROJET)
            {
                rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull)) { txtNoSoumission.Text = rstProjSoum.Fields["IDSoumission"].Value; } else { txtNoSoumission.Text = string.Empty; }
                if ((int.Parse(Droite(txtNoProjSoum.Text, 2)) > 60) & (int.Parse(Droite(txtNoProjSoum.Text, 2)) < 98))
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["LiaisonChargeable"].Value)))
                    {
                        m_sLiaison = rstProjSoum.Fields["LiaisonChargeable"].Value;
                    }
                    else
                    {
                        m_sLiaison = string.Empty; while (string.IsNullOrEmpty(Strings.Trim(m_sLiaison)))
                            m_sLiaison = Interaction.InputBox("Quelle est l'extention au projet " + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 3) + " auquel ce projet sera lié?");
                        rstProjSoum.Fields["LiaisonChargeable"].Value = m_sLiaison;
                        rstProjSoum.Update();
                    }
                }
            }
            else
            {
                rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            m_bSansTemps = rstProjSoum.Fields["SansTemps"].Value;
            rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE IDClient = " + rstProjSoum.Fields["IDClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE IDContact = " + rstProjSoum.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            txtClient.Text = rstClient.Fields["NomClient"].Value;
            txtContact.Text = rstContact.Fields["NomContact"].Value;
            rstClient.Close();
            rstClient = default;
            rstContact.Close();
            rstContact = default;
            txtProjet.Text = rstProjSoum.Fields["Description"].Value;
            txtNbreManuel.Text = rstProjSoum.Fields["NbreManuel"].Value;
            txtPrixManuel.Text = rstProjSoum.Fields["total_manuel"].Value;
            txtTransport.Text = rstProjSoum.Fields["transport"].Value;
            txtTotalPieces.Text = rstProjSoum.Fields["Total_Piece"].Value;
            txtTotalTemps.Text = rstProjSoum.Fields["Total_Temps"].Value;
            txtPrixTotal.Text = rstProjSoum.Fields["PrixTotal"].Value;
            txtImprevus.Text = rstProjSoum.Fields["Total_Imprevue"].Value;
            txtProfit.Text = rstProjSoum.Fields["total_profit"].Value;
            txtCommission.Text = rstProjSoum.Fields["total_commission"].Value;
            if (!(rstProjSoum.Fields["CheminPhotos"].Value is DBNull))
            {
                txtCheminPhotos.Text = rstProjSoum.Fields["CheminPhotos"].Value;
            }
            else
            {
                txtCheminPhotos.Text = string.Empty;
            }
            chkCSA.Checked = (bool)rstProjSoum.Fields["CSA"].Value;
            chkCUL.Checked = (bool)rstProjSoum.Fields["CUL"].Value;
            chkUL.Checked = (bool)rstProjSoum.Fields["UL"].Value;
            chkCUR.Checked = (bool)rstProjSoum.Fields["CUR"].Value;
            chkUR.Checked = (bool)rstProjSoum.Fields["UR"].Value;
            chkCE.Checked = (bool)rstProjSoum.Fields["CE"].Value;
            if (!(rstProjSoum.Fields["Delais"].Value is DBNull))
            {
                txtDelais.Text = Strings.Trim(rstProjSoum.Fields["Delais"].Value);
            }
            else
            {
                txtDelais.Text = "";
            }
            if (!(rstProjSoum.Fields["MontantForfait"].Value is DBNull))
            {
                txtForfait.Text = rstProjSoum.Fields["MontantForfait"].Value;
                if (!(rstProjSoum.Fields["InitialeForfait"].Value is DBNull))
                {
                    lblForfaitInitiale.Text = rstProjSoum.Fields["InitialeForfait"].Value;
                }
                else
                {
                    lblForfaitInitiale.Text = "";
                }
            }
            else
            {
                txtForfait.Text = "";
                lblForfaitInitiale.Text = "";
            }
            if (m_eType == EnumType.TYPE_PROJET)
            {
                if (!(rstProjSoum.Fields["PrixRéception"].Value is DBNull))
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["PrixRéception"].Value)))
                    {
                        txtPrixReception.Text = rstProjSoum.Fields["PrixRéception"].Value;
                    }
                    else
                    {
                        txtPrixReception.Text = "0$";
                    }
                }
                else
                { txtPrixReception.Text = "0$"; }
                if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                {
                    rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + rstProjSoum.Fields["IDSoumission"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstSoum.EOF)
                    {
                        if (!(rstSoum.Fields["PrixTotal"].Value is DBNull))
                        {
                            if (!string.IsNullOrEmpty(Strings.Trim(rstSoum.Fields["PrixTotal"].Value)))
                            {
                                txtPrixSoumission.Text = rstSoum.Fields["PrixTotal"].Value;
                            }
                            else
                            {
                                txtPrixSoumission.Text = 0.ToString() + "$";
                            }
                        }
                        else
                        {
                            txtPrixSoumission.Text = 0.ToString() + "$";
                        }
                    }
                    else
                    {
                        txtPrixSoumission.Text = 0.ToString() + "$";
                    }
                    rstSoum.Close();
                    rstSoum = default;
                }
            }
            rstProjSoum.Close();
            rstProjSoum = default;
            RemplirListViewProjSoum(txtNoProjSoum.Text);
        }
        private void RemplirListViewProjSoum(string text)
        {
            ADODB.Recordset rstProjSoum = new Recordset();
            ADODB.Recordset rstSection = new Recordset();
            ADODB.Recordset rstFRS = new Recordset();
            bool bPremierEnr;
            var iOrdreSection = default(int);
            var sSousSection = default(string);
            string sSection;
            Color lColor;
            bool bBold;
            lvwSoumission.Items.Clear();
            bPremierEnr = true;
            if (m_eType == EnumType.TYPE_PROJET)
            {
                rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + cmbProjSoum.Text + "' ORDER BY (OrdreSection), NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstProjSoum.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + cmbProjSoum.Text + "' ORDER BY C(OrdreSection), NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            if (m_eLangage == EnumLangage.ANGLAIS) { sSection = "NomSectionEN"; } else { sSection = "NomSectionFR"; }
            int x = 0;
            while (!rstProjSoum.EOF)
            {
                /*
                         string[] EntetesLvwSoumission = { "QUANTITE","PIECE","DESCR","MANUFACT","PRIX_LIST","ESCOMPTE","PRIX_NET","DISTRIB","TEMPS","MONTAGE","TOTAL","PROFIT","COMMENTAIRE","ID",
                        "FACTURATION","DATE_COMMANDE","DATE_REQUISE","NOM_COMMANDE","NO_SEQUENTIEL","PROVENANCE"};
            */
                ListViewItem itemProjSoum = lvwSoumission.Items.Add(string.Empty);
                if (x % 2 == 0) { itemProjSoum.BackColor = Color.Gainsboro; }
                itemProjSoum.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[4].Value}"));  // Qté=QUANTITE
                itemProjSoum.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[3].Value}"));  // NumItem=PIECE
                if (m_eLangage == EnumLangage.FRANCAIS)
                { itemProjSoum.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[5].Value}")); } // Desc_FR=DESCR
                else { itemProjSoum.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[6].Value}")); }  // Desc_EN
                itemProjSoum.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[7].Value}"));  // Manufact=MANUFACT
                itemProjSoum.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[8].Value}"));  // Prix_list=PRIX_LIST
                itemProjSoum.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[9].Value}"));  // Escompte=ESCOMPTE
                itemProjSoum.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[10].Value}"));  // Prix_net=PRIX_NET
                itemProjSoum.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[11].Value}"));  // IDFRS=DISTRIB
                itemProjSoum.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[12].Value}"));  // Temps=TEMPS
                itemProjSoum.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[13].Value}"));  // Temps_total=MONTAGE
                itemProjSoum.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[14].Value}"));  // Prix_total=TOTAL
                itemProjSoum.SubItems.Insert(11, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[16].Value}"));  // Profit_Argent=PROFIT
                itemProjSoum.SubItems.Insert(12, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[41].Value}"));  // Commentaire=COMMENTAIRE
                itemProjSoum.SubItems.Insert(13, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[0].Value}"));  // NoEnreg=ID
                itemProjSoum.SubItems.Insert(14, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[31].Value}"));  // Facturation=FACTURATION
                itemProjSoum.SubItems.Insert(15, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[36].Value}"));  // DateCommande=DATE_COMMANDE
                itemProjSoum.SubItems.Insert(16, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[37].Value}"));  // DateRequise=DATE_REQUISE
                itemProjSoum.SubItems.Insert(17, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[38].Value}"));  // NomCommande=NOM_COMMANDE
                itemProjSoum.SubItems.Insert(18, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[39].Value}"));  // NoSéquentiel=NO_SEQUENTIEL
                itemProjSoum.SubItems.Insert(19, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[43].Value}"));  // Provenance=PROVENANCE
                ListViewItem itemPiece = lvwPieces.Items.Add(string.Empty);
                itemPiece.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[3].Value}GRB"));
                itemPiece.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[3].Value}"));
                itemPiece.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[7].Value}"));
                itemPiece.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[5].Value}"));
                itemPiece.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields[6].Value}"));
                if (rstProjSoum.Fields["PieceExtraChargeable"].Value == true) { lColor = COLOR_BLEU; bBold = true; }
                else if (rstProjSoum.Fields["PieceExtraNonChargeable"].Value == true) { lColor = COLOR_ROSE; bBold = true; }
                else if (rstProjSoum.Fields["CommandeAnnulée"].Value == true) { lColor = COLOR_VERT_FORET; bBold = true; }
                else if (rstProjSoum.Fields["Retour"].Value == true) { lColor = COLOR_ROUGE; bBold = false; }
                else if (rstProjSoum.Fields["Commandé"].Value == true) { lColor = COLOR_ORANGE; bBold = false; }
                else if (rstProjSoum.Fields["Recu"].Value == true) { lColor = COLOR_GRIS; bBold = false; }
                else if (rstProjSoum.Fields["IDFRS"].Value == 0 & rstProjSoum.Fields["NumItem"].Value != "Texte" & rstProjSoum.Fields["NumItem"].Value != "Text") { lColor = COLOR_MAGENTA; bBold = false; }
                else if (rstProjSoum.Fields["MatérielInutile"].Value == true) { lColor = COLOR_BRUN; bBold = false; }
                else { lColor = COLOR_NOIR; bBold = false; }
                if (bBold == true)
                {
                    itemProjSoum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    itemProjSoum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                cmbSections.Items.Add($"{rstProjSoum.Fields[16].Value}");
                Recordset rstProjetElec = new Recordset();
                rstProjetElec.Open($"SELECT * FROM PROJETELEC INNER JOIN PROJSOUM ON PROJETELEC.IDPROJET = PROJSOUM.IDPROJSOUM WHERE IDPROJET='{rstProjSoum.Fields[0].Value}' AND  OUVERT = 0 ORDER BY IDPROJET DESC"
                    , odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
                if (!rstProjetElec.EOF)
                {
                    chkCUL.Checked = rstProjetElec.Fields[12].Value; chkCUL.Enabled = chkCUL.Checked;
                    chkCSA.Checked = rstProjetElec.Fields[11].Value; chkCSA.Enabled = chkCSA.Checked;
                    chkUL.Checked = rstProjetElec.Fields[13].Value; chkUL.Enabled = chkUL.Checked;
                    chkCUR.Checked = rstProjetElec.Fields[14].Value; chkCUR.Enabled = chkCUR.Checked;
                    chkUR.Checked = rstProjetElec.Fields[15].Value; chkUR.Enabled = chkUR.Checked;
                    chkCE.Checked = rstProjetElec.Fields[16].Value; chkCE.Enabled = chkCE.Checked;
                    txtDelais.Text = rstProjetElec.Fields[17].Value;
                    if (rstProjetElec.Fields[7].Value is DBNull) { txtNbreManuel.Text = "0"; } else { txtNbreManuel.Text = rstProjetElec.Fields[7].Value; }
                    Recordset rstClient = new Recordset();
                    rstClient.Open($"select * from Client where IDClient = '{rstProjetElec.Fields[2].Value}'", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
                    if (!rstClient.EOF)
                    {
                        cmbClient.Items.Clear();
                        cmbClient.Items.Add($"{rstClient.Fields["NomClient"].Value}-{rstClient.Fields["IDClient"].Value}");
                        if (cmbClient.Items.Count > 0) { cmbClient.SelectedIndex = 0; }
                        cmbContact.Items.Clear();
                        cmbContact.Items.Add(rstClient.Fields["ContactGRB"].Value);
                        if (cmbContact.Items.Count > 0) { cmbContact.SelectedIndex = 0; }
                    }
                    rstClient.Close();
                }
                rstProjetElec.Close();

                rstProjSoum.MoveNext();
                x++;
            }
        }
        private void Deselect()
        {
            if (lvwSoumission.Items.Count > 0)
            {
                for (int X = 0; X < lvwSoumission.Items.Count; X++)
                    lvwSoumission.Items[X].Selected = false;
            }
        }
        private void ValeurParDefaut(ListViewItem itmSoumission)
        {
            if (m_bDroitPrix == true)
            {
                if (itmSoumission.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoumission.SubItems[I_COL_SOUM_PRIX_LIST].Text = " "; } else { itmSoumission.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                if (itmSoumission.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoumission.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; } else { itmSoumission.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                if (itmSoumission.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoumission.SubItems[I_COL_SOUM_PRIX_NET].Text = " "; } else { itmSoumission.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, " ")); }
                if (itmSoumission.SubItems.Count > I_COL_SOUM_TOTAL) { itmSoumission.SubItems[I_COL_SOUM_TOTAL].Text = " "; } else { itmSoumission.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, " ")); }
                if (itmSoumission.SubItems.Count > I_COL_SOUM_PROFIT) { itmSoumission.SubItems[I_COL_SOUM_PROFIT].Text = " "; } else { itmSoumission.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, " ")); }
            }
        }
        private bool VerifierSiDejaProjet()
        {
            ADODB.Recordset rstProjet;
            rstProjet = new Recordset();
            rstProjet.Open("SELECT * FROM ProjetElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (!rstProjet.EOF)
            {
                return true;
            }
            rstProjet.Close();
            rstProjet = default;
            return false;
        }
        private void InitialiserTempsTaux()
        {
            ADODB.Recordset rstConfig;
            rstConfig = new Recordset();
            rstConfig.Open("SELECT TauxDessinElec, TauxFabrication, TauxAssemblageElec, TauxProgInterface, TauxProgAutomate, TauxProgRobot, TauxVision, TauxTestElec, TauxInstallationElec," +
                " TauxMiseService, TauxFormationElec, TauxGestionProjetsElec, TauxShippingElec, Hebergement1, Hebergement2, Repas, Standard, UniteMobile FROM Config"
                , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (!(rstConfig.Fields["TauxDessinElec"].Value is DBNull)) { m_sTauxDessin = rstConfig.Fields["TauxDessinElec"].Value; } else { m_sTauxDessin = "0"; }
            if (!(rstConfig.Fields["TauxFabrication"].Value is DBNull)) { m_sTauxFabrication = rstConfig.Fields["TauxFabrication"].Value; } else { m_sTauxFabrication = "0"; }
            if (!(rstConfig.Fields["TauxAssemblageElec"].Value is DBNull)) { m_sTauxAssemblage = rstConfig.Fields["TauxAssemblageElec"].Value; } else { m_sTauxAssemblage = "0"; }
            if (!(rstConfig.Fields["TauxProgInterface"].Value is DBNull)) { m_sTauxProgInterface = rstConfig.Fields["TauxProgInterface"].Value; } else { m_sTauxProgInterface = "0"; }
            if (!(rstConfig.Fields["TauxProgAutomate"].Value is DBNull)) { m_sTauxProgAutomate = rstConfig.Fields["TauxProgAutomate"].Value; } else { m_sTauxProgAutomate = "0"; }
            if (!(rstConfig.Fields["TauxProgRobot"].Value is DBNull)) { m_sTauxProgRobot = rstConfig.Fields["TauxProgRobot"].Value; } else { m_sTauxProgRobot = "0"; }
            if (!(rstConfig.Fields["TauxVision"].Value is DBNull)) { m_sTauxVision = rstConfig.Fields["TauxVision"].Value; } else { m_sTauxVision = "0"; }
            if (!(rstConfig.Fields["TauxTestElec"].Value is DBNull)) { m_sTauxTest = rstConfig.Fields["TauxTestElec"].Value; } else { m_sTauxTest = "0"; }
            if (!(rstConfig.Fields["TauxInstallationElec"].Value is DBNull)) { m_sTauxInstallation = rstConfig.Fields["TauxInstallationElec"].Value; } else { m_sTauxInstallation = "0"; }
            if (!(rstConfig.Fields["TauxMiseService"].Value is DBNull)) { m_sTauxMiseService = rstConfig.Fields["TauxMiseService"].Value; } else { m_sTauxMiseService = "0"; }
            if (!(rstConfig.Fields["TauxFormationElec"].Value is DBNull)) { m_sTauxFormation = rstConfig.Fields["TauxFormationElec"].Value; } else { m_sTauxFormation = "0"; }
            if (!(rstConfig.Fields["TauxGestionProjetsElec"].Value is DBNull)) { m_sTauxGestion = rstConfig.Fields["TauxGestionProjetsElec"].Value; } else { m_sTauxGestion = "0"; }
            if (!(rstConfig.Fields["TauxShippingElec"].Value is DBNull)) { m_sTauxShipping = rstConfig.Fields["TauxShippingElec"].Value; } else { m_sTauxShipping = "0"; }
            if (m_eType == EnumType.TYPE_PROJET)
            {
                m_sTauxHebergement1 = "0";
                m_sTauxHebergement2 = "0";
                m_sTauxRepas = "0";
                m_sTauxTransport = "0";
                m_sTauxUniteMobile = "0";
            }
            else
            {
                m_sTauxHebergement1 = rstConfig.Fields["Hebergement1"].Value;
                m_sTauxHebergement2 = rstConfig.Fields["Hebergement2"].Value;
                m_sTauxRepas = rstConfig.Fields["Repas"].Value;
                m_sTauxTransport = rstConfig.Fields["Standard"].Value;
                m_sTauxUniteMobile = rstConfig.Fields["UniteMobile"].Value;
            }
            rstConfig.Close();
            rstConfig = default;
        }
        private void InitialiserVariables(string text)
        {
            ADODB.Recordset rstConfig;
            ADODB.Recordset rstProjSoum;
            rstProjSoum = new Recordset();
            if (m_eType == EnumType.TYPE_PROJET)
            {
                rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + cmbProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + cmbProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            if (!rstProjSoum.EOF)
            {
                m_sProfit = rstProjSoum.Fields["Profit"].Value;
                m_sCommission = rstProjSoum.Fields["Commission"].Value;
                m_sImprevue = rstProjSoum.Fields["Imprevue"].Value;
            }
            else
            {
                rstConfig = new Recordset();
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                m_sProfit = rstConfig.Fields["ProfitElec"].Value;
                m_sCommission = rstConfig.Fields["Commission"].Value;
                m_sImprevue = rstConfig.Fields["Imprévus"].Value;
                rstConfig.Close();
                rstConfig = default;
            }
            rstProjSoum.Close();
            rstProjSoum = default;
        }
        private void NewProjSoumElec_Load(object sender, EventArgs e)
        {
            Titre = Text;
            for (int x = 0; x < 0x14; x++)
            {
                lvwSoumission.Columns.Add(EntetesLvwSoumission[x]);
            }
        }
        private void cmdDateFacturation_Click(object sender, EventArgs e)
        {
            mvwDateFacturation.Visible = true;
            mvwDateFacturation.SelectionStart.AddDays(-1);
        }
        private void mvwDateFacturation_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDateFacturation.Text = mvwDateFacturation.SelectionRange.Start.ToShortDateString();
            mvwDateFacturation.Visible = false;
        }
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Sélectionner une image a charger pour le projet " + cmbProjSoum.Text;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtCheminPhotos.Text = openFile.FileName;
            }
        }
        private void cmdBavards_Click(object sender, EventArgs e)
        {
            if (((cmbProjSoum.Items.Count) > (0)))
            {
                RemplirListViewSuppression();
            }

        }
        private void RemplirListViewSuppression()
        {
            ADODB.Recordset rstBavard;
            ADODB.Recordset rstEmploye;
            lvwBavard.Items.Clear();
            rstBavard = new ADODB.Recordset();
            rstEmploye = new ADODB.Recordset();
            rstBavard.Open(("SELECT * FROM BavardSuppression WHERE NoProjSoum = '" + txtNoProjSoum.Text) + "' AND Type = 'E' ORDER BY [Date], Heure", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            if (rstBavard.EOF) { MessageBox.Show("Aucun donnée pour le projet " + cmbProjSoum.Text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); lvwBavard.Visible = false; return; }
            lvwBavard.Visible = true;
            lvwBavard.Focus();
            while (!(rstBavard.EOF))
            {
                System.Windows.Forms.ListViewItem itmBavard = lvwBavard.Items.Add(string.Empty);
                rstEmploye.Open($"SELECT Employe FROM Employés WHERE NoEmploye = {rstBavard.Fields["IDUser"].Value}", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                itmBavard.Text = rstEmploye.Fields["Employe"].Value;
                rstEmploye.Close();
                itmBavard.SubItems.Insert(I_COL_SUPP_DATE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, $"{rstBavard.Fields["Date"].Value}"));
                itmBavard.SubItems.Insert(I_COL_SUPP_HEURE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, $"{rstBavard.Fields["Heure"].Value}"));
                itmBavard.SubItems.Insert(I_COL_SUPP_QTE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, $"{rstBavard.Fields["Qté"].Value}"));
                itmBavard.SubItems.Insert(I_COL_SUPP_NO_ITEM, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, $"{rstBavard.Fields["No Item"].Value}"));
                rstBavard.MoveNext();
            }
            rstBavard.Close();
            rstBavard = (ADODB.Recordset)null;
            rstEmploye = (ADODB.Recordset)null;
        }
        private void cmdLegende_Click(object sender, EventArgs e)
        {
            Legende legende = new Legende();
            legende.MdiParent = Conteneur.Mdi;
            legende.Icon = Conteneur.ActiveForm.Icon;
            legende.Show();
        }
        private void cmdExport_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum = new ADODB.Recordset();
            if ((m_eType == EnumType.TYPE_PROJET))
            {
                rstProjSoum.Open(("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text) + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstProjSoum.Open(("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text) + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            ExporterListePieces(rstProjSoum);
            rstProjSoum.Close();
            rstProjSoum = (ADODB.Recordset)null;
        }
        private void ExporterListePieces(ADODB.Recordset rstProjSoum)
        {
            ADODB.Recordset rstPiece = new ADODB.Recordset();
            ADODB.Recordset rstTemp = new ADODB.Recordset();
            ADODB.Recordset rstImpListePiece = new ADODB.Recordset();
            System.Int16 iCompteurPiece;
            System.String sSousSection;
            System.String sSection;
            System.String sNoProjet;
            System.String sNoSoumission;
            System.Boolean bAjouterSection;
            System.Boolean bAjouterSousSection;
            System.Boolean bAjouterPiece;
            Microsoft.Office.Interop.Excel.Application xlsApp;
            Microsoft.Office.Interop.Excel.Workbook xlsWorkBook;
            System.Int16 iCompteur;
            System.String sSaveAsFileName;
            iCompteurPiece = (System.Int16)1;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((m_eType == EnumType.TYPE_PROJET))
            {
                sNoProjet = $"{rstProjSoum.Fields["IDProjet"].Value}";
                sNoSoumission = $"{rstProjSoum.Fields["IDSoumission"].Value}";
                rstPiece.Open(("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet) + "' AND Type = 'E' ORDER BY NuméroLigne", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            else
            {
                sNoProjet = string.Empty;
                sNoSoumission = $"{rstProjSoum.Fields["IDSoumission"].Value}";
                rstPiece.Open(("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoSoumission) + "' AND Type = 'E' ORDER BY NuméroLigne", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            while (!(rstPiece.EOF))
            {
                if (rstPiece.Fields["Visible"].Value)
                {
                    bAjouterSection = true;
                    bAjouterSousSection = true;
                    bAjouterPiece = true;
                    rstImpListePiece.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                    rstImpListePiece.Open($"SELECT * FROM Impression_ListePiece WHERE IDSection = '{rstPiece.Fields["IDSection"].Value}'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (!(rstImpListePiece.EOF))
                    {
                        bAjouterSection = false;
                        while (!(rstImpListePiece.EOF))
                        {
                            if ((rstImpListePiece.Fields["NomSousSection"].Value ?? "") == (rstPiece.Fields["SousSection"].Value ?? ""))
                            {
                                bAjouterSousSection = false;
                                if ((rstPiece.Fields["NumItem"].Value == "Texte") & (rstPiece.Fields["NumItem"].Value != "Text"))
                                {
                                    if (rstImpListePiece.Fields["NumItem"].Value != rstPiece.Fields["NumItem"].Value)
                                    {
                                        bAjouterPiece = false;
                                        rstImpListePiece.Fields["Qté"].Value = (double.Parse($"{rstImpListePiece.Fields["Qté"].Value}") + double.Parse($"{rstPiece.Fields["Qté"].Value}")).ToString();
                                        if (!((rstImpListePiece.Fields["ID"].Value is System.DBNull)))
                                        {
                                            if (rstImpListePiece.Fields["ID"].Value != "")
                                            {
                                                rstImpListePiece.Fields["ID"].Value = $"{rstImpListePiece.Fields["ID"].Value}, {rstPiece.Fields["ID"].Value}";
                                            }
                                            else
                                            {
                                                rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value;
                                            }
                                        }
                                        else
                                        {
                                            rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value;
                                        }
                                        rstImpListePiece.Update();
                                        if (int.Parse($"{rstImpListePiece.Fields["Qté"].Value}") > 0)
                                        {
                                            rstImpListePiece.Delete();
                                            rstImpListePiece.Filter = $"NomSousSection = '{$"{rstPiece.Fields["SousSection"].Value}".Replace("'", "''")}'";
                                            if (((rstImpListePiece.RecordCount) == (1)))
                                            {
                                                rstImpListePiece.Delete();
                                                rstImpListePiece.Filter = $"IDSection = '{rstPiece.Fields["IDSection"].Value}'";
                                                if (((rstImpListePiece.RecordCount) == (1)))
                                                {
                                                    rstImpListePiece.Delete();
                                                }
                                            }
                                            rstImpListePiece.Filter = "";
                                        }
                                        break;
                                    }
                                }
                                else { break; }
                            }
                            rstImpListePiece.MoveNext();
                        }
                    }
                    if (((bAjouterSection) == (true)))
                    {
                        if ((m_eLangage == EnumLangage.ANGLAIS)) { sSection = "NomSectionEN"; }
                        else { sSection = "NomSectionFR"; }
                        rstTemp.Open($"SELECT {sSection} FROM SoumProjSectionElec WHERE IDSection = '{rstPiece.Fields["IDSection"].Value}'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                        rstImpListePiece.AddNew();
                        rstImpListePiece.Fields["NoLigne"].Value = (System.Object)iCompteurPiece;
                        rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                        if (!((rstTemp.Fields[sSection].Value is System.DBNull)))
                        {
                            rstImpListePiece.Fields["Section"].Value = rstTemp.Fields[sSection].Value;
                        }
                        else
                        {
                            rstImpListePiece.Fields["Section"].Value = " ";
                        }
                        rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                        rstImpListePiece.Update();
                        iCompteurPiece = (System.Int16)((System.Int32)(iCompteurPiece) + (1));
                        rstTemp.Close();
                    }
                    if (((bAjouterSousSection) == (true)))
                    {
                        sSousSection = $"{rstPiece.Fields["SousSection"].Value}";
                        if (((sSousSection ?? "") == S_PAS_SOUS_SECTION)) { sSousSection = " "; }
                        rstImpListePiece.AddNew();
                        rstImpListePiece.Fields["NoLigne"].Value = (System.Object)iCompteurPiece;
                        rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                        rstImpListePiece.Fields["SousSection"].Value = sSousSection;
                        rstImpListePiece.Fields["NomSousSection"].Value = rstPiece.Fields["SousSection"].Value;
                        rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                        rstImpListePiece.Update();
                        iCompteurPiece = (System.Int16)((System.Int32)(iCompteurPiece) + (1));
                    }
                    if (((bAjouterPiece) == (true)))
                    {
                        rstImpListePiece.AddNew();
                        rstImpListePiece.Fields["NoLigne"].Value = (System.Object)iCompteurPiece;
                        rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                        rstImpListePiece.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                        rstImpListePiece.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                        if ((m_eLangage == EnumLangage.ANGLAIS))
                        {
                            rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_EN"].Value;
                        }
                        else
                        {
                            rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_FR"].Value;
                        }
                        rstImpListePiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                        if ((m_eType == EnumType.TYPE_PROJET))
                        {
                            rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value;
                        }
                        rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                        rstImpListePiece.Fields["NomSousSection"].Value = rstPiece.Fields["SousSection"].Value;
                        rstImpListePiece.Update();
                        iCompteurPiece = (System.Int16)((System.Int32)(iCompteurPiece) + (1));
                    }
                    rstImpListePiece.Close();
                }
                rstPiece.MoveNext();
            }
            rstImpListePiece.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            rstImpListePiece.Open($"SELECT * FROM impression_Listepiece WHERE TRIM(IDSoumission) = '{sNoSoumission.Trim()}' ORDER BY noligne", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            xlsApp = new Microsoft.Office.Interop.Excel.Application();
            xlsWorkBook = xlsApp.Workbooks.Add(string.Empty);
            xlsApp.Range["A1"].Value = (("Liste de matériel ( " + txtNoProjSoum.Text) + " )");
            xlsApp.Range["A1"].Font.Bold = true;
            xlsApp.Range["A1"].Font.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingle;
            xlsApp.Range["A1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["A1"].Font.Size = 14;
            xlsApp.Range["A1:E1"].Merge();
            xlsApp.Range["A4"].Value = "Qté";
            xlsApp.Range["A4"].Font.Bold = true;
            xlsApp.Range["A4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["B4"].Value = "No. Item";
            xlsApp.Range["B4"].Font.Bold = true;
            xlsApp.Range["B4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["C4"].Value = "Description";
            xlsApp.Range["C4"].Font.Bold = true;
            xlsApp.Range["C4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["D4"].Value = "Manufacturier";
            xlsApp.Range["D4"].Font.Bold = true;
            xlsApp.Range["D4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["E4"].Value = "#ID";
            xlsApp.Range["E4"].Font.Bold = true;
            xlsApp.Range["E4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            xlsApp.Range["A4:E4"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
            iCompteur = 0x05;
            while (!(rstImpListePiece.EOF))
            {
                xlsApp.Range["A" + iCompteur].Value = rstImpListePiece.Fields["Qté"].Value;
                if ((rstImpListePiece.Fields["Section"].Value is System.DBNull))
                {
                    xlsApp.Range["B" + iCompteur].Value = rstImpListePiece.Fields["NumItem"].Value;
                }
                else
                {
                    xlsApp.Range["B" + iCompteur].Value = rstImpListePiece.Fields["Section"].Value;
                    xlsApp.Range["B" + iCompteur].Font.Bold = true;
                }
                if ((rstImpListePiece.Fields["SousSection"].Value is System.DBNull))
                {
                    xlsApp.Range["C" + iCompteur].Value = rstImpListePiece.Fields["Description"].Value;
                }
                else
                {
                    xlsApp.Range["C" + iCompteur].Value = rstImpListePiece.Fields["SousSection"].Value;
                    xlsApp.Range["C" + iCompteur].Font.Bold = true;
                }
                xlsApp.Range["D" + iCompteur].Value = rstImpListePiece.Fields["Manufact"].Value;
                xlsApp.Range["E" + iCompteur].Value = rstImpListePiece.Fields["ID"].Value;
                rstImpListePiece.MoveNext();
                iCompteur = (System.Int16)((System.Int32)(iCompteur) + (1));
            }
            iCompteur = (System.Int16)((System.Int32)(iCompteur) - (1));
            xlsApp.Columns["A:A"].EntireColumn.AutoFit();
            xlsApp.Columns["B:B"].EntireColumn.AutoFit();
            xlsApp.Columns["C:C"].EntireColumn.AutoFit();
            xlsApp.Columns["D:D"].EntireColumn.AutoFit();
            xlsApp.Columns["E:E"].EntireColumn.AutoFit();
            rstImpListePiece.Close();
            rstImpListePiece = null;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            sSaveAsFileName = xlsApp.GetSaveAsFilename(txtNoProjSoum.Text + ".xlsx", "Fichiers Excel (*.xls), *.xlsx");
            if ((sSaveAsFileName != "Faux")) { xlsWorkBook.SaveAs(sSaveAsFileName); }
            xlsWorkBook.Saved = true;
            xlsWorkBook.Close();
            xlsWorkBook = default;
            xlsApp.Quit();
            xlsApp = default;
            rstTemp = null;
        }
        private void cmdOKCommentaire_Click(object sender, EventArgs e)
        {
            if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_COMMENTAIRE)))
            {
                lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_COMMENTAIRE].Text = txtCommentaire.Text;
            }
            else
            {
                lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_COMMENTAIRE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, txtCommentaire.Text));
            }
            fraCommentaire.Visible = false;
        }
        private void cmdOKDateRequise_Click(object sender, EventArgs e)
        {
            System.DateTime datDate = mvwDateRequise.SelectionStart;
            if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_DATE_REQUISE)))
            {
                lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DATE_REQUISE].Text = datDate.ToShortDateString();
            }
            else
            {
                lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_DATE_REQUISE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, datDate.ToShortDateString()));
            }
            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DATE_REQUISE].ForeColor = COLOR_ORANGE;
            fraDateRequise.Visible = false;
            m_bMonthViewHasFocus = false;
        }
        private void cmdOKFRS_Click(object sender, EventArgs e)
        {
            if ((((m_bPieceInutile) == (true)) | ((m_bChangementFRS) == (true))))
            {
                ChoisirFournisseurMateriel();
            }
            else
            {
                ChoisirFournisseur();

            }
        }
        private void ChoisirFournisseur()
        {
            System.String sQuantite;
            var sSousSection = default(System.String);
            var bDemanderSS = default(System.Boolean);
            System.String sParams;
            if (((lvwSoumission.Items.Count) > (0)))
            {
                if (((lvwSoumission.FocusedItem.Index) > (1)))
                {
                    if (((VerifierEmplacement((System.Int16)lvwSoumission.FocusedItem.Index)) == (true)))
                    {
                        if (lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PIECE].Tag.ToString() == "")
                        {
                            if (lvwSoumission.Items[(lvwSoumission.FocusedItem.Index) - (1)].Tag == "")
                            {
                                MessageBox.Show("Vous ne pouvez pas mettre une pièce entre une section et une sous-section", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                fraFournisseur.Visible = false;
                                Deselect();
                                lvwSoumission.Items[1].Selected = true;
                                return;
                            }
                            else
                            {
                                sSousSection = (lvwSoumission.Items[(lvwSoumission.FocusedItem.Index) - (1)].SubItems[(System.Int32)I_COL_SOUM_PIECE].Tag).ToString();
                            }
                        }
                        else
                        {
                            sSousSection = lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PIECE].Tag.ToString();
                        }
                    }
                    else
                    {
                        if (lvwSoumission.Items[(lvwSoumission.FocusedItem.Index) - (1)].SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Tag != "")
                        {
                            if (MessageBox.Show($"Vous essayez d'ajouter une pièce de la section {cmbSections.Text} dans la section " +
                                $"{lvwSoumission.Items[(lvwSoumission.FocusedItem.Index - 1)].SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Tag.ToString()}" +
                                $"\nVoulez-vous ajouter la pièce dans la section ", Application.ProductName + "." + Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                == DialogResult.Yes)
                            {
                                cmbSections.SelectedIndex = lvwSoumission.FocusedItem.Index - 1;
                                ChoisirFournisseur();
                            }
                            fraFournisseur.Visible = false;
                            Deselect();
                            lvwSoumission.Items[1].Selected = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Impossible d'ajouter entre une section et une sous-section!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    bDemanderSS = true;
                }
            }
            else
            {
                bDemanderSS = true;
            }
            sQuantite = Microsoft.VisualBasic.Interaction.InputBox("Quelle est la quantité?").Replace(".", ",");
            if (!string.IsNullOrEmpty(sQuantite))
            {
                if (!(Microsoft.VisualBasic.Information.IsNumeric(sQuantite)))
                {
                    MessageBox.Show("Quantité non numérique!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if ((((double.Parse(sQuantite))) < (0d)))
                    {
                        if ((lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT"))
                        {
                            MessageBox.Show("Impossible de faire une demande de prix sur une pièce négative!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                return;
            }
            if (((bDemanderSS) == (true)))
            {
                if (((m_sSousSection ?? "") != S_PAS_SOUS_SECTION))
                {
                    sSousSection = Microsoft.VisualBasic.Interaction.InputBox("Quelle est la sous-section?", DefaultResponse: m_sSousSection);
                }
                else
                {
                    sSousSection = Microsoft.VisualBasic.Interaction.InputBox("Quelle est la sous-section?");
                }
            }
            if (string.IsNullOrEmpty(sSousSection))
            {
                sSousSection = S_PAS_SOUS_SECTION;
                m_sSousSection = Microsoft.VisualBasic.Constants.vbNullString;
            }
            else
            {
                m_sSousSection = sSousSection;
            }
            if ((((double.Parse(sQuantite))) < (0d)))
            {
                if ((m_eType == EnumType.TYPE_PROJET))
                {
                    if (((((double.Parse(Microsoft.VisualBasic.Strings.Right(txtNoProjSoum.Text, 2)))) >= (60d)) & (((double.Parse(Microsoft.VisualBasic.Strings.Right(txtNoProjSoum.Text, 2)))) <= (98d))))
                    {
                        AjouterNegatifDansListView(double.Parse(sQuantite), sSousSection);
                    }
                    else
                    {
                        AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection);
                    }
                }
                else
                {
                    AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection);
                }
            }
            else
            {
                AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection);
            }
            CalculerPrix();
            fraFournisseur.Visible = false;
            if (((lvwSoumission.Items.Count) > (0)))
            {
                Deselect();
                lvwSoumission.Items[1].Selected = true;
            }
        }
        private void AjouterNegatifDansListView(double v, string sSousSection)
        {
            int iIndex = default;
            ListViewItem itmSoum;
            int X;
            int iIDSection;
            int iTagSection;
            bool bSelected;
            var iIndexSel = default(int);
            double dblTempsMec;
            ADODB.Recordset rstProjet;
            var bQteOK = default(bool);
            var sNoProjet = default(string);
            string sPrixList;
            string sEscompte;
            string sPrixNet;
            string sTemps;
            var dblTotalQte = default(double);
            rstProjet = new Recordset();
            if (double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 60d & double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 98d)
            {
                sNoProjet = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + m_sLiaison;
                if (m_bRecherchePiece == true)
                {
                    rstProjet.Open($"SELECT * FROM Projet_Pieces WHERE IDProjet = '{sNoProjet}' AND NumItem = " +
                        $"'{lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text.Replace("'", "''")}' AND IDFRS = {lvwFournisseur.FocusedItem.Tag}",
                        odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjet.Open($"SELECT * FROM Projet_Pieces WHERE IDProjet = '{sNoProjet} ' AND NumItem = " +
                        $"'{lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text.Replace("'", "''")}' AND IDFRS = {lvwFournisseur.FocusedItem.Tag}",
                        odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
            }
            if (!rstProjet.EOF)
            {
                while (!rstProjet.EOF)
                {
                    dblTotalQte = dblTotalQte + rstProjet.Fields["Qté"].Value;
                    rstProjet.MoveNext();
                }
                if (dblTotalQte >= Math.Abs(dblQuantite)) { bQteOK = true; }
            }
            else
            {
                MessageBox.Show("La pièce n'existe pas dans le projet " + sNoProjet, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                rstProjet.Close();
                rstProjet = default;
                return;
            }
            if (bQteOK == true)
            {
                rstProjet.MovePrevious();
                sPrixList = rstProjet.Fields["Prix_List"].Value;
                sEscompte = rstProjet.Fields["Escompte"].Value;
                sPrixNet = rstProjet.Fields["Prix_Net"].Value;
                sTemps = rstProjet.Fields["Temps"].Value;
            }
            else
            {
                if (m_bRecherchePiece == true)
                {
                    MessageBox.Show("Il n'y a pas assez de " + lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text + " dans le projet " + sNoProjet + " pour en enlever " + Math.Abs(dblQuantite) + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Il n'y a pas assez de " + lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text + " dans le projet " + sNoProjet + " pour en enlever " + Math.Abs(dblQuantite) + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                rstProjet.Close();
                rstProjet = default;
                return;
            }
            rstProjet.Close();
            rstProjet = default;
            bSelected = false;
            if (lvwSoumission.Items.Count > 0)
            {
                if (lvwSoumission.FocusedItem.Index > 1)
                {
                    bSelected = true;
                    iIndexSel = lvwSoumission.FocusedItem.Index;
                }
            }
            if (bSelected == false) { bool bIndex = TrouverIndexSection(sSousSection); } else { iIndex = iIndexSel; }
            itmSoum = lvwSoumission.Items.Insert(iIndex, "");
            itmSoum.Checked = true;
            //Quantité
            itmSoum.Text = dblQuantite.ToString();
            if (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_QUOTER].Text == "Oui")
            {
                itmSoum.Text = itmSoum.Text + "*";
                itmSoum.ForeColor = COLOR_VERT;
            }
            else { itmSoum.ForeColor = COLOR_NOIR; }
            itmSoum.Tag = cmbSections.Items[cmbSections.SelectedIndex].ToString();
            //IDSection
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text)); }
            itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
            itmSoum.SubItems[I_COL_SOUM_PIECE].Tag = sSousSection;
            if (m_eLangage == EnumLangage.ANGLAIS)
            {
                if (m_bRecherchePiece == true)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text; }
                    else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text;
                }
                else
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text; }
                    else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text;
                }
            }
            else
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text)); }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text;
            }
            else
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text)); }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text;
            }
            itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text)); }
            itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = (cmbSections.SelectedIndex + 1).ToString();
            itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
            if (string.IsNullOrEmpty(Strings.Trim(sPrixList)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = "0"; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, "0")); }
            }
            else
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = sPrixList; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, sPrixList)); }
                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = sPrixList;
            }
            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor;
            if (!string.IsNullOrEmpty(Strings.Trim(sEscompte)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = sEscompte; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, sEscompte)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = "0"; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, "0")); }
            itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor;
            if (!string.IsNullOrEmpty(Strings.Trim(sPrixNet)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = sPrixNet; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, sPrixNet)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = "0"; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, "0")); }
            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor;
            if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = lvwFournisseur.FocusedItem.Text; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.Text)); }
            itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
            itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
            if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = sTemps; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, sTemps)); }
            itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor;
            if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text.Replace(".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString(); }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text.Replace(".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString())); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
            itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor;
            if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * int.Parse(m_sProfit), 2).ToString(); }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(m_sProfit), 2).ToString())); }
            itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
            if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$"; }
            else { itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$")); }
            itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor;
            if (string.IsNullOrEmpty(itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; }
                else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
            }
            CalculerTempsFabrication();
        }
        private void CalculerTempsFabrication()
        {
            var dblTempsFab = default(double);
            for (int X = 0; X < lvwSoumission.Items.Count; X++)
            {
                if (!string.IsNullOrEmpty(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_MONTAGE].Text)))
                {
                    dblTempsFab = dblTempsFab + double.Parse(Strings.Replace(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_MONTAGE].Text), ".", ","));
                }
            }
            m_sTempsFabrication = (dblTempsFab / 10d).ToString().Replace(".", ",");
        }
        private bool TrouverIndexSection(string sSousSection)
        {
            int X;
            var iIndex = default(int);
            int iTagSection;
            int iIDSection;
            var iIndexSect = default(int);
            var bTrouverSect = default(bool);
            var bTrouverSSect = default(bool);
            var bTrouverIndexItem = default(bool);
            int iIndexSSection = 0;
            string sTagSousSection;
            ListViewItem itmSoum;
            if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
            {
                sSousSection = string.Empty;
                sTagSousSection = S_PAS_SOUS_SECTION;
            }
            else { sTagSousSection = sSousSection; }
            if (lvwSoumission.Items.Count > 0)
            {
                for (X = 0; X < lvwSoumission.Items.Count; X++)
                {
                    if ((lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text ?? "") == (cmbSections.Text ?? ""))
                    {
                        bTrouverSect = true; iIndexSect = X; X++; while ((string)lvwSoumission.Items[X].Tag != cmbSections.Items[cmbSections.SelectedIndex].ToString())
                        {
                            if ((lvwSoumission.Items[X].SubItems[I_COL_SOUM_DESCR].Text ?? "") == (sSousSection ?? "")) { bTrouverSSect = true; iIndex++; break; }
                            X++;
                            if (X > lvwSoumission.Items.Count) { break; }
                        }
                        break;
                    }
                }
            }
            else
            {
                bTrouverSect = false;
            }
            if (bTrouverSect == false)
            {
                if (lvwSoumission.Items.Count > 0)
                {
                    for (X = 0; X < lvwSoumission.Items.Count; X++)
                    {
                        if (lvwSoumission.Items[X].Tag.ToString() != string.Empty)
                        {
                            iTagSection = (int)lvwSoumission.Items[X].SubItems[I_COL_SOUM_MANUFACT].Tag;
                            iIDSection = cmbSections.SelectedIndex + 1;
                            if (X == 2)
                            {
                                if (iIDSection < iTagSection) { iIndex = 1; break; }
                            }
                            else
                            if (X == lvwSoumission.Items.Count)
                            {
                                if (iIDSection > iTagSection) { iIndex++; break; }
                            }
                            else
                            if ((string)lvwSoumission.Items[X + 1].Tag != string.Empty)
                            {
                                if (iIDSection != (int)lvwSoumission.Items[X + 1].SubItems[I_COL_SOUM_MANUFACT].Tag)
                                {
                                    iIndex++; break;
                                }
                            }
                            if (iIDSection > iTagSection & iIDSection != (int)lvwSoumission.Items[X + 2].SubItems[I_COL_SOUM_MANUFACT].Tag)
                            {
                                iIndex++;
                            }
                        }
                    }
                }
                else
                {
                    iIndex = 1;
                }
                itmSoum = lvwSoumission.Items.Insert(iIndex, "");
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = cmbSections.Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, cmbSections.Text)); }
                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = (cmbSections.SelectedIndex + 1).ToString();
                ValeurParDefaut(itmSoum);
                iIndex++;
                if (AjouterSousSection(iIndex, sTagSousSection)) { iIndexSSection++; }
                iIndex = iIndexSSection;
            }
            else
            if (bTrouverSSect == false)
            {
                if (AjouterSousSection(iIndexSect + 1, sTagSousSection)) { iIndexSSection++; }
                iIndex = iIndexSSection;
            }
            int counter = 0;
            counter = iIndex;
            for (X = counter; X <= lvwSoumission.Items.Count; X++)
            {
                if ((string)lvwSoumission.Items[X].Tag != cmbSections.Items[cmbSections.SelectedIndex].ToString())
                {
                    bTrouverIndexItem = true;
                    iIndex = X;
                    break;
                }
            }
            if (bTrouverIndexItem == false)
            {
                iIndex = lvwSoumission.Items.Count + 1;
            }
            return true;
        }
        private bool AjouterSousSection(int iIndex, string sTagSousSection)
        {
            ListViewItem itmSoum;
            int X;
            var bTrouverIndexSSection = default(bool);
            string sTag;
            if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
            {
                sSousSection = string.Empty;
                sTag = S_PAS_SOUS_SECTION;
            }
            else { sTag = sSousSection; }
            if ((sTag ?? "") != S_PAS_SOUS_SECTION)
            {
                for (X = iIndexSection; X < lvwSoumission.Items.Count; X++)
                {
                    if (lvwSoumission.Items[X].Tag.ToString() == cmbSections.Items[cmbSections.SelectedIndex].ToString()) { bTrouverIndexSSection = true; iIndex = X; break; }
                }
                if (bTrouverIndexSSection == false) { iIndex = lvwSoumission.Items.Count + 1; }
            }
            else { iIndex = iIndexSection; }
            itmSoum = lvwSoumission.Items.Insert(iIndex, "");
            ValeurParDefaut(itmSoum);
            if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
            itmSoum.Tag = cmbSections.Items[cmbSections.SelectedIndex].ToString();
            if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
            itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = (cmbSections.SelectedIndex + 1).ToString();
            return true;
        }
        private bool VerifierEmplacement(short index)
        {
            ListViewItem itmSoum;
            itmSoum = lvwSoumission.Items[iIndexSelection];
            if (itmSoum.Tag != "")
            {
                itmSoum = lvwSoumission.Items[iIndexSelection - 1];
            }
            if (itmSoum.Tag == cmbSections.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
        private void ChoisirFournisseurMateriel()
        {
            ADODB.Recordset rstProjet;
            ADODB.Recordset rstConfig;
            System.Windows.Forms.ListViewItem itmAncien;
            System.Windows.Forms.ListViewItem itmNouveau;
            System.String sQuantite;
            var sExtra = default(System.String);
            System.String sTauxUSA;
            System.String sTauxSPA;
            if (((m_bChangementFRS) == (true)))
            {
                if ((lvwFournisseur.FocusedItem.Text != "CHOISIR ULTÉRIEUREMENT"))
                {
                    rstConfig = new ADODB.Recordset();
                    rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM GRB_Config", odbc, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly);
                    sTauxUSA = $"{rstConfig.Fields["TauxAmericain"].Value}";
                    sTauxSPA = $"{rstConfig.Fields["TauxEspagnol"].Value}";
                    rstConfig.Close();
                    rstConfig = (ADODB.Recordset)null;
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_DISTRIB)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Text = lvwFournisseur.FocusedItem.Text;
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_DISTRIB, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, lvwFournisseur.FocusedItem.Text));
                    }
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
                    if (lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PIECE].ForeColor != (COLOR_BRUN))
                    {
                        if (string.IsNullOrEmpty(Microsoft.VisualBasic.Strings.Trim(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text)))
                        {
                            if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                            {
                                lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)4);
                            }
                            else
                            {
                                lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)4)));
                            }
                        }
                        else
                        {
                            if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "USA")
                            {
                                if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                                {
                                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                }
                                else
                                {
                                    lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                }
                            }
                            else
                            {
                                if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "SPA")
                                {
                                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                                    {
                                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                    }
                                    else
                                    {
                                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                    }
                                }
                                else
                                {
                                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                                    {
                                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text, EnumConvert.MODE_ARGENT, (System.Int16)4);
                                    }
                                    else
                                    {
                                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Text, EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                    }
                                }
                            }
                        }
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Tag = lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_LIST].Tag;
                        if (!string.IsNullOrEmpty(Microsoft.VisualBasic.Strings.Trim(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text)))
                        {
                            if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_ESCOMPTE)))
                            {
                                lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_ESCOMPTE].Text, EnumConvert.MODE_POURCENT);
                            }
                            else
                            {
                                lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_ESCOMPTE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_ESCOMPTE].Text, EnumConvert.MODE_POURCENT)));
                            }
                            if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "USA")
                            {
                                if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                {
                                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                }
                                else
                                {
                                    lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                }
                            }
                            else
                            {
                                if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "SPA")
                                {
                                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                    {
                                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                    }
                                    else
                                    {
                                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                    }
                                }
                                else
                                {
                                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                    {
                                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text, EnumConvert.MODE_ARGENT, (System.Int16)4);
                                    }
                                    else
                                    {
                                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_NET].Text, EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(Microsoft.VisualBasic.Strings.Trim(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text)))
                            {
                                if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "USA")
                                {
                                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                    {
                                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                    }
                                    else
                                    {
                                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text))) / ((double.Parse(sTauxUSA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                    }
                                }
                                else
                                {
                                    if (lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag.ToString() == "SPA")
                                    {
                                        if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                        {
                                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4);
                                        }
                                        else
                                        {
                                            lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text))) / ((double.Parse(sTauxSPA))), 4)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                        }
                                    }
                                    else
                                    {
                                        if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                        {
                                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text, EnumConvert.MODE_ARGENT, (System.Int16)4);
                                        }
                                        else
                                        {
                                            lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed(lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PRIX_SP].Text, EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_ESCOMPTE)))
                                {
                                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                                }
                                else
                                {
                                    lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_ESCOMPTE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                                }
                                if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                                {
                                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)4);
                                }
                                else
                                {
                                    lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)4)));
                                }
                            }
                        }
                        if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_TOTAL)))
                        {
                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text = Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty)))) * ((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * (System.Double)((int.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)2);
                        }
                        else
                        {
                            lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_TOTAL, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty)))) * ((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * (System.Double)((int.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)2)));
                        }
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Tag = lvwFournisseur.FocusedItem.SubItems[(System.Int32)I_COL_FRS_PERS_RESS].Tag;
                        if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PROFIT)))
                        {
                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PROFIT].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty))))))), 2)).ToString(), EnumConvert.MODE_ARGENT);
                        }
                        else
                        {
                            lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PROFIT, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty))))))), 2)).ToString(), EnumConvert.MODE_ARGENT)));
                        }
                    }
                }
                else
                {
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_DISTRIB)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Text = string.Empty;
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_DISTRIB, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, string.Empty));
                    }
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Tag = (0).ToString();
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)2);
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)2)));
                    }
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_ESCOMPTE)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_ESCOMPTE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                    }
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)2);
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed("0", EnumConvert.MODE_ARGENT, (System.Int16)2)));
                    }
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_TOTAL)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text = Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty)))) * ((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * (System.Double)((int.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)2);
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_TOTAL, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty)))) * ((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * (System.Double)((int.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT, (System.Int16)2)));
                    }
                    if (((lvwSoumission.FocusedItem.SubItems.Count) > (System.Int32)(I_COL_SOUM_PROFIT)))
                    {
                        lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PROFIT].Text = Conversion_Renamed((System.Math.Round(((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty))))))), 2)).ToString(), EnumConvert.MODE_ARGENT);
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert((System.Int32)I_COL_SOUM_PROFIT, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty))))))), 2)).ToString(), EnumConvert.MODE_ARGENT)));
                    }
                    if ((m_eType == EnumType.TYPE_PROJET))
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_COMMENTAIRE].Text))
                        {
                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_COMMENTAIRE].ForeColor = (COLOR_MAGENTA);
                        }
                        if (!string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_FACTURATION].Text))
                        {
                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_FACTURATION].ForeColor = (COLOR_MAGENTA);
                        }
                        if (!string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ID].Text))
                        {
                            lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ID].ForeColor = (COLOR_MAGENTA);
                        }
                    }

                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_DESCR].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_MONTAGE].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PIECE].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_PROFIT].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TEMPS].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.FocusedItem.SubItems[(System.Int32)I_COL_SOUM_TOTAL].ForeColor = (COLOR_MAGENTA);
                    lvwSoumission.Refresh();
                }
                CalculerPrix();
                fraFournisseur.Visible = false;
                m_bPieceInutile = false;
                m_bChangementFRS = false;
            }
            else
            {
                if (int.Parse(Droite(txtNoProjSoum.Text, 0x02)) >= 0 & int.Parse(Droite(txtNoProjSoum.Text, 2)) <= 0x13)
                {
                    sExtra = Microsoft.VisualBasic.Interaction.InputBox("Dans quel extra le retour doit être fait ? (2 chiffres seulement)");
                    if (((Microsoft.VisualBasic.Strings.Len(sExtra)) != (2)))
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Format incorrect!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                    if (!(Microsoft.VisualBasic.Information.IsNumeric(sExtra)))
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("L'extra doit être numérique!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                    if ((double.Parse(sExtra) < 60d) | (double.Parse(sExtra) > 98d))
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("L'extra doit être entre 60 et 98!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                    rstProjet = new ADODB.Recordset();
                    rstProjet.Open("SELECT * FROM GRB_ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, (txtNoProjSoum.Text.Length - 2)) + sExtra + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (rstProjet.EOF)
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox((("Le projet " + Gauche(txtNoProjSoum.Text, (Microsoft.VisualBasic.Strings.Len(txtNoProjSoum.Text)) - (2))) + sExtra) + " n'existe pas!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                        rstProjet.Close();
                        rstProjet = (ADODB.Recordset)null;
                        return;
                    }
                    else
                    {
                        rstProjet.Close();
                        rstProjet = (ADODB.Recordset)null;
                    }
                }
                sQuantite = Microsoft.VisualBasic.Interaction.InputBox("Quelle est la quantité?");
                sQuantite = Microsoft.VisualBasic.Strings.Replace(sQuantite, ".", ",");
                sQuantite = Microsoft.VisualBasic.Strings.Replace(sQuantite, "-", "");
                if (!string.IsNullOrEmpty(sQuantite))
                {
                    if (!(Microsoft.VisualBasic.Information.IsNumeric(sQuantite)))
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Quantité non numérique!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                else { return; }
                if ((((double.Parse(sQuantite))) <= ((double.Parse(Microsoft.VisualBasic.Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty))))))
                {
                    itmAncien = lvwSoumission.FocusedItem;
                    itmNouveau = lvwSoumission.Items.Insert((itmAncien.Index) + (1), "");
                    itmNouveau.Checked = itmAncien.Checked;
                    itmNouveau.Text = ("-" + sQuantite);
                    itmNouveau.Tag = itmAncien.Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_PIECE)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PIECE].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_PIECE].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_PIECE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_PIECE].Text));
                    }
                    itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PIECE].Tag = itmAncien.SubItems[(System.Int32)I_COL_SOUM_PIECE].Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_DESCR)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DESCR].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_DESCR].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_DESCR, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_DESCR].Text));
                    }
                    itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DESCR].Tag = itmAncien.SubItems[(System.Int32)I_COL_SOUM_DESCR].Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_MANUFACT)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_MANUFACT, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Text));
                    }
                    itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Tag = itmAncien.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_LIST)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_LIST, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Text));
                    }
                    itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Tag = itmAncien.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_ESCOMPTE)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_ESCOMPTE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].Text));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_PRIX_NET)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_PRIX_NET, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_DISTRIB)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Text = lvwFournisseur.FocusedItem.Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_DISTRIB, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, lvwFournisseur.FocusedItem.Text));
                    }
                    itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_TEMPS)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text = itmAncien.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_TEMPS, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, itmAncien.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text));
                    }
                    if (!string.IsNullOrEmpty(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text.Trim()))
                    {
                        if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_MONTAGE)))
                        {
                            itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MONTAGE].Text = ((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text, ".", ",")))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", string.Empty)))))).ToString();
                        }
                        else
                        {
                            itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_MONTAGE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, ((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].Text, ".", ",")))) * ((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", string.Empty)))))).ToString()));
                        }
                    }
                    else
                    {
                        if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_MONTAGE)))
                        {
                            itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MONTAGE].Text = string.Empty;
                        }
                        else
                        {
                            itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_MONTAGE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, string.Empty));
                        }

                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_TOTAL)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text = Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", "")))) * ((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * ((double.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT);
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_TOTAL, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", "")))) * ((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))) * ((double.Parse(m_sProfit))), 2)).ToString(), EnumConvert.MODE_ARGENT)));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_PROFIT)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PROFIT].Text = Conversion_Renamed((System.Math.Round(((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", "")))) * ((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))))), 2)).ToString(), EnumConvert.MODE_ARGENT);
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_PROFIT, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, Conversion_Renamed((System.Math.Round(((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TOTAL].Text))) - (((((double.Parse(Microsoft.VisualBasic.Strings.Replace(itmNouveau.Text, "*", "")))) * ((double.Parse(itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].Text)))))), 2)).ToString(), EnumConvert.MODE_ARGENT)));
                    }
                    if ((int.Parse(Droite(txtNoProjSoum.Text, 2)) >= 0) & (int.Parse(Droite(txtNoProjSoum.Text, 2)) <= 19))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PROFIT].Tag = ("RETOUR " + sExtra);
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_DATE_COMMANDE)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_COMMANDE].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_DATE_COMMANDE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, " "));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_DATE_REQUISE)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_REQUISE].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_DATE_REQUISE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, " "));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_NOM_COMMANDE)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NOM_COMMANDE].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_NOM_COMMANDE, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, " "));
                    }
                    if (((itmNouveau.SubItems.Count) > (System.Int32)(I_COL_SOUM_NO_SEQUENTIEL)))
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NO_SEQUENTIEL].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert((System.Int32)I_COL_SOUM_NO_SEQUENTIEL, new System.Windows.Forms.ListViewItem.ListViewSubItem((System.Windows.Forms.ListViewItem)null, " "));
                    }
                    if (itmAncien.SubItems[(System.Int32)I_COL_SOUM_PIECE].ForeColor == COLOR_NOIR)
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_COMMANDE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_REQUISE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DESCR].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_ID].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MONTAGE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NO_SEQUENTIEL].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NOM_COMMANDE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PIECE].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PROFIT].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].ForeColor = (COLOR_NOIR);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TOTAL].ForeColor = (COLOR_NOIR);
                    }
                    else
                    {
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_COMMANDE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DATE_REQUISE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DESCR].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_DISTRIB].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_ESCOMPTE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_ID].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MANUFACT].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_MONTAGE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NO_SEQUENTIEL].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_NOM_COMMANDE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PIECE].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_LIST].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PRIX_NET].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_PROFIT].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TEMPS].ForeColor = (COLOR_BRUN);
                        itmNouveau.SubItems[(System.Int32)I_COL_SOUM_TOTAL].ForeColor = (COLOR_BRUN);
                    }
                    CalculerTempsFabrication();
                    CalculerPrix();
                    fraFournisseur.Visible = false;
                    m_bPieceInutile = false;
                    if (((lvwSoumission.Items.Count) > (0)))
                    {
                        Deselect();
                        lvwSoumission.Items[1].Selected = true;
                    }
                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Quantité trop grande!", Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Erreur");
                }
            }
        }
        private void AjouterDansListViewSoumission(double v, string sSousSection)
        {
            ADODB.Recordset rstConfig;
            int iIndex = 0;
            int X;
            int iIDSection;
            int iTagSection;
            var iIndexSel = default(int);
            ListViewItem itmSoum;
            bool bSelected;
            bool bIndex = false;
            double dblTempsMec;
            string sDistrib;
            string sTauxUSA;
            string sTauxSPA;
            Color lColor;
            bSelected = false;
            if (lvwSoumission.Items.Count > 0)
            {
                if (lvwSoumission.FocusedItem.Index > 1)
                {
                    bSelected = true;
                    iIndexSel = lvwSoumission.FocusedItem.Index;
                }
            }
            if (bSelected == false)
            {
                bIndex = TrouverIndexSection(sSousSection);
            }
            else
            {
                iIndex = iIndexSel;
            }
            rstConfig = new Recordset();
            rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
            sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
            sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
            rstConfig.Close();
            rstConfig = default;
            itmSoum = lvwSoumission.Items.Insert(iIndex, "");
            itmSoum.Checked = true;
            itmSoum.Text = dblQuantite.ToString();
            if (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_QUOTER].Text == "Oui")
            {
                itmSoum.Text = itmSoum.Text + "*";
                itmSoum.ForeColor = COLOR_VERT;
            }
            else { itmSoum.ForeColor = COLOR_NOIR; }
            if (lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT") { lColor = COLOR_MAGENTA; } else { lColor = COLOR_NOIR; }
            itmSoum.Tag = cmbSections.Items[cmbSections.SelectedIndex].ToString();
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text)); }
            itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
            itmSoum.SubItems[I_COL_SOUM_PIECE].Tag = sSousSection;
            if (m_eLangage == EnumLangage.ANGLAIS)
            {
                if (m_bRecherchePiece == true)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text;
                }
                else
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text;
                }
            }
            else
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text)); }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text;
            }
            else
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text)); }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text;
            }
            itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text)); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text)); }
            itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = (cmbSections.SelectedIndex + 1).ToString();
            itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
            if (string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, "0")); }
            }
            else
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxUSA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxUSA), 4).ToString())); }
            }
            else
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxSPA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxSPA), 4).ToString())); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text)); }
            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Tag;
            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor;
            if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text)))
            {
                if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text)); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = 0.ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, 0.ToString())); }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString())); }
                }
                else
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString())); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text)); }
            }
            else
            if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)))
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxUSA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxUSA), 4).ToString())); }
                }
                else
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxSPA), 4).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxSPA), 4).ToString())); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)); }
            }
            else
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, "0")); }
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, "0")); }
            }
            itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor;
            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor;
            if (lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT") { sDistrib = string.Empty; } else { sDistrib = lvwFournisseur.FocusedItem.Text; }
            if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = sDistrib; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, sDistrib)); }
            itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
            itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
            if (m_bRecherchePiece == true)
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = Strings.Replace((string)lvwPieceTrouve.FocusedItem.Tag, ".", ","); } else { itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, Strings.Replace((string)lvwPieceTrouve.FocusedItem.Tag, ".", ","))); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = Strings.Replace((string)lvwPieces.FocusedItem.Tag, ".", ","); } else { itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, Strings.Replace((string)lvwPieces.FocusedItem.Tag, ".", ","))); }
            itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor;
            if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString())); }
            }
            else
            if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
            itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor;
            if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString())); }
            itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
            itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag;
            if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$")); }
            itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor;
            if (string.IsNullOrEmpty(itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text))
            {
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
            }
            CalculerTempsFabrication();
            itmSoum.EnsureVisible();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum;
            string sNumero;
            var sNoProjet = default(string);
            bool bExiste;
            var bProjet = default(bool);
            var bContinuer = default(bool);
            bool bNoValide;
            // Affiche le message de saisie 
            if (m_eType == EnumType.TYPE_PROJET)
            {
                sNumero = Interaction.InputBox("Veuillez entrer le numéro du projet");
            }
            else if (MessageBox.Show("Voulez-vous créer une nouvelle soumission?\nOui - Nouvelle soumission\nNon - Copie d'un projet dans une soumission", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sNumero = Interaction.InputBox("Veuillez entrer le numéro de la soumission");
            }
            else
            {
                sNumero = Interaction.InputBox("Veuillez entrer le numéro de la soumission");
                sNoProjet = Interaction.InputBox("À partir de quel projet voulez-vous créer cette soumission?");
                bProjet = true;
            }
            if (bProjet == true)
            {
                if (!string.IsNullOrEmpty(sNumero) & !string.IsNullOrEmpty(sNoProjet))
                {
                    bContinuer = true;
                }
            }
            else if (!string.IsNullOrEmpty(sNumero))
            {
                bContinuer = true;
            }
            if (bContinuer == true)
            {
                Cursor.Current = Cursors.WaitCursor;
                bNoValide = true;
                if (ValiderFormatNumeroProjSoum(sNumero) == false)
                {
                    bNoValide = false;
                }
                if (bNoValide == true)
                {
                    if (ValiderFormatElectrique(sNumero) == false)
                    {
                        bNoValide = false;
                    }
                }
                if (bNoValide == true)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (ValiderFormatJobSansSoum(sNumero) == false)
                        {
                            bNoValide = false;
                        }
                    }
                    else if (ValiderFormatSoumission(sNumero) == false)
                    {
                        bNoValide = false;
                    }
                }
                if (bNoValide == false)
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }
                sNumero = Strings.UCase(sNumero);
                rstProjSoum = new Recordset();

                rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic);
                if (rstProjSoum.EOF)
                {
                    bExiste = false;
                }
                else
                {
                    bExiste = true;
                    MessageBox.Show("Le numéro " + sNumero + " existe dans les soumissions électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstProjSoum.Close();
                if (bExiste == false)
                {
                    rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        bExiste = false;
                    }
                    else
                    {
                        bExiste = true;
                        MessageBox.Show("Le numéro " + sNumero + " existe dans les projets électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                }
                if (bExiste == false)
                {
                    rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        bExiste = false;
                    }
                    else
                    {
                        bExiste = true;
                        MessageBox.Show("Le numéro " + sNumero + " existe dans les soumissions mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                }
                if (bExiste == false)
                {
                    rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        bExiste = false;
                    }
                    else
                    {
                        bExiste = true;
                        MessageBox.Show("Le numéro " + sNumero + " existe dans les projets mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                }
                // Si le projet ou la soumission n'existe pas
                if (bExiste == false)
                {


                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstProjSoum.EOF)
                    {
                        if (rstProjSoum.Fields["Ouvert"].Value == false)
                        {
                            MessageBox.Show("Ce numéro est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rstProjSoum.Close();
                            rstProjSoum = default;
                            Cursor.Current = Cursors.Default;
                            return;
                        }
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    if (bProjet == false)
                    {
                        InitialiserTempsTaux(true);
                        InitialiserNouveauxTaux();
                        m_sAncienProjSoum = txtNoProjSoum.Text;
                        txtNoProjSoum.Text = sNumero;
                        InitialiserVariables(txtNoProjSoum.Text);
                        BarrerChamps(false);
                        ViderChamps();
                    }
                    else if (VerifierProjet(sNoProjet) == true)
                    {
                        BarrerChamps(false);
                        ViderChamps();
                        txtNoProjSoum.Text = sNumero;
                        RemplirSoumissionProjet(sNumero, sNoProjet);
                    }
                    else
                    {
                        MessageBox.Show("Le projet " + sNoProjet + " n'existe pas!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                    m_sSousSection = string.Empty;
                    m_bModeAjout = true;
                    m_bModeAffichage = false;
                    AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void InitialiserTempsTaux(bool bEmpty)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                string sTable;
                string sChamps;
                m_bTempsDejaOuvert = false;
                if (bEmpty == true)
                {
                    m_sTempsDessin = "0";
                    m_sTempsFabrication = "0";
                    m_sTempsAssemblage = "0";
                    m_sTempsProgInterface = "0";
                    m_sTempsProgAutomate = "0";
                    m_sTempsProgRobot = "0";
                    m_sTempsVision = "0";
                    m_sTempsTest = "0";
                    m_sTempsInstallation = "0";
                    m_sTempsMiseService = "0";
                    m_sTempsFormation = "0";
                    m_sTempsGestion = "0";
                    m_sTempsShipping = "0";
                    m_sNbrePersonne = "0";
                    m_sTempsHebergement = "0";
                    m_sTempsRepas = "0";
                    m_sTempsTransport = "0";
                    m_sTempsUniteMobile = "0";
                    m_sPrixEmballage = "0";
                    m_sTauxHebergement1 = "0";
                    m_sTauxHebergement2 = "0";
                    m_sTauxRepas = "0";
                    m_sTauxTransport = "0";
                    m_sTauxUniteMobile = "0";
                    m_sTauxDessin = "0";
                    m_sTauxFabrication = "0";
                    m_sTauxAssemblage = "0";
                    m_sTauxProgInterface = "0";
                    m_sTauxProgAutomate = "0";
                    m_sTauxProgRobot = "0";
                    m_sTauxVision = "0";
                    m_sTauxTest = "0";
                    m_sTauxInstallation = "0";
                    m_sTauxMiseService = "0";
                    m_sTauxFormation = "0";
                    m_sTauxGestion = "0";
                    m_sTauxShipping = "0";
                }
                else
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        sTable = "ProjetElec";
                        sChamps = "IDProjet";
                    }
                    else
                    {
                        sTable = "SoumissionElec";
                        sChamps = "IDSoumission";
                    }
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (m_eType == EnumType.TYPE_SOUMISSION)
                    {
                        if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull)) { m_sTempsDessin = rstProjSoum.Fields["TempsDessin"].Value; } else { m_sTempsDessin = "0"; }
                        if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull)) { m_sTempsFabrication = rstProjSoum.Fields["TempsFabrication"].Value; } else { m_sTempsFabrication = "0"; }
                        if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull)) { m_sTempsAssemblage = rstProjSoum.Fields["TempsAssemblage"].Value; } else { m_sTempsAssemblage = "0"; }
                        if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull)) { m_sTempsProgInterface = rstProjSoum.Fields["TempsProgInterface"].Value; } else { m_sTempsProgInterface = "0"; }
                        if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull)) { m_sTempsProgAutomate = rstProjSoum.Fields["TempsProgAutomate"].Value; } else { m_sTempsProgAutomate = "0"; }
                        if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull)) { m_sTempsProgRobot = rstProjSoum.Fields["TempsProgRobot"].Value; } else { m_sTempsProgRobot = "0"; }
                        if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull)) { m_sTempsVision = rstProjSoum.Fields["TempsVision"].Value; } else { m_sTempsVision = "0"; }
                        if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull)) { m_sTempsTest = rstProjSoum.Fields["TempsTest"].Value; } else { m_sTempsTest = "0"; }
                        if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull)) { m_sTempsInstallation = rstProjSoum.Fields["TempsInstallation"].Value; } else { m_sTempsInstallation = "0"; }
                        if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull)) { m_sTempsMiseService = rstProjSoum.Fields["TempsMiseService"].Value; } else { m_sTempsMiseService = "0"; }
                        if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull)) { m_sTempsFormation = rstProjSoum.Fields["TempsFormation"].Value; } else { m_sTempsFormation = "0"; }
                        if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull)) { m_sTempsGestion = rstProjSoum.Fields["TempsGestion"].Value; } else { m_sTempsGestion = "0"; }
                        if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull)) { m_sTempsShipping = rstProjSoum.Fields["TempsShipping"].Value; } else { m_sTempsShipping = "0"; }
                    }
                    else
                    {
                        InitialiserTempsReel();
                    }
                    if (!(rstProjSoum.Fields["TauxDessin"].Value is DBNull)) { m_sTauxDessin = rstProjSoum.Fields["TauxDessin"].Value; } else { m_sTauxDessin = "0"; }
                    if (!(rstProjSoum.Fields["TauxFabrication"].Value is DBNull)) { m_sTauxFabrication = rstProjSoum.Fields["TauxFabrication"].Value; } else { m_sTauxFabrication = "0"; }
                    if (!(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull)) { m_sTauxAssemblage = rstProjSoum.Fields["TauxAssemblage"].Value; } else { m_sTauxAssemblage = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull)) { m_sTauxProgInterface = rstProjSoum.Fields["TauxProgInterface"].Value; } else { m_sTauxProgInterface = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull)) { m_sTauxProgAutomate = rstProjSoum.Fields["TauxProgAutomate"].Value; } else { m_sTauxProgAutomate = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull)) { m_sTauxProgRobot = rstProjSoum.Fields["TauxProgRobot"].Value; } else { m_sTauxProgRobot = "0"; }
                    if (!(rstProjSoum.Fields["TauxVision"].Value is DBNull)) { m_sTauxVision = rstProjSoum.Fields["TauxVision"].Value; } else { m_sTauxVision = "0"; }
                    if (!(rstProjSoum.Fields["TauxTest"].Value is DBNull)) { m_sTauxTest = rstProjSoum.Fields["TauxTest"].Value; } else { m_sTauxTest = "0"; }
                    if (!(rstProjSoum.Fields["TauxInstallation"].Value is DBNull)) { m_sTauxInstallation = rstProjSoum.Fields["TauxInstallation"].Value; } else { m_sTauxInstallation = "0"; }
                    if (!(rstProjSoum.Fields["TauxMiseService"].Value is DBNull)) { m_sTauxMiseService = rstProjSoum.Fields["TauxMiseService"].Value; } else { m_sTauxMiseService = "0"; }
                    if (!(rstProjSoum.Fields["TauxFormation"].Value is DBNull)) { m_sTauxFormation = rstProjSoum.Fields["TauxFormation"].Value; } else { m_sTauxFormation = "0"; }
                    if (!(rstProjSoum.Fields["TauxGestion"].Value is DBNull)) { m_sTauxGestion = rstProjSoum.Fields["TauxGestion"].Value; } else { m_sTauxGestion = "0"; }
                    if (!(rstProjSoum.Fields["TauxShipping"].Value is DBNull)) { m_sTauxShipping = rstProjSoum.Fields["TauxShipping"].Value; } else { m_sTauxShipping = "0"; }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        m_sNbrePersonne = "0";
                        m_sTempsHebergement = "0";
                        m_sTempsRepas = "0";
                        m_sTempsTransport = "0";
                        m_sTempsUniteMobile = "0";
                    }
                    else
                    {
                        if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull)) { m_sNbrePersonne = rstProjSoum.Fields["NbrePersonne"].Value; } else { m_sNbrePersonne = "0"; }
                        if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull)) { m_sTempsHebergement = rstProjSoum.Fields["TempsHebergement"].Value; } else { m_sTempsHebergement = "0"; }
                        if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull)) { m_sTempsRepas = rstProjSoum.Fields["TempsRepas"].Value; } else { m_sTempsRepas = "0"; }
                        if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull)) { m_sTempsTransport = rstProjSoum.Fields["TempsTransport"].Value; } else { m_sTempsTransport = "0"; }
                        if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull)) { m_sTempsUniteMobile = rstProjSoum.Fields["TempsUniteMobile"].Value; } else { m_sTempsUniteMobile = "0"; }
                    }
                    if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull)) { m_sPrixEmballage = rstProjSoum.Fields["PrixEmballage"].Value; } else { m_sPrixEmballage = "0"; }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        m_sTauxHebergement1 = "0";
                        m_sTauxHebergement2 = "0";
                        m_sTauxRepas = "0";
                        m_sTauxTransport = "0";
                        m_sTauxUniteMobile = "0";
                    }
                    else
                    {
                        if (!(rstProjSoum.Fields["TauxHebergement1"].Value is DBNull)) { m_sTauxHebergement1 = rstProjSoum.Fields["TauxHebergement1"].Value; } else { m_sTauxHebergement1 = "0"; }
                        if (!(rstProjSoum.Fields["TauxHebergement2"].Value is DBNull)) { m_sTauxHebergement2 = rstProjSoum.Fields["TauxHebergement2"].Value; } else { m_sTauxHebergement2 = "0"; }
                        if (!(rstProjSoum.Fields["TauxRepas"].Value is DBNull)) { m_sTauxRepas = rstProjSoum.Fields["TauxRepas"].Value; } else { m_sTauxRepas = "0"; }
                        if (!(rstProjSoum.Fields["TauxTransport"].Value is DBNull)) { m_sTauxTransport = rstProjSoum.Fields["TauxTransport"].Value; } else { m_sTauxTransport = "0"; }
                        if (!(rstProjSoum.Fields["TauxUniteMobile"].Value is DBNull)) { m_sTauxUniteMobile = rstProjSoum.Fields["TauxUniteMobile"].Value; } else { m_sTauxUniteMobile = "0"; }
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "InitialiserTempsTaux", ex);
            }
        }
        private void InitialiserTempsReel()
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sFilterNoProjet;
                if (Droite(txtNoProjSoum.Text, 2) == "99") { sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "'"; } else { sFilterNoProjet = "NoProjet = '" + txtNoProjSoum.Text + "'"; }
                rstPunch = new Recordset();
                string sql = $"select Type,sum(datediff(minute,heureDébut,heurefin)) as 'Total' from punch where '{sFilterNoProjet}' and HeureFin is not null AND HeureDébut is not null GROUP BY Type";
                rstPunch.Open(sql, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                m_sTempsDessin = "0";
                m_sTempsFabrication = "0";
                m_sTempsAssemblage = "0";
                m_sTempsProgInterface = "0";
                m_sTempsProgAutomate = "0";
                m_sTempsProgRobot = "0";
                m_sTempsVision = "0";
                m_sTempsTest = "0";
                m_sTempsInstallation = "0";
                m_sTempsMiseService = "0";
                m_sTempsFormation = "0";
                m_sTempsGestion = "0";
                m_sTempsShipping = "0";
                Clipboard.SetText(sql);
                while (!rstPunch.EOF)
                {
                    if (!(rstPunch.Fields["Total"].Value is DBNull))
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin": { m_sTempsDessin = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Fabrication": { m_sTempsFabrication = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Assemblage": { m_sTempsAssemblage = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "ProgInterface": { m_sTempsProgInterface = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "ProgAutomate": { m_sTempsProgAutomate = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "ProgRobot": { m_sTempsProgRobot = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Vision": { m_sTempsVision = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Test": { m_sTempsTest = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Installation": { m_sTempsInstallation = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "MiseService": { m_sTempsMiseService = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Formation": { m_sTempsFormation = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Gestion": { m_sTempsGestion = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                            case "Shipping": { m_sTempsShipping = (string)Math.Round(rstPunch.Fields["Total"].Value / 60, 2); break; }
                        }
                    }
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                rstPunch = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElecTemps", "AfficherTempsReels", ex);
            }
        }
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bAjouter = default(bool);
                var bModintier = default(bool);
                var bSupprimer = default(bool);
                var bEnregistrer = default(bool);
                var bAnnuler = default(bool);
                var bFermer = default(bool);
                var bImprimer = default(bool);
                var bCmbClient = default(bool);
                var bCmbContact = default(bool);
                var bCmbProjSoum = default(bool);
                var bCmbTransport = default(bool);
                var bCmbChoix = default(bool);
                var bCmbOuvertFerme = default(bool);
                var bSection = default(bool);
                var bPieces = default(bool);
                var bDate = default(bool);
                var bTexte = default(bool);
                var bCreerProjet = default(bool);
                var bHistorique = default(bool);
                var bCopier = default(bool);
                var bBonCommande = default(bool);
                var bTri = default(bool);
                var bDemande = default(bool);
                var bExtra = default(bool);
                var bCatalogue = default(bool);
                var bBrowseChemin = default(bool);
                var bInutile = default(bool);
                var bMauvaisPrix = default(bool);
                var bRapportFact = default(bool);
                var bDateFacture = default(bool);
                var bSortiMagasin = default(bool);
                var bRetour = default(bool);
                var bForfait = default(bool);
                var bExporter = default(bool);
                var bReception = default(bool);
                var bAnglaisFrancais = default(bool);
                var bRechercheClient = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_MODIF:
                        {
                            bEnregistrer = true; bAnnuler = true; bSection = true; bPieces = true; bTexte = true; bTri = true;
                            if (m_eType == EnumType.TYPE_SOUMISSION | m_eType == EnumType.TYPE_PROJET & txtNoProjSoum.Text.Substring(3, 1) != "3") { bCmbClient = true; bCmbContact = true; bRechercheClient = true; }
                            bCmbTransport = true; bDate = true; bCatalogue = true; bBrowseChemin = true; bMauvaisPrix = true; bForfait = true;
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                bInutile = true;
                                if (g_bModificationReception) { bSortiMagasin = true; }
                                if (g_bModificationFacturation) { bDateFacture = true; }
                            }
                            break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bModintier = true; bFermer = true; bImprimer = true; bCmbProjSoum = true; bCmbChoix = true; bCmbOuvertFerme = true; bHistorique = true; bDemande = true; bExporter = true; bAnglaisFrancais = true; bAjouter = true;
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                bBonCommande = true; bExtra = true;
                                if (g_bModificationRetourMarchandise) { bRetour = true; }
                                if (g_bModificationFacturation) { bRapportFact = true; }
                                if (g_bModificationReception) { bReception = true; }
                                if (m_bSupprimer == true) { bSupprimer = true; }
                            }
                            else
                            {
                                bSupprimer = true; bCopier = true;
                                if (VerintierSiDejaProjet() == false) { bCreerProjet = true; }
                            }
                            break;
                        }
                }
                cmdAjouter.Visible = bAjouter;
                cmdModifier.Visible = bModintier;
                cmdSupprimer.Visible = bSupprimer;
                cmdEnregistrer.Visible = bEnregistrer;
                cmdAnnuler.Visible = bAnnuler;
                cmdFermer.Visible = bFermer;
                cmdImprimer.Visible = bImprimer;
                cmdRapportFACT.Visible = bRapportFact;
                cmdDate.Visible = bDate;
                cmdTexte.Visible = bTexte;
                cmdHistorique.Visible = bHistorique;
                cmdCopier.Visible = bCopier;
                cmdBonCommande.Visible = bBonCommande;
                cmdCreerProjet.Visible = bCreerProjet;
                cmdDemande.Visible = bDemande;
                cmdExtra.Visible = bExtra;
                cmdCatalogue.Visible = bCatalogue;
                cmdBrowse.Visible = bBrowseChemin;
                cmdMaterielInutile.Visible = bInutile;
                cmdMauvaisPrix.Visible = bMauvaisPrix;
                cmdSortieMagasin.Visible = bSortiMagasin;
                cmdRetour.Visible = bRetour;
                cmdForfait.Visible = bForfait;
                cmdEffacerForfait.Visible = bForfait;
                cmdExport.Visible = bExporter;
                cmdReception.Visible = bReception;
                cmdAnglaisFrancais.Visible = bAnglaisFrancais;
                lblDateFacturation.Visible = bDateFacture;
                txtDateFacturation.Visible = bDateFacture;
                cmdDateFacturation.Visible = bDateFacture;
                cmbClient.Visible = bCmbClient;
                txtClient.Visible = !bCmbClient;
                cmbContact.Visible = bCmbContact;
                txtContact.Visible = !bCmbContact;
                cmbTransport.Visible = bCmbTransport;
                txtTransport.Visible = !bCmbTransport;
                cmbOuvertFerme.Visible = bCmbOuvertFerme;
                cmbProjSoum.Visible = bCmbProjSoum;
                txtNoProjSoum.Visible = !bCmbProjSoum;
                lblSections.Visible = bSection;
                cmbSections.Visible = bSection;
                cmdAjouterSection.Visible = bSection;
                lblPiece.Visible = bPieces;
                cmbPieces.Visible = bPieces;
                lvwPieces.Visible = bPieces;
                lblTri.Visible = bTri;
                cmbTri.Visible = bTri;
                cmdTri.Visible = bTri;
                cmdRafraichir.Visible = bTri;
                fraPrix.Visible = m_bDroitPrix;
                cmdRechercherClient.Visible = bRechercheClient;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AfficherControles", ex);
            }
        }
        private bool VerintierSiDejaProjet()
        {
            bool VerintierSiDejaProjetRet = default;
            try
            {
                ADODB.Recordset rstProjet;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF) { VerintierSiDejaProjetRet = true; }
                rstProjet.Close();
                rstProjet = default;
                return VerintierSiDejaProjetRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "VerintierSiDejaProjet", ex); return false;
            }
        }
        private void InitialiserNouveauxTaux()
        {
            try
            {
                ADODB.Recordset rstConfig;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxDessinElec, TauxFabrication, TauxAssemblageElec, TauxProgInterface, TauxProgAutomate, TauxProgRobot, TauxVision, TauxTestElec, TauxInstallationElec," +
                    " TauxMiseService, TauxFormationElec, TauxGestionProjetsElec, TauxShippingElec, Hebergement1, Hebergement2, Repas, Standard, UniteMobile FROM Config"
                    , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstConfig.Fields["TauxDessinElec"].Value is DBNull)) { m_sTauxDessin = rstConfig.Fields["TauxDessinElec"].Value; } else { m_sTauxDessin = "0"; }
                if (!(rstConfig.Fields["TauxFabrication"].Value is DBNull)) { m_sTauxFabrication = rstConfig.Fields["TauxFabrication"].Value; } else { m_sTauxFabrication = "0"; }
                if (!(rstConfig.Fields["TauxAssemblageElec"].Value is DBNull)) { m_sTauxAssemblage = rstConfig.Fields["TauxAssemblageElec"].Value; } else { m_sTauxAssemblage = "0"; }
                if (!(rstConfig.Fields["TauxProgInterface"].Value is DBNull)) { m_sTauxProgInterface = rstConfig.Fields["TauxProgInterface"].Value; } else { m_sTauxProgInterface = "0"; }
                if (!(rstConfig.Fields["TauxProgAutomate"].Value is DBNull)) { m_sTauxProgAutomate = rstConfig.Fields["TauxProgAutomate"].Value; } else { m_sTauxProgAutomate = "0"; }
                if (!(rstConfig.Fields["TauxProgRobot"].Value is DBNull)) { m_sTauxProgRobot = rstConfig.Fields["TauxProgRobot"].Value; } else { m_sTauxProgRobot = "0"; }
                if (!(rstConfig.Fields["TauxVision"].Value is DBNull)) { m_sTauxVision = rstConfig.Fields["TauxVision"].Value; } else { m_sTauxVision = "0"; }
                if (!(rstConfig.Fields["TauxTestElec"].Value is DBNull)) { m_sTauxTest = rstConfig.Fields["TauxTestElec"].Value; } else { m_sTauxTest = "0"; }
                if (!(rstConfig.Fields["TauxInstallationElec"].Value is DBNull)) { m_sTauxInstallation = rstConfig.Fields["TauxInstallationElec"].Value; } else { m_sTauxInstallation = "0"; }
                if (!(rstConfig.Fields["TauxMiseService"].Value is DBNull)) { m_sTauxMiseService = rstConfig.Fields["TauxMiseService"].Value; } else { m_sTauxMiseService = "0"; }
                if (!(rstConfig.Fields["TauxFormationElec"].Value is DBNull)) { m_sTauxFormation = rstConfig.Fields["TauxFormationElec"].Value; } else { m_sTauxFormation = "0"; }
                if (!(rstConfig.Fields["TauxGestionProjetsElec"].Value is DBNull)) { m_sTauxGestion = rstConfig.Fields["TauxGestionProjetsElec"].Value; } else { m_sTauxGestion = "0"; }
                if (!(rstConfig.Fields["TauxShippingElec"].Value is DBNull)) { m_sTauxShipping = rstConfig.Fields["TauxShippingElec"].Value; } else { m_sTauxShipping = "0"; }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    m_sTauxHebergement1 = "0";
                    m_sTauxHebergement2 = "0";
                    m_sTauxRepas = "0";
                    m_sTauxTransport = "0";
                    m_sTauxUniteMobile = "0";
                }
                else
                {
                    m_sTauxHebergement1 = rstConfig.Fields["Hebergement1"].Value;
                    m_sTauxHebergement2 = rstConfig.Fields["Hebergement2"].Value;
                    m_sTauxRepas = rstConfig.Fields["Repas"].Value;
                    m_sTauxTransport = rstConfig.Fields["Standard"].Value;
                    m_sTauxUniteMobile = rstConfig.Fields["UniteMobile"].Value;
                }
                rstConfig.Close();
                rstConfig = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "InitialiserNouveauxTaux", ex);
            }
        }
        private void BarrerChamps(bool bBarrer)
        {
            try
            {
                txtProjet.ReadOnly = bBarrer;
                txtNbreManuel.ReadOnly = bBarrer;
                txtPrixManuel.ReadOnly = bBarrer;
                picApprob.Enabled = !bBarrer;
                txtCheminPhotos.ReadOnly = bBarrer;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "BarrerChamps", ex);
            }
        }
        private void ViderChamps()
        {
            try
            {
                txtClient.Text = string.Empty;
                txtContact.Text = string.Empty;
                txtProjet.Text = string.Empty;
                txtNbreManuel.Text = 0.ToString();
                txtPrixManuel.Text = 0.ToString();
                txtTransport.Text = string.Empty;
                txtPrixReception.Text = "0$";
                txtPrixSoumission.Text = "0$";
                chkCSA.CheckState = CheckState.Unchecked;
                chkCUL.CheckState = CheckState.Unchecked;
                chkUL.CheckState = CheckState.Unchecked;
                chkCUR.CheckState = CheckState.Unchecked;
                chkUR.CheckState = CheckState.Unchecked;
                chkCE.CheckState = CheckState.Unchecked;
                txtPrixTotal.Text = 0.ToString();
                txtProfit.Text = 0.ToString();
                txtDelais.Text = string.Empty;
                txtCommission.Text = 0.ToString();
                txtNoSoumission.Text = string.Empty;
                txtCheminPhotos.Text = string.Empty;
                txtForfait.Text = string.Empty;
                lblForfaitInitiale.Text = string.Empty;
                cmbTransport.SelectedIndex = I_TRANS_FAB_GRANBY;
                cmbClient.SelectedIndex = -1;
                m_bSansTemps = false;
                lblPasTemps.Visible = false;
                tmrTemps.Enabled = false;
                lvwSoumission.Items.Clear();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ViderChamps", ex);
            }
        }
        private bool VerifierProjet(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjet;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                rstProjet.Close();
                rstProjet = default;
                return false;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "VerifierProjet", ex);
                return false;
            }
        }
        private void RemplirSoumissionProjet(string sNoSoumission, string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstConfig;
                bool bVariables;
                bool bTauxHoraire;
                bool bPrixPieces;
                rstProjSoum = new Recordset();
                rstConfig = new Recordset();
                if (MessageBox.Show("Voulez-vous mettre à jour les variables systèmes?\n-  % Profit\n-  % Commission\n-  % Imprévu\n-  $ Pages manuel", "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { bVariables = true; } else { bVariables = false; }
                if (MessageBox.Show("Voulez-vous mettre à jour les taux horaires?", "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bTauxHoraire = true;
                }
                else { bTauxHoraire = false; }
                if (MessageBox.Show("Voulez-vous mettre à jour le prix des pièces?", "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { bPrixPieces = true; } else { bPrixPieces = false; }
                rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                m_bSansTemps = rstProjSoum.Fields["SansTemps"].Value;
                if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull)) { m_sTempsDessin = rstProjSoum.Fields["TempsDessin"].Value; } else { m_sTempsDessin = "0"; }
                if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull)) { m_sTempsFabrication = rstProjSoum.Fields["TempsFabrication"].Value; } else { m_sTempsFabrication = "0"; }
                if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull)) { m_sTempsAssemblage = rstProjSoum.Fields["TempsAssemblage"].Value; } else { m_sTempsAssemblage = "0"; }
                if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull)) { m_sTempsProgInterface = rstProjSoum.Fields["TempsProgInterface"].Value; } else { m_sTempsProgInterface = "0"; }
                if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull)) { m_sTempsProgAutomate = rstProjSoum.Fields["TempsProgAutomate"].Value; } else { m_sTempsProgAutomate = "0"; }
                if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull)) { m_sTempsProgRobot = rstProjSoum.Fields["TempsProgRobot"].Value; } else { m_sTempsProgRobot = "0"; }
                if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull)) { m_sTempsVision = rstProjSoum.Fields["TempsVision"].Value; } else { m_sTempsVision = "0"; }
                if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull)) { m_sTempsTest = rstProjSoum.Fields["TempsTest"].Value; } else { m_sTempsTest = "0"; }
                if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull)) { m_sTempsInstallation = rstProjSoum.Fields["TempsInstallation"].Value; } else { m_sTempsInstallation = "0"; }
                if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull)) { m_sTempsMiseService = rstProjSoum.Fields["TempsMiseService"].Value; } else { m_sTempsMiseService = "0"; }
                if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull)) { m_sTempsFormation = rstProjSoum.Fields["TempsFormation"].Value; } else { m_sTempsFormation = "0"; }
                if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull)) { m_sTempsGestion = rstProjSoum.Fields["TempsGestion"].Value; } else { m_sTempsGestion = "0"; }
                if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull)) { m_sTempsShipping = rstProjSoum.Fields["TempsShipping"].Value; } else { m_sTempsShipping = "0"; }
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (bTauxHoraire == true)
                {
                    if (!(rstConfig.Fields["TauxDessinElec"].Value is DBNull)) { m_sTauxDessin = rstConfig.Fields["TauxDessinElec"].Value; } else { m_sTauxDessin = "0"; }
                    if (!(rstConfig.Fields["TauxFabrication"].Value is DBNull)) { m_sTauxFabrication = rstConfig.Fields["TauxFabrication"].Value; } else { m_sTauxFabrication = "0"; }
                    if (!(rstConfig.Fields["TauxAssemblageElec"].Value is DBNull)) { m_sTauxAssemblage = rstConfig.Fields["TauxAssemblageElec"].Value; } else { m_sTauxAssemblage = "0"; }
                    if (!(rstConfig.Fields["TauxProgInterface"].Value is DBNull)) { m_sTauxProgInterface = rstConfig.Fields["TauxProgInterface"].Value; } else { m_sTauxProgInterface = "0"; }
                    if (!(rstConfig.Fields["TauxProgAutomate"].Value is DBNull)) { m_sTauxProgAutomate = rstConfig.Fields["TauxProgAutomate"].Value; } else { m_sTauxProgAutomate = "0"; }
                    if (!(rstConfig.Fields["TauxProgRobot"].Value is DBNull)) { m_sTauxProgRobot = rstConfig.Fields["TauxProgRobot"].Value; } else { m_sTauxProgRobot = "0"; }
                    if (!(rstConfig.Fields["TauxVision"].Value is DBNull)) { m_sTauxVision = rstConfig.Fields["TauxVision"].Value; } else { m_sTauxVision = "0"; }
                    if (!(rstConfig.Fields["TauxTestElec"].Value is DBNull)) { m_sTauxTest = rstConfig.Fields["TauxTestElec"].Value; } else { m_sTauxTest = "0"; }
                    if (!(rstConfig.Fields["TauxInstallationElec"].Value is DBNull)) { m_sTauxInstallation = rstConfig.Fields["TauxInstallationElec"].Value; } else { m_sTauxInstallation = "0"; }
                    if (!(rstConfig.Fields["TauxMiseService"].Value is DBNull)) { m_sTauxMiseService = rstConfig.Fields["TauxMiseService"].Value; } else { m_sTauxMiseService = "0"; }
                    if (!(rstConfig.Fields["TauxFormationElec"].Value is DBNull)) { m_sTauxFormation = rstConfig.Fields["TauxFormationElec"].Value; } else { m_sTauxFormation = "0"; }
                    if (!(rstConfig.Fields["TauxGestionProjetsElec"].Value is DBNull)) { m_sTauxGestion = rstConfig.Fields["TauxGestionProjetsElec"].Value; } else { m_sTauxGestion = "0"; }
                    if (!(rstConfig.Fields["TauxShippingElec"].Value is DBNull)) { m_sTauxShipping = rstConfig.Fields["TauxShippingElec"].Value; } else { m_sTauxShipping = "0"; }
                }
                else
                {
                    if (!(rstProjSoum.Fields["TauxDessin"].Value is DBNull)) { m_sTauxDessin = rstProjSoum.Fields["TauxDessin"].Value; } else { m_sTauxDessin = "0"; }
                    if (!(rstProjSoum.Fields["TauxFabrication"].Value is DBNull)) { m_sTauxFabrication = rstProjSoum.Fields["TauxFabrication"].Value; } else { m_sTauxFabrication = "0"; }
                    if (!(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull)) { m_sTauxAssemblage = rstProjSoum.Fields["TauxAssemblage"].Value; } else { m_sTauxAssemblage = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull)) { m_sTauxProgInterface = rstProjSoum.Fields["TauxProgInterface"].Value; } else { m_sTauxProgInterface = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull)) { m_sTauxProgAutomate = rstProjSoum.Fields["TauxProgAutomate"].Value; } else { m_sTauxProgAutomate = "0"; }
                    if (!(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull)) { m_sTauxProgRobot = rstProjSoum.Fields["TauxProgRobot"].Value; } else { m_sTauxProgRobot = "0"; }
                    if (!(rstProjSoum.Fields["TauxVision"].Value is DBNull)) { m_sTauxVision = rstProjSoum.Fields["TauxVision"].Value; } else { m_sTauxVision = "0"; }
                    if (!(rstProjSoum.Fields["TauxTest"].Value is DBNull)) { m_sTauxTest = rstProjSoum.Fields["TauxTest"].Value; } else { m_sTauxTest = "0"; }
                    if (!(rstProjSoum.Fields["TauxInstallation"].Value is DBNull)) { m_sTauxInstallation = rstProjSoum.Fields["TauxInstallation"].Value; } else { m_sTauxInstallation = "0"; }
                    if (!(rstProjSoum.Fields["TauxMiseService"].Value is DBNull)) { m_sTauxMiseService = rstProjSoum.Fields["TauxMiseService"].Value; } else { m_sTauxMiseService = "0"; }
                    if (!(rstProjSoum.Fields["TauxFormation"].Value is DBNull)) { m_sTauxFormation = rstProjSoum.Fields["TauxFormation"].Value; } else { m_sTauxFormation = "0"; }
                    if (!(rstProjSoum.Fields["TauxGestion"].Value is DBNull)) { m_sTauxGestion = rstProjSoum.Fields["TauxGestion"].Value; } else { m_sTauxGestion = "0"; }
                    if (!(rstProjSoum.Fields["TauxShipping"].Value is DBNull)) { m_sTauxShipping = rstProjSoum.Fields["TauxShipping"].Value; } else { m_sTauxShipping = "0"; }
                }
                if (bVariables == true)
                {
                    m_sProfit = rstConfig.Fields["ProfitElec"].Value;
                    m_sCommission = rstConfig.Fields["Commission"].Value;
                    m_sImprevue = rstConfig.Fields["Imprévus"].Value;
                }
                else
                {
                    m_sProfit = rstProjSoum.Fields["Profit"].Value;
                    m_sCommission = rstProjSoum.Fields["Commission"].Value;
                    m_sImprevue = rstProjSoum.Fields["Imprevue"].Value;
                }
                rstConfig.Close();
                rstConfig = default;
                txtProjet.Text = rstProjSoum.Fields["Description"].Value;
                txtNbreManuel.Text = rstProjSoum.Fields["NbreManuel"].Value;
                txtPrixManuel.Text = rstProjSoum.Fields["total_manuel"].Value;
                txtTransport.Text = rstProjSoum.Fields["transport"].Value;
                if (!(rstProjSoum.Fields["CheminPhotos"].Value is DBNull))
                {
                    txtCheminPhotos.Text = rstProjSoum.Fields["CheminPhotos"].Value;
                }
                else
                {
                    txtCheminPhotos.Text = string.Empty;
                }
                chkCSA.Checked = (bool)rstProjSoum.Fields["CSA"].Value;
                chkCUL.Checked = (bool)rstProjSoum.Fields["CUL"].Value;
                chkUL.Checked = (bool)rstProjSoum.Fields["UL"].Value;
                chkCUR.Checked = (bool)rstProjSoum.Fields["CUR"].Value;
                chkUR.Checked = (bool)rstProjSoum.Fields["UR"].Value;
                chkCE.Checked = (bool)rstProjSoum.Fields["CE"].Value;
                txtPrixTotal.Text = rstProjSoum.Fields["PrixTotal"].Value;
                txtProfit.Text = rstProjSoum.Fields["total_profit"].Value;
                if (!(rstProjSoum.Fields["Delais"].Value is DBNull)) { txtDelais.Text = rstProjSoum.Fields["Delais"].Value; } else { txtDelais.Text = "0"; }
                txtCommission.Text = rstProjSoum.Fields["total_commission"].Value;
                if (!(rstProjSoum.Fields["MontantForfait"].Value is DBNull))
                {
                    txtForfait.Text = rstProjSoum.Fields["MontantForfait"].Value;
                    if (!(rstProjSoum.Fields["InitialeForfait"].Value is DBNull)) { lblForfaitInitiale.Text = rstProjSoum.Fields["InitialeForfait"].Value; } else { lblForfaitInitiale.Text = ""; }
                }
                else
                {
                    txtForfait.Text = "";
                    lblForfaitInitiale.Text = "";
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                RemplirListViewSoumissionProjet(sNoProjet);
                if (bPrixPieces == true) { UpdatePieces(); }
                m_bModeAffichage = false;
                CalculerPrix();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirProjSoum", ex);
            }
        }
        private void RemplirListViewSoumissionProjet(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstSection;
                ADODB.Recordset rstFRS;
                ListViewItem itmProjSoum;
                bool bPremierEnr;
                var iOrdreSection = default(bool);
                var sSousSection = default(string);
                string sSection;
                Color lColor;
                rstProjSoum = new Recordset();
                rstSection = new Recordset();
                rstFRS = new Recordset();
                lvwSoumission.Items.Clear();
                bPremierEnr = true;
                rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_eLangage == EnumLangage.ANGLAIS) { sSection = "NomSectionEN"; } else { sSection = "NomSectionFR"; } while (!rstProjSoum.EOF)
                {
                    itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    if (bPremierEnr == true)
                    {
                        iOrdreSection = rstProjSoum.Fields["OrdreSection"].Value;
                        sSousSection = rstProjSoum.Fields["SousSection"].Value;
                        rstSection.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstProjSoum.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!(rstSection.Fields[sSection].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstSection.Fields[sSection].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstSection.Fields[sSection].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        ValeurParDefaut(itmProjSoum);
                        rstSection.Close();
                        itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                        if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                        itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                        ValeurParDefaut(itmProjSoum);
                        itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                        bPremierEnr = false;
                    }
                    else
                    if (iOrdreSection != rstProjSoum.Fields["OrdreSection"].Value)
                    {
                        iOrdreSection = rstProjSoum.Fields["OrdreSection"].Value;
                        rstSection.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstProjSoum.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!(rstSection.Fields[sSection].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstSection.Fields[sSection].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstSection.Fields[sSection].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        ValeurParDefaut(itmProjSoum);
                        rstSection.Close();
                        itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                        sSousSection = rstProjSoum.Fields["SousSection"].Value;
                        if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["SousSection"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["SousSection"].Value)); }
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                        ValeurParDefaut(itmProjSoum);
                        itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                        itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    }
                    else
                    if (sSousSection != rstProjSoum.Fields["SousSection"].Value)
                    {
                        sSousSection = rstProjSoum.Fields["SousSection"].Value;
                        if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
                        ValeurParDefaut(itmProjSoum);
                        itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                        itmProjSoum = lvwSoumission.Items.Add(string.Empty);
                    }
                    if (rstProjSoum.Fields["IDFRS"].Value == 0 & rstProjSoum.Fields["NumItem"].Value != "Texte" & rstProjSoum.Fields["NumItem"].Value != "Text")
                    {
                        lColor = COLOR_MAGENTA;
                    }
                    else
                    {
                        lColor = COLOR_NOIR;
                    }
                    itmProjSoum.Tag = rstProjSoum.Fields["IDSection"].Value;
                    if (rstProjSoum.Fields["Visible"].Value == true) { itmProjSoum.Checked = true; } else { itmProjSoum.Checked = false; }
                    if (!(rstProjSoum.Fields["Qté"].Value is DBNull)) { itmProjSoum.Text = rstProjSoum.Fields["Qté"].Value; } else { itmProjSoum.Text = string.Empty; }
                    if (rstProjSoum.Fields["Quoté"].Value == true)
                    {
                        itmProjSoum.Text = itmProjSoum.Text + "*";
                        itmProjSoum.ForeColor = COLOR_VERT;
                        if (!(rstProjSoum.Fields["NumItem"].Value is DBNull))
                        {
                            if (rstProjSoum.Fields["NumItem"].Value == "Texte" | rstProjSoum.Fields["NumItem"].Value == "Text")
                            {
                                if (m_eLangage == EnumLangage.ANGLAIS)
                                {
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = "Text"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Text")); }
                                }
                                else
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = "Texte"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Texte")); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstProjSoum.Fields["NumItem"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["NumItem"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
                        itmProjSoum.SubItems[I_COL_SOUM_PIECE].Tag = rstProjSoum.Fields["SousSection"].Value;
                        if (itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text == "Texte" | itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text == "Text")
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_FR"].Value)); }
                        }
                        else
                        if (m_eLangage == EnumLangage.ANGLAIS)
                        {
                            if (!(rstProjSoum.Fields["DESC_EN"].Value is DBNull))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_EN"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_EN"].Value)); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            if (!(rstProjSoum.Fields["DESC_FR"].Value is DBNull)) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                        }
                        else
                        {
                            if (!(rstProjSoum.Fields["DESC_FR"].Value is DBNull))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = rstProjSoum.Fields["DESC_FR"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["DESC_FR"].Value)); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            if (!(rstProjSoum.Fields["DESC_EN"].Value is DBNull)) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = rstProjSoum.Fields["DESC_EN"].Value; } else { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                        }
                        itmProjSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
                        if (!(rstProjSoum.Fields["Manufact"].Value is DBNull))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = rstProjSoum.Fields["Manufact"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Manufact"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
                        itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = iOrdreSection.ToString();
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_List"].Value)))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = rstProjSoum.Fields["Prix_list"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Prix_list"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor;
                        itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = rstProjSoum.Fields["PrixOrigine"].Value;
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Escompte"].Value)))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = rstProjSoum.Fields["Escompte"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Escompte"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor;
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_net"].Value)))
                        {
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = rstProjSoum.Fields["Prix_net"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Prix_net"].Value)); }
                        }
                        else
                        if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, " ")); }
                        itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor;
                        if (!(rstProjSoum.Fields["IDFRS"].Value is DBNull) & rstProjSoum.Fields["IDFRS"].Value > 0)
                        {
                            if (itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                            {
                                rstFRS.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstProjSoum.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Text = rstFRS.Fields["NomFournisseur"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, rstFRS.Fields["NomFournisseur"].Value)); }
                                itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
                            }
                            else
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                                itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = 0.ToString();
                            }
                            if (!(rstProjSoum.Fields["Temps"].Value is DBNull))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmProjSoum.SubItems[I_COL_SOUM_TEMPS].Text = rstProjSoum.Fields["Temps"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Temps"].Value)); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmProjSoum.SubItems[I_COL_SOUM_TEMPS].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            itmProjSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor;
                            if (!(rstProjSoum.Fields["Temps_total"].Value is DBNull))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].Text = rstProjSoum.Fields["Temps_total"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Temps_total"].Value)); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor;
                            //Prix total
                            if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Prix_total"].Value)))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(rstProjSoum.Fields["Prix_total"].Value, 2) + "$"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(rstProjSoum.Fields["Prix_total"].Value, 2) + "$")); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, " ")); }
                            itmProjSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
                            //Profit
                            if (!string.IsNullOrEmpty(Strings.Trim(rstProjSoum.Fields["Profit_argent"].Value)))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(rstProjSoum.Fields["Profit_Argent"].Value, 2) + "$"; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(rstProjSoum.Fields["Profit_Argent"].Value, 2) + "$")); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, " ")); }
                            itmProjSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor;
                            if (!(rstProjSoum.Fields["Commentaire"].Value is DBNull))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = rstProjSoum.Fields["Commentaire"].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Commentaire"].Value)); }
                            }
                            else
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = lColor;
                            rstProjSoum.MoveNext();
                            lvwSoumission.Refresh();
                        }
                        rstProjSoum.Close();
                        rstProjSoum = default;
                        rstFRS = default;
                        rstSection = default;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirListSoumissionProjet", ex);
            }
        }
        private void UpdatePieces()
        {
            try
            {
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstConfig;
                ListViewItem itmPiece;
                string sTauxUSA;
                string sTauxSPA;
                rstPieceFRS = new Recordset();
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
                sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
                rstConfig.Close();
                rstConfig = default;
                for (int X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, string.Empty, false)))
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            itmPiece = lvwSoumission.Items[X];
                            ValeurParDefaut(itmPiece);
                            if (itmPiece.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmPiece.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                            {
                                rstPieceFRS.Open(Operators.ConcatenateObject("SELECT PRIX_LIST, PRIX_SP, PRIX_NET, ESCOMPTE, DeviseMonétaire FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(itmPiece.SubItems[I_COL_SOUM_PIECE].Text, "'", "''") + "' AND IDFRS = ", itmPiece.SubItems[I_COL_SOUM_DISTRIB].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (!rstPieceFRS.EOF)
                                {
                                    if (!(rstPieceFRS.Fields["PRIX_LIST"].Value is DBNull))
                                    {
                                        if (!string.IsNullOrEmpty(Strings.Trim(rstPieceFRS.Fields["PRIX_LIST"].Value)))
                                        {
                                            if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                                            {
                                                if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                                {
                                                    itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value) / double.Parse(sTauxUSA), 4).ToString() + "$";
                                                }
                                                else
                                                {
                                                    itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Math.Round((double)rstPieceFRS.Fields["PRIX_LIST"].Value / double.Parse(sTauxUSA), 4).ToString() + "$"));
                                                }
                                            }
                                            else
                                            if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA")
                                            {
                                                if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                                {
                                                    itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = Math.Round((double)rstPieceFRS.Fields["PRIX_LIST"].Value / double.Parse(sTauxSPA), 4).ToString() + "$";
                                                }
                                                else
                                                {
                                                    itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Math.Round((double)rstPieceFRS.Fields["PRIX_LIST"].Value / double.Parse(sTauxSPA), 4).ToString() + "$"));
                                                }
                                            }
                                            else
                                            if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                            {
                                                itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = rstPieceFRS.Fields["PRIX_LIST"].Value + "$";
                                            }
                                            else
                                            {
                                                itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["PRIX_LIST"].Value + "$"));
                                            }
                                        }
                                        else
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = "0".ToString() + "$";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, "0"));
                                        }
                                    }
                                    else
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = "0".ToString() + "$";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, "0"));
                                    }
                                    if (!(rstPieceFRS.Fields["PRIX_NET"].Value is DBNull))
                                    {
                                        if (!string.IsNullOrEmpty(rstPieceFRS.Fields["PRIX_NET"].Value))
                                        {
                                            if (rstPieceFRS.Fields["ESCOMPTE"].Value != string.Empty)
                                            {
                                                if (itmPiece.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                                                {
                                                    itmPiece.SubItems[I_COL_SOUM_ESCOMPTE].Text = rstPieceFRS.Fields["Escompte"].Value + "%";
                                                }
                                                else
                                                {
                                                    itmPiece.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Escompte"].Value + "%"));
                                                }
                                            }
                                            if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                            {
                                                itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = rstPieceFRS.Fields["PRIX_NET"].Value + "$";
                                            }
                                            else
                                            {
                                                itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["PRIX_NET"].Value + "$"));
                                            }
                                        }
                                        else
                                        if (!(rstPieceFRS.Fields["PRIX_SP"].Value is DBNull))
                                        {
                                            if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                            {
                                                itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = rstPieceFRS.Fields["PRIX_SP"].Value + "$";
                                            }
                                            else
                                            {
                                                itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["PRIX_SP"].Value + "$"));
                                            }
                                        }
                                        else
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = "";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, ""));
                                        }
                                    }
                                    else
                                    if (!(rstPieceFRS.Fields["PRIX_SP"].Value is DBNull))
                                    {
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = rstPieceFRS.Fields["PRIX_SP"].Value + "$";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["PRIX_SP"].Value + "$"));
                                        }
                                    }
                                    else
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = "";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, ""));
                                    }
                                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                                    {
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString() + "$";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString()));
                                        }
                                    }
                                    else
                                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA")
                                    {
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = Math.Round(double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString() + "$";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString()));
                                        }
                                    }
                                    else
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text = itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text.ToString() + "$";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text));
                                    }
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_TOTAL)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_TOTAL].Text = (double.Parse(Strings.Replace(itmPiece.Text, "*", string.Empty)) * double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit)).ToString();
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmPiece.Text, "*", string.Empty)) * double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit)).ToString()));
                                    }
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_PROFIT)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_PROFIT].Text = (double.Parse(itmPiece.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmPiece.Text, "*", string.Empty))).ToString();
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, (double.Parse(itmPiece.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmPiece.Text, "*", string.Empty))).ToString()));
                                    }
                                    if (string.IsNullOrEmpty(Strings.Trim(itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text)))
                                    {
                                        if (itmPiece.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text = " ";
                                        }
                                        else
                                        {
                                            itmPiece.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                                        }
                                    }
                                    if (!(rstPieceFRS.Fields["PRIX_NET"].Value is DBNull))
                                    {
                                        if (!string.IsNullOrEmpty(Strings.Trim(rstPieceFRS.Fields["PRIX_NET"].Value)))
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Tag = rstPieceFRS.Fields["PRIX_LIST"].Value;
                                        }
                                        else
                                        {
                                            itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Tag = rstPieceFRS.Fields["PRIX_SP"].Value;
                                        }
                                    }
                                    else { itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Tag = rstPieceFRS.Fields["PRIX_SP"].Value; }
                                }
                                else
                                {
                                    MessageBox.Show("Il n'y a pas de prix du fournisseur " + itmPiece.SubItems[I_COL_SOUM_DISTRIB].Text + " pour la pièce " + itmPiece.SubItems[I_COL_SOUM_PIECE].Text + " ou la pièce n'existe plus!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                rstPieceFRS.Close();
                            }
                        }
                    }
                }
                rstPieceFRS = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "UpdatePieces", ex);
            }
        }
        //*****************************************************************************************************************************
        public bool PeutFermer()
        {
            bool PeutFermerRet = default;
            try
            {
                if (m_eMode == EnumMode.MODE_INACTIF) { PeutFermerRet = true; } else { PeutFermerRet = false; }
                return PeutFermerRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "PeutFermer", ex); return false;
            }
        }
        private void ActiverBoutonsGroupe()
        {
            bool g_bModinticationReception = default;
            bool g_bModinticationRetourMarchandise = default;
            bool g_bModinticationCatalogueElec = default;
            bool g_bSuppressionProjets = default;
            bool g_bModinticationBC = default;
            bool g_bAffichageSoumissionsElec = default;
            bool g_bAffichageProjetsElec = default;
            bool g_bModinticationSoumissionsElec = default;
            bool g_bModinticationProjetsElec = default;
            try
            {
                bool bModint;
                if (g_bAffichageProjetsElec)
                {
                    cmbChoix.Visible = true;
                    m_bComboChoix = true;
                    m_eType = EnumType.TYPE_PROJET;
                    bModint = g_bModinticationProjetsElec;
                }
                else
                {
                    cmbChoix.Visible = false;
                    m_bComboChoix = false;
                    if (g_bAffichageProjetsElec)
                    {
                        m_eType = EnumType.TYPE_PROJET;
                        bModint = g_bModinticationProjetsElec;
                    }
                    else
                    {
                        m_eType = EnumType.TYPE_SOUMISSION;
                        bModint = g_bModinticationSoumissionsElec;
                    }
                }
                m_bModintProj = g_bModinticationProjetsElec;
                m_bModintSoum = g_bModinticationSoumissionsElec;
                m_bModintBonCommande = g_bModinticationBC;
                m_bSupprimer = g_bSuppressionProjets;
                cmdAjouter.Enabled = bModint;
                cmdSupprimer.Enabled = bModint;
                cmdModifier.Enabled = bModint;
                cmdCopier.Enabled = bModint;
                cmdCreerProjet.Enabled = bModint;
                cmdBonCommande.Enabled = m_bModintBonCommande;
                cmdImprimer.Enabled = bModint;
                cmdDemande.Enabled = bModint;
                cmdAnglaisFrancais.Enabled = bModint;
                cmdExtra.Enabled = bModint;
                cmdSupprimerFRS.Visible = g_bModinticationCatalogueElec;
                cmdRetour.Enabled = g_bModinticationRetourMarchandise;
                cmdReception.Enabled = g_bModinticationReception;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ActiverBoutonsGroupe", ex);
            }
        }
        private void AfficherProjSoum(string sNoProjSoum)
        {
            try
            {
                m_bPieceInutile = false;
                m_bChangementFRS = false;
                m_bRecherchePiece = false;
                m_bModeAffichage = true;
                ViderChamps();
                RemplirComboProjSoum();
                BarrerChamps(true);
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AfficherProjSoum", ex);
            }
        }
        private void UpdateDescription()
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstPieceElec;
                rstProjSoum = new Recordset();
                rstPieceElec = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET) { rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstProjSoum.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } while (!rstProjSoum.EOF)
                {
                    rstPieceElec.Open("SELECT * FROM CatalogueElec WHERE PIECE = '" + rstProjSoum.Fields["NumItem"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjSoum.Fields["Desc_Fr"].Value = rstPieceElec.Fields["DESC_FR"].Value;
                    rstProjSoum.Fields["Desc_En"].Value = rstPieceElec.Fields["DESC_EN"].Value;
                    rstProjSoum.Update();
                    rstPieceElec.Close();
                    rstProjSoum.MoveNext();
                }
                rstPieceElec = default;
                rstProjSoum.Close();
                rstProjSoum = default;
                RemplirListViewProjSoum(txtNoProjSoum.Text);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "UpdateDescription", ex);
            }
        }
        public void Commande()
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstBC;
                ADODB.Recordset rstFRS;
                var iIDFRS = default(bool);
                string sFRS;
                string sNoBC;
                string sWherePiece;
                string sWhereNoLigne;
                string sWhere;
                var sDateRequise = default(string);
                string sNoLigne;
                bool bPremier;
                bool bPremierNoLigne;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT ProchaineCommande FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstProjet.Fields["ProchaineCommande"].Value is DBNull))
                {
                    rstProjet.Fields["ProchaineCommande"].Value = rstProjet.Fields["ProchaineCommande"].Value + 1;
                    rstProjet.Update();
                }
                rstProjet.Close();
                rstProjet = default;
                sFRS = ViewCommande.lblFournisseur.Text;
                sNoBC = ViewCommande.lblNoBC.Text;
                rstBC = new Recordset();
                rstFRS = new Recordset();
                rstPiece = new Recordset();
                rstBCPiece = new Recordset();
                rstBC.Open("SELECT * FROM BonsCommandes WHERE NoBonCommande = '" + sNoBC + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstBC.EOF)
                {
                    rstFRS.Open("SELECT IDFRS, NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstBC.Fields["NoFournisseur"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstFRS.Fields["NomFournisseur"].Value == sFRS)
                    {
                        iIDFRS = rstFRS.Fields["IDFRS"].Value;
                        sDateRequise = rstBC.Fields["DateRequise"].Value;
                        rstFRS.Close();
                        break;
                    }
                    rstFRS.Close();
                    rstBC.MoveNext();
                }
                rstBC.Close();
                rstBC = default;
                rstFRS = default;
                rstBCPiece.Open("SELECT NoItem, NuméroLigne FROM BonsCommandes_Pieces WHERE NoFournisseur = " + iIDFRS + " AND NoBonCommande = '" + sNoBC + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sWhere = "(IDProjet = '" + txtNoProjSoum.Text + "')";
                sWherePiece = "NumItem In (";
                sWhereNoLigne = "NuméroLigne In (";
                bPremier = true;
                while (!rstBCPiece.EOF)
                {
                    if (!(rstBCPiece.Fields["NoItem"].Value is DBNull))
                    {
                        sNoLigne = rstBCPiece.Fields["NuméroLigne"].Value;
                        if (bPremier == true)
                        {
                            if (Strings.InStr(1, sNoLigne, ",") == 0)
                            {
                                sWherePiece += "'" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'";
                                sWhereNoLigne += rstBCPiece.Fields["NuméroLigne"].Value;
                            }
                            else
                            {
                                bPremierNoLigne = true; while (Strings.InStr(1, sNoLigne, ",") > 0)
                                {
                                    if (bPremierNoLigne == true) { sWherePiece += "'" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'"; sWhereNoLigne += Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1); bPremierNoLigne = false; } else { sWherePiece += ", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'"; sWhereNoLigne += ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1); }
                                    sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1));
                                }
                                if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne))) { sWherePiece += ", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'"; sWhereNoLigne += ", " + sNoLigne; }
                            }
                            bPremier = false;
                        }
                        else
                        if (Strings.InStr(1, sNoLigne, ",") == 0) { sWherePiece += ", '" + rstBCPiece.Fields["NoItem"].Value + "'"; sWhereNoLigne += ", " + rstBCPiece.Fields["NuméroLigne"].Value; }
                        else
                        {
                            while (Strings.InStr(1, sNoLigne, ",") > 0) { sWherePiece += ", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'"; sWhereNoLigne += ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1); sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1)); }
                            if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne))) { sWherePiece += ", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'"; sWhereNoLigne += ", " + sNoLigne; }
                        }
                    }
                    rstBCPiece.MoveNext();
                }
                sWherePiece += ")";
                sWhereNoLigne += ")";
                sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstBCPiece.Close();
                rstBCPiece = default;
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    rstPiece.Fields["Commandé"].Value = true;
                    rstPiece.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    rstPiece.Fields["DateRequise"].Value = sDateRequise;
                    rstPiece.Fields["NomCommande"].Value = IdNomEmploye;
                    rstPiece.Fields["NoSéquentiel"].Value = Droite(sNoBC, 3);
                    rstPiece.Update();
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = default;
                RemplirListViewProjSoum(txtNoProjSoum.Text);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "Commande", ex);
            }
        }
        private void MauvaisPrix()
        {
            try
            {
                if (lvwSoumission.Items.Count > 0)
                {
                    if ((string)lvwSoumission.FocusedItem.SubItems[11].Tag == "EXTRA")
                    {
                        if ((string)lvwSoumission.FocusedItem.Tag != string.Empty)
                        {
                            if (!string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text))
                            {
                                if (lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                                {
                                    if (double.Parse(Strings.Replace(lvwSoumission.FocusedItem.Text, "*", string.Empty)) > 0d)
                                    {
                                        ViderChamps_frs();
                                        RemplirComboFournisseur();
                                        var loopTo = cmbfrs.Items.Count - 1;
                                        for (int X = 0; X <= loopTo; X++)
                                        {
                                            if (cmbfrs.Items[X].ToString() != (string)lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DISTRIB].Tag)
                                            {
                                                cmbfrs.SelectedIndex = X; break;
                                            }
                                        }
                                        cmbfrs.Enabled = true;
                                        fraPrixPiece.Tag = lvwSoumission.FocusedItem.Index;
                                        m_bMauvaisPrix = true;
                                        fraPrixPiece.Visible = true; txtPrixList.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La quantité est déjà dans le négatint!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cette commande doit être faite dans le projet " + lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PROVENANCE].Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "MauvaisPrix", ex);
            }
        }
        private void MaterielInutile()
        {
            var COLOR_ROSE = default(object);
            try
            {
                ListViewItem itmProjet;
                if (lvwSoumission.Items.Count > 0)
                {
                    itmProjet = lvwSoumission.FocusedItem;
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectNotEqual(itmProjet.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_ROSE, false), Operators.ConditionalCompareObjectNotEqual(itmProjet.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BLEU, false))))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmProjet.Tag, string.Empty, false)))
                        {
                            if (!string.IsNullOrEmpty(itmProjet.SubItems[I_COL_SOUM_PIECE].Text))
                            {
                                if (itmProjet.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmProjet.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                                {
                                    if (double.Parse(Strings.Replace(itmProjet.Text, "*", string.Empty)) > 0d)
                                    {
                                        m_bPieceInutile = true; m_bRecherchePiece = false; m_bChangementFRS = false; AfficherListeFournisseurs();
                                        if (lvwFournisseur.Items.Count == 0) { MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; } else { fraFournisseur.Visible = true; }
                                    }
                                    else { MessageBox.Show("La quantité est déjà dans le négatint!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                                }
                            }
                        }
                    }
                    else { MessageBox.Show("Cette commande doit être faite dans le projet " + itmProjet.SubItems[I_COL_SOUM_PROVENANCE].Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "MaterielInutile", ex);
            }
        }
        private void UpdateOrdre()
        {
            try
            {
                ADODB.Recordset rstOrdre;
                ADODB.Recordset rstCount;
                ADODB.Recordset rstSection;
                int X;
                int X2;
                int iIndexCopie;
                var iSection = default(int);
                int iIndex;
                int iNbreSection;
                bool bPremier;
                ListViewItem itmProjSoum;
                string sSection;
                rstOrdre = new Recordset();
                for (X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, string.Empty, false)))
                    {
                        rstOrdre.Open("SELECT Ordre FROM SoumProjSectionElec WHERE IDSection = " + (string)lvwSoumission.Items[X].Tag, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        lvwSoumission.Items[X].SubItems[I_COL_SOUM_MANUFACT].Tag = rstOrdre.Fields["Ordre"].Value;
                        rstOrdre.Close();
                    }
                }
                rstOrdre = default;
                rstCount = new Recordset();
                rstCount.Open("SELECT COUNT(IDSection) as NbreSection FROM SoumProjSectionElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNbreSection = rstCount.Fields["NbreSection"].Value;
                rstCount.Close();
                rstCount = default;
                for (X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if ((string)lvwSoumission.Items[X - iSection].Tag != string.Empty)
                    {
                        lvwSoumission.Items.RemoveAt(X - iSection);
                        iSection++;
                    }
                }
                iIndex = 1;
                rstSection = new Recordset();
                var loopTo2 = iNbreSection;
                for (X = 1; X <= loopTo2; X++)
                {
                    bPremier = true;
                    X2 = iIndex;
                    while (X2 <= lvwSoumission.Items.Count)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X2].SubItems[I_COL_SOUM_MANUFACT].Tag, X, false)))
                        {
                            if (bPremier == true)
                            {
                                itmProjSoum = lvwSoumission.Items.Insert(iIndex, "");
                                ValeurParDefaut(itmProjSoum);
                                if (m_eLangage == EnumLangage.ANGLAIS) { sSection = "NomSectionEN"; } else { sSection = "NomSectionFR"; }
                                rstSection.Open(Operators.ConcatenateObject("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = ", lvwSoumission.Items[X2 + 1].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (!(rstSection.Fields[sSection].Value is DBNull))
                                {
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = rstSection.Fields[sSection].Value; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, rstSection.Fields[sSection].Value)); }
                                }
                                else
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                                rstSection.Close(); iIndex++; X2++; bPremier = false;
                            }
                            itmProjSoum = lvwSoumission.Items.Insert(iIndex, ""); iIndexCopie = X2 + 1; itmProjSoum.Checked = lvwSoumission.Items[iIndexCopie].Checked; itmProjSoum.Text = lvwSoumission.Items[iIndexCopie].Text; itmProjSoum.ForeColor = lvwSoumission.Items[iIndexCopie].ForeColor; itmProjSoum.Tag = lvwSoumission.Items[iIndexCopie].Tag;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PIECE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PIECE].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_PIECE].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PIECE].Tag;
                            itmProjSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PIECE].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmProjSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DESCR].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DESCR].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DESCR].Tag;
                            itmProjSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DESCR].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MANUFACT].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MANUFACT].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MANUFACT].Tag;
                            itmProjSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MANUFACT].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_LIST].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_LIST].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_LIST].Tag;
                            itmProjSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_LIST].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ESCOMPTE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ESCOMPTE].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ESCOMPTE].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_NET].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_NET].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_NET].ForeColor;
                            itmProjSoum.SubItems[I_COL_SOUM_PRIX_NET].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PRIX_NET].Tag;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmProjSoum.SubItems[I_COL_SOUM_TEMPS].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TEMPS].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TEMPS].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TEMPS].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MONTAGE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MONTAGE].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_MONTAGE].ForeColor;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TOTAL].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TOTAL].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TOTAL].ForeColor;
                            itmProjSoum.SubItems[I_COL_SOUM_TOTAL].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_TOTAL].Tag;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROFIT].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROFIT].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROFIT].ForeColor;
                            itmProjSoum.SubItems[I_COL_SOUM_PROFIT].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROFIT].Tag;
                            if (itmProjSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DISTRIB].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DISTRIB].Text)); }
                            itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DISTRIB].Tag;
                            itmProjSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DISTRIB].ForeColor;
                            if (string.IsNullOrEmpty(lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_COMMENTAIRE].Text))
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = " "; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, " ")); }
                            }
                            else
                            {
                                if (itmProjSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE) { itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_COMMENTAIRE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_COMMENTAIRE].Text)); }
                                itmProjSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor;
                            }
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                if (!string.IsNullOrEmpty(itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text) & itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & itmProjSoum.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                                {
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_ID) { itmProjSoum.SubItems[I_COL_SOUM_ID].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ID].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_ID, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ID].Text)); }
                                    itmProjSoum.SubItems[I_COL_SOUM_ID].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_ID].ForeColor;
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_FACTURATION) { itmProjSoum.SubItems[I_COL_SOUM_FACTURATION].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_FACTURATION].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_FACTURATION].Text)); }
                                    if (string.IsNullOrEmpty(lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_FACTURATION].Text)) { itmProjSoum.SubItems[I_COL_SOUM_FACTURATION].Tag = ""; } else { itmProjSoum.SubItems[I_COL_SOUM_FACTURATION].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_FACTURATION].Tag; }
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_DATE_COMMANDE) { itmProjSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_COMMANDE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_COMMANDE].Text)); }
                                    if (!string.IsNullOrEmpty(itmProjSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].Text)) { itmProjSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_COMMANDE].ForeColor; }
                                    itmProjSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_COMMANDE].Tag;
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_DATE_REQUISE) { itmProjSoum.SubItems[I_COL_SOUM_DATE_REQUISE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_REQUISE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_REQUISE].Text)); }
                                    itmProjSoum.SubItems[I_COL_SOUM_DATE_REQUISE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_REQUISE].ForeColor;
                                    itmProjSoum.SubItems[I_COL_SOUM_DATE_REQUISE].Tag = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_DATE_REQUISE].Tag;
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_NOM_COMMANDE) { itmProjSoum.SubItems[I_COL_SOUM_NOM_COMMANDE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NOM_COMMANDE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_NOM_COMMANDE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NOM_COMMANDE].Text)); }
                                    itmProjSoum.SubItems[I_COL_SOUM_NOM_COMMANDE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NOM_COMMANDE].ForeColor;
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_NO_SEQUENTIEL) { itmProjSoum.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_NO_SEQUENTIEL, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text)); }
                                    itmProjSoum.SubItems[I_COL_SOUM_NO_SEQUENTIEL].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_NO_SEQUENTIEL].ForeColor;
                                    if (itmProjSoum.SubItems.Count > I_COL_SOUM_PROVENANCE) { itmProjSoum.SubItems[I_COL_SOUM_PROVENANCE].Text = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROVENANCE].Text; } else { itmProjSoum.SubItems.Insert(I_COL_SOUM_PROVENANCE, new ListViewItem.ListViewSubItem(null, lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROVENANCE].Text)); }
                                    itmProjSoum.SubItems[I_COL_SOUM_PROVENANCE].ForeColor = lvwSoumission.Items[iIndexCopie].SubItems[I_COL_SOUM_PROVENANCE].ForeColor;
                                }
                            }
                            lvwSoumission.Items.RemoveAt(iIndexCopie); lvwSoumission.Refresh(); iIndex++;
                        }
                        X2++;
                    }
                }
                rstSection = default;
                if (lvwSoumission.Items.Count > 0)
                {
                    Deselect();
                    lvwSoumission.Items[1].Selected = true;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "UpdateOrdre", ex);
            }
        }
        private void TransfererSoumDansProjet(string sNoProjet, string sLiaison)
        {
            try
            {
                ADODB.Recordset rstSoum;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSoumPiece;
                ADODB.Recordset rstProjetPiece;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstConfig;
                int X;
                rstSoum = new Recordset();
                rstProjet = new Recordset();
                rstSoumPiece = new Recordset();
                rstProjetPiece = new Recordset();
                rstEmploye = new Recordset();
                rstProjSoum = new Recordset();
                rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstSoumPiece.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + txtNoProjSoum.Text + "' AND Type = 'E' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjetPiece.Open("SELECT * FROM Projet_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjSoum.EOF)
                {
                    rstProjSoum.AddNew();
                    rstProjSoum.Fields["IDProjSoum"].Value = sNoProjet;
                    rstProjSoum.Fields["NoClient"].Value = rstSoum.Fields["IDClient"].Value;
                    rstProjSoum.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today);
                    rstProjSoum.Fields["Description"].Value = rstSoum.Fields["Description"].Value;
                    rstProjSoum.Fields["Ouvert"].Value = true;
                    rstProjSoum.Fields["Type"].Value = "P";
                    rstProjSoum.Update();
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjSoum.Fields["Ouvert"].Value = false;
                rstProjSoum.Update();
                rstProjSoum.Close();
                rstProjSoum = default;
                //On l'ajoute
                rstProjet.AddNew();
                rstProjet.Fields["IDProjet"].Value = sNoProjet;
                rstProjet.Fields["IDSoumission"].Value = rstSoum.Fields["IDSoumission"].Value;
                rstProjet.Fields["IDClient"].Value = rstSoum.Fields["IDClient"].Value;
                rstProjet.Fields["IDContact"].Value = rstSoum.Fields["IDContact"].Value;
                rstProjet.Fields["Description"].Value = rstSoum.Fields["Description"].Value;
                rstProjet.Fields["Panneau_aire"].Value = rstSoum.Fields["Panneau_aire"].Value;
                rstProjet.Fields["panneau_espace"].Value = rstSoum.Fields["panneau_espace"].Value;
                rstProjet.Fields["NbreManuel"].Value = rstSoum.Fields["NbreManuel"].Value;
                rstProjet.Fields["transport"].Value = rstSoum.Fields["transport"].Value;
                rstProjet.Fields["csa"].Value = rstSoum.Fields["csa"].Value;
                rstProjet.Fields["cul"].Value = rstSoum.Fields["cul"].Value;
                rstProjet.Fields["cur"].Value = rstSoum.Fields["cur"].Value;
                rstProjet.Fields["ul"].Value = rstSoum.Fields["ul"].Value;
                rstProjet.Fields["ur"].Value = rstSoum.Fields["ur"].Value;
                rstProjet.Fields["ce"].Value = rstSoum.Fields["ce"].Value;
                rstProjet.Fields["Delais"].Value = rstSoum.Fields["Delais"].Value;
                rstProjet.Fields["Creer"].Value = ConvertDate(DateTime.Today);
                rstProjet.Fields["CheminPhotos"].Value = rstSoum.Fields["CheminPhotos"].Value;
                if (!string.IsNullOrEmpty(sLiaison)) { rstProjet.Fields["LiaisonChargeable"].Value = sLiaison; }
                rstEmploye.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT noEmploye FROM Employés WHERE loginname = '", IdLoginEmploye), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjet.Fields["Creer_Par"].Value = rstEmploye.Fields["noEmploye"].Value;
                rstEmploye.Close();
                rstEmploye = default;
                rstProjet.Fields["TempsDessin"].Value = rstSoum.Fields["TempsDessin"].Value;
                rstProjet.Fields["TempsFabrication"].Value = rstSoum.Fields["TempsFabrication"].Value;
                rstProjet.Fields["TempsAssemblage"].Value = rstSoum.Fields["TempsAssemblage"].Value;
                rstProjet.Fields["TempsProgInterface"].Value = rstSoum.Fields["TempsProgInterface"].Value;
                rstProjet.Fields["TempsProgAutomate"].Value = rstSoum.Fields["TempsProgAutomate"].Value;
                rstProjet.Fields["TempsProgRobot"].Value = rstSoum.Fields["TempsProgRobot"].Value;
                rstProjet.Fields["TempsVision"].Value = rstSoum.Fields["TempsVision"].Value;
                rstProjet.Fields["TempsTest"].Value = rstSoum.Fields["TempsTest"].Value;
                rstProjet.Fields["TempsInstallation"].Value = 0;
                rstProjet.Fields["TempsMiseService"].Value = 0;
                rstProjet.Fields["TempsFormation"].Value = rstSoum.Fields["TempsFormation"].Value;
                rstProjet.Fields["TempsGestion"].Value = rstSoum.Fields["TempsGestion"].Value;
                rstProjet.Fields["TempsShipping"].Value = rstSoum.Fields["TempsShipping"].Value;
                rstConfig = new Recordset();
                if (!(rstSoum.Fields["TauxDessin"].Value is DBNull)) { rstProjet.Fields["TauxDessin"].Value = rstSoum.Fields["TauxDessin"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxDessinElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxDessin"].Value = rstConfig.Fields["TauxDessinElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxFabrication"].Value is DBNull)) { rstProjet.Fields["TauxFabrication"].Value = rstSoum.Fields["TauxFabrication"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxFabrication FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxFabrication"].Value = rstConfig.Fields["TauxFabrication"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxAssemblage"].Value is DBNull)) { rstProjet.Fields["TauxAssemblage"].Value = rstSoum.Fields["TauxAssemblage"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxAssemblageElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxAssemblage"].Value = rstConfig.Fields["TauxAssemblageElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxProgInterface"].Value is DBNull)) { rstProjet.Fields["TauxProgInterface"].Value = rstSoum.Fields["TauxProgInterface"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxProgInterface FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxProgInterface"].Value = rstConfig.Fields["TauxProgInterface"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxProgAutomate"].Value is DBNull)) { rstProjet.Fields["TauxProgAutomate"].Value = rstSoum.Fields["TauxProgAutomate"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxProgAutomate FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxProgAutomate"].Value = rstConfig.Fields["TauxProgAutomate"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxProgRobot"].Value is DBNull)) { rstProjet.Fields["TauxProgRobot"].Value = rstSoum.Fields["TauxProgRobot"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxProgRobot FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxProgRobot"].Value = rstConfig.Fields["TauxProgRobot"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxVision"].Value is DBNull)) { rstProjet.Fields["TauxVision"].Value = rstSoum.Fields["TauxVision"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxVision FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxVision"].Value = rstConfig.Fields["TauxVision"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxTest"].Value is DBNull)) { rstProjet.Fields["TauxTest"].Value = rstSoum.Fields["TauxTest"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxTestElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxTest"].Value = rstConfig.Fields["TauxTestElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxInstallation"].Value is DBNull)) { rstProjet.Fields["TauxInstallation"].Value = rstSoum.Fields["TauxInstallation"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxInstallationElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxInstallation"].Value = rstConfig.Fields["TauxInstallationElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxMiseService"].Value is DBNull)) { rstProjet.Fields["TauxMiseService"].Value = rstSoum.Fields["TauxMiseService"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxMiseService FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxMiseService"].Value = rstConfig.Fields["TauxMiseService"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxFormation"].Value is DBNull)) { rstProjet.Fields["TauxFormation"].Value = rstSoum.Fields["TauxFormation"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxFormationElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxFormation"].Value = rstConfig.Fields["TauxFormationElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxGestion"].Value is DBNull)) { rstProjet.Fields["TauxGestion"].Value = rstSoum.Fields["TauxGestion"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxGestionProjetsElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxGestion"].Value = rstConfig.Fields["TauxGestionProjetsElec"].Value;
                    rstConfig.Close();
                }
                if (!(rstSoum.Fields["TauxShipping"].Value is DBNull)) { rstProjet.Fields["TauxShipping"].Value = rstSoum.Fields["TauxShipping"].Value; }
                else
                {
                    rstConfig.Open("SELECT TauxShippingElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjet.Fields["TauxShipping"].Value = rstConfig.Fields["TauxShippingElec"].Value;
                    rstConfig.Close();
                }
                rstConfig = default;
                rstProjet.Fields["PrixEmballage"].Value = rstSoum.Fields["PrixEmballage"].Value;
                rstProjet.Fields["imprevue"].Value = rstSoum.Fields["imprevue"].Value;
                rstProjet.Fields["commission"].Value = rstSoum.Fields["commission"].Value;
                rstProjet.Fields["Profit"].Value = rstSoum.Fields["Profit"].Value;
                rstProjet.Fields["total_manuel"].Value = rstSoum.Fields["total_manuel"].Value;
                rstProjet.Fields["total_commission"].Value = rstSoum.Fields["total_Commission"].Value;
                rstProjet.Fields["total_profit"].Value = rstSoum.Fields["Total_Profit"].Value;
                rstProjet.Fields["PrixTotal"].Value = rstSoum.Fields["PrixTotal"].Value;
                rstProjet.Fields["total_piece"].Value = rstSoum.Fields["Total_piece"].Value;
                rstProjet.Fields["total_imprevue"].Value = rstSoum.Fields["total_imprevue"].Value;
                rstProjet.Fields["total_temps"].Value = rstSoum.Fields["total_temps"].Value;
                rstProjet.Fields["SansTemps"].Value = rstSoum.Fields["SansTemps"].Value;
                rstProjet.Fields["MontantForfait"].Value = rstSoum.Fields["MontantForfait"].Value;
                rstProjet.Fields["InitialeForfait"].Value = rstSoum.Fields["InitialeForfait"].Value;
                rstProjet.Fields["ProchaineCommande"].Value = 1;
                rstProjet.Update();
                while (!rstSoumPiece.EOF)
                {
                    if (rstSoumPiece.Fields["TransfertJob"].Value == true)
                    {
                        rstProjetPiece.AddNew();
                        rstProjetPiece.Fields["Type"].Value = "E";
                        rstProjetPiece.Fields["IDProjet"].Value = sNoProjet;
                        rstProjetPiece.Fields["IDSection"].Value = rstSoumPiece.Fields["IDSection"].Value;
                        rstProjetPiece.Fields["NumItem"].Value = rstSoumPiece.Fields["NumItem"].Value;
                        rstProjetPiece.Fields["Qté"].Value = rstSoumPiece.Fields["Qté"].Value;
                        rstProjetPiece.Fields["Desc_FR"].Value = rstSoumPiece.Fields["Desc_FR"].Value;
                        rstProjetPiece.Fields["Desc_EN"].Value = rstSoumPiece.Fields["Desc_EN"].Value;
                        rstProjetPiece.Fields["Manufact"].Value = rstSoumPiece.Fields["Manufact"].Value;
                        rstProjetPiece.Fields["Prix_List"].Value = rstSoumPiece.Fields["Prix_list"].Value;
                        rstProjetPiece.Fields["Escompte"].Value = rstSoumPiece.Fields["Escompte"].Value;
                        rstProjetPiece.Fields["Prix_net"].Value = rstSoumPiece.Fields["Prix_net"].Value;
                        rstProjetPiece.Fields["OrdreSection"].Value = rstSoumPiece.Fields["OrdreSection"].Value;
                        rstProjetPiece.Fields["NuméroLigne"].Value = rstSoumPiece.Fields["NuméroLigne"].Value;
                        rstProjetPiece.Fields["IDFRS"].Value = rstSoumPiece.Fields["IDFRS"].Value;
                        rstProjetPiece.Fields["Temps"].Value = rstSoumPiece.Fields["Temps"].Value;
                        rstProjetPiece.Fields["Temps_total"].Value = rstSoumPiece.Fields["Temps_Total"].Value;
                        rstProjetPiece.Fields["Prix_total"].Value = rstSoumPiece.Fields["Prix_Total"].Value;
                        rstProjetPiece.Fields["Profit_argent"].Value = rstSoumPiece.Fields["Profit_argent"].Value;
                        rstProjetPiece.Fields["SousSection"].Value = rstSoumPiece.Fields["SousSection"].Value;
                        rstProjetPiece.Fields["PrixOrigine"].Value = rstSoumPiece.Fields["PrixOrigine"].Value;
                        rstProjetPiece.Fields["Visible"].Value = rstSoumPiece.Fields["Visible"].Value;
                        rstProjetPiece.Fields["Commentaire"].Value = rstSoumPiece.Fields["Commentaire"].Value;
                        rstProjetPiece.Fields["Quoté"].Value = rstSoumPiece.Fields["Quoté"].Value;
                        rstProjetPiece.Fields["Devise"].Value = rstSoumPiece.Fields["Devise"].Value;
                        rstProjetPiece.Update();
                        if (!string.IsNullOrEmpty(sLiaison))
                        {
                            if (Operators.CompareString(Droite(sNoProjet, 2), "60", false) >= 0 & double.Parse(Droite(sNoProjet, 2)) <= 79d) { }
                            else
                            if (double.Parse(Droite(sNoProjet, 2)) >= 80d & double.Parse(Droite(sNoProjet, 2)) <= 98d) { }
                        }
                    }
                    rstSoumPiece.MoveNext();
                }
                m_eType = EnumType.TYPE_PROJET;
                if ((double)rstSoum.Fields["TempsInstallation"].Value > 0d | (double)rstSoum.Fields["TempsMiseService"].Value > 0d)
                {
                    CreerProjetInstallation(Gauche(sNoProjet, 7) + "51");
                }
                rstSoum.Close();
                rstSoum = default;
                rstProjet.Close();
                rstProjet = default;
                rstSoumPiece.Close();
                rstSoumPiece = default;
                rstProjetPiece.Close();
                rstProjetPiece = default;
                CalculerTotalRecordset(sNoProjet);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "TransfererSoumDansProjet", ex);
            }
        }
        private void CreerProjetInstallation(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstSoum;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstConfig;
                int X;
                rstSoum = new Recordset();
                rstProjet = new Recordset();
                rstEmploye = new Recordset();
                rstProjSoum = new Recordset();
                rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjet.EOF)
                {
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        rstProjSoum.AddNew();
                        rstProjSoum.Fields["IDProjSoum"].Value = sNoProjet;
                        rstProjSoum.Fields["NoClient"].Value = rstSoum.Fields["IDClient"].Value;
                        rstProjSoum.Fields["Description"].Value = rstSoum.Fields["Description"].Value;
                        rstProjSoum.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today);
                        rstProjSoum.Fields["Ouvert"].Value = true;
                        rstProjSoum.Fields["Type"].Value = "P";
                        rstProjSoum.Update();
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    rstProjet.AddNew();
                    rstProjet.Fields["IDProjet"].Value = sNoProjet;
                    rstProjet.Fields["IDSoumission"].Value = string.Empty;
                    rstProjet.Fields["IDClient"].Value = rstSoum.Fields["IDClient"].Value;
                    rstProjet.Fields["IDContact"].Value = rstSoum.Fields["IDContact"].Value;
                    rstProjet.Fields["Description"].Value = rstSoum.Fields["Description"].Value;
                    rstProjet.Fields["Panneau_aire"].Value = rstSoum.Fields["Panneau_aire"].Value;
                    rstProjet.Fields["panneau_espace"].Value = rstSoum.Fields["panneau_espace"].Value;
                    rstProjet.Fields["NbreManuel"].Value = rstSoum.Fields["NbreManuel"].Value;
                    rstProjet.Fields["transport"].Value = rstSoum.Fields["transport"].Value;
                    rstProjet.Fields["csa"].Value = rstSoum.Fields["csa"].Value;
                    rstProjet.Fields["cul"].Value = rstSoum.Fields["cul"].Value;
                    rstProjet.Fields["cur"].Value = rstSoum.Fields["cur"].Value;
                    rstProjet.Fields["ul"].Value = rstSoum.Fields["ul"].Value;
                    rstProjet.Fields["ur"].Value = rstSoum.Fields["ur"].Value;
                    rstProjet.Fields["ce"].Value = rstSoum.Fields["ce"].Value;
                    rstProjet.Fields["Delais"].Value = rstSoum.Fields["Delais"].Value;
                    rstProjet.Fields["Creer"].Value = ConvertDate(DateTime.Today);
                    rstProjet.Fields["CheminPhotos"].Value = rstSoum.Fields["CheminPhotos"].Value;
                    rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjet.Fields["Creer_Par"].Value = rstEmploye.Fields["noEmploye"].Value;
                    rstEmploye.Close();
                    rstEmploye = default;
                    rstProjet.Fields["TempsDessin"].Value = 0;
                    rstProjet.Fields["TempsFabrication"].Value = 0;
                    rstProjet.Fields["TempsAssemblage"].Value = 0;
                    rstProjet.Fields["TempsProgInterface"].Value = 0;
                    rstProjet.Fields["TempsProgAutomate"].Value = 0;
                    rstProjet.Fields["TempsProgRobot"].Value = 0;
                    rstProjet.Fields["TempsVision"].Value = 0;
                    rstProjet.Fields["TempsTest"].Value = 0;
                    rstProjet.Fields["TempsInstallation"].Value = rstSoum.Fields["TempsInstallation"].Value;
                    rstProjet.Fields["TempsMiseService"].Value = rstSoum.Fields["TempsMiseService"].Value;
                    rstProjet.Fields["TempsFormation"].Value = 0;
                    rstProjet.Fields["TempsGestion"].Value = 0;
                    rstProjet.Fields["TempsShipping"].Value = 0;
                    rstConfig = new Recordset();
                    if (!(rstSoum.Fields["TauxDessin"].Value is DBNull)) { rstProjet.Fields["TauxDessin"].Value = rstSoum.Fields["TauxDessin"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxDessinElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxDessin"].Value = rstConfig.Fields["TauxDessinElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxFabrication"].Value is DBNull)) { rstProjet.Fields["TauxFabrication"].Value = rstSoum.Fields["TauxFabrication"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxFabrication FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxFabrication"].Value = rstConfig.Fields["TauxFabrication"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxAssemblage"].Value is DBNull)) { rstProjet.Fields["TauxAssemblage"].Value = rstSoum.Fields["TauxAssemblage"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxAssemblageElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxAssemblage"].Value = rstConfig.Fields["TauxAssemblageElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxProgInterface"].Value is DBNull)) { rstProjet.Fields["TauxProgInterface"].Value = rstSoum.Fields["TauxProgInterface"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxProgInterface FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxProgInterface"].Value = rstConfig.Fields["TauxProgInterface"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxProgAutomate"].Value is DBNull)) { rstProjet.Fields["TauxProgAutomate"].Value = rstSoum.Fields["TauxProgAutomate"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxProgAutomate FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxProgAutomate"].Value = rstConfig.Fields["TauxProgAutomate"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxProgRobot"].Value is DBNull)) { rstProjet.Fields["TauxProgRobot"].Value = rstSoum.Fields["TauxProgRobot"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxProgRobot FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxProgRobot"].Value = rstConfig.Fields["TauxProgRobot"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxVision"].Value is DBNull)) { rstProjet.Fields["TauxVision"].Value = rstSoum.Fields["TauxVision"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxVision FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxVision"].Value = rstConfig.Fields["TauxVision"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxTest"].Value is DBNull)) { rstProjet.Fields["TauxTest"].Value = rstSoum.Fields["TauxTest"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxTestElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxTest"].Value = rstConfig.Fields["TauxTestElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxInstallation"].Value is DBNull)) { rstProjet.Fields["TauxInstallation"].Value = rstSoum.Fields["TauxInstallation"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxInstallationElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxInstallation"].Value = rstConfig.Fields["TauxInstallationElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxMiseService"].Value is DBNull)) { rstProjet.Fields["TauxMiseService"].Value = rstSoum.Fields["TauxMiseService"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxMiseService FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxMiseService"].Value = rstConfig.Fields["TauxMiseService"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxFormation"].Value is DBNull)) { rstProjet.Fields["TauxFormation"].Value = rstSoum.Fields["TauxFormation"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxFormationElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxFormation"].Value = rstConfig.Fields["TauxFormationElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxGestion"].Value is DBNull)) { rstProjet.Fields["TauxGestion"].Value = rstSoum.Fields["TauxGestion"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxGestionProjetsElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxGestion"].Value = rstConfig.Fields["TauxGestionProjetsElec"].Value;
                        rstConfig.Close();
                    }
                    if (!(rstSoum.Fields["TauxShipping"].Value is DBNull)) { rstProjet.Fields["TauxShipping"].Value = rstSoum.Fields["TauxShipping"].Value; }
                    else
                    {
                        rstConfig.Open("SELECT TauxShippingElec FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjet.Fields["TauxShipping"].Value = rstConfig.Fields["TauxShippingElec"].Value;
                        rstConfig.Close();
                    }
                    rstConfig = default;
                    rstProjet.Fields["PrixEmballage"].Value = 0;
                    rstProjet.Fields["imprevue"].Value = rstSoum.Fields["imprevue"].Value;
                    rstProjet.Fields["commission"].Value = rstSoum.Fields["commission"].Value;
                    rstProjet.Fields["Profit"].Value = rstSoum.Fields["Profit"].Value;
                    rstProjet.Fields["total_manuel"].Value = rstSoum.Fields["total_manuel"].Value;
                    rstProjet.Fields["total_commission"].Value = rstSoum.Fields["total_Commission"].Value;
                    rstProjet.Fields["total_profit"].Value = rstSoum.Fields["Total_Profit"].Value;
                    rstProjet.Fields["PrixTotal"].Value = rstSoum.Fields["PrixTotal"].Value;
                    rstProjet.Fields["total_piece"].Value = rstSoum.Fields["Total_piece"].Value;
                    rstProjet.Fields["total_imprevue"].Value = rstSoum.Fields["total_imprevue"].Value;
                    rstProjet.Fields["total_temps"].Value = rstSoum.Fields["total_temps"].Value;
                    rstProjet.Fields["SansTemps"].Value = rstSoum.Fields["SansTemps"].Value;
                    rstProjet.Fields["ProchaineCommande"].Value = 1;
                    rstProjet.Update();
                }
                rstSoum.Close();
                rstSoum = default;
                rstProjet.Close();
                rstProjet = default;
                CalculerTotalRecordset(sNoProjet);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CreerProjetInstallation", ex);
            }
        }
        private void ChangerQuantite()
        {
            try
            {
                string sQuantite;
                ListViewItem itmSoum;
                sQuantite = Interaction.InputBox("Quelle est la nouvelle quantité?");
                if (IsNumeric(sQuantite))
                {
                    itmSoum = lvwSoumission.FocusedItem;
                    itmSoum.Text = sQuantite;
                    if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString())); }
                    }
                    else
                    if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL)
                    {
                        itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString();
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString()));
                    }
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT)
                    {
                        itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString();
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString()));
                    }
                    CalculerTempsFabrication();
                    CalculerPrix();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ChangerQuantite", ex);
            }
        }
        private void SortieMagasin()
        {
            try
            {
                Color lColor;
                string sTag;
                if (lvwSoumission.Items.Count > 0)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PROFIT].Tag, "EXTRA", false)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.FocusedItem.Tag, "", false)))
                        {
                            if (!string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text))
                            {
                                if (lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                                {
                                    if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_NOIR, false), Operators.ConditionalCompareObjectEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_GRIS, false))))
                                    {
                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_NOIR, false))) { lColor = COLOR_ORANGE; sTag = Strings.Replace(lvwSoumission.FocusedItem.Text, "*", ""); } else { lColor = COLOR_NOIR; sTag = ""; }
                                        lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor; lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
                                        if (string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_FACTURATION].Text))
                                        {
                                            if (lvwSoumission.FocusedItem.SubItems.Count > I_COL_SOUM_FACTURATION) { lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_FACTURATION].Text = " "; } else { lvwSoumission.FocusedItem.SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, " ")); }
                                        }
                                        lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_FACTURATION].Tag = sTag; lvwSoumission.Refresh(); CalculerPrixReception();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cette commande doit être faite dans le projet " + lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PROVENANCE].Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "SortieMagasin", ex);
            }
        }
        private void PositionnerBoutons()
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "PositionnerBoutons", ex);
            }
        }
        private void AjouterPrix()
        {
            try
            {
                ViderChamps_frs();
                RemplirComboFournisseur();
                cmbfrs.Enabled = false;
                m_bMauvaisPrix = false;
                fraPrixPiece.Top = 500;
                fraPrixPiece.Visible = true;
                fraPrixPiece.Tag = lvwSoumission.FocusedItem.Index;
                cmbfrs.Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterPrix", ex);
            }
        }
        private void ModintierTexte()
        {
            try
            {
                string sTexte;
                sTexte = Interaction.InputBox("Quel est le nouveau texte?", DefaultResponse: lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text);
                if (!string.IsNullOrEmpty(sTexte))
                {
                    if (sTexte.Length > 255) { MessageBox.Show("Le texte ne pas dépasser 255 caractères!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    else
                    if (lvwSoumission.FocusedItem.SubItems.Count > I_COL_SOUM_DESCR) { lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text = sTexte; } else { lvwSoumission.FocusedItem.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sTexte)); }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModintierTexte", ex);
            }
        }
        private void ModintierSousSection()
        {
            try
            {
                string sSousSection;
                string sAncienneSS;
                string sTag;
                int X;
                sSousSection = Interaction.InputBox("Quel est le nouveau nom ?", DefaultResponse: lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text);
                if (sSousSection.Length != 0)
                {
                    sAncienneSS = lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text;
                    if (string.IsNullOrEmpty(sAncienneSS)) { sAncienneSS = S_PAS_SOUS_SECTION; }
                    if (string.IsNullOrEmpty(Strings.Trim(sSousSection)))
                    {
                        sTag = S_PAS_SOUS_SECTION;
                        sSousSection = string.Empty;
                    }
                    else { sTag = sSousSection; }
                    if (lvwSoumission.FocusedItem.SubItems.Count > I_COL_SOUM_DESCR) { lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text = sSousSection; } else { lvwSoumission.FocusedItem.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection)); }
                    for (X = lvwSoumission.FocusedItem.Index + 1; X <= lvwSoumission.Items.Count; X++)
                    {
                        if (lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Tag != sAncienneSS)
                        {
                            lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Tag = sTag;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModintierSousSection", ex);
            }
        }
        private void ChangerFournisseurRetour()
        {
            try
            {
                m_bPieceInutile = true;
                m_bRecherchePiece = false;
                m_bChangementFRS = true;
                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 0)
                {
                    MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else { fraFournisseur.Visible = true; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ChangerFournisseurRetour", ex);
            }
        }
        private void EnleverSelection()
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "EnleverSelection", ex);
            }
        }
        private void RemplirListViewModintications()
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstCreation;
                string sChamps;
                string sTable;
                string sTableCreer;
                ListViewItem itmModint;
                rstProjSoum = new Recordset();
                rstEmploye = new Recordset();
                rstCreation = new Recordset();
                lvwHistorique.Items.Clear();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sChamps = "IDProjet";
                    sTable = "Projet_Modint";
                    sTableCreer = "ProjetElec";
                }
                else
                {
                    sChamps = "IDSoumission";
                    sTable = "Soumission_Modint";
                    sTableCreer = "SoumissionElec";
                }
                rstCreation.Open("SELECT creer, creer_par FROM " + sTableCreer + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                itmModint = lvwHistorique.Items.Add(string.Empty);
                itmModint.Text = "Création";
                itmModint = lvwHistorique.Items.Add(string.Empty);
                rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstCreation.Fields["creer_par"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                itmModint.Text = rstEmploye.Fields["Employe"].Value;
                rstEmploye.Close();
                if (itmModint.SubItems.Count > I_COL_MODIF_DATE) { itmModint.SubItems[I_COL_MODIF_DATE].Text = rstCreation.Fields["creer"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstCreation.Fields["creer"].Value)); }
                if (itmModint.SubItems.Count > I_COL_MODIF_HEURE) { itmModint.SubItems[I_COL_MODIF_HEURE].Text = string.Empty; } else { itmModint.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                rstCreation.Close();
                rstCreation = default;
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModint = 'MODintICATION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModint = lvwHistorique.Items.Add(string.Empty);
                    itmModint.Text = "Modintications";
                    while (!rstProjSoum.EOF)
                    {
                        itmModint = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModint.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModint.SubItems.Count > I_COL_MODIF_DATE) { itmModint.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value)); }
                        if (itmModint.SubItems.Count > I_COL_MODIF_HEURE) { itmModint.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value)); }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModint = 'RECEPTION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModint = lvwHistorique.Items.Add(string.Empty);
                    itmModint.Text = "Réception";
                    while (!rstProjSoum.EOF)
                    {
                        //Ajout des modintications
                        itmModint = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModint.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModint.SubItems.Count > I_COL_MODIF_DATE) { itmModint.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value)); }
                        if (itmModint.SubItems.Count > I_COL_MODIF_HEURE) { itmModint.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value)); }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModint = 'RETOUR' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModint = lvwHistorique.Items.Add(string.Empty);
                    itmModint.Text = "Retour de marchandise";
                    while (!rstProjSoum.EOF)
                    {
                        itmModint = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModint.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModint.SubItems.Count > I_COL_MODIF_DATE) { itmModint.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value)); }
                        if (itmModint.SubItems.Count > I_COL_MODIF_HEURE) { itmModint.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value)); }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM  " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModint = 'FACTURATION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModint = lvwHistorique.Items.Add(string.Empty);
                    itmModint.Text = "Facturation";
                    while (!rstProjSoum.EOF)
                    {
                        itmModint = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModint.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModint.SubItems.Count > I_COL_MODIF_DATE) { itmModint.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value)); }
                        if (itmModint.SubItems.Count > I_COL_MODIF_HEURE) { itmModint.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value)); }
                        if (itmModint.SubItems.Count > I_COL_MODIF_MONTANT) { itmModint.SubItems[I_COL_MODIF_MONTANT].Text = rstProjSoum.Fields["Valeur"].Value; } else { itmModint.SubItems.Insert(I_COL_MODIF_MONTANT, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Valeur"].Value)); }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                rstEmploye = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirListViewModintications", ex);
            }
        }
        private bool VerintierProjet(string sNoProjet)
        {
            bool VerintierProjetRet = default;
            try
            {
                ADODB.Recordset rstProjet;
                bool bExiste;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF) { bExiste = true; } else { bExiste = false; }
                rstProjet.Close();
                rstProjet = default;
                VerintierProjetRet = bExiste;
                return VerintierProjetRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "VerintierProjet", ex);
                return false;
            }
        }
        private void RemplirComboCategoriesPieces()
        {
            try
            {
                ADODB.Recordset rstCatalogueElec;
                cmbPieces.Items.Clear();
                rstCatalogueElec = new Recordset();
                rstCatalogueElec.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstCatalogueElec.EOF)
                {
                    cmbPieces.Items.Add(rstCatalogueElec.Fields["CATEGORIE"].Value);
                    rstCatalogueElec.MoveNext();
                }
                rstCatalogueElec.Close();
                rstCatalogueElec = default;
                if (cmbPieces.Items.Count > 0) { cmbPieces.SelectedIndex = 0; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirComboCategoriesPieces", ex);
            }
        }
        private void RemplirComboContacts()
        {
            try
            {
                ADODB.Recordset rstContact;
                cmbContact.Items.Clear();
                if (cmbClient.SelectedIndex > -1)
                {
                    rstContact = new Recordset();
                    rstContact.Open("SELECT NomContact, IDContact FROM Contact INNER JOIN ContactClient ON Contact.IDContact = ContactClient.NoContact WHERE ContactClient.nomClient = " + cmbClient.Items[cmbClient.SelectedIndex].ToString(), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstContact.EOF)
                    {
                        rstContact.Close();
                        rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE Supprimé = 0", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    while (!rstContact.EOF)
                    {
                        cmbContact.Items.Add($"{rstContact.Fields["NomContact"].Value} - {rstContact.Fields["IDContact"].Value}");
                        rstContact.MoveNext();
                    }
                    rstContact.Close();
                    rstContact = default;
                    if (cmbContact.Items.Count > 0) { cmbContact.SelectedIndex = 0; }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirComboContacts", ex);
            }
        }
        private void RemplirComboSections()
        {
            try
            {
                ADODB.Recordset rstSection;
                string sChamps;
                cmbSections.Items.Clear();
                rstSection = new Recordset();
                rstSection.Open("SELECT * FROM SoumProjSectionElec ORDER BY Ordre", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_eLangage == EnumLangage.ANGLAIS) { sChamps = "NomSectionEN"; } else { sChamps = "NomSectionFR"; } while (!rstSection.EOF)
                {
                    if (!(rstSection.Fields[sChamps].Value is DBNull))
                    {
                        cmbSections.Items.Add(rstSection.Fields[sChamps].Value);
                    }
                    else { cmbSections.Items.Add(string.Empty); }
                    cmbSections.Tag = (int)rstSection.Fields["IDSection"].Value;
                    rstSection.MoveNext();
                }
                rstSection.Close();
                rstSection = default;
                if (cmbSections.Items.Count > 0) { cmbSections.SelectedIndex = 0; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirComboSections", ex);
            }
        }
        private void ImprimerProjSoum(ADODB.Recordset rstProjSoum)
        {
            ADODB.Recordset rstPiece;
            ADODB.Recordset rstPrixSoum;
            ADODB.Recordset rstTemp;
            ADODB.Recordset rstImpProjSoum;
            ADODB.Recordset rstSoum;
            string sOrdreSection;
            int XSoum;
            var sSousSection = default(string);
            string sSousSectionRS;
            double dblTempsDessin;
            double dblTempsFabrication;
            double dblTempsAssemblage;
            double dblTempsProgInterface;
            double dblTempsProgAutomate;
            double dblTempsProgRobot;
            double dblTempsVision;
            double dblTempsTest;
            double dblTempsInstallation;
            double dblTempsMiseService;
            double dblTempsFormation;
            double dblTempsGestion;
            double dblTempsShipping;
            double dblTotalTemps;
            double dblTotalAutre;
            double dblTotalReste;
            var dblTotalHebergement = default(double);
            var dblTotalRepas = default(double);
            double dblTotalTransport;
            double dblTotalUniteMobile;
            string sChampsSection;
            string sNoProjet;
            string sNoSoumission;
            double dblPrixEmballage;
            UpdateSQL("DELETE FROM impression_soumission");
            XSoum = 1;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                rstImpProjSoum = new Recordset();
                rstImpProjSoum.Open("SELECT * FROM impression_soumission", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sOrdreSection = string.Empty;
                rstPiece = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sNoProjet = rstProjSoum.Fields["IDProjet"].Value;
                    if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull)) { sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value; } else { sNoSoumission = string.Empty; }
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' And Type = 'E' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    sNoProjet = string.Empty;
                    sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value;
                    rstPiece.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoSoumission + "' And Type = 'E' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstTemp = new Recordset();
                while (!rstPiece.EOF)
                {
                    sSousSectionRS = rstPiece.Fields["SousSection"].Value;
                    if ((sSousSectionRS ?? "") == S_PAS_SOUS_SECTION) { sSousSectionRS = " "; }
                    if (sOrdreSection != rstPiece.Fields["OrdreSection"].Value)
                    {
                        sOrdreSection = rstPiece.Fields["OrdreSection"].Value;
                        if (m_eLangage == EnumLangage.ANGLAIS) { sChampsSection = "NomSectionEN"; } else { sChampsSection = "NomSectionFR"; }
                        rstTemp.Open("SELECT " + sChampsSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstPiece.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        if (m_eType == EnumType.TYPE_PROJET) { rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet; } else { rstImpProjSoum.Fields["IDSoumission"].Value = sNoSoumission; }
                        if (!(rstTemp.Fields[sChampsSection].Value is DBNull)) { rstImpProjSoum.Fields["NomSection"].Value = rstTemp.Fields[sChampsSection].Value; } else { rstImpProjSoum.Fields["NomSection"].Value = " "; }
                        rstImpProjSoum.Update();
                        XSoum++;
                        rstTemp.Close();
                        sSousSection = rstPiece.Fields["SousSection"].Value;
                        if ((sSousSection ?? "") == S_PAS_SOUS_SECTION | string.IsNullOrEmpty(sSousSection)) { sSousSection = " "; }
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        if (m_eType == EnumType.TYPE_PROJET) { rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet; } else { rstImpProjSoum.Fields["IDSoumission"].Value = sNoSoumission; }
                        rstImpProjSoum.Fields["SousSection"].Value = sSousSection;
                        rstImpProjSoum.Update();
                        XSoum++;
                    }
                    else
                    if ((sSousSection ?? "") != (sSousSectionRS ?? ""))
                    {
                        sSousSection = sSousSectionRS;
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        if (m_eType == EnumType.TYPE_PROJET) { rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet; } else { rstImpProjSoum.Fields["IDSoumission"].Value = sNoSoumission; }
                        rstImpProjSoum.Fields["SousSection"].Value = sSousSectionRS;
                        rstImpProjSoum.Update();
                        XSoum++;
                    }
                    rstImpProjSoum.AddNew();
                    rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                    if (m_eType == EnumType.TYPE_PROJET) { rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet; } else { rstImpProjSoum.Fields["IDSoumission"].Value = sNoSoumission; }
                    rstImpProjSoum.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                    rstImpProjSoum.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                    if (m_eLangage == EnumLangage.ANGLAIS) { rstImpProjSoum.Fields["Description"].Value = rstPiece.Fields["DESC_EN"].Value; } else { rstImpProjSoum.Fields["Description"].Value = rstPiece.Fields["DESC_FR"].Value; }
                    rstImpProjSoum.Fields["MANUFACT"].Value = rstPiece.Fields["MANUFACT"].Value;
                    rstImpProjSoum.Fields["PRIX_NET"].Value = rstPiece.Fields["PRIX_NET"].Value;
                    rstTemp.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstPiece.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstTemp.EOF) { rstImpProjSoum.Fields["NomFournisseur"].Value = rstTemp.Fields["NomFournisseur"].Value; }
                    rstTemp.Close();
                    rstImpProjSoum.Fields["PRIX_TOTAL"].Value = rstPiece.Fields["PRIX_TOTAL"].Value;
                    rstImpProjSoum.Fields["PROFIT_ARGENT"].Value = rstPiece.Fields["PROFIT_ARGENT"].Value;
                    rstImpProjSoum.Fields["NoSéquentiel"].Value = rstPiece.Fields["NoSéquentiel"].Value;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["DateRéception"].Value))) { rstImpProjSoum.Fields["DateReception"].Value = rstPiece.Fields["DateRéception"].Value; } else { rstImpProjSoum.Fields["DateReception"].Value = ""; }
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["DateCommande"].Value))) { rstImpProjSoum.Fields["DateCommande"].Value = rstPiece.Fields["DateCommande"].Value; } else { rstImpProjSoum.Fields["DateCommande"].Value = ""; }
                    }
                    else
                    {
                        rstImpProjSoum.Fields["DateReception"].Value = "";
                        rstImpProjSoum.Fields["DateCommande"].Value = "";
                    }
                    rstImpProjSoum.Update();
                    XSoum++;
                    rstPiece.MoveNext();
                }
                rstImpProjSoum.Close();
                string sProjet;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sProjet = sNoProjet;
                }
                else
                {
                    sProjet = sNoSoumission;
                }
                rstImpProjSoum.Open("SELECT * FROM impression_Soumission WHERE IDSoumission = '" + sProjet + "' ORDER BY NoLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                string sqlstr;
                ADODB.Recordset rstExport = new ADODB.Recordset();
                ///
                //Modintication PWE 2024 Export Soumission vers Excel
                //
                ViewSoumissionElec.DataSource = rstImpProjSoum;
                if (bTrigger == false)
                {
                    bTrigger = true;
                }
                if (MessageBox.Show("Désirez-vous exporter les données dans Excel, SEULEMENT ?", "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlstr = "SELECT impression_soumission.IDSoumission, CDbl([Qté]) AS Quantité, impression_soumission.NumItem, impression_soumission.Description, impression_soumission.Manufact, CDbl([Prix_list]) AS PrixdeListe, CDbl(Left([escompte],Len([escompte])-1)) AS Escomptes, CDbl([Prix_net]) AS prix_nette, impression_soumission.Prix_total - impression_soumission.Profit_Argent AS Prix_Total ,impression_soumission.NomFournisseur, impression_soumission.DateReception , impression_soumission.DateCommande ,  impression_soumission.NoSéquentiel ";
                    sqlstr += "FROM impression_soumission ";
                    sqlstr += "WHERE (((impression_soumission.IDSoumission)='" + sProjet + "') AND ((impression_soumission.NumItem) Is Not Null)) ";
                    sqlstr += "ORDER BY impression_soumission.noligne";
                    rstExport.Open(sqlstr, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ExporterVersExcel(rstExport);
                    Cursor.Current = Cursors.Default;
                    return;
                }
                TraduireImpressionSoumission();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    ViewSoumissionElec.shpCadrePrixReception.Visible = true;
                    ViewSoumissionElec.lblTitrePrixReception.Visible = true;
                    ViewSoumissionElec.lblPrixReception.Visible = true;
                    ViewSoumissionElec.shpCadrePrixSoumission.Visible = true;
                    ViewSoumissionElec.lblTitrePrixSoumission.Visible = true;
                    ViewSoumissionElec.lblPrixSoumission.Visible = true;
                }
                else
                {
                    ViewSoumissionElec.shpCadrePrixReception.Visible = false;
                    ViewSoumissionElec.lblTitrePrixReception.Visible = false;
                    ViewSoumissionElec.lblPrixReception.Visible = false;
                    ViewSoumissionElec.shpCadrePrixSoumission.Visible = false;
                    ViewSoumissionElec.lblTitrePrixSoumission.Visible = false;
                    ViewSoumissionElec.lblPrixSoumission.Visible = false;
                }
                if (MessageBox.Show("Désirez-vous affiche en bas de page ?", "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ViewSoumissionElec.lbldate.Text = ConvertToUSDate(DateTime.Today);
                }
                else
                {
                    ViewSoumissionElec.lbldate.Text = " ";
                }
                if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                {
                    ViewSoumissionElec.lblSoumission.Text = rstProjSoum.Fields["IDSoumission"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblSoumission.Text = string.Empty;
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    ViewSoumissionElec.lblProjet.Text = rstProjSoum.Fields["IDProjet"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblProjet.Text = string.Empty;
                }
                ViewSoumissionElec.lbldescription.Text = rstProjSoum.Fields["Description"].Value;
                rstTemp.Open("SELECT NomClient FROM Client WHERE IDClient = " + rstProjSoum.Fields["IDClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewSoumissionElec.lblclient.Text = rstTemp.Fields["NomClient"].Value;
                rstTemp.Close();
                rstTemp.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstProjSoum.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewSoumissionElec.lblcontact.Text = rstTemp.Fields["NomContact"].Value;
                rstTemp.Close();
                if (!(rstProjSoum.Fields["TauxDessin"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxDessin.Text = rstProjSoum.Fields["TauxDessin"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxDessin.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxFabrication"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxFabrication.Text = rstProjSoum.Fields["TauxFabrication"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxFabrication.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxAssemblage.Text = rstProjSoum.Fields["TauxAssemblage"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxAssemblage.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxProgInterface.Text = rstProjSoum.Fields["TauxProgInterface"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxProgInterface.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxProgAutomate.Text = rstProjSoum.Fields["TauxProgAutomate"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxProgAutomate.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxProgRobot.Text = rstProjSoum.Fields["TauxProgRobot"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxProgRobot.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxVision"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxVision.Text = rstProjSoum.Fields["TauxVision"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxVision.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxTest"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxTest.Text = rstProjSoum.Fields["TauxTest"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxTest.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxInstallation"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxInstallation.Text = rstProjSoum.Fields["TauxInstallation"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxInstallation.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxMiseService"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxMiseService.Text = rstProjSoum.Fields["TauxMiseService"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxMiseService.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxFormation"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxFormation.Text = rstProjSoum.Fields["TauxFormation"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxFormation.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxGestion"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxGestion.Text = rstProjSoum.Fields["TauxGestion"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxGestion.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxShipping"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxShipping.Text = rstProjSoum.Fields["TauxShipping"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxShipping.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsDessinSoum.Text = rstProjSoum.Fields["TempsDessin"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsDessinSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull))
                {
                    if (rstProjSoum.Fields["SansTemps"].Value == false) { ViewSoumissionElec.lblTempsFabricationSoum.Text = rstProjSoum.Fields["TempsFabrication"].Value; }
                    else
                    {
                        ViewSoumissionElec.lblTempsFabricationSoum.Text = "0";
                    }
                }
                else
                {
                    ViewSoumissionElec.lblTempsFabricationSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsAssemblageSoum.Text = rstProjSoum.Fields["TempsAssemblage"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsAssemblageSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsAssemblageSoum.Text = rstProjSoum.Fields["TempsProgInterface"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsAssemblageSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsProgAutomateSoum.Text = rstProjSoum.Fields["TempsProgAutomate"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsProgAutomateSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsProgRobotSoum.Text = rstProjSoum.Fields["TempsProgRobot"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsProgRobotSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsVisionSoum.Text = rstProjSoum.Fields["TempsVision"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsVisionSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsTestSoum.Text = rstProjSoum.Fields["TempsTest"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsTestSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsInstallationSoum.Text = rstProjSoum.Fields["TempsInstallation"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsInstallationSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsMiseServiceSoum.Text = rstProjSoum.Fields["TempsMiseService"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsMiseServiceSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsFormationSoum.Text = rstProjSoum.Fields["TempsFormation"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsFormationSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsGestionSoum.Text = rstProjSoum.Fields["TempsGestion"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsGestionSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTempsShippingSoum.Text = rstProjSoum.Fields["TempsShipping"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTempsShippingSoum.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsDessin"].Value)) { dblTempsDessin = (double)rstProjSoum.Fields["TempsDessin"].Value; }
                    else
                    {
                        dblTempsDessin = 0d;
                    }
                }
                else
                {
                    dblTempsDessin = 0d;
                }
                if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull))
                {
                    if (rstProjSoum.Fields["SansTemps"].Value == false)
                    {
                        if (IsNumeric(rstProjSoum.Fields["TempsFabrication"].Value)) { dblTempsFabrication = (double)rstProjSoum.Fields["TempsFabrication"].Value; } else { dblTempsFabrication = 0d; }
                    }
                    else
                    {
                        dblTempsFabrication = 0d;
                    }
                }
                else
                {
                    dblTempsFabrication = 0d;
                }
                if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsAssemblage"].Value)) { dblTempsAssemblage = (double)rstProjSoum.Fields["TempsAssemblage"].Value; }
                    else
                    {
                        dblTempsAssemblage = 0d;
                    }
                }
                else
                {
                    dblTempsAssemblage = 0d;
                }
                if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsProgInterface"].Value)) { dblTempsProgInterface = (double)rstProjSoum.Fields["TempsProgInterface"].Value; } else { dblTempsProgInterface = 0d; }
                }
                else
                {
                    dblTempsProgInterface = 0d;
                }
                if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsProgAutomate"].Value)) { dblTempsProgAutomate = (double)rstProjSoum.Fields["TempsProgAutomate"].Value; }
                    else
                    {
                        dblTempsProgAutomate = 0d;
                    }
                }
                else
                {
                    dblTempsProgAutomate = 0d;
                }
                if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsProgRobot"].Value)) { dblTempsProgRobot = (double)rstProjSoum.Fields["TempsProgRobot"].Value; }
                    else
                    {
                        dblTempsProgRobot = 0d;
                    }
                }
                else
                {
                    dblTempsProgRobot = 0d;
                }
                if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsVision"].Value)) { dblTempsVision = (double)rstProjSoum.Fields["TempsVision"].Value; }
                    else
                    {
                        dblTempsVision = 0d;
                    }
                }
                else
                {
                    dblTempsVision = 0d;
                }
                if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsTest"].Value)) { dblTempsTest = (double)rstProjSoum.Fields["TempsTest"].Value; }
                    else
                    {
                        dblTempsTest = 0d;
                    }
                }
                else
                {
                    dblTempsTest = 0d;
                }
                if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsInstallation"].Value)) { dblTempsInstallation = (double)rstProjSoum.Fields["TempsInstallation"].Value; }
                    else
                    {
                        dblTempsInstallation = 0d;
                    }
                }
                else
                {
                    dblTempsInstallation = 0d;
                }
                if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsMiseService"].Value)) { dblTempsMiseService = (double)rstProjSoum.Fields["TempsMiseService"].Value; }
                    else
                    {
                        dblTempsMiseService = 0d;
                    }
                }
                else
                {
                    dblTempsMiseService = 0d;
                }
                if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsFormation"].Value)) { dblTempsFormation = (double)rstProjSoum.Fields["TempsFormation"].Value; }
                    else
                    {
                        dblTempsFormation = 0d;
                    }
                }
                else
                {
                    dblTempsFormation = 0d;
                }
                if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsGestion"].Value)) { dblTempsGestion = (double)rstProjSoum.Fields["TempsGestion"].Value; }
                    else
                    {
                        dblTempsGestion = 0d;
                    }
                }
                else
                {
                    dblTempsGestion = 0d;
                }
                if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull))
                {
                    if (IsNumeric(rstProjSoum.Fields["TempsShipping"].Value)) { dblTempsShipping = (double)rstProjSoum.Fields["TempsShipping"].Value; }
                    else
                    {
                        dblTempsShipping = 0d;
                    }
                }
                else
                {
                    dblTempsShipping = 0d;
                }
                dblTotalTemps = dblTempsDessin + dblTempsFabrication + dblTempsAssemblage + dblTempsProgInterface + dblTempsProgAutomate + dblTempsProgRobot + dblTempsVision + dblTempsTest + dblTempsInstallation + dblTempsMiseService + dblTempsFormation + dblTempsGestion + dblTempsShipping;
                ViewSoumissionElec.lblTotalTempsRHSoum.Text = dblTotalTemps.ToString();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    CalculerTempsReelsImpression(rstProjSoum.Fields["IDProjet"].Value);
                }
                //Autres frais
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    ViewSoumissionElec.lblNbrePersonne.Text = "0";
                    ViewSoumissionElec.lblTempsHebergement.Text = "0";
                    ViewSoumissionElec.lblTauxHebergement1.Text = "0";
                    ViewSoumissionElec.lblTauxHebergement2.Text = "0";
                    ViewSoumissionElec.lblTempsRepas.Text = "0";
                    ViewSoumissionElec.lblTauxRepas.Text = "0";
                    ViewSoumissionElec.lblTempsTransport.Text = "0";
                    ViewSoumissionElec.lblTauxTransport.Text = "0";
                    ViewSoumissionElec.lblTempsUniteMobile.Text = "0";
                    ViewSoumissionElec.lblTauxUniteMobile.Text = "0";
                }
                else
                {
                    if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull)) { ViewSoumissionElec.lblNbrePersonne.Text = rstProjSoum.Fields["NbrePersonne"].Value; } else { ViewSoumissionElec.lblNbrePersonne.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull)) { ViewSoumissionElec.lblTempsHebergement.Text = rstProjSoum.Fields["TempsHebergement"].Value; } else { ViewSoumissionElec.lblTempsHebergement.Text = "0"; }
                    if (!(rstProjSoum.Fields["TauxHebergement1"].Value is DBNull)) { ViewSoumissionElec.lblTauxHebergement1.Text = rstProjSoum.Fields["TauxHebergement1"].Value; } else { ViewSoumissionElec.lblTauxHebergement1.Text = "0"; }
                    if (!(rstProjSoum.Fields["TauxHebergement2"].Value is DBNull)) { ViewSoumissionElec.lblTauxHebergement2.Text = rstProjSoum.Fields["TauxHebergement2"].Value; } else { ViewSoumissionElec.lblTauxHebergement2.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull)) { ViewSoumissionElec.lblTempsRepas.Text = rstProjSoum.Fields["TempsRepas"].Value; } else { ViewSoumissionElec.lblTempsRepas.Text = "0"; }
                    if (!(rstProjSoum.Fields["TauxRepas"].Value is DBNull)) { ViewSoumissionElec.lblTauxRepas.Text = rstProjSoum.Fields["TauxRepas"].Value; } else { ViewSoumissionElec.lblTauxRepas.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull)) { ViewSoumissionElec.lblTempsTransport.Text = rstProjSoum.Fields["TempsTransport"].Value; } else { ViewSoumissionElec.lblTempsTransport.Text = "0"; }
                    if (!(rstProjSoum.Fields["TauxTransport"].Value is DBNull)) { ViewSoumissionElec.lblTauxTransport.Text = rstProjSoum.Fields["TauxTransport"].Value; } else { ViewSoumissionElec.lblTauxTransport.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull)) { ViewSoumissionElec.lblTempsUniteMobile.Text = rstProjSoum.Fields["TempsUniteMobile"].Value; } else { ViewSoumissionElec.lblTempsUniteMobile.Text = "0"; }
                    if (!(rstProjSoum.Fields["TauxUniteMobile"].Value is DBNull)) { ViewSoumissionElec.lblTauxUniteMobile.Text = rstProjSoum.Fields["TauxUniteMobile"].Value; }
                    else
                    {
                        ViewSoumissionElec.lblTauxUniteMobile.Text = "0";
                    }
                }
                if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull))
                {
                    ViewSoumissionElec.lblPrixEmballage.Text = rstProjSoum.Fields["PrixEmballage"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblPrixEmballage.Text = "0";
                }
                ViewSoumissionElec.lblPrixManuel.Text = rstProjSoum.Fields["Total_manuel"].Value;
                ViewSoumissionElec.lblTotalTempsAR.Text = rstProjSoum.Fields["total_temps"].Value;
                ViewSoumissionElec.lblTotalPieceAR.Text = rstProjSoum.Fields["total_piece"].Value;
                ViewSoumissionElec.lblProfit.Text = $"{(rstProjSoum.Fields["profit"].Value - 1) * 100}";
                ViewSoumissionElec.lblTotalProfit.Text = rstProjSoum.Fields["total_profit"].Value;
                ViewSoumissionElec.lblImprevue.Text = rstProjSoum.Fields["imprevue"].Value;
                ViewSoumissionElec.lblImprevueAR.Text = rstProjSoum.Fields["total_imprevue"].Value;
                ViewSoumissionElec.lblCommission.Text = rstProjSoum.Fields["commission"].Value;
                ViewSoumissionElec.lblcommissionAR.Text = rstProjSoum.Fields["total_commission"].Value;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (!(rstProjSoum.Fields["PrixRéception"].Value is DBNull)) { ViewSoumissionElec.lblPrixReception.Text = rstProjSoum.Fields["PrixRéception"].Value; } else { ViewSoumissionElec.lblPrixReception.Text = 0.ToString() + "$"; }
                    if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstPrixSoum = new Recordset();
                        rstPrixSoum.Open("SELECT PrixTotal FROM SoumissionElec WHERE IDSoumission = '" + rstProjSoum.Fields["IDSoumission"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstPrixSoum.EOF)
                        {
                            if (!(rstPrixSoum.Fields["PrixTotal"].Value is DBNull)) { ViewSoumissionElec.lblPrixSoumission.Text = rstPrixSoum.Fields["PrixTotal"].Value; } else { ViewSoumissionElec.lblPrixSoumission.Text = "0$"; }
                        }
                        else
                        {
                            ViewSoumissionElec.lblPrixSoumission.Text = "0$";
                        }
                        rstPrixSoum.Close();
                        rstPrixSoum = default;
                    }
                    else
                    {
                        ViewSoumissionElec.lblPrixSoumission.Text = "0$";
                    }
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    dblTotalHebergement = 0d;
                    dblTotalRepas = 0d;
                    dblTotalTransport = 0d;
                    dblTotalUniteMobile = 0d;
                }
                else
                {
                    if (!(rstProjSoum.Fields["TotalHebergement"].Value is DBNull)) { dblTotalHebergement = rstProjSoum.Fields["TotalHebergement"].Value; }
                    if (!(rstProjSoum.Fields["TotalRepas"].Value is DBNull)) { dblTotalRepas = rstProjSoum.Fields["TotalRepas"].Value; }
                    if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull) & !(rstProjSoum.Fields["TauxTransport"].Value is DBNull)) { dblTotalTransport = (double)rstProjSoum.Fields["TempsTransport"].Value * (double)rstProjSoum.Fields["TauxTransport"].Value; } else { dblTotalTransport = 0d; }
                    if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull) & !(rstProjSoum.Fields["TauxUniteMobile"].Value is DBNull)) { dblTotalUniteMobile = (double)rstProjSoum.Fields["TempsUniteMobile"].Value * (double)rstProjSoum.Fields["TauxUniteMobile"].Value; }
                    else
                    {
                        dblTotalUniteMobile = 0d;
                    }
                }
                if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull))
                {
                    dblPrixEmballage = double.Parse(Strings.Replace(rstProjSoum.Fields["PrixEmballage"].Value, ".", ","));
                }
                else
                {
                    dblPrixEmballage = 0d;
                }
                dblTotalReste = dblTotalHebergement + dblTotalRepas + dblTotalTransport + dblTotalUniteMobile + dblPrixEmballage;
                dblTotalAutre = dblTotalReste + (double)rstProjSoum.Fields["total_manuel"].Value;
                ViewSoumissionElec.lblAutre.Text = dblTotalAutre.ToString() + "$";
                ViewSoumissionElec.lblGrandTotalAR.Text = rstProjSoum.Fields["prixtotal"].Value;
                if (rstProjSoum.Fields["MontantForfait"].Value != "")
                {
                    ViewSoumissionElec.shpCadreForfait.Visible = true;
                    ViewSoumissionElec.lblTitreForfait.Visible = true;
                    ViewSoumissionElec.lblForfait.Visible = true;
                    ViewSoumissionElec.lblTitreForfait.Text = ViewSoumissionElec.lblTitreForfait.Text + " ( " + rstProjSoum.Fields["InitialeForfait"].Value + " )";
                    ViewSoumissionElec.lblForfait.Text = rstProjSoum.Fields["MontantForfait"].Value;
                }
                else
                {
                    ViewSoumissionElec.shpCadreForfait.Visible = false;
                    ViewSoumissionElec.lblTitreForfait.Visible = false;
                    ViewSoumissionElec.lblForfait.Visible = false;
                }
                ViewSoumissionElec.Orientation = false;
                ViewSoumissionElec f = new ViewSoumissionElec();
                f.Show();
                rstImpProjSoum.Close();
                rstImpProjSoum = default;
                rstTemp = default;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ImprimerProjSoum", ex);
            }
        }
        private void ImprimerListePieces(ADODB.Recordset rstProjSoum)
        {
            var rptOrientPortrait = default(object);
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstTemp;
                ADODB.Recordset rstImpListePiece;
                int XPiece;
                string sSousSection;
                string sSection;
                string sNoProjet;
                string sNoSoumission;
                bool bAjouterSection;
                bool bAjouterSousSection;
                bool bAjouterPiece;
                rstPiece = new Recordset();
                rstTemp = new Recordset();
                rstImpListePiece = new Recordset();
                UpdateSQL("DELETE FROM impression_listepiece");
                XPiece = 1;
                Cursor.Current = Cursors.WaitCursor;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sNoProjet = rstProjSoum.Fields["IDProjet"].Value;
                    if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull)) { sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value; } else { sNoSoumission = string.Empty; }
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'E' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    sNoProjet = string.Empty;
                    sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value;
                    rstPiece.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoSoumission + "' AND Type = 'E' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstPiece.EOF)
                {
                    if (rstPiece.Fields["Visible"].Value == true)
                    {
                        bAjouterSection = true;
                        bAjouterSousSection = true;
                        bAjouterPiece = true;
                        rstImpListePiece.CursorLocation = CursorLocationEnum.adUseClient;
                        rstImpListePiece.Open("SELECT * FROM Impression_ListePiece WHERE IDSection = '" + rstPiece.Fields["IDSection"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstImpListePiece.EOF)
                        {
                            bAjouterSection = false;
                            while (!rstImpListePiece.EOF)
                            {
                                if (rstImpListePiece.Fields["NomSousSection"].Value == rstPiece.Fields["SousSection"].Value)
                                {
                                    bAjouterSousSection = false;
                                    if (rstPiece.Fields["NumItem"].Value != "Texte" & rstPiece.Fields["NumItem"].Value != "Text")
                                    {
                                        if (rstImpListePiece.Fields["NumItem"].Value == rstPiece.Fields["NumItem"].Value)
                                        {
                                            bAjouterPiece = false; rstImpListePiece.Fields["Qté"].Value = Strings.Replace(((double)rstImpListePiece.Fields["Qté"].Value + (double)rstPiece.Fields["Qté"].Value).ToString(), ".", ",");
                                            if (!(rstImpListePiece.Fields["ID"].Value is DBNull))
                                            {
                                                if (rstImpListePiece.Fields["ID"].Value != "")
                                                {
                                                    rstImpListePiece.Fields["ID"].Value = rstImpListePiece.Fields["ID"].Value + ", " + rstPiece.Fields["ID"].Value;
                                                }
                                                else
                                                {
                                                    rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value;
                                                }
                                            }
                                            else
                                            {
                                                rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value;
                                            }
                                            rstImpListePiece.Update();
                                            if (rstImpListePiece.Fields["Qté"].Value == 0)
                                            {
                                                rstImpListePiece.Delete(); rstImpListePiece.Filter = "NomSousSection = '" + Strings.Replace(rstPiece.Fields["SousSection"].Value, "'", "''") + "'";
                                                if (rstImpListePiece.RecordCount == 1)
                                                {
                                                    rstImpListePiece.Delete();
                                                    rstImpListePiece.Filter = "IDSection = '" + rstPiece.Fields["IDSection"].Value + "'";
                                                    if (rstImpListePiece.RecordCount == 1)
                                                    {
                                                        rstImpListePiece.Delete();
                                                    }
                                                }
                                                rstImpListePiece.Filter = "";
                                            }
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                rstImpListePiece.MoveNext();
                                if (bAjouterSection == true)
                                {
                                    if (m_eLangage == EnumLangage.ANGLAIS)
                                    {
                                        sSection = "NomSectionEN";
                                    }
                                    else
                                    {
                                        sSection = "NomSectionFR";
                                    }
                                    rstTemp.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstPiece.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    rstImpListePiece.AddNew();
                                    rstImpListePiece.Fields["NoLigne"].Value = XPiece;
                                    rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                                    if (!(rstTemp.Fields[sSection].Value is DBNull))
                                    {
                                        rstImpListePiece.Fields["Section"].Value = rstTemp.Fields[sSection].Value;
                                    }
                                    else
                                    {
                                        rstImpListePiece.Fields["Section"].Value = " ";
                                    }
                                    rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                                    rstImpListePiece.Update();
                                    XPiece++;
                                    rstTemp.Close();
                                }
                                if (bAjouterSousSection == true)
                                {
                                    sSousSection = rstPiece.Fields["SousSection"].Value;
                                    if ((sSousSection ?? "") == S_PAS_SOUS_SECTION)
                                    {
                                        sSousSection = " ";
                                    }
                                    rstImpListePiece.AddNew();
                                    rstImpListePiece.Fields["NoLigne"].Value = XPiece;
                                    rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                                    rstImpListePiece.Fields["SousSection"].Value = sSousSection;
                                    rstImpListePiece.Fields["NomSousSection"].Value = rstPiece.Fields["SousSection"].Value; rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value; rstImpListePiece.Update(); XPiece++;
                                }
                                if (bAjouterPiece == true)
                                {
                                    rstImpListePiece.AddNew();
                                    rstImpListePiece.Fields["NoLigne"].Value = XPiece;
                                    rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                                    rstImpListePiece.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                                    rstImpListePiece.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                                    if (m_eLangage == EnumLangage.ANGLAIS)
                                    {
                                        rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_EN"].Value;
                                    }
                                    else
                                    {
                                        rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_FR"].Value;
                                    }
                                    rstImpListePiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                                    if (m_eType == EnumType.TYPE_PROJET) { rstImpListePiece.Fields["ID"].Value = rstPiece.Fields["ID"].Value; }
                                    rstImpListePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                                    rstImpListePiece.Fields["NomSousSection"].Value = rstPiece.Fields["SousSection"].Value;
                                    rstImpListePiece.Update();
                                    XPiece++;
                                }
                                rstImpListePiece.Close();
                            }
                        }
                        rstPiece.MoveNext();
                    }
                    rstImpListePiece.CursorLocation = CursorLocationEnum.adUseClient;
                    rstImpListePiece.Open("SELECT * FROM impression_Listepiece WHERE TRIM(IDSoumission) = '" + Strings.Trim(sNoSoumission) + "' ORDER BY noligne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.DataSource = rstImpListePiece;
                    TraduireImpressionListePiece();
                    ViewListePiece.lblDate.Text = ConvertDate(DateTime.Today);
                    ViewListePiece.lblProjet.Text = sNoProjet;
                    ViewListePiece.lblsoumission.Text = sNoSoumission;
                    ViewListePiece.lbldescription.Text = rstProjSoum.Fields["Description"].Value;
                    rstTemp.Open("SELECT NomClient FROM Client WHERE IDClient = " + rstProjSoum.Fields["IDClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.lblClient = rstTemp.Fields["NomClient"].Value;
                    rstTemp.Close();
                    rstTemp.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstProjSoum.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.lblContact = rstTemp.Fields["nomcontact"].Value;
                    rstTemp.Close();
                    ViewListePiece.Orientation = false;
                    rstImpListePiece.Close();
                    rstImpListePiece = default;
                    rstTemp = default;
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ImprimerListePieces", ex);
            }
        }
        private void CalculerTempsReelsImpression(string sNoProjet)
        {
            try
            {
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                string sFilterNoProjet = string.Empty;
                if (Droite(sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + sNoProjet + "'";
                }
                SqlDataReader rstTotal = new SqlCommand($"SELECT * FROM PUNCH WHERE {sFilterNoProjet}  HEUREFIN !='' AND HEUREDÉBUT !='' ORDER BY TYPE,DATE", sql).ExecuteReader();
                while (rstTotal.Read())
                {
                    string[] debut = rstTotal["HeureDébut"].ToString().Split(':');
                    double sDateDebut = double.Parse(debut[0]) * 24 + double.Parse(debut[1]);
                    string[] fin = rstTotal["HeureFin"].ToString().Split(':');
                    double sDateFin = double.Parse(fin[0]) * 24 + double.Parse(fin[1]);
                    double sTotal = sDateFin - sDateDebut;
                }
                double stotal = 0d;
                ViewSoumissionElec.lblTempsDessinReel.Text = "0";
                ViewSoumissionElec.lblTempsFabricationReel.Text = "0";
                ViewSoumissionElec.lblTempsAssemblageReel.Text = "0";
                ViewSoumissionElec.lblTempsProgInterfaceReel.Text = "0";
                ViewSoumissionElec.lblTempsProgAutomateReel.Text = "0";
                ViewSoumissionElec.lblTempsProgRobotReel.Text = "0";
                ViewSoumissionElec.lblTempsVisionReel.Text = "0";
                ViewSoumissionElec.lblTempsTestReel.Text = "0";
                ViewSoumissionElec.lblTempsInstallationReel.Text = "0";
                ViewSoumissionElec.lblTempsMiseServiceReel.Text = "0";
                ViewSoumissionElec.lblTempsFormationReel.Text = "0";
                ViewSoumissionElec.lblTempsGestionReel.Text = "0";
                ViewSoumissionElec.lblTempsShippingReel.Text = "0";
                while (rstTotal.Read())
                {
                    if (rstTotal["Total"].ToString() != string.Empty)
                    {
                        switch (rstTotal["Type"].ToString())
                        {
                            case "Dessin": { ViewSoumissionElec.lblTempsDessinReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Fabrication": { ViewSoumissionElec.lblTempsFabricationReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Assemblage": { ViewSoumissionElec.lblTempsAssemblageReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "ProgInterface": { ViewSoumissionElec.lblTempsProgInterfaceReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "ProgAutomate": { ViewSoumissionElec.lblTempsProgAutomateReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "ProgRobot": { ViewSoumissionElec.lblTempsProgRobotReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Vision": { ViewSoumissionElec.lblTempsVisionReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Test": { ViewSoumissionElec.lblTempsTestReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Installation": { ViewSoumissionElec.lblTempsInstallationReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "MiseService": { ViewSoumissionElec.lblTempsMiseServiceReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Formation": { ViewSoumissionElec.lblTempsFormationReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Gestion": { ViewSoumissionElec.lblTempsGestionReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                            case "Shipping": { ViewSoumissionElec.lblTempsShippingReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString(); break; }
                        }
                    }
                }
                rstTotal.Close();
                rstTotal = new SqlCommand("SELECT * FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null", sql).ExecuteReader();
                if (rstTotal["Total"].ToString() != string.Empty)
                {
                    ViewSoumissionElec.lblTotalTempsRHReel.Text = Math.Round((double)rstTotal["Total"], 2).ToString();
                }
                else
                {
                    ViewSoumissionElec.lblTotalTempsRHReel.Text = "0";
                }
                rstTotal.Close();
                rstTotal = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerTempsReels", ex);
            }
        }
        private void ImprimerProjSoumFacturation(ADODB.Recordset rstProjSoum, string sNoFacture)
        {
            var rptOrientLandscape = default(object);
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstTemp;
                ADODB.Recordset rstImpProjSoum;
                var sOrdreSection = default(string);
                int XSoum;
                var sSousSection = default(string);
                string sSousSectionRS;
                string sSection;
                string sNoProjet;
                string sNoSoumission;
                var sCommission = default(string);
                var sPrixTotal = default(string);
                var sProfit = default(string);
                var sTempsFabrication = default(string);
                var sTotalPiece = default(string);
                var sImprevue = default(string);
                var sTotalTemps = default(string);
                var sManuel = default(string);
                double dblTotalTemps;
                double dblTempsDessin;
                double dblTempsFabrication;
                double dblTempsAssemblage;
                double dblTempsProgInterface;
                double dblTempsProgAutomate;
                double dblTempsProgRobot;
                double dblTempsVision;
                double dblTempsTest;
                double dblTempsInstallation;
                double dblTempsMiseService;
                double dblTempsFormation;
                double dblTempsGestion;
                double dblTempsShipping;
                double dblTotalHebergement;
                double dblTotalRepas;
                double dblTotalTransport;
                double dblTotalUniteMobile;
                double dblPrixEmballage;
                double dblTotalReste;
                double dblTotalAutre;
                rstPiece = new Recordset();
                rstTemp = new Recordset();
                rstImpProjSoum = new Recordset();
                UpdateSQL("DELETE FROM impression_soumission");
                XSoum = 1;
                Cursor.Current = Cursors.WaitCursor;
                rstImpProjSoum.Open("SELECT * FROM impression_soumission", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sNoProjet = rstProjSoum.Fields["IDProjet"].Value;
                sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value;
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'E' AND Facturation = '" + sNoFacture + "' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    sSousSectionRS = rstPiece.Fields["SousSection"].Value;
                    if ((sSousSectionRS ?? "") == S_PAS_SOUS_SECTION) { sSousSectionRS = " "; }
                    if (sOrdreSection != rstPiece.Fields["OrdreSection"].Value)
                    {
                        sOrdreSection = rstPiece.Fields["OrdreSection"].Value;
                        if (m_eLangage == EnumLangage.ANGLAIS) { sSection = "NomSectionEN"; } else { sSection = "NomSectionFR"; }
                        rstTemp.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstPiece.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet;
                        if (!(rstTemp.Fields[sSection].Value is DBNull)) { rstImpProjSoum.Fields["NomSection"].Value = rstTemp.Fields[sSection].Value; } else { rstImpProjSoum.Fields["NomSection"].Value = " "; }
                        rstImpProjSoum.Update();
                        XSoum++;
                        rstTemp.Close();
                        sSousSection = rstPiece.Fields["SousSection"].Value;
                        if ((sSousSection ?? "") == S_PAS_SOUS_SECTION) { sSousSection = " "; }
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        if (m_eType == EnumType.TYPE_PROJET) { rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet; } else { rstImpProjSoum.Fields["IDSoumission"].Value = sNoSoumission; }
                        rstImpProjSoum.Fields["SousSection"].Value = sSousSection;
                        rstImpProjSoum.Update();
                        XSoum++;
                    }
                    else
                    if ((sSousSection ?? "") != (sSousSectionRS ?? ""))
                    {
                        sSousSection = sSousSectionRS;
                        rstImpProjSoum.AddNew();
                        rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                        rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet;
                        rstImpProjSoum.Fields["SousSection"].Value = sSousSectionRS;
                        rstImpProjSoum.Update();
                        XSoum++;
                    }
                    rstImpProjSoum.AddNew();
                    rstImpProjSoum.Fields["NoLigne"].Value = XSoum;
                    rstImpProjSoum.Fields["IDSoumission"].Value = sNoProjet;
                    rstImpProjSoum.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                    rstImpProjSoum.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                    if (m_eLangage == EnumLangage.ANGLAIS) { rstImpProjSoum.Fields["Description"].Value = rstPiece.Fields["DESC_EN"].Value; } else { rstImpProjSoum.Fields["Description"].Value = rstPiece.Fields["DESC_FR"].Value; }
                    rstImpProjSoum.Fields["MANUFACT"].Value = rstPiece.Fields["MANUFACT"].Value;
                    rstImpProjSoum.Fields["PRIX_NET"].Value = rstPiece.Fields["PRIX_NET"].Value;
                    rstTemp.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstPiece.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstTemp.EOF) { rstImpProjSoum.Fields["NomFournisseur"].Value = rstTemp.Fields["NomFournisseur"].Value; }
                    rstTemp.Close();
                    rstImpProjSoum.Fields["PRIX_TOTAL"].Value = rstPiece.Fields["PRIX_TOTAL"].Value;
                    rstImpProjSoum.Fields["PROFIT_ARGENT"].Value = rstPiece.Fields["PROFIT_ARGENT"].Value;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["DateRéception"].Value))) { rstImpProjSoum.Fields["DateReception"].Value = rstPiece.Fields["DateRéception"].Value; } else { rstImpProjSoum.Fields["DateReception"].Value = ""; }
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["DateCommande"].Value))) { rstImpProjSoum.Fields["DateCommande"].Value = rstPiece.Fields["DateCommande"].Value; } else { rstImpProjSoum.Fields["DateCommande"].Value = ""; }
                    }
                    else
                    {
                        rstImpProjSoum.Fields["DateReception"].Value = "";
                        rstImpProjSoum.Fields["DateCommande"].Value = "";
                    }
                    rstImpProjSoum.Update();
                    XSoum++;
                    rstPiece.MoveNext();
                }
                rstImpProjSoum.Close();
                rstImpProjSoum.Open("SELECT * FROM impression_soumission WHERE IDSoumission = '" + sNoProjet + "' ORDER BY NoLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewSoumissionElec.DataSource = rstImpProjSoum;
                CalculerPrixFacturation(sNoFacture, ref sCommission, ref sPrixTotal, ref sProfit, ref sTempsFabrication, ref sTotalPiece, ref sImprevue, ref sTotalTemps, ref sManuel);
                TraduireImpressionSoumission();
                ViewSoumissionElec.shpCadrePrixReception.Visible = false;
                ViewSoumissionElec.lblTitrePrixReception.Visible = false;
                ViewSoumissionElec.lblPrixReception.Visible = false;
                ViewSoumissionElec.shpCadrePrixSoumission.Visible = false;
                ViewSoumissionElec.lblTitrePrixSoumission.Visible = false;
                ViewSoumissionElec.lblPrixSoumission.Visible = false;
                ViewSoumissionElec.shpCadreForfait.Visible = false;
                ViewSoumissionElec.lblTitreForfait.Visible = false;
                ViewSoumissionElec.lblForfait.Visible = false;
                ViewSoumissionElec.lblTitreNoFacture.Visible = true;
                ViewSoumissionElec.lblNoFacture.Visible = true;
                ViewSoumissionElec.lblNoFacture.Text = sNoFacture;
                ViewSoumissionElec.lbldate.Text = ConvertDate(DateTime.Today);
                ViewSoumissionElec.lblSoumission.Text = sNoSoumission;
                ViewSoumissionElec.lblProjet.Text = sNoProjet;
                ViewSoumissionElec.lbldescription.Text = rstProjSoum.Fields["Description"].Value;
                rstTemp.Open("SELECT NomClient FROM Client WHERE IDClient = " + rstProjSoum.Fields["IDClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewSoumissionElec.lblclient.Text = rstTemp.Fields["NomClient"].Value;
                rstTemp.Close();
                rstTemp.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstProjSoum.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewSoumissionElec.lblcontact.Text = rstTemp.Fields["NomContact"].Value;
                rstTemp.Close();
                if (!(rstProjSoum.Fields["TauxDessin"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxDessin.Text = rstProjSoum.Fields["TauxDessin"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxDessin.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxFabrication"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxFabrication.Text = rstProjSoum.Fields["TauxFabrication"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxFabrication.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull))
                {
                    ViewSoumissionElec.lblTauxAssemblage.Text = rstProjSoum.Fields["TauxAssemblage"].Value;
                }
                else
                {
                    ViewSoumissionElec.lblTauxAssemblage.Text = "0";
                }
                if (!(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull)) { ViewSoumissionElec.lblTauxProgInterface.Text = rstProjSoum.Fields["TauxProgInterface"].Value; } else { ViewSoumissionElec.lblTauxProgInterface.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull)) { ViewSoumissionElec.lblTauxProgAutomate.Text = rstProjSoum.Fields["TauxProgAutomate"].Value; } else { ViewSoumissionElec.lblTauxProgAutomate.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull)) { ViewSoumissionElec.lblTauxProgRobot.Text = rstProjSoum.Fields["TauxProgRobot"].Value; } else { ViewSoumissionElec.lblTauxProgRobot.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxVision"].Value is DBNull)) { ViewSoumissionElec.lblTauxVision.Text = rstProjSoum.Fields["TauxVision"].Value; } else { ViewSoumissionElec.lblTauxVision.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxTest"].Value is DBNull)) { ViewSoumissionElec.lblTauxTest.Text = rstProjSoum.Fields["TauxTest"].Value; } else { ViewSoumissionElec.lblTauxTest.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxInstallation"].Value is DBNull)) { ViewSoumissionElec.lblTauxInstallation.Text = rstProjSoum.Fields["TauxInstallation"].Value; } else { ViewSoumissionElec.lblTauxInstallation.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxMiseService"].Value is DBNull)) { ViewSoumissionElec.lblTauxMiseService.Text = rstProjSoum.Fields["TauxMiseService"].Value; } else { ViewSoumissionElec.lblTauxMiseService.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxFormation"].Value is DBNull)) { ViewSoumissionElec.lblTauxFormation.Text = rstProjSoum.Fields["TauxFormation"].Value; } else { ViewSoumissionElec.lblTauxFormation.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxGestion"].Value is DBNull)) { ViewSoumissionElec.lblTauxGestion.Text = rstProjSoum.Fields["TauxGestion"].Value; } else { ViewSoumissionElec.lblTauxGestion.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxShipping"].Value is DBNull)) { ViewSoumissionElec.lblTauxShipping.Text = rstProjSoum.Fields["TauxShipping"].Value; } else { ViewSoumissionElec.lblTauxShipping.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull)) { ViewSoumissionElec.lblTempsDessinSoum.Text = rstProjSoum.Fields["TempsDessin"].Value; }
                else
                {
                    ViewSoumissionElec.lblTempsDessinSoum.Text = "0";
                }
                ViewSoumissionElec.lblTempsFabricationSoum.Text = sTempsFabrication;
                if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull)) { ViewSoumissionElec.lblTempsAssemblageSoum.Text = rstProjSoum.Fields["TempsAssemblage"].Value; } else { ViewSoumissionElec.lblTempsAssemblageSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull)) { ViewSoumissionElec.lblTempsAssemblageSoum.Text = rstProjSoum.Fields["TempsProgInterface"].Value; } else { ViewSoumissionElec.lblTempsAssemblageSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull)) { ViewSoumissionElec.lblTempsProgAutomateSoum.Text = rstProjSoum.Fields["TempsProgAutomate"].Value; } else { ViewSoumissionElec.lblTempsProgAutomateSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull)) { ViewSoumissionElec.lblTempsProgRobotSoum.Text = rstProjSoum.Fields["TempsProgRobot"].Value; } else { ViewSoumissionElec.lblTempsProgRobotSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull)) { ViewSoumissionElec.lblTempsVisionSoum.Text = rstProjSoum.Fields["TempsVision"].Value; } else { ViewSoumissionElec.lblTempsVisionSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull)) { ViewSoumissionElec.lblTempsTestSoum.Text = rstProjSoum.Fields["TempsTest"].Value; } else { ViewSoumissionElec.lblTempsTestSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull)) { ViewSoumissionElec.lblTempsInstallationSoum.Text = rstProjSoum.Fields["TempsInstallation"].Value; } else { ViewSoumissionElec.lblTempsInstallationSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull)) { ViewSoumissionElec.lblTempsMiseServiceSoum.Text = rstProjSoum.Fields["TempsMiseService"].Value; } else { ViewSoumissionElec.lblTempsMiseServiceSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull)) { ViewSoumissionElec.lblTempsFormationSoum.Text = rstProjSoum.Fields["TempsFormation"].Value; } else { ViewSoumissionElec.lblTempsFormationSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull)) { ViewSoumissionElec.lblTempsGestionSoum.Text = rstProjSoum.Fields["TempsGestion"].Value; } else { ViewSoumissionElec.lblTempsGestionSoum.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull)) { ViewSoumissionElec.lblTempsShippingSoum.Text = rstProjSoum.Fields["TempsShipping"].Value; } else { ViewSoumissionElec.lblTempsShippingSoum.Text = "0"; }
                if (IsNumeric(rstProjSoum.Fields["TempsDessin"].Value)) { dblTempsDessin = (double)rstProjSoum.Fields["TempsDessin"].Value; } else { dblTempsDessin = 0d; }
                if (IsNumeric(sTempsFabrication)) { dblTempsFabrication = double.Parse(sTempsFabrication); } else { dblTempsFabrication = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsAssemblage"].Value)) { dblTempsAssemblage = (double)rstProjSoum.Fields["TempsAssemblage"].Value; } else { dblTempsAssemblage = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsProgInterface"].Value)) { dblTempsProgInterface = (double)rstProjSoum.Fields["TempsProgInterface"].Value; } else { dblTempsProgInterface = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsProgAutomate"].Value)) { dblTempsProgAutomate = (double)rstProjSoum.Fields["TempsProgAutomate"].Value; } else { dblTempsProgAutomate = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsProgRobot"].Value)) { dblTempsProgRobot = (double)rstProjSoum.Fields["TempsProgRobot"].Value; } else { dblTempsProgRobot = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsVision"].Value)) { dblTempsVision = (double)rstProjSoum.Fields["TempsVision"].Value; } else { dblTempsVision = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsTest"].Value)) { dblTempsTest = (double)rstProjSoum.Fields["TempsTest"].Value; } else { dblTempsTest = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsInstallation"].Value)) { dblTempsInstallation = (double)rstProjSoum.Fields["TempsInstallation"].Value; } else { dblTempsInstallation = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsMiseService"].Value)) { dblTempsMiseService = (double)rstProjSoum.Fields["TempsMiseService"].Value; } else { dblTempsMiseService = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsFormation"].Value)) { dblTempsFormation = (double)rstProjSoum.Fields["TempsFormation"].Value; } else { dblTempsFormation = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsGestion"].Value)) { dblTempsGestion = (double)rstProjSoum.Fields["TempsGestion"].Value; } else { dblTempsGestion = 0d; }
                if (IsNumeric(rstProjSoum.Fields["TempsShipping"].Value)) { dblTempsShipping = (double)rstProjSoum.Fields["TempsShipping"].Value; } else { dblTempsShipping = 0d; }
                dblTotalTemps = dblTempsDessin + dblTempsFabrication + dblTempsAssemblage + dblTempsProgInterface + dblTempsProgAutomate + dblTempsProgRobot + dblTempsVision + dblTempsTest + dblTempsInstallation + dblTempsMiseService + dblTempsFormation + dblTempsGestion + dblTempsShipping; ViewSoumissionElec.lblTotalTempsRHSoum.Text = dblTotalTemps.ToString()
;
                CalculerTempsReelsImpression(rstProjSoum.Fields["IDProjet"].Value);
                //Autres frais
                if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull)) { ViewSoumissionElec.lblNbrePersonne.Text = rstProjSoum.Fields["NbrePersonne"].Value; } else { ViewSoumissionElec.lblNbrePersonne.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull)) { ViewSoumissionElec.lblTempsHebergement.Text = rstProjSoum.Fields["TempsHebergement"].Value; } else { ViewSoumissionElec.lblTempsHebergement.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxHebergement1"].Value is DBNull)) { ViewSoumissionElec.lblTauxHebergement1.Text = rstProjSoum.Fields["TauxHebergement1"].Value; } else { ViewSoumissionElec.lblTauxHebergement1.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxHebergement2"].Value is DBNull)) { ViewSoumissionElec.lblTauxHebergement2.Text = rstProjSoum.Fields["TauxHebergement2"].Value; } else { ViewSoumissionElec.lblTauxHebergement2.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull)) { ViewSoumissionElec.lblTempsRepas.Text = rstProjSoum.Fields["TempsRepas"].Value; } else { ViewSoumissionElec.lblTempsRepas.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxRepas"].Value is DBNull)) { ViewSoumissionElec.lblTauxRepas.Text = rstProjSoum.Fields["TauxRepas"].Value; } else { ViewSoumissionElec.lblTauxRepas.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull)) { ViewSoumissionElec.lblTempsTransport.Text = rstProjSoum.Fields["TempsTransport"].Value; } else { ViewSoumissionElec.lblTempsTransport.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxTransport"].Value is DBNull)) { ViewSoumissionElec.lblTauxTransport.Text = rstProjSoum.Fields["TauxTransport"].Value; } else { ViewSoumissionElec.lblTauxTransport.Text = "0"; }
                if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull)) { ViewSoumissionElec.lblTempsUniteMobile.Text = rstProjSoum.Fields["TempsUniteMobile"].Value; } else { ViewSoumissionElec.lblTempsUniteMobile.Text = "0"; }
                if (!(rstProjSoum.Fields["TauxUniteMobile"].Value is DBNull)) { ViewSoumissionElec.lblTauxUniteMobile.Text = rstProjSoum.Fields["TauxUniteMobile"].Value; } else { ViewSoumissionElec.lblTauxUniteMobile.Text = "0"; }
                if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull)) { ViewSoumissionElec.lblPrixEmballage.Text = rstProjSoum.Fields["PrixEmballage"].Value; }
                else
                {
                    ViewSoumissionElec.lblPrixEmballage.Text = "0";
                }
                ViewSoumissionElec.lblPrixManuel.Text = rstProjSoum.Fields["Total_Manuel"].Value;
                ViewSoumissionElec.lblTotalPieceAR.Text = sTotalPiece + "$";
                ViewSoumissionElec.lblImprevue.Text = rstProjSoum.Fields["imprevue"].Value;
                ViewSoumissionElec.lblImprevueAR.Text = sImprevue + "$";
                ViewSoumissionElec.lblTotalTempsAR.Text = sTotalTemps + "$";
                ViewSoumissionElec.lblCommission.Text = rstProjSoum.Fields["commission"].Value;
                ViewSoumissionElec.lblcommissionAR.Text = sCommission + "$";
                ViewSoumissionElec.lblGrandTotalAR.Text = sPrixTotal + "$";
                ViewSoumissionElec.lblProfit.Text = rstProjSoum.Fields["profit"].Value * 100;
                ViewSoumissionElec.lblTotalProfit.Text = sProfit + "$";
                dblTotalHebergement = (double)rstProjSoum.Fields["TotalHebergement"].Value;
                dblTotalRepas = (double)rstProjSoum.Fields["TotalRepas"].Value;
                if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull) & !(rstProjSoum.Fields["TauxTransport"].Value is DBNull))
                {
                    dblTotalTransport = (double)rstProjSoum.Fields["TempsTransport"].Value * (double)rstProjSoum.Fields["TauxTransport"].Value;
                }
                else
                {
                    dblTotalTransport = 0d;
                }
                if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull) & !(rstProjSoum.Fields["TauxUniteMobile"].Value is DBNull))
                {
                    dblTotalUniteMobile = (double)rstProjSoum.Fields["TempsUniteMobile"].Value * (double)rstProjSoum.Fields["TauxUniteMobile"].Value;
                }
                else { dblTotalUniteMobile = 0d; }
                if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage = double.Parse(Strings.Replace(rstProjSoum.Fields["PrixEmballage"].Value, ".", ",")); } else { dblPrixEmballage = 0d; }
                dblTotalReste = dblTotalHebergement + dblTotalRepas + dblTotalTransport + dblTotalUniteMobile + dblPrixEmballage;
                dblTotalAutre = dblTotalReste + (double)rstProjSoum.Fields["total_manuel"].Value;
                ViewSoumissionElec.lblAutre.Text = dblTotalAutre.ToString() + "$";
                ViewSoumissionElec f = new ViewSoumissionElec();
                f.Icon = ActiveForm.Icon;
                f.Show();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ImprimerProjSoum", ex);
            }
        }
        private void ImprimerListePiecesFacturation(ADODB.Recordset rstProjSoum, string sNoFacture)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstTemp;
                ADODB.Recordset rstImpListePiece;
                string sOrdreSection;
                int XPiece = 0;
                var sSousSection = default(string);
                string sSousSectionRS;
                string sSection;
                string sNoProjet;
                string sNoSoumission;
                rstPiece = new Recordset();
                rstTemp = new Recordset();
                rstImpListePiece = new Recordset();
                UpdateSQL("DELETE FROM impression_listepiece");
                XPiece = 1;
                Cursor.Current = Cursors.WaitCursor;
                rstImpListePiece.Open("SELECT * FROM impression_listepiece", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sOrdreSection = string.Empty;
                sNoProjet = rstProjSoum.Fields["IDProjet"].Value;
                sNoSoumission = rstProjSoum.Fields["IDSoumission"].Value;
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'E' AND Facturation = '" + sNoFacture + "' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (rstPiece.Fields["Visible"].Value == true)
                    {
                        sSousSectionRS = rstPiece.Fields["SousSection"].Value;
                        if ((sSousSectionRS ?? "") == S_PAS_SOUS_SECTION) { sSousSectionRS = " "; }
                        if (sOrdreSection != rstPiece.Fields["OrdreSection"].Value)
                        {
                            if (m_eLangage == EnumLangage.ANGLAIS)
                            {
                                sSection = "NomSectionEN";
                            }
                            else
                            {
                                sSection = "NomSectionFR";
                            }
                            rstTemp.Open("SELECT " + sSection + " FROM SoumProjSectionElec WHERE IDSection = " + rstPiece.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstImpListePiece.AddNew();
                            rstImpListePiece.Fields["NoLigne"].Value = XPiece;
                            rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                            if (!(rstTemp.Fields[sSection].Value is DBNull))
                            {
                                rstImpListePiece.Fields["NomSection"].Value = rstTemp.Fields[sSection].Value;
                            }
                            else
                            {
                                rstImpListePiece.Fields["NomSection"].Value = " ";
                            }
                            rstImpListePiece.Update();
                            XPiece++;
                            rstTemp.Close(); sSousSection = rstPiece.Fields["SousSection"].Value;
                            if ((sSousSection ?? "") == S_PAS_SOUS_SECTION) { sSousSection = " "; }
                            rstImpListePiece.AddNew(); rstImpListePiece.Fields["NoLigne"].Value = XPiece; rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission; rstImpListePiece.Fields["SousSection"].Value = sSousSection; rstImpListePiece.Update(); XPiece++;
                        }
                        else
                        if ((sSousSection ?? "") != (sSousSectionRS ?? ""))
                        {
                            sSousSection = sSousSectionRS;
                            rstImpListePiece.AddNew();
                            rstImpListePiece.Fields["NoLigne"].Value = XPiece;
                            rstImpListePiece.Fields["IDSoumission"].Value = sNoSoumission;
                            rstImpListePiece.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                            rstImpListePiece.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                            if (m_eLangage == EnumLangage.ANGLAIS) { rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_EN"].Value; } else { rstImpListePiece.Fields["Description"].Value = rstPiece.Fields["Desc_FR"].Value; }
                            rstImpListePiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                            rstImpListePiece.Update();
                            XPiece++;
                        }
                        rstPiece.MoveNext();
                    }
                    rstImpListePiece.Close();
                    rstImpListePiece.Open("SELECT * FROM impression_Listepiece WHERE IDSoumission = '" + sNoSoumission + "' ORDER BY noligne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.DataSource = rstImpListePiece;
                    TraduireImpressionListePiece();
                    ViewListePiece.lblTitreNoFacture.Visible = true;
                    ViewListePiece.lblNoFacture.Visible = true;
                    ViewListePiece.lblNoFacture.Text = sNoFacture;
                    ViewListePiece.lblDate.Text = ConvertDate(DateTime.Today);
                    ViewListePiece.lblProjet.Text = sNoProjet;
                    ViewListePiece.lblsoumission.Text = sNoSoumission;
                    ViewListePiece.lbldescription.Text = rstProjSoum.Fields["Description"].Value;
                    rstTemp.Open("SELECT NomClient FROM Client WHERE IDClient = " + rstProjSoum.Fields["IDClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.lblClient = rstTemp.Fields["NomClient"].Value;
                    rstTemp.Close();
                    rstTemp.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstProjSoum.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewListePiece.lblContact = rstTemp.Fields["nomcontact"].Value;
                    rstTemp.Close();
                    ViewListePiece.Orientation = false;
                    Form f = new InterfaceWeb("ViewListePiece?");
                    f.Icon = ActiveForm.Icon;
                    f.Show();
                    rstImpListePiece.Close();
                    rstImpListePiece = default;
                    rstTemp = default;
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ImprimerListePieces", ex);
            }
        }
        private void TraduireImpressionListePiece()
        {
            try
            {
                if (m_eLangage == EnumLangage.ANGLAIS)
                {
                    ViewListePiece.lblTitreProjet.Text = "Project:";
                    ViewListePiece.lblTitreSoumission.Text = "Quote:";
                    ViewListePiece.lblTitreQuantite.Text = "Qty";
                    ViewListePiece.lblTitreNoItem.Text = "Item No.";
                    ViewListePiece.lblTitreManufacturier.Text = "Manufacturer";
                }
                else
                {
                    ViewListePiece.lblTitreProjet.Text = "Projet:";
                    ViewListePiece.lblTitreSoumission.Text = "Soumission:";
                    ViewListePiece.lblTitreQuantite.Text = "Qté";
                    ViewListePiece.lblTitreNoItem.Text = "No. Item";
                    ViewListePiece.lblTitreManufacturier.Text = "Manufacturier";
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "TraduireImpressionListePiece", ex);
            }
        }
        private void TraduireImpressionSoumission()
        {
            try
            {
                if (m_eLangage == EnumLangage.ANGLAIS)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        ViewSoumissionElec.lblGrosTitre.Text = "Electrical Project";
                    }
                    else
                    {
                        ViewSoumissionElec.lblGrosTitre.Text = "Electrical Quote";
                    }
                    ViewSoumissionElec.lblTitreProjet.Text = "Project :";
                    ViewSoumissionElec.lblTitreSoumission.Text = "Quote :";
                    ViewSoumissionElec.lblTitreClient.Text = "Client :";
                    ViewSoumissionElec.lblTitreContact.Text = "Contact :";
                    ViewSoumissionElec.lblTitreQuantite.Text = "Qty";
                    ViewSoumissionElec.lblTitreNoItem.Text = "Item No.";
                    ViewSoumissionElec.lblTitreDescription.Text = "Description";
                    ViewSoumissionElec.lblTitreManufacturier.Text = "Manufacturer";
                    ViewSoumissionElec.lblTitreCoutant.Text = "Cost";
                    ViewSoumissionElec.lblTitreFournisseur.Text = "Supplier";
                    ViewSoumissionElec.lblTitreTotal.Text = "Total";
                    ViewSoumissionElec.lbl_DateCommande.Text = "Order Date";
                    ViewSoumissionElec.lbl_DateReception.Text = "Reception Date";
                    ViewSoumissionElec.lblTitreDessin.Text = "Drafting :";
                    ViewSoumissionElec.lblTitreFabrication.Text = "Manufacturing :";
                    ViewSoumissionElec.lblTitreAssemblage.Text = "Assembling :";
                    ViewSoumissionElec.lblTitreProgInterface.Text = "Interface programming :";
                    ViewSoumissionElec.lblTitreProgAutomate.Text = "PLC programming :";
                    ViewSoumissionElec.lblTitreProgRobot.Text = "Robot programming :";
                    ViewSoumissionElec.lblTitreVision.Text = "Vision :";
                    ViewSoumissionElec.lblTitreTest.Text = "Test :";
                    ViewSoumissionElec.lblTitreInstallation.Text = "Installation :";
                    ViewSoumissionElec.lblTitreMiseService.Text = "Activation :";
                    ViewSoumissionElec.lblTitreFormation.Text = "Training :";
                    ViewSoumissionElec.lblTitreGestion.Text = "Project management :";
                    ViewSoumissionElec.lblTitreShipping.Text = "Shipping :";
                    ViewSoumissionElec.lblTitreTauxHoraire.Text = "Rate / Hours";
                    ViewSoumissionElec.lblTitreTemps.Text = "Time (Hour)";
                    ViewSoumissionElec.lblTitreTotalPiece.Text = "Parts Total:";
                    ViewSoumissionElec.lblTitreImprevue.Text = "Unforeseen:";
                    ViewSoumissionElec.lblTitreTotalTemps.Text = "Time Total:";
                    ViewSoumissionElec.lblTitreGrandTotal.Text = "Final Price:";
                    ViewSoumissionElec.lblNoPage.Text = "Page %p of %P";
                    ViewSoumissionElec.lblTitrePrixReception.Text = "Receiving up to date";
                    ViewSoumissionElec.lblTitrePrixSoumission.Text = "Quote Price";
                    ViewSoumissionElec.lblTitreForfait.Text = "Package Deal";
                }
                else
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        ViewSoumissionElec.lblGrosTitre.Text = "Projet Électrique";
                    }
                    else
                    {
                        ViewSoumissionElec.lblGrosTitre.Text = "Soumission Électrique";
                    }
                    ViewSoumissionElec.lblTitreProjet.Text = "Projet:";
                    ViewSoumissionElec.lblTitreSoumission.Text = "Soumission:";
                    ViewSoumissionElec.lblTitreClient.Text = "Client:";
                    ViewSoumissionElec.lblTitreContact.Text = "Contact:";
                    ViewSoumissionElec.lblTitreQuantite.Text = "Qté";
                    ViewSoumissionElec.lblTitreNoItem.Text = "No. Item";
                    ViewSoumissionElec.lblTitreDescription.Text = "Description";
                    ViewSoumissionElec.lblTitreManufacturier.Text = "Manufacturier";
                    ViewSoumissionElec.lblTitreCoutant.Text = "Coûtant";
                    ViewSoumissionElec.lblTitreFournisseur.Text = "Fournisseur";
                    ViewSoumissionElec.lblTitreTotal.Text = "Total";
                    ViewSoumissionElec.lbl_DateCommande.Text = "Date commandé";
                    ViewSoumissionElec.lbl_DateReception.Text = "Date reçu";
                    ViewSoumissionElec.lblTitreDessin.Text = "Dessin :";
                    ViewSoumissionElec.lblTitreFabrication.Text = "Fabrication :";
                    ViewSoumissionElec.lblTitreAssemblage.Text = "Assemblage :";
                    ViewSoumissionElec.lblTitreProgInterface.Text = "Programmation d'interface :";
                    ViewSoumissionElec.lblTitreProgAutomate.Text = "Programmation d'automate :";
                    ViewSoumissionElec.lblTitreProgRobot.Text = "Programmation de robot :";
                    ViewSoumissionElec.lblTitreVision.Text = "Vision :";
                    ViewSoumissionElec.lblTitreTest.Text = "Test :";
                    ViewSoumissionElec.lblTitreInstallation.Text = "Installation :";
                    ViewSoumissionElec.lblTitreMiseService.Text = "Mise en service :";
                    ViewSoumissionElec.lblTitreFormation.Text = "Formation du personnel :";
                    ViewSoumissionElec.lblTitreGestion.Text = "Gestion du projet :";
                    ViewSoumissionElec.lblTitreShipping.Text = "Expédition :";
                    ViewSoumissionElec.lblTitreTauxHoraire.Text = "Taux Horaire";
                    ViewSoumissionElec.lblTitreTemps.Text = "Temps (Heure)";
                    ViewSoumissionElec.lblTitreTotalPiece.Text = "Total pièce:";
                    ViewSoumissionElec.lblTitreImprevue.Text = "Imprévue:";
                    ViewSoumissionElec.lblTitreTotalTemps.Text = "Total temps:";
                    ViewSoumissionElec.lblTitreGrandTotal.Text = "Grand total:";
                    ViewSoumissionElec.lblNoPage.Text = "Page %p de %P";
                    ViewSoumissionElec.lblTitrePrixReception.Text = "Réception jusqu'à maintenant";
                    ViewSoumissionElec.lblTitrePrixSoumission.Text = "$ Soumission";
                    ViewSoumissionElec.lblTitreForfait.Text = "Forfait";
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "TraduireImpressionSoumission", ex);
            }
        }
        private void RemplirColonnes()
        {
            try
            {
                bool bModint;
                var bCacherPrix = default(bool);
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (m_bModintProj == false)
                    {
                        bCacherPrix = true;
                    }
                }
                else
                if (m_bModintSoum == false)
                {
                    bCacherPrix = true;
                }
                if (bCacherPrix == true)
                {
                    m_bDroitPrix = false;
                    if (lvwSoumission.Columns.Count == 12) { return; }
                }
                else
                {
                    m_bDroitPrix = true;
                    if (lvwSoumission.Columns.Count == 18) { return; }
                }
                lvwSoumission.Columns.Clear();
                lvwSoumission.Columns.Add("", "Qté", 50);
                lvwSoumission.Columns.Add("", "No. Item", 100);
                lvwSoumission.Columns.Add("", "Description", 250);
                lvwSoumission.Columns.Add("", "Manufacturier", 250);
                if (bCacherPrix == false)
                {
                    lvwSoumission.Columns.Add("Prix listé", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("Escompte", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("Prix net", 75, HorizontalAlignment.Right);
                }
                lvwSoumission.Columns.Add("Distributeur", 175, HorizontalAlignment.Left);
                lvwSoumission.Columns.Add("Temps", 75, HorizontalAlignment.Right);
                lvwSoumission.Columns.Add("Montage", 75, HorizontalAlignment.Right);
                if (bCacherPrix == false)
                {
                    lvwSoumission.Columns.Add("TOTAL", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("Profit", 75, HorizontalAlignment.Right);
                }
                lvwSoumission.Columns.Add("Commentaire", 275, HorizontalAlignment.Right);
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    lvwSoumission.Columns.Add("ID", 25, HorizontalAlignment.Right);
                    if (bCacherPrix == false)
                    {
                        lvwSoumission.Columns.Add("Facturation", 175, HorizontalAlignment.Right);
                    }
                    lvwSoumission.Columns.Add("Date Commande", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("Date Requise", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("Commandé par", 75, HorizontalAlignment.Right);
                    lvwSoumission.Columns.Add("No Séquentiel", 75, HorizontalAlignment.Right);
                }
                lvwSoumission.Columns.Add("Provenance", 175, HorizontalAlignment.Left);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirColonnes", ex);
            }
        }
        private void RemplirComboProjSoum()
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                cmbProjSoum.Items.Clear();
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (cmbOuvertFerme.SelectedIndex == I_CMB_OUVERT)
                    {
                        rstProjSoum.Open("SELECT IDProjet FROM ProjetElec " +
                            "INNER JOIN ProjSoum ON ProjetElec.IDProjet = ProjSoum.IDProjSoum " +
                            "WHERE Ouvert = 1 ORDER BY IDProjet DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else { rstProjSoum.Open("SELECT IDProjet FROM ProjetElec ORDER BY IDProjet DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                }
                else
                if (cmbOuvertFerme.SelectedIndex == I_CMB_OUVERT)
                {
                    rstProjSoum.Open("SELECT IDSoumission FROM SoumissionElec " +
                    "INNER JOIN ProjSoum ON SoumissionElec.IDSoumission = ProjSoum.IDProjSoum " +
                    "WHERE Ouvert = 1 ORDER BY IDSoumission DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else { rstProjSoum.Open("SELECT IDSoumission FROM SoumissionElec ORDER BY IDSoumission DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                while (!rstProjSoum.EOF)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        cmbProjSoum.Items.Add(rstProjSoum.Fields["IDProjet"].Value);
                    }
                    else
                    {
                        cmbProjSoum.Items.Add(rstProjSoum.Fields["IDSoumission"].Value);
                    }
                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                if (cmbProjSoum.Items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(cmbProjSoum.Text))
                    {
                        RechercherProjSoum(cmbProjSoum.Text);
                    }
                    else
                    {
                        cmbProjSoum.SelectedIndex = 0;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirComboProjSoum", ex);
            }
        }
        private void CalculerPrixReel(string sNoItem)
        {
            try
            {
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstConfig;
                var sPrixCalcul = default(string);
                string sTauxUSA;
                string sTauxSPA;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
                sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
                rstConfig.Close();
                rstConfig = default;
                rstPieceFRS = new Recordset();
                rstPieceFRS.CursorLocation = CursorLocationEnum.adUseServer;
                rstPieceFRS.Open("SELECT PrixReel, PRIX_NET, PRIX_SP, DeviseMonétaire FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(sNoItem, "'", "''") + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty) { sPrixCalcul = rstPieceFRS.Fields["PRIX_NET"].Value; }
                    else
                    if (rstPieceFRS.Fields["PRIX_SP"].Value != string.Empty) { sPrixCalcul = rstPieceFRS.Fields["PRIX_SP"].Value; }
                    sPrixCalcul = Strings.Replace(sPrixCalcul, ".", ",");
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA") { rstPieceFRS.Fields["PrixReel"].Value = Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxUSA), 4).ToString(); }
                    else
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA") { rstPieceFRS.Fields["PrixReel"].Value = Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxSPA), 4).ToString(); } else { rstPieceFRS.Fields["PrixReel"].Value = sPrixCalcul; }
                    rstPieceFRS.Update();
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerPrixReel", ex);
            }
        }
        private void RemplirListViewFournisseur()
        {
            try
            {
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstContact;
                ADODB.Recordset rstFRS;
                ADODB.Recordset rstInv;
                ListViewItem itmFRS;
                int X;
                bool iNoClient;
                var bAjouterDP = default(bool);
                string sDevise;
                Color lColor;
                rstPieceFRS = new Recordset();
                rstContact = new Recordset();
                rstFRS = new Recordset();
                lvwFournisseur.Items.Clear();
                if (m_bPieceInutile == true | m_bChangementFRS == true) { CalculerPrixReel(Strings.Trim(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text)); }
                else
                if (m_bRecherchePiece == true)
                {
                    CalculerPrixReel(Strings.Trim(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text));
                }
                else
                {
                    CalculerPrixReel(Strings.Trim(lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text));
                }
                rstFRS.Open("SELECT IDFRS FROM Fournisseur WHERE NomFournisseur = 'FOURNI PAR LE CLIENT'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoClient = rstFRS.Fields["IDFRS"].Value;
                rstFRS.Close();
                rstFRS = default;
                if (m_bPieceInutile == true | m_bChangementFRS == true) { rstPieceFRS.Open("SELECT PiecesFRS.*, Fournisseur.NomFournisseur FROM PiecesFRS INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text, "'", "''")) + "' AND Type = 'E' ORDER BY CDbl(PrixReel)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else
                if (m_bRecherchePiece == true)
                {
                    rstPieceFRS.Open("SELECT PiecesFRS.*, Fournisseur.NomFournisseur FROM PiecesFRS " +
                        "INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS " +
                        "WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text, "'", "''")) + "' AND Type = 'E' ORDER BY CDbl(PrixReel)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPieceFRS.Open("SELECT PiecesFRS.*, Fournisseur.NomFournisseur FROM PiecesFRS " +
                        "INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS " +
                        "WHERE PIECE = '" + lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text.Replace("'", "''").Trim() + "' AND Type = 'E' ORDER BY CDbl(PrixReel)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstPieceFRS.EOF)
                {
                    if (m_bPieceInutile == true)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BRUN, false)))
                        {
                            if (rstPieceFRS.Fields["IDFRS"].Value == iNoClient)
                            {
                                rstPieceFRS.MoveNext();
                                if (rstPieceFRS.EOF) { break; }
                            }
                        }
                    }
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "CAN")
                    {
                        sDevise = "CAN";
                        lColor = COLOR_NOIR;
                    }
                    else
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                    {
                        sDevise = "USA";
                        lColor = COLOR_BLEU;
                    }
                    else
                    {
                        sDevise = "SPA";
                        lColor = COLOR_BLEU;
                    }
                    itmFRS = lvwFournisseur.Items.Add(string.Empty);
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST) { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE) { itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET) { itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP) { itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, " ")); }
                    itmFRS.Text = rstPieceFRS.Fields["NomFournisseur"].Value;
                    itmFRS.Tag = rstPieceFRS.Fields["IDFRS"].Value;
                    itmFRS.ForeColor = lColor;
                    if (!(rstPieceFRS.Fields["PERS_RESS"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPieceFRS.Fields["PERS_RESS"].Value)))
                        {
                            rstContact.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstPieceFRS.Fields["PERS_RESS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!rstContact.EOF)
                            {
                                if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS) { itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = rstContact.Fields["NomContact"].Value; } else { itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, rstContact.Fields["NomContact"].Value)); }
                                itmFRS.SubItems[I_COL_FRS_PERS_RESS].ForeColor = lColor;
                            }
                            rstContact.Close();
                        }
                    }
                    if (!(rstPieceFRS.Fields["Date"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_DATE) { itmFRS.SubItems[I_COL_FRS_DATE].Text = rstPieceFRS.Fields["Date"].Value; } else { itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Date"].Value)); }
                    }
                    else
                    if (itmFRS.SubItems.Count > I_COL_FRS_DATE) { itmFRS.SubItems[I_COL_FRS_DATE].Text = string.Empty; } else { itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    itmFRS.SubItems[I_COL_FRS_DATE].ForeColor = lColor;
                    if (!(rstPieceFRS.Fields["Entrer_Par"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR) { itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = rstPieceFRS.Fields["ENTRER_PAR"].Value; } else { itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["ENTRER_PAR"].Value)); }
                    }
                    else
                    if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR) { itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = string.Empty; } else { itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].ForeColor = lColor;
                    if (!(rstPieceFRS.Fields["Valide"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE) { itmFRS.SubItems[I_COL_FRS_VALIDE].Text = rstPieceFRS.Fields["Valide"].Value; } else { itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Valide"].Value)); }
                    }
                    else
                    if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE) { itmFRS.SubItems[I_COL_FRS_VALIDE].Text = string.Empty; } else { itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                    itmFRS.SubItems[I_COL_FRS_VALIDE].ForeColor = lColor;
                    if (rstPieceFRS.Fields["PRIX_LIST"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST) { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Math.Round(double.Parse(Strings.Replace(rstPieceFRS.Fields["PRIX_LIST"].Value, ".", ",")), 4); } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(rstPieceFRS.Fields["PRIX_LIST"].Value, ".", ",")), 4))); }
                    }
                    itmFRS.SubItems[I_COL_FRS_PRIX_LIST].ForeColor = lColor;
                    if (rstPieceFRS.Fields["ESCOMPTE"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE) { itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = double.Parse(Strings.Replace(Strings.Replace(rstPieceFRS.Fields["ESCOMPTE"].Value, "_", string.Empty), ".", ",")) * 100d; } else { itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, double.Parse(Strings.Replace(Strings.Replace(rstPieceFRS.Fields["ESCOMPTE"].Value, "_", string.Empty), ".", ",")) * 100d)); }
                    }
                    itmFRS.SubItems[I_COL_FRS_ESCOMPTE].ForeColor = lColor;
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET) { itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Math.Round(double.Parse(Strings.Replace(rstPieceFRS.Fields["PRIX_NET"].Value, ".", ",")), 4); } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(rstPieceFRS.Fields["PRIX_NET"].Value, ".", ",")), 4))); }
                    }
                    itmFRS.SubItems[I_COL_FRS_PRIX_NET].ForeColor = lColor;
                    if (rstPieceFRS.Fields["PRIX_SP"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP) { itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = Math.Round(rstPieceFRS.Fields["PRIX_SP"].Value, 4); } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, Math.Round(rstPieceFRS.Fields["PRIX_SP"].Value, 4))); }
                    }
                    itmFRS.SubItems[I_COL_FRS_PRIX_SP].ForeColor = lColor;
                    if (rstPieceFRS.Fields["QUOTER"].Value == true)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER) { itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Oui"; } else { itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Oui")); }
                    }
                    else
                    if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER) { itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Non"; } else { itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Non")); }
                    itmFRS.SubItems[I_COL_FRS_QUOTER].ForeColor = lColor;
                    if (rstPieceFRS.Fields["IDFRS"].Value == 717)
                    {
                        rstInv = new Recordset();
                        rstInv.Open("SELECT * FROM InventaireElec WHERE TRIM(NoItem) = '" + Strings.Trim(rstPieceFRS.Fields["PIECE"].Value) + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        if (!rstInv.EOF)
                        {
                            if (!(rstInv.Fields["QuantitéStock"].Value is DBNull))
                            {
                                if (itmFRS.SubItems.Count > I_COL_FRS_STOCK) { itmFRS.SubItems[I_COL_FRS_STOCK].Text = rstInv.Fields["QuantitéStock"].Value; } else { itmFRS.SubItems.Insert(I_COL_FRS_STOCK, new ListViewItem.ListViewSubItem(null, rstInv.Fields["QuantitéStock"].Value)); }
                            }
                            else
                            if (itmFRS.SubItems.Count > I_COL_FRS_STOCK) { itmFRS.SubItems[I_COL_FRS_STOCK].Text = 0.ToString(); } else { itmFRS.SubItems.Insert(I_COL_FRS_STOCK, new ListViewItem.ListViewSubItem(null, 0.ToString())); }
                        }
                        rstInv.Close();
                        rstInv = default;
                    }
                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST) { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                    }
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        if (rstPieceFRS.Fields["PRIX_LIST"].Value == "0,00" | rstPieceFRS.Fields["PRIX_LIST"].Value == "0") { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_NET"].Value, ".", ","); } else { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_LIST"].Value, ".", ","); }
                    }
                    else
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_SP"].Value, ".", ",");
                    }
                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR) { itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, " ")); }
                    }
                    itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Tag = rstPieceFRS.Fields["NoEnreg"].Value;
                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS) { itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, " ")); }
                    }
                    itmFRS.SubItems[I_COL_FRS_PERS_RESS].Tag = sDevise;
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = default;
                rstContact = default;
                if (m_bPieceInutile == false)
                {
                    if (lvwSoumission.Items.Count > 0)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BRUN, false))) { bAjouterDP = true; }
                        else
                        if (m_bChangementFRS == false) { bAjouterDP = true; }
                    }
                    else
                    { bAjouterDP = true; }
                }
                else
                if (m_bChangementFRS == true)
                {
                    if (lvwSoumission.Items.Count > 0)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BRUN, false))) { bAjouterDP = true; }
                    }
                    else
                    { bAjouterDP = true; }
                }
                if (bAjouterDP == true)
                {
                    itmFRS = lvwFournisseur.Items.Add(string.Empty);
                    itmFRS.Text = "CHOISIR ULTÉRIEUREMENT";
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST) { itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE) { itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET) { itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, " ")); }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP) { itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = " "; } else { itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, " ")); }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirListViewFournisseur", ex);
            }
        }
        private void RemplirListViewPieces()
        {
            try
            {
                ADODB.Recordset rstPieces;
                ListViewItem itmPieces = default;
                string sCategorie;
                string sTri;
                var sOrderBy = default(string);
                bool bDebut;
                int iIndex = 0;
                sTri = m_sTri;
                switch (cmbTri.SelectedIndex)
                {
                    case I_CMB_PIECE_GRB:
                        { sOrderBy = "PIECE_GRB"; break; }
                    case I_CMB_PIECE:
                        { sOrderBy = "PIECE"; break; }
                    case I_CMB_FABRICANT:
                        { sOrderBy = "FABRICANT"; break; }
                    case I_CMB_DESCR_FR:
                        { sOrderBy = "DESC_FR"; break; }
                    case I_CMB_DESCR_EN:
                        { sOrderBy = "DESC_EN"; break; }
                }
                lvwPieces.Items.Clear();
                sCategorie = Strings.Replace(cmbPieces.Text, "'", "''");
                rstPieces = new Recordset();
                rstPieces.Open("SELECT * FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY " + sOrderBy, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iIndex = 1;
                while (!rstPieces.EOF)
                {
                    if (rstPieces.Fields["PIECE"].Value != string.Empty & rstPieces.Fields["FABRICANT"].Value != string.Empty)
                    {
                        if (!string.IsNullOrEmpty(sTri))
                        {
                            bDebut = false;
                            switch (m_iCol)
                            {
                                case I_COL_PIECES_PIECE_GRB:
                                    {
                                        if ($"{rstPieces.Fields["PIECE_GRB"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                                case I_COL_PIECES_NO_ITEM:
                                    {
                                        if ($"{rstPieces.Fields["PIECE"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                                case I_COL_PIECES_MANUFACT:
                                    {
                                        if ($"{rstPieces.Fields["FABRICANT"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                                case I_COL_PIECES_DESCR_FR:
                                    {
                                        if ($"{rstPieces.Fields["DESC_FR"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                                case I_COL_PIECES_DESCR_EN:
                                    {
                                        if ($"{rstPieces.Fields["DESC_EN"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                            }
                            if (bDebut == true)
                            {
                                itmPieces = lvwPieces.Items.Insert(iIndex, ""); iIndex = iIndex + 1;
                            }
                            else
                            {
                                itmPieces = lvwPieces.Items.Add(string.Empty);
                            }
                        }
                        else
                        {
                            if (!(rstPieces.Fields["TEMPS"].Value is DBNull)) { itmPieces.Tag = rstPieces.Fields["TEMPS"].Value; } else { itmPieces.Tag = string.Empty; }
                            if (!(rstPieces.Fields["PIECE_GRB"].Value is DBNull)) { itmPieces.Text = Strings.Trim(rstPieces.Fields["PIECE_GRB"].Value); } else { itmPieces.Text = string.Empty; }
                            if (!(rstPieces.Fields["PIECE"].Value is DBNull))
                            {
                                if (itmPieces.SubItems.Count > I_COL_PIECES_NO_ITEM) { itmPieces.SubItems[I_COL_PIECES_NO_ITEM].Text = Strings.Trim(rstPieces.Fields["PIECE"].Value); } else { itmPieces.SubItems.Insert(I_COL_PIECES_NO_ITEM, new ListViewItem.ListViewSubItem(null, Strings.Trim(rstPieces.Fields["PIECE"].Value))); }
                            }
                            else
                            if (itmPieces.SubItems.Count > I_COL_PIECES_NO_ITEM) { itmPieces.SubItems[I_COL_PIECES_NO_ITEM].Text = string.Empty; } else { itmPieces.SubItems.Insert(I_COL_PIECES_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            if (!(rstPieces.Fields["FABRICANT"].Value is DBNull))
                            {
                                if (itmPieces.SubItems.Count > I_COL_PIECES_MANUFACT) { itmPieces.SubItems[I_COL_PIECES_MANUFACT].Text = Strings.Trim(rstPieces.Fields["FABRICANT"].Value); } else { itmPieces.SubItems.Insert(I_COL_PIECES_MANUFACT, new ListViewItem.ListViewSubItem(null, Strings.Trim(rstPieces.Fields["FABRICANT"].Value))); }
                            }
                            else
    if (itmPieces.SubItems.Count > I_COL_PIECES_MANUFACT) { itmPieces.SubItems[I_COL_PIECES_MANUFACT].Text = string.Empty; } else { itmPieces.SubItems.Insert(I_COL_PIECES_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            if (!(rstPieces.Fields["DESC_FR"].Value is DBNull))
                            {
                                if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_FR) { itmPieces.SubItems[I_COL_PIECES_DESCR_FR].Text = Strings.Trim(rstPieces.Fields["DESC_FR"].Value); } else { itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_FR, new ListViewItem.ListViewSubItem(null, Strings.Trim(rstPieces.Fields["DESC_FR"].Value))); }
                            }
                            else
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_FR) { itmPieces.SubItems[I_COL_PIECES_DESCR_FR].Text = string.Empty; } else { itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                            if (!(rstPieces.Fields["DESC_EN"].Value is DBNull))
                            {
                                if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_EN) { itmPieces.SubItems[I_COL_PIECES_DESCR_EN].Text = Strings.Trim(rstPieces.Fields["DESC_EN"].Value); } else { itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_EN, new ListViewItem.ListViewSubItem(null, Strings.Trim(rstPieces.Fields["DESC_EN"].Value))); }
                            }
                            else
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_EN) { itmPieces.SubItems[I_COL_PIECES_DESCR_EN].Text = string.Empty; } else { itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        }
                        rstPieces.MoveNext();
                    }
                    rstPieces.Close();
                    rstPieces = default;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirListViewPieces", ex);
            }
        }
        private void AjouterNegatintDansListView(double dblQuantite, string sSousSection)
        {
            try
            {
                int iIndex = default;
                ListViewItem itmSoum;
                int X;
                int iIDSection;
                int iTagSection;
                bool bSelected;
                var iIndexSel = default(int);
                double dblTempsMec;
                ADODB.Recordset rstProjet;
                var bQteOK = default(bool);
                var sNoProjet = default(string);
                string sPrixList;
                string sEscompte;
                string sPrixNet;
                string sTemps;
                var dblTotalQte = default(double);
                rstProjet = new Recordset();
                if (double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 60d & double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 98d)
                {
                    sNoProjet = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + m_sLiaison;
                    if (m_bRecherchePiece == true)
                    {
                        rstProjet.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND NumItem = '" + Strings.Replace(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text, "'", "''") + "' AND IDFRS = ", lvwFournisseur.FocusedItem.Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstProjet.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND NumItem = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text, "'", "''") + "' AND IDFRS = ", lvwFournisseur.FocusedItem.Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                if (!rstProjet.EOF)
                {
                    while (!rstProjet.EOF)
                    {
                        dblTotalQte = dblTotalQte + rstProjet.Fields["Qté"].Value;
                        rstProjet.MoveNext();
                    }
                    if (dblTotalQte >= Math.Abs(dblQuantite)) { bQteOK = true; }
                }
                else
                {
                    MessageBox.Show("La pièce n'existe pas dans le projet " + sNoProjet, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    rstProjet.Close();
                    rstProjet = default;
                    return;
                }
                if (bQteOK == true)
                {
                    rstProjet.MovePrevious();
                    sPrixList = rstProjet.Fields["Prix_List"].Value;
                    sEscompte = rstProjet.Fields["Escompte"].Value;
                    sPrixNet = rstProjet.Fields["Prix_Net"].Value;
                    sTemps = rstProjet.Fields["Temps"].Value;
                }
                else
                {
                    if (m_bRecherchePiece == true)
                    {
                        MessageBox.Show("Il n'y a pas assez de " + lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text + " dans le projet " + sNoProjet + " pour en enlever " + Math.Abs(dblQuantite) + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas assez de " + lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text + " dans le projet " + sNoProjet + " pour en enlever " + Math.Abs(dblQuantite) + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    rstProjet.Close();
                    rstProjet = default;
                    return;
                }
                rstProjet.Close();
                rstProjet = default;
                bSelected = false;
                if (lvwSoumission.Items.Count > 0)
                {
                    if (lvwSoumission.FocusedItem.Index > 1)
                    {
                        bSelected = true;
                        iIndexSel = lvwSoumission.FocusedItem.Index;
                    }
                }
                if (bSelected == false) { bool bIndex = TrouverIndexSection(sSousSection); } else { iIndex = iIndexSel; }
                itmSoum = lvwSoumission.Items.Insert(iIndex, "");
                itmSoum.Checked = true;
                //Quantité
                itmSoum.Text = dblQuantite.ToString();
                if (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_QUOTER].Text == "Oui")
                {
                    itmSoum.Text = itmSoum.Text + "*";
                    itmSoum.ForeColor = COLOR_VERT;
                }
                else { itmSoum.ForeColor = COLOR_NOIR; }
                itmSoum.Tag = cmbSections.Items[cmbSections.SelectedIndex].ToString();
                //IDSection
                if (m_bRecherchePiece == true)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text)); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE) { itmSoum.SubItems[I_COL_SOUM_PIECE].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text)); }
                itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
                itmSoum.SubItems[I_COL_SOUM_PIECE].Tag = sSousSection;
                if (m_eLangage == EnumLangage.ANGLAIS)
                {
                    if (m_bRecherchePiece == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text)); }
                        itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text;
                    }
                    else
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text)); }
                        itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text;
                    }
                }
                else
                if (m_bRecherchePiece == true)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text;
                }
                else
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR) { itmSoum.SubItems[I_COL_SOUM_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text)); }
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text;
                }
                itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
                if (m_bRecherchePiece == true)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text)); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT) { itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text)); }
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = (cmbSections.SelectedIndex + 1).ToString();
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
                if (string.IsNullOrEmpty(Strings.Trim(sPrixList)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, "0")); }
                }
                else
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = sPrixList; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, sPrixList)); }
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = sPrixList;
                }
                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = lColor;
                if (!string.IsNullOrEmpty(Strings.Trim(sEscompte)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = sEscompte; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, sEscompte)); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, "0")); }
                itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = lColor;
                if (!string.IsNullOrEmpty(Strings.Trim(sPrixNet)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = sPrixNet; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, sPrixNet)); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = "0"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, "0")); }
                itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = lColor;
                if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB) { itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = lvwFournisseur.FocusedItem.Text; } else { itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.Text)); }
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
                //Temps
                if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS) { itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = sTemps; } else { itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, sTemps)); }
                itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = lColor;
                if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString())); }
                }
                else
                if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE) { itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = lColor;
                if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL) { itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(); } else { itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(m_sProfit), 2).ToString())); }
                itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = lColor;
                if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT) { itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$"; } else { itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString() + "$")); }
                itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = lColor;
                if (string.IsNullOrEmpty(itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = " "; } else { itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " ")); }
                }
                CalculerTempsFabrication();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterNegatintDansListView", ex);
            }
        }
        private bool VerintierEmplacement(int iIndexSelection)
        {
            bool VerintierEmplacementRet = default;
            try
            {
                ListViewItem itmSoum;
                itmSoum = lvwSoumission.Items[iIndexSelection];
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(itmSoum.Tag, string.Empty, false))) { itmSoum = lvwSoumission.Items[iIndexSelection - 1]; }
                if ((string)itmSoum.Tag == cmbSections.Items[cmbSections.SelectedIndex].ToString()) { VerintierEmplacementRet = true; } else { VerintierEmplacementRet = false; }
                return VerintierEmplacementRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "VerintierEmplacement", ex);
                return false;
            }
        }
        private void CalculerTempsFabricationRecordset(string sNoProjSoum)
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                var dblTempsFab = default(double);
                rstProjet = new Recordset();
                rstPiece = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet ='" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["Temps_total"].Value)))
                    {
                        dblTempsFab = dblTempsFab + double.Parse(Strings.Replace(Strings.Trim(rstPiece.Fields["Temps_total"].Value), ".", ","));
                    }
                    rstPiece.MoveNext();
                }
                rstProjet.Fields["TempsFabrication"].Value = Strings.Replace((dblTempsFab / 10d).ToString(), ".", ",");
                rstProjet.Update();
                rstPiece.Close();
                rstPiece = default;
                rstProjet.Close();
                rstProjet = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerTempsFabricationRecordset", ex);
            }
        }
        private void CalculerTotalRecordset(string sNoProjSoum)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstPunch;
                double dblTotalDessin;
                double dblTotalFabrication;
                double dblTotalAssemblage;
                double dblTotalProgInterface = 0d;
                double dblTotalProgAutomate;
                double dblTotalProgRobot;
                double dblTotalVision;
                double dblTotalTest;
                double dblTotalInstallation;
                double dblTotalMiseService;
                double dblTotalFormation;
                double dblTotalGestion;
                double dblTotalShipping;
                double dblHebergement;
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalPieceImprevue;
                double dblGrandTotal;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET) { rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                if (!rstProjSoum.EOF)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (Droite(sNoProjSoum, 2) == "99") { sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(sNoProjSoum, 6) + "'"; } else { sFilterNoProjet = "NoProjet = '" + sNoProjSoum + "'"; }
                        sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                        sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                        sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                        rstPunch = new Recordset();
                        rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        dblTotalDessin = 0d;
                        dblTotalFabrication = 0d;
                        dblTotalAssemblage = 0d;
                        dblTotalProgInterface = 0d;
                        dblTotalProgAutomate = 0d;
                        dblTotalProgRobot = 0d;
                        dblTotalVision = 0d;
                        dblTotalTest = 0d;
                        dblTotalInstallation = 0d;
                        dblTotalMiseService = 0d;
                        dblTotalFormation = 0d;
                        dblTotalGestion = 0d;
                        dblTotalShipping = 0d;
                        while (!rstPunch.EOF)
                        {
                            //
                            if (!(rstPunch.Fields["Total"].Value is DBNull))
                            {
                                switch (rstPunch.Fields["Type"].Value)
                                {
                                    case "Dessin":
                                        {
                                            if (!(rstProjSoum.Fields["TauxDessin"].Value is DBNull)) { dblTotalDessin = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxDessin"].Value; } else { dblTotalDessin = 0d; }
                                            break;
                                        }
                                    case "Fabrication":
                                        {
                                            if (!(rstProjSoum.Fields["TauxFabrication"].Value is DBNull)) { dblTotalFabrication = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxFabrication"].Value; } else { dblTotalFabrication = 0d; }
                                            break;
                                        }
                                    case "Assemblage":
                                        {
                                            if (!(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull)) { dblTotalAssemblage = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxAssemblage"].Value; } else { dblTotalAssemblage = 0d; }
                                            break;
                                        }
                                    case "ProgInterface":
                                        {
                                            if (!(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull)) { dblTotalProgInterface = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxProgInterface"].Value; } else { dblTotalProgInterface = 0d; }
                                            break;
                                        }
                                    case "ProgAutomate":
                                        {
                                            if (!(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull)) { dblTotalProgAutomate = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxProgAutomate"].Value; } else { dblTotalProgAutomate = 0d; }
                                            break;
                                        }
                                    case "ProgRobot":
                                        {
                                            if (!(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull)) { dblTotalProgRobot = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxProgRobot"].Value; } else { dblTotalProgRobot = 0d; }
                                            break;
                                        }
                                    case "Vision":
                                        {
                                            if (!(rstProjSoum.Fields["TauxVision"].Value is DBNull)) { dblTotalVision = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxVision"].Value; } else { dblTotalVision = 0d; }
                                            break;
                                        }
                                    case "Test":
                                        {
                                            if (!(rstProjSoum.Fields["TauxTest"].Value is DBNull)) { dblTotalTest = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxTest"].Value; } else { dblTotalTest = 0d; }
                                            break;
                                        }
                                    case "Installation":
                                        {
                                            if (!(rstProjSoum.Fields["TauxInstallation"].Value is DBNull)) { dblTotalInstallation = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxInstallation"].Value; } else { dblTotalInstallation = 0d; }
                                            break;
                                        }
                                    case "MiseService":
                                        {
                                            if (!(rstProjSoum.Fields["TauxMiseService"].Value is DBNull)) { dblTotalMiseService = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxMiseService"].Value; } else { dblTotalMiseService = 0d; }
                                            break;
                                        }
                                    case "Formation":
                                        {
                                            if (!(rstProjSoum.Fields["TauxFormation"].Value is DBNull)) { dblTotalFormation = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxFormation"].Value; } else { dblTotalFormation = 0d; }
                                            break;
                                        }
                                    case "Gestion":
                                        {
                                            if (!(rstProjSoum.Fields["TauxGestion"].Value is DBNull)) { dblTotalGestion = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxGestion"].Value; } else { dblTotalGestion = 0d; }
                                            break;
                                        }
                                    case "Shipping":
                                        {
                                            if (!(rstProjSoum.Fields["TauxShipping"].Value is DBNull)) { dblTotalShipping = (double)rstPunch.Fields["Total"].Value * (double)rstProjSoum.Fields["TauxShipping"].Value; } else { dblTotalShipping = 0d; }
                                            break;
                                        }
                                }
                            }
                            rstPunch.MoveNext();
                        }
                        rstPunch.Close();
                        //Object rstPunch
                        rstPunch = default;
                    }
                    else
                    {//
                        if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull) & !(rstProjSoum.Fields["TauxDessin"].Value is DBNull)) { dblTotalDessin = (double)rstProjSoum.Fields["TempsDessin"].Value * (double)rstProjSoum.Fields["TauxDessin"].Value; } else { dblTotalDessin = 0d; }
                        if (rstProjSoum.Fields["SansTemps"].Value == false)
                        {
                            //
                            if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull) & !(rstProjSoum.Fields["TauxFabrication"].Value is DBNull)) { dblTotalFabrication = (double)rstProjSoum.Fields["TempsFabrication"].Value * (double)rstProjSoum.Fields["TauxFabrication"].Value; } else { dblTotalFabrication = 0d; }
                        }
                        else { dblTotalFabrication = 0d; }
                        if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull) & !(rstProjSoum.Fields["TauxAssemblage"].Value is DBNull)) { dblTotalAssemblage = (double)rstProjSoum.Fields["TempsAssemblage"].Value * (double)rstProjSoum.Fields["TauxAssemblage"].Value; } else { dblTotalAssemblage = 0d; }
                        if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull) & !(rstProjSoum.Fields["TauxProgInterface"].Value is DBNull)) { dblTotalProgInterface = (double)rstProjSoum.Fields["TempsProgInterface"].Value * (double)rstProjSoum.Fields["TauxProgInterface"].Value; } else { dblTotalProgInterface = 0d; }
                        if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull) & !(rstProjSoum.Fields["TauxProgAutomate"].Value is DBNull)) { dblTotalProgAutomate = (double)rstProjSoum.Fields["TempsProgAutomate"].Value * (double)rstProjSoum.Fields["TauxProgAutomate"].Value; } else { dblTotalProgAutomate = 0d; }
                        if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull) & !(rstProjSoum.Fields["TauxProgRobot"].Value is DBNull)) { dblTotalProgRobot = (double)rstProjSoum.Fields["TempsProgRobot"].Value * (double)rstProjSoum.Fields["TauxProgRobot"].Value; } else { dblTotalProgRobot = 0d; }
                        if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull) & !(rstProjSoum.Fields["TauxVision"].Value is DBNull)) { dblTotalVision = (double)rstProjSoum.Fields["TempsVision"].Value * (double)rstProjSoum.Fields["TauxVision"].Value; } else { dblTotalVision = 0d; }
                        if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull) & !(rstProjSoum.Fields["TauxTest"].Value is DBNull)) { dblTotalTest = (double)rstProjSoum.Fields["TempsTest"].Value * (double)rstProjSoum.Fields["TauxTest"].Value; } else { dblTotalTest = 0d; }
                        if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull) & !(rstProjSoum.Fields["TauxInstallation"].Value is DBNull)) { dblTotalInstallation = (double)rstProjSoum.Fields["TempsInstallation"].Value * (double)rstProjSoum.Fields["TauxInstallation"].Value; } else { dblTotalInstallation = 0d; }
                        if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull) & !(rstProjSoum.Fields["TauxMiseService"].Value is DBNull)) { dblTotalMiseService = (double)rstProjSoum.Fields["TempsMiseService"].Value * (double)rstProjSoum.Fields["TauxMiseService"].Value; } else { dblTotalMiseService = 0d; }
                        if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull) & !(rstProjSoum.Fields["TauxFormation"].Value is DBNull)) { dblTotalFormation = (double)rstProjSoum.Fields["TempsFormation"].Value * (double)rstProjSoum.Fields["TauxFormation"].Value; } else { dblTotalFormation = 0d; }
                        if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull) & !(rstProjSoum.Fields["TauxGestion"].Value is DBNull)) { dblTotalGestion = (double)rstProjSoum.Fields["TempsGestion"].Value * (double)rstProjSoum.Fields["TauxGestion"].Value; } else { dblTotalGestion = 0d; }
                        if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull) & !(rstProjSoum.Fields["TauxShipping"].Value is DBNull)) { dblTotalShipping = (double)rstProjSoum.Fields["TempsShipping"].Value * (double)rstProjSoum.Fields["TauxShipping"].Value; } else { dblTotalShipping = 0d; }
                    }
                    dblTotalTemps = dblTotalDessin + dblTotalFabrication + dblTotalAssemblage + dblTotalProgInterface + dblTotalProgAutomate + dblTotalProgRobot + dblTotalVision
+ dblTotalTest + dblTotalInstallation + dblTotalMiseService + dblTotalFormation + dblTotalGestion + dblTotalShipping;
                    rstPiece = new Recordset();
                    if (m_eType == EnumType.TYPE_PROJET) { rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjSoum + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                    else
                    {
                        rstPiece.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoProjSoum + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    while (!rstPiece.EOF)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(rstPiece.Fields["Prix_total"].Value)))
                        {
                            dblPrixPieces = dblPrixPieces + (double)rstPiece.Fields["Prix_total"].Value - (double)rstPiece.Fields["Profit_Argent"].Value;
                            dblProfit = dblProfit + (double)rstPiece.Fields["Profit_Argent"].Value;
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    //Object rstPiece
                    rstPiece = default;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        dblHebergement = 0d;
                        dblRepas = 0d;
                        dblTransport = 0d;
                        dblUniteMobile = 0d;
                    }
                    else
                    {
                        if (!(rstProjSoum.Fields["TotalHebergement"].Value is DBNull)) { dblHebergement = (double)rstProjSoum.Fields["TotalHebergement"].Value; } else { dblHebergement = 0d; }
                        if (!(rstProjSoum.Fields["TotalRepas"].Value is DBNull)) { dblRepas = (double)rstProjSoum.Fields["TotalRepas"].Value; } else { dblRepas = 0d; }
                        if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull)) { dblTransport = (double)rstProjSoum.Fields["TempsTransport"].Value * (double)rstProjSoum.Fields["TauxTransport"].Value; } else { dblTransport = 0d; }
                        if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull)) { dblUniteMobile = (double)rstProjSoum.Fields["TempsUniteMobile"].Value * (double)rstProjSoum.Fields["TauxUniteMobile"].Value; } else { dblUniteMobile = 0d; }
                    }
                    if (IsNumeric(rstProjSoum.Fields["PrixEmballage"].Value)) { dblPrixEmballage = (double)rstProjSoum.Fields["PrixEmballage"].Value; } else { dblPrixEmballage = 0d; }
                    dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                    if (IsNumeric(rstProjSoum.Fields["total_manuel"].Value)) { dblTotalManuel = (double)rstProjSoum.Fields["total_manuel"].Value; } else { dblTotalManuel = 0d; }
                    dblTotalPieceImprevue = (dblPrixPieces + dblProfit) * (1d + (double)rstProjSoum.Fields["Imprevue"].Value);
                    dblPrixTotal = dblTotalTemps + dblTotalManuel + dblTotalPieceImprevue + dblTotalResteTemps;
                    dblCommission = dblPrixTotal * (double)rstProjSoum.Fields["Commission"].Value;
                    dblGrandTotal = dblPrixTotal + dblCommission;
                    rstProjSoum.Fields["total_commission"].Value = dblCommission;
                    rstProjSoum.Fields["Total_manuel"].Value = dblTotalManuel;
                    rstProjSoum.Fields["Total_temps"].Value = dblTotalTemps;
                    rstProjSoum.Fields["total_imprevue"].Value = dblTotalPieceImprevue - (dblPrixPieces + dblProfit);
                    rstProjSoum.Fields["total_piece"].Value = dblPrixPieces;
                    rstProjSoum.Fields["Total_Commission"].Value = Math.Round(dblCommission, 2).ToString() + "$";
                    rstProjSoum.Fields["PrixTotal"].Value = Math.Round(dblGrandTotal, 2).ToString() + "$";
                    rstProjSoum.Fields["Total_Profit"].Value = Math.Round(dblProfit, 2).ToString() + "$";
                    rstProjSoum.Update();
                }
                else
                if (m_eType == EnumType.TYPE_PROJET) { MessageBox.Show("Le projet " + sNoProjSoum + " est inexistant!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); } else { MessageBox.Show("La soumission " + sNoProjSoum + " est inexistant!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                rstProjSoum.Close();
                rstProjSoum = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerTotalRecordset " + sNoProjSoum, ex);
            }
        }
        private void CalculerPrixFacturation(string sNoFacturation, ref string sCommission, ref string sPrixTotal, ref string sProfit, ref string sTempsFabrication, ref string sTotalPiece, ref string sImprevue, ref string sTotalTemps, ref string sManuel)
        {
            try
            {
                int X;
                double dblTotalDessin;
                double dblTotalFabrication;
                double dblTotalAssemblage;
                double dblTotalProgInterface;
                double dblTotalProgAutomate;
                double dblTotalProgRobot;
                double dblTotalVision;
                double dblTotalTest;
                double dblTotalInstallation;
                double dblTotalMiseService;
                double dblTotalFormation;
                double dblTotalGestion;
                double dblTotalShipping;
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalPieceImprevue;
                double dblGrandTotal;
                var dblTempsFabrication = default(double);
                dblTotalDessin = double.Parse(m_sTempsDessin) * double.Parse(m_sTauxDessin);
                if (m_bSansTemps == false) { dblTotalFabrication = double.Parse(m_sTempsFabrication) * double.Parse(m_sTauxFabrication); }
                else
                {
                    dblTotalFabrication = 0d;
                }
                dblTotalAssemblage = double.Parse(m_sTempsAssemblage) * double.Parse(m_sTauxAssemblage);
                dblTotalProgInterface = double.Parse(m_sTempsProgInterface) * double.Parse(m_sTauxProgInterface);
                dblTotalProgAutomate = double.Parse(m_sTempsProgAutomate) * double.Parse(m_sTauxProgAutomate);
                dblTotalProgRobot = double.Parse(m_sTempsProgRobot) * double.Parse(m_sTauxProgRobot);
                dblTotalVision = double.Parse(m_sTempsVision) * double.Parse(m_sTauxVision);
                dblTotalTest = double.Parse(m_sTempsTest) * double.Parse(m_sTauxTest);
                dblTotalInstallation = double.Parse(m_sTempsInstallation) * double.Parse(m_sTauxInstallation);
                dblTotalMiseService = double.Parse(m_sTempsMiseService) * double.Parse(m_sTauxMiseService);
                dblTotalFormation = double.Parse(m_sTempsFormation) * double.Parse(m_sTauxFormation);
                dblTotalGestion = double.Parse(m_sTempsGestion) * double.Parse(m_sTauxGestion);
                dblTotalShipping = double.Parse(m_sTempsShipping) * double.Parse(m_sTauxShipping);
                dblTotalTemps = dblTotalDessin + dblTotalFabrication + dblTotalAssemblage + dblTotalProgInterface + dblTotalProgAutomate
                    + dblTotalProgRobot + dblTotalVision + dblTotalTest + dblTotalInstallation + dblTotalMiseService + dblTotalFormation
                    + dblTotalGestion + dblTotalShipping;
                for (X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if (lvwSoumission.Items[X].Tag != string.Empty)
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text) & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text != "Text")
                        {
                            if ((lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text ?? "") == (sNoFacturation ?? ""))
                            {
                                if (!string.IsNullOrEmpty(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_TOTAL].Text)))
                                {
                                    dblPrixPieces += double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_TOTAL].Text);
                                    dblProfit += double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text);
                                    if (m_bSansTemps == false)
                                    {
                                        if (!string.IsNullOrEmpty(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_MONTAGE].Text))) { dblTempsFabrication = dblTempsFabrication + double.Parse(lvwSoumission.Items[X].SubItems[I_COL_SOUM_MONTAGE].Text); }
                                    }
                                }
                            }
                        }
                    }
                }
                if (IsNumeric(txtPrixManuel.Text))
                {
                    dblTotalManuel = double.Parse(txtPrixManuel.Text);
                }
                else { dblTotalManuel = 0d; }
                dblTotalPieceImprevue = dblPrixPieces * (1d + double.Parse(m_sImprevue));
                dblPrixTotal = dblTotalTemps + dblTotalManuel + dblTotalPieceImprevue;
                dblCommission = dblPrixTotal * double.Parse(m_sCommission);
                dblGrandTotal = dblPrixTotal + dblCommission;
                sCommission = Math.Round(dblCommission, 2).ToString() + "$";
                sPrixTotal = Math.Round(dblGrandTotal, 2).ToString() + "$";
                sProfit = Math.Round(dblProfit, 2).ToString() + "$";
                sTempsFabrication = dblTempsFabrication.ToString();
                sImprevue = Math.Round(dblPrixPieces * double.Parse(m_sImprevue), 2).ToString() + "$";
                sManuel = Math.Round(dblTotalManuel, 2).ToString() + "$";
                sTotalPiece = Math.Round(dblPrixPieces, 2).ToString() + "$";
                sTotalTemps = Math.Round(dblTotalTemps, 2).ToString() + "$";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerPrix", ex);
            }
        }
        private void ChoisirFournisseur1()
        {
            try
            {
                string sQuantite;
                var sSousSection = default(string);
                var bDemanderSS = default(bool);
                string sParams;
                if (lvwSoumission.Items.Count > 0)
                {
                    if (lvwSoumission.FocusedItem.Index > 1)
                    {
                        if (VerintierEmplacement(lvwSoumission.FocusedItem.Index) == true)
                        {
                            if (lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Tag != string.Empty)
                            {
                                if (lvwSoumission.Items[lvwSoumission.FocusedItem.Index - 1].Tag != string.Empty)
                                {
                                    MessageBox.Show("Vous ne pouvez pas mettre une pièce entre une section et une sous-section", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    fraFournisseur.Visible = false;
                                    Deselect();
                                    lvwSoumission.Items[1].Selected = true;
                                    return;
                                }
                                else
                                {
                                    sSousSection = (string)lvwSoumission.Items[lvwSoumission.FocusedItem.Index - 1].SubItems[I_COL_SOUM_PIECE].Tag;
                                }
                            }
                            else
                            {
                                sSousSection = (string)lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Tag;
                            }
                        }
                    }
                    else
                    { bDemanderSS = true; }
                }
                else
                {
                    bDemanderSS = true;
                }
                sQuantite = Interaction.InputBox("Quelle est la quantité?");
                sQuantite = Strings.Replace(sQuantite, ".", ",");
                if (!string.IsNullOrEmpty(sQuantite))
                {
                    if (!IsNumeric(sQuantite))
                    {
                        MessageBox.Show("Quantité non numérique!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    if (double.Parse(sQuantite) < 0d)
                    {
                        if (lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT") { MessageBox.Show("Impossible de faire une demande de prix sur une pièce négative!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
                    }
                }
                else
                {
                    return;
                }
                if (bDemanderSS == true)
                {
                    if ((m_sSousSection ?? "") != S_PAS_SOUS_SECTION)
                    {
                        sSousSection =
                                             Interaction.InputBox("Quelle est la sous-section?", DefaultResponse: m_sSousSection);
                    }
                    else
                    {
                        sSousSection =
                                             Interaction.InputBox("Quelle est la sous-section?");
                    }
                }
                if (string.IsNullOrEmpty(sSousSection))
                {
                    sSousSection = S_PAS_SOUS_SECTION;
                    m_sSousSection = string.Empty;
                }
                else { m_sSousSection = sSousSection; }
                if (double.Parse(sQuantite) < 0d)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 60d & double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 98d) { AjouterNegatintDansListView(double.Parse(sQuantite), sSousSection); } else { AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection); }
                    }
                    else
                    { AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection); }
                }
                else
                {
                    AjouterDansListViewSoumission(double.Parse(sQuantite), sSousSection);
                }
                CalculerPrix();
                fraFournisseur.Visible = false;
                if (lvwSoumission.Items.Count > 0)
                {
                    Deselect();
                    lvwSoumission.Items[1].Selected = true;
                }
                return;
            }
            catch (Exception ex)
            {
                if (Information.Err().Number == 13 & Information.Erl() == 110)
                {
                    ex.Source = (string)Operators.ConcatenateObject("cmbSections.Text : " + cmbSections.Text + "   " + "No Proj/Soum : " + txtNoProjSoum.Text + "   " + "lvwSoumission.SelectedItem.Index - 1 : " + (lvwSoumission.FocusedItem.Index - 1) + "   " + "lvwSoumission.ListItems(lvwSoumission.SelectedItem.Index - 1).ListSubItems(I_COL_SOUM_MANUFACT).Tag : ", lvwSoumission.Items[lvwSoumission.FocusedItem.Index - 1].SubItems[I_COL_SOUM_MANUFACT].Tag);
                    AfficherErreur("ProjSoumElec", "ChoisirFournisseur", ex);
                }
                else
                {
                    AfficherErreur("ProjSoumElec", "ChoisirFournisseur", ex);
                }
            }
        }
        private void AfficherListeFournisseurs()
        {
            try
            {
                RemplirListViewFournisseur();
                if (lvwFournisseur.Items.Count > 1)
                {
                    if (m_bRecherchePiece == true) { fraPieceTrouve.Visible = false; }
                    fraFournisseur.Visible = true;
                    lvwFournisseur.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AfficherListeFournisseurs", ex);
            }
        }
        private void FacturerDate()
        {
            try
            {
                int X;
                for (X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, "", false)))
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            if (lvwSoumission.Items[X].Selected == true)
                            {
                                if (Gauche(lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text, 2) == "F-")
                                {
                                    if (lvwSoumission.Items[X].SubItems.Count > I_COL_SOUM_FACTURATION) { lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text = ""; } else { lvwSoumission.Items[X].SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, "")); }
                                }
                                if (string.IsNullOrEmpty(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text)))
                                {
                                    if (lvwSoumission.Items[X].SubItems.Count > I_COL_SOUM_FACTURATION) { lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text = "F-" + txtDateFacturation.Text; } else { lvwSoumission.Items[X].SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, "F-" + txtDateFacturation.Text)); }
                                }
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "FacturerDate", ex);
            }
        }
        private void FacturerNC()
        {
            try
            {
                int X;
                for (X = 1; X <= lvwSoumission.Items.Count; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, "", false)))
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            if (lvwSoumission.Items[X].Selected == true)
                            {
                                if (lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text == "NC")
                                {
                                    if (lvwSoumission.Items[X].SubItems.Count > I_COL_SOUM_FACTURATION) { lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text = ""; } else { lvwSoumission.Items[X].SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, "")); }
                                }
                                if (string.IsNullOrEmpty(Strings.Trim(lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text)))
                                {
                                    if (lvwSoumission.Items[X].SubItems.Count > I_COL_SOUM_FACTURATION)
                                    {
                                        lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text = "NC";
                                    }
                                    else
                                    {
                                        lvwSoumission.Items[X].SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, "NC"));
                                    }
                                }
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "FacturerNC", ex);
            }
        }
        private void RechercherPieceListViewSoumission(string sTexte)
        {
            try
            {
                int X;
                int iSelected;
                var bTrouve = default(bool);
                if (lvwSoumission.FocusedItem.Index == 1) { iSelected = 1; }
                else
                if (lvwSoumission.FocusedItem.Index + 1 > lvwSoumission.Items.Count) { iSelected = 1; } else { iSelected = lvwSoumission.FocusedItem.Index + 1; }
                var loopTo = lvwSoumission.Items.Count;
                for (X = iSelected; X <= loopTo; X++)
                {
                    if (Strings.InStr(1, Strings.UCase(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text), Strings.UCase(sTexte)) > 0)
                    {
                        lvwSoumission.Focus();
                        Deselect();
                        lvwSoumission.Items[X].Selected = true;
                        lvwSoumission.FocusedItem.EnsureVisible();
                        bTrouve = true;
                        break;
                    }
                }
                if (bTrouve == false)
                {
                    var loopTo1 = iSelected - 1;
                    for (X = 1; X <= loopTo1; X++)
                    {
                        if (Strings.InStr(1, Strings.UCase(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text), Strings.UCase(sTexte)) > 0)
                        {
                            lvwSoumission.Focus(); Deselect(); lvwSoumission.Items[X].Selected = true;
                        }
                    }
                    if (bTrouve == false) { MessageBox.Show("Aucun enregistrement trouvé!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RechercherPieceListViewSoumission", ex);
            }
        }
        private void EffacerItemListViewSoumission()
        {
            var COLOR_BRUN = default(object);
            try
            {
                bool bSeulSS;
                bool bSeulS;
                int iIndex;
                ListViewItem itmPrecedent;
                ListViewItem itmSuivant;
                int X;
                string sMessage;
                var iNbreSelected = default(int);
                bool bSupprimer;
                var bPermission = default(bool);
                var loopTo = lvwSoumission.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lvwSoumission.Items[X].Selected == true)
                    {
                        iNbreSelected++;
                        if (iNbreSelected > 1) { break; }
                    }
                }
                if (iNbreSelected > 1) { sMessage = "Voulez-vous vraiment effacer ces pièces?"; } else { sMessage = "Voulez-vous vraiment effacer cette pièce?"; }
                if (m_eType == EnumType.TYPE_SOUMISSION) { bPermission = true; }
                else
                if (iNbreSelected > 1) { bPermission = true; }
                else
                {
                    var loopTo1 = lvwSoumission.Items.Count;
                    for (X = 1; X <= loopTo1; X++)
                    {
                        if (lvwSoumission.Items[X].Selected == true) { break; }
                    }
                    if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_NOIR, false), Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BRUN, false)), Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_MAGENTA, false)))) { bPermission = true; }
                }
                X = 1;
                if (bPermission == true)
                {
                    if (MessageBox.Show(sMessage, "Projet soumission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        while (X <= lvwSoumission.Items.Count)
                        {
                            bSupprimer = false; bSeulS = false; bSeulSS = false;
                            if (lvwSoumission.Items[X].Selected == true)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, string.Empty, false)))
                                {
                                    if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                                    {
                                        if (m_eType == EnumType.TYPE_SOUMISSION)
                                        {
                                            bSupprimer = true;
                                        }
                                        else
                                        if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_NOIR, false), Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_BRUN, false)), Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor, COLOR_MAGENTA, false)))) { bSupprimer = true; }
                                        if (bSupprimer == true)
                                        {
                                            if (string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text))
                                            {
                                                if (lvwSoumission.Items[X].SubItems.Count > I_COL_SOUM_PROFIT)
                                                {
                                                    lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Text = " ";
                                                }
                                                else
                                                {
                                                    lvwSoumission.Items[X].SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, " "));
                                                }
                                            }
                                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PROFIT].Tag, "EXTRA", false)))
                                            {
                                                if (m_bModeAjout == false) { AjouterSuppressionList<String>(X); }
                                                iIndex = X;
                                                if (iIndex == lvwSoumission.Items.Count)
                                                {
                                                    if (string.IsNullOrEmpty(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_PIECE].Text))
                                                    {
                                                        bSeulSS = true;
                                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[iIndex - 2].Tag, string.Empty, false)))
                                                        {
                                                            bSeulS = true;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    itmPrecedent = lvwSoumission.Items[iIndex - 1]; itmSuivant = lvwSoumission.Items[iIndex + 1];
                                                    if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(itmPrecedent.SubItems[I_COL_SOUM_PIECE].Tag, string.Empty, false), Operators.OrObject(Operators.ConditionalCompareObjectEqual(itmSuivant.Tag, string.Empty, false), Operators.AndObject(Operators.ConditionalCompareObjectNotEqual(itmSuivant.Tag, string.Empty, false), Operators.ConditionalCompareObjectEqual(itmSuivant.SubItems[I_COL_SOUM_PIECE].Tag, string.Empty, false))))))
                                                    {
                                                        bSeulSS = true;
                                                        if (lvwSoumission.Items[iIndex - 2].Tag != string.Empty & itmSuivant.Tag != string.Empty)
                                                        {
                                                            bSeulS = true;
                                                        }
                                                    }
                                                }
                                                lvwSoumission.Items.RemoveAt(iIndex);
                                                if (bSeulSS == true) { lvwSoumission.Items.RemoveAt(iIndex - 1); X++; }
                                                if (bSeulS == true) { lvwSoumission.Items.RemoveAt(iIndex - 2); X++; }
                                                CalculerTempsFabrication();
                                                CalculerPrix();
                                            }
                                            else
                                            {
                                                MessageBox.Show("La pièce " + lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text + " doit être effacée dans le projet " + lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PROVENANCE].Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); X++;
                                            }
                                        }
                                        else { MessageBox.Show("La pièce " + lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text + " ne peut pas être supprimée!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); X++; }
                                    }
                                    else { X++; }
                                }
                                else { X++; }
                            }
                            else { X++; }
                        }
                    }
                    else
                    { bPermission = false; }
                }
                if (lvwSoumission.Items.Count > 0)
                {
                    if (bPermission == true)
                    {
                        Deselect();
                        lvwSoumission.Items[1].Selected = true;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "EffacerItemListViewSoumission", ex);
            }
        }
        private void AjouterSuppressionList<String>(int iIndex)
        {
            try
            {
                if (lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Text != "Texte" & lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text != "Text")
                {
                    m_collQteSupp.Add(Strings.Replace(lvwSoumission.Items[iIndex].Text, "*", ""));
                    m_collNoItemSupp.Add(lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Text);
                    m_collDateSupp.Add(ConvertDate(DateTime.Today));
                    m_collHeureSupp.Add(DateTime.Now.ToShortTimeString());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterSuppressionList<String>", ex);
            }
        }
        private void EnregistrerSuppression()
        {
            try
            {
                ADODB.Recordset rstBavard;
                ADODB.Recordset rstEmploye;
                bool iNoEmploye;
                int X;
                rstBavard = new Recordset();
                rstEmploye = new Recordset();
                rstBavard.Open("SELECT * FROM BavardSuppression", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoEmploye = rstEmploye.Fields["noEmploye"].Value;
                rstEmploye.Close();
                rstEmploye = default;
                var loopTo = m_collNoItemSupp.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    rstBavard.AddNew();
                    rstBavard.Fields["IDUser"].Value = iNoEmploye;
                    rstBavard.Fields["NoProjsoum"].Value = txtNoProjSoum.Text;
                    rstBavard.Fields["Type"].Value = "E";
                    rstBavard.Fields["Qté"].Value = m_collQteSupp[X];
                    rstBavard.Fields["No Item"].Value = m_collNoItemSupp[X];
                    rstBavard.Fields["Date"].Value = m_collDateSupp[X];
                    rstBavard.Fields["Heure"].Value = m_collHeureSupp[X];
                    rstBavard.Update();
                }
                rstBavard.Close();
                rstBavard = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "EnregistrerSuppression", ex);
            }
        }
        private void RemplirComboFournisseur()
        {
            try
            {
                ADODB.Recordset rstFRS;
                bool bExiste;
                rstFRS = new Recordset();
                cmbfrs.Items.Clear();
                rstFRS.Open("SELECT PiecesFRS.*, Fournisseur.NomFournisseur FROM PiecesFRS " +
                    "INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Replace(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text, "'", "''") + "' ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    bExiste = false;
                    for (int X = 0; X <= cmbfrs.Items.Count - 1; X++)
                    {
                        if (cmbfrs.Items[X].ToString() == rstFRS.Fields[16].Value) { bExiste = true; break; }
                    }
                    if (bExiste == false)
                    {
                        cmbfrs.Items.Add($"{rstFRS.Fields[16].Value} - {rstFRS.Fields[1].Value}");
                    }
                    rstFRS.MoveNext();
                }
                rstFRS.Close();
                rstFRS = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirComboFournisseur", ex);
            }
        }
        private void CalculerPrixNet()
        {
            try
            {
                double dblEscompte;
                double dblPrix;
                if (txtPrixNet.ReadOnly == false)
                {
                    mskEscompte.Text = Strings.Replace(mskEscompte.Text, "_", string.Empty);
                    mskEscompte.Text = Strings.Replace(mskEscompte.Text, ".", ",");
                    if (!string.IsNullOrEmpty(mskEscompte.Text))
                    {
                        dblEscompte = double.Parse(mskEscompte.Text);
                    }
                    else { dblEscompte = 0d; }
                    if (!string.IsNullOrEmpty(txtPrixList.Text)) { dblPrix = double.Parse(Strings.Replace(txtPrixList.Text, ".", ",")); } else { dblPrix = 0d; }
                    txtPrixNet.Text = Math.Round(dblPrix * (1d - dblEscompte), 4).ToString();
                    txtPrixNet.Text = Strings.Replace(txtPrixNet.Text, ".", ",");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CalculerPrixNet", ex);
            }
        }
        private void ViderChamps_frs()
        {
            try
            {
                txtPrixList.Text = string.Empty;
                mskEscompte.Text = string.Empty;
                txtPrixNet.Text = string.Empty;
                txtPrixSpecial.Text = string.Empty;
                optCAN.Checked = true;
                AfficherDrapeau();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ViderChamps_frs", ex);
            }
        }
        private void AfficherDrapeau()
        {
            try
            {
                if (optCAN.Checked == true)
                {
                    imgCanada.Visible = true;
                    imgEU.Visible = false;
                    imgSpain.Visible = false;
                }
                else if (optUSA.Checked == true)
                {
                    imgEU.Visible = true;
                    imgCanada.Visible = false;
                    imgSpain.Visible = false;
                }
                else
                {
                    imgSpain.Visible = true;
                    imgCanada.Visible = false;
                    imgEU.Visible = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AfficherDrapeau", ex);
            }
        }
        private void ModintierPrixCatalogue()
        {
            try
            {
                ADODB.Recordset rstPrix;
                double dblPrixList;
                double dblEscompte;
                double dblPrixNet;
                if (!string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text))) { dblPrixList = double.Parse(txtPrixList.Text); } else { dblPrixList = 0d; }//object mskEscompte.Text.
                if (!string.IsNullOrEmpty(mskEscompte.Text))
                {
                    dblEscompte = double.Parse(mskEscompte.Text);
                }
                else { dblEscompte = 0d; }
                if (!string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text))) { dblPrixNet = double.Parse(txtPrixNet.Text); } else { dblPrixNet = double.Parse(txtPrixSpecial.Text); }
                rstPrix = new Recordset();
                if (txtPrixNet.Enabled == true)
                {
                    rstPrix.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + lvwSoumission.Items[(int)fraPrixPiece.Tag].SubItems[I_COL_SOUM_PIECE].Text.Replace("'", "''") + "' AND IDFRS = " + cmbfrs.Items[cmbfrs.SelectedIndex].ToString() + " AND PRIX_NET <> ''", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPrix.EOF)
                    {
                        rstPrix.AddNew();
                        rstPrix.Fields["PIECE"].Value = lvwSoumission.Items[(int)fraPrixPiece.Tag].SubItems[I_COL_SOUM_PIECE].Text;
                        rstPrix.Fields["IDFRS"].Value = GetFournisseurID(cmbfrs.Items[cmbfrs.SelectedIndex].ToString());
                    }
                    rstPrix.Fields["PRIX_LIST"].Value = dblPrixList;
                    rstPrix.Fields["ESCOMPTE"].Value = dblEscompte;
                    rstPrix.Fields["PRIX_NET"].Value = dblPrixNet;
                    rstPrix.Fields["PRIX_SP"].Value = "";
                }
                else
                {
                    rstPrix.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + cmbfrs.Items[cmbfrs.SelectedIndex].ToString() + "' AND IDFRS = " + cmbfrs.Items[cmbfrs.SelectedIndex].ToString() + " AND PRIX_SP <> ''", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPrix.EOF)
                    {
                        rstPrix.AddNew();
                        rstPrix.Fields["PIECE"].Value = lvwSoumission.Items[(int)fraPrixPiece.Tag].SubItems[I_COL_SOUM_PIECE].Text;
                        rstPrix.Fields["IDFRS"].Value = GetFournisseurID(cmbfrs.Items[cmbfrs.SelectedIndex].ToString());
                    }
                    rstPrix.Fields["PRIX_SP"].Value = dblPrixNet;
                    rstPrix.Fields["PRIX_LIST"].Value = "";
                    rstPrix.Fields["ESCOMPTE"].Value = "";
                    rstPrix.Fields["PRIX_NET"].Value = "";
                }
                if (optCAN.Checked == true) { rstPrix.Fields["DeviseMonétaire"].Value = "CAN"; }
                else
                if (optUSA.Checked == true) { rstPrix.Fields["DeviseMonétaire"].Value = "USA"; } else { rstPrix.Fields["DeviseMonétaire"].Value = "SPA"; }
                rstPrix.Fields["Type"].Value = "E";
                rstPrix.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                rstPrix.Fields["Date"].Value = ConvertDate(DateTime.Today);
                rstPrix.Update();
                rstPrix.Close();
                rstPrix = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModintierPrixCatalogue", ex);
            }
        }
        private bool VerintierSiOuvert(ref string sUser)
        {
            bool VerintierSiOuvertRet = default;
            try
            {
                ADODB.Recordset rstProjSoum;
                bool bModintication;
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET) { rstProjSoum.Open("SELECT Modintication, Par FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstProjSoum.Open("SELECT Modintication, Par FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                if (rstProjSoum.Fields["Modintication"].Value == true)
                {
                    sUser = rstProjSoum.Fields["Par"].Value;
                    bModintication = true;
                }
                else
                {
                    sUser = "";
                    bModintication = false;
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                VerintierSiOuvertRet = bModintication;
                return VerintierSiOuvertRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "VerintierSiOuvert", ex);
                return false;
            }
        }
        private void OuvrirProjSoum(bool bOuvrir)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                rstProjSoum = new Recordset();
                rstProjSoum.CursorLocation = CursorLocationEnum.adUseServer;
                if (m_eType == EnumType.TYPE_PROJET) { rstProjSoum.Open("SELECT Modintication, Par FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstProjSoum.Open("SELECT Modintication, Par FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } while (!rstProjSoum.EOF)
                {
                    if (bOuvrir == true)
                    {
                        rstProjSoum.Fields["Modintication"].Value = true;
                        rstProjSoum.Fields["Par"].Value = IdNoEmploye.ToString();
                    }
                    else
                    {
                        rstProjSoum.Fields["Modintication"].Value = false;
                        rstProjSoum.Fields["Par"].Value = "";
                    }
                    rstProjSoum.Update();
                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "OuvrirProjSoum", ex);
            }
        }
        private void AnnulerCommande()
        {
            try
            {
                ADODB.Recordset rstProjet;
                ListViewItem itmAvant;
                ListViewItem itmAnnulation;
                var sExtra = default(string);
                if (Operators.CompareString(Droite(txtNoProjSoum.Text, 2), "00", false) >= 0 & Operators.CompareString(Droite(txtNoProjSoum.Text, 2), "19", false) <= 0)
                {
                    sExtra =
                   Interaction.InputBox("Dans quel extra l'annulation de commande doit être faite ? (2 chintfres seulement)");
                    if (Strings.Len(sExtra) != 2)
                    {
                        MessageBox.Show("Format incorrect!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (!IsNumeric(sExtra))
                    {
                        MessageBox.Show("L'extra doit être numérique!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (double.Parse(sExtra) < 60d | double.Parse(sExtra) > 98d)
                    {
                        MessageBox.Show("L'extra doit être entre 60 et 98!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjet.EOF)
                    {
                        MessageBox.Show("Le projet " + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + " n'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        rstProjet.Close();
                        rstProjet = default;
                        return;
                    }
                    else
                    {
                        rstProjet.Close();
                        rstProjet = default;
                    }
                }
                itmAvant = lvwSoumission.FocusedItem;
                itmAnnulation = lvwSoumission.Items.Insert(itmAvant.Index + 1, "");
                itmAnnulation.Checked = itmAvant.Checked;
                itmAnnulation.Text = "-" + itmAvant.Text;
                itmAnnulation.Tag = itmAvant.Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_PIECE) { itmAnnulation.SubItems[I_COL_SOUM_PIECE].Text = itmAvant.SubItems[I_COL_SOUM_PIECE].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PIECE].Text)); }
                itmAnnulation.SubItems[I_COL_SOUM_PIECE].Tag = itmAvant.SubItems[I_COL_SOUM_PIECE].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_DESCR) { itmAnnulation.SubItems[I_COL_SOUM_DESCR].Text = itmAvant.SubItems[I_COL_SOUM_DESCR].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DESCR].Text)); }
                itmAnnulation.SubItems[I_COL_SOUM_DESCR].Tag = itmAvant.SubItems[I_COL_SOUM_DESCR].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_MANUFACT) { itmAnnulation.SubItems[I_COL_SOUM_MANUFACT].Text = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text)); }
                itmAnnulation.SubItems[I_COL_SOUM_MANUFACT].Tag = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmAnnulation.SubItems[I_COL_SOUM_PRIX_LIST].Text = itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Text)); }
                itmAnnulation.SubItems[I_COL_SOUM_PRIX_LIST].Tag = itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmAnnulation.SubItems[I_COL_SOUM_ESCOMPTE].Text = itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].Text)); }
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmAnnulation.SubItems[I_COL_SOUM_PRIX_NET].Text = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Text)); }
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_DISTRIB) { itmAnnulation.SubItems[I_COL_SOUM_DISTRIB].Text = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text)); }
                itmAnnulation.SubItems[I_COL_SOUM_DISTRIB].Tag = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_TEMPS) { itmAnnulation.SubItems[I_COL_SOUM_TEMPS].Text = itmAvant.SubItems[I_COL_SOUM_TEMPS].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_TEMPS].Text)); }
                if (!string.IsNullOrEmpty(Strings.Trim(itmAnnulation.SubItems[I_COL_SOUM_TEMPS].Text)))
                {
                    if (itmAnnulation.SubItems.Count > I_COL_SOUM_MONTAGE) { itmAnnulation.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(Strings.Replace(itmAnnulation.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmAnnulation.Text, "*", string.Empty))).ToString(); } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmAnnulation.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmAnnulation.Text, "*", string.Empty))).ToString())); }
                }
                else
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_MONTAGE) { itmAnnulation.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_TOTAL) { itmAnnulation.SubItems[I_COL_SOUM_TOTAL].Text = "-" + itmAvant.SubItems[I_COL_SOUM_TOTAL].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_SOUM_TOTAL].Text)); }
                if (itmAnnulation.SubItems.Count > I_COL_SOUM_PROFIT) { itmAnnulation.SubItems[I_COL_SOUM_PROFIT].Text = "-" + itmAvant.SubItems[I_COL_SOUM_PROFIT].Text; } else { itmAnnulation.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_SOUM_PROFIT].Text)); }
                if (Operators.CompareString(Droite(txtNoProjSoum.Text, 2), "00", false) >= 0 & Operators.CompareString(Droite(txtNoProjSoum.Text, 2), "19", false) <= 0)
                {
                    itmAnnulation.SubItems[I_COL_SOUM_PROFIT].Tag = "ANNULATION " + sExtra;
                }
                itmAnnulation.SubItems[I_COL_SOUM_PIECE].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_DESCR].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_DISTRIB].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_MANUFACT].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_MONTAGE].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_PROFIT].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_TEMPS].ForeColor = COLOR_VERT_FORET;
                itmAnnulation.SubItems[I_COL_SOUM_TOTAL].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_PIECE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_DESCR].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_DISTRIB].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_MANUFACT].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_MONTAGE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_PROFIT].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_TEMPS].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_TOTAL].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_DATE_COMMANDE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_DATE_REQUISE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_NOM_COMMANDE].ForeColor = COLOR_VERT_FORET;
                itmAvant.SubItems[I_COL_SOUM_NO_SEQUENTIEL].ForeColor = COLOR_VERT_FORET;
                lvwSoumission.Refresh();
                CalculerPrix();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AnnulerCommande", ex);
            }
        }
        private void CopierPiece()
        {
            try
            {
                ListViewItem itmCopier;
                int iNbreSelect;
                int X;
                var iNbreSelected = default(int);
                var iIndex = default(int);
                var loopTo = lvwSoumission.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lvwSoumission.Items[X].Selected == true)
                    {
                        if ((lvwSoumission.Items[X].Tag.ToString()== "")| string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            MessageBox.Show("Impossible de copier, la sélection contient une section ou une sous-section!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return; 
                        } else { iNbreSelected++; }
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                m_iNbreCopie = iNbreSelected;
                m_arr_tyCopie = new CopiePiece[iNbreSelected];
                var loopTo1 = lvwSoumission.Items.Count;
                for (X = 1; X <= loopTo1; X++)
                {
                    if (lvwSoumission.Items[X].Selected == true)
                    {
                        itmCopier = lvwSoumission.Items[X];
                        m_arr_tyCopie[iIndex].lColor = itmCopier.SubItems[I_COL_SOUM_PIECE].ForeColor;
                        m_arr_tyCopie[iIndex].bChecked = itmCopier.Checked;
                        m_arr_tyCopie[iIndex].sQuantite = itmCopier.Text;
                        m_arr_tyCopie[iIndex].sPiece = itmCopier.SubItems[I_COL_SOUM_PIECE].Text;
                        m_arr_tyCopie[iIndex].sDescr = itmCopier.SubItems[I_COL_SOUM_DESCR].Text;
                        m_arr_tyCopie[iIndex].sDescrTag = (string)itmCopier.SubItems[I_COL_SOUM_DESCR].Tag;
                        m_arr_tyCopie[iIndex].sManufact = itmCopier.SubItems[I_COL_SOUM_MANUFACT].Text;
                        m_arr_tyCopie[iIndex].sPrixList = itmCopier.SubItems[I_COL_SOUM_PRIX_LIST].Text;
                        m_arr_tyCopie[iIndex].sPrixListTag = (string)itmCopier.SubItems[I_COL_SOUM_PRIX_LIST].Tag;
                        m_arr_tyCopie[iIndex].sEscompte = itmCopier.SubItems[I_COL_SOUM_ESCOMPTE].Text;
                        m_arr_tyCopie[iIndex].sPrixNet = itmCopier.SubItems[I_COL_SOUM_PRIX_NET].Text;
                        m_arr_tyCopie[iIndex].sFRS = itmCopier.SubItems[I_COL_SOUM_DISTRIB].Text;
                        m_arr_tyCopie[iIndex].sFRSTag = (string)itmCopier.SubItems[I_COL_SOUM_DISTRIB].Tag;
                        m_arr_tyCopie[iIndex].sTemps = itmCopier.SubItems[I_COL_SOUM_TEMPS].Text;
                        m_arr_tyCopie[iIndex].sMontage = itmCopier.SubItems[I_COL_SOUM_MONTAGE].Text;
                        m_arr_tyCopie[iIndex].sTotal = itmCopier.SubItems[I_COL_SOUM_TOTAL].Text;
                        m_arr_tyCopie[iIndex].sProfit = itmCopier.SubItems[I_COL_SOUM_PROFIT].Text;
                        iIndex++;
                    }
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CopierPiece", ex);
            }
        }
        private void CollerPiece()
        {
            try
            {
                string sIDSection;
                string sOrdreSection;
                string sSousSection;
                ListViewItem itmColler;
                int X;
                int iIndexSelected;
                int iIndex;
                if (m_iNbreCopie == 0) { return; }
                iIndexSelected = lvwSoumission.FocusedItem.Index;
                if (iIndexSelected >= 3)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.FocusedItem.Tag, string.Empty, false))) { iIndex = iIndexSelected - 1; }
                    else
                    if (string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[iIndexSelected - 1].Tag, "", false))) { MessageBox.Show("Impossible de coller la pièce entre une section et une sous-section!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; } else { iIndex = iIndexSelected - 1; }
                    }
                    else
                    { iIndex = iIndexSelected; }
                }
                else
                {
                    MessageBox.Show("Emplacement incorrect!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                sIDSection = (string)lvwSoumission.Items[iIndex].Tag;
                sOrdreSection = (string)lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_MANUFACT].Tag;
                sSousSection = (string)lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Tag;
                Cursor.Current = Cursors.WaitCursor;
                for (X = 0; X <= m_arr_tyCopie.Length; X++)
                {
                    itmColler = lvwSoumission.Items.Insert(iIndexSelected + X, "");
                    itmColler.Checked = m_arr_tyCopie[X].bChecked;
                    itmColler.Text = m_arr_tyCopie[X].sQuantite;
                    itmColler.Tag = sIDSection;
                    if (itmColler.SubItems.Count > I_COL_SOUM_PIECE) { itmColler.SubItems[I_COL_SOUM_PIECE].Text = m_arr_tyCopie[X].sPiece; } else { itmColler.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sPiece)); }
                    itmColler.SubItems[I_COL_SOUM_PIECE].Tag = sSousSection;
                    if (itmColler.SubItems.Count > I_COL_SOUM_DESCR) { itmColler.SubItems[I_COL_SOUM_DESCR].Text = m_arr_tyCopie[X].sDescr; } else { itmColler.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sDescr)); }
                    itmColler.SubItems[I_COL_SOUM_DESCR].Tag = m_arr_tyCopie[X].sDescrTag;
                    if (itmColler.SubItems.Count > I_COL_SOUM_MANUFACT) { itmColler.SubItems[I_COL_SOUM_MANUFACT].Text = m_arr_tyCopie[X].sManufact; } else { itmColler.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sManufact)); }
                    itmColler.SubItems[I_COL_SOUM_MANUFACT].Tag = sOrdreSection;
                    if (itmColler.SubItems.Count > I_COL_SOUM_PRIX_LIST) { itmColler.SubItems[I_COL_SOUM_PRIX_LIST].Text = m_arr_tyCopie[X].sPrixList; } else { itmColler.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sPrixList)); }
                    itmColler.SubItems[I_COL_SOUM_PRIX_LIST].Tag = m_arr_tyCopie[X].sPrixListTag;
                    if (itmColler.SubItems.Count > I_COL_SOUM_ESCOMPTE) { itmColler.SubItems[I_COL_SOUM_ESCOMPTE].Text = m_arr_tyCopie[X].sEscompte; } else { itmColler.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sEscompte)); }
                    if (itmColler.SubItems.Count > I_COL_SOUM_PRIX_NET) { itmColler.SubItems[I_COL_SOUM_PRIX_NET].Text = m_arr_tyCopie[X].sPrixNet; } else { itmColler.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sPrixNet)); }
                    if (itmColler.SubItems.Count > I_COL_SOUM_DISTRIB) { itmColler.SubItems[I_COL_SOUM_DISTRIB].Text = m_arr_tyCopie[X].sFRS; } else { itmColler.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sFRS)); }
                    itmColler.SubItems[I_COL_SOUM_DISTRIB].Tag = m_arr_tyCopie[X].sFRSTag;
                    if (itmColler.SubItems.Count > I_COL_SOUM_TEMPS) { itmColler.SubItems[I_COL_SOUM_TEMPS].Text = m_arr_tyCopie[X].sTemps; } else { itmColler.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sTemps)); }
                    if (itmColler.SubItems.Count > I_COL_SOUM_MONTAGE) { itmColler.SubItems[I_COL_SOUM_MONTAGE].Text = m_arr_tyCopie[X].sMontage; } else { itmColler.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sMontage)); }
                    if (itmColler.SubItems.Count > I_COL_SOUM_TOTAL) { itmColler.SubItems[I_COL_SOUM_TOTAL].Text = m_arr_tyCopie[X].sTotal; } else { itmColler.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sTotal)); }
                    if (itmColler.SubItems.Count > I_COL_SOUM_PROFIT) { itmColler.SubItems[I_COL_SOUM_PROFIT].Text = m_arr_tyCopie[X].sProfit; } else { itmColler.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, m_arr_tyCopie[X].sProfit)); }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        itmColler.SubItems[I_COL_SOUM_PROFIT].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_TOTAL].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_MONTAGE].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_TEMPS].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_DISTRIB].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_DESCR].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_PIECE].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_MANUFACT].ForeColor = m_arr_tyCopie[X].lColor;
                        itmColler.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = m_arr_tyCopie[X].lColor;
                    }
                    else
                    {
                        itmColler.SubItems[I_COL_SOUM_PROFIT].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_TOTAL].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_MONTAGE].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_TEMPS].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_DISTRIB].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_DESCR].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_PIECE].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_MANUFACT].ForeColor = COLOR_NOIR;
                        itmColler.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = COLOR_NOIR;
                    }
                    lvwSoumission.Refresh();
                }
                CalculerTempsFabrication();
                CalculerPrix();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "CollerPiece", ex);
            }
        }
        private bool ValiderFormatElectrique(string sNoProjSoum)
        {
            bool ValiderFormatElectriqueRet = default;
            try
            {
                if (Strings.UCase(Gauche(sNoProjSoum, 1)) == "E") { ValiderFormatElectriqueRet = true; }
                else
                {
                    MessageBox.Show("Un numéro électrique doit absolument commencé par 'E' !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ValiderFormatElectriqueRet = false;
                }
                return ValiderFormatElectriqueRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ValiderFormatElectrique", ex);
                return false;
            }
        }
        private bool ValiderFormatSoumission(string sNoSoumission)
        {
            bool ValiderFormatSoumissionRet = default;
            try
            {
                if (sNoSoumission.Substring(3, 1) == "1") { ValiderFormatSoumissionRet = true; }
                else
                {
                    MessageBox.Show("Une soumission doit absolument avoir un '1' comme 3e caractère !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ValiderFormatSoumissionRet = false;
                }
                return ValiderFormatSoumissionRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ValiderFormatSoumission", ex);
                return false;
            }
        }
        private bool ValiderFormatJobSansSoum(string sNoProjet)
        {
            bool ValiderFormatJobSansSoumRet = default;
            try
            {
                if (sNoProjet.Substring(3, 1) != "3" & sNoProjet.Substring(3, 1) != "1") { ValiderFormatJobSansSoumRet = true; }
                else
                {
                    MessageBox.Show("Un projet créé sans soumission ne peut pas être un '" + sNoProjet.Substring(2, 2) + "' !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ValiderFormatJobSansSoumRet = false;
                }
                return ValiderFormatJobSansSoumRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ValiderFormatJobSansSoum", ex);
                return false;
            }
        }
        private bool ValiderFormatJobAvecSoum(string sNoProjet)
        {
            bool ValiderFormatJobAvecSoumRet = default;
            try
            {
                if (sNoProjet.Substring(3, 1) == "3") { ValiderFormatJobAvecSoumRet = true; }
                else
                {
                    MessageBox.Show("Un projet créé à partir d'une soumission doit absolument avec un '3' comme 3e caractère!", "Création projet", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ValiderFormatJobAvecSoumRet = false;
                }
                return ValiderFormatJobAvecSoumRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ValiderFormatJobAvecSoum", ex);
                return false;
            }
        }
        private bool ValiderFormatJobExtra(string sNoProjet)
        {
            bool ValiderFormatJobExtraRet = default;
            try
            {
                if (int.Parse(Droite(sNoProjet, 2)) >= 50 & int.Parse(Droite(sNoProjet, 2)) <= 98)
                {
                    ValiderFormatJobExtraRet = true;
                }
                else
                {
                    MessageBox.Show("L'entension d'un extra doit être compris entre 50 et 98 !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ValiderFormatJobExtraRet = false;
                }
                return ValiderFormatJobExtraRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ValiderFormatJobExtra", ex);
                return false;
            }
        }
        private void AjouterProjetAuCumulatif()
        {
            try
            {
                string sNoCumulatint;
                ADODB.Recordset rstProj;
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstProjCumulatint;
                ADODB.Recordset rstPiecesCumulatint;
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstSoum;
                bool bCumulatintExiste;
                var dblNbreManuel = default(double);
                var dblPrixEmballage = default(double);
                var dblTotalManuel = default(double);
                var dblForfait = default(double);
                sNoCumulatint = Gauche(txtNoProjSoum.Text, 7) + "99";
                rstProj = new Recordset();
                rstPieces = new Recordset();
                rstProjCumulatint = new Recordset();
                rstPiecesCumulatint = new Recordset();
                rstProjCumulatint.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjCumulatint.EOF)
                {
                    bCumulatintExiste = false;
                    rstProjCumulatint.AddNew();
                    rstProjCumulatint.Fields["IDProjet"].Value = sNoCumulatint;
                    rstProj.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, 6) + "-01'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    if (!rstProj.EOF)
                    {
                        if (!(rstProj.Fields["IDSoumission"].Value is DBNull))
                        {
                            if ($"{rstProj.Fields["IDSoumission"].Value}".Length >= 6)
                            {
                                rstSoum = new Recordset(); rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + Gauche(rstProj.Fields["IDSoumission"].Value, 6) + "-99'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                                if (!rstSoum.EOF) { rstProjCumulatint.Fields["IDSoumission"].Value = rstSoum.Fields["IDSoumission"].Value; }
                                rstSoum.Close();
                                rstSoum = default;
                            }
                        }
                        rstProj.Close();
                        rstProj.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjCumulatint.Fields["IDClient"].Value = rstProj.Fields["IDClient"].Value;
                        rstProjCumulatint.Fields["IDContact"].Value = rstProj.Fields["IDContact"].Value;
                        rstProjCumulatint.Fields["TauxDessin"].Value = rstProj.Fields["TauxDessin"].Value;
                        rstProjCumulatint.Fields["TauxFabrication"].Value = rstProj.Fields["TauxFabrication"].Value;
                        rstProjCumulatint.Fields["TauxAssemblage"].Value = rstProj.Fields["TauxAssemblage"].Value;
                        rstProjCumulatint.Fields["TauxProgInterface"].Value = rstProj.Fields["TauxProgInterface"].Value;
                        rstProjCumulatint.Fields["TauxProgAutomate"].Value = rstProj.Fields["TauxProgAutomate"].Value;
                        rstProjCumulatint.Fields["TauxProgRobot"].Value = rstProj.Fields["TauxProgRobot"].Value;
                        rstProjCumulatint.Fields["TauxVision"].Value = rstProj.Fields["TauxVision"].Value;
                        rstProjCumulatint.Fields["TauxTest"].Value = rstProj.Fields["TauxTest"].Value;
                        rstProjCumulatint.Fields["TauxInstallation"].Value = rstProj.Fields["TauxInstallation"].Value;
                        rstProjCumulatint.Fields["TauxMiseService"].Value = rstProj.Fields["TauxMiseService"].Value;
                        rstProjCumulatint.Fields["TauxFormation"].Value = rstProj.Fields["TauxFormation"].Value;
                        rstProjCumulatint.Fields["TauxGestion"].Value = rstProj.Fields["TauxGestion"].Value;
                        rstProjCumulatint.Fields["TauxShipping"].Value = rstProj.Fields["TauxShipping"].Value;
                        rstProjCumulatint.Fields["Transport"].Value = rstProj.Fields["Transport"].Value;
                        rstProjCumulatint.Fields["Profit"].Value = rstProj.Fields["Profit"].Value;
                        rstProjCumulatint.Fields["imprevue"].Value = rstProj.Fields["imprevue"].Value;
                        rstProjCumulatint.Fields["commission"].Value = rstProj.Fields["commission"].Value;
                        rstProj.Close();
                        rstProjCumulatint.Fields["Description"].Value = "Cumulatint de " + Gauche(txtNoProjSoum.Text, 6);
                        rstEmploye = new Recordset();
                        rstEmploye.Open("SELECT * FROM employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        rstProjCumulatint.Fields["creer"].Value = ConvertDate(DateTime.Today);
                        rstProjCumulatint.Fields["creer_par"].Value = rstEmploye.Fields["NoEmploye"].Value;
                        rstEmploye.Close();
                        rstEmploye = default;
                        rstProjCumulatint.Update();
                        rstProjSoum = new Recordset();
                        rstProjSoum.Open("SELECT * FROM ProjSoum", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstProjSoum.AddNew();
                        rstProjSoum.Fields["IDProjSoum"].Value = sNoCumulatint;
                        rstProjSoum.Fields["NoClient"].Value = rstProjCumulatint.Fields["IDClient"].Value;
                        rstProjSoum.Fields["Description"].Value = rstProjCumulatint.Fields["Description"].Value;
                        rstProjSoum.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today);
                        rstProjSoum.Fields["Ouvert"].Value = true;
                        rstProjSoum.Fields["Verrouillé"].Value = true;
                        rstProjSoum.Fields["Type"].Value = "P";
                        rstProjSoum.Update();
                        rstProjSoum.Close();
                        rstProjSoum = default;
                    }
                    else
                    {
                        bCumulatintExiste = true;
                    }
                    rstProj.CursorLocation = CursorLocationEnum.adUseClient;
                    rstProj.Open("SELECT * FROM ProjetElec WHERE LEFT(IDProjet, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDProjet, 2) <> '99'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    if (rstProj.RecordCount == 1)
                    {
                        rstProjCumulatint.Fields["NbreManuel"].Value = rstProj.Fields["NbreManuel"].Value;
                        rstProjCumulatint.Fields["PrixEmballage"].Value = rstProj.Fields["PrixEmballage"].Value;
                        rstProjCumulatint.Fields["total_manuel"].Value = rstProj.Fields["total_manuel"].Value;
                        rstProjCumulatint.Fields["MontantForfait"].Value = rstProj.Fields["MontantForfait"].Value;
                    }
                    else
                    {
                        while (!rstProj.EOF)
                        {//
                            if (!(rstProj.Fields["NbreManuel"].Value is DBNull)) { dblNbreManuel += (double)rstProj.Fields["NbreManuel"].Value; }
                            if (!(rstProj.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage += (double)rstProj.Fields["PrixEmballage"].Value; }
                            if (!(rstProj.Fields["total_manuel"].Value is DBNull)) { dblTotalManuel += (double)rstProj.Fields["total_manuel"].Value; }
                            if (!(rstProj.Fields["MontantForfait"].Value is DBNull))
                            {
                                if (IsNumeric(rstProj.Fields["MontantForfait"].Value)) { dblForfait += (double)rstProj.Fields["MontantForfait"].Value; }
                            }
                            rstProj.MoveNext();
                        }
                        rstProjCumulatint.Fields["NbreManuel"].Value = dblNbreManuel;
                        rstProjCumulatint.Fields["PrixEmballage"].Value = dblPrixEmballage;
                        rstProjCumulatint.Fields["total_manuel"].Value = dblTotalManuel;
                        rstProjCumulatint.Fields["MontantForfait"].Value = dblForfait;
                    }
                    rstProj.Close();
                    rstProjCumulatint.Update();
                    rstProjCumulatint.Close();
                    rstPiecesCumulatint.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (bCumulatintExiste == true)
                    {
                        UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + sNoCumulatint + "' AND Provenance = '" + Droite(txtNoProjSoum.Text, 2) + "'");
                        rstPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjSoum.Text + "' AND Provenance Is Null OR Provenance = '' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else { rstPieces.Open("SELECT * FROM Projet_Pieces WHERE LEFT(IDProjet, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDProjet, 2) <> '99' AND Provenance Is Null OR Provenance = '' ORDER BY OrdreSection, NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly); } while (!rstPieces.EOF)
                    {
                        rstPiecesCumulatint.AddNew();
                        rstPiecesCumulatint.Fields["IDProjet"].Value = sNoCumulatint;
                        rstPiecesCumulatint.Fields["IDSection"].Value = rstPieces.Fields["IDSection"].Value;
                        rstPiecesCumulatint.Fields["NumItem"].Value = rstPieces.Fields["NumItem"].Value;
                        rstPiecesCumulatint.Fields["Qté"].Value = rstPieces.Fields["Qté"].Value;
                        rstPiecesCumulatint.Fields["Desc_FR"].Value = rstPieces.Fields["Desc_FR"].Value;
                        rstPiecesCumulatint.Fields["Desc_EN"].Value = rstPieces.Fields["Desc_EN"].Value;
                        rstPiecesCumulatint.Fields["Manufact"].Value = rstPieces.Fields["Manufact"].Value;
                        rstPiecesCumulatint.Fields["Prix_list"].Value = rstPieces.Fields["Prix_list"].Value;
                        rstPiecesCumulatint.Fields["Escompte"].Value = rstPieces.Fields["Escompte"].Value;
                        rstPiecesCumulatint.Fields["Prix_net"].Value = rstPieces.Fields["Prix_net"].Value;
                        rstPiecesCumulatint.Fields["IDFRS"].Value = rstPieces.Fields["IDFRS"].Value;
                        rstPiecesCumulatint.Fields["Temps"].Value = rstPieces.Fields["Temps"].Value;
                        rstPiecesCumulatint.Fields["Temps_Total"].Value = rstPieces.Fields["Temps_Total"].Value;
                        rstPiecesCumulatint.Fields["Prix_total"].Value = rstPieces.Fields["Prix_total"].Value;
                        rstPiecesCumulatint.Fields["Profit_Argent"].Value = rstPieces.Fields["Profit_Argent"].Value;
                        rstPiecesCumulatint.Fields["SousSection"].Value = rstPieces.Fields["SousSection"].Value;
                        rstPiecesCumulatint.Fields["OrdreSection"].Value = rstPieces.Fields["OrdreSection"].Value;
                        rstPiecesCumulatint.Fields["NuméroLigne"].Value = rstPieces.Fields["NuméroLigne"].Value;
                        rstPiecesCumulatint.Fields["PrixOrigine"].Value = rstPieces.Fields["PrixOrigine"].Value;
                        rstPiecesCumulatint.Fields["Type"].Value = rstPieces.Fields["Type"].Value;
                        rstPiecesCumulatint.Fields["Visible"].Value = rstPieces.Fields["Visible"].Value;
                        rstPiecesCumulatint.Fields["Commentaire"].Value = rstPieces.Fields["Commentaire"].Value;
                        rstPiecesCumulatint.Fields["Devise"].Value = rstPieces.Fields["Devise"].Value;
                        rstPiecesCumulatint.Fields["Provenance"].Value = Droite(rstPieces.Fields["IDProjet"].Value, 2);
                        rstPiecesCumulatint.Update();
                        rstPieces.MoveNext();
                    }
                    rstPiecesCumulatint.Close();
                    rstPieces.Close();
                    rstProj = default;
                    rstPieces = default;
                    rstProjCumulatint = default;
                    rstPiecesCumulatint = default;
                    CalculerTotalRecordset(sNoCumulatint);
                    if (bCumulatintExiste == false)
                    {
                        if (cmbOuvertFerme.SelectedIndex == I_CMB_OUVERT) { RemplirComboProjSoum(); }
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterProjetAuCumulatif", ex);
            }
        }
        private void AjouterSoumissionAuCumulatif()
        {
            try
            {
                string sNoCumulatint;
                ADODB.Recordset rstSoum;
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstSoumCumulatint;
                ADODB.Recordset rstPiecesCumulatint;
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstEmploye;
                bool bCumulatintExiste;
                var dblNbreManuel = default(double);
                var dblTempsDessin = default(double);
                var dblTempsFabrication = default(double);
                var dblTempsAssemblage = default(double);
                var dblTempsProgInterface = default(double);
                var dblTempsProgAutomate = default(double);
                var dblTempsProgRobot = default(double);
                var dblTempsVision = default(double);
                var dblTempsTest = default(double);
                var dblTempsInstallation = default(double);
                var dblTempsMiseService = default(double);
                var dblTempsFormation = default(double);
                var dblTempsGestion = default(double);
                var dblTempsShipping = default(double);
                var dblTempsTransport = default(double);
                var dblTempsUniteMobile = default(double);
                var dblTotalHebergement = default(double);
                var dblTotalRepas = default(double);
                var dblPrixEmballage = default(double);
                var dblTotalManuel = default(double);
                var dblForfait = default(double);
                sNoCumulatint = Gauche(txtNoProjSoum.Text, 7) + "99";
                rstSoum = new Recordset();
                rstPieces = new Recordset();
                rstSoumCumulatint = new Recordset();
                rstPiecesCumulatint = new Recordset();
                rstSoumCumulatint.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstSoumCumulatint.EOF)
                {
                    bCumulatintExiste = false;
                    rstSoumCumulatint.AddNew();
                    rstSoumCumulatint.Fields["IDSoumission"].Value = sNoCumulatint;
                    rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstSoumCumulatint.Fields["IDClient"].Value = rstSoum.Fields["IDClient"].Value;
                    rstSoumCumulatint.Fields["IDContact"].Value = rstSoum.Fields["IDContact"].Value;
                    rstSoumCumulatint.Fields["TauxDessin"].Value = rstSoum.Fields["TauxDessin"].Value;
                    rstSoumCumulatint.Fields["TauxFabrication"].Value = rstSoum.Fields["TauxFabrication"].Value;
                    rstSoumCumulatint.Fields["TauxAssemblage"].Value = rstSoum.Fields["TauxAssemblage"].Value;
                    rstSoumCumulatint.Fields["TauxProgInterface"].Value = rstSoum.Fields["TauxProgInterface"].Value;
                    rstSoumCumulatint.Fields["TauxProgAutomate"].Value = rstSoum.Fields["TauxProgAutomate"].Value;
                    rstSoumCumulatint.Fields["TauxProgRobot"].Value = rstSoum.Fields["TauxProgRobot"].Value;
                    rstSoumCumulatint.Fields["TauxVision"].Value = rstSoum.Fields["TauxVision"].Value;
                    rstSoumCumulatint.Fields["TauxTest"].Value = rstSoum.Fields["TauxTest"].Value;
                    rstSoumCumulatint.Fields["TauxInstallation"].Value = rstSoum.Fields["TauxInstallation"].Value;
                    rstSoumCumulatint.Fields["TauxMiseService"].Value = rstSoum.Fields["TauxMiseService"].Value;
                    rstSoumCumulatint.Fields["TauxFormation"].Value = rstSoum.Fields["TauxFormation"].Value;
                    rstSoumCumulatint.Fields["TauxGestion"].Value = rstSoum.Fields["TauxGestion"].Value;
                    rstSoumCumulatint.Fields["TauxShipping"].Value = rstSoum.Fields["TauxShipping"].Value;
                    rstSoumCumulatint.Fields["TauxHebergement1"].Value = rstSoum.Fields["TauxHebergement1"].Value;
                    rstSoumCumulatint.Fields["TauxHebergement2"].Value = rstSoum.Fields["TauxHebergement2"].Value;
                    rstSoumCumulatint.Fields["TauxRepas"].Value = rstSoum.Fields["TauxRepas"].Value;
                    rstSoumCumulatint.Fields["TauxTransport"].Value = rstSoum.Fields["TauxTransport"].Value;
                    rstSoumCumulatint.Fields["TauxUniteMobile"].Value = rstSoum.Fields["TauxUniteMobile"].Value;
                    rstSoumCumulatint.Fields["Transport"].Value = rstSoum.Fields["Transport"].Value;
                    rstSoumCumulatint.Fields["Profit"].Value = rstSoum.Fields["Profit"].Value;
                    rstSoumCumulatint.Fields["imprevue"].Value = rstSoum.Fields["imprevue"].Value;
                    rstSoumCumulatint.Fields["commission"].Value = rstSoum.Fields["commission"].Value;
                    rstSoum.Close();
                    rstSoumCumulatint.Fields["Description"].Value = "Cumulatint de " + Gauche(txtNoProjSoum.Text, 6);
                    rstEmploye = new Recordset();
                    rstEmploye.Open("SELECT * FROM employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstSoumCumulatint.Fields["creer"].Value = ConvertDate(DateTime.Today);
                    rstSoumCumulatint.Fields["creer_par"].Value = rstEmploye.Fields["NoEmploye"].Value;
                    rstEmploye.Close();
                    rstEmploye = default;
                    rstSoumCumulatint.Update();
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjSoum.AddNew();
                    rstProjSoum.Fields["IDProjSoum"].Value = sNoCumulatint;
                    rstProjSoum.Fields["NoClient"].Value = rstSoumCumulatint.Fields["IDClient"].Value;
                    rstProjSoum.Fields["Description"].Value = rstSoumCumulatint.Fields["Description"].Value;
                    rstProjSoum.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today);
                    rstProjSoum.Fields["Ouvert"].Value = true;
                    rstProjSoum.Fields["Verrouillé"].Value = true;
                    rstProjSoum.Fields["Type"].Value = "S";
                    rstProjSoum.Update();
                    rstProjSoum.Close();
                    rstProjSoum = default;
                }
                else { bCumulatintExiste = true; }
                rstSoum.CursorLocation = CursorLocationEnum.adUseClient;
                rstSoum.Open("SELECT * FROM SoumissionElec WHERE LEFT(IDSoumission, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDSoumission, 2) <> '99'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (rstSoum.RecordCount == 1)
                {
                    rstSoumCumulatint.Fields["NbreManuel"].Value = rstSoum.Fields["NbreManuel"].Value;
                    rstSoumCumulatint.Fields["TempsDessin"].Value = rstSoum.Fields["TempsDessin"].Value;
                    if (rstSoum.Fields["SansTemps"].Value == false) { rstSoumCumulatint.Fields["TempsFabrication"].Value = rstSoum.Fields["TempsFabrication"].Value; } else { rstSoumCumulatint.Fields["TempsFabrication"].Value = 0; }
                    rstSoumCumulatint.Fields["TempsAssemblage"].Value = rstSoum.Fields["TempsAssemblage"].Value;
                    rstSoumCumulatint.Fields["TempsProgInterface"].Value = rstSoum.Fields["TempsProgInterface"].Value;
                    rstSoumCumulatint.Fields["TempsProgAutomate"].Value = rstSoum.Fields["TempsProgAutomate"].Value;
                    rstSoumCumulatint.Fields["TempsProgRobot"].Value = rstSoum.Fields["TempsProgRobot"].Value;
                    rstSoumCumulatint.Fields["TempsVision"].Value = rstSoum.Fields["TempsVision"].Value;
                    rstSoumCumulatint.Fields["TempsTest"].Value = rstSoum.Fields["TempsTest"].Value;
                    rstSoumCumulatint.Fields["TempsInstallation"].Value = rstSoum.Fields["TempsInstallation"].Value;
                    rstSoumCumulatint.Fields["TempsMiseService"].Value = rstSoum.Fields["TempsMiseService"].Value;
                    rstSoumCumulatint.Fields["TempsFormation"].Value = rstSoum.Fields["TempsFormation"].Value;
                    rstSoumCumulatint.Fields["TempsGestion"].Value = rstSoum.Fields["TempsGestion"].Value;
                    rstSoumCumulatint.Fields["TempsShipping"].Value = rstSoum.Fields["TempsShipping"].Value;
                    rstSoumCumulatint.Fields["NbrePersonne"].Value = rstSoum.Fields["NbrePersonne"].Value;
                    rstSoumCumulatint.Fields["TempsHebergement"].Value = rstSoum.Fields["TempsHebergement"].Value;
                    rstSoumCumulatint.Fields["TempsRepas"].Value = rstSoum.Fields["TempsRepas"].Value;
                    rstSoumCumulatint.Fields["TempsTransport"].Value = rstSoum.Fields["TempsTransport"].Value;
                    rstSoumCumulatint.Fields["TempsUniteMobile"].Value = rstSoum.Fields["TempsUniteMobile"].Value;
                    rstSoumCumulatint.Fields["TotalHebergement"].Value = rstSoum.Fields["TotalHebergement"].Value;
                    rstSoumCumulatint.Fields["TotalRepas"].Value = rstSoum.Fields["TotalRepas"].Value;
                    rstSoumCumulatint.Fields["PrixEmballage"].Value = rstSoum.Fields["PrixEmballage"].Value;
                    rstSoumCumulatint.Fields["total_manuel"].Value = rstSoum.Fields["total_manuel"].Value;
                    rstSoumCumulatint.Fields["MontantForfait"].Value = rstSoum.Fields["MontantForfait"].Value;
                }
                else
                {
                    while (!rstSoum.EOF)
                    {//
                        if (!(rstSoum.Fields["NbreManuel"].Value is DBNull)) { dblNbreManuel += (double)rstSoum.Fields["NbreManuel"].Value; }
                        if (!(rstSoum.Fields["TempsDessin"].Value is DBNull)) { dblTempsDessin = dblTempsDessin + (double)rstSoum.Fields["TempsDessin"].Value; }
                        if (rstSoum.Fields["SansTemps"].Value == false)
                        {
                            //
                            if (!(rstSoum.Fields["TempsFabrication"].Value is DBNull)) { dblTempsFabrication = dblTempsFabrication + (double)rstSoum.Fields["TempsFabrication"].Value; }
                        }
                        if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull)) { dblTempsAssemblage = dblTempsAssemblage + (double)rstSoum.Fields["TempsAssemblage"].Value; }
                        if (!(rstSoum.Fields["TempsProgInterface"].Value is DBNull)) { dblTempsProgInterface = dblTempsProgInterface + (double)rstSoum.Fields["TempsProgInterface"].Value; }
                        if (!(rstSoum.Fields["TempsProgAutomate"].Value is DBNull)) { dblTempsProgAutomate = dblTempsProgAutomate + (double)rstSoum.Fields["TempsProgAutomate"].Value; }
                        if (!(rstSoum.Fields["TempsProgRobot"].Value is DBNull)) { dblTempsProgRobot = dblTempsProgRobot + (double)rstSoum.Fields["TempsProgRobot"].Value; }
                        if (!(rstSoum.Fields["TempsVision"].Value is DBNull)) { dblTempsVision = dblTempsVision + (double)rstSoum.Fields["TempsVision"].Value; }
                        if (!(rstSoum.Fields["TempsTest"].Value is DBNull)) { dblTempsTest = dblTempsTest + (double)rstSoum.Fields["TempsTest"].Value; }
                        if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull)) { dblTempsInstallation = dblTempsInstallation + (double)rstSoum.Fields["TempsInstallation"].Value; }
                        if (!(rstSoum.Fields["TempsMiseService"].Value is DBNull)) { dblTempsMiseService = dblTempsMiseService + (double)rstSoum.Fields["TempsMiseService"].Value; }
                        if (!(rstSoum.Fields["TempsFormation"].Value is DBNull)) { dblTempsFormation = dblTempsFormation + (double)rstSoum.Fields["TempsFormation"].Value; }
                        if (!(rstSoum.Fields["TempsGestion"].Value is DBNull)) { dblTempsGestion = dblTempsGestion + (double)rstSoum.Fields["TempsGestion"].Value; }
                        if (!(rstSoum.Fields["TempsShipping"].Value is DBNull)) { dblTempsShipping = dblTempsShipping + (double)rstSoum.Fields["TempsShipping"].Value; }
                        if (!(rstSoum.Fields["TempsTransport"].Value is DBNull)) { dblTempsTransport = dblTempsTransport + (double)rstSoum.Fields["TempsTransport"].Value; }
                        if (!(rstSoum.Fields["TempsUniteMobile"].Value is DBNull)) { dblTempsUniteMobile = dblTempsUniteMobile + (double)rstSoum.Fields["TempsUniteMobile"].Value; }
                        if (!(rstSoum.Fields["TotalHebergement"].Value is DBNull)) { dblTotalHebergement = dblTotalHebergement + (double)rstSoum.Fields["TotalHebergement"].Value; }
                        if (!(rstSoum.Fields["TotalRepas"].Value is DBNull)) { dblTotalRepas = dblTotalRepas + (double)rstSoum.Fields["TotalRepas"].Value; }
                        if (!(rstSoum.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage += (double)rstSoum.Fields["PrixEmballage"].Value; }
                        if (!(rstSoum.Fields["total_manuel"].Value is DBNull)) { dblTotalManuel += (double)rstSoum.Fields["total_manuel"].Value; }
                        if (!(rstSoum.Fields["MontantForfait"].Value is DBNull))
                        {
                            if (IsNumeric(rstSoum.Fields["MontantForfait"].Value)) { dblForfait += (double)rstSoum.Fields["MontantForfait"].Value; }
                        }
                        rstSoum.MoveNext();
                    }
                    rstSoumCumulatint.Fields["NbreManuel"].Value = dblNbreManuel;
                    rstSoumCumulatint.Fields["TempsDessin"].Value = dblTempsDessin;
                    rstSoumCumulatint.Fields["TempsFabrication"].Value = dblTempsFabrication;
                    rstSoumCumulatint.Fields["TempsAssemblage"].Value = dblTempsAssemblage;
                    rstSoumCumulatint.Fields["TempsProgInterface"].Value = dblTempsProgInterface;
                    rstSoumCumulatint.Fields["TempsProgAutomate"].Value = dblTempsProgAutomate;
                    rstSoumCumulatint.Fields["TempsProgRobot"].Value = dblTempsProgRobot;
                    rstSoumCumulatint.Fields["TempsVision"].Value = dblTempsVision;
                    rstSoumCumulatint.Fields["TempsTest"].Value = dblTempsTest;
                    rstSoumCumulatint.Fields["TempsInstallation"].Value = dblTempsInstallation;
                    rstSoumCumulatint.Fields["TempsMiseService"].Value = dblTempsMiseService;
                    rstSoumCumulatint.Fields["TempsFormation"].Value = dblTempsFormation;
                    rstSoumCumulatint.Fields["TempsGestion"].Value = dblTempsGestion;
                    rstSoumCumulatint.Fields["TempsShipping"].Value = dblTempsShipping;
                    rstSoumCumulatint.Fields["TempsTransport"].Value = dblTempsTransport;
                    rstSoumCumulatint.Fields["TempsUniteMobile"].Value = dblTempsUniteMobile;
                    rstSoumCumulatint.Fields["TotalHebergement"].Value = dblTotalHebergement;
                    rstSoumCumulatint.Fields["TotalRepas"].Value = dblTotalRepas;
                    rstSoumCumulatint.Fields["PrixEmballage"].Value = dblPrixEmballage;
                    rstSoumCumulatint.Fields["total_manuel"].Value = dblTotalManuel;
                    rstSoumCumulatint.Fields["MontantForfait"].Value = dblForfait;
                }
                rstSoumCumulatint.Update();
                rstSoumCumulatint.Close();
                rstSoum.Close();
                rstPiecesCumulatint.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (bCumulatintExiste == true)
                {
                    UpdateSQL("DELETE FROM Soumission_Pieces WHERE IDSoumission = '" + sNoCumulatint + "' AND Provenance = '" + Droite(txtNoProjSoum.Text, 2) + "'");
                    rstPieces.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + txtNoProjSoum.Text + "' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                else
                {
                    rstPieces.Open("SELECT * FROM Soumission_Pieces WHERE LEFT(IDSoumission, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDSoumission, 2) <> '99' ORDER BY OrdreSection, NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                while (!rstPieces.EOF)
                {
                    rstPiecesCumulatint.AddNew();
                    rstPiecesCumulatint.Fields["IDSoumission"].Value = sNoCumulatint;
                    rstPiecesCumulatint.Fields["IDSection"].Value = rstPieces.Fields["IDSection"].Value;
                    rstPiecesCumulatint.Fields["NumItem"].Value = rstPieces.Fields["NumItem"].Value;
                    rstPiecesCumulatint.Fields["Qté"].Value = rstPieces.Fields["Qté"].Value;
                    rstPiecesCumulatint.Fields["Desc_FR"].Value = rstPieces.Fields["Desc_FR"].Value;
                    rstPiecesCumulatint.Fields["Desc_EN"].Value = rstPieces.Fields["Desc_EN"].Value;
                    rstPiecesCumulatint.Fields["Manufact"].Value = rstPieces.Fields["Manufact"].Value;
                    rstPiecesCumulatint.Fields["Prix_list"].Value = rstPieces.Fields["Prix_list"].Value;
                    rstPiecesCumulatint.Fields["Escompte"].Value = rstPieces.Fields["Escompte"].Value;
                    rstPiecesCumulatint.Fields["Prix_net"].Value = rstPieces.Fields["Prix_net"].Value;
                    rstPiecesCumulatint.Fields["IDFRS"].Value = rstPieces.Fields["IDFRS"].Value;
                    rstPiecesCumulatint.Fields["Temps"].Value = rstPieces.Fields["Temps"].Value;
                    rstPiecesCumulatint.Fields["Temps_Total"].Value = rstPieces.Fields["Temps_Total"].Value;
                    rstPiecesCumulatint.Fields["Prix_total"].Value = rstPieces.Fields["Prix_total"].Value;
                    rstPiecesCumulatint.Fields["Profit_Argent"].Value = rstPieces.Fields["Profit_Argent"].Value;
                    rstPiecesCumulatint.Fields["SousSection"].Value = rstPieces.Fields["SousSection"].Value;
                    rstPiecesCumulatint.Fields["OrdreSection"].Value = rstPieces.Fields["OrdreSection"].Value;
                    rstPiecesCumulatint.Fields["NuméroLigne"].Value = rstPieces.Fields["NuméroLigne"].Value;
                    rstPiecesCumulatint.Fields["PrixOrigine"].Value = rstPieces.Fields["PrixOrigine"].Value;
                    rstPiecesCumulatint.Fields["Type"].Value = rstPieces.Fields["Type"].Value;
                    rstPiecesCumulatint.Fields["Visible"].Value = rstPieces.Fields["Visible"].Value;
                    rstPiecesCumulatint.Fields["Commentaire"].Value = rstPieces.Fields["Commentaire"].Value;
                    rstPiecesCumulatint.Fields["Devise"].Value = rstPieces.Fields["Devise"].Value;
                    rstPiecesCumulatint.Fields["Provenance"].Value = Droite(rstPieces.Fields["IDSoumission"].Value, 2);
                    rstPiecesCumulatint.Update();
                    rstPieces.MoveNext();
                }
                rstPiecesCumulatint.Close();
                rstPieces.Close();
                rstSoum = default;
                rstPieces = default;
                rstSoumCumulatint = default;
                rstPiecesCumulatint = default;
                CalculerTotalRecordset(sNoCumulatint);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterSoumissionAuCumulatif", ex);
            }
        }
        private void RecreerProjetCumulatif()
        {
            try
            {
                string sNoCumulatint;
                ADODB.Recordset rstProj;
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstProjCumulatint;
                ADODB.Recordset rstPiecesCumulatint;
                ADODB.Recordset rstProjSoum;
                var dblNbreManuel = default(double);
                var dblPrixEmballage = default(double);
                var dblTotalManuel = default(double);
                var dblForfait = default(double);
                var bSupprimer = default(bool);
                sNoCumulatint = Gauche(txtNoProjSoum.Text, 7) + "99";
                rstProj = new Recordset();
                rstPieces = new Recordset();
                rstProjCumulatint = new Recordset();
                rstPiecesCumulatint = new Recordset();
                rstProj.CursorLocation = CursorLocationEnum.adUseClient;
                rstProj.Open("SELECT * FROM ProjetElec WHERE LEFT(IDProjet, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDProjet, 2) <> '99'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (rstProj.EOF)
                {
                    UpdateSQL("DELETE FROM ProjSoum WHERE IDProjSoum = '" + sNoCumulatint + "'");
                    UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + sNoCumulatint + "' AND Type = 'E'");
                    UpdateSQL("DELETE FROM ProjetElec WHERE IDProjet = '" + sNoCumulatint + "'");
                    bSupprimer = true;
                }
                else
                {
                    rstProjCumulatint.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProj.RecordCount == 1)
                    {
                        rstProjCumulatint.Fields["NbreManuel"].Value = rstProj.Fields["NbreManuel"].Value;
                        rstProjCumulatint.Fields["PrixEmballage"].Value = rstProj.Fields["PrixEmballage"].Value;
                        rstProjCumulatint.Fields["total_manuel"].Value = rstProj.Fields["total_manuel"].Value;
                        rstProjCumulatint.Fields["MontantForfait"].Value = rstProj.Fields["MontantForfait"].Value;
                    }
                    else
                    {
                        while (!rstProj.EOF)
                        {
                            if (!(rstProj.Fields["NbreManuel"].Value is DBNull)) { dblNbreManuel += (double)rstProj.Fields["NbreManuel"].Value; }
                            if (!(rstProj.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage += (double)rstProj.Fields["PrixEmballage"].Value; }
                            if (!(rstProj.Fields["total_manuel"].Value is DBNull)) { dblTotalManuel += (double)rstProj.Fields["total_manuel"].Value; }
                            if (!(rstProj.Fields["MontantForfait"].Value is DBNull))
                            {
                                if (IsNumeric(rstProj.Fields["MontantForfait"].Value)) { dblForfait += (double)rstProj.Fields["MontantForfait"].Value; }
                            }
                            rstProj.MoveNext();
                        }
                        rstProjCumulatint.Fields["NbreManuel"].Value = dblNbreManuel;
                        rstProjCumulatint.Fields["PrixEmballage"].Value = dblPrixEmballage;
                        rstProjCumulatint.Fields["total_manuel"].Value = dblTotalManuel;
                        rstProjCumulatint.Fields["MontantForfait"].Value = dblForfait;
                    }
                    rstProj.Close();
                    rstProjCumulatint.Update();
                    rstProjCumulatint.Close();
                }
                rstPiecesCumulatint.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + sNoCumulatint + "' AND Provenance = '" + Droite(txtNoProjSoum.Text, 2) + "'");
                rstPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjSoum.Text + "' AND Provenance Is Null OR Provenance = '' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPieces.EOF)
                {
                    rstPiecesCumulatint.AddNew();
                    rstPiecesCumulatint.Fields["IDProjet"].Value = sNoCumulatint;
                    rstPiecesCumulatint.Fields["IDSection"].Value = rstPieces.Fields["IDSection"].Value;
                    rstPiecesCumulatint.Fields["NumItem"].Value = rstPieces.Fields["NumItem"].Value;
                    rstPiecesCumulatint.Fields["Qté"].Value = rstPieces.Fields["Qté"].Value;
                    rstPiecesCumulatint.Fields["Desc_FR"].Value = rstPieces.Fields["Desc_FR"].Value;
                    rstPiecesCumulatint.Fields["Desc_EN"].Value = rstPieces.Fields["Desc_EN"].Value;
                    rstPiecesCumulatint.Fields["Manufact"].Value = rstPieces.Fields["Manufact"].Value;
                    rstPiecesCumulatint.Fields["Prix_list"].Value = rstPieces.Fields["Prix_list"].Value;
                    rstPiecesCumulatint.Fields["Escompte"].Value = rstPieces.Fields["Escompte"].Value;
                    rstPiecesCumulatint.Fields["Prix_net"].Value = rstPieces.Fields["Prix_net"].Value;
                    rstPiecesCumulatint.Fields["IDFRS"].Value = rstPieces.Fields["IDFRS"].Value;
                    rstPiecesCumulatint.Fields["Temps"].Value = rstPieces.Fields["Temps"].Value;
                    rstPiecesCumulatint.Fields["Temps_Total"].Value = rstPieces.Fields["Temps_Total"].Value;
                    rstPiecesCumulatint.Fields["Prix_total"].Value = rstPieces.Fields["Prix_total"].Value;
                    rstPiecesCumulatint.Fields["Profit_Argent"].Value = rstPieces.Fields["Profit_Argent"].Value;
                    rstPiecesCumulatint.Fields["SousSection"].Value = rstPieces.Fields["SousSection"].Value;
                    rstPiecesCumulatint.Fields["OrdreSection"].Value = rstPieces.Fields["OrdreSection"].Value;
                    rstPiecesCumulatint.Fields["NuméroLigne"].Value = rstPieces.Fields["NuméroLigne"].Value;
                    rstPiecesCumulatint.Fields["PrixOrigine"].Value = rstPieces.Fields["PrixOrigine"].Value;
                    rstPiecesCumulatint.Fields["Type"].Value = rstPieces.Fields["Type"].Value;
                    rstPiecesCumulatint.Fields["Visible"].Value = rstPieces.Fields["Visible"].Value;
                    rstPiecesCumulatint.Fields["Commentaire"].Value = rstPieces.Fields["Commentaire"].Value;
                    rstPiecesCumulatint.Fields["Devise"].Value = rstPieces.Fields["Devise"].Value;
                    rstPiecesCumulatint.Fields["Provenance"].Value = Droite(rstPieces.Fields["IDProjet"].Value, 2);
                    rstPiecesCumulatint.Update();
                    rstPieces.MoveNext();
                }
                rstPiecesCumulatint.Close();
                rstPieces.Close();
                rstProj = default;
                rstPieces = default;
                rstProjCumulatint = default;
                rstPiecesCumulatint = default;
                if (bSupprimer == false) { CalculerTotalRecordset(sNoCumulatint); }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterProjetAuCumulatif", ex);
            }
        }
        private void RecreerSoumissionCumulatif()
        {
            try
            {
                string sNoCumulatint;
                ADODB.Recordset rstSoum;
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstSoumCumulatint;
                ADODB.Recordset rstPiecesCumulatint;
                ADODB.Recordset rstProjSoum;
                var dblNbreManuel = default(double);
                var dblTempsDessin = default(double);
                var dblTempsFabrication = default(double);
                var dblTempsAssemblage = default(double);
                var dblTempsProgInterface = default(double);
                var dblTempsProgAutomate = default(double);
                var dblTempsProgRobot = default(double);
                var dblTempsVision = default(double);
                var dblTempsTest = default(double);
                var dblTempsInstallation = default(double);
                var dblTempsMiseService = default(double);
                var dblTempsFormation = default(double);
                var dblTempsGestion = default(double);
                var dblTempsShipping = default(double);
                var dblTempsTransport = default(double);
                var dblTempsUniteMobile = default(double);
                var dblTotalHebergement = default(double);
                var dblTotalRepas = default(double);
                var dblPrixEmballage = default(double);
                var dblTotalManuel = default(double);
                var dblForfait = default(double);
                var bSupprimer = default(bool);
                sNoCumulatint = Gauche(txtNoProjSoum.Text, 7) + "99";
                rstSoum = new Recordset();
                rstPieces = new Recordset();
                rstSoumCumulatint = new Recordset();
                rstPiecesCumulatint = new Recordset();
                rstSoum.CursorLocation = CursorLocationEnum.adUseClient;
                rstSoum.Open("SELECT * FROM SoumissionElec WHERE LEFT(IDSoumission, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDSoumission, 2) <> '99'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                ///supprime la soumission
                if (rstSoum.EOF)
                {
                    UpdateSQL("DELETE FROM ProjSoum WHERE IDProjSoum = '" + sNoCumulatint + "'");
                    UpdateSQL("DELETE FROM Soumission_Pieces WHERE IDSoumission = '" + sNoCumulatint + "' AND Type = 'E'");
                    UpdateSQL("DELETE FROM SoumissionElec WHERE IDSoumission = '" + sNoCumulatint + "'");
                    bSupprimer = true;
                }
                else
                {
                    rstSoumCumulatint.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstSoum.RecordCount == 1)
                    {
                        rstSoumCumulatint.Fields["NbreManuel"].Value = rstSoum.Fields["NbreManuel"].Value;
                        rstSoumCumulatint.Fields["TempsDessin"].Value = rstSoum.Fields["TempsDessin"].Value;
                        if (rstSoum.Fields["SansTemps"].Value == false) { rstSoumCumulatint.Fields["TempsFabrication"].Value = rstSoum.Fields["TempsFabrication"].Value; } else { rstSoumCumulatint.Fields["TempsFabrication"].Value = 0; }
                        rstSoumCumulatint.Fields["TempsAssemblage"].Value = rstSoum.Fields["TempsAssemblage"].Value;
                        rstSoumCumulatint.Fields["TempsProgInterface"].Value = rstSoum.Fields["TempsProgInterface"].Value;
                        rstSoumCumulatint.Fields["TempsProgAutomate"].Value = rstSoum.Fields["TempsProgAutomate"].Value;
                        rstSoumCumulatint.Fields["TempsProgRobot"].Value = rstSoum.Fields["TempsProgRobot"].Value;
                        rstSoumCumulatint.Fields["TempsVision"].Value = rstSoum.Fields["TempsVision"].Value;
                        rstSoumCumulatint.Fields["TempsTest"].Value = rstSoum.Fields["TempsTest"].Value;
                        rstSoumCumulatint.Fields["TempsInstallation"].Value = rstSoum.Fields["TempsInstallation"].Value;
                        rstSoumCumulatint.Fields["TempsMiseService"].Value = rstSoum.Fields["TempsMiseService"].Value;
                        rstSoumCumulatint.Fields["TempsFormation"].Value = rstSoum.Fields["TempsFormation"].Value;
                        rstSoumCumulatint.Fields["TempsGestion"].Value = rstSoum.Fields["TempsGestion"].Value;
                        rstSoumCumulatint.Fields["TempsShipping"].Value = rstSoum.Fields["TempsShipping"].Value;
                        rstSoumCumulatint.Fields["NbrePersonne"].Value = rstSoum.Fields["NbrePersonne"].Value;
                        rstSoumCumulatint.Fields["TempsHebergement"].Value = rstSoum.Fields["TempsHebergement"].Value;
                        rstSoumCumulatint.Fields["TempsRepas"].Value = rstSoum.Fields["TempsRepas"].Value;
                        rstSoumCumulatint.Fields["TempsTransport"].Value = rstSoum.Fields["TempsTransport"].Value;
                        rstSoumCumulatint.Fields["TempsUniteMobile"].Value = rstSoum.Fields["TempsUniteMobile"].Value;
                        rstSoumCumulatint.Fields["TotalHebergement"].Value = rstSoum.Fields["TotalHebergement"].Value;
                        rstSoumCumulatint.Fields["TotalRepas"].Value = rstSoum.Fields["TotalRepas"].Value;
                        rstSoumCumulatint.Fields["PrixEmballage"].Value = rstSoum.Fields["PrixEmballage"].Value;
                        rstSoumCumulatint.Fields["total_manuel"].Value = rstSoum.Fields["total_manuel"].Value;
                        rstSoumCumulatint.Fields["MontantForfait"].Value = rstSoum.Fields["MontantForfait"].Value;
                    }
                    else
                    {
                        while (!rstSoum.EOF)
                        {
                            if (!(rstSoum.Fields["NbreManuel"].Value is DBNull)) { dblNbreManuel += (double)rstSoum.Fields["NbreManuel"].Value; }
                            if (!(rstSoum.Fields["TempsDessin"].Value is DBNull)) { dblTempsDessin = dblTempsDessin + (double)rstSoum.Fields["TempsDessin"].Value; }
                            if (rstSoum.Fields["SansTemps"].Value == false)
                            {
                                if (!(rstSoum.Fields["TempsFabrication"].Value is DBNull))
                                {
                                    dblTempsFabrication = dblTempsFabrication + (double)rstSoum.Fields["TempsFabrication"].Value;
                                }
                            }
                            if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull)) { dblTempsAssemblage = dblTempsAssemblage + (double)rstSoum.Fields["TempsAssemblage"].Value; }
                            if (!(rstSoum.Fields["TempsProgInterface"].Value is DBNull)) { dblTempsProgInterface = dblTempsProgInterface + (double)rstSoum.Fields["TempsProgInterface"].Value; }
                            if (!(rstSoum.Fields["TempsProgAutomate"].Value is DBNull)) { dblTempsProgAutomate = dblTempsProgAutomate + (double)rstSoum.Fields["TempsProgAutomate"].Value; }
                            if (!(rstSoum.Fields["TempsProgRobot"].Value is DBNull)) { dblTempsProgRobot = dblTempsProgRobot + (double)rstSoum.Fields["TempsProgRobot"].Value; }
                            if (!(rstSoum.Fields["TempsVision"].Value is DBNull)) { dblTempsVision = dblTempsVision + (double)rstSoum.Fields["TempsVision"].Value; }
                            if (!(rstSoum.Fields["TempsTest"].Value is DBNull)) { dblTempsTest = dblTempsTest + (double)rstSoum.Fields["TempsTest"].Value; }
                            if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull)) { dblTempsInstallation = dblTempsInstallation + (double)rstSoum.Fields["TempsInstallation"].Value; }
                            if (!(rstSoum.Fields["TempsMiseService"].Value is DBNull)) { dblTempsMiseService = dblTempsMiseService + (double)rstSoum.Fields["TempsMiseService"].Value; }
                            if (!(rstSoum.Fields["TempsFormation"].Value is DBNull)) { dblTempsFormation = dblTempsFormation + (double)rstSoum.Fields["TempsFormation"].Value; }
                            if (!(rstSoum.Fields["TempsGestion"].Value is DBNull)) { dblTempsGestion = dblTempsGestion + (double)rstSoum.Fields["TempsGestion"].Value; }
                            if (!(rstSoum.Fields["TempsShipping"].Value is DBNull)) { dblTempsShipping = dblTempsShipping + (double)rstSoum.Fields["TempsShipping"].Value; }
                            if (!(rstSoum.Fields["TempsTransport"].Value is DBNull)) { dblTempsTransport = dblTempsTransport + (double)rstSoum.Fields["TempsTransport"].Value; }
                            if (!(rstSoum.Fields["TempsUniteMobile"].Value is DBNull)) { dblTempsUniteMobile = dblTempsUniteMobile + (double)rstSoum.Fields["TempsUniteMobile"].Value; }
                            if (!(rstSoum.Fields["TotalHebergement"].Value is DBNull)) { dblTotalHebergement = dblTotalHebergement + (double)rstSoum.Fields["TotalHebergement"].Value; }
                            if (!(rstSoum.Fields["TotalRepas"].Value is DBNull)) { dblTotalRepas = dblTotalRepas + (double)rstSoum.Fields["TotalRepas"].Value; }
                            if (!(rstSoum.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage += (double)rstSoum.Fields["PrixEmballage"].Value; }
                            if (!(rstSoum.Fields["total_manuel"].Value is DBNull)) { dblTotalManuel += (double)rstSoum.Fields["total_manuel"].Value; }
                            if (!(rstSoum.Fields["MontantForfait"].Value is DBNull))
                            {
                                if (IsNumeric(rstSoum.Fields["MontantForfait"].Value))
                                {
                                    dblForfait += (double)rstSoum.Fields["MontantForfait"].Value;
                                }
                            }
                            rstSoum.MoveNext();
                        }
                        rstSoumCumulatint.Fields["NbreManuel"].Value = dblNbreManuel;
                        rstSoumCumulatint.Fields["TempsDessin"].Value = dblTempsDessin;
                        rstSoumCumulatint.Fields["TempsFabrication"].Value = dblTempsFabrication;
                        rstSoumCumulatint.Fields["TempsAssemblage"].Value = dblTempsAssemblage;
                        rstSoumCumulatint.Fields["TempsProgInterface"].Value = dblTempsProgInterface;
                        rstSoumCumulatint.Fields["TempsProgAutomate"].Value = dblTempsProgAutomate;
                        rstSoumCumulatint.Fields["TempsProgRobot"].Value = dblTempsProgRobot;
                        rstSoumCumulatint.Fields["TempsVision"].Value = dblTempsVision;
                        rstSoumCumulatint.Fields["TempsTest"].Value = dblTempsTest;
                        rstSoumCumulatint.Fields["TempsInstallation"].Value = dblTempsInstallation;
                        rstSoumCumulatint.Fields["TempsMiseService"].Value = dblTempsMiseService;
                        rstSoumCumulatint.Fields["TempsFormation"].Value = dblTempsFormation;
                        rstSoumCumulatint.Fields["TempsGestion"].Value = dblTempsGestion;
                        rstSoumCumulatint.Fields["TempsShipping"].Value = dblTempsShipping;
                        rstSoumCumulatint.Fields["TempsTransport"].Value = dblTempsTransport;
                        rstSoumCumulatint.Fields["TempsUniteMobile"].Value = dblTempsUniteMobile;
                        rstSoumCumulatint.Fields["TotalHebergement"].Value = dblTotalHebergement;
                        rstSoumCumulatint.Fields["TotalRepas"].Value = dblTotalRepas;
                        rstSoumCumulatint.Fields["PrixEmballage"].Value = dblPrixEmballage;
                        rstSoumCumulatint.Fields["total_manuel"].Value = dblTotalManuel;
                        rstSoumCumulatint.Fields["MontantForfait"].Value = dblForfait;
                    }
                    rstSoum.Close();
                    rstSoumCumulatint.Update();
                    rstSoumCumulatint.Close();
                }
                rstPiecesCumulatint.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoCumulatint + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                UpdateSQL("DELETE FROM Soumission_Pieces WHERE IDSoumission = '" + sNoCumulatint + "'");
                rstPieces.Open("SELECT * FROM Soumission_Pieces WHERE LEFT(IDSoumission, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' AND RIGHT(IDSoumission, 2) <> '99' ORDER BY OrdreSection, NuméroLigne", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPieces.EOF)
                {
                    rstPiecesCumulatint.AddNew();
                    rstPiecesCumulatint.Fields["IDSoumission"].Value = sNoCumulatint;
                    rstPiecesCumulatint.Fields["IDSection"].Value = rstPieces.Fields["IDSection"].Value;
                    rstPiecesCumulatint.Fields["NumItem"].Value = rstPieces.Fields["NumItem"].Value;
                    rstPiecesCumulatint.Fields["Qté"].Value = rstPieces.Fields["Qté"].Value;
                    rstPiecesCumulatint.Fields["Desc_FR"].Value = rstPieces.Fields["Desc_FR"].Value;
                    rstPiecesCumulatint.Fields["Desc_EN"].Value = rstPieces.Fields["Desc_EN"].Value;
                    rstPiecesCumulatint.Fields["Manufact"].Value = rstPieces.Fields["Manufact"].Value;
                    rstPiecesCumulatint.Fields["Prix_list"].Value = rstPieces.Fields["Prix_list"].Value;
                    rstPiecesCumulatint.Fields["Escompte"].Value = rstPieces.Fields["Escompte"].Value;
                    rstPiecesCumulatint.Fields["Prix_net"].Value = rstPieces.Fields["Prix_net"].Value;
                    rstPiecesCumulatint.Fields["IDFRS"].Value = rstPieces.Fields["IDFRS"].Value;
                    rstPiecesCumulatint.Fields["Temps"].Value = rstPieces.Fields["Temps"].Value;
                    rstPiecesCumulatint.Fields["Temps_Total"].Value = rstPieces.Fields["Temps_Total"].Value;
                    rstPiecesCumulatint.Fields["Prix_total"].Value = rstPieces.Fields["Prix_total"].Value;
                    rstPiecesCumulatint.Fields["Profit_Argent"].Value = rstPieces.Fields["Profit_Argent"].Value;
                    rstPiecesCumulatint.Fields["SousSection"].Value = rstPieces.Fields["SousSection"].Value;
                    rstPiecesCumulatint.Fields["OrdreSection"].Value = rstPieces.Fields["OrdreSection"].Value;
                    rstPiecesCumulatint.Fields["NuméroLigne"].Value = rstPieces.Fields["NuméroLigne"].Value;
                    rstPiecesCumulatint.Fields["PrixOrigine"].Value = rstPieces.Fields["PrixOrigine"].Value;
                    rstPiecesCumulatint.Fields["Type"].Value = rstPieces.Fields["Type"].Value;
                    rstPiecesCumulatint.Fields["Visible"].Value = rstPieces.Fields["Visible"].Value;
                    rstPiecesCumulatint.Fields["Commentaire"].Value = rstPieces.Fields["Commentaire"].Value;
                    rstPiecesCumulatint.Fields["Devise"].Value = rstPieces.Fields["Devise"].Value;
                    rstPiecesCumulatint.Fields["Provenance"].Value = Droite(rstPieces.Fields["IDSoumission"].Value, 2);
                    rstPiecesCumulatint.Update();
                    rstPieces.MoveNext();
                }
                rstPiecesCumulatint.Close();
                rstPieces.Close();
                rstSoum = new Recordset();
                rstPieces = new Recordset();
                rstSoumCumulatint = new Recordset();
                rstPiecesCumulatint = new Recordset();
                if (bSupprimer == false)
                {
                    CalculerTotalRecordset(sNoCumulatint);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RecreerSoumissionCumulatif", ex);
            }
        }
        private void ExporterVersExcel(ADODB.Recordset oRecordset)
        {
            try
            {
                int iCount;
                Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook oXLBook;
                Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
                oXLBook = oXLApp.Workbooks.Add(oXLApp.Application.Name);
                oXLSheet = oXLBook.Worksheets[1];
                oXLSheet.Columns[1].ColumnWidth = 10;
                oXLSheet.Columns[2].ColumnWidth = 8;
                oXLSheet.Columns[3].ColumnWidth = 20;
                oXLSheet.Columns[4].ColumnWidth = 45;
                oXLSheet.Columns[5].ColumnWidth = 20;
                oXLSheet.Columns[6].ColumnWidth = 12;
                oXLSheet.Columns[7].ColumnWidth = 12;
                oXLSheet.Columns[8].ColumnWidth = 12;
                oXLSheet.Columns[9].ColumnWidth = 12;
                oXLSheet.Columns[10].ColumnWidth = 30;
                oXLSheet.Columns[11].ColumnWidth = 20;
                oXLSheet.Columns[12].ColumnWidth = 20;
                oXLSheet.Range["A1: N1"].Font.Bold = true;
                {
                    ref var withBlock = ref oXLSheet;
                    var loopTo = oRecordset.Fields.Count - 1;
                    for (iCount = 0; iCount <= loopTo; iCount++)
                        withBlock.Cells[1, iCount + 1] = oRecordset.Fields[iCount].Name;
                }
                oXLApp.Visible = true;
                oXLSheet = default;
                oXLBook = default;
                oXLApp = default;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMec", "ExporterVersExcel", ex);
            }
        }
        private void ModifierTexte()
        {
            try
            {
                string sTexte;
                sTexte = Interaction.InputBox("Quel est le nouveau texte?", DefaultResponse: lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text);
                if (!string.IsNullOrEmpty(sTexte))
                {
                    if (Strings.Len(sTexte) > 255)
                    {
                        MessageBox.Show("Le texte ne pas dépasser 255 caractères!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (lvwSoumission.FocusedItem.SubItems.Count > I_COL_SOUM_DESCR)
                    {
                        lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text = sTexte;
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sTexte));
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModifierTexte", ex);
            }
        }
        private void ModifierSousSection()
        {
            try
            {
                string sSousSection;
                string sAncienneSS;
                string sTag;
                short X;
                sSousSection = Interaction.InputBox("Quel est le nouveau nom ?", DefaultResponse: lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text);
                if (sSousSection.Length > 0)
                {
                    sAncienneSS = lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text;
                    if (string.IsNullOrEmpty(sAncienneSS))
                    {
                        sAncienneSS = S_PAS_SOUS_SECTION;
                    }
                    if (string.IsNullOrEmpty(Strings.Trim(sSousSection)))
                    {
                        sTag = S_PAS_SOUS_SECTION;
                        sSousSection = string.Empty;
                    }
                    else
                    {
                        sTag = sSousSection;
                    }
                    if (lvwSoumission.FocusedItem.SubItems.Count > I_COL_SOUM_DESCR)
                    {
                        lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_DESCR].Text = sSousSection;
                    }
                    else
                    {
                        lvwSoumission.FocusedItem.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sSousSection));
                    }
                    var loopTo = (short)lvwSoumission.Items.Count;
                    for (X = (short)(lvwSoumission.FocusedItem.Index + 1); X <= loopTo; X++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Tag, sAncienneSS, false)))
                        {
                            lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Tag = sTag;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModifierSousSection", ex);
            }
        }
        private void RemplirOptionsMenuRightClick(short iNbreSelected)
        {
            var COLOR_NOIR = default(object);
            var COLOR_MAGENTA = default(object);
            var COLOR_ROUGE = default(object);
            var COLOR_VERT_FORET = default(object);
            var COLOR_GRIS = default(object);
            var COLOR_BRUN = default(object);
            var COLOR_ORANGE = default(object);
            var g_bModificationFacturation = default(object);
            try
            {
                var bFacturer = default(bool);
                var bNC = default(bool);
                var bDateRequise = default(bool);
                var bCommentaire = default(bool);
                var bID = default(bool);
                var bMauvaisPrix = default(bool);
                var bMaterielInutile = default(bool);
                var bTexte = default(bool);
                var bSousSection = default(bool);
                var bFournisseur = default(bool);
                var bAnnulerCommande = default(bool);
                var bSupprimer = default(bool);
                var bAjouterPrix = default(bool);
                var bSortieMagasin = default(bool);
                var bChangerQuantite = default(bool);
                if (iNbreSelected > 1)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        // chk: g_bModificationFacturation.
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationFacturation, true, false)))
                        {
                            bFacturer = true;
                            bNC = true;
                            bSupprimer = true;
                        }
                    }
                    else
                    {
                        bSupprimer = true;
                    }
                }
                // Si c'est une sous-section
                else if (string.IsNullOrEmpty(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text))
                {
                    bSousSection = true;
                }
                else if (lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text == "Texte" | lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text == "Text")
                {
                    bTexte = true;
                    if (m_eType == EnumType.TYPE_SOUMISSION | m_eType == EnumType.TYPE_PROJET & double.Parse(Droite(txtNoProjSoum.Text, 2)) > 19d)
                    {
                        bSupprimer = true;
                    }
                }
                else
                {
                    if (ColorTranslator.ToOle(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor) == -2147483640)
                    {
                        lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor = ColorTranslator.FromOle(0);
                    }
                    switch (ColorTranslator.ToOle(lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].ForeColor))
                    {
                        case var @case when Operators.ConditionalCompareObjectEqual(@case, COLOR_ORANGE, false):
                            {
                                // chk: g_bModificationFacturation.
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationFacturation, true, false)))
                                {
                                    bFacturer = true;
                                    bNC = true;
                                }
                                bID = true;
                                bDateRequise = true;
                                bCommentaire = true;
                                bAnnulerCommande = true;
                                bMauvaisPrix = true;
                                break;
                            }
                        case var case1 when Operators.ConditionalCompareObjectEqual(case1, COLOR_BRUN, false):
                            {
                                bCommentaire = true;
                                bFournisseur = true;
                                if (m_eType == EnumType.TYPE_SOUMISSION | m_eType == EnumType.TYPE_PROJET & double.Parse(Droite(txtNoProjSoum.Text, 2)) > 19d)
                                {
                                    bSupprimer = true;
                                }
                                break;
                            }
                        case var case2 when Operators.ConditionalCompareObjectEqual(case2, COLOR_GRIS, false):
                            {
                                // chk: g_bModificationFacturation.
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationFacturation, true, false)))
                                {
                                    bFacturer = true;
                                    bNC = true;
                                }
                                bCommentaire = true;
                                bID = true;
                                bMauvaisPrix = true;
                                bMaterielInutile = true;
                                break;
                            }
                        case var case3 when Operators.ConditionalCompareObjectEqual(case3, COLOR_VERT_FORET, false):
                            {
                                bCommentaire = true;
                                if (m_eType == EnumType.TYPE_SOUMISSION | m_eType == EnumType.TYPE_PROJET & double.Parse(Droite(txtNoProjSoum.Text, 2)) > 19d)
                                {
                                    bSupprimer = true;
                                }
                                break;
                            }
                        case var case4 when Operators.ConditionalCompareObjectEqual(case4, COLOR_ROUGE, false):
                            {
                                bCommentaire = true;
                                break;
                            }
                        case var case5 when Operators.ConditionalCompareObjectEqual(case5, COLOR_MAGENTA, false):
                            {
                                bCommentaire = true;
                                bAjouterPrix = true;
                                if (m_eType == EnumType.TYPE_PROJET)
                                {
                                    bID = true;
                                }
                                if (m_eType == EnumType.TYPE_SOUMISSION)
                                {
                                    bChangerQuantite = true;
                                }
                                break;
                            }
                        case var case6 when Operators.ConditionalCompareObjectEqual(case6, COLOR_NOIR, false):
                            {
                                if (m_eType == EnumType.TYPE_PROJET)
                                {
                                    // chk: g_bModificationFacturation.
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationFacturation, true, false)))
                                    {
                                        bFacturer = true;
                                        bNC = true;
                                    }
                                    bID = true;
                                    bMaterielInutile = true;
                                    bSortieMagasin = true;
                                }
                                else
                                {
                                    bChangerQuantite = true;
                                }
                                bCommentaire = true;
                                bMauvaisPrix = true;
                                bFournisseur = true;
                                bSupprimer = true;
                                break;
                            }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirOptionsMenuRightClick", ex);
            }
        }
        private void EnregistrerFACT(string sNoProjet)
        {
            var IdLoginEmploye = default(object);
            try
            {
                ADODB.Recordset rstModif;
                ADODB.Recordset rstEmploye;
                var sPrixTotal = default(string);
                var sProfit = default(string);
                var sCommission = default(string);
                string sNoFacture;
                var sTempsFab = default(string);
                var sTotalPiece = default(string);
                var sImprevue = default(string);
                var sTotalTemps = default(string);
                var sManuel = default(string);
                short X;
                short iIndexFacture;
                List<String> collFacture;
                bool bExiste;
                collFacture = new List<String>();
                UpdateSQL("DELETE FROM Projet_Modif WHERE IDProjet = '" + sNoProjet + "' AND Type = 'E' AND TypeModif = 'FACTURATION'");
                if (lvwSoumission.Items.Count > 0)
                {
                    rstModif = new Recordset();
                    rstEmploye = new Recordset();
                    var loopTo = (short)lvwSoumission.Items.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        bExiste = false;
                        sNoFacture = lvwSoumission.Items[X].SubItems[I_COL_SOUM_FACTURATION].Text;
                        if (!string.IsNullOrEmpty(Strings.Trim(sNoFacture)))
                        {
                            var loopTo1 = (short)collFacture.Count;
                            for (iIndexFacture = 1; iIndexFacture <= loopTo1; iIndexFacture++)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(collFacture[iIndexFacture], sNoFacture, false)))
                                {
                                    bExiste = true;
                                    break;
                                }
                            }
                            if (bExiste == false)
                            {
                                collFacture.Add(sNoFacture);
                                CalculerPrixFacturation(sNoFacture, ref sCommission, ref sPrixTotal, ref sProfit, ref sTempsFab, ref sTotalPiece, ref sImprevue, ref sTotalTemps, ref sManuel);
                                rstModif.Open("SELECT * FROM Projet_Modif WHERE [Date] = '" + Strings.Replace(sNoFacture, "F-", "") + "' AND TypeModif = 'FACTURATION'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstModif.EOF)
                                {
                                    rstModif.AddNew();
                                }
                                rstModif.Fields["IDProjet"].Value = txtNoProjSoum.Text;
                                rstEmploye.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Employés WHERE loginname = '", IdLoginEmploye), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                rstModif.Fields["NoEmployé"].Value = rstEmploye.Fields["NoEmploye"].Value;
                                rstEmploye.Close();
                                rstModif.Fields["Date"].Value = Strings.Replace(sNoFacture, "F-", "");
                                rstModif.Fields["Heure"].Value = " ";
                                rstModif.Fields["Type"].Value = "E";
                                rstModif.Fields["TypeModif"].Value = "FACTURATION";
                                rstModif.Fields["Valeur"].Value = sPrixTotal;
                                rstModif.Update();
                                rstModif.Close();
                            }
                        }
                    }
                    rstModif = default;
                    rstEmploye = default;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "EnregistrerFACT", ex);
            }
        }
        private bool BackupPieces1(string sNoProjSoum)
        {
            bool BackupPiecesRet = default;
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstProjSoumBackup;
                string sDateCopie;
                rstProjSoum = new Recordset();
                rstProjSoumBackup = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjSoumBackup.Open("SELECT * FROM Projet_Pieces_Tampon", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    rstProjSoumBackup.Open("SELECT * FROM Soumission_Pieces_Tampon", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                sDateCopie = ConvertDate(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
                while (!rstProjSoum.EOF)
                {
                    rstProjSoumBackup.AddNew();
                    rstProjSoumBackup.Fields["DateCopie"].Value = sDateCopie;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        rstProjSoumBackup.Fields["IDProjet"].Value = rstProjSoum.Fields["IDProjet"].Value;
                    }
                    else
                    {
                        rstProjSoumBackup.Fields["IDSoumission"].Value = rstProjSoum.Fields["IDSoumission"].Value;
                    }
                    rstProjSoumBackup.Fields["Initiales"].Value = Conteneur.idInitiales.Text;
                    rstProjSoumBackup.Fields["IDSection"].Value = rstProjSoum.Fields["IDSection"].Value;
                    rstProjSoumBackup.Fields["NumItem"].Value = rstProjSoum.Fields["NumItem"].Value;
                    rstProjSoumBackup.Fields["Qté"].Value = rstProjSoum.Fields["Qté"].Value;
                    rstProjSoumBackup.Fields["Desc_FR"].Value = rstProjSoum.Fields["Desc_FR"].Value;
                    rstProjSoumBackup.Fields["Desc_EN"].Value = rstProjSoum.Fields["Desc_EN"].Value;
                    rstProjSoumBackup.Fields["Manufact"].Value = rstProjSoum.Fields["Manufact"].Value;
                    rstProjSoumBackup.Fields["Prix_list"].Value = rstProjSoum.Fields["Prix_list"].Value;
                    rstProjSoumBackup.Fields["Escompte"].Value = rstProjSoum.Fields["Escompte"].Value;
                    rstProjSoumBackup.Fields["Prix_net"].Value = rstProjSoum.Fields["Prix_net"].Value;
                    rstProjSoumBackup.Fields["IDFRS"].Value = rstProjSoum.Fields["IDFRS"].Value;
                    rstProjSoumBackup.Fields["Temps"].Value = rstProjSoum.Fields["Temps"].Value;
                    rstProjSoumBackup.Fields["Temps_total"].Value = rstProjSoum.Fields["Temps_total"].Value;
                    rstProjSoumBackup.Fields["Prix_total"].Value = rstProjSoum.Fields["Prix_total"].Value;
                    rstProjSoumBackup.Fields["Profit_Argent"].Value = rstProjSoum.Fields["Profit_Argent"].Value;
                    rstProjSoumBackup.Fields["sousSection"].Value = rstProjSoum.Fields["sousSection"].Value;
                    rstProjSoumBackup.Fields["OrdreSection"].Value = rstProjSoum.Fields["OrdreSection"].Value;
                    rstProjSoumBackup.Fields["NuméroLigne"].Value = rstProjSoum.Fields["NuméroLigne"].Value;
                    rstProjSoumBackup.Fields["PrixOrigine"].Value = rstProjSoum.Fields["PrixOrigine"].Value;
                    rstProjSoumBackup.Fields["Type"].Value = rstProjSoum.Fields["Type"].Value;
                    rstProjSoumBackup.Fields["Visible"].Value = rstProjSoum.Fields["Visible"].Value;
                    rstProjSoumBackup.Fields["Commandé"].Value = rstProjSoum.Fields["Commandé"].Value;
                    rstProjSoumBackup.Fields["Quoté"].Value = rstProjSoum.Fields["Quoté"].Value;
                    rstProjSoumBackup.Fields["Recu"].Value = rstProjSoum.Fields["Recu"].Value;
                    rstProjSoumBackup.Fields["Retour"].Value = rstProjSoum.Fields["Retour"].Value;
                    rstProjSoumBackup.Fields["CommandeAnnulée"].Value = rstProjSoum.Fields["CommandeAnnulée"].Value;
                    rstProjSoumBackup.Fields["ID"].Value = rstProjSoum.Fields["ID"].Value;
                    rstProjSoumBackup.Fields["PieceExtra"].Value = rstProjSoum.Fields["PieceExtra"].Value;
                    rstProjSoumBackup.Fields["PieceExtraChargeable"].Value = rstProjSoum.Fields["PieceExtraChargeable"].Value;
                    rstProjSoumBackup.Fields["PieceExtraNonChargeable"].Value = rstProjSoum.Fields["PieceExtraNonChargeable"].Value;
                    rstProjSoumBackup.Fields["MatérielInutile"].Value = rstProjSoum.Fields["MatérielInutile"].Value;
                    rstProjSoumBackup.Fields["Commentaire"].Value = rstProjSoum.Fields["Commentaire"].Value;
                    rstProjSoumBackup.Fields["Devise"].Value = rstProjSoum.Fields["Devise"].Value;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        rstProjSoumBackup.Fields["NoRetour"].Value = rstProjSoum.Fields["NoRetour"].Value;
                        rstProjSoumBackup.Fields["DateRéception"].Value = rstProjSoum.Fields["DateRéception"].Value;
                        rstProjSoumBackup.Fields["QuantitéRecue"].Value = rstProjSoum.Fields["QuantitéRecue"].Value;
                        rstProjSoumBackup.Fields["Facturation"].Value = rstProjSoum.Fields["Facturation"].Value;
                        rstProjSoumBackup.Fields["DateCommande"].Value = rstProjSoum.Fields["DateCommande"].Value;
                        rstProjSoumBackup.Fields["DateRequise"].Value = rstProjSoum.Fields["DateRequise"].Value;
                        rstProjSoumBackup.Fields["NomCommande"].Value = rstProjSoum.Fields["NomCommande"].Value;
                        rstProjSoumBackup.Fields["NoSéquentiel"].Value = rstProjSoum.Fields["NoSéquentiel"].Value;
                        rstProjSoumBackup.Fields["DateRetour"].Value = rstProjSoum.Fields["DateRetour"].Value;
                    }
                    rstProjSoumBackup.Fields["Provenance"].Value = rstProjSoum.Fields["Provenance"].Value;
                    rstProjSoumBackup.Update();
                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                rstProjSoumBackup.Close();
                rstProjSoumBackup = default;
                BackupPiecesRet = true;
                return BackupPiecesRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "BackupPieces", ex);
                return false;
            }
        }
        private void EnregistrerProjSoum(string sNoProjSoum)
        {
            var COLOR_ROSE = default(object);
            var COLOR_BLEU = default(object);
            var COLOR_BRUN = default(object);
            var COLOR_VERT_FORET = default(object);
            var COLOR_ROUGE = default(object);
            var COLOR_GRIS = default(object);
            var COLOR_ORANGE = default(object);
            var g_bModificationFacturation = default(object);
            var IdLoginEmploye = default(object);
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstModif;
                ADODB.Recordset rstOuvert;
                ADODB.Recordset rstSection;
                ADODB.Recordset rstPunch;
                short X;
                ListViewItem itmPiece;
                string sTable;
                string sTableModif;
                string sTablePiece;
                string sChamps;
                string sSection;
                var sExtra = default(string);
                var bCalculExtra = default(bool);
                List<String> collExtra;
                short XExtra;
                bool bExiste;
                var bAjoutCommande = default(bool);
                double dblNbrePers;
                double dblJoursHebergement;
                double dblJoursRepas;
                double dblHebergement1;
                double dblHebergement2;
                double dblRepas;
                double dblTotalHebergement;
                rstProjSoum = new Recordset();
                rstPiece = new Recordset();
                rstEmploye = new Recordset();
                rstModif = new Recordset();
                rstOuvert = new Recordset();
                rstSection = new Recordset();
                collExtra = new List<String>();
                // chk: IdLoginEmploye.
                rstEmploye.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT noEmploye FROM Employés WHERE loginname = '", IdLoginEmploye), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si c'est un projet
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sTable = "ProjetElec";
                    sTableModif = "Projet_Modif";
                    sTablePiece = "Projet_Pieces";
                    sChamps = "IDProjet";
                }
                else
                {
                    sTable = "SoumissionElec";
                    sTableModif = "Soumission_Modif";
                    sTablePiece = "Soumission_Pieces";
                    sChamps = "IDSoumission";
                }
                if (m_bModeAjout == true)
                {

                    rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (rstProjSoum.EOF)
                        {
                            bAjoutCommande = true;
                        }
                        else
                        {
                            bAjoutCommande = false;
                        }
                    }
                    else
                    {
                        bAjoutCommande = false;
                    }
                    rstProjSoum.AddNew();
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        rstProjSoum.Fields["LiaisonChargeable"].Value = m_sLiaison;
                    }
                    rstProjSoum.Fields["Creer"].Value = ConvertDate(DateTime.Today);
                    rstProjSoum.Fields["Creer_Par"].Value = rstEmploye.Fields["noEmploye"].Value;
                    rstProjSoum.Fields[sChamps].Value = sNoProjSoum;
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        rstProjSoum.Fields["IDSoumission"].Value = txtNoSoumission.Text;
                    }
                    rstOuvert.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstOuvert.EOF)
                    {
                        rstOuvert.AddNew();
                        rstOuvert.Fields["IDProjSoum"].Value = sNoProjSoum;
                        rstOuvert.Fields["NoClient"].Value = cmbClient.SelectedIndex;
                        rstOuvert.Fields["Description"].Value = txtProjet.Text;
                        rstOuvert.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today);
                        rstOuvert.Fields["Ouvert"].Value = true;
                        if (m_eType == EnumType.TYPE_PROJET)
                        {
                            rstOuvert.Fields["Type"].Value = "P";
                        }
                        else
                        {
                            rstOuvert.Fields["Type"].Value = "S";
                        }
                        rstOuvert.Update();
                    }
                    rstOuvert.Close();

                    rstOuvert = default;
                    m_bModeAjout = false;
                }
                else
                {
                    EnregistrerSuppression();
                    rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstModif.Open("SELECT * FROM " + sTableModif, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstModif.AddNew();
                    rstModif.Fields["Type"].Value = "E";
                    rstModif.Fields[sChamps].Value = sNoProjSoum;
                    rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                    rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                    rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                    rstModif.Fields["TypeModif"].Value = "MODIFICATION";
                    rstModif.Update();
                    rstModif.Close();

                    rstModif = default;
                    rstOuvert.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstOuvert.Fields["NoClient"].Value != cmbClient.SelectedIndex) ;
                    {
                        rstOuvert.Fields["NoClient"].Value = cmbClient.SelectedIndex;
                        rstPunch = new Recordset();
                        rstPunch.Open("SELECT * FROM Punch WHERE NoProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstPunch.EOF)
                        {
                            if (MessageBox.Show("Le client a été modifié, voulez-vous changer les punch de ce projet ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                while (!rstPunch.EOF)
                                {
                                    rstPunch.Fields["NoClient"].Value = cmbClient.SelectedIndex;
                                    rstPunch.Update();
                                    rstPunch.MoveNext();
                                }
                            }
                        }
                        rstPunch.Close();

                        rstPunch = default;
                    }
                    rstOuvert.Fields["Description"].Value = txtProjet.Text;
                    rstOuvert.Update();
                    rstOuvert.Close();

                    rstOuvert = default;
                    UpdateSQL("DELETE FROM " + sTablePiece + " WHERE " + sChamps + " = '" + sNoProjSoum + "' AND Type = 'E'");
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (double.Parse(Droite(sNoProjSoum, 2)) >= 60d & double.Parse(Droite(sNoProjSoum, 2)) <= 98d)
                        {
                            UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + Gauche(sNoProjSoum, 6) + "-" + rstProjSoum.Fields["LiaisonChargeable"].Value + "' AND Type = 'E' AND (PieceExtraChargeable = 1 OR PieceExtraNonChargeable = 1) AND Provenance = '" + Droite(txtNoProjSoum.Text, 2) + "'");
                        }
                    }
                }


                rstProjSoum.Fields["IDClient"].Value = cmbClient.SelectedIndex;
                rstProjSoum.Fields["IDContact"].Value = cmbContact.SelectedIndex;
                rstProjSoum.Fields["description"].Value = txtProjet.Text;
                rstProjSoum.Fields["NbreManuel"].Value = txtNbreManuel.Text;
                rstProjSoum.Fields["transport"].Value = cmbTransport.Text;
                rstProjSoum.Fields["CSA"].Value = chkCSA.CheckState;
                rstProjSoum.Fields["CUL"].Value = chkCUL.CheckState;
                rstProjSoum.Fields["UL"].Value = chkUL.CheckState;
                rstProjSoum.Fields["CUR"].Value = chkCUR.CheckState;
                rstProjSoum.Fields["UR"].Value = chkUR.CheckState;
                rstProjSoum.Fields["CE"].Value = chkCE.CheckState;
                if (!string.IsNullOrEmpty(txtDelais.Text))
                {
                    rstProjSoum.Fields["Delais"].Value = txtDelais.Text;
                }
                else
                {
                    rstProjSoum.Fields["Delais"].Value = " ";
                }
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    rstProjSoum.Fields["TempsDessin"].Value = m_sTempsDessin;
                    rstProjSoum.Fields["TempsFabrication"].Value = m_sTempsFabrication;
                    rstProjSoum.Fields["TempsAssemblage"].Value = m_sTempsAssemblage;
                    rstProjSoum.Fields["TempsProgInterface"].Value = m_sTempsProgInterface;
                    rstProjSoum.Fields["TempsProgAutomate"].Value = m_sTempsProgAutomate;
                    rstProjSoum.Fields["TempsProgRobot"].Value = m_sTempsProgRobot;
                    rstProjSoum.Fields["TempsVision"].Value = m_sTempsVision;
                    rstProjSoum.Fields["TempsTest"].Value = m_sTempsTest;
                    rstProjSoum.Fields["TempsInstallation"].Value = m_sTempsInstallation;
                    rstProjSoum.Fields["TempsMiseService"].Value = m_sTempsMiseService;
                    rstProjSoum.Fields["TempsFormation"].Value = m_sTempsFormation;
                    rstProjSoum.Fields["TempsGestion"].Value = m_sTempsGestion;
                    rstProjSoum.Fields["TempsShipping"].Value = m_sTempsShipping;
                }
                rstProjSoum.Fields["NbrePersonne"].Value = m_sNbrePersonne;
                rstProjSoum.Fields["TempsHebergement"].Value = m_sTempsHebergement;
                rstProjSoum.Fields["TempsRepas"].Value = m_sTempsRepas;
                rstProjSoum.Fields["TempsTransport"].Value = m_sTempsTransport;
                rstProjSoum.Fields["TempsUniteMobile"].Value = m_sTempsUniteMobile;
                rstProjSoum.Fields["PrixEmballage"].Value = m_sPrixEmballage;
                rstProjSoum.Fields["TauxHebergement1"].Value = m_sTauxHebergement1;
                rstProjSoum.Fields["TauxHebergement2"].Value = m_sTauxHebergement2;
                rstProjSoum.Fields["TauxRepas"].Value = m_sTauxRepas;
                rstProjSoum.Fields["TauxTransport"].Value = m_sTauxTransport;
                rstProjSoum.Fields["TauxUniteMobile"].Value = m_sTauxUniteMobile;
                rstProjSoum.Fields["TauxDessin"].Value = m_sTauxDessin;
                rstProjSoum.Fields["TauxFabrication"].Value = m_sTauxFabrication;
                rstProjSoum.Fields["TauxAssemblage"].Value = m_sTauxAssemblage;
                rstProjSoum.Fields["TauxProgInterface"].Value = m_sTauxProgInterface;
                rstProjSoum.Fields["TauxProgAutomate"].Value = m_sTauxProgAutomate;
                rstProjSoum.Fields["TauxProgRobot"].Value = m_sTauxProgRobot;
                rstProjSoum.Fields["TauxVision"].Value = m_sTauxVision;
                rstProjSoum.Fields["TauxTest"].Value = m_sTauxTest;
                rstProjSoum.Fields["TauxInstallation"].Value = m_sTauxInstallation;
                rstProjSoum.Fields["TauxMiseService"].Value = m_sTauxMiseService;
                rstProjSoum.Fields["TauxFormation"].Value = m_sTauxFormation;
                rstProjSoum.Fields["TauxGestion"].Value = m_sTauxGestion;
                rstProjSoum.Fields["TauxShipping"].Value = m_sTauxShipping;
                rstProjSoum.Fields["imprevue"].Value = m_sImprevue;
                rstProjSoum.Fields["commission"].Value = m_sCommission;
                rstProjSoum.Fields["Profit"].Value = m_sProfit;
                rstProjSoum.Fields["SansTemps"].Value = m_bSansTemps;
                rstProjSoum.Fields["CheminPhotos"].Value = txtCheminPhotos.Text;
                rstProjSoum.Fields["MontantForfait"].Value = txtForfait.Text;
                rstProjSoum.Fields["InitialeForfait"].Value = Strings.Trim(Strings.Replace(lblForfaitInitiale.Text, "Par :", ""));
                if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull))
                {
                    dblNbrePers = (double)rstProjSoum.Fields["NbrePersonne"].Value;
                }
                else
                {
                    dblNbrePers = 0d;
                }
                if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull))
                {
                    dblJoursHebergement = (double)rstProjSoum.Fields["TempsHebergement"].Value;
                }
                else
                {
                    dblJoursHebergement = 0d;
                }
                if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull))
                {
                    dblJoursRepas = (double)rstProjSoum.Fields["TempsRepas"].Value;
                }
                else
                {
                    dblJoursRepas = 0d;
                }
                if (!(rstProjSoum.Fields["TauxHebergement1"].Value is DBNull))
                {
                    dblHebergement1 = (double)rstProjSoum.Fields["TauxHebergement1"].Value;
                }
                else
                {
                    dblHebergement1 = 0d;
                }
                if (!(rstProjSoum.Fields["TauxHebergement2"].Value is DBNull))
                {
                    dblHebergement2 = (double)rstProjSoum.Fields["TauxHebergement2"].Value;
                }
                else
                {
                    dblHebergement2 = 0d;
                }
                if (!(rstProjSoum.Fields["TauxRepas"].Value is DBNull))
                {
                    dblRepas = (double)rstProjSoum.Fields["TauxRepas"].Value;
                }
                else
                {
                    dblRepas = 0d;
                }
                rstProjSoum.Fields["TotalRepas"].Value = dblNbrePers * dblJoursRepas * dblRepas;
                dblTotalHebergement = 0d;
                while (dblNbrePers > 0d)
                {
                    if (dblNbrePers >= 2d)
                    {
                        dblTotalHebergement += dblJoursHebergement * dblHebergement2;
                        dblNbrePers = dblNbrePers - 2d;
                    }
                    else
                    {
                        dblTotalHebergement += dblJoursHebergement * dblHebergement1;
                        dblNbrePers = dblNbrePers - 1d;
                    }
                }
                rstProjSoum.Fields["TotalHebergement"].Value = dblTotalHebergement;
                if (bAjoutCommande == true)
                {
                    rstProjSoum.Fields["ProchaineCommande"].Value = 1;
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstProjSoum.Fields["PrixRéception"].Value = txtPrixReception.Text;
                }
                if (IsNumeric(txtPrixManuel.Text))
                {
                    rstProjSoum.Fields["Total_Manuel"].Value = txtPrixManuel.Text;
                }
                else
                {
                    rstProjSoum.Fields["Total_Manuel"].Value.Text = "0";
                }
                rstProjSoum.Fields["total_Commission"].Value = txtCommission.Text;
                rstProjSoum.Fields["Total_Profit"].Value = txtProfit.Text;
                rstProjSoum.Fields["PrixTotal"].Value = txtPrixTotal.Text;
                rstProjSoum.Fields["Total_piece"].Value = txtTotalPieces.Text;
                rstProjSoum.Fields["total_imprevue"].Value = txtImprevus.Text;
                rstProjSoum.Fields["PrixTotal"].Value = txtPrixTotal.Text;
                rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstPiece.Open("SELECT * FROM Projet_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPiece.Open("SELECT * FROM Soumission_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationFacturation, true, false)))
                    {
                        EnregistrerFACT(sNoProjSoum);
                    }
                }
                var loopTo = (short)lvwSoumission.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, string.Empty, false)))
                    {
                        if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                        {
                            itmPiece = lvwSoumission.Items[X];
                            rstPiece.AddNew();
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                rstPiece.Fields["IDProjet"].Value = sNoProjSoum;
                            }
                            else
                            {
                                rstPiece.Fields["IDSoumission"].Value = sNoProjSoum;
                            }
                            rstPiece.Fields["Type"].Value = "E";
                            if (itmPiece.Checked == true)
                            {
                                rstPiece.Fields["Visible"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["Visible"].Value = false;
                            }
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                rstPiece.Fields["Facturation"].Value = itmPiece.SubItems[I_COL_SOUM_FACTURATION].Text;
                                if (string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_FACTURATION].Text))
                                {
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_FACTURATION)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_FACTURATION].Text = " ";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, " "));
                                    }
                                }
                                if (string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_DATE_COMMANDE].Text))
                                {
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_DATE_COMMANDE)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_DATE_COMMANDE].Text = " ";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, " "));
                                    }
                                }
                                rstPiece.Fields["NoRetour"].Value = itmPiece.SubItems[I_COL_SOUM_DATE_COMMANDE].Tag;
                                rstPiece.Fields["DateRéception"].Value = itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Tag;
                            }
                            rstPiece.Fields["IDSection"].Value = itmPiece.Tag;
                            rstPiece.Fields["NumItem"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_PIECE].Text);
                            rstPiece.Fields["Qté"].Value = Strings.Replace(itmPiece.Text, "*", string.Empty);
                            if (itmPiece.SubItems[I_COL_SOUM_PIECE].Text == "Texte" | itmPiece.SubItems[I_COL_SOUM_PIECE].Text == "Text")
                            {
                                rstPiece.Fields["DESC_EN"].Value = "";
                                rstPiece.Fields["DESC_FR"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_DESCR].Text);
                            }
                            else if (m_eLangage == EnumLangage.ANGLAIS)
                            {
                                rstPiece.Fields["DESC_EN"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_DESCR].Text);
                                rstPiece.Fields["DESC_FR"].Value = Strings.Trim(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_DESCR].Tag));
                            }
                            else
                            {
                                rstPiece.Fields["DESC_FR"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_DESCR].Text);
                                rstPiece.Fields["DESC_EN"].Value = Strings.Trim(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_DESCR].Tag));
                            }
                            rstPiece.Fields["Manufact"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_MANUFACT].Text);
                            rstPiece.Fields["Prix_list"].Value = Conversion_Renamed(itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text, EnumConvert.MODE_PAS_FORMAT, 4);
                            if (!string.IsNullOrEmpty(Strings.Trim(itmPiece.SubItems[I_COL_SOUM_ESCOMPTE].Text)))
                            {
                                rstPiece.Fields["Escompte"].Value = Conversion_Renamed((double.Parse(Strings.Replace(itmPiece.SubItems[I_COL_SOUM_ESCOMPTE].Text, "%", "")) / 100d).ToString(), EnumConvert.MODE_PAS_FORMAT);
                            }
                            else
                            {
                                rstPiece.Fields["Escompte"].Value = "";
                            }
                            rstPiece.Fields["Prix_net"].Value = Conversion_Renamed(itmPiece.SubItems[I_COL_SOUM_PRIX_NET].Text, EnumConvert.MODE_PAS_FORMAT, 4);
                            rstPiece.Fields["OrdreSection"].Value = itmPiece.SubItems[I_COL_SOUM_MANUFACT].Tag;
                            rstPiece.Fields["NuméroLigne"].Value = X;
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_ORANGE, false)))
                            {
                                rstPiece.Fields["Commandé"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["Commandé"].Value = false;
                            }
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_GRIS, false)))
                            {
                                rstPiece.Fields["Recu"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["Recu"].Value = false;
                            }
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_ROUGE, false)))
                            {
                                rstPiece.Fields["Retour"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["Retour"].Value = false;
                            }
                            if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_VERT_FORET, false), itmPiece.SubItems[I_COL_SOUM_PIECE].Font.Bold == true)))
                            {
                                rstPiece.Fields["CommandeAnnulée"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["CommandeAnnulée"].Value = false;
                            }
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_BRUN, false)))
                            {
                                rstPiece.Fields["MatérielInutile"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["MatérielInutile"].Value = false;
                            }
                            if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_DISTRIB].Text))
                            {
                                rstPiece.Fields["IDFRS"].Value = itmPiece.SubItems[I_COL_SOUM_DISTRIB].Tag;
                            }
                            rstPiece.Fields["Temps"].Value = Strings.Trim(itmPiece.SubItems[I_COL_SOUM_TEMPS].Text);
                            rstPiece.Fields["Temps_Total"].Value = itmPiece.SubItems[I_COL_SOUM_MONTAGE].Text;
                            rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed(itmPiece.SubItems[I_COL_SOUM_TOTAL].Text, EnumConvert.MODE_PAS_FORMAT);
                            rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed(itmPiece.SubItems[I_COL_SOUM_PROFIT].Text, EnumConvert.MODE_PAS_FORMAT);
                            if (Strings.Len(itmPiece.SubItems[I_COL_SOUM_PIECE].Tag) <= 50)
                            {
                                rstPiece.Fields["SousSection"].Value = itmPiece.SubItems[I_COL_SOUM_PIECE].Tag;
                            }
                            else
                            {
                                rstPiece.Fields["SousSection"].Value = Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PIECE].Tag), 50);
                            }
                            if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Text))
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Tag, string.Empty, false)))
                                {
                                    rstPiece.Fields["PrixOrigine"].Value = Strings.Replace(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PRIX_LIST].Tag), ".", ",")), 4).ToString(), ".", ",");
                                }
                                else
                                {
                                    rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                                }
                            }
                            else
                            {
                                rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                            }
                            if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_TOTAL].Text))
                            {
                                rstPiece.Fields["Devise"].Value = itmPiece.SubItems[I_COL_SOUM_TOTAL].Tag;
                            }
                            else
                            {
                                rstPiece.Fields["Devise"].Value = "";
                            }
                            if (Strings.InStr(1, itmPiece.Text, "*") > 0)
                            {
                                rstPiece.Fields["Quoté"].Value = true;
                            }
                            else
                            {
                                rstPiece.Fields["Quoté"].Value = false;
                            }
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                if (Conversions.ToBoolean(Strings.Trim(Conversions.ToString(!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_ID].Text)))))
                                {
                                    rstPiece.Fields["ID"].Value = itmPiece.SubItems[I_COL_SOUM_ID].Text;
                                }
                                rstPiece.Fields["DateCommande"].Value = itmPiece.SubItems[I_COL_SOUM_DATE_COMMANDE].Text;
                                rstPiece.Fields["DateRequise"].Value = itmPiece.SubItems[I_COL_SOUM_DATE_REQUISE].Text;
                                if (string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_DATE_REQUISE].Text))
                                {
                                    if (itmPiece.SubItems.Count > I_COL_SOUM_DATE_REQUISE)
                                    {
                                        itmPiece.SubItems[I_COL_SOUM_DATE_REQUISE].Text = " ";
                                    }
                                    else
                                    {
                                        itmPiece.SubItems.Insert(I_COL_SOUM_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, " "));
                                    }
                                }
                                rstPiece.Fields["DateRetour"].Value = itmPiece.SubItems[I_COL_SOUM_DATE_REQUISE].Tag;
                                rstPiece.Fields["NomCommande"].Value = itmPiece.SubItems[I_COL_SOUM_NOM_COMMANDE].Text;
                                rstPiece.Fields["NoSéquentiel"].Value = itmPiece.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text;
                            }
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_ROSE, false)))
                                {
                                    rstPiece.Fields["PieceExtraNonChargeable"].Value = true;
                                    rstPiece.Fields["PieceExtraChargeable"].Value = false;
                                }
                                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmPiece.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_BLEU, false)))
                                {
                                    rstPiece.Fields["PieceExtraChargeable"].Value = true;
                                    rstPiece.Fields["PieceExtraNonChargeable"].Value = false;
                                }
                                else if (Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 6) == "RETOUR" | Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 10) == "ANNULATION")
                                {
                                    sExtra = Droite(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 2);
                                    if (Operators.CompareString(sExtra, "80", false) >= 0 & Operators.CompareString(sExtra, "98", false) <= 0)
                                    {
                                        rstPiece.Fields["PieceExtraNonChargeable"].Value = true;
                                        rstPiece.Fields["PieceExtraChargeable"].Value = false;
                                    }
                                    else
                                    {
                                        rstPiece.Fields["PieceExtraChargeable"].Value = true;
                                        rstPiece.Fields["PieceExtraNonChargeable"].Value = false;
                                    }
                                }
                                if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_SOUM_PROVENANCE].Text))
                                {
                                    rstPiece.Fields["Provenance"].Value = Droite(itmPiece.SubItems[I_COL_SOUM_PROVENANCE].Text, 2);
                                }
                                else if (Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 6) == "RETOUR" | Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 10) == "ANNULATION")
                                {
                                    rstPiece.Fields["Provenance"].Value = sExtra;
                                }
                            }
                            rstPiece.Fields["Commentaire"].Value = itmPiece.SubItems[I_COL_SOUM_COMMENTAIRE].Text;
                            rstPiece.Update();
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                if (double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 98d & double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 80d)
                                {
                                    AjouterPiecesExtraDansJob(itmPiece, rstProjSoum.Fields["LiaisonChargeable"].Value);
                                }
                                else if (double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 79d & double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 60d)
                                {
                                    AjouterPiecesExtraChargeableDansJob(itmPiece, rstProjSoum.Fields["LiaisonChargeable"].Value);
                                }
                                else if (Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 6) == "RETOUR")
                                {
                                    AjouterInutileDansExtra(itmPiece, sExtra);
                                    bCalculExtra = true;
                                    bExiste = false;
                                    var loopTo1 = (short)collExtra.Count;
                                    for (XExtra = 1; XExtra <= loopTo1; XExtra++)
                                    {
                                        // chk: collExtra(XExtra).
                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(collExtra[XExtra], Droite(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 2), false)))
                                        {
                                            bExiste = true;
                                            break;
                                        }
                                    }
                                    if (bExiste == false)
                                    {
                                        collExtra.Add(Droite(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 2));
                                    }
                                }
                                else if (Gauche(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 10) == "ANNULATION")
                                {
                                    AjouterAnnulationDansExtra(itmPiece, sExtra);
                                    bCalculExtra = true;
                                    bExiste = false;
                                    var loopTo2 = (short)collExtra.Count;
                                    for (XExtra = 1; XExtra <= loopTo2; XExtra++)
                                    {
                                        // chk: collExtra(XExtra).
                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(collExtra[XExtra], Droite(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 2), false)))
                                        {
                                            bExiste = true;
                                            break;
                                        }
                                    }
                                    if (bExiste == false)
                                    {
                                        collExtra.Add(Droite(Conversions.ToString(itmPiece.SubItems[I_COL_SOUM_PROFIT].Tag), 2));
                                    }
                                }
                            }
                        }
                    }
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (double.Parse(Droite(txtNoProjSoum.Text, 2)) <= 98d & double.Parse(Droite(txtNoProjSoum.Text, 2)) >= 60d)
                    {
                        CalculerTotalRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + rstProjSoum.Fields["LiaisonChargeable"].Value);
                    }
                }
                if (bCalculExtra == true)
                {
                    var loopTo3 = (short)collExtra.Count;
                    for (XExtra = 1; XExtra <= loopTo3; XExtra++)
                        // chk: collExtra(XExtra).
                        CalculerTotalRecordset(Conversions.ToString(Operators.ConcatenateObject(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2), collExtra[XExtra])));
                }
                rstProjSoum.Fields["total_temps"].Value = txtTotalTemps.Text;
                rstProjSoum.Update();
                rstProjSoum.Close();
                rstProjSoum = default;
                rstPiece.Close();
                rstPiece = default;
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    AjouterSoumissionAuCumulatif();
                }
                else
                {
                    AjouterProjetAuCumulatif();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "EnregistrerProjSoum", ex, sNoProjSoum);
            }
        }
        private void AjouterPiecesExtraChargeableDansJob(ListViewItem itmSource, string sLiaison)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSection;
                short X;
                string sSection;
                var bSkip = default(bool);
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si le projet existe
                if (!rstProjet.EOF)
                {

                    rstPiece = new Recordset();

                    rstPiece.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "' AND IDSection = ", itmSource.Tag), " AND SousSection = '"), Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PIECE].Tag), "'", "''")), "' ORDER BY NuméroLigne"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstPiece.EOF)
                    {
                        rstPiece.MoveLast();
                        X = rstPiece.Fields["NuméroLigne"].Value + 1;
                    }
                    else
                    {
                        X = 1;
                    }
                    rstPiece.AddNew();
                    rstPiece.Fields["IDProjet"].Value = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison;
                    rstPiece.Fields["Type"].Value = "E";
                    if (itmSource.Checked == true)
                    {
                        rstPiece.Fields["Visible"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Visible"].Value = false;
                    }

                    rstPiece.Fields["Facturation"].Value = itmSource.SubItems[I_COL_SOUM_FACTURATION].Text;

                    rstPiece.Fields["IDSection"].Value = itmSource.Tag;

                    rstPiece.Fields["NumItem"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_PIECE].Text);
                    rstPiece.Fields["Qté"].Value = Strings.Replace(itmSource.Text, "*", string.Empty);

                    rstPiece.Fields["Desc_FR"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                    rstPiece.Fields["Desc_EN"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));

                    rstPiece.Fields["Manufact"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_MANUFACT].Text);

                    rstPiece.Fields["Prix_list"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text, EnumConvert.MODE_PAS_FORMAT, 4);

                    rstPiece.Fields["Escompte"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_ESCOMPTE].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Prix_net"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_NET].Text, EnumConvert.MODE_PAS_FORMAT, 4);


                    rstPiece.Fields["OrdreSection"].Value = itmSource.SubItems[I_COL_SOUM_MANUFACT].Tag;
                    rstPiece.Fields["NuméroLigne"].Value = X;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_DISTRIB].Text))
                    {


                        rstPiece.Fields["IDFRS"].Value = itmSource.SubItems[I_COL_SOUM_DISTRIB].Tag;
                    }

                    rstPiece.Fields["Temps"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_TEMPS].Text);

                    rstPiece.Fields["Temps_Total"].Value = itmSource.SubItems[I_COL_SOUM_MONTAGE].Text;

                    rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_TOTAL].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PROFIT].Text, EnumConvert.MODE_PAS_FORMAT);


                    rstPiece.Fields["SousSection"].Value = itmSource.SubItems[I_COL_SOUM_PIECE].Tag;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text))
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag, string.Empty, false)))
                        {

                            rstPiece.Fields["PrixOrigine"].Value = Strings.Replace(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag), ".", ",")), 4).ToString(), ".", ",");
                        }
                        else
                        {
                            rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                        }
                    }
                    else
                    {
                        rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                    }
                    if (Strings.InStr(1, itmSource.Text, "*") > 0)
                    {
                        rstPiece.Fields["Quoté"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Quoté"].Value = false;
                    }

                    if (Conversions.ToBoolean(Strings.Trim(Conversions.ToString(!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_ID].Text)))))
                    {

                        rstPiece.Fields["ID"].Value = itmSource.SubItems[I_COL_SOUM_ID].Text;
                    }
                    rstPiece.Fields["PieceExtraChargeable"].Value = true;
                    rstPiece.Fields["Provenance"].Value = Droite(txtNoProjSoum.Text, 2);
                    rstPiece.Update();
                    rstPiece.Close();
                    rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "' AND NuméroLigne >= " + X + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                    while (!rstPiece.EOF)
                    {

                        if (rstPiece.Fields["PieceExtraChargeable"].Value == true & rstPiece.Fields["Qté"].Value == itmSource.Text & rstPiece.Fields["NumItem"].Value == itmSource.SubItems[I_COL_SOUM_PIECE].Text & bSkip == false)
                        {
                            bSkip = true;
                        }
                        else
                        {
                            rstPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value + 1;
                            rstPiece.Update();
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = default;
                    CalculerTempsFabricationRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison);
                }
                rstProjet.Close();
                //chk: rstProjet may not be destroyed until it is garbage collected.
                rstProjet = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterPiecesExtraDansJob", ex);
            }
        }
        private void AjouterPiecesExtraDansJob(ListViewItem itmSource, string sLiaison)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSection;
                short X;
                string sSection;
                var bSkip = default(bool);
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si le projet existe
                if (!rstProjet.EOF)
                {

                    rstPiece = new Recordset();

                    rstPiece.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "' AND IDSection = ", itmSource.Tag), " AND SousSection = '"), Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PIECE].Tag), "'", "''")), "' ORDER BY NuméroLigne"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstPiece.EOF)
                    {
                        rstPiece.MoveLast();
                        X = rstPiece.Fields["NuméroLigne"].Value + 1;
                    }
                    else
                    {
                        X = 1;
                    }
                    rstPiece.AddNew();
                    rstPiece.Fields["IDProjet"].Value = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison;
                    rstPiece.Fields["Type"].Value = "E";
                    if (itmSource.Checked == true)
                    {
                        rstPiece.Fields["Visible"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Visible"].Value = false;
                    }

                    rstPiece.Fields["Facturation"].Value = itmSource.SubItems[I_COL_SOUM_FACTURATION].Text;

                    rstPiece.Fields["IDSection"].Value = itmSource.Tag;

                    rstPiece.Fields["NumItem"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_PIECE].Text);
                    rstPiece.Fields["Qté"].Value = Strings.Replace(itmSource.Text, "*", string.Empty);

                    rstPiece.Fields["Desc_FR"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                    rstPiece.Fields["Desc_EN"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));

                    rstPiece.Fields["Manufact"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_MANUFACT].Text);

                    rstPiece.Fields["Prix_list"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text, EnumConvert.MODE_PAS_FORMAT, 4);

                    rstPiece.Fields["Escompte"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_ESCOMPTE].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Prix_net"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_NET].Text, EnumConvert.MODE_PAS_FORMAT, 4);


                    rstPiece.Fields["OrdreSection"].Value = itmSource.SubItems[I_COL_SOUM_MANUFACT].Tag;
                    rstPiece.Fields["NuméroLigne"].Value = X;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_DISTRIB].Text))
                    {


                        rstPiece.Fields["IDFRS"].Value = itmSource.SubItems[I_COL_SOUM_DISTRIB].Tag;
                    }

                    rstPiece.Fields["Temps"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_TEMPS].Text);

                    rstPiece.Fields["Temps_Total"].Value = itmSource.SubItems[I_COL_SOUM_MONTAGE].Text;

                    rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_TOTAL].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PROFIT].Text, EnumConvert.MODE_PAS_FORMAT);


                    rstPiece.Fields["SousSection"].Value = itmSource.SubItems[I_COL_SOUM_PIECE].Tag;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text))
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag, string.Empty, false)))
                        {

                            rstPiece.Fields["PrixOrigine"].Value = Strings.Replace(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag), ".", ",")), 2).ToString(), ".", ",");
                        }
                        else
                        {
                            rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                        }
                    }
                    else
                    {
                        rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                    }
                    if (Strings.InStr(1, itmSource.Text, "*") > 0)
                    {
                        rstPiece.Fields["Quoté"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Quoté"].Value = false;
                    }

                    if (Conversions.ToBoolean(Strings.Trim(Conversions.ToString(!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_ID].Text)))))
                    {

                        rstPiece.Fields["ID"].Value = itmSource.SubItems[I_COL_SOUM_ID].Text;
                    }
                    rstPiece.Fields["PieceExtraNonChargeable"].Value = true;
                    rstPiece.Fields["Provenance"].Value = Droite(txtNoProjSoum.Text, 2);
                    rstPiece.Update();
                    rstPiece.Close();
                    rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison + "' AND NuméroLigne >= " + X + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                    while (!rstPiece.EOF)
                    {

                        if (rstPiece.Fields["PieceExtraNonChargeable"].Value == true & rstPiece.Fields["Qté"].Value == itmSource.Text & rstPiece.Fields["NumItem"].Value == itmSource.SubItems[I_COL_SOUM_PIECE].Text & bSkip == false)
                        {
                            bSkip = true;
                        }
                        else
                        {
                            rstPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value + 1;
                            rstPiece.Update();
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = default;
                    CalculerTempsFabricationRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sLiaison);
                }
                rstProjet.Close();
                //chk: rstProjet may not be destroyed until it is garbage collected.
                rstProjet = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterPiecesExtraDansJob", ex);
            }
        }
        private void AjouterInutileDansExtra(ListViewItem itmSource, string sExtra)
        {
            var COLOR_BRUN = default(object);
            var COLOR_NOIR = default(object);
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSection;
                short X;
                string sSection;
                var bSkip = default(bool);
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si le projet existe
                if (!rstProjet.EOF)
                {

                    rstPiece = new Recordset();

                    rstPiece.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "' AND IDSection = ", itmSource.Tag), " AND SousSection = '"), Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PIECE].Tag), "'", "''")), "' ORDER BY NuméroLigne"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstPiece.EOF)
                    {
                        rstPiece.MoveLast();
                        X = rstPiece.Fields["NuméroLigne"].Value + 1;
                    }
                    else
                    {
                        X = 1;
                    }
                    rstPiece.AddNew();
                    rstPiece.Fields["IDProjet"].Value = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra;
                    rstPiece.Fields["Type"].Value = "E";
                    if (itmSource.Checked == true)
                    {
                        rstPiece.Fields["Visible"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Visible"].Value = false;
                    }

                    rstPiece.Fields["IDSection"].Value = itmSource.Tag;

                    rstPiece.Fields["NumItem"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_PIECE].Text);
                    rstPiece.Fields["Qté"].Value = Strings.Replace(itmSource.Text, "*", string.Empty);
                    if (m_eLangage == EnumLangage.ANGLAIS)
                    {

                        rstPiece.Fields["DESC_EN"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                        rstPiece.Fields["DESC_FR"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));
                    }
                    else
                    {

                        rstPiece.Fields["DESC_FR"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                        rstPiece.Fields["DESC_EN"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));
                    }

                    rstPiece.Fields["Manufact"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_MANUFACT].Text);

                    rstPiece.Fields["Prix_list"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text, EnumConvert.MODE_PAS_FORMAT, 4);

                    rstPiece.Fields["Escompte"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_ESCOMPTE].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Prix_net"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_NET].Text, EnumConvert.MODE_PAS_FORMAT, 4);


                    rstPiece.Fields["OrdreSection"].Value = itmSource.SubItems[I_COL_SOUM_MANUFACT].Tag;
                    rstPiece.Fields["NuméroLigne"].Value = X;

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmSource.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_NOIR, false)))
                    {
                        rstPiece.Fields["MatérielInutile"].Value = false;
                    }
                    else
                    {
                        rstPiece.Fields["MatérielInutile"].Value = true;
                    }

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_DISTRIB].Text))
                    {


                        rstPiece.Fields["IDFRS"].Value = itmSource.SubItems[I_COL_SOUM_DISTRIB].Tag;
                    }

                    rstPiece.Fields["Temps"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_TEMPS].Text);

                    rstPiece.Fields["Temps_Total"].Value = itmSource.SubItems[I_COL_SOUM_MONTAGE].Text;

                    rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_TOTAL].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PROFIT].Text, EnumConvert.MODE_PAS_FORMAT);


                    rstPiece.Fields["SousSection"].Value = itmSource.SubItems[I_COL_SOUM_PIECE].Tag;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text))
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag, string.Empty, false)))
                        {

                            rstPiece.Fields["PrixOrigine"].Value = Strings.Replace(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag), ".", ",")), 4).ToString(), ".", ",");
                        }
                        else
                        {
                            rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                        }
                    }
                    else
                    {
                        rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                    }
                    if (Strings.InStr(1, itmSource.Text, "*") > 0)
                    {
                        rstPiece.Fields["Quoté"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Quoté"].Value = false;
                    }


                    rstPiece.Fields["DateRetour"].Value = itmSource.SubItems[I_COL_SOUM_DATE_REQUISE].Tag;

                    rstPiece.Fields["Commentaire"].Value = itmSource.SubItems[I_COL_SOUM_COMMENTAIRE].Text;
                    rstPiece.Update();
                    rstPiece.Close();
                    rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "' AND NuméroLigne >= " + X + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                    while (!rstPiece.EOF)
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(itmSource.SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_BRUN, false)))
                        {

                            if (rstPiece.Fields["MatérielInutile"].Value == true & rstPiece.Fields["Qté"].Value == itmSource.Text & rstPiece.Fields["NumItem"].Value == itmSource.SubItems[I_COL_SOUM_PIECE].Text & bSkip == false)
                            {
                                bSkip = true;
                            }
                            else
                            {
                                rstPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value + 1;
                                rstPiece.Update();
                            }
                        }

                        else if (rstPiece.Fields["MatérielInutile"].Value == false & rstPiece.Fields["Qté"].Value == itmSource.Text & rstPiece.Fields["NumItem"].Value == itmSource.SubItems[I_COL_SOUM_PIECE].Text & bSkip == false)
                        {
                            bSkip = true;
                        }
                        else
                        {
                            rstPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value + 1;
                            rstPiece.Update();
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = default;
                    CalculerTempsFabricationRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra);
                }
                rstProjet.Close();
                //chk: rstProjet may not be destroyed until it is garbage collected.
                rstProjet = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterInutileDansExtra", ex);
            }
        }
        private void AjouterAnnulationDansExtra(ListViewItem itmSource, string sExtra)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSection;
                short X;
                string sSection;
                var bSkip = default(bool);
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si le projet existe
                if (!rstProjet.EOF)
                {

                    rstPiece = new Recordset();

                    rstPiece.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "' AND IDSection = ", itmSource.Tag), " AND SousSection = '"), Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PIECE].Tag), "'", "''")), "' ORDER BY NuméroLigne"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstPiece.EOF)
                    {
                        rstPiece.MoveLast();
                        X = rstPiece.Fields["NuméroLigne"].Value + 1;
                    }
                    else
                    {
                        X = 1;
                    }
                    rstPiece.AddNew();
                    rstPiece.Fields["IDProjet"].Value = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra;
                    rstPiece.Fields["Type"].Value = "E";
                    if (itmSource.Checked == true)
                    {
                        rstPiece.Fields["Visible"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Visible"].Value = false;
                    }

                    rstPiece.Fields["IDSection"].Value = itmSource.Tag;

                    rstPiece.Fields["NumItem"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_PIECE].Text);
                    rstPiece.Fields["Qté"].Value = Strings.Replace(itmSource.Text, "*", string.Empty);
                    if (m_eLangage == EnumLangage.ANGLAIS)
                    {

                        rstPiece.Fields["DESC_EN"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                        rstPiece.Fields["DESC_FR"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));
                    }
                    else
                    {

                        rstPiece.Fields["DESC_FR"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_DESCR].Text);

                        rstPiece.Fields["DESC_EN"].Value = Strings.Trim(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_DESCR].Tag));
                    }

                    rstPiece.Fields["Manufact"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_MANUFACT].Text);

                    rstPiece.Fields["Prix_list"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text, EnumConvert.MODE_PAS_FORMAT, 4);

                    rstPiece.Fields["Escompte"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_ESCOMPTE].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Prix_net"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PRIX_NET].Text, EnumConvert.MODE_PAS_FORMAT, 4);


                    rstPiece.Fields["OrdreSection"].Value = itmSource.SubItems[I_COL_SOUM_MANUFACT].Tag;
                    rstPiece.Fields["NuméroLigne"].Value = X;
                    rstPiece.Fields["CommandeAnnulée"].Value = true;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_DISTRIB].Text))
                    {


                        rstPiece.Fields["IDFRS"].Value = itmSource.SubItems[I_COL_SOUM_DISTRIB].Tag;
                    }

                    rstPiece.Fields["Temps"].Value = Strings.Trim(itmSource.SubItems[I_COL_SOUM_TEMPS].Text);

                    rstPiece.Fields["Temps_Total"].Value = itmSource.SubItems[I_COL_SOUM_MONTAGE].Text;

                    rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_TOTAL].Text, EnumConvert.MODE_PAS_FORMAT);

                    rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed(itmSource.SubItems[I_COL_SOUM_PROFIT].Text, EnumConvert.MODE_PAS_FORMAT);


                    rstPiece.Fields["SousSection"].Value = itmSource.SubItems[I_COL_SOUM_PIECE].Tag;

                    if (!string.IsNullOrEmpty(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Text))
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag, string.Empty, false)))
                        {

                            rstPiece.Fields["PrixOrigine"].Value = Strings.Replace(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(itmSource.SubItems[I_COL_SOUM_PRIX_LIST].Tag), ".", ",")), 2).ToString(), ".", ",");
                        }
                        else
                        {
                            rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                        }
                    }
                    else
                    {
                        rstPiece.Fields["PrixOrigine"].Value.Text = "0";
                    }
                    if (Strings.InStr(1, itmSource.Text, "*") > 0)
                    {
                        rstPiece.Fields["Quoté"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Quoté"].Value = false;
                    }

                    rstPiece.Fields["Commentaire"].Value = itmSource.SubItems[I_COL_SOUM_COMMENTAIRE].Text;
                    rstPiece.Update();
                    rstPiece.Close();
                    rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra + "' AND NuméroLigne >= " + X + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                    while (!rstPiece.EOF)
                    {

                        if (rstPiece.Fields["CommandeAnnulée"].Value == true & rstPiece.Fields["Qté"].Value == itmSource.Text & rstPiece.Fields["NumItem"].Value == itmSource.SubItems[I_COL_SOUM_PIECE].Text & bSkip == false)
                        {
                            bSkip = true;
                        }
                        else
                        {
                            rstPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value + 1;
                            rstPiece.Update();
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = default;
                    CalculerTempsFabricationRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + sExtra);
                }
                rstProjet.Close();
                //chk: rstProjet may not be destroyed until it is garbage collected.
                rstProjet = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterAnnulationDansExtra", ex);
            }
        }
        private void RemplirListViewModifications()
        {
            try
            {
                // Rempli le lvwHistorique
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstCreation;
                string sChamps;
                string sTable;
                string sTableCreer;
                ListViewItem itmModif;
                rstProjSoum = new Recordset();
                rstEmploye = new Recordset();
                rstCreation = new Recordset();
                // Il faut le vider avant de le remplir
                lvwHistorique.Items.Clear();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sChamps = "IDProjet";
                    sTable = "Projet_Modif";
                    sTableCreer = "ProjetElec";
                }
                else
                {
                    sChamps = "IDSoumission";
                    sTable = "Soumission_Modif";
                    sTableCreer = "SoumissionElec";
                }
                rstCreation.Open("SELECT creer, creer_par FROM " + sTableCreer + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                itmModif = lvwHistorique.Items.Add(string.Empty);
                itmModif.Text = "Création";
                itmModif = lvwHistorique.Items.Add(string.Empty);
                rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstCreation.Fields["creer_par"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                itmModif.Text = rstEmploye.Fields["Employe"].Value;
                rstEmploye.Close();
                if (itmModif.SubItems.Count > I_COL_MODIF_DATE)
                {
                    itmModif.SubItems[I_COL_MODIF_DATE].Text = rstCreation.Fields["creer"].Value;
                }
                else
                {
                    itmModif.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstCreation.Fields["creer"].Value));
                }
                if (itmModif.SubItems.Count > I_COL_MODIF_HEURE)
                {
                    itmModif.SubItems[I_COL_MODIF_HEURE].Text = string.Empty;
                }
                else
                {
                    itmModif.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, string.Empty));
                }
                rstCreation.Close();
                rstCreation = default;
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModif = 'MODIFICATION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModif = lvwHistorique.Items.Add(string.Empty);
                    itmModif.Text = "Modifications";
                    while (!rstProjSoum.EOF)
                    {
                        itmModif = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModif.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModif.SubItems.Count > I_COL_MODIF_DATE)
                        {
                            itmModif.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value));
                        }
                        if (itmModif.SubItems.Count > I_COL_MODIF_HEURE)
                        {
                            itmModif.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value));
                        }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModif = 'RECEPTION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModif = lvwHistorique.Items.Add(string.Empty);
                    itmModif.Text = "Réception";
                    while (!rstProjSoum.EOF)
                    {
                        itmModif = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModif.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModif.SubItems.Count > I_COL_MODIF_DATE)
                        {
                            itmModif.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value));
                        }
                        // Heure
                        if (itmModif.SubItems.Count > I_COL_MODIF_HEURE)
                        {
                            itmModif.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value));
                        }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModif = 'RETOUR' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModif = lvwHistorique.Items.Add(string.Empty);
                    itmModif.Text = "Retour de marchandise";
                    while (!rstProjSoum.EOF)
                    {
                        itmModif = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModif.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModif.SubItems.Count > I_COL_MODIF_DATE)
                        {
                            itmModif.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value));
                        }
                        if (itmModif.SubItems.Count > I_COL_MODIF_HEURE)
                        {
                            itmModif.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value));
                        }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + txtNoProjSoum.Text + "' AND Type = 'E' AND TypeModif = 'FACTURATION' ORDER BY [Date], Heure", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    itmModif = lvwHistorique.Items.Add(string.Empty);
                    itmModif.Text = "Facturation";
                    while (!rstProjSoum.EOF)
                    {
                        itmModif = lvwHistorique.Items.Add(string.Empty);
                        rstEmploye.Open("SELECT Employe FROM Employés WHERE noEmploye = " + rstProjSoum.Fields["NoEmployé"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmModif.Text = rstEmploye.Fields["Employe"].Value;
                        rstEmploye.Close();
                        if (itmModif.SubItems.Count > I_COL_MODIF_DATE)
                        {
                            itmModif.SubItems[I_COL_MODIF_DATE].Text = rstProjSoum.Fields["Date"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_DATE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Date"].Value));
                        }
                        if (itmModif.SubItems.Count > I_COL_MODIF_HEURE)
                        {
                            itmModif.SubItems[I_COL_MODIF_HEURE].Text = rstProjSoum.Fields["Heure"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_HEURE, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Heure"].Value));
                        }
                        if (itmModif.SubItems.Count > I_COL_MODIF_MONTANT)
                        {
                            itmModif.SubItems[I_COL_MODIF_MONTANT].Text = rstProjSoum.Fields["Valeur"].Value;
                        }
                        else
                        {
                            itmModif.SubItems.Insert(I_COL_MODIF_MONTANT, new ListViewItem.ListViewSubItem(null, rstProjSoum.Fields["Valeur"].Value));
                        }
                        rstProjSoum.MoveNext();
                    }
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                rstEmploye = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "RemplirListViewModifications", ex);
            }
        }
        private void ModifierPrixCatalogue()
        {//Enregistrement du prix de la pièce
            try
            {
                ADODB.Recordset rstPrix;
                double dblPrixList;
                double dblEscompte;
                double dblPrixNet;
                if (!string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text)))
                {
                    dblPrixList = double.Parse(txtPrixList.Text);
                }
                else
                {
                    dblPrixList = 0d;
                }
                if (!string.IsNullOrEmpty(mskEscompte.Text))
                {
                    dblEscompte = double.Parse(mskEscompte.Text);
                }
                else
                {
                    dblEscompte = 0d;
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)))
                {
                    dblPrixNet = double.Parse(txtPrixNet.Text);
                }
                else
                {
                    dblPrixNet = double.Parse(txtPrixSpecial.Text);
                }
                rstPrix = new Recordset();
                if (txtPrixNet.Enabled == true)
                {

                    rstPrix.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())].SubItems[I_COL_SOUM_PIECE].Text, "'", "''") + "' AND IDFRS = " + GetFournisseurFromName(cmbfrs.Text) + " AND PRIX_NET <> ''", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); ;
                    if (rstPrix.EOF)
                    {
                        rstPrix.AddNew();
                        rstPrix.Fields["PIECE"].Value = lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())].SubItems[I_COL_SOUM_PIECE].Text;
                        rstPrix.Fields["IDFRS"].Value = GetFournisseurFromName(cmbfrs.Text);
                    }
                    rstPrix.Fields["PRIX_LIST"].Value = dblPrixList;
                    rstPrix.Fields["ESCOMPTE"].Value = dblEscompte;
                    rstPrix.Fields["PRIX_NET"].Value = dblPrixNet;
                    rstPrix.Fields["PRIX_SP"].Value = "";
                }
                else
                {
                    rstPrix.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())].SubItems[I_COL_SOUM_PIECE].Text, "'", "''") + "' AND IDFRS = " + GetFournisseurFromName(cmbfrs.Text) + " AND PRIX_SP <> ''", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPrix.EOF)
                    {
                        rstPrix.AddNew();
                        rstPrix.Fields["PIECE"].Value = lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())].SubItems[I_COL_SOUM_PIECE].Text;
                        rstPrix.Fields["IDFRS"].Value = GetFournisseurFromName(cmbfrs.Text);
                    }
                    rstPrix.Fields["PRIX_SP"].Value = dblPrixNet;
                    rstPrix.Fields["PRIX_LIST"].Value = "";
                    rstPrix.Fields["ESCOMPTE"].Value = "";
                    rstPrix.Fields["PRIX_NET"].Value = "";
                }
                if (optCAN.Checked == true)
                {
                    rstPrix.Fields["DeviseMonétaire"].Value = "CAN";
                }
                else if (optUSA.Checked == true)
                {
                    rstPrix.Fields["DeviseMonétaire"].Value = "USA";
                }
                else
                {
                    rstPrix.Fields["DeviseMonétaire"].Value = "SPA";
                }
                rstPrix.Fields["Type"].Value = "E";
                rstPrix.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                rstPrix.Fields["Date"].Value = ConvertDate(DateTime.Today);
                rstPrix.Update();
                rstPrix.Close();
                rstPrix = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "ModifierPrixCatalogue", ex);
            }
        }
        private void mskEscompte_GotFocus()
        {
            try
            {
                if (mskEscompte.Enabled == true)
                {
                    mskEscompte.Mask = "0,####";
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "mskEscompte_GotFocus", ex);
            }
        }
        private void mskEscompte_LostFocus()
        {
            try
            {
                mskEscompte.Mask = string.Empty;
                if (mskEscompte.Text == "0,____")
                {

                    mskEscompte.Text = string.Empty;
                }
                CalculerPrixNet();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "mskEscompte_LostFocus", ex);
            }
        }
        private object ExportdansExcel(ADODB.Recordset oRecordset)
        {
            short iCount;
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook oXLBook = oXLApp.Workbooks.Add();
            Worksheet oXLSheet = oXLBook.Worksheets[1];
            oXLSheet.Columns[1].ColumnWidth = 10;
            oXLSheet.Columns[2].ColumnWidth = 8;
            oXLSheet.Columns[3].ColumnWidth = 20;
            oXLSheet.Columns[4].ColumnWidth = 45;
            oXLSheet.Columns[5].ColumnWidth = 20;
            oXLSheet.Columns[6].ColumnWidth = 12;
            oXLSheet.Columns[7].ColumnWidth = 12;
            oXLSheet.Columns[8].ColumnWidth = 12;
            oXLSheet.Columns[9].ColumnWidth = 12;
            oXLSheet.Columns[10].ColumnWidth = 30;
            oXLSheet.Columns[11].ColumnWidth = 20;
            oXLSheet.Columns[12].ColumnWidth = 20;
            oXLSheet.Range["A1: N1"].Font.Bold = true;
            {
                ref var withBlock = ref oXLSheet;
                var loopTo = oRecordset.Fields.Count - 1;
                for (iCount = 0; iCount <= loopTo; iCount++)
                    withBlock.Cells[1, iCount + 1] = oRecordset.Fields[iCount].Name;
                withBlock.Range["A2"].CopyFromRecordset(oRecordset);
            }
            oXLApp.Visible = true;
            oXLSheet = default;
            oXLBook = default;
            oXLApp = default;
            return default;
        }
        private void AjouterTexte(short iIndex, string sTexte, string sNomSousSection)
        {
            try
            {
                string sSousSection;
                string sOrdre;
                string sIDSection;
                if (iIndex > lvwSoumission.Items.Count)
                {
                    if (string.IsNullOrEmpty(sNomSousSection))
                    {
                        sSousSection = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_PIECE].Tag);
                    }
                    else
                    {
                        sSousSection = sNomSousSection;
                    }
                    sOrdre = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_MANUFACT].Tag);
                    // chk: lvwSoumission.ListItems().Tag.
                    sIDSection = Conversions.ToString(lvwSoumission.Items[iIndex - 1].Tag);
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwSoumission.Items[iIndex].Tag, string.Empty, false)))
                {
                    if (string.IsNullOrEmpty(sNomSousSection))
                    {
                        sSousSection = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_PIECE].Tag);
                    }
                    else
                    {
                        sSousSection = sNomSousSection;
                    }
                    sOrdre = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_MANUFACT].Tag);
                    sIDSection = Conversions.ToString(lvwSoumission.Items[iIndex - 1].Tag);
                }
                else if (string.IsNullOrEmpty(lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Text))
                {
                    // Si c'est pas la première sous-section
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[iIndex - 1].Tag, string.Empty, false)))
                    {
                        if (string.IsNullOrEmpty(sNomSousSection))
                        {
                            sSousSection = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_PIECE].Tag);
                        }
                        else
                        {
                            sSousSection = sNomSousSection;
                        }
                        sOrdre = Conversions.ToString(lvwSoumission.Items[iIndex - 1].SubItems[I_COL_SOUM_MANUFACT].Tag);
                        // chk: lvwSoumission.ListItems().Tag.
                        sIDSection = Conversions.ToString(lvwSoumission.Items[iIndex].Tag);
                    }
                    else
                    {
                        MessageBox.Show("Vous ne pouvez pas mettre du texte entre une section et une sous-section!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(sNomSousSection))
                    {
                        sSousSection = Conversions.ToString(lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Tag);
                    }
                    else
                    {
                        sSousSection = sNomSousSection;
                    }
                    sOrdre = Conversions.ToString(lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_MANUFACT].Tag);
                    // chk: lvwSoumission.ListItems().Tag.
                    sIDSection = Conversions.ToString(lvwSoumission.Items[iIndex].Tag);
                }
                lvwSoumission.Items.Insert(iIndex, "");
                ValeurParDefaut(lvwSoumission.Items[iIndex]);
                if (m_eLangage == EnumLangage.ANGLAIS)
                {
                    if (lvwSoumission.Items[iIndex].SubItems.Count > I_COL_SOUM_PIECE)
                    {
                        lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Text = "Text";
                    }
                    else
                    {
                        lvwSoumission.Items[iIndex].SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Text"));
                    }
                }
                else if (lvwSoumission.Items[iIndex].SubItems.Count > I_COL_SOUM_PIECE)
                {
                    lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Text = "Texte";
                }
                else
                {
                    lvwSoumission.Items[iIndex].SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, "Texte"));
                }
                if (lvwSoumission.Items[iIndex].SubItems.Count > I_COL_SOUM_DESCR)
                {
                    lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_DESCR].Text = sTexte;
                }
                else
                {
                    lvwSoumission.Items[iIndex].SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, sTexte));
                }
                lvwSoumission.Items[iIndex].Tag = sIDSection;
                if (lvwSoumission.Items[iIndex].SubItems.Count > I_COL_SOUM_MANUFACT)
                {
                    lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_MANUFACT].Text = " ";
                }
                else
                {
                    lvwSoumission.Items[iIndex].SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, " "));
                }
                // Ordre de la section
                lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_MANUFACT].Tag = sOrdre;

                lvwSoumission.Items[iIndex].SubItems[I_COL_SOUM_PIECE].Tag = sSousSection;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElec", "AjouterTexte", ex);
            }
        }
        private void cmdAjouterSection_Click(object sender, EventArgs e)
        {
            SoumissionSectionElec sectionElec = new SoumissionSectionElec();
            sectionElec.Icon = Conteneur.ActiveForm.Icon;
            if (sectionElec.ShowDialog() == DialogResult.OK)
            {
                RemplirComboSections();
                UpdateOrdre();
            }
        }
        private void cmdAnglaisFrancais_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                if (cmdAnglaisFrancais.Text == "Anglais")
                {
                    m_eLangage = EnumLangage.ANGLAIS;
                    cmdAnglaisFrancais.Text = "Français";
                }
                else
                {
                    m_eLangage = EnumLangage.FRANCAIS;
                    cmdAnglaisFrancais.Text = "Anglais";
                }
                UpdateDescription();
                RemplirComboSections();
                UpdateOrdre();
                Cursor.Current = Cursors.Default;

        }
        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
                fraPieceTrouve.Visible = false;
                fraFournisseur.Visible = false;
                fraCommentaire.Visible = false;
                fraDateRequise.Visible = false;
                Cursor.Current = Cursors.WaitCursor;
                OuvrirProjSoum(false);
                AfficherControles(EnumMode.MODE_INACTIF);
                m_bEnregistrement = true;
                AfficherProjSoum(m_sAncienProjSoum);
                m_bEnregistrement = false;
                m_bModeAjout = false;
                Cursor.Current = Cursors.Default;

        }
        private void cmdAnnulerCommentaire_Click(object sender, EventArgs e)
        {
                fraCommentaire.Visible = false;
                return;
        }
        private void cmdAnnulerDateRequise_Click(object sender, EventArgs e)
        {
                fraDateRequise.Visible = false;
                m_bMonthViewHasFocus = false;
        }
        private void cmdAnnulerFRS_Click(object sender, EventArgs e) => fraFournisseur.Visible = false;
        private void cmdAnnulerPrix_Click(object sender, EventArgs e)
        {
                fraPrixPiece.Visible = false;
                m_bMauvaisPrix = false;
        }
        private void cmdAnnulerPieceTrouve_Click(object sender, EventArgs e) => fraPieceTrouve.Visible = false;
        private void cmdBonCommande_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum;
            var sUser = default(string);
            if (Droite(txtNoProjSoum.Text, 2) == "99")
            {
                MessageBox.Show("Vous ne pouvez pas commander de pièce à partir de ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rstProjSoum = new Recordset();
            rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (rstProjSoum.Fields["Ouvert"].Value == true & rstProjSoum.Fields["Verrouillé"].Value == false)
            {
                if (VerifierSiOuvert(ref sUser) == false)
                {
                    if (lvwSoumission.Items.Count > 0)
                    {
                        Form f = new ChoixBonCommande(txtNoProjSoum.Text, this, (int)m_eLangage);
                        f.Text = "Commande n~ " + txtNoProjSoum.Text;
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas de pièces à commander pour ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rstProjSoum.Fields["Ouvert"].Value == false)
            {
                MessageBox.Show("Ce projet est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ce projet est verrouillé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rstProjSoum.Close();
            rstProjSoum = default;
            if (g_bModificationBC == true)
            {
                cmbProjSoum_SelectedIndexChanged(cmbProjSoum, new EventArgs());
            }
        }
        private void cmdCatalogue_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CatalogueElec f = new CatalogueElec(cmbPieces.Text, string.Empty, string.Empty);
            Cursor.Current = Cursors.Default;

        }
        private System.Boolean VerifierSiOuvert(ref System.String sUser)
        {
            System.Boolean VerifierSiOuvertRet = default(System.Boolean);
            ADODB.Recordset rstProjSoum = new ADODB.Recordset();
            System.Boolean bModification;
            if ((m_eType == EnumType.TYPE_PROJET))
            {
                rstProjSoum.Open(("SELECT Modification, Par FROM GRB_ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text) + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstProjSoum.Open(("SELECT Modification, Par FROM GRB_SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text) + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Modification"].Value, true, false)))
            {
                sUser = Conversions.ToString(rstProjSoum.Fields["Par"].Value);
                bModification = true;
            }
            else
            {
                sUser = "";
                bModification = false;
            }
            rstProjSoum.Close();
            rstProjSoum = (ADODB.Recordset)null;
            VerifierSiOuvertRet = bModification;
            return VerifierSiOuvertRet;
        }
        private void cmdCopier_Click(object sender, EventArgs e)
        {
                ADODB.Recordset rstProjSoum;
                string sNoProjSoum;
                var sUser = default(string);
                bool bExiste;
                bool bVariables;
                bool bTauxHoraire;
                bool bPrixPieces;
                bool bNoValide;
                if (cmbProjSoum.Items.Count > 0)
                {
                    if (VerifierSiOuvert(ref sUser) == false)
                    {
                        sNoProjSoum = Interaction.InputBox("Quel est le numéro de la soumission?");
                        if (!string.IsNullOrEmpty(Strings.Trim(sNoProjSoum)))
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            bNoValide = true;
                            if (ValiderFormatNumeroProjSoum(sNoProjSoum) == false)
                            {
                                bNoValide = false;
                            }
                            if (bNoValide == true)
                            {
                                if (ValiderFormatElectrique(sNoProjSoum) == false)
                                {
                                    bNoValide = false;
                                }
                            }
                            if (bNoValide == true)
                            {
                                if (ValiderFormatSoumission(sNoProjSoum) == false)
                                {
                                    bNoValide = false;
                                }
                            }
                            if (bNoValide == false)
                            {
                                Cursor.Current = Cursors.Default;
                                return;
                            }
                            sNoProjSoum = Strings.UCase(sNoProjSoum);
                            rstProjSoum = new Recordset();
                            rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                bExiste = false;
                            }
                            else
                            {
                                bExiste = true;
                                MessageBox.Show("Ce numéro existe dans les soumissions électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            rstProjSoum.Close();
                            if (bExiste == false)
                            {
                                rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstProjSoum.EOF)
                                {
                                    bExiste = false;
                                }
                                else
                                {
                                    bExiste = true;
                                    MessageBox.Show("Ce numéro existe dans les projets électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                rstProjSoum.Close();
                            }
                            if (bExiste == false)
                            {
                                rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstProjSoum.EOF)
                                {
                                    bExiste = false;
                                }
                                else
                                {
                                    bExiste = true;
                                    MessageBox.Show("Ce numéro existe dans les soumissions mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                rstProjSoum.Close();
                            }
                            if (bExiste == false)
                            {
                                rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstProjSoum.EOF)
                                {
                                    bExiste = false;
                                }
                                else
                                {
                                    bExiste = true;
                                    MessageBox.Show("Ce numéro existe dans les projets mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                rstProjSoum.Close();
                            }
                            if (bExiste == false)
                            {
                                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (!rstProjSoum.EOF)
                                {
                                    if (rstProjSoum.Fields["Ouvert"].Value == false)
                                    {
                                        MessageBox.Show("Ce numéro est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        rstProjSoum.Close();
                                        rstProjSoum = default;
                                        Cursor.Current = Cursors.Default;
                                        return;
                                    }
                                }
                                rstProjSoum.Close();
                                rstProjSoum = default;
                                if (MessageBox.Show("Voulez-vous mettre à jour les variables systèmes?\n-  % Profit\n-  % Commission\n-  % Imprévu\n-  $ Pages manuel", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    bVariables = true;
                                }
                                else
                                {
                                    bVariables = false;
                                }
                                if (MessageBox.Show("Voulez-vous mettre à jour les taux horaires?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    bTauxHoraire = true;
                                }
                                else
                                {
                                    bTauxHoraire = false;
                                }
                                if (MessageBox.Show("Voulez-vous mettre à jour le prix des pièces?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    bPrixPieces = true;
                                }
                                else
                                {
                                    bPrixPieces = false;
                                }
                                m_bModeAjout = true;
                                m_bModeAffichage = false;
                                m_bTempsDejaOuvert = true;
                                if (bVariables == true)
                                {
                                    InitialiserVariables(sNoProjSoum);
                                }
                                if (bTauxHoraire == true)
                                {
                                    InitialiserNouveauxTaux();
                                }
                                AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                                if (bPrixPieces == true)
                                {
                                    UpdatePieces();
                                }
                                UpdateOrdre();
                                if (bVariables == true | bTauxHoraire == true | bPrixPieces == true)
                                {
                                    CalculerPrix();
                                }
                                BarrerChamps(false);
                                txtNoProjSoum.Text = sNoProjSoum;
                                txtNoSoumission.Text = string.Empty;
                            }
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    else if (m_eType == EnumType.TYPE_PROJET)
                    {
                        MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
        private void cmdCreerProjet_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum;
            string sNoProjet;
            var sUser = default(string);
            short X;
            bool bExiste;
            bool bNoValide;
            var sLiaison = default(string);
            if (cmbProjSoum.Items.Count > 0)
            {
                if (Droite(txtNoProjSoum.Text, 2) == "99")
                {
                    MessageBox.Show("Impossible de créer un projet à partir de cette soumission!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjSoum.Fields["Ouvert"].Value == false | rstProjSoum.Fields["Verrouillé"].Value == true)
                {
                    if (rstProjSoum.Fields["Ouvert"].Value == false)
                    {
                        MessageBox.Show("Cette soumission est fermée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est verrouillée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    return;
                }
                rstProjSoum.Close();
                if (VerifierSiOuvert(ref sUser) == false)
                {
                    sNoProjet = Interaction.InputBox("Quel est le numéro du projet?");
                    if (!string.IsNullOrEmpty(Strings.Trim(sNoProjet)))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        bNoValide = true;
                        if (ValiderFormatNumeroProjSoum(sNoProjet) == false)
                        {
                            bNoValide = false;
                        }
                        if (bNoValide == true)
                        {
                            if (ValiderFormatElectrique(sNoProjet) == false)
                            {
                                bNoValide = false;
                            }
                        }
                        if (bNoValide == true)
                        {
                            if (ValiderFormatJobAvecSoum(sNoProjet) == false)
                            {
                                bNoValide = false;
                            }
                        }
                        if (bNoValide == false)
                        {
                            rstProjSoum = default;
                            Cursor.Current = Cursors.Default;
                            return;
                        }
                        sNoProjet = Strings.UCase(sNoProjet);
                        rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            bExiste = false;
                        }
                        else
                        {
                            bExiste = true;
                            MessageBox.Show("Ce numéro existe dans les soumissions électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstProjSoum.Close();
                        if (bExiste == false)
                        {
                            rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                bExiste = false;
                            }
                            else
                            {
                                bExiste = true;
                                MessageBox.Show("Ce numéro existe dans les projets électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            rstProjSoum.Close();
                        }
                        if (bExiste == false)
                        {
                            rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                bExiste = false;
                            }
                            else
                            {
                                bExiste = true;
                                MessageBox.Show("Ce numéro existe dans les soumissions mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            rstProjSoum.Close();
                        }
                        if (bExiste == false)
                        {
                            rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                bExiste = false;
                            }
                            else
                            {
                                bExiste = true;
                                MessageBox.Show("Ce numéro existe dans les projets mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            rstProjSoum.Close();
                        }
                        if (bExiste == true)
                        {
                            rstProjSoum = default;
                            Cursor.Current = Cursors.Default;
                            return;
                        }
                        rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstProjSoum.EOF)
                        {
                            if (rstProjSoum.Fields["Ouvert"].Value == false)
                            {
                                MessageBox.Show("Ce numéro est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rstProjSoum.Close();
                                rstProjSoum = default;
                                return;
                            }
                        }
                        rstProjSoum.Close();
                        rstProjSoum = default;
                        if (double.Parse(Droite(sNoProjet, 2)) >= 60d & double.Parse(Droite(sNoProjet, 2)) <= 98d)
                        {
                            sLiaison = Interaction.InputBox("Quelle est l'extention du projet " + Gauche(sNoProjet, 6) + " auquel ce projet sera lié?");
                        }
                        Form f = new ChoixTransfertJob(txtNoProjSoum.Text, "E");
                        if (m_bTransfertJobCancel == false)
                        {
                            TransfererSoumDansProjet(sNoProjet, sLiaison);
                            if (m_bComboChoix == true)
                            {
                                cmbChoix.SelectedIndex = I_IDX_PROJET;
                                for (X = 0; X <= (short)(cmbProjSoum.Items.Count - 1); X++)
                                {
                                    if (cmbProjSoum.Items[X].ToString() == (sNoProjet ?? ""))
                                    {
                                        cmbProjSoum.SelectedIndex = X;
                                        break;
                                    }
                                }
                                if (!string.IsNullOrEmpty(sLiaison))
                                {
                                    for (X = 1; X <= (short)lvwSoumission.Items.Count; X++)
                                    {
                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwSoumission.Items[X].Tag, "", false)))
                                        {
                                            if (!string.IsNullOrEmpty(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text))
                                            {
                                                if (double.Parse(Droite(sNoProjet, 2)) >= 60d & double.Parse(Droite(sNoProjet, 2)) <= 79d)
                                                {
                                                    AjouterPiecesExtraChargeableDansJob(lvwSoumission.Items[X], sLiaison);
                                                }
                                                else if (double.Parse(Droite(sNoProjet, 2)) >= 80d & double.Parse(Droite(sNoProjet, 2)) <= 98d)
                                                {
                                                    AjouterPiecesExtraDansJob(lvwSoumission.Items[X], sLiaison);
                                                }
                                            }
                                        }
                                        CalculerTotalRecordset(sNoProjet);
                                    }
                                }
                                AjouterProjetAuCumulatif();
                            }
                            cmdCreerProjet.Visible = false;
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        rstProjSoum = default;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cette soumission est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cmdDate_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(Strings.Trim(txtDelais.Text)))
                {
                    mvwDate.SelectionStart = Conversions.ToDate(txtDelais.Text);
                }
                else
                {
                    mvwDate.SelectionStart = DateTime.Today;
                }
                mvwDate.Visible = true;
                mvwDate.Focus();
        }
        private void cmdDemande_Click(object sender, EventArgs e)
        {
                ADODB.Recordset rstProjSoum;
                var sUser = default(string);
                if (Droite(txtNoProjSoum.Text, 2) == "99")
                {
                    MessageBox.Show("Vous ne pouvez pas commander de pièce à partir de ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjSoum.Fields["Ouvert"].Value == true & rstProjSoum.Fields["Verrouillé"].Value == false)
                {
                    if (VerifierSiOuvert(ref sUser) == false)
                    {
                        Form f = new ChoixDemande(txtNoProjSoum.Text, EnumCatalogue.ELECTRIQUE, EnumModeDemande.MODE_PIECE);
                        f.Text = " EnumCatalogue.ELECTRIQUE   EnumModeDemande.MODE_PIECE";
                        f.Show();
                    }
                    else if (m_eType == EnumType.TYPE_PROJET)
                    {
                        MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rstProjSoum.Fields["Ouvert"].Value == false)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        MessageBox.Show("Ce projet est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est fermée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (m_eType == EnumType.TYPE_PROJET)
                {
                    MessageBox.Show("Ce projet est verrouillé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cette soumission est verrouillée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstProjSoum.Close();
                rstProjSoum = default;
        }
        private void cmdEffacerForfait_Click(object sender, EventArgs e)
        {
            txtForfait.Text = "";
            lblForfaitInitiale.Text = "";
        }
        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
                string sMessage;
                fraFournisseur.Visible = false;
                fraPieceTrouve.Visible = false;
                fraCommentaire.Visible = false;
                fraDateRequise.Visible = false;
                foreach (Control objControl in Controls)
                {
                    if (objControl is System.Windows.Forms.TextBox)
                    {
                        if (objControl.Visible == true)
                        {
                            if (objControl.Name != "txtNoSoumission" & objControl.Name != "txtCheminPhotos" & objControl.Name != "txtPrixReception" & objControl.Name != "txtDateFacturation" & objControl.Name != "txtPrixSoumission" & objControl.Name != "txtDelais" & objControl.Name != "txtForfait")
                            {
                                if (string.IsNullOrEmpty(Strings.Trim(objControl.Text)))
                                {
                                    MessageBox.Show("Vous devez remplir tous les champs!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    else if (objControl is ComboBox)
                    {
                        if (objControl.Visible == true)
                        {
                            if (objControl.Name != "cmbTri" & objControl.Name != "cmbSections" & objControl.Name != "cmbPieces")
                            {
                                MessageBox.Show("Vous devez remplir tous les champs!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                if (cmbTransport.SelectedIndex == -1)
                {
                    MessageBox.Show("Vous devez choisir le transport!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (double.Parse(m_sTempsTest) == 0d | double.Parse(m_sTempsDessin) == 0d)
                    {
                        if (MessageBox.Show("Les temps de dessin ou de test sont vides\nVoulez - vous l'enregistrer?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                if (BackupPieces1(txtNoProjSoum.Text) == false)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        sMessage = "Une erreur est survenue lors de la copie de sauvegarde du projet en cours!";
                    }
                    else
                    {
                        sMessage = "Une erreur est survenue lors de la copie de sauvegarde de la soumission en cours!";
                    }
                    sMessage = sMessage + "\n\nVoulez-vous continuer ?";
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(sMessage, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                    }
                }
                EnregistrerProjSoum(txtNoProjSoum.Text);
                OuvrirProjSoum(false);
                AfficherControles(EnumMode.MODE_INACTIF);
                m_bEnregistrement = true;
                m_bEnregistrement = false;
                Cursor.Current = Cursors.Default;
        }
        private void cmdExtra_Click(object sender, EventArgs e)
        {
                string sNumero;
                ADODB.Recordset rstProjSoum;
                bool bExiste;
                string sExtension;
                bool bNoValide;
                if (Droite(txtNoProjSoum.Text, 2) == "99")
                {
                    MessageBox.Show("Vous ne pouvez pas faire un extra à partir de ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sExtension = Droite(txtNoProjSoum.Text, 2);
                sNumero = Interaction.InputBox("Quel est l'extension à ajouter au numéro " + Gauche(txtNoProjSoum.Text, 6) + "?");
                if (!string.IsNullOrEmpty(sNumero))
                {
                    if (!IsNumeric(sNumero))
                    {
                        MessageBox.Show("Numéro non numérique!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sNumero = Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 3) + "-" + sNumero;
                    Cursor.Current = Cursors.WaitCursor;
                    bNoValide = true;
                    if (ValiderFormatNumeroProjSoum(sNumero) == false)
                    {
                        bNoValide = false;
                    }
                    if (bNoValide == true)
                    {
                        if (ValiderFormatElectrique(sNumero) == false)
                        {
                            bNoValide = false;
                        }
                    }
                    if (bNoValide == true)
                    {
                        if (ValiderFormatJobExtra(sNumero) == false)
                        {
                            bNoValide = false;
                        }
                    }
                    if (bNoValide == false)
                    {
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                    sNumero = Strings.UCase(sNumero);
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        bExiste = false;
                    }
                    else
                    {
                        bExiste = true;
                        MessageBox.Show("Ce numéro existe dans les soumissions électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                    if (bExiste == false)
                    {
                        rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            bExiste = false;
                        }
                        else
                        {
                            bExiste = true;
                            MessageBox.Show("Ce numéro existe dans les projets électriques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstProjSoum.Close();
                    }
                    if (bExiste == false)
                    {
                        rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            bExiste = false;
                        }
                        else
                        {
                            bExiste = true;
                            MessageBox.Show("Ce numéro existe dans les soumissions mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstProjSoum.Close();
                    }
                    if (bExiste == false)
                    {
                        rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            bExiste = false;
                        }
                        else
                        {
                            bExiste = true;
                            MessageBox.Show("Ce numéro existe dans les projets mécaniques!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstProjSoum.Close();
                    }
                    // Si le projet ou la soumission n'existe pas
                    if (bExiste == false)
                    {


                        rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstProjSoum.EOF)
                        {
                            if (rstProjSoum.Fields["Ouvert"].Value == false)
                            {
                                MessageBox.Show("Ce numéro est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rstProjSoum.Close();
                                rstProjSoum = default;
                                Cursor.Current = Cursors.Default;
                                return;
                            }
                        }
                        rstProjSoum.Close();
                        rstProjSoum = default;
                        m_sAncienProjSoum = txtNoProjSoum.Text;
                        InitialiserVariables(txtNoProjSoum.Text);
                        txtNoProjSoum.Text = sNumero;
                        if (double.Parse(Droite(sNumero, 2)) >= 60d & double.Parse(Droite(sNumero, 2)) <= 98d)
                        {
                            m_sLiaison = Interaction.InputBox("Quelle est l'extention au projet " + Gauche(txtNoProjSoum.Text, 6) + " auquel ce projet sera lié?", DefaultResponse: sExtension);
                        }
                        m_bModeAjout = true;
                        lvwSoumission.Items.Clear();
                        CalculerPrix();
                        BarrerChamps(false);
                        m_sTempsDessin = "0";
                        m_sTempsFabrication = "0";
                        m_sTempsAssemblage = "0";
                        m_sTempsProgInterface = "0";
                        m_sTempsProgAutomate = "0";
                        m_sTempsProgRobot = "0";
                        m_sTempsVision = "0";
                        m_sTempsTest = "0";
                        m_sTempsInstallation = "0";
                        m_sTempsMiseService = "0";
                        m_sTempsFormation = "0";
                        m_sTempsGestion = "0";
                        m_sTempsShipping = "0";
                        m_sNbrePersonne = "0";
                        m_sTempsHebergement = "0";
                        m_sTempsRepas = "0";
                        m_sTempsTransport = "0";
                        m_sTempsUniteMobile = "0";
                        m_sPrixEmballage = "0";
                        txtNbreManuel.Text = "0";
                        txtPrixManuel.Text = "0";
                        txtForfait.Text = "";
                        lblForfaitInitiale.Text = "";
                        txtPrixReception.Text = "0";
                        txtPrixSoumission.Text = "0";
                        txtPrixTotal.Text = "0";
                        txtProfit.Text = "0";
                        txtCommission.Text = "0";
                        txtTotalTemps.Text = "0";
                        txtTotalPieces.Text = "0";
                        txtImprevus.Text = "0";
                        txtNoSoumission.Text = string.Empty;
                        m_sSousSection = string.Empty;
                        txtProjet.Text = string.Empty;
                        m_bModeAjout = true;
                        m_bModeAffichage = false;
                        m_bExtra = true;
                        AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                    }
                }
                Cursor.Current = Cursors.Default;
        }
        private void cmdFermer_Click(object sender, EventArgs e)
        {
                m_bResize = false;
                Close();
        }
        private void cmdForfait_Click(object sender, EventArgs e)
        {
            System.String sMontant= Interaction.InputBox("Quel est le montant du forfait?");
            if (!string.IsNullOrEmpty(sMontant.Trim()))
            {
                sMontant = global::Microsoft.VisualBasic.Strings.Replace(sMontant, ".", ",");
                if (global::Microsoft.VisualBasic.Information.IsNumeric(sMontant))
                {
                    txtForfait.Text =Conversion_Renamed(sMontant, EnumConvert.MODE_ARGENT);
                    lblForfaitInitiale.Text = Conteneur.idInitiales.Text;
                }
                else
                {
                    Interaction.MsgBox("Montant non numérique!", MsgBoxStyle.OkOnly, "Erreur");
                }
            }
        }
        private void cmdHistorique_Click(object sender, EventArgs e)
        {
            if (((cmbProjSoum.Items.Count) > (0)))
            {
                RemplirListViewModifications();
                lvwHistorique.Visible = true;
                lvwHistorique.Focus();
            }
        }
        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            var sUser = default(string);
            if (!string.IsNullOrEmpty(txtNoProjSoum.Text))
            {
                if (VerifierSiOuvert(ref sUser) == false)
                {
                    ADODB.Recordset rstProjSoum = new Recordset();
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (MessageBox.Show("Voulez-vous faire imprimer le projet et tous les extras associés à ce projet?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            rstProjSoum.Open("SELECT * FROM ProjetElec WHERE Left(IDProjet, 6) = '" + Gauche(txtNoProjSoum.Text, 6) + "' ORDER BY IDProjet", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "' ORDER BY IDProjet", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                    else
                    {
                        rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "' ORDER BY IDSoumission", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    bTrigger = false;
                    // Modification PWE 2024-07-10
                    DialogResult dummie = MessageBox.Show("Désirez-vous afficher les dates de réception et de commande?", "Date de réception et de commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dummie == DialogResult.Yes)
                    {
                        bFlag = true;
                    }
                    else
                    {
                        bFlag = false;
                    }
                    while (!rstProjSoum.EOF)
                    {
                        if (m_eType == EnumType.TYPE_PROJET)
                        {
                            CalculerTotalRecordset(rstProjSoum.Fields["IDProjet"].Value);
                        }
                        ImprimerProjSoum(rstProjSoum);
                        if (dummie == DialogResult.No)
                        {
                            ImprimerListePieces(rstProjSoum);
                        }
                        rstProjSoum.MoveNext();
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                }
                else if (m_eType == EnumType.TYPE_PROJET)
                {
                    MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cette soumission est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cmdMaterielInutile_Click(object sender, EventArgs e) => MaterielInutile();
        private void cmdMauvaisPrix_Click(object sender, EventArgs e) => MauvaisPrix();

        private void cmdModifier_Click(object sender, EventArgs e)
        {
                ADODB.Recordset rstProjSoum;
                var sUser = default(string);
                m_collQteSupp = new List<String>();
                m_collDateSupp = new List<String>();
                m_collHeureSupp = new List<String>();
                m_collNoItemSupp = new List<String>();
                if (cmbProjSoum.SelectedIndex > -1) //modif soumission
                {
                    if (Droite(txtNoProjSoum.Text, 2) == "99")
                    {
                        if (m_eType == EnumType.TYPE_PROJET)
                        {
                            MessageBox.Show("Ce projet ne peut pas être modifié!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Cette soumission ne peut pas être modifiée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                    if (m_eType == EnumType.TYPE_SOUMISSION)
                    {
                        if (VerifierSiDejaProjet() == true)
                        {
                            MessageBox.Show("Vous ne pouvez pas modifier cette soumission, le projet a déjà été créé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum ='" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.Fields["Ouvert"].Value == false | rstProjSoum.Fields["Verrouillé"].Value == true)
                    {
                        if (rstProjSoum.Fields["Ouvert"].Value == false)
                        {
                            if (m_eType == EnumType.TYPE_PROJET)
                            {
                                MessageBox.Show("Ce projet est fermé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Cette soumission est fermée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (m_eType == EnumType.TYPE_PROJET)
                        {
                            MessageBox.Show("Ce projet est verrouillé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Cette soumission est verrouillée!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstProjSoum.Close();
                        rstProjSoum = default;
                        return;
                    }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    if (VerifierSiOuvert(ref sUser) == false)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        BarrerChamps(false);
                        m_sAncienProjSoum = txtNoProjSoum.Text;
                        m_bModeAjout = false;
                        m_bModeAffichage = false;
                        RemplirProjSoum();
                        AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                        UpdateOrdre();
                        CalculerPrix();
                        lvwSoumission.Refresh();
                        OuvrirProjSoum(true);
                        Cursor.Current = Cursors.Default;
                    }
                    else if (m_eType == EnumType.TYPE_PROJET)
                    {
                        MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
        private void cmdOKPieceTrouve_Click(object sender, EventArgs e)
        {
            m_bRecherchePiece = true;
            m_bPieceInutile = false;
            AfficherListeFournisseurs();
            if (lvwFournisseur.Items.Count == 1)
            {
                if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!\nVoulez-vous en ajouter?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Form f = new CatalogueElec(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_CATEGORIE].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text);
                    f.MdiParent = Conteneur.Mdi;
                    f.Show();
                    Cursor.Current = Cursors.Default;
                    AfficherListeFournisseurs();
                }
            }
        }
        private void cmdOKPrix_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstConfig;
            ListViewItem itmSoum;
            ListViewItem itmAvant;
            bool bPrixSpecial;
            short X;
            Color lColor;
            string sQuantite;
            string sPiece;
            string sTauxUSA;
            string sTauxSPA;
            rstConfig = new Recordset();
            rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
            sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
            sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
            rstConfig.Close();
            rstConfig = default;
            if (m_bMauvaisPrix == false)
            {
                if (cmbfrs.SelectedIndex == -1)
                {
                    MessageBox.Show("Vous devez choisir un fournisseur!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text)))
            {
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                {
                    MessageBox.Show("Vous devez remplir le prix listé!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)) & string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
            {
                MessageBox.Show("Vous devez choisir un prix!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)))
            {
                bPrixSpecial = false;
            }
            else
            {
                bPrixSpecial = true;
            }
            if (m_bMauvaisPrix == true)
            {
                sQuantite = Interaction.InputBox("Quelle est la quantité!");
                if (!string.IsNullOrEmpty(sQuantite))
                {
                    if (!IsNumeric(sQuantite))
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
                itmAvant = lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())];
                itmSoum = lvwSoumission.Items.Insert(int.Parse(fraPrixPiece.Tag.ToString()) + 1, "");
                lColor = itmAvant.SubItems[I_COL_SOUM_PIECE].ForeColor;
                itmSoum.Checked = itmAvant.Checked;
                itmSoum.Text = "-" + itmAvant.Text;
                itmSoum.Tag = itmAvant.Tag;
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE)
                {
                    itmSoum.SubItems[I_COL_SOUM_PIECE].Text = itmAvant.SubItems[I_COL_SOUM_PIECE].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PIECE].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_PIECE].Tag = itmAvant.SubItems[I_COL_SOUM_PIECE].Tag;

                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR)
                {
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Text = itmAvant.SubItems[I_COL_SOUM_DESCR].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DESCR].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = itmAvant.SubItems[I_COL_SOUM_DESCR].Tag;

                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT)
                {
                    itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Tag;

                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                {
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].Tag;
                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                {
                    itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].Text));
                }
                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                {
                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Tag = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Tag;

                if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB)
                {
                    itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Tag;
                // Temps
                if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS)
                {
                    itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = itmAvant.SubItems[I_COL_SOUM_TEMPS].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_TEMPS].Text));
                }
                if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString();
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString()));
                    }
                }
                else if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE)
                {
                    itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty));
                }

                if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL)
                {
                    itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = "-" + itmAvant.SubItems[I_COL_SOUM_TOTAL].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_SOUM_TOTAL].Text));
                }
                if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT)
                {
                    itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = "-" + itmAvant.SubItems[I_COL_SOUM_PROFIT].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_SOUM_PROFIT].Text));
                }
                itmSoum = lvwSoumission.Items.Insert(int.Parse(fraPrixPiece.Tag.ToString()) + 2, "");
                itmSoum.Checked = itmAvant.Checked;
                itmSoum.Text = sQuantite;
                itmSoum.Tag = itmAvant.Tag;
                if (itmSoum.SubItems.Count > I_COL_SOUM_PIECE)
                {
                    itmSoum.SubItems[I_COL_SOUM_PIECE].Text = itmAvant.SubItems[I_COL_SOUM_PIECE].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_PIECE].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = (lColor);
                itmSoum.SubItems[I_COL_SOUM_PIECE].Tag = itmAvant.SubItems[I_COL_SOUM_PIECE].Tag;
                if (itmSoum.SubItems.Count > I_COL_SOUM_DESCR)
                {
                    itmSoum.SubItems[I_COL_SOUM_DESCR].Text = itmAvant.SubItems[I_COL_SOUM_DESCR].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DESCR].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_DESCR].Tag = itmAvant.SubItems[I_COL_SOUM_DESCR].Tag;
                itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = (lColor);

                if (itmSoum.SubItems.Count > I_COL_SOUM_MANUFACT)
                {
                    itmSoum.SubItems[I_COL_SOUM_MANUFACT].Text = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_MANUFACT].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].Tag = itmAvant.SubItems[I_COL_SOUM_MANUFACT].Tag;
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = (lColor);
                if (bPrixSpecial == false)
                {
                    if (optUSA.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (optSpain.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                    {
                        itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(txtPrixList.Text, EnumConvert.MODE_ARGENT, 4);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixList.Text, EnumConvert.MODE_ARGENT, 4)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = txtPrixList.Text;
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = (lColor);

                    if (!string.IsNullOrEmpty(mskEscompte.Text))
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                        {
                            itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed(mskEscompte.Text, EnumConvert.MODE_POURCENT);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(mskEscompte.Text, EnumConvert.MODE_POURCENT)));
                        }
                    }
                    else if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = (lColor);

                    if (optUSA.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (optSpain.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                    {
                        itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(txtPrixNet.Text, EnumConvert.MODE_ARGENT, 4);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixNet.Text, EnumConvert.MODE_ARGENT, 4)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Tag = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Tag;
                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = (lColor);
                }
                else
                {
                    if (optUSA.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (optSpain.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                    {
                        itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = txtPrixSpecial.Text;
                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = (lColor);
                    if (optUSA.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (optSpain.Checked == true)
                    {
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                        }
                    }
                    else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                    {
                        itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4);
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4)));
                    }
                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Tag = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].Tag;
                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = (lColor);
                }

                if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB)
                {
                    itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DISTRIB].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = itmAvant.SubItems[I_COL_SOUM_DISTRIB].Tag;
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = (lColor);
                if (itmSoum.SubItems.Count > I_COL_SOUM_TEMPS)
                {
                    itmSoum.SubItems[I_COL_SOUM_TEMPS].Text = itmAvant.SubItems[I_COL_SOUM_TEMPS].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_TEMPS, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_TEMPS].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = (lColor);
                if (!string.IsNullOrEmpty(Strings.Trim(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text)))
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString();
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(itmSoum.SubItems[I_COL_SOUM_TEMPS].Text, ".", ",")) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty))).ToString()));
                    }
                }
                else if (itmSoum.SubItems.Count > I_COL_SOUM_MONTAGE)
                {
                    itmSoum.SubItems[I_COL_SOUM_MONTAGE].Text = string.Empty;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_MONTAGE, new ListViewItem.ListViewSubItem(null, string.Empty));
                }
                itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = (lColor);

                if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL)
                {
                    itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(), EnumConvert.MODE_ARGENT);
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(), EnumConvert.MODE_ARGENT)));
                }
                itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = (lColor);
                if (optUSA.Checked == true)
                {
                    itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "USA";
                }
                else if (optSpain.Checked == true)
                {
                    itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "SPA";
                }
                else
                {
                    itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "CAN";
                }
                // Pour le profit, c'est le prix total - (prix net * quantité)
                if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT)
                {
                    itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Conversion_Renamed(Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString(), EnumConvert.MODE_ARGENT);
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", string.Empty)), 2).ToString(), EnumConvert.MODE_ARGENT)));
                }
                itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = (lColor);
                if (itmSoum.SubItems.Count > I_COL_SOUM_COMMENTAIRE)
                {
                    itmSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text = itmAvant.SubItems[I_COL_SOUM_COMMENTAIRE].Text;
                }
                else
                {
                    itmSoum.SubItems.Insert(I_COL_SOUM_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_COMMENTAIRE].Text));
                }
                itmSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = (lColor);
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DATE_COMMANDE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].Text = itmAvant.SubItems[I_COL_SOUM_DATE_COMMANDE].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DATE_COMMANDE].Text));
                    }
                    itmSoum.SubItems[I_COL_SOUM_DATE_COMMANDE].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_DATE_REQUISE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_DATE_REQUISE].Text = itmAvant.SubItems[I_COL_SOUM_DATE_REQUISE].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_DATE_REQUISE].Text));
                    }
                    itmSoum.SubItems[I_COL_SOUM_DATE_REQUISE].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_NOM_COMMANDE)
                    {
                        itmSoum.SubItems[I_COL_SOUM_NOM_COMMANDE].Text = itmAvant.SubItems[I_COL_SOUM_NOM_COMMANDE].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_NOM_COMMANDE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_NOM_COMMANDE].Text));
                    }
                    itmSoum.SubItems[I_COL_SOUM_NOM_COMMANDE].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_NO_SEQUENTIEL)
                    {
                        itmSoum.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text = itmAvant.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_NO_SEQUENTIEL, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text));
                    }
                    itmSoum.SubItems[I_COL_SOUM_NO_SEQUENTIEL].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_ID)
                    {
                        itmSoum.SubItems[I_COL_SOUM_ID].Text = itmAvant.SubItems[I_COL_SOUM_ID].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_ID, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_ID].Text));
                    }
                    itmSoum.SubItems[I_COL_SOUM_ID].ForeColor = (lColor);
                    if (itmSoum.SubItems.Count > I_COL_SOUM_FACTURATION)
                    {
                        itmSoum.SubItems[I_COL_SOUM_FACTURATION].Text = itmAvant.SubItems[I_COL_SOUM_FACTURATION].Text;
                    }
                    else
                    {
                        itmSoum.SubItems.Insert(I_COL_SOUM_FACTURATION, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_SOUM_FACTURATION].Text));
                    }
                    if (!string.IsNullOrEmpty(itmSoum.SubItems[I_COL_SOUM_FACTURATION].Text))
                    {
                        itmSoum.SubItems[I_COL_SOUM_FACTURATION].Tag = itmAvant.SubItems[I_COL_SOUM_FACTURATION].Text;
                    }
                    itmSoum.SubItems[I_COL_SOUM_FACTURATION].ForeColor = (lColor);
                }
                if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_COMMENTAIRE].Text))
                {
                    itmSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = itmAvant.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor;
                    itmAvant.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor = Color.Black;
                }
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_DATE_COMMANDE].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_DATE_COMMANDE].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_DATE_REQUISE].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_DATE_REQUISE].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_NOM_COMMANDE].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_NOM_COMMANDE].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_NO_SEQUENTIEL].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_NO_SEQUENTIEL].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_FACTURATION].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_FACTURATION].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_ID].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_ID].ForeColor = Color.Black;
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_SOUM_PROVENANCE].Text))
                    {
                        itmAvant.SubItems[I_COL_SOUM_PROVENANCE].ForeColor = Color.Black;
                    }
                }
                itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor = itmAvant.SubItems[I_COL_SOUM_DESCR].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor = itmAvant.SubItems[I_COL_SOUM_DISTRIB].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor = itmAvant.SubItems[I_COL_SOUM_MANUFACT].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor = itmAvant.SubItems[I_COL_SOUM_MONTAGE].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor = itmAvant.SubItems[I_COL_SOUM_PIECE].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = itmAvant.SubItems[I_COL_SOUM_PRIX_NET].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor = itmAvant.SubItems[I_COL_SOUM_PROFIT].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor = itmAvant.SubItems[I_COL_SOUM_TEMPS].ForeColor;
                itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor = itmAvant.SubItems[I_COL_SOUM_TOTAL].ForeColor;
                itmAvant.SubItems[I_COL_SOUM_DESCR].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_DISTRIB].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_MANUFACT].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_MONTAGE].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_PIECE].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_PRIX_NET].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_PROFIT].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_TEMPS].ForeColor = Color.Black;
                itmAvant.SubItems[I_COL_SOUM_TOTAL].ForeColor = Color.Black;
                CalculerTempsFabrication();
                if (lvwSoumission.Items.Count > 0)
                {
                    Deselect();
                    lvwSoumission.Items[1].Selected = true;
                }
                m_bMauvaisPrix = false;
                cmbfrs.Enabled = false;
                lvwSoumission.Refresh();
            }
            else
            {
                sPiece = lvwSoumission.Items[int.Parse(fraPrixPiece.Tag.ToString())].SubItems[I_COL_SOUM_PIECE].Text;
                for (X = 0; X <lvwSoumission.Items.Count; X++)
                {
                    if (Conversions.ToBoolean(Operators.AndObject((lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].Text ?? "") == (sPiece ?? ""), Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(lvwSoumission.Items[X].SubItems[I_COL_SOUM_PIECE].ForeColor), COLOR_MAGENTA, false))))
                    {
                        itmSoum = lvwSoumission.Items[X];
                        itmSoum.SubItems[I_COL_SOUM_PIECE].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_DESCR].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_DISTRIB].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_MANUFACT].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_MONTAGE].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_PRIX_NET].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_PROFIT].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_TEMPS].ForeColor =COLOR_NOIR;
                        itmSoum.SubItems[I_COL_SOUM_TOTAL].ForeColor =COLOR_NOIR;
                        if (!string.IsNullOrEmpty(itmSoum.SubItems[I_COL_SOUM_COMMENTAIRE].Text))
                        {
                            itmSoum.SubItems[I_COL_SOUM_COMMENTAIRE].ForeColor =COLOR_NOIR;
                        }
                        lvwSoumission.Refresh();
                        if (bPrixSpecial == false)
                        {

                            if (optUSA.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (optSpain.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                            {
                                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(txtPrixList.Text, EnumConvert.MODE_ARGENT, 4);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixList.Text, EnumConvert.MODE_ARGENT, 4)));
                            }
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = txtPrixList.Text;

                            if (!string.IsNullOrEmpty(mskEscompte.Text))
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed(mskEscompte.Text, EnumConvert.MODE_POURCENT);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(mskEscompte.Text, EnumConvert.MODE_POURCENT)));
                                }
                            }
                            else if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                            {
                                itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                            }

                            if (optUSA.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (optSpain.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                            {
                                itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(txtPrixNet.Text, EnumConvert.MODE_ARGENT, 4);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixNet.Text, EnumConvert.MODE_ARGENT, 4)));
                            }
                        }
                        else
                        {
                            if (optUSA.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (optSpain.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_LIST)
                            {
                                itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Text = Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4)));
                            }
                            itmSoum.SubItems[I_COL_SOUM_PRIX_LIST].Tag = txtPrixSpecial.Text;
                            if (itmSoum.SubItems.Count > I_COL_SOUM_ESCOMPTE)
                            {
                                itmSoum.SubItems[I_COL_SOUM_ESCOMPTE].Text = Conversion_Renamed("0", EnumConvert.MODE_POURCENT);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed("0", EnumConvert.MODE_POURCENT)));
                            }
                            if (optUSA.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (optSpain.Checked == true)
                            {
                                if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                                {
                                    itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                                }
                                else
                                {
                                    itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                                }
                            }
                            else if (itmSoum.SubItems.Count > I_COL_SOUM_PRIX_NET)
                            {
                                itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text = Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4);
                            }
                            else
                            {
                                itmSoum.SubItems.Insert(I_COL_SOUM_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(txtPrixSpecial.Text, EnumConvert.MODE_ARGENT, 4)));
                            }
                        }

                        if (itmSoum.SubItems.Count > I_COL_SOUM_DISTRIB)
                        {
                            itmSoum.SubItems[I_COL_SOUM_DISTRIB].Text = cmbfrs.Text;
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, cmbfrs.Text));
                        }
                        itmSoum.SubItems[I_COL_SOUM_DISTRIB].Tag = cmbfrs.SelectedIndex;

                        if (itmSoum.SubItems.Count > I_COL_SOUM_TOTAL)
                        {
                            itmSoum.SubItems[I_COL_SOUM_TOTAL].Text = Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", "")) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(), EnumConvert.MODE_ARGENT);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_TOTAL, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(itmSoum.Text, "*", "")) * double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * Conversions.ToSingle(m_sProfit), 2).ToString(), EnumConvert.MODE_ARGENT)));
                        }
                        if (optUSA.Checked == true)
                        {
                            itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "USA";
                        }
                        else if (optSpain.Checked == true)
                        {
                            itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "SPA";
                        }
                        else
                        {
                            itmSoum.SubItems[I_COL_SOUM_TOTAL].Tag = "CAN";
                        }
                        // Pour le profit, c'est le prix total - (prix net * quantité)
                        if (itmSoum.SubItems.Count > I_COL_SOUM_PROFIT)
                        {
                            itmSoum.SubItems[I_COL_SOUM_PROFIT].Text = Conversion_Renamed(Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", "")), 2).ToString(), EnumConvert.MODE_ARGENT);
                        }
                        else
                        {
                            itmSoum.SubItems.Insert(I_COL_SOUM_PROFIT, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(itmSoum.SubItems[I_COL_SOUM_TOTAL].Text) - double.Parse(itmSoum.SubItems[I_COL_SOUM_PRIX_NET].Text) * double.Parse(Strings.Replace(itmSoum.Text, "*", "")), 2).ToString(), EnumConvert.MODE_ARGENT)));
                        }
                    }
                }
            }
            ModifierPrixCatalogue();
            fraPrixPiece.Visible = false;
            CalculerPrix();
        }

        private void cmdPhotos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCheminPhotos.Text))
            {
                PhotoProjSoum f = new PhotoProjSoum(txtCheminPhotos.Text);
                f.Text = " Photos pour le projet " + txtNoProjSoum.Text;
                f.Show();
            }
        }

        private void cmdRafraichir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m_sTri))
            {
                m_sTri = string.Empty;
                RemplirListViewPieces();
            }
        }
        private void cmdRapportFACT_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum;
            var sUser = default(string);
            string sNoFacture;
            if (lvwSoumission.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtNoProjSoum.Text))
                {
                    if (VerifierSiOuvert(ref sUser) == false)
                    {
                        sNoFacture = lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_FACTURATION].Text;
                        if (Gauche(sNoFacture, 2) == "F-" | sNoFacture == "NC")
                        {
                            rstProjSoum = new Recordset();
                            rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "' ORDER BY IDProjet", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            /// Module de GAÉTAN GINGRAS 07 FÉVRIER 2010
                            if (MessageBox.Show("Désirez-vous afficher les dates de réception et de commande?", "Date de réception et de commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bFlag = true;
                            }
                            else
                            {
                                bFlag = false;
                            }
                            ImprimerProjSoumFacturation(rstProjSoum, sNoFacture);
                            ImprimerListePiecesFacturation(rstProjSoum, sNoFacture);
                            rstProjSoum.Close();
                            rstProjSoum = default;
                        }
                        else
                        {
                            MessageBox.Show("La ligne sélectionnée ne contient aucune facture!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce projet est en modification par " + sUser + "!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ce projet ne contient aucune pièce à imprimer!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmdReception_Click(object sender, EventArgs e)
        {
            if (Droite(txtNoProjSoum.Text, 2) == "99"){MessageBox.Show("Vous ne pouvez pas faire de réception pour ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);return;}
            if (bOuvert == true){Close();}
            ReceptionElec f = new ReceptionElec(IdLoginEmploye, txtNoProjSoum.Text);
            f.MdiParent = Conteneur.Mdi;
            f.Show();
            RemplirListViewProjSoum(txtNoProjSoum.Text);
        }
        private void cmdRechercherClient_Click(object sender, EventArgs e)
        {
            System.String sRecherche= Interaction.InputBox("Entrez le texte à rechercher.");
            if (string.IsNullOrEmpty(sRecherche)){RemplirComboClients(sRecherche);}
        }
        private void cmdReset_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstProjSoum;
            if (MessageBox.Show("Êtes-vous certains de ne pas être en modification sur un autre ordinateur?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstProjSoum.Fields["Modification"].Value = false;
                rstProjSoum.Fields["Par"].Value = "";
                rstProjSoum.Update();
                rstProjSoum.Close();
                rstProjSoum = default;
                cmdReset.Visible = false;
            }
        }
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            if (Droite(txtNoProjSoum.Text, 2) == "99")
            {
                MessageBox.Show("Vous ne pouvez pas faire de retour dans ce projet!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            RetourMarchandise f = new RetourMarchandise(txtNoProjSoum.Text, (int)EnumTypeRetour.PROJET, IdLoginEmploye);
            f.Text = "Retour marchandise pour le projet " + txtNoProjSoum.Text;
            f.Show();
            cmbProjSoum_SelectedIndexChanged(cmbProjSoum, new EventArgs());
            Cursor.Current = Cursors.Default;
        }
        private void cmdSortieMagasin_Click(object sender, EventArgs e)=>SortieMagasin();
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult iReponse;
            ADODB.Recordset rstProjSoum;
            ADODB.Recordset rstProjet;
            string sSoumission;
            var sUser = default(string);
            int iExtension;
            if (cmbProjSoum.Items.Count > 0)
            {
                if (Droite(txtNoProjSoum.Text, 2) == "99")
                {
                    if (m_eType == EnumType.TYPE_PROJET) { MessageBox.Show("Vous ne pouvez pas supprimer ce projet!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); } else { MessageBox.Show("Vous ne pouvez pas supprimer cette soumission!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    return;
                }
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstProjSoum.Fields["Ouvert"].Value == false | rstProjSoum.Fields["Verrouillé"].Value == true)
                {
                    if (rstProjSoum.Fields["Ouvert"].Value == false)
                    {
                        if (m_eType == EnumType.TYPE_PROJET) { MessageBox.Show("Ce projet est fermé!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); } else { MessageBox.Show("Cette soumission est fermée!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    }
                    else
                    if (m_eType == EnumType.TYPE_PROJET) { MessageBox.Show("Ce projet est verrouillé!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); } else { MessageBox.Show("Cette soumission est verrouillée!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    rstProjSoum.Close();
                    rstProjSoum = default;
                    return;
                }
                rstProjSoum.Close();
                rstProjSoum = default;
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (VerintierSiDejaProjet() == true) { MessageBox.Show("Vous ne pouvez pas supprimer cette soumission, le projet a déjà été créé!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
                }
                if (VerintierSiOuvert(ref sUser) == false)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        iReponse = MessageBox.Show("Voulez-vous vraiment EFFACER LE PROJET " + txtNoProjSoum.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (iReponse == DialogResult.Yes)
                        {
                            ValiderSuppression f = new ValiderSuppression(true, txtNoProjSoum.Text,this);
                            f.Show();
                            if (m_bValide == true) { iReponse = DialogResult.Yes; } else { iReponse = DialogResult.No; }
                        }
                    }
                    else
                    {
                        iReponse = MessageBox.Show("Voulez-vous vraiment EFFACER LA SOUMISSION " + txtNoProjSoum.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (iReponse == DialogResult.Yes)
                        {
                            ValiderSuppression f = new ValiderSuppression(false, txtNoProjSoum.Text, this);
                            if (m_bValide == true) { iReponse = DialogResult.Yes; } else { iReponse = DialogResult.No; }
                        }
                    }
                    if (iReponse == DialogResult.Yes)
                    {
                        if (m_eType == EnumType.TYPE_PROJET)
                        {
                            rstProjet = new Recordset(); rstProjet.Open("SELECT IDSoumission FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                            if (!(rstProjet.Fields["IDSoumission"].Value is DBNull))
                            {
                                sSoumission = rstProjet.Fields["IDSoumission"].Value;
                            }
                            else
                            {
                                sSoumission = string.Empty;
                            }
                            rstProjet.Close();
                            rstProjet = default;
                            UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjSoum.Text + "' AND Type = 'E'");
                            if (IsNumeric(Droite(txtNoProjSoum.Text, 2)))
                            {
                                iExtension = int.Parse(Droite(txtNoProjSoum.Text, 2));
                            }
                            else { iExtension = 0; }
                            if (iExtension >= 60 & iExtension <= 79 | iExtension >= 80 & iExtension <= 98) { rstProjSoum = new Recordset(); rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly); UpdateSQL("DELETE FROM Projet_Pieces WHERE IDProjet = '" + Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + rstProjSoum.Fields["LiaisonChargeable"].Value + "' AND Provenance = '" + iExtension + "'"); CalculerTotalRecordset(Gauche(txtNoProjSoum.Text, Strings.Len(txtNoProjSoum.Text) - 2) + rstProjSoum.Fields["LiaisonChargeable"].Value); rstProjSoum.Close(); rstProjSoum = default; }
                            UpdateSQL("DELETE FROM Projet_Modint WHERE IDProjet = '" + txtNoProjSoum.Text + "' AND Type = 'E'");
                            UpdateSQL("DELETE FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'");
                            UpdateSQL("DELETE FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'"); rstProjSoum = new Recordset(); rstProjSoum.Open("SELECT Ouvert FROM ProjSoum WHERE IDProjSoum = '" + sSoumission + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!rstProjSoum.EOF) { rstProjSoum.Fields["Ouvert"].Value = true; rstProjSoum.Update(); }
                            rstProjSoum.Close(); rstProjSoum = default;
                        }
                        else
                        {
                            UpdateSQL("DELETE FROM Soumission_Pieces WHERE IDSoumission = '" + txtNoProjSoum.Text + "' AND Type = 'E'");
                            UpdateSQL("DELETE FROM Soumission_Modint WHERE IDSoumission = '" + txtNoProjSoum.Text + "' AND Type = 'E'");
                            UpdateSQL("DELETE FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'");
                            UpdateSQL("DELETE FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'");
                        }
                        if (m_eType == EnumType.TYPE_PROJET)
                        {
                            RecreerProjetCumulatif();
                        }
                        else
                        {
                            RecreerSoumissionCumulatif();
                        }
                        AfficherProjSoum(string.Empty);
                    }
                }
                else
                if (m_eType == EnumType.TYPE_PROJET) { MessageBox.Show("Ce projet est en modintication par " + sUser + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); } else { MessageBox.Show("Cette soumission est en modintication par " + sUser + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
        }
        private void cmdSupprimerFRS_Click(object sender, EventArgs e)
        {
            string sPiece;
            if (lvwFournisseur.FocusedItem.Text != "CHOISIR ULTÉRIEUREMENT")
            {
                if (m_bPieceInutile == true)
                {
                    sPiece = lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text;
                }
                else if (m_bRecherchePiece == true)
                {
                    sPiece = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text;
                }
                else
                {
                    sPiece = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text;
                }
                if (MessageBox.Show("Voulez-vous vraiment supprimer le fournisseur " + lvwFournisseur.FocusedItem.Text + " pour la pièce " + sPiece + "?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateSQL("DELETE FROM PiecesFRS WHERE NoEnreg = " + lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ENTRER_PAR].Tag);
                    RemplirListViewFournisseur();
                    fraFournisseur.Visible = true;
                    lvwFournisseur.Focus();
                }
            }
        }
        private void cmdTemps_Click(object sender, EventArgs e)
        {
            if (cmbProjSoum.Items.Count > 0)
            {
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    if (m_bModeAjout == true)
                    {
                        if (m_bExtra == true)
                        {
                            ProjSoumElecTemp f = new ProjSoumElecTemp(txtNoProjSoum.Text, (short)m_eType, (short)m_eMode, false);
                            f.Text = " ProjSoumElecTemps";
                            f.Show();
                        }
                        else
                        {
                            ProjSoumElecTemp f = new ProjSoumElecTemp(txtNoProjSoum.Text, (short)m_eType, (short)m_eMode, true);
                            f.Text = " ProjSoumElecTemps";
                            f.Show();
                        }
                    }
                    else
                    {
                        ProjSoumElecTemp f = new ProjSoumElecTemp(txtNoProjSoum.Text, (short)m_eType, (short)m_eMode, false);
                        f.Text = " ProjSoumElecTemps";
                        f.Show();
                    }
                }
                else
                {
                    ProjSoumElecTemp f = new ProjSoumElecTemp(txtNoProjSoum.Text, (short)m_eType, (short)m_eMode, false);
                    f.Text = " ProjSoumElecTemps";
                    f.Show();
                }
            }
            if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
            {
                CalculerPrix();
            }
            m_bTempsDejaOuvert = true;
        }
        private void cmdTexte_Click(object sender, EventArgs e)
        {
            short iIndex;
            string sSousSection;
            string sTexte;
            if (lvwSoumission.Items.Count > 0)
            {
                if (lvwSoumission.FocusedItem.Index == 1)
                {
                    sSousSection = Interaction.InputBox("Quelle est la sous-section?");
                    if (string.IsNullOrEmpty(Strings.Trim(sSousSection)))
                    {
                        sSousSection = S_PAS_SOUS_SECTION;
                    }
                    sTexte = Interaction.InputBox("Quel est le texte?");
                    if (!string.IsNullOrEmpty(Strings.Trim(sTexte)))
                    {
                        if (sTexte.Length > 0xFF)
                        {
                            MessageBox.Show("Le texte ne doit pas dépasser 255 caractères!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (TrouverIndexSection(sSousSection) == true) { iIndex = 0; } else { iIndex = 1; }
                            AjouterTexte(iIndex, sTexte, sSousSection);
                        }
                    }
                }
                else
                {
                    sTexte = Interaction.InputBox("Quel est le texte?");
                    if (!string.IsNullOrEmpty(Strings.Trim(sTexte)))
                    {
                        if (sTexte.Length > 0xFF)
                        {
                            MessageBox.Show("Le texte ne doit pas dépasser 255 caractères!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            iIndex = (short)lvwSoumission.FocusedItem.Index;
                            AjouterTexte(iIndex, sTexte, "");
                        }
                    }
                }
            }
        }

        private void cmdTri_Click(object sender, EventArgs e)
        {
            m_sTri = Interaction.InputBox("Quel est le texte à trier?");
            m_iCol = (short)cmbTri.SelectedIndex;
            if (!string.IsNullOrEmpty(m_sTri))
            {
                RemplirListViewPieces();
            }
        }
        private void lvwFournisseur_DoubleClick(object sender, EventArgs e)
        {
            if (m_bPieceInutile == true | m_bChangementFRS == true)
            {
                ChoisirFournisseurMateriel();
            }
            else
            {
                ChoisirFournisseur();
            }
        }

        private void lvwFournisseur_KeyDown(object sender, KeyEventArgs e)
        {
            short KeyCode = (short)e.KeyCode;
            short Shift = (short)((int)e.KeyData / 0x10000);
            var g_bModificationCatalogueElec = default(object);
            string sPiece;
            if (KeyCode == (int)Keys.Delete)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g_bModificationCatalogueElec, true, false)))
                {
                    if (lvwFournisseur.FocusedItem.Text != "CHOISIR ULTÉRIEUREMENT")
                    {
                        if (m_bPieceInutile == true)
                        {
                            sPiece = lvwSoumission.FocusedItem.SubItems[I_COL_SOUM_PIECE].Text;
                        }
                        else if (m_bRecherchePiece == true)
                        {
                            sPiece = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text;
                        }
                        else
                        {
                            sPiece = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text;
                        }
                        if (MessageBox.Show("Voulez-vous vraiment supprimer le fournisseur " + lvwFournisseur.FocusedItem.Text + " pour la pièce " + sPiece + "?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateSQL("DELETE FROM PiecesFRS WHERE NoEnreg = " + lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ENTRER_PAR].Tag);
                            RemplirListViewFournisseur();
                            fraFournisseur.Visible = true;
                            lvwFournisseur.Focus();
                        }
                    }
                }
            }
        }
        private void lvwHistorique_Leave(object sender, EventArgs e) => lvwHistorique.Visible = false;
        private void cmbOuvertFerme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoix.SelectedIndex != -1)
            {
                if (m_bChangementChoix == false){RemplirComboProjSoum();}
            }
        }
        //*****************************************************************************************************************************
    }

}
