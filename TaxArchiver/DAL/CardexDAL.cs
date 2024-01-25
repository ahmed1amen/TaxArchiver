using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    internal class CardexDAL
    {
        // Token: 0x06001B0B RID: 6923 RVA: 0x000E6338 File Offset: 0x000E4538
        public CardexDAL(bool vide)
        {
            this.dt = new DataTable();
            CardexDAL._list = new List<Cardex>();
        }

        // Token: 0x06001B0C RID: 6924 RVA: 0x000E6358 File Offset: 0x000E4558
        public CardexDAL()
        {
            this.dt = new DataTable();
            CardexDAL._list = new List<Cardex>();
            this.pays = new Pays();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    this.pays = PaysDAL.getPays(Convert.ToInt32(dataRow[11]));
                }
                else
                {
                    this.pays = new Pays();
                }
                DateTime dateNaissance = default(DateTime);
                if (dataRow[6] != DBNull.Value)
                {
                    dateNaissance = Convert.ToDateTime(dataRow[6]);
                }
                Cardex item = new Cardex(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), dataRow[3].ToString().Trim(), dataRow[4].ToString().Trim(), dataRow[5].ToString().Trim(), dateNaissance, Convert.ToBoolean(dataRow[7]), Convert.ToInt32(dataRow[8]), dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), this.pays, dataRow[12].ToString().Trim(), dataRow[13].ToString().Trim(), Convert.ToDecimal(dataRow[14]));
                CardexDAL._list.Add(item);
            }
        }

        // Token: 0x06001B0D RID: 6925 RVA: 0x000E6534 File Offset: 0x000E4734
        public CardexDAL(Cardex _cardex)
        {
            this.dt = new DataTable();
            CardexDAL._list = new List<Cardex>();
            this.pays = new Pays();
            this.dt = this.getAll(_cardex);
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    this.pays = PaysDAL.getPays(Convert.ToInt32(dataRow[11]));
                }
                else
                {
                    this.pays = new Pays();
                }
                DateTime dateNaissance = default(DateTime);
                if (dataRow[6] != DBNull.Value)
                {
                    dateNaissance = Convert.ToDateTime(dataRow[6]);
                }
                Cardex item = new Cardex(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), dataRow[3].ToString().Trim(), dataRow[4].ToString().Trim(), dataRow[5].ToString().Trim(), dateNaissance, Convert.ToBoolean(dataRow[7]), Convert.ToInt32(dataRow[8]), dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), this.pays, dataRow[12].ToString().Trim(), dataRow[13].ToString().Trim(), 0m);
                CardexDAL._list.Add(item);
            }
        }

        // Token: 0x06001B0E RID: 6926 RVA: 0x000E670C File Offset: 0x000E490C
        public CardexDAL(int id)
        {
            this.dt = new DataTable();
            CardexDAL._list = new List<Cardex>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (Convert.ToInt32(dataRow[11]) != 0)
                {
                    this.pays = PaysDAL.getPays(Convert.ToInt32(dataRow[11]));
                }
                else
                {
                    this.pays = new Pays();
                }
                DateTime dateNaissance = default(DateTime);
                if (dataRow[6] != DBNull.Value)
                {
                    dateNaissance = Convert.ToDateTime(dataRow[6]);
                }
                Cardex item = new Cardex(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), dataRow[3].ToString().Trim(), dataRow[4].ToString().Trim(), dataRow[5].ToString().Trim(), dateNaissance, Convert.ToBoolean(dataRow[7]), Convert.ToInt32(dataRow[8]), dataRow[9].ToString().Trim(), dataRow[10].ToString().Trim(), this.pays, dataRow[12].ToString().Trim(), dataRow[13].ToString().Trim(), 0m);
                CardexDAL._list.Add(item);
            }
        }

        // Token: 0x06001B0F RID: 6927 RVA: 0x000E68D8 File Offset: 0x000E4AD8
        private DataTable getAll(int id)
        {
            string sql = "select * cardex where id=" + id + " ";
            return Connexion.executeQuery(sql);
        }

        // Token: 0x06001B10 RID: 6928 RVA: 0x000E6904 File Offset: 0x000E4B04
        private DataTable getAll(Cardex cardex)
        {
            string text = " ";
            int num = 0;
            text += "select * from cardex where ";
            if (cardex._nom != "")
            {
                text = text + " nom like '%" + cardex._nom + "%'  ";
                num = 1;
            }
            if (cardex._prenom != "")
            {
                if (num != 0)
                {
                    text += " or ";
                }
                else
                {
                    num = 1;
                }
                text = text + " prenom like '%" + cardex._prenom + "%'  ";
            }
            if (cardex._tel != "")
            {
                if (num != 0)
                {
                    text += " or ";
                }
                text = text + " tel like '%" + cardex._tel + "%'  ";
            }
            text += "  order by id; ";
            return Connexion.executeQuery(text);
        }

        // Token: 0x06001B11 RID: 6929 RVA: 0x000E69D8 File Offset: 0x000E4BD8
        private DataTable getAll()
        {
            string text = "select cardex.*,coalesce(sum(l1.summontant),'0') as total from  ( ";
            text += " select idcardex, sum(lignepaiement.montant) as summontant from lignepaiement group by idcardex ";
            text += " union ";
            text += " select idcardex, sum(archlignepaiement.montant) as summontant from archlignepaiement group by idcardex ";
            text += " ) as l1 right join cardex on cardex.id= l1.idcardex ";
            text += " group by cardex.id, cardex.nom, cardex.adresse, cardex.tel, cardex.fax, cardex.email, cardex.datenaissance, cardex.etat, cardex.remise,  cardex.prenom, cardex.statut, cardex.idpays, cardex.indicatif, cardex.preference order by cardex.id  ";
            return Connexion.executeQuery(text);
        }

        // Token: 0x06001B12 RID: 6930 RVA: 0x000E6A30 File Offset: 0x000E4C30
        public static int addCardex(Cardex l)
        {
            string text = " INSERT INTO cardex( nom, adresse, tel, fax, email, datenaissance, etat, remise, prenom, statut, idpays, indicatif, preference)";
            object obj = text;
            text = string.Concat(new object[]
            {
                obj,
                " VALUES ('",
                l._nom.ToUpper(),
                "', '",
                l._adresse,
                "', '",
                l._tel,
                "', '",
                l._fax,
                "', '",
                l._email,
                "', '",
                l._dateNaissance,
                "', ",
                l._etat,
                ", ",
                l._remise,
                ", '",
                l._prenom,
                "', '",
                l._statut,
                "', ",
                l._pays._id,
                ", '",
                l._indicatif,
                "', '",
                l._preference,
                "');select currval('",
                '"',
                "cardex_id_seq",
                '"',
                "');"
            });
            return Connexion.executeScalar(text);
        }

        // Token: 0x06001B13 RID: 6931 RVA: 0x000E6B9C File Offset: 0x000E4D9C
        public static int updateCardex(Cardex l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE cardex SET nom='",
                l._nom.ToUpper(),
                "', adresse='",
                l._adresse,
                "', tel='",
                l._tel,
                "', fax='",
                l._fax,
                "', email='",
                l._email,
                "', datenaissance='",
                l._dateNaissance,
                "', remise=",
                l._remise,
                ", prenom='",
                l._prenom,
                "', statut='",
                l._statut,
                "', idpays=",
                l._pays._id,
                ", indicatif='",
                l._indicatif,
                "', preference='",
                l._preference,
                "' WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06001B14 RID: 6932 RVA: 0x000E6CD1 File Offset: 0x000E4ED1
        public static List<Cardex> getCardex()
        {
            return CardexDAL._list;
        }

        // Token: 0x06001B15 RID: 6933 RVA: 0x000E6CF8 File Offset: 0x000E4EF8
        public static Cardex getCardex(Cardex c)
        {
            return CardexDAL._list.Find((Cardex bk) => bk._id == c._id);
        }

        // Token: 0x06001B16 RID: 6934 RVA: 0x000E6D44 File Offset: 0x000E4F44
        public static Cardex getCardex(int c)
        {
            return CardexDAL._list.Find((Cardex bk) => bk._id == c);
        }

        // Token: 0x04001353 RID: 4947
        private DataTable dt;

        // Token: 0x04001354 RID: 4948
        private static List<Cardex> _list;

        // Token: 0x04001355 RID: 4949
        private Pays pays;
    }
}
