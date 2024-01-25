using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Functions;
using TaxArchiver.Models;

namespace TaxArchiver
{
    // Token: 0x02000131 RID: 305
    public class FactureDAL
    {
        // Token: 0x060014D9 RID: 5337 RVA: 0x000B4DFC File Offset: 0x000B2FFC
        public FactureDAL()
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL();
            this._lignePaiementDAL = new LignePaiementDAL(false);
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
        }

        // Token: 0x060014DA RID: 5338 RVA: 0x000B4E74 File Offset: 0x000B3074
        public FactureDAL(bool Solder)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL(Solder);
            this._lignePaiementDAL = new LignePaiementDAL();
            this._zoneDAL = new ZoneDAL();
            List<LigneFacture> listLigneFacture = new List<LigneFacture>();
            List<LignePaiement> listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            if (Solder)
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
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, listLigneFacture, listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014DB RID: 5339 RVA: 0x000B51B0 File Offset: 0x000B33B0
        public FactureDAL(bool _solder, bool _vide, Service _service)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._zoneDAL = new ZoneDAL();
            if (!_vide)
            {
                this._ligneFactureDAL = new LigneFactureDAL(_solder);
                this._lignePaiementDAL = new LignePaiementDAL();
            }
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            if (_solder)
            {
                this.dt = this.getAll(_service);
            }
            else
            {
                this.dt = this.getNonSolder(_service);
            }
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (!_vide)
                {
                    this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                    this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                }
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014DC RID: 5340 RVA: 0x000B5510 File Offset: 0x000B3710
        public FactureDAL(bool _solder, bool _vide, Service _service, Utilisateur _user)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._zoneDAL = new ZoneDAL();
            if (!_vide)
            {
                this._ligneFactureDAL = new LigneFactureDAL(_solder, _user);
                this._lignePaiementDAL = new LignePaiementDAL();
            }
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            if (_solder)
            {
                this.dt = this.getAll(_service);
            }
            else
            {
                this.dt = this.getNonSolder(_user, _service);
            }
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (!_vide)
                {
                    this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                    this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                }
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014DD RID: 5341 RVA: 0x000B5874 File Offset: 0x000B3A74
        public FactureDAL(int id, bool GetAll, Service _service)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._zoneDAL = new ZoneDAL();
            if (!GetAll)
            {
                this._ligneFactureDAL = new LigneFactureDAL(id);
            }
            else
            {
                this._ligneFactureDAL = new LigneFactureDAL(id, GetAll);
            }
            this._lignePaiementDAL = new LignePaiementDAL(id);
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getAllToPrint(id, _service);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

 

