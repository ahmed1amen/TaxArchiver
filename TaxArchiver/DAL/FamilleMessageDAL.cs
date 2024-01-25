using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static TaxArchiver.Models.FamilleCarte;
using TaxArchiver.DAL.DAO;

namespace TaxArchiver.DAL
{
    // Token: 0x02000375 RID: 885
    internal class FamilleMessageDAL
    {
        // Token: 0x06003CBF RID: 15551 RVA: 0x001CAB3C File Offset: 0x001C8D3C
        public FamilleMessageDAL()
        {
            this.dt = new DataTable();
            FamilleMessageDAL._list = new List<FamilleMessage>();
            new MessageRapideDAL();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                FamilleMessage item = new FamilleMessage(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), MessageRapideDAL.getMessageRapideByFamilleMessage(Convert.ToInt32(dataRow[0])), Convert.ToBoolean(dataRow[2]));
                FamilleMessageDAL._list.Add(item);
            }
        }

        // Token: 0x06003CC0 RID: 15552 RVA: 0x001CAC0C File Offset: 0x001C8E0C
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from famillemessage ");
        }

        // Token: 0x06003CC1 RID: 15553 RVA: 0x001CAC18 File Offset: 0x001C8E18
        public static List<FamilleMessage> getFamilleMessage()
        {
            return FamilleMessageDAL._list;
        }

        // Token: 0x06003CC2 RID: 15554 RVA: 0x001CAC20 File Offset: 0x001C8E20
        public static int addFamilleMessage(FamilleMessage l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO famillemessage( libelle,  etat) VALUES ( '",
                l._libelle,
                "',",
                l._etat,
                ");select currval('",
                '"',
                "famillemessage_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06003CC3 RID: 15555 RVA: 0x001CAC94 File Offset: 0x001C8E94
        public static int updateFamilleMessage(FamilleMessage l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE famillemessage SET  libelle='",
                l._libelle,
                "', etat=",
                l._etat,
                " where id=",
                l._id
            }));
        }

        // Token: 0x06003CC4 RID: 15556 RVA: 0x001CAD10 File Offset: 0x001C8F10
        public static FamilleMessage getFamilleMessage(FamilleMessage c)
        {
            return FamilleMessageDAL._list.Find((FamilleMessage bk) => bk._id == c._id);
        }

        // Token: 0x06003CC5 RID: 15557 RVA: 0x001CAD5C File Offset: 0x001C8F5C
        public FamilleMessage getFamilleMessage(int c)
        {
            return FamilleMessageDAL._list.Find((FamilleMessage bk) => bk._id == c);
        }

        // Token: 0x0400262C RID: 9772
        private DataTable dt;

        // Token: 0x0400262D RID: 9773
        private static List<FamilleMessage> _list;
    }
}
