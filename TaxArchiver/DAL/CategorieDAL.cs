using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    internal class CategorieDAL
    {
        // Token: 0x06001AFA RID: 6906 RVA: 0x000E5C7C File Offset: 0x000E3E7C
        public CategorieDAL()
        {
            this.dt = new DataTable();
            this.dt = this.getAll();
            CategorieDAL._list = new List<Categorie>();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Categorie item = new Categorie(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToBoolean(dataRow[3]));
                CategorieDAL._list.Add(item);
            }
        }

        // Token: 0x06001AFB RID: 6907 RVA: 0x000E5D48 File Offset: 0x000E3F48
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from categorie order by id");
        }

        // Token: 0x06001AFC RID: 6908 RVA: 0x000E5D54 File Offset: 0x000E3F54
        public static int addCategorie(Categorie l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO categorie(code, libelle, etat) VALUES ( '",
                l._code,
                "', '",
                l._libelle,
                "', ",
                l._etat,
                ");select currval('",
                '"',
                "categorie_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06001AFD RID: 6909 RVA: 0x000E5DDC File Offset: 0x000E3FDC
        public static int updateCategorie(Categorie l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE categorie SET  libelle='",
                l._libelle,
                "', etat=",
                l._etat,
                " WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06001AFE RID: 6910 RVA: 0x000E5E40 File Offset: 0x000E4040
        public static List<Categorie> getCategorie()
        {
            return CategorieDAL._list;
        }

        // Token: 0x06001AFF RID: 6911 RVA: 0x000E5E64 File Offset: 0x000E4064
        public static Categorie getCategorie(Categorie c)
        {
            return CategorieDAL._list.Find((Categorie bk) => bk._id == c._id);
        }

        // Token: 0x06001B00 RID: 6912 RVA: 0x000E5EB0 File Offset: 0x000E40B0
        public static Categorie getCategorie(int c)
        {
            return CategorieDAL._list.Find((Categorie bk) => bk._id == c);
        }

        // Token: 0x0400134F RID: 4943
        private DataTable dt;

        // Token: 0x04001350 RID: 4944
        private static List<Categorie> _list;
    }
}
