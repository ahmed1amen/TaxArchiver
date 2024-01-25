using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static TaxArchiver.Models.FamilleCarte;

namespace TaxArchiver.Models
{
    public class Facture
    {
        // Token: 0x1700111F RID: 4383
        // (get) Token: 0x0600405D RID: 16477 RVA: 0x001F499C File Offset: 0x001F2B9C
        // (set) Token: 0x0600405E RID: 16478 RVA: 0x001F49A4 File Offset: 0x001F2BA4
        public int _id { get; set; }

        // Token: 0x17001120 RID: 4384
        // (get) Token: 0x0600405F RID: 16479 RVA: 0x001F49AD File Offset: 0x001F2BAD
        // (set) Token: 0x06004060 RID: 16480 RVA: 0x001F49B5 File Offset: 0x001F2BB5
        public string _table { get; set; }

        // Token: 0x17001121 RID: 4385
        // (get) Token: 0x06004061 RID: 16481 RVA: 0x001F49BE File Offset: 0x001F2BBE
        // (set) Token: 0x06004062 RID: 16482 RVA: 0x001F49C6 File Offset: 0x001F2BC6
        public int _couvert { get; set; }

        // Token: 0x17001122 RID: 4386
        // (get) Token: 0x06004063 RID: 16483 RVA: 0x001F49CF File Offset: 0x001F2BCF
        // (set) Token: 0x06004064 RID: 16484 RVA: 0x001F49D7 File Offset: 0x001F2BD7
        public Utilisateur _utilisateur { get; set; }

        // Token: 0x17001123 RID: 4387
        // (get) Token: 0x06004065 RID: 16485 RVA: 0x001F49E0 File Offset: 0x001F2BE0
        // (set) Token: 0x06004066 RID: 16486 RVA: 0x001F49E8 File Offset: 0x001F2BE8
        public decimal _totalFacture { get; set; }

        // Token: 0x17001124 RID: 4388
        // (get) Token: 0x06004067 RID: 16487 RVA: 0x001F49F1 File Offset: 0x001F2BF1
        // (set) Token: 0x06004068 RID: 16488 RVA: 0x001F49F9 File Offset: 0x001F2BF9
        public decimal _totalTva { get; set; }

        // Token: 0x17001125 RID: 4389
        // (get) Token: 0x06004069 RID: 16489 RVA: 0x001F4A02 File Offset: 0x001F2C02
        // (set) Token: 0x0600406A RID: 16490 RVA: 0x001F4A0A File Offset: 0x001F2C0A
        public bool _solder { get; set; }

        // Token: 0x17001126 RID: 4390
        // (get) Token: 0x0600406B RID: 16491 RVA: 0x001F4A13 File Offset: 0x001F2C13
        // (set) Token: 0x0600406C RID: 16492 RVA: 0x001F4A1B File Offset: 0x001F2C1B
        public DateTime _dateOuverture { get; set; }

        // Token: 0x17001127 RID: 4391
        // (get) Token: 0x0600406D RID: 16493 RVA: 0x001F4A24 File Offset: 0x001F2C24
        // (set) Token: 0x0600406E RID: 16494 RVA: 0x001F4A2C File Offset: 0x001F2C2C
        public DateTime _dateFermeture { get; set; }

        // Token: 0x17001128 RID: 4392
        // (get) Token: 0x0600406F RID: 16495 RVA: 0x001F4A35 File Offset: 0x001F2C35
        // (set) Token: 0x06004070 RID: 16496 RVA: 0x001F4A3D File Offset: 0x001F2C3D
        public Service _service { get; set; }

        // Token: 0x17001129 RID: 4393
        // (get) Token: 0x06004071 RID: 16497 RVA: 0x001F4A46 File Offset: 0x001F2C46
        // (set) Token: 0x06004072 RID: 16498 RVA: 0x001F4A4E File Offset: 0x001F2C4E
        public List<LigneFacture> _listLigneFacture { get; set; }

        // Token: 0x1700112A RID: 4394
        // (get) Token: 0x06004073 RID: 16499 RVA: 0x001F4A57 File Offset: 0x001F2C57
        // (set) Token: 0x06004074 RID: 16500 RVA: 0x001F4A5F File Offset: 0x001F2C5F
        public List<LignePaiement> _listLignePaiement { get; set; }

        // Token: 0x1700112B RID: 4395
        // (get) Token: 0x06004075 RID: 16501 RVA: 0x001F4A68 File Offset: 0x001F2C68
        // (set) Token: 0x06004076 RID: 16502 RVA: 0x001F4A70 File Offset: 0x001F2C70
        public DateTime _dateSystem { get; set; }

        // Token: 0x1700112C RID: 4396
        // (get) Token: 0x06004077 RID: 16503 RVA: 0x001F4A79 File Offset: 0x001F2C79
        // (set) Token: 0x06004078 RID: 16504 RVA: 0x001F4A81 File Offset: 0x001F2C81
        public string _serveur { get; set; }

        // Token: 0x1700112D RID: 4397
        // (get) Token: 0x06004079 RID: 16505 RVA: 0x001F4A8A File Offset: 0x001F2C8A
        // (set) Token: 0x0600407A RID: 16506 RVA: 0x001F4A92 File Offset: 0x001F2C92
        public char _etatFacture { get; set; }

        // Token: 0x1700112E RID: 4398
        // (get) Token: 0x0600407B RID: 16507 RVA: 0x001F4A9B File Offset: 0x001F2C9B
        // (set) Token: 0x0600407C RID: 16508 RVA: 0x001F4AA3 File Offset: 0x001F2CA3
        public int _numeroFacture { get; set; }

        // Token: 0x1700112F RID: 4399
        // (get) Token: 0x0600407D RID: 16509 RVA: 0x001F4AAC File Offset: 0x001F2CAC
        // (set) Token: 0x0600407E RID: 16510 RVA: 0x001F4AB4 File Offset: 0x001F2CB4
        public Zone _zone { get; set; }

        // Token: 0x17001130 RID: 4400
        // (get) Token: 0x0600407F RID: 16511 RVA: 0x001F4ABD File Offset: 0x001F2CBD
        // (set) Token: 0x06004080 RID: 16512 RVA: 0x001F4AC5 File Offset: 0x001F2CC5
        public int _idClient { get; set; }

        // Token: 0x17001131 RID: 4401
        // (get) Token: 0x06004081 RID: 16513 RVA: 0x001F4ACE File Offset: 0x001F2CCE
        // (set) Token: 0x06004082 RID: 16514 RVA: 0x001F4AD6 File Offset: 0x001F2CD6
        public bool _cloture { get; set; }

        // Token: 0x17001132 RID: 4402
        // (get) Token: 0x06004083 RID: 16515 RVA: 0x001F4ADF File Offset: 0x001F2CDF
        // (set) Token: 0x06004084 RID: 16516 RVA: 0x001F4AE7 File Offset: 0x001F2CE7
        public bool _transfert { get; set; }

        // Token: 0x17001133 RID: 4403
        // (get) Token: 0x06004085 RID: 16517 RVA: 0x001F4AF0 File Offset: 0x001F2CF0
        // (set) Token: 0x06004086 RID: 16518 RVA: 0x001F4AF8 File Offset: 0x001F2CF8
        public TimeSpan _temps { get; set; }

        // Token: 0x17001134 RID: 4404
        // (get) Token: 0x06004087 RID: 16519 RVA: 0x001F4B01 File Offset: 0x001F2D01
        // (set) Token: 0x06004088 RID: 16520 RVA: 0x001F4B09 File Offset: 0x001F2D09
        public decimal _valMinSpend { get; set; }

        // Token: 0x06004089 RID: 16521 RVA: 0x001F4B14 File Offset: 0x001F2D14
        public Facture()
        {
            this._id = 0;
            this._table = "0";
            this._couvert = 0;
            this._utilisateur = new Utilisateur();
            this._totalFacture = 0m;
            this._totalTva = 0m;
            this._solder = false;
            this._dateFermeture = default(DateTime);
            this._dateOuverture = default(DateTime);
            this._service = new Service();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this._dateSystem = default(DateTime);
            this._serveur = "";
            this._etatFacture = 'E';
            this._numeroFacture = 0;
            this._zone = new Zone();
            this._idClient = 0;
            this._cloture = false;
            this._transfert = false;
            this._temps = DateTime.Now - this._dateOuverture;
            this._valMinSpend = 0m;
        }

        // Token: 0x0600408A RID: 16522 RVA: 0x001F4C14 File Offset: 0x001F2E14
        public Facture(int id, string table, int couvert, Utilisateur utilisateur, decimal totalFacture, decimal totalTva, bool solder, DateTime dateOuvertre, DateTime dateFermeture, Service service, List<LigneFacture> listLigneFacture, List<LignePaiement> listLignePaiement, DateTime dateSystem, string serveur, char etatFacture, int numeroFacture, Zone zone, int idClient, bool cloture, bool transfert, decimal valMinSpend)
        {
            this._id = id;
            this._table = table;
            this._couvert = couvert;
            this._utilisateur = utilisateur;
            this._totalFacture = totalFacture;
            this._totalTva = totalTva;
            this._solder = solder;
            this._dateFermeture = dateFermeture;
            this._dateOuverture = dateOuvertre;
            this._service = service;
            this._listLigneFacture = listLigneFacture;
            this._listLignePaiement = listLignePaiement;
            this._dateSystem = dateSystem;
            this._serveur = serveur;
            this._etatFacture = etatFacture;
            this._numeroFacture = numeroFacture;
            this._zone = zone;
            this._idClient = idClient;
            this._cloture = cloture;
            this._transfert = transfert;
            if (this._solder)
            {
                this._temps = this._dateFermeture - this._dateOuverture;
            }
            else
            {
                this._temps = DateTime.Now - this._dateOuverture;
            }
            this._valMinSpend = valMinSpend;
        }
    }

    // Token: 0x0200018D RID: 397
    public class LignePaiement
    {
        // Token: 0x17000704 RID: 1796
        // (get) Token: 0x06001B86 RID: 7046 RVA: 0x000E8AB7 File Offset: 0x000E6CB7
        // (set) Token: 0x06001B87 RID: 7047 RVA: 0x000E8ABF File Offset: 0x000E6CBF
        public int _id { get; set; }

        // Token: 0x17000705 RID: 1797
        // (get) Token: 0x06001B88 RID: 7048 RVA: 0x000E8AC8 File Offset: 0x000E6CC8
        // (set) Token: 0x06001B89 RID: 7049 RVA: 0x000E8AD0 File Offset: 0x000E6CD0
        public int _idModePaiement { get; set; }

        // Token: 0x17000706 RID: 1798
        // (get) Token: 0x06001B8A RID: 7050 RVA: 0x000E8AD9 File Offset: 0x000E6CD9
        // (set) Token: 0x06001B8B RID: 7051 RVA: 0x000E8AE1 File Offset: 0x000E6CE1
        public string _libelleModePaiement { get; set; }

        // Token: 0x17000707 RID: 1799
        // (get) Token: 0x06001B8C RID: 7052 RVA: 0x000E8AEA File Offset: 0x000E6CEA
        // (set) Token: 0x06001B8D RID: 7053 RVA: 0x000E8AF2 File Offset: 0x000E6CF2
        public decimal _montant { get; set; }

        // Token: 0x17000708 RID: 1800
        // (get) Token: 0x06001B8E RID: 7054 RVA: 0x000E8AFB File Offset: 0x000E6CFB
        // (set) Token: 0x06001B8F RID: 7055 RVA: 0x000E8B03 File Offset: 0x000E6D03
        public Service _service { get; set; }

        // Token: 0x17000709 RID: 1801
        // (get) Token: 0x06001B90 RID: 7056 RVA: 0x000E8B0C File Offset: 0x000E6D0C
        // (set) Token: 0x06001B91 RID: 7057 RVA: 0x000E8B14 File Offset: 0x000E6D14
        public DateTime _date { get; set; }

        // Token: 0x1700070A RID: 1802
        // (get) Token: 0x06001B92 RID: 7058 RVA: 0x000E8B1D File Offset: 0x000E6D1D
        // (set) Token: 0x06001B93 RID: 7059 RVA: 0x000E8B25 File Offset: 0x000E6D25
        public int _nbrImpression { get; set; }

        // Token: 0x1700070B RID: 1803
        // (get) Token: 0x06001B94 RID: 7060 RVA: 0x000E8B2E File Offset: 0x000E6D2E
        // (set) Token: 0x06001B95 RID: 7061 RVA: 0x000E8B36 File Offset: 0x000E6D36
        public bool _saved { get; set; }

        // Token: 0x1700070C RID: 1804
        // (get) Token: 0x06001B96 RID: 7062 RVA: 0x000E8B3F File Offset: 0x000E6D3F
        // (set) Token: 0x06001B97 RID: 7063 RVA: 0x000E8B47 File Offset: 0x000E6D47
        public Utilisateur _utilisateur { get; set; }

        // Token: 0x1700070D RID: 1805
        // (get) Token: 0x06001B98 RID: 7064 RVA: 0x000E8B50 File Offset: 0x000E6D50
        // (set) Token: 0x06001B99 RID: 7065 RVA: 0x000E8B58 File Offset: 0x000E6D58
        public DateTime _dateSystem { get; set; }

        // Token: 0x1700070E RID: 1806
        // (get) Token: 0x06001B9A RID: 7066 RVA: 0x000E8B61 File Offset: 0x000E6D61
        // (set) Token: 0x06001B9B RID: 7067 RVA: 0x000E8B69 File Offset: 0x000E6D69
        public string _serveur { get; set; }

        // Token: 0x1700070F RID: 1807
        // (get) Token: 0x06001B9C RID: 7068 RVA: 0x000E8B72 File Offset: 0x000E6D72
        // (set) Token: 0x06001B9D RID: 7069 RVA: 0x000E8B7A File Offset: 0x000E6D7A
        public string _gratuite { get; set; }

        // Token: 0x17000710 RID: 1808
        // (get) Token: 0x06001B9E RID: 7070 RVA: 0x000E8B83 File Offset: 0x000E6D83
        // (set) Token: 0x06001B9F RID: 7071 RVA: 0x000E8B8B File Offset: 0x000E6D8B
        public Cardex _cardex { get; set; }

        // Token: 0x17000711 RID: 1809
        // (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000E8B94 File Offset: 0x000E6D94
        // (set) Token: 0x06001BA1 RID: 7073 RVA: 0x000E8B9C File Offset: 0x000E6D9C
        public string _reference { get; set; }

        // Token: 0x06001BA2 RID: 7074 RVA: 0x000E8BA8 File Offset: 0x000E6DA8
        public LignePaiement()
        {
            this._id = 0;
            this._idModePaiement = 0;
            this._libelleModePaiement = "";
            this._montant = 0m;
            this._service = new Service();
            this._date = default(DateTime);
            this._nbrImpression = 0;
            this._saved = false;
            this._utilisateur = new Utilisateur();
            this._dateSystem = default(DateTime);
            this._serveur = "";
            this._gratuite = "";
            this._cardex = new Cardex();
            this._reference = "";
        }

        // Token: 0x06001BA3 RID: 7075 RVA: 0x000E8C50 File Offset: 0x000E6E50
        public LignePaiement(int id, int idModePaiement, string libelleModePaiement, decimal montant, Service service, DateTime date, int nbrImpression, bool saved, Utilisateur utilisateur, DateTime dateSystem, string serveur, string gratuite, Cardex cardex, string reference)
        {
            this._id = id;
            this._idModePaiement = idModePaiement;
            this._libelleModePaiement = libelleModePaiement;
            this._montant = montant;
            this._service = service;
            this._date = date;
            this._nbrImpression = nbrImpression;
            this._saved = saved;
            this._utilisateur = utilisateur;
            this._dateSystem = dateSystem;
            this._serveur = serveur;
            this._gratuite = gratuite;
            this._cardex = cardex;
            this._reference = reference;
        }

        // Token: 0x06001BA4 RID: 7076 RVA: 0x000E8CD0 File Offset: 0x000E6ED0
        public LignePaiement(LignePaiement _lignepaiement)
        {
            this._id = _lignepaiement._id;
            this._idModePaiement = _lignepaiement._idModePaiement;
            this._libelleModePaiement = _lignepaiement._libelleModePaiement;
            this._montant = _lignepaiement._montant;
            this._service = _lignepaiement._service;
            this._date = _lignepaiement._date;
            this._nbrImpression = _lignepaiement._nbrImpression;
            this._saved = _lignepaiement._saved;
            this._utilisateur = _lignepaiement._utilisateur;
            this._dateSystem = _lignepaiement._dateSystem;
            this._serveur = _lignepaiement._serveur;
            this._gratuite = _lignepaiement._gratuite;
            this._cardex = _lignepaiement._cardex;
            this._reference = _lignepaiement._reference;
        }
    }


    // Token: 0x02000461 RID: 1121
    public class LigneFacture
    {
        // Token: 0x17001483 RID: 5251
        // (get) Token: 0x06004B32 RID: 19250 RVA: 0x0022E7E5 File Offset: 0x0022C9E5
        // (set) Token: 0x06004B33 RID: 19251 RVA: 0x0022E7ED File Offset: 0x0022C9ED
        public int _id { get; set; }

        // Token: 0x17001484 RID: 5252
        // (get) Token: 0x06004B34 RID: 19252 RVA: 0x0022E7F6 File Offset: 0x0022C9F6
        // (set) Token: 0x06004B35 RID: 19253 RVA: 0x0022E7FE File Offset: 0x0022C9FE
        public int _idArticle { get; set; }

        // Token: 0x17001485 RID: 5253
        // (get) Token: 0x06004B36 RID: 19254 RVA: 0x0022E807 File Offset: 0x0022CA07
        // (set) Token: 0x06004B37 RID: 19255 RVA: 0x0022E80F File Offset: 0x0022CA0F
        public string _libelleArticle { get; set; }

        // Token: 0x17001486 RID: 5254
        // (get) Token: 0x06004B38 RID: 19256 RVA: 0x0022E818 File Offset: 0x0022CA18
        // (set) Token: 0x06004B39 RID: 19257 RVA: 0x0022E820 File Offset: 0x0022CA20
        public int _qte { get; set; }

        // Token: 0x17001487 RID: 5255
        // (get) Token: 0x06004B3A RID: 19258 RVA: 0x0022E829 File Offset: 0x0022CA29
        // (set) Token: 0x06004B3B RID: 19259 RVA: 0x0022E831 File Offset: 0x0022CA31
        public decimal _PU { get; set; }

