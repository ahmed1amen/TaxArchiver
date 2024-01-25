using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    public class Utilisateur
    {
        // Token: 0x17000303 RID: 771
        // (get) Token: 0x06000AEB RID: 2795 RVA: 0x00063908 File Offset: 0x00061B08
        // (set) Token: 0x06000AEC RID: 2796 RVA: 0x00063910 File Offset: 0x00061B10
        public int _id { get; set; }

        // Token: 0x17000304 RID: 772
        // (get) Token: 0x06000AED RID: 2797 RVA: 0x00063919 File Offset: 0x00061B19
        // (set) Token: 0x06000AEE RID: 2798 RVA: 0x00063921 File Offset: 0x00061B21
        public string _login { get; set; }

        // Token: 0x17000305 RID: 773
        // (get) Token: 0x06000AEF RID: 2799 RVA: 0x0006392A File Offset: 0x00061B2A
        // (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00063932 File Offset: 0x00061B32
        public string _password { get; set; }

        // Token: 0x17000306 RID: 774
        // (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0006393B File Offset: 0x00061B3B
        // (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00063943 File Offset: 0x00061B43
        public bool _etat { get; set; }

        // Token: 0x17000307 RID: 775
        // (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0006394C File Offset: 0x00061B4C
        // (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00063954 File Offset: 0x00061B54
        public List<Droit> _droits { get; set; }

        // Token: 0x17000308 RID: 776
        // (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0006395D File Offset: 0x00061B5D
        // (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00063965 File Offset: 0x00061B65
        public string _cleDallas { get; set; }

        // Token: 0x06000AF7 RID: 2807 RVA: 0x00063970 File Offset: 0x00061B70
        public Utilisateur()
        {
            this._id = 0;
            this._login = "";
            this._password = "";
            this._etat = false;
            this._droits = new List<Droit>();
            this._cleDallas = "";
        }

        // Token: 0x06000AF8 RID: 2808 RVA: 0x000639BD File Offset: 0x00061BBD
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
