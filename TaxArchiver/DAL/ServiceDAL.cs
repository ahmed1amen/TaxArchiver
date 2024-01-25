using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200022F RID: 559
    public class ServiceDAL
    {
        // Token: 0x060026CD RID: 9933 RVA: 0x00144ACC File Offset: 0x00142CCC
        public ServiceDAL()
        {
            this.dt = new DataTable();
            ServiceDAL._list = new List<Service>();
            new PointDeVenteDAL(true, "", false);
            new ImprimanteDAL();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Imprimante imprimante;
                if (Convert.ToInt32(dataRow[9]) == 0)
                {
                    imprimante = new Imprimante();
                }
                else
                {
                    imprimante = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[9]));
                }
                Imprimante imprimante2;
                if (Convert.ToInt32(dataRow[12]) == 0)
                {
                    imprimante2 = new Imprimante();
                }
                else
                {
                    imprimante2 = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[12]));
                }
                PointDeVente pointVente = PointDeVenteDAL.getPointVente(Convert.ToInt32(dataRow[7]));
                DateTime dateOuverture = default(DateTime);
                if (dataRow[3] != DBNull.Value)
                {
                    dateOuverture = Convert.ToDateTime(dataRow[3]);
                }
                Service item = new Service(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToBoolean(dataRow[2]), dateOuverture, new Departement(), new Departement(), new Departement(), pointVente, Convert.ToBoolean(dataRow[8]), imprimante, Convert.ToBoolean(dataRow[10]), Convert.ToBoolean(dataRow[11]), imprimante2);
                ServiceDAL._list.Add(item);
            }
        }

        // Token: 0x060026CE RID: 9934 RVA: 0x00144C84 File Offset: 0x00142E84
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from service order by id");
        }

        // Token: 0x060026CF RID: 9935 RVA: 0x00144C90 File Offset: 0x00142E90
        public static List<Service> getService()
        {
            return ServiceDAL._list;
        }

        // Token: 0x060026D0 RID: 9936 RVA: 0x00144C98 File Offset: 0x00142E98
        public static int addService(Service l)
        {
            Console.WriteLine(string.Concat(new object[]
            {
                "INSERT INTO service( libelle, ouvert, iddepartementnourriture, iddepartementboisson, iddepartementdivers, idpointvente, imprimercommande, idimprimante, etat, imprimercommandenourriture, idimprimante2) VALUES ( '",
                l._libelle,
                "',",
                l._ouvert,
                ", ",
                l._departementNourriture._id,
                ", ",
                l._departementBoisson._id,
                ",",
                l._departementDiver._id,
                ", ",
                l._pointDeVente._id,
                ", ",
                l._imprimerCommande,
                ", ",
                l._imprimante._id,
                ", ",
                l._etat,
                ", imprimercommandenourriture=",
                l._imprimerCommandeNourriture,
                ", ",
                l._imprimante2._id,
                ");select currval('",
                '"',
                "service_id_seq",
                '"',
                "');"
            }));
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO service( libelle, ouvert, iddepartementnourriture, iddepartementboisson, iddepartementdivers, idpointvente, imprimercommande, idimprimante, etat, imprimercommandenourriture, idimprimante2) VALUES ( '",
                l._libelle,
                "',",
                l._ouvert,
                ", ",
                l._departementNourriture._id,
                ", ",
                l._departementBoisson._id,
                ",",
                l._departementDiver._id,
                ", ",
                l._pointDeVente._id,
                ", ",
                l._imprimerCommande,
                ", ",
                l._imprimante._id,
                ", ",
                l._etat,
                ", ",
                l._imprimerCommandeNourriture,
                ", ",
                l._imprimante2._id,
                ");select currval('",
                '"',
                "service_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x060026D1 RID: 9937 RVA: 0x00144F60 File Offset: 0x00143160
        public static int updateService(Service l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE service SET  libelle='",
                l._libelle,
                "', ouvert=",
                l._ouvert,
                ", dateouverture='",
                l._dateOuverture,
                "', iddepartementnourriture=",
                l._departementNourriture._id,
                ", iddepartementboisson=",
                l._departementBoisson._id,
                ", iddepartementdivers=",
                l._departementDiver._id,
                ", idpointvente=",
                l._pointDeVente._id,
                ", imprimercommande=",
                l._imprimerCommande,
                ", idimprimante=",
                l._imprimante._id,
                ", etat=",
                l._etat,
                " ,imprimercommandenourriture=",
                l._imprimerCommandeNourriture,
                ", idimprimante2=",
                l._imprimante2._id,
                "   where id=",
                l._id
            }));
        }

        // Token: 0x060026D2 RID: 9938 RVA: 0x001450C8 File Offset: 0x001432C8
        public static List<Service> getListService()
        {
            return ServiceDAL._list;
        }

        // Token: 0x060026D3 RID: 9939 RVA: 0x001450CF File Offset: 0x001432CF
        public static List<Service> getListService(PointDeVente d)
        {
            return ServiceDAL.getListService(d._id);
        }

        // Token: 0x060026D4 RID: 9940 RVA: 0x001450FC File Offset: 0x001432FC
        public static List<Service> getListService(int id)
        {
            List<Service> list = new List<Service>();
            return ServiceDAL._list.FindAll((Service bk) => bk._pointDeVente._id == id);
        }

        // Token: 0x060026D5 RID: 9941 RVA: 0x0014513C File Offset: 0x0014333C
        public static Service getListServiceOuvert()
        {
            return ServiceDAL._list.FirstOrDefault((Service bk) => bk._ouvert);
        }

        // Token: 0x060026D6 RID: 9942 RVA: 0x00145190 File Offset: 0x00143390
        public Service getService(Service c)
        {
            return ServiceDAL._list.Find((Service bk) => bk._id == c._id);
        }

        // Token: 0x060026D7 RID: 9943 RVA: 0x001451DC File Offset: 0x001433DC
        public static Service getService(int c)
        {
            return ServiceDAL._list.Find((Service bk) => bk._id == c);
        }

        // Token: 0x04001B20 RID: 6944
        private DataTable dt;

        // Token: 0x04001B21 RID: 6945
        private static List<Service> _list;
    }
}
