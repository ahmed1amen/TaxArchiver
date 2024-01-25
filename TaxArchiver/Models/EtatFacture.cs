using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200037E RID: 894
    public class EtatFacture
    {
        // Token: 0x17001052 RID: 4178
        // (get) Token: 0x06003D64 RID: 15716 RVA: 0x001CC19F File Offset: 0x001CA39F
        // (set) Token: 0x06003D65 RID: 15717 RVA: 0x001CC1A7 File Offset: 0x001CA3A7
        public bool _solder { get; set; }

        // Token: 0x17001053 RID: 4179
        // (get) Token: 0x06003D66 RID: 15718 RVA: 0x001CC1B0 File Offset: 0x001CA3B0
        // (set) Token: 0x06003D67 RID: 15719 RVA: 0x001CC1B8 File Offset: 0x001CA3B8
        public int _nbrLigneFacture { get; set; }

        // Token: 0x17001054 RID: 4180
        // (get) Token: 0x06003D68 RID: 15720 RVA: 0x001CC1C1 File Offset: 0x001CA3C1
        // (set) Token: 0x06003D69 RID: 15721 RVA: 0x001CC1C9 File Offset: 0x001CA3C9
        public int _nbrLignePaiement { get; set; }

        // Token: 0x06003D6A RID: 15722 RVA: 0x001CC1D2 File Offset: 0x001CA3D2
        public EtatFacture()
        {
            this._solder = false;
            this._nbrLigneFacture = 0;
            this._nbrLignePaiement = 0;
        }

        // Token: 0x06003D6B RID: 15723 RVA: 0x001CC1EF File Offset: 0x001CA3EF
        public EtatFacture(bool solder, int nbrLigneFacture, int nbrLignePaiement)
        {
            this._solder = solder;
            this._nbrLigneFacture = nbrLigneFacture;
            this._nbrLignePaiement = nbrLignePaiement;
        }
    }
}
