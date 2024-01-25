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
    // Token: 0x020003CF RID: 975
    public class LigneFactureDAL
    {
        // Token: 0x060042F1 RID: 17137 RVA: 0x002051D8 File Offset: 0x002033D8
        public LigneFactureDAL(bool solder)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            if (solder)
            {
                this.dt = this.getAll();
            }
            else
            {
                this.dt = this.getNonSolder();
            }
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F2 RID: 17138 RVA: 0x002054E8 File Offset: 0x002036E8
        public LigneFactureDAL(bool solder, Utilisateur _user)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            if (solder)
            {
                this.dt = this.getAll();
            }
            else
            {
                this.dt = this.getNonSolder(_user);
            }
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F3 RID: 17139 RVA: 0x002057F8 File Offset: 0x002039F8
        public LigneFactureDAL()
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
        }

        // Token: 0x060042F4 RID: 17140 RVA: 0x0020585C File Offset: 0x00203A5C
        public LigneFactureDAL(int id, bool getAll)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.GetAllToPrint(id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F5 RID: 17141 RVA: 0x00205B5C File Offset: 0x00203D5C
        public LigneFactureDAL(int id)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.notGetAllToPrint(id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._dateSystem, 0, new Utilisateur(), true, 0, this._dateSystem, 0, "", 0m, 0m, true, Convert.ToInt32(dataRow[11]), 0, "", Convert.ToInt32(dataRow[12]), "", dataRow[13].ToString().Trim(), dataRow[14].ToString().Trim(), 0, "", 0, 0, 0);
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F6 RID: 17142 RVA: 0x00205D88 File Offset: 0x00203F88
        public LigneFactureDAL(int id, Service _service, Cardex cardex)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.getAllByCardex(id, _service, cardex._id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F7 RID: 17143 RVA: 0x00206090 File Offset: 0x00204290
        public LigneFactureDAL(DateTime du, DateTime au)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.getArchive(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F8 RID: 17144 RVA: 0x00206390 File Offset: 0x00204590
        public LigneFactureDAL(DateTime du, DateTime au, int i)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.getArchive(du, au, i);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[28]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042F9 RID: 17145 RVA: 0x00206694 File Offset: 0x00204894
        public LigneFactureDAL(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            this.dt = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            this._serviceDAL = new ServiceDAL();
            this.U = new Utilisateur();
            this.S = new Service();
            this.D = new LigneFacture();
            this.dt = this.getArchive(du, au, _pointDeVente);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                this.S = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                this._date = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._date = Convert.ToDateTime(dataRow[8]);
                }
                this.D = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), this.S, this._date, Convert.ToInt32(dataRow[9]), this.U, true, Convert.ToInt32(dataRow[11]), this._dateSystem, Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), Convert.ToInt32(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), dataRow[23].ToString().Trim(), Convert.ToInt32(dataRow[24]), dataRow[25].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), Convert.ToInt32(dataRow[28]));
                LigneFactureDAL._list.Add(this.D);
            }
        }

        // Token: 0x060042FA RID: 17146 RVA: 0x00206998 File Offset: 0x00204B98
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from lignefacture order by sid");
        }

        // Token: 0x060042FB RID: 17147 RVA: 0x002069A4 File Offset: 0x00204BA4
        private DataTable getNonSolder()
        {
            return Connexion.executeQuery("select lignefacture.* from lignefacture, facture where lignefacture.id=facture.id and facture.solder=false order by sid");
        }

        // Token: 0x060042FC RID: 17148 RVA: 0x002069B0 File Offset: 0x00204BB0
        private DataTable getNonSolder(Utilisateur _user)
        {
            return Connexion.executeQuery("select lignefacture.* from lignefacture, facture where lignefacture.id=facture.id and facture.solder=false and facture.idutilisateur=" + _user._id + " order by sid");
        }

        // Token: 0x060042FD RID: 17149 RVA: 0x002069D1 File Offset: 0x00204BD1
        private DataTable notGetAllToPrint(int id)
        {
            return Connexion.executeQuery(" select * from ( SELECT id, idarticle, libellearticle, sum(qte) as totalqte, pu, sum(prixtotal), sum(totaltva), idservice, datesystem, prixachat, tauxtva, remise,   gramme,  gratuite, remarque FROM lignefacture where id=" + id + " group by  id, idarticle, libellearticle,  pu, idservice, datesystem, prixachat, tauxtva,  remise,   gramme,  gratuite, remarque order by min(sid)) as t  where totalqte<>  0 ;");
        }

        // Token: 0x060042FE RID: 17150 RVA: 0x002069F0 File Offset: 0x00204BF0
        public DataTable getSumArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select produit.libelle, archlignefacture.idservice, famillecarte.id,famillecarte.libelle, sum(archlignefacture.prixtotal), sum(archlignefacture.qte) from archlignefacture,famillecarte,produit where archlignefacture.idarticle=produit.id and famillecarte.id=produit.idfamille and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' group by produit.libelle, archlignefacture.idservice, famillecarte.id,famillecarte.libelle order by famillecarte.id;"
            }));
        }

        // Token: 0x060042FF RID: 17151 RVA: 0x00206A3C File Offset: 0x00204C3C
        public DataTable getOffertArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select libellearticle, archlignefacture.idservice, gratuite,  pu, sum(archlignefacture.qte) from archlignefacture where idarticle!=0 and  archlignefacture.remise=100 and remarque='' and   datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' group by  libellearticle, archlignefacture.idservice, pu, gratuite order by gratuite ;"
            }));
        }

        // Token: 0x06004300 RID: 17152 RVA: 0x00206A88 File Offset: 0x00204C88
        public DataTable getRemiseArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select libellearticle, archlignefacture.idservice, gratuite,  pu, sum(archlignefacture.qte), sum(archlignefacture.prixtotal) from archlignefacture where idarticle!=0 and  archlignefacture.remise!=100 and archlignefacture.remise!=0 and remarque='' and   datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' group by  libellearticle, archlignefacture.idservice, pu, gratuite order by gratuite ;"
            }));
        }

        // Token: 0x06004301 RID: 17153 RVA: 0x00206AD4 File Offset: 0x00204CD4
        public DataTable getSumAnnulationArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select produit.libelle, archlignefacture.idservice, famillecarte.id,famillecarte.libelle, sum(archlignefacture.prixtotal), sum(archlignefacture.qte) from archlignefacture,famillecarte,produit where archlignefacture.qte<0 and archlignefacture.idarticle=produit.id and famillecarte.id=produit.idfamille and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' group by produit.libelle, archlignefacture.idservice, famillecarte.id,famillecarte.libelle order by famillecarte.id;"
            }));
        }

        // Token: 0x06004302 RID: 17154 RVA: 0x00206B1D File Offset: 0x00204D1D
        private DataTable GetAllToPrint(int id)
        {
            return Connexion.executeQuery("select * from lignefacture where id= " + id + " order by sid");
        }

        // Token: 0x06004303 RID: 17155 RVA: 0x00206B3C File Offset: 0x00204D3C
        private DataTable getAllByCardex(int id, Service _service, int idcardex)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select lignefacture.* from lignefacture where id=",
                id,
                " and  idservice=",
                _service._id,
                " union select archlignefacture.* from archlignefacture where id=",
                id,
                " and  idservice=",
                _service._id,
                "  "
            }));
        }

        // Token: 0x06004304 RID: 17156 RVA: 0x00206BB4 File Offset: 0x00204DB4
        private DataTable getArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archlignefacture  where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' order by id"
            }));
        }

        // Token: 0x06004305 RID: 17157 RVA: 0x00206C00 File Offset: 0x00204E00
        private DataTable getArchive(DateTime du, DateTime au, int i)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignefacture.*, produit.idcategorie from archlignefacture,produit  where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and archlignefacture.idarticle=produit.id order by id"
            }));
        }

        // Token: 0x06004306 RID: 17158 RVA: 0x00206C4C File Offset: 0x00204E4C
        private DataTable getArchive(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archlignefacture  where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and  idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ") order by id"
            }));
        }

        // Token: 0x06004307 RID: 17159 RVA: 0x00206CAB File Offset: 0x00204EAB
        public static List<LigneFacture> getLigneFacture()
        {
            return LigneFactureDAL._list;
        }

        // Token: 0x06004308 RID: 17160 RVA: 0x00206CB4 File Offset: 0x00204EB4
        public static int addLigneFacture(List<LigneFacture> d)
        {
            string text = "";
            foreach (LigneFacture ligneFacture in d)
            {
                if (!ligneFacture._saved)
                {
                    if ((ligneFacture._libelleArticle.StartsWith("   =>") || ligneFacture._libelleArticle.StartsWith("=>")) && ligneFacture._imprimer)
                    {
                        object obj = text;
                        text = string.Concat(new object[]
                        {
                            obj,
                            " delete from lignefacture where sid= ",
                            ligneFacture._sid,
                            " and id=",
                            ligneFacture._id,
                            " ; "
                        });
                    }
                    else
                    {
                        text += LigneFactureDAL.getRequestAdd(ligneFacture);
                        text += LigneFactureDAL.getRequestAddFicheTechnique(ligneFacture);
                        text += ProduitDAL.geRequestUpdateQteVente(ligneFacture);
                    }
                }
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06004309 RID: 17161 RVA: 0x00206DC0 File Offset: 0x00204FC0
        public List<LigneFacture> getLigneFactureStat(DateTime du, DateTime au)
        {
            DataTable dataTable = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            LigneFacture item = new LigneFacture();
            string str = "select idarticle, libellearticle, sum( qte) as totalQte, pu, sum(prixtotal), sum(totaltva) from( ";
            string text = "  select idarticle, libellearticle, qte, pu, prixtotal, totaltva from lignefacture ";
            string text2 = " union select idarticle, libellearticle, qte, pu, prixtotal, totaltva  from archlignefacture ";
            string str2 = " ) as t group by  idarticle,libellearticle, pu order by totalQte DESC ";
            object obj = text;
            text = string.Concat(new object[]
            {
                obj,
                " where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and  (remise!=100 or remarque ='')  "
            });
            object obj2 = text2;
            text2 = string.Concat(new object[]
            {
                obj2,
                " where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and  (remise!=100 and remarque ='') "
            });
            dataTable = Connexion.executeQuery(str + text + text2 + str2);
            foreach (object obj3 in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj3;
                item = new LigneFacture(0, Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), Convert.ToDecimal(dataRow[3].ToString().Trim()), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()));
                LigneFactureDAL._list.Add(item);
            }
            return LigneFactureDAL._list;
        }

        // Token: 0x0600430A RID: 17162 RVA: 0x00206F84 File Offset: 0x00205184
        public List<LigneFacture> getLigneFactureAnnulation(DateTime du, DateTime au)
        {
            DataTable dataTable = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            new Service();
            LigneFacture item = new LigneFacture();
            string sql = string.Concat(new object[]
            {
                "select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem from(  select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem from lignefacture where qte<0 and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' union select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem from archlignefacture where qte<0 and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' ) as t  order by datesystem, date DESC"
            });
            dataTable = Connexion.executeQuery(sql);
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                item = new LigneFacture(0, Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), Convert.ToDecimal(dataRow[3].ToString().Trim()), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDateTime(dataRow[6]), utilisateur, Convert.ToDateTime(dataRow[8]), 0, "", "");
                LigneFactureDAL._list.Add(item);
            }
            return LigneFactureDAL._list;
        }

        // Token: 0x0600430B RID: 17163 RVA: 0x00207140 File Offset: 0x00205340
        public List<LigneFacture> getLigneFactureOffert(DateTime du, DateTime au)
        {
            DataTable dataTable = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            new Service();
            LigneFacture item = new LigneFacture();
            string sql = string.Concat(new object[]
            {
                "select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, gratuite from(  select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, gratuite from lignefacture where remise!= 0 and (gratuite!= '' or remarque='') and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' union select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, gratuite from archlignefacture where remise!= 0 and (gratuite!= '' or remarque='') and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' ) as t  order by datesystem, date DESC"
            });
            dataTable = Connexion.executeQuery(sql);
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                item = new LigneFacture(0, Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), Convert.ToDecimal(dataRow[3].ToString().Trim()), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDateTime(dataRow[6]), utilisateur, Convert.ToDateTime(dataRow[8]), Convert.ToInt32(dataRow[9]), dataRow[10].ToString().Trim(), "");
                LigneFactureDAL._list.Add(item);
            }
            return LigneFactureDAL._list;
        }

        // Token: 0x0600430C RID: 17164 RVA: 0x00207318 File Offset: 0x00205518
        public List<LigneFacture> getLigneFacturePerte(DateTime du, DateTime au)
        {
            DataTable dataTable = new DataTable();
            LigneFactureDAL._list = new List<LigneFacture>();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            new Service();
            LigneFacture item = new LigneFacture();
            string sql = string.Concat(new object[]
            {
                "select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, remarque from(  select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, remarque from lignefacture where remise!= 0 and  remarque!='' and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' union select idarticle, libellearticle, qte , pu, prixtotal, totaltva, date,idutilisateur, datesystem, remise, gratuite from archlignefacture where remise!= 0 and  remarque!='' and datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' ) as t  order by datesystem, date DESC"
            });
            dataTable = Connexion.executeQuery(sql);
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[7]));
                item = new LigneFacture(0, Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), Convert.ToDecimal(dataRow[3].ToString().Trim()), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDateTime(dataRow[6]), utilisateur, Convert.ToDateTime(dataRow[8]), Convert.ToInt32(dataRow[9]), "", dataRow[10].ToString().Trim());
                LigneFactureDAL._list.Add(item);
            }
            return LigneFactureDAL._list;
        }

        // Token: 0x0600430D RID: 17165 RVA: 0x002074F0 File Offset: 0x002056F0
        public static string addLigneFactureForTransfert(List<LigneFacture> d)
        {
            string text = "";
            int num = 0;
            foreach (LigneFacture ligneFacture in d)
            {
                num = (ligneFacture._idList = num + 1);
                text += LigneFactureDAL.getRequestAdd(ligneFacture);
            }
            return text;
        }

        // Token: 0x0600430E RID: 17166 RVA: 0x00207558 File Offset: 0x00205758
        public static int updateLigneFactureRemise(LigneFacture d)
        {
            if (d._sid == 0)
            {
                return Connexion.executeScalar(string.Concat(new object[]
                {
                    " UPDATE lignefacture set prixtotal=",
                    Converting.decimalToString(d._prixTotal),
                    ", totaltva=",
                    Converting.decimalToString(d._totalTva),
                    ", remise=",
                    d._remise,
                    ", gratuite='",
                    d._gratuite,
                    "', remarque='",
                    d._remarque,
                    "' where id=",
                    d._id,
                    " and idarticle=",
                    d._idArticle,
                    " and index=",
                    d._idList,
                    ";  "
                }));
            }
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE lignefacture set prixtotal=",
                Converting.decimalToString(d._prixTotal),
                ", totaltva=",
                Converting.decimalToString(d._totalTva),
                ", remise=",
                d._remise,
                ", gratuite='",
                d._gratuite,
                "' , remarque='",
                d._remarque,
                "' where id=",
                d._id,
                " and sid=",
                d._sid,
                " ;  "
            }));
        }

        // Token: 0x0600430F RID: 17167 RVA: 0x002076EC File Offset: 0x002058EC
        public static int updateLigneFactureRemise(List<LigneFacture> d)
        {
            string text = " ";
            foreach (LigneFacture ligneFacture in d)
            {
                if (ligneFacture._saved)
                {
                    text += LigneFactureDAL.getRequestLigneFactureRemise(ligneFacture);
                }
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06004310 RID: 17168 RVA: 0x00207754 File Offset: 0x00205954
        private static string getRequestLigneFactureRemise(LigneFacture d)
        {
            if (d._sid == 0)
            {
                return string.Concat(new object[]
                {
                    " UPDATE lignefacture set prixtotal=",
                    Converting.decimalToString(d._prixTotal),
                    ", totaltva=",
                    Converting.decimalToString(d._totalTva),
                    ", remise=",
                    d._remise,
                    ", gratuite='",
                    d._gratuite,
                    "', remarque='",
                    d._remarque,
                    "' where id=",
                    d._id,
                    " and idarticle=",
                    d._idArticle,
                    " and index=",
                    d._idList,
                    "  ;  "
                });
            }
            return string.Concat(new object[]
            {
                " UPDATE lignefacture set prixtotal=",
                Converting.decimalToString(d._prixTotal),
                ", totaltva=",
                Converting.decimalToString(d._totalTva),
                ", remise=",
                d._remise,
                ", gratuite='",
                d._gratuite,
                "' , remarque='",
                d._remarque,
                "' where id=",
                d._id,
                " and sid=",
                d._sid,
                "  ;  "
            });
        }

        // Token: 0x06004311 RID: 17169 RVA: 0x002078E0 File Offset: 0x00205AE0
        public static string getRequestUpdateNbrImpression(Facture d, string type)
        {
            return string.Concat(new object[]
            {
                " UPDATE lignefacture set nbimpression= nbimpression + 1 where  id=",
                d._id,
                " and type='",
                type,
                "' and idservice=",
                d._service._id,
                "; "
            });
        }

        // Token: 0x06004312 RID: 17170 RVA: 0x00207940 File Offset: 0x00205B40
        public static string getRequestAdd(LigneFacture l)
        {
            return string.Concat(new object[]
            {
                " INSERT INTO lignefacture( id, idarticle, libellearticle, qte, pu, prixtotal, totaltva, idservice, date, nbimpression, idutilisateur,idimprimante,datesystem,prixachat,tauxtva,imprimer, remise, index, idimprimante2, serveur, gramme, type, gratuite, remarque, poste, idimprimante3, idimprimante4, idprestation)  VALUES (",
                l._id,
                ", ",
                l._idArticle,
                ", '",
                l._libelleArticle,
                "', ",
                l._qte,
                ", ",
                Converting.decimalToString(l._PU),
                ", ",
                Converting.decimalToString(l._prixTotal),
                ", ",
                Converting.decimalToString(l._totalTva),
                ",  ",
                l._service._id,
                ", CURRENT_TIMESTAMP, ",
                l._nbrImpression,
                ", ",
                l._utilisateur._id,
                ",",
                l._idImprimante,
                ",(select date from parametrage), ",
                Converting.decimalToString(l._prixAchat),
                ", ",
                Converting.decimalToString(l._tauxTVA),
                ",",
                l._imprimer,
                ", ",
                l._remise,
                ", ",
                l._idList,
                ", ",
                l._idImprimante2,
                ", '",
                l._serveur,
                "', ",
                l._gramme,
                ", '",
                l._type,
                "','",
                l._gratuite,
                "', '",
                l._remarque,
                "', '",
                l._poste,
                "', ",
                l._idImprimante3,
                ", ",
                l._idImprimante4,
                ", ",
                l._idPrestation,
                "); "
            });
        }

        // Token: 0x06004313 RID: 17171 RVA: 0x00207BB8 File Offset: 0x00205DB8
        public static decimal getVentesByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignefacture.prixtotal),0) from facture, lignefacture where facture.id=lignefacture.id and  lignefacture.idservice=",
                ids,
                " and lignefacture.idutilisateur = ",
                idutilisateur,
                " ; "
            }));
        }

        // Token: 0x06004314 RID: 17172 RVA: 0x00207C08 File Offset: 0x00205E08
        public static decimal getCAByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignefacture.prixtotal),0) from facture, lignefacture where facture.id=lignefacture.id and  lignefacture.idservice=",
                ids,
                " and facture.idutilisateur = ",
                idutilisateur,
                " ; "
            }));
        }

        // Token: 0x06004315 RID: 17173 RVA: 0x00207C58 File Offset: 0x00205E58
        public static decimal getCAOuverteByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignefacture.prixtotal),0) from facture, lignefacture where facture.id=lignefacture.id and facture.solder=false and lignefacture.idservice=",
                ids,
                " and facture.idutilisateur = ",
                idutilisateur,
                " ; "
            }));
        }

        // Token: 0x06004316 RID: 17174 RVA: 0x00207CA8 File Offset: 0x00205EA8
        public static decimal getVentesByPoste(int ids, string idPoste)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignefacture.prixtotal),0) from facture, lignefacture where facture.id=lignefacture.id and  lignefacture.idservice=",
                ids,
                " and lignefacture.poste = '",
                idPoste,
                "' ; "
            }));
        }

        // Token: 0x06004317 RID: 17175 RVA: 0x00207CF4 File Offset: 0x00205EF4
        public static decimal getCAOuverteByPoste(int ids, string idPoste)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(lignefacture.prixtotal),0) from facture, lignefacture where facture.id=lignefacture.id and facture.solder=false and lignefacture.idservice=",
                ids,
                " and lignefacture.poste = '",
                idPoste,
                "' ; "
            }));
        }

        // Token: 0x06004318 RID: 17176 RVA: 0x00207D3D File Offset: 0x00205F3D
        public static decimal getCADiver(int ids)
        {
            return Connexion.executeScalar("select COALESCE( sum(lignefacture.prixtotal),0) from lignefacture,produit where produit.id=lignefacture.idarticle and produit.idcategorie=3 and lignefacture.idservice=" + ids + "  ; ");
        }

        // Token: 0x06004319 RID: 17177 RVA: 0x00207D60 File Offset: 0x00205F60
        public static decimal getCADiver(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE( sum(archlignefacture.prixtotal),0) from archlignefacture,produit where produit.id=archlignefacture.idarticle and produit.idcategorie=3 and  datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  and  idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ")  ; "
            }));
        }

        // Token: 0x0600431A RID: 17178 RVA: 0x00207DC4 File Offset: 0x00205FC4
        public static string getRequestAddFicheTechnique(LigneFacture l)
        {
            LigneFactureDAL._listFicheTechnique = LigneFactureDAL._ficheTechniqueDAL.getFicheTechniqueByProduit(l._idArticle);
            string text = " ";
            foreach (FicheTechnique ficheTechnique in LigneFactureDAL._listFicheTechnique)
            {
                if (Connexion.executeScalar(string.Concat(new object[]
                {
                    "select count(*) from detaillocal where idarticle=",
                    ficheTechnique._article._id,
                    " and idlocal=",
                    ficheTechnique._local._id
                })) == 0)
                {
                    Connexion.executeScalar(string.Concat(new object[]
                    {
                        " INSERT INTO detaillocal(idarticle, codearticle, libellearticle, idlocal, codelocal, libellelocal, qte, cout, pmplocal, qtevente) VALUES (",
                        ficheTechnique._article._id,
                        ", '",
                        ficheTechnique._article._code,
                        "','",
                        ficheTechnique._article._libelle,
                        "', ",
                        ficheTechnique._local._id,
                        ",'",
                        ficheTechnique._local._code,
                        "','",
                        ficheTechnique._local._libelle,
                        "', ",
                        Converting.decimalToString(0m),
                        ", ",
                        Converting.decimalToString(0m),
                        ",",
                        Converting.decimalToString(0m),
                        ", ",
                        Converting.decimalToString(l._qte * ficheTechnique._qte * l._gramme),
                        ");  "
                    }));
                }
                else
                {
                    object obj = text;
                    text = string.Concat(new object[]
                    {
                        obj,
                        " UPDATE detaillocal SET  qtevente=qtevente +",
                        Converting.decimalToString(l._qte * ficheTechnique._qte * l._gramme),
                        " WHERE idlocal=",
                        ficheTechnique._local._id,
                        " and idarticle=",
                        ficheTechnique._article._id,
                        ";"
                    });
                }
            }
            return text;
        }

        // Token: 0x0600431B RID: 17179 RVA: 0x002080A4 File Offset: 0x002062A4
        public static List<LigneFacture> getListLigneFacture(int id, int ids)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            return LigneFactureDAL._list.FindAll((LigneFacture bk) => bk._id == id && bk._service._id == ids);
        }

        // Token: 0x0600431C RID: 17180 RVA: 0x00208100 File Offset: 0x00206300
        public static List<LigneFacture> getListLigneFactureByService(int id)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            return LigneFactureDAL._list.FindAll((LigneFacture bk) => bk._service._id == id);
        }

        // Token: 0x0600431D RID: 17181 RVA: 0x00208138 File Offset: 0x00206338
        public static List<LigneFacture> getListLigneFactureByServiceByFamille(DateTime du, DateTime au)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignefacture.id as idligne, archlignefacture.idarticle, archlignefacture.libellearticle, archlignefacture.qte, archlignefacture.pu, archlignefacture.prixtotal, archlignefacture.totaltva, archlignefacture.idservice, archlignefacture.date, archlignefacture.nbimpression, archlignefacture.idutilisateur, archlignefacture.idimprimante, archlignefacture.datesystem, archlignefacture.prixachat, archlignefacture.tauxtva, archlignefacture.imprimer, archlignefacture.remise ,archlignefacture.serveur, archlignefacture.gramme, archlignefacture.type,archlignefacture.gratuite, archlignefacture.remarque,  archlignefacture.poste, famillecarte.id,famillecarte.libelle   from archlignefacture,produit,famillecarte  where archlignefacture.datesystem<='",
                au,
                "' and archlignefacture.datesystem>='",
                du,
                "' and archlignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id   union all select lignefacture.id as idligne, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise ,lignefacture.serveur, lignefacture.gramme, lignefacture.type,lignefacture.gratuite, lignefacture.remarque,  lignefacture.poste, famillecarte.id,famillecarte.libelle   from lignefacture,produit,famillecarte  where lignefacture.datesystem<='",
                au,
                "' and lignefacture.datesystem>='",
                du,
                "' and lignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id order by idligne"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), 0, 0, 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x0600431E RID: 17182 RVA: 0x00208428 File Offset: 0x00206628
        public static List<LigneFacture> getListLigneFactureByServiceByHeure(DateTime du, DateTime au)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignefacture.id as idligne, archlignefacture.idarticle, archlignefacture.libellearticle, archlignefacture.qte, archlignefacture.pu, archlignefacture.prixtotal, archlignefacture.totaltva, archlignefacture.idservice, archlignefacture.date, archlignefacture.nbimpression, archlignefacture.idutilisateur, archlignefacture.idimprimante, archlignefacture.datesystem, archlignefacture.prixachat, archlignefacture.tauxtva, archlignefacture.imprimer, archlignefacture.remise ,archlignefacture.serveur, archlignefacture.gramme, archlignefacture.type,archlignefacture.gratuite, archlignefacture.remarque,  archlignefacture.poste, famillecarte.id,famillecarte.libelle   from archlignefacture,produit,famillecarte  where archlignefacture.datesystem<='",
                au,
                "' and archlignefacture.datesystem>='",
                du,
                "' and archlignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id   union all select lignefacture.id as idligne, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise ,lignefacture.serveur, lignefacture.gramme, lignefacture.type,lignefacture.gratuite, lignefacture.remarque,  lignefacture.poste, famillecarte.id,famillecarte.libelle   from lignefacture,produit,famillecarte  where lignefacture.datesystem<='",
                au,
                "' and lignefacture.datesystem>='",
                du,
                "' and lignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id order by date"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), 0, 0, 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x0600431F RID: 17183 RVA: 0x00208718 File Offset: 0x00206918
        public static List<LigneFacture> getListLigneFactureByServiceByFamille(DateTime du, DateTime au, bool blk)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignefacture.id, archlignefacture.idarticle, archlignefacture.libellearticle, archlignefacture.qte, archlignefacture.pu, archlignefacture.prixtotal, archlignefacture.totaltva, archlignefacture.idservice, archlignefacture.date, archlignefacture.nbimpression, archlignefacture.idutilisateur, archlignefacture.idimprimante, archlignefacture.datesystem, archlignefacture.prixachat, archlignefacture.tauxtva, archlignefacture.imprimer, archlignefacture.remise ,archlignefacture.serveur, archlignefacture.gramme, archlignefacture.type,archlignefacture.gratuite, archlignefacture.remarque,archlignefacture.poste,  famillecarte.id,famillecarte.libelle   from archlignefacture,produit,famillecarte, archfacture  where archlignefacture.id= archfacture.id and archlignefacture.idservice=archfacture.idservice and archfacture.numerofacture<>0 and archlignefacture.datesystem<='",
                au,
                "' and archlignefacture.datesystem>='",
                du,
                "' and archlignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id order by archlignefacture.id"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]), 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004320 RID: 17184 RVA: 0x002089F8 File Offset: 0x00206BF8
        public static List<LigneFacture> getListLigneFactureByServiceByPrestationPMS(int id)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(" select 0, pms.prestation.id, pms.prestation.libelle,sum( lignefacture.qte), sum(lignefacture.pu), sum(lignefacture.prixtotal), sum(lignefacture.totaltva), lignefacture.idservice, lignefacture.datesystem, 0, 0, 0, lignefacture.datesystem, 0, lignefacture.tauxtva, false, 0, '', 1, '', '', '', '', pms.prestation.id,pms.prestation.libelle, 0, 0   from facture, lignefacture,produit,pms.prestation  where facture.transfert=false and facture.id=lignefacture.id and  lignefacture.idarticle=produit.id and produit.idprestation=pms.prestation.id and lignefacture.idservice=" + id + "   group by pms.prestation.id, pms.prestation.libelle , lignefacture.idservice, lignefacture.datesystem, lignefacture.tauxtva");
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), Convert.ToInt32(dataRow[25]), Convert.ToInt32(dataRow[26]), 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004321 RID: 17185 RVA: 0x00208CB0 File Offset: 0x00206EB0
        public static List<LigneFacture> getListLigneFactureByServiceByFamille(int id)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery("select lignefacture.id, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise, lignefacture.serveur, lignefacture.gramme, lignefacture.type, lignefacture.gratuite, lignefacture.remarque, lignefacture.poste, famillecarte.id,famillecarte.libelle, lignefacture.idimprimante3, lignefacture.idimprimante4   from lignefacture,produit,famillecarte  where  lignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id and lignefacture.idservice=" + id + "  order by lignefacture.id");
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), Convert.ToInt32(dataRow[25]), Convert.ToInt32(dataRow[26]), 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004322 RID: 17186 RVA: 0x00208F68 File Offset: 0x00207168
        public static List<LigneFacture> getListLigneFactureByServiceByCategorie(int id)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery("select lignefacture.id, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise, lignefacture.serveur, lignefacture.gramme, lignefacture.type, lignefacture.gratuite, lignefacture.remarque, lignefacture.poste, categorie.id,categorie.libelle, lignefacture.idimprimante3, lignefacture.idimprimante4   from lignefacture,produit,categorie  where  lignefacture.idarticle=produit.id and produit.idcategorie=categorie.id and lignefacture.idservice=" + id + "  order by lignefacture.id");
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), Convert.ToInt32(dataRow[25]), Convert.ToInt32(dataRow[26]), 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004323 RID: 17187 RVA: 0x00209220 File Offset: 0x00207420
        public static List<LigneFacture> getListLigneFactureByServiceByCategorie(int id, int idc)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new object[]
            {
                "select lignefacture.id, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise, lignefacture.serveur, lignefacture.gramme, lignefacture.type, lignefacture.gratuite, lignefacture.remarque, lignefacture.poste, famillecarte.id,famillecarte.libelle, lignefacture.idimprimante3, lignefacture.idimprimante4, lignefacture.idprestation   from lignefacture,produit,famillecarte  where  lignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id and produit.idcategorie=",
                idc,
                " and lignefacture.idservice=",
                id,
                "  order by lignefacture.id"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), Convert.ToInt32(dataRow[25]), Convert.ToInt32(dataRow[26]), Convert.ToInt32(dataRow[27]));
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004324 RID: 17188 RVA: 0x00209510 File Offset: 0x00207710
        public static List<LigneFacture> getListLigneFactureByServiceByCategorie(DateTime du, DateTime au)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new string[]
            {
                "select produit.id, produit.libelle, coalesce (t.qte,0), produit.prix, coalesce (t.total,0), produit.idcategorie, produit.categorie, produit.qtevisuelle-produit.qtevente from produit left join (select  archlignefacture.idarticle, archlignefacture.libellearticle, sum( archlignefacture.qte) as qte, archlignefacture.pu, sum(archlignefacture.prixtotal) as total , categorie.id as idcategorie,categorie.libelle as libellecategorie   from archlignefacture,produit,categorie  where archlignefacture.datesystem<='",
                au.ToShortDateString(),
                "' and archlignefacture.datesystem>='",
                du.ToShortDateString(),
                "' and  archlignefacture.idarticle=produit.id and produit.idcategorie=categorie.id  group by archlignefacture.idarticle, archlignefacture.libellearticle,  categorie.id,categorie.libelle, archlignefacture.pu) t on t.idarticle = produit.id order by produit.id;"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                item = new LigneFacture(Convert.ToInt32(dataRow[7]), Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), Convert.ToDecimal(dataRow[3].ToString().Trim()), Convert.ToDecimal(dataRow[4].ToString().Trim()), 0m, service, date, 0, new Utilisateur(), true, 0, dateSystem, Convert.ToInt32(dataRow[5]), dataRow[6].ToString().Trim(), 0m, 0m, true, 0, 0, "", 1, "", "", "", 0, "", 0, 0, 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004325 RID: 17189 RVA: 0x002096CC File Offset: 0x002078CC
        public static List<LigneFacture> getListLigneFactureByServiceByZoneByFamille(DateTime du, DateTime au)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery(string.Concat(new object[]
            {
                "select archlignefacture.id, archlignefacture.idarticle, archlignefacture.libellearticle, archlignefacture.qte, archlignefacture.pu, archlignefacture.prixtotal, archlignefacture.totaltva, archlignefacture.idservice, archlignefacture.date, archlignefacture.nbimpression, archlignefacture.idutilisateur, archlignefacture.idimprimante, archlignefacture.datesystem, archlignefacture.prixachat, archlignefacture.tauxtva, archlignefacture.imprimer, archlignefacture.remise ,archlignefacture.serveur, archlignefacture.gramme, archlignefacture.type,archlignefacture.gratuite, archlignefacture.remarque,  zone.libelle , famillecarte.id,famillecarte.libelle   from archlignefacture,produit,famillecarte,archfacture,zone  where archlignefacture.id=archfacture.id and zone.id=archfacture.idzone and archlignefacture.datesystem<='",
                au,
                "' and archlignefacture.datesystem>='",
                du,
                "' and archlignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id order by archlignefacture.id"
            }));
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), 0, 0, 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004326 RID: 17190 RVA: 0x00209994 File Offset: 0x00207B94
        public static List<LigneFacture> getListLigneFactureByServiceByZoneByFamille(int id)
        {
            List<LigneFacture> list = new List<LigneFacture>();
            DataTable dataTable = new DataTable();
            new ServiceDAL();
            Utilisateur utilisateur = new Utilisateur();
            Service service = new Service();
            LigneFacture item = new LigneFacture();
            dataTable = Connexion.executeQuery("select lignefacture.id, lignefacture.idarticle, lignefacture.libellearticle, lignefacture.qte, lignefacture.pu, lignefacture.prixtotal, lignefacture.totaltva, lignefacture.idservice, lignefacture.date, lignefacture.nbimpression, lignefacture.idutilisateur, lignefacture.idimprimante, lignefacture.datesystem, lignefacture.prixachat, lignefacture.tauxtva, lignefacture.imprimer, lignefacture.remise, lignefacture.serveur, lignefacture.gramme, lignefacture.type, lignefacture.gratuite, lignefacture.remarque, zone.libelle, famillecarte.id,famillecarte.libelle   from lignefacture,produit,famillecarte,facture,zone  where lignefacture.id=facture.id and zone.id=facture.idzone and  lignefacture.idarticle=produit.id and produit.idfamille=famillecarte.id and lignefacture.idservice=" + id + "  order by lignefacture.id");
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                utilisateur = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[10]));
                service = ServiceDAL.getService(Convert.ToInt32(dataRow[7]));
                DateTime date = default(DateTime);
                DateTime dateSystem = default(DateTime);
                if (dataRow[12] != DBNull.Value)
                {
                    dateSystem = Convert.ToDateTime(dataRow[12]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    date = Convert.ToDateTime(dataRow[8]);
                }
                item = new LigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[1]), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), service, date, Convert.ToInt32(dataRow[9]), utilisateur, true, Convert.ToInt32(dataRow[11]), dateSystem, Convert.ToInt32(dataRow[23]), dataRow[24].ToString().Trim(), Convert.ToDecimal(dataRow[13]), Convert.ToDecimal(dataRow[14]), Convert.ToBoolean(dataRow[15]), Convert.ToInt32(dataRow[16]), 0, dataRow[17].ToString().Trim(), Convert.ToInt32(dataRow[18]), dataRow[19].ToString().Trim(), dataRow[20].ToString().Trim(), dataRow[21].ToString().Trim(), 0, dataRow[22].ToString().Trim(), 0, 0, 0);
                list.Add(item);
            }
            return list;
        }

        // Token: 0x04002A57 RID: 10839
        private DataTable dt;

        // Token: 0x04002A58 RID: 10840
        private static List<LigneFacture> _list;

        // Token: 0x04002A59 RID: 10841
        private static FicheTechniqueDAL _ficheTechniqueDAL = new FicheTechniqueDAL();

        // Token: 0x04002A5A RID: 10842
        private static List<FicheTechnique> _listFicheTechnique = new List<FicheTechnique>();

        // Token: 0x04002A5B RID: 10843
        private ServiceDAL _serviceDAL;

        // Token: 0x04002A5C RID: 10844
        private Utilisateur U;

        // Token: 0x04002A5D RID: 10845
        private Service S;

        // Token: 0x04002A5E RID: 10846
        private LigneFacture D;

        // Token: 0x04002A5F RID: 10847
        private DateTime _date = default(DateTime);

        // Token: 0x04002A60 RID: 10848
        private DateTime _dateSystem = default(DateTime);
    }
}
