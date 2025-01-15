using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.UI.WebControls;
using CheckBox = System.Windows.Forms.CheckBox;
using System.Threading;
using System.ComponentModel;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;
using Application = System.Windows.Forms.Application;
using ControleurServeur;
using Stripe;
using System.Security.Cryptography;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Net;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
#warning © Patrice Waechter-Ebling 2023-2024
#pragma warning disable CS1030 // Directive #warning
#pragma warning disable CS0169
#pragma warning disable CS1998
#pragma warning disable CS8603
#pragma warning disable CS8604
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8629 // Le type valeur Nullable peut avoir une valeur null.
#pragma warning disable ASP0014 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS0219
#pragma warning disable CS0252
#pragma warning disable CS0414
#pragma warning disable CS0649

namespace ControleurServeur
{
    public class AfficherErreurServeurWeb
    {
        public string RequestId;
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class IISHandler1 : IHttpHandler
    {
        /// Vous devrez configurer ce gestionnaire dans le fichier Web.CONFIG de votre 
        /// projet Web et l'inscrire auprès des services IIS (Internet Information Services) pour pouvoir l'utiliser. Pour plus d'informations
        /// consultez le lien suivant : https://go.microsoft.com/?linkid=8101007
        bool IHttpHandler.IsReusable => throw new NotImplementedException();

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct LOGFONT
    {
        public const int LF_FACESIZE = 32;
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = LF_FACESIZE)]
        public string lfFaceName;
    }
    class AfficherException
    {
        public string ID;
        public string Exception;
    }
    internal class AfficherFinFabrication
    {
        internal string no;
        internal string qte_com;
        internal string qte_livr;
        internal string qte_bo;
        internal string description;
        internal string manufacturier;
        internal string user;
    }
    public class AfficherListeCommande
    {
        public string Qte;
        public string IdPièc;
        public string Description;
        public string Manufacturier;
        public string PrixParUnite;
        public string Esc;
        public string Total;
        public double GrandTotal;
    }
    public class AfficherListeCommentaires
    {
        public int ID;
        public string commentaire;
        public int Clef;
        public bool Section;
        public bool SousSection;
        public string Relative;
        public dynamic Tag;
    }
    public class AfficherListeNomEmployes
    {
        public int NoEmploye;
        public string NonEmploye;
    }
    public class Outil
    {
        public Outil() { }
        public Outil(string noOutils, string nomOutils, string departement, string cout, string typeEtiquette,
            string dateAchat, string dateHorsFonction, string commentaire)
        {
            NoOutils = noOutils;
            NomOutils = nomOutils;
            Departement = departement;
            Cout = cout;
            TypeEtiquette = typeEtiquette;
            DateAchat = dateAchat;
            DateHorsFonction = dateHorsFonction;
            Commentaire = commentaire;
        }
        public string NoOutils;
        public string NomOutils;
        public string Departement;
        public string Cout;
        public string TypeEtiquette;
        public string DateAchat;
        public string DateHorsFonction;
        public string Commentaire;
    }
    public class AfficherListeOutils : Outil
    {
        public AfficherListeOutils() { }
        public string NoEmploye;
        public string DepartDateHeure;
        public string RetourDateHeure;
        public string Tag;
        public string NomEmploye;
    }
    public class AfficherListeOutilsModifies : AfficherListeOutils
    {
        public new string DateAchat;
        public new string DateHorsFonction;
    }
    public class AfficherListePieceSortie
    {
        public string PIECE;
        public string DESC_FR;
        public string DESC_EN;
        public string FABRICANT;
    }
    public class AfficherListeProjetsReception
    {
        public Color lColor { get; internal set; } = Color.AntiqueWhite;
        public string QUANTITE = string.Empty;
        public string PIECE = string.Empty;
        public string DESCRIPTION = string.Empty;
        public string MANUFACTURIER = string.Empty;
        public string DISTRIBUTEUR = string.Empty;
        public string DATE_RECEPTION = string.Empty;
        public string DATE_COMMANDE = string.Empty;
        public string DATE_REQUISE = string.Empty;
        public string ID = string.Empty;
        public override string ToString() => ID;
    }
    public class AfficherListePunch
    {
        public string PROJET; //ID = 0  ;
        public string DATE; //ID =1;
        public string DEBUT; //ID =2;
        public string FIN; //ID =3;
        public string CLIENT; //ID =4;
        public string TYPE; //ID =5;
        public string COMMENTAIRE; //ID =6;
        public dynamic TAG;
    }
    internal class AfficherListeReception
    {
        public dynamic DATE_RECEPTION;
        public dynamic QUANTITE;
        public dynamic PIECE;
    }
    public class AfficherListeSoumissionSPBase
    {
        public string QUANTITE;
        public string PIECE;
        public string DESCR;
        public string MANUFACT;
        public string DISTRIB;
        public string TEMPS;
        public string MONTAGE;
        public string COMMENTAIRE;
        public string ID;
        public string DATE_COMMANDE;
        public string DATE_REQUISE;
        public string NOM_COMMANDE;
        public string NO_SEQUENTIEL;
        public string PROVENANCE;
    }
    public class AfficherListeSoumissionSP : AfficherListeSoumissionSPBase { public AfficherListeSoumissionSP() { } }
    public class AfficherListeSoumission : AfficherListeSoumissionSP
    {
        public string PRIX_LIST; // ID=4;
        public string ESCOMPTE; // ID=5;
        public string PRIX_NET; // ID=6;
        public string TOTAL; // ID=10;
        public string PROFIT; // ID=11;
        public string FACTURATION; // ID=14;
    }
    public class Impression
    {
        public static bool m_bImpressionAnnuler = false;
        public static bool m_bImpressionVille = false;
        public static bool m_bImpressionCategorie = false;
        public static bool m_bImpressionPotentiel = false;
        public static bool m_bImpressionFacturer = false;
        public static bool m_bImpressionBeton = false;
        public static bool m_bImpressionPave = false;
        public static bool m_bImpressionPharmaceutique = false;
        public static bool m_bImpressionAgroAlimentaire = false;
        public static bool m_bImpressionMeuble = false;
        public static bool m_bImpressionMeunerie = false;
        public static bool m_bImpressionManufacturier = false;
        public static bool m_bImpressionConsultant = false;
        public static bool m_bImpressionAsphalte = false;
        public static bool m_bImpressionICPI = false;
        public static bool m_bImpressionProduitsChimiques = false;
        public static bool m_bImpressionAutre = false;
    }
    public class ImpressionBackOrder
    {
        public static string lblTitre = "Projets electriques : Pièces non reçues";
        public static string lblTitreProjetAchat = "";
        public static string lblDate = "";
        public static string lblProjetAchat = "";
        public static string lblTitreNoProjet = "# DB_Achat";
        public static string txtNoItem = "PIECE";
        public static string txtNoProjAchat = "NoAchat";
    }
    public class ImpressionBonLivraison
    {
        public string QteeCom;
        public string QteeLivree;
        public string QteeBO;
        public string Description;
        public string Manufacturier;
    }
    public class ImpressionBonLivraisonTagee : ImpressionBonLivraison
    {
        public dynamic Tag;
    }
    public class ImpressionCommandeRecue
    {
        public string Qte;
        public string NoItem;
        public string Description;
        public string Manufacturier;
        public string Localisation;
    }
    public class ImpressionFacturation
    {
        public string Date;
        public string Initiale;
        public string Comment;
        public string HeureDébut;
        public string HeureFin;
        public string Total;
        public string Facturé;
        public string NoFacture;
    }
    public class ImpressionFermeture : AfficherListePunch
    {
        public string KM;
    }
    public class ImpressionFeuilleHeure
    {
        public string Journee;
        public string Projet;
        public string Client;
        public string Type;
        public string Commentaire;
        public string DE;
        public string A;
        public string Total;
        public string KM;
    }
    public class Utilisateur
    {
        [Required, StringLength(10)] public string UserName;
        [Required] public string HashedPassword;
        [Required] public byte[] Salt;
        [Required] public int ID;
        public Utilisateur()
        {
            UserName = Program.IdLoginEmploye;
            Hash(Program.IdPassEmploye);
        }
        public Utilisateur(string userName, string password)
        {
            UserName = userName;
            Hash(password);
        }
        public void OpenAccessWebServer()
        {
            Program.UpdateSQL($"UPDATE [WebAccess].[DBO].[WEBUSER] SET[NomPC] = '{Environment.MachineName}', [IP] = '{Conteneur.ip}', [UserDomaine] = '{Environment.UserName}@{Environment.UserDomainName}',[LastConnect] = '{DateTime.Now.ToString()}' WHERE[noemploye] ={Program.IdNoEmploye}");
            string sql = $"INSERT INTO [WebAccess].[DBO].[WEBLOGIN]([NOEMPLOYE],[EMPLOYE],[NOMPC],[IP],[USERDOMAINE],[LASTCONNECT]) VALUES ({Program.IdNoEmploye},'{Program.IdNomEmploye}','{Environment.MachineName}','{Conteneur.ip}','{Environment.UserName}@{Environment.UserDomainName}','{DateTime.Now.ToString()}')";
            Program.UpdateSQL(sql);
        }
        public void Hash(string password)
        {
            byte[] bt = new byte[100];
            RandomNumberGenerator.Create().GetBytes(bt);
            Salt = bt;
            HashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: Salt, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 10000, numBytesRequested: 16));
        }
    }
    class ModuleMBD
    {
        internal Connection g_connData;
        /// Pour Access 2000, il faut utiliser Microsoft Jet 4.0 pour une appli x86 
        /// le jet 4 peut occasionner des erreur de flux en mode 32=>64bits
        ///  le ACE.Jet.12 est priviligié pour dx x64
        ///  anyway sous Windows12 il y a aura plus le choix 
        internal bool OuvrirConnectionMDB(string CheminBD)
        {
            if (g_connData is null)
            {
                g_connData.Open($"Provider=Microsoft.Jet.OLEDB.4.0;User ID = Admin;Data Source={CheminBD};Persist Security Info=False");
                return true;
            }
            else
            {
                MessageBox.Show($"La base de donnée est introuvable!\n{CheminBD}\n\nVérifiez votre connexion réseau!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }
        internal void FermerConnectionMDB()
        {
            if (!(g_connData is null))
            {
                g_connData.Close();
                g_connData = null;
            }
        }
    }
 public class DR_ApercuProjet
    {
        public static string lblNumero="0.00";
        public static string lblClient="0.00";
        public static string lblDescription="0.00";
        public static string lblDate="0.00";
        public static string lblForfaitMecSoum="0.00";
        public static string lblForfaitElecSoum="0.00";
        public static string lblTotalForfaitSoum="0.00";
        public static string lblForfaitElecProj="0.00";
        public static string lblForfaitMecProj="0.00";
        public static string lblTotalForfaitProj="0.00";
        public static string lblHeuresElecTotalSoum="0.00";
        public static string lblHeuresMecTotalSoum="0.00";
        public static string lblTotalHeuresSoum="0.00";
        public static string lblGrandTotalSoum="0.00";
        public static string lblTotalElecSoum="0.00";
        public static string lblTotalMecSoum="0.00";
        public static string lblTotalHeuresProj="0.00";
        public static string lblHeuresElecTotalProj="0.00";
        public static string lblHeuresMecTotalProj="0.00";
        public static string lblGrandTotalProj="0.00";
        public static string lblTotalElecProj="0.00";
        public static string lblTotalMecProj="0.00";
        public static string lblProfitSoum="0.00";
        public static string lblProfitProj="0.00";
        public static string lblProjetElec="0.00";
        public static string lblArgentElecDessinSoum="0.00";
        public static string lblHeuresElecDessinSoum="0.00";
        public static string lblArgentElecFabricationSoum="0.00";
        public static string lblHeuresElecFabricationSoum="0.00";
        public static string lblArgentElecAssemblageSoum="0.00";
        public static string lblHeuresElecAssemblageSoum="0.00";
        public static string lblArgentElecProgInterfaceSoum="0.00";
        public static string lblHeuresElecProgInterfaceSoum="0.00";
        public static string lblArgentElecProgAutomateSoum="0.00";
        public static string lblHeuresElecProgAutomateSoum="0.00";
        public static string lblArgentElecProgRobotSoum="0.00";
        public static string lblHeuresElecProgRobotSoum="0.00";
        public static string lblHeuresElecVisionSoum="0.00";
        public static string lblArgentElecVisionSoum="0.00";
        public static string lblHeuresElecTestSoum="0.00";
        public static string lblArgentElecTestSoum="0.00";
        public static string lblArgentElecInstallationSoum="0.00";
        public static string lblHeuresElecInstallationSoum="0.00";
        public static string lblHeuresElecMiseServiceSoum="0.00";
        public static string lblArgentElecMiseServiceSoum="0.00";
        public static string lblHeuresElecFormationSoum="0.00";
        public static string lblArgentElecFormationSoum="0.00";
        public static string lblHeuresElecGestionSoum="0.00";
        public static string lblArgentElecGestionSoum="0.00";
        public static string lblHeuresElecShippingSoum="0.00";
        public static string lblArgentElecShippingSoum="0.00";
        public static string lblPiecesElecSoum="0.00";
        public static string lblImprevuElecSoum="0.00";
        public static string lblAutresElecSoum="0.00";
        public static string lblArgentElecAssemblageProj="0.00";
        public static string lblHeuresElecDessinProj="0.00";
        public static string lblArgentElecDessinProj="0.00";
        public static string lblHeuresElecFabricationProj="0.00";
        public static string lblArgentElecFabricationProj="0.00";
        public static string lblHeuresElecAssemblageProj="0.00";
        public static string lblHeuresElecProgInterfaceProj="0.00";
        public static string lblArgentElecProgInterfaceProj="0.00";
        public static string lblArgentElecProgAutomateProj="0.00";
        public static string lblHeuresElecProgAutomateProj="0.00";
        public static string lblHeuresElecProgRobotProj="0.00";
        public static string lblArgentElecProgRobotProj="0.00";
        public static string lblHeuresElecVisionProj="0.00";
        public static string lblArgentElecVisionProj="0.00";
        public static string lblHeuresElecTestProj="0.00";
        public static string lblArgentElecTestProj="0.00";
        public static string lblArgentElecInstallationProj="0.00";
        public static string lblHeuresElecInstallationProj="0.00";
        public static string lblHeuresElecMiseServiceProj="0.00";
        public static string lblArgentElecMiseServiceProj="0.00";
        public static string lblHeuresElecFormationProj="0.00";
        public static string lblArgentElecFormationProj="0.00";
        public static string lblHeuresElecGestionProj="0.00";
        public static string lblArgentElecGestionProj="0.00";
        public static string lblHeuresElecShippingProj="0.00";
        public static string lblArgentElecShippingProj="0.00";
        public static string lblHeuresElecRechercheProj="0.00";
        public static string lblArgentElecRechercheProj="0.00";
        public static string lblImprevuElecProj="0.00";
        public static string lblPiecesElecProj="0.00";
        public static string lblAutresElecProj="0.00";
        public static string lblArgentElecTotalSoum="0.00";
        public static string lblArgentElecTotalProj="0.00";
        public static string lblHeuresMecDessinSoum="0.00";
        public static string lblArgentMecDessinSoum="0.00";
        public static string lblHeuresMecCoupeSoum="0.00";
        public static string lblArgentMecCoupeSoum="0.00";
        public static string lblHeuresMecMachinageSoum="0.00";
        public static string lblArgentMecMachinageSoum="0.00";
        public static string lblHeuresMecSoudureSoum="0.00";
        public static string lblArgentMecSoudureSoum="0.00";
        public static string lblHeuresMecAssemblageSoum="0.00";
        public static string lblArgentMecAssemblageSoum="0.00";
        public static string lblHeuresMecPeintureSoum="0.00";
        public static string lblArgentMecPeintureSoum="0.00";
        public static string lblHeuresMecTestSoum="0.00";
        public static string lblArgentMecTestSoum="0.00";
        public static string lblHeuresMecInstallationSoum="0.00";
        public static string lblArgentMecInstallationSoum="0.00";
        public static string lblHeuresMecFormationSoum="0.00";
        public static string lblArgentMecFormationSoum="0.00";
        public static string lblHeuresMecGestionSoum="0.00";
        public static string lblArgentMecGestionSoum="0.00";
        public static string lblHeuresMecShippingSoum="0.00";
        public static string lblArgentMecShippingSoum="0.00";
        public static string lblPiecesMecSoum="0.00";
        public static string lblImprevuMecSoum="0.00";
        public static string lblAutresMecSoum="0.00";
        public static string lblProjetMec="0.00";
        public static string lblHeuresMecDessinProj="0.00";
        public static string lblArgentMecDessinProj="0.00";
        public static string lblHeuresMecCoupeProj="0.00";
        public static string lblArgentMecCoupeProj="0.00";
        public static string lblArgentMecMachinageProj="0.00";
        public static string lblHeuresMecMachinageProj="0.00";
        public static string lblHeuresMecSoudureProj="0.00";
        public static string lblArgentMecSoudureProj="0.00";
        public static string lblHeuresMecAssemblageProj="0.00";
        public static string lblArgentMecAssemblageProj="0.00";
        public static string lblHeuresMecPeintureProj="0.00";
        public static string lblArgentMecPeintureProj="0.00";
        public static string lblHeuresMecTestProj="0.00";
        public static string lblArgentMecTestProj="0.00";
        public static string lblHeuresMecInstallationProj="0.00";
        public static string lblArgentMecInstallationProj="0.00";
        public static string lblHeuresMecFormationProj="0.00";
        public static string lblArgentMecFormationProj="0.00";
        public static string lblHeuresMecGestionProj="0.00";
        public static string lblArgentMecGestionProj="0.00";
        public static string lblArgentMecShippingProj="0.00";
        public static string lblHeuresMecShippingProj="0.00";
        public static string lblHeuresMecRechercheProj="0.00";
        public static string lblArgentMecRechercheProj="0.00";
        public static string lblPiecesMecProj="0.00";
        public static string lblImprevuMecProj="0.00";
        public static string lblAutresMecProj="0.00";
        public static string lblArgentMecTotalSoum="0.00";
        public static string lblArgentMecTotalProj="0.00";
        public static string lblTitreRapport="0.00";
        public static string lblTitreNoProjet="0.00";
        public static string lblTitreProj="0.00";
        public static string lblTitreClient="0.00";
        public static string lblTitreDescription="0.00";
        public static string lblTitreDate="0.00";
        public static string lblTitreSoum="0.00";
        public static string lblTitreHeuresSoum="0.00";
        public static string lblTitreArgentSoum="0.00";
        public static string lblTitreHeuresProj="0.00";
        public static string lblTitreArgentProj="0.00";
        public static string lblTitreRevenus="0.00";
        public static string lblTitreForfaitElec="0.00";
        public static string lblTitreForfaitMec="0.00";
        public static string lblTitreTotalForfait="0.00";
        public static string lblTitreDepenses="0.00";
        public static string lblTitreTempsElec="0.00";
        public static string lblTitreTempsElecDessin="0.00";
        public static string lblTitreTempsElecFabrication="0.00";
        public static string lblTitreTempsElecAssemblage="0.00";
        public static string lblTitreTempsElecProgInterface="0.00";
        public static string lblTitreTempsElecProgAutomate="0.00";
        public static string lblTitreTempsElecProgRobot="0.00";
        public static string lblTitreTempsElecVision="0.00";
        public static string lblTitreTempsElecTest="0.00";
        public static string lblTitreTempsElecInstallation="0.00";
        public static string lblTitreTempsElecMiseService="0.00";
        public static string lblTitreTempsElecFormation="0.00";
        public static string lblTitreTempsElecGestion="0.00";
        public static string lblTitreTempsElecShipping="0.00";
        public static string lblTitreTempsElecTotal="0.00";
        public static string lblHeuresElecTotalProj0="0.00";
        public static string lblTotalElecProj0="0.00";
        public static string lblTitrePiecesElec="0.00";
        public static string lblTitreImprevuElec="0.00";
        public static string lblTitreAutresElec="0.00";
        public static string lblTitreTotalElec="0.00";
        public static string lblTotalElecSoum0="0.00";
        public static string lblTotalHeuresProj0="0.00";
        public static string lblTitreTempsMec="0.00";
        public static string lblTitreTempsMecDessin="0.00";
        public static string lblTitreTempsMecCoupe="0.00";
        public static string lblTitreTempsMecMachinage="0.00";
        public static string lblTitreTempsMecSoudure="0.00";
        public static string lblTitreTempsMecAssemblage="0.00";
        public static string lblTitreTempsMecPeinture="0.00";
        public static string lblTitreTempsMecTest="0.00";
        public static string lblTitreTempsMecInstallation="0.00";
        public static string lblTitreTempsMecFormation="0.00";
        public static string lblTitreTempsMecGestion="0.00";
        public static string lblTitreTempsMecShipping="0.00";
        public static string Label2="0.00";
        public static string lblTitreTempsMecTotal="0.00";
        public static string lblTitrePiecesMec="0.00";
        public static string lblTitreImprevuMec="0.00";
        public static string lblTitreAutresMec="0.00";
        public static string lblTitreTotalMec="0.00";
        public static string lblTitreTotal="0.00";
        public static string lblTitreProfitTotal="0.00";
    }
    public class DR_BackOrder
    {
        internal static string blTitre;
        internal static string blTitreProjetAchat;
        internal static string blDate;
        internal static string blProjetAchat;
        internal static string blTitreNoProjet;
        internal static string xtNoProjAchat;
        internal static string xtNoItem;
        internal static string Impression;
        internal static string lblTitre;
        internal static string Label5;
        internal static string lblDate;
        internal static string lblTitreProjetAchat;
        internal static string lblProjetAchat;
        internal static string lblTitreNoProjet;
        internal static string lblTitreQuantite;
        internal static string lblTitreNoItem;
        internal static string lblTitreDescription;
        internal static string lblTitreFournisseur;
        internal static string Label2;
        internal static string Label3;
        internal static string txtNoProjAchat;
        internal static string Text1;
        internal static string txtNoItem;
        internal static string Text3;
        internal static string Text4;
        internal static string Text6;
        internal static string Text5;
        internal static string Qte;
        internal static string Description;
        internal static string Fournisseur;
        internal static string DateCommande;
        internal static string DateRequise;
        public static Recordset DataSource;
        public static bool Visible;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class RechercheInventaire
    {
        internal static string NoItem;
        internal static string Qte;
        internal static string Manufacturier;
        internal static string Description;
        internal static string Localisation;
        internal static string PrixListe;
        internal static string Escompte;
        internal static string PrixNet;
        internal static string QuantiteStock;
        internal static string Total;
        internal Program.EnumCatalogue eLECTRIQUE;
        internal RechercheInventaire(Program.EnumCatalogue eLECTRIQUE)
        {
            eLECTRIQUE = eLECTRIQUE;
        }
    }
    public class DR_Client
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string Label3;
        public static string Label7;
        public static string Label29;
        public static string TextBox1;
        public static string TextBox2;
        public static string Label1;
        public static string lblDate;
        public static string TextBox3;
        public static string Label33;
        public static string lblDateOuverture;
        public static string Label34;
        public static string lblDateDue;
        public static string Label35;
        public static string TextBox4;
        public static string lblClient;
        public static string lblContact;
        public static string Label38;
        public static string TextBox5;
        public static string lblProjet;
        public static string Label36;
        public static string lblTel;
        public static string Label37;
        public static string lblFax;
        public static string Label30;
        public static string Label31;
        public static string Label32;
        public static string Label8;
        public static string TextBox6;
        public static string TextBox7;
        public static string TextBox8;
        public static string Label9;
        public static string TextBox9;
        public static string TextBox10;
        public static string TextBox11;
        public static string Label10;
        public static string TextBox12;
        public static string TextBox13;
        public static string TextBox14;
        public static string Label11;
        public static string TextBox15;
        public static string TextBox16;
        public static string TextBox17;
        public static string Label12;
        public static string TextBox18;
        public static string TextBox19;
        public static string TextBox20;
        public static string Label13;
        public static string TextBox21;
        public static string TextBox22;
        public static string TextBox23;
        public static string Label14;
        public static string TextBox24;
        public static string TextBox25;
        public static string TextBox26;
        public static string Label15;
        public static string TextBox27;
        public static string TextBox28;
        public static string TextBox29;
        public static string Label16;
        public static string TextBox30;
        public static string TextBox31;
        public static string TextBox32;
        public static string Label17;
        public static string TextBox33;
        public static string TextBox34;
        public static string TextBox35;
        public static string Label18;
        public static string TextBox36;
        public static string TextBox37;
        public static string TextBox38;
        public static string Label19;
        public static string TextBox39;
        public static string TextBox40;
        public static string TextBox41;
        public static string Label20;
        public static string TextBox42;
        public static string TextBox43;
        public static string TextBox44;
        public static string Label21;
        public static string TextBox45;
        public static string TextBox46;
        public static string TextBox47;
        public static string Label22;
        public static string TextBox48;
        public static string TextBox49;
        public static string TextBox50;
        public static string lblUser;
        public static string lblNoSoum;
        public static string lblNoProj;
        public static string lblProjetNom;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_Commande
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string lblTitreCommande;
        public static string lblTitreFournisseur;
        public static string lblFournisseur;
        public static string lblTitreNoSoum;
        public static string lblNoSoum;
        public static string lblTitreBC;
        public static string lblNoBC;
        public static string lblTitreContact;
        public static string lblContact;
        public static string lblTitreTel;
        public static string lblTel;
        public static string lbltitredate;
        public static string lblDate;
        public static string lbltitredatereq;
        public static string lblDateRequise;
        public static string lblTitreFax;
        public static string lblTitreTransport;
        public static string lblFax;
        public static string lblTransport;
        public static string lbltitrecompar;
        public static string lblTitrePage;
        public static string lblCommandePar;
        public static string lblPage;
        public static string lblPiedPage;
        public static string lblCSA;
        public static string lbltitrecommentaire;
        public static string lblCommentaire;
        public static string lbltitretotalfin;
        public static string lblTotalFin;
        public static string lblCopieCredit;
        public static string lblAdresse;
        public static string lbltitredescription;
        public static string lbltitreescompte;
        public static string lbltitremanufact;
        public static string lbltitrePiece;
        public static string lbltitreprix;
        public static string lbltitreqte;
        public static string lbltitretotal;
        public static string lbltypeprix;
        public static bool Orientation = ControleurServeur.Program.isLandscape;
        public static string Title;
    }
    public class DR_CommandeParcel
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string Label3;
        public static string Label4;
        public static string Label14;
        public static string lblgrb;
        public static string lblcompagnie;
        public static string lbladresse;
        public static string lblpays;
        public static string Label5;
        public static string lblreminder;
        public static string Label7;
        public static string Label8;
        public static string Label11;
        public static string Label9;
        public static string Label12;
        public static string Label10;
        public static string lblassist;
        public static string lblUser;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_CommandeRecue
    {
        public static dynamic lblfournisseur;
        public static dynamic lblprojet;
        public static dynamic lbldatereq;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static Recordset DataSource;
    }
    public class DR_Conception
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string Controls3;
        public static string Controls7;
        public static string Controls7p;
        public static string Controls29;
        public static string Controls43;
        public static string Controls1;
        public static string Controls46;
        public static string Controls2;
        public static string Controls44;
        public static string Controls33;
        public static string Controls45;
        public static string Controls34;
        public static string TextBox1;
        public static string Controls35;
        public static string TextBox2;
        public static string Controls4;
        public static string Controls39;
        public static string Controls5;
        public static string Controls40;
        public static string Controls38;
        public static string TextBox3;
        public static string Controls6;
        public static string Controls47;
        public static string Controls36;
        public static string Controls41;
        public static string Controls37;
        public static string Controls42;
        public static string Controls30;
        public static string Controls31;
        public static string Controls32;
        public static string Controls8;
        public static string Controls9;
        public static string Controls10;
        public static string Controls11;
        public static string Controls12;
        public static string Controls13;
        public static string Controls14;
        public static string Controls15;
        public static string Controls16;
        public static string Controls17;
        public static string Controls18;
        public static string Controls19;
        public static string Controls20;
        public static string Controls21;
        public static string Controls22;
        public static string Controls23;
        public static string Controls24;
        public static string Controls25;
        public static string Controls26;
        public static string Controls27;
        public static string Controls28;
        private static object Impression;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static string Controls90;
        public static string Controls91;
        public static string Controls92;
        public static string Controls93;
        public static string Controls94;
        public static string Controls95;
        public static string Controls96;
        public static string Controls97;
        public static string Controls98;
        public static string Controls99;
        public static string EnTeteLogo;
        public void CreerPage()
        {
            StreamWriter sw = new StreamWriter($"\\\\developpement\\D$\\CacheWeb\\DR_Conception_{ControleurServeur.Program.IdNoEmploye}_{DateTime.Now.ToShortDateString()}.html");
            sw.Write($"<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><meta http-equiv=\"Content-Type\" " +
                $"content=\"text/html; charset=utf-8\" /><title>{DR_Conception.EnTeteAdresse}</title></head><body>" +
                $"<form ><div class=\"aspNetHidden\"></div><div><div {DR_Conception.Impression}><table align=\"right\">" +
                $"<tr align=\"center\"><td><img alt=\"{DR_Conception.EnTeteLogo}\" src=\"images/logo%20GRB-inc.2.bmp\" /></td></tr>" +
                $"<tr align=\"center\"><td>149, rue Pierre Paradis, <br />St-Alphonse-de-Granby, QC J0E 2A4</td></tr>" +
                $"<tr align=\"center\"><td>Tel: (450) 372-0021  Fax: (450) 372-3860</td></tr></table><br />");
            sw.Write($"<table><tr><td class=\"text-center\" colspan=\"3\"><br /><span {DR_Conception.Controls3} style=\"font-size:Larger;\">" +
                $"CONCEPTION</span></td><td>    <span {DR_Conception.Controls7}>Soumission: </span><br />" +
                $"<span {DR_Conception.Controls7p}>Projet #: </span></td><td><span {DR_Conception.Controls29}></span>" +
                $"<br /><span {DR_Conception.Controls43}></span></td><td><span {DR_Conception.Controls1}>" +
                $"Date: </span></td><td><span {DR_Conception.Controls46}></span></td></tr><tr><td rowspan=\"2\">" +
                $"<span {DR_Conception.Controls2}>Projet/Nom: </span></td><td colspan=\"6\">" +
                $"<span {DR_Conception.Controls44} style=\"display:inline-block;width:100%;\"></span></td></tr><tr><td>" +
                $"<span {DR_Conception.Controls33}>Date d'ouverture: </span></td><td>" +
                $"<span {DR_Conception.Controls45}></span></td><td>" +
                $"<span {DR_Conception.Controls34}>Date du: </span></td><td>" +
                $"<span {DR_Conception.TextBox1}></span></td><td><span {DR_Conception.Controls35}>Heure: </span></td><td>" +
                $"<span {DR_Conception.TextBox2}></span></td></tr><tr><td><span {DR_Conception.Controls4}>Client: </span></td>" +
                $"<td colspan=\"6\"><span {DR_Conception.Controls39} style=\"display:inline-block;width:100%;\">" +
                $"</span></td></tr><tr><td><span {DR_Conception.Controls5}>Contact</span></td><td colspan=\"4\">" +
                $"<span {DR_Conception.Controls40} style=\"display:inline-block;width:100%;\"></span></td><td>" +
                $"<span {DR_Conception.Controls38}>Date de fermeture: </span></td><td>    <span {DR_Conception.TextBox3}>" +
                $"</span></td></tr><tr><td><span {DR_Conception.Controls6}>Projet: </span></td><td colspan=\"2\">" +
                $"<span {DR_Conception.Controls47} style=\"display:inline-block;width:100%;\"></span></td><td>" +
                $"<span {DR_Conception.Controls36}>Tel: </span></td><td><span {DR_Conception.Controls41}></span></td><td>" +
                $"<span {DR_Conception.Controls37}>Fax: </span></td><td><span {DR_Conception.Controls42}></span></td>" +
                $"</tr></table><br /><table><tr align=\"center\"><td class=\"NoLignes\">#</td><td><span {DR_Conception.Controls30} " +
                $"style=\"display:inline-block;width:100px;\">Date</span></td><td><span {DR_Conception.Controls31}" +
                $" style=\"display:inline-block;width:300px;\">Contact</span></td><td><span {DR_Conception.Controls32} " +
                $"style=\"display:inline-block;width:550px;\">Commentaires</span></td></tr><tr align=\"center\"><td class=\"NoLignes\">" +
                $"<span {DR_Conception.Controls8}>1</span></td><td></td><td></td><td></td></tr><tr align=\"center\">" +
                $"<td class=\"NoLignes\"><span {DR_Conception.Controls9}>2</span></td><td></td><td></td><td></td></tr>" +
                $"<tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls10}>3</span></td><td></td><td></td><td></td>" +
                $"</tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls11}>4</span></td><td></td><td></td><td></td>" +
                $"</tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls12}>5</span></td><td></td><td></td><td></td>" +
                $"</tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls13}>" +
                $"6</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls14}>" +
                $"7</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls15}>" +
                $"8</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls16}>" +
                $"9</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls17}>" +
                $"10</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls18}>" +
                $"11</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls19}>" +
                $"12</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls20}>" +
                $"13</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls21}>" +
                $"14</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls22}>" +
                $"15</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls23}>" +
                $"16</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls24}>" +
                $"17</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls25}>" +
                $"18</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls26}>" +
                $"19</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls27}>" +
                $"20</span></td><td></td><td></td><td></td></tr><tr align=\"center\"><td class=\"NoLignes\"><span {DR_Conception.Controls28}>" +
                $"21</span></td><td></td><td></td><td></td></tr></table></div></div></form></body></html>");
        }
    }
    public class DR_DemandePrix
    {
        public static string lblTitreDemande; //lblTitreFournisseur.
        public static string lblTitreFournisseur; //lblFournisseur.
        public static string lblFournisseur; //lblTitreNoSoum.
        public static string lblTitreNoSoum; //lblNoSoum.
        public static string lblNoSoum; //lblTitreNoGRB.
        public static string lblTitreNoGRB; //lblNoGRB.
        public static string lblNoGRB; //lblTitreContact.
        public static string lblTitreContact; //lblContact.
        public static string lblContact; //lblTitreTel.
        public static string lblTitreTel; //lblTel.
        public static string lblTel; //lblTitreDate.
        public static string lblTitreDate; //lblDate.
        public static string lblDate; //lblTitreDateReq.
        public static string lblTitreDateReq; //lblDateRequise.
        public static string lblDateRequise; //lblTitreFax.
        public static string lblTitreFax; //lblFax.
        public static string lblFax; //lblTitreComPar.
        public static string lblTitreComPar; //lblCommandePar.
        public static string lblCommandePar; //lblTitreTransport.
        public static string lblTitreTransport; //lblTransport.
        public static string lblTransport; //lblTitrePage.
        public static string lblTitrePage; //lblPage.
        public static string lblPage; //lblTitreQte.
        public static string lblTitreQte; //lblTitrePiece.
        public static string lblTitrePiece; //lblTitreDescription.
        public static string lblTitreDescription; //lblTitreManufact.
        public static string lblTitreManufact; //lblTitrePrix.
        public static string lblTitrePrix; //lblTitreDelais.
        public static string lblTitreDelais; //Label2.
        public static string Label2; //Label3.
        public static string Label3; //Label4.
        public static string Label4; //Label5.
        public static string Label5; //GridView1.; ///GridView GridView1; //Label6.
        public static string Label6; //lblTitreCommentaire.
        public static string lblTitreCommentaire; //lblCommentaire.
        public static string lblCommentaire; //lblPrixValide.
        public static string lblPrixValide; //TextBox1.
        public static string TextBox1; //lblJours.
        public static string lblJours; //lblAdresse.
        public static string lblAdresse; //lblPiedPage.
        public static string lblPiedPage;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_FabricationFermeture
    {
        public static string lblGrandTotal; //lblGrandTotal
        public static string Label3; //Fabrication - Fermeture
        public static string Label7; //Soumission
        public static string Label44; //Projet #
        public static string lblSoum;
        public static string lblProj;
        public static string lblDate;
        public static string lblProjetNom;
        public static string lblDateOuverture;
        public static string Label35; //Heure: 
        public static string TextBox3;
        public static string lblNom; //Client
        public static string lblClient;
        public static string Label5; //Contact
        public static string lblContact;
        public static string Label38; //Date de fermeture
        public static string lblDatePrint;
        public static string Label6; //Projet
        public static string lblProjet;
        public static string Label36; //Tel.: 
        public static string lblTel;
        public static string Label37; //Fax: 
        public static string lblFax;
        public static string lblGrandTotalKM; //lblGrandTotalKM
        public static string Label8; //Documents obligatoires pour la fermeture du dossier
        public static string Label16; //Liste de materiel
        public static string Label9; //Dessin tel que construit
        public static string Label47; //Rapport CSA
        public static string Label48; //etiquette CSA
        public static string Label49; //Fiche technique
        public static string Label10; //Documents pour fin des fabrication
        public static string Label15; //Description
        public static string Label13; //Date
        public static string Label14; //Nbre de page
        public static string Label12; //Liste de materiel ATELIER
        public static string TextBox1;
        public static string TextBox4;
        public static string Label17; //Dessins Mecaniques
        public static string Label18; //# 
        public static string Label31; //Dessins 
        public static string Label27; //Revision
    }
    public class DR_Facturation
    {
        public static string lblTitreNumero;
        public static string lblNumero;
        public static string lblClient;
        public static string lblDate;
        public static string lblHeuresFacturees;
        public static dynamic lblHeuresNonFacturees;
        public static dynamic lblGrandTotal;
        public static string lblDateDebut;
        public static string lblDateFin;
        public static string Label8;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_FacturationManuelle
    {
        ///EnTeteAdresse.
        public static string EnTeteAdresse; //EnTeteTelFax.
        public static string EnTeteTelFax; //Label1.
        public static string Label1; //lblTitreNumero.
        public static string lblTitreNumero; //lblNumero.
        public static string lblNumero; //Label3.
        public static string Label3; //lblClient.
        public static string lblClient; //Label15.
        public static string Label15; //lblDateDebut.
        public static string lblDateDebut; //Label17.
        public static string Label17; //lblDateFin.
        public static string lblDateFin;
        public static string lblDate; //Label8.
        public static string Label8; //Label13.
        public static string Label13; //lblHeuresFacturees.
        public static string lblHeuresFacturees; //Label11.
        public static string Label11; //lblHeuresNonFacturees.
        public static string lblHeuresNonFacturees; //Label10.
        public static string Label10; //lblGrandTotal.
        public static string lblGrandTotal;
    }
    public class DR_FaxAnglais
    {
        public static string Label3; //Label9.
        public static string Label9; //Label10.
        public static string Label10; //lblDate.
        public static string lblDate; //lblNoProjetSoum.
        public static string lblNoProjetSoum; //lblProjet.
        public static string lblProjet; //Label11.
        public static string Label11; //lblAttention.
        public static string lblAttention; //Label12.
        public static string Label12; //lblEntreprise.
        public static string lblEntreprise; //Label13.
        public static string Label13; //lblFax.
        public static string lblFax; //Label21.
        public static string Label21; //lblSujet.
        public static string lblSujet; //Label5.
        public static string Label5; //Label1.
        public static string Label1; //lblPage.
        public static string lblPage; //Label7.
        public static string Label7; //lblDe.
        public static string lblDe; //Label6.
        public static string Label6; //lblMessage.
        public static string lblMessage; //Label4.
        public static string Label4; //Label2.
        public static string Label2; //Label8.
        public static string Label8;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_FaxFrancais
    {
        ///Label9.
        public static string Label9; //Label14.
        public static string Label14; //Label10.
        public static string Label10; //lblDate.
        public static string lblDate; //lblNoProjetSoum.
        public static string lblNoProjetSoum; //lblProjet.
        public static string lblProjet; //Label11.
        public static string Label11; //lblAttention.
        public static string lblAttention; //Label12.
        public static string Label12; //lblEntreprise.
        public static string lblEntreprise; //Label13.
        public static string Label13; //lblFax.
        public static string lblFax; //Label21.
        public static string Label21; //lblSujet.
        public static string lblSujet; //Label5.
        public static string Label5; //Label1.
        public static string Label1; //lblPage.
        public static string lblPage; //Label7.
        public static string Label7; //lblDe.
        public static string lblDe; //Label6.
        public static string Label6; //lblMessage.
        public static string lblMessage; //Label4.
        public static string Label4; //Label2.
        public static string Label2; //Label8.
        public static string Label8; //Label3.
        public static string Label3;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_FeuilleTemps
    {
        public static string Label2; //lblSemaine.
        public static string lblSemaine; //lblUtilisateur.
        public static string lblUtilisateur; //lblTotalKM.
        public static string lblTotalKM; //lblTotalHeures.
        public static string lblTotalHeures;
        public static string lblGrandTotalKM;
        public static double lblGrandTotal;
        public static string lblDatePrint;
        public static string lblDate;
        public static string lblNom;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static Recordset DataSource;
    }
    public class DR_FinFab
    {
        public static string Label3; //Label53.
        public static string Label53; //TextBox1.
        public static string TextBox1; //Label59.
        public static string Label59; //TextBox2.
        public static string TextBox2; //Label1.
        public static string Label1; //TextBox3.
        public static string TextBox3; //Label17.
        public static string Label17; //Label18.
        public static string Label18; //Label30.
        public static string Label30; //Label31.
        public static string Label31; //Label32.
        public static string Label32; //Label27.
        public static string Label27; //Label28.
        public static string Label28; //Label19.
        public static string Label19; //Label20.
        public static string Label20; //Label21.
        public static string Label21; //Label22.
        public static string Label22; //Label23.
        public static string Label23; //Label24.
        public static string Label24; //Label25.
        public static string Label25; //Label26.
        public static string Label26; //Label29.
        public static string Label29; //Label39.
        public static string Label39; //Label40.
        public static string Label40; //Label41.
        public static string Label41; //Label42.
        public static string Label42; //Label43.
        public static string Label43; //Label45.
        public static string Label45; //Label46.
        public static string Label46; //Label2.
        public static string Label2; //Label4.
        public static string Label4; //Label5.
        public static string Label5; //Label6.
        public static string Label6; //Label7.
        public static string Label7; //Label8.
        public static string Label8;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_Fournisseur
    {
        ///EnTeteLogo.
        ///Image EnTeteLogo; //EnTeteAdresse.
        public static string EnTeteAdresse; //EnTeteTelFax.
        public static string EnTeteTelFax; //DR_FounisseurLabel3.
        public static string DR_FounisseurLabel3; //DR_FounisseurLabel7.
        public static string DR_FounisseurLabel7; //DR_FounisseurLabel29.
        public static string DR_FounisseurLabel29; //TextBox1.
        public static string TextBox1; //TextBox2.
        public static string TextBox2; //DR_FounisseurLabel1.
        public static string DR_FounisseurLabel1; //DR_FounisseurLblDate.
        public static string DR_FounisseurLblDate; //DR_FounisseurLabel2.
        public static string DR_FounisseurLabel2; //TextBox3.
        public static string TextBox3; //DR_FounisseurLabel33.
        public static string DR_FounisseurLabel33; //DR_FounisseurLblDateOuverture.
        public static string DR_FounisseurLblDateOuverture; //DR_FounisseurLabel34.
        public static string DR_FounisseurLabel34; //DR_FounisseurLblDateDue.
        public static string DR_FounisseurLblDateDue; //DR_FounisseurLabel35.
        public static string DR_FounisseurLabel35; //TextBox4.
        public static string TextBox4; //DR_FounisseurLabel4.
        public static string DR_FounisseurLabel4; //DR_FounisseurLblClient.
        public static string DR_FounisseurLblClient; //DR_FounisseurLabel5.
        public static string DR_FounisseurLabel5; //DR_FounisseurLblContact.
        public static string DR_FounisseurLblContact; //DR_FounisseurLabel38.
        public static string DR_FounisseurLabel38; //TextBox5.
        public static string TextBox5; //DR_FounisseurLabel6.
        public static string DR_FounisseurLabel6; //DR_FounisseurLblProjet.
        public static string DR_FounisseurLblProjet; //DR_FounisseurLabel36.
        public static string DR_FounisseurLabel36; //DR_FounisseurLblTel.
        public static string DR_FounisseurLblTel; //DR_FounisseurLabel37.
        public static string DR_FounisseurLabel37; //DR_FounisseurLblFax.
        public static string DR_FounisseurLblFax; //DR_FounisseurLabel30.
        public static string DR_FounisseurLabel30; //DR_FounisseurLabel31.
        public static string DR_FounisseurLabel31; //DR_FounisseurLabel32.
        public static string DR_FounisseurLabel32; //DR_FounisseurLabel8.
        public static string DR_FounisseurLabel8; //TextBox6.
        public static string TextBox6; //TextBox7.
        public static string TextBox7; //TextBox8.
        public static string TextBox8; //DR_FounisseurLabel9.
        public static string DR_FounisseurLabel9; //TextBox9.
        public static string TextBox9; //TextBox10.
        public static string TextBox10; //TextBox11.
        public static string TextBox11; //DR_FounisseurLabel10.
        public static string DR_FounisseurLabel10; //TextBox12.
        public static string TextBox12; //TextBox13.
        public static string TextBox13; //TextBox14.
        public static string TextBox14; //DR_FounisseurLabel11.
        public static string DR_FounisseurLabel11; //TextBox15.
        public static string TextBox15; //TextBox16.
        public static string TextBox16; //TextBox17.
        public static string TextBox17; //DR_FounisseurLabel12.
        public static string DR_FounisseurLabel12; //TextBox18.
        public static string TextBox18; //TextBox19.
        public static string TextBox19; //TextBox20.
        public static string TextBox20; //DR_FounisseurLabel13.
        public static string DR_FounisseurLabel13; //TextBox21.
        public static string TextBox21; //TextBox22.
        public static string TextBox22; //TextBox23.
        public static string TextBox23; //DR_FounisseurLabel14.
        public static string DR_FounisseurLabel14; //TextBox24.
        public static string TextBox24; //TextBox25.
        public static string TextBox25; //TextBox26.
        public static string TextBox26; //DR_FounisseurLabel15.
        public static string DR_FounisseurLabel15; //TextBox27.
        public static string TextBox27; //TextBox28.
        public static string TextBox28; //TextBox29.
        public static string TextBox29; //DR_FounisseurLabel16.
        public static string DR_FounisseurLabel16; //TextBox30.
        public static string TextBox30; //TextBox31.
        public static string TextBox31; //TextBox32.
        public static string TextBox32; //DR_FounisseurLabel17.
        public static string DR_FounisseurLabel17; //TextBox33.
        public static string TextBox33; //TextBox34.
        public static string TextBox34; //TextBox35.
        public static string TextBox35; //DR_FounisseurLabel18.
        public static string DR_FounisseurLabel18; //TextBox36.
        public static string TextBox36; //TextBox37.
        public static string TextBox37; //TextBox38.
        public static string TextBox38; //DR_FounisseurLabel19.
        public static string DR_FounisseurLabel19; //TextBox39.
        public static string TextBox39; //TextBox40.
        public static string TextBox40; //TextBox41.
        public static string TextBox41; //DR_FounisseurLabel20.
        public static string DR_FounisseurLabel20; //TextBox42.
        public static string TextBox42; //TextBox43.
        public static string TextBox43; //TextBox44.
        public static string TextBox44; //DR_FounisseurLabel21.
        public static string DR_FounisseurLabel21; //TextBox45.
        public static string TextBox45; //TextBox46.
        public static string TextBox46; //TextBox47.
        public static string TextBox47; //DR_FounisseurLabel22.
        public static string DR_FounisseurLabel22; //TextBox48.
        public static string TextBox48; //TextBox49.
        public static string TextBox49; //TextBox50.
        public static string TextBox50;
        public static string lblClient;
        public static string lblContact;
        public static string lblTel;
        public static string lblFax;
        public static string lblNoSoum;
        public static string lblNoProj;
        public static string lblProjetNom;
        public static string lblDate;
        public static string lblDateOuverture;
        public static string lblDateDue;
        public static string lblProjet;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_Inventaire
    {
        public static string lblDate;
        public static dynamic lblTotal;
        public static string lblTitre;
        public static Recordset DataSource;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_InventaireM
    {
        ///lvwInventaireAjust.
        ///GridView lvwInventaireAjust;
    }
    public class DR_Liste_piece
    {
        public DR_Liste_piece()
        {
        }
        public static Recordset DataSource;
        public static string lblDate;
        public static string lblProjet;
        public static string lblSoumission;
        public static string lblDescription;
        public static string lblClient;
        public static string lblContact;
        public static bool rptOrientPortrait;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static bool lblTitreNoFactureVisible;
        public static bool lblNoFactureVisible;
        public static string lblNoFacture;
        public static string lbldate;
        public static string lblTitreProjet;
        public static string lblTitreSoumission;
        public static string lblTitreQuantite;
        public static string lblTitreNoItem;
        public static string lblTitreManufacturier;
        public static string lblTitreID;
        public static string lblNoPage;
        public static string lblsoumission;
        public static string Label1 = "149, rue Pierre Paradis, St-Alphonse-de-Granby, QC J0E 2A4";
        public static string Label2 = "Tel: (450) 372-0021  Fax: (450) 372-3860";
        public static string lblTitreClient; //"Client: 
        public static string lblTitreContact; //"Contact: 
        public static string lblcontact;
        public static string Label4; //"Description: 
        public static string lbldescription;
        public static string lblTitreNoFacture; //"Facture: 
        public static string TextBox2;
        public static string lblTitreDescription; //"Description"
        public static string lblTitreid; //"# id"
        public static string Label3; //"CSA Verifie"
        public static string Text1; //"Qte"
        public static string Text6; //"No. Item"
        public static string Text3; //"Description"
        public static string Text4; //"Manufacturier"
        public static string Text5; //"# id"
    }
    public class DR_ListeAchats
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string Label2; //lblNumero.
        public static string lblNumero; //Label14.
        public static string Label14; //lblDate.
        public static string lblDate; //Label3.
        public static string Label3; //Label4.
        public static string Label4; //Label6.
        public static string Label6; //Label5.
        public static string Label5; //Label8.
        public static string Label8; //Label7.
        public static string Label7; //Label9.
        public static string Label9; //Label10.
        public static string Label10; //Label16.
        public static string Label16; //Label11.
        public static string Label11; //Label12.
        public static string Label12; //Label13.
        public static string Label13; //Label17.
        public static string Label17; //GridView1.
        ///GridView GridView1; //lblDateImpression.
        public static string lblDateImpression; //TextBox1.
        public static string TextBox1; //Label18.
        public static string Label18; //Label33.
        public static string Label33; //Label19.
        public static string Label19; //lblTotal.
        public static string lblTotal;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_ListeClient
    {
        public static string EnTeteAdresse; //EnTeteTelFax.
        public static string EnTeteTelFax; //Label2.
        public static string Label2; //Label4.
        public static string Label4; //Label9.
        public static string Label9; //Label10.
        public static string Label10; //Label3.
        public static string Label3; //Label7.
        public static string Label7; //Label5.
        public static string Label5; //Text1.
        public static string Text1; //Text3.
        public static string Text3; //Text6.
        public static string Text6; //Text9.
        public static string Text9; //Text12.
        public static string Text12; //Text11.
        public static string Text11; //Text10.
        public static string Text10; //Text4.
        public static string Text4; //Text2.
        public static string Text2; //Text5.
        public static string Text5; //GridView1.
        ///GridView GridView1; //Label1.
        public static string Label1; //TextBox2.
        public static string TextBox2; //Label6.
        public static string Label6; //TextBox3.
        public static string TextBox3;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static Recordset DataSource;
    }
    public class DR_ListeContact
    {
        ///Label2.
        public static string Label2; //Filler.
        public static string Filler; //Mode.
        ///Panel Mode; //Text1.
        public static string Text1; //Text2.
        public static string Text2; //Text3.
        public static string Text3; //Text9.
        public static string Text9; //Text7.
        public static string Text7; //Text4.
        public static string Text4; //Text5.
        public static string Text5; //Text6.
        public static string Text6;
        public static string lblDateImpression;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static Recordset DataSource;
    }
    public class DR_ListeFournisseur
    {
        public static Recordset DataSource;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_ListeInventaire
    {
        public static string EnTeteAdresse; //EnTeteTelFax.
        public static string EnTeteTelFax; //lblTitre.
        public static string lblTitre; //Label2.
        public static string Label2; //Label3.
        public static string Label3; //Label4.
        public static string Label4; //Label5.
        public static string Label5; //Label1.
        public static string Label1; //Label6.
        public static string Label6; //txtNoItem.
        public static string txtNoItem; //txtDescription.
        public static string txtDescription; //txtManufacturier.
        public static string txtManufacturier; //txtLocalisation.
        public static string txtLocalisation; //Text1.
        public static string Text1; //Shape2.
        public static string Shape2; //GridView1.
        public static string lblDateImpression; //Label18.
        public static string Label18;
        public static string lblDate;
        public static Recordset DataSource { get; set; }
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_ListeProjet
    {
        public static string EnTeteAdresse; //EnTeteTelFax
        public static string EnTeteTelFax; //lblTitre
        public static string lblTitre; //Label15
        public static string Label15; //TextBox1
        public static string TextBox1; //Label17
        public static string Label17; //TextBox2
        public static string TextBox2; //Label1
        public static string Label1; //Label2
        public static string Label2; //Text4
        public static string Text4; //Text5
        public static string Text5; //GridView1
        public static string lblDateImpression; //Label18
        public static string Label18;
        public static string lblDateDebut;
        public static string lblDateFin;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_OutilsInOut
    {
        public static string EnTeteAdresse; //EnTeteTelFax
        public static string EnTeteTelFax; //lblTitre
        public static string lblTitre; //Label1
        public static string Label1; //Label6
        public static string Label6; //Label4
        public static string Label4; //Label5
        public static string Label5; //Label2
        public static string Label2; //Label3
        public static string Label3; //txtno
        public static string txtno; //txtnom
        public static string txtnom; //txttype
        public static string txttype; //txtcout
        public static string txtcout; //txtachat
        public static string txtachat; //txthorsfonction
        public static string txthorsfonction; //GridView1
        public static string lblDateImpression; //Label18
        public static string Label18;
        public static string lbldepartement;
        public static string lbldate;
        public static Recordset DataSource;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_OutilsMachinerie
    {
        public static string EnTeteAdresse;
        public static string EnTeteTelFax;
        public static string lblTitre;
        public static string Label1;
        public static string Label6;
        public static string Label4;
        public static string Label5;
        public static string Label2;
        public static string Label3;
        public static string Label8;
        public static string txtno;
        public static string txtnom;
        public static string txttype;
        public static string txtcout;
        public static string txtachat;
        public static string txthorsfonction;
        public static string txtcommentaire;
        public static string lbldepartement;
        public static string lbldate;
        public static string lblDateImpression;
        public static string Label18;
        public static Recordset DataSource;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_Probleme
    {
        public static string DR_ProblemesLblTitreProjSoum;
        public static string DR_ProblemesLblNoProjSoum;
        public static string DR_ProblemesLabel2;
        public static string DR_ProblemesLblNomEmploye;
        public static string DR_ProblemesLabel3;
        public static string DR_ProblemesLabel5;
        public static string DR_ProblemesLabel1;
        public static string DR_ProblemesLabel4;
        public static string DR_ProblemesLabel6;
        public static string DR_ProblemesLabel7;
        public static string DR_ProblemesLabel8;
        public static string DR_ProblemesLabel9;
        public static string DR_ProblemesLabel10;
        public static string DR_ProblemesLabel11;
        public static string DR_ProblemesLabel12;
        public static string DR_ProblemesLabel13;
        public static string DR_ProblemesLabel14;
        public static string lblTitreProjSoum; //Projet #
        public static string lblNoProjSoum;
        public static string Label2; //Nom de l'employe
        public static string lblNomEmploye;
        public static string TextBox1;
        public static string TextBox2;
        public static string TextBox3;
        public static string TextBox4;
        public static string TextBox5;
        public static string Label3; //#
        public static string Label5; //Problèmes rencontres
        public static string Label1; //Date"
        public static string Label4; //1
        public static string TextBox6;
        public static string TextBox7;
        public static string Label6; //2
        public static string TextBox8;
        public static string TextBox9;
        public static string Label7; //3
        public static string TextBox10;
        public static string TextBox11;
        public static string Label8; //4
        public static string TextBox12;
        public static string TextBox13;
        public static string Label9; //5
        public static string TextBox14;
        public static string TextBox15;
        public static string Label10; //6
        public static string TextBox16;
        public static string TextBox17;
        public static string Label11; //7
        public static string TextBox18;
        public static string TextBox19;
        public static string Label12; //8
        public static string TextBox20;
        public static string TextBox21;
        public static string Label13; //9
        public static string TextBox22;
        public static string TextBox23;
        public static string Label14; //10
        public static string TextBox24;
        public static string TextBox25;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_Programmation
    {
        public static string Label3;
        public static string Label7; //Label22
        public static string Label22; //TextBox1
        public static string TextBox1; //TextBox2
        public static string TextBox2; //Label1
        public static string Label1; //lblDate
        public static string lblDate; //Label2
        public static string Label2; //lblProjetNom
        public static string lblProjetNom; //Label33
        public static string Label33; //lblMDPAutomate
        public static string lblMDPAutomate; //Label34
        public static string Label34; //lblMDPAutre
        public static string lblMDPAutre; //Label4
        public static string Label4; //lblClient
        public static string lblClient; //Label5
        public static string Label5; //lblContact
        public static string lblContact; //Label38
        public static string Label38; //TextBox5
        public static string TextBox5; //Label6
        public static string Label6; //lblProjetClient
        public static string lblProjetClient; //Label36
        public static string Label36; //lblTelephone
        public static string lblTelephone; //Label37
        public static string Label37; //lblFax
        public static string lblFax; //Label8
        public static string Label8; //Label13
        public static string Label13; //Label9
        public static string Label9; //Label14
        public static string Label14; //Label10
        public static string Label10; //Label15
        public static string Label15; //Label11
        public static string Label11; //Label16
        public static string Label16; //Label12
        public static string Label12; //Label17
        public static string Label17; //TextBox3
        public static string TextBox3; //Label18
        public static string Label18; //TextBox4
        public static string TextBox4; //Label21
        public static string Label21; //Label19
        public static string Label19; //Label20
        public static string Label20; //Label23
        public static string Label23; //TextBox6
        public static string TextBox6; //TextBox8
        public static string TextBox8; //TextBox9
        public static string TextBox9; //TextBox7
        public static string TextBox7; //TextBox10
        public static string TextBox10; //TextBox11
        public static string TextBox11; //TextBox12
        public static string TextBox12; //TextBox13
        public static string TextBox13; //TextBox14
        public static string TextBox14; //TextBox15
        public static string TextBox15; //TextBox16
        public static string TextBox16; //TextBox17
        public static string TextBox17; //TextBox18
        public static string TextBox18; //TextBox19
        public static string TextBox19; //TextBox20
        public static string TextBox20; //TextBox21
        public static string TextBox21; //TextBox22
        public static string TextBox22; //TextBox23
        public static string TextBox23; //TextBox24
        public static string TextBox24; //TextBox25
        public static string TextBox25; //TextBox26
        public static string TextBox26; //TextBox27
        public static string TextBox27; //TextBox28
        public static string TextBox28; //TextBox29
        public static string TextBox29; //TextBox30
        public static string TextBox30; //TextBox31
        public static string TextBox31; //TextBox32
        public static string TextBox32; //TextBox33
        public static string TextBox33; //TextBox34
        public static string TextBox34; //TextBox35
        public static string TextBox35; //TextBox36
        public static string TextBox36; //TextBox37
        public static string TextBox37; //TextBox38
        public static string TextBox38; //TextBox39
        public static string TextBox39; //TextBox40
        public static string TextBox40; //TextBox41
        public static string TextBox41; //TextBox42
        public static string TextBox42; //TextBox43
        public static string TextBox43; //TextBox44
        public static string TextBox44; //TextBox45
        public static string TextBox45; //TextBox46
        public static string TextBox46; //TextBox47
        public static string TextBox47; //TextBox48
        public static string TextBox48; //TextBox49
        public static string TextBox49; //TextBox50
        public static string TextBox50; //TextBox51
        public static string TextBox51; //TextBox52
        public static string TextBox52; //TextBox53
        public static string TextBox53; //TextBox54
        public static string TextBox54; //TextBox55
        public static string TextBox55; //TextBox56
        public static string TextBox56; //TextBox57
        public static string TextBox57; //TextBox58
        public static string TextBox58; //TextBox59
        public static string TextBox59; //TextBox60
        public static string TextBox60; //TextBox61
        public static string TextBox61; //TextBox62
        public static string TextBox62; //TextBox63
        public static string TextBox63; //TextBox64
        public static string TextBox64; //TextBox65
        public static string TextBox65; //TextBox66
        public static string TextBox66; //TextBox67
        public static string TextBox67; //TextBox68
        public static string TextBox68; //TextBox69
        public static string TextBox69; //TextBox70
        public static string TextBox70; //TextBox71
        public static string TextBox71; //TextBox72
        public static string TextBox72; //TextBox73
        public static string TextBox73; //TextBox74
        public static string TextBox74; //TextBox75
        public static string TextBox75; //TextBox76
        public static string TextBox76; //TextBox77
        public static string TextBox77; //TextBox78
        public static string TextBox78; //TextBox79
        public static string TextBox79; //TextBox80
        public static string TextBox80; //TextBox81
        public static string TextBox81; //TextBox82
        public static string TextBox82; //TextBox83
        public static string TextBox83; //TextBox84
        public static string TextBox84; //TextBox85
        public static string TextBox85; //TextBox86
        public static string TextBox86; //TextBox87
        public static string TextBox87; //TextBox88
        public static string TextBox88; //TextBox89
        public static string TextBox89;
        public static string lblNoProj;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        internal static string lblNoSoum;
    }
    public class DR_ProjSoumElec
    {
        public static string lblFormTitle; //lblTotalTemps
        public static string lblTotalTemps; //txtTotalTemps
        public static string txtTotalTemps; //lblTotalPieces
        public static string lblTotalPieces; //txtTotalPieces
        public static string txtTotalPieces; //Label5
        public static string Label5; //txtProfit
        public static string txtProfit; //lblImprevus
        public static string lblImprevus; //txtImprevus
        public static string txtImprevus; //Label8
        public static string Label8; //txtCommission
        public static string txtCommission; //Label7
        public static string Label7; //txtPrixTotal
        public static string txtPrixTotal; //lblPasTemps
        public static string lblPasTemps; //txtChoix
        public static string txtChoix; //txtNoProjSoum
        public static string txtNoProjSoum; //lblNoSoumission
        public static string lblNoSoumission; //txtNoSoumission
        public static string txtNoSoumission; //Label26
        public static string Label26; //txtTransport
        public static string txtTransport; //Label2
        public static string Label2; //txtCheminPhotos
        public static string txtCheminPhotos; //Label4
        public static string Label4; //txtClient
        public static string txtClient; //lblPrixReception
        public static string lblPrixReception; //txtPrixReception
        public static string txtPrixReception; //Label3
        public static string Label3; //txtForfait
        public static string txtForfait; //lblForfaitInitiale
        public static string lblForfaitInitiale; //Label6
        public static string Label6; //txtContact
        public static string txtContact; //lblPrixSoumission
        public static string lblPrixSoumission; //txtPrixSoumission
        public static string txtPrixSoumission; //lblDateFacturation
        public static string lblDateFacturation; //txtDateFacturation
        public static string txtDateFacturation; //lblProjet
        public static string lblProjet; //txtProjet
        public static string txtProjet; //lblfraManuel
        public static string lblfraManuel; //Label23
        public static string Label23; //txtNbreManuel
        public static string txtNbreManuel; //Label22
        public static string Label22; //txtPrixManuel
        public static string txtPrixManuel; //Label21
        public static string Label21; //txtDelais
        public static string txtDelais; //lblSections
        public static string lblSections; //lblPiece
        public static string lblPiece; //lblTri
        public static string lblTri; //lblfraPieceTrouve
        public static string lblfraPieceTrouve; //lblfraPrixPiece
        public static string lblfraPrixPiece; //Label11
        public static string Label11; //Label12
        public static string Label12; //txtPrixList
        public static string txtPrixList; //Label13
        public static string Label13; //mskEscompte
        public static string mskEscompte; //Label14
        public static string Label14; //txtPrixNet
        public static string txtPrixNet; //Label15
        public static string Label15; //txtPrixSpecial
        public static string txtPrixSpecial; //lblfraDateRequise
        public static string lblfraDateRequise; //lblfraCommentaire
        public static string lblfraCommentaire; //txtCommentaire
        public static string txtCommentaire;
    }
    public class DR_ProjSoumMec
    {
        public static string lblFormTitle; //lblTotalTemps
        public static string lblTotalTemps; //txtTotalTemps
        public static string txtTotalTemps; //lblTotalPieces
        public static string lblTotalPieces; //txtTotalPieces
        public static string txtTotalPieces; //Label5
        public static string Label5; //txtProfit
        public static string txtProfit; //lblImprevus
        public static string lblImprevus; //txtImprevus
        public static string txtImprevus; //Label8
        public static string Label8; //txtCommission
        public static string txtCommission; //Label7
        public static string Label7; //txtPrixTotal
        public static string txtPrixTotal; //lblPasTemps
        public static string lblPasTemps; //txtChoix
        public static string txtChoix; //txtNoProjSoum
        public static string txtNoProjSoum; //lblNoSoumission
        public static string lblNoSoumission; //txtNoSoumission
        public static string txtNoSoumission; //Label26
        public static string Label26; //txtTransport
        public static string txtTransport; //Label2
        public static string Label2; //txtCheminPhotos
        public static string txtCheminPhotos; //Label4
        public static string Label4; //txtClient
        public static string txtClient; //lblPrixReception
        public static string lblPrixReception; //txtPrixReception
        public static string txtPrixReception; //Label3
        public static string Label3; //txtForfait
        public static string txtForfait; //lblForfaitInitiale
        public static string lblForfaitInitiale; //Label6
        public static string Label6; //txtContact
        public static string txtContact; //lblPrixSoumission
        public static string lblPrixSoumission; //txtPrixSoumission
        public static string txtPrixSoumission; //lblDateFacturation
        public static string lblDateFacturation; //txtDateFacturation
        public static string txtDateFacturation; //lblProjet
        public static string lblProjet; //txtProjet
        public static string txtProjet; //lblfraManuel
        public static string lblfraManuel; //Label23
        public static string Label23; //txtNbreManuel
        public static string txtNbreManuel; //Label22
        public static string Label22; //txtPrixManuel
        public static string txtPrixManuel; //Label21
        public static string Label21; //txtDelais
        public static string txtDelais; //lblSections
        public static string lblSections; //lblPiece
        public static string lblPiece; //lblTri
        public static string lblTri; //lblfraPieceTrouve
        public static string lblfraPieceTrouve; //lblfraPrixPiece
        public static string lblfraPrixPiece; //Label11
        public static string Label11; //Label12
        public static string Label12; //txtPrixList
        public static string txtPrixList; //Label13
        public static string Label13; //mskEscompte
        public static string mskEscompte; //Label14
        public static string Label14; //txtPrixNet
        public static string txtPrixNet; //Label15
        public static string Label15; //txtPrixSpecial
        public static string txtPrixSpecial; //lblfraDateRequise
        public static string lblfraDateRequise; //lblfraCommentaire
        public static string lblfraCommentaire; //txtCommentaire
        public static string txtCommentaire;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_ProjSoumMecTemps
    {
        public static string lblfraRessourcesHumaines;
        public static string Label8;
        public static string Label9;
        public static string Label54;
        public static string Label56;
        public static string Label57;
        public static string Label58;
        public static string Label7;
        public static string txtTempsDessinSoum;
        public static string txtTempsDessinProj;
        public static string txtTempsDessinConc;
        public static string lblTempsDessinReel;
        public static string Label16;
        public static string lblPrixDessin;
        public static string Label30;
        public static string Label2;
        public static string txtTempsCoupeSoum;
        public static string txtTempsCoupeProj;
        public static string txtTempsCoupeConc;
        public static string lblTempsCoupeReel;
        public static string Label15;
        public static string lblPrixCoupe;
        public static string Label18;
        public static string Label1;
        public static string txtTempsMachinageSoum;
        public static string txtTempsMachinageProj;
        public static string txtTempsMachinageConc; //lblTempsMachinageReel
        public static string lblTempsMachinageReel; //Label51
        public static string Label51; //lblPrixMachinage
        public static string lblPrixMachinage; //Label19
        public static string Label19; //Label3
        public static string Label3; //txtTempsSoudureSoum
        public static string txtTempsSoudureSoum; //txtTempsSoudureProj
        public static string txtTempsSoudureProj; //txtTempsSoudureConc
        public static string txtTempsSoudureConc; //lblTempsSoudureReel
        public static string lblTempsSoudureReel; //Label66
        public static string Label66; //lblPrixSoudure
        public static string lblPrixSoudure; //Label21
        public static string Label21; //Label5
        public static string Label5; //txtTempsAssemblageSoum
        public static string txtTempsAssemblageSoum; //txtTempsAssemblageProj
        public static string txtTempsAssemblageProj; //txtTempsAssemblageConc
        public static string txtTempsAssemblageConc; //lblTempsAssemblageReel
        public static string lblTempsAssemblageReel; //Label55
        public static string Label55; //lblPrixAssemblage
        public static string lblPrixAssemblage; //Label22
        public static string Label22; //Label4
        public static string Label4; //txtTempsPeintureSoum
        public static string txtTempsPeintureSoum; //txtTempsPeintureProj
        public static string txtTempsPeintureProj; //txtTempsPeintureConc
        public static string txtTempsPeintureConc; //lblTempsPeintureReel
        public static string lblTempsPeintureReel; //Label14
        public static string Label14; //lblPrixPeinture
        public static string lblPrixPeinture; //Label32
        public static string Label32; //Label6
        public static string Label6; //txtTempsTestSoum
        public static string txtTempsTestSoum; //txtTempsTestProj
        public static string txtTempsTestProj; //txtTempsTestConc
        public static string txtTempsTestConc; //lblTempsTestReel
        public static string lblTempsTestReel; //Label13
        public static string Label13; //lblPrixTest
        public static string lblPrixTest; //Label43
        public static string Label43; //Label49
        public static string Label49; //txtTempsInstallationSoum
        public static string txtTempsInstallationSoum; //txtTempsInstallationProj
        public static string txtTempsInstallationProj; //txtTempsInstallationConc
        public static string txtTempsInstallationConc; //lblTempsInstallationReel
        public static string lblTempsInstallationReel; //Label12
        public static string Label12; //lblPrixInstallation
        public static string lblPrixInstallation; //Label65
        public static string Label65; //Label41
        public static string Label41; //txtTempsFormationSoum
        public static string txtTempsFormationSoum; //txtTempsFormationProj
        public static string txtTempsFormationProj; //txtTempsFormationConc
        public static string txtTempsFormationConc; //lblTempsFormationReel
        public static string lblTempsFormationReel; //Label10
        public static string Label10; //lblPrixFormation
        public static string lblPrixFormation; //Label59
        public static string Label59; //Label67
        public static string Label67; //txtTempsGestionSoum
        public static string txtTempsGestionSoum; //txtTempsGestionProj
        public static string txtTempsGestionProj; //txtTempsGestionConc
        public static string txtTempsGestionConc; //lblTempsGestionReel
        public static string lblTempsGestionReel; //Label47
        public static string Label47; //lblPrixGestion
        public static string lblPrixGestion; //Label39
        public static string Label39; //Label53
        public static string Label53; //txtTempsShippingSoum
        public static string txtTempsShippingSoum; //txtTempsShippingProj
        public static string txtTempsShippingProj; //txtTempsShippingConc
        public static string txtTempsShippingConc; //lblTempsShippingReel
        public static string lblTempsShippingReel; //Label50
        public static string Label50; //lblPrixShipping
        public static string lblPrixShipping; //Label20
        public static string Label20; //Label60
        public static string Label60; //txtTempsPrototypeSoum
        public static string txtTempsPrototypeSoum; //txtTempsPrototypeProj
        public static string txtTempsPrototypeProj; //txtTempsPrototypeConc
        public static string txtTempsPrototypeConc; //lblTempsPrototypeReel
        public static string lblTempsPrototypeReel; //Label23
        public static string Label23; //lblPrixPrototype
        public static string lblPrixPrototype; //Label17
        public static string Label17; //Label52
        public static string Label52; //lblTotalTempsRHSoum
        public static string lblTotalTempsRHSoum; //lblTotalTempsRHProj
        public static string lblTotalTempsRHProj; //lblTotalTempsRHConc
        public static string lblTotalTempsRHConc; //lblTotalTempsRHReel
        public static string lblTotalTempsRHReel; //Label11
        public static string Label11; //lblTotalPrixRH
        public static string lblTotalPrixRH; //lblDollarRH
        public static string lblDollarRH; //cmdDetail
        public static string cmdDetail; //lblFormTitle
        public static string lblFormTitle; //fraFraisSubsistences
        public static string fraFraisSubsistences; //lblfraFraisSubsistences
        public static string lblfraFraisSubsistences; //Label38
        public static string Label38; //Label46
        public static string Label46; //txtNbrePersonne
        public static string txtNbrePersonne; //Label31
        public static string Label31; //txtTempsHebergement
        public static string txtTempsHebergement; //Label36
        public static string Label36; //lblPrixHebergement
        public static string lblPrixHebergement; //Label27
        public static string Label27; //Label45
        public static string Label45; //txtTempsRepas
        public static string txtTempsRepas; //Label37
        public static string Label37; //lblPrixRepas
        public static string lblPrixRepas; //Label29
        public static string Label29; //Label44
        public static string Label44; //txtTempsDeplacement
        public static string txtTempsDeplacement; //Label35
        public static string Label35; //lblPrixDeplacement
        public static string lblPrixDeplacement; //Label28
        public static string Label28; //Label42
        public static string Label42; //txtTempsUniteMobile
        public static string txtTempsUniteMobile; //Label34
        public static string Label34; //lblPrixUniteMobile
        public static string lblPrixUniteMobile; //Label40
        public static string Label40; //fraManutention
        public static string fraManutention; //lblfraManutention
        public static string lblfraManutention; //Label33
        public static string Label33; //Label24
        public static string Label24; //txtPrixEmballage
        public static string txtPrixEmballage; //Label48
        public static string Label48; //cmdUnlock
        public static string cmdUnlock; //cmdLock
        public static string cmdLock; //Label25
        public static string Label25; //lblTotal
        public static string lblTotal; //Label26
        public static string Label26;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public class DR_Reception
    {
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static string lblTitre; //TitreNumero
        public static string TitreNumero; //lblDate
        public static string lblDate; //lblTitreProjetAchat
        public static string lblTitreProjetAchat; //lblProjetAchat
        public static string lblProjetAchat; //GridView1
        public static string Label8; //lblTotal
        public static string lblTotal;
    }
    public class DR_Retour
    {
        public static string Button1;
        public static string Impression;
        public static string lblTitreCommande;
        public static string lblTitreFournisseur;
        public static string lblFournisseur;
        public static string lblTitreProjet;
        public static string lblNoProjet;
        public static string lblTitreRMA;
        public static string lblNoRMA;
        public static string lblTitreDate;
        public static string lblDate;
        public static string lblTitreTransport;
        public static string TextBox5;
        public static string lblTitreExpiditeur;
        public static string TextBox4;
        public static string Label3;
        public static string TextBox3;
        public static string lblTitreRecepteur;
        public static string TextBox2;
        public static string lblTitreDateReception; //"Date: ";
        public static string TextBox1;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_SommaireHeures
    {
        public static string Impression; //lblTitreDateDebut
        public static string lblTitreDateDebut; //lblDateDebut
        public static string lblDateDebut; //lblTitreDateFin
        public static string lblTitreDateFin; //lblDateFin
        public static string lblDateFin; //Label1
        public static string Label1; //lblTitreHeures
        public static string lblTitreHeures; //lblTitreSoumElec
        public static string lblTitreSoumElec; //lblSoumElec
        public static string lblSoumElec; //lblTitreSoumMec
        public static string lblTitreSoumMec; //lblSoumMec
        public static string lblSoumMec; //lblTitreVide0
        public static string lblTitreVide0; //lblVide0
        public static string lblVide0; //lblTitreTotalSoum
        public static string lblTitreTotalSoum; //lblTotalSoum
        public static string lblTotalSoum; //lblTitreVide1
        public static string lblTitreVide1; //lblVide1
        public static string lblVide1; //lblTitreProjGRBElec
        public static string lblTitreProjGRBElec; //lblProjGRBElec
        public static string lblProjGRBElec; //lblTitreProjGRBMec
        public static string lblTitreProjGRBMec; //lblProjGRBMec
        public static string lblProjGRBMec; //lblTitreVide2
        public static string lblTitreVide2; //lblVide2
        public static string lblVide2; //lblTitreTotalProjGRB
        public static string lblTitreTotalProjGRB; //lblTotalProjGRB
        public static string lblTotalProjGRB; //lblTitreVide3
        public static string lblTitreVide3; //lblVide3
        public static string lblVide3; //lblTitreProjElec
        public static string lblTitreProjElec; //lblProjElec
        public static string lblProjElec; //lblTitreProjMec
        public static string lblTitreProjMec; //lblProjMec
        public static string lblProjMec; //lblTitreVide4
        public static string lblTitreVide4; //lblVide4
        public static string lblVide4; //lblTitreTotalProj
        public static string lblTitreTotalProj; //lblTotalProj
        public static string lblTotalProj; //lblTitreVide5
        public static string lblTitreVide5; //lblVide5
        public static string lblVide5; //lblTitreFabElec
        public static string lblTitreFabElec; //lblFabElec
        public static string lblFabElec; //lblTitreFabMec
        public static string lblTitreFabMec; //lblFabMec
        public static string lblFabMec; //lblTitreVide6
        public static string lblTitreVide6; //lblVide6
        public static string lblVide6; //lblTitreTotalFab
        public static string lblTitreTotalFab; //lbTotalFab
        public static string lbTotalFab; //lblTitreVide7
        public static string lblTitreVide7; //lblVide7
        public static string lblVide7; //lblTitreRechElec
        public static string lblTitreRechElec; //lblRechElec
        public static string lblRechElec; //lblTitreRechMec
        public static string lblTitreRechMec; //lblRechMec
        public static string lblRechMec; //lblTitreVide8
        public static string lblTitreVide8; //lblVide8
        public static string lblVide8; //lblTitreTotalRech
        public static string lblTitreTotalRech; //lblTotalRech
        public static string lblTotalRech; //lblTitreVide9
        public static string lblTitreVide9; //lblVide9
        public static string lblVide9; //lblTitreAppelsElec
        public static string lblTitreAppelsElec; //lblAppelsElec
        public static string lblAppelsElec; //lblTitreAppelsMec
        public static string lblTitreAppelsMec; //lblAppelsMec
        public static string lblAppelsMec; //lblTitreVide10
        public static string lblTitreVide10; //lblVide10
        public static string lblVide10; //lblTitreTotalAppels
        public static string lblTitreTotalAppels; //lblTotalAppels
        public static string lblTotalAppels; //lblTitreVide11
        public static string lblTitreVide11; //lblVide11
        public static string lblVide11; //lblTitreGrandTotal
        public static string lblTitreGrandTotal; //lblGrandTotal
        public static string lblGrandTotal;
        public static string lblTotalFab;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_SommairePunchGRB
    {
        public static string EnTeteAdresse; //EnTeteTelFax.        
        public static string EnTeteTelFax; //Label15.        
        public static string Label15; //lblDateDebut.        
        public static string lblDateDebut; //Label17.        
        public static string Label17; //lblDateFin.        
        public static string lblDateFin; //Label3.        
        public static string Label3; //Label4.        
        public static string Label4; //Label2.        
        public static string Label2; //Label5.        
        public static string Label5; //Label6.        
        public static string Label6; //Label7.        
        public static string Label7; //Label9.        
        public static string Label9; //Label12.        
        public static string Label12; //txtNomJour.        
        public static string txtNomJour; //txtProjet.        
        public static string txtProjet; //Text1.        
        public static string Text1; //txtDescription.        
        public static string txtDescription; //txtJournee.        
        public static string txtJournee; //txtA.        
        public static string txtA; //txtTotal.        
        public static string txtTotal; //Text2.        
        public static string Text2; //GridView1.
        public static string Label0; //lblGrandTotal.        
        public static string lblGrandTotal; //Label13.        
        public static string Label13; //lblGrandTotalKM.        
        public static string lblGrandTotalKM; //Label8.        
        public static string Label8;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_SoumissionElec
    {
        public static string Button2; //Impression
        public static string Impression; //EnTeteLogo
        public static string EnTeteAdresse; //EnTeteTelFax
        public static string EnTeteTelFax; //lblTitre
        public static string lblTitre; //lblTitreProjet
        public static string lblTitreProjet; //lblProjet
        public static string lblProjet; //lblTitreSoumission
        public static string lblTitreSoumission; //lblSoumission
        public static string lblSoumission; //Label3
        public static string Label3; //lblDescription
        public static string lblDescription; //lblTitreClient
        public static string lblTitreClient; //lblClient
        public static string lblClient; //lblTitreFacture
        public static string lblTitreFacture; //lblFacture
        public static string lblFacture; //lblTitreContact
        public static string lblTitreContact; //lblContact
        public static string lblContact; //lblTitreQuantite
        public static string lblTitreQuantite; //lblTitreNoItem
        public static string lblTitreNoItem; //lblTitreDescription
        public static string lblTitreDescription; //lblTitreManufacturier
        public static string lblTitreManufacturier; //lblTitreCoutant
        public static string lblTitreCoutant; //lblTitreFournisseur
        public static string lblTitreFournisseur; //lblTitreTotal
        public static string lblTitreTotal; //lblTitreProfit
        public static string lblTitreProfit; //lbl_DateCommande
        public static string lbl_DateCommande; //lbl_DateReception
        public static string lbl_DateReception; //Text1
        public static string Text1; //Text2
        public static string Text2; //Text14
        public static string Text14; //Text3
        public static string Text3; //Text12
        public static string Text12; //Text4
        public static string Text4; //Text7
        public static string Text7; //Text8
        public static string Text8; //Text11
        public static string Text11; //Text13
        public static string Text13; //txt_DateCommande
        public static string txt_DateCommande; //txt_DateReception
        public static string txt_DateReception; //lblTitreTemps
        public static string lblTitreTemps; //lblTitreTauxHoraire
        public static string lblTitreTauxHoraire; //Label40
        public static string Label40; //lblTitreDessin
        public static string lblTitreDessin; //lblTauxDessin
        public static string lblTauxDessin; //lblTempsDessinSoum
        public static string lblTempsDessinSoum; //lblTempsDessinReel
        public static string lblTempsDessinReel; //lblHeure1
        public static string lblHeure1; //lblTitreFabrication
        public static string lblTitreFabrication; //lblTauxFabrication
        public static string lblTauxFabrication; //lblTempsFabrication
        public static string lblTempsFabrication; //lblTempsFabricationReel
        public static string lblTempsFabricationReel; //lblHeure2
        public static string lblHeure2; //lblTitreAssemblage
        public static string lblTitreAssemblage; //lblTauxAssemblage
        public static string lblTauxAssemblage; //lblTempsAssemblageSoum
        public static string lblTempsAssemblageSoum; //lblTempsAssemblageReel
        public static string lblTempsAssemblageReel; //lblHeure3
        public static string lblHeure3; //lblTitreProgInterface
        public static string lblTitreProgInterface; //lblTauxProgInterface
        public static string lblTauxProgInterface; //lblTempsProgInterfaceSoum
        public static string lblTempsProgInterfaceSoum; //Label21
        public static string Label21; //lblHeure4
        public static string lblHeure4; //lblTitreProgAutomate
        public static string lblTitreProgAutomate; //lblTauxProgAutomate
        public static string lblTauxProgAutomate; //lblTempsProgAutomateSoum
        public static string lblTempsProgAutomateSoum; //lblTempsProgAutomateReel
        public static string lblTempsProgAutomateReel; //lblHeure5
        public static string lblHeure5; //lblTitreProgRobot
        public static string lblTitreProgRobot; //lblTauxProgRobot
        public static string lblTauxProgRobot; //lblTempsProgRobotSoum
        public static string lblTempsProgRobotSoum; //lblTempsProgRobotReel
        public static string lblTempsProgRobotReel; //lblHeure6
        public static string lblHeure6; //lblTitreVision
        public static string lblTitreVision; //lblTauxVision
        public static string lblTauxVision; //lblTempsVisionSoum
        public static string lblTempsVisionSoum; //lblTempsVisionReel
        public static string lblTempsVisionReel; //lblHeure7
        public static string lblHeure7; //lblTitreTest
        public static string lblTitreTest; //lblTauxTest
        public static string lblTauxTest; //lblTempsTestSoum
        public static string lblTempsTestSoum; //lblTempsTestReel
        public static string lblTempsTestReel; //lblHeure8
        public static string lblHeure8; //lblTitreInstallation
        public static string lblTitreInstallation; //lblTauxInstallation
        public static string lblTauxInstallation; //lblTempsInstallationSoum
        public static string lblTempsInstallationSoum; //lblTempsInstallationReel
        public static string lblTempsInstallationReel; //lblHeure9
        public static string lblHeure9; //lblTitreMiseService
        public static string lblTitreMiseService; //lblTauxMiseService
        public static string lblTauxMiseService; //lblTempsMiseServiceSoum
        public static string lblTempsMiseServiceSoum; //lblTempsMiseServiceReel
        public static string lblTempsMiseServiceReel; //lblHeure11
        public static string lblHeure11; //lblTitreFormation
        public static string lblTitreFormation; //lblTauxFormation
        public static string lblTauxFormation; //lblTempsFormationSoum
        public static string lblTempsFormationSoum; //lblTempsFormationReel
        public static string lblTempsFormationReel; //lblHeure12
        public static string lblHeure12; //lblTitreGestion
        public static string lblTitreGestion; //lblTauxGestion
        public static string lblTauxGestion; //lblTempsGestionSoum
        public static string lblTempsGestionSoum; //lblTempsGestionReel
        public static string lblTempsGestionReel; //lblHeure13
        public static string lblHeure13; //lblTitreShipping
        public static string lblTitreShipping; //lblTauxShipping
        public static string lblTauxShipping; //lblTempsShippingSoum
        public static string lblTempsShippingSoum; //lblTempsShippingReel
        public static string lblTempsShippingReel; //lblHeure14
        public static string lblHeure14; //lblTotalTempsRHSoum
        public static string lblTotalTempsRHSoum; //lblTotalTempsRHReel
        public static string lblTotalTempsRHReel; //lblHeure10
        public static string lblHeure10; //lblTitreNbrePersonne
        public static string lblTitreNbrePersonne; //lblNbrePersonne
        public static string lblNbrePersonne; //lblTitreHebergement1
        public static string lblTitreHebergement1; //lblTauxHebergement1
        public static string lblTauxHebergement1; //lblTempsHebergement
        public static string lblTempsHebergement; //lblJour1
        public static string lblJour1; //Label1
        public static string Label1; //lblTauxHebergement2
        public static string lblTauxHebergement2; //lblTitreRepas
        public static string lblTitreRepas; //lblTauxRepas
        public static string lblTauxRepas; //lblTempsRepas
        public static string lblTempsRepas; //lblJour2
        public static string lblJour2; //lblTitreTransportDeplacement
        public static string lblTitreTransportDeplacement; //lblTauxTransport
        public static string lblTauxTransport; //lblTempsTransport
        public static string lblTempsTransport; //Label46
        public static string Label46; //lblTitreTransportUniteMobile
        public static string lblTitreTransportUniteMobile; //lblTauxUniteMobile
        public static string lblTauxUniteMobile; //lblTempsUniteMobile
        public static string lblTempsUniteMobile; //Label47
        public static string Label47; //lblTitreTransportEmballage
        public static string lblTitreTransportEmballage; //lblPrixEmballage
        public static string lblPrixEmballage; //Label4
        public static string Label4; //lblPrixManuel
        public static string lblPrixManuel; //lblTitreTotalPiece
        public static string lblTitreTotalPiece; //lblTotalPieceAR
        public static string lblTotalPieceAR; //lblTitreProfitGlobal
        public static string lblTitreProfitGlobal; //lblProfit
        public static string lblProfit; //lblTotalProfit
        public static string lblTotalProfit; //lblTitreImprevue
        public static string lblTitreImprevue; //lblImprevue
        public static string lblImprevue; //lblImprevueAR
        public static string lblImprevueAR; //lblTitreTotalTemps
        public static string lblTitreTotalTemps; //lblTotalTempsAR
        public static string lblTotalTempsAR; //lblTitreAutre
        public static string lblTitreAutre; //lblAutre
        public static string lblAutre; //lblTitreCommission
        public static string lblTitreCommission; //lblCommission
        public static string lblCommission; //lblcommissionAR
        public static string lblcommissionAR; //lblTitreGrandTotal
        public static string lblTitreGrandTotal; //lblGrandTotalAR
        public static string lblGrandTotalAR; //lblTitrePrixReception
        public static string lblTitrePrixReception; //lblTitrePrixSoumission
        public static string lblTitrePrixSoumission; //lblTitreForfait
        public static string lblTitreForfait; //lblPrixReception
        public static string lblPrixReception; //lblPrixSoumission
        public static string lblPrixSoumission; //lblForfait
        public static string lblForfait;
        public static bool shpCadrePrixReceptionVisible;
        public static bool lblTitrePrixReceptionVisible;
        public static bool lblPrixReceptionVisible;
        public static bool shpCadrePrixSoumissionVisible;
        public static bool lblTitrePrixSoumissionVisible;
        public static bool lblPrixSoumissionVisible;
        public static string lbldateCaption;
        public static dynamic lblSoumissionCaption;
        public static string lblProjetCaption;
        public static dynamic lbldescriptionCaption;
        public static dynamic lblclientCaption;
        public static dynamic lblTempsFabricationSoum;
        public static dynamic lblCommissionAR;
        public static bool shpCadreForfaitVisible;
        public static bool lblTitreForfaitVisible;
        public static bool lblForfaitVisible;
        public static string lblTitreForfaitCaption;
        public static bool lbl_DateCommandeVisible;
        public static bool lbl_DateReceptionVisible;
        public static bool txt_DateCommandeVisible;
        public static bool txt_DateReceptionVisible;
        public static string lblTempsProgInterfaceReel;
        public static bool lblTitreNoFactureVisible;
        public static bool lblNoFactureVisible;
        public static string lblNoFacture;
        public static string lblGrosTitre;
        public static string lblNoPage;
        public static Recordset DataSource;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
    }
    public  class DR_SoumissionMec
    {
        public static string EnTeteAdresse; //EnTeteTelFax.
        public static string EnTeteTelFax; //lblTitre.
        public static string lblTitre; //lblTitreProjet.
        public static string lblTitreProjet; //lblProjet.
        public static string lblProjet; //lblTitreSoumission.
        public static string lblTitreSoumission; //lblSoumission.
        public static string lblSoumission; //Label3.
        public static string Label3; //lblDescription.
        public static string lblDescription; //lblTitreClient.
        public static string lblTitreClient; //lblClient.
        public static string lblClient; //lblTitreFacture.
        public static string lblTitreFacture; //lblFacture.
        public static string lblFacture; //lblTitreContact.
        public static string lblTitreContact; //lblContact.
        public static string lblContact; //lblTitreQuantite.
        public static string lblTitreQuantite; //lblTitreNoItem.
        public static string lblTitreNoItem; //lblTitreDescription.
        public static string lblTitreDescription; //lblTitreManufacturier.
        public static string lblTitreManufacturier; //lblTitreCoutant.
        public static string lblTitreCoutant; //lblTitreFournisseur.
        public static string lblTitreFournisseur; //lblTitreTotal.
        public static string lblTitreTotal; //lblTitreProfit.
        public static string lblTitreProfit; //lbl_DateCommande.
        public static string lbl_DateCommande; //lbl_DateReception.
        public static string lbl_DateReception; //Text1.
        public static string Text1; //Text2.
        public static string Text2; //Text14.
        public static string Text14; //Text3.
        public static string Text3; //Text12.
        public static string Text12; //Text4.
        public static string Text4; //Text7.
        public static string Text7; //Text8.
        public static string Text8; //Text11.
        public static string Text11; //Text13.
        public static string Text13; //txt_DateCommande.
        public static string txt_DateCommande; //txt_DateReception.
        public static string txt_DateReception; //GridView1.; //lblTitreTemps.
        public static string lblTitreTemps; //lblTitreTauxHoraire.
        public static string lblTitreTauxHoraire; //Label40.
        public static string Label40; //lblTitreDessin.
        public static string lblTitreDessin; //lblTauxDessin.
        public static string lblTauxDessin; //lblTempsDessinSoum.
        public static string lblTempsDessinSoum; //lblTempsDessinReel.
        public static string lblTempsDessinReel; //lblHeure1.
        public static string lblHeure1; //lblTitreFabrication.
        public static string lblTitreFabrication; //lblTauxFabrication.
        public static string lblTauxFabrication; //lblTempsFabrication.
        public static string lblTempsFabrication; //lblTempsFabricationReel.
        public static string lblTempsFabricationReel; //lblHeure2.
        public static string lblHeure2; //lblTitreAssemblage.
        public static string lblTitreAssemblage; //lblTauxAssemblage.
        public static string lblTauxAssemblage; //lblTempsAssemblageSoum.
        public static string lblTempsAssemblageSoum; //lblTempsAssemblageReel.
        public static string lblTempsAssemblageReel; //lblHeure3.
        public static string lblHeure3; //lblTitreProgInterface.
        public static string lblTitreProgInterface; //lblTauxProgInterface.
        public static string lblTauxProgInterface; //lblTempsProgInterfaceSoum.
        public static string lblTempsProgInterfaceSoum; //Label21.
        public static string Label21; //lblHeure4.
        public static string lblHeure4; //lblTitreProgAutomate.
        public static string lblTitreProgAutomate; //lblTauxProgAutomate.
        public static string lblTauxProgAutomate; //lblTempsProgAutomateSoum.
        public static string lblTempsProgAutomateSoum; //lblTempsProgAutomateReel.
        public static string lblTempsProgAutomateReel; //lblHeure5.
        public static string lblHeure5; //lblTitreProgRobot.
        public static string lblTitreProgRobot; //lblTauxProgRobot.
        public static string lblTauxProgRobot; //lblTempsProgRobotSoum.
        public static string lblTempsProgRobotSoum; //lblTempsProgRobotReel.
        public static string lblTempsProgRobotReel; //lblHeure6.
        public static string lblHeure6; //lblTitreVision.
        public static string lblTitreVision; //lblTauxVision.
        public static string lblTauxVision; //lblTempsVisionSoum.
        public static string lblTempsVisionSoum; //lblTempsVisionReel.
        public static string lblTempsVisionReel; //lblHeure7.
        public static string lblHeure7; //lblTitreTest.
        public static string lblTitreTest; //lblTauxTest.
        public static string lblTauxTest; //lblTempsTestSoum.
        public static string lblTempsTestSoum; //lblTempsTestReel.
        public static string lblTempsTestReel; //lblHeure8.
        public static string lblHeure8; //lblTitreInstallation.
        public static string lblTitreInstallation; //lblTauxInstallation.
        public static string lblTauxInstallation; //lblTempsInstallationSoum.
        public static string lblTempsInstallationSoum; //lblTempsInstallationReel.
        public static string lblTempsInstallationReel; //lblHeure9.
        public static string lblHeure9; //lblTitreMiseService.
        public static string lblTitreMiseService; //lblTauxMiseService.
        public static string lblTauxMiseService; //lblTempsMiseServiceSoum.
        public static string lblTempsMiseServiceSoum; //lblTempsMiseServiceReel.
        public static string lblTempsMiseServiceReel; //lblHeure11.
        public static string lblHeure11; //lblTitreFormation.
        public static string lblTitreFormation; //lblTauxFormation.
        public static string lblTauxFormation; //lblTempsFormationSoum.
        public static string lblTempsFormationSoum; //lblTempsFormationReel.
        public static string lblTempsFormationReel; //lblHeure12.
        public static string lblHeure12; //lblTitreGestion.
        public static string lblTitreGestion; //lblTauxGestion.
        public static string lblTauxGestion; //lblTempsGestionSoum.
        public static string lblTempsGestionSoum; //lblTempsGestionReel.
        public static string lblTempsGestionReel; //lblHeure13.
        public static string lblHeure13; //lblTitreShipping.
        public static string lblTitreShipping; //lblTauxShipping.
        public static string lblTauxShipping; //lblTempsShippingSoum.
        public static string lblTempsShippingSoum; //lblTempsShippingReel.
        public static string lblTempsShippingReel; //lblHeure14.
        public static string lblHeure14; //lblTotalTempsRHSoum.
        public static string lblTotalTempsRHSoum; //lblTotalTempsRHReel.
        public static string lblTotalTempsRHReel; //lblHeure10.
        public static string lblHeure10; //lblTitreNbrePersonne.
        public static string lblTitreNbrePersonne; //lblNbrePersonne.
        public static string lblNbrePersonne; //lblTitreHebergement1.
        public static string lblTitreHebergement1; //lblTauxHebergement1.
        public static string lblTauxHebergement1; //lblTempsHebergement.
        public static string lblTempsHebergement; //lblJour1.
        public static string lblJour1; //Label1.
        public static string Label1; //lblTauxHebergement2.
        public static string lblTauxHebergement2; //lblTitreRepas.
        public static string lblTitreRepas; //lblTauxRepas.
        public static string lblTauxRepas; //lblTempsRepas.
        public static string lblTempsRepas; //lblJour2.
        public static string lblJour2; //lblTitreTransportDeplacement.
        public static string lblTitreTransportDeplacement; //lblTauxTransport.
        public static string lblTauxTransport; //lblTempsTransport.
        public static string lblTempsTransport; //Label46.
        public static string Label46; //lblTitreTransportUniteMobile.
        public static string lblTitreTransportUniteMobile; //lblTauxUniteMobile.
        public static string lblTauxUniteMobile; //lblTempsUniteMobile.
        public static string lblTempsUniteMobile; //Label47.
        public static string Label47; //lblTitreTransportEmballage.
        public static string lblTitreTransportEmballage; //lblPrixEmballage.
        public static string lblPrixEmballage; //Label4.
        public static string Label4; //lblPrixManuel.
        public static string lblPrixManuel; //lblTitreTotalPiece.
        public static string lblTitreTotalPiece; //lblTotalPieceAR.
        public static string lblTotalPieceAR; //lblTitreProfitGlobal.
        public static string lblTitreProfitGlobal; //lblProfit.
        public static string lblProfit; //lblTotalProfit.
        public static string lblTotalProfit; //lblTitreImprevue.
        public static string lblTitreImprevue; //lblImprevue.
        public static string lblImprevue; //lblImprevueAR.
        public static string lblImprevueAR; //lblTitreTotalTemps.
        public static string lblTitreTotalTemps; //lblTotalTempsAR.
        public static string lblTotalTempsAR; //lblTitreAutre.
        public static string lblTitreAutre; //lblAutre.
        public static string lblAutre; //lblTitreCommission.
        public static string lblTitreCommission; //lblCommission.
        public static string lblCommission; //lblcommissionAR.
        public static string lblcommissionAR; //lblTitreGrandTotal.
        public static string lblTitreGrandTotal; //lblGrandTotalAR.
        public static string lblGrandTotalAR; //lblTitrePrixReception.
        public static string lblTitrePrixReception; //lblTitrePrixSoumission.
        public static string lblTitrePrixSoumission; //lblTitreForfait.
        public static string lblTitreForfait; //lblPrixReception.
        public static string lblPrixReception; //lblPrixSoumission.
        public static string lblPrixSoumission; //lblForfait.
        public static string lblForfait; //Label8.
        public static string Label8;
        public static string lblTotalTempsRHConc;
        public static string lblTempsDessinConc;
        public static string lblTempsCoupeConc;
        public static string lblTempsMachinageConc;
        public static string lblTempsSoudureConc;
        public static string lblTempsAssemblageConc;
        public static string lblTempsPeintureConc;
        public static string lblTempsTestConc;
        public static string lblTempsInstallationConc;
        public static string lblTempsFormationConc;
        public static string lblTempsGestionConc;
        public static string lblTempsShippingConc;
        public static bool shpCadreForfaitVisible;
        public static bool lblTitreForfaitVisible;
        public static bool lblForfaitVisible;
        public static bool lbl_DateCommandeVisible;
        public static bool lbl_DateReceptionVisible;
        public static bool txt_DateCommandeVisible;
        public static bool txt_DateReceptionVisible;
        public static string lblTempsCoupeReel;
        public static string lblTempsMachinageReel;
        public static string lblTempsSoudureReel;
        public static string lblTempsPeintureReel;
        public static string lblGrosTitre;
        public static string lblTitreMachinage;
        public static string lblTitreCoupePreparation;
        public static string lblTitreAssemblageSoudure;
        public static string lblTitreAssemblageSysteme;
        public static string lblTitrePeintureFinition;
        public static string lblTitreTestFinal;
        public static string lblTitreConceptionDessin;
        public static string lblTitreHebergement2;
        public static string lblNoPage;
        public static bool shpCadrePrixReceptionVisible;
        public static bool lblTitrePrixReceptionVisible;
        public static bool lblPrixReceptionVisible;
        public static string lblTauxCoupe;
        public static string lbldate;
        public static bool lblNoFactureVisible;
        public static bool lblTitreNoFactureVisible;
        public static bool shpCadrePrixSoumissionVisible;
        public static bool lblTitrePrixSoumissionVisible;
        public static bool lblPrixSoumissionVisible;
        public static string lblNoFacture;
        public static string lblTauxMachinage;
        public static string lblTempsDessinProj;
        public static string lblTempsCoupeProj;
        public static string lblTempsMachinageProj;
        public static string lblTempsSoudureProj;
        public static string lblTempsAssemblageProj;
        public static string lblTempsPeintureProj;
        public static string lblTempsTestProj;
        public static string lblTempsInstallationProj;
        public static string lblTempsFormationProj;
        public static string lblTempsGestionProj;
        public static string lblTempsShippingProj;
        public static string lblTotalTempsRHProj;
        public static string lblTauxPeinture;
        public static string lblTauxSoudure;
        public static string lblTempsCoupeSoum;
        public static string lblTempsMachinageSoum;
        public static string lblTempsSoudureSoum;
        public static string lblTempsPeintureSoum;
        public static bool Orientation = !ControleurServeur.Program.isLandscape;
        public static string Text;
        public static Recordset DataSource;
        internal static string lblCommissionAR;
        internal static string lbldateCaption;
        internal static dynamic lbldescriptionCaption;
        internal static string lblProjetCaption;
        internal static dynamic lblTempsFabricationSoum;
        internal static string lblTempsProgInterfaceReel;
        internal static string lblTitreForfaitCaption;
    }
    public  class DR_TempsElec
    {
        public static string EnTeteAdresse; //EnTeteTelFax*/
        public static string EnTeteTelFax; //Label24*/
        public static string Label24; //lblNoProjet*/
        public static string lblNoProjet; //Label2*/
        public static string Label2; //Label23*/
        public static string Label23; //Label32*/
        public static string Label32; //Label4*/
        public static string Label4; //lblTempsDessinEstime*/
        public static string lblTempsDessinEstime; //lblTempsDessinReel*/
        public static string lblTempsDessinReel; //Label11*/
        public static string Label11; //Label5*/
        public static string Label5; //lblTempsFabricationEstime*/
        public static string lblTempsFabricationEstime; //lblTempsFabricationReel*/
        public static string lblTempsFabricationReel; //Label12*/
        public static string Label12; //Label6*/
        public static string Label6; //lblTempsAssemblageEstime*/
        public static string lblTempsAssemblageEstime; //lblTempsAssemblageReel*/
        public static string lblTempsAssemblageReel; //Label13*/
        public static string Label13; //Label7*/
        public static string Label7; //lblTempsProgInterfaceEstime*/
        public static string lblTempsProgInterfaceEstime; //lblTempsProgInterfaceReel*/
        public static string lblTempsProgInterfaceReel; //Label14*/
        public static string Label14; //Label8*/
        public static string Label8; //lblTempsProgAutomateEstime*/
        public static string lblTempsProgAutomateEstime; //lblTempsProgAutomateReel*/
        public static string lblTempsProgAutomateReel; //Label15*/
        public static string Label15; //Label9*/
        public static string Label9; //lblTempsProgRobotEstime*/
        public static string lblTempsProgRobotEstime; //lblTempsProgRobotReel*/
        public static string lblTempsProgRobotReel; //Label16*/
        public static string Label16; //Label33*/
        public static string Label33; //lblTempsVisionEstime*/
        public static string lblTempsVisionEstime; //lblTempsVisionReel*/
        public static string lblTempsVisionReel; //Label35*/
        public static string Label35; //Label37*/
        public static string Label37; //lblTempsTestEstime*/
        public static string lblTempsTestEstime; //lblTempsTestReel*/
        public static string lblTempsTestReel; //Label39*/
        public static string Label39; //Label41*/
        public static string Label41; //lblTempsInstallationEstime*/
        public static string lblTempsInstallationEstime; //lblTempsInstallationReel*/
        public static string lblTempsInstallationReel; //Label43*/
        public static string Label43; //Label45*/
        public static string Label45; //lblTempsMiseServiceEstime*/
        public static string lblTempsMiseServiceEstime; //lblTempsMiseServiceReel*/
        public static string lblTempsMiseServiceReel; //Label47*/
        public static string Label47; //Label1*/
        public static string Label1; //lblTempsFormationEstime*/
        public static string lblTempsFormationEstime; //lblTempsFormationReel*/
        public static string lblTempsFormationReel; //Label22*/
        public static string Label22; //Label49*/
        public static string Label49; //lblTempsGestionEstime*/
        public static string lblTempsGestionEstime; //lblTempsGestionReel*/
        public static string lblTempsGestionReel; //Label51*/
        public static string Label51; //Label25*/
        public static string Label25; //lblTempsShippingEstime*/
        public static string lblTempsShippingEstime; //lblTempsShippingReel*/
        public static string lblTempsShippingReel; //Label27*/
        public static string Label27; //Label26*/
        public static string Label26; //Label28*/
        public static string Label28; //lblTempsprototypeReel*/
        public static string lblTempsprototypeReel; //Label29*/
        public static string Label29; //lblTitreTotalTemps*/
        public static string lblTitreTotalTemps; //lblTotalTempsEstime*/
        public static string lblTotalTempsEstime; //lblTotalTempsReel*/
        public static string lblTotalTempsReel; //Label17*/
        public static string Label17; //Label3*/
        public static string Label3; //Label20*/
        public static string Label20; //Label10*/
        public static string Label10; //Label21*/
        public static string Label21; //Text1*/
        public static string Text1; //Text3*/
        public static string Text3; //Text2*/
        public static string Text2;
        public static Recordset DataSource;
    }
    public class DR_TempsMec
    {
        internal static string lblNoProjet;
        internal static string lblTempsDessinSoum;
        internal static string lblTempsCoupeSoum;
        internal static string lblTempsMachinageSoum;
        internal static string lblTempsSoudureSoum;
        internal static string lblTempsAssemblageSoum;
        internal static string lblTempsPeintureSoum;
        internal static string lblTempsTestSoum;
        internal static string lblTempsInstallationSoum;
        internal static string lblTempsFormationSoum;
        internal static string lblTempsGestionSoum;
        internal static string lblTempsShippingSoum;
        internal static string lblTempsDessinProj;
        internal static string lblTempsCoupeProj;
        internal static string lblTempsMachinageProj;
        internal static string lblTempsSoudureProj;
        internal static string lblTempsAssemblageProj;
        internal static string lblTempsPeintureProj;
        internal static string lblTempsTestProj;
        internal static string lblTempsInstallationProj;
        internal static string lblTempsFormationProj;
        internal static string lblTempsGestionProj;
        internal static string lblTempsShippingProj;
        internal static string lblTempsDessinConc;
        internal static string lblTempsCoupeConc;
        internal static string lblTempsMachinageConc;
        internal static string lblTempsSoudureConc;
        internal static string lblTempsAssemblageConc;
        internal static string lblTempsPeintureConc;
        internal static string lblTempsTestConc;
        internal static string lblTempsInstallationConc;
        internal static string lblTempsFormationConc;
        internal static string lblTempsGestionConc;
        internal static string lblTempsShippingConc;
        internal static string lblTotalTempsSoum;
        internal static string lblTotalTempsProj;
        internal static string lblTotalTempsConc;
        internal static string lblTempsDessinReel;
        internal static string lblTempsCoupeReel;
        internal static string lblTempsMachinageReel;
        internal static string lblTempsSoudureReel;
        internal static string lblTempsAssemblageReel;
        internal static string lblTempsPeintureReel;
        internal static string lblTempsTestReel;
        internal static string lblTempsInstallationReel;
        internal static string lblTempsFormationReel;
        internal static string lblTempsGestionReel;
        internal static string lblTempsShippingReel;
        internal static string lblTempsprototypeReel;
        internal static dynamic lblTempsPrototypeReel;
        internal static string lblTotalTempsReel;
        internal static string lblTitreRapport;
        internal static string Label24;
        internal static string TextBox1;
        internal static string lblTitreTemps;
        internal static string lblTempsSoum; //Soum.";
        internal static string lblTempsProj; //Proj.";
        internal static string lblTempsConc; //Conc.";
        internal static string lblTempsReel; //Reels";
        internal static string Label4; //Temps de dessin: ";
        internal static string lblTempsDessinEstime;
        internal static string TextBox2;
        internal static string TextBox58;
        internal static string TextBox59;
        internal static string Label11; //hrs";
        internal static string Label5; //Temps de fabrication: ";
        internal static string TextBox4;
        internal static string TextBox5;
        internal static string TextBox56;
        internal static string TextBox57;
        internal static string Label12; //hrs";
        internal static string Label6; //Temps d'assemblage: ";
        internal static string TextBox6;
        internal static string TextBox7;
        internal static string TextBox54;
        internal static string TextBox55;
        internal static string Label13; //hrs";
        internal static string Label7; //Temps de programmation d'interface: ";
        internal static string TextBox8;
        internal static string TextBox9;
        internal static string TextBox52;
        internal static string TextBox53;
        internal static string Label14; //hrs";
        internal static string Label8; //Temps de programmation d'automate: ";
        internal static string TextBox3;
        internal static string TextBox10;
        internal static string TextBox50;
        internal static string TextBox51;
        internal static string Label15; //hrs";
        internal static string Label9; //Temps de programmation de robot: ";
        internal static string TextBox99;
        internal static string TextBox49;
        internal static string TextBox11;
        internal static string TextBox48;
        internal static string Label16; //hrs";
        internal static string Label33; //Temps de vision: ";
        internal static string TextBox12;
        internal static string TextBox13;
        internal static string TextBox46;
        internal static string TextBox47;
        internal static string Label35; //hrs";
        internal static string Label37; //Temps de test: ";
        internal static string TextBox14;
        internal static string TextBox15;
        internal static string TextBox44;
        internal static string TextBox45;
        internal static string Label39; //hrs";
        internal static string Label41; //Temps d'installation: ";
        internal static string TextBox16;
        internal static string TextBox17;
        internal static string TextBox42;
        internal static string TextBox43;
        internal static string Label43; //hrs";
        internal static string Label45; //Temps de mise en service: ";
        internal static string TextBox18;
        internal static string TextBox19;
        internal static string TextBox40;
        internal static string TextBox41;
        internal static string Label47; //hrs";
        internal static string Label1; //Temps de formation du personnel: ";
        internal static string TextBox20;
        internal static string TextBox21;
        internal static string TextBox38;
        internal static string TextBox39;
        internal static string Label22; //hrs";
        internal static string Label49; //Temps de gestion de projet: ";
        internal static string TextBox22;
        internal static string TextBox23;
        internal static string TextBox36;
        internal static string TextBox37;
        internal static string Label51; //hrs";
        internal static string Label25; //Temps d'expedition: ";
        internal static string TextBox24;
        internal static string TextBox25;
        internal static string TextBox34;
        internal static string TextBox35;
        internal static string Label27; //hrs";
        internal static string Label26; //Prototypage: ";
        internal static string TextBox32;
        internal static string TextBox33;
        internal static string TextBox26;
        internal static string TextBox27;
        internal static string Label29; //hrs";
        internal static string lblTitreTotalTemps; //Total: ";
        internal static string TextBox28;
        internal static string TextBox29;
        internal static string TextBox30;
        internal static string TextBox31;
        internal static string Label17; //hrs";
        internal static string Label3; //Temps reels";
        internal static string Label20; //Nom de l'employe"
        internal static string Label10; //Type"
        internal static string Label21; //Heure"
        internal static string Text1; //Employe"
        internal static string Text3; //Type"
        internal static string Text2; //TotalHeures"
        internal static string Label19; //%D";
        internal static string Label18; //Page %p de %P";
        internal static Recordset DataSource;
    }
    internal class Utilisateurs
    {
        internal int NOEMPLOYE;
        internal string LOGINNAME;
        internal string EMPLOYE;
        public Utilisateurs()
        {
        }
        public Utilisateurs(int nOEMPLOYE, string lOGINNAME, string eMPLOYE)
        {
            NOEMPLOYE = nOEMPLOYE;
            LOGINNAME = lOGINNAME;
            EMPLOYE = eMPLOYE;
        }
    }
    internal class UtilisateurActifs : Utilisateurs
    {
        internal string INITIALE;
        internal string TEL;
        internal string PAGE;
        internal string CELL;
        internal bool ACTIF;
        internal int GROUPE;
        internal int FAMILLE;
        internal bool SUPPRIMÉ;
        internal int IDGroupe;
        internal string NomGroupe;
        internal bool Clients;
        internal bool Fournisseurs;
        internal bool Contacts;
        internal bool ContactsVendeurs;
        internal bool Rapport;
        internal bool CatalogueMec;
        internal bool CatalogueElec;
        internal bool Employes;
        internal bool Cedule;
        internal bool Configuration;
        internal bool Punch;
        internal bool Outils;
        internal bool SoumissionMec;
        internal bool ProjetMec;
        internal bool SoumissionElec;
        internal bool ProjetElec;
        internal bool InventaireMec;
        internal bool InventaireElec;
        internal bool ACHAT;
        internal bool ModificationFacturation;
        internal bool ModificationClients;
        internal bool ModificationFournisseurs;
        internal bool ModificationContacts;
        internal bool ModificationGroupes;
        internal bool ModificationEmployes;
        internal bool ModificationFeuillesTemps;
        internal bool ModificationOutils;
        internal bool ModificationSoumissionsMec;
        internal bool ModificationProjetsMec;
        internal bool ModificationSoumissionsElec;
        internal bool ModificationProjetsElec;
        internal bool ModificationBonsCommandes;
        internal bool ModificationCatalogueElec;
        internal bool ModificationCatalogueMec;
        internal bool ModificationInventaireMec;
        internal bool ModificationInventaireElec;
        internal bool ModificationPunchEmployes;
        internal bool ModificationReception;
        internal bool ModificationRetourMarchandise;
        internal bool SuppressionProjets;
        internal bool ListeDistribution;
        internal bool PunchSemaineAntérieure;
        internal bool VerrouillageTempsProjet;
        internal bool DéverrouillageTempsProjet;
        public UtilisateurActifs()
        {
        }
        public UtilisateurActifs(int nOEMPLOYE, string lOGINNAME, string eMPLOYE, string iNITIALE, string tEL, string pAGE, string cELL, bool aCTIF, 
            int gROUPE, int fAMILLE, bool sUPPRIMÉ, int iDGroupe, string nomGroupe, bool clients, bool fournisseurs, bool contacts, bool contactsVendeurs, 
            bool rapport, bool catalogueMec, bool catalogueElec, bool employes, bool cedule, bool configuration, bool punch, bool outils, bool soumissionMec, 
            bool projetMec, bool soumissionElec, bool projetElec, bool inventaireMec, bool inventaireElec, bool ACHAT, bool modificationFacturation, 
            bool modificationClients, bool modificationFournisseurs, bool modificationContacts, bool modificationGroupes, bool modificationEmployes, 
            bool modificationFeuillesTemps, bool modificationOutils, bool modificationSoumissionsMec, bool modificationProjetsMec, 
            bool modificationSoumissionsElec, bool modificationProjetsElec, bool modificationBonsCommandes, bool modificationCatalogueElec, 
            bool modificationCatalogueMec, bool modificationInventaireMec, bool modificationInventaireElec, bool modificationPunchEmployes,
            bool modificationReception, bool modificationRetourMarchandise, bool suppressionProjets, bool listeDistribution, bool punchSemaineAntérieure, 
            bool verrouillageTempsProjet, bool déverrouillageTempsProjet) : base(nOEMPLOYE, lOGINNAME, eMPLOYE)
        {
            INITIALE = iNITIALE;
            TEL = tEL;
            PAGE = pAGE;
            CELL = cELL;
            ACTIF = aCTIF;
            GROUPE = gROUPE;
            FAMILLE = fAMILLE;
            SUPPRIMÉ = sUPPRIMÉ;
            IDGroupe = iDGroupe;
            NomGroupe = nomGroupe;
            Clients = clients;
            Fournisseurs = fournisseurs;
            Contacts = contacts;
            ContactsVendeurs = contactsVendeurs;
            Rapport = rapport;
            CatalogueMec = catalogueMec;
            CatalogueElec = catalogueElec;
            Employes = employes;
            Cedule = cedule;
            Configuration = configuration;
            Punch = punch;
            Outils = outils;
            SoumissionMec = soumissionMec;
            ProjetMec = projetMec;
            SoumissionElec = soumissionElec;
            ProjetElec = projetElec;
            InventaireMec = inventaireMec;
            InventaireElec = inventaireElec;
            ACHAT = ACHAT;
            ModificationFacturation = modificationFacturation;
            ModificationClients = modificationClients;
            ModificationFournisseurs = modificationFournisseurs;
            ModificationContacts = modificationContacts;
            ModificationGroupes = modificationGroupes;
            ModificationEmployes = modificationEmployes;
            ModificationFeuillesTemps = modificationFeuillesTemps;
            ModificationOutils = modificationOutils;
            ModificationSoumissionsMec = modificationSoumissionsMec;
            ModificationProjetsMec = modificationProjetsMec;
            ModificationSoumissionsElec = modificationSoumissionsElec;
            ModificationProjetsElec = modificationProjetsElec;
            ModificationBonsCommandes = modificationBonsCommandes;
            ModificationCatalogueElec = modificationCatalogueElec;
            ModificationCatalogueMec = modificationCatalogueMec;
            ModificationInventaireMec = modificationInventaireMec;
            ModificationInventaireElec = modificationInventaireElec;
            ModificationPunchEmployes = modificationPunchEmployes;
            ModificationReception = modificationReception;
            ModificationRetourMarchandise = modificationRetourMarchandise;
            SuppressionProjets = suppressionProjets;
            ListeDistribution = listeDistribution;
            PunchSemaineAntérieure = punchSemaineAntérieure;
            VerrouillageTempsProjet = verrouillageTempsProjet;
            DéverrouillageTempsProjet = déverrouillageTempsProjet;
        }
    }
    internal class WebUtilisateurActifs : Utilisateurs
    {
        internal bool BUGS;
        internal bool GRB;
        internal bool Perma;
        internal bool Reservations;
        private bool value1;
        private bool value2;
        private bool value3;
        private bool value4;
        public WebUtilisateurActifs()
        {
        }
        public WebUtilisateurActifs(bool bUGS, bool gRB, bool perma, bool reservations)
        {
            BUGS = bUGS;
            GRB = gRB;
            Perma = perma;
            Reservations = reservations;
        }
        public WebUtilisateurActifs(int nOEMPLOYE, string lOGINNAME, string eMPLOYE, bool value1, bool value2, bool value3, bool value4) : base(nOEMPLOYE, lOGINNAME, eMPLOYE)
        {
            value1 = value1;
            value2 = value2;
            value3 = value3;
            value4 = value4;
        }
    }
    public class GestionnaireUtilisateur
    {
        protected ContexteAppli _context;
        GestionnaireUtilisateur(ContexteAppli context) => _context = context;
        public GestionnaireUtilisateur()
        {
        }
        public Utilisateur Create(Utilisateur utilisateur)
        {
            _context.Add(utilisateur);
            _context.SaveChanges();
            return utilisateur;
        }
        public List<Utilisateur> ReadAll() => _context.Utilisateurs.ToList();
        public Utilisateur Read(int id) => _context.Utilisateurs.Find(id);
        public Utilisateur Update(Utilisateur utilisateur)
        {
            Utilisateur existingUtilisateur = _context.Utilisateurs.Find(utilisateur.ID);
            if (existingUtilisateur != null)
            {
                existingUtilisateur = utilisateur;
                _context.SaveChanges();
            }
            return existingUtilisateur;
        }
        public void Delete(int id)
        {
            Utilisateur utilisateur = Read(id);
            if (utilisateur != null) { _context.Remove(utilisateur); _context.SaveChanges(); }
        }
        public Utilisateur GetByUserName(string userName) => _context.Utilisateurs.Where(u => u.UserName == userName).FirstOrDefault();
    }
    public class GestionnaireBuisnessAPI
    {
        public string Devise;
        public double Montant;
        public string SourceCarte;
        public string Description;
        public readonly string ApiKey = "sk_test_4eC39HqLyjWDarjtT1zdp7dc";
        private ChargeCreateOptions options = new ChargeCreateOptions();
        private ChargeService service = new ChargeService();
        public GestionnaireBuisnessAPI() { }
        public GestionnaireBuisnessAPI(ChargeService service) => service = service;
        public GestionnaireBuisnessAPI(ChargeCreateOptions options) => options = options;
        public GestionnaireBuisnessAPI(ChargeCreateOptions options, ChargeService service)
        {
            options = options;
            service = service;
        }
        public GestionnaireBuisnessAPI(double Montant, string Devise, string SourceCarte, string Description)
        {
            var service = new ChargeService();
            object value = service.Create(options);
        }
        public GestionnaireBuisnessAPI(double montant, string sourceCarte)
        {
            ActiverEBuisnessKey();
            Montant = montant;
            SourceCarte = sourceCarte;
            Devise = "cad";
            SetChargeOptions();
        }
        public GestionnaireBuisnessAPI(string devise, double montant, string sourceCarte, string description)
        {
            Devise = devise ?? throw new ArgumentNullException(nameof(devise));
            Montant = montant;
            SourceCarte = sourceCarte ?? throw new ArgumentNullException(nameof(sourceCarte));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
        private void ActiverEBuisnessKey() => StripeConfiguration.ApiKey = ApiKey;
        public void SetChargeOptions()
        {
            options.Description = Description;
            options.Amount = (long)Montant;
            options.Currency = "cad";
            options.Source = "visa";
        }
        public void SetChargeOptions(string devise, double montant, string sourceCarte, string description)
        {
            options.Description = Description;
            options.Amount = (long)Montant;
            options.Currency = Devise;
            options.Source = SourceCarte;
        }
        public Charge CreateCharge(double montant, string sourceCarte, string Description)
        {
            var options = new ChargeCreateOptions { Amount = (long)montant, Currency = "cad", Source = sourceCarte, Description = Description };
            var service = new ChargeService();
            return service.Create(options);
        }
        public bool CreateCharge(double montant, string sourceCarte)
        {
            var options = new ChargeCreateOptions { Amount = (long)montant, Currency = "cad", Source = sourceCarte, Description = Description };
            var service = new ChargeService();
            return service.Create(options).Paid;
        }
        public bool PayementValide(Charge charge) => charge.Paid;
        public override string ToString() => ApiKey;
    }
    public class GDI32
    {
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFontIndirect([In, MarshalAs(UnmanagedType.LPStruct)] LOGFONT lplf);
        public static Font CreerPolice(string NomPolice,int Taille, byte Qualité)
        {
            LOGFONT lf = new LOGFONT();
            lf.lfFaceName = NomPolice;
            lf.lfHeight = Taille;
            lf.lfQuality = Qualité;
            IntPtr handle = CreateFontIndirect(lf);
            return Font.FromLogFont(lf);
        }
    }
    public class DB_AchatPiece
    {
        public int NoEnreg;
        public string Idachat;
        public int IndexAchat;
        public string Piece;
        public int NumeroLigne;
        public string Qte;
        public string DescFr;
        public string DescEn;
        public string Manufact;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public int Idfrs;
        public string PrixTotal;
        public string Type;
        public bool Commande;
        public bool Retour;
        public string NoRetour;
        public bool Recu;
        public string DateReception;
        public string QuantiteRecue;
        public string DateCommande;
        public string DateRequise;
        public bool Inutile;
        public bool CommandeAnnulee;
        public string DateRetour;
        public string PrixOrigine;
        public string Devise;
        public DB_AchatPiece()
        {
        }
        public DB_AchatPiece(int noEnreg, string idachat, int indexAchat, string piece, int numeroLigne, string qte, string descFr, string descEn,
            string manufact, string prixList, string escompte, string prixNet, int idfrs, string prixTotal, string type, bool commande, bool retour,
            string noRetour, bool recu, string dateReception, string quantiteRecue, string dateCommande, string dateRequise, bool inutile, bool commandeAnnulee,
            string dateRetour, string prixOrigine, string devise)
        {
            NoEnreg = noEnreg;
            Idachat = idachat;
            IndexAchat = indexAchat;
            Piece = piece;
            NumeroLigne = numeroLigne;
            Qte = qte;
            DescFr = descFr;
            DescEn = descEn;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Idfrs = idfrs;
            PrixTotal = prixTotal;
            Type = type;
            Commande = commande;
            Retour = retour;
            NoRetour = noRetour;
            Recu = recu;
            DateReception = dateReception;
            QuantiteRecue = quantiteRecue;
            DateCommande = dateCommande;
            DateRequise = dateRequise;
            Inutile = inutile;
            CommandeAnnulee = commandeAnnulee;
            DateRetour = dateRetour;
            PrixOrigine = prixOrigine;
            Devise = devise;
        }
    }
    public class DB_AchatPiecesTampon
    {
        public int NoEnreg;
        public string DateCopie;
        public string Initiales;
        public string Idachat;
        public int IndexAchat;
        public string Piece;
        public int NumeroLigne;
        public string Qte;
        public string DescFr;
        public string DescEn;
        public string Manufact;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public int Idfrs;
        public string PrixTotal;
        public string Type;
        public bool Commande;
        public bool Retour;
        public string NoRetour;
        public bool Recu;
        public string DateReception;
        public string QuantiteRecue;
        public string DateCommande;
        public string DateRequise;
        public bool Inutile;
        public bool CommandeAnnulee;
        public string DateRetour;
        public string PrixOrigine;
        public string Devise;
        public DB_AchatPiecesTampon() { }
        public DB_AchatPiecesTampon(int noEnreg, string dateCopie, string initiales, string idachat, int indexAchat, string piece, int numeroLigne, string qte,
            string descFr, string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string prixTotal, string type,
            bool commande, bool retour, string noRetour, bool recu, string dateReception, string quantiteRecue, string dateCommande, string dateRequise,
            bool inutile, bool commandeAnnulee, string dateRetour, string prixOrigine, string devise)
        {
            NoEnreg = noEnreg;
            DateCopie = dateCopie;
            Initiales = initiales;
            Idachat = idachat;
            IndexAchat = indexAchat;
            Piece = piece;
            NumeroLigne = numeroLigne;
            Qte = qte;
            DescFr = descFr;
            DescEn = descEn;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Idfrs = idfrs;
            PrixTotal = prixTotal;
            Type = type;
            Commande = commande;
            Retour = retour;
            NoRetour = noRetour;
            Recu = recu;
            DateReception = dateReception;
            QuantiteRecue = quantiteRecue;
            DateCommande = dateCommande;
            DateRequise = dateRequise;
            Inutile = inutile;
            CommandeAnnulee = commandeAnnulee;
            DateRetour = dateRetour;
            PrixOrigine = prixOrigine;
            Devise = devise;
        }
    }
    public class DB_Achats
    {
        public string Idachat;
        public int IndexAchat;
        public string Raison;
        public string DateAchat;
        public int Acheteur;
        public string PrixTotal;
        public string Type;
        public bool Modification;
        public string Par;
        public DB_Achats() { }
        public DB_Achats(string idachat, int indexAchat, string raison, string dateAchat, int acheteur, string prixTotal, string type, bool modification,
            string par)
        {
            Idachat = idachat;
            IndexAchat = indexAchat;
            Raison = raison;
            DateAchat = dateAchat;
            Acheteur = acheteur;
            PrixTotal = prixTotal;
            Type = type;
            Modification = modification;
            Par = par;
        }
    }
    public class DB_Alarme
    {
        public int Idalarme;
        public string Initiale;
        public int Idcedule;
        public string Type;
        public string Date;
        public string Heure;
        public string Message;
        public int JourSemaine;
        public int NoEmploye;
        public string TypeCedule;
        public DB_Alarme() { }
        public DB_Alarme(int idalarme, string initiale, int idcedule, string type, string date, string heure, string message, int jourSemaine, int noEmploye,
            string typeCedule)
        {
            Idalarme = idalarme;
            Initiale = initiale;
            Idcedule = idcedule;
            Type = type;
            Date = date;
            Heure = heure;
            Message = message;
            JourSemaine = jourSemaine;
            NoEmploye = noEmploye;
            TypeCedule = typeCedule;
        }
    }
    public class DB_AutorisationPunch
    {
        public int Idautorisation;
        public int NoEmploye;
        public int AutoriserPar;
        public DB_AutorisationPunch() { }
        public DB_AutorisationPunch(int idautorisation, int noEmploye, int autoriserPar)
        {
            Idautorisation = idautorisation;
            NoEmploye = noEmploye;
            AutoriserPar = autoriserPar;
        }
        public override string ToString() => Idautorisation.ToString();
    }
    public class DB_BavardSuppression
    {
        public int NoBavard;
        public int Iduser;
        public string NoProjSoum;
        public string Type;
        public string Qte;
        public string NoItem;
        public string Date;
        public string Heure;
        public DB_BavardSuppression() { }
        public DB_BavardSuppression(int noBavard, int iduser, string noProjSoum, string type, string qte, string noItem, string date, string heure)
        {
            NoBavard = noBavard;
            Iduser = iduser;
            NoProjSoum = noProjSoum;
            Type = type;
            Qte = qte;
            NoItem = noItem;
            Date = date;
            Heure = heure;
        }
        public override string ToString() => Iduser.ToString();
    }
    public class DB_BonsCommandesCommande
    {
        public string NoBonCommande;
        public int? NoFournisseur;
        public string NoProjet;
        public string Attention;
        public string Transport;
        public string DateRequise;
        public string VotreNoSoum;
        public string DateCommande;
        public string CommandePar;
        public string Total;
        public string Commentaire;
        public bool? AffichageInstructions;
        public string LangueImpression;
        public string Type;
        public DB_BonsCommandesCommande() { }
        public DB_BonsCommandesCommande(string noBonCommande, int? noFournisseur, string noProjet, string attention, string transport, string dateRequise,
            string votreNoSoum, string dateCommande, string commandePar, string total, string commentaire, bool? affichageInstructions,
            string langueImpression, string type)
        {
            NoBonCommande = noBonCommande;
            NoFournisseur = noFournisseur;
            NoProjet = noProjet;
            Attention = attention;
            Transport = transport;
            DateRequise = dateRequise;
            VotreNoSoum = votreNoSoum;
            DateCommande = dateCommande;
            CommandePar = commandePar;
            Total = total;
            Commentaire = commentaire;
            AffichageInstructions = affichageInstructions;
            LangueImpression = langueImpression;
            Type = type;
        }
    }
    public class DB_BonsCommandesPiece
    {
        public string NoBonCommande;
        public int NoFournisseur;
        public string Qte;
        public string NoItem;
        public string Description;
        public string Manufact;
        public string Prix;
        public string Escompte;
        public string Total;
        public string Type;
        public string NumeroLigne;
        public DB_BonsCommandesPiece() { }
        public DB_BonsCommandesPiece(string noBonCommande, int noFournisseur, string qte, string noItem, string description, string manufact, string prix,
            string escompte, string total, string type, string numeroLigne)
        {
            NoBonCommande = noBonCommande;
            NoFournisseur = noFournisseur;
            Qte = qte;
            NoItem = noItem;
            Description = description;
            Manufact = manufact;
            Prix = prix;
            Escompte = escompte;
            Total = total;
            Type = type;
            NumeroLigne = numeroLigne;
        }
    }
    public class DB_CatalogueElec
    {
        public string PieceGrb;
        public string Piece;
        public string PieceModif;
        public string DescFr;
        public string DescEn;
        public string Fabricant;
        public string Commentaire;
        public string Temps;
        public string Categorie;
        public string Dessin;
        public DB_CatalogueElec() { }
        public DB_CatalogueElec(string pieceGrb, string piece, string pieceModif, string descFr, string descEn, string fabricant, string commentaire,
            string temps, string categorie, string dessin)
        {
            PieceGrb = pieceGrb;
            Piece = piece;
            PieceModif = pieceModif;
            DescFr = descFr;
            DescEn = descEn;
            Fabricant = fabricant;
            Commentaire = commentaire;
            Temps = temps;
            Categorie = categorie;
            Dessin = dessin;
        }
    }
    public class DB_CatalogueMec
    {
        public string PieceGrb;
        public string Piece;
        public string PieceModif;
        public string DescFr;
        public string DescEn;
        public string Fabricant;
        public string Commentaire;
        public string Categorie;
        public DB_CatalogueMec() { }
        public DB_CatalogueMec(string pieceGrb, string piece, string pieceModif, string descFr, string descEn, string fabricant, string commentaire, string categorie)
        {
            PieceGrb = pieceGrb;
            Piece = piece;
            PieceModif = pieceModif;
            DescFr = descFr;
            DescEn = descEn;
            Fabricant = fabricant;
            Commentaire = commentaire;
            Categorie = categorie;
        }
    }
    public class DB_Cedule
    {
        public int Noenreg;
        public string Initiale;
        public string DateCedule;
        public string HeureDebut;
        public string HeureFin;
        public string Client;
        public int Joursemaine;
        public string Transport;
        public int Finprojet;
        public bool Alarme;
        public DB_Cedule() { }
        public DB_Cedule(int noenreg, string initiale, string dateCedule, string heureDebut, string heureFin, string client, int joursemaine,
            string transport, int finprojet, bool alarme)
        {
            Noenreg = noenreg;
            Initiale = initiale;
            DateCedule = dateCedule;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            Client = client;
            Joursemaine = joursemaine;
            Transport = transport;
            Finprojet = finprojet;
            Alarme = alarme;
        }
    }
    public class DB_Client
    {
        public int Idclient;
        public string NomClient;
        public string Compagnie;
        public string Telephonne;
        public string Fax;
        public string Pagette;
        public string Cellulaire;
        public string ContactGrb;
        public string Email;
        public string AdresseLiv;
        public string VilleLiv;
        public string ProvEtatLiv;
        public string PaysLiv;
        public string CodePostalLiv;
        public string Noposte;
        public string Commentaire;
        public string SiteWeb;
        public string DateCreation;
        public string UserCreation;
        public string DateModification;
        public string UserModification;
        public string EntryIdoutlook;
        public bool Beton;
        public bool Pave;
        public bool Pharmaceutique;
        public bool Agroalimentaire;
        public bool Meuble;
        public bool Meunerie;
        public bool Manufacturier;
        public bool Autre;
        public bool Consultant;
        public bool Asphalte;
        public bool Icpi;
        public bool Potentiel;
        public bool ProduitsChimiques;
        public bool Supprime;
        public string NomContact;
        public DB_Client() { }
        public DB_Client(int idclient, string nomClient, string compagnie, string telephonne, string fax, string pagette, string cellulaire,
            string contactGrb, string email, string adresseLiv, string villeLiv, string provEtatLiv, string paysLiv, string codePostalLiv,
            string noposte, string commentaire, string siteWeb, string dateCreation, string userCreation, string dateModification,
            string userModification, string entryIdoutlook, bool beton, bool pave, bool pharmaceutique, bool agroalimentaire, bool meuble,
            bool meunerie, bool manufacturier, bool autre, bool consultant, bool asphalte, bool icpi, bool potentiel, bool produitsChimiques,
            bool supprime, string nomContact)
        {
            Idclient = idclient;
            NomClient = nomClient;
            Compagnie = compagnie;
            Telephonne = telephonne;
            Fax = fax;
            Pagette = pagette;
            Cellulaire = cellulaire;
            ContactGrb = contactGrb;
            Email = email;
            AdresseLiv = adresseLiv;
            VilleLiv = villeLiv;
            ProvEtatLiv = provEtatLiv;
            PaysLiv = paysLiv;
            CodePostalLiv = codePostalLiv;
            Noposte = noposte;
            Commentaire = commentaire;
            SiteWeb = siteWeb;
            DateCreation = dateCreation;
            UserCreation = userCreation;
            DateModification = dateModification;
            UserModification = userModification;
            EntryIdoutlook = entryIdoutlook;
            Beton = beton;
            Pave = pave;
            Pharmaceutique = pharmaceutique;
            Agroalimentaire = agroalimentaire;
            Meuble = meuble;
            Meunerie = meunerie;
            Manufacturier = manufacturier;
            Autre = autre;
            Consultant = consultant;
            Asphalte = asphalte;
            Icpi = icpi;
            Potentiel = potentiel;
            ProduitsChimiques = produitsChimiques;
            Supprime = supprime;
            NomContact = nomContact;
        }
    }
    public class DB_Commentaire
    {
        public int Id;
        public string NoProjSoum;
        public int Index;
        public string Commentaires;
        public bool Section;
        public bool SousSection;
        public string Key;
        public string Relative;
        public DB_Commentaire() { }
        public DB_Commentaire(int id, string noProjSoum, int index, string commentaires, bool section, bool sousSection, string key, string relative)
        {
            Id = id;
            NoProjSoum = noProjSoum;
            Index = index;
            Commentaires = commentaires;
            Section = section;
            SousSection = sousSection;
            Key = key;
            Relative = relative;
        }
    }
    public class DB_Config
    {
        public string ProfitElec;
        public string ProfitMec;
        public string Commission;
        public string Imprevus;
        public string PrixPagesManuel;
        public string IndiceDessin;
        public string TauxAmericain;
        public string TauxEspagnol;
        public string TauxDessinElec;
        public string TauxProgInterface;
        public string TauxAssemblageElec;
        public string TauxFabrication;
        public string TauxTestElec;
        public string TauxVision;
        public string TauxProgAutomate;
        public string TauxProgRobot;
        public string TauxGestionProjetsElec;
        public string TauxInstallationElec;
        public string TauxFormationElec;
        public string TauxMiseService;
        public string TauxShippingElec;
        public string LeGrand;
        public string Lamine;
        public string Thermo;
        public string _4em;
        public string FsDixMoins;
        public string FsDix;
        public string FsQuinze;
        public string FsVingt;
        public string FsVingtCinq;
        public string FsCinquante;
        public string FsCent;
        public string ParcelLabelLine1;
        public string ParcelLabelLine2;
        public string ParcelLabelLine3;
        public string ParcelAssist;
        public string ParcelEtat;
        public string Hebergement1;
        public string Hebergement2;
        public string Repas;
        public string Standard;
        public string UniteMobile;
        public string CheminSee4000;
        public string TauxMachinage;
        public string TauxCoupe;
        public string TauxSoudure;
        public string TauxAssemblageMec;
        public string TauxPeinture;
        public string TauxTestMec;
        public string TauxDessinMec;
        public string TauxFormationMec;
        public string TauxInstallationMec;
        public string TauxGestionProjetsMec;
        public string TauxShippingMec;
        public string DerniereVersion;
        public DB_Config() { }
        public DB_Config(string profitElec, string profitMec, string commission, string imprevus, string prixPagesManuel,
            string indiceDessin, string tauxAmericain, string tauxEspagnol, string tauxDessinElec, string tauxProgInterface,
            string tauxAssemblageElec, string tauxFabrication, string tauxTestElec, string tauxVision, string tauxProgAutomate,
            string tauxProgRobot, string tauxGestionProjetsElec, string tauxInstallationElec, string tauxFormationElec,
            string tauxMiseService, string tauxShippingElec, string leGrand, string lamine, string thermo, string _4em,
            string fsDixMoins, string fsDix, string fsQuinze, string fsVingt, string fsVingtCinq, string fsCinquante, string fsCent,
            string parcelLabelLine1, string parcelLabelLine2, string parcelLabelLine3, string parcelAssist, string parcelEtat,
            string hebergement1, string hebergement2, string repas, string standard, string uniteMobile, string cheminSee4000,
            string tauxMachinage, string tauxCoupe, string tauxSoudure, string tauxAssemblageMec, string tauxPeinture,
            string tauxTestMec, string tauxDessinMec, string tauxFormationMec, string tauxInstallationMec, string tauxGestionProjetsMec,
            string tauxShippingMec, string derniereVersion)
        {
            ProfitElec = profitElec;
            ProfitMec = profitMec;
            Commission = commission;
            Imprevus = imprevus;
            PrixPagesManuel = prixPagesManuel;
            IndiceDessin = indiceDessin;
            TauxAmericain = tauxAmericain;
            TauxEspagnol = tauxEspagnol;
            TauxDessinElec = tauxDessinElec;
            TauxProgInterface = tauxProgInterface;
            TauxAssemblageElec = tauxAssemblageElec;
            TauxFabrication = tauxFabrication;
            TauxTestElec = tauxTestElec;
            TauxVision = tauxVision;
            TauxProgAutomate = tauxProgAutomate;
            TauxProgRobot = tauxProgRobot;
            TauxGestionProjetsElec = tauxGestionProjetsElec;
            TauxInstallationElec = tauxInstallationElec;
            TauxFormationElec = tauxFormationElec;
            TauxMiseService = tauxMiseService;
            TauxShippingElec = tauxShippingElec;
            LeGrand = leGrand;
            Lamine = lamine;
            Thermo = thermo;
            _4em = _4em;
            FsDixMoins = fsDixMoins;
            FsDix = fsDix;
            FsQuinze = fsQuinze;
            FsVingt = fsVingt;
            FsVingtCinq = fsVingtCinq;
            FsCinquante = fsCinquante;
            FsCent = fsCent;
            ParcelLabelLine1 = parcelLabelLine1;
            ParcelLabelLine2 = parcelLabelLine2;
            ParcelLabelLine3 = parcelLabelLine3;
            ParcelAssist = parcelAssist;
            ParcelEtat = parcelEtat;
            Hebergement1 = hebergement1;
            Hebergement2 = hebergement2;
            Repas = repas;
            Standard = standard;
            UniteMobile = uniteMobile;
            CheminSee4000 = cheminSee4000;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxAssemblageMec = tauxAssemblageMec;
            TauxPeinture = tauxPeinture;
            TauxTestMec = tauxTestMec;
            TauxDessinMec = tauxDessinMec;
            TauxFormationMec = tauxFormationMec;
            TauxInstallationMec = tauxInstallationMec;
            TauxGestionProjetsMec = tauxGestionProjetsMec;
            TauxShippingMec = tauxShippingMec;
            DerniereVersion = derniereVersion;
        }
        internal static void RestaurerConfigConstructeur()
        {
            Program.UpdateSQL("DELETE FROM [DBO].[CONFIG]");
            Program.UpdateSQL("DELETE FROM [DBO].[CONFIG]" +
                "INSERT[DBO].[Config]([ProfitElec], [ProfitMec], [Commission], [Imprévus], [PrixPagesManuel],[IndiceDessin], " +
                "[TauxAmericain], [TauxEspagnol], [TauxDessinElec], [TauxProgInterface], [TauxAssemblageElec],[TauxFabrication], " +
                "[TauxTestElec], [TauxVision], [TauxProgAutomate], [TauxProgRobot], [TauxGestionProjetsElec],[TauxInstallationElec]," +
                " [TauxFormationElec], [TauxMiseService], [TauxShippingElec], [LeGrand], [Lamine], [Thermo],[4em], [fsDixMoins], " +
                "[fsDix], [fsQuinze], [fsVingt], [fsVingtCinq], [fsCinquante], [fsCent], [Parcel_label_line1],[parcel_label_line2], " +
                "[parcel_label_line3], [ParcelAssist], [ParcelEtat], [Hebergement1], [Hebergement2], [Repas],[Standard], [UniteMobile], " +
                "[CheminSee4000], [TauxMachinage], [TauxCoupe], [TauxSoudure], [TauxAssemblageMec],[TauxPeinture], [TauxTestMec], [TauxDessinMec], " +
                "[TauxFormationMec],[TauxInstallationMec], [TauxGestionProjetsMec],[TauxShippingMec], [DerniereVersion]) VALUES(" +
                "N'1,40', N'1,40', N'0,09', N'0,10', N'0,05', N'1', N'0,73', N'102,161', N'85', N'105', N'85', N'85', N'105', N'105',N'105', " +
                "N'105', N'85', N'100', N'85', N'100', N'60', N'1', N'1,50', N'1,75', N'2', N'0,017', N'0,015', N'0,01',N'0,009', N'0,007', " +
                "N'0,005', N'0,004', N'Les Produits Tourval inc', N'50, rue du Pacifique Est Bromont, J2L 1J5', N'CANADA ',N'Chantal Couture #230'," +
                " N'Quebec', N'75', N'90', N'50', N'0,55', N'1,00', N'\\\\Serveur\\bdgrb\\SEEGRB\\Equipment.mdb', N'85',N'85', N'85', N'85', N'85', " +
                "N'85', N'85', N'85', N'85', N'85', N'60', N'2.24.180')");
        }
        internal static void AfficherInterfaceConfiguration()
        {
            Form conf = new Configuration();
            conf.Icon = Conteneur.Mdi.Icon;
            conf.FormBorderStyle = FormBorderStyle.FixedSingle;
            conf.ShowInTaskbar = false;
            conf.StartPosition = FormStartPosition.CenterScreen;
            conf.Text = "Restauration Configuration mode Constructeur";
            conf.ShowDialog();
        }
    }
    public class DB_ContactClient
    {
        public int NoEnreg;
        public int Noclient;
        public int Nocontact;
        public DB_ContactClient() { }
        public DB_ContactClient(int noEnreg, int noclient, int nocontact)
        {
            NoEnreg = noEnreg;
            Noclient = noclient;
            Nocontact = nocontact;
        }
    }
    public class DB_ContactFr
    {
        public int NoEnreg;
        public int NoFrs;
        public int NoContact;
        public DB_ContactFr() { }
        public DB_ContactFr(int noEnreg, int noFrs, int noContact)
        {
            NoEnreg = noEnreg;
            NoFrs = noFrs;
            NoContact = noContact;
        }
    }
    public class DB_Contacts
    {
        public int Idcontact;
        public string NomContact;
        public string Compagnie;
        public string Telephonne;
        public string Fax;
        public string Cellulaire;
        public string Pagette;
        public string EMail;
        public string Noposte;
        public string Teldomicile;
        public string DateCreation;
        public string UserCreation;
        public string DateModification;
        public string UserModification;
        public string Commentaire;
        public string Titre;
        public string EntryIdoutlook;
        public bool Supprime;
        public DB_Contacts() { }
        public DB_Contacts(int idcontact, string nomContact, string compagnie, string telephonne, string fax, string cellulaire,
            string pagette, string eMail, string noposte, string teldomicile, string dateCreation, string userCreation,
            string dateModification, string userModification, string commentaire, string titre, string entryIdoutlook, bool supprime)
        {
            Idcontact = idcontact;
            NomContact = nomContact;
            Compagnie = compagnie;
            Telephonne = telephonne;
            Fax = fax;
            Cellulaire = cellulaire;
            Pagette = pagette;
            EMail = eMail;
            Noposte = noposte;
            Teldomicile = teldomicile;
            DateCreation = dateCreation;
            UserCreation = userCreation;
            DateModification = dateModification;
            UserModification = userModification;
            Commentaire = commentaire;
            Titre = titre;
            EntryIdoutlook = entryIdoutlook;
            Supprime = supprime;
        }
    }
    public class DB_Dessin
    {
        public int NoEnreg;
        public string NoProjet;
        public string NoDessin;
        public string Description;
        public string Type;
        public DB_Dessin() { }
        public DB_Dessin(int noEnreg, string noProjet, string noDessin, string description, string type)
        {
            NoEnreg = noEnreg;
            NoProjet = noProjet;
            NoDessin = noDessin;
            Description = description;
            Type = type;
        }
    }
    public class DB_Doublon
    {
        public int NoEnreg;
        public string Piece;
        public string Fabricant;
        public string DescrFr;
        public string DescrEn;
        public string Categorie;
        public DB_Doublon() { }
        public DB_Doublon(int noEnreg, string piece, string fabricant, string descrFr, string descrEn, string categorie)
        {
            NoEnreg = noEnreg;
            Piece = piece;
            Fabricant = fabricant;
            DescrFr = descrFr;
            DescrEn = descrEn;
            Categorie = categorie;
        }
    }
    public class DB_Employe
    {
        public int Noemploye;
        public string Loginname;
        public string Passwd;
        public string Employes;
        public string Initiale;
        public string Tel;
        public string Page;
        public string Cell;
        public bool Actif;
        public int Groupe;
        public int Famille;
        public bool Supprime;
        public DB_Employe() { }
        public DB_Employe(int noemploye, string loginname, string passwd, string employes, string initiale, string tel, string page,
            string cell, bool actif, int groupe, int famille, bool supprime)
        {
            Noemploye = noemploye;
            Loginname = loginname;
            Passwd = passwd;
            Employes = employes;
            Initiale = initiale;
            Tel = tel;
            Page = page;
            Cell = cell;
            Actif = actif;
            Groupe = groupe;
            Famille = famille;
            Supprime = supprime;
        }
        public override bool Equals(object obj) => Noemploye.Equals(Program.idNoEmploye);
        public override int GetHashCode() => Loginname.GetHashCode();
        public override string ToString() => $"{Noemploye}-{Loginname}-{Employes}-{Initiale}-{Tel}-{Page}-{Cell}-{Actif}-{Groupe}-{Famille}-{Supprime}";
    }
    public class DB_Erreur
    {
        public int Iderreur;
        public string Qui;
        public string Date;
        public string Heure;
        public string Form;
        public string Methode;
        public int NoLigne;
        public int NoErreur;
        public string Description;
        public string Source;
        public string Params;
        public DB_Erreur()
        {
        }
        /// pour les tables Identity
        public DB_Erreur(string qui, string date, string heure, string form, string methode, int noLigne, int noErreur,
            string description, string source, string @params)
        {
            Qui = qui;
            Date = date;
            Heure = heure;
            Form = form;
            Methode = methode;
            NoLigne = noLigne;
            NoErreur = noErreur;
            Description = description;
            Source = source;
            Params = @params;
        }
        public DB_Erreur(int iderreur, string qui, string date, string heure, string form, string methode, int noLigne,
                    int noErreur, string description, string source, string @params)
        {
            Iderreur = iderreur;
            Qui = qui;
            Date = date;
            Heure = heure;
            Form = form;
            Methode = methode;
            NoLigne = noLigne;
            NoErreur = noErreur;
            Description = description;
            Source = source;
            Params = @params;
        }
    }
    public class DB_ExceptionsDl
    {
        public int Id;
        public string Exception;
        public DB_ExceptionsDl() { }
        public DB_ExceptionsDl(int id, string exception)
        {
            Id = id;
            Exception = exception;
        }
    }
    public class DB_Famille
    {
        public int Idfamille;
        public string Familles;
        public DB_Famille() { }
        public DB_Famille(int idfamille, string familles)
        {
            Idfamille = idfamille;
            Familles = familles;
        }
    }
    public class DB_Fournisseur
    {
        public DB_Fournisseur()
        {
        }
        public DB_Fournisseur(int idfrs, string nomFournisseur, string abbreviation, string rep, string interne, string adresse, string ville, string provEtat, string pays,
            string codePostal, string telephonne, string fax, string eMail, string condTransport, string noposte, string siteweb, string commentaire, string dateCreation,
            string userCreation, string dateModification, string userModification, string entryIdoutlook, bool supprime, string categorie)
        {
            Idfrs = idfrs;
            NomFournisseur = nomFournisseur;
            Abbreviation = abbreviation;
            Rep = rep;
            Interne = interne;
            Adresse = adresse;
            Ville = ville;
            ProvEtat = provEtat;
            Pays = pays;
            CodePostal = codePostal;
            Telephonne = telephonne;
            Fax = fax;
            EMail = eMail;
            CondTransport = condTransport;
            Noposte = noposte;
            Siteweb = siteweb;
            Commentaire = commentaire;
            DateCreation = dateCreation;
            UserCreation = userCreation;
            DateModification = dateModification;
            UserModification = userModification;
            EntryIdoutlook = entryIdoutlook;
            Supprime = supprime;
            Categorie = categorie;
        }
        public DB_Fournisseur(string nomFournisseur, string abbreviation, string rep, string interne, string adresse, string ville,
                    string provEtat, string pays, string codePostal, string telephonne, string fax, string eMail, string condTransport,
                    string noposte, string siteweb, string commentaire, string dateCreation, string userCreation, string dateModification,
                    string userModification, string entryIdoutlook, bool supprime, string categorie)
        {
            NomFournisseur = nomFournisseur;
            Abbreviation = abbreviation;
            Rep = rep;
            Interne = interne;
            Adresse = adresse;
            Ville = ville;
            ProvEtat = provEtat;
            Pays = pays;
            CodePostal = codePostal;
            Telephonne = telephonne;
            Fax = fax;
            EMail = eMail;
            CondTransport = condTransport;
            Noposte = noposte;
            Siteweb = siteweb;
            Commentaire = commentaire;
            DateCreation = dateCreation;
            UserCreation = userCreation;
            DateModification = dateModification;
            UserModification = userModification;
            EntryIdoutlook = entryIdoutlook;
            Supprime = supprime;
            Categorie = categorie;
        }
        public int Idfrs;
        public string NomFournisseur;
        public string Abbreviation;
        public string Rep;
        public string Interne;
        public string Adresse;
        public string Ville;
        public string ProvEtat;
        public string Pays;
        public string CodePostal;
        public string Telephonne;
        public string Fax;
        public string EMail;
        public string CondTransport;
        public string Noposte;
        public string Siteweb;
        public string Commentaire;
        public string DateCreation;
        public string UserCreation;
        public string DateModification;
        public string UserModification;
        public string EntryIdoutlook;
        public bool Supprime;
        public string Categorie;
    }
    public class DB_Groupes
    {
        public int Idgroupe;
        public string NomGroupe;
        public bool Clients;
        public bool Fournisseurs;
        public bool Contacts;
        public bool ContactsVendeurs;
        public bool Rapport;
        public bool CatalogueMec;
        public bool CatalogueElec;
        public bool Employes;
        public bool Cedule;
        public bool Configuration;
        public bool Punch;
        public bool Outils;
        public bool SoumissionMec;
        public bool ProjetMec;
        public bool SoumissionElec;
        public bool ProjetElec;
        public bool InventaireMec;
        public bool InventaireElec;
        public bool ACHAT;
        public bool ModificationFacturation;
        public bool ModificationClients;
        public bool ModificationFournisseurs;
        public bool ModificationContacts;
        public bool ModificationGroupes;
        public bool ModificationEmployes;
        public bool ModificationFeuillesTemps;
        public bool ModificationOutils;
        public bool ModificationSoumissionsMec;
        public bool ModificationProjetsMec;
        public bool ModificationSoumissionsElec;
        public bool ModificationProjetsElec;
        public bool ModificationBonsCommandes;
        public bool ModificationCatalogueElec;
        public bool ModificationCatalogueMec;
        public bool ModificationInventaireMec;
        public bool ModificationInventaireElec;
        public bool ModificationPunchEmployes;
        public bool ModificationReception;
        public bool ModificationRetourMarchandise;
        public bool SuppressionProjets;
        public bool ListeDistribution;
        public bool PunchSemaineAnterieure;
        public bool VerrouillageTempsProjet;
        public bool DeverrouillageTempsProjet;
        private int value1;
        private string v;
        private bool value2;
        private bool value3;
        private bool value4;
        private bool value5;
        private bool value6;
        private bool value7;
        private bool value8;
        private bool value9;
        private bool value10;
        private bool value11;
        private bool value12;
        private bool value13;
        private bool value14;
        private bool value15;
        private bool value16;
        private bool value17;
        private bool value18;
        private bool value19;
        private bool value20;
        private bool value21;
        private bool value22;
        private bool value23;
        private bool value24;
        private bool value25;
        private bool value26;
        private bool value27;
        private bool value28;
        private bool value29;
        private bool value30;
        private bool value31;
        private bool value32;
        private bool value33;
        private bool value34;
        private bool value35;
        private bool value36;
        private bool value37;
        private bool value38;
        private bool value39;
        private bool value40;
        private bool value41;
        private bool value42;
        private bool value43;
        private bool value44;

        public DB_Groupes() { }

        public DB_Groupes(int value1, string v, bool value2, bool value3, bool value4, bool value5, bool value6, bool value7, bool value8, bool value9, bool value10, bool value11, bool value12, bool value13, bool value14, bool value15, bool value16, bool value17, bool value18, bool value19, bool value20, bool value21, bool value22, bool value23, bool value24, bool value25, bool value26, bool value27, bool value28, bool value29, bool value30, bool value31, bool value32, bool value33, bool value34, bool value35, bool value36, bool value37, bool value38, bool value39, bool value40, bool value41, bool value42, bool value43, bool value44)
        {
            value1 = value1;
            v = v;
            value2 = value2;
            value3 = value3;
            value4 = value4;
            value5 = value5;
            value6 = value6;
            value7 = value7;
            value8 = value8;
            value9 = value9;
            value10 = value10;
            value11 = value11;
            value12 = value12;
            value13 = value13;
            value14 = value14;
            value15 = value15;
            value16 = value16;
            value17 = value17;
            value18 = value18;
            value19 = value19;
            value20 = value20;
            value21 = value21;
            value22 = value22;
            value23 = value23;
            value24 = value24;
            value25 = value25;
            value26 = value26;
            value27 = value27;
            value28 = value28;
            value29 = value29;
            value30 = value30;
            value31 = value31;
            value32 = value32;
            value33 = value33;
            value34 = value34;
            value35 = value35;
            value36 = value36;
            value37 = value37;
            value38 = value38;
            value39 = value39;
            value40 = value40;
            value41 = value41;
            value42 = value42;
            value43 = value43;
            value44 = value44;
        }

        public DB_Groupes(int idgroupe, string nomGroupe, bool clients, bool fournisseurs, bool contacts, bool contactsVendeurs, bool rapport,
            bool catalogueMec, bool catalogueElec, bool employes, bool cedule, bool configuration, bool punch, bool outils, bool soumissionMec,
            bool projetMec, bool soumissionElec, bool projetElec, bool inventaireMec, bool inventaireElec, bool ACHAT, bool modificationFacturation,
            bool modificationClients, bool modificationFournisseurs, bool modificationContacts, bool modificationGroupes, bool modificationEmployes,
            bool modificationFeuillesTemps, bool modificationOutils, bool modificationSoumissionsMec, bool modificationProjetsMec,
            bool modificationSoumissionsElec, bool modificationProjetsElec, bool modificationBonsCommandes, bool modificationCatalogueElec,
            bool modificationCatalogueMec, bool modificationInventaireMec, bool modificationInventaireElec, bool modificationPunchEmployes,
            bool modificationReception, bool modificationRetourMarchandise, bool suppressionProjets, bool listeDistribution, bool punchSemaineAnterieure,
            bool verrouillageTempsProjet, bool deverrouillageTempsProjet)
        {
            Idgroupe = idgroupe;
            NomGroupe = nomGroupe;
            Clients = clients;
            Fournisseurs = fournisseurs;
            Contacts = contacts;
            ContactsVendeurs = contactsVendeurs;
            Rapport = rapport;
            CatalogueMec = catalogueMec;
            CatalogueElec = catalogueElec;
            Employes = employes;
            Cedule = cedule;
            Configuration = configuration;
            Punch = punch;
            Outils = outils;
            SoumissionMec = soumissionMec;
            ProjetMec = projetMec;
            SoumissionElec = soumissionElec;
            ProjetElec = projetElec;
            InventaireMec = inventaireMec;
            InventaireElec = inventaireElec;
            ACHAT = ACHAT;
            ModificationFacturation = modificationFacturation;
            ModificationClients = modificationClients;
            ModificationFournisseurs = modificationFournisseurs;
            ModificationContacts = modificationContacts;
            ModificationGroupes = modificationGroupes;
            ModificationEmployes = modificationEmployes;
            ModificationFeuillesTemps = modificationFeuillesTemps;
            ModificationOutils = modificationOutils;
            ModificationSoumissionsMec = modificationSoumissionsMec;
            ModificationProjetsMec = modificationProjetsMec;
            ModificationSoumissionsElec = modificationSoumissionsElec;
            ModificationProjetsElec = modificationProjetsElec;
            ModificationBonsCommandes = modificationBonsCommandes;
            ModificationCatalogueElec = modificationCatalogueElec;
            ModificationCatalogueMec = modificationCatalogueMec;
            ModificationInventaireMec = modificationInventaireMec;
            ModificationInventaireElec = modificationInventaireElec;
            ModificationPunchEmployes = modificationPunchEmployes;
            ModificationReception = modificationReception;
            ModificationRetourMarchandise = modificationRetourMarchandise;
            SuppressionProjets = suppressionProjets;
            ListeDistribution = listeDistribution;
            PunchSemaineAnterieure = punchSemaineAnterieure;
            VerrouillageTempsProjet = verrouillageTempsProjet;
            DeverrouillageTempsProjet = deverrouillageTempsProjet;
        }
    }
    public class DB_ImpressionBonlivraison
    {
        public int No;
        public string QteCom;
        public string QteLivr;
        public string QteBo;
        public string Description;
        public string Manufacturier;
        public string User;
        public DB_ImpressionBonlivraison() { }
        public DB_ImpressionBonlivraison(int no, string qteCom, string qteLivr, string qteBo, string description, string manufacturier, string user)
        {
            No = no;
            QteCom = qteCom;
            QteLivr = qteLivr;
            QteBo = qteBo;
            Description = description;
            Manufacturier = manufacturier;
            User = user;
        }
    }
    public class DB_ImpressionDemandePrixElec
    {
        public string Qte;
        public string NoPiece;
        public string Description;
        public string Manufacturier;
        public DB_ImpressionDemandePrixElec() { }
        public DB_ImpressionDemandePrixElec(string qte, string noPiece, string description, string manufacturier)
        {
            Qte = qte;
            NoPiece = noPiece;
            Description = description;
            Manufacturier = manufacturier;
        }
    }
    public class DB_ImpressionDemandePrixMec
    {
        public string Qte;
        public string NoPiece;
        public string Description;
        public string Manufacturier;
        public DB_ImpressionDemandePrixMec() { }
        public DB_ImpressionDemandePrixMec(string qte, string noPiece, string description, string manufacturier)
        {
            Qte = qte;
            NoPiece = noPiece;
            Description = description;
            Manufacturier = manufacturier;
        }
    }
    public class DB_ImpressionDetailTemp
    {
        public int Id;
        public string Employe;
        public string Type;
        public string TotalHeures;
        public DB_ImpressionDetailTemp() { }
        public DB_ImpressionDetailTemp(int id, string employe, string type, string totalHeures)
        {
            Id = id;
            Employe = employe;
            Type = type;
            TotalHeures = totalHeures;
        }
    }
    public class DB_ImpressionListePiece
    {
        public int Noligne;
        public string Idsoumission;
        public string NomSection;
        public string SousSection;
        public string NumItem;
        public string Qte;
        public string Description;
        public string Manufact;
        public string Section;
        public string NomSousSection;
        public string Idsection;
        public string Id;
        public DB_ImpressionListePiece() { }
        public DB_ImpressionListePiece(int noligne, string idsoumission, string nomSection, string sousSection, string numItem,
            string qte, string description, string manufact, string section, string nomSousSection, string idsection, string id)
        {
            Noligne = noligne;
            Idsoumission = idsoumission;
            NomSection = nomSection;
            SousSection = sousSection;
            NumItem = numItem;
            Qte = qte;
            Description = description;
            Manufact = manufact;
            Section = section;
            NomSousSection = nomSousSection;
            Idsection = idsection;
            Id = id;
        }
    }
    public class DB_ImpressionPoste
    {
        public string Attention;
        public string Client;
        public string AdresseLiv;
        public string VilleProv;
        public string PaysCode;
        public DB_ImpressionPoste() { }
        public DB_ImpressionPoste(string attention, string client, string adresseLiv, string villeProv, string paysCode)
        {
            Attention = attention;
            Client = client;
            AdresseLiv = adresseLiv;
            VilleProv = villeProv;
            PaysCode = paysCode;
        }
    }
    public class DB_ImpressionPunch
    {
        public int Id;
        public string NoProjet;
        public string Date;
        public string Commentaire;
        public string HeureDebut;
        public string HeureFin;
        public string NbreKm;
        public string Total;
        public string NomJour;
        public string Client;
        public string Type;
        public DB_ImpressionPunch() { }
        public DB_ImpressionPunch(int id, string noProjet, string date, string commentaire, string heureDebut,
            string heureFin, string nbreKm, string total, string nomJour, string client, string type)
        {
            Id = id;
            NoProjet = noProjet;
            Date = date;
            Commentaire = commentaire;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            NbreKm = nbreKm;
            Total = total;
            NomJour = nomJour;
            Client = client;
            Type = type;
        }
    }
    public class DB_ImpressionSommairePunch
    {
        public int Id;
        public int Employe;
        public int NoProjet;
        public DateTime Date;
        public DateTime HeureDebut;
        public DateTime HeureFin;
        public double NbreKm;
        public double Total;
        public string Commentaire;
        public DB_ImpressionSommairePunch() { }
        public DB_ImpressionSommairePunch(int id, int employe, int noProjet, DateTime date, DateTime heureDebut,
            DateTime heureFin, double nbreKm, double total, string commentaire)
        {
            Id = id;
            Employe = employe;
            NoProjet = noProjet;
            Date = date;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            NbreKm = nbreKm;
            Total = total;
            Commentaire = commentaire;
        }
    }
    public class DB_ImpressionSommairePunchGeneral
    {
        public int Id;
        public string NoProjet;
        public string Total;
        public DB_ImpressionSommairePunchGeneral() { }
        public DB_ImpressionSommairePunchGeneral(int id, string noProjet, string total)
        {
            Id = id;
            NoProjet = noProjet;
            Total = total;
        }
    }
    public class DB_ImpressionSommairePunchGrb : DB_ImpressionSommairePunchGeneral
    {
        public string Employe;
        public string Date;
        public string Commentaire;
        public string HeureDebut;
        public string HeureFin;
        public string NbreKm;
        public DB_ImpressionSommairePunchGrb() { }
        public DB_ImpressionSommairePunchGrb(int id, string noProjet, string total, string employe, string date, string commentaire, string heureDebut, string heureFin, string nbreKm) : base(id, noProjet, total)
        {
            Employe = employe;
            Date = date;
            Commentaire = commentaire;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            NbreKm = nbreKm;
        }
        public DB_ImpressionSommairePunchGrb(string employe, string date, string commentaire, string heureDebut, string heureFin, string nbreKm)
        {
            Employe = employe;
            Date = date;
            Commentaire = commentaire;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            NbreKm = nbreKm;
        }
        public DB_ImpressionSommairePunchGrb(int id, string noProjet, string total) : base(id, noProjet, total)
        {
        }
    }
    public class DB_ImpressionSoumission
    {
        public int Noligne;
        public string Idsoumission;
        public string NomSection;
        public string NumItem;
        public string Qte;
        public string Description;
        public string Manufact;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public string NomFournisseur;
        public string Temps;
        public string TempsTotal;
        public string PrixTotal;
        public string ProfitPourcent;
        public string ProfitArgent;
        public string SousSection;
        public string DateReception;
        public string DateCommande;
        public string NoSequentiel;
        public DB_ImpressionSoumission() { }
        public DB_ImpressionSoumission(int noligne, string idsoumission, string nomSection, string numItem, string qte,
            string description, string manufact, string prixList, string escompte, string prixNet, string nomFournisseur,
            string temps, string tempsTotal, string prixTotal, string profitPourcent, string profitArgent, string sousSection,
            string dateReception, string dateCommande, string noSequentiel)
        {
            Noligne = noligne;
            Idsoumission = idsoumission;
            NomSection = nomSection;
            NumItem = numItem;
            Qte = qte;
            Description = description;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            NomFournisseur = nomFournisseur;
            Temps = temps;
            TempsTotal = tempsTotal;
            PrixTotal = prixTotal;
            ProfitPourcent = profitPourcent;
            ProfitArgent = profitArgent;
            SousSection = sousSection;
            DateReception = dateReception;
            DateCommande = dateCommande;
            NoSequentiel = noSequentiel;
        }
    }
    public class DB_InventaireElec
    {
        public int position;
        public int NoEnreg;
        public string NoItem;
        public string Description;
        public string Manufacturier;
        public string QteBoite;
        public string PrixListe;
        public string Escompte;
        public string PrixNet;
        public string Commentaires;
        public string Localisation;
        public string DeviseMonetaire;
        public string QuantiteStock;
        public string QuantiteCommandee;
        public bool Minimum;
        public string QuantiteMinimum;
        public string Commande;
        public string NoProjet;
        public bool CommandeParBoite;
        public float Total;
        public DB_InventaireElec() { }
        public DB_InventaireElec(int position, int noEnreg, string noItem, string description, string manufacturier,
            string qteBoite, string prixListe, string escompte, string prixNet, string commentaires, string localisation,
            string deviseMonetaire, string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum,
            string commande, string noProjet, bool commandeParBoite, float total)
        {
            position = position;
            NoEnreg = noEnreg;
            NoItem = noItem;
            Description = description;
            Manufacturier = manufacturier;
            QteBoite = qteBoite;
            PrixListe = prixListe;
            Escompte = escompte;
            PrixNet = prixNet;
            Commentaires = commentaires;
            Localisation = localisation;
            DeviseMonetaire = deviseMonetaire;
            QuantiteStock = quantiteStock;
            QuantiteCommandee = quantiteCommandee;
            Minimum = minimum;
            QuantiteMinimum = quantiteMinimum;
            Commande = commande;
            NoProjet = noProjet;
            CommandeParBoite = commandeParBoite;
            Total = total;
        }
    }
    public class DB_InventaireElecModif : DB_InventaireElec
    {
        public int NumId;
        public string Date;
        public string Idprojet;
        public string noItem;
        public string Quantite;
        public string User;
        public DB_InventaireElecModif() { }
        public DB_InventaireElecModif(int numId, string date, string idprojet, string noItem, string quantite, string user)
        {
            Date = date;
            Idprojet = idprojet;
            Quantite = quantite;
            User = user;
            NumId = numId;
            noItem = noItem;
        }
        public DB_InventaireElecModif(int position, int noEnreg, string noItem, string description, string manufacturier,
            string qteBoite, string prixListe, string escompte, string prixNet, string commentaires, string localisation,
            string deviseMonetaire, string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum,
            string commande, string noProjet, bool commandeParBoite, float total)
            : base(position, noEnreg, noItem, description, manufacturier, qteBoite, prixListe, escompte, prixNet, commentaires,
                  localisation, deviseMonetaire, quantiteStock, quantiteCommandee, minimum, quantiteMinimum, commande, noProjet,
                  commandeParBoite, total)
        { }
        public DB_InventaireElecModif(int position, int noEnreg, string noItem, string description, string manufacturier,
            string qteBoite, string prixListe, string escompte, string prixNet, string commentaires, string localisation,
            string deviseMonetaire, string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum,
            string commande, string noProjet, bool commandeParBoite, float total, string date, string idprojet, string quantite,
            string user, int numId) :
            base(position, noEnreg, noItem, description, manufacturier, qteBoite, prixListe, escompte, prixNet, commentaires,
                localisation, deviseMonetaire, quantiteStock, quantiteCommandee, minimum, quantiteMinimum, commande, noProjet,
                commandeParBoite, total)
        {
            Date = date;
            Idprojet = idprojet;
            Quantite = quantite;
            User = user;
            NumId = numId;
        }
    }
    public class DB_InventaireMec
    {
        public int NoEnreg;
        public string NoItem;
        public string Description;
        public string Manufacturier;
        public string QteBoite;
        public string PrixListe;
        public string Escompte;
        public string PrixNet;
        public string Commentaires;
        public string Localisation;
        public string DeviseMonetaire;
        public string QuantiteStock;
        public string QuantiteCommandee;
        public bool Minimum;
        public string QuantiteMinimum;
        public string Commande;
        public string NoProjet;
        public bool CommandeParBoite;
        public DB_InventaireMec() { }
        public DB_InventaireMec(int noEnreg, string noItem, string description, string manufacturier, string qteBoite,
            string prixListe, string escompte, string prixNet, string commentaires, string localisation, string deviseMonetaire,
            string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum, string commande,
            string noProjet, bool commandeParBoite)
        {
            NoEnreg = noEnreg;
            NoItem = noItem;
            Description = description;
            Manufacturier = manufacturier;
            QteBoite = qteBoite;
            PrixListe = prixListe;
            Escompte = escompte;
            PrixNet = prixNet;
            Commentaires = commentaires;
            Localisation = localisation;
            DeviseMonetaire = deviseMonetaire;
            QuantiteStock = quantiteStock;
            QuantiteCommandee = quantiteCommandee;
            Minimum = minimum;
            QuantiteMinimum = quantiteMinimum;
            Commande = commande;
            NoProjet = noProjet;
            CommandeParBoite = commandeParBoite;
        }
    }
    public class DB_InventaireMecModif : DB_InventaireMec
    {
        public string Date;
        public string Idprojet;
        public string Quantite;
        public string User;
        public int NumId;
        public DB_InventaireMecModif() { }
        public DB_InventaireMecModif(string date, string idprojet, string quantite, string user, int numId)
        {
            Date = date;
            Idprojet = idprojet;
            Quantite = quantite;
            User = user;
            NumId = numId;
        }
        public DB_InventaireMecModif(int noEnreg, string noItem, string description, string manufacturier, string qteBoite,
                    string prixListe, string escompte, string prixNet, string commentaires, string localisation, string deviseMonetaire,
                    string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum, string commande, string noProjet,
                    bool commandeParBoite)
                    : base(noEnreg, noItem, description, manufacturier, qteBoite, prixListe, escompte, prixNet, commentaires, localisation,
  deviseMonetaire, quantiteStock, quantiteCommandee, minimum, quantiteMinimum, commande, noProjet, commandeParBoite)
        { }
        public DB_InventaireMecModif(int noEnreg, string noItem, string description, string manufacturier, string qteBoite,
            string prixListe, string escompte, string prixNet, string commentaires, string localisation, string deviseMonetaire,
            string quantiteStock, string quantiteCommandee, bool minimum, string quantiteMinimum, string commande, string noProjet,
            bool commandeParBoite, string date, string idprojet, string quantite, string user, int numId)
            : base(noEnreg, noItem, description, manufacturier, qteBoite, prixListe, escompte, prixNet, commentaires, localisation,
                  deviseMonetaire, quantiteStock, quantiteCommandee, minimum, quantiteMinimum, commande, noProjet, commandeParBoite)
        {
            Date = date;
            Idprojet = idprojet;
            Quantite = quantite;
            User = user;
            NumId = numId;
        }
    }
    public class DB_Outils
    {
        public string NoOutils;
        public string NomOutils;
        public string Departement;
        public string Cout;
        public string TypeEtiquette;
        public string DateAchat;
        public string DateHorsFonction;
        public string Commentaire;
        public DB_Outils() { }
        public DB_Outils(string noOutils, string nomOutils, string departement, string cout, string typeEtiquette,
            string dateAchat, string dateHorsFonction, string commentaire)
        {
            NoOutils = noOutils;
            NomOutils = nomOutils;
            Departement = departement;
            Cout = cout;
            TypeEtiquette = typeEtiquette;
            DateAchat = dateAchat;
            DateHorsFonction = dateHorsFonction;
            Commentaire = commentaire;
        }
    }
    public class DB_OutilsInOut
    {
        public int NoOutils;
        public int NoEmploye;
        public string DepartDateHeure;
        public string RetourDateHeure;
        public string Commentaire;
        public int NoEnreg;
        public DB_OutilsInOut() { }
        public DB_OutilsInOut(int noOutils, int noEmploye, string departDateHeure, string retourDateHeure, string commentaire, int noEnreg)
        {
            NoOutils = noOutils;
            NoEmploye = noEmploye;
            DepartDateHeure = departDateHeure;
            RetourDateHeure = retourDateHeure;
            Commentaire = commentaire;
            NoEnreg = noEnreg;
        }
    }
    public class DB_Outlook
    {
        public int? Id;
        public string NomContact;
        public string Compagnie;
        public string Telephonne;
        public string Cellulaire;
        public string EMail;
        public string EntryIdoutlook;
        public string Noposte;
        public DB_Outlook() { }
        public DB_Outlook(int? id, string nomContact, string compagnie, string telephonne, string cellulaire, string eMail,
            string entryIdoutlook, string noposte)
        {
            Id = id;
            NomContact = nomContact;
            Compagnie = compagnie;
            Telephonne = telephonne;
            Cellulaire = cellulaire;
            EMail = eMail;
            EntryIdoutlook = entryIdoutlook;
            Noposte = noposte;
        }
    }
    public class DB_Pieces
    {
        string m_collPiece;
        string m_collQuantite;
        string m_collDescriptionFR;
        string m_collDescriptionEN;
        string m_collCategorie;
        string m_collManufacturier;
        public DB_Pieces() { }
        public DB_Pieces(string collPiece, string collQuantite, string collDescriptionFR, string collDescriptionEN,
            string collCategorie, string collManufacturier)
        {
            m_collPiece = collPiece;
            m_collQuantite = collQuantite;
            m_collDescriptionFR = collDescriptionFR;
            m_collDescriptionEN = collDescriptionEN;
            m_collCategorie = collCategorie;
            m_collManufacturier = collManufacturier;
        }
    }
    public class DB_PiecesFr
    {
        public int NoEnreg;
        public int Idfrs;
        public string Piece;
        public string TableElec;
        public string PrixSp;
        public string PersRess;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public string Date;
        public string EntrerPar;
        public string Valide;
        public bool Quoter;
        public string DeviseMonetaire;
        public string PrixReel;
        public string Type;
        public DB_PiecesFr() { }
        public DB_PiecesFr(int noEnreg, int idfrs, string piece, string tableElec, string prixSp, string persRess,
            string prixList, string escompte, string prixNet, string date, string entrerPar, string valide,
            bool quoter, string deviseMonetaire, string prixReel, string type)
        {
            NoEnreg = noEnreg;
            Idfrs = idfrs;
            Piece = piece;
            TableElec = tableElec;
            PrixSp = prixSp;
            PersRess = persRess;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Date = date;
            EntrerPar = entrerPar;
            Valide = valide;
            Quoter = quoter;
            DeviseMonetaire = deviseMonetaire;
            PrixReel = prixReel;
            Type = type;
        }
    }
    public class DB_Projet
    {
        public string Idprojet;
        public string Idsoumission;
        public int Idclient;
        public int Idcontact;
        public string Description;
        public string Creer;
        public int CreerPar;
        public string TempsFabrication;
        public string TempsAssemblage;
        public string Transport;
        public string NbrePersonne;
        public string TempsHebergement;
        public string TotalHebergement;
        public string TempsRepas;
        public string TotalRepas;
        public string TempsTransport;
        public string TauxHebergement1;
        public string TauxHebergement2;
        public string TauxRepas;
        public string TauxTransport;
        public string Imprevue;
        public string TotalImprevue;
        public string TotalTemps;
        public string PrixTotal;
        public string Profit;
        public string TotalProfit;
        public DB_Projet() { }
        public DB_Projet(string idprojet, string idsoumission, int idclient, int idcontact, string description,
            string creer, int creerPar, string tempsFabrication, string tempsAssemblage, string transport,
            string nbrePersonne, string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas,
            string tempsTransport, string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport,
            string imprevue, string totalImprevue, string totalTemps, string prixTotal, string profit, string totalProfit)
        {
            Idprojet = idprojet;
            Idsoumission = idsoumission;
            Idclient = idclient;
            Idcontact = idcontact;
            Description = description;
            Creer = creer;
            CreerPar = creerPar;
            TempsFabrication = tempsFabrication;
            TempsAssemblage = tempsAssemblage;
            Transport = transport;
            NbrePersonne = nbrePersonne;
            TempsHebergement = tempsHebergement;
            TotalHebergement = totalHebergement;
            TempsRepas = tempsRepas;
            TotalRepas = totalRepas;
            TempsTransport = tempsTransport;
            TauxHebergement1 = tauxHebergement1;
            TauxHebergement2 = tauxHebergement2;
            TauxRepas = tauxRepas;
            TauxTransport = tauxTransport;
            Imprevue = imprevue;
            TotalImprevue = totalImprevue;
            TotalTemps = totalTemps;
            PrixTotal = prixTotal;
            Profit = profit;
            TotalProfit = totalProfit;
        }
    }
    public class DB_ProjetElec : DB_Projet
    {
        public string PanneauAire;
        public string PanneauEspace;
        public string NbreManuel;
        public string Floorstock;
        public string Marqueur;
        public bool Csa;
        public bool Cul;
        public bool Ul;
        public bool Cur;
        public bool Ur;
        public bool Ce;
        public string Delais;
        public string TempsDessin;
        public string TempsProgInterface;
        public string TempsTest;
        public string TempsVision;
        public string TempsProgAutomate;
        public string TempsProgRobot;
        public string TempsInstallation;
        public string TempsMiseService;
        public string TempsFormation;
        public string TempsGestion;
        public string TempsShipping;
        public string TempsUniteMobile;
        public string PrixEmballage;
        public string TauxDessin;
        public string TauxProgInterface;
        public string TauxFabrication;
        public string TauxAssemblage;
        public string TauxTest;
        public string TauxVision;
        public string TauxProgAutomate;
        public string TauxProgRobot;
        public string TauxInstallation;
        public string TauxMiseService;
        public string TauxFormation;
        public string TauxGestion;
        public string TauxShipping;
        public string TauxUniteMobile;
        public string TotalPiece;
        public string TotalManuel;
        public string Commission;
        public string TotalCommission;
        public bool SansTemps;
        public string CheminPhotos;
        public bool Modification;
        public string Par;
        public string PrixReception;
        public string MontantForfait;
        public string InitialeForfait;
        public string LiaisonChargeable;
        public int ProchaineCommande;
        public DB_ProjetElec() { }
        public DB_ProjetElec(string idprojet, string idsoumission, int idclient, int idcontact, string description,
            string creer, int creerPar, string tempsFabrication, string tempsAssemblage, string transport, string nbrePersonne,
            string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport,
            string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport, string imprevue,
            string totalImprevue, string totalTemps, string prixTotal, string profit, string totalProfit)
            : base(idprojet, idsoumission, idclient, idcontact, description, creer, creerPar, tempsFabrication,
                  tempsAssemblage, transport, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas,
                  tempsTransport, tauxHebergement1, tauxHebergement2, tauxRepas, tauxTransport, imprevue, totalImprevue,
                  totalTemps, prixTotal, profit, totalProfit)
        { }
        public DB_ProjetElec(string panneauAire, string panneauEspace, string nbreManuel, string floorstock, string marqueur,
            bool csa, bool cul, bool ul, bool cur, bool ur, bool ce, string delais, string tempsDessin, string tempsProgInterface,
            string tempsTest, string tempsVision, string tempsProgAutomate, string tempsProgRobot, string tempsInstallation,
            string tempsMiseService, string tempsFormation, string tempsGestion, string tempsShipping, string tempsUniteMobile,
            string prixEmballage, string tauxDessin, string tauxProgInterface, string tauxFabrication, string tauxAssemblage,
            string tauxTest, string tauxVision, string tauxProgAutomate, string tauxProgRobot, string tauxInstallation,
            string tauxMiseService, string tauxFormation, string tauxGestion, string tauxShipping, string tauxUniteMobile,
            string totalPiece, string totalManuel, string commission, string totalCommission, bool sansTemps, string cheminPhotos,
            bool modification, string par, string prixReception, string montantForfait, string initialeForfait,
            string liaisonChargeable, int prochaineCommande)
        {
            PanneauAire = panneauAire;
            PanneauEspace = panneauEspace;
            NbreManuel = nbreManuel;
            Floorstock = floorstock;
            Marqueur = marqueur;
            Csa = csa;
            Cul = cul;
            Ul = ul;
            Cur = cur;
            Ur = ur;
            Ce = ce;
            Delais = delais;
            TempsDessin = tempsDessin;
            TempsProgInterface = tempsProgInterface;
            TempsTest = tempsTest;
            TempsVision = tempsVision;
            TempsProgAutomate = tempsProgAutomate;
            TempsProgRobot = tempsProgRobot;
            TempsInstallation = tempsInstallation;
            TempsMiseService = tempsMiseService;
            TempsFormation = tempsFormation;
            TempsGestion = tempsGestion;
            TempsShipping = tempsShipping;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxDessin = tauxDessin;
            TauxProgInterface = tauxProgInterface;
            TauxFabrication = tauxFabrication;
            TauxAssemblage = tauxAssemblage;
            TauxTest = tauxTest;
            TauxVision = tauxVision;
            TauxProgAutomate = tauxProgAutomate;
            TauxProgRobot = tauxProgRobot;
            TauxInstallation = tauxInstallation;
            TauxMiseService = tauxMiseService;
            TauxFormation = tauxFormation;
            TauxGestion = tauxGestion;
            TauxShipping = tauxShipping;
            TauxUniteMobile = tauxUniteMobile;
            TotalPiece = totalPiece;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            SansTemps = sansTemps;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            PrixReception = prixReception;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
            LiaisonChargeable = liaisonChargeable;
            ProchaineCommande = prochaineCommande;
        }
        public DB_ProjetElec(string idprojet, string idsoumission, int idclient, int idcontact, string description,
                    string creer, int creerPar, string tempsFabrication, string tempsAssemblage, string transport, string nbrePersonne,
                    string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport,
                    string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport, string imprevue,
                    string totalImprevue, string totalTemps, string prixTotal, string profit, string totalProfit, string panneauAire,
                    string panneauEspace, string nbreManuel, string floorstock, string marqueur, bool csa, bool cul, bool ul, bool cur,
                    bool ur, bool ce, string delais, string tempsDessin, string tempsProgInterface, string tempsTest, string tempsVision,
                    string tempsProgAutomate, string tempsProgRobot, string tempsInstallation, string tempsMiseService, string tempsFormation,
                    string tempsGestion, string tempsShipping, string tempsUniteMobile, string prixEmballage, string tauxDessin,
                    string tauxProgInterface, string tauxFabrication, string tauxAssemblage, string tauxTest, string tauxVision,
                    string tauxProgAutomate, string tauxProgRobot, string tauxInstallation, string tauxMiseService, string tauxFormation,
                    string tauxGestion, string tauxShipping, string tauxUniteMobile, string totalPiece, string totalManuel, string commission,
                    string totalCommission, bool sansTemps, string cheminPhotos, bool modification, string par, string prixReception,
                    string montantForfait, string initialeForfait, string liaisonChargeable, int prochaineCommande)
                    : base(idprojet, idsoumission, idclient, idcontact, description, creer, creerPar, tempsFabrication, tempsAssemblage,
  transport, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport, tauxHebergement1,
  tauxHebergement2, tauxRepas, tauxTransport, imprevue, totalImprevue, totalTemps, prixTotal, profit, totalProfit)
        {
            PanneauAire = panneauAire;
            PanneauEspace = panneauEspace;
            NbreManuel = nbreManuel;
            Floorstock = floorstock;
            Marqueur = marqueur;
            Csa = csa;
            Cul = cul;
            Ul = ul;
            Cur = cur;
            Ur = ur;
            Ce = ce;
            Delais = delais;
            TempsDessin = tempsDessin;
            TempsProgInterface = tempsProgInterface;
            TempsTest = tempsTest;
            TempsVision = tempsVision;
            TempsProgAutomate = tempsProgAutomate;
            TempsProgRobot = tempsProgRobot;
            TempsInstallation = tempsInstallation;
            TempsMiseService = tempsMiseService;
            TempsFormation = tempsFormation;
            TempsGestion = tempsGestion;
            TempsShipping = tempsShipping;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxDessin = tauxDessin;
            TauxProgInterface = tauxProgInterface;
            TauxFabrication = tauxFabrication;
            TauxAssemblage = tauxAssemblage;
            TauxTest = tauxTest;
            TauxVision = tauxVision;
            TauxProgAutomate = tauxProgAutomate;
            TauxProgRobot = tauxProgRobot;
            TauxInstallation = tauxInstallation;
            TauxMiseService = tauxMiseService;
            TauxFormation = tauxFormation;
            TauxGestion = tauxGestion;
            TauxShipping = tauxShipping;
            TauxUniteMobile = tauxUniteMobile;
            TotalPiece = totalPiece;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            SansTemps = sansTemps;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            PrixReception = prixReception;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
            LiaisonChargeable = liaisonChargeable;
            ProchaineCommande = prochaineCommande;
        }
    }
    public class DB_ProjetMec : DB_Projet
    {
        public string Manuel;
        public string TotalPiece;
        public string TotalManuel;
        public string Commission;
        public string TotalCommission;
        public bool? TempsProjBarre;
        public string TempsMachinageProj;
        public string TempsCoupeProj;
        public string TempsSoudureProj;
        public string TempsAssemblageProj;
        public string TempsPeintureProj;
        public string TempsTestProj;
        public string TempsDessinProj;
        public string TempsFormationProj;
        public string TempsInstallationProj;
        public string TempsGestionProj;
        public string TempsShippingProj;
        public string TempsMachinageConc;
        public string TempsCoupeConc;
        public string TempsSoudureConc;
        public string TempsAssemblageConc;
        public string TempsPeintureConc;
        public string TempsTestConc;
        public string TempsGestionConc;
        public string TempsShippingConc;
        public string TempsDessinConc;
        public string TempsInstallationConc;
        public string TempsFormationConc;
        public string TempsUniteMobile;
        public string PrixEmballage;
        public string TauxMachinage;
        public string TauxCoupe;
        public string TauxSoudure;
        public string TauxAssemblage;
        public string TauxPeinture;
        public string TauxTest;
        public string TauxDessin;
        public string TauxFormation;
        public string TauxInstallation;
        public string TauxGestion;
        public string TauxShipping;
        public string TauxUniteMobile;
        public string CheminPhotos;
        public bool? Modification;
        public string Par;
        public string PrixReception;
        public string MontantForfait;
        public string InitialeForfait;
        public string LiaisonChargeable;
        public int? ProchaineCommande;
        public DB_ProjetMec(string manuel = null, string totalPiece = null, string totalManuel = null, string commission = null, string totalCommission = null, bool? tempsProjBarre = null, string tempsMachinageProj = null, string tempsCoupeProj = null, string tempsSoudureProj = null, string tempsAssemblageProj = null, string tempsPeintureProj = null, string tempsTestProj = null, string tempsDessinProj = null, string tempsFormationProj = null, string tempsInstallationProj = null, string tempsGestionProj = null, string tempsShippingProj = null, string tempsMachinageConc = null, string tempsCoupeConc = null, string tempsSoudureConc = null, string tempsAssemblageConc = null, string tempsPeintureConc = null, string tempsTestConc = null, string tempsGestionConc = null, string tempsShippingConc = null, string tempsDessinConc = null, string tempsInstallationConc = null, string tempsFormationConc = null, string tempsUniteMobile = null, string prixEmballage = null, string tauxMachinage = null, string tauxCoupe = null, string tauxSoudure = null, string tauxAssemblage = null, string tauxPeinture = null, string tauxTest = null, string tauxDessin = null, string tauxFormation = null, string tauxInstallation = null, string tauxGestion = null, string tauxShipping = null, string tauxUniteMobile = null, string cheminPhotos = null, bool? modification = null, string par = null, string prixReception = null, string montantForfait = null, string initialeForfait = null, string liaisonChargeable = null, int? prochaineCommande = null)
        {
            Manuel = manuel;
            TotalPiece = totalPiece;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            TempsProjBarre = tempsProjBarre;
            TempsMachinageProj = tempsMachinageProj;
            TempsCoupeProj = tempsCoupeProj;
            TempsSoudureProj = tempsSoudureProj;
            TempsAssemblageProj = tempsAssemblageProj;
            TempsPeintureProj = tempsPeintureProj;
            TempsTestProj = tempsTestProj;
            TempsDessinProj = tempsDessinProj;
            TempsFormationProj = tempsFormationProj;
            TempsInstallationProj = tempsInstallationProj;
            TempsGestionProj = tempsGestionProj;
            TempsShippingProj = tempsShippingProj;
            TempsMachinageConc = tempsMachinageConc;
            TempsCoupeConc = tempsCoupeConc;
            TempsSoudureConc = tempsSoudureConc;
            TempsAssemblageConc = tempsAssemblageConc;
            TempsPeintureConc = tempsPeintureConc;
            TempsTestConc = tempsTestConc;
            TempsGestionConc = tempsGestionConc;
            TempsShippingConc = tempsShippingConc;
            TempsDessinConc = tempsDessinConc;
            TempsInstallationConc = tempsInstallationConc;
            TempsFormationConc = tempsFormationConc;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxAssemblage = tauxAssemblage;
            TauxPeinture = tauxPeinture;
            TauxTest = tauxTest;
            TauxDessin = tauxDessin;
            TauxFormation = tauxFormation;
            TauxInstallation = tauxInstallation;
            TauxGestion = tauxGestion;
            TauxShipping = tauxShipping;
            TauxUniteMobile = tauxUniteMobile;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            PrixReception = prixReception;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
            LiaisonChargeable = liaisonChargeable;
            ProchaineCommande = prochaineCommande;
        }
        public DB_ProjetMec(string idprojet, string idsoumission, int idclient, int idcontact, string description,
            string creer, int creerPar, string tempsFabrication, string tempsAssemblage, string transport,
            string nbrePersonne, string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas,
            string tempsTransport, string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport,
            string imprevue, string totalImprevue, string totalTemps, string prixTotal, string profit, string totalProfit)
            : base(idprojet, idsoumission, idclient, idcontact, description, creer, creerPar, tempsFabrication,
                  tempsAssemblage, transport, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas,
                  tempsTransport, tauxHebergement1, tauxHebergement2, tauxRepas, tauxTransport, imprevue, totalImprevue,
                  totalTemps, prixTotal, profit, totalProfit)
        { }
        public DB_ProjetMec(string manuel, string totalPiece, string totalManuel, string commission, string totalCommission,
            bool? tempsProjBarre, string tempsMachinageProj, string tempsCoupeProj, string tempsSoudureProj,
            string tempsAssemblageProj, string tempsPeintureProj, string tempsTestProj, string tempsDessinProj,
            string tempsFormationProj, string tempsInstallationProj, string tempsGestionProj, string tempsShippingProj,
            string tempsMachinageConc, string tempsCoupeConc, string tempsSoudureConc, string tempsAssemblageConc,
            string tempsPeintureConc, string tempsTestConc, string tempsGestionConc, string tempsShippingConc,
            string tempsDessinConc, string tempsInstallationConc, string tempsFormationConc, string tempsUniteMobile,
            string prixEmballage, string tauxMachinage, string tauxCoupe, string tauxSoudure, string tauxAssemblage,
            string tauxPeinture, string tauxTest, string tauxDessin, string tauxFormation, string tauxInstallation,
            string tauxGestion, string tauxShipping, string tauxUniteMobile, string cheminPhotos, bool modification, string par,
            string prixReception, string montantForfait, string initialeForfait, string liaisonChargeable, int prochaineCommande)
        {
            Manuel = manuel;
            TotalPiece = totalPiece;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            TempsProjBarre = tempsProjBarre;
            TempsMachinageProj = tempsMachinageProj;
            TempsCoupeProj = tempsCoupeProj;
            TempsSoudureProj = tempsSoudureProj;
            TempsAssemblageProj = tempsAssemblageProj;
            TempsPeintureProj = tempsPeintureProj;
            TempsTestProj = tempsTestProj;
            TempsDessinProj = tempsDessinProj;
            TempsFormationProj = tempsFormationProj;
            TempsInstallationProj = tempsInstallationProj;
            TempsGestionProj = tempsGestionProj;
            TempsShippingProj = tempsShippingProj;
            TempsMachinageConc = tempsMachinageConc;
            TempsCoupeConc = tempsCoupeConc;
            TempsSoudureConc = tempsSoudureConc;
            TempsAssemblageConc = tempsAssemblageConc;
            TempsPeintureConc = tempsPeintureConc;
            TempsTestConc = tempsTestConc;
            TempsGestionConc = tempsGestionConc;
            TempsShippingConc = tempsShippingConc;
            TempsDessinConc = tempsDessinConc;
            TempsInstallationConc = tempsInstallationConc;
            TempsFormationConc = tempsFormationConc;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxAssemblage = tauxAssemblage;
            TauxPeinture = tauxPeinture;
            TauxTest = tauxTest;
            TauxDessin = tauxDessin;
            TauxFormation = tauxFormation;
            TauxInstallation = tauxInstallation;
            TauxGestion = tauxGestion;
            TauxShipping = tauxShipping;
            TauxUniteMobile = tauxUniteMobile;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            PrixReception = prixReception;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
            LiaisonChargeable = liaisonChargeable;
            ProchaineCommande = prochaineCommande;
        }
        public DB_ProjetMec(string idprojet, string idsoumission, int idclient, int idcontact, string description,
                    string creer, int creerPar, string tempsFabrication, string tempsAssemblage, string transport, string nbrePersonne,
                    string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport,
                    string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport, string imprevue,
                    string totalImprevue, string totalTemps, string prixTotal, string profit, string totalProfit, string manuel,
                    string totalPiece, string totalManuel, string commission, string totalCommission, bool? tempsProjBarre,
                    string tempsMachinageProj, string tempsCoupeProj, string tempsSoudureProj, string tempsAssemblageProj,
                    string tempsPeintureProj, string tempsTestProj, string tempsDessinProj, string tempsFormationProj,
                    string tempsInstallationProj, string tempsGestionProj, string tempsShippingProj, string tempsMachinageConc,
                    string tempsCoupeConc, string tempsSoudureConc, string tempsAssemblageConc, string tempsPeintureConc,
                    string tempsTestConc, string tempsGestionConc, string tempsShippingConc, string tempsDessinConc,
                    string tempsInstallationConc, string tempsFormationConc, string tempsUniteMobile, string prixEmballage,
                    string tauxMachinage, string tauxCoupe, string tauxSoudure, string tauxAssemblage, string tauxPeinture,
                    string tauxTest, string tauxDessin, string tauxFormation, string tauxInstallation, string tauxGestion,
                    string tauxShipping, string tauxUniteMobile, string cheminPhotos, bool? modification, string par, string prixReception,
                    string montantForfait, string initialeForfait, string liaisonChargeable, int? prochaineCommande)
                    : base(idprojet, idsoumission, idclient, idcontact, description, creer, creerPar, tempsFabrication, tempsAssemblage,
  transport, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport, tauxHebergement1,
  tauxHebergement2, tauxRepas, tauxTransport, imprevue, totalImprevue, totalTemps, prixTotal, profit, totalProfit)
        {
            Manuel = manuel;
            TotalPiece = totalPiece;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            TempsProjBarre = tempsProjBarre;
            TempsMachinageProj = tempsMachinageProj;
            TempsCoupeProj = tempsCoupeProj;
            TempsSoudureProj = tempsSoudureProj;
            TempsAssemblageProj = tempsAssemblageProj;
            TempsPeintureProj = tempsPeintureProj;
            TempsTestProj = tempsTestProj;
            TempsDessinProj = tempsDessinProj;
            TempsFormationProj = tempsFormationProj;
            TempsInstallationProj = tempsInstallationProj;
            TempsGestionProj = tempsGestionProj;
            TempsShippingProj = tempsShippingProj;
            TempsMachinageConc = tempsMachinageConc;
            TempsCoupeConc = tempsCoupeConc;
            TempsSoudureConc = tempsSoudureConc;
            TempsAssemblageConc = tempsAssemblageConc;
            TempsPeintureConc = tempsPeintureConc;
            TempsTestConc = tempsTestConc;
            TempsGestionConc = tempsGestionConc;
            TempsShippingConc = tempsShippingConc;
            TempsDessinConc = tempsDessinConc;
            TempsInstallationConc = tempsInstallationConc;
            TempsFormationConc = tempsFormationConc;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxAssemblage = tauxAssemblage;
            TauxPeinture = tauxPeinture;
            TauxTest = tauxTest;
            TauxDessin = tauxDessin;
            TauxFormation = tauxFormation;
            TauxInstallation = tauxInstallation;
            TauxGestion = tauxGestion;
            TauxShipping = tauxShipping;
            TauxUniteMobile = tauxUniteMobile;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            PrixReception = prixReception;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
            LiaisonChargeable = liaisonChargeable;
            ProchaineCommande = prochaineCommande;
        }
        public DB_ProjetMec()
        {
        }
    }
    public class DB_ProjetModif
    {
        public int Idmodif;
        public string Idprojet;
        public int? NoEmploye;
        public string Date;
        public string Heure;
        public string Type;
        public string TypeModif;
        public string Valeur;
        public DB_ProjetModif() { }
        public DB_ProjetModif(int idmodif, string idprojet, int? noEmploye, string date, string heure, string type, string typeModif, string valeur)
        {
            Idmodif = idmodif;
            Idprojet = idprojet;
            NoEmploye = noEmploye;
            Date = date;
            Heure = heure;
            Type = type;
            TypeModif = typeModif;
            Valeur = valeur;
        }
    }
    public class DB_ProjetPiece
    {
        public int NoEnreg;
        public string Idprojet;
        public int Idsection;
        public string NumItem;
        public string Qte;
        public string DescFr;
        public string DescEn;
        public string Manufact;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public int Idfrs;
        public string Temps;
        public string TempsTotal;
        public string PrixTotal;
        public string ProfitPourcent;
        public string ProfitArgent;
        public string SousSection;
        public string OrdreSection;
        public int NumeroLigne;
        public string PrixOrigine;
        public string Type;
        public bool Visible;
        public bool Commande;
        public bool Quote;
        public bool Recu;
        public bool Retour;
        public string NoRetour;
        public bool CommandeAnnulee;
        public string DateReception;
        public string QuantiteRecue;
        public string Facturation;
        public string Id;
        public bool PieceExtra;
        public bool PieceExtraChargeable;
        public bool PieceExtraNonChargeable;
        public string DateCommande;
        public string DateRequise;
        public string NomCommande;
        public string NoSequentiel;
        public bool MaterielInutile;
        public string Commentaire;
        public string DateRetour;
        public string Provenance;
        public string Devise;
        public DB_ProjetPiece() { }
        public DB_ProjetPiece(int noEnreg, string idprojet, int idsection, string numItem, string qte, string descFr,
            string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps,
            string tempsTotal, string prixTotal, string profitPourcent, string profitArgent, string sousSection,
            string ordreSection, int numeroLigne, string prixOrigine, string type, bool visible, bool commande, bool quote,
            bool recu, bool retour, string noRetour, bool commandeAnnulee, string dateReception, string quantiteRecue,
            string facturation, string id, bool pieceExtra, bool pieceExtraChargeable, bool pieceExtraNonChargeable,
            string dateCommande, string dateRequise, string nomCommande, string noSequentiel, bool materielInutile,
            string commentaire, string dateRetour, string provenance, string devise)
        {
            NoEnreg = noEnreg;
            Idprojet = idprojet;
            Idsection = idsection;
            NumItem = numItem;
            Qte = qte;
            DescFr = descFr;
            DescEn = descEn;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Idfrs = idfrs;
            Temps = temps;
            TempsTotal = tempsTotal;
            PrixTotal = prixTotal;
            ProfitPourcent = profitPourcent;
            ProfitArgent = profitArgent;
            SousSection = sousSection;
            OrdreSection = ordreSection;
            NumeroLigne = numeroLigne;
            PrixOrigine = prixOrigine;
            Type = type;
            Visible = visible;
            Commande = commande;
            Quote = quote;
            Recu = recu;
            Retour = retour;
            NoRetour = noRetour;
            CommandeAnnulee = commandeAnnulee;
            DateReception = dateReception;
            QuantiteRecue = quantiteRecue;
            Facturation = facturation;
            Id = id;
            PieceExtra = pieceExtra;
            PieceExtraChargeable = pieceExtraChargeable;
            PieceExtraNonChargeable = pieceExtraNonChargeable;
            DateCommande = dateCommande;
            DateRequise = dateRequise;
            NomCommande = nomCommande;
            NoSequentiel = noSequentiel;
            MaterielInutile = materielInutile;
            Commentaire = commentaire;
            DateRetour = dateRetour;
            Provenance = provenance;
            Devise = devise;
        }
    }
    public class DB_ProjetPieceBack : DB_ProjetPiece
    {
        public new int NoEnreg;
        public DB_ProjetPieceBack() { }
        public DB_ProjetPieceBack(int noEnreg) => NoEnreg = noEnreg;
        /// héritage polymorphique de DB_ProjetPiece
        public DB_ProjetPieceBack(int noEnreg, string idprojet, int idsection, string numItem, string qte,
            string descFr, string descEn, string manufact, string prixList, string escompte, string prixNet,
            int idfrs, string temps, string tempsTotal, string prixTotal, string profitPourcent, string profitArgent,
            string sousSection, string ordreSection, int numeroLigne, string prixOrigine, string type, bool visible,
            bool commande, bool quote, bool recu, bool retour, string noRetour, bool commandeAnnulee,
            string dateReception, string quantiteRecue, string facturation, string id, bool pieceExtra,
            bool pieceExtraChargeable, bool pieceExtraNonChargeable, string dateCommande, string dateRequise,
            string nomCommande, string noSequentiel, bool materielInutile, string commentaire, string dateRetour,
            string provenance, string devise)
            : base(noEnreg, idprojet, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet,
                  idfrs, temps, tempsTotal, prixTotal, profitPourcent, profitArgent, sousSection, ordreSection,
                  numeroLigne, prixOrigine, type, visible, commande, quote, recu, retour, noRetour, commandeAnnulee,
                  dateReception, quantiteRecue, facturation, id, pieceExtra, pieceExtraChargeable, pieceExtraNonChargeable,
                  dateCommande, dateRequise, nomCommande, noSequentiel, materielInutile, commentaire, dateRetour, provenance, devise)
        {
        }
    }
    public class DB_ProjetPiecesTampon : DB_ProjetPiece
    {
        public new int NoEnreg;
        public string DateCopie;
        public string Initiales;
        public DB_ProjetPiecesTampon() { }
        public DB_ProjetPiecesTampon(int noEnreg, string dateCopie, string initiales)
        {
            NoEnreg = noEnreg;
            DateCopie = dateCopie;
            Initiales = initiales;
        }
        /// héritage polymorphique de DB_ProjetPiece 
        public DB_ProjetPiecesTampon(int noEnreg, string idprojet, int idsection, string numItem, string qte, string descFr,
            string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps, string tempsTotal,
            string prixTotal, string profitPourcent, string profitArgent, string sousSection, string ordreSection, int numeroLigne,
            string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour, string noRetour,
            bool commandeAnnulee, string dateReception, string quantiteRecue, string facturation, string id, bool pieceExtra,
            bool pieceExtraChargeable, bool pieceExtraNonChargeable, string dateCommande, string dateRequise, string nomCommande,
            string noSequentiel, bool materielInutile, string commentaire, string dateRetour, string provenance, string devise)
            : base(noEnreg, idprojet, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs, temps,
                  tempsTotal, prixTotal, profitPourcent, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine, type,
                  visible, commande, quote, recu, retour, noRetour, commandeAnnulee, dateReception, quantiteRecue, facturation, id,
                  pieceExtra, pieceExtraChargeable, pieceExtraNonChargeable, dateCommande, dateRequise, nomCommande, noSequentiel,
                  materielInutile, commentaire, dateRetour, provenance, devise)
        {
        }
        /// héritage polymorphique de DB_ProjetPiece
        public DB_ProjetPiecesTampon(int noEnreg, string idprojet, int idsection, string numItem, string qte, string descFr,
                    string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps, string tempsTotal,
                    string prixTotal, string profitPourcent, string profitArgent, string sousSection, string ordreSection, int numeroLigne,
                    string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour, string noRetour,
                    bool commandeAnnulee, string dateReception, string quantiteRecue, string facturation, string id, bool pieceExtra,
                    bool pieceExtraChargeable, bool pieceExtraNonChargeable, string dateCommande, string dateRequise, string nomCommande,
                    string noSequentiel, bool materielInutile, string commentaire, string dateRetour, string provenance, string devise,
                    string dateCopie, string initiales)
                    : base(noEnreg, idprojet, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs,
  temps, tempsTotal, prixTotal, profitPourcent, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine,
  type, visible, commande, quote, recu, retour, noRetour, commandeAnnulee, dateReception, quantiteRecue, facturation,
  id, pieceExtra, pieceExtraChargeable, pieceExtraNonChargeable, dateCommande, dateRequise, nomCommande, noSequentiel,
  materielInutile, commentaire, dateRetour, provenance, devise)
        {
            DateCopie = dateCopie;
            Initiales = initiales;
        }
    }
    public class DB_ProjetsDessin
    {
        public string NoProjet;
        public DB_ProjetsDessin() { }
        public DB_ProjetsDessin(string noProjet)
        {
            NoProjet = noProjet;
        }
    }
    public class DB_ProjetTamponBack : DB_ProjetPiecesTampon
    {
        public new int? NoEnreg;
        public DB_ProjetTamponBack() { }
        public DB_ProjetTamponBack(int noEnreg, string dateCopie, string initiales)
            : base(noEnreg, dateCopie, initiales) { }
        public DB_ProjetTamponBack(int noEnreg, string idprojet, int idsection, string numItem, string qte, string descFr,
            string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps,
            string tempsTotal, string prixTotal, string profitPourcent, string profitArgent, string sousSection, string ordreSection,
            int numeroLigne, string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour,
            string noRetour, bool commandeAnnulee, string dateReception, string quantiteRecue, string facturation, string id,
            bool pieceExtra, bool pieceExtraChargeable, bool pieceExtraNonChargeable, string dateCommande, string dateRequise,
            string nomCommande, string noSequentiel, bool materielInutile, string commentaire, string dateRetour, string provenance,
            string devise)
            : base(noEnreg, idprojet, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs, temps,
                  tempsTotal, prixTotal, profitPourcent, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine, type,
                  visible, commande, quote, recu, retour, noRetour, commandeAnnulee, dateReception, quantiteRecue, facturation, id,
                  pieceExtra, pieceExtraChargeable, pieceExtraNonChargeable, dateCommande, dateRequise, nomCommande, noSequentiel,
                  materielInutile, commentaire, dateRetour, provenance, devise)
        { }
        public DB_ProjetTamponBack(int noEnreg, string idprojet, int idsection, string numItem, string qte, string descFr,
            string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps, string tempsTotal,
            string prixTotal, string profitPourcent, string profitArgent, string sousSection, string ordreSection, int numeroLigne,
            string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour, string noRetour,
            bool commandeAnnulee, string dateReception, string quantiteRecue, string facturation, string id, bool pieceExtra,
            bool pieceExtraChargeable, bool pieceExtraNonChargeable, string dateCommande, string dateRequise, string nomCommande,
            string noSequentiel, bool materielInutile, string commentaire, string dateRetour, string provenance, string devise,
            string dateCopie, string initiales)
            : base(noEnreg, idprojet, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs,
                  temps, tempsTotal, prixTotal, profitPourcent, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine,
                  type, visible, commande, quote, recu, retour, noRetour, commandeAnnulee, dateReception, quantiteRecue, facturation,
                  id, pieceExtra, pieceExtraChargeable, pieceExtraNonChargeable, dateCommande, dateRequise, nomCommande, noSequentiel,
                  materielInutile, commentaire, dateRetour, provenance, devise, dateCopie, initiales)
        {
        }
    }
    public class DB_ProjSoum
    {
        public string IdprojSoum;
        public int NoClient;
        public string DateOuverture;
        public string DateFermeture;
        public string RaisonFermeture;
        public bool Ouvert;
        public bool Verrouille;
        public string Type;
        public string Description;
        public DB_ProjSoum() { }
        public DB_ProjSoum(string idprojSoum, int noClient, string dateOuverture, string dateFermeture, string raisonFermeture,
            bool ouvert, bool verrouille, string type, string description)
        {
            IdprojSoum = idprojSoum;
            NoClient = noClient;
            DateOuverture = dateOuverture;
            DateFermeture = dateFermeture;
            RaisonFermeture = raisonFermeture;
            Ouvert = ouvert;
            Verrouille = verrouille;
            Type = type;
            Description = description;
        }
    }
    public class DB_Punch : DB_PunchExcel
    {
        public string Date;
        public bool ModifDebut;
        public bool ModifFin;
        public string Commentaire;
        public bool Facture;
        public string NoFacture;
        public string NoClient;
        public bool Km;
        public string NbreKm;
        public string Type;
        public DB_Punch() { }
        public DB_Punch(int idpunch, int noEmploye, string noProjet, string heureDebut, string heureFin, string date,
            bool modifDebut, bool modifFin, string commentaire, bool facture, string noFacture, string noClient, bool km,
            string nbreKm, string type)
            : base(idpunch, noEmploye, noProjet, heureDebut, heureFin)
        {
            Date = date;
            ModifDebut = modifDebut;
            ModifFin = modifFin;
            Commentaire = commentaire;
            Facture = facture;
            NoFacture = noFacture;
            NoClient = noClient;
            Km = km;
            NbreKm = nbreKm;
            Type = type;
        }
        public DB_Punch(string date, bool modifDebut, bool modifFin, string commentaire, bool facture, string noFacture,
                    string noClient, bool km, string nbreKm, string type)
        {
            Date = date;
            ModifDebut = modifDebut;
            ModifFin = modifFin;
            Commentaire = commentaire;
            Facture = facture;
            NoFacture = noFacture;
            NoClient = noClient;
            Km = km;
            NbreKm = nbreKm;
            Type = type;
        }
        public DB_Punch(int idpunch, int noEmploye, string noProjet, string heureDebut, string heureFin)
                    : base(idpunch, noEmploye, noProjet, heureDebut, heureFin)
        {
        }
    }
    public class DB_PunchExcel
    {
        public int Idpunch;
        public int NoEmploye;
        public string NoProjet;
        public string HeureDebut;
        public string HeureFin;
        public DB_PunchExcel() { }
        public DB_PunchExcel(int idpunch, int noEmploye, string noProjet, string heureDebut, string heureFin)
        {
            Idpunch = idpunch;
            NoEmploye = noEmploye;
            NoProjet = noProjet;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
        }
    }
    public class DB_SortieMateriel
    {
        public int Idsortie;
        public string Qte;
        public string Nom;
        public string NoProjet;
        public string NoItem;
        public string Date;
        public string Type;
        public DB_SortieMateriel() { }
        public DB_SortieMateriel(int idsortie, string qte, string nom, string noProjet, string noItem, string date, string type)
        {
            Idsortie = idsortie;
            Qte = qte;
            Nom = nom;
            NoProjet = noProjet;
            NoItem = noItem;
            Date = date;
            Type = type;
        }
    }
    public class DB_Soumission
    {
        public string Idsoumission;
        public int Idclient;
        public int Idcontact;
        public string Description;
        public string PanneauAire;
        public string PanneauEspace;
        public string NbreManuel;
        public string Floorstock;
        public string Transport;
        public string Marqueur;
        public string Delais;
        public string Creer;
        public int CreerPar;
        public string TempsDessin;
        public string TempsProgInterface;
        public string TempsFabrication;
        public string TempsAssemblage;
        public string TempsTest;
        public string TempsVision;
        public string TempsProgAutomate;
        public string TempsProgRobot;
        public string TempsInstallation;
        public string TempsMiseService;
        public string TempsFormation;
        public string TempsGestion;
        public string TempsShipping;
        public string NbrePersonne;
        public string TempsHebergement;
        public string TotalHebergement;
        public string TempsRepas;
        public string TotalRepas;
        public string TempsTransport;
        public string TempsUniteMobile;
        public string PrixEmballage;
        public string TauxDessin;
        public string TauxProgInterface;
        public string TauxFabrication;
        public string TauxAssemblage;
        public string TauxShipping;
        public string TauxHebergement1;
        public string TauxHebergement2;
        public string TauxRepas;
        public string TauxTransport;
        public string TauxUniteMobile;
        public string TotalPiece;
        public string Imprevue;
        public string TotalImprevue;
        public string TotalTemps;
        public string TotalManuel;
        public string Commission;
        public string TotalCommission;
        public string Profit;
        public string TotalProfit;
        public string PrixTotal;
        public bool SansTemps;
        public string Type;
        public string CheminPhotos;
        public bool Modification;
        public string Par;
        public string MontantForfait;
        public string InitialeForfait;
        public DB_Soumission() { }
        public DB_Soumission(string idsoumission, int idclient, int idcontact, string description, string panneauAire,
            string panneauEspace, string nbreManuel, string floorstock, string transport, string marqueur, string delais,
            string creer, int creerPar, string tempsDessin, string tempsProgInterface, string tempsFabrication,
            string tempsAssemblage, string tempsTest, string tempsVision, string tempsProgAutomate, string tempsProgRobot,
            string tempsInstallation, string tempsMiseService, string tempsFormation, string tempsGestion, string tempsShipping,
            string nbrePersonne, string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas,
            string tempsTransport, string tempsUniteMobile, string prixEmballage, string tauxDessin, string tauxProgInterface,
            string tauxFabrication, string tauxAssemblage, string tauxShipping, string tauxHebergement1, string tauxHebergement2,
            string tauxRepas, string tauxTransport, string tauxUniteMobile, string totalPiece, string imprevue, string totalImprevue,
            string totalTemps, string totalManuel, string commission, string totalCommission, string profit, string totalProfit,
            string prixTotal, bool sansTemps, string type, string cheminPhotos, bool modification, string par, string montantForfait,
            string initialeForfait)
        {
            Idsoumission = idsoumission;
            Idclient = idclient;
            Idcontact = idcontact;
            Description = description;
            PanneauAire = panneauAire;
            PanneauEspace = panneauEspace;
            NbreManuel = nbreManuel;
            Floorstock = floorstock;
            Transport = transport;
            Marqueur = marqueur;
            Delais = delais;
            Creer = creer;
            CreerPar = creerPar;
            TempsDessin = tempsDessin;
            TempsProgInterface = tempsProgInterface;
            TempsFabrication = tempsFabrication;
            TempsAssemblage = tempsAssemblage;
            TempsTest = tempsTest;
            TempsVision = tempsVision;
            TempsProgAutomate = tempsProgAutomate;
            TempsProgRobot = tempsProgRobot;
            TempsInstallation = tempsInstallation;
            TempsMiseService = tempsMiseService;
            TempsFormation = tempsFormation;
            TempsGestion = tempsGestion;
            TempsShipping = tempsShipping;
            NbrePersonne = nbrePersonne;
            TempsHebergement = tempsHebergement;
            TotalHebergement = totalHebergement;
            TempsRepas = tempsRepas;
            TotalRepas = totalRepas;
            TempsTransport = tempsTransport;
            TempsUniteMobile = tempsUniteMobile;
            PrixEmballage = prixEmballage;
            TauxDessin = tauxDessin;
            TauxProgInterface = tauxProgInterface;
            TauxFabrication = tauxFabrication;
            TauxAssemblage = tauxAssemblage;
            TauxShipping = tauxShipping;
            TauxHebergement1 = tauxHebergement1;
            TauxHebergement2 = tauxHebergement2;
            TauxRepas = tauxRepas;
            TauxTransport = tauxTransport;
            TauxUniteMobile = tauxUniteMobile;
            TotalPiece = totalPiece;
            Imprevue = imprevue;
            TotalImprevue = totalImprevue;
            TotalTemps = totalTemps;
            TotalManuel = totalManuel;
            Commission = commission;
            TotalCommission = totalCommission;
            Profit = profit;
            TotalProfit = totalProfit;
            PrixTotal = prixTotal;
            SansTemps = sansTemps;
            Type = type;
            CheminPhotos = cheminPhotos;
            Modification = modification;
            Par = par;
            MontantForfait = montantForfait;
            InitialeForfait = initialeForfait;
        }
    }
    public class DB_SoumissionElec : DB_Soumission
    {
        public string TauxTest;
        public string TauxVision;
        public string TauxProgAutomate;
        public string TauxProgRobot;
        public string TauxInstallation;
        public string TauxMiseService;
        public string TauxFormation;
        public string TauxGestion;
        public bool Csa;
        public bool Cul;
        public bool Ul;
        public bool Cur;
        public bool Ur;
        public bool Ce;
        public DB_SoumissionElec() { }
        public DB_SoumissionElec(string tauxTest, string tauxVision, string tauxProgAutomate, string tauxProgRobot,
            string tauxInstallation, string tauxMiseService, string tauxFormation, string tauxGestion, bool csa, bool cul,
            bool ul, bool cur, bool ur, bool ce)
        {
            TauxTest = tauxTest;
            TauxVision = tauxVision;
            TauxProgAutomate = tauxProgAutomate;
            TauxProgRobot = tauxProgRobot;
            TauxInstallation = tauxInstallation;
            TauxMiseService = tauxMiseService;
            TauxFormation = tauxFormation;
            TauxGestion = tauxGestion;
            Csa = csa;
            Cul = cul;
            Ul = ul;
            Cur = cur;
            Ur = ur;
            Ce = ce;
        }
        public DB_SoumissionElec(string idsoumission, int idclient, int idcontact, string description, string panneauAire,
                    string panneauEspace, string nbreManuel, string floorstock, string transport, string marqueur, string delais,
                    string creer, int creerPar, string tempsDessin, string tempsProgInterface, string tempsFabrication,
                    string tempsAssemblage, string tempsTest, string tempsVision, string tempsProgAutomate, string tempsProgRobot,
                    string tempsInstallation, string tempsMiseService, string tempsFormation, string tempsGestion, string tempsShipping,
                    string nbrePersonne, string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas,
                    string tempsTransport, string tempsUniteMobile, string prixEmballage, string tauxDessin, string tauxProgInterface,
                    string tauxFabrication, string tauxAssemblage, string tauxShipping, string tauxHebergement1, string tauxHebergement2,
                    string tauxRepas, string tauxTransport, string tauxUniteMobile, string totalPiece, string imprevue, string totalImprevue,
                    string totalTemps, string totalManuel, string commission, string totalCommission, string profit, string totalProfit,
                    string prixTotal, bool sansTemps, string type, string cheminPhotos, bool modification, string par, string montantForfait,
                    string initialeForfait)
                    : base(idsoumission, idclient, idcontact, description, panneauAire, panneauEspace, nbreManuel, floorstock, transport,
  marqueur, delais, creer, creerPar, tempsDessin, tempsProgInterface, tempsFabrication, tempsAssemblage, tempsTest,
  tempsVision, tempsProgAutomate, tempsProgRobot, tempsInstallation, tempsMiseService, tempsFormation, tempsGestion,
  tempsShipping, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport,
  tempsUniteMobile, prixEmballage, tauxDessin, tauxProgInterface, tauxFabrication, tauxAssemblage, tauxShipping,
  tauxHebergement1, tauxHebergement2, tauxRepas, tauxTransport, tauxUniteMobile, totalPiece, imprevue, totalImprevue,
  totalTemps, totalManuel, commission, totalCommission, profit, totalProfit, prixTotal, sansTemps, type, cheminPhotos,
  modification, par, montantForfait, initialeForfait)
        { }
        public DB_SoumissionElec(string idsoumission, int idclient, int idcontact, string description, string panneauAire,
            string panneauEspace, string nbreManuel, string floorstock, string transport, string marqueur, string delais,
            string creer, int creerPar, string tempsDessin, string tempsProgInterface, string tempsFabrication, string tempsAssemblage,
            string tempsTest, string tempsVision, string tempsProgAutomate, string tempsProgRobot, string tempsInstallation,
            string tempsMiseService, string tempsFormation, string tempsGestion, string tempsShipping, string nbrePersonne,
            string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport,
            string tempsUniteMobile, string prixEmballage, string tauxDessin, string tauxProgInterface, string tauxFabrication,
            string tauxAssemblage, string tauxShipping, string tauxHebergement1, string tauxHebergement2, string tauxRepas,
            string tauxTransport, string tauxUniteMobile, string totalPiece, string imprevue, string totalImprevue, string totalTemps,
            string totalManuel, string commission, string totalCommission, string profit, string totalProfit, string prixTotal,
            bool sansTemps, string type, string cheminPhotos, bool modification, string par, string montantForfait, string initialeForfait,
            string tauxTest, string tauxVision, string tauxProgAutomate, string tauxProgRobot, string tauxInstallation,
            string tauxMiseService, string tauxFormation, string tauxGestion, bool csa, bool cul, bool ul, bool cur, bool ur, bool ce)
            : base(idsoumission, idclient, idcontact, description, panneauAire, panneauEspace, nbreManuel, floorstock, transport,
                  marqueur, delais, creer, creerPar, tempsDessin, tempsProgInterface, tempsFabrication, tempsAssemblage, tempsTest,
                  tempsVision, tempsProgAutomate, tempsProgRobot, tempsInstallation, tempsMiseService, tempsFormation, tempsGestion,
                  tempsShipping, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport,
                  tempsUniteMobile, prixEmballage, tauxDessin, tauxProgInterface, tauxFabrication, tauxAssemblage, tauxShipping,
                  tauxHebergement1, tauxHebergement2, tauxRepas, tauxTransport, tauxUniteMobile, totalPiece, imprevue, totalImprevue,
                  totalTemps, totalManuel, commission, totalCommission, profit, totalProfit, prixTotal, sansTemps, type, cheminPhotos,
                  modification, par, montantForfait, initialeForfait)
        {
            TauxTest = tauxTest;
            TauxVision = tauxVision;
            TauxProgAutomate = tauxProgAutomate;
            TauxProgRobot = tauxProgRobot;
            TauxInstallation = tauxInstallation;
            TauxMiseService = tauxMiseService;
            TauxFormation = tauxFormation;
            TauxGestion = tauxGestion;
            Csa = csa;
            Cul = cul;
            Ul = ul;
            Cur = cur;
            Ur = ur;
            Ce = ce;
        }
    }
    public class DB_SoumissionMec : DB_Soumission
    {
        public string Manuel;
        public string TempsMachinage;
        public string TempsCoupe;
        public string TempsSoudure;
        public string TempsPeinture;
        public string TauxMachinage;
        public string TauxCoupe;
        public string TauxSoudure;
        public string TauxPeinture;
        public string TauxTest;
        public string TauxFormation;
        public string TauxInstallation;
        public string TauxGestion;
        public DB_SoumissionMec() { }
        public DB_SoumissionMec(string manuel, string tempsMachinage, string tempsCoupe, string tempsSoudure, string tempsPeinture,
            string tauxMachinage, string tauxCoupe, string tauxSoudure, string tauxPeinture, string tauxTest, string tauxFormation,
            string tauxInstallation, string tauxGestion)
        {
            Manuel = manuel;
            TempsMachinage = tempsMachinage;
            TempsCoupe = tempsCoupe;
            TempsSoudure = tempsSoudure;
            TempsPeinture = tempsPeinture;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxPeinture = tauxPeinture;
            TauxTest = tauxTest;
            TauxFormation = tauxFormation;
            TauxInstallation = tauxInstallation;
            TauxGestion = tauxGestion;
        }
        public DB_SoumissionMec(string idsoumission, int idclient, int idcontact, string description, string panneauAire,
                    string panneauEspace, string nbreManuel, string floorstock, string transport, string marqueur, string delais, string creer,
                    int creerPar, string tempsDessin, string tempsProgInterface, string tempsFabrication, string tempsAssemblage,
                    string tempsTest, string tempsVision, string tempsProgAutomate, string tempsProgRobot, string tempsInstallation,
                    string tempsMiseService, string tempsFormation, string tempsGestion, string tempsShipping, string nbrePersonne,
                    string tempsHebergement, string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport,
                    string tempsUniteMobile, string prixEmballage, string tauxDessin, string tauxProgInterface, string tauxFabrication,
                    string tauxAssemblage, string tauxShipping, string tauxHebergement1, string tauxHebergement2, string tauxRepas,
                    string tauxTransport, string tauxUniteMobile, string totalPiece, string imprevue, string totalImprevue, string totalTemps,
                    string totalManuel, string commission, string totalCommission, string profit, string totalProfit, string prixTotal,
                    bool sansTemps, string type, string cheminPhotos, bool modification, string par, string montantForfait, string initialeForfait)
                    : base(idsoumission, idclient, idcontact, description, panneauAire, panneauEspace, nbreManuel, floorstock, transport,
  marqueur, delais, creer, creerPar, tempsDessin, tempsProgInterface, tempsFabrication, tempsAssemblage, tempsTest,
  tempsVision, tempsProgAutomate, tempsProgRobot, tempsInstallation, tempsMiseService, tempsFormation, tempsGestion,
  tempsShipping, nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport,
  tempsUniteMobile, prixEmballage, tauxDessin, tauxProgInterface, tauxFabrication, tauxAssemblage, tauxShipping,
  tauxHebergement1, tauxHebergement2, tauxRepas, tauxTransport, tauxUniteMobile, totalPiece, imprevue, totalImprevue,
  totalTemps, totalManuel, commission, totalCommission, profit, totalProfit, prixTotal, sansTemps, type, cheminPhotos,
  modification, par, montantForfait, initialeForfait)
        { }
        public DB_SoumissionMec(string idsoumission, int idclient, int idcontact, string description, string panneauAire,
            string panneauEspace, string nbreManuel, string floorstock, string transport, string marqueur, string delais, string creer,
            int creerPar, string tempsDessin, string tempsProgInterface, string tempsFabrication, string tempsAssemblage, string tempsTest,
            string tempsVision, string tempsProgAutomate, string tempsProgRobot, string tempsInstallation, string tempsMiseService,
            string tempsFormation, string tempsGestion, string tempsShipping, string nbrePersonne, string tempsHebergement,
            string totalHebergement, string tempsRepas, string totalRepas, string tempsTransport, string tempsUniteMobile,
            string prixEmballage, string tauxDessin, string tauxProgInterface, string tauxFabrication, string tauxAssemblage,
            string tauxShipping, string tauxHebergement1, string tauxHebergement2, string tauxRepas, string tauxTransport,
            string tauxUniteMobile, string totalPiece, string imprevue, string totalImprevue, string totalTemps, string totalManuel,
            string commission, string totalCommission, string profit, string totalProfit, string prixTotal, bool sansTemps, string type,
            string cheminPhotos, bool modification, string par, string montantForfait, string initialeForfait, string manuel,
            string tempsMachinage, string tempsCoupe, string tempsSoudure, string tempsPeinture, string tauxMachinage, string tauxCoupe,
            string tauxSoudure, string tauxPeinture, string tauxTest, string tauxFormation, string tauxInstallation, string tauxGestion)
            : base(idsoumission, idclient, idcontact, description, panneauAire, panneauEspace, nbreManuel, floorstock, transport, marqueur,
                  delais, creer, creerPar, tempsDessin, tempsProgInterface, tempsFabrication, tempsAssemblage, tempsTest, tempsVision,
                  tempsProgAutomate, tempsProgRobot, tempsInstallation, tempsMiseService, tempsFormation, tempsGestion, tempsShipping,
                  nbrePersonne, tempsHebergement, totalHebergement, tempsRepas, totalRepas, tempsTransport, tempsUniteMobile, prixEmballage,
                  tauxDessin, tauxProgInterface, tauxFabrication, tauxAssemblage, tauxShipping, tauxHebergement1, tauxHebergement2, tauxRepas,
                  tauxTransport, tauxUniteMobile, totalPiece, imprevue, totalImprevue, totalTemps, totalManuel, commission, totalCommission,
                  profit, totalProfit, prixTotal, sansTemps, type, cheminPhotos, modification, par, montantForfait, initialeForfait)
        {
            Manuel = manuel;
            TempsMachinage = tempsMachinage;
            TempsCoupe = tempsCoupe;
            TempsSoudure = tempsSoudure;
            TempsPeinture = tempsPeinture;
            TauxMachinage = tauxMachinage;
            TauxCoupe = tauxCoupe;
            TauxSoudure = tauxSoudure;
            TauxPeinture = tauxPeinture;
            TauxTest = tauxTest;
            TauxFormation = tauxFormation;
            TauxInstallation = tauxInstallation;
            TauxGestion = tauxGestion;
        }
    }
    public class DB_SoumissionModif
    {
        public int Idmodif;
        public string Idsoumission;
        public int NoEmploye;
        public string Date;
        public string Heure;
        public string Type;
        public string TypeModif;
        public DB_SoumissionModif() { }
        public DB_SoumissionModif(int idmodif, string idsoumission, int noEmploye, string date, string heure, string type, string typeModif)
        {
            Idmodif = idmodif;
            Idsoumission = idsoumission;
            NoEmploye = noEmploye;
            Date = date;
            Heure = heure;
            Type = type;
            TypeModif = typeModif;
        }
    }
    public class DB_SoumissionPiece
    {
        public int NoEnreg;
        public string Idsoumission;
        public int Idsection;
        public string NumItem;
        public string Qte;
        public string DescFr;
        public string DescEn;
        public string Manufact;
        public string PrixList;
        public string Escompte;
        public string PrixNet;
        public int Idfrs;
        public string Temps;
        public string TempsTotal;
        public string PrixTotal;
        public string ProfitArgent;
        public string SousSection;
        public string OrdreSection;
        public int NumeroLigne;
        public string PrixOrigine;
        public string Type;
        public bool Visible;
        public bool Commande;
        public bool Quote;
        public bool Recu;
        public bool Retour;
        public bool CommandeAnnulee;
        public bool PieceExtra;
        public bool MaterielInutile;
        public string Commentaire;
        public bool PieceExtraNonChargeable;
        public bool PieceExtraChargeable;
        public string LiaisonChargeable;
        public string Id;
        public string Devise;
        public bool TransfertJob;
        public string Provenance;
        public DB_SoumissionPiece() { }
        public DB_SoumissionPiece(int noEnreg, string idsoumission, int idsection, string numItem, string qte, string descFr,
            string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string temps,
            string tempsTotal, string prixTotal, string profitArgent, string sousSection, string ordreSection, int numeroLigne,
            string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour, bool commandeAnnulee,
            bool pieceExtra, bool materielInutile, string commentaire, bool pieceExtraNonChargeable, bool pieceExtraChargeable,
            string liaisonChargeable, string id, string devise, bool transfertJob, string provenance)
        {
            NoEnreg = noEnreg;
            Idsoumission = idsoumission;
            Idsection = idsection;
            NumItem = numItem;
            Qte = qte;
            DescFr = descFr;
            DescEn = descEn;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Idfrs = idfrs;
            Temps = temps;
            TempsTotal = tempsTotal;
            PrixTotal = prixTotal;
            ProfitArgent = profitArgent;
            SousSection = sousSection;
            OrdreSection = ordreSection;
            NumeroLigne = numeroLigne;
            PrixOrigine = prixOrigine;
            Type = type;
            Visible = visible;
            Commande = commande;
            Quote = quote;
            Recu = recu;
            Retour = retour;
            CommandeAnnulee = commandeAnnulee;
            PieceExtra = pieceExtra;
            MaterielInutile = materielInutile;
            Commentaire = commentaire;
            PieceExtraNonChargeable = pieceExtraNonChargeable;
            PieceExtraChargeable = pieceExtraChargeable;
            LiaisonChargeable = liaisonChargeable;
            Id = id;
            Devise = devise;
            TransfertJob = transfertJob;
            Provenance = provenance;
        }
    }
    public class DB_SoumissionPiecesTampon : DB_SoumissionPiece
    {
        public string DateCopie;
        public string Initiales;
        public DB_SoumissionPiecesTampon() { }
        public DB_SoumissionPiecesTampon(string dateCopie, string initiales)
        {
            DateCopie = dateCopie;
            Initiales = initiales;
        }
        public DB_SoumissionPiecesTampon(int noEnreg, string idsoumission, int idsection, string numItem, string qte,
                    string descFr, string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs,
                    string temps, string tempsTotal, string prixTotal, string profitArgent, string sousSection, string ordreSection,
                    int numeroLigne, string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour,
                    bool commandeAnnulee, bool pieceExtra, bool materielInutile, string commentaire, bool pieceExtraNonChargeable,
                    bool pieceExtraChargeable, string liaisonChargeable, string id, string devise, bool transfertJob, string provenance)
                    : base(noEnreg, idsoumission, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs,
  temps, tempsTotal, prixTotal, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine, type, visible,
  commande, quote, recu, retour, commandeAnnulee, pieceExtra, materielInutile, commentaire, pieceExtraNonChargeable,
  pieceExtraChargeable, liaisonChargeable, id, devise, transfertJob, provenance)
        { }
        public DB_SoumissionPiecesTampon(int noEnreg, string idsoumission, int idsection, string numItem, string qte,
            string descFr, string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs,
            string temps, string tempsTotal, string prixTotal, string profitArgent, string sousSection, string ordreSection,
            int numeroLigne, string prixOrigine, string type, bool visible, bool commande, bool quote, bool recu, bool retour,
            bool commandeAnnulee, bool pieceExtra, bool materielInutile, string commentaire, bool pieceExtraNonChargeable,
            bool pieceExtraChargeable, string liaisonChargeable, string id, string devise, bool transfertJob, string provenance,
            string dateCopie, string initiales)
            : base(noEnreg, idsoumission, idsection, numItem, qte, descFr, descEn, manufact, prixList, escompte, prixNet, idfrs,
                  temps, tempsTotal, prixTotal, profitArgent, sousSection, ordreSection, numeroLigne, prixOrigine, type, visible,
                  commande, quote, recu, retour, commandeAnnulee, pieceExtra, materielInutile, commentaire, pieceExtraNonChargeable,
                  pieceExtraChargeable, liaisonChargeable, id, devise, transfertJob, provenance)
        {
            DateCopie = dateCopie;
            Initiales = initiales;
        }
    }
    public class DB_SoumProjSectionElec
    {
        public int Idsection;
        public string NomSectionFr;
        public string NomSectionEn;
        public int Ordre;
        public DB_SoumProjSectionElec() { }
        public DB_SoumProjSectionElec(int idsection, string nomSectionFr, string nomSectionEn, int ordre)
        {
            Idsection = idsection;
            NomSectionFr = nomSectionFr;
            NomSectionEn = nomSectionEn;
            Ordre = ordre;
        }
    }
    public class DB_SoumProjSectionMec
    {
        public int Idsection;
        public string NomSectionFr;
        public string NomSectionEn;
        public int Ordre;
        public DB_SoumProjSectionMec() { }
        public DB_SoumProjSectionMec(int idsection, string nomSectionFr, string nomSectionEn, int ordre)
        {
            Idsection = idsection;
            NomSectionFr = nomSectionFr;
            NomSectionEn = nomSectionEn;
            Ordre = ordre;
        }
    }
    public class DB_TableDesErreurs
    {
        public int No;
        public int Idclient;
        public string Date;
        public string Contact;
        public string Commentaire;
        public string EnregPar;
        public string Etat;
        public DB_TableDesErreurs() { }
        public DB_TableDesErreurs(int no, int idclient, string date, string contact, string commentaire, string enregPar, string etat)
        {
            No = no;
            Idclient = idclient;
            Date = date;
            Contact = contact;
            Commentaire = commentaire;
            EnregPar = enregPar;
            Etat = etat;
        }
    }
    public class DB_TblCategorie
    {
        public string Correspondance;
        public string Nom;
        public DB_TblCategorie() { }
        public DB_TblCategorie(string correspondance, string nom)
        {
            Correspondance = correspondance;
            Nom = nom;
        }
    }
    public class DB_TblPunchType
    {
        public string Mode;
        public string Name;
        public DB_TblPunchType() { }
        public DB_TblPunchType(string mode, string name)
        {
            Mode = mode;
            Name = name;
        }
    }
    public class DB_TempDp
    {
        public int Id;
        public string Piece;
        public int Ordre;
        public string Type;
        public DB_TempDp() { }
        public DB_TempDp(int id, string piece, int ordre, string type)
        {
            Id = id;
            Piece = piece;
            Ordre = ordre;
            Type = type;
        }
    }
    public class DB_TempInventaire
    {
        public int Idinventaire;
        public string NoItem;
        public string Description;
        public DB_TempInventaire() { }
        public DB_TempInventaire(int idinventaire, string noItem, string description)
        {
            Idinventaire = idinventaire;
            NoItem = noItem;
            Description = description;
        }
    }
    public class DB_Transport
    {
        public string Transports;
        public DB_Transport() { }
        public DB_Transport(string transports) => Transports = transports;
    }
    public class DB_Vendeur
    {
        public int No;
        public int Idclient;
        public string Date;
        public string Contact;
        public string Commentaire;
        public string EnregPar;
        public string Etat;
        public string Enregistrerpar;
        public string Type;
        public DB_Vendeur() { }
        public DB_Vendeur(int idclient, string date, string contact, string commentaire, string enregPar, string etat, string enregistrerpar, string type)
        {
            Idclient = idclient;
            Date = date;
            Contact = contact;
            Commentaire = commentaire;
            EnregPar = enregPar;
            Etat = etat;
            Enregistrerpar = enregistrerpar;
            Type = type;
        }
        public DB_Vendeur(int no, int idclient, string date, string contact, string commentaire, string enregPar, string etat,
                    string enregistrerpar, string type)
        {
            No = no;
            Idclient = idclient;
            Date = date;
            Contact = contact;
            Commentaire = commentaire;
            EnregPar = enregPar;
            Etat = etat;
            Enregistrerpar = enregistrerpar;
            Type = type;
        }
    }
    public class ServiceMail
    {
        public int Id;
        public string Expediteur;
        public string Destinataire;
        public string Mot2Passe;                    // Password vaut peut etre mieux le HardCoder?!?
        public string Sujet;
        public string AliasEmetteur;
        public string Corps = string.Empty;
        public ServiceMail(string Expediteur, string Destinataire, string MotDePasse = null, string Sujet = null, string aliasEmetteur = null)
        {
            Expediteur = Expediteur;
            Destinataire = Destinataire;
            Mot2Passe = MotDePasse;
            Sujet = Sujet;
            AliasEmetteur = aliasEmetteur;
        }
        public ServiceMail(string Expediteur, string Destinataire, string Password, string sujet)
        {
            Expediteur = Expediteur;
            Destinataire = Destinataire;
            Mot2Passe = Password;
            Sujet = sujet;
            AliasEmetteur = Program.IdNomEmploye+"@"+Environment.UserDomainName;
        }
        protected string ComposerEntete(ServiceMail serviceMail)
        {
            string Entete = $"From: {serviceMail.AliasEmetteur} \n";
            Entete += $"Email: {serviceMail.Expediteur}\n";
            Entete += $"Sujet:{serviceMail.Sujet}\n";
            return Entete;
        }
        protected string InsererCommande(ServiceMail serviceMail, int numeroCommande)
        {
            string commande = serviceMail.Corps;
            return commande;
        }
        protected void EnvoyerMail(ServiceMail email)
        {
            Corps = ComposerEntete(email);//    body += Question: \n + Comments.Text + \n;
            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(Expediteur, Mot2Passe);
                smtp.Timeout = 20000;
            }
            smtp.Send(Expediteur, Destinataire, Sujet, Corps);
        }
    }

    /// déclaration  classe ,structure ,declaration API
    public class ContexteAppli : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs;
        public DbSet<DB_Client> Clients;
        public DbSet<DB_Achats> Achats;
        public DbSet<DB_AchatPiece> AchatPieces;
        public DbSet<DB_Alarme> Alarmes;
        public DbSet<DB_AutorisationPunch> AutorisationPunchs;
        public DbSet<DB_BavardSuppression> BavardSuppressions;
        public DbSet<DB_BonsCommandesPiece> BonsCommandesPieces;
        public DbSet<DB_CatalogueElec> CatalogueElecs;
        public DbSet<DB_CatalogueMec> CatalogueMecs;
        public DbSet<DB_Commentaire> Commentaires;
        public DbSet<DB_Config> Configs;
        public DbSet<DB_Contacts> Contacts;
        public DbSet<DB_ContactClient> ContactClients;
        public DbSet<DB_ContactFr> ContactFrs;
        public DbSet<DB_Cedule> Cedules;
        public DbSet<DB_Dessin> Dessins;
        public DbSet<DB_Doublon> Doublons;
        public DbSet<DB_Employe> Employes;
        public DbSet<DB_Erreur> Erreurs;
        public DbSet<DB_ExceptionsDl> ExceptionsDls;
        public DbSet<DB_Famille> Familles;
        public DbSet<DB_Fournisseur> Fournisseurs;
        public DbSet<DB_Groupes> Groupes;
        public DbSet<DB_ImpressionBonlivraison> ImpressionBonLivraisons;
        public DbSet<DB_ImpressionDemandePrixElec> ImpressionDemandePrixElecs;
        public DbSet<DB_ImpressionDemandePrixMec> ImpressionDemandePrixMecs;
        public DbSet<DB_ImpressionDetailTemp> ImpressionDetailTemps;
        public DbSet<DB_ImpressionListePiece> ImpressionListePieces;
        public DbSet<DB_ImpressionPoste> ImpressionPostes;
        public DbSet<DB_ImpressionPunch> ImpressionPunchs;
        public DbSet<DB_ImpressionSommairePunchGeneral> ImpressionSommairePunchGenerals;
        public DbSet<DB_ImpressionSommairePunchGrb> ImpressionSommairePunchs;
        public DbSet<DB_ImpressionSoumission> ImpressionSoumissions;
        public DbSet<DB_InventaireElec> InventaireElecs;
        public DbSet<DB_InventaireElecModif> InventaireElecModifs;
        public DbSet<DB_InventaireMec> InventaireMecs;
        public DbSet<DB_InventaireMecModif> InventaireMecModifs;
        public DbSet<DB_Outils> Outils;
        public DbSet<DB_OutilsInOut> OutilsInOuts;
        public DbSet<DB_PiecesFr> PiecesFrs;
        public DbSet<DB_ProjSoum> ProjSoums;
        public DbSet<DB_ProjetElec> ProjetElecs;
        public DbSet<DB_ProjetMec> ProjetMecs;
        public DbSet<DB_ProjetModif> ProjetModifs;
        public DbSet<DB_ProjetPiece> ProjetPieces;
        public DbSet<DB_ProjetPiecesTampon> ProjetPiecesTampons;
        public DbSet<DB_ProjetsDessin> ProjetsDessins;
        public DbSet<DB_Punch> Punchs;
        public DbSet<DB_PunchExcel> PunchExcels;
        public DbSet<DB_SortieMateriel> SortieMateriels;
        public DbSet<DB_SoumProjSectionElec> SoumProjSectionElecs;
        public DbSet<DB_SoumProjSectionMec> SoumProjSectionMecs;
        public DbSet<DB_SoumissionElec> SoumissionElecs;
        public DbSet<DB_SoumissionMec> SoumissionMecs;
        public DbSet<DB_SoumissionModif> SoumissionModifs;
        public DbSet<DB_SoumissionPiece> SoumissionPieces;
        public DbSet<DB_SoumissionPiecesTampon> SoumissionPiecesTampons;
        public DbSet<DB_TempDp> TempDps;
        public DbSet<DB_TempInventaire> TempInventaires;
        public DbSet<DB_Transport> Transports;
        public DbSet<DB_Vendeur> Vendeurs;
        public DbSet<DB_ProjetPieceBack> ProjetPieceBacks;
        public DbSet<DB_ProjetTamponBack> ProjetTamponBacks;
        public DbSet<DB_TableDesErreurs> TableDesErreurs;
        public DbSet<DB_TblPunchType> TblPunchTypes;
        public DbSet<DB_TblCategorie> TblCategorie;
        public DbSet<DB_ImpressionListePiece> IimpressionListePiece;
        public DbSet<DB_AchatPiecesTampon> Achat_Pieces_Tampon;
    }
    internal partial class Program
    {
        public enum EnumCatalogue { ELECTRIQUE = 0, MECANIQUE = 1 }
        public enum EnumConvert { MODE_PAS_FORMAT = 0, MODE_DECIMAL = 1, MODE_ARGENT = 2, MODE_POURCENT = 3 }
        public enum EnumDate { AUCUNE = 0, DEBUT = 1, FIN = 2 }
        public enum EnumExtra { AUCUN_EXTRA = 0, EXTRA_CHARGEABLE = 1, EXTRA_NON_CHARGEABLE = 2 }
        public enum EnumDeplacement { I_AUCUN = 0, I_PRECEDENT = 1, I_SUIVANT = 2 }
        public enum EnumForm { FRM_CLIENTS = 0, FRM_FRS = 1, FRM_CONTACTS = 2 }
        public enum EnumFormSource { I_PROJET_MEC = 0, I_PROJET_ELEC = 1, I_ACHAT_MEC = 2, I_ACHAT_ELEC = 3, I_INVENTAIRE_MEC = 4, I_INVENTAIRE_ELEC = 5, I_RETOUR_MARCHANDISE = 6 }
        public enum EnumImpressionRetour { MODE_DEMANDE_RETOUR = 0, MODE_RETOUR = 1 }
        public enum EnumLangage { FRANCAIS = 0, ANGLAIS = 1 }
        public enum EnumLangueFax { FAX_FRANCAIS = 0, FAX_ANGLAIS = 1 }
        public enum EnumModeCherche { MODE_DATE = 0, MODE_CLIENT = 1 }
        public enum TypeFormatSortieFichier { ID_EXCEL = 0, ID_TEXT = 1, ID_LOG = 2,
            ID_EXCEL_XLSX = 3
        }
        public enum EnumPunch { I_PUNCH_IN = 0, I_PUNCH_OUT = 1, I_MODIF_PUNCH_IN = 2, I_MODIF_PUNCH_OUT = 3 }
        public enum EnumImpressionInventaire { MODE_AJUST_INV = 0, MODE_VAL_COMPTABLE = 1 }
        public enum EnumMode { MODE_AJOUT = 0, MODE_MODIF = 1, MODE_MODIF_NON_AUTORISE = 2, MODE_INACTIF = 3, MODE_CONTACT = 4, MODE_AJOUT_MODIF = 5, FOURNISSEUR = 6, PIECE = 7, CATEGORIE = 8, NOUVELLE_PIECE = 9, MANUFACTURIER = 10 }
        public enum EnumModeCatalogueMec { MODE_AJOUT_MODIF_MEC = 0, MODE_INACTIF = 1, MODE_AJOUT_MODIF_FRS = 2 }
        public enum EnumType{TYPE_PROJET = 0, TYPE_SOUMISSION = 1, ACHAT = 2}
        public enum EnumTypeReception { PROJET = 0, ACHAT = 1 }
        public enum EnumModeDemande { MODE_PIECE = 0, MODE_FOURNISSEUR = 1, MODE_CATEGORIE = 2, MODE_NOUVELLE = 3 }
        public enum EnumTypeRetour { PROJET = 0, ACHAT = 1 }
        public enum EnumModeCatalogueElec{MODE_AJOUT_MODIF_ELEC = 0,MODE_INACTIF = 1,MODE_AJOUT_MODIF_FRS = 2}
        public struct CopiePiece
        {
            public bool bChecked;
            public string sQuantite;
            public string sPiece;
            public string sDescr;
            public string sManufact;
            public string sPrixList;
            public string sEscompte;
            public string sPrixNet;
            public string sFRS;
            public string sTemps;
            public string sMontage;
            public string sTotal;
            public string sProfit;
            public string sDescrTag;
            public string sPrixListTag;
            public string sFRSTag;
            public System.Drawing.Color lColor;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFOEX
        {
            public STARTUPINFO StartupInfo;
            public IntPtr lpAttributeList;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public int wShowWindow;
            public int cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }
        public struct RECT
        {
            private long left;
            private long top;
            private long right;
            private long bottom;
            public RECT(long right, long left, long top, long bottom) : this()
            {
                Right = right;
                Left = left;
                Top = top;
                Bottom = bottom;
            }
            public long Right { get => right; set => right = value; }
            public long Left { get => left; set => left = value; }
            public long Top { get => top; set => top = value; }
            public long Bottom { get => bottom; set => bottom = value; }
        }
        const uint EXTENDED_STARTUPINFO_PRESENT = 0x00080000;
        [DllImport("user32")] private static extern int EnumWindows(int lpEnumFunc, int lParam);
        [DllImport("user32", EntryPoint = "GetWindowTextA")] private static extern int GetWindowText(int hwnd, string lpString, int cch);
        [DllImport("user32")] private static extern int IsWindowVisible(int hwnd);
        [DllImport("user32")] private static extern int GetParent(int hwnd);
        [DllImport("user32")] public static extern int FlashWindow(int hwnd, int bInvert);
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteA")] public static extern int ShellExecute(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        [DllImport("kernel32")] public static extern int GetUserDefaultLCID();
        [DllImport("kernel32", EntryPoint = "GetLocaleInfoA")] public static extern int GetLocaleInfo(int Locale, int LCType, string lpLCData, int cchData);
        [DllImport("user32", EntryPoint = "TrackPopupMenu")] public static extern long PopupMenu(long hMenu, long wFlags, long x, long y, long nReserved, long hwnd, RECT lprc);
        [DllImport("user32", EntryPoint = "GetClientRect")] public static extern long GetClientRect(long hwnd, RECT lpRect);
        [DllImport("kernel32.dll")][return: MarshalAs(UnmanagedType.Bool)] static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFOEX lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);
        [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] private static extern bool UpdateProcThreadAttribute(out IntPtr lpAttributeList, uint dwFlags, IntPtr Attribute, IntPtr lpValue, IntPtr cbSize, IntPtr lpPreviousValue, IntPtr lpReturnSize);
        [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] private static extern bool InitializeProcThreadAttributeList(out IntPtr lpAttributeList, int dwAttributeCount, int dwFlags, ref IntPtr lpSize);
        internal static PROCESS_INFORMATION pInfo = new PROCESS_INFORMATION();
        internal static SECURITY_ATTRIBUTES pSec = new SECURITY_ATTRIBUTES();
        internal static SECURITY_ATTRIBUTES tSec = new SECURITY_ATTRIBUTES();
        static STARTUPINFOEX sInfoEx = new STARTUPINFOEX();       
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)] public static extern int GetLongPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder longPath, int longPathLength);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)] public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);
        [DllImport("shell32.dll", CharSet = CharSet.Auto)] public static extern int ExtractIconEx(string path, int i, IntPtr[] small, IntPtr[] big, uint op);
        internal static Color SkinFond = System.Drawing.Color.GhostWhite;
        internal static Color SkinAvant = System.Drawing.Color.DarkBlue;
        internal static Icon Skinicone = global::ControleurServeur.Properties.Resources.CTRCAN;
        public static StreamWriter swSQL = new StreamWriter($"{Tests}@suiviSQL.log", true);
        internal static string Tests = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        static Bitmap memoryImage;
        /// configuration basique 
        public static Connection odbc = new Connection();
        public static List<UtilisateurActifs> utilisateursActifs = new List<UtilisateurActifs>();
        internal static  string RootExcel = "\\\\production.grb.local\\C$\\inetpub\\wwwroot\\AutoGRB\\expExcel\\";
        internal static string dirCheminPhotos = "\\\\production.grb.local\\C$\\inetpub\\wwwroot\\AutoGRB\\images\\Photos";
        public static List<WebUtilisateurActifs> utilisateurs = new List<WebUtilisateurActifs>();
        internal static List<ListItem> fournisseurs = new List<ListItem>();
        internal static List<ListItem> CatégorieFournisseur = new List<ListItem>();
        internal static List<ListItem> clients = new List<ListItem>();
        internal static List<ListItem> manufacturiers = new List<ListItem>();
        internal static List<DB_Employe> Employes = new List<DB_Employe>();
        internal static DB_Employe Utilisateur;
        internal static List<DB_AchatPiece> AchatPieces;
        internal static List<DB_AchatPiecesTampon> Achat_Pieces_Tampon;
        internal static List<DB_Achats> ACHAT;
        internal static List<DB_Alarme> Alarmes;
        internal static List<DB_AutorisationPunch> AutorisationPunch;
        internal static List<DB_BavardSuppression> BavardSuppression;
        internal static List<DB_BonsCommandesCommande> BonsCommandes;
        internal static List<DB_BonsCommandesPiece> BonsCommandesPieces;
        internal static List<DB_CatalogueElec> CatalogueElec;
        internal static List<DB_CatalogueMec> CatalogueMec;
        internal static List<DB_Cedule> cedules;
        internal static List<DB_Client> Clients;
        internal static List<DB_Commentaire> Commentaires;
        internal static List<DB_Config> CONFIG;
        internal static List<DB_ContactClient> ContactClient;
        internal static List<DB_ContactFr> ContactFrs;
        internal static List<DB_Contacts> Contacts;
        internal static List<DB_Dessin> Dessins;
        internal static List<DB_Erreur> Erreurs;
        internal static List<DB_ExceptionsDl> ExceptionsDl;
        internal static List<DB_Famille> Famille;
        internal static List<DB_Fournisseur> Fournisseurs;
        internal static List<DB_Groupes> Groupes;
        internal static List<DB_ImpressionBonlivraison> bonlivraisons;
        internal static List<DB_ImpressionBonlivraison> bonTravail;
        internal static List<DB_ImpressionDemandePrixElec> ImpressionDemandePrixElec;
        internal static List<DB_ImpressionDemandePrixMec> ImpressionDemandePrixMec;
        internal static List<DB_ImpressionDetailTemp> ImpressionDetailTemps;
        internal static List<DB_ImpressionListePiece> ImpressionListePiece;
        internal static List<DB_ImpressionPoste> ImpressionPoste;
        internal static List<DB_ImpressionPunch> ImpressionPunch;
        internal static List<DB_ImpressionSommairePunch> ImpressionSommairePunch;
        internal static List<DB_ImpressionSommairePunchGeneral> ImpressionSommairePunchGeneral;
        internal static List<DB_ImpressionSommairePunchGrb> ImpressionSommairePunchGrb;
        internal static List<DB_ImpressionSoumission> ImpressionSoumission;
        internal static List<DB_InventaireElec> InventaireElecs;
        internal static List<DB_InventaireElecModif> InventaireElecModif;
        internal static List<DB_InventaireMec> InventaireMecs;
        internal static List<DB_InventaireMecModif> InventaireMecModif;
        internal static List<DB_OutilsInOut> OutilsInOut;
        internal static List<DB_Outlook> Outlook;
        internal static List<DB_PiecesFr> PiecesFrs;
        internal static List<DB_ProjetElec> ProjetElec;
        internal static List<DB_ProjetMec> ProjetMecs;
        internal static List<DB_ProjetModif> ProjetModif;
        internal static List<DB_ProjetPiece> ProjetPieces;
        internal static List<DB_ProjetPieceBack> ProjetPieceBacks;
        internal static List<DB_ProjetPiecesTampon> ProjetPiecesTampon;
        internal static List<DB_ProjetsDessin> ProjetsDessins;
        internal static List<DB_ProjetTamponBack> ProjetPiecesBack;
        internal static List<DB_ProjetTamponBack> ProjetTamponBacks;
        internal static List<DB_ProjSoum> ProjSoum;
        internal static List<DB_Punch> Punch;
        internal static List<DB_PunchExcel> PunchExcel;
        internal static List<DB_SortieMateriel> SortieMateriel;
        internal static List<DB_SoumissionElec> SoumissionElecs;
        internal static List<DB_SoumissionMec> SoumissionMecs;
        internal static List<DB_SoumissionModif> SoumissionModifs;
        internal static List<DB_SoumissionPiece> SoumissionPieces;
        internal static List<DB_SoumissionPiecesTampon> SoumissionPiecesTampons;
        internal static List<DB_SoumProjSectionElec> SoumProjSectionElec;
        internal static List<DB_SoumProjSectionMec> SoumProjSectionMec;
        internal static List<DB_TableDesErreurs> TableDesErreurs;
        internal static List<DB_TblCategorie> TblCategories;
        internal static List<DB_TblPunchType> TblPunchTypes;
        internal static List<DB_TempDp> TempDp;
        internal static List<DB_TempInventaire> TempInventaire;
        internal static List<DB_Transport> Transports;
        internal static List<DB_Vendeur> Vendeurs;
        internal static List<ListItem> Catégorie;
        internal static List<ListItem> clients1;
        internal static List<ListItem> Contactsfr;
        internal static List<ListItem> frs;
        internal static List<Outil> Outils;
        internal static List<WebUtilisateurActifs> users;
        internal static List<ListItem>  groupes= new List<ListItem>();
        internal static List<string> TablesSQL = new List<string>();
        public static SqlConnection con = new SqlConnection(StringSQL);
        internal static SqlCommand cmd;
        internal static SqlDataReader reader;
        public static string StringSQL= "Data Source=PRODUCTION\\SQLEXPRESS;Initial Catalog=AutoGRB;Integrated Security=false;Persist Security Info=True;User ID=sa; pwd=$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo;";
        public static bool GRB;
        public static bool Permaroute;
        internal static string  SqlNameDB= "AutoGRB";
          /// ne pas changer les controls d'identification
         internal static string S_GROUPE_DEFAUT = "Par défaut";
        internal static string S_GROUPE_ADMIN = "Administrateur";
        internal static string S_PASS_DEFAUT = "passe";
        public static int IdNoEmploye=0xFFF;
        public static string IdNomEmploye="Non Connecté";
        public static string IdLoginEmploye="Non Connecté";
        public static string IdPassEmploye="Non Connecté";
        public static string VersionDB="Non Connecté";
        public static int FacturationlvwProjetsItemsCount;
        public static string CheminBD;
        public static bool m_bValide;
        public static bool m_bAnnulerCopie;
        public static string m_sCategorieCopie="Non Connecté";
        public static dynamic IdFamille="Non Connecté";
        public static bool IdSatut;
        private static EnumTypeReception m_eTypeReception;
        private static string m_sNoProjet;
        private static string m_sIDAchat;
        private static string m_iIndexAchat;
        private static EnumCatalogue m_eCatalogue;
        internal static string m_datDebut;
        internal static string m_datFin;
        internal static EnumModeCatalogueElec m_eMode;
        internal static string m_sSelectCategorie;
        internal static string m_sSelectFabricant;
        internal static string m_sSelectNoItem;
        internal static string txtNoItemGRB;
        internal static string txtDescriptionFRText;
        internal static string cmbCategorieText;
        internal static bool g_bModificationClients;
        internal static bool g_bModificationListeDistribution;
        internal static bool g_bModificationFeuillesTemps;
        internal static bool g_bAffichageSoumissionsElec;
        internal static bool g_bAffichageProjetsElec;
        internal static bool g_bModificationProjetsElec;
        internal static bool g_bAffichageClients;
        internal static bool g_bAffichageFournisseurs;
        internal static bool g_bAffichageContacts;
        internal static bool g_bAffichageContactsVendeurs;
        internal static bool g_bAffichageRapports;
        internal static bool g_bAffichageEmployes;
        internal static bool g_bAffichageCedule;
        internal static bool g_bAffichageConfiguration;
        internal static bool g_bAffichagePunch;
        internal static bool g_bAffichageOutils;
        internal static bool g_bAffichageInventaireMec;
        internal static bool g_bAffichageCatalogueMec;
        internal static bool g_bAffichageSoumissionsMec;
        internal static bool g_bAffichageProjetsMec;
        internal static bool g_bAffichageInventaireElec;
        internal static bool g_bAffichageCatalogueElec;
        internal static bool g_bAffichageAchats;
        internal static bool g_bModificationFournisseurs;
        internal static bool g_bModificationContacts;
        internal static bool g_bModificationEmployes;
        internal static bool g_bModificationGroupes;
        internal static bool g_bModificationOutils;
        internal static bool g_bModificationFacturation;
        internal static bool g_bModificationBC;
        internal static bool g_bModificationPunchEmployes;
        internal static bool g_bModificationInventaireMec;
        internal static bool g_bModificationCatalogueMec;
        internal static bool g_bModificationSoumissionsMec;
        internal static bool g_bModificationProjetsMec;
        internal static bool g_bModificationInventaireElec;
        internal static bool g_bModificationCatalogueElec;
        internal static bool g_bModificationSoumissionsElec;
        internal static bool g_bSuppressionProjets;
        internal static bool g_bModificationReception;
        internal static bool g_bModificationRetourMarchandise;
        internal static bool g_bPunchSemaineAnterieure;
        internal static bool g_bVerrouillageTempsProjet;
        internal static bool g_bDeverrouillageTempsProjet;
        internal static bool g_admin;
        internal static int m_iIDClient;
        internal static string m_sDescription;
        internal static bool m_bTempsDejaOuvert;
        internal static bool g_bCeduleOuverte;
/// <summary>
// Tenir compte du fond d'interface pour ajuster les couleurs
/// </summary>
        internal static readonly Color COLOR_ROUGE = Color.Red;
        internal static readonly Color COLOR_ORANGE = Color.Orange;
        internal static readonly Color COLOR_VERT = Color.Lime;//modif du au fond noir dans les interfaces
        internal static readonly Color COLOR_MAGENTA = Color.Magenta;
        internal static readonly Color COLOR_JAUNE = Color.Yellow;
        internal static readonly Color COLOR_GRIS = Color.Gainsboro; //modif du au fond noir dans les interfaces
        internal static readonly Color COLOR_VERT_FORET = Color.ForestGreen;
        internal static readonly Color COLOR_BLEU = Color.Blue;
        internal static readonly Color COLOR_ROSE = Color.Pink;
        internal static readonly Color COLOR_BRUN = Color.Brown;
/// <summary>
        internal static readonly Color COLOR_NOIR = Color.Black;
//ne pas utiliser comme couleur dans la propriete .Forecolor car le fond est noir dans les interfaces
//pourrait introduire une fausse perception d'erreur car l'affichage est masqué par le fond
/// </summary>
        internal static readonly Color COLOR_CYAN = Color.Cyan;
        internal static readonly Color COLOR_BLANC = Color.White;
        private static readonly string S_CHEMIN_DEFAUT;
        internal static readonly object idNoEmploye;
        internal static int IdGroupe;
        public static string OutlookProfile;
        /// <summary>
        internal static Microsoft.Office.Interop.Outlook.Application OutlookApplication_definst ;
        // peut provoquer un message d'erreur si outlook 2016 &+ est deja actif du a une contrainte interne a outlook : SingleInstance //src microsoft learn office 
        //       internal static Excel.Application ExcelGlobal_definst = new Microsoft.Office.Interop.Excel.Application();
        /// </summary>
        internal static bool bChkactif;
        internal static dynamic g_sLocalisation;
        internal static bool g_bBonPasswd;
        internal static Form m_Source;
        internal static Microsoft.Office.Interop.Outlook.Application m_otlApp;
        internal static bool m_bAnnulerDistList;
        internal static bool m_bAnnuleImpression;
        internal static ChoixImpressionInventaire.enumImpressionInventaire m_eTypeImpression;
        internal static string g_sQteBoite;
        internal static bool g_bQteBoite;
        internal static EnumModeDemande m_eDemande;
        internal static bool m_bDemandeAnnuler;
        internal static bool modeDev;
        internal static DateTime m_datDateChoisie;
        internal static string webServer = "https://production.grb.local/autogrb";
        internal static string sqlServer = "production\\SQLEXPRESS";
        internal static bool isLandscape = true;       
        internal static Connection mdbodbc=new Connection();
        internal static string m_sTauxDessin;
        internal static int idFournisseur;
        internal static string[] NomMois = { "","janvier", "février", "mars", "avril", "mai", "juin", "juillet","août", "septembre", "octobre", "novembre", "décembre"};
        private static string[] NomJourSemaine= {"Dimanche","Lundi","Mardi","Mercredi","Jeudi","Vendredi","Samedi" };
        internal static string GetContactFournisseurID(string v)
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, $"SELECT [REP] FROM [DBO].[FOURNISSEUR] WHERE [DBO].[FOURNISSEUR].[NOMFOURNISSEUR]='{v}'");
            if (!rst.EOF)
            {
                return rst.Fields[0].Value;
            }
            return null;
        }
        internal static string AddNowToFileName()
        {
            DateTime dt = DateTime.Now;
            return $"{dt.Year}{dt.Month.ToString().PadLeft(2, '0')}{dt.Day.ToString().PadLeft(2, '0')}_{dt.Hour.ToString().PadLeft(2, '0')}{dt.Minute.ToString().PadLeft(2, '0')}{dt.Second.ToString().PadLeft(2, '0')}.csv";
        }
        internal static string GenererNomFichierByDateTime(string text, TypeFormatSortieFichier type)
        {
            DateTime dt = DateTime.Now;
            string str = string.Empty;
            string date = $"{dt.Year}{dt.Month.ToString().PadLeft(2, '0')}{dt.Day.ToString().PadLeft(2, '0')}";
            string heure = $"{dt.Hour.ToString().PadLeft(2, '0')}{dt.Minute.ToString().PadLeft(2, '0')}-{dt.Second.ToString().PadLeft(2, '0')}";
            String sType = "";
            switch (type)
            {
                case TypeFormatSortieFichier.ID_EXCEL: { sType = ".csv"; } break;
                case TypeFormatSortieFichier.ID_EXCEL_XLSX: { sType = ".xlsx"; } break;
                case TypeFormatSortieFichier.ID_TEXT: { sType = ".txt"; } break;
                case TypeFormatSortieFichier.ID_LOG: { sType = ".log"; } break;
            }
            if (text != "")
            {
                str = $"{Application.ProductName}{text}_{date}_{heure}";
            }
            else
            {
                str = $"{Tests}{text}_{date}_{heure}";
            }
            return str + sType;
        }
        internal static bool EstUnNombre(string Texte)
        {
            if (float.IsNaN(float.Parse(Texte)) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        internal static bool InitProcessSupport(int parentProcessId)
        {
            const int PROC_THREAD_ATTRIBUTE_PARENT_PROCESS = 0x00020000;
            sInfoEx.StartupInfo = new STARTUPINFO();
            if (parentProcessId > 0)
            {
                var lpSize = IntPtr.Zero;
                IntPtr dummyPtr;
                var success = InitializeProcThreadAttributeList(out dummyPtr, 1, 0, ref lpSize);
                if (success || lpSize == IntPtr.Zero) { return false; }
                sInfoEx.lpAttributeList = Marshal.AllocHGlobal(lpSize);
                if (sInfoEx.lpAttributeList == IntPtr.Zero) { return false; }
                success = InitializeProcThreadAttributeList(out sInfoEx.lpAttributeList, 1, 0, ref lpSize);
                if (!success) { return false; }
                var parentHandle = System.Diagnostics.Process.GetProcessById(parentProcessId).Handle;
                success = UpdateProcThreadAttribute(out sInfoEx.lpAttributeList, 0, (IntPtr)PROC_THREAD_ATTRIBUTE_PARENT_PROCESS, parentHandle, (IntPtr)IntPtr.Size, IntPtr.Zero, IntPtr.Zero);
                if (!success) { return false; }
                sInfoEx.StartupInfo.cb = Marshal.SizeOf(sInfoEx);
            }
            return true;
        }
        internal static void ImpressionFormulaire(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        public static bool CreateProcessTerminal(int parentProcessId)
        {
            pSec.nLength = Marshal.SizeOf(pSec);
            tSec.nLength = Marshal.SizeOf(tSec);
            var lpApplicationName = System.IO.Path.Combine(Environment.SystemDirectory, "cmd.exe");
            if (InitProcessSupport(parentProcessId))
            {
                return CreateProcess(lpApplicationName, null, ref pSec, ref tSec, false, EXTENDED_STARTUPINFO_PRESENT, IntPtr.Zero, null, ref sInfoEx, out pInfo);
            }
            else { return false; }
        }
        public static bool CreateProcess(int parentProcessId, string application)
        {
            pSec.nLength = Marshal.SizeOf(pSec);
            tSec.nLength = Marshal.SizeOf(tSec);
            if (InitProcessSupport(parentProcessId))
            {
                return CreateProcess(application, null, ref pSec, ref tSec, false, EXTENDED_STARTUPINFO_PRESENT, IntPtr.Zero, null, ref sInfoEx, out pInfo);
            }
            else { return false; }
        }
        internal static string GetNomJourDateFr(DayOfWeek dayOfWeek)
        {
            return NomJourSemaine[(int)dayOfWeek];
        }
        public static int GetNoMois(string sMois)
        {
            var iNoMois = default(int);
            sMois = sMois.ToUpper();
            switch (sMois ?? "")
            {
                case "JANVIER": { iNoMois = 1; break; }
                case "FÉVRIER": { iNoMois = 2; break; }
                case "MARS": { iNoMois = 3; break; }
                case "AVRIL": { iNoMois = 4; break; }
                case "MAI": { iNoMois = 5; break; }
                case "JUIN": { iNoMois = 6; break; }
                case "JUILLET": { iNoMois = 7; break; }
                case "AOÛT": { iNoMois = 8; break; }
                case "SEPTEMBRE": { iNoMois = 9; break; }
                case "OCTOBRE": { iNoMois = 10; break; }
                case "NOVEMBRE": { iNoMois = 11; break; }
                case "DÉCEMBRE": { iNoMois = 12; break; }
            }
            return iNoMois;
        }
        public static string GetNomMois(int sMois)
        {
            if ((sMois < 13) & (sMois > 0)){return NomMois[sMois];}
            return sMois.ToString();
        }
        public static DateTime GetDimancheDelaDate(DateTime dateTime)
        {
            int j = 0;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday: { j = 0; } break;
                case DayOfWeek.Monday: { j = -1; } break;
                case DayOfWeek.Tuesday: { j = -2; } break;
                case DayOfWeek.Wednesday: { j = -3; } break;
                case DayOfWeek.Thursday: { j = -4; } break;
                case DayOfWeek.Friday: { j = -5; } break;
                case DayOfWeek.Saturday: { j = -6; } break;
            }
            DateTime dt = dateTime.AddDays(j);
            m_datDebut = ConvertToUSDate(dt);
            m_datFin = ConvertToUSDate(dt.AddDays(6));
            return dt;
        }
        public static string GetSemaineDelaDate(DateTime dateTime)
        {
            //intégration condition si la semaine fini l'année d'après
            //ex.: 29-12-2024 au 04-01-2025
            int j = 0;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday: { j = 0; } break;
                case DayOfWeek.Monday: { j = -1; } break;
                case DayOfWeek.Tuesday: { j = -2; } break;
                case DayOfWeek.Wednesday: { j = -3; } break;
                case DayOfWeek.Thursday: { j = -4; } break;
                case DayOfWeek.Friday: { j = -5; } break;
                case DayOfWeek.Saturday: { j = -6; } break;
            }
            DateTime dt = dateTime.AddDays(j);
            m_datDebut = ConvertToUSDate(dt);
            m_datFin = ConvertToUSDate(dt.AddDays(6));
            if (dt.Year == dt.AddDays(6).Year)
            {
                if (dt.Month == dt.AddDays(6).Month)
                {
                    return $"Semaine du {dt.Day} au {dt.AddDays(6).ToLongDateString()}";
                }
                else
                {
                    return $"Semaine du {dt.Day} {NomMois[dt.Month]} au {dt.AddDays(6).ToLongDateString()}";
                }
            }
            else 
            {
                return $"Semaine du {dt.Day} {NomMois[dt.Month]} {dt.Year} au {dt.AddDays(6).ToLongDateString()}";
            }
        }
        public static int GetDecallage()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday: { return 0; }
                case DayOfWeek.Monday: { return -1; }
                case DayOfWeek.Tuesday: { return -2; }
                case DayOfWeek.Wednesday: { return -3; }
                case DayOfWeek.Thursday: { return -4; }
                case DayOfWeek.Friday: { return -5; }
                case DayOfWeek.Saturday: { return -6; }
            }
            return 0;
        }
        public static int GetDecallage(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday: { return 0; }
                case DayOfWeek.Monday: { return -1; }
                case DayOfWeek.Tuesday: { return -2; }
                case DayOfWeek.Wednesday: { return -3; }
                case DayOfWeek.Thursday: { return -4; }
                case DayOfWeek.Friday: { return -5; }
                case DayOfWeek.Saturday: { return -6; }
            }
            return 0;
        }
        public static string Now2String()
        {
            return $"{DateTime.Now.Year}{DateTime.Now.Month.ToString().PadLeft(2, '0')}{DateTime.Now.Day.ToString().PadLeft(2, '0')}-" +
                $"{DateTime.Now.Hour.ToString().PadLeft(2, '0')}{DateTime.Now.Minute.ToString().PadLeft(2, '0')}{DateTime.Now.Second.ToString().PadLeft(2, '0')}";
        }
        public static DateTime GetFirstDay(DateTime datDate)
        {
            int iNoJour = (int)DateAndTime.Weekday(datDate);
            while (iNoJour > 1)
            {
                datDate = DateTime.FromOADate(datDate.ToOADate()).AddDays(iNoJour--);
            }
            return datDate;
        }
        public static string GetDateTexte(DateTime datDate) => $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(datDate)} {DateAndTime.MonthName(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(datDate))} {System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(datDate)}";
        public static string GetDateTexte(string strDate)
        {
            DateTime datDate = DateAndTime.DateValue(strDate);
            return $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(datDate)} {DateAndTime.MonthName(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(datDate))} " +
                $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(datDate)}";
        }
        public static DateTime ConvertDateTexte(string strDate)
        {
            if (strDate.Length == 10)
            {
                string[] seg = strDate.Split('-');
                if (seg.Length == 3)
                {
                    return new DateTime(int.Parse(seg[0]), int.Parse(seg[1]), int.Parse(seg[2]));
                }
            }
            DateTime datDate = DateAndTime.DateValue(strDate);
            return datDate;
        }
        public static Microsoft.Office.Interop.Outlook.MAPIFolder GetFolder(Microsoft.Office.Interop.Outlook.Application otlApp, string sFolderName)
        {
            Microsoft.Office.Interop.Outlook.NameSpace oNS;
            var oFolder = default(Microsoft.Office.Interop.Outlook.MAPIFolder);
            bool bFolderFound = false;
            oNS = otlApp.GetNamespace("MAPI");
            foreach (Microsoft.Office.Interop.Outlook.MAPIFolder oPublicFolders in oNS.Folders)
            {
                if (oPublicFolders.Name.ToUpper() == "ARCHIVE FOLDERS" | oPublicFolders.Name.ToUpper() == "PUBLIC FOLDERS" | oPublicFolders.Name.ToUpper() == "DOSSIERS PUBLICS" | Strings.InStr(oPublicFolders.Name.ToUpper(), "DOSSIERS PUBLICS") > 0 | Strings.InStr(oPublicFolders.Name.ToUpper(), "PUBLIC FOLDERS") > 0)
                {
                    foreach (Microsoft.Office.Interop.Outlook.MAPIFolder oAllPublicFolders in oPublicFolders.Folders)
                    {
                        if (oAllPublicFolders.Name.ToUpper() == "ALL PUBLIC FOLDERS" | oAllPublicFolders.Name.ToUpper() == "TOUS LES DOSSIERS PUBLICS")
                        {
                            foreach (Microsoft.Office.Interop.Outlook.MAPIFolder currentOFolder in oAllPublicFolders.Folders)
                            {
                                oFolder = currentOFolder;
                                if (oFolder.Name.ToUpper() == sFolderName.ToUpper())
                                {
                                    bFolderFound = true;
                                    break;
                                }
                            }
                        }
                        if (bFolderFound == true) { break; }
                    }
                }
                if (bFolderFound == true) { break; }
            }
            return oFolder;
        }
        public static void BuildQuickMail(string Adressse, string Sujet, string CopieConforme, string Corps)
        {
            if (string.IsNullOrEmpty(Adressse)) { throw new ArgumentException($"« {nameof(Adressse)} » ne peut pas être vide ou avoir la valeur Null.", nameof(Adressse)); }
            if (string.IsNullOrEmpty(Sujet)) { throw new ArgumentException($"« {nameof(Sujet)} » ne peut pas être vide ou avoir la valeur Null.", nameof(Sujet)); }
            if (string.IsNullOrEmpty(Corps)) { throw new ArgumentException($"« {nameof(Corps)} » ne peut pas être vide ou avoir la valeur Null.", nameof(Corps)); }
            if (string.IsNullOrEmpty(CopieConforme))
            {
                System.Diagnostics.Process.Start($"mailto:{Adressse}?subject={Sujet}&body={Corps}");
            }
            else
            {
                System.Diagnostics.Process.Start($"mailto:{Adressse}?subject={Sujet}&cc={CopieConforme}&body={Corps}");
            }
        }
        public static string ConvertToUSDate(DateTime now) => $"{now.Year}-{now.Month.ToString().PadLeft(2, '0')}-{now.Day.ToString().PadLeft(2, '0')}";
        public static bool ValiderDate(string sDate) => Information.IsDate(sDate);
        public static bool ValiderHeure(string sHeure)
        {
            if (sHeure.Length != 10) return false;
            string[] seg = sHeure.Split(':');
            if (float.IsNaN(float.Parse(seg[0])) == true) return false;
            if (float.IsNaN(float.Parse(seg[1])) == true) return false;
            if (float.IsNaN(float.Parse(seg[2])) == true) return false;
            return true;
        }
        public static DateTime ConvertTexte2DateTime(String texte) => DateTime.Parse(texte);
        public static bool CompareIntervalDates(string text1, string text2)
        {
            if (DateTime.Compare(ConvertTexte2DateTime(text2), ConvertTexte2DateTime(text1)) > 0) return true;
            return false;
        }
        public static DateTime GetLastDay(DateTime datDate)
        {
            DateTime GetLastDayRet;
            int iNoJour = (int)datDate.DayOfWeek;
            while (iNoJour < 7)
            {
                datDate = DateTime.FromOADate(datDate.ToOADate()).AddDays(iNoJour++);
            }
            GetLastDayRet = datDate;
            return GetLastDayRet;
        }
        internal static double CalculestringervalTemps(string v1, string v2)
        {
            if (string.IsNullOrEmpty(v1)) { return 0d; }
            if (string.IsNullOrEmpty(v2)) { return 0d; }
            DateTime debut = DateAndTime.TimeValue(v1);
            DateTime fin = DateAndTime.TimeValue(v2);
            long dif = DateAndTime.DateDiff(DateInterval.Minute, debut, fin, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            return dif;
        }
        public static string AlerteBox(string sMessage) => $"<script language='javascript'>alert('{sMessage}');</script>";
        public static string newWindow(string url)
        {
            string tmp = "< script >";
            tmp += "var Main = window.open('" + url + "', '_blank', 'Width=1280px height=768px directories=no location=no menubar =no resizable =yes scrollbars=yes status=yes titlebar= yes toolbar=no');";
            tmp += "</ script >";
            return tmp;
        }
        public static void DisplayMessageErreur(Exception ex) => MessageBox.Show($"{ex.Message}\n{ex.StackTrace}\n{ex.Data}\n{ex.Source}\n", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        internal static int ConvertTexte2DateToInt(string text)
        {
            string[] valDate = text.Split(':');
            int val = int.Parse(valDate[0]) * 60 + int.Parse(valDate[1]);
            return val;
        }
        public static string GetFournisseurFromName(string Nom)
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT *  FROM [DBO].[Fournisseur] where [NomFournisseur]='{Nom}'", con).ExecuteReader();
            if (reader.Read())
            {
                return (string)reader[0];
            }
            con.Close();
            return "0";
        }
        public static string GetContactFromName(string Nom)
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT *  FROM [DBO].[Fournisseur] where [NomFournisseur]='{Nom}'", con).ExecuteReader();
            if (reader.Read())
            {
                return (string)reader[0];
            }
            con.Close();
            return "0";
        }
        internal static string GenererNomExportInventaire(string Prefixe) => $"{RootExcel}{Prefixe}_{ConvertToUSDate(DateTime.Now)}{DateTime.Now.ToShortTimeString().Replace(":", "").Replace("-", "")}.csv";
        public static string GetGroupes(int valeur)
        {
            if (Groupes.Count < 1)
            {
                EnumGroupes();
            }
            foreach (DB_Groupes p in Groupes)
            {
                if (p.Idgroupe == valeur)
                {
                    return p.NomGroupe;
                }
            }
            return "Non defini";
        }
        public static string GetLastIndex(string Table, string Collone)
        {
            string rep = "1";
            con = new SqlConnection(StringSQL);
            try
            {
                con.Open();
                SqlDataReader sqlData = new SqlCommand($"select top(1)[{Collone}] FROM [DBO].[{Table}] order by [{Collone}] desc", con).ExecuteReader();
                if (sqlData.Read())
                {
                    rep = sqlData[0].ToString();
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.Write(ex.Message); }
            con.Close();
            return rep;
        }
        public static string GetNextProjetIndex(string Table, string clef, string type)
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader reader = new SqlCommand($"select top(1)Right(Left(clef,6),5)+1 FROM [DBO].[Table] where left([{clef}],1) ='{type}' order by [{clef}] desc", sql).ExecuteReader();
            if (reader.Read())
            {
                return type + reader[0];
            }
            sql.Close();
            return clef;
        }
        public static string GetNextProjetNumber(string Table, string clef, string type)
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader reader = new SqlCommand($"select top(1)Right(Left(clef,6),5)+1 FROM [DBO].[Table] where left([{clef}],1) ='{type}' order by [{clef}] desc", sql).ExecuteReader();
            if (reader.Read())
            {
                return (string)reader[0];
            }
            sql.Close();
            return "1";
        }
        public static void AfficherChoixDateImpressionReception(string sNoProjet, EnumCatalogue eCatalogue, EnumTypeReception eTypeReception)
        {
            ///SoftIce  fired:  0x23534
            m_eTypeReception = eTypeReception;
            switch (eTypeReception)
            {
                case EnumTypeReception.PROJET: { m_sNoProjet = sNoProjet; break; }
                case EnumTypeReception.ACHAT:
                    {
                        m_sIDAchat = Gauche(sNoProjet, 9);
                        m_iIndexAchat = Droite(sNoProjet, 3);
                        break;
                    }
            }
            m_eCatalogue = eCatalogue;
        }
        public static void AfficherChoixLocalisation(EnumCatalogue eCatalogue, string sNoPiece) => m_eCatalogue = eCatalogue;
        public static void AfficherRetourMateriel(EnumCatalogue eCatalogue) => m_eCatalogue = eCatalogue;
        public static bool ValiderFormatNumeroProjSoum(string sNoProjSoum)
        {
            bool bNoValide;
            var sErreurMsg = default(string);
            bNoValide = true;
            if (sNoProjSoum.Length != 9)
            {
                bNoValide = false;
                sErreurMsg = "Le numéro doit contenir 9 caractères!";
            }
            if (bNoValide == true)
            {
                if (Gauche(sNoProjSoum, 1).ToUpper() != "M" & Gauche(sNoProjSoum, 1).ToUpper() != "E")
                {
                    bNoValide = false;
                    sErreurMsg = "Le numéro doit commencé par : " + Constants.vbNewLine + Constants.vbNewLine + "      E pour les soumissions et projets électriques" + Constants.vbNewLine + "      M pour les soumissions et projets mécaniques";
                }
            }
            if (bNoValide == true)
            {
                if (!IsNumeric(Strings.Mid(sNoProjSoum, 2, 5)))
                {
                    bNoValide = false;
                    sErreurMsg = "Format invalide !";
                }
            }
            if (bNoValide == true)
            {
                if (!IsNumeric(Droite(sNoProjSoum, 2)))
                {
                    bNoValide = false;
                    sErreurMsg = "Format invalide !";
                }
            }
            if (bNoValide == true)
            {
                if (Strings.Mid(sNoProjSoum, 7, 1) != "-")
                {
                    bNoValide = false;
                    sErreurMsg = "Format invalide !";
                }
            }
            if (bNoValide == true)
            {
                if (double.Parse(Strings.Mid(sNoProjSoum, 3, 1)) == 0d)
                {
                    bNoValide = false;
                    sErreurMsg = "Le 3e caractère ne peut pas être '0' !";
                }
            }
            if (bNoValide == true)
            {
                if (Droite(sNoProjSoum, 2) == "99" | Droite(sNoProjSoum, 2) == "00")
                {
                    bNoValide = false;
                    sErreurMsg = "L'extension doit être comprise entre 01 et 98";
                }
            }
            if (bNoValide == false)
            {
                Interaction.MsgBox(sErreurMsg, MsgBoxStyle.OkOnly, "Erreur");
            }
            return bNoValide;
        }
        public static bool ComboContient(ComboBox cmbSource, string sRecherche)
        {
            for (int X = 0; X <= (cmbSource.Items.Count - 1); X++)
            {
                if ((cmbSource.Items[X].ToString().Trim().ToUpper() ?? "") == (sRecherche.Trim().ToUpper() ?? ""))
                { return true; }
            }
            return false;
        }
        public static string ConvertDate(DateTime datDate)
        {
            return $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(datDate)}-" +
                 $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(datDate).ToString().PadLeft(2, '0')}-" +
                 $"{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(datDate).ToString().PadLeft(2, '0')}";
        }
        public static bool EmployeExiste(string text)
        {
            if (Employes.Count < 1) { EnumEmployes(); }
            foreach (DB_Employe p in Employes)
            {
                if (p.Loginname == text) { return true; }
                if (p.Noemploye.ToString() == text) { return true; }
            }
            return false;
        }
        private static void EnumEmployes()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "autogrb", "SELECT DISTINCT *  FROM [DBO].[EMPLOYÉS]");
            while (!rst.EOF)
            {
                Employes.Add(new DB_Employe((int)rst.Fields[1].Value, (string)rst.Fields[2].Value, string.Empty,
                    (string)rst.Fields[3].Value, (string)rst.Fields[4].Value, (string)rst.Fields[5].Value, (string)rst.Fields[6].Value, (string)rst.Fields[7].Value,
                    (bool)rst.Fields[8].Value, (int)rst.Fields[9].Value, (int)rst.Fields[10].Value, (bool)rst.Fields[11].Value));
                rst.MoveNext();
            }
            rst.Close();
        }
        public static string GetNomFournisseur(int ID)
        {
            foreach (DB_Fournisseur p in Fournisseurs)
            {
                if (p.Idfrs == ID)
                {
                    return $"{p.NomFournisseur}";
                }
            }
            return "Fournisseur non trouvé";
        }
        public static void InitialiserVariablesConfiguration()
        {
            try
            {
                CheminBD = Interaction.GetSetting("GRB", "CONFIG", "CheminBD", S_CHEMIN_DEFAUT);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(System.Windows.Forms.Application.ProductName, "InitialiserVariablesConfiguration", ex);
            }
        }
        public static void OuvrirForm(Form Source, bool bModal)
        {
            try
            {
                var objForm = default(Form);
                var bDejaOuvert = default(bool);
                if (bDejaOuvert == false)
                {
                    if (bModal == true)
                    {
                        Source.ShowDialog();
                    }
                    else
                    {
                        Source.Show();
                    }
                }
                else
                {
                    objForm.WindowState = FormWindowState.Normal;
                    // La méthode objForm.ZOrder est devenue bingtofront
                    objForm.BringToFront();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "OuvrirForm", ex);
            }
        }
        internal static int GetEmployeID(string v)
        {
            foreach (DB_Employe p in Employes) { if (p.Employes == v) { return p.Noemploye; } }
            return 0x0C;
        }
        public static Microsoft.Office.Interop.Outlook.Application OuvrirOutlook(ref bool bDejaOuvert)
        {
            Microsoft.Office.Interop.Outlook.Application OuvrirOutlookRet = default;
            Microsoft.Office.Interop.Outlook.Application otlApp = default;
            try
            {
                otlApp = new Microsoft.Office.Interop.Outlook.Application();
                bDejaOuvert = true;
            }
            catch (Exception ex)
            {
                bDejaOuvert = false;
                AfficherErreur("NoyauPrincipal", "OuvrirOutlook", ex);
            }
            OuvrirOutlookRet = otlApp;
            OutlookProfile = otlApp.DefaultProfileName;
            return OuvrirOutlookRet;
        }
        internal static void KillingOutlookProcess()
        {
            try
            {
                using (System.Diagnostics.Process myProcess = System.Diagnostics.Process.Start("C:\\Program Files(x86)\\Microsoft Office\\root\\Office16\\OUTLOOK.EXE"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (!myProcess.HasExited)
                        {
                            myProcess.Refresh();
                            MessageBox.Show($"Physical Memory Usage: {myProcess.WorkingSet}");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            break;
                        }
                    }
                    myProcess.CloseMainWindow();
                    myProcess.Close();
                }
            }
            catch (Exception e) when (e is Win32Exception || e is FileNotFoundException)
            {
                MessageBox.Show("L'erreur suivante est survenue\n"+e.Message,Application.ProductName+".KillingOutlookProcess" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        internal static void EnumCatégorieFournisseur()
        {
            CatégorieFournisseur.Clear();
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "autogrb", "SELECT CATEGORIE FROM FOURNISSEUR WHERE Categorie !=''");
            while (!rst.EOF)
            {
                CatégorieFournisseur.Add(new ListItem($"{rst.Fields[0].Value}", $"{rst.Fields[0].Value}"));
                rst.MoveNext();
            }
            rst.Close();
        }
        internal static void EnumClients()
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            clients.Clear();
            SqlDataReader rd = new SqlCommand($"SELECT DISTINCT [IDCLIENT],[NOMCLIENT]FROM [DBO].[CLIENT] WHERE SUPPRIMÉ= 0   order by nomclient", sql).ExecuteReader();
            while (rd.Read())
            {
                clients.Add(new ListItem(rd[1].ToString().ToUpper(), rd[0].ToString()));
            }
        }
        internal static void EnumEmployesActifsGRB()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "AutoGRB", "SELECT DISTINCT * FROM [DBO].[EMPLOYÉS]  WHERE [Actif]=1 AND [Supprimé]= 0   ORDER BY EMPLOYE");
            while (!rst.EOF)
            {
                utilisateursActifs.Add(new UtilisateurActifs((int)rst.Fields[0].Value, (string)rst.Fields[1].Value, (string)rst.Fields[3].Value, (string)rst.Fields[4].Value,
                    (string)rst.Fields[5].Value, (string)rst.Fields[6].Value, (string)rst.Fields[7].Value, (bool)rst.Fields[8].Value, (int)rst.Fields[9].Value,
                    (int)rst.Fields[10].Value, (bool)rst.Fields[11].Value, (int)rst.Fields[12].Value, (string)rst.Fields[13].Value, (bool)rst.Fields[14].Value,
                    (bool)rst.Fields[15].Value, (bool)rst.Fields[16].Value, (bool)rst.Fields[17].Value, (bool)rst.Fields[18].Value, (bool)rst.Fields[19].Value,
                    (bool)rst.Fields[20].Value, (bool)rst.Fields[21].Value, (bool)rst.Fields[22].Value, (bool)rst.Fields[23].Value, (bool)rst.Fields[24].Value,
                    (bool)rst.Fields[25].Value, (bool)rst.Fields[26].Value, (bool)rst.Fields[27].Value, (bool)rst.Fields[28].Value, (bool)rst.Fields[29].Value,
                    (bool)rst.Fields[30].Value, (bool)rst.Fields[31].Value, (bool)rst.Fields[32].Value, (bool)rst.Fields[33].Value, (bool)rst.Fields[34].Value,
                    (bool)rst.Fields[35].Value, (bool)rst.Fields[36].Value, (bool)rst.Fields[37].Value, (bool)rst.Fields[38].Value, (bool)rst.Fields[39].Value,
                    (bool)rst.Fields[40].Value, (bool)rst.Fields[41].Value, (bool)rst.Fields[42].Value, (bool)rst.Fields[43].Value, (bool)rst.Fields[44].Value,
                    (bool)rst.Fields[45].Value, (bool)rst.Fields[46].Value, (bool)rst.Fields[47].Value, (bool)rst.Fields[48].Value, (bool)rst.Fields[49].Value,
                    (bool)rst.Fields[50].Value, (bool)rst.Fields[51].Value, (bool)rst.Fields[52].Value, (bool)rst.Fields[53].Value, (bool)rst.Fields[54].Value,
                    (bool)rst.Fields[55].Value, (bool)rst.Fields[56].Value, (bool)rst.Fields[57].Value));
                rst.MoveNext();
            }
            rst.Close();
            rst = default;
        }
        internal static void EnumEmployesActifsPermaroute()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "PermaRourte", "SELECT DISTINCT * FROM [DBO].[PERMAROUTE_EMPLOYÉS]  WHERE [Actif]=1 AND [Supprimé]= 0   ORDER BY EMPLOYE");
            while (!rst.EOF)
            {
                utilisateursActifs.Add(new UtilisateurActifs((int)rst.Fields[0].Value, (string)rst.Fields[1].Value, (string)rst.Fields[3].Value, (string)rst.Fields[4].Value,
                    (string)rst.Fields[5].Value, (string)rst.Fields[6].Value, (string)rst.Fields[7].Value, (bool)rst.Fields[8].Value, (int)rst.Fields[9].Value,
                    (int)rst.Fields[10].Value, (bool)rst.Fields[11].Value, (int)rst.Fields[12].Value, (string)rst.Fields[13].Value, (bool)rst.Fields[14].Value,
                    (bool)rst.Fields[15].Value, (bool)rst.Fields[16].Value, (bool)rst.Fields[17].Value, (bool)rst.Fields[18].Value, (bool)rst.Fields[19].Value,
                    (bool)rst.Fields[20].Value, (bool)rst.Fields[21].Value, (bool)rst.Fields[22].Value, (bool)rst.Fields[23].Value, (bool)rst.Fields[24].Value,
                    (bool)rst.Fields[25].Value, (bool)rst.Fields[26].Value, (bool)rst.Fields[27].Value, (bool)rst.Fields[28].Value, (bool)rst.Fields[29].Value,
                    (bool)rst.Fields[30].Value, (bool)rst.Fields[31].Value, (bool)rst.Fields[32].Value, (bool)rst.Fields[33].Value, (bool)rst.Fields[34].Value,
                    (bool)rst.Fields[35].Value, (bool)rst.Fields[36].Value, (bool)rst.Fields[37].Value, (bool)rst.Fields[38].Value, (bool)rst.Fields[39].Value,
                    (bool)rst.Fields[40].Value, (bool)rst.Fields[41].Value, (bool)rst.Fields[42].Value, (bool)rst.Fields[43].Value, (bool)rst.Fields[44].Value,
                    (bool)rst.Fields[45].Value, (bool)rst.Fields[46].Value, (bool)rst.Fields[47].Value, (bool)rst.Fields[48].Value, (bool)rst.Fields[49].Value,
                    (bool)rst.Fields[50].Value, (bool)rst.Fields[51].Value, (bool)rst.Fields[52].Value, (bool)rst.Fields[53].Value, (bool)rst.Fields[54].Value,
                    (bool)rst.Fields[55].Value, (bool)rst.Fields[56].Value, (bool)rst.Fields[57].Value));
                rst.MoveNext();
            }
            rst.Close();
            rst = default;
        }
        public static void EnumEmployesActifsWeb()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "WebAccess", "SELECT DISTINCT * FROM [WEBUSER]  WHERE [Actif]=1 AND [Supprimé]= 0   ORDER BY EMPLOYE");
            while (!rst.EOF)
            {
                utilisateurs.Add(new WebUtilisateurActifs((int)rst.Fields[0].Value, (string)rst.Fields[1].Value, (string)rst.Fields[3].Value,
                    (bool)rst.Fields[4].Value, (bool)rst.Fields[5].Value, (bool)rst.Fields[6].Value, (bool)rst.Fields[7].Value));
                rst.MoveNext();
            }
            rst.Close();
            rst = default;
        }
        internal static void EnumManufacturiers()
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            manufacturiers.Clear();
            SqlDataReader rd = new SqlCommand($"SELECT DISTINCT REPLACE(UPPER([FABRICANT]),'-',' ')  FROM [DBO].[CATALOGUEELEC] ", sql).ExecuteReader();
            while (rd.Read())
            {
                manufacturiers.Add(new ListItem() { Text = rd[0].ToString().ToUpper(), Value = rd[0].ToString() });
            }
        }
        internal static void EnumFournisseurs()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "autogrb", "SELECT DISTINCT TRIM(REPLACE(UPPER([NOMFOURNISSEUR]),'-',' ')),[IDFRS]  FROM [DBO].[FOURNISSEUR]");
            while (!rst.EOF)
            {
                fournisseurs.Add(new ListItem($"{rst.Fields[0].Value}", $"{rst.Fields[0].Value}"));
                rst.MoveNext();
            }
            rst.Close();
        }
        internal static void EnumGroupes()
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            groupes.Clear();
            SqlDataReader rd = new SqlCommand("SELECT  DISTINCT *  FROM [DBO].[GROUPES]", sql).ExecuteReader();
            while (rd.Read())
            {
                groupes.Add(new ListItem(rd[0].ToString().ToUpper(),  rd[0].ToString()));
            }
        }
        public static string[] EnumNomChampsRecordSet(SqlDataReader recordset)
        {
            ///il est rare d'avoir des tables qui ont plus de 256 EntetesLvwSoumission
            string[] p = new string[0xFF];
            if (recordset.FieldCount < 0xFF)
            {
                for (int x = 0; x < recordset.FieldCount; x++) { p[x] = recordset.GetName(x); }
            }
            return p;
        }
        public static string[] EnumNomChampsRecordSet(ADODB.Recordset recordset)
        {
            ///il est rare d'avoir des tables qui ont plus de 256 EntetesLvwSoumission
            string[] p = new string[0xFF];
            if (recordset.Fields.Count < 0xFF)
            {
                for (int x = 0; x < recordset.Fields.Count; x++) { p[x] = recordset.Fields[x].Name; }
            }
            return p;
        }
        public static void EnumAchat()
        {// DB_Achat
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ACHAT]", con).ExecuteReader();
            while (reader.Read())
            {
                ACHAT.Add(new DB_Achats(reader[0].ToString(), (int)reader[1], reader[2].ToString(), reader[3].ToString(), 
                    (int)reader[4], reader[5].ToString(), reader[6].ToString(), (bool)reader[7], reader[8].ToString()));
            }
            con.Close();
        }
        public static void EnumGrbAchatPieces()
        {  // GrbAchatPieces
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ACHAT_PIECES]", con).ExecuteReader();
            while (reader.Read())
            {
                AchatPieces.Add(new DB_AchatPiece((int)reader[0], (string)reader[1], (int)reader[2], 
                    (string)reader[3], (int)reader[4], (string)reader[5], (string)reader[6], (string)reader[7],
                    (string)reader[8], (string)reader[9], (string)reader[10], (string)reader[11], (int)reader[12],
                    (string)reader[13], (string)reader[14], (bool)reader[15], (bool)reader[16], (string)reader[17],
                    (bool)reader[18], (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22],
                    (bool)reader[23], (bool)reader[24], (string)reader[25], (string)reader[26], (string)reader[27]));
            }
            con.Close();
        }
        public static void EnumProjetElec()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJETELEC]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetElec.Add(new DB_ProjetElec((string)reader[0],(string) reader[1], (int)reader[2], (int)reader[3],
                    (string)reader[4],(string) reader[5], (int)reader[6],(string) reader[7],(string) reader[8],
                    (string)reader[9],(string) reader[10], (string)reader[11], (string)reader[12], (string)reader[13],
                    (string)reader[14], (string)reader[15], (string)reader[16],(string) reader[17],(string) reader[18],
                    (string)reader[19],(string) reader[20],(string) reader[21],(string) reader[22],(string) reader[23],
                    (string)reader[24],(string) reader[25],(string) reader[26],(string) reader[27],(string) reader[28],
                    (string)reader[29],(string) reader[30], (bool)reader[31], (bool)reader[32], (bool)reader[33], 
                    (bool)reader[34], (bool)reader[35], (bool)reader[36],(string) reader[37],(string) reader[38],
                    (string)reader[39],(string) reader[40],(string) reader[41],(string) reader[42],(string) reader[43],
                    (string)reader[44],(string) reader[45],(string) reader[46],(string) reader[47],(string) reader[48],
                    (string)reader[49],(string) reader[50],(string) reader[51],(string) reader[52],(string) reader[53],
                    (string)reader[54],(string) reader[55],(string) reader[56],(string) reader[57],(string) reader[58],
                    (string)reader[59],(string) reader[60],(string) reader[61],(string) reader[62],(string) reader[63],
                    (string)reader[64],(string) reader[65],(string) reader[66],(string) reader[67],(string) reader[68],
                    (bool)reader[69],(string) reader[70], (bool)reader[71],(string) reader[72],(string) reader[73],
                    (string)reader[74],(string) reader[75],(string) reader[76], (int)reader[77]));
            }
            con.Close();
        }
        public static void EnumAchatPiecesTampon()
        {
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ACHAT_PIECES_TAMPON]", con).ExecuteReader();
            while (reader.Read())
            {
                Achat_Pieces_Tampon.Add(new DB_AchatPiecesTampon((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], 
                    (int)reader[4], (string)reader[5], (int)reader[6], (string)reader[7], (string)reader[8], (string)reader[9], 
                    (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13], (int)reader[14],(string)reader[15],
                    (string)reader[16], (bool)reader[17], (bool)reader[18], (string)reader[19], (bool)reader[20], (string)reader[21],
                    (string)reader[22], (string)reader[23], (string)reader[24], (bool)reader[25],(bool)reader[26], (string)reader[27],
                    (string)reader[28], (string)reader[29]));
            } 
            con.Close();
        } // DB_AchatPiecesTampon
        public static void EnumAlarmes()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ALARMES]", con).ExecuteReader();
            while (reader.Read())
            {
                Alarmes.Add(new DB_Alarme((int)reader[0], (string)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], 
                    (string)reader[5], (string)reader[6], (int)reader[7], (int)reader[8], (string)reader[9]));
            }
            con.Close();
        } // DB_Alarmes
        public static void EnumAutorisationPunch()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[AUTORISATIONPUNCH]", con).ExecuteReader();
            while (reader.Read())
            {
                AutorisationPunch.Add(new DB_AutorisationPunch()
                {
                    Idautorisation = (int)reader[0],
                    NoEmploye = (int)reader[1],
                    AutoriserPar = (int)reader[2],
                });
            }
            con.Close();
        } // DB_AutorisationPunch
        public static void EnumBavardSuppression()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[BAVARDSUPPRESSION]", con).ExecuteReader();
            while (reader.Read())
            {
                BavardSuppression.Add(new DB_BavardSuppression()
                {
                    NoBavard = (int)reader[0],
                    Iduser = (int)reader[1],
                    NoProjSoum = reader[2].ToString(),
                    Type = reader[3].ToString(),
                    Qte = reader[4].ToString(),
                    NoItem = reader[5].ToString(),
                    Date = reader[6].ToString(),
                    Heure = reader[7].ToString(),
                });
            }
            con.Close();
        } // DB_BavardSuppression
        public static void EnumBonsCommandes()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[BONSCOMMANDES]", con).ExecuteReader();
            while (reader.Read())
            {
                BonsCommandes.Add(new DB_BonsCommandesCommande()
                {
                    NoBonCommande = reader[0].ToString(),
                    NoFournisseur = (int)reader[1],
                    NoProjet = reader[2].ToString(),
                    Attention = reader[3].ToString(),
                    Transport = reader[4].ToString(),
                    DateRequise = reader[5].ToString(),
                    VotreNoSoum = reader[6].ToString(),
                    DateCommande = reader[7].ToString(),
                    CommandePar = reader[8].ToString(),
                    Total = reader[9].ToString(),
                    Commentaire = reader[10].ToString(),
                    AffichageInstructions = (bool)reader[11],
                    LangueImpression = reader[12].ToString(),
                    Type = reader[13].ToString(),
                });
            }
            con.Close();
        } // GrbBonsCommandes
        public static void EnumBonsCommandesPieces()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[BONSCOMMANDES_PIECES]", con).ExecuteReader();
            while (reader.Read())
            {
                BonsCommandesPieces.Add(new DB_BonsCommandesPiece()
                {
                    NoBonCommande = reader[0].ToString(),
                    NoFournisseur = (int)reader[1],
                    Qte = reader[2].ToString(),
                    NoItem = reader[3].ToString(),
                    Description = reader[4].ToString(),
                    Manufact = reader[5].ToString(),
                    Prix = reader[6].ToString(),
                    Escompte = reader[7].ToString(),
                    Total = reader[8].ToString(),
                    Type = reader[9].ToString(),
                    NumeroLigne = reader[10].ToString(),
                });
            }
            con.Close();
        } // GrbBonsCommandesPieces
        public static void EnumCatalogueElec()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CATALOGUEELEC]", con).ExecuteReader();
            while (reader.Read())
            {
               CatalogueElec.Add(new DB_CatalogueElec(reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),
                   reader[3].ToString(),reader[4].ToString(),reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),
                   reader[8].ToString(),reader[9].ToString()));
            }
            con.Close();
        } // DB_CatalogueElec
        public static void EnumCatalogueMec()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con.Open();
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CATALOGUEMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                CatalogueMec.Add(new DB_CatalogueMec(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                   reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
            }
            con.Close();
        } // DB_CatalogueMec
        public static void EnumClient()
        {
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open("SELECT * FROM [DBO].[CLIENT] WHERE SUPPRIMÉ = 0", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                Clients.Add(new DB_Client((int)rd.Fields[0].Value,$"{rd .Fields[1].Value}",$"{rd .Fields[2].Value}",$"{rd .Fields[3].Value}",
                    $"{rd.Fields[4].Value}",$"{rd .Fields[5].Value}",$"{rd .Fields[6].Value}",$"{rd .Fields[7].Value}",$"{rd .Fields[8].Value}",
                    $"{rd.Fields[9].Value}",$"{rd .Fields[10].Value}",$"{rd .Fields[11].Value}",$"{rd .Fields[12].Value}",$"{rd .Fields[13].Value}",
                    $"{rd.Fields[14].Value}",$"{rd .Fields[15].Value}",$"{rd .Fields[16].Value}",$"{rd .Fields[17].Value}",$"{rd .Fields[18].Value}",
                    $"{rd.Fields[19].Value}",$"{rd .Fields[20].Value}",$"{rd .Fields[21].Value}", (bool)rd.Fields[22].Value, (bool)rd.Fields[23].Value, 
                    (bool)rd.Fields[24].Value, (bool)rd.Fields[25].Value, (bool)rd.Fields[26].Value, (bool)rd.Fields[27].Value, (bool)rd.Fields[28].Value,
                    (bool)rd.Fields[29].Value,(bool)rd.Fields[30].Value, (bool)rd.Fields[31].Value, (bool)rd.Fields[32].Value, (bool)rd.Fields[33].Value,
                    (bool)rd.Fields[34].Value, (bool)rd.Fields[35].Value, $"{rd.Fields[36].Value}"));
             //   clients.Add(new ListItem($"{rd.Fields[1].Value}", $"{rd.Fields[0].Value}"));
            }
            con.Close();
        } // DB_Client
        public static void EnumCommentaires()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[COMMENTAIRES]", con).ExecuteReader();
            while (reader.Read())
            {
                Commentaires.Add(new DB_Commentaire((int)reader[0],reader[1].ToString(),(int)reader[2],reader[3].ToString(),
                    (bool)reader[4], (bool)reader[5],reader[6].ToString(),reader[7].ToString()));
            }
            con.Close();
        } // GrbCommentaires
        public static void EnumConfig()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CONFIG]", con).ExecuteReader();
            int x = 0x00;
            while (reader.Read())
            {
                x++;
                if (x > 1) return;
                CONFIG.Add(new DB_Config((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], 
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13], 
                    (string)reader[14], (string)reader[15], (string)reader[16], (string)reader[17], (string)reader[18],
                    (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22], (string)reader[23],
                    (string)reader[24], (string)reader[25], (string)reader[26], (string)reader[27], (string)reader[28],
                    (string)reader[29], (string)reader[30], (string)reader[31], (string)reader[32], (string)reader[33], 
                    (string)reader[34], (string)reader[35], (string)reader[36], (string)reader[37], (string)reader[38],
                    (string)reader[39], (string)reader[40], (string)reader[41], (string)reader[42], (string)reader[43],
                    (string)reader[44], (string)reader[45], (string)reader[46], (string)reader[47], (string)reader[48],
                    (string)reader[49], (string)reader[50], (string)reader[51], (string)reader[52], (string)reader[53], 
                    (string)reader[54]));
            }
            con.Close();
        } // DB_Config
        public static void EnumContact()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CONTACT]", con).ExecuteReader();
            while (reader.Read())
            {
                Contacts.Add(new DB_Contacts((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], 
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8], (string)reader[9], 
                    (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13], (string)reader[14], 
                    (string)reader[15], (string)reader[16], (bool)reader[17]));
            }
            con.Close();
        } // DB_Contacts
        public static void EnumContactClient()
        {// DB_ContactClient
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CONTACTCLIENT]", con).ExecuteReader();
            while (reader.Read())
            {
                ContactClient.Add(new DB_ContactClient( (int)reader[0],(int)reader[1],(int)reader[2]));
            }
            con.Close();
        }
        public static void EnumContactFrs()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CONTACTFRS]", con).ExecuteReader();
            while (reader.Read())
            {
                ContactFrs.Add(new DB_ContactFr() { NoEnreg = (int)reader[0], NoFrs = (int)reader[1], NoContact = (int)reader[2], });
            }
            con.Close();
        } // CONTACTFrs
        public static void EnumCedule()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CÉDULE]", con).ExecuteReader();
            while (reader.Read())
            {
                cedules.Add(new DB_Cedule((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4],
                    (string)reader[5], (int)reader[6], (string)reader[7], (int)reader[8], (bool)reader[9]));
            }
            con.Close();
        } // GrbCedule
        public static void EnumDessins()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[DESSINS]", con).ExecuteReader();
            while (reader.Read())
            {
                Dessins.Add(new DB_Dessin()
                {
                    NoEnreg = (int)reader[0],
                    NoProjet = reader[1].ToString(),
                    NoDessin = reader[2].ToString(),
                    Description = reader[3].ToString(),
                    Type = reader[4].ToString(),
                });
            }
            con.Close();
        } // GrbDessins
        public static void EnumErreurs()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ERREURS]", con).ExecuteReader();
            while (reader.Read())
            {
                Erreurs.Add(new DB_Erreur()
                {
                    Iderreur = (int)reader[0],
                    Qui = reader[1].ToString(),
                    Date = reader[2].ToString(),
                    Heure = reader[3].ToString(),
                    Form = reader[4].ToString(),
                    Methode = reader[5].ToString(),
                    NoLigne = (int)reader[6],
                    NoErreur = (int)reader[7],
                    Description = reader[8].ToString(),
                    Source = reader[9].ToString(),
                    Params = reader[10].ToString(),
                });
            }
            con.Close();
        } // GrbErreurs
        public static void EnumExceptionsDl()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[ExceptionsDL]", con).ExecuteReader();
            while (reader.Read())
            {
                ExceptionsDl.Add(new DB_ExceptionsDl()
                {
                    Id = (int)reader[0],
                    Exception = reader[2].ToString(),
                });
            }
            con.Close();
        } // DB_ExceptionsDl
        public static void EnumFamille()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[FAMILLE]", con).ExecuteReader();
            while (reader.Read())
            {
                Famille.Add(new DB_Famille((int)reader[0],reader[1].ToString()));
            }
            con.Close();
        } // Familles
        public static void EnumFournisseur()
        {
            fournisseurs.Clear();
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst,"autogrb", "SELECT * FROM [DBO].[FOURNISSEUR] ORDER BY NOMFOURNISSEUR");
            while (!rst.EOF)
            {
     /*           Fournisseurs.Add(new DB_Fournisseur((int)rst.Fields[0].Value,$"{rst.Fields[1].Value}",$"{rst.Fields[2].Value}",$"{rst.Fields[3].Value}",
                    $"{rst.Fields[4].Value}",$"{rst.Fields[5].Value}",$"{rst.Fields[6].Value}",$"{rst.Fields[7].Value}",$"{rst.Fields[8].Value}",
                    $"{rst.Fields[9].Value}",$"{rst.Fields[10].Value}",$"{rst.Fields[11].Value}",$"{rst.Fields[12].Value}",$"{rst.Fields[13].Value}",
                    $"{rst.Fields[14].Value}",$"{rst.Fields[15].Value}",$"{rst.Fields[16].Value}",$"{rst.Fields[17].Value}",$"{rst.Fields[18].Value}",
                    $"{rst.Fields[19].Value}",$"{rst.Fields[20].Value}",$"{rst.Fields[21].Value}", (bool)rst.Fields[22].Value,$"{rst.Fields[23].Value}"));*/
                fournisseurs.Add(new ListItem($"{rst.Fields[1].Value}",$"{rst.Fields[0].Value}"));
                rst.MoveNext();
            }
            rst.Close();

        } // DB_Fournisseur
        public static void EnumImpressionBonlivraison()
        {// DB_ImpressionBonlivraison
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSION_BONLIVRAISON]", con).ExecuteReader();
            while (reader.Read())
            {
                bonlivraisons.Add(new DB_ImpressionBonlivraison((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], 
                    (string)reader[4], (string)reader[5], (string)reader[6]));
            }
            con.Close();
        }
        public static void EnumImpressionDemandePrixElec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONDEMANDEPRIXELEC]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionDemandePrixElec.Add(new DB_ImpressionDemandePrixElec((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            con.Close();
        } // DB_ImpressionDemandePrixElec
        public static void EnumImpressionDemandePrixMec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONDEMANDEPRIXMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionDemandePrixMec.Add(new DB_ImpressionDemandePrixMec((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            con.Close();
        } // ImpressionDemandePrixMec
        public static void EnumImpressionDetailTemps()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONDETAILTEMPS]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionDetailTemps.Add(new DB_ImpressionDetailTemp((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            con.Close();
        } // GrbImpressionDetailTemps
        public static void EnumImpressionListePiece()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSION_LISTEPIECE]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionListePiece.Add(new DB_ImpressionListePiece()
                {
                    Noligne = (int)reader[0],
                    Idsoumission = reader[1].ToString(),
                    NomSection = reader[2].ToString(),
                    SousSection = reader[3].ToString(),
                    NumItem = reader[4].ToString(),
                    Qte = reader[5].ToString(),
                    Description = reader[6].ToString(),
                    Manufact = reader[7].ToString(),
                    Section = reader[8].ToString(),
                    NomSousSection = reader[9].ToString(),
                    Idsection = reader[10].ToString(),
                    Id = reader[11].ToString(),
                });
            }
            con.Close();
        } // DB_ImpressionListePiece
        public static void EnumImpressionPoste()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONPOSTE]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionPoste.Add(new DB_ImpressionPoste((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],(string)reader[4]));
            }
            con.Close();
        } // DB_ImpressionPoste
        public static void EnumImpressionPunch()
        { // DB_ImpressionPunch
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT NOPROJET, NOMJOUR, DATE, HEUREDÉBUT, HEUREFIN, CLIENT, COMMENTAIRE, TOTAL, NBREKM, TYPE FROM [DBO].[IMPRESSIONPUNCH]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionPunch.Add(new DB_ImpressionPunch()
                {
                    NoProjet = reader[0].ToString(),
                    NomJour = reader[1].ToString(),
                    Date = reader[2].ToString(),
                    HeureDebut = reader[3].ToString(),
                    HeureFin = reader[4].ToString(),
                    Client = reader[5].ToString(),
                    Commentaire = reader[6].ToString(),
                    Total = reader[7].ToString(),
                    NbreKm = reader[8].ToString(),
                    Type = reader[9].ToString(),
                });
            }
            con.Close();
        }
        public static void EnumImpressionSommairePunchGeneral()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONSOMMAIREPUNCHGENERAL]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionSommairePunchGeneral.Add(new DB_ImpressionSommairePunchGeneral((int)reader[0], (string)reader[1], (string)reader[2]));
            }
            con.Close();
        } // DB_ImpressionSommairePunchGeneral
        public static void EnumImpressionSommairePunchGrb()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSIONSOMMAIREPUNCHGRB]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionSommairePunchGrb.Add(new DB_ImpressionSommairePunchGrb((int)reader[0], (string)reader[1], (string)reader[2], 
                    (string)reader[3],(string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7],reader[8].ToString()));
            }
            con.Close();
        } // DB_ImpressionSommairePunchGrb
        public static void EnumGrbImpressionSoumission()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[IMPRESSION_SOUMISSION]", con).ExecuteReader();
            while (reader.Read())
            {
                ImpressionSoumission.Add(new DB_ImpressionSoumission((int)reader[0],(string) reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8], (string)reader[9],
                    (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13], (string)reader[14], (string)reader[15],
                    (string)reader[16], (string)reader[17], (string)reader[18], (string)reader[19]));
            }
            con.Close();
        } // DB_ImpressionSoumission
        public static void EnumInventaireElec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[INVENTAIREELEC]", con).ExecuteReader();
            while (reader.Read())
            {
                InventaireElecs.Add(new DB_InventaireElec((int)reader[0], (int)reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8], (string)reader[9],
                    (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13], (bool)reader[14], (string)reader[15],
                    (string)reader[16], (string)reader[17],(bool)reader[18],(float)reader[18]));
            }
            con.Close();
        }// DB_InventaireElec
        public static void EnumInventaireElecModif()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[INVENTAIREELECMODIF]", con).ExecuteReader();
            while (reader.Read())
            {
                InventaireElecModif.Add(new DB_InventaireElecModif((int)reader[0] ,(string)reader[1],(string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]));
            }
            con.Close();
        } // DB_InventaireElecModif
        public static void EnumInventaireMec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[INVENTAIREMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                InventaireMecs.Add(new DB_InventaireMec((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8], 
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (bool)reader[13],
                    (string)reader[14], (string)reader[15], (string)reader[16], (bool)reader[17]));
            }
            con.Close();
        } // InventaireMec
        public static void EnumInventaireMecModif()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[INVENTAIREMECMODIF]", con).ExecuteReader();
            while (reader.Read())
            {
                InventaireMecModif.Add(new DB_InventaireMecModif((string)reader[0],(string)reader[1],(string)reader[2],
                    (string)reader[3],(int)reader[4]));
            }
            con.Close();
        } // DB_InventaireMecModif
        public static void EnumOutils()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[OUTILS]", con).ExecuteReader();
            while (reader.Read())
            {
                Outils.Add(new ControleurServeur.Outil((string)reader[0], (string)reader[1],(string)reader[2],(string)reader[3],(string)reader[4],(string)reader[5],(string)reader[6],(string)reader[7]));
            }
            con.Close();
        } // GrbOutils
        public static void EnumOutilsInOut()
        {
            SqlConnection con = new SqlConnection(StringSQL);
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[OUTILS_IN_OUT]", con).ExecuteReader();
            while (reader.Read())
            {
                OutilsInOut.Add(new DB_OutilsInOut((int)reader[0], (int)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (int)reader[5]));
            }
            con.Close();
        } // DB_OutilsInOut
        public static void EnumOutlook()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[OUTLOOK]", con).ExecuteReader();
            while (reader.Read())
            {
                Outlook.Add(new DB_Outlook((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7] ));
            }
            con.Close();
        } // DB_Outlook
        public static void EnumPiecesFrs()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PIECESFRS]", con).ExecuteReader();
            while (reader.Read())
            {
                PiecesFrs.Add(new DB_PiecesFr((int)reader[0], (int)reader[1], (string)reader[2], (string)reader[3], 
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                    (string)reader[9], (string)reader[10], (string)reader[11], (bool)reader[12], (string)reader[13], 
                    (string)reader[14], (string)reader[15]));
            }
            con.Close();
        } // GrbPiecesFrs
        public static void EnumProjSoum()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJSOUM]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjSoum.Add(new DB_ProjSoum((string)reader[0], (int)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], 
                    (bool)reader[5], (bool)reader[6], (string)reader[7], (string)reader[8]));
            }
            con.Close();
        } // DB_ProjSoum
        public static void EnumProjetMec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJETMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetMecs.Add(new DB_ProjetMec()
                {
                    Idprojet = reader[0].ToString(),
                    Idsoumission = reader[1].ToString(),
                    Idclient = (int)reader[2],
                    Idcontact = (int)reader[3],
                    Description = reader[4].ToString(),
                    Manuel = reader[5].ToString(),
                    Creer = reader[6].ToString(),
                    CreerPar = (int)reader[7],
                    TotalPiece = reader[8].ToString(),
                    Imprevue = reader[9].ToString(),
                    TotalImprevue = reader[10].ToString(),
                    TotalTemps = reader[11].ToString(),
                    TotalManuel = reader[12].ToString(),
                    Commission = reader[13].ToString(),
                    TotalCommission = reader[14].ToString(),
                    PrixTotal = reader[15].ToString(),
                    Profit = reader[16].ToString(),
                    TotalProfit = reader[17].ToString(),
                    TempsProjBarre = (bool)reader[18],
                    TempsMachinageProj = reader[19].ToString(),
                    TempsCoupeProj = reader[20].ToString(),
                    TempsSoudureProj = reader[21].ToString(),
                    TempsAssemblageProj = reader[22].ToString(),
                    TempsPeintureProj = reader[23].ToString(),
                    TempsTestProj = reader[24].ToString(),
                    TempsDessinProj = reader[25].ToString(),
                    TempsFormationProj = reader[26].ToString(),
                    TempsInstallationProj = reader[27].ToString(),
                    TempsGestionProj = reader[28].ToString(),
                    TempsShippingProj = reader[29].ToString(),
                    TempsMachinageConc = reader[30].ToString(),
                    TempsCoupeConc = reader[31].ToString(),
                    TempsSoudureConc = reader[32].ToString(),
                    TempsAssemblageConc = reader[33].ToString(),
                    TempsPeintureConc = reader[34].ToString(),
                    TempsTestConc = reader[35].ToString(),
                    TempsGestionConc = reader[36].ToString(),
                    TempsShippingConc = reader[37].ToString(),
                    TempsDessinConc = reader[38].ToString(),
                    TempsInstallationConc = reader[39].ToString(),
                    TempsFormationConc = reader[40].ToString(),
                    NbrePersonne = reader[41].ToString(),
                    TempsHebergement = reader[42].ToString(),
                    TotalHebergement = reader[43].ToString(),
                    TempsRepas = reader[44].ToString(),
                    TotalRepas = reader[45].ToString(),
                    TempsTransport = reader[46].ToString(),
                    TempsUniteMobile = reader[47].ToString(),
                    PrixEmballage = reader[48].ToString(),
                    TauxHebergement1 = reader[49].ToString(),
                    TauxHebergement2 = reader[50].ToString(),
                    TauxMachinage = reader[51].ToString(),
                    TauxCoupe = reader[52].ToString(),
                    TauxSoudure = reader[53].ToString(),
                    TauxAssemblage = reader[54].ToString(),
                    TauxPeinture = reader[55].ToString(),
                    TauxTest = reader[56].ToString(),
                    TauxDessin = reader[57].ToString(),
                    TauxFormation = reader[58].ToString(),
                    TauxInstallation = reader[59].ToString(),
                    TauxGestion = reader[60].ToString(),
                    TauxShipping = reader[61].ToString(),
                    TauxRepas = reader[62].ToString(),
                    TauxTransport = reader[63].ToString(),
                    TauxUniteMobile = reader[64].ToString(),
                    CheminPhotos = reader[65].ToString(),
                    Modification = (bool)reader[66],
                    Par = reader[67].ToString(),
                    PrixReception = reader[68].ToString(),
                    MontantForfait = reader[69].ToString(),
                    InitialeForfait = reader[70].ToString(),
                    LiaisonChargeable = reader[71].ToString(),
                    ProchaineCommande = (int)reader[72]
                });
            }
            con.Close();
        } // DB_ProjetElec
        public static void EnumProjetModif()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJET_MODIF]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetModif.Add(new DB_ProjetModif()
                {
                    Idmodif = (int)reader[0],
                    Idprojet = reader[1].ToString(),
                    NoEmploye = (int)reader[2],
                    Date = reader[3].ToString(),
                    Heure = reader[4].ToString(),
                    Type = reader[5].ToString(),
                    TypeModif = reader[6].ToString(),
                    Valeur = reader[7].ToString(),
                });
            }
            con.Close();
        } // DB_ProjetModif
        public static void EnumProjetPieces()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJET_PIECES]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetPieces.Add(new DB_ProjetPiece()
                {
                    NoEnreg = (int)reader[0],
                    Idprojet = reader[1].ToString(),
                    Idsection = (int)reader[2],
                    NumItem = reader[3].ToString(),
                    Qte = reader[4].ToString(),
                    DescFr = reader[5].ToString(),
                    DescEn = reader[6].ToString(),
                    Manufact = reader[7].ToString(),
                    PrixList = reader[8].ToString(),
                    Escompte = reader[9].ToString(),
                    PrixNet = reader[10].ToString(),
                    Idfrs = (int)reader[11],
                    Temps = reader[12].ToString(),
                    TempsTotal = reader[13].ToString(),
                    PrixTotal = reader[14].ToString(),
                    ProfitPourcent = reader[15].ToString(),
                    ProfitArgent = reader[16].ToString(),
                    SousSection = reader[17].ToString(),
                    OrdreSection = reader[18].ToString(),
                    NumeroLigne = (int)reader[19],
                    PrixOrigine = reader[20].ToString(),
                    Type = reader[21].ToString(),
                    Visible = (bool)reader[22],
                    Commande = (bool)reader[23],
                    Quote = (bool)reader[24],
                    Recu = (bool)reader[25],
                    Retour = (bool)reader[26],
                    NoRetour = reader[27].ToString(),
                    CommandeAnnulee = (bool)reader[28],
                    DateReception = reader[29].ToString(),
                    QuantiteRecue = reader[30].ToString(),
                    Facturation = reader[31].ToString(),
                    Id = reader[32].ToString(),
                    PieceExtra = (bool)reader[33],
                    PieceExtraChargeable = (bool)reader[34],
                    PieceExtraNonChargeable = (bool)reader[35],
                    DateCommande = reader[36].ToString(),
                    DateRequise = reader[37].ToString(),
                    NomCommande = reader[38].ToString(),
                    NoSequentiel = reader[39].ToString(),
                    MaterielInutile = (bool)reader[40],
                    Commentaire = reader[41].ToString(),
                    DateRetour = reader[42].ToString(),
                    Provenance = reader[43].ToString(),
                    Devise = reader[44].ToString(),
                });
            }
            con.Close();
        } // GrbProjetPieces
        public static void EnumProjetPiecesTampon()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJET_PIECES_TAMPON]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetPiecesTampon.Add(new DB_ProjetPiecesTampon()
                {
                    NoEnreg = (int)reader[0],
                    DateCopie = reader[1].ToString(),
                    Initiales = reader[2].ToString(),
                    Idprojet = reader[3].ToString(),
                    Idsection = (int)reader[4],
                    NumItem = reader[5].ToString(),
                    Qte = reader[6].ToString(),
                    DescFr = reader[7].ToString(),
                    DescEn = reader[8].ToString(),
                    Manufact = reader[9].ToString(),
                    PrixList = reader[10].ToString(),
                    Escompte = reader[11].ToString(),
                    PrixNet = reader[12].ToString(),
                    Idfrs = (int)reader[13],
                    Temps = reader[14].ToString(),
                    TempsTotal = reader[15].ToString(),
                    PrixTotal = reader[16].ToString(),
                    ProfitPourcent = reader[17].ToString(),
                    ProfitArgent = reader[18].ToString(),
                    SousSection = reader[19].ToString(),
                    OrdreSection = reader[20].ToString(),
                    NumeroLigne = (int)reader[21],
                    PrixOrigine = reader[22].ToString(),
                    Type = reader[23].ToString(),
                    Visible = (bool)reader[24],
                    Commande = (bool)reader[25],
                    Quote = (bool)reader[26],
                    Recu = (bool)reader[27],
                    Retour = (bool)reader[28],
                    NoRetour = reader[29].ToString(),
                    CommandeAnnulee = (bool)reader[30],
                    DateReception = reader[31].ToString(),
                    QuantiteRecue = reader[32].ToString(),
                    Facturation = reader[33].ToString(),
                    Id = reader[34].ToString(),
                    PieceExtra = (bool)reader[35],
                    PieceExtraChargeable = (bool)reader[36],
                    PieceExtraNonChargeable = (bool)reader[37],
                    DateCommande = reader[38].ToString(),
                    DateRequise = reader[39].ToString(),
                    NomCommande = reader[40].ToString(),
                    NoSequentiel = reader[41].ToString(),
                    MaterielInutile = (bool)reader[42],
                    Commentaire = reader[43].ToString(),
                    DateRetour = reader[44].ToString(),
                    Provenance = reader[45].ToString(),
                    Devise = reader[46].ToString(),
                });
            }
            con.Close();
        } // DB_ProjetPiecesTampon
        public static void EnumProjetsDessins()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJETSDESSINS]", con).ExecuteReader();
            while (reader.Read())
            {
                Dessins.Add(new DB_Dessin() { NoProjet = reader[0].ToString(), });
            }
            con.Close();
        } // GrbProjetsDessins
        public static void EnumPunchExcel()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PUNCHEXCEL]", con).ExecuteReader();
            while (reader.Read())
            {
                PunchExcel.Add(new DB_PunchExcel()
                {
                    Idpunch = (int)reader[0],
                    NoEmploye = (int)reader[1],
                    NoProjet = reader[2].ToString(),
                    HeureDebut = reader[3].ToString(),
                    HeureFin = reader[4].ToString(),
                });
            }
            con.Close();
        } // DB_PunchExcel
        public static void EnumSortieMateriel()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SORTIEMATÉRIEL]", con).ExecuteReader();
            while (reader.Read())
            {
                SortieMateriel.Add(new DB_SortieMateriel()
                {
                    Idsortie = (int)reader[0],
                    Qte = reader[1].ToString(),
                    Nom = reader[2].ToString(),
                    NoProjet = reader[3].ToString(),
                    NoItem = reader[4].ToString(),
                    Date = reader[5].ToString(),
                    Type = reader[6].ToString(),
                });
            }
            con.Close();
        } // DB_SortieMateriel
        public static void EnumSoumProjSectionElec()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMPROJSECTIONELEC]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumProjSectionElec.Add(new DB_SoumProjSectionElec()
                {
                    Idsection = (int)reader[0],
                    NomSectionFr = reader[1].ToString(),
                    NomSectionEn = reader[2].ToString(),
                    Ordre = (int)reader[3],
                });
            }
            con.Close();
        } // DB_SoumProjSectionElec
        public static void EnumSoumProjSectionMec()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMPROJSECTIONMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumProjSectionMec.Add(new DB_SoumProjSectionMec()
                {
                    Idsection = (int)reader[0],
                    NomSectionFr = reader[1].ToString(),
                    NomSectionEn = reader[2].ToString(),
                    Ordre = (int)reader[3],
                });
            }
            con.Close();
        } // DB_SoumProjSectionMec
        public static void EnumSoumissionElec()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMISSIONELEC]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumissionElecs.Add(new DB_SoumissionElec()
                {
                    Idsoumission = reader[0].ToString(),
                    Idclient = (int)reader[1],
                    Idcontact = (int)reader[2],
                    Description = reader[3].ToString(),
                    PanneauAire = reader[4].ToString(),
                    PanneauEspace = reader[5].ToString(),
                    NbreManuel = reader[6].ToString(),
                    Floorstock = reader[7].ToString(),
                    Transport = reader[8].ToString(),
                    Marqueur = reader[9].ToString(),
                    Csa = (bool)reader[10],
                    Cul = (bool)reader[11],
                    Ul = (bool)reader[12],
                    Cur = (bool)reader[13],
                    Ur = (bool)reader[14],
                    Ce = (bool)reader[15],
                    Delais = reader[16].ToString(),
                    Creer = reader[17].ToString(),
                    CreerPar = (int)reader[18],
                    TempsDessin = reader[19].ToString(),
                    TempsProgInterface = reader[20].ToString(),
                    TempsFabrication = reader[21].ToString(),
                    TempsAssemblage = reader[22].ToString(),
                    TempsTest = reader[23].ToString(),
                    TempsVision = reader[24].ToString(),
                    TempsProgAutomate = reader[25].ToString(),
                    TempsProgRobot = reader[26].ToString(),
                    TempsInstallation = reader[27].ToString(),
                    TempsMiseService = reader[28].ToString(),
                    TempsFormation = reader[29].ToString(),
                    TempsGestion = reader[30].ToString(),
                    TempsShipping = reader[31].ToString(),
                    NbrePersonne = reader[32].ToString(),
                    TempsHebergement = reader[33].ToString(),
                    TotalHebergement = reader[34].ToString(),
                    TempsRepas = reader[35].ToString(),
                    TotalRepas = reader[36].ToString(),
                    TempsTransport = reader[37].ToString(),
                    TempsUniteMobile = reader[38].ToString(),
                    PrixEmballage = reader[39].ToString(),
                    TauxDessin = reader[40].ToString(),
                    TauxProgInterface = reader[41].ToString(),
                    TauxFabrication = reader[42].ToString(),
                    TauxAssemblage = reader[43].ToString(),
                    TauxTest = reader[44].ToString(),
                    TauxVision = reader[45].ToString(),
                    TauxProgAutomate = reader[46].ToString(),
                    TauxProgRobot = reader[47].ToString(),
                    TauxInstallation = reader[48].ToString(),
                    TauxMiseService = reader[49].ToString(),
                    TauxFormation = reader[50].ToString(),
                    TauxGestion = reader[51].ToString(),
                    TauxShipping = reader[52].ToString(),
                    TauxHebergement1 = reader[53].ToString(),
                    TauxHebergement2 = reader[54].ToString(),
                    TauxRepas = reader[55].ToString(),
                    TauxTransport = reader[56].ToString(),
                    TauxUniteMobile = reader[57].ToString(),
                    TotalPiece = reader[58].ToString(),
                    Imprevue = reader[59].ToString(),
                    TotalImprevue = reader[60].ToString(),
                    TotalTemps = reader[61].ToString(),
                    TotalManuel = reader[62].ToString(),
                    Commission = reader[63].ToString(),
                    TotalCommission = reader[64].ToString(),
                    Profit = reader[65].ToString(),
                    TotalProfit = reader[66].ToString(),
                    PrixTotal = reader[67].ToString(),
                    SansTemps = (bool)reader[67],
                    Type = reader[68].ToString(),
                    CheminPhotos = reader[69].ToString(),
                    Modification = (bool)reader[70],
                    Par = reader[71].ToString(),
                    MontantForfait = reader[72].ToString(),
                    InitialeForfait = reader[73].ToString(),
                });
            }
            con.Close();
        } // DB_SoumissionElec
        public static void EnumSoumissionMec()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMISSIONMEC]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumissionMecs.Add(new DB_SoumissionMec()
                {
                    Idsoumission = reader[0].ToString(),
                    Idclient = (int)reader[1],
                    Idcontact = (int)reader[2],
                    Description = reader[3].ToString(),
                    Manuel = reader[4].ToString(),
                    Creer = reader[5].ToString(),
                    CreerPar = (int)reader[6],
                    TotalPiece = reader[7].ToString(),
                    Imprevue = reader[8].ToString(),
                    TotalImprevue = reader[9].ToString(),
                    TotalTemps = reader[10].ToString(),
                    TotalManuel = reader[11].ToString(),
                    Commission = reader[12].ToString(),
                    TotalCommission = reader[13].ToString(),
                    PrixTotal = reader[14].ToString(),
                    Profit = reader[15].ToString(),
                    TotalProfit = reader[16].ToString(),
                    TempsMachinage = reader[17].ToString(),
                    TempsCoupe = reader[18].ToString(),
                    TempsSoudure = reader[19].ToString(),
                    TempsAssemblage = reader[20].ToString(),
                    TempsPeinture = reader[21].ToString(),
                    TempsTest = reader[22].ToString(),
                    TempsDessin = reader[23].ToString(),
                    TempsFormation = reader[24].ToString(),
                    TempsInstallation = reader[25].ToString(),
                    TempsGestion = reader[26].ToString(),
                    TempsShipping = reader[27].ToString(),
                    NbrePersonne = reader[28].ToString(),
                    TempsHebergement = reader[29].ToString(),
                    TotalHebergement = reader[30].ToString(),
                    TempsRepas = reader[31].ToString(),
                    TotalRepas = reader[32].ToString(),
                    TempsTransport = reader[33].ToString(),
                    TempsUniteMobile = reader[34].ToString(),
                    PrixEmballage = reader[35].ToString(),
                    TauxHebergement1 = reader[36].ToString(),
                    TauxHebergement2 = reader[37].ToString(),
                    TauxMachinage = reader[38].ToString(),
                    TauxCoupe = reader[39].ToString(),
                    TauxSoudure = reader[40].ToString(),
                    TauxAssemblage = reader[41].ToString(),
                    TauxPeinture = reader[42].ToString(),
                    TauxTest = reader[43].ToString(),
                    TauxDessin = reader[44].ToString(),
                    TauxFormation = reader[45].ToString(),
                    TauxInstallation = reader[46].ToString(),
                    TauxGestion = reader[47].ToString(),
                    TauxShipping = reader[48].ToString(),
                    TauxRepas = reader[49].ToString(),
                    TauxTransport = reader[50].ToString(),
                    TauxUniteMobile = reader[51].ToString(),
                    CheminPhotos = reader[52].ToString(),
                    Modification = (bool)reader[53],
                    Par = reader[54].ToString(),
                    MontantForfait = reader[55].ToString(),
                    InitialeForfait = reader[56].ToString(),
                });
            }
            con.Close();
        } // DB_SoumissionMec
        public static void EnumSoumissionModif()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMISSION_MODIF]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumissionModifs.Add(new DB_SoumissionModif()
                {
                    Idmodif = (int)reader[0],
                    Idsoumission = reader[1].ToString(),
                    NoEmploye = (int)reader[2],
                    Date = reader[3].ToString(),
                    Heure = reader[4].ToString(),
                    Type = reader[5].ToString(),
                    TypeModif = reader[6].ToString(),
                });
            }
            con.Close();
        } // DB_SoumissionModif
        public static void EnumSoumissionPieces()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMISSION_PIECES]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumissionPieces.Add(new DB_SoumissionPiece()
                {
                    NoEnreg = (int)reader[0],
                    Idsoumission = reader[1].ToString(),
                    Idsection = (int)reader[2],
                    NumItem = reader[3].ToString(),
                    Qte = reader[4].ToString(),
                    DescFr = reader[5].ToString(),
                    DescEn = reader[6].ToString(),
                    Manufact = reader[7].ToString(),
                    PrixList = reader[8].ToString(),
                    Escompte = reader[9].ToString(),
                    PrixNet = reader[10].ToString(),
                    Idfrs = (int)reader[11],
                    Temps = reader[12].ToString(),
                    TempsTotal = reader[13].ToString(),
                    PrixTotal = reader[14].ToString(),
                    ProfitArgent = reader[15].ToString(),
                    SousSection = reader[16].ToString(),
                    OrdreSection = reader[17].ToString(),
                    NumeroLigne = (int)reader[18],
                    PrixOrigine = reader[19].ToString(),
                    Type = reader[20].ToString(),
                    Visible = (bool)reader[21],
                    Commande = (bool)reader[22],
                    Quote = (bool)reader[23],
                    Recu = (bool)reader[24],
                    Retour = (bool)reader[25],
                    CommandeAnnulee = (bool)reader[26],
                    PieceExtra = (bool)reader[27],
                    MaterielInutile = (bool)reader[28],
                    Commentaire = reader[29].ToString(),
                    PieceExtraNonChargeable = (bool)reader[30],
                    PieceExtraChargeable = (bool)reader[31],
                    LiaisonChargeable = reader[32].ToString(),
                    Id = reader[33].ToString(),
                    Devise = reader[34].ToString(),
                    TransfertJob = (bool)reader[35],
                    Provenance = reader[36].ToString(),
                });
            }
            con.Close();
        } // GrbSoumissionPieces
        public static void EnumSoumissionPiecesTampon()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[SOUMISSION_PIECES_TAMPON]", con).ExecuteReader();
            while (reader.Read())
            {
                SoumissionPiecesTampons.Add(new DB_SoumissionPiecesTampon()
                {
                    NoEnreg = (int)reader[0],
                    DateCopie = reader[1].ToString(),
                    Initiales = reader[2].ToString(),
                    Idsoumission = reader[3].ToString(),
                    Idsection = (int)reader[4],
                    NumItem = reader[5].ToString(),
                    Qte = reader[6].ToString(),
                    DescFr = reader[7].ToString(),
                    DescEn = reader[8].ToString(),
                    Manufact = reader[9].ToString(),
                    PrixList = reader[10].ToString(),
                    Escompte = reader[11].ToString(),
                    PrixNet = reader[12].ToString(),
                    Idfrs = (int)reader[13],
                    Temps = reader[14].ToString(),
                    TempsTotal = reader[15].ToString(),
                    PrixTotal = reader[16].ToString(),
                    ProfitArgent = reader[17].ToString(),
                    SousSection = reader[18].ToString(),
                    OrdreSection = reader[19].ToString(),
                    NumeroLigne = (int)reader[20],
                    PrixOrigine = reader[21].ToString(),
                    Type = reader[22].ToString(),
                    Visible = (bool)reader[23],
                    Commande = (bool)reader[24],
                    Quote = (bool)reader[25],
                    Recu = (bool)reader[26],
                    Retour = (bool)reader[27],
                    CommandeAnnulee = (bool)reader[28],
                    PieceExtra = (bool)reader[29],
                    MaterielInutile = (bool)reader[30],
                    Commentaire = reader[31].ToString(),
                    PieceExtraNonChargeable = (bool)reader[32],
                    PieceExtraChargeable = (bool)reader[33],
                    LiaisonChargeable = reader[34].ToString(),
                    Id = reader[35].ToString(),
                    Devise = reader[36].ToString(),
                    Provenance = reader[37].ToString(),
                });
            }
            con.Close();
        } // DB_SoumissionPiecesTampon
        public static void EnumTempDp()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TEMPDP]", con).ExecuteReader();
            while (reader.Read())
            {
                TempDp.Add(new DB_TempDp()
                {
                    Id = (int)reader[0],
                    Piece = reader[1].ToString(),
                    Ordre = (int)reader[2],
                    Type = reader[3].ToString(),
                });
            }
            con.Close();
        } // DB_TempDp
        public static void EnumTempInventaire()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TEMPINVENTAIRE]", con).ExecuteReader();
            while (reader.Read())
            {
                TempInventaire.Add(new DB_TempInventaire()
                {
                    Idinventaire = (int)reader[0],
                    NoItem = reader[1].ToString(),
                    Description = reader[2].ToString(),
                });
            }
            con.Close();
        } // DB_TempInventaire
        public static void EnumTransport()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TRANSPORT]", con).ExecuteReader();
            /* Généré par GetOrdinalRequeteSQL_x86 1.0.5 
            © Patrice Waechter-Ebling 2024
            ID 0 : transport
           */
            int pos = 0;
            while (reader.Read())
            {
                pos++;
                Transports.Add(new DB_Transport()
                {
                    Transports = reader[0].ToString()
                });
            }
            con.Close();
        } // Transports
        public static void EnumVendeur()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[VENDEUR]", con).ExecuteReader();
            /* Généré par GetOrdinalRequeteSQL_x86 1.0.5 
            © Patrice Waechter-Ebling 2024
            ID 0 : no
            ID 1 : idclient
            ID 2 : date
            ID 3 : contact
            ID 4 : commentaire
            ID 5 : EnregPar
            ID 6 : Etat
            ID 7 : Enregistrerpar
            ID 8 : Type
           */
            while (reader.Read())
            {
                Vendeurs.Add(new DB_Vendeur()
                {
                    No = (int)reader[0],
                    Idclient = (int)reader[1],
                    Date = reader[2].ToString(),
                    Contact = reader[3].ToString(),
                    Commentaire = reader[4].ToString(),
                    EnregPar = reader[5].ToString(),
                    Etat = reader[6].ToString(),
                    Enregistrerpar = reader[7].ToString(),
                    Type = reader[8].ToString(),
                });
            }
            con.Close();
        } // DB_Vendeur
        public static void EnumProjetPieceBack()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJET_PIECE_BACK]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetPiecesBack.Add(new DB_ProjetTamponBack()
                {
                    NoEnreg = (int)reader[0],
                    Idprojet = reader[1].ToString(),
                    Idsection = (int)reader[2],
                    NumItem = reader[3].ToString(),
                    Qte = reader[4].ToString(),
                    DescFr = reader[5].ToString(),
                    DescEn = reader[6].ToString(),
                    Manufact = reader[7].ToString(),
                    PrixList = reader[8].ToString(),
                    Escompte = reader[9].ToString(),
                    PrixNet = reader[10].ToString(),
                    Idfrs = (int)reader[11],
                    Temps = reader[12].ToString(),
                    TempsTotal = reader[13].ToString(),
                    PrixTotal = reader[14].ToString(),
                    ProfitPourcent = reader[15].ToString(),
                    ProfitArgent = reader[16].ToString(),
                    SousSection = reader[17].ToString(),
                    OrdreSection = reader[18].ToString(),
                    NumeroLigne = (int)reader[19],
                    PrixOrigine = reader[20].ToString(),
                    Type = reader[21].ToString(),
                    Visible = (bool)reader[22],
                    Commande = (bool)reader[23],
                    Quote = (bool)reader[24],
                    Recu = (bool)reader[25],
                    Retour = (bool)reader[26],
                    NoRetour = reader[27].ToString(),
                    CommandeAnnulee = (bool)reader[28],
                    DateReception = reader[29].ToString(),
                    QuantiteRecue = reader[30].ToString(),
                    Facturation = reader[31].ToString(),
                    Id = reader[32].ToString(),
                    PieceExtra = (bool)reader[33],
                    PieceExtraChargeable = (bool)reader[34],
                    PieceExtraNonChargeable = (bool)reader[35],
                    DateCommande = reader[36].ToString(),
                    DateRequise = reader[37].ToString(),
                    NomCommande = reader[38].ToString(),
                    NoSequentiel = reader[39].ToString(),
                    MaterielInutile = (bool)reader[40],
                    Commentaire = reader[41].ToString(),
                    DateRetour = reader[42].ToString(),
                    Provenance = reader[43].ToString(),
                    Devise = reader[44].ToString(),
                });
            }
            con.Close();
        } // DB_ProjetPieceBack
        public static void EnumProjetTamponBack()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[PROJET_TAMPON_BACK]", con).ExecuteReader();
            while (reader.Read())
            {
                ProjetTamponBacks.Add(new DB_ProjetTamponBack()
                {
                    NoEnreg = (int)reader[0],
                    Idprojet = reader[1].ToString(),
                    Idsection = (int)reader[2],
                    NumItem = reader[3].ToString(),
                    Qte = reader[4].ToString(),
                    DescFr = reader[5].ToString(),
                    DescEn = reader[6].ToString(),
                    Manufact = reader[7].ToString(),
                    PrixList = reader[8].ToString(),
                    Escompte = reader[9].ToString(),
                    PrixNet = reader[10].ToString(),
                    Idfrs = (int)reader[11],
                    Temps = reader[12].ToString(),
                    TempsTotal = reader[13].ToString(),
                    PrixTotal = reader[14].ToString(),
                    ProfitPourcent = reader[15].ToString(),
                    ProfitArgent = reader[16].ToString(),
                    SousSection = reader[17].ToString(),
                    OrdreSection = reader[18].ToString(),
                    NumeroLigne = (int)reader[19],
                    PrixOrigine = reader[20].ToString(),
                    Type = reader[21].ToString(),
                    Visible = (bool)reader[22],
                    Commande = (bool)reader[23],
                    Quote = (bool)reader[24],
                    Recu = (bool)reader[25],
                    Retour = (bool)reader[26],
                    NoRetour = reader[27].ToString(),
                    CommandeAnnulee = (bool)reader[28],
                    DateReception = reader[29].ToString(),
                    QuantiteRecue = reader[30].ToString(),
                    Facturation = reader[31].ToString(),
                    Id = reader[32].ToString(),
                    PieceExtra = (bool)reader[33],
                    PieceExtraChargeable = (bool)reader[34],
                    PieceExtraNonChargeable = (bool)reader[35],
                    DateCommande = reader[36].ToString(),
                    DateRequise = reader[37].ToString(),
                    NomCommande = reader[38].ToString(),
                    NoSequentiel = reader[39].ToString(),
                    MaterielInutile = (bool)reader[40],
                    Commentaire = reader[41].ToString(),
                    DateRetour = reader[42].ToString(),
                    Provenance = reader[43].ToString(),
                    Devise = reader[44].ToString(),
                });
            }
            con.Close();
        } // DB_ProjetTamponBack
        public static void EnumTableDesErreurs()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TABLE DES ERREURS]", con).ExecuteReader();
            /* Généré par GetOrdinalRequeteSQL_x86 1.0.5 
            © Patrice Waechter-Ebling 2024
            ID 0 : no
            ID 1 : idclient
            ID 2 : date
            ID 3 : contact
            ID 4 : commentaire
            ID 5 : EnregPar
            ID 6 : Etat
           */
            while (reader.Read())
            {
                TableDesErreurs.Add(new DB_TableDesErreurs()
                {
                    No = (int)reader[0],
                    Idclient = (int)reader[1],
                    Date = reader[2].ToString(),
                    Contact = reader[3].ToString(),
                    Commentaire = reader[4].ToString(),
                    EnregPar = reader[5].ToString(),
                    Etat = reader[6].ToString(),
                });
            }
            con.Close();
        } // TableDesErreurs
        public static void EnumTblCategorie()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TBL_CATEGORIE]", con).ExecuteReader();
            /* Généré par GetOrdinalRequeteSQL_x86 1.0.5 
           © Patrice Waechter-Ebling 2024
           ID 0 : Correspondance
           ID 1 : Nom
          */
            while (reader.Read())
            {
                TblCategories.Add(new DB_TblCategorie()
                {
                    Correspondance = reader[0].ToString(),
                    Nom = reader[1].ToString(),
                });
            }
            con.Close();
        } // DB_TblCategorie
        public static void EnumTblPunchType()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[TBL_PUNCH_TYPE]", con).ExecuteReader();
            while (reader.Read())
            {
                TblPunchTypes.Add(new DB_TblPunchType()
                {
                    Mode = reader[0].ToString(),
                    Name = reader[1].ToString(),
                });
            }
            con.Close();
        } // DB_TblPunchType
        public static void EnumBonTravail()
        {
            con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            reader = new SqlCommand($"SELECT NO, QTE_COM, QTE_LIVR, QTE_BO, DESCRIPTION, MANUFACTURIER,[USER] FROM [DBO].[IMPRESSION_BONLIVRAISON]", con).ExecuteReader();
            /* Généré par GetOrdinalRequeteSQL_x86 1.0.5 
           © Patrice Waechter-Ebling 2024
           ID 0 : NO
           ID 1 : QTE_COM
           ID 2 : QTE_LIVR
           ID 3 : QTE_BO
           ID 4 : DESCRIPTION
           ID 5 : MANUFACTURIER
           ID 6 : USER
          */
            while (reader.Read())
            {
                bonTravail.Add(new DB_ImpressionBonlivraison()
                {
                    No = (int)reader[0],
                    QteCom = reader[1].ToString(),
                    QteLivr = reader[2].ToString(),
                    QteBo = reader[3].ToString(),
                    Description = reader[4].ToString(),
                    Manufacturier = reader[5].ToString(),
                    User = reader[6].ToString(),
                });//ajoute tous ceux qui coresspondent a l'utilisateur logge
                if (bonTravail.Count == 0)
                {
                    MessageBox.Show($"Désolé {IdNomEmploye},Je n'ai pas trouvé de bon a votre nom",Application.ProductName+".Impression.Bon2Livraison");
                }
            }
            con.Close();
        }
        public static void EnumFournisseurRestraints()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "autogrb", "SELECT IDFRS, NOMFOURNISSEUR, ABBREVIATION, REP, INTERNE, ADRESSE, VILLE, [PROV/ETAT], PAYS, CODEPOSTAL, TELEPHONNE," +
                " FAX, [E-MAIL], CONDTRANSPORT, NOPOSTE, SITEWEB, COMMENTAIRE, DATECRÉATION, USERCRÉATION, DATEMODIFICATION, USERMODIFICATION, ENTRYIDOUTLOOK, " +
                "SUPPRIMÉ, CATEGORIE  FROM FOURNISSEUR");
            while (!rst.EOF)
            {
                Fournisseurs.Add(new DB_Fournisseur(rst.Fields[0].Value, rst.Fields[1].Value, rst.Fields[2].Value, rst.Fields[3].Value, rst.Fields[4].Value,
                    rst.Fields[5].Value, rst.Fields[6].Value, rst.Fields[7].Value, rst.Fields[8].Value, rst.Fields[9].Value, rst.Fields[10].Value,
                    rst.Fields[11].Value, rst.Fields[12].Value, rst.Fields[13].Value, rst.Fields[14].Value, rst.Fields[15].Value, rst.Fields[16].Value,
                    rst.Fields[17].Value, rst.Fields[18].Value, rst.Fields[19].Value, rst.Fields[20].Value, rst.Fields[21].Value, rst.Fields[22].Value, rst.Fields[23].Value));
                rst.MoveNext();
            }
            rst.Close();
        }
        public static void ImporterCSVData(string Table, string CSVFile)
        {
            String line;
            SqlConnection sql = new SqlConnection(StringSQL);
            SqlDataReader sqlImport = new SqlCommand($"SELECT * FROM '{Table.ToUpper()}'", sql).ExecuteReader();
            int nbsql = 0;
            if (sqlImport.Read())
            {
                nbsql = sqlImport.GetSchemaTable().Columns.Count;
            }
            try
            {
                StreamReader sr = new StreamReader(CSVFile);
                line = sr.ReadLine();
                string[] data = line.Split(';');
                int nbCollumn = data.Length;
                if (nbsql != nbCollumn)
                {
                    MessageBox.Show($"Le serveur indique {nbsql}champs tandis que l'assistant d'importation lui indique {nbCollumn}");
                    return;
                }
                while (line != null)
                {
                    data = line.Split(';');
                    string sqlData = $"INSERT '{Table.ToUpper()}'(";
                    for (int x = 0; x < nbCollumn; x++)
                    {
                        if (x < nbCollumn - 1)
                        {
                            sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName},";
                        }
                        else
                        {
                            sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName})VALUES(";
                        }
                    }
                    /// integre les donnees dans chaque adresse
                    for (int x = 0; x < nbCollumn; x++)
                    {
                        if (x < nbCollumn - 1)
                        {
                            sqlData += $"{data[x]},";
                        }
                        else
                        {
                            sqlData += $"{data[x]})";
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Execution terminee");
            }
        }
        public static void ImporterSQLData(string Serveur, string Catalogue, string Table)
        {
            SqlConnection sql = new SqlConnection($"Data Source={Serveur};Initial Catalog=autogrb;Integrated Security=True;");
            SqlConnection sql1 = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\MDF;Integrated Security=True;Persist Security Info=True;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
            int nbColum = 0x1;
            sql.Open();
            SqlDataReader sqlImport = new SqlCommand($"SELECT * FROM '{Table.ToUpper()}'", sql).ExecuteReader();
            while (sqlImport.Read())
            {
                nbColum = sqlImport.FieldCount;
                ///creer l'entete descriptive de la requete
                string sqlData = $"INSERT '{Table.ToUpper()}'(";
                for (int x = 0; x < nbColum; x++)
                {
                    if (x < nbColum - 1)
                    {
                        sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName},";
                    }
                    else
                    {
                        sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName})VALUES(";
                    }
                }
                /// integre les donnees dans chaque adresse
                for (int x = 0; x < nbColum; x++)
                {
                    if (x < nbColum - 1)
                    {
                        sqlData += $"{sqlImport[x]},";
                    }
                    else
                    {
                        sqlData += $"{sqlImport[x]})";
                    }
                }
                ///envoyer la requete au serveur
                try
                {
                    sql1.Open();
                    SqlCommand cmd = new SqlCommand(sqlData, sql1);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                sql1.Close();
            }
            sql.Close();
        }
        public static void ImporterSQLData(string Table)
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            SqlConnection sql1 = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\MDF;Integrated Security=True;Persist Security Info=True;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
            int nbColum = 0x1;
            sql.Open();
            SqlDataReader sqlImport = new SqlCommand($"SELECT * FROM '{Table.ToUpper()}'", sql).ExecuteReader();
            while (sqlImport.Read())
            {
                nbColum = sqlImport.FieldCount;
                ///creer l'entete descriptive de la requete
                string sqlData = $"INSERT '{Table.ToUpper()}'(";
                for (int x = 0; x < nbColum; x++)
                {
                    if (x < nbColum - 1)
                    {
                        sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName},";
                    }
                    else
                    {
                        sqlData += $"{sqlImport.GetSchemaTable().Columns[x].ColumnName})VALUES(";
                    }
                }
                /// integre les donnees dans chaque adresse
                for (int x = 0; x < nbColum; x++)
                {
                    if (x < nbColum - 1)
                    {
                        sqlData += $"{sqlImport[x]},";
                    }
                    else
                    {
                        sqlData += $"{sqlImport[x]})";
                    }
                }
                ///envoyer la requete au serveur
                try
                {
                    sql1.Open();
                    SqlCommand cmd = new SqlCommand(sqlData, sql1);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                sql1.Close();
            }
            sql.Close();
        }
        public static bool OuvrirConnectionMDB(string Path)
        {
            string sdsn;
            //            sdsn = $"Provider=Microsoft.Jet.OLEDB.4.0;User ID = Admin;Data Source={Path};Persist Security Info=False";
            if (Gauche(Path, 2) == "\\\\")
            {
                mdbodbc.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";"); //ouverture DB en mode reseau 
            }else {
                mdbodbc.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";Persist Security Info=False;"); //ouverture DB en mode local 
            }
            if (!(mdbodbc is null)) { return true; }
            return false;
        }
        public static void FermerConnectionMDB()
        {
            if (!(mdbodbc is null)) { odbc.Close(); }
        }
        public static void ListerTableSurLeServeur()
        {
            using (SqlConnection con = new SqlConnection(StringSQL))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        SqlNameDB = reader.GetSchemaTable().TableName;
                        TablesSQL.Clear();
                        while (reader.Read())
                        {
                            TablesSQL.Add((string)reader["TABLE_NAME"].ToString().ToUpper());
                        }
                    }
                }
                con.Close();
            }
        }
        public static void InitialiserODBC()
        {
            if (odbc.State == 0)
            {
                odbc.Open($"Provider=SQLOLEDB;Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=AutoGRB;", "sa", "$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo", -1);
            }
        }
        public static ADODB.Recordset SqlLinkODBC(string Requete)
        {
            InitialiserODBC();
            ADODB.Recordset record = new ADODB.Recordset();
            if (record.State == 1) { record.Close(); }
            record.Open(Requete, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            return record;
        }
        public static ADODB.Recordset SqlLinkODBC(ADODB.Recordset record, string Requete)
        {
            InitialiserODBC();
           LogSQL(Requete, System.Windows.Forms.Application.ProductName,"SqlLinkODBC");
            record.Open(Requete, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            return record;
        }
        public static void UpdateSQL(string requeteSQL)
        {
            StreamWriter sw = new StreamWriter($"{Tests}RequetesSQL.txt", true);
            sw.WriteLine(IdNomEmploye + "@" + Conteneur.ip + "@" + DateTime.Now.ToString());
            sw.WriteLine(requeteSQL);
            sw.Close();
            try
            {
                if (odbc.State == 0) { odbc.Open($"Provider=SQLOLEDB;Data Source=production\\sqlexpress;Initial Catalog=AutoGRB;", "sa", "$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo", -1); }
                object affectés;
                odbc.Execute(requeteSQL, out affectés, -1);
                if ((int)affectés < 2)
                {
                    Conteneur.txtStatus.Text = $"{affectés} enregistrement a été affecté";
                }
                else
                {
                    Conteneur.txtStatus.Text = $"{affectés} enregistrements ont étés affectés";
                }
            }
            catch (Exception ex)
            {
                sw = new StreamWriter($"{Tests}Erreurs_SQLUpdates.txt", true);
                sw.WriteLine(IdNomEmploye + "@" + Conteneur.ip + "@" + DateTime.Now.ToString());
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.HResult);
                sw.WriteLine(ex.InnerException);
                sw.WriteLine(ex.Source);
                sw.WriteLine(ex.StackTrace);
                sw.WriteLine(ex.TargetSite);
                sw.Close();
                MessageBox.Show($"{requeteSQL}\n\n{ex.Message}\n{ex.HResult}\n{ex.InnerException}\n{ex.Source}\n{ex.StackTrace}\n{ex.TargetSite}", "Surveillance SQL", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        internal static string GetIdSecureKeyFromServer()
        {
            if (modeDev)
            {
                return $"{Environment.UserName}@{Conteneur.ip.MapToIPv4().GetHashCode()}";
            }
            else
            {
                SqlConnection sql = new SqlConnection($"Data Source=production\\sqlexpress;Initial Catalog=WebAccess;Integrated Security=false;Persist Security Info=True;User ID=sa; pwd=$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo;");
                Program.LogSQL(sql.ConnectionString, System.Windows.Forms.Application.ProductName, "GetIdSecureKeyFromServer");
                sql.Open();
                SqlDataReader reader = new SqlCommand($"SELECT *  FROM [WebAccess].[DBO].[WEBUSER]  where  [LOGINNAME]='{IdLoginEmploye}' and [EMPLOYE]='{IdNomEmploye}' and [NOEMPLOYE]='{IdNoEmploye}'", sql).ExecuteReader();
                while (reader.Read())
                {
                    if ((bool)reader[5] & (bool)reader[6] & (bool)reader[7] & (bool)reader[8]) { g_admin = true; }
                    return reader[3].ToString();
                }
                return string.Empty;
            }
        }
        public static void OuvrirConnexionSQL() => con = new SqlConnection(StringSQL);
        public static void ExporterLesNomsDesTablesSQL()
        {
            ListerTableSurLeServeur();
            if (TablesSQL.Count < 1)
            {
                MessageBox.Show("Le contenteur est vide");
            }
            else
            {
                try
                {
                    string sortie = SqlNameDB + ".txt";
                    StreamWriter sw = new StreamWriter(sortie);
                    sw.WriteLine(SqlNameDB);
                    foreach (string p in TablesSQL)
                    {
                        sw.WriteLine(p);
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Écriture du fichier teminée");
                }
            }
        }
        public static void ImporterSqlDataRaffale()
        {
            ListerTableSurLeServeur();
            foreach (string p in TablesSQL) { ImporterSQLData(p); }
        }
        public static int ImportRestraint(string table)
        {
            Recordset rd = new Recordset();
            rd.Open($"SELECT [POSITION] FROM [DBO].[IDENTITÉ] WHERE [TABLEANCIENDB]='{table}'", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            Clipboard.SetText(rd.Source);
            if (!rd.EOF)
            {
                return (int)rd.Fields[0].Value;
            }
            else
            {
                MessageBox.Show(table + " introuvable dans le descripteur", Application.ProductName + "SQL.ImportRestraint");
            }
            rd.Close();
            rd = null;
            return 0;
        } 
        internal string GetDosFormat(String path)
        {
            StringBuilder shortPath = new StringBuilder(255);
            GetShortPathName(path, shortPath, shortPath.Capacity);
            return shortPath.ToString();
        }
        internal string GetNomEfs(String path)
        {
            StringBuilder longPath = new StringBuilder(255);
            GetLongPathName(path, longPath, longPath.Capacity);
            return longPath.ToString();
        }
        public static ADODB.Recordset SqlLinkODBC(ADODB.Recordset record, string Catalogue, string Requete)
        {
            LogSQL(Requete, "Program", "SqlLinkODBC");
            if (record is null) { throw new ArgumentNullException(nameof(record)); }
            if (string.IsNullOrWhiteSpace(Catalogue)) { throw new ArgumentException($"'{nameof(Catalogue)}' ne peut pas avoir une valeur null ou être un espace blanc.", nameof(Catalogue)); }
            if (string.IsNullOrWhiteSpace(Requete)) { throw new ArgumentException($"'{nameof(Requete)}' ne peut pas avoir une valeur null ou être un espace blanc.", nameof(Requete)); }
            if (odbc.State == 0)
            {
                odbc.Open($"Provider=SQLOLEDB;Data Source=production\\sqlexpress;Initial Catalog=autogrb;", "sa", "$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo", -1);
            }
            record.Open(Requete, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            return record;
        }
        /// update sql a distance avec retour resultat nbr operation
        /// <param name="requeteSQL">instruction passée a SQL</param>
        // Pour Access 2000, il faut utiliser Microsoft Jet 4.0 seulement si application est en 32bits sinon
        //  il vaut mieux utiliser la ACE.12.0 (office 2010) 
        //ideal SQL Natif 17 sous Serveur 2019-2022
        public static string GetSqlWhereIntervalDate(DateTime debut, DateTime fin)
        {
            return $" between '{debut.ToShortDateString()}'and '{fin.ToShortDateString()}'".ToUpper();
        }
        public static void ExecuteSQL(string requete, string Table, bool Identite)
        {
            if (Identite == true)
            {
                string str = $"SET IDENTITY_INSERT [DBO].[{Table}] ON ";
                str += requete;
                str += $"SET IDENTITY_INSERT [DBO].[{Table}] OFF ";
                UpdateSQL(str);
            }
            else
            {
                UpdateSQL(requete);
            }
        }
        internal static void IsNouvelleAnneeFiscale()
        {
            if (DateTime.Today.Month == 10 & DateTime.Today.Day < 3)
            {
                MessageBox.Show($"Attention nous sommes au mois d'{NomMois[10]} !!! \n\tC'est le temps de l'inventaire. \n" +
                    $"\nN'oubliez pas que c'est aussi a cette période que les codes de projet changent passant de" +
                    $" {Droite(DateTime.Today.Year.ToString(), 1)}XXXX-XX à {Droite(DateTime.Today.AddYears(1).Year.ToString(), 1)}XXXX-XX"
                    , Application.ProductName + ".AnnéeFiscale", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        /// <summary>
        /// Sert a suivre les echanges entre le serveur SQL et le controleur
        /// </summary>
        public static void LogSQL(string requeteSQL, string Module, string Fonction) => swSQL.WriteLine($"{DateTime.Now.ToString()} => {System.Windows.Forms.Application.ProductName}.{Module}.{Fonction}\n{Conteneur.ip} >> {requeteSQL}\n");
        /// Cette fonction vien de MSDN Microsoft Developper
        public static void SendEmailFromAccount(Outlook.Application application, string subject, string body, string to)
        {
            try
            {
                Outlook.MailItem newMail = (Outlook.MailItem)application.CreateItem(OlItemType.olMailItem);
                newMail.To = to;
                newMail.Subject = subject;
                newMail.Body = body;
                Outlook.Account account = GetAccountForEmailAddress(application, "mail.grb-inc.com");
                newMail.SendUsingAccount = account;
                newMail.Send();
            }
            catch (Exception ex)
            {
                AfficherErreur("SendEmailFromAccount", "Program.MailDeamon", ex);
            }
        }
        public static Outlook.Account GetAccountForEmailAddress(Outlook.Application application, string smtpAddress)
        {
            Outlook.Accounts accounts = application.Session.Accounts;
            foreach (Outlook.Account account in accounts)
            {
                if (account.SmtpAddress == smtpAddress)
                {
                    return account;
                }
            }
            throw new System.Exception(string.Format("No Account with SmtpAddress: {0} exists!", smtpAddress));
        }
        internal static int GetPersRess(string v)
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader rd = new SqlCommand($"SELECT [IDCONTACT] FROM [DBO].[CONTACT] WHERE [NOMCONTACT]='{v}'", sql).ExecuteReader();
            while (rd.Read())
            {
                return (int)rd[0];
            }
            rd.Close();
            sql.Close();
            return 0;
        }
        public static void Ouvrir(string url) => Process.Start(url);
        public static string[] SegmenterTexte(string texte, char delimiteur) => texte.Split(delimiteur);
        internal static string GetNomClient(int idClient)
        {
            if (Clients.Count < 1) { EnumClient(); }
            foreach (DB_Client p in Clients)
            {
                if (p.Idclient == idClient)
                {
                    return p.NomClient;
                }
            }
            return "Nom inconnu";
        }
        internal static int GetClientID(string nom)
        {
            foreach (ListItem p in clients)
            {
                if (p.Text == nom)
                {
                    return int.Parse(p.Value);
                }
            }
            return 0;
        }
        internal static string GetInitialesEmploye(int idEmploye)
        {
            if (Employes.Count < 1) { EnumEmployes(); }
            foreach (DB_Employe p in Employes)
            {
                if (p.Noemploye == idEmploye)
                {
                    return p.Initiale;
                }
            }
            return idEmploye.ToString();
        }
        public static string RetireTypeProjet(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text.Substring(1, text.Length - 1);
            }
            return text;
        }
        public static string Gauche(string text, int longeur)
        {
            if (longeur < text.Length)
            {
                return text.Substring(0, longeur);
            }
            return text;
        }
        public static string Droite(string text, int longeur)
        {
            if (longeur < text.Length & longeur > 0)
            {
                return text.Substring(text.Length - longeur, longeur);
            }
            return text;
        }
        public static int GetPosition(string Chaine, char Charactere)
        {
            for (int x = 0; x < Chaine.Length; x++)
            {
                if (Chaine[x] == Charactere)
                {
                    return x;
                }
            }
            return Chaine.Length;
        }
        internal static string[] DecouperChaine(string chaine, char separateur) { return chaine.Split(separateur); }
        public static string ExtraireIdAchat(string chaine) => Gauche(chaine, GetPosition(chaine.Trim(), '-') + 3);
        public static int ExtraireIndexAchat(string chaine) => int.Parse(Droite(chaine, 3));
        public static string Gauche(string text, short longeur)
        {
            if (longeur < text.Length)
            {
                return text.Substring(0, longeur);
            }
            return text;
        }
        public static string Droite(string text, short longeur)
        {
            if (longeur < text.Length & longeur > 0)
            {
                return text.Substring(text.Length - longeur, longeur);
            }
            return text;
        }
        public static int GetASCII(string Lettre) => (int)GetASCII(Lettre);
        public static int OuvrirForm(string commande, int Zoom) => ShellExecute(0x00, "open", commande, string.Empty, Environment.CurrentDirectory, Zoom);
        public static void OuvrirForm(string v1, bool v2)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = v1;
            psi.UseShellExecute = true;
            if (v2 == false) { psi.WindowStyle = ProcessWindowStyle.Normal; } else { psi.WindowStyle = ProcessWindowStyle.Maximized; }
            Process.Start(psi);
        }
        internal static int Bool2Int(bool @checked)
        {
            if (@checked == true) return 1;
            return 0;
        }
        internal static void AfficherErreur(string Module, string Fonction, Exception ex)
        {
            ADODB.Recordset rd = new ADODB.Recordset();
            string sql = $"SQLTracker@production.grb.local => {ex.InnerException}";
            StreamWriter sw = new StreamWriter($"{Tests}{GenererNomFichierByDateTime($"{Module}_{Fonction}", TypeFormatSortieFichier.ID_TEXT)}");
            sql += $"\n{Conteneur.idNomSemaine.Text}\t{Conteneur.idGroupeEmploye.Text}";
            int newClef = DateTime.Now.Year + DateTime.Now.DayOfYear + DateTime.Now.Hour + DateTime.Now.Minute;
            sql += $"{IdNomEmploye}\t{IdNoEmploye}\t{Conteneur.ip.MapToIPv4()}\t{Conteneur.ip.GetHashCode()}\t{DateTime.Now.ToShortDateString()}\t{DateTime.Now.ToShortTimeString()},'{(int)DateTime.Now.DayOfWeek}'\nErreur dans '{Module}.{Fonction}" +
                $"'{Math.Abs(ex.HResult)}','{ex.Message}','{ex.Source}','{ex.Data}')";
            sql += $" Une erreur dans {Application.ProductName}.{Module}.{Fonction}\nNouvel index d'erreur:{newClef}\nMessage: {ex.Message}\nResultat:{ex.HResult}\n" +
                $"Exception:{ex.InnerException}\nSources: {ex.Source}\nTrace:{ex.StackTrace}\nInformations{ex.Data}";
            sw.WriteLine(sql);
            sw.WriteLine("Informations complémentaires");
            MessageBox.Show(sql, "SQLTracker@production.grb.local", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Conteneur.txtStatus.ForeColor = COLOR_ROUGE;
            Conteneur.txtStatus.Text = $"Une erreur dans {Application.ProductName}.{Module}.{Fonction} index d'erreur: {newClef}";
            Conteneur.txtStatus.ForeColor = COLOR_ORANGE;
            sw.Close();
            Conteneur.txtStatus.ForeColor = COLOR_BLEU;
            Conteneur.txtStatus.Text = $"Log généré {Application.ProductName}_{Module}_{Fonction}.txt";
            rd.Open($"SELECT TOP (1) * FROM [DBO].[ERREURS] ORDER BY [IDERREUR] DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (rd.EOF)
            {
                rd.AddNew();
                if (IdNomEmploye == "") { rd.Fields["Qui"].Value = "SQLTracker@production.grb.local"; } else { rd.Fields["Qui"].Value = IdNomEmploye; }
                rd.Fields["Date"].Value = DateTime.Today.ToShortDateString();
                rd.Fields["Heure"].Value = DateTime.Now.ToShortTimeString();
                rd.Fields["Form"].Value = Module;
                rd.Fields["Methode"].Value = Fonction;
                rd.Fields["NoLigne"].Value = DateTime.Now.Hour;
                rd.Fields["NoErreur"].Value = ex.HResult;
                rd.Fields["Description"].Value = ex.Message;
                rd.Fields["Source"].Value = ex.Source;
                rd.Fields["Params"].Value = ex.TargetSite.ToString();
                rd.Update();
            }
            else
            {
                if (IdNomEmploye == "") { rd.Fields["Qui"].Value = "SQLTracker@production.grb.local"; } else { rd.Fields["Qui"].Value = IdNomEmploye; }
                rd.Fields["Date"].Value = DateTime.Today.ToShortDateString();
                rd.Fields["Heure"].Value = DateTime.Now.ToShortTimeString();
                rd.Fields["Form"].Value = Module;
                rd.Fields["Methode"].Value = Fonction;
                rd.Fields["NoLigne"].Value = DateTime.Now.Hour;
                rd.Fields["NoErreur"].Value = ex.HResult;
                rd.Fields["Description"].Value = ex.Message;
                rd.Fields["Source"].Value = ex.Source;
                rd.Fields["Params"].Value = ex.TargetSite.ToString();
                rd.Update();

            }
        }
        internal static int GetContactID(string Nom)
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            Nom = Nom.Replace("'", "''");
            SqlLinkODBC(rst, $"SELECT [IDCONTACT] FROM [DBO].[CONTACT] WHERE [NOMCONTACT]='{Nom}'");
            LogSQL($"SELECT [IDCONTACT] FROM [DBO].[CONTACT] WHERE [NOMCONTACT]='{Nom}'", "Program", "GetContactID");
            if (!rst.EOF)
            {
                return (int)rst.Fields[0].Value;
            }
            rst.Close();
            return 0;
        }
        internal static string GetCategorieID(string v)
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            v = v.Replace("'", "''");
            LogSQL($"SELECT [CORRESPONDANCE],[NOM]  FROM [DBO].[TBL_CATEGORIE] WHERE NOM='{v}'", "Program", "GetCategorieID");
            SqlLinkODBC(rst, $"SELECT [CORRESPONDANCE],[NOM]  FROM [DBO].[TBL_CATEGORIE] WHERE NOM='{v}'");
            if (!rst.EOF)
            {
                return rst.Fields[0].Value;
            }
            rst.Close();
            return string.Empty;
        }
        internal static int GetFournisseurID(string v)
        {
            foreach (ListItem p in fournisseurs)
            {
                if (p.Text == v)
                {
                    int.Parse(p.Value);
                }
            }
            return 0;
        }
        internal static bool IsNumeric(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                if (!float.IsNaN(float.Parse(text)))
                {
                    return true;
                }
            }
            return false;
        }
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            webServer = //"https://production.grb.local/autogrb/Content";
            sqlServer = "PRODUCTION\\SQLEXPRESS";
            modeDev = false;
            StringSQL = $"Data Source=production\\sqlexpress;Initial Catalog=AutoGRB;Integrated Security=false;Persist Security Info=True;User ID=sa; pwd=$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo;";
            LogSQL(StringSQL, "Program", "Main");
            Application.Run(new Conteneur());
        }
        internal static string Conversion_Renamed(string value, EnumConvert mODE, int v) => value;
        internal static void AfficherErreur(string v1, string v2, Exception ex, string sNoProjSoum)
        {
            AfficherErreur(v1 + sNoProjSoum, v2, ex);
        }
        internal static string Conversion_Renamed(string value, EnumConvert mODE_POURCENT) => value;
        internal static int CheckConfig()
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader reader = new SqlCommand("SELECT *  FROM [DBO].[CONFIG] ORDER BY TAUXTESTELEC ASC", sql).ExecuteReader();
            LogSQL($"SELECT *  FROM [DBO].[CONFIG] ORDER BY TAUXTESTELEC ASC", "Program", "CheckConfig");

            while (reader.Read())
            {
                /// stoque les données dans une matrice en vue de reconstruire la configuration en se basant sur les tarifs les plus élevés 
                /// stratégie basée sur le cout de la vie : tout est toujours plus cher
                CONFIG.Add(new DB_Config((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13],
                    (string)reader[14], (string)reader[15], (string)reader[16], (string)reader[17], (string)reader[18],
                    (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22], (string)reader[23],
                    (string)reader[24], (string)reader[25], (string)reader[26], (string)reader[27], (string)reader[28],
                    (string)reader[29], (string)reader[30], (string)reader[31], (string)reader[32], (string)reader[33],
                    (string)reader[34], (string)reader[35], (string)reader[36], (string)reader[37], (string)reader[38],
                    (string)reader[39], (string)reader[40], (string)reader[41], (string)reader[42], (string)reader[43],
                    (string)reader[44], (string)reader[45], (string)reader[46], (string)reader[47], (string)reader[48],
                    (string)reader[49], (string)reader[50], (string)reader[51], (string)reader[52], (string)reader[53],
                    (string)reader[54]));
            }
            sql.Close();
            return CONFIG.Count;
        }
    }
}
