using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static TaxArchiver.Models.FamilleCarte;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    internal class FamilleCarteDAL
    {
        // Token: 0x0600482A RID: 18474 RVA: 0x00221704 File Offset: 0x0021F904
        public FamilleCarteDAL()
        {
            this.dt = new DataTable();
            FamilleCarteDAL._list = new List<FamilleCarte>();
            new PointDeVenteDAL(true, "", false);
            FamilleMessageDAL familleMessageDAL = new FamilleMessageDAL();
            CategorieCarteDAL categorieCarteDAL = new CategorieCarteDAL();
            FamilleMessage familleMessage = new FamilleMessage();
            CategorieCarte categorieCarte = new CategorieCarte();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                PointDeVente pointVente = PointDeVenteDAL.getPointVente(Convert.ToInt32(dataRow[2]));
                if (Convert.ToInt32(dataRow[8]) != 0)
                {
                    familleMessage = familleMessageDAL.getFamilleMessage(Convert.ToInt32(dataRow[8]));
                }
                else
                {
                    familleMessage = new FamilleMessage();
                }
                if (Convert.ToInt32(dataRow[9]) != 0)
                {
                    categorieCarte = categorieCarteDAL.getCategorieCarte(Convert.ToInt32(dataRow[9]));
                }
                else
                {
                    categorieCarte = new CategorieCarte();
                }
                FamilleCarte item = new FamilleCarte(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), pointVente, new List<Produit>(), Convert.ToInt32(dataRow[4]), dataRow[5].ToString(), Convert.ToBoolean(dataRow[6]), Convert.ToBoolean(dataRow[7]), familleMessage, categorieCarte);
                FamilleCarteDAL._list.Add(item);
            }
        }

        // Token: 0x0600482B RID: 18475 RVA: 0x00221894 File Offset: 0x0021FA94
        public FamilleCarteDAL(bool WithSubItems)
        {
            this.dt = new DataTable();
            FamilleCarteDAL._list = new List<FamilleCarte>();
            this.dt = this.getWithoutSubItems();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                FamilleCarte item = new FamilleCarte(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim());
                FamilleCarteDAL._list.Add(item);
            }
        }

        // Token: 0x0600482C RID: 18476 RVA: 0x00221940 File Offset: 0x0021FB40
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from famillecarte order by ordre");
        }

        // Token: 0x0600482D RID: 18477 RVA: 0x0022194C File Offset: 0x0021FB4C
        private DataTable getWithoutSubItems()
        {
            return Connexion.executeQuery("select id,libelle from famillecarte order by ordre");
        }

        // Token: 0x0600482E RID: 18478 RVA: 0x00221958 File Offset: 0x0021FB58
        public static List<FamilleCarte> getFamilleCarte()
        {
            return FamilleCarteDAL._list;
        }

        // Token: 0x0600482F RID: 18479 RVA: 0x00221960 File Offset: 0x0021FB60
        public static int addFamilleCarte(FamilleCarte l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO famillecarte( libelle, idpointdevente, libellepointdevente, ordre, couleur,etat , msgobligatoire , idfamillemessage, idcategoriecarte) VALUES ('",
                l._libelle,
                "', ",
                l._pointDeVente._id,
                ",'",
                l._pointDeVente._libelle,
                "', ",
                l._ordre,
                ", '",
                l._couleur,
                "', ",
                l._etat,
                " , ",
                l._msgObligatoire,
                ", ",
                l._familleMessage._id,
                ", ",
                l._categorieCarte._id,
                ");select currval('",
                '"',
                "famillecarte_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06004830 RID: 18480 RVA: 0x00221A88 File Offset: 0x0021FC88
        public static int updateFamilleCarte(FamilleCarte l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE famillecarte SET  libelle='",
                l._libelle,
                "', idpointdevente=",
                l._pointDeVente._id,
                ", libellepointdevente='",
                l._pointDeVente._libelle,
                "', ordre=",
                l._ordre,
                ", couleur='",
                l._couleur,
                "', etat=",
                l._etat,
                ", msgobligatoire=",
                l._msgObligatoire,
                ",idcategoriecarte =",
                l._categorieCarte._id,
                ", idfamillemessage=",
                l._familleMessage._id,
                " where id=",
                l._id
            }));
        }

        // Token: 0x06004831 RID: 18481 RVA: 0x00221B94 File Offset: 0x0021FD94
        public static List<FamilleCarte> getListFamilleCarte(PointDeVente d)
        {
            return FamilleCarteDAL.getListFamilleCarte(d._id);
        }

        // Token: 0x06004832 RID: 18482 RVA: 0x00221BBC File Offset: 0x0021FDBC
        public static FamilleCarte getFamilleCarteById(int id)
        {
            FamilleCarte familleCarte = new FamilleCarte();
            return FamilleCarteDAL._list.Find((FamilleCarte bk) => bk._id == id);
        }

        // Token: 0x06004833 RID: 18483 RVA: 0x00221C14 File Offset: 0x0021FE14
        public static List<FamilleCarte> getListFamilleCarte(int id)
        {
            List<FamilleCarte> list = new List<FamilleCarte>();
            return FamilleCarteDAL._list.FindAll((FamilleCarte bk) => bk._pointDeVente._id == id);
        }

        // Token: 0x06004834 RID: 18484 RVA: 0x00221C64 File Offset: 0x0021FE64
        public FamilleCarte getFamilleCarte(int c)
        {
            return FamilleCarteDAL._list.Find((FamilleCarte bk) => bk._id == c);
        }

        // Token: 0x04002BFE RID: 11262
        private DataTable dt;

        // Token: 0x04002BFF RID: 11263
        private static List<FamilleCarte> _list;
    }
}
