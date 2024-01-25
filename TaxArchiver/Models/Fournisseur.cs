using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x020000EE RID: 238
    public class Fournisseur
    {
        // Token: 0x170003E0 RID: 992
        // (get) Token: 0x06000F7A RID: 3962 RVA: 0x00092DA9 File Offset: 0x00090FA9
        // (set) Token: 0x06000F7B RID: 3963 RVA: 0x00092DB1 File Offset: 0x00090FB1
        public int _id { get; set; }

        // Token: 0x170003E1 RID: 993
        // (get) Token: 0x06000F7C RID: 3964 RVA: 0x00092DBA File Offset: 0x00090FBA
        // (set) Token: 0x06000F7D RID: 3965 RVA: 0x00092DC2 File Offset: 0x00090FC2
        public string _code { get; set; }

        // Token: 0x170003E2 RID: 994
        // (get) Token: 0x06000F7E RID: 3966 RVA: 0x00092DCB File Offset: 0x00090FCB
        // (set) Token: 0x06000F7F RID: 3967 RVA: 0x00092DD3 File Offset: 0x00090FD3
        public string _libelle { get; set; }

        // Token: 0x170003E3 RID: 995
        // (get) Token: 0x06000F80 RID: 3968 RVA: 0x00092DDC File Offset: 0x00090FDC
        // (set) Token: 0x06000F81 RID: 3969 RVA: 0x00092DE4 File Offset: 0x00090FE4
        public string _rue { get; set; }

        // Token: 0x170003E4 RID: 996
        // (get) Token: 0x06000F82 RID: 3970 RVA: 0x00092DED File Offset: 0x00090FED
        // (set) Token: 0x06000F83 RID: 3971 RVA: 0x00092DF5 File Offset: 0x00090FF5
        public string _tel { get; set; }

        // Token: 0x170003E5 RID: 997
        // (get) Token: 0x06000F84 RID: 3972 RVA: 0x00092DFE File Offset: 0x00090FFE
        // (set) Token: 0x06000F85 RID: 3973 RVA: 0x00092E06 File Offset: 0x00091006
        public string _fax { get; set; }

        // Token: 0x170003E6 RID: 998
        // (get) Token: 0x06000F86 RID: 3974 RVA: 0x00092E0F File Offset: 0x0009100F
        // (set) Token: 0x06000F87 RID: 3975 RVA: 0x00092E17 File Offset: 0x00091017
        public string _email { get; set; }

        // Token: 0x170003E7 RID: 999
        // (get) Token: 0x06000F88 RID: 3976 RVA: 0x00092E20 File Offset: 0x00091020
        // (set) Token: 0x06000F89 RID: 3977 RVA: 0x00092E28 File Offset: 0x00091028
        public bool _etat { get; set; }

        // Token: 0x170003E8 RID: 1000
        // (get) Token: 0x06000F8A RID: 3978 RVA: 0x00092E31 File Offset: 0x00091031
        // (set) Token: 0x06000F8B RID: 3979 RVA: 0x00092E39 File Offset: 0x00091039
        public Ville _ville { get; set; }

        // Token: 0x170003E9 RID: 1001
        // (get) Token: 0x06000F8C RID: 3980 RVA: 0x00092E42 File Offset: 0x00091042
        // (set) Token: 0x06000F8D RID: 3981 RVA: 0x00092E4A File Offset: 0x0009104A
        public string _compte { get; set; }

        // Token: 0x170003EA RID: 1002
        // (get) Token: 0x06000F8E RID: 3982 RVA: 0x00092E53 File Offset: 0x00091053
        // (set) Token: 0x06000F8F RID: 3983 RVA: 0x00092E5B File Offset: 0x0009105B
        public string _compteFar { get; set; }

        // Token: 0x170003EB RID: 1003
        // (get) Token: 0x06000F90 RID: 3984 RVA: 0x00092E64 File Offset: 0x00091064
        // (set) Token: 0x06000F91 RID: 3985 RVA: 0x00092E6C File Offset: 0x0009106C
        public string _jrn { get; set; }

        // Token: 0x170003EC RID: 1004
        // (get) Token: 0x06000F92 RID: 3986 RVA: 0x00092E75 File Offset: 0x00091075
        // (set) Token: 0x06000F93 RID: 3987 RVA: 0x00092E7D File Offset: 0x0009107D
        public string _jrnFar { get; set; }

        // Token: 0x06000F94 RID: 3988 RVA: 0x00092E88 File Offset: 0x00091088
        public Fournisseur()
        {
            this._id = 0;
            this._code = (this._libelle = (this._rue = (this._tel = (this._fax = (this._email = (this._jrnFar = (this._jrn = "")))))));
            this._etat = false;
            this._compteFar = (this._compte = "");
            this._ville = new Ville();
        }

        // Token: 0x06000F95 RID: 3989 RVA: 0x00092F1C File Offset: 0x0009111C
        public Fournisseur(int id, string code, string libelle, string rue, string tel, string fax, string email, string compte, string compteFar, string jrn, string jrnFar, Ville ville, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._rue = rue;
            this._ville = ville;
            this._tel = tel;
            this._fax = fax;
            this._email = email;
            this._compte = compte;
            this._compteFar = compteFar;
            this._jrn = jrn;
            this._jrnFar = jrnFar;
            this._etat = etat;
        }
    }
}
