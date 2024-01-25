using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x020000F5 RID: 245
    internal class FicheTechnique
    {
        // Token: 0x1700042F RID: 1071
        // (get) Token: 0x06001028 RID: 4136 RVA: 0x00093AC1 File Offset: 0x00091CC1
        // (set) Token: 0x06001029 RID: 4137 RVA: 0x00093AC9 File Offset: 0x00091CC9
        public Produit _produit { get; set; }

        // Token: 0x17000430 RID: 1072
        // (get) Token: 0x0600102A RID: 4138 RVA: 0x00093AD2 File Offset: 0x00091CD2
        // (set) Token: 0x0600102B RID: 4139 RVA: 0x00093ADA File Offset: 0x00091CDA
        public Article _article { get; set; }

        // Token: 0x17000431 RID: 1073
        // (get) Token: 0x0600102C RID: 4140 RVA: 0x00093AE3 File Offset: 0x00091CE3
        // (set) Token: 0x0600102D RID: 4141 RVA: 0x00093AEB File Offset: 0x00091CEB
        public Local _local { get; set; }

        // Token: 0x17000432 RID: 1074
        // (get) Token: 0x0600102E RID: 4142 RVA: 0x00093AF4 File Offset: 0x00091CF4
        // (set) Token: 0x0600102F RID: 4143 RVA: 0x00093AFC File Offset: 0x00091CFC
        public decimal _qte { get; set; }

        // Token: 0x17000433 RID: 1075
        // (get) Token: 0x06001030 RID: 4144 RVA: 0x00093B05 File Offset: 0x00091D05
        // (set) Token: 0x06001031 RID: 4145 RVA: 0x00093B0D File Offset: 0x00091D0D
        public string _codeUnite { get; set; }

        // Token: 0x17000434 RID: 1076
        // (get) Token: 0x06001032 RID: 4146 RVA: 0x00093B16 File Offset: 0x00091D16
        // (set) Token: 0x06001033 RID: 4147 RVA: 0x00093B1E File Offset: 0x00091D1E
        public bool _deleted { get; set; }

        // Token: 0x06001034 RID: 4148 RVA: 0x00093B28 File Offset: 0x00091D28
        public FicheTechnique()
        {
            this._produit = new Produit();
            this._article = new Article();
            this._local = new Local();
            this._qte = 0m;
            this._codeUnite = "";
            this._deleted = false;
        }

        // Token: 0x06001035 RID: 4149 RVA: 0x00093B7A File Offset: 0x00091D7A
        public FicheTechnique(Produit produit, Article article, Local local, decimal qte, string codeUnite)
        {
            this._produit = produit;
            this._article = article;
            this._local = local;
            this._qte = qte;
            this._codeUnite = codeUnite;
            this._deleted = false;
        }
    }
}
