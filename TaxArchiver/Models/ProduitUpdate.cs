using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000192 RID: 402
    public class ProduitUpdate
    {
        // Token: 0x1700072A RID: 1834
        // (get) Token: 0x06001BDF RID: 7135 RVA: 0x000E9654 File Offset: 0x000E7854
        // (set) Token: 0x06001BE0 RID: 7136 RVA: 0x000E965C File Offset: 0x000E785C
        public int _id { get; set; }

        // Token: 0x1700072B RID: 1835
        // (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000E9665 File Offset: 0x000E7865
        // (set) Token: 0x06001BE2 RID: 7138 RVA: 0x000E966D File Offset: 0x000E786D
        public string _libelle { get; set; }

        // Token: 0x1700072C RID: 1836
        // (get) Token: 0x06001BE3 RID: 7139 RVA: 0x000E9676 File Offset: 0x000E7876
        // (set) Token: 0x06001BE4 RID: 7140 RVA: 0x000E967E File Offset: 0x000E787E
        public bool _etat { get; set; }

        // Token: 0x1700072D RID: 1837
        // (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000E9687 File Offset: 0x000E7887
        // (set) Token: 0x06001BE6 RID: 7142 RVA: 0x000E968F File Offset: 0x000E788F
        public decimal _qteVisuelle { get; set; }

        // Token: 0x1700072E RID: 1838
        // (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000E9698 File Offset: 0x000E7898
        // (set) Token: 0x06001BE8 RID: 7144 RVA: 0x000E96A0 File Offset: 0x000E78A0
        public decimal _qteVente { get; set; }

        // Token: 0x06001BE9 RID: 7145 RVA: 0x000E96A9 File Offset: 0x000E78A9
        public ProduitUpdate()
        {
            this._id = 0;
            this._libelle = "";
            this._etat = false;
            this._qteVente = 0m;
            this._qteVisuelle = 0m;
        }

        // Token: 0x06001BEA RID: 7146 RVA: 0x000E96E2 File Offset: 0x000E78E2
        public ProduitUpdate(int id, bool etat, decimal qteVente, decimal qteVisuelle)
        {
            this._id = id;
            this._libelle = "";
            this._etat = etat;
            this._qteVente = qteVente;
            this._qteVisuelle = qteVisuelle;
        }

        // Token: 0x06001BEB RID: 7147 RVA: 0x000E9712 File Offset: 0x000E7912
        public ProduitUpdate(int id, string libelle, bool etat, decimal qteVente, decimal qteVisuelle)
        {
            this._id = id;
            this._libelle = libelle;
            this._etat = etat;
            this._qteVente = qteVente;
            this._qteVisuelle = qteVisuelle;
        }
    }
}
