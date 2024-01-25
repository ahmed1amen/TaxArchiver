using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;

namespace TaxArchiver.Models
{
    // Token: 0x0200045F RID: 1119
    public class ReclamationFacture
    {
        // Token: 0x17001479 RID: 5241
        // (get) Token: 0x06004B1A RID: 19226 RVA: 0x0022E682 File Offset: 0x0022C882
        // (set) Token: 0x06004B1B RID: 19227 RVA: 0x0022E68A File Offset: 0x0022C88A
        public int _id { get; set; }

        // Token: 0x1700147A RID: 5242
        // (get) Token: 0x06004B1C RID: 19228 RVA: 0x0022E693 File Offset: 0x0022C893
        // (set) Token: 0x06004B1D RID: 19229 RVA: 0x0022E69B File Offset: 0x0022C89B
        public char _etat { get; set; }

        // Token: 0x1700147B RID: 5243
        // (get) Token: 0x06004B1E RID: 19230 RVA: 0x0022E6A4 File Offset: 0x0022C8A4
        // (set) Token: 0x06004B1F RID: 19231 RVA: 0x0022E6AC File Offset: 0x0022C8AC
        public DateTime _dateReclamation { get; set; }

        // Token: 0x1700147C RID: 5244
        // (get) Token: 0x06004B20 RID: 19232 RVA: 0x0022E6B5 File Offset: 0x0022C8B5
        // (set) Token: 0x06004B21 RID: 19233 RVA: 0x0022E6BD File Offset: 0x0022C8BD
        public string _utilisateur { get; set; }

        // Token: 0x1700147D RID: 5245
        // (get) Token: 0x06004B22 RID: 19234 RVA: 0x0022E6C6 File Offset: 0x0022C8C6
        // (set) Token: 0x06004B23 RID: 19235 RVA: 0x0022E6CE File Offset: 0x0022C8CE
        public int _idService { get; set; }

        // Token: 0x06004B24 RID: 19236 RVA: 0x0022E6D7 File Offset: 0x0022C8D7
        public ReclamationFacture()
        {
            this._id = 0;
            this._etat = 'E';
            this._dateReclamation = DateTime.Now;
            this._utilisateur = "";
            this._idService = 0;
        }

        // Token: 0x06004B25 RID: 19237 RVA: 0x0022E70B File Offset: 0x0022C90B
        public ReclamationFacture(int id, char etat, DateTime dateReclamation, string utilisateur, int idService)
        {
            this._id = id;
            this._etat = etat;
            this._dateReclamation = dateReclamation;
            this._utilisateur = utilisateur;
            this._idService = idService;
        }
    }
}
