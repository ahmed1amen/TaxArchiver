using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200045B RID: 1115
    internal class CategorieCarteDAL
    {
        // Token: 0x06004AFA RID: 19194 RVA: 0x0022D8AC File Offset: 0x0022BAAC
        public CategorieCarteDAL()
        {
            this.dt = new DataTable();
            CategorieCarteDAL._list = new List<CategorieCarte>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                CategorieCarte item = new CategorieCarte(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), new PointDeVente(Convert.ToInt32(dataRow[2])), Convert.ToBoolean(dataRow[3]), dataRow[4].ToString().Trim(), Convert.ToInt32(dataRow[5]));
                CategorieCarteDAL._list.Add(item);
            }
        }

        // Token: 0x06004AFB RID: 19195 RVA: 0x0022D994 File Offset: 0x0022BB94
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from categoriecarte order by ordre,id");
        }

        // Token: 0x06004AFC RID: 19196 RVA: 0x0022D9A0 File Offset: 0x0022BBA0
        public static List<CategorieCarte> getCategorieCarte()
        {
            return CategorieCarteDAL._list;
        }

        // Token: 0x06004AFD RID: 19197 RVA: 0x0022D9A8 File Offset: 0x0022BBA8
        public static int addCategorieCarte(CategorieCarte l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO categoriecarte( libelle,  idpointdevente , etat, couleur, ordre)    VALUES ('",
                l._libelle,
                "', ",
                l._pointDeVente._id,
                ",",
                l._etat,
                ",'",
                l._couleur,
                "', ",
                l._ordre,
                ");select currval('",
                '"',
                "categoriecarte_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06004AFE RID: 19198 RVA: 0x0022DA64 File Offset: 0x0022BC64
        public static int updateCategorieCarte(CategorieCarte l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE categoriecarte  SET  libelle='",
                l._libelle,
                "', idpointdevente= ",
                l._pointDeVente._id,
                ", etat=",
                l._etat,
                ", couleur='",
                l._couleur,
                "', ordre=",
                l._ordre,
                " WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06004AFF RID: 19199 RVA: 0x0022DB0F File Offset: 0x0022BD0F
        public static List<CategorieCarte> getListCategorieCarte(PointDeVente d)
        {
            return CategorieCarteDAL.getListCategorieCarte(d._id);
        }

        // Token: 0x06004B00 RID: 19200 RVA: 0x0022DB3C File Offset: 0x0022BD3C
        public static List<CategorieCarte> getListCategorieCarte(int id)
        {
            List<CategorieCarte> list = new List<CategorieCarte>();
            return CategorieCarteDAL._list.FindAll((CategorieCarte bk) => bk._pointDeVente._id == id);
        }

        // Token: 0x06004B01 RID: 19201 RVA: 0x0022DB94 File Offset: 0x0022BD94
        public static CategorieCarte getCategorieCarte(CategorieCarte c)
        {
            return CategorieCarteDAL._list.Find((CategorieCarte bk) => bk._id == c._id);
        }

        // Token: 0x06004B02 RID: 19202 RVA: 0x0022DBE0 File Offset: 0x0022BDE0
        public CategorieCarte getCategorieCarte(int c)
        {
            return CategorieCarteDAL._list.Find((CategorieCarte bk) => bk._id == c);
        }

        // Token: 0x04002CF0 RID: 11504
        private DataTable dt;

        // Token: 0x04002CF1 RID: 11505
        private static List<CategorieCarte> _list;
    }
}
