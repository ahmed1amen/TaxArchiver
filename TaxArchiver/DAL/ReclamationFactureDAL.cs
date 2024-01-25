using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000457 RID: 1111
    internal class ReclamationFactureDAL
    {
        // Token: 0x06004AA8 RID: 19112 RVA: 0x0022A43C File Offset: 0x0022863C
        public ReclamationFactureDAL()
        {
            this.dt = new DataTable();
            ReclamationFactureDAL._list = new List<ReclamationFacture>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                ReclamationFacture item = new ReclamationFacture(Convert.ToInt32(dataRow[0]), Convert.ToChar(dataRow[1].ToString()), Convert.ToDateTime(dataRow[2]), dataRow[3].ToString().Trim(), Convert.ToInt32(dataRow[4]));
                ReclamationFactureDAL._list.Add(item);
            }
        }

        // Token: 0x06004AA9 RID: 19113 RVA: 0x0022A514 File Offset: 0x00228714
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from reclamationfacture order by id");
        }

        // Token: 0x06004AAA RID: 19114 RVA: 0x0022A520 File Offset: 0x00228720
        public static List<ReclamationFacture> getReclamationFacture()
        {
            return ReclamationFactureDAL._list;
        }

        // Token: 0x06004AAB RID: 19115 RVA: 0x0022A528 File Offset: 0x00228728
        public static int addReclamationFacture(ReclamationFacture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO reclamationfacture( id, etat, heure, utilisateur, idservice)    VALUES (",
                l._id,
                " ,'",
                l._etat,
                "', '",
                l._dateReclamation,
                "','",
                l._utilisateur,
                "', ",
                l._idService,
                " ); "
            }));
        }

        // Token: 0x06004AAC RID: 19116 RVA: 0x0022A5BC File Offset: 0x002287BC
        public static string getRequestReclamationFacture(ReclamationFacture l)
        {
            return string.Concat(new object[]
            {
                "INSERT INTO reclamationfacture( id, etat, heure, utilisateur, idservice)    VALUES (",
                l._id,
                " ,'",
                l._etat,
                "', '",
                l._dateReclamation,
                "','",
                l._utilisateur,
                "' , ",
                l._idService,
                "  ); "
            });
        }

        // Token: 0x06004AAD RID: 19117 RVA: 0x0022A668 File Offset: 0x00228868
        public static ReclamationFacture getReclamationFacture(ReclamationFacture c)
        {
            return ReclamationFactureDAL._list.Find((ReclamationFacture bk) => bk._id == c._id);
        }

        // Token: 0x06004AAE RID: 19118 RVA: 0x0022A6B4 File Offset: 0x002288B4
        public ReclamationFacture getReclamationFacture(int c)
        {
            return ReclamationFactureDAL._list.Find((ReclamationFacture bk) => bk._id == c);
        }

        // Token: 0x06004AAF RID: 19119 RVA: 0x0022A710 File Offset: 0x00228910
        public List<ReclamationFacture> getReclamationFacture(int c, int ids)
        {
            List<ReclamationFacture> list = new List<ReclamationFacture>();
            return ReclamationFactureDAL._list.FindAll((ReclamationFacture bk) => bk._id == c && bk._idService == ids);
        }

        // Token: 0x04002CDD RID: 11485
        private DataTable dt;

        // Token: 0x04002CDE RID: 11486
        private static List<ReclamationFacture> _list;
    }
}
