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
    // Token: 0x02000096 RID: 150
    public class ModePaiementDAL
    {
        // Token: 0x06000A04 RID: 2564 RVA: 0x000618C0 File Offset: 0x0005FAC0
        public ModePaiementDAL()
        {
            this.dt = new DataTable();
            ModePaiementDAL._list = new List<ModePaiement>();
            ZoneDAL zoneDAL = new ZoneDAL();
            new PointDeVenteDAL(true, "", false);
            new ImprimanteDAL();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Zone zone;
                if (Convert.ToInt32(dataRow[10]) == 0)
                {
                    zone = new Zone();
                }
                else
                {
                    zone = zoneDAL.getZone(Convert.ToInt32(dataRow[10]));
                }
                Imprimante imprimante;
                if (Convert.ToInt32(dataRow[8]) == 0)
                {
                    imprimante = new Imprimante();
                }
                else
                {
                    imprimante = ImprimanteDAL.getImprimante(Convert.ToInt32(dataRow[8]));
                }
                PointDeVente pointVente = PointDeVenteDAL.getPointVente(Convert.ToInt32(dataRow[3]));
                ModePaiement item = new ModePaiement(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), Convert.ToInt32(dataRow[2]), pointVente, dataRow[5].ToString().Trim(), dataRow[6].ToString().Trim(), Convert.ToBoolean(dataRow[7]), imprimante, Convert.ToDecimal(dataRow[9]), zone);
                ModePaiementDAL._list.Add(item);
            }
        }

        // Token: 0x06000A05 RID: 2565 RVA: 0x00061A60 File Offset: 0x0005FC60
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from modepaiement order by id");
        }

        // Token: 0x06000A06 RID: 2566 RVA: 0x00061A6C File Offset: 0x0005FC6C
        public static List<ModePaiement> getModePaiement()
        {
            return ModePaiementDAL._list;
        }

        // Token: 0x06000A07 RID: 2567 RVA: 0x00061A74 File Offset: 0x0005FC74
        public static int addModePaiement(ModePaiement l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO modepaiement( libelle, ordre, idpointdevente, libellepointdevente, type, couleur, etat, idimprimante, commission,idzone) VALUES ('",
                l._libelle,
                "', ",
                l._ordre,
                ", ",
                l._pointDeVente._id,
                ", '",
                l._pointDeVente._libelle,
                "', '",
                l._type,
                "', '",
                l._couleur,
                "', ",
                l._etat,
                ", ",
                l._imprimante._id,
                ", ",
                Converting.decimalToString(Math.Round(l._commission, ControleParam._NDecimal)),
                ", ",
                l._zone._id,
                ");select currval('",
                '"',
                "modepaiement_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06000A08 RID: 2568 RVA: 0x00061BB8 File Offset: 0x0005FDB8
        public static int updateModePaiement(ModePaiement l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE modepaiement  SET libelle='",
                l._libelle,
                "', ordre=",
                l._ordre,
                ", idpointdevente=",
                l._pointDeVente._id,
                ", libellepointdevente='",
                l._pointDeVente._libelle,
                "', type='",
                l._type,
                "', couleur='",
                l._couleur,
                "', etat=",
                l._etat,
                " , idimprimante = ",
                l._imprimante._id,
                " , commission = ",
                Converting.decimalToString(Math.Round(l._commission, ControleParam._NDecimal)),
                ", idzone=",
                l._zone._id,
                " WHERE  id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06000A09 RID: 2569 RVA: 0x00061CEA File Offset: 0x0005FEEA
        public static List<ModePaiement> getListModePaiement(PointDeVente d)
        {
            return ModePaiementDAL.getListModePaiement(d._id);
        }

        // Token: 0x06000A0A RID: 2570 RVA: 0x00061D14 File Offset: 0x0005FF14
        public static List<ModePaiement> getListModePaiement(int id)
        {
            List<ModePaiement> list = new List<ModePaiement>();
            return ModePaiementDAL._list.FindAll((ModePaiement bk) => bk._pointDeVente._id == id);
        }

        // Token: 0x06000A0B RID: 2571 RVA: 0x00061D64 File Offset: 0x0005FF64
        public static ModePaiement getModePaiement(int id)
        {
            return ModePaiementDAL._list.FirstOrDefault((ModePaiement bk) => bk._id == id);
        }

        // Token: 0x040007CF RID: 1999
        private DataTable dt;

        // Token: 0x040007D0 RID: 2000
        private static List<ModePaiement> _list;
    }
}
