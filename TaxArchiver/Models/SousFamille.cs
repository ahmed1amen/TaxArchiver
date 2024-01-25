using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000003 RID: 3
    public class SousFamille
    {
        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
        // (set) Token: 0x06000005 RID: 5 RVA: 0x0000207D File Offset: 0x0000027D
        public int _id { get; set; }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000006 RID: 6 RVA: 0x00002086 File Offset: 0x00000286
        // (set) Token: 0x06000007 RID: 7 RVA: 0x0000208E File Offset: 0x0000028E
        public string _code { get; set; }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000008 RID: 8 RVA: 0x00002097 File Offset: 0x00000297
        // (set) Token: 0x06000009 RID: 9 RVA: 0x0000209F File Offset: 0x0000029F
        public string _libelle { get; set; }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000A RID: 10 RVA: 0x000020A8 File Offset: 0x000002A8
        // (set) Token: 0x0600000B RID: 11 RVA: 0x000020B0 File Offset: 0x000002B0
        public Famille _famille { get; set; }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x0600000C RID: 12 RVA: 0x000020B9 File Offset: 0x000002B9
        // (set) Token: 0x0600000D RID: 13 RVA: 0x000020C1 File Offset: 0x000002C1
        public bool _interface { get; set; }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x0600000E RID: 14 RVA: 0x000020CA File Offset: 0x000002CA
        // (set) Token: 0x0600000F RID: 15 RVA: 0x000020D2 File Offset: 0x000002D2
        public bool _stockNull { get; set; }

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000010 RID: 16 RVA: 0x000020DB File Offset: 0x000002DB
        // (set) Token: 0x06000011 RID: 17 RVA: 0x000020E3 File Offset: 0x000002E3
        public string _compteStock { get; set; }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000012 RID: 18 RVA: 0x000020EC File Offset: 0x000002EC
        // (set) Token: 0x06000013 RID: 19 RVA: 0x000020F4 File Offset: 0x000002F4
        public string _compteAchat { get; set; }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000014 RID: 20 RVA: 0x000020FD File Offset: 0x000002FD
        // (set) Token: 0x06000015 RID: 21 RVA: 0x00002105 File Offset: 0x00000305
        public string _compteVariation { get; set; }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000016 RID: 22 RVA: 0x0000210E File Offset: 0x0000030E
        // (set) Token: 0x06000017 RID: 23 RVA: 0x00002116 File Offset: 0x00000316
        public bool _etat { get; set; }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000018 RID: 24 RVA: 0x0000211F File Offset: 0x0000031F
        // (set) Token: 0x06000019 RID: 25 RVA: 0x00002127 File Offset: 0x00000327
        public bool _appCategorieArticle { get; set; }

        // Token: 0x0600001A RID: 26 RVA: 0x00002130 File Offset: 0x00000330
        public SousFamille()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._famille = new Famille();
            this._etat = false;
            this._interface = false;
            this._stockNull = false;
            this._compteStock = "";
            this._compteAchat = "";
            this._compteVariation = "";
        }

        // Token: 0x0600001B RID: 27 RVA: 0x000021A4 File Offset: 0x000003A4
        public SousFamille(int id, string code, string libelle, Famille famille, bool interf, bool stockNull, string compteStock, string compteAchat, string compteVariation, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._famille = famille;
            this._interface = interf;
            this._stockNull = stockNull;
            this._compteStock = compteStock;
            this._compteAchat = compteAchat;
            this._compteVariation = compteVariation;
            this._etat = etat;
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002204 File Offset: 0x00000404
        public SousFamille(int id, string code, string libelle, Famille famille)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._famille = famille;
            this._interface = false;
            this._stockNull = false;
            this._compteStock = "";
            this._compteAchat = "";
            this._compteVariation = "";
            this._etat = false;
        }
    }
}
