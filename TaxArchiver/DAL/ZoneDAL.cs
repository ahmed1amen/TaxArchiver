using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x02000373 RID: 883
    internal class ZoneDAL
    {
        // Token: 0x06003CB1 RID: 15537 RVA: 0x001CA45C File Offset: 0x001C865C
        public ZoneDAL()
        {
            this.dt = new DataTable();
            ZoneDAL._list = new List<Zone>();
            new PointDeVenteDAL(true, "", false);
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                PointDeVente pointVente = PointDeVenteDAL.getPointVente(Convert.ToInt32(dataRow[4]));
                Zone item = new Zone(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim(), Convert.ToInt32(dataRow[3]), pointVente, Convert.ToBoolean(dataRow[5]), dataRow[6].ToString().Trim(), Convert.ToBoolean(dataRow[7]), Convert.ToBoolean(dataRow[8]));
                ZoneDAL._list.Add(item);
            }
        }

        // Token: 0x06003CB2 RID: 15538 RVA: 0x001CA584 File Offset: 0x001C8784
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from zone order by id");
        }

        // Token: 0x06003CB3 RID: 15539 RVA: 0x001CA590 File Offset: 0x001C8790
        public static List<Zone> getZone()
        {
            return ZoneDAL._list;
        }

        // Token: 0x06003CB4 RID: 15540 RVA: 0x001CA598 File Offset: 0x001C8798
        public static int addZone(Zone l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO zone( libelle, prix,pourcentage, idpointdevente, etat, couleur, avectable, aveccardex)    VALUES ( '",
                l._libelle,
                "', '",
                l._prix,
                "', ",
                l._pourcentage,
                ", ",
                l._pointDeVente._id,
                " ,",
                l._etat,
                ", '",
                l._couleur,
                "', ",
                l._avecTable,
                " , ",
                l._avecCardex,
                " );select currval('",
                '"',
                "zone_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06003CB5 RID: 15541 RVA: 0x001CA698 File Offset: 0x001C8898
        public static int updateZone(Zone l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE zone  SET  libelle ='",
                l._libelle,
                "', prix='",
                l._prix,
                "', pourcentage=",
                l._pourcentage,
                ", idpointdevente=",
                l._pointDeVente._id,
                ", etat=",
                l._etat,
                " , couleur= '",
                l._couleur,
                "',avectable= ",
                l._avecTable,
                ", aveccardex=",
                l._avecCardex,
                "  WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06003CB6 RID: 15542 RVA: 0x001CA7A4 File Offset: 0x001C89A4
        public static Zone getZone(Zone c)
        {
            return ZoneDAL._list.Find((Zone bk) => bk._id == c._id);
        }

        // Token: 0x06003CB7 RID: 15543 RVA: 0x001CA7F0 File Offset: 0x001C89F0
        public Zone getZone(int c)
        {
            return ZoneDAL._list.Find((Zone bk) => bk._id == c);
        }

        // Token: 0x04002628 RID: 9768
        private DataTable dt;

        // Token: 0x04002629 RID: 9769
        private static List<Zone> _list;
    }
}
