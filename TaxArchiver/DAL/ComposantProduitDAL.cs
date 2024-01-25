using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200045A RID: 1114
    internal class ComposantProduitDAL
    {
        // Token: 0x06004AF1 RID: 19185 RVA: 0x0022D488 File Offset: 0x0022B688
        public ComposantProduitDAL()
        {
            this.dt = new DataTable();
            ComposantProduitDAL._list = new List<ComposantProduit>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                ComposantProduit item = new ComposantProduit(new Produit(Convert.ToInt32(dataRow[0]), "", ""), new FamilleMenu(Convert.ToInt32(dataRow[1]), dataRow[4].ToString().Trim()), Convert.ToInt32(dataRow[2]), Convert.ToBoolean(dataRow[3]));
                ComposantProduitDAL._list.Add(item);
            }
        }

        // Token: 0x06004AF2 RID: 19186 RVA: 0x0022D56C File Offset: 0x0022B76C
        private DataTable getAll()
        {
            return Connexion.executeQuery("select composantproduit.*, famillemenu.libelle from composantproduit,famillemenu where composantproduit.idfamille=famillemenu.id order by famillemenu.ordre ");
        }

        // Token: 0x06004AF3 RID: 19187 RVA: 0x0022D578 File Offset: 0x0022B778
        public static List<ComposantProduit> getComposantProduit()
        {
            return ComposantProduitDAL._list;
        }

        // Token: 0x06004AF4 RID: 19188 RVA: 0x0022D580 File Offset: 0x0022B780
        public static int composantProduitAdd(List<ComposantProduit> d)
        {
            string text = "";
            foreach (ComposantProduit composantProduit in d)
            {
                if (composantProduit._deleted)
                {
                    text += ComposantProduitDAL.getRequestDelete(composantProduit);
                }
                else
                {
                    text += ComposantProduitDAL.getRequestAdd(composantProduit);
                }
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06004AF5 RID: 19189 RVA: 0x0022D5F8 File Offset: 0x0022B7F8
        public static int composantProduitAdd(ComposantProduit d)
        {
            string text = "";
            if (d._deleted)
            {
                text += ComposantProduitDAL.getRequestDelete(d);
            }
            else
            {
                text += ComposantProduitDAL.getRequestAdd(d);
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06004AF6 RID: 19190 RVA: 0x0022D638 File Offset: 0x0022B838
        private static string getRequestAdd(ComposantProduit f)
        {
            int num = Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from composantproduit where idproduit=",
                f._produit._id,
                " and idfamille=",
                f._familleMenu._id,
                " ; "
            }));
            string result = " ";
            if (num == 0)
            {
                result = string.Concat(new object[]
                {
                    " INSERT INTO composantproduit(idproduit, idfamille, nombreproduit, obligatoire) VALUES ( ",
                    f._produit._id,
                    ", ",
                    f._familleMenu._id,
                    ", ",
                    f._nombreProduit,
                    " , ",
                    f._obligatoire,
                    "); "
                });
            }
            else if (num == 1)
            {
                result = string.Concat(new object[]
                {
                    " UPDATE composantproduit SET  nombreproduit=",
                    f._nombreProduit,
                    ", obligatoire=",
                    f._obligatoire,
                    "  WHERE idproduit=",
                    f._produit._id,
                    " and idfamille=",
                    f._familleMenu._id,
                    "  ; "
                });
            }
            return result;
        }

        // Token: 0x06004AF7 RID: 19191 RVA: 0x0022D7AC File Offset: 0x0022B9AC
        private static string getRequestDelete(ComposantProduit f)
        {
            return string.Concat(new object[]
            {
                " DELETE FROM composantproduit WHERE idproduit=",
                f._produit._id,
                " and idfamille=",
                f._familleMenu._id,
                " ; "
            });
        }

        // Token: 0x06004AF8 RID: 19192 RVA: 0x0022D828 File Offset: 0x0022BA28
        public static List<ComposantProduit> getComposantProduitByProduit(Produit c)
        {
            return ComposantProduitDAL._list.FindAll((ComposantProduit bk) => bk._produit._id == c._id);
        }

        // Token: 0x06004AF9 RID: 19193 RVA: 0x0022D878 File Offset: 0x0022BA78
        public List<ComposantProduit> getComposantProduitByIdProduit(int c)
        {
            return ComposantProduitDAL._list.FindAll((ComposantProduit bk) => bk._produit._id == c);
        }

        // Token: 0x04002CEE RID: 11502
        private DataTable dt;

        // Token: 0x04002CEF RID: 11503
        private static List<ComposantProduit> _list;
    }
}
