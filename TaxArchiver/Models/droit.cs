using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    public class Droit
    {
        // Token: 0x170014DD RID: 5341
        // (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0022FFFC File Offset: 0x0022E1FC
        // (set) Token: 0x06004BF4 RID: 19444 RVA: 0x00230004 File Offset: 0x0022E204
        public int _id { get; set; }

        // Token: 0x170014DE RID: 5342
        // (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0023000D File Offset: 0x0022E20D
        // (set) Token: 0x06004BF6 RID: 19446 RVA: 0x00230015 File Offset: 0x0022E215
        public ListDroit _listDroit { get; set; }

        // Token: 0x170014DF RID: 5343
        // (get) Token: 0x06004BF7 RID: 19447 RVA: 0x0023001E File Offset: 0x0022E21E
        // (set) Token: 0x06004BF8 RID: 19448 RVA: 0x00230026 File Offset: 0x0022E226
        public bool _droit { get; set; }

        // Token: 0x06004BF9 RID: 19449 RVA: 0x0023002F File Offset: 0x0022E22F
        public Droit()
        {
            this._id = 0;
            this._listDroit = new ListDroit();
            this._droit = false;
        }

        // Token: 0x06004BFA RID: 19450 RVA: 0x00230050 File Offset: 0x0022E250
        public Droit(int id, ListDroit listDroit, bool droit)
        {
            this._id = id;
            this._listDroit = listDroit;
            this._droit = droit;
        }
    }

    public class ListDroit
    {
        // Token: 0x170013E0 RID: 5088
        // (get) Token: 0x060048EF RID: 18671 RVA: 0x00222D68 File Offset: 0x00220F68
        // (set) Token: 0x060048F0 RID: 18672 RVA: 0x00222D70 File Offset: 0x00220F70
        public int _id { get; set; }

        // Token: 0x170013E1 RID: 5089
        // (get) Token: 0x060048F1 RID: 18673 RVA: 0x00222D79 File Offset: 0x00220F79
        // (set) Token: 0x060048F2 RID: 18674 RVA: 0x00222D81 File Offset: 0x00220F81
        public string _libelle { get; set; }

        // Token: 0x170013E2 RID: 5090
        // (get) Token: 0x060048F3 RID: 18675 RVA: 0x00222D8A File Offset: 0x00220F8A
        // (set) Token: 0x060048F4 RID: 18676 RVA: 0x00222D92 File Offset: 0x00220F92
        public string _description { get; set; }

        // Token: 0x170013E3 RID: 5091
        // (get) Token: 0x060048F5 RID: 18677 RVA: 0x00222D9B File Offset: 0x00220F9B
        // (set) Token: 0x060048F6 RID: 18678 RVA: 0x00222DA3 File Offset: 0x00220FA3
        public int _niveau { get; set; }

        // Token: 0x060048F7 RID: 18679 RVA: 0x00222DAC File Offset: 0x00220FAC
        public ListDroit()
        {
            this._id = 0;
            this._libelle = "";
            this._description = "";
            this._niveau = 0;
        }

        // Token: 0x060048F8 RID: 18680 RVA: 0x00222DD8 File Offset: 0x00220FD8
        public ListDroit(int id, string libelle, string description, int niveau)
        {
            this._id = id;
            this._libelle = libelle;
            this._description = description;
            this._niveau = niveau;
        }
    }
}