        // Token: 0x17001488 RID: 5256
        // (get) Token: 0x06004B3C RID: 19260 RVA: 0x0022E83A File Offset: 0x0022CA3A
        // (set) Token: 0x06004B3D RID: 19261 RVA: 0x0022E842 File Offset: 0x0022CA42
        public decimal _prixTotal { get; set; }

        // Token: 0x17001489 RID: 5257
        // (get) Token: 0x06004B3E RID: 19262 RVA: 0x0022E84B File Offset: 0x0022CA4B
        // (set) Token: 0x06004B3F RID: 19263 RVA: 0x0022E853 File Offset: 0x0022CA53
        public decimal _totalTva { get; set; }

        // Token: 0x1700148A RID: 5258
        // (get) Token: 0x06004B40 RID: 19264 RVA: 0x0022E85C File Offset: 0x0022CA5C
        // (set) Token: 0x06004B41 RID: 19265 RVA: 0x0022E864 File Offset: 0x0022CA64
        public Service _service { get; set; }

        // Token: 0x1700148B RID: 5259
        // (get) Token: 0x06004B42 RID: 19266 RVA: 0x0022E86D File Offset: 0x0022CA6D
        // (set) Token: 0x06004B43 RID: 19267 RVA: 0x0022E875 File Offset: 0x0022CA75
        public DateTime _date { get; set; }

        // Token: 0x1700148C RID: 5260
        // (get) Token: 0x06004B44 RID: 19268 RVA: 0x0022E87E File Offset: 0x0022CA7E
        // (set) Token: 0x06004B45 RID: 19269 RVA: 0x0022E886 File Offset: 0x0022CA86
        public int _nbrImpression { get; set; }

        // Token: 0x1700148D RID: 5261
        // (get) Token: 0x06004B46 RID: 19270 RVA: 0x0022E88F File Offset: 0x0022CA8F
        // (set) Token: 0x06004B47 RID: 19271 RVA: 0x0022E897 File Offset: 0x0022CA97
        public bool _saved { get; set; }

        // Token: 0x1700148E RID: 5262
        // (get) Token: 0x06004B48 RID: 19272 RVA: 0x0022E8A0 File Offset: 0x0022CAA0
        // (set) Token: 0x06004B49 RID: 19273 RVA: 0x0022E8A8 File Offset: 0x0022CAA8
        public Utilisateur _utilisateur { get; set; }

        // Token: 0x1700148F RID: 5263
        // (get) Token: 0x06004B4A RID: 19274 RVA: 0x0022E8B1 File Offset: 0x0022CAB1
        // (set) Token: 0x06004B4B RID: 19275 RVA: 0x0022E8B9 File Offset: 0x0022CAB9
        public int _idImprimante { get; set; }

        // Token: 0x17001490 RID: 5264
        // (get) Token: 0x06004B4C RID: 19276 RVA: 0x0022E8C2 File Offset: 0x0022CAC2
        // (set) Token: 0x06004B4D RID: 19277 RVA: 0x0022E8CA File Offset: 0x0022CACA
        public DateTime _dateSystem { get; set; }

        // Token: 0x17001491 RID: 5265
        // (get) Token: 0x06004B4E RID: 19278 RVA: 0x0022E8D3 File Offset: 0x0022CAD3
        // (set) Token: 0x06004B4F RID: 19279 RVA: 0x0022E8DB File Offset: 0x0022CADB
        public int _idList { get; set; }

        // Token: 0x17001492 RID: 5266
        // (get) Token: 0x06004B50 RID: 19280 RVA: 0x0022E8E4 File Offset: 0x0022CAE4
        // (set) Token: 0x06004B51 RID: 19281 RVA: 0x0022E8EC File Offset: 0x0022CAEC
        public int _idFamille { get; set; }

        // Token: 0x17001493 RID: 5267
        // (get) Token: 0x06004B52 RID: 19282 RVA: 0x0022E8F5 File Offset: 0x0022CAF5
        // (set) Token: 0x06004B53 RID: 19283 RVA: 0x0022E8FD File Offset: 0x0022CAFD
        public string _libelleFamille { get; set; }

        // Token: 0x17001494 RID: 5268
        // (get) Token: 0x06004B54 RID: 19284 RVA: 0x0022E906 File Offset: 0x0022CB06
        // (set) Token: 0x06004B55 RID: 19285 RVA: 0x0022E90E File Offset: 0x0022CB0E
        public decimal _prixAchat { get; set; }

        // Token: 0x17001495 RID: 5269
        // (get) Token: 0x06004B56 RID: 19286 RVA: 0x0022E917 File Offset: 0x0022CB17
        // (set) Token: 0x06004B57 RID: 19287 RVA: 0x0022E91F File Offset: 0x0022CB1F
        public decimal _tauxTVA { get; set; }

        // Token: 0x17001496 RID: 5270
        // (get) Token: 0x06004B58 RID: 19288 RVA: 0x0022E928 File Offset: 0x0022CB28
        // (set) Token: 0x06004B59 RID: 19289 RVA: 0x0022E930 File Offset: 0x0022CB30
        public bool _imprimer { get; set; }

        // Token: 0x17001497 RID: 5271
        // (get) Token: 0x06004B5A RID: 19290 RVA: 0x0022E939 File Offset: 0x0022CB39
        // (set) Token: 0x06004B5B RID: 19291 RVA: 0x0022E941 File Offset: 0x0022CB41
        public int _remise { get; set; }

        // Token: 0x17001498 RID: 5272
        // (get) Token: 0x06004B5C RID: 19292 RVA: 0x0022E94A File Offset: 0x0022CB4A
        // (set) Token: 0x06004B5D RID: 19293 RVA: 0x0022E952 File Offset: 0x0022CB52
        public int _idImprimante2 { get; set; }

        // Token: 0x17001499 RID: 5273
        // (get) Token: 0x06004B5E RID: 19294 RVA: 0x0022E95B File Offset: 0x0022CB5B
        // (set) Token: 0x06004B5F RID: 19295 RVA: 0x0022E963 File Offset: 0x0022CB63
        public string _serveur { get; set; }

        // Token: 0x1700149A RID: 5274
        // (get) Token: 0x06004B60 RID: 19296 RVA: 0x0022E96C File Offset: 0x0022CB6C
        // (set) Token: 0x06004B61 RID: 19297 RVA: 0x0022E974 File Offset: 0x0022CB74
        public int _gramme { get; set; }

        // Token: 0x1700149B RID: 5275
        // (get) Token: 0x06004B62 RID: 19298 RVA: 0x0022E97D File Offset: 0x0022CB7D
        // (set) Token: 0x06004B63 RID: 19299 RVA: 0x0022E985 File Offset: 0x0022CB85
        public string _type { get; set; }

        // Token: 0x1700149C RID: 5276
        // (get) Token: 0x06004B64 RID: 19300 RVA: 0x0022E98E File Offset: 0x0022CB8E
        // (set) Token: 0x06004B65 RID: 19301 RVA: 0x0022E996 File Offset: 0x0022CB96
        public string _gratuite { get; set; }

        // Token: 0x1700149D RID: 5277
        // (get) Token: 0x06004B66 RID: 19302 RVA: 0x0022E99F File Offset: 0x0022CB9F
        // (set) Token: 0x06004B67 RID: 19303 RVA: 0x0022E9A7 File Offset: 0x0022CBA7
        public string _remarque { get; set; }

        // Token: 0x1700149E RID: 5278
        // (get) Token: 0x06004B68 RID: 19304 RVA: 0x0022E9B0 File Offset: 0x0022CBB0
        // (set) Token: 0x06004B69 RID: 19305 RVA: 0x0022E9B8 File Offset: 0x0022CBB8
        public int _sid { get; set; }

        // Token: 0x1700149F RID: 5279
        // (get) Token: 0x06004B6A RID: 19306 RVA: 0x0022E9C1 File Offset: 0x0022CBC1
        // (set) Token: 0x06004B6B RID: 19307 RVA: 0x0022E9C9 File Offset: 0x0022CBC9
        public string _poste { get; set; }

        // Token: 0x170014A0 RID: 5280
        // (get) Token: 0x06004B6C RID: 19308 RVA: 0x0022E9D2 File Offset: 0x0022CBD2
        // (set) Token: 0x06004B6D RID: 19309 RVA: 0x0022E9DA File Offset: 0x0022CBDA
        public int _idImprimante3 { get; set; }

        // Token: 0x170014A1 RID: 5281
        // (get) Token: 0x06004B6E RID: 19310 RVA: 0x0022E9E3 File Offset: 0x0022CBE3
        // (set) Token: 0x06004B6F RID: 19311 RVA: 0x0022E9EB File Offset: 0x0022CBEB
        public int _idImprimante4 { get; set; }

        // Token: 0x170014A2 RID: 5282
        // (get) Token: 0x06004B70 RID: 19312 RVA: 0x0022E9F4 File Offset: 0x0022CBF4
        // (set) Token: 0x06004B71 RID: 19313 RVA: 0x0022E9FC File Offset: 0x0022CBFC
        public int _idPrestation { get; set; }

        // Token: 0x06004B72 RID: 19314 RVA: 0x0022EA08 File Offset: 0x0022CC08
        public LigneFacture()
        {
            this._id = 0;
            this._idArticle = 0;
            this._libelleArticle = "";
            this._qte = 0;
            this._PU = 0m;
            this._prixTotal = 0m;
            this._totalTva = 0m;
            this._service = new Service();
            this._date = default(DateTime);
            this._nbrImpression = 0;
            this._saved = false;
            this._utilisateur = new Utilisateur();
            this._idImprimante = 0;
            this._dateSystem = default(DateTime);
            this._idFamille = 0;
            this._libelleFamille = "";
            this._prixAchat = 0m;
            this._tauxTVA = 0m;
            this._imprimer = true;
            this._remise = 0;
            this._idImprimante2 = 0;
            this._serveur = "";
            this._gramme = 0;
            this._type = "";
            this._gratuite = "";
            this._remarque = "";
            this._sid = 0;
            this._poste = "";
            this._idImprimante3 = 0;
            this._idImprimante4 = 0;
            this._idPrestation = 0;
        }

        // Token: 0x06004B73 RID: 19315 RVA: 0x0022EB44 File Offset: 0x0022CD44
        public LigneFacture(int id, int idArticle, string libelleArticle, int qte, decimal pu, decimal prixTotal, decimal totalTva)
        {
            this._id = id;
            this._idArticle = idArticle;
            this._libelleArticle = libelleArticle;
            this._qte = qte;
            this._PU = pu;
            this._prixTotal = prixTotal;
            this._totalTva = totalTva;
            this._service = new Service();
            this._date = default(DateTime);
            this._nbrImpression = 0;
            this._saved = false;
            this._utilisateur = new Utilisateur();
            this._idImprimante = 0;
            this._dateSystem = default(DateTime);
            this._idFamille = 0;
            this._libelleFamille = "";
            this._prixAchat = 0m;
            this._tauxTVA = 0m;
            this._imprimer = true;
            this._remise = 0;
            this._idImprimante2 = 0;
            this._serveur = "";
            this._gramme = 0;
            this._type = "";
            this._gratuite = "";
            this._remarque = "";
            this._sid = 0;
            this._poste = "";
            this._idImprimante3 = 0;
            this._idImprimante4 = 0;
            this._idPrestation = 0;
        }

        // Token: 0x06004B74 RID: 19316 RVA: 0x0022EC70 File Offset: 0x0022CE70
        public LigneFacture(int id, int idArticle, string libelleArticle, int qte, decimal pu, decimal prixTotal, decimal totalTva, DateTime date, Utilisateur utilisateur, DateTime datesystem, int remise, string gratuite, string remarque)
        {
            this._id = id;
            this._idArticle = idArticle;
            this._libelleArticle = libelleArticle;
            this._qte = qte;
            this._PU = pu;
            this._prixTotal = prixTotal;
            this._totalTva = totalTva;
            this._service = new Service();
            this._date = date;
            this._nbrImpression = 0;
            this._saved = false;
            this._utilisateur = utilisateur;
            this._idImprimante = 0;
            this._dateSystem = datesystem;
            this._idFamille = 0;
            this._libelleFamille = "";
            this._prixAchat = 0m;
            this._tauxTVA = 0m;
            this._imprimer = true;
            this._remise = remise;
            this._idImprimante2 = 0;
            this._serveur = "";
            this._gramme = 0;
            this._type = "";
            this._gratuite = gratuite;
            this._remarque = remarque;
            this._sid = 0;
            this._poste = "";
            this._idImprimante3 = 0;
            this._idImprimante4 = 0;
            this._idPrestation = 0;
        }

        // Token: 0x06004B75 RID: 19317 RVA: 0x0022ED84 File Offset: 0x0022CF84
        public LigneFacture(int id, int idArticle, string libelleArticle, int qte, decimal pu, decimal prixTotal, decimal totalTva, Service service, DateTime date, int nbrImpression, Utilisateur utilisateur, bool saved, int idImprimante, DateTime dateSystem, decimal prixAchat, decimal tauxTVA, bool imprimer, int remise, int idimprimante2, string serveur, int gramme, string type, string gratuite, string remarque, int sid, string poste, int idImprimante3, int idImprimante4, int idPrestation)
        {
            this._id = id;
            this._idArticle = idArticle;
            this._libelleArticle = libelleArticle;
            this._qte = qte;
            this._PU = pu;
            this._prixTotal = prixTotal;
            this._totalTva = totalTva;
            this._service = service;
            this._date = date;
            this._nbrImpression = nbrImpression;
            this._saved = saved;
            this._utilisateur = utilisateur;
            this._idImprimante = idImprimante;
            this._dateSystem = dateSystem;
            this._idFamille = 0;
            this._libelleFamille = "";
            this._prixAchat = prixAchat;
            this._tauxTVA = tauxTVA;
            this._imprimer = imprimer;
            this._remise = remise;
            this._idImprimante2 = idimprimante2;
            this._serveur = serveur;
            this._gramme = gramme;
            this._type = type;
            this._gratuite = gratuite;
            this._remarque = remarque;
            this._sid = sid;
            this._poste = poste;
            this._idImprimante3 = idImprimante3;
            this._idImprimante4 = idImprimante4;
            this._idPrestation = idPrestation;
        }

        // Token: 0x06004B76 RID: 19318 RVA: 0x0022EE90 File Offset: 0x0022D090
        public LigneFacture(int id, int idArticle, string libelleArticle, int qte, decimal pu, decimal prixTotal, decimal totalTva, Service service, DateTime date, int nbrImpression, Utilisateur utilisateur, bool saved, int idImprimante, DateTime dateSystem, int idFamille, string libelleFamille, decimal prixAchat, decimal tauxTVA, bool imprimer, int remise, int idImprimante2, string serveur, int gramme, string type, string gratuite, string remarque, int sid, string poste, int idImprimante3, int idImprimante4, int idPrestation)
        {
            this._id = id;
            this._idArticle = idArticle;
            this._libelleArticle = libelleArticle;
            this._qte = qte;
            this._PU = pu;
            this._prixTotal = prixTotal;
            this._totalTva = totalTva;
            this._service = service;
            this._date = date;
            this._nbrImpression = nbrImpression;
            this._saved = saved;
            this._utilisateur = utilisateur;
            this._idImprimante = idImprimante;
            this._dateSystem = dateSystem;
            this._idFamille = idFamille;
            this._libelleFamille = libelleFamille;
            this._prixAchat = prixAchat;
            this._tauxTVA = tauxTVA;
            this._imprimer = imprimer;
            this._remise = remise;
            this._idImprimante2 = idImprimante2;
            this._serveur = serveur;
            this._gramme = gramme;
            this._type = type;
            this._gratuite = gratuite;
            this._remarque = remarque;
            this._sid = sid;
            this._poste = poste;
            this._idImprimante3 = idImprimante3;
            this._idImprimante4 = idImprimante4;
            this._idPrestation = idPrestation;
        }

        // Token: 0x06004B77 RID: 19319 RVA: 0x0022EF98 File Offset: 0x0022D198
        public LigneFacture(LigneFacture _ligneFacture)
        {
            this._id = _ligneFacture._id;
            this._idArticle = _ligneFacture._idArticle;
            this._libelleArticle = _ligneFacture._libelleArticle;
            this._qte = 0;
            this._PU = _ligneFacture._PU;
            this._prixTotal = 0m;
            this._totalTva = 0m;
            this._service = _ligneFacture._service;
            this._date = _ligneFacture._date;
            this._nbrImpression = _ligneFacture._nbrImpression;
            this._saved = _ligneFacture._saved;
            this._utilisateur = _ligneFacture._utilisateur;
            this._idImprimante = _ligneFacture._idImprimante;
            this._dateSystem = _ligneFacture._dateSystem;
            this._idFamille = _ligneFacture._idFamille;
            this._idList = _ligneFacture._idList;
            this._libelleFamille = _ligneFacture._libelleFamille;
            this._prixAchat = _ligneFacture._prixAchat;
            this._tauxTVA = _ligneFacture._tauxTVA;
            this._imprimer = _ligneFacture._imprimer;
            this._remise = _ligneFacture._remise;
            this._idImprimante2 = _ligneFacture._idImprimante2;
            this._serveur = _ligneFacture._serveur;
            this._gramme = _ligneFacture._gramme;
            this._type = _ligneFacture._type;
            this._gratuite = _ligneFacture._gratuite;
            this._remarque = _ligneFacture._remarque;
            this._sid = _ligneFacture._sid;
            this._poste = _ligneFacture._poste;
            this._idImprimante3 = _ligneFacture._idImprimante3;
            this._idImprimante4 = _ligneFacture._idImprimante4;
            this._idPrestation = _ligneFacture._idPrestation;
        }

