using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static TaxArchiver.Models.FamilleCarte;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200039B RID: 923
    internal class MessageRapideDAL
    {
        // Token: 0x06003FB3 RID: 16307 RVA: 0x001F1C9C File Offset: 0x001EFE9C
        public MessageRapideDAL()
        {
            this.dt = new DataTable();
            MessageRapideDAL._list = new List<MessageRapide>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                MessageRapide item = new MessageRapide(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), new PointDeVente(Convert.ToInt32(dataRow[2])), Convert.ToBoolean(dataRow[3]), dataRow[4].ToString().Trim(), new FamilleMessage(Convert.ToInt32(dataRow[5]), "", new List<MessageRapide>(), true));
                MessageRapideDAL._list.Add(item);
            }
        }

        // Token: 0x06003FB4 RID: 16308 RVA: 0x001F1D98 File Offset: 0x001EFF98
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from messagerapide order by id");
        }

        // Token: 0x06003FB5 RID: 16309 RVA: 0x001F1DA4 File Offset: 0x001EFFA4
        public static List<MessageRapide> getMessageRapide()
        {
            return MessageRapideDAL._list;
        }

        // Token: 0x06003FB6 RID: 16310 RVA: 0x001F1DAC File Offset: 0x001EFFAC
        public static int addMessageRapide(MessageRapide l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "INSERT INTO messagerapide( message, idpointdevente , etat, couleur, idfamillemessage)    VALUES ('",
                l._message,
                "',",
                l._pointDeVente._id,
                ",",
                l._etat,
                ", '",
                l._couleur,
                "', ",
                l._familleMessage._id,
                ");select currval('",
                '"',
                "messagerapide_id_seq",
                '"',
                "');"
            }));
        }

        // Token: 0x06003FB7 RID: 16311 RVA: 0x001F1E6C File Offset: 0x001F006C
        public static int updateMessageRapide(MessageRapide l)
        {
            return Connexion.executeScalar(string.Concat(new object[]
            {
                "UPDATE messagerapide  SET  message='",
                l._message,
                "', idpointdevente= ",
                l._pointDeVente._id,
                ", etat=",
                l._etat,
                ", couleur='",
                l._couleur,
                "', idfamillemessage=",
                l._familleMessage._id,
                " WHERE id=",
                l._id,
                ";"
            }));
        }

        // Token: 0x06003FB8 RID: 16312 RVA: 0x001F1F3C File Offset: 0x001F013C
        public static MessageRapide getMessageRapide(MessageRapide c)
        {
            return MessageRapideDAL._list.Find((MessageRapide bk) => bk._id == c._id);
        }

        // Token: 0x06003FB9 RID: 16313 RVA: 0x001F1F90 File Offset: 0x001F0190
        public static List<MessageRapide> getMessageRapideByPointDeVente(PointDeVente p)
        {
            List<MessageRapide> list = new List<MessageRapide>();
            return MessageRapideDAL._list.FindAll((MessageRapide bk) => bk._pointDeVente._id == p._id);
        }

        // Token: 0x06003FBA RID: 16314 RVA: 0x001F1FE8 File Offset: 0x001F01E8
        public static List<MessageRapide> getMessageRapideByFamilleMessage(int f)
        {
            List<MessageRapide> list = new List<MessageRapide>();
            return MessageRapideDAL._list.FindAll((MessageRapide bk) => bk._familleMessage._id == f);
        }

        // Token: 0x06003FBB RID: 16315 RVA: 0x001F2038 File Offset: 0x001F0238
        public MessageRapide getMessageRapide(int c)
        {
            return MessageRapideDAL._list.Find((MessageRapide bk) => bk._id == c);
        }

        // Token: 0x040028C4 RID: 10436
        private DataTable dt;

        // Token: 0x040028C5 RID: 10437
        private static List<MessageRapide> _list;
    }
}
