using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000137 RID: 311
    public class Article
    {
        // Token: 0x1700055D RID: 1373
        // (get) Token: 0x06001561 RID: 5473 RVA: 0x000B9F64 File Offset: 0x000B8164
        // (set) Token: 0x06001562 RID: 5474 RVA: 0x000B9F6C File Offset: 0x000B816C
        public int _id { get; set; }

        // Token: 0x1700055E RID: 1374
        // (get) Token: 0x06001563 RID: 5475 RVA: 0x000B9F75 File Offset: 0x000B8175
        // (set) Token: 0x06001564 RID: 5476 RVA: 0x000B9F7D File Offset: 0x000B817D
        public string _code { get; set; }

        // Token: 0x1700055F RID: 1375
        // (get) Token: 0x06001565 RID: 5477 RVA: 0x000B9F86 File Offset: 0x000B8186
        // (set) Token: 0x06001566 RID: 5478 RVA: 0x000B9F8E File Offset: 0x000B818E
        public string _libelle { get; set; }

        // Token: 0x17000560 RID: 1376
        // (get) Token: 0x06001567 RID: 5479 RVA: 0x000B9F97 File Offset: 0x000B8197
        // (set) Token: 0x06001568 RID: 5480 RVA: 0x000B9F9F File Offset: 0x000B819F
        public SousFamille _sousFamille { get; set; }

        // Token: 0x17000561 RID: 1377
        // (get) Token: 0x06001569 RID: 5481 RVA: 0x000B9FA8 File Offset: 0x000B81A8
        // (set) Token: 0x0600156A RID: 5482 RVA: 0x000B9FB0 File Offset: 0x000B81B0
        public Unite _unite { get; set; }

        // Token: 0x17000562 RID: 1378
        // (get) Token: 0x0600156B RID: 5483 RVA: 0x000B9FB9 File Offset: 0x000B81B9
        // (set) Token: 0x0600156C RID: 5484 RVA: 0x000B9FC1 File Offset: 0x000B81C1
        public decimal _qteMin { get; set; }

        // Token: 0x17000563 RID: 1379
        // (get) Token: 0x0600156D RID: 5485 RVA: 0x000B9FCA File Offset: 0x000B81CA
        // (set) Token: 0x0600156E RID: 5486 RVA: 0x000B9FD2 File Offset: 0x000B81D2
        public decimal _qteMax { get; set; }

        // Token: 0x17000564 RID: 1380
        // (get) Token: 0x0600156F RID: 5487 RVA: 0x000B9FDB File Offset: 0x000B81DB
        // (set) Token: 0x06001570 RID: 5488 RVA: 0x000B9FE3 File Offset: 0x000B81E3
        public Tva _tva { get; set; }

        // Token: 0x17000565 RID: 1381
        // (get) Token: 0x06001571 RID: 5489 RVA: 0x000B9FEC File Offset: 0x000B81EC
        // (set) Token: 0x06001572 RID: 5490 RVA: 0x000B9FF4 File Offset: 0x000B81F4
        public decimal _prixVente { get; set; }

        // Token: 0x17000566 RID: 1382
        // (get) Token: 0x06001573 RID: 5491 RVA: 0x000B9FFD File Offset: 0x000B81FD
        // (set) Token: 0x06001574 RID: 5492 RVA: 0x000BA005 File Offset: 0x000B8205
        public decimal _pmp { get; set; }

        // Token: 0x17000567 RID: 1383
        // (get) Token: 0x06001575 RID: 5493 RVA: 0x000BA00E File Offset: 0x000B820E
        // (set) Token: 0x06001576 RID: 5494 RVA: 0x000BA016 File Offset: 0x000B8216
        public decimal _qteTotal { get; set; }

        // Token: 0x17000568 RID: 1384
        // (get) Token: 0x06001577 RID: 5495 RVA: 0x000BA01F File Offset: 0x000B821F
        // (set) Token: 0x06001578 RID: 5496 RVA: 0x000BA027 File Offset: 0x000B8227
        public bool _etat { get; set; }

        // Token: 0x17000569 RID: 1385
        // (get) Token: 0x06001579 RID: 5497 RVA: 0x000BA030 File Offset: 0x000B8230
        // (set) Token: 0x0600157A RID: 5498 RVA: 0x000BA038 File Offset: 0x000B8238
        public List<Catalogue> _listCatalogue { get; set; }

        // Token: 0x1700056A RID: 1386
        // (get) Token: 0x0600157B RID: 5499 RVA: 0x000BA041 File Offset: 0x000B8241
        // (set) Token: 0x0600157C RID: 5500 RVA: 0x000BA049 File Offset: 0x000B8249
        public decimal _qteMinLocal { get; set; }

        // Token: 0x1700056B RID: 1387
        // (get) Token: 0x0600157D RID: 5501 RVA: 0x000BA052 File Offset: 0x000B8252
        // (set) Token: 0x0600157E RID: 5502 RVA: 0x000BA05A File Offset: 0x000B825A
        public bool _fini { get; set; }

        // Token: 0x1700056C RID: 1388
        // (get) Token: 0x0600157F RID: 5503 RVA: 0x000BA063 File Offset: 0x000B8263
        // (set) Token: 0x06001580 RID: 5504 RVA: 0x000BA06B File Offset: 0x000B826B
        public Local _local { get; set; }

        // Token: 0x06001581 RID: 5505 RVA: 0x000BA074 File Offset: 0x000B8274
        public Article()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._etat = false;
            this._sousFamille = new SousFamille();
            this._unite = new Unite();
            this._commentaire = "";
            this._qteMin = (this._prixVente = (this._pmp = (this._qteMax = 0m)));
            this._tva = new Tva();
            this._listCatalogue = new List<Catalogue>();
            this._qteMinLocal = 0m;
            this._fini = false;
            this._local = new Local();
        }

        // Token: 0x06001582 RID: 5506 RVA: 0x000BA128 File Offset: 0x000B8328
        public Article(int id, string code, string libelle)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = false;
            this._sousFamille = new SousFamille();
            this._unite = new Unite();
            this._commentaire = "";
            this._qteMin = (this._prixVente = (this._pmp = (this._qteMax = 0m)));
            this._tva = new Tva();
            this._listCatalogue = new List<Catalogue>();
            this._qteMinLocal = 0m;
            this._fini = false;
            this._local = new Local();
        }

        // Token: 0x06001583 RID: 5507 RVA: 0x000BA1D4 File Offset: 0x000B83D4
        public Article(int id, string code, string libelle, decimal qte, decimal qtemin)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = false;
            this._sousFamille = new SousFamille();
            this._unite = new Unite();
            this._commentaire = "";
            this._qteMin = qtemin;
            this._prixVente = (this._pmp = (this._qteMax = 0m));
            this._tva = new Tva();
            this._listCatalogue = new List<Catalogue>();
            this._qteTotal = qte;
        }

        // Token: 0x06001584 RID: 5508 RVA: 0x000BA268 File Offset: 0x000B8468
        public Article(int id, string code, string libelle, SousFamille sousFamille, Unite unite)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = false;
            this._sousFamille = sousFamille;
            this._unite = unite;
            this._commentaire = "";
            this._qteMin = (this._prixVente = (this._pmp = (this._qteMax = 0m)));
            this._tva = new Tva();
            this._listCatalogue = new List<Catalogue>();
        }

        // Token: 0x06001585 RID: 5509 RVA: 0x000BA2F0 File Offset: 0x000B84F0
        public Article(int id, string code, string libelle, SousFamille sousFamille, Unite unite, string commentaire, decimal qteMin, decimal qteMax, Tva tva, decimal prixVente, decimal pmp, bool etat, decimal qteMinLocal, bool fini, Local local)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._sousFamille = sousFamille;
            this._unite = unite;
            this._commentaire = commentaire;
            this._qteMin = qteMin;
            this._prixVente = prixVente;
            this._pmp = pmp;
            this._qteMax = qteMax;
            this._tva = tva;
            this._listCatalogue = new List<Catalogue>();
            this._qteMinLocal = qteMinLocal;
            this._fini = fini;
            this._local = local;
        }

        // Token: 0x06001586 RID: 5510 RVA: 0x000BA384 File Offset: 0x000B8584
        public Article(int id, string code, string libelle, SousFamille sousFamille, Unite unite, string commentaire, decimal qteMin, decimal qteMax, Tva tva, decimal prixVente, decimal pmp, decimal qtetotal, List<Catalogue> listCatalogue, bool etat, decimal qteMinLocal, bool fini, Local local)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._sousFamille = sousFamille;
            this._unite = unite;
            this._commentaire = commentaire;
            this._qteMin = qteMin;
            this._prixVente = prixVente;
            this._pmp = pmp;
            this._qteMax = qteMax;
            this._tva = tva;
            this._listCatalogue = listCatalogue;
            this._qteMinLocal = qteMinLocal;
            this._fini = fini;
            this._local = local;
        }

        // Token: 0x06001587 RID: 5511 RVA: 0x000BA414 File Offset: 0x000B8614
        public Article(int id, string code, string libelle, SousFamille sousFamille, Unite unite, string commentaire, decimal qteMin, decimal qteMax, Tva tva, decimal prixVente, decimal pmp, decimal qtetotal, bool etat, decimal qteMinLocal, bool fini, Local local)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._sousFamille = sousFamille;
            this._unite = unite;
            this._commentaire = commentaire;
            this._qteMin = qteMin;
            this._prixVente = prixVente;
            this._pmp = pmp;
            this._qteMax = qteMax;
            this._tva = tva;
            this._qteTotal = qtetotal;
            this._listCatalogue = new List<Catalogue>();
            this._qteMinLocal = qteMinLocal;
            this._fini = fini;
            this._local = local;
        }

        // Token: 0x1700056D RID: 1389
        // (get) Token: 0x06001588 RID: 5512 RVA: 0x000BA4BC File Offset: 0x000B86BC
        // (set) Token: 0x06001589 RID: 5513 RVA: 0x000BA534 File Offset: 0x000B8734
        public Catalogue catalogueSelectionner
        {
            get
            {
                Catalogue catalogue = this._listCatalogue.Find((Catalogue _cus) => _cus._selectionner);
                if (catalogue._id != 0)
                {
                    return catalogue;
                }
                return new Catalogue();
            }
            set
            {
                this._listCatalogue.Find(delegate (Catalogue _cus)
                {
                    if (_cus._selectionner)
                    {
                        _cus._selectionner = false;
                        return true;
                    }
                    if (_cus.Equals(value))
                    {
                        _cus._selectionner = true;
                        return true;
                    }
                    return false;
                });
            }
        }

        // Token: 0x0600158A RID: 5514 RVA: 0x000BA566 File Offset: 0x000B8766
        public int ajouterCatalogue(Catalogue catalogue)
        {
            this._listCatalogue.Add(catalogue);
            return 0;
        }

        // Token: 0x0600158B RID: 5515 RVA: 0x000BA575 File Offset: 0x000B8775
        public override string ToString()
        {
            return this._libelle;
        }

        // Token: 0x04000F64 RID: 3940
        public string _commentaire;
    }
}
