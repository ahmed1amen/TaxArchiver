using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    internal class TvaDAL
    {
        // Token: 0x060004E9 RID: 1257 RVA: 0x000356A4 File Offset: 0x000338A4
        public TvaDAL()
        {
            this.dt = new DataTable();
            this.dt = this.getAll();
            TvaDAL._list = new List<Tva>();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Tva item = new Tva(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToBoolean(dataRow[4]));
                TvaDAL._list.Add(item);
            }
        }

        // Token: 0x060004EA RID: 1258 RVA: 0x0003577C File Offset: 0x0003397C
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from tva order by id");
        }

        // Token: 0x060004EB RID: 1259 RVA: 0x00035788 File Offset: 0x00033988
        public static int addTva(Tva l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO tva(code, libelle,taux, etat) VALUES ( '",
                l._code,
                "', '",
                l._libelle,
                "',",
                l._taux,
                ", ",
                l._etat,
                ");select currval('",
                '"',
                "tva_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x060004EC RID: 1260 RVA: 0x00035828 File Offset: 0x00033A28
        public static int updateTva(Tva l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE tva SET  libelle='",
                l._libelle,
                "', etat=",
                l._etat,
                " WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x060004ED RID: 1261 RVA: 0x0003588C File Offset: 0x00033A8C
        public static List<Tva> getTva()
        {
            return TvaDAL._list;
        }

        // Token: 0x060004EE RID: 1262 RVA: 0x000358B0 File Offset: 0x00033AB0
        public static Tva getTva(Tva c)
        {
            return TvaDAL._list.Find((Tva bk) => bk._id == c._id);
        }

        // Token: 0x060004EF RID: 1263 RVA: 0x000358FC File Offset: 0x00033AFC
        public static Tva getTva(int c)
        {
            return TvaDAL._list.Find((Tva bk) => bk._id == c);
        }

        // Token: 0x0400044A RID: 1098
        private DataTable dt;

        // Token: 0x0400044B RID: 1099
        private static List<Tva> _list;
    }
}
