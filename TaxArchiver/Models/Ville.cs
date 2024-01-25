using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200043B RID: 1083
    public class Ville
    {
        // Token: 0x170013E4 RID: 5092
        // (get) Token: 0x060048F9 RID: 18681 RVA: 0x00222DFD File Offset: 0x00220FFD
        // (set) Token: 0x060048FA RID: 18682 RVA: 0x00222E05 File Offset: 0x00221005
        public int _id { get; set; }

        // Token: 0x170013E5 RID: 5093
        // (get) Token: 0x060048FB RID: 18683 RVA: 0x00222E0E File Offset: 0x0022100E
        // (set) Token: 0x060048FC RID: 18684 RVA: 0x00222E16 File Offset: 0x00221016
        public string _code { get; set; }

        // Token: 0x170013E6 RID: 5094
        // (get) Token: 0x060048FD RID: 18685 RVA: 0x00222E1F File Offset: 0x0022101F
        // (set) Token: 0x060048FE RID: 18686 RVA: 0x00222E27 File Offset: 0x00221027
        public string _libelle { get; set; }

        // Token: 0x170013E7 RID: 5095
        // (get) Token: 0x060048FF RID: 18687 RVA: 0x00222E30 File Offset: 0x00221030
        // (set) Token: 0x06004900 RID: 18688 RVA: 0x00222E38 File Offset: 0x00221038
        public bool _etat { get; set; }

        // Token: 0x170013E8 RID: 5096
        // (get) Token: 0x06004901 RID: 18689 RVA: 0x00222E41 File Offset: 0x00221041
        // (set) Token: 0x06004902 RID: 18690 RVA: 0x00222E49 File Offset: 0x00221049
        public Pays _pays { get; set; }

        // Token: 0x06004903 RID: 18691 RVA: 0x00222E52 File Offset: 0x00221052
        public Ville()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._pays = new Pays();
            this._etat = false;
        }

        // Token: 0x06004904 RID: 18692 RVA: 0x00222E89 File Offset: 0x00221089
        public Ville(int id, string code, string libelle, Pays pays, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._pays = pays;
            this._etat = etat;
        }
    }
}
