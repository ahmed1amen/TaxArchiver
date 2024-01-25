using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200009D RID: 157
    public class Famille
    {
        // Token: 0x170002D6 RID: 726
        // (get) Token: 0x06000A86 RID: 2694 RVA: 0x00062FD8 File Offset: 0x000611D8
        // (set) Token: 0x06000A87 RID: 2695 RVA: 0x00062FE0 File Offset: 0x000611E0
        public int _id { get; set; }

        // Token: 0x170002D7 RID: 727
        // (get) Token: 0x06000A88 RID: 2696 RVA: 0x00062FE9 File Offset: 0x000611E9
        // (set) Token: 0x06000A89 RID: 2697 RVA: 0x00062FF1 File Offset: 0x000611F1
        public string _code { get; set; }

        // Token: 0x170002D8 RID: 728
        // (get) Token: 0x06000A8A RID: 2698 RVA: 0x00062FFA File Offset: 0x000611FA
        // (set) Token: 0x06000A8B RID: 2699 RVA: 0x00063002 File Offset: 0x00061202
        public string _libelle { get; set; }

        // Token: 0x170002D9 RID: 729
        // (get) Token: 0x06000A8C RID: 2700 RVA: 0x0006300B File Offset: 0x0006120B
        // (set) Token: 0x06000A8D RID: 2701 RVA: 0x00063013 File Offset: 0x00061213
        public Categorie _categorie { get; set; }

        // Token: 0x170002DA RID: 730
        // (get) Token: 0x06000A8E RID: 2702 RVA: 0x0006301C File Offset: 0x0006121C
        // (set) Token: 0x06000A8F RID: 2703 RVA: 0x00063024 File Offset: 0x00061224
        public bool _etat { get; set; }

        // Token: 0x06000A90 RID: 2704 RVA: 0x0006302D File Offset: 0x0006122D
        public Famille()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._categorie = new Categorie();
            this._etat = false;
        }

        // Token: 0x06000A91 RID: 2705 RVA: 0x00063064 File Offset: 0x00061264
        public Famille(int id, string code, string libelle, Categorie categorie, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._categorie = categorie;
            this._etat = etat;
        }
    }
}
