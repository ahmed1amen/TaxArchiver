using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000379 RID: 889
    public class LigneDemandeAchat
    {
        // Token: 0x17001020 RID: 4128
        // (get) Token: 0x06003CEE RID: 15598 RVA: 0x001CB58D File Offset: 0x001C978D
        // (set) Token: 0x06003CEF RID: 15599 RVA: 0x001CB595 File Offset: 0x001C9795
        public int _id { get; set; }

        // Token: 0x17001021 RID: 4129
        // (get) Token: 0x06003CF0 RID: 15600 RVA: 0x001CB59E File Offset: 0x001C979E
        // (set) Token: 0x06003CF1 RID: 15601 RVA: 0x001CB5A6 File Offset: 0x001C97A6
        public Article _article { get; set; }

        // Token: 0x17001022 RID: 4130
        // (get) Token: 0x06003CF2 RID: 15602 RVA: 0x001CB5AF File Offset: 0x001C97AF
        // (set) Token: 0x06003CF3 RID: 15603 RVA: 0x001CB5B7 File Offset: 0x001C97B7
        public decimal _qteDemande { get; set; }

        // Token: 0x17001023 RID: 4131
        // (get) Token: 0x06003CF4 RID: 15604 RVA: 0x001CB5C0 File Offset: 0x001C97C0
        // (set) Token: 0x06003CF5 RID: 15605 RVA: 0x001CB5C8 File Offset: 0x001C97C8
        public decimal _qteValider { get; set; }

        // Token: 0x17001024 RID: 4132
        // (get) Token: 0x06003CF6 RID: 15606 RVA: 0x001CB5D1 File Offset: 0x001C97D1
        // (set) Token: 0x06003CF7 RID: 15607 RVA: 0x001CB5D9 File Offset: 0x001C97D9
        public bool _commander { get; set; }

        // Token: 0x17001025 RID: 4133
        // (get) Token: 0x06003CF8 RID: 15608 RVA: 0x001CB5E2 File Offset: 0x001C97E2
        // (set) Token: 0x06003CF9 RID: 15609 RVA: 0x001CB5EA File Offset: 0x001C97EA
        public Catalogue _catalogue { get; set; }

        // Token: 0x06003CFA RID: 15610 RVA: 0x001CB5F4 File Offset: 0x001C97F4
        public LigneDemandeAchat()
        {
            this._id = 0;
            this._article = new Article();
            this._qteDemande = 0m;
            this._qteValider = 0m;
            this._commander = false;
            this._catalogue = new Catalogue();
        }

        // Token: 0x06003CFB RID: 15611 RVA: 0x001CB643 File Offset: 0x001C9843
        public LigneDemandeAchat(int id, Article article, decimal qteDemande, decimal qteValider)
        {
            this._id = id;
            this._article = article;
            this._qteDemande = qteDemande;
            this._qteValider = qteValider;
            this._commander = false;
            this._catalogue = new Catalogue();
        }

        // Token: 0x06003CFC RID: 15612 RVA: 0x001CB67C File Offset: 0x001C987C
        public LigneDemandeAchat(int id, Article article, decimal qteDemande, decimal qteValider, bool commander, Catalogue catalogue)
        {
            this._id = id;
            this._article = article;
            this._article.catalogueSelectionner = catalogue;
            this._catalogue = catalogue;
            this._qteDemande = qteDemande;
            this._qteValider = qteValider;
            this._commander = commander;
        }

        // Token: 0x06003CFD RID: 15613 RVA: 0x001CB6CC File Offset: 0x001C98CC
        public new string ToString()
        {
            string result;
            try
            {
                result = string.Concat(new object[]
                {
                    this._id,
                    " ",
                    this._article._libelle,
                    " ",
                    this._article.catalogueSelectionner._fourniseur._libelle,
                    " ",
                    this._qteDemande,
                    "\n"
                });
            }
            catch (Exception)
            {
                result = string.Concat(new object[]
                {
                    this._id,
                    " ",
                    this._article._libelle,
                    "  ",
                    this._qteDemande,
                    "\n"
                });
            }
            return result;
        }
    }
}
