using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Functions;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200022A RID: 554
    public class LignePaiementDAL
    {
        // Token: 0x06002686 RID: 9862 RVA: 0x001420DA File Offset: 0x001402DA
        public LignePaiementDAL(bool vide)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new CardexDAL(false);
            new Utilisateur();
            new Service();
            new LignePaiement();
            new Cardex();
        }

        // Token: 0x06002687 RID: 9863 RVA: 0x00142118 File Offset: 0x00140318
        public LignePaiementDAL()
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x06002688 RID: 9864 RVA: 0x0014230C File Offset: 0x0014050C
        public LignePaiementDAL(int id)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = this.GetAllToPrint(id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x06002689 RID: 9865 RVA: 0x00142504 File Offset: 0x00140704
        public LignePaiementDAL(int id, Service _service, Cardex cardex)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex2 = new Cardex();
            this.dt = this.getAllByCardex(id, _service, cardex._id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex2 = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex2, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x0600268A RID: 9866 RVA: 0x00142700 File Offset: 0x00140900
        public LignePaiementDAL(DateTime du, DateTime au)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = this.getArchive(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x0600268B RID: 9867 RVA: 0x001428F8 File Offset: 0x00140AF8
        public LignePaiementDAL(DateTime du, DateTime au, bool blk)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = this.getArchiveBLK(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x0600268C RID: 9868 RVA: 0x00142AF0 File Offset: 0x00140CF0
        public LignePaiementDAL(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            this.dt = new DataTable();
            LignePaiementDAL._list = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = this.getArchive(du, au, _pointDeVente);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x0600268D RID: 9869 RVA: 0x00142CE8 File Offset: 0x00140EE8
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from lignepaiement order by id");
        }

        // Token: 0x0600268E RID: 9870 RVA: 0x00142CF4 File Offset: 0x00140EF4
        private DataTable GetAllToPrint(int id)
        {
            return Connexion.executeQuery("select * from lignepaiement where id= " + id + " order by id");
        }

        // Token: 0x0600268F RID: 9871 RVA: 0x00142D10 File Offset: 0x00140F10
        private DataTable getArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archlignepaiement where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' union select * from lignepaiement where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' order by id"
            }));
        }

        // Token: 0x06002690 RID: 9872 RVA: 0x00142D7C File Offset: 0x00140F7C
        public DataTable getSumArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select libellemodepaiement, idservice, sum(montant) from archlignepaiement where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' group by libellemodepaiement, idservice;"
            }));
        }

        // Token: 0x06002691 RID: 9873 RVA: 0x00142DC8 File Offset: 0x00140FC8
        private DataTable getArchiveBLK(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignepaiement.* from archlignepaiement,archfacture where archlignepaiement.id= archfacture.id and archlignepaiement.idservice=archfacture.idservice and archfacture.numerofacture<>0 and archlignepaiement.datesystem<='",
                au,
                "' and archlignepaiement.datesystem>='",
                du,
                "' order by archlignepaiement.id"
            }));
        }

        // Token: 0x06002692 RID: 9874 RVA: 0x00142E14 File Offset: 0x00141014
        private DataTable getArchive(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archlignepaiement where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and  idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ") order by id"
            }));
        }

        // Token: 0x06002693 RID: 9875 RVA: 0x00142E74 File Offset: 0x00141074
        private DataTable getAllByCardex(int id, Service _service, int idcardex)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from lignepaiement where id=",
                id,
                " and  idservice=",
                _service._id,
                " union select * from archlignepaiement where id=",
                id,
                " and  idservice=",
                _service._id
            }));
        }

        // Token: 0x06002694 RID: 9876 RVA: 0x00142EE1 File Offset: 0x001410E1
        private decimal getSum(Service service)
        {
            return Connexion.executeScalar("select COALESCE(sum(lignepaiement.montant),0) from lignepaiement,modepaiement where lignepaiement.idservice=" + service._id + "  and lignepaiement.idmodepaiement=modepaiement.id and modepaiement.type='Cash'");
        }

        // Token: 0x06002695 RID: 9877 RVA: 0x00142F07 File Offset: 0x00141107
        private decimal getAllSum(Service service)
        {
            return Connexion.executeScalar("select COALESCE(sum(lignepaiement.montant),0) from lignepaiement where lignepaiement.idservice=" + service._id + " ");
        }

        // Token: 0x06002696 RID: 9878 RVA: 0x00142F30 File Offset: 0x00141130
        public static decimal getEncaissementByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignepaiement.montant),0) from facture, lignepaiement where facture.id=lignepaiement.id and lignepaiement.idservice=",
                ids,
                " and lignepaiement.idutilisateur = ",
                idutilisateur,
                " and facture.idservice=",
                ids,
                " ; "
            }));
        }

        // Token: 0x06002697 RID: 9879 RVA: 0x00142F8F File Offset: 0x0014118F
        private decimal getSumDeclare(Service service)
        {
            return Connexion.executeScalar("select COALESCE(sum(lignepaiement.montant),0) from lignepaiement,facture,modepaiement where lignepaiement.idservice=" + service._id + "  and facture.numerofacture<>0 and facture.id=lignepaiement.id  and lignepaiement.idmodepaiement=modepaiement.id and modepaiement.type='Cash'");
        }

        // Token: 0x06002698 RID: 9880 RVA: 0x00142FB8 File Offset: 0x001411B8
        private decimal getSum(DateTime _date, PointDeVente pointDeVente)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select sum(archlignepaiement.montant) from archlignepaiement,modepaiement,service,pointdevente where datesystem='",
                _date,
                "' and  archlignepaiement.idservice=service.id and service.idpointvente=",
                pointDeVente._id,
                " and pointdevente.id=",
                pointDeVente._id,
                " and archlignepaiement.idmodepaiement=modepaiement.id and modepaiement.type='Cash'"
            }));
        }

        // Token: 0x06002699 RID: 9881 RVA: 0x00143024 File Offset: 0x00141224
        private decimal getSumDeclare(DateTime _date, PointDeVente pointDeVente)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select sum(archlignepaiement.montant) from archlignepaiement,archfacture,modepaiement,service,pointdevente where datesystem='",
                _date,
                "' and  archlignepaiement.idservice=service.id and service.idpointvente=",
                pointDeVente._id,
                "  and archfacture.numerofacture<>0 and archfacture.id=archlignepaiement.id  and archlignepaiement.idmodepaiement=modepaiement.id and modepaiement.type='Cash'"
            }));
        }

        // Token: 0x0600269A RID: 9882 RVA: 0x00143077 File Offset: 0x00141277
        public static List<LignePaiement> getLignePaiement()
        {
            return LignePaiementDAL._list;
        }

        // Token: 0x0600269B RID: 9883 RVA: 0x00143080 File Offset: 0x00141280
        public static int addLignePaiement(List<LignePaiement> d)
        {
            string text = "";
            foreach (LignePaiement lignePaiement in d)
            {
                if (!lignePaiement._saved)
                {
                    text += LignePaiementDAL.getRequestAdd(lignePaiement);
                }
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x0600269C RID: 9884 RVA: 0x001430E8 File Offset: 0x001412E8
        public static string getRequestAdd(LignePaiement l)
        {
            return string.Concat(new object[]
            {
                " INSERT INTO lignepaiement(id, idmodepaiement, libellemodepaiement, montant, idservice, date, nbrimpression, idutilisateur,datesystem,serveur,gratuite, idcardex, reference) VALUES (",
                l._id,
                ", ",
                l._idModePaiement,
                ", '",
                l._libelleModePaiement,
                "', ",
                Converting.decimalToString(l._montant),
                ", ",
                l._service._id,
                ", CURRENT_TIMESTAMP , ",
                l._nbrImpression,
                ", ",
                l._utilisateur._id,
                ",(select date from parametrage), '",
                l._serveur,
                "','",
                l._gratuite,
                "', ",
                l._cardex._id,
                ", '",
                l._reference,
                "'); "
            });
        }

        // Token: 0x0600269D RID: 9885 RVA: 0x00143208 File Offset: 0x00141408
        public static int deleteLignePaiement(LignePaiement l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "delete from lignepaiement where id=",
                l._id,
                " and idservice=",
                l._service._id,
                "; "
            }));
        }

        // Token: 0x0600269E RID: 9886 RVA: 0x00143290 File Offset: 0x00141490
        public static List<LignePaiement> getListLignePaiement(int id, int ids)
        {
            List<LignePaiement> list = new List<LignePaiement>();
            return LignePaiementDAL._list.FindAll((LignePaiement bk) => bk._id == id && bk._service._id == ids);
        }

        // Token: 0x0600269F RID: 9887 RVA: 0x001432EC File Offset: 0x001414EC
        public static List<LignePaiement> getListLignePaiementByService(int id)
        {
            List<LignePaiement> list = new List<LignePaiement>();
            return LignePaiementDAL._list.FindAll((LignePaiement bk) => bk._service._id == id);
        }

        // Token: 0x060026A0 RID: 9888 RVA: 0x00143324 File Offset: 0x00141524
        public LignePaiementDAL(int id, bool table)
        {
            this.dt = new DataTable();
            LignePaiementDAL._listLignePaiementTable = new List<LignePaiement>();
            new ServiceDAL();
            new CardexDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LignePaiement item = new LignePaiement();
            Cardex cardex = new Cardex();
            this.dt = Connexion.executeQuery("select lignepaiement.id, lignepaiement.idmodepaiement, lignepaiement.libellemodepaiement, lignepaiement.montant, lignepaiement.idservice, lignepaiement.date, lignepaiement.nbrimpression, lignepaiement.idutilisateur,lignepaiement.datesystem,lignepaiement.serveur,lignepaiement.gratuite, lignepaiement.idcardex, facture.ntable from lignepaiement,facture where lignepaiement.id=facture.id and facture.idservice=" + id + " order by lignepaiement.id ; ");
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[4]));
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    cardex = CardexDAL.getCardex(Convert.ToInt32(dataRow[11]));
                }
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[8] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[5] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[5]);
                }
                item = new LignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToDecimal(dataRow[3].ToString().Trim()), service, date, Convert.ToInt32(dataRow[6]), true, utilisateur, dateSystem, dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), cardex, dataRow[12].ToString().Trim());
                LignePaiementDAL._listLignePaiementTable.Add(item);
            }
        }

        // Token: 0x060026A1 RID: 9889 RVA: 0x0014352C File Offset: 0x0014172C
        public static List<LignePaiement> getListLignePaiementByServiceByTable(int id)
        {
            return LignePaiementDAL._listLignePaiementTable;
        }

        // Token: 0x060026A2 RID: 9890 RVA: 0x00143533 File Offset: 0x00141733
        public decimal getSumLignePaiement(DateTime _date, PointDeVente pdv)
        {
            return this.getSum(_date, pdv);
        }

        // Token: 0x060026A3 RID: 9891 RVA: 0x0014353D File Offset: 0x0014173D
        public decimal getSumLignePaiementDeclare(DateTime _date, PointDeVente pdv)
        {
            return this.getSumDeclare(_date, pdv);
        }

        // Token: 0x060026A4 RID: 9892 RVA: 0x00143547 File Offset: 0x00141747
        public decimal getSumLignePaiement(Service service)
        {
            return this.getSum(service);
        }

        // Token: 0x060026A5 RID: 9893 RVA: 0x00143550 File Offset: 0x00141750
        public decimal getAllSumLignePaiement(Service service)
        {
            return this.getAllSum(service);
        }

        // Token: 0x060026A6 RID: 9894 RVA: 0x00143559 File Offset: 0x00141759
        public decimal getSumLignePaiementDeclare(Service service)
        {
            return this.getSumDeclare(service);
        }

        // Token: 0x04001B0E RID: 6926
        private DataTable dt;

        // Token: 0x04001B0F RID: 6927
        private static List<LignePaiement> _list;

        // Token: 0x04001B10 RID: 6928
        private static List<LignePaiement> _listLignePaiementTable;
    }
}
