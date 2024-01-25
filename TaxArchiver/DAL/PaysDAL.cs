using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000052 RID: 82
    public class PaysDAL
    {
        // Token: 0x060004F0 RID: 1264 RVA: 0x00035930 File Offset: 0x00033B30
        public PaysDAL()
        {
            this.dt = new DataTable();
            this.dt = this.getAll();
            PaysDAL._list = new List<Pays>();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Pays item = new Pays(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToBoolean(dataRow[3]), dataRow[4].ToString().Trim());
                PaysDAL._list.Add(item);
            }
        }

        // Token: 0x060004F1 RID: 1265 RVA: 0x00035A0C File Offset: 0x00033C0C
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from pays order by id");
        }

        // Token: 0x060004F2 RID: 1266 RVA: 0x00035A18 File Offset: 0x00033C18
        public int addPays(Pays l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO pays(code, libelle, etat,indicatif) VALUES ( '",
                l._code,
                "', '",
                l._libelle,
                "', ",
                l._etat,
                ", '",
                l._indicatif,
                "');select currval('",
                '"',
                "pays_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x060004F3 RID: 1267 RVA: 0x00035AB4 File Offset: 0x00033CB4
        public static int updatePays(Pays l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE pays SET  libelle='",
                l._libelle,
                "', etat=",
                l._etat,
                " , indicatif='",
                l._indicatif,
                "' WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x060004F4 RID: 1268 RVA: 0x00035B2A File Offset: 0x00033D2A
        public static List<Pays> getPays()
        {
            return PaysDAL._list;
        }

        // Token: 0x060004F5 RID: 1269 RVA: 0x00035B50 File Offset: 0x00033D50
        public static Pays getPays(Pays c)
        {
            return PaysDAL._list.Find((Pays bk) => bk._id == c._id);
        }

        // Token: 0x060004F6 RID: 1270 RVA: 0x00035B9C File Offset: 0x00033D9C
        public static Pays getPays(int c)
        {
            return PaysDAL._list.Find((Pays bk) => bk._id == c);
        }

        // Token: 0x0400044C RID: 1100
        private DataTable dt;

        // Token: 0x0400044D RID: 1101
        private static List<Pays> _list;
    }
}
