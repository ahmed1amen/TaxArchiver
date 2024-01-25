using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200040B RID: 1035
    public class Catalogue
    {
        // Token: 0x170012E9 RID: 4841
        // (get) Token: 0x06004660 RID: 18016 RVA: 0x00219B61 File Offset: 0x00217D61
        // (set) Token: 0x06004661 RID: 18017 RVA: 0x00219B69 File Offset: 0x00217D69
        public int _id { get; set; }

        // Token: 0x170012EA RID: 4842
        // (get) Token: 0x06004662 RID: 18018 RVA: 0x00219B72 File Offset: 0x00217D72
        // (set) Token: 0x06004663 RID: 18019 RVA: 0x00219B7A File Offset: 0x00217D7A
        public Fournisseur _fourniseur { get; set; }

        // Token: 0x170012EB RID: 4843
        // (get) Token: 0x06004664 RID: 18020 RVA: 0x00219B83 File Offset: 0x00217D83
        // (set) Token: 0x06004665 RID: 18021 RVA: 0x00219B8B File Offset: 0x00217D8B
        public Article _article { get; set; }

        // Token: 0x170012EC RID: 4844
        // (get) Token: 0x06004666 RID: 18022 RVA: 0x00219B94 File Offset: 0x00217D94
        // (set) Token: 0x06004667 RID: 18023 RVA: 0x00219B9C File Offset: 0x00217D9C
        public decimal _prix { get; set; }

        // Token: 0x170012ED RID: 4845
        // (get) Token: 0x06004668 RID: 18024 RVA: 0x00219BA5 File Offset: 0x00217DA5
        // (set) Token: 0x06004669 RID: 18025 RVA: 0x00219BAD File Offset: 0x00217DAD
        public int _classement { get; set; }

        // Token: 0x170012EE RID: 4846
        // (get) Token: 0x0600466A RID: 18026 RVA: 0x00219BB6 File Offset: 0x00217DB6
        // (set) Token: 0x0600466B RID: 18027 RVA: 0x00219BBE File Offset: 0x00217DBE
        public bool _selectionner { get; set; }

        // Token: 0x170012EF RID: 4847
        // (get) Token: 0x0600466C RID: 18028 RVA: 0x00219BC7 File Offset: 0x00217DC7
        // (set) Token: 0x0600466D RID: 18029 RVA: 0x00219BCF File Offset: 0x00217DCF
        public int _delaiLivraison { get; set; }

        // Token: 0x170012F0 RID: 4848
        // (get) Token: 0x0600466E RID: 18030 RVA: 0x00219BD8 File Offset: 0x00217DD8
        // (set) Token: 0x0600466F RID: 18031 RVA: 0x00219BE0 File Offset: 0x00217DE0
        public decimal _fraisTransport { get; set; }

        // Token: 0x170012F1 RID: 4849
        // (get) Token: 0x06004670 RID: 18032 RVA: 0x00219BE9 File Offset: 0x00217DE9
        // (set) Token: 0x06004671 RID: 18033 RVA: 0x00219BF1 File Offset: 0x00217DF1
        public string _commentaire { get; set; }

        // Token: 0x06004672 RID: 18034 RVA: 0x00219BFC File Offset: 0x00217DFC
        public Catalogue()
        {
            this._id = 0;
            this._fourniseur = new Fournisseur();
            this._article = new Article();
            this._prix = 0m;
            this._classement = 0;
            this._selectionner = false;
            this._delaiLivraison = 0;
            this._fraisTransport = 0m;
            this._commentaire = "";
        }

        // Token: 0x06004673 RID: 18035 RVA: 0x00219C64 File Offset: 0x00217E64
        public Catalogue(int id, Fournisseur fournisseur, Article article, decimal prix, int delaiLivraison, string commentaire)
        {
            this._id = id;
            this._fourniseur = fournisseur;
            this._article = article;
            this._prix = prix;
            this._classement = 0;
            this._selectionner = false;
            this._delaiLivraison = delaiLivraison;
            this._fraisTransport = 0m;
            this._commentaire = commentaire;
        }

        // Token: 0x06004674 RID: 18036 RVA: 0x00219CC0 File Offset: 0x00217EC0
        public Catalogue(int id, Fournisseur fournisseur, Article article, decimal prix, string commentaire)
        {
            this._id = id;
            this._fourniseur = fournisseur;
            this._article = article;
            this._prix = prix;
            this._classement = 0;
            this._selectionner = false;
            this._delaiLivraison = 0;
            this._fraisTransport = 0m;
            this._commentaire = commentaire;
        }

        // Token: 0x06004675 RID: 18037 RVA: 0x00219D1C File Offset: 0x00217F1C
        public Catalogue(int id, Fournisseur fournisseur, Article article, decimal prix, int delaiLivraison, decimal fraistransport, string commentaire)
        {
            this._id = id;
            this._fourniseur = fournisseur;
            this._article = article;
            this._prix = prix;
            this._classement = 0;
            this._selectionner = false;
            this._delaiLivraison = delaiLivraison;
            this._fraisTransport = fraistransport;
            this._commentaire = commentaire;
        }

        // Token: 0x170012F2 RID: 4850
        // (get) Token: 0x06004676 RID: 18038 RVA: 0x00219D72 File Offset: 0x00217F72
        public string getLibelleFournisseur
        {
            get
            {
                return this._fourniseur._libelle;
            }
        }
    }
}