        // Token: 0x060014DF RID: 5343 RVA: 0x000B5F10 File Offset: 0x000B4110
        public FactureDAL(DateTime du, DateTime au, int i)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL(du, au, i);
            this._lignePaiementDAL = new LignePaiementDAL(du, au);
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getArchive(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), false, false, 0m);
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E0 RID: 5344 RVA: 0x000B6240 File Offset: 0x000B4440
        public FactureDAL(DateTime du, DateTime au, bool blk)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL(du, au);
            this._lignePaiementDAL = new LignePaiementDAL(du, au);
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getArchiveBlk(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[13]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E1 RID: 5345 RVA: 0x000B658C File Offset: 0x000B478C
        public FactureDAL(DateTime du, DateTime au, Service service)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL(du, au);
            this._lignePaiementDAL = new LignePaiementDAL(du, au);
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getArchive(du, au);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E2 RID: 5346 RVA: 0x000B68D8 File Offset: 0x000B4AD8
        public FactureDAL(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._ligneFactureDAL = new LigneFactureDAL(du, au, _pointDeVente);
            this._lignePaiementDAL = new LignePaiementDAL(du, au, _pointDeVente);
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getArchive(du, au, _pointDeVente);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E3 RID: 5347 RVA: 0x000B6C28 File Offset: 0x000B4E28
        public FactureDAL(Cardex cardex)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getAllByCompte(cardex._id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E4 RID: 5348 RVA: 0x000B6F60 File Offset: 0x000B5160
        public FactureDAL(int id, Service _service, Cardex cardex)
        {
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getAllByCompte(cardex._id);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                this._listLigneFacture = LigneFactureDAL.getListLigneFacture(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this._listLignePaiement = LignePaiementDAL.getListLignePaiement(Convert.ToInt32(dataRow[0]), Convert.ToInt32(dataRow[9]));
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                FactureDAL._list.Add(this.F);
            }
        }

        // Token: 0x060014E5 RID: 5349 RVA: 0x000B7298 File Offset: 0x000B5498
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from facture order by id");
        }

        // Token: 0x060014E6 RID: 5350 RVA: 0x000B72A4 File Offset: 0x000B54A4
        private DataTable getAll(Service _service)
        {
            return Connexion.executeQuery("select * from facture where idservice=" + _service._id + " order by id");
        }

        // Token: 0x060014E7 RID: 5351 RVA: 0x000B72C8 File Offset: 0x000B54C8
        private DataTable getAllToPrint(int id, Service _service)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from facture where id=",
                id,
                " and idservice=",
                _service._id,
                " order by id"
            }));
        }

        // Token: 0x060014E8 RID: 5352 RVA: 0x000B7318 File Offset: 0x000B5518
        public static bool getSolder(int id, Service _service)
        {
            return Connexion.executeScalarBoolean(string.Concat(new object[]
            {
                "select solder from facture where id=",
                id,
                " and idservice=",
                _service._id
            }));
        }

        // Token: 0x060014E9 RID: 5353 RVA: 0x000B735E File Offset: 0x000B555E
        private DataTable getNonSolder()
        {
            return Connexion.executeQuery("select * from facture where solder=false order by id");
        }

        // Token: 0x060014EA RID: 5354 RVA: 0x000B736A File Offset: 0x000B556A
        private DataTable getNonSolder(Service _service)
        {
            return Connexion.executeQuery("select * from facture where idservice=" + _service._id + " and solder=false order by id");
        }

        // Token: 0x060014EB RID: 5355 RVA: 0x000B738B File Offset: 0x000B558B
        private DataTable getNonSolder(Utilisateur _user)
        {
            return Connexion.executeQuery("select * from facture where  solder=false and idutilisateur=" + _user._id + " order by id");
        }

        // Token: 0x060014EC RID: 5356 RVA: 0x000B73AC File Offset: 0x000B55AC
        private DataTable getNonSolder(Utilisateur _user, Service _service)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from facture where idservice=",
                _service._id,
                " and solder=false and idutilisateur=",
                _user._id,
                " order by id"
            }));
        }

        // Token: 0x060014ED RID: 5357 RVA: 0x000B7400 File Offset: 0x000B5600
        private DataTable getArchive(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  order by id"
            }));
        }

        // Token: 0x060014EE RID: 5358 RVA: 0x000B744C File Offset: 0x000B564C
        private DataTable getAllTableParClient(Service _service, int _table)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from facture where idservice=",
                _service._id,
                " and solder = false and ntable='",
                _table,
                "' order by id"
            }));
        }

        // Token: 0x060014EF RID: 5359 RVA: 0x000B749C File Offset: 0x000B569C
        private DataTable getArchiveBlk(DateTime du, DateTime au)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and numerofacture<>0  order by id"
            }));
        }

        // Token: 0x060014F0 RID: 5360 RVA: 0x000B74E8 File Offset: 0x000B56E8
        private DataTable getArchive(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeQuery(string.Concat(new object[]
            {
                "select * from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ")  order by id"
            }));
        }

        // Token: 0x060014F1 RID: 5361 RVA: 0x000B7547 File Offset: 0x000B5747
        public static int getCouverts(int ids)
        {
            return Connexion.executeScalar("select COALESCE(sum(couvert),0) from facture where idservice=" + ids + " ");
        }

        // Token: 0x060014F2 RID: 5362 RVA: 0x000B7564 File Offset: 0x000B5764
        public static int getCouverts(DateTime du, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE(sum(couvert),0) from (select couvert from facture where idservice=",
                ids,
                " union all select couvert from archfacture where idservice=",
                ids,
                " and datesystem='",
                du,
                "') as t  "
            }));
        }

        // Token: 0x060014F3 RID: 5363 RVA: 0x000B75C0 File Offset: 0x000B57C0
        public static int getCouverts(DateTime du, DateTime au, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE(sum(couvert),0) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and idservice=",
                ids,
                " "
            }));
        }

        // Token: 0x060014F4 RID: 5364 RVA: 0x000B761C File Offset: 0x000B581C
        public static int getCouverts(DateTime du, DateTime au)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE(sum(couvert),0) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  "
            }));
        }

        // Token: 0x060014F5 RID: 5365 RVA: 0x000B7668 File Offset: 0x000B5868
        public static int getCouverts(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select COALESCE(sum(couvert),0) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  and  idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ") "
            }));
        }

        // Token: 0x060014F6 RID: 5366 RVA: 0x000B76C7 File Offset: 0x000B58C7
        public static int getNbrTicket(int ids)
        {
            return Connexion.executeScalar("select count(*) from facture where idservice=" + ids + " ");
        }

        // Token: 0x060014F7 RID: 5367 RVA: 0x000B76E4 File Offset: 0x000B58E4
        public static int getNbrTicketSolderByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from facture where idservice=",
                ids,
                " and idutilisateur = ",
                idutilisateur,
                " and solder=true; "
            }));
        }

        // Token: 0x060014F8 RID: 5368 RVA: 0x000B7730 File Offset: 0x000B5930
        public static int getNbrTicketOuverteByUser(int ids, int idutilisateur)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from facture where idservice=",
                ids,
                " and idutilisateur = ",
                idutilisateur,
                " and solder=false "
            }));
        }

        // Token: 0x060014F9 RID: 5369 RVA: 0x000B777C File Offset: 0x000B597C
        public static int getNbrTicket(DateTime du, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from (select id from facture where idservice=",
                ids,
                " union all select id from archfacture where idservice=",
                ids,
                " and datesystem='",
                du,
                "') as t  "
            }));
        }

        // Token: 0x060014FA RID: 5370 RVA: 0x000B77D8 File Offset: 0x000B59D8
        public static int getNbrTicket(DateTime du, DateTime au)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  "
            }));
        }

        // Token: 0x060014FB RID: 5371 RVA: 0x000B7824 File Offset: 0x000B5A24
        public static int getNbrTicket(DateTime du, DateTime au, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "' and idservice=",
                ids,
                " "
            }));
        }

        // Token: 0x060014FC RID: 5372 RVA: 0x000B7880 File Offset: 0x000B5A80
        public static int getNbrTicket(DateTime du, DateTime au, PointDeVente _pointDeVente)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  and  idservice in (select id from service where idpointvente=",
                _pointDeVente._id,
                ") "
            }));
        }

        // Token: 0x060014FD RID: 5373 RVA: 0x000B78E0 File Offset: 0x000B5AE0
        public static decimal getTotalFacture(DateTime du, DateTime au)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select sum(totalfacture) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  "
            }));
        }

        // Token: 0x060014FE RID: 5374 RVA: 0x000B7930 File Offset: 0x000B5B30
        public static decimal getTotalTVA(DateTime du, DateTime au)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select sum(totaltva) from archfacture where datesystem<='",
                au,
                "' and datesystem>='",
                du,
                "'  "
            }));
        }

        // Token: 0x060014FF RID: 5375 RVA: 0x000B797E File Offset: 0x000B5B7E
        public static int getChiffreAffaireAvecCouvert(int ids)
        {
            return Connexion.executeScalar("select coalesce(sum(lignefacture.prixtotal),0) from lignefacture,facture where facture.idservice=" + ids + " and facture.couvert <> 0 and facture.id=lignefacture.id ");
        }

        // Token: 0x06001500 RID: 5376 RVA: 0x000B799C File Offset: 0x000B5B9C
        public static int getChiffreAffaireAvecCouvert(DateTime du, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select coalesce(sum(prixtotal),0) from (select lignefacture.prixtotal from lignefacture,facture where facture.idservice=",
                ids,
                " and facture.couvert <> 0 and facture.id=lignefacture.id union all select archlignefacture.prixtotal from archlignefacture,archfacture where archfacture.idservice=",
                ids,
                " and archfacture.couvert <> 0 and archlignefacture.id=archfacture.id and archfacture.datesystem='",
                du,
                "') as t  "
            }));
        }

        // Token: 0x06001501 RID: 5377 RVA: 0x000B79F8 File Offset: 0x000B5BF8
        public static int getChiffreAffaireAvecCouvert(DateTime du, DateTime au, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "select coalesce(sum(archlignefacture.prixtotal),0) from archlignefacture,archfacture where archfacture.datesystem<='",
                au,
                "' and archfacture.datesystem>='",
                du,
                "' and archfacture.idservice=",
                ids,
                " and archfacture.couvert <> 0 and archlignefacture.id=archfacture.id"
            }));
        }

        // Token: 0x06001502 RID: 5378 RVA: 0x000B7A54 File Offset: 0x000B5C54
        private DataTable getAllByCompte(int idcardex)
        {
            string text = " select facture.* from facture where (facture.id,facture.idservice) in ( select facture.id,facture.idservice from facture, lignepaiement where facture.id=lignepaiement.id and lignepaiement.idcardex=" + idcardex + " and lignepaiement.idservice=facture.idservice group by facture.id, facture.idservice having sum(lignepaiement.montant)<>0) ";
            object obj = text;
            text = string.Concat(new object[]
            {
                obj,
                " union  select archfacture.* from archfacture where( archfacture.id, archfacture.idservice) in ( select archfacture.id,archfacture.idservice from archfacture, (select * from lignepaiement where lignepaiement.idcardex=",
                idcardex,
                "  union select * from archlignepaiement where archlignepaiement.idcardex=",
                idcardex,
                "  ) as t where archfacture.id=t.id and t.idservice=archfacture.idservice  group by archfacture.id ,archfacture.idservice having sum(t.montant)<>0)"
            });
            return Connexion.executeQuery(text);
        }

        // Token: 0x06001503 RID: 5379 RVA: 0x000B7ABB File Offset: 0x000B5CBB
        public static List<Facture> getFacture()
        {
            return FactureDAL._list;
        }

        // Token: 0x06001504 RID: 5380 RVA: 0x000B7AC4 File Offset: 0x000B5CC4
        public static int addFacture(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO facture(id, ntable, couvert, idutilisateur, totalfacture, totaltva, solder, dateouverture, idservice,datesystem,datefermeture,serveur,etatfacture,idzone,idclient,cloture,valminspend) VALUES (",
                l._id,
                ", '",
                l._table,
                "', ",
                l._couvert,
                ", ",
                l._utilisateur._id,
                ", ",
                Converting.decimalToString(l._totalFacture),
                ", ",
                Converting.decimalToString(l._totalTva),
                ", ",
                l._solder,
                ", CURRENT_TIMESTAMP,   ",
                l._service._id,
                ",(select date from parametrage), '",
                l._dateFermeture,
                "' , '",
                l._serveur,
                "' , '",
                l._etatFacture,
                "', ",
                l._zone._id,
                ", ",
                l._idClient,
                ", ",
                l._cloture,
                ", ",
                Converting.decimalToString(l._valMinSpend),
                ");"
            }));
        }

        // Token: 0x06001505 RID: 5381 RVA: 0x000B7C54 File Offset: 0x000B5E54
        public static int updateFacture(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET ntable='",
                l._table,
                "', couvert=",
                l._couvert,
                ", idutilisateur=",
                l._utilisateur._id,
                ", totalfacture=",
                Converting.decimalToString(l._totalFacture),
                ", totaltva=",
                Converting.decimalToString(l._totalTva),
                ", solder=",
                l._solder,
                ",  datefermeture='",
                l._dateFermeture,
                "', serveur='",
                l._serveur,
                "',numerofacture=",
                l._numeroFacture,
                ", cloture=",
                l._cloture,
                ", transfert=",
                l._transfert,
                ", valminspend=",
                Converting.decimalToString(l._valMinSpend),
                "  WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            }));
        }

        // Token: 0x06001506 RID: 5382 RVA: 0x000B7DC4 File Offset: 0x000B5FC4
        public static int updateFactureClient(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET idclient=",
                l._idClient,
                " WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            }));
        }

        // Token: 0x06001507 RID: 5383 RVA: 0x000B7E34 File Offset: 0x000B6034
        public static int updateZoneFacture(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET idzone=",
                l._zone._id,
                "  WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            }));
        }

        // Token: 0x06001508 RID: 5384 RVA: 0x000B7EA8 File Offset: 0x000B60A8
        public static int updateArchFacture(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE archfacture SET numerofacture=",
                l._numeroFacture,
                "  WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            }));
        }

        // Token: 0x06001509 RID: 5385 RVA: 0x000B7F18 File Offset: 0x000B6118
        public static int updateEtatFacture(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET etatfacture='",
                l._etatFacture,
                "' WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                "; ",
                ReclamationFactureDAL.getRequestReclamationFacture(new ReclamationFacture(l._id, l._etatFacture, DateTime.Now, l._utilisateur._login, l._service._id))
            }));
        }

        // Token: 0x0600150A RID: 5386 RVA: 0x000B7FBC File Offset: 0x000B61BC
        public static int updateFactureForWeb(Facture l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET   totalfacture=",
                Converting.decimalToString(Math.Round(l._totalFacture, Parametrage._nombredecimalpdv)),
                ", solder=",
                l._solder,
                "  WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            }));
        }

        // Token: 0x0600150B RID: 5387 RVA: 0x000B804B File Offset: 0x000B624B
        public static int updateNbrImpression(Facture l, string type)
        {
            return Connexion.executeScalar(LigneFactureDAL.getRequestUpdateNbrImpression(l, type));
        }

        // Token: 0x0600150C RID: 5388 RVA: 0x000B805C File Offset: 0x000B625C
        public static int updateFacture(Facture l, Facture l2)
        {
            string text = string.Concat(new object[]
            {
                " UPDATE facture SET ntable='",
                l._table,
                "', couvert=",
                l._couvert,
                ", idutilisateur=",
                l._utilisateur._id,
                ", totalfacture=",
                Converting.decimalToString(Math.Round(l._totalFacture, Parametrage._nombredecimalpdv)),
                ", totaltva=",
                Converting.decimalToString(Math.Round(l._totalTva, Parametrage._nombredecimalpdv)),
                ", solder=",
                l._solder,
                ",  datefermeture='",
                l._dateFermeture,
                "', serveur='",
                l._serveur,
                "' WHERE id=",
                l._id,
                " and idservice=",
                l._service._id,
                ";"
            });
            object obj = text;
            text = string.Concat(new object[]
            {
                obj,
                " UPDATE facture SET ntable='",
                l2._table,
                "', couvert=",
                l2._couvert,
                ", idutilisateur=",
                l2._utilisateur._id,
                ", totalfacture=",
                Converting.decimalToString(Math.Round(l2._totalFacture, Parametrage._nombredecimalpdv)),
                ", totaltva=",
                Converting.decimalToString(Math.Round(l2._totalTva, Parametrage._nombredecimalpdv)),
                ", solder=",
                l2._solder,
                ",  datefermeture='",
                l2._dateFermeture,
                "', serveur='",
                l2._serveur,
                "' WHERE id=",
                l2._id,
                " and idservice=",
                l2._service._id,
                ";"
            });
            foreach (LigneFacture ligneFacture in l._listLigneFacture)
            {
                object obj2 = text;
                text = string.Concat(new object[]
                {
                    obj2,
                    " DELETE from lignefacture where sid=",
                    ligneFacture._sid,
                    "  ; "
                });
            }
            foreach (LigneFacture ligneFacture2 in l2._listLigneFacture)
            {
                object obj3 = text;
                text = string.Concat(new object[]
                {
                    obj3,
                    " DELETE from lignefacture where sid=",
                    ligneFacture2._sid,
                    "  ; "
                });
            }
            text += LigneFactureDAL.addLigneFactureForTransfert(l._listLigneFacture);
            text += LigneFactureDAL.addLigneFactureForTransfert(l2._listLigneFacture);
            return Connexion.executeScalar(text);
        }

        // Token: 0x0600150D RID: 5389 RVA: 0x000B83CC File Offset: 0x000B65CC
        public static EtatFacture getEtatFacture(Facture _facture)
        {
            FactureDAL._etatFacture = new EtatFacture();
            FactureDAL._etatFacture._nbrLigneFacture = Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from lignefacture where idservice=",
                _facture._service._id,
                " and id=",
                _facture._id,
                "   "
            }));
            FactureDAL._etatFacture._nbrLignePaiement = Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from lignepaiement where idservice=",
                _facture._service._id,
                " and id=",
                _facture._id,
                "   "
            }));
            FactureDAL._etatFacture._solder = Convert.ToBoolean(Connexion.executeQuery(string.Concat(new object[]
            {
                "select solder from facture where idservice=",
                _facture._service._id,
                " and id=",
                _facture._id,
                "   "
            })).Rows[0][0]);
            return FactureDAL._etatFacture;
        }

        // Token: 0x0600150E RID: 5390 RVA: 0x000B8500 File Offset: 0x000B6700
        public static int updateFactureSolder(Service s)
        {
            Console.WriteLine(string.Concat(new object[]
            {
                " UPDATE facture SET solder=true, datefermeture='",
                DateTime.Now,
                "'  WHERE totalfacture=0 and idservice=",
                s._id,
                " and solder=false and id not in (select id from lignefacture) and id not in (select id from lignepaiement)  ;"
            }));
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET solder=true, datefermeture='",
                DateTime.Now,
                "'  WHERE totalfacture=0 and idservice=",
                s._id,
                " and solder=false and id not in (select id from lignefacture) and id not in (select id from lignepaiement)  ;"
            }));
        }

        // Token: 0x0600150F RID: 5391 RVA: 0x000B8598 File Offset: 0x000B6798
        public static int repriseFactureSolder(int c, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET solder=false  WHERE id=",
                c,
                " and idservice=",
                ids,
                ";"
            }));
        }

        // Token: 0x06001510 RID: 5392 RVA: 0x000B85E4 File Offset: 0x000B67E4
        public static int updateMinSpend(Facture _facture)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE facture SET valminspend=",
                Converting.decimalToString(_facture._valMinSpend),
                "  WHERE id=",
                _facture._id,
                " and idservice=",
                _facture._service._id,
                ";"
            }));
        }

        // Token: 0x06001511 RID: 5393 RVA: 0x000B8654 File Offset: 0x000B6854
        public static int UhSF(int idf, int ids)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                " UPDATE archfacture SET couvert=0,   totalfacture=0.00 , totaltva=0.00   WHERE id=",
                idf,
                " and idservice=",
                ids,
                "; delete from archlignepaiement where id=",
                idf,
                " and idservice=",
                ids,
                "; delete from archlignefacture where id=",
                idf,
                " and idservice=",
                ids,
                "; "
            }));
        }

        // Token: 0x06001512 RID: 5394 RVA: 0x000B86E8 File Offset: 0x000B68E8
        public static int annulerFactureSolder(Facture f)
        {
            string text = " ";
            decimal num = 0m;
            foreach (LignePaiement lignePaiement in f._listLignePaiement)
            {
                num += lignePaiement._montant;
                lignePaiement._montant = -lignePaiement._montant;
                lignePaiement._utilisateur = Session._utilisateur;
                text += LignePaiementDAL.getRequestAdd(lignePaiement);
            }
            LignePaiement lignePaiement2 = new LignePaiement();
            lignePaiement2 = f._listLignePaiement[0];
            lignePaiement2._montant = num;
            lignePaiement2._utilisateur = Session._utilisateur;
            lignePaiement2._libelleModePaiement = "ANNULER";
            text += LignePaiementDAL.getRequestAdd(lignePaiement2);
            return Connexion.executeScalar(text);
        }

        // Token: 0x06001513 RID: 5395 RVA: 0x000B87EC File Offset: 0x000B69EC
        public static Facture getFacture(int c, int ids)
        {
            return FactureDAL._list.Find((Facture bk) => bk._id == c && bk._service._id == ids);
        }

        // Token: 0x06001514 RID: 5396 RVA: 0x000B8840 File Offset: 0x000B6A40
        public static Facture getFacture(int c)
        {
            return FactureDAL._list.Find((Facture bk) => bk._id == c);
        }

        // Token: 0x06001515 RID: 5397 RVA: 0x000B8890 File Offset: 0x000B6A90
        public static List<Facture> getListFactureByService(int id)
        {
            List<Facture> list = new List<Facture>();
            return FactureDAL._list.FindAll((Facture bk) => bk._service._id == id);
        }

        // Token: 0x06001516 RID: 5398 RVA: 0x000B88C8 File Offset: 0x000B6AC8
        public List<Facture> getClientTable(Service _service, int _table)
        {
            List<Facture> list = new List<Facture>();
            this.dt = new DataTable();
            FactureDAL._list = new List<Facture>();
            this._serviceDAL = new ServiceDAL();
            this._zoneDAL = new ZoneDAL();
            this._listLigneFacture = new List<LigneFacture>();
            this._listLignePaiement = new List<LignePaiement>();
            this.F = new Facture();
            this.D = new Service();
            this.U = new Utilisateur();
            this.dt = this.getAllTableParClient(_service, _table);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.D = ServiceDAL.getService(Convert.ToInt32(dataRow[9]));
                this.U = UtilisateurDAL.getUtilisateur(Convert.ToInt32(dataRow[3]));
                if (Convert.ToInt32(dataRow[14]) == 0)
                {
                    this.Z = new Zone();
                }
                else
                {
                    this.Z = this._zoneDAL.getZone(Convert.ToInt32(dataRow[14]));
                }
                this._dateOuverture = default(DateTime);
                this._dateFermeture = default(DateTime);
                this._dateSystem = default(DateTime);
                if (dataRow[7] != DBNull.Value)
                {
                    this._dateOuverture = Convert.ToDateTime(dataRow[7]);
                }
                if (dataRow[8] != DBNull.Value)
                {
                    this._dateFermeture = Convert.ToDateTime(dataRow[8]);
                }
                if (dataRow[10] != DBNull.Value)
                {
                    this._dateSystem = Convert.ToDateTime(dataRow[10]);
                }
                this.F = new Facture(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), this.U, Convert.ToDecimal(dataRow[4].ToString().Trim()), Math.Round(Convert.ToDecimal(dataRow[5].ToString().Trim()), Parametrage._nombredecimalpdv), Convert.ToBoolean(dataRow[6]), this._dateOuverture, this._dateFermeture, this.D, this._listLigneFacture, this._listLignePaiement, this._dateSystem, dataRow[11].ToString().Trim(), Convert.ToChar(dataRow[12].ToString()), Convert.ToInt32(dataRow[13]), this.Z, Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), Convert.ToBoolean(dataRow[17]), Convert.ToDecimal(dataRow[18]));
                list.Add(this.F);
            }
            return list;
        }

        // Token: 0x06001517 RID: 5399 RVA: 0x000B8BE4 File Offset: 0x000B6DE4
        public static List<Facture> getListFactureByServiceAndUser(int ids, int idutilisateur)
        {
            List<Facture> list = new List<Facture>();
            return FactureDAL._list.FindAll((Facture bk) => bk._service._id == ids && bk._utilisateur._id == idutilisateur);
        }

        // Token: 0x06001518 RID: 5400 RVA: 0x000B8C48 File Offset: 0x000B6E48
        public static List<Facture> getListFactureSolderByService(int id)
        {
            List<Facture> list = new List<Facture>();
            return FactureDAL._list.FindAll((Facture bk) => bk._service._id == id && bk._solder);
        }

        // Token: 0x06001519 RID: 5401 RVA: 0x000B8CB8 File Offset: 0x000B6EB8
        public static List<Facture> getListFactureSolderByServiceAndUser(int ids, int idutilisateur)
        {
            List<Facture> list = new List<Facture>();
            return FactureDAL._list.FindAll((Facture bk) => bk._service._id == ids && bk._utilisateur._id == idutilisateur && bk._solder);
        }

        // Token: 0x0600151A RID: 5402 RVA: 0x000B8CF8 File Offset: 0x000B6EF8
        public static int archivageFacture(Service _service, bool _solder)
        {
            string text;
            if (_solder)
            {
                text = string.Concat(new object[]
                {
                    " insert into archfacture select * from facture where solder=true and idservice=",
                    _service._id,
                    " and cloture=false; delete from facture where solder=true and idservice=",
                    _service._id,
                    " and cloture=false;"
                });
                object obj = text;
                text = string.Concat(new object[]
                {
                    obj,
                    " insert into archlignefacture select * from lignefacture where id not in(select id from facture where  idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    " ; delete from lignefacture where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    ";"
                });
                object obj2 = text;
                text = string.Concat(new object[]
                {
                    obj2,
                    " insert into archlignepaiement select * from lignepaiement where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and   idservice=",
                    _service._id,
                    "; delete from lignepaiement where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    ";"
                });
                text += " insert into archcommandeclient select * from commandeclient ; delete from commandeclient; ";
                text += " insert into archcommandeserveur select * from commandeserveur ; delete from commandeserveur; ";
                object obj3 = text;
                text = string.Concat(new object[]
                {
                    obj3,
                    " insert into archlogpdv select * from logpdv where idservice=",
                    _service._id,
                    "; delete from logpdv where idservice=",
                    _service._id,
                    "; "
                });
                text += " insert into archlignecommandeclient select * from lignecommandeclient ; delete from lignecommandeclient; ";
                text += " insert into archlignecommandeserveur select * from lignecommandeserveur ; delete from lignecommandeserveur; ";
                text += " insert into archreclamationfacture select * from reclamationfacture ; delete from reclamationfacture; ";
                text += " insert into archlignedepense select * from lignedepense ; delete from lignedepense; ";
                text += " delete from commandekitchen; delete from lignecommandekitchen; ";
                text += " insert into archentreestock select * from entreestock ; delete from entreestock; ";
                text += " alter sequence lignefacture_sid_seq restart with 1 ;";
            }
            else
            {
                text = string.Concat(new object[]
                {
                    " insert into archfacture select * from facture where idservice=",
                    _service._id,
                    " and cloture=false; delete from facture where idservice=",
                    _service._id,
                    " and cloture=false;"
                });
                object obj4 = text;
                text = string.Concat(new object[]
                {
                    obj4,
                    " insert into archlignefacture select * from lignefacture where id not in(select id from facture where  idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    " ; delete from lignefacture where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    ";"
                });
                object obj5 = text;
                text = string.Concat(new object[]
                {
                    obj5,
                    " insert into archlignepaiement select * from lignepaiement where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and   idservice=",
                    _service._id,
                    "; delete from lignepaiement where id not in(select id from facture where idservice=",
                    _service._id,
                    ") and  idservice=",
                    _service._id,
                    ";"
                });
                text += " insert into archcommandeclient select * from commandeclient ; delete from commandeclient; ";
                text += " insert into archcommandeserveur select * from commandeserveur ; delete from commandeserveur; ";
                object obj6 = text;
                text = string.Concat(new object[]
                {
                    obj6,
                    " insert into archlogpdv select * from logpdv where idservice=",
                    _service._id,
                    "; delete from logpdv where idservice=",
                    _service._id,
                    "; "
                });
                text += " insert into archlignecommandeclient select * from lignecommandeclient ; delete from lignecommandeclient; ";
                text += " insert into archlignecommandeserveur select * from lignecommandeserveur ; delete from lignecommandeserveur; ";
                text += " insert into archreclamationfacture select * from reclamationfacture ; delete from reclamationfacture; ";
                text += " insert into archlignedepense select * from lignedepense ; delete from lignedepense; ";
                text += " delete from commandekitchen; delete from lignecommandekitchen; ";
                text += " insert into archentreestock select * from entreestock ; delete from entreestock; ";
                text += " alter sequence lignefacture_sid_seq restart with 1 ;";
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x04000F3B RID: 3899
        private DataTable dt;

        // Token: 0x04000F3C RID: 3900
        private static List<Facture> _list;

        // Token: 0x04000F3D RID: 3901
        private static EtatFacture _etatFacture = new EtatFacture();

        // Token: 0x04000F3E RID: 3902
        private ServiceDAL _serviceDAL;

        // Token: 0x04000F3F RID: 3903
        private LigneFactureDAL _ligneFactureDAL;

        // Token: 0x04000F40 RID: 3904
        private LignePaiementDAL _lignePaiementDAL;

        // Token: 0x04000F41 RID: 3905
        private ZoneDAL _zoneDAL;

        // Token: 0x04000F42 RID: 3906
        private List<LigneFacture> _listLigneFacture;

        // Token: 0x04000F43 RID: 3907
        private List<LignePaiement> _listLignePaiement;

        // Token: 0x04000F44 RID: 3908
        private Facture F;

        // Token: 0x04000F45 RID: 3909
        private Service D;

        // Token: 0x04000F46 RID: 3910
        private Utilisateur U;

        // Token: 0x04000F47 RID: 3911
        private Zone Z;

        // Token: 0x04000F48 RID: 3912
        private DateTime _dateOuverture;

        // Token: 0x04000F49 RID: 3913
        private DateTime _dateFermeture;

        // Token: 0x04000F4A RID: 3914
        private DateTime _dateSystem;
    }
}
