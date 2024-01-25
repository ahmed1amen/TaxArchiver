using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000404 RID: 1028
    public class ImprimanteDAL
    {
        // Token: 0x06004619 RID: 17945 RVA: 0x00218C70 File Offset: 0x00216E70
        public ImprimanteDAL()
        {
            this.dt = new DataTable();
            ImprimanteDAL._list = new List<Imprimante>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Imprimante item = new Imprimante(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToBoolean(dataRow[3]), Convert.ToBoolean(dataRow[4]), Convert.ToInt32(dataRow[5]), Convert.ToBoolean(dataRow[6]), dataRow[7].ToString().Trim());
                ImprimanteDAL._list.Add(item);
            }
        }

        // Token: 0x0600461A RID: 17946 RVA: 0x00218D74 File Offset: 0x00216F74
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from imprimante order by id");
        }

        // Token: 0x0600461B RID: 17947 RVA: 0x00218D80 File Offset: 0x00216F80
        public static List<Imprimante> getImprimante()
        {
            return ImprimanteDAL._list;
        }

        // Token: 0x0600461C RID: 17948 RVA: 0x00218D88 File Offset: 0x00216F88
        public static int addImprimante(Imprimante l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO imprimante( libelle, nomimprimante, imprimerdetail, etat,nombrecommande, kitchendisplay, ecran)    VALUES ('",
                l._libelle,
                "', '",
                l._nomImprimante,
                "',",
                l._imprimerDetail,
                ",",
                l._etat,
                ", ",
                l._nombrecommande,
                ", ",
                l._kitchenDisplay,
                ", '",
                l._ecran,
                "');select currval('",
                '"',
                "imprimante_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x0600461D RID: 17949 RVA: 0x00218E6C File Offset: 0x0021706C
        public static int updateImprimante(Imprimante l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE imprimante  SET  libelle='",
                l._libelle,
                "', nomimprimante='",
                l._nomImprimante,
                "', imprimerdetail= ",
                l._imprimerDetail,
                ", etat=",
                l._etat,
                ", nombrecommande=",
                l._nombrecommande,
                ", kitchendisplay=",
                l._kitchenDisplay,
                " , ecran = '",
                l._ecran,
                "' WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x0600461E RID: 17950 RVA: 0x00218F5C File Offset: 0x0021715C
        public static Imprimante getImprimante(Imprimante c)
        {
            return ImprimanteDAL._list.Find((Imprimante bk) => bk._id == c._id);
        }

        // Token: 0x0600461F RID: 17951 RVA: 0x00218FA8 File Offset: 0x002171A8
        public static Imprimante getImprimante(int c)
        {
            return ImprimanteDAL._list.Find((Imprimante bk) => bk._id == c);
        }

        // Token: 0x04002B48 RID: 11080
        private DataTable dt;

        // Token: 0x04002B49 RID: 11081
        private static List<Imprimante> _list;
    }
}
