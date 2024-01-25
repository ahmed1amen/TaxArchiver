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
    // Token: 0x02000097 RID: 151
    internal class FicheTechniqueDAL
    {
        // Token: 0x06000A0C RID: 2572 RVA: 0x00061D98 File Offset: 0x0005FF98
        public FicheTechniqueDAL()
        {
            this.dt = new DataTable();
            FicheTechniqueDAL._list = new List<FicheTechnique>();
            this.dt = this.getAll();
            foreach (object obj in this.dt.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                Article article = new Article(Convert.ToInt32(dataRow[3]), dataRow[4].ToString().Trim(), dataRow[5].ToString().Trim());
                Produit produit = new Produit(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[2].ToString().Trim());
                Local local = new Local(Convert.ToInt32(dataRow[7]), dataRow[8].ToString().Trim(), dataRow[9].ToString().Trim(), true);
                FicheTechnique item = new FicheTechnique(produit, article, local, Convert.ToDecimal(dataRow[10].ToString().Trim()), dataRow[6].ToString().Trim());
                FicheTechniqueDAL._list.Add(item);
            }
        }

        // Token: 0x06000A0D RID: 2573 RVA: 0x00061F28 File Offset: 0x00060128
        private DataTable getAll()
        {
            return Connexion.executeQuery("select produit.id as idproduit,produit.codebarre as codeproduit,produit.libelle as libelleproduit,article.id as idarticle, article.code as codearticle, article.libelle as libellearticle, article.codeunite as codeunite, local.id as idlocal,local.code as codelocal, local.libelle as libellelocal, fichetechnique.qte from produit,article,local, fichetechnique where fichetechnique.idarticle=article.id and fichetechnique.idproduit=produit.id and fichetechnique.idlocal=local.id");
        }

        // Token: 0x06000A0E RID: 2574 RVA: 0x00061F34 File Offset: 0x00060134
        private DataTable getAllByProduit(int id)
        {
            return Connexion.executeQuery("select produit.id as idproduit,produit.codebarre as codeproduit,produit.libelle as libelleproduit,article.id as idarticle, article.code as codearticle, article.libelle as libellearticle, article.codeunite as codeunite, local.id as idlocal,local.code as codelocal, local.libelle as libellelocal, fichetechnique.qte from produit,article,local, fichetechnique where fichetechnique.idarticle=article.id and fichetechnique.idproduit=produit.id and fichetechnique.idlocal=local.id and produit.id=" + id);
        }

        // Token: 0x06000A0F RID: 2575 RVA: 0x00061F4C File Offset: 0x0006014C
        public static int ficheTechniqueAdd(List<FicheTechnique> d)
        {
            string text = "";
            foreach (FicheTechnique ficheTechnique in d)
            {
                if (ficheTechnique._deleted)
                {
                    text += FicheTechniqueDAL.getRequestDelete(ficheTechnique);
                }
                else
                {
                    text += FicheTechniqueDAL.getRequestAdd(ficheTechnique);
                }
            }
            Console.WriteLine(text);
            return Connexion.executeScalar(text);
        }

        // Token: 0x06000A10 RID: 2576 RVA: 0x00061FCC File Offset: 0x000601CC
        public static int ficheTechniqueAdd(FicheTechnique d)
        {
            string text = "";
            if (d._deleted)
            {
                text += FicheTechniqueDAL.getRequestDelete(d);
            }
            else
            {
                text += FicheTechniqueDAL.getRequestAdd(d);
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06000A11 RID: 2577 RVA: 0x0006200C File Offset: 0x0006020C
        private static string getRequestAdd(FicheTechnique f)
        {
            int num = Connexion.executeScalar(string.Concat(new object[]
            {
                "select count(*) from fichetechnique where idarticle=",
                f._article._id,
                " and idlocal=",
                f._local._id,
                " and idproduit=",
                f._produit._id
            }));
            string result = " ";
            if (num == 0)
            {
                result = string.Concat(new object[]
                {
                    " INSERT INTO fichetechnique(idproduit, idarticle, idlocal, qte) VALUES (",
                    f._produit._id,
                    ", ",
                    f._article._id,
                    ", ",
                    f._local._id,
                    ",  ",
                    Converting.decimalToString(f._qte),
                    "); "
                });
            }
            else if (num == 1)
            {
                result = string.Concat(new object[]
                {
                    " UPDATE fichetechnique SET  qte=",
                    Converting.decimalToString(f._qte),
                    " WHERE idproduit=",
                    f._produit._id,
                    " and idarticle=",
                    f._article._id,
                    " and idlocal=",
                    f._local._id,
                    "; "
                });
            }
            return result;
        }

        // Token: 0x06000A12 RID: 2578 RVA: 0x000621A0 File Offset: 0x000603A0
        private static string getRequestDelete(FicheTechnique f)
        {
            return string.Concat(new object[]
            {
                " DELETE FROM fichetechnique WHERE idproduit=",
                f._produit._id,
                " and idarticle=",
                f._article._id,
                " and idlocal=",
                f._local._id,
                "; "
            });
        }

        // Token: 0x06000A13 RID: 2579 RVA: 0x00062213 File Offset: 0x00060413
        public static decimal getValeurFicheTechnique(Produit d)
        {
            return Connexion.executeScalarDecimal("select COALESCE(sum(prix), 0)  from (select  detaillocal.pmplocal*fichetechnique.qte as prix from detaillocal , fichetechnique where detaillocal.idarticle=fichetechnique.idarticle and detaillocal.idlocal= fichetechnique.idlocal and idproduit=" + d._id + " ) as t ");
        }

        // Token: 0x06000A14 RID: 2580 RVA: 0x00062234 File Offset: 0x00060434
        public static decimal getValeurFicheTechnique(int d)
        {
            return Connexion.executeScalarDecimal("select COALESCE(sum(prix), 0)  from (select  detaillocal.pmplocal*fichetechnique.qte as prix from detaillocal , fichetechnique where detaillocal.idarticle=fichetechnique.idarticle and detaillocal.idlocal= fichetechnique.idlocal and idproduit=" + d + " ) as t ");
        }

        // Token: 0x06000A15 RID: 2581 RVA: 0x00062270 File Offset: 0x00060470
        public List<FicheTechnique> getFicheTechniqueByProduit(int c)
        {
            List<FicheTechnique> list = new List<FicheTechnique>();
            return FicheTechniqueDAL._list.FindAll((FicheTechnique bk) => bk._produit._id == c);
        }

        // Token: 0x040007D1 RID: 2001
        private DataTable dt;

        // Token: 0x040007D2 RID: 2002
        private static List<FicheTechnique> _list;

        // Token: 0x040007D3 RID: 2003
        private Converting cng = new Converting(StockParam._formatDecimal);
    }
}
