using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver
{
    public class ListDroit
    {
        // Token: 0x170013E0 RID: 5088
        // (get) Token: 0x060048ED RID: 18669 RVA: 0x00222AEC File Offset: 0x00220CEC
        // (set) Token: 0x060048EE RID: 18670 RVA: 0x00222AF4 File Offset: 0x00220CF4
        public int _id { get; set; }

        // Token: 0x170013E1 RID: 5089
        // (get) Token: 0x060048EF RID: 18671 RVA: 0x00222AFD File Offset: 0x00220CFD
        // (set) Token: 0x060048F0 RID: 18672 RVA: 0x00222B05 File Offset: 0x00220D05
        public string _libelle { get; set; }

        // Token: 0x170013E2 RID: 5090
        // (get) Token: 0x060048F1 RID: 18673 RVA: 0x00222B0E File Offset: 0x00220D0E
        // (set) Token: 0x060048F2 RID: 18674 RVA: 0x00222B16 File Offset: 0x00220D16
        public string _description { get; set; }

        // Token: 0x170013E3 RID: 5091
        // (get) Token: 0x060048F3 RID: 18675 RVA: 0x00222B1F File Offset: 0x00220D1F
        // (set) Token: 0x060048F4 RID: 18676 RVA: 0x00222B27 File Offset: 0x00220D27
        public int _niveau { get; set; }

        // Token: 0x060048F5 RID: 18677 RVA: 0x00222B30 File Offset: 0x00220D30
        public ListDroit()
        {
            this._id = 0;
            this._libelle = "";
            this._description = "";
            this._niveau = 0;
        }

        // Token: 0x060048F6 RID: 18678 RVA: 0x00222B5C File Offset: 0x00220D5C
        public ListDroit(int id, string libelle, string description, int niveau)
        {
            this._id = id;
            this._libelle = libelle;
            this._description = description;
            this._niveau = niveau;
        }
    }
}
