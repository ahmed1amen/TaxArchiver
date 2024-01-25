using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000234 RID: 564
    public class Unite
    {
        // Token: 0x170009AA RID: 2474
        // (get) Token: 0x060026F9 RID: 9977 RVA: 0x001464F9 File Offset: 0x001446F9
        // (set) Token: 0x060026FA RID: 9978 RVA: 0x00146501 File Offset: 0x00144701
        public int _id { get; set; }

        // Token: 0x170009AB RID: 2475
        // (get) Token: 0x060026FB RID: 9979 RVA: 0x0014650A File Offset: 0x0014470A
        // (set) Token: 0x060026FC RID: 9980 RVA: 0x00146512 File Offset: 0x00144712
        public string _code { get; set; }

        // Token: 0x170009AC RID: 2476
        // (get) Token: 0x060026FD RID: 9981 RVA: 0x0014651B File Offset: 0x0014471B
        // (set) Token: 0x060026FE RID: 9982 RVA: 0x00146523 File Offset: 0x00144723
        public string _libelle { get; set; }

        // Token: 0x170009AD RID: 2477
        // (get) Token: 0x060026FF RID: 9983 RVA: 0x0014652C File Offset: 0x0014472C
        // (set) Token: 0x06002700 RID: 9984 RVA: 0x00146534 File Offset: 0x00144734
        public bool _etat { get; set; }

        // Token: 0x06002701 RID: 9985 RVA: 0x0014653D File Offset: 0x0014473D
        public Unite()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._etat = false;
        }

        // Token: 0x06002702 RID: 9986 RVA: 0x00146569 File Offset: 0x00144769
        public Unite(int id, string code, string libelle, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
        }

        // Token: 0x06002703 RID: 9987 RVA: 0x0014658E File Offset: 0x0014478E
        public override string ToString()
        {
            return this._code;
        }
    }
}