        // Token: 0x06004B78 RID: 19320 RVA: 0x0022F128 File Offset: 0x0022D328
        public LigneFacture(LigneFacture _ligneFacture, bool annuler)
        {
            this._id = _ligneFacture._id;
            this._idArticle = _ligneFacture._idArticle;
            this._libelleArticle = _ligneFacture._libelleArticle;
            this._qte = _ligneFacture._qte;
            this._PU = _ligneFacture._PU;
            this._prixTotal = _ligneFacture._prixTotal;
            this._totalTva = _ligneFacture._totalTva;
            this._service = _ligneFacture._service;
            this._date = _ligneFacture._date;
            this._nbrImpression = _ligneFacture._nbrImpression;
            this._saved = _ligneFacture._saved;
            this._utilisateur = _ligneFacture._utilisateur;
            this._idImprimante = _ligneFacture._idImprimante;
            this._dateSystem = _ligneFacture._dateSystem;
            this._idFamille = _ligneFacture._idFamille;
            this._idList = _ligneFacture._idList;
            this._libelleFamille = _ligneFacture._libelleFamille;
            this._prixAchat = _ligneFacture._prixAchat;
            this._tauxTVA = _ligneFacture._tauxTVA;
            this._imprimer = _ligneFacture._imprimer;
            this._remise = _ligneFacture._remise;
            this._idImprimante2 = _ligneFacture._idImprimante2;
            this._serveur = _ligneFacture._serveur;
            this._gramme = _ligneFacture._gramme;
            this._type = _ligneFacture._type;
            this._gratuite = _ligneFacture._gratuite;
            this._remarque = _ligneFacture._remarque;
            this._sid = _ligneFacture._sid;
            this._poste = _ligneFacture._poste;
            this._idImprimante3 = _ligneFacture._idImprimante3;
            this._idImprimante4 = _ligneFacture._idImprimante4;
            this._idPrestation = _ligneFacture._idPrestation;
        }

        // Token: 0x06004B79 RID: 19321 RVA: 0x0022F2BB File Offset: 0x0022D4BB
        public LigneFacture(LigneCommandeClient _ligneCommandeClient)
        {
        }




        public class LigneCommandeClient
        {
            // Token: 0x17000712 RID: 1810
            // (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000E8D8B File Offset: 0x000E6F8B
            // (set) Token: 0x06001BA6 RID: 7078 RVA: 0x000E8D93 File Offset: 0x000E6F93
            public int _id { get; set; }

            // Token: 0x17000713 RID: 1811
            // (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000E8D9C File Offset: 0x000E6F9C
            // (set) Token: 0x06001BA8 RID: 7080 RVA: 0x000E8DA4 File Offset: 0x000E6FA4
            public int _idArticle { get; set; }

            // Token: 0x17000714 RID: 1812
            // (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000E8DAD File Offset: 0x000E6FAD
            // (set) Token: 0x06001BAA RID: 7082 RVA: 0x000E8DB5 File Offset: 0x000E6FB5
            public string _libelleArticle { get; set; }

            // Token: 0x17000715 RID: 1813
            // (get) Token: 0x06001BAB RID: 7083 RVA: 0x000E8DBE File Offset: 0x000E6FBE
            // (set) Token: 0x06001BAC RID: 7084 RVA: 0x000E8DC6 File Offset: 0x000E6FC6
            public int _qte { get; set; }

            // Token: 0x17000716 RID: 1814
            // (get) Token: 0x06001BAD RID: 7085 RVA: 0x000E8DCF File Offset: 0x000E6FCF
            // (set) Token: 0x06001BAE RID: 7086 RVA: 0x000E8DD7 File Offset: 0x000E6FD7
            public decimal _PU { get; set; }

            // Token: 0x17000717 RID: 1815
            // (get) Token: 0x06001BAF RID: 7087 RVA: 0x000E8DE0 File Offset: 0x000E6FE0
            // (set) Token: 0x06001BB0 RID: 7088 RVA: 0x000E8DE8 File Offset: 0x000E6FE8
            public decimal _prixTotal { get; set; }

            // Token: 0x17000718 RID: 1816
            // (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000E8DF1 File Offset: 0x000E6FF1
            // (set) Token: 0x06001BB2 RID: 7090 RVA: 0x000E8DF9 File Offset: 0x000E6FF9
            public decimal _totalTva { get; set; }

            // Token: 0x17000719 RID: 1817
            // (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000E8E02 File Offset: 0x000E7002
            // (set) Token: 0x06001BB4 RID: 7092 RVA: 0x000E8E0A File Offset: 0x000E700A
            public Service _service { get; set; }

            // Token: 0x1700071A RID: 1818
            // (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000E8E13 File Offset: 0x000E7013
            // (set) Token: 0x06001BB6 RID: 7094 RVA: 0x000E8E1B File Offset: 0x000E701B
            public DateTime _date { get; set; }

            // Token: 0x1700071B RID: 1819
            // (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000E8E24 File Offset: 0x000E7024
            // (set) Token: 0x06001BB8 RID: 7096 RVA: 0x000E8E2C File Offset: 0x000E702C
            public bool _saved { get; set; }

            // Token: 0x1700071C RID: 1820
            // (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000E8E35 File Offset: 0x000E7035
            // (set) Token: 0x06001BBA RID: 7098 RVA: 0x000E8E3D File Offset: 0x000E703D
            public DateTime _dateSystem { get; set; }

            // Token: 0x1700071D RID: 1821
            // (get) Token: 0x06001BBB RID: 7099 RVA: 0x000E8E46 File Offset: 0x000E7046
            // (set) Token: 0x06001BBC RID: 7100 RVA: 0x000E8E4E File Offset: 0x000E704E
            public int _idList { get; set; }

            // Token: 0x1700071E RID: 1822
            // (get) Token: 0x06001BBD RID: 7101 RVA: 0x000E8E57 File Offset: 0x000E7057
            // (set) Token: 0x06001BBE RID: 7102 RVA: 0x000E8E5F File Offset: 0x000E705F
            public Utilisateur _utilisateur { get; set; }

            // Token: 0x1700071F RID: 1823
            // (get) Token: 0x06001BBF RID: 7103 RVA: 0x000E8E68 File Offset: 0x000E7068
            // (set) Token: 0x06001BC0 RID: 7104 RVA: 0x000E8E70 File Offset: 0x000E7070
            public string _type { get; set; }

            // Token: 0x17000720 RID: 1824
            // (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000E8E79 File Offset: 0x000E7079
            // (set) Token: 0x06001BC2 RID: 7106 RVA: 0x000E8E81 File Offset: 0x000E7081
            public int _composant { get; set; }

            // Token: 0x06001BC3 RID: 7107 RVA: 0x000E8E8C File Offset: 0x000E708C
            public LigneCommandeClient()
            {
                this._id = 0;
                this._idArticle = 0;
                this._libelleArticle = "";
                this._qte = 0;
                this._PU = 0m;
                this._prixTotal = 0m;
                this._totalTva = 0m;
                this._service = new Service();
                this._date = default(DateTime);
                this._saved = false;
                this._dateSystem = default(DateTime);
                this._idList = 0;
                this._utilisateur = new Utilisateur();
                this._type = "";
                this._composant = 0;
            }

            // Token: 0x06001BC4 RID: 7108 RVA: 0x000E8F38 File Offset: 0x000E7138
            public LigneCommandeClient(int id, int idArticle, string libelleArticle, int qte, Service service, Utilisateur utilisateur, string type, int composant)
            {
                this._id = id;
                this._idArticle = idArticle;
                this._libelleArticle = libelleArticle;
                this._qte = qte;
                this._PU = 0m;
                this._prixTotal = 0m;
                this._totalTva = 0m;
                this._service = service;
                this._date = default(DateTime);
                this._saved = false;
                this._dateSystem = default(DateTime);
                this._idList = 0;
                this._utilisateur = utilisateur;
                this._type = type;
                this._composant = composant;
            }

            // Token: 0x06001BC5 RID: 7109 RVA: 0x000E8FD8 File Offset: 0x000E71D8
            public LigneCommandeClient(int id, int idarticle, string libellearticle, int qte, decimal PU, decimal prixTotal, decimal totalTva, Service service, DateTime date, bool saved, DateTime dateSystem, Utilisateur utilisateur, string type, int composant)
            {
                this._id = id;
                this._idArticle = idarticle;
                this._libelleArticle = libellearticle;
                this._qte = qte;
                this._PU = PU;
                this._prixTotal = prixTotal;
                this._totalTva = totalTva;
                this._service = service;
                this._date = date;
                this._saved = saved;
                this._dateSystem = dateSystem;
                this._utilisateur = utilisateur;
                this._type = type;
                this._composant = composant;
            }
        }



        // Token: 0x0200018D RID: 397
        public class LignePaiement
        {
            // Token: 0x17000704 RID: 1796
            // (get) Token: 0x06001B86 RID: 7046 RVA: 0x000E8AB7 File Offset: 0x000E6CB7
            // (set) Token: 0x06001B87 RID: 7047 RVA: 0x000E8ABF File Offset: 0x000E6CBF
            public int _id { get; set; }

            // Token: 0x17000705 RID: 1797
            // (get) Token: 0x06001B88 RID: 7048 RVA: 0x000E8AC8 File Offset: 0x000E6CC8
            // (set) Token: 0x06001B89 RID: 7049 RVA: 0x000E8AD0 File Offset: 0x000E6CD0
            public int _idModePaiement { get; set; }

            // Token: 0x17000706 RID: 1798
            // (get) Token: 0x06001B8A RID: 7050 RVA: 0x000E8AD9 File Offset: 0x000E6CD9
            // (set) Token: 0x06001B8B RID: 7051 RVA: 0x000E8AE1 File Offset: 0x000E6CE1
            public string _libelleModePaiement { get; set; }

            // Token: 0x17000707 RID: 1799
            // (get) Token: 0x06001B8C RID: 7052 RVA: 0x000E8AEA File Offset: 0x000E6CEA
            // (set) Token: 0x06001B8D RID: 7053 RVA: 0x000E8AF2 File Offset: 0x000E6CF2
            public decimal _montant { get; set; }

            // Token: 0x17000708 RID: 1800
            // (get) Token: 0x06001B8E RID: 7054 RVA: 0x000E8AFB File Offset: 0x000E6CFB
            // (set) Token: 0x06001B8F RID: 7055 RVA: 0x000E8B03 File Offset: 0x000E6D03
            public Service _service { get; set; }

            // Token: 0x17000709 RID: 1801
            // (get) Token: 0x06001B90 RID: 7056 RVA: 0x000E8B0C File Offset: 0x000E6D0C
            // (set) Token: 0x06001B91 RID: 7057 RVA: 0x000E8B14 File Offset: 0x000E6D14
            public DateTime _date { get; set; }

            // Token: 0x1700070A RID: 1802
            // (get) Token: 0x06001B92 RID: 7058 RVA: 0x000E8B1D File Offset: 0x000E6D1D
            // (set) Token: 0x06001B93 RID: 7059 RVA: 0x000E8B25 File Offset: 0x000E6D25
            public int _nbrImpression { get; set; }

            // Token: 0x1700070B RID: 1803
            // (get) Token: 0x06001B94 RID: 7060 RVA: 0x000E8B2E File Offset: 0x000E6D2E
            // (set) Token: 0x06001B95 RID: 7061 RVA: 0x000E8B36 File Offset: 0x000E6D36
            public bool _saved { get; set; }

            // Token: 0x1700070C RID: 1804
            // (get) Token: 0x06001B96 RID: 7062 RVA: 0x000E8B3F File Offset: 0x000E6D3F
            // (set) Token: 0x06001B97 RID: 7063 RVA: 0x000E8B47 File Offset: 0x000E6D47
            public Utilisateur _utilisateur { get; set; }

            // Token: 0x1700070D RID: 1805
            // (get) Token: 0x06001B98 RID: 7064 RVA: 0x000E8B50 File Offset: 0x000E6D50
            // (set) Token: 0x06001B99 RID: 7065 RVA: 0x000E8B58 File Offset: 0x000E6D58
            public DateTime _dateSystem { get; set; }

            // Token: 0x1700070E RID: 1806
            // (get) Token: 0x06001B9A RID: 7066 RVA: 0x000E8B61 File Offset: 0x000E6D61
            // (set) Token: 0x06001B9B RID: 7067 RVA: 0x000E8B69 File Offset: 0x000E6D69
            public string _serveur { get; set; }

            // Token: 0x1700070F RID: 1807
            // (get) Token: 0x06001B9C RID: 7068 RVA: 0x000E8B72 File Offset: 0x000E6D72
            // (set) Token: 0x06001B9D RID: 7069 RVA: 0x000E8B7A File Offset: 0x000E6D7A
            public string _gratuite { get; set; }

            // Token: 0x17000710 RID: 1808
            // (get) Token: 0x06001B9E RID: 7070 RVA: 0x000E8B83 File Offset: 0x000E6D83
            // (set) Token: 0x06001B9F RID: 7071 RVA: 0x000E8B8B File Offset: 0x000E6D8B
            public Cardex _cardex { get; set; }

            // Token: 0x17000711 RID: 1809
            // (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000E8B94 File Offset: 0x000E6D94
            // (set) Token: 0x06001BA1 RID: 7073 RVA: 0x000E8B9C File Offset: 0x000E6D9C
            public string _reference { get; set; }

            // Token: 0x06001BA2 RID: 7074 RVA: 0x000E8BA8 File Offset: 0x000E6DA8
            public LignePaiement()
            {
                this._id = 0;
                this._idModePaiement = 0;
                this._libelleModePaiement = "";
                this._montant = 0m;
                this._service = new Service();
                this._date = default(DateTime);
                this._nbrImpression = 0;
                this._saved = false;
                this._utilisateur = new Utilisateur();
                this._dateSystem = default(DateTime);
                this._serveur = "";
                this._gratuite = "";
                this._cardex = new Cardex();
                this._reference = "";
            }

            // Token: 0x06001BA3 RID: 7075 RVA: 0x000E8C50 File Offset: 0x000E6E50
            public LignePaiement(int id, int idModePaiement, string libelleModePaiement, decimal montant, Service service, DateTime date, int nbrImpression, bool saved, Utilisateur utilisateur, DateTime dateSystem, string serveur, string gratuite, Cardex cardex, string reference)
            {
                this._id = id;
                this._idModePaiement = idModePaiement;
                this._libelleModePaiement = libelleModePaiement;
                this._montant = montant;
                this._service = service;
                this._date = date;
                this._nbrImpression = nbrImpression;
                this._saved = saved;
                this._utilisateur = utilisateur;
                this._dateSystem = dateSystem;
                this._serveur = serveur;
                this._gratuite = gratuite;
                this._cardex = cardex;
                this._reference = reference;
            }

            // Token: 0x06001BA4 RID: 7076 RVA: 0x000E8CD0 File Offset: 0x000E6ED0
            public LignePaiement(LignePaiement _lignepaiement)
            {
                this._id = _lignepaiement._id;
                this._idModePaiement = _lignepaiement._idModePaiement;
                this._libelleModePaiement = _lignepaiement._libelleModePaiement;
                this._montant = _lignepaiement._montant;
                this._service = _lignepaiement._service;
                this._date = _lignepaiement._date;
                this._nbrImpression = _lignepaiement._nbrImpression;
                this._saved = _lignepaiement._saved;
                this._utilisateur = _lignepaiement._utilisateur;
                this._dateSystem = _lignepaiement._dateSystem;
                this._serveur = _lignepaiement._serveur;
                this._gratuite = _lignepaiement._gratuite;
                this._cardex = _lignepaiement._cardex;
                this._reference = _lignepaiement._reference;
            }
        }
    }



    // Token: 0x020002F9 RID: 761
    public class Cardex
    {
        // Token: 0x17000DCD RID: 3533
        // (get) Token: 0x060034B8 RID: 13496 RVA: 0x001956F2 File Offset: 0x001938F2
        // (set) Token: 0x060034B9 RID: 13497 RVA: 0x001956FA File Offset: 0x001938FA
        public int _id { get; set; }

        // Token: 0x17000DCE RID: 3534
        // (get) Token: 0x060034BA RID: 13498 RVA: 0x00195703 File Offset: 0x00193903
        // (set) Token: 0x060034BB RID: 13499 RVA: 0x0019570B File Offset: 0x0019390B
        public string _nom { get; set; }

        // Token: 0x17000DCF RID: 3535
        // (get) Token: 0x060034BC RID: 13500 RVA: 0x00195714 File Offset: 0x00193914
        // (set) Token: 0x060034BD RID: 13501 RVA: 0x0019571C File Offset: 0x0019391C
        public string _adresse { get; set; }

        // Token: 0x17000DD0 RID: 3536
        // (get) Token: 0x060034BE RID: 13502 RVA: 0x00195725 File Offset: 0x00193925
        // (set) Token: 0x060034BF RID: 13503 RVA: 0x0019572D File Offset: 0x0019392D
        public string _tel { get; set; }

        // Token: 0x17000DD1 RID: 3537
        // (get) Token: 0x060034C0 RID: 13504 RVA: 0x00195736 File Offset: 0x00193936
        // (set) Token: 0x060034C1 RID: 13505 RVA: 0x0019573E File Offset: 0x0019393E
        public string _fax { get; set; }

        // Token: 0x17000DD2 RID: 3538
        // (get) Token: 0x060034C2 RID: 13506 RVA: 0x00195747 File Offset: 0x00193947
        // (set) Token: 0x060034C3 RID: 13507 RVA: 0x0019574F File Offset: 0x0019394F
        public string _email { get; set; }

        // Token: 0x17000DD3 RID: 3539
        // (get) Token: 0x060034C4 RID: 13508 RVA: 0x00195758 File Offset: 0x00193958
        // (set) Token: 0x060034C5 RID: 13509 RVA: 0x00195760 File Offset: 0x00193960
        public DateTime _dateNaissance { get; set; }

        // Token: 0x17000DD4 RID: 3540
        // (get) Token: 0x060034C6 RID: 13510 RVA: 0x00195769 File Offset: 0x00193969
        // (set) Token: 0x060034C7 RID: 13511 RVA: 0x00195771 File Offset: 0x00193971
        public bool _etat { get; set; }

        // Token: 0x17000DD5 RID: 3541
        // (get) Token: 0x060034C8 RID: 13512 RVA: 0x0019577A File Offset: 0x0019397A
        // (set) Token: 0x060034C9 RID: 13513 RVA: 0x00195782 File Offset: 0x00193982
        public decimal _solde { get; set; }

        // Token: 0x17000DD6 RID: 3542
        // (get) Token: 0x060034CA RID: 13514 RVA: 0x0019578B File Offset: 0x0019398B
        // (set) Token: 0x060034CB RID: 13515 RVA: 0x00195793 File Offset: 0x00193993
        public int _remise { get; set; }

        // Token: 0x17000DD7 RID: 3543
        // (get) Token: 0x060034CC RID: 13516 RVA: 0x0019579C File Offset: 0x0019399C
        // (set) Token: 0x060034CD RID: 13517 RVA: 0x001957A4 File Offset: 0x001939A4
        public string _prenom { get; set; }

        // Token: 0x17000DD8 RID: 3544
        // (get) Token: 0x060034CE RID: 13518 RVA: 0x001957AD File Offset: 0x001939AD
        // (set) Token: 0x060034CF RID: 13519 RVA: 0x001957B5 File Offset: 0x001939B5
        public string _statut { get; set; }

