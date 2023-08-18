using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace TaxArchiver
{
    // Token: 0x020003A4 RID: 932
    public class Facture
    {
        
        public int _id { get; set; }
        public string _table { get; set; }
        public int _couvert { get; set; }
        public Utilisateur _utilisateur { get; set; }

        public decimal _totalFacture { get; set; }

        public decimal _totalTva { get; set; }
        public bool _solder { get; set; }

        public DateTime _dateOuverture { get; set; }

        public DateTime _dateFermeture { get; set; }

        public Service _service { get; set; }

        public List<LigneFacture> _listLigneFacture { get; set; }

        public List<LignePaiement> _listLignePaiement { get; set; }

        public DateTime _dateSystem { get; set; }

        public string _serveur { get; set; }

        public char _etatFacture { get; set; }

      
        public int _numeroFacture { get; set; }

        public Zone _zone { get; set; }

        public int _idClient { get; set; }

        public bool _cloture { get; set; }

        public bool _transfert { get; set; }

        public TimeSpan _temps { get; set; }

        public decimal _valMinSpend { get; set; }

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

        // Token: 0x06004088 RID: 16520 RVA: 0x001F4998 File Offset: 0x001F2B98
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
}
