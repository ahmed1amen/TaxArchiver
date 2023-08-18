using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver
{
    // Token: 0x020000A3 RID: 163
    public class Utilisateur
    {
        // Token: 0x17000303 RID: 771
        // (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0006365C File Offset: 0x0006185C
        // (set) Token: 0x06000AEA RID: 2794 RVA: 0x00063664 File Offset: 0x00061864
        public int _id { get; set; }

        // Token: 0x17000304 RID: 772
        // (get) Token: 0x06000AEB RID: 2795 RVA: 0x0006366D File Offset: 0x0006186D
        // (set) Token: 0x06000AEC RID: 2796 RVA: 0x00063675 File Offset: 0x00061875
        public string _login { get; set; }

        // Token: 0x17000305 RID: 773
        // (get) Token: 0x06000AED RID: 2797 RVA: 0x0006367E File Offset: 0x0006187E
        // (set) Token: 0x06000AEE RID: 2798 RVA: 0x00063686 File Offset: 0x00061886
        public string _password { get; set; }

        // Token: 0x17000306 RID: 774
        // (get) Token: 0x06000AEF RID: 2799 RVA: 0x0006368F File Offset: 0x0006188F
        // (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00063697 File Offset: 0x00061897
        public bool _etat { get; set; }

        // Token: 0x17000307 RID: 775
        // (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000636A0 File Offset: 0x000618A0
        // (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000636A8 File Offset: 0x000618A8
        public List<Droit> _droits { get; set; }

        // Token: 0x17000308 RID: 776
        // (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000636B1 File Offset: 0x000618B1
        // (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000636B9 File Offset: 0x000618B9
        public string _cleDallas { get; set; }

        // Token: 0x06000AF5 RID: 2805 RVA: 0x000636C4 File Offset: 0x000618C4
        public Utilisateur()
        {
            this._id = 0;
            this._login = "";
            this._password = "";
            this._etat = false;
            this._droits = new List<Droit>();
            this._cleDallas = "";
        }

        // Token: 0x06000AF6 RID: 2806 RVA: 0x00063711 File Offset: 0x00061911
        public Utilisateur(int id, string login, string password, bool etat, List<Droit> droits, string cleDallas)
        {
            this._id = id;
            this._login = login;
            this._password = password;
            this._etat = etat;
            this._droits = droits;
            this._cleDallas = cleDallas;
        }
    }
}