        // Token: 0x17000DD9 RID: 3545
        // (get) Token: 0x060034D0 RID: 13520 RVA: 0x001957BE File Offset: 0x001939BE
        // (set) Token: 0x060034D1 RID: 13521 RVA: 0x001957C6 File Offset: 0x001939C6
        public Pays _pays { get; set; }

        // Token: 0x17000DDA RID: 3546
        // (get) Token: 0x060034D2 RID: 13522 RVA: 0x001957CF File Offset: 0x001939CF
        // (set) Token: 0x060034D3 RID: 13523 RVA: 0x001957D7 File Offset: 0x001939D7
        public string _indicatif { get; set; }

        // Token: 0x17000DDB RID: 3547
        // (get) Token: 0x060034D4 RID: 13524 RVA: 0x001957E0 File Offset: 0x001939E0
        // (set) Token: 0x060034D5 RID: 13525 RVA: 0x001957E8 File Offset: 0x001939E8
        public string _preference { get; set; }

        // Token: 0x060034D6 RID: 13526 RVA: 0x001957F4 File Offset: 0x001939F4
        public Cardex()
        {
            this._id = 0;
            this._nom = "";
            this._adresse = "";
            this._tel = "";
            this._fax = "";
            this._email = "";
            this._dateNaissance = default(DateTime);
            this._etat = false;
            this._solde = 0m;
            this._remise = 0;
            this._prenom = "";
            this._statut = "";
            this._pays = new Pays();
            this._indicatif = "";
            this._preference = "";
        }

        // Token: 0x060034D7 RID: 13527 RVA: 0x001958A8 File Offset: 0x00193AA8
        public Cardex(int id, string nom, string adresse, string tel, string fax, string email, DateTime dateNaissance, bool etat, int remise, string prenom, string statut, Pays pays, string indicatif, string preference, decimal solde)
        {
            this._id = id;
            this._nom = nom;
            this._adresse = adresse;
            this._tel = tel;
            this._fax = fax;
            this._email = email;
            this._dateNaissance = dateNaissance;
            this._etat = etat;
            this._remise = remise;
            this._solde = solde;
            this._prenom = prenom;
            this._statut = statut;
            this._pays = pays;
            this._indicatif = indicatif;
            this._preference = preference;
        }
    }


    public class Pays
    {
        // Token: 0x170005CE RID: 1486
        // (get) Token: 0x06001663 RID: 5731 RVA: 0x000BB55C File Offset: 0x000B975C
        // (set) Token: 0x06001664 RID: 5732 RVA: 0x000BB564 File Offset: 0x000B9764
        public int _id { get; set; }

        // Token: 0x170005CF RID: 1487
        // (get) Token: 0x06001665 RID: 5733 RVA: 0x000BB56D File Offset: 0x000B976D
        // (set) Token: 0x06001666 RID: 5734 RVA: 0x000BB575 File Offset: 0x000B9775
        public string _code { get; set; }

        // Token: 0x170005D0 RID: 1488
        // (get) Token: 0x06001667 RID: 5735 RVA: 0x000BB57E File Offset: 0x000B977E
        // (set) Token: 0x06001668 RID: 5736 RVA: 0x000BB586 File Offset: 0x000B9786
        public string _libelle { get; set; }

        // Token: 0x170005D1 RID: 1489
        // (get) Token: 0x06001669 RID: 5737 RVA: 0x000BB58F File Offset: 0x000B978F
        // (set) Token: 0x0600166A RID: 5738 RVA: 0x000BB597 File Offset: 0x000B9797
        public bool _etat { get; set; }

        // Token: 0x170005D2 RID: 1490
        // (get) Token: 0x0600166B RID: 5739 RVA: 0x000BB5A0 File Offset: 0x000B97A0
        // (set) Token: 0x0600166C RID: 5740 RVA: 0x000BB5A8 File Offset: 0x000B97A8
        public string _indicatif { get; set; }

        // Token: 0x0600166D RID: 5741 RVA: 0x000BB5B1 File Offset: 0x000B97B1
        public Pays()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._etat = false;
            this._indicatif = "";
        }

