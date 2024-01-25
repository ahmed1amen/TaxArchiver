using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000095 RID: 149
    public class PointDeVenteDAL
    {
        // Token: 0x060009FC RID: 2556 RVA: 0x000604D8 File Offset: 0x0005E6D8
        public PointDeVenteDAL(bool order, string orderBy, bool withSubItems)
        {
            this.dt = new DataTable();
            PointDeVenteDAL._list = new List<PointDeVente>();
            new ImprimanteDAL();
            Imprimante imprimanteLog = new Imprimante();
            Imprimante imprimanteA = new Imprimante();
            Imprimante imprimanteTransfert = new Imprimante();
            this.dt = this.getAll();
            if (withSubItems)
            {
                new ModePaiementDAL();
                new ServiceDAL();
                new FamilleCarteDAL();
                IEnumerator enumerator = this.dt.Rows.GetEnumerator();


                    while (enumerator.MoveNext())
                    {
                        object obj = enumerator.Current;
                        DataRow dataRow = (DataRow)obj;
                        if (Convert.ToInt32(dataRow[22]) == 0)
                        {
                            imprimanteLog = new Imprimante();
                        }
                        else
                        {
                            imprimanteLog = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[22]));
                        }
                        if (Convert.ToInt32(dataRow[24]) == 0)
                        {
                            imprimanteA = new Imprimante();
                        }
                        else
                        {
                            imprimanteA = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[24]));
                        }
                        if (Convert.ToInt32(dataRow[54]) == 0)
                        {
                            imprimanteTransfert = new Imprimante();
                        }
                        else
                        {
                            imprimanteTransfert = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[54]));
                        }
                        ModePaiementDAL.getListModePaiement(Convert.ToInt32(dataRow[0]));
                        ServiceDAL.getListService(Convert.ToInt32(dataRow[0]));
                        FamilleCarteDAL.getListFamilleCarte(Convert.ToInt32(dataRow[0]));
                        PointDeVente item = new PointDeVente(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), dataRow[3].ToString().Trim(), Convert.ToBoolean(dataRow[4]), Convert.ToBoolean(dataRow[5]), Convert.ToBoolean(dataRow[6]), Convert.ToInt32(dataRow[8]), Convert.ToBoolean(dataRow[9]), Convert.ToBoolean(dataRow[7]), Convert.ToBoolean(dataRow[10]), Convert.ToBoolean(dataRow[11]), Convert.ToBoolean(dataRow[12]), Convert.ToBoolean(dataRow[13]), Convert.ToBoolean(dataRow[17]), Convert.ToInt32(dataRow[16]), Convert.ToBoolean(dataRow[15]), Convert.ToBoolean(dataRow[14]), Convert.ToInt32(dataRow[18]), Convert.ToInt32(dataRow[19]), Convert.ToBoolean(dataRow[21]), imprimanteLog, Convert.ToBoolean(dataRow[23]), imprimanteA, Convert.ToBoolean(dataRow[25]), Convert.ToBoolean(dataRow[26]), Convert.ToBoolean(dataRow[27]), Convert.ToBoolean(dataRow[28]), Convert.ToBoolean(dataRow[29]), Convert.ToBoolean(dataRow[30]), Convert.ToBoolean(dataRow[31]), Convert.ToBoolean(dataRow[32]), Convert.ToBoolean(dataRow[33]), Convert.ToBoolean(dataRow[34]), Convert.ToBoolean(dataRow[36]), dataRow[37].ToString().Trim(), Convert.ToBoolean(dataRow[38]), Convert.ToBoolean(dataRow[39]), Convert.ToBoolean(dataRow[40]), Convert.ToBoolean(dataRow[41]), Convert.ToBoolean(dataRow[42]), Convert.ToBoolean(dataRow[43]), Convert.ToBoolean(dataRow[44]), Convert.ToBoolean(dataRow[45]), Convert.ToInt32(dataRow[46]), Convert.ToBoolean(dataRow[47]), Convert.ToBoolean(dataRow[48]), Convert.ToInt32(dataRow[49]), Convert.ToInt32(dataRow[50]), Convert.ToInt32(dataRow[51]), Convert.ToBoolean(dataRow[52]), Convert.ToBoolean(dataRow[53]), imprimanteTransfert, Convert.ToBoolean(dataRow[55]), Convert.ToDecimal(dataRow[56]));
                        PointDeVenteDAL._list.Add(item);
                    }
                   
               
            }
            if (!withSubItems)
            {
                foreach (object obj2 in this.dt.Rows)
                {
                    DataRow dataRow2 = (DataRow)obj2;
                    if (Convert.ToInt32(dataRow2[22]) == 0)
                    {
                        imprimanteLog = new Imprimante();
                    }
                    else
                    {
                        imprimanteLog = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow2[22]));
                    }
                    if (Convert.ToInt32(dataRow2[24]) == 0)
                    {
                        imprimanteA = new Imprimante();
                    }
                    else
                    {
                        imprimanteA = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow2[24]));
                    }
                    if (Convert.ToInt32(dataRow2[54]) == 0)
                    {
                        imprimanteTransfert = new Imprimante();
                    }
                    else
                    {
                        imprimanteTransfert = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow2[54]));
                    }
                    PointDeVente item = new PointDeVente(Convert.ToInt32(dataRow2[0]), dataRow2[1].ToString().Trim(), dataRow2[2].ToString().Trim(), dataRow2[3].ToString().Trim(), Convert.ToBoolean(dataRow2[4]), Convert.ToBoolean(dataRow2[5]), Convert.ToBoolean(dataRow2[6]), Convert.ToInt32(dataRow2[8]), Convert.ToBoolean(dataRow2[9]), Convert.ToBoolean(dataRow2[7]), Convert.ToBoolean(dataRow2[10]), Convert.ToBoolean(dataRow2[11]), Convert.ToBoolean(dataRow2[12]), Convert.ToBoolean(dataRow2[13]), Convert.ToBoolean(dataRow2[17]), Convert.ToInt32(dataRow2[16]), Convert.ToBoolean(dataRow2[15]), Convert.ToBoolean(dataRow2[14]), Convert.ToInt32(dataRow2[18]), Convert.ToInt32(dataRow2[19]), Convert.ToBoolean(dataRow2[21]), imprimanteLog, Convert.ToBoolean(dataRow2[23]), imprimanteA, Convert.ToBoolean(dataRow2[25]), Convert.ToBoolean(dataRow2[26]), Convert.ToBoolean(dataRow2[27]), Convert.ToBoolean(dataRow2[28]), Convert.ToBoolean(dataRow2[29]), Convert.ToBoolean(dataRow2[30]), Convert.ToBoolean(dataRow2[31]), Convert.ToBoolean(dataRow2[32]), Convert.ToBoolean(dataRow2[33]), Convert.ToBoolean(dataRow2[34]), Convert.ToBoolean(dataRow2[36]), dataRow2[37].ToString().Trim(), Convert.ToBoolean(dataRow2[38]), Convert.ToBoolean(dataRow2[39]), Convert.ToBoolean(dataRow2[40]), Convert.ToBoolean(dataRow2[41]), Convert.ToBoolean(dataRow2[42]), Convert.ToBoolean(dataRow2[43]), Convert.ToBoolean(dataRow2[44]), Convert.ToBoolean(dataRow2[45]), Convert.ToInt32(dataRow2[46]), Convert.ToBoolean(dataRow2[47]), Convert.ToBoolean(dataRow2[48]), Convert.ToInt32(dataRow2[49]), Convert.ToInt32(dataRow2[50]), Convert.ToInt32(dataRow2[51]), Convert.ToBoolean(dataRow2[52]), Convert.ToBoolean(dataRow2[53]), imprimanteTransfert, Convert.ToBoolean(dataRow2[55]), Convert.ToDecimal(dataRow2[56]));
                    PointDeVenteDAL._list.Add(item);
                }
            }
        }

        // Token: 0x060009FD RID: 2557 RVA: 0x00060D38 File Offset: 0x0005EF38
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from pointdevente order by id");
        }

        // Token: 0x060009FE RID: 2558 RVA: 0x00060D5C File Offset: 0x0005EF5C
        public static PointDeVente getPointVente(int c)
        {
            return PointDeVenteDAL._list.Find((PointDeVente bk) => bk._id == c);
        }

        // Token: 0x060009FF RID: 2559 RVA: 0x00060D8E File Offset: 0x0005EF8E
        public static List<PointDeVente> getPointDeVente()
        {
            return PointDeVenteDAL._list;
        }

        // Token: 0x06000A00 RID: 2560 RVA: 0x00060D98 File Offset: 0x0005EF98
        public static int addPointDeVente(PointDeVente l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO pointdevente(libelle, type, typefacture, couvertsobligatoire, imprimeruniquementfacturesolde, imprimerprestation,numerofacture,tableobligatoire, etat,serveurobligatoire,aveccodebarre,venterapide,aveccalculateur, plansalle, nombrecommande, avecqtevisuelle, garderqtevisuelle, codearticle, codepoids,imprimerlog,idimprimantelog, imprimera4 ,idimprimantea4, attribuerencaissement, imprimerfacture,imprimerbonannulation,imprimerfactureavecanulation,imprimerbontransfert,imprimerbontransfertavecarticle, venteparzone, imprimerbonremise, imprimerbonperte, calculateurbillet, imprimerprestationcloture,typecommande,doubleecran,imprimercloture, imprimerdetailreclamation, grouperlignecommande, bloquerreclamaton, rappelmenu, interfacereservationcaisse, historiquestock,nbrimpressionfacture,  imprimerstockvisuelle, stockparfournisseur,intervalheures,intervalminutes,intervaleminutesretard,supprimerpaiement,imprimertransfert,idimprimantetransfert, minspend, valminspend)    VALUES ('",
                l._libelle,
                "','",
                l._type,
                "','",
                l._typeFacture,
                "', ",
                l._couvertsObligatoire,
                ",",
                l._imprimerUniquementFactureSolde,
                ",",
                l._imprimerPrestation,
                ",",
                l._numeroFacture,
                ",",
                l._tableObligatoire,
                ",",
                l._etat,
                ", ",
                l._serveurObligatoir,
                ", ",
                l._avecCodeBarre,
                ", ",
                l._venteRapide,
                ", ",
                l._avecCalculateur,
                ", ",
                l._avecPlanSalle,
                ", ",
                l._nombreCommande,
                ", ",
                l._avecQteVisuelle,
                " , ",
                l._garderQteVisuelle,
                ", ",
                l._codeArticle,
                ", ",
                l._codePoids,
                ", ",
                l._imprimerLog,
                ", ",
                l._imprimanteLog._id,
                ", ",
                l._imprimerA4,
                ", ",
                l._imprimanteA4._id,
                " , ",
                l._attribueEncaissement,
                ", ",
                l._imprimerFacture,
                " ,  ",
                l._imprimerBonAnnulation,
                " , ",
                l._imprimerFactureAvecAnulation,
                ", ",
                l._imprimerBonTransfert,
                ", ",
                l._imprimerBonTransfertAvecArticle,
                ", ",
                l._venteParZone,
                ", ",
                l._imprimerBonRemise,
                ", ",
                l._imprimerBonPerte,
                ", ",
                l._calculateurBillet,
                ", ",
                l._imprimerPrestationCloture,
                ", '",
                l._typeCommande,
                "', ",
                l._doubleEcran,
                " , ",
                l._imprimerCloture,
                " , ",
                l._imprimerDetailReclamation,
                ", ",
                l._grouperLigneCommande,
                " , ",
                l._bloquerReclamation,
                " , ",
                l._rappelMenu,
                ", ",
                l._interfaceReservationCaisse,
                ",",
                l._historiqueStock,
                ", ",
                l._nbrImpressionFacture,
                ", ",
                l._imprimerStockVisuelle,
                ", ",
                l._stockParFournisseur,
                ", ",
                l._intervalheure,
                ", ",
                l._intervalminutes,
                ", ",
                l._intervalminutesRetard,
                ", ",
                l._supprimerPaiement,
                ", ",
                l._imprimerTransfert,
                ", ",
                l._imprimanteTransfert._id,
                " , ",
                l._minSpend,
                ", ",
                l._valMinSpend,
                " );select currval('",
                '"',
                "pointdevente_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06000A01 RID: 2561 RVA: 0x000612EC File Offset: 0x0005F4EC
        public static int updatePointDeVente(PointDeVente l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE pointdevente SET libelle='",
                l._libelle,
                "', type='",
                l._type,
                "', typefacture='",
                l._typeFacture,
                "', couvertsobligatoire=",
                l._couvertsObligatoire,
                ",  imprimeruniquementfacturesolde=",
                l._imprimerUniquementFactureSolde,
                ", imprimerprestation=",
                l._imprimerPrestation,
                ",tableobligatoire=",
                l._tableObligatoire,
                ", etat=",
                l._etat,
                ", serveurobligatoire=",
                l._serveurObligatoir,
                ", aveccodebarre=",
                l._avecCodeBarre,
                ", venterapide=",
                l._venteRapide,
                ", aveccalculateur=",
                l._avecCalculateur,
                ", plansalle=",
                l._avecPlanSalle,
                ", nombrecommande=",
                l._nombreCommande,
                ", avecqtevisuelle=",
                l._avecQteVisuelle,
                ",  garderqtevisuelle=",
                l._garderQteVisuelle,
                ", codearticle=",
                l._codeArticle,
                ", codepoids=",
                l._codePoids,
                ", idimprimantelog=",
                l._imprimanteLog._id,
                ",imprimerlog=",
                l._imprimerLog,
                ", imprimera4=",
                l._imprimerA4,
                " ,idimprimantea4=",
                l._imprimanteA4._id,
                " , attribuerencaissement= ",
                l._attribueEncaissement,
                ", imprimerfacture = ",
                l._imprimerFacture,
                " , imprimerbonannulation = ",
                l._imprimerBonAnnulation,
                ",imprimerfactureavecanulation = ",
                l._imprimerFactureAvecAnulation,
                ",imprimerbontransfert = ",
                l._imprimerBonTransfert,
                " ,imprimerbontransfertavecarticle = ",
                l._imprimerBonTransfertAvecArticle,
                " , venteparzone=",
                l._venteParZone,
                " ,imprimerbonremise=",
                l._imprimerBonRemise,
                ", imprimerbonperte=",
                l._imprimerBonPerte,
                " , calculateurbillet= ",
                l._calculateurBillet,
                " , imprimerprestationcloture=",
                l._imprimerPrestationCloture,
                ", typecommande='",
                l._typeCommande,
                "', doubleecran=",
                l._doubleEcran,
                " , imprimercloture= ",
                l._imprimerCloture,
                " , imprimerdetailreclamation = ",
                l._imprimerDetailReclamation,
                " , grouperlignecommande=",
                l._grouperLigneCommande,
                ", bloquerreclamaton= ",
                l._bloquerReclamation,
                " , rappelmenu=",
                l._rappelMenu,
                " , interfacereservationcaisse=",
                l._interfaceReservationCaisse,
                ", historiquestock=",
                l._historiqueStock,
                " , nbrimpressionfacture= ",
                l._nbrImpressionFacture,
                ", imprimerstockvisuelle=",
                l._imprimerStockVisuelle,
                ", stockparfournisseur=",
                l._stockParFournisseur,
                ", intervalminutes= ",
                l._intervalminutes,
                ", intervalheures=",
                l._intervalheure,
                ", intervaleminutesretard =",
                l._intervalminutesRetard,
                "  ,supprimerpaiement =",
                l._supprimerPaiement,
                ",imprimertransfert=",
                l._imprimerTransfert,
                ",idimprimantetransfert=",
                l._imprimanteTransfert._id,
                "  , minspend=",
                l._minSpend,
                ", valminspend=",
                l._valMinSpend,
                " WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06000A02 RID: 2562 RVA: 0x00061818 File Offset: 0x0005FA18
        public static int getNumeroFacture(PointDeVente l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "update pointdevente set numerofacture=numerofacture+1 where id=",
                l._id,
                "; select numerofacture from pointdevente where id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06000A03 RID: 2563 RVA: 0x0006186C File Offset: 0x0005FA6C
        public static int getNumeroFactureBLK(PointDeVente l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "update pointdevente set idfacture=idfacture+1 where id=",
                l._id,
                "; select idfacture from pointdevente where id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x040007CD RID: 1997
        private DataTable dt;

        // Token: 0x040007CE RID: 1998
        private static List<PointDeVente> _list;
    }
}
