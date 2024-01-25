using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000376 RID: 886
    public class UtilisateurDAL
    {
        // Token: 0x06003CC6 RID: 15558 RVA: 0x001CAD90 File Offset: 0x001C8F90
        public UtilisateurDAL()
        {
            DataTable dataTable = new DataTable();
            UtilisateurDAL._droitDal = new DroitDAL();
            UtilisateurDAL._list = new List<Utilisateur>();
            dataTable = this.getAll();
            Utilisateur item = new Utilisateur();
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                item = new Utilisateur(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToBoolean(dataRow[3]), UtilisateurDAL._droitDal.getDroits((int)Convert.ToInt16(dataRow[0])), dataRow[4].ToString().Trim());
                UtilisateurDAL._list.Add(item);
            }
        }

        // Token: 0x06003CC7 RID: 15559 RVA: 0x001CAE88 File Offset: 0x001C9088
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from utilisateur order by id");
        }

        // Token: 0x06003CC8 RID: 15560 RVA: 0x001CAE94 File Offset: 0x001C9094
        public DataTable getAll(int id)
        {
            return Connexion.executeQuery("select * from utilisateur where id=" + id);
        }

        // Token: 0x06003CC9 RID: 15561 RVA: 0x001CAEC4 File Offset: 0x001C90C4
        public static Utilisateur getUtilisateur(int id)
        {
            return UtilisateurDAL._list.Find((Utilisateur bk) => bk._id == id);
        }

        // Token: 0x06003CCA RID: 15562 RVA: 0x001CAEF6 File Offset: 0x001C90F6
        public static List<Utilisateur> getUtilisateur()
        {
            return UtilisateurDAL._list;
        }

        // Token: 0x06003CCB RID: 15563 RVA: 0x001CAF00 File Offset: 0x001C9100
        public static int addUtilisateur(Utilisateur utilisateur)
        {
            UtilisateurDAL._droitDal = new DroitDAL();
            int num = Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO utilisateur( login, password, etat,cledallas) VALUES ('",
                utilisateur._login,
                "','",
                utilisateur._password,
                "',",
                utilisateur._etat,
                ",'",
                utilisateur._cleDallas,
                "');select currval('",
                '"',
                "utilisateur_id_seq",
                '"',
                "');"
            }));
            utilisateur._id = num;
            UtilisateurDAL._droitDal.addDroits(utilisateur);
            return num;
        }

        // Token: 0x06003CCC RID: 15564 RVA: 0x001CAFB8 File Offset: 0x001C91B8
        public static int updateUtilisateur(Utilisateur utilisateur)
        {
            UtilisateurDAL._droitDal = new DroitDAL();
            string text = string.Concat(new object[]
            {
                "Delete from droit where  idutilisateur=",
                utilisateur._id,
                "; UPDATE utilisateur SET login='",
                utilisateur._login,
                "', password='",
                utilisateur._password,
                "', etat=",
                utilisateur._etat,
                ", cledallas='",
                utilisateur._cleDallas,
                "' where id=",
                utilisateur._id,
                "; "
            });
            text += UtilisateurDAL._droitDal.addDroit(utilisateur);
            Console.WriteLine(text);
            return Connexion.executeScalar(text);
        }

        // Token: 0x06003CCD RID: 15565 RVA: 0x001CB084 File Offset: 0x001C9284
        public static int updateMotDePasse(Utilisateur utilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE utilisateur SET  password='",
                utilisateur._password,
                "' where id=",
                utilisateur._id,
                "; "
            }));
        }

        // Token: 0x06003CCE RID: 15566 RVA: 0x001CB0D4 File Offset: 0x001C92D4
        public static int updateDallas(Utilisateur utilisateur)
        {
            UtilisateurDAL._droitDal = new DroitDAL();
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE utilisateur SET   cledallas='",
                utilisateur._cleDallas,
                "' where id=",
                utilisateur._id,
                "; "
            }));
        }

        // Token: 0x0400262E RID: 9774
        private static DroitDAL _droitDal;

        // Token: 0x0400262F RID: 9775
        private static List<Utilisateur> _list;
    }
}