        // Token: 0x0600166E RID: 5742 RVA: 0x000BB5E8 File Offset: 0x000B97E8
        public Pays(int id, string code, string libelle, bool etat, string indicatif)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._indicatif = indicatif;
        }
    }
    public class Zone
    {
        // Token: 0x170013C8 RID: 5064
        // (get) Token: 0x060048B6 RID: 18614 RVA: 0x002229B3 File Offset: 0x00220BB3
        // (set) Token: 0x060048B7 RID: 18615 RVA: 0x002229BB File Offset: 0x00220BBB
        public int _id { get; set; }

        // Token: 0x170013C9 RID: 5065
        // (get) Token: 0x060048B8 RID: 18616 RVA: 0x002229C4 File Offset: 0x00220BC4
        // (set) Token: 0x060048B9 RID: 18617 RVA: 0x002229CC File Offset: 0x00220BCC
        public string _libelle { get; set; }

        // Token: 0x170013CA RID: 5066
        // (get) Token: 0x060048BA RID: 18618 RVA: 0x002229D5 File Offset: 0x00220BD5
        // (set) Token: 0x060048BB RID: 18619 RVA: 0x002229DD File Offset: 0x00220BDD
        public int _pourcentage { get; set; }

        // Token: 0x170013CB RID: 5067
        // (get) Token: 0x060048BC RID: 18620 RVA: 0x002229E6 File Offset: 0x00220BE6
        // (set) Token: 0x060048BD RID: 18621 RVA: 0x002229EE File Offset: 0x00220BEE
        public string _prix { get; set; }

        // Token: 0x170013CC RID: 5068
        // (get) Token: 0x060048BE RID: 18622 RVA: 0x002229F7 File Offset: 0x00220BF7
        // (set) Token: 0x060048BF RID: 18623 RVA: 0x002229FF File Offset: 0x00220BFF
        public PointDeVente _pointDeVente { get; set; }

        // Token: 0x170013CD RID: 5069
        // (get) Token: 0x060048C0 RID: 18624 RVA: 0x00222A08 File Offset: 0x00220C08
        // (set) Token: 0x060048C1 RID: 18625 RVA: 0x00222A10 File Offset: 0x00220C10
        public bool _etat { get; set; }

        // Token: 0x170013CE RID: 5070
        // (get) Token: 0x060048C2 RID: 18626 RVA: 0x00222A19 File Offset: 0x00220C19
        // (set) Token: 0x060048C3 RID: 18627 RVA: 0x00222A21 File Offset: 0x00220C21
        public string _couleur { get; set; }

        // Token: 0x170013CF RID: 5071
        // (get) Token: 0x060048C4 RID: 18628 RVA: 0x00222A2A File Offset: 0x00220C2A
        // (set) Token: 0x060048C5 RID: 18629 RVA: 0x00222A32 File Offset: 0x00220C32
        public bool _avecTable { get; set; }

        // Token: 0x170013D0 RID: 5072
        // (get) Token: 0x060048C6 RID: 18630 RVA: 0x00222A3B File Offset: 0x00220C3B
        // (set) Token: 0x060048C7 RID: 18631 RVA: 0x00222A43 File Offset: 0x00220C43
        public bool _avecCardex { get; set; }

        // Token: 0x060048C8 RID: 18632 RVA: 0x00222A4C File Offset: 0x00220C4C
        public Zone()
        {
            this._id = 0;
            this._libelle = "";
            this._pourcentage = 0;
            this._prix = "";
            this._pointDeVente = new PointDeVente();
            this._etat = false;
            this._couleur = "";
            this._avecTable = false;
            this._avecCardex = false;
        }

        // Token: 0x060048C9 RID: 18633 RVA: 0x00222AB0 File Offset: 0x00220CB0
        public Zone(int id, string libelle, string prix, int pourcentage, PointDeVente pointDeVente, bool etat, string couleur, bool avecTable, bool avecCardex)
        {
            this._id = id;
            this._libelle = libelle;
            this._pourcentage = pourcentage;
            this._prix = prix;
            this._pointDeVente = pointDeVente;
            this._etat = etat;
            this._couleur = couleur;
            this._avecTable = avecTable;
            this._avecCardex = avecCardex;
        }
    }

    public class PointDeVente
    {
        // Token: 0x170014A3 RID: 5283
        // (get) Token: 0x06004B7A RID: 19322 RVA: 0x0022F2C3 File Offset: 0x0022D4C3
        // (set) Token: 0x06004B7B RID: 19323 RVA: 0x0022F2CB File Offset: 0x0022D4CB
        public int _id { get; set; }

        // Token: 0x170014A4 RID: 5284
        // (get) Token: 0x06004B7C RID: 19324 RVA: 0x0022F2D4 File Offset: 0x0022D4D4
        // (set) Token: 0x06004B7D RID: 19325 RVA: 0x0022F2DC File Offset: 0x0022D4DC
        public string _libelle { get; set; }

        // Token: 0x170014A5 RID: 5285
        // (get) Token: 0x06004B7E RID: 19326 RVA: 0x0022F2E5 File Offset: 0x0022D4E5
        // (set) Token: 0x06004B7F RID: 19327 RVA: 0x0022F2ED File Offset: 0x0022D4ED
        public string _type { get; set; }

        // Token: 0x170014A6 RID: 5286
        // (get) Token: 0x06004B80 RID: 19328 RVA: 0x0022F2F6 File Offset: 0x0022D4F6
        // (set) Token: 0x06004B81 RID: 19329 RVA: 0x0022F2FE File Offset: 0x0022D4FE
        public string _typeFacture { get; set; }

        // Token: 0x170014A7 RID: 5287
        // (get) Token: 0x06004B82 RID: 19330 RVA: 0x0022F307 File Offset: 0x0022D507
        // (set) Token: 0x06004B83 RID: 19331 RVA: 0x0022F30F File Offset: 0x0022D50F
        public bool _couvertsObligatoire { get; set; }

        // Token: 0x170014A8 RID: 5288
        // (get) Token: 0x06004B84 RID: 19332 RVA: 0x0022F318 File Offset: 0x0022D518
        // (set) Token: 0x06004B85 RID: 19333 RVA: 0x0022F320 File Offset: 0x0022D520
        public bool _imprimerUniquementFactureSolde { get; set; }

        // Token: 0x170014A9 RID: 5289
        // (get) Token: 0x06004B86 RID: 19334 RVA: 0x0022F329 File Offset: 0x0022D529
        // (set) Token: 0x06004B87 RID: 19335 RVA: 0x0022F331 File Offset: 0x0022D531
        public bool _imprimerPrestation { get; set; }

        // Token: 0x170014AA RID: 5290
        // (get) Token: 0x06004B88 RID: 19336 RVA: 0x0022F33A File Offset: 0x0022D53A
        // (set) Token: 0x06004B89 RID: 19337 RVA: 0x0022F342 File Offset: 0x0022D542
        public bool _tableObligatoire { get; set; }

        // Token: 0x170014AB RID: 5291
        // (get) Token: 0x06004B8A RID: 19338 RVA: 0x0022F34B File Offset: 0x0022D54B
        // (set) Token: 0x06004B8B RID: 19339 RVA: 0x0022F353 File Offset: 0x0022D553
        public int _numeroFacture { get; set; }

        // Token: 0x170014AC RID: 5292
        // (get) Token: 0x06004B8C RID: 19340 RVA: 0x0022F35C File Offset: 0x0022D55C
        // (set) Token: 0x06004B8D RID: 19341 RVA: 0x0022F364 File Offset: 0x0022D564
        public List<Service> _listService { get; set; }

        // Token: 0x170014AD RID: 5293
        // (get) Token: 0x06004B8E RID: 19342 RVA: 0x0022F36D File Offset: 0x0022D56D
        // (set) Token: 0x06004B8F RID: 19343 RVA: 0x0022F375 File Offset: 0x0022D575
        public List<FamilleCarte> _listFamilleCarte { get; set; }

        // Token: 0x170014AE RID: 5294
        // (get) Token: 0x06004B90 RID: 19344 RVA: 0x0022F37E File Offset: 0x0022D57E
        // (set) Token: 0x06004B91 RID: 19345 RVA: 0x0022F386 File Offset: 0x0022D586
        public List<ModePaiement> _listModePaiement { get; set; }

        // Token: 0x170014AF RID: 5295
        // (get) Token: 0x06004B92 RID: 19346 RVA: 0x0022F38F File Offset: 0x0022D58F
        // (set) Token: 0x06004B93 RID: 19347 RVA: 0x0022F397 File Offset: 0x0022D597
        public bool _etat { get; set; }

        // Token: 0x170014B0 RID: 5296
        // (get) Token: 0x06004B94 RID: 19348 RVA: 0x0022F3A0 File Offset: 0x0022D5A0
        // (set) Token: 0x06004B95 RID: 19349 RVA: 0x0022F3A8 File Offset: 0x0022D5A8
        public bool _serveurObligatoir { get; set; }

        // Token: 0x170014B1 RID: 5297
        // (get) Token: 0x06004B96 RID: 19350 RVA: 0x0022F3B1 File Offset: 0x0022D5B1
        // (set) Token: 0x06004B97 RID: 19351 RVA: 0x0022F3B9 File Offset: 0x0022D5B9
        public bool _avecCodeBarre { get; set; }

        // Token: 0x170014B2 RID: 5298
        // (get) Token: 0x06004B98 RID: 19352 RVA: 0x0022F3C2 File Offset: 0x0022D5C2
        // (set) Token: 0x06004B99 RID: 19353 RVA: 0x0022F3CA File Offset: 0x0022D5CA
        public bool _venteRapide { get; set; }

        // Token: 0x170014B3 RID: 5299
        // (get) Token: 0x06004B9A RID: 19354 RVA: 0x0022F3D3 File Offset: 0x0022D5D3
        // (set) Token: 0x06004B9B RID: 19355 RVA: 0x0022F3DB File Offset: 0x0022D5DB
        public bool _avecCalculateur { get; set; }

        // Token: 0x170014B4 RID: 5300
        // (get) Token: 0x06004B9C RID: 19356 RVA: 0x0022F3E4 File Offset: 0x0022D5E4
        // (set) Token: 0x06004B9D RID: 19357 RVA: 0x0022F3EC File Offset: 0x0022D5EC
        public bool _avecPlanSalle { get; set; }

        // Token: 0x170014B5 RID: 5301
        // (get) Token: 0x06004B9E RID: 19358 RVA: 0x0022F3F5 File Offset: 0x0022D5F5
        // (set) Token: 0x06004B9F RID: 19359 RVA: 0x0022F3FD File Offset: 0x0022D5FD
        public int _nombreCommande { get; set; }

        // Token: 0x170014B6 RID: 5302
        // (get) Token: 0x06004BA0 RID: 19360 RVA: 0x0022F406 File Offset: 0x0022D606
        // (set) Token: 0x06004BA1 RID: 19361 RVA: 0x0022F40E File Offset: 0x0022D60E
        public bool _avecQteVisuelle { get; set; }

        // Token: 0x170014B7 RID: 5303
        // (get) Token: 0x06004BA2 RID: 19362 RVA: 0x0022F417 File Offset: 0x0022D617
        // (set) Token: 0x06004BA3 RID: 19363 RVA: 0x0022F41F File Offset: 0x0022D61F
        public bool _garderQteVisuelle { get; set; }

        // Token: 0x170014B8 RID: 5304
        // (get) Token: 0x06004BA4 RID: 19364 RVA: 0x0022F428 File Offset: 0x0022D628
        // (set) Token: 0x06004BA5 RID: 19365 RVA: 0x0022F430 File Offset: 0x0022D630
        public int _codeArticle { get; set; }

        // Token: 0x170014B9 RID: 5305
        // (get) Token: 0x06004BA6 RID: 19366 RVA: 0x0022F439 File Offset: 0x0022D639
        // (set) Token: 0x06004BA7 RID: 19367 RVA: 0x0022F441 File Offset: 0x0022D641
        public int _codePoids { get; set; }

        // Token: 0x170014BA RID: 5306
        // (get) Token: 0x06004BA8 RID: 19368 RVA: 0x0022F44A File Offset: 0x0022D64A
        // (set) Token: 0x06004BA9 RID: 19369 RVA: 0x0022F452 File Offset: 0x0022D652
        public bool _imprimerLog { get; set; }

        // Token: 0x170014BB RID: 5307
        // (get) Token: 0x06004BAA RID: 19370 RVA: 0x0022F45B File Offset: 0x0022D65B
        // (set) Token: 0x06004BAB RID: 19371 RVA: 0x0022F463 File Offset: 0x0022D663
        public Imprimante _imprimanteLog { get; set; }

        // Token: 0x170014BC RID: 5308
        // (get) Token: 0x06004BAC RID: 19372 RVA: 0x0022F46C File Offset: 0x0022D66C
        // (set) Token: 0x06004BAD RID: 19373 RVA: 0x0022F474 File Offset: 0x0022D674
        public bool _imprimerA4 { get; set; }

        // Token: 0x170014BD RID: 5309
        // (get) Token: 0x06004BAE RID: 19374 RVA: 0x0022F47D File Offset: 0x0022D67D
        // (set) Token: 0x06004BAF RID: 19375 RVA: 0x0022F485 File Offset: 0x0022D685
        public Imprimante _imprimanteA4 { get; set; }

        // Token: 0x170014BE RID: 5310
        // (get) Token: 0x06004BB0 RID: 19376 RVA: 0x0022F48E File Offset: 0x0022D68E
        // (set) Token: 0x06004BB1 RID: 19377 RVA: 0x0022F496 File Offset: 0x0022D696
        public bool _attribueEncaissement { get; set; }

        // Token: 0x170014BF RID: 5311
        // (get) Token: 0x06004BB2 RID: 19378 RVA: 0x0022F49F File Offset: 0x0022D69F
        // (set) Token: 0x06004BB3 RID: 19379 RVA: 0x0022F4A7 File Offset: 0x0022D6A7
        public bool _imprimerFacture { get; set; }

        // Token: 0x170014C0 RID: 5312
        // (get) Token: 0x06004BB4 RID: 19380 RVA: 0x0022F4B0 File Offset: 0x0022D6B0
        // (set) Token: 0x06004BB5 RID: 19381 RVA: 0x0022F4B8 File Offset: 0x0022D6B8
        public bool _imprimerBonAnnulation { get; set; }

        // Token: 0x170014C1 RID: 5313
        // (get) Token: 0x06004BB6 RID: 19382 RVA: 0x0022F4C1 File Offset: 0x0022D6C1
        // (set) Token: 0x06004BB7 RID: 19383 RVA: 0x0022F4C9 File Offset: 0x0022D6C9
        public bool _imprimerFactureAvecAnulation { get; set; }

        // Token: 0x170014C2 RID: 5314
        // (get) Token: 0x06004BB8 RID: 19384 RVA: 0x0022F4D2 File Offset: 0x0022D6D2
        // (set) Token: 0x06004BB9 RID: 19385 RVA: 0x0022F4DA File Offset: 0x0022D6DA
        public bool _imprimerBonTransfert { get; set; }

        // Token: 0x170014C3 RID: 5315
        // (get) Token: 0x06004BBA RID: 19386 RVA: 0x0022F4E3 File Offset: 0x0022D6E3
        // (set) Token: 0x06004BBB RID: 19387 RVA: 0x0022F4EB File Offset: 0x0022D6EB
        public bool _imprimerBonTransfertAvecArticle { get; set; }

        // Token: 0x170014C4 RID: 5316
        // (get) Token: 0x06004BBC RID: 19388 RVA: 0x0022F4F4 File Offset: 0x0022D6F4
        // (set) Token: 0x06004BBD RID: 19389 RVA: 0x0022F4FC File Offset: 0x0022D6FC
        public bool _venteParZone { get; set; }

        // Token: 0x170014C5 RID: 5317
        // (get) Token: 0x06004BBE RID: 19390 RVA: 0x0022F505 File Offset: 0x0022D705
        // (set) Token: 0x06004BBF RID: 19391 RVA: 0x0022F50D File Offset: 0x0022D70D
        public bool _imprimerBonRemise { get; set; }

        // Token: 0x170014C6 RID: 5318
        // (get) Token: 0x06004BC0 RID: 19392 RVA: 0x0022F516 File Offset: 0x0022D716
        // (set) Token: 0x06004BC1 RID: 19393 RVA: 0x0022F51E File Offset: 0x0022D71E
        public bool _imprimerBonPerte { get; set; }

        // Token: 0x170014C7 RID: 5319
        // (get) Token: 0x06004BC2 RID: 19394 RVA: 0x0022F527 File Offset: 0x0022D727
        // (set) Token: 0x06004BC3 RID: 19395 RVA: 0x0022F52F File Offset: 0x0022D72F
        public bool _calculateurBillet { get; set; }

        // Token: 0x170014C8 RID: 5320
        // (get) Token: 0x06004BC4 RID: 19396 RVA: 0x0022F538 File Offset: 0x0022D738
        // (set) Token: 0x06004BC5 RID: 19397 RVA: 0x0022F540 File Offset: 0x0022D740
        public bool _imprimerPrestationCloture { get; set; }

        // Token: 0x170014C9 RID: 5321
        // (get) Token: 0x06004BC6 RID: 19398 RVA: 0x0022F549 File Offset: 0x0022D749
        // (set) Token: 0x06004BC7 RID: 19399 RVA: 0x0022F551 File Offset: 0x0022D751
        public string _typeCommande { get; set; }

        // Token: 0x170014CA RID: 5322
        // (get) Token: 0x06004BC8 RID: 19400 RVA: 0x0022F55A File Offset: 0x0022D75A
        // (set) Token: 0x06004BC9 RID: 19401 RVA: 0x0022F562 File Offset: 0x0022D762
        public bool _doubleEcran { get; set; }

        // Token: 0x170014CB RID: 5323
        // (get) Token: 0x06004BCA RID: 19402 RVA: 0x0022F56B File Offset: 0x0022D76B
        // (set) Token: 0x06004BCB RID: 19403 RVA: 0x0022F573 File Offset: 0x0022D773
        public bool _imprimerCloture { get; set; }

        // Token: 0x170014CC RID: 5324
        // (get) Token: 0x06004BCC RID: 19404 RVA: 0x0022F57C File Offset: 0x0022D77C
        // (set) Token: 0x06004BCD RID: 19405 RVA: 0x0022F584 File Offset: 0x0022D784
        public bool _imprimerDetailReclamation { get; set; }

        // Token: 0x170014CD RID: 5325
        // (get) Token: 0x06004BCE RID: 19406 RVA: 0x0022F58D File Offset: 0x0022D78D
        // (set) Token: 0x06004BCF RID: 19407 RVA: 0x0022F595 File Offset: 0x0022D795
        public bool _grouperLigneCommande { get; set; }

        // Token: 0x170014CE RID: 5326
        // (get) Token: 0x06004BD0 RID: 19408 RVA: 0x0022F59E File Offset: 0x0022D79E
        // (set) Token: 0x06004BD1 RID: 19409 RVA: 0x0022F5A6 File Offset: 0x0022D7A6
        public bool _bloquerReclamation { get; set; }

        // Token: 0x170014CF RID: 5327
        // (get) Token: 0x06004BD2 RID: 19410 RVA: 0x0022F5AF File Offset: 0x0022D7AF
        // (set) Token: 0x06004BD3 RID: 19411 RVA: 0x0022F5B7 File Offset: 0x0022D7B7
        public bool _rappelMenu { get; set; }

        // Token: 0x170014D0 RID: 5328
        // (get) Token: 0x06004BD4 RID: 19412 RVA: 0x0022F5C0 File Offset: 0x0022D7C0
        // (set) Token: 0x06004BD5 RID: 19413 RVA: 0x0022F5C8 File Offset: 0x0022D7C8
        public bool _interfaceReservationCaisse { get; set; }

        // Token: 0x170014D1 RID: 5329
        // (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0022F5D1 File Offset: 0x0022D7D1
        // (set) Token: 0x06004BD7 RID: 19415 RVA: 0x0022F5D9 File Offset: 0x0022D7D9
        public bool _historiqueStock { get; set; }

        // Token: 0x170014D2 RID: 5330
        // (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0022F5E2 File Offset: 0x0022D7E2
        // (set) Token: 0x06004BD9 RID: 19417 RVA: 0x0022F5EA File Offset: 0x0022D7EA
        public int _nbrImpressionFacture { get; set; }

        // Token: 0x170014D3 RID: 5331
        // (get) Token: 0x06004BDA RID: 19418 RVA: 0x0022F5F3 File Offset: 0x0022D7F3
        // (set) Token: 0x06004BDB RID: 19419 RVA: 0x0022F5FB File Offset: 0x0022D7FB
        public bool _imprimerStockVisuelle { get; set; }

        // Token: 0x170014D4 RID: 5332
        // (get) Token: 0x06004BDC RID: 19420 RVA: 0x0022F604 File Offset: 0x0022D804
        // (set) Token: 0x06004BDD RID: 19421 RVA: 0x0022F60C File Offset: 0x0022D80C
        public bool _stockParFournisseur { get; set; }

        // Token: 0x170014D5 RID: 5333
        // (get) Token: 0x06004BDE RID: 19422 RVA: 0x0022F615 File Offset: 0x0022D815
        // (set) Token: 0x06004BDF RID: 19423 RVA: 0x0022F61D File Offset: 0x0022D81D
        public int _intervalheure { get; set; }

        // Token: 0x170014D6 RID: 5334
        // (get) Token: 0x06004BE0 RID: 19424 RVA: 0x0022F626 File Offset: 0x0022D826
        // (set) Token: 0x06004BE1 RID: 19425 RVA: 0x0022F62E File Offset: 0x0022D82E
        public int _intervalminutes { get; set; }

        // Token: 0x170014D7 RID: 5335
        // (get) Token: 0x06004BE2 RID: 19426 RVA: 0x0022F637 File Offset: 0x0022D837
        // (set) Token: 0x06004BE3 RID: 19427 RVA: 0x0022F63F File Offset: 0x0022D83F
        public int _intervalminutesRetard { get; set; }

        // Token: 0x170014D8 RID: 5336
        // (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0022F648 File Offset: 0x0022D848
        // (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0022F650 File Offset: 0x0022D850
        public bool _supprimerPaiement { get; set; }

        // Token: 0x170014D9 RID: 5337
        // (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0022F659 File Offset: 0x0022D859
        // (set) Token: 0x06004BE7 RID: 19431 RVA: 0x0022F661 File Offset: 0x0022D861
        public bool _imprimerTransfert { get; set; }

        // Token: 0x170014DA RID: 5338
        // (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0022F66A File Offset: 0x0022D86A
        // (set) Token: 0x06004BE9 RID: 19433 RVA: 0x0022F672 File Offset: 0x0022D872
        public Imprimante _imprimanteTransfert { get; set; }

        // Token: 0x170014DB RID: 5339
        // (get) Token: 0x06004BEA RID: 19434 RVA: 0x0022F67B File Offset: 0x0022D87B
        // (set) Token: 0x06004BEB RID: 19435 RVA: 0x0022F683 File Offset: 0x0022D883
        public bool _minSpend { get; set; }

        // Token: 0x170014DC RID: 5340
        // (get) Token: 0x06004BEC RID: 19436 RVA: 0x0022F68C File Offset: 0x0022D88C
        // (set) Token: 0x06004BED RID: 19437 RVA: 0x0022F694 File Offset: 0x0022D894
        public decimal _valMinSpend { get; set; }

        // Token: 0x06004BEE RID: 19438 RVA: 0x0022F6A0 File Offset: 0x0022D8A0
        public PointDeVente()
        {
            this._id = 0;
            this._libelle = "";
            this._type = "";
            this._typeFacture = "";
            this._couvertsObligatoire = false;
            this._tableObligatoire = false;
            this._imprimerUniquementFactureSolde = false;
            this._imprimerPrestation = false;
            this._listService = new List<Service>();
            this._listFamilleCarte = new List<FamilleCarte>();
            this._listModePaiement = new List<ModePaiement>();
            this._etat = false;
            this._numeroFacture = 0;
            this._serveurObligatoir = false;
            this._avecCodeBarre = false;
            this._venteRapide = false;
            this._avecCalculateur = false;
            this._avecPlanSalle = false;
            this._nombreCommande = 1;
            this._avecQteVisuelle = false;
            this._garderQteVisuelle = false;
            this._codeArticle = 0;
            this._codePoids = 0;
            this._imprimerLog = false;
            this._imprimanteLog = new Imprimante();
            this._imprimerA4 = false;
            this._imprimanteA4 = new Imprimante();
            this._attribueEncaissement = false;
            this._imprimerFacture = false;
            this._imprimerBonAnnulation = false;
            this._imprimerFactureAvecAnulation = false;
            this._imprimerBonTransfert = false;
            this._imprimerBonTransfertAvecArticle = false;
            this._venteParZone = false;
            this._imprimerBonRemise = false;
            this._imprimerBonPerte = false;
            this._calculateurBillet = false;
            this._imprimerPrestationCloture = false;
            this._typeCommande = "";
            this._doubleEcran = false;
            this._imprimerCloture = true;
            this._imprimerDetailReclamation = true;
            this._grouperLigneCommande = false;
            this._bloquerReclamation = false;
            this._rappelMenu = false;
            this._interfaceReservationCaisse = false;
            this._historiqueStock = false;
            this._nbrImpressionFacture = 1;
            this._imprimerStockVisuelle = false;
            this._stockParFournisseur = false;
            this._intervalheure = 24;
            this._intervalminutes = 0;
            this._intervalminutesRetard = 0;
            this._supprimerPaiement = false;
            this._imprimerTransfert = false;
            this._imprimanteTransfert = new Imprimante();
            this._minSpend = false;
            this._valMinSpend = 0m;
        }

        // Token: 0x06004BEF RID: 19439 RVA: 0x0022F878 File Offset: 0x0022DA78
        public PointDeVente(int id)
        {
            this._id = id;
            this._libelle = "";
            this._type = "";
            this._typeFacture = "";
            this._couvertsObligatoire = false;
            this._tableObligatoire = false;
            this._imprimerUniquementFactureSolde = false;
            this._imprimerPrestation = false;
            this._listService = new List<Service>();
            this._listFamilleCarte = new List<FamilleCarte>();
            this._listModePaiement = new List<ModePaiement>();
            this._etat = false;
            this._numeroFacture = 0;
            this._serveurObligatoir = false;
            this._avecCodeBarre = false;
            this._venteRapide = false;
            this._avecCalculateur = false;
            this._avecPlanSalle = false;
            this._nombreCommande = 1;
            this._avecQteVisuelle = false;
            this._garderQteVisuelle = false;
            this._codePoids = 0;
            this._codeArticle = 0;
            this._imprimerLog = false;
            this._imprimanteLog = new Imprimante();
            this._imprimerA4 = false;
            this._imprimanteA4 = new Imprimante();
            this._attribueEncaissement = false;
            this._imprimerFacture = false;
            this._imprimerBonAnnulation = false;
            this._imprimerFactureAvecAnulation = false;
            this._imprimerBonTransfert = false;
            this._imprimerBonTransfertAvecArticle = false;
            this._venteParZone = false;
            this._imprimerBonRemise = false;
            this._imprimerBonPerte = false;
            this._calculateurBillet = false;
            this._imprimerPrestationCloture = false;
            this._typeCommande = "";
            this._doubleEcran = false;
            this._imprimerCloture = true;
            this._imprimerDetailReclamation = true;
            this._grouperLigneCommande = false;
            this._bloquerReclamation = false;
            this._rappelMenu = false;
            this._interfaceReservationCaisse = false;
            this._historiqueStock = false;
            this._nbrImpressionFacture = 1;
            this._imprimerStockVisuelle = false;
            this._stockParFournisseur = false;
            this._intervalheure = 24;
            this._intervalminutes = 0;
            this._intervalminutesRetard = 0;
            this._supprimerPaiement = false;
            this._imprimerTransfert = false;
            this._imprimanteTransfert = new Imprimante();
            this._minSpend = false;
            this._valMinSpend = 0m;
        }

        // Token: 0x06004BF0 RID: 19440 RVA: 0x0022FA50 File Offset: 0x0022DC50
        public PointDeVente(int id, string libelle, string type, string typeFacture, bool couvertsObligatoire, bool imprimerUniquementFactureSolde, bool imprimerPrestation, int numeroFacture, bool tableObligatoire, bool etat, bool serveurObligatoir, bool avecCodeBarre, bool venteRapide, bool avecCalculateur, bool avecPlanSalle, int nombreCommande, bool avecQteVisuelle, bool garderQteVisuelle, int codeArticle, int codePoids, bool imprimerLog, Imprimante imprimanteLog, bool imprimerA4, Imprimante imprimanteA4, bool attribueEncaissement, bool imprimerFacture, bool imprimerBonAnnulation, bool imprimerFactureAvecAnulation, bool imprimerBonTransfert, bool imprimerBonTransfertAvecArticle, bool venteParZone, bool imprimerBonRemise, bool imprimerBonPerte, bool calculateurBillet, bool imprimerPrestationCloture, string typeCommande, bool doubleEcran, bool imprimerCloture, bool imprimerDetailReclamation, bool grouperLigneCommande, bool bloquerReclamation, bool rappelMenu, bool interfaceReservationCaisse, bool historiqueStock, int nbrImpressionFacture, bool imprimerStockVisuelle, bool stockParFournisseur, int intervalheure, int intervalminutes, int intervalminutesRetard, bool supprimerPaiement, bool imprimerTransfert, Imprimante imprimanteTransfert, bool minSpend, decimal valMinSpend)
        {
            this._id = id;
            this._libelle = libelle;
            this._type = type;
            this._typeFacture = typeFacture;
            this._tableObligatoire = tableObligatoire;
            this._couvertsObligatoire = couvertsObligatoire;
            this._imprimerPrestation = imprimerPrestation;
            this._imprimerUniquementFactureSolde = imprimerUniquementFactureSolde;
            this._listService = new List<Service>();
            this._listFamilleCarte = new List<FamilleCarte>();
            this._listModePaiement = new List<ModePaiement>();
            this._numeroFacture = numeroFacture;
            this._etat = etat;
            this._serveurObligatoir = serveurObligatoir;
            this._avecCodeBarre = avecCodeBarre;
            this._venteRapide = venteRapide;
            this._avecCalculateur = avecCalculateur;
            this._avecPlanSalle = avecPlanSalle;
            this._nombreCommande = nombreCommande;
            this._avecQteVisuelle = avecQteVisuelle;
            this._garderQteVisuelle = garderQteVisuelle;
            this._codeArticle = codeArticle;
            this._codePoids = codePoids;
            this._imprimerLog = imprimerLog;
            this._imprimanteLog = imprimanteLog;
            this._imprimerA4 = imprimerA4;
            this._imprimanteA4 = imprimanteA4;
            this._attribueEncaissement = attribueEncaissement;
            this._imprimerFacture = imprimerFacture;
            this._imprimerBonAnnulation = imprimerBonAnnulation;
            this._imprimerFactureAvecAnulation = imprimerFactureAvecAnulation;
            this._imprimerBonTransfert = imprimerBonTransfert;
            this._imprimerBonTransfertAvecArticle = imprimerBonTransfertAvecArticle;
            this._venteParZone = venteParZone;
            this._imprimerBonRemise = imprimerBonRemise;
            this._imprimerBonPerte = imprimerBonPerte;
            this._calculateurBillet = calculateurBillet;
            this._imprimerPrestationCloture = imprimerPrestationCloture;
            this._typeCommande = typeCommande;
            this._doubleEcran = doubleEcran;
            this._imprimerCloture = imprimerCloture;
            this._imprimerDetailReclamation = imprimerDetailReclamation;
            this._grouperLigneCommande = grouperLigneCommande;
            this._bloquerReclamation = bloquerReclamation;
            this._rappelMenu = rappelMenu;
            this._interfaceReservationCaisse = interfaceReservationCaisse;
            this._historiqueStock = historiqueStock;
            this._nbrImpressionFacture = nbrImpressionFacture;
            this._imprimerStockVisuelle = imprimerStockVisuelle;
            this._stockParFournisseur = stockParFournisseur;
            this._intervalheure = intervalheure;
            this._intervalminutes = intervalminutes;
            this._intervalminutesRetard = intervalminutesRetard;
            this._supprimerPaiement = supprimerPaiement;
            this._imprimerTransfert = imprimerTransfert;
            this._imprimanteTransfert = imprimanteTransfert;
            this._minSpend = minSpend;
            this._valMinSpend = valMinSpend;
        }

        // Token: 0x06004BF1 RID: 19441 RVA: 0x0022FC3C File Offset: 0x0022DE3C
        public PointDeVente(int id, string libelle, string type, string typeFacture, bool couvertsObligatoire, bool imprimerUniquementFactureSolde, bool imprimerPrestation, List<Service> listService, int numeroFacture, bool tableObligatoire, bool etat, bool serveurObligatoir, bool avecCodeBarre, bool venteRapide, bool avecCalculateur, bool avecPlanSalle, int nombreCommande, bool avecQteVisuelle, bool garderQteVisuelle, int codeArticle, int codePoids, bool imprimerLog, Imprimante imprimanteLog, bool imprimerA4, Imprimante imprimanteA4, bool attribueEncaissement, bool imprimerFacture, bool imprimerBonAnnulation, bool imprimerFactureAvecAnulation, bool imprimerBonTransfert, bool imprimerBonTransfertAvecArticle, bool venteParZone, bool imprimerBonRemise, bool imprimerBonPerte, bool calculateurBillet, bool imprimerPrestationCloture, string typeCommande, bool doubleEcran, bool imprimerCloture, bool imprimerDetailReclamation, bool grouperLigneCommande, bool bloquerReclamation, bool rappelMenu, bool interfaceReservationCaisse, bool historiqueStock, int nbrImpressionFacture, bool imprimerStockVisuelle, bool stockParFournisseur, int intervalheure, int intervalminutes, int intervalminutesRetard, bool supprimerPaiement, bool imprimerTransfert, Imprimante imprimanteTransfert, bool minSpend, decimal valMinSpend)
        {
            this._id = id;
            this._libelle = libelle;
            this._type = type;
            this._typeFacture = typeFacture;
            this._couvertsObligatoire = couvertsObligatoire;
            this._tableObligatoire = tableObligatoire;
            this._imprimerPrestation = imprimerPrestation;
            this._imprimerUniquementFactureSolde = imprimerUniquementFactureSolde;
            this._listService = listService;
            this._listFamilleCarte = new List<FamilleCarte>();
            this._listModePaiement = new List<ModePaiement>();
            this._numeroFacture = numeroFacture;
            this._etat = etat;
            this._serveurObligatoir = serveurObligatoir;
            this._avecCodeBarre = avecCodeBarre;
            this._venteRapide = venteRapide;
            this._avecCalculateur = avecCalculateur;
            this._avecPlanSalle = avecPlanSalle;
            this._nombreCommande = nombreCommande;
            this._avecQteVisuelle = avecQteVisuelle;
            this._garderQteVisuelle = garderQteVisuelle;
            this._codeArticle = codeArticle;
            this._codePoids = codePoids;
            this._imprimerLog = imprimerLog;
            this._imprimanteLog = imprimanteLog;
            this._imprimerA4 = imprimerA4;
            this._imprimanteA4 = imprimanteA4;
            this._attribueEncaissement = attribueEncaissement;
            this._imprimerFacture = imprimerFacture;
            this._imprimerBonAnnulation = imprimerBonAnnulation;
            this._imprimerFactureAvecAnulation = imprimerFactureAvecAnulation;
            this._imprimerBonTransfert = imprimerBonTransfert;
            this._imprimerBonTransfertAvecArticle = imprimerBonTransfertAvecArticle;
            this._venteParZone = venteParZone;
            this._imprimerBonRemise = imprimerBonRemise;
            this._imprimerBonPerte = imprimerBonPerte;
            this._calculateurBillet = calculateurBillet;
            this._imprimerPrestationCloture = imprimerPrestationCloture;
            this._typeCommande = typeCommande;
            this._doubleEcran = doubleEcran;
            this._imprimerCloture = imprimerCloture;
            this._imprimerDetailReclamation = imprimerDetailReclamation;
            this._grouperLigneCommande = grouperLigneCommande;
            this._bloquerReclamation = bloquerReclamation;
            this._rappelMenu = rappelMenu;
            this._interfaceReservationCaisse = interfaceReservationCaisse;
            this._nbrImpressionFacture = nbrImpressionFacture;
            this._imprimerStockVisuelle = imprimerStockVisuelle;
            this._stockParFournisseur = stockParFournisseur;
            this._intervalheure = intervalheure;
            this._intervalminutes = intervalminutes;
            this._intervalminutesRetard = intervalminutesRetard;
            this._supprimerPaiement = supprimerPaiement;
            this._imprimerTransfert = imprimerTransfert;
            this._imprimanteTransfert = imprimanteTransfert;
            this._minSpend = minSpend;
            this._valMinSpend = valMinSpend;
        }

        // Token: 0x06004BF2 RID: 19442 RVA: 0x0022FE1C File Offset: 0x0022E01C
        public PointDeVente(int id, string libelle, string type, string typeFacture, bool couvertsObligatoire, bool imprimerUniquementFactureSolde, bool imprimerPrestation, List<Service> listService, List<FamilleCarte> listFamilleCarte, List<ModePaiement> listModePaiement, int numeroFacture, bool tableObligatoire, bool etat, bool serveurObligatoir, bool avecCodeBarre, bool venteRapide, bool avecCalculateur, bool avecPlanSalle, int nombreCommande, bool avecQteVisuelle, bool garderQteVisuelle, int codeArticle, int codePoids, bool imprimerLog, Imprimante imprimanteLog, bool imprimerA4, Imprimante imprimanteA4, bool attribueEncaissement, bool imprimerFacture, bool imprimerBonAnnulation, bool imprimerFactureAvecAnulation, bool imprimerBonTransfert, bool imprimerBonTransfertAvecArticle, bool venteParZone, bool imprimerBonRemise, bool imprimerBonPerte, bool calculateurBillet, bool imprimerPrestationCloture, string typeCommande, bool doubleEcran, bool imprimerCloture, bool imprimerDetailReclamation, bool grouperLigneCommande, bool bloquerReclamation, bool rappelMenu, bool interfaceReservationCaisse, bool historiqueStock, int nbrImpressionFacture, bool imprimerStockVisuelle, bool stockParFournisseur, int intervalheure, int intervalminutes, int intervalminutesRetard, bool supprimerPaiement, bool imprimerTransfert, Imprimante imprimanteTransfert, bool minSpend, decimal valMinSpend)
        {
            this._id = id;
            this._libelle = libelle;
            this._type = type;
            this._typeFacture = typeFacture;
            this._couvertsObligatoire = couvertsObligatoire;
            this._imprimerPrestation = imprimerPrestation;
            this._tableObligatoire = tableObligatoire;
            this._imprimerUniquementFactureSolde = imprimerUniquementFactureSolde;
            this._listService = listService;
            this._listFamilleCarte = listFamilleCarte;
            this._listModePaiement = listModePaiement;
            this._numeroFacture = numeroFacture;
            this._etat = etat;
            this._serveurObligatoir = serveurObligatoir;
            this._avecCodeBarre = avecCodeBarre;
            this._venteRapide = venteRapide;
            this._avecCalculateur = avecCalculateur;
            this._avecPlanSalle = avecPlanSalle;
            this._nombreCommande = nombreCommande;
            this._avecQteVisuelle = avecQteVisuelle;
            this._garderQteVisuelle = garderQteVisuelle;
            this._codeArticle = codeArticle;
            this._codePoids = codePoids;
            this._imprimerLog = imprimerLog;
            this._imprimanteLog = imprimanteLog;
            this._imprimerA4 = imprimerA4;
            this._imprimanteA4 = imprimanteA4;
            this._attribueEncaissement = attribueEncaissement;
            this._imprimerFacture = imprimerFacture;
            this._imprimerBonAnnulation = imprimerBonAnnulation;
            this._imprimerFactureAvecAnulation = imprimerFactureAvecAnulation;
            this._imprimerBonTransfert = imprimerBonTransfert;
            this._imprimerBonTransfertAvecArticle = imprimerBonTransfertAvecArticle;
            this._venteParZone = venteParZone;
            this._imprimerBonRemise = imprimerBonRemise;
            this._imprimerBonPerte = imprimerBonPerte;
            this._calculateurBillet = calculateurBillet;
            this._imprimerPrestationCloture = imprimerPrestationCloture;
            this._typeCommande = typeCommande;
            this._doubleEcran = doubleEcran;
            this._imprimerCloture = imprimerCloture;
            this._imprimerDetailReclamation = imprimerDetailReclamation;
            this._grouperLigneCommande = grouperLigneCommande;
            this._bloquerReclamation = bloquerReclamation;
            this._rappelMenu = rappelMenu;
            this._interfaceReservationCaisse = interfaceReservationCaisse;
            this._historiqueStock = historiqueStock;
            this._nbrImpressionFacture = nbrImpressionFacture;
            this._imprimerStockVisuelle = imprimerStockVisuelle;
            this._stockParFournisseur = stockParFournisseur;
            this._intervalheure = intervalheure;
            this._intervalminutes = intervalminutes;
            this._intervalminutesRetard = intervalminutesRetard;
            this._supprimerPaiement = supprimerPaiement;
            this._imprimerTransfert = imprimerTransfert;
            this._imprimanteTransfert = imprimanteTransfert;
            this._minSpend = minSpend;
            this._valMinSpend = valMinSpend;
        }
    }

    // Token: 0x02000239 RID: 569
    public class ModePaiement
    {
        // Token: 0x170009D8 RID: 2520
        // (get) Token: 0x06002762 RID: 10082 RVA: 0x00146F06 File Offset: 0x00145106
        // (set) Token: 0x06002763 RID: 10083 RVA: 0x00146F0E File Offset: 0x0014510E
        public int _id { get; set; }

        // Token: 0x170009D9 RID: 2521
        // (get) Token: 0x06002764 RID: 10084 RVA: 0x00146F17 File Offset: 0x00145117
        // (set) Token: 0x06002765 RID: 10085 RVA: 0x00146F1F File Offset: 0x0014511F
        public string _libelle { get; set; }

        // Token: 0x170009DA RID: 2522
        // (get) Token: 0x06002766 RID: 10086 RVA: 0x00146F28 File Offset: 0x00145128
        // (set) Token: 0x06002767 RID: 10087 RVA: 0x00146F30 File Offset: 0x00145130
        public int _ordre { get; set; }

        // Token: 0x170009DB RID: 2523
        // (get) Token: 0x06002768 RID: 10088 RVA: 0x00146F39 File Offset: 0x00145139
        // (set) Token: 0x06002769 RID: 10089 RVA: 0x00146F41 File Offset: 0x00145141
        public PointDeVente _pointDeVente { get; set; }

        // Token: 0x170009DC RID: 2524
        // (get) Token: 0x0600276A RID: 10090 RVA: 0x00146F4A File Offset: 0x0014514A
        // (set) Token: 0x0600276B RID: 10091 RVA: 0x00146F52 File Offset: 0x00145152
        public string _type { get; set; }

        // Token: 0x170009DD RID: 2525
        // (get) Token: 0x0600276C RID: 10092 RVA: 0x00146F5B File Offset: 0x0014515B
        // (set) Token: 0x0600276D RID: 10093 RVA: 0x00146F63 File Offset: 0x00145163
        public string _couleur { get; set; }

        // Token: 0x170009DE RID: 2526
        // (get) Token: 0x0600276E RID: 10094 RVA: 0x00146F6C File Offset: 0x0014516C
        // (set) Token: 0x0600276F RID: 10095 RVA: 0x00146F74 File Offset: 0x00145174
        public bool _etat { get; set; }

        // Token: 0x170009DF RID: 2527
        // (get) Token: 0x06002770 RID: 10096 RVA: 0x00146F7D File Offset: 0x0014517D
        // (set) Token: 0x06002771 RID: 10097 RVA: 0x00146F85 File Offset: 0x00145185
        public Imprimante _imprimante { get; set; }

        // Token: 0x170009E0 RID: 2528
        // (get) Token: 0x06002772 RID: 10098 RVA: 0x00146F8E File Offset: 0x0014518E
        // (set) Token: 0x06002773 RID: 10099 RVA: 0x00146F96 File Offset: 0x00145196
        public decimal _commission { get; set; }

        // Token: 0x170009E1 RID: 2529
        // (get) Token: 0x06002774 RID: 10100 RVA: 0x00146F9F File Offset: 0x0014519F
        // (set) Token: 0x06002775 RID: 10101 RVA: 0x00146FA7 File Offset: 0x001451A7
        public Zone _zone { get; set; }

        // Token: 0x06002776 RID: 10102 RVA: 0x00146FB0 File Offset: 0x001451B0
        public ModePaiement()
        {
            this._id = 0;
            this._libelle = "";
            this._ordre = 0;
            this._pointDeVente = new PointDeVente();
            this._type = "";
            this._couleur = "";
            this._etat = false;
            this._imprimante = new Imprimante();
            this._commission = 0m;
            this._zone = new Zone();
        }

        // Token: 0x06002777 RID: 10103 RVA: 0x00147028 File Offset: 0x00145228
        public ModePaiement(int id, string libelle, int ordre, PointDeVente pointDeVente, string type, string couleur, bool etat, Imprimante imprimante, decimal commission, Zone zone)
        {
            this._id = id;
            this._libelle = libelle;
            this._ordre = ordre;
            this._pointDeVente = pointDeVente;
            this._type = type;
            this._couleur = couleur;
            this._etat = etat;
            this._imprimante = imprimante;
            this._commission = commission;
            this._zone = zone;
        }
    }
    public class FamilleCarte
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00037438 File Offset: 0x00035638
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00037440 File Offset: 0x00035640
		public int _id { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00037449 File Offset: 0x00035649
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00037451 File Offset: 0x00035651
		public string _libelle { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0003745A File Offset: 0x0003565A
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00037462 File Offset: 0x00035662
		public PointDeVente _pointDeVente { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0003746B File Offset: 0x0003566B
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00037473 File Offset: 0x00035673
		public List<Produit> _listProduit { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0003747C File Offset: 0x0003567C
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00037484 File Offset: 0x00035684
		public int _ordre { get; set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0003748D File Offset: 0x0003568D
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00037495 File Offset: 0x00035695
		public string _couleur { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0003749E File Offset: 0x0003569E
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x000374A6 File Offset: 0x000356A6
		public bool _etat { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000374AF File Offset: 0x000356AF
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x000374B7 File Offset: 0x000356B7
		public bool _msgObligatoire { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000374C0 File Offset: 0x000356C0
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x000374C8 File Offset: 0x000356C8
		public FamilleMessage _familleMessage { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000374D1 File Offset: 0x000356D1
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000374D9 File Offset: 0x000356D9
		public CategorieCarte _categorieCarte { get; set; }

		// Token: 0x06000626 RID: 1574 RVA: 0x000374E4 File Offset: 0x000356E4
		public FamilleCarte()
		{
			this._id = 0;
			this._libelle = "";
			this._pointDeVente = new PointDeVente();
			this._listProduit = new List<Produit>();
			this._ordre = 0;
			this._couleur = "";
			this._etat = false;
			this._msgObligatoire = false;
			this._familleMessage = new FamilleMessage();
			this._categorieCarte = new CategorieCarte();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00037558 File Offset: 0x00035758
		public FamilleCarte(int id)
		{
			this._id = id;
			this._libelle = "";
			this._pointDeVente = new PointDeVente();
			this._listProduit = new List<Produit>();
			this._ordre = 0;
			this._couleur = "";
			this._etat = false;
			this._msgObligatoire = false;
			this._familleMessage = new FamilleMessage();
			this._categorieCarte = new CategorieCarte();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000375CC File Offset: 0x000357CC
		public FamilleCarte(int id, string libelle)
		{
			this._id = id;
			this._libelle = libelle;
			this._pointDeVente = new PointDeVente();
			this._listProduit = new List<Produit>();
			this._ordre = 0;
			this._couleur = "";
			this._etat = false;
			this._msgObligatoire = false;
			this._familleMessage = new FamilleMessage();
			this._categorieCarte = new CategorieCarte();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0003763C File Offset: 0x0003583C
		public FamilleCarte(int id, string libelle, PointDeVente pointDeVente, List<Produit> listProduit, int ordre, string couleur, bool etat, bool msgObligatoire, FamilleMessage familleMessage, CategorieCarte categorieCarte)
		{
			this._id = id;
			this._libelle = libelle;
			this._pointDeVente = pointDeVente;
			this._listProduit = listProduit;
			this._ordre = ordre;
			this._couleur = couleur;
			this._etat = etat;
			this._msgObligatoire = msgObligatoire;
			this._familleMessage = familleMessage;
			this._categorieCarte = categorieCarte;
		}

        // Token: 0x0200013E RID: 318
        public class FamilleMessage
        {
            // Token: 0x170005A3 RID: 1443
            // (get) Token: 0x06001603 RID: 5635 RVA: 0x000BADD8 File Offset: 0x000B8FD8
            // (set) Token: 0x06001604 RID: 5636 RVA: 0x000BADE0 File Offset: 0x000B8FE0
            public int _id { get; set; }

            // Token: 0x170005A4 RID: 1444
            // (get) Token: 0x06001605 RID: 5637 RVA: 0x000BADE9 File Offset: 0x000B8FE9
            // (set) Token: 0x06001606 RID: 5638 RVA: 0x000BADF1 File Offset: 0x000B8FF1
            public string _libelle { get; set; }

            // Token: 0x170005A5 RID: 1445
            // (get) Token: 0x06001607 RID: 5639 RVA: 0x000BADFA File Offset: 0x000B8FFA
            // (set) Token: 0x06001608 RID: 5640 RVA: 0x000BAE02 File Offset: 0x000B9002
            public bool _etat { get; set; }

            // Token: 0x170005A6 RID: 1446
            // (get) Token: 0x06001609 RID: 5641 RVA: 0x000BAE0B File Offset: 0x000B900B
            // (set) Token: 0x0600160A RID: 5642 RVA: 0x000BAE13 File Offset: 0x000B9013
            public List<MessageRapide> _listMessageRapide { get; set; }

            // Token: 0x0600160B RID: 5643 RVA: 0x000BAE1C File Offset: 0x000B901C
            public FamilleMessage()
            {
                this._id = 0;
                this._libelle = "";
                this._listMessageRapide = new List<MessageRapide>();
                this._etat = false;
            }

            // Token: 0x0600160C RID: 5644 RVA: 0x000BAE48 File Offset: 0x000B9048
            public FamilleMessage(int id, string libelle, bool etat)
            {
                this._id = id;
                this._listMessageRapide = new List<MessageRapide>();
                this._libelle = libelle;
                this._etat = etat;
            }

            // Token: 0x0600160D RID: 5645 RVA: 0x000BAE70 File Offset: 0x000B9070
            public FamilleMessage(int id, string libelle, List<MessageRapide> listMessageRapide, bool etat)
            {
                this._id = id;
                this._listMessageRapide = listMessageRapide;
                this._libelle = libelle;
                this._etat = etat;
            }
        }
        // Token: 0x02000194 RID: 404
        public class MessageRapide
        {
            // Token: 0x17000739 RID: 1849
            // (get) Token: 0x06001C02 RID: 7170 RVA: 0x000E98CB File Offset: 0x000E7ACB
            // (set) Token: 0x06001C03 RID: 7171 RVA: 0x000E98D3 File Offset: 0x000E7AD3
            public int _id { get; set; }

            // Token: 0x1700073A RID: 1850
            // (get) Token: 0x06001C04 RID: 7172 RVA: 0x000E98DC File Offset: 0x000E7ADC
            // (set) Token: 0x06001C05 RID: 7173 RVA: 0x000E98E4 File Offset: 0x000E7AE4
            public string _message { get; set; }

            // Token: 0x1700073B RID: 1851
            // (get) Token: 0x06001C06 RID: 7174 RVA: 0x000E98ED File Offset: 0x000E7AED
            // (set) Token: 0x06001C07 RID: 7175 RVA: 0x000E98F5 File Offset: 0x000E7AF5
            public PointDeVente _pointDeVente { get; set; }

            // Token: 0x1700073C RID: 1852
            // (get) Token: 0x06001C08 RID: 7176 RVA: 0x000E98FE File Offset: 0x000E7AFE
            // (set) Token: 0x06001C09 RID: 7177 RVA: 0x000E9906 File Offset: 0x000E7B06
            public bool _etat { get; set; }

            // Token: 0x1700073D RID: 1853
            // (get) Token: 0x06001C0A RID: 7178 RVA: 0x000E990F File Offset: 0x000E7B0F
            // (set) Token: 0x06001C0B RID: 7179 RVA: 0x000E9917 File Offset: 0x000E7B17
            public string _couleur { get; set; }

            // Token: 0x1700073E RID: 1854
            // (get) Token: 0x06001C0C RID: 7180 RVA: 0x000E9920 File Offset: 0x000E7B20
            // (set) Token: 0x06001C0D RID: 7181 RVA: 0x000E9928 File Offset: 0x000E7B28
            public FamilleMessage _familleMessage { get; set; }

            // Token: 0x06001C0E RID: 7182 RVA: 0x000E9934 File Offset: 0x000E7B34
            public MessageRapide()
            {
                this._id = 0;
                this._message = "";
                this._pointDeVente = new PointDeVente();
                this._etat = false;
                this._couleur = "White";
                this._familleMessage = new FamilleMessage();
            }

            // Token: 0x06001C0F RID: 7183 RVA: 0x000E9981 File Offset: 0x000E7B81
            public MessageRapide(int id, string message, PointDeVente pointDeVente, bool etat, string couleur, FamilleMessage familleMessage)
            {
                this._id = id;
                this._message = message;
                this._pointDeVente = pointDeVente;
                this._etat = etat;
                this._couleur = couleur;
                this._familleMessage = familleMessage;
            }
        }
    }

    public class CategorieCarte
    {
        // Token: 0x17000F3B RID: 3899
        // (get) Token: 0x06003988 RID: 14728 RVA: 0x001AFAD5 File Offset: 0x001ADCD5
        // (set) Token: 0x06003989 RID: 14729 RVA: 0x001AFADD File Offset: 0x001ADCDD
        public int _id { get; set; }

        // Token: 0x17000F3C RID: 3900
        // (get) Token: 0x0600398A RID: 14730 RVA: 0x001AFAE6 File Offset: 0x001ADCE6
        // (set) Token: 0x0600398B RID: 14731 RVA: 0x001AFAEE File Offset: 0x001ADCEE
        public string _libelle { get; set; }

        // Token: 0x17000F3D RID: 3901
        // (get) Token: 0x0600398C RID: 14732 RVA: 0x001AFAF7 File Offset: 0x001ADCF7
        // (set) Token: 0x0600398D RID: 14733 RVA: 0x001AFAFF File Offset: 0x001ADCFF
        public PointDeVente _pointDeVente { get; set; }

        // Token: 0x17000F3E RID: 3902
        // (get) Token: 0x0600398E RID: 14734 RVA: 0x001AFB08 File Offset: 0x001ADD08
        // (set) Token: 0x0600398F RID: 14735 RVA: 0x001AFB10 File Offset: 0x001ADD10
        public bool _etat { get; set; }

        // Token: 0x17000F3F RID: 3903
        // (get) Token: 0x06003990 RID: 14736 RVA: 0x001AFB19 File Offset: 0x001ADD19
        // (set) Token: 0x06003991 RID: 14737 RVA: 0x001AFB21 File Offset: 0x001ADD21
        public string _couleur { get; set; }

        // Token: 0x17000F40 RID: 3904
        // (get) Token: 0x06003992 RID: 14738 RVA: 0x001AFB2A File Offset: 0x001ADD2A
        // (set) Token: 0x06003993 RID: 14739 RVA: 0x001AFB32 File Offset: 0x001ADD32
        public int _ordre { get; set; }

        // Token: 0x06003994 RID: 14740 RVA: 0x001AFB3B File Offset: 0x001ADD3B
        public CategorieCarte()
        {
            this._id = 0;
            this._libelle = "";
            this._pointDeVente = new PointDeVente();
            this._etat = false;
            this._couleur = "White";
            this._ordre = 0;
        }

        // Token: 0x06003995 RID: 14741 RVA: 0x001AFB79 File Offset: 0x001ADD79
        public CategorieCarte(int id, string libelle, PointDeVente pointDeVente, bool etat, string couleur, int ordre)
        {
            this._id = id;
            this._libelle = libelle;
            this._pointDeVente = pointDeVente;
            this._etat = etat;
            this._couleur = couleur;
            this._ordre = ordre;
        }
    }

    // Token: 0x0200037F RID: 895
    public class Produit
    {
        // Token: 0x17001055 RID: 4181
        // (get) Token: 0x06003D6C RID: 15724 RVA: 0x001CC20C File Offset: 0x001CA40C
        // (set) Token: 0x06003D6D RID: 15725 RVA: 0x001CC214 File Offset: 0x001CA414
        public int _id { get; set; }

        // Token: 0x17001056 RID: 4182
        // (get) Token: 0x06003D6E RID: 15726 RVA: 0x001CC21D File Offset: 0x001CA41D
        // (set) Token: 0x06003D6F RID: 15727 RVA: 0x001CC225 File Offset: 0x001CA425
        public string _libelle { get; set; }

        // Token: 0x17001057 RID: 4183
        // (get) Token: 0x06003D70 RID: 15728 RVA: 0x001CC22E File Offset: 0x001CA42E
        // (set) Token: 0x06003D71 RID: 15729 RVA: 0x001CC236 File Offset: 0x001CA436
        public string _type { get; set; }

        // Token: 0x17001058 RID: 4184
        // (get) Token: 0x06003D72 RID: 15730 RVA: 0x001CC23F File Offset: 0x001CA43F
        // (set) Token: 0x06003D73 RID: 15731 RVA: 0x001CC247 File Offset: 0x001CA447
        public Categorie _categorie { get; set; }

        // Token: 0x17001059 RID: 4185
        // (get) Token: 0x06003D74 RID: 15732 RVA: 0x001CC250 File Offset: 0x001CA450
        // (set) Token: 0x06003D75 RID: 15733 RVA: 0x001CC258 File Offset: 0x001CA458
        public decimal _prix { get; set; }

        // Token: 0x1700105A RID: 4186
        // (get) Token: 0x06003D76 RID: 15734 RVA: 0x001CC261 File Offset: 0x001CA461
        // (set) Token: 0x06003D77 RID: 15735 RVA: 0x001CC269 File Offset: 0x001CA469
        public decimal _prixAchat { get; set; }

        // Token: 0x1700105B RID: 4187
        // (get) Token: 0x06003D78 RID: 15736 RVA: 0x001CC272 File Offset: 0x001CA472
        // (set) Token: 0x06003D79 RID: 15737 RVA: 0x001CC27A File Offset: 0x001CA47A
        public decimal _ratioMultiplicateur { get; set; }

        // Token: 0x1700105C RID: 4188
        // (get) Token: 0x06003D7A RID: 15738 RVA: 0x001CC283 File Offset: 0x001CA483
        // (set) Token: 0x06003D7B RID: 15739 RVA: 0x001CC28B File Offset: 0x001CA48B
        public Tva _tva { get; set; }

        // Token: 0x1700105D RID: 4189
        // (get) Token: 0x06003D7C RID: 15740 RVA: 0x001CC294 File Offset: 0x001CA494
        // (set) Token: 0x06003D7D RID: 15741 RVA: 0x001CC29C File Offset: 0x001CA49C
        public FamilleCarte _familleCarte { get; set; }

        // Token: 0x1700105E RID: 4190
        // (get) Token: 0x06003D7E RID: 15742 RVA: 0x001CC2A5 File Offset: 0x001CA4A5
        // (set) Token: 0x06003D7F RID: 15743 RVA: 0x001CC2AD File Offset: 0x001CA4AD
        public string _codeBarre { get; set; }

        // Token: 0x1700105F RID: 4191
        // (get) Token: 0x06003D80 RID: 15744 RVA: 0x001CC2B6 File Offset: 0x001CA4B6
        // (set) Token: 0x06003D81 RID: 15745 RVA: 0x001CC2BE File Offset: 0x001CA4BE
        public Imprimante _imprimante { get; set; }

        // Token: 0x17001060 RID: 4192
        // (get) Token: 0x06003D82 RID: 15746 RVA: 0x001CC2C7 File Offset: 0x001CA4C7
        // (set) Token: 0x06003D83 RID: 15747 RVA: 0x001CC2CF File Offset: 0x001CA4CF
        public bool _composer { get; set; }

        // Token: 0x17001061 RID: 4193
        // (get) Token: 0x06003D84 RID: 15748 RVA: 0x001CC2D8 File Offset: 0x001CA4D8
        // (set) Token: 0x06003D85 RID: 15749 RVA: 0x001CC2E0 File Offset: 0x001CA4E0
        public bool _imprimerComposant { get; set; }

        // Token: 0x17001062 RID: 4194
        // (get) Token: 0x06003D86 RID: 15750 RVA: 0x001CC2E9 File Offset: 0x001CA4E9
        // (set) Token: 0x06003D87 RID: 15751 RVA: 0x001CC2F1 File Offset: 0x001CA4F1
        public int _nbrPortion { get; set; }

        // Token: 0x17001063 RID: 4195
        // (get) Token: 0x06003D88 RID: 15752 RVA: 0x001CC2FA File Offset: 0x001CA4FA
        // (set) Token: 0x06003D89 RID: 15753 RVA: 0x001CC302 File Offset: 0x001CA502
        public bool _accompagnement { get; set; }

        // Token: 0x17001064 RID: 4196
        // (get) Token: 0x06003D8A RID: 15754 RVA: 0x001CC30B File Offset: 0x001CA50B
        // (set) Token: 0x06003D8B RID: 15755 RVA: 0x001CC313 File Offset: 0x001CA513
        public int _ordre { get; set; }

        // Token: 0x17001065 RID: 4197
        // (get) Token: 0x06003D8C RID: 15756 RVA: 0x001CC31C File Offset: 0x001CA51C
        // (set) Token: 0x06003D8D RID: 15757 RVA: 0x001CC324 File Offset: 0x001CA524
        public bool _etat { get; set; }

        // Token: 0x17001066 RID: 4198
        // (get) Token: 0x06003D8E RID: 15758 RVA: 0x001CC32D File Offset: 0x001CA52D
        // (set) Token: 0x06003D8F RID: 15759 RVA: 0x001CC335 File Offset: 0x001CA535
        public FamilleMessage _familleMessage { get; set; }

        // Token: 0x17001067 RID: 4199
        // (get) Token: 0x06003D90 RID: 15760 RVA: 0x001CC33E File Offset: 0x001CA53E
        // (set) Token: 0x06003D91 RID: 15761 RVA: 0x001CC346 File Offset: 0x001CA546
        public string _couleur { get; set; }

        // Token: 0x17001068 RID: 4200
        // (get) Token: 0x06003D92 RID: 15762 RVA: 0x001CC34F File Offset: 0x001CA54F
        // (set) Token: 0x06003D93 RID: 15763 RVA: 0x001CC357 File Offset: 0x001CA557
        public bool _prixManuel { get; set; }

        // Token: 0x17001069 RID: 4201
        // (get) Token: 0x06003D94 RID: 15764 RVA: 0x001CC360 File Offset: 0x001CA560
        // (set) Token: 0x06003D95 RID: 15765 RVA: 0x001CC368 File Offset: 0x001CA568
        public string _img { get; set; }

        // Token: 0x1700106A RID: 4202
        // (get) Token: 0x06003D96 RID: 15766 RVA: 0x001CC371 File Offset: 0x001CA571
        // (set) Token: 0x06003D97 RID: 15767 RVA: 0x001CC379 File Offset: 0x001CA579
        public byte[] _img64 { get; set; }

        // Token: 0x1700106B RID: 4203
        // (get) Token: 0x06003D98 RID: 15768 RVA: 0x001CC382 File Offset: 0x001CA582
        // (set) Token: 0x06003D99 RID: 15769 RVA: 0x001CC38A File Offset: 0x001CA58A
        public string _description { get; set; }

        // Token: 0x1700106C RID: 4204
        // (get) Token: 0x06003D9A RID: 15770 RVA: 0x001CC393 File Offset: 0x001CA593
        // (set) Token: 0x06003D9B RID: 15771 RVA: 0x001CC39B File Offset: 0x001CA59B
        public decimal _prix0 { get; set; }

        // Token: 0x1700106D RID: 4205
        // (get) Token: 0x06003D9C RID: 15772 RVA: 0x001CC3A4 File Offset: 0x001CA5A4
        // (set) Token: 0x06003D9D RID: 15773 RVA: 0x001CC3AC File Offset: 0x001CA5AC
        public decimal _prix1 { get; set; }

        // Token: 0x1700106E RID: 4206
        // (get) Token: 0x06003D9E RID: 15774 RVA: 0x001CC3B5 File Offset: 0x001CA5B5
        // (set) Token: 0x06003D9F RID: 15775 RVA: 0x001CC3BD File Offset: 0x001CA5BD
        public decimal _prix2 { get; set; }

        // Token: 0x1700106F RID: 4207
        // (get) Token: 0x06003DA0 RID: 15776 RVA: 0x001CC3C6 File Offset: 0x001CA5C6
        // (set) Token: 0x06003DA1 RID: 15777 RVA: 0x001CC3CE File Offset: 0x001CA5CE
        public decimal _prix3 { get; set; }

        // Token: 0x17001070 RID: 4208
        // (get) Token: 0x06003DA2 RID: 15778 RVA: 0x001CC3D7 File Offset: 0x001CA5D7
        // (set) Token: 0x06003DA3 RID: 15779 RVA: 0x001CC3DF File Offset: 0x001CA5DF
        public decimal _prix4 { get; set; }

        // Token: 0x17001071 RID: 4209
        // (get) Token: 0x06003DA4 RID: 15780 RVA: 0x001CC3E8 File Offset: 0x001CA5E8
        // (set) Token: 0x06003DA5 RID: 15781 RVA: 0x001CC3F0 File Offset: 0x001CA5F0
        public decimal _prix5 { get; set; }

        // Token: 0x17001072 RID: 4210
        // (get) Token: 0x06003DA6 RID: 15782 RVA: 0x001CC3F9 File Offset: 0x001CA5F9
        // (set) Token: 0x06003DA7 RID: 15783 RVA: 0x001CC401 File Offset: 0x001CA601
        public decimal _qteVisuelle { get; set; }

        // Token: 0x17001073 RID: 4211
        // (get) Token: 0x06003DA8 RID: 15784 RVA: 0x001CC40A File Offset: 0x001CA60A
        // (set) Token: 0x06003DA9 RID: 15785 RVA: 0x001CC412 File Offset: 0x001CA612
        public decimal _qteVente { get; set; }

        // Token: 0x17001074 RID: 4212
        // (get) Token: 0x06003DAA RID: 15786 RVA: 0x001CC41B File Offset: 0x001CA61B
        // (set) Token: 0x06003DAB RID: 15787 RVA: 0x001CC423 File Offset: 0x001CA623
        public bool _prixparqte { get; set; }

        // Token: 0x17001075 RID: 4213
        // (get) Token: 0x06003DAC RID: 15788 RVA: 0x001CC42C File Offset: 0x001CA62C
        // (set) Token: 0x06003DAD RID: 15789 RVA: 0x001CC434 File Offset: 0x001CA634
        public Imprimante _imprimante2 { get; set; }

        // Token: 0x17001076 RID: 4214
        // (get) Token: 0x06003DAE RID: 15790 RVA: 0x001CC43D File Offset: 0x001CA63D
        // (set) Token: 0x06003DAF RID: 15791 RVA: 0x001CC445 File Offset: 0x001CA645
        public List<ComposantProduit> _listeComposantProduit { get; set; }

        // Token: 0x17001077 RID: 4215
        // (get) Token: 0x06003DB0 RID: 15792 RVA: 0x001CC44E File Offset: 0x001CA64E
        // (set) Token: 0x06003DB1 RID: 15793 RVA: 0x001CC456 File Offset: 0x001CA656
        public Imprimante _imprimante3 { get; set; }

        // Token: 0x17001078 RID: 4216
        // (get) Token: 0x06003DB2 RID: 15794 RVA: 0x001CC45F File Offset: 0x001CA65F
        // (set) Token: 0x06003DB3 RID: 15795 RVA: 0x001CC467 File Offset: 0x001CA667
        public Imprimante _imprimante4 { get; set; }

        // Token: 0x17001079 RID: 4217
        // (get) Token: 0x06003DB4 RID: 15796 RVA: 0x001CC470 File Offset: 0x001CA670
        // (set) Token: 0x06003DB5 RID: 15797 RVA: 0x001CC478 File Offset: 0x001CA678
        public int _idPrestation { get; set; }

        // Token: 0x06003DB6 RID: 15798 RVA: 0x001CC484 File Offset: 0x001CA684
        public Produit()
        {
            this._id = 0;
            this._libelle = "";
            this._type = "";
            this._categorie = new Categorie();
            this._prix = (this._prix0 = (this._prix1 = (this._prix2 = (this._prix3 = (this._prix4 = (this._prix5 = 0m))))));
            this._prixAchat = 0m;
            this._ratioMultiplicateur = 0m;
            this._tva = new Tva();
            this._familleCarte = new FamilleCarte();
            this._codeBarre = "";
            this._imprimante = new Imprimante();
            this._composer = false;
            this._imprimerComposant = false;
            this._nbrPortion = 0;
            this._accompagnement = false;
            this._ordre = 0;
            this._etat = false;
            this._familleMessage = new FamilleMessage();
            this._couleur = "control";
            this._prixManuel = false;
            this._img = "";
            this._description = "";
            this._qteVisuelle = 0m;
            this._qteVente = 0m;
            this._prixparqte = false;
            this._imprimante2 = new Imprimante();
            this._listeComposantProduit = new List<ComposantProduit>();
            this._imprimante3 = new Imprimante();
            this._imprimante4 = new Imprimante();
            this._idPrestation = 0;
        }

        // Token: 0x06003DB7 RID: 15799 RVA: 0x001CC5F8 File Offset: 0x001CA7F8
        public Produit(int id, string codeBarre, string libelle)
        {
            this._id = id;
            this._libelle = libelle;
            this._type = "";
            this._categorie = new Categorie();
            this._prix = (this._prix0 = (this._prix1 = (this._prix2 = (this._prix3 = (this._prix4 = (this._prix5 = 0m))))));
            this._prixAchat = 0m;
            this._ratioMultiplicateur = 0m;
            this._tva = new Tva();
            this._familleCarte = new FamilleCarte();
            this._codeBarre = codeBarre;
            this._imprimante = new Imprimante();
            this._composer = false;
            this._imprimerComposant = false;
            this._nbrPortion = 0;
            this._accompagnement = false;
            this._ordre = 0;
            this._etat = false;
            this._familleMessage = new FamilleMessage();
            this._couleur = "control";
            this._prixManuel = false;
            this._img = "";
            this._description = "";
            this._qteVisuelle = 0m;
            this._qteVente = 0m;
            this._prixparqte = false;
            this._imprimante2 = new Imprimante();
            this._listeComposantProduit = new List<ComposantProduit>();
            this._imprimante3 = new Imprimante();
            this._imprimante4 = new Imprimante();
            this._idPrestation = 0;
        }

        // Token: 0x06003DB8 RID: 15800 RVA: 0x001CC764 File Offset: 0x001CA964
        public Produit(int id, string libelle, string type, Categorie categorie, decimal prix, decimal prixAchat, decimal ratioMultiplicateur, Tva tva, FamilleCarte familleCarte, string codeBarre, Imprimante imprimante, bool composer, bool imprimerComposant, int nbrPortion, bool accompagnement, int ordre, bool etat, FamilleMessage familleMessage, string couleur, bool prixManuel, string img, string description, decimal prix1, decimal prix2, decimal prix3, decimal prix4, decimal prix5, decimal qteVisuelle, decimal qteVente, bool prixparqte, Imprimante imprimante2, List<ComposantProduit> listeComposantProduit, Imprimante imprimante3, Imprimante imprimante4, int idPrestation)
        {
            this._id = id;
            this._libelle = libelle;
            this._type = type;
            this._categorie = categorie;
            this._prix0 = prix;
            this._prix = prix;
            this._prix1 = prix1;
            this._prix2 = prix2;
            this._prix3 = prix3;
            this._prix4 = prix4;
            this._prix5 = prix5;
            this._prixAchat = prixAchat;
            this._ratioMultiplicateur = ratioMultiplicateur;
            this._tva = tva;
            this._familleCarte = familleCarte;
            this._codeBarre = codeBarre;
            this._imprimante = imprimante;
            this._composer = composer;
            this._imprimerComposant = imprimerComposant;
            this._nbrPortion = nbrPortion;
            this._accompagnement = accompagnement;
            this._ordre = ordre;
            this._etat = etat;
            this._familleMessage = familleMessage;
            this._couleur = couleur;
            this._prixManuel = prixManuel;
            this._img = img;
            this._description = description;
            this._qteVisuelle = qteVisuelle;
            this._qteVente = qteVente;
            this._prixparqte = prixparqte;
            this._imprimante2 = imprimante2;
            this._listeComposantProduit = listeComposantProduit;
            if (this._img.Length != 0)
            {
                this._img64 = Convert.FromBase64String(this._img);
            }
            this._imprimante3 = imprimante3;
            this._imprimante4 = imprimante4;
            this._idPrestation = idPrestation;
        }
    }
    // Token: 0x020000F3 RID: 243
    public class Imprimante
    {
        // Token: 0x17000422 RID: 1058
        // (get) Token: 0x0600100A RID: 4106 RVA: 0x000938D7 File Offset: 0x00091AD7
        // (set) Token: 0x0600100B RID: 4107 RVA: 0x000938DF File Offset: 0x00091ADF
        public int _id { get; set; }

        // Token: 0x17000423 RID: 1059
        // (get) Token: 0x0600100C RID: 4108 RVA: 0x000938E8 File Offset: 0x00091AE8
        // (set) Token: 0x0600100D RID: 4109 RVA: 0x000938F0 File Offset: 0x00091AF0
        public string _libelle { get; set; }

        // Token: 0x17000424 RID: 1060
        // (get) Token: 0x0600100E RID: 4110 RVA: 0x000938F9 File Offset: 0x00091AF9
        // (set) Token: 0x0600100F RID: 4111 RVA: 0x00093901 File Offset: 0x00091B01
        public string _nomImprimante { get; set; }

        // Token: 0x17000425 RID: 1061
        // (get) Token: 0x06001010 RID: 4112 RVA: 0x0009390A File Offset: 0x00091B0A
        // (set) Token: 0x06001011 RID: 4113 RVA: 0x00093912 File Offset: 0x00091B12
        public bool _imprimerDetail { get; set; }

        // Token: 0x17000426 RID: 1062
        // (get) Token: 0x06001012 RID: 4114 RVA: 0x0009391B File Offset: 0x00091B1B
        // (set) Token: 0x06001013 RID: 4115 RVA: 0x00093923 File Offset: 0x00091B23
        public bool _etat { get; set; }

        // Token: 0x17000427 RID: 1063
        // (get) Token: 0x06001014 RID: 4116 RVA: 0x0009392C File Offset: 0x00091B2C
        // (set) Token: 0x06001015 RID: 4117 RVA: 0x00093934 File Offset: 0x00091B34
        public int _nombrecommande { get; set; }

        // Token: 0x17000428 RID: 1064
        // (get) Token: 0x06001016 RID: 4118 RVA: 0x0009393D File Offset: 0x00091B3D
        // (set) Token: 0x06001017 RID: 4119 RVA: 0x00093945 File Offset: 0x00091B45
        public bool _kitchenDisplay { get; set; }

        // Token: 0x17000429 RID: 1065
        // (get) Token: 0x06001018 RID: 4120 RVA: 0x0009394E File Offset: 0x00091B4E
        // (set) Token: 0x06001019 RID: 4121 RVA: 0x00093956 File Offset: 0x00091B56
        public string _ecran { get; set; }

        // Token: 0x0600101A RID: 4122 RVA: 0x00093960 File Offset: 0x00091B60
        public Imprimante()
        {
            this._id = 0;
            this._libelle = "";
            this._nomImprimante = "";
            this._imprimerDetail = false;
            this._nombrecommande = 0;
            this._etat = false;
            this._kitchenDisplay = false;
            this._ecran = "";
        }

        // Token: 0x0600101B RID: 4123 RVA: 0x000939B8 File Offset: 0x00091BB8
        public Imprimante(int id, string libelle, string nomImprimante, bool imprimerDetail, bool etat, int nombrecommande, bool kitchenDisplay, string ecran)
        {
            this._id = id;
            this._libelle = libelle;
            this._nomImprimante = nomImprimante;
            this._imprimerDetail = imprimerDetail;
            this._nombrecommande = nombrecommande;
            this._etat = etat;
            this._kitchenDisplay = kitchenDisplay;
            this._ecran = ecran;
        }
    }
    public class ComposantProduit
    {
        // Token: 0x170005AE RID: 1454
        // (get) Token: 0x0600161E RID: 5662 RVA: 0x000BAF9D File Offset: 0x000B919D
        // (set) Token: 0x0600161F RID: 5663 RVA: 0x000BAFA5 File Offset: 0x000B91A5
        public Produit _produit { get; set; }

        // Token: 0x170005AF RID: 1455
        // (get) Token: 0x06001620 RID: 5664 RVA: 0x000BAFAE File Offset: 0x000B91AE
        // (set) Token: 0x06001621 RID: 5665 RVA: 0x000BAFB6 File Offset: 0x000B91B6
        public FamilleMenu _familleMenu { get; set; }

        // Token: 0x170005B0 RID: 1456
        // (get) Token: 0x06001622 RID: 5666 RVA: 0x000BAFBF File Offset: 0x000B91BF
        // (set) Token: 0x06001623 RID: 5667 RVA: 0x000BAFC7 File Offset: 0x000B91C7
        public int _nombreProduit { get; set; }

        // Token: 0x170005B1 RID: 1457
        // (get) Token: 0x06001624 RID: 5668 RVA: 0x000BAFD0 File Offset: 0x000B91D0
        // (set) Token: 0x06001625 RID: 5669 RVA: 0x000BAFD8 File Offset: 0x000B91D8
        public bool _obligatoire { get; set; }

        // Token: 0x170005B2 RID: 1458
        // (get) Token: 0x06001626 RID: 5670 RVA: 0x000BAFE1 File Offset: 0x000B91E1
        // (set) Token: 0x06001627 RID: 5671 RVA: 0x000BAFE9 File Offset: 0x000B91E9
        public bool _deleted { get; set; }

        // Token: 0x06001628 RID: 5672 RVA: 0x000BAFF2 File Offset: 0x000B91F2
        public ComposantProduit()
        {
            this._produit = new Produit();
            this._familleMenu = new FamilleMenu();
            this._nombreProduit = 0;
            this._obligatoire = false;
            this._deleted = false;
        }

        // Token: 0x06001629 RID: 5673 RVA: 0x000BB025 File Offset: 0x000B9225
        public ComposantProduit(Produit produit, FamilleMenu familleMenu, int nombreProduit, bool obligatoire)
        {
            this._produit = produit;
            this._familleMenu = familleMenu;
            this._nombreProduit = nombreProduit;
            this._obligatoire = obligatoire;
            this._deleted = false;
        }
    }

    // Token: 0x020001EA RID: 490
    public class FamilleMenu
    {
        // Token: 0x170008AE RID: 2222
        // (get) Token: 0x06002217 RID: 8727 RVA: 0x00117D7F File Offset: 0x00115F7F
        // (set) Token: 0x06002218 RID: 8728 RVA: 0x00117D87 File Offset: 0x00115F87
        public int _id { get; set; }

        // Token: 0x170008AF RID: 2223
        // (get) Token: 0x06002219 RID: 8729 RVA: 0x00117D90 File Offset: 0x00115F90
        // (set) Token: 0x0600221A RID: 8730 RVA: 0x00117D98 File Offset: 0x00115F98
        public string _libelle { get; set; }

        // Token: 0x170008B0 RID: 2224
        // (get) Token: 0x0600221B RID: 8731 RVA: 0x00117DA1 File Offset: 0x00115FA1
        // (set) Token: 0x0600221C RID: 8732 RVA: 0x00117DA9 File Offset: 0x00115FA9
        public PointDeVente _pointDeVente { get; set; }

        // Token: 0x170008B1 RID: 2225
        // (get) Token: 0x0600221D RID: 8733 RVA: 0x00117DB2 File Offset: 0x00115FB2
        // (set) Token: 0x0600221E RID: 8734 RVA: 0x00117DBA File Offset: 0x00115FBA
        public List<Produit> _listProduit { get; set; }

        // Token: 0x170008B2 RID: 2226
        // (get) Token: 0x0600221F RID: 8735 RVA: 0x00117DC3 File Offset: 0x00115FC3
        // (set) Token: 0x06002220 RID: 8736 RVA: 0x00117DCB File Offset: 0x00115FCB
        public int _ordre { get; set; }

        // Token: 0x170008B3 RID: 2227
        // (get) Token: 0x06002221 RID: 8737 RVA: 0x00117DD4 File Offset: 0x00115FD4
        // (set) Token: 0x06002222 RID: 8738 RVA: 0x00117DDC File Offset: 0x00115FDC
        public string _couleur { get; set; }

        // Token: 0x170008B4 RID: 2228
        // (get) Token: 0x06002223 RID: 8739 RVA: 0x00117DE5 File Offset: 0x00115FE5
        // (set) Token: 0x06002224 RID: 8740 RVA: 0x00117DED File Offset: 0x00115FED
        public bool _etat { get; set; }

        // Token: 0x170008B5 RID: 2229
        // (get) Token: 0x06002225 RID: 8741 RVA: 0x00117DF6 File Offset: 0x00115FF6
        // (set) Token: 0x06002226 RID: 8742 RVA: 0x00117DFE File Offset: 0x00115FFE
        public bool _msgObligatoire { get; set; }

        // Token: 0x170008B6 RID: 2230
        // (get) Token: 0x06002227 RID: 8743 RVA: 0x00117E07 File Offset: 0x00116007
        // (set) Token: 0x06002228 RID: 8744 RVA: 0x00117E0F File Offset: 0x0011600F
        public FamilleMessage _familleMessage { get; set; }

        // Token: 0x06002229 RID: 8745 RVA: 0x00117E18 File Offset: 0x00116018
        public FamilleMenu()
        {
            this._id = 0;
            this._libelle = "";
            this._pointDeVente = new PointDeVente();
            this._listProduit = new List<Produit>();
            this._ordre = 0;
            this._couleur = "";
            this._etat = false;
            this._msgObligatoire = false;
            this._familleMessage = new FamilleMessage();
        }

        // Token: 0x0600222A RID: 8746 RVA: 0x00117E80 File Offset: 0x00116080
        public FamilleMenu(int id)
        {
            this._id = id;
            this._libelle = "";
            this._pointDeVente = new PointDeVente();
            this._listProduit = new List<Produit>();
            this._ordre = 0;
            this._couleur = "";
            this._etat = false;
            this._msgObligatoire = false;
            this._familleMessage = new FamilleMessage();
        }

        // Token: 0x0600222B RID: 8747 RVA: 0x00117EE8 File Offset: 0x001160E8
        public FamilleMenu(int id, string libelle)
        {
            this._id = id;
            this._libelle = libelle;
            this._pointDeVente = new PointDeVente();
            this._listProduit = new List<Produit>();
            this._ordre = 0;
            this._couleur = "";
            this._etat = false;
            this._msgObligatoire = false;
            this._familleMessage = new FamilleMessage();
        }

        // Token: 0x0600222C RID: 8748 RVA: 0x00117F4C File Offset: 0x0011614C
        public FamilleMenu(int id, string libelle, PointDeVente pointDeVente, List<Produit> listProduit, int ordre, string couleur, bool etat, bool msgObligatoire, FamilleMessage familleMessage)
        {
            this._id = id;
            this._libelle = libelle;
            this._pointDeVente = pointDeVente;
            this._listProduit = listProduit;
            this._ordre = ordre;
            this._couleur = couleur;
            this._etat = etat;
            this._msgObligatoire = msgObligatoire;
            this._familleMessage = familleMessage;
        }
    }

    // Token: 0x02000430 RID: 1072
    public class Categorie
    {
        // Token: 0x170013B1 RID: 5041
        // (get) Token: 0x0600486D RID: 18541 RVA: 0x00222388 File Offset: 0x00220588
        // (set) Token: 0x0600486E RID: 18542 RVA: 0x00222390 File Offset: 0x00220590
        public int _id { get; set; }

        // Token: 0x170013B2 RID: 5042
        // (get) Token: 0x0600486F RID: 18543 RVA: 0x00222399 File Offset: 0x00220599
        // (set) Token: 0x06004870 RID: 18544 RVA: 0x002223A1 File Offset: 0x002205A1
        public string _code { get; set; }

        // Token: 0x170013B3 RID: 5043
        // (get) Token: 0x06004871 RID: 18545 RVA: 0x002223AA File Offset: 0x002205AA
        // (set) Token: 0x06004872 RID: 18546 RVA: 0x002223B2 File Offset: 0x002205B2
        public string _libelle { get; set; }

        // Token: 0x170013B4 RID: 5044
        // (get) Token: 0x06004873 RID: 18547 RVA: 0x002223BB File Offset: 0x002205BB
        // (set) Token: 0x06004874 RID: 18548 RVA: 0x002223C3 File Offset: 0x002205C3
        public bool _etat { get; set; }

        // Token: 0x06004875 RID: 18549 RVA: 0x002223CC File Offset: 0x002205CC
        public Categorie()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._etat = false;
        }

        // Token: 0x06004876 RID: 18550 RVA: 0x002223F8 File Offset: 0x002205F8
        public Categorie(int id, string code, string libelle, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
        }
    }


    // Token: 0x02000006 RID: 6
    public class Tva
    {
        // Token: 0x1700001C RID: 28
        // (get) Token: 0x0600003F RID: 63 RVA: 0x000024A8 File Offset: 0x000006A8
        // (set) Token: 0x06000040 RID: 64 RVA: 0x000024B0 File Offset: 0x000006B0
        public int _id { get; set; }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x06000041 RID: 65 RVA: 0x000024B9 File Offset: 0x000006B9
        // (set) Token: 0x06000042 RID: 66 RVA: 0x000024C1 File Offset: 0x000006C1
        public string _code { get; set; }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000043 RID: 67 RVA: 0x000024CA File Offset: 0x000006CA
        // (set) Token: 0x06000044 RID: 68 RVA: 0x000024D2 File Offset: 0x000006D2
        public string _libelle { get; set; }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000045 RID: 69 RVA: 0x000024DB File Offset: 0x000006DB
        // (set) Token: 0x06000046 RID: 70 RVA: 0x000024E3 File Offset: 0x000006E3
        public int _taux { get; set; }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000047 RID: 71 RVA: 0x000024EC File Offset: 0x000006EC
        // (set) Token: 0x06000048 RID: 72 RVA: 0x000024F4 File Offset: 0x000006F4
        public bool _etat { get; set; }

        // Token: 0x06000049 RID: 73 RVA: 0x000024FD File Offset: 0x000006FD
        public Tva()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._taux = 0;
            this._etat = false;
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00002530 File Offset: 0x00000730
        public Tva(int id, string code, string libelle, int taux, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._taux = taux;
            this._etat = etat;
        }
    }


}

