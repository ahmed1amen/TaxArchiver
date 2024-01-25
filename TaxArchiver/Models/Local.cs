using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000054 RID: 84
    public class Local
    {
        // Token: 0x17000122 RID: 290
        // (get) Token: 0x060004FF RID: 1279 RVA: 0x00035F6A File Offset: 0x0003416A
        // (set) Token: 0x06000500 RID: 1280 RVA: 0x00035F72 File Offset: 0x00034172
        public int _id { get; set; }

        // Token: 0x17000123 RID: 291
        // (get) Token: 0x06000501 RID: 1281 RVA: 0x00035F7B File Offset: 0x0003417B
        // (set) Token: 0x06000502 RID: 1282 RVA: 0x00035F83 File Offset: 0x00034183
        public string _code { get; set; }

        // Token: 0x17000124 RID: 292
        // (get) Token: 0x06000503 RID: 1283 RVA: 0x00035F8C File Offset: 0x0003418C
        // (set) Token: 0x06000504 RID: 1284 RVA: 0x00035F94 File Offset: 0x00034194
        public string _libelle { get; set; }

        // Token: 0x17000125 RID: 293
        // (get) Token: 0x06000505 RID: 1285 RVA: 0x00035F9D File Offset: 0x0003419D
        // (set) Token: 0x06000506 RID: 1286 RVA: 0x00035FA5 File Offset: 0x000341A5
        public bool _etat { get; set; }

        // Token: 0x17000126 RID: 294
        // (get) Token: 0x06000507 RID: 1287 RVA: 0x00035FAE File Offset: 0x000341AE
        // (set) Token: 0x06000508 RID: 1288 RVA: 0x00035FB6 File Offset: 0x000341B6
        public List<Article> _listArticle { get; set; }

        // Token: 0x06000509 RID: 1289 RVA: 0x00035FBF File Offset: 0x000341BF
        public Local()
        {
            this._id = 0;
            this._libelle = "";
            this._code = "";
            this._etat = false;
            this._listArticle = new List<Article>();
        }

        // Token: 0x0600050A RID: 1290 RVA: 0x00035FF6 File Offset: 0x000341F6
        public Local(int id, string code, string libelle, bool etat)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._listArticle = new List<Article>();
        }

        // Token: 0x0600050B RID: 1291 RVA: 0x00036026 File Offset: 0x00034226
        public Local(int id, string code, string libelle, bool etat, List<Article> listArticle)
        {
            this._id = id;
            this._libelle = libelle;
            this._code = code;
            this._etat = etat;
            this._listArticle = listArticle;
        }

        // Token: 0x0600050C RID: 1292 RVA: 0x00036053 File Offset: 0x00034253
        public override string ToString()
        {
            return this._libelle;
        }
    }
}
