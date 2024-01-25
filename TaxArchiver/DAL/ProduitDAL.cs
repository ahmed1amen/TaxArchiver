using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static TaxArchiver.Models.FamilleCarte;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Functions;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    public class ProduitDAL
    {
        // Token: 0x060004C8 RID: 1224 RVA: 0x00034147 File Offset: 0x00032347
        public ProduitDAL(bool empty)
        {
        }

        // Token: 0x060004C9 RID: 1225 RVA: 0x00034150 File Offset: 0x00032350
        public ProduitDAL()
        {
            this.dt = new DataTable();
            ProduitDAL._list = new List<Produit>();
            new TvaDAL();
            FamilleCarteDAL familleCarteDAL = new FamilleCarteDAL();
            new ImprimanteDAL();
            FamilleMessageDAL familleMessageDAL = new FamilleMessageDAL();
            new CategorieDAL();
            ComposantProduitDAL composantProduitDAL = new ComposantProduitDAL();
            Produit item = new Produit();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                FamilleCarte familleCarte = familleCarteDAL.getFamilleCarte(Convert.ToInt32(dataRow[8]));
                Imprimante imprimante;
                if (Convert.ToInt32(dataRow[10]) == 0)
                {
                    imprimante = new Imprimante();
                }
                else
                {
                    imprimante = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[10]));
                }
                Imprimante imprimante2;
                if (Convert.ToInt32(dataRow[31]) == 0)
                {
                    imprimante2 = new Imprimante();
                }
                else
                {
                    imprimante2 = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[31]));
                }
                Imprimante imprimante3;
                if (Convert.ToInt32(dataRow[32]) == 0)
                {
                    imprimante3 = new Imprimante();
                }
                else
                {
                    imprimante3 = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[32]));
                }
                Imprimante imprimante4;
                if (Convert.ToInt32(dataRow[33]) == 0)
                {
                    imprimante4 = new Imprimante();
                }
                else
                {
                    imprimante4 = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[33]));
                }
                FamilleMessage familleMessage;
                if (Convert.ToInt32(dataRow[18]) == 0)
                {
                    familleMessage = new FamilleMessage();
                }
                else
                {
                    familleMessage = familleMessageDAL.getFamilleMessage(Convert.ToInt32(dataRow[18]));
                }
                Tva tva = TvaDAL.getTva(Convert.ToInt32(dataRow[7]));
                Categorie categorie = CategorieDAL.getCategorie(Convert.ToInt32(dataRow[17].ToString().Trim()));
                item = new Produit(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), categorie, Convert.ToDecimal(dataRow[4].ToString().Trim()), Convert.ToDecimal(dataRow[5].ToString().Trim()), Convert.ToDecimal(dataRow[6].ToString().Trim()), tva, familleCarte, dataRow[9].ToString().Trim(), imprimante, Convert.ToBoolean(dataRow[11]), Convert.ToBoolean(dataRow[12]), Convert.ToInt32(dataRow[13]), Convert.ToBoolean(dataRow[14]), Convert.ToInt32(dataRow[15]), Convert.ToBoolean(dataRow[16]), familleMessage, dataRow[19].ToString(), Convert.ToBoolean(dataRow[20]), dataRow[21].ToString().Trim(), dataRow[22].ToString().Trim(), Convert.ToDecimal(dataRow[23].ToString().Trim()), Convert.ToDecimal(dataRow[24].ToString().Trim()), Convert.ToDecimal(dataRow[25]), Convert.ToDecimal(dataRow[26]), Convert.ToDecimal(dataRow[27]), Convert.ToDecimal(dataRow[29]), Convert.ToDecimal(dataRow[28]), Convert.ToBoolean(dataRow[30]), imprimante2, composantProduitDAL.getComposantProduitByIdProduit(Convert.ToInt32(dataRow[0])), imprimante3, imprimante4, Convert.ToInt32(dataRow[34]));
                ProduitDAL._list.Add(item);
            }
        }

        // Token: 0x060004CA RID: 1226 RVA: 0x00034528 File Offset: 0x00032728
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from produit order by ordre,id");
        }

        // Token: 0x060004CB RID: 1227 RVA: 0x00034534 File Offset: 0x00032734
        private DataTable getAllUpdate()
        {
            return Connexion.executeQuery("select id, etat, qtevente,qtevisuelle from produit order by id");
        }

        // Token: 0x060004CC RID: 1228 RVA: 0x00034540 File Offset: 0x00032740
        private DataTable getAllRupture()
        {
            return Connexion.executeQuery("select id,libelle , etat, qtevente,qtevisuelle-qtevente from produit where qtevisuelle-qtevente <5 and  qtevisuelle !=0  order by  qtevisuelle ");
        }

        // Token: 0x060004CD RID: 1229 RVA: 0x0003456C File Offset: 0x0003276C
        public List<Produit> updateProduit(List<Produit> _listProduit)
        {
            this.dt = new DataTable();
            ProduitUpdate P = new ProduitUpdate();
            this.dt = this.getAllUpdate();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                P = new ProduitUpdate(Convert.ToInt32(dataRow[0]), Convert.ToBoolean(dataRow[1]), Convert.ToDecimal(dataRow[2]), Convert.ToDecimal(dataRow[3]));
                Produit produit = _listProduit.FirstOrDefault((Produit Produit) => Produit._id == P._id);
                if (produit._id == P._id)
                {
                    produit._etat = P._etat;
                    produit._qteVente = P._qteVente;
                    produit._qteVisuelle = P._qteVisuelle;
                }
            }
            return _listProduit;
        }

        // Token: 0x060004CE RID: 1230 RVA: 0x00034694 File Offset: 0x00032894
        public List<ProduitUpdate> RuptureProduit()
        {
            this.dt = new DataTable();
            List<ProduitUpdate> list = new List<ProduitUpdate>();
            ProduitUpdate item = new ProduitUpdate();
            this.dt = this.getAllRupture();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                item = new ProduitUpdate(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToBoolean(dataRow[2]), Convert.ToDecimal(dataRow[3]), Convert.ToDecimal(dataRow[4]));
                list.Add(item);
            }
            return list;
        }

        // Token: 0x060004CF RID: 1231 RVA: 0x00034760 File Offset: 0x00032960
        public static List<Produit> getProduit()
        {
            return ProduitDAL._list;
        }

        // Token: 0x060004D0 RID: 1232 RVA: 0x00034768 File Offset: 0x00032968
        public static int addProduit(Produit l)
        {
            int result = Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO produit( libelle, type, categorie, prix, prixachat, ratiomultiplicateur, idtva, idfamille, codebarre, idimprimante, composer, imprimercomposant,  nbrportion, accompagnement, idcategorie, ordre, etat, famillecomposante, couleur, prixmanuel,description,prix1,prix2,prix3,prix4,prix5, prixparqte, idimprimante2, idimprimante3, idimprimante4 , idprestation) VALUES ('",
                l._libelle,
                "', '",
                l._type,
                "','",
                l._categorie._libelle,
                "', ",
                Converting.decimalToString(Math.Round(l._prix, ControleParam._NDecimal)),
                ", ",
                Converting.decimalToString(l._prixAchat),
                ",",
                Converting.decimalToString(l._ratioMultiplicateur),
                " ,",
                l._tva._id,
                ",",
                l._familleCarte._id,
                ", '",
                l._codeBarre,
                "',",
                l._imprimante._id,
                ", ",
                l._composer,
                ", ",
                l._imprimerComposant,
                ",",
                l._nbrPortion,
                ",",
                l._accompagnement,
                ",",
                l._categorie._id,
                ",",
                l._ordre,
                ",",
                l._etat,
                ",",
                l._familleMessage._id,
                ",'",
                l._couleur,
                "', ",
                l._prixManuel,
                ", '",
                l._description,
                "', ",
                Converting.decimalToString(Math.Round(l._prix1, PDVParam._NDecimal)),
                ", ",
                Converting.decimalToString(Math.Round(l._prix2, PDVParam._NDecimal)),
                ", ",
                Converting.decimalToString(Math.Round(l._prix3, PDVParam._NDecimal)),
                ", ",
                Converting.decimalToString(Math.Round(l._prix4, PDVParam._NDecimal)),
                ", ",
                Converting.decimalToString(Math.Round(l._prix5, PDVParam._NDecimal)),
                ", ",
                l._prixparqte,
                ", ",
                l._imprimante2._id,
                ", ",
                l._imprimante3._id,
                ", ",
                l._imprimante4._id,
                ", ",
                l._idPrestation,
                ");select currval('",
                '"',
                "produit_id_seq",
                '"',
                "');"
            }));
            ProduitDAL.updateIMG(l);
            return result;
        }

        // Token: 0x060004D1 RID: 1233 RVA: 0x00034AEC File Offset: 0x00032CEC
        public static int updateProduit(Produit l)
        {
            ProduitDAL.updateIMG(l);
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE produit set libelle='",
                l._libelle,
                "', type='",
                l._type,
                "', categorie='",
                l._categorie._libelle,
                "', prix=",
                Converting.decimalToString(Math.Round(l._prix, ControleParam._NDecimal)),
                ", prix1=",
                Converting.decimalToString(Math.Round(l._prix1, ControleParam._NDecimal)),
                ", prix2=",
                Converting.decimalToString(Math.Round(l._prix2, ControleParam._NDecimal)),
                ", prix3=",
                Converting.decimalToString(Math.Round(l._prix3, ControleParam._NDecimal)),
                ", prix4=",
                Converting.decimalToString(Math.Round(l._prix4, ControleParam._NDecimal)),
                ", prix5=",
                Converting.decimalToString(Math.Round(l._prix5, ControleParam._NDecimal)),
                ", prixachat=",
                Converting.decimalToString(l._prixAchat),
                ", ratiomultiplicateur=",
                Converting.decimalToString(l._ratioMultiplicateur),
                ", idtva=",
                l._tva._id,
                ", idfamille=",
                l._familleCarte._id,
                ", codebarre='",
                l._codeBarre,
                "', idimprimante=",
                l._imprimante._id,
                ", composer=",
                l._composer,
                ", imprimercomposant=",
                l._imprimerComposant,
                ", nbrportion=",
                l._nbrPortion,
                ", accompagnement=",
                l._accompagnement,
                ", ordre=",
                l._ordre,
                ", etat=",
                l._etat,
                ", idcategorie=",
                l._categorie._id,
                ", famillecomposante=",
                l._familleMessage._id,
                " , couleur='",
                l._couleur,
                "' , prixmanuel=",
                l._prixManuel,
                ", description='",
                l._description,
                "', prixparqte=",
                l._prixparqte,
                ", idimprimante2=",
                l._imprimante2._id,
                ", idimprimante3 = ",
                l._imprimante3._id,
                " , idimprimante4 = ",
                l._imprimante4._id,
                ", idprestation=",
                l._idPrestation,
                " where id=",
                l._id
            }));
        }

        // Token: 0x060004D2 RID: 1234 RVA: 0x00034E74 File Offset: 0x00033074
        public Produit getProduit(Produit c)
        {
            return ProduitDAL._list.Find((Produit bk) => bk._id == c._id);
        }

        // Token: 0x060004D3 RID: 1235 RVA: 0x00034EC0 File Offset: 0x000330C0
        public static Produit getProduit(int c)
        {
            return ProduitDAL._list.Find((Produit bk) => bk._id == c);
        }

        // Token: 0x060004D4 RID: 1236 RVA: 0x00034EF4 File Offset: 0x000330F4
        public static string geRequestUpdateQteVente(LigneFacture l)
        {
            return string.Concat(new object[]
            {
                " update produit set qtevente=qtevente+",
                l._qte,
                " where id=",
                l._idArticle,
                " ; "
            });
        }

        // Token: 0x060004D5 RID: 1237 RVA: 0x00034F44 File Offset: 0x00033144
        public static string InitQteVente()
        {
            string text = " ";
            List<PointDeVente> pointDeVente = PointDeVenteDAL.getPointDeVente();
            foreach (PointDeVente pointDeVente2 in pointDeVente)
            {
                if (!pointDeVente2._garderQteVisuelle)
                {
                    object obj = text;
                    text = string.Concat(new object[]
                    {
                        obj,
                        " update produit set qtevisuelle=qtevisuelle-qtevente from famillecarte where famillecarte.idpointdevente=",
                        pointDeVente2._id,
                        " AND produit.idfamille=famillecarte.id and produit.qtevisuelle<>0 ; "
                    });
                }
            }
            text += " update produit set qtevente=0; ";
            Console.WriteLine(text);
            return text;
        }

        // Token: 0x060004D6 RID: 1238 RVA: 0x00034FEC File Offset: 0x000331EC
        public static void updateQteVisuelle(int p, decimal qte)
        {
            Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE produit set qtevisuelle=",
                Converting.decimalToString(Math.Round(qte, ControleParam._NDecimal)),
                ", qtevente=0 where id=",
                p,
                ";"
            }));
        }

        // Token: 0x060004D7 RID: 1239 RVA: 0x00035040 File Offset: 0x00033240
        public static void UpdateImprimante(FamilleCarte _famille, Imprimante _imp1, Imprimante _imp2, Imprimante _imp3, Imprimante _imp4)
        {
            Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE produit set idimprimante=",
                _imp1._id,
                ", idimprimante2=",
                _imp2._id,
                ", idimprimante3=",
                _imp3._id,
                ", idimprimante4=",
                _imp4._id,
                " where idfamille=",
                _famille._id,
                ";"
            }));
        }

        // Token: 0x060004D8 RID: 1240 RVA: 0x000350DC File Offset: 0x000332DC
        public static void UpdatePrestationPMS(FamilleCarte _famille, int idPrestation)
        {
            Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE produit set idprestation=",
                idPrestation,
                " where idfamille=",
                _famille._id,
                ";"
            }));
        }

        // Token: 0x060004D9 RID: 1241 RVA: 0x0003512C File Offset: 0x0003332C
        public static int updateIMG(Produit a)
        {
            string sql = "update produit set img=@img where id=" + a._id;
            return Connexion.executeNonQueryWithParametres(sql, new NpgsqlParameter("@img", NpgsqlDbType.Text)
            {
                Value = a._img
            });
        }

        // Token: 0x04000445 RID: 1093
        private DataTable dt;

        // Token: 0x04000446 RID: 1094
        private static List<Produit> _list;

        // Token: 0x04000447 RID: 1095
        private static List<ProduitUpdate> _listUpdate;
    }
}
