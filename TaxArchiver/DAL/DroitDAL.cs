using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaxArchiver.DAL.DAO;
using TaxArchiver.Models;

namespace TaxArchiver.DAL
{
    // Token: 0x0200045C RID: 1116
    internal class DroitDAL
    {
        // Token: 0x06004B04 RID: 19204 RVA: 0x0022DC1A File Offset: 0x0022BE1A
        private DataTable getAll()
        {
            return Connexion.executeQuery("select * from droit order by id");
        }

        // Token: 0x06004B05 RID: 19205 RVA: 0x0022DC26 File Offset: 0x0022BE26
        private DataTable getAll(int idUtilisateur)
        {
            return Connexion.executeQuery("select listdroit.id, listdroit.libelle, droit.autoriser, listdroit.description, listdroit.niveau from droit, listdroit where droit.idutilisateur=" + idUtilisateur + " and droit.iddroit=listdroit.id order by listdroit.id");
        }

        // Token: 0x06004B06 RID: 19206 RVA: 0x0022DC44 File Offset: 0x0022BE44
        public List<Droit> getDroits()
        {
            DataTable dataTable = new DataTable();
            dataTable = this.getAll();
            List<Droit> list = new List<Droit>();
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                ListDroit listDroit = new ListDroit(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[3].ToString().Trim(), Convert.ToInt32(dataRow[4]));
                Droit item = new Droit(Convert.ToInt32(dataRow[0]), listDroit, Convert.ToBoolean(dataRow[2]));
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004B07 RID: 19207 RVA: 0x0022DD24 File Offset: 0x0022BF24
        public List<Droit> getDroits(Utilisateur user)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.getAll(user._id);
            List<Droit> list = new List<Droit>();
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                ListDroit listDroit = new ListDroit(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[3].ToString().Trim(), Convert.ToInt32(dataRow[4]));
                Droit item = new Droit(Convert.ToInt32(dataRow[0]), listDroit, Convert.ToBoolean(dataRow[2]));
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004B08 RID: 19208 RVA: 0x0022DE08 File Offset: 0x0022C008
        public List<Droit> getDroits(int idUser)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.getAll(idUser);
            List<Droit> list = new List<Droit>();
            foreach (object obj in dataTable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                ListDroit listDroit = new ListDroit(Convert.ToInt32(dataRow[0]), dataRow[1].ToString().Trim(), dataRow[3].ToString().Trim(), Convert.ToInt32(dataRow[4]));
                Droit item = new Droit(Convert.ToInt32(dataRow[0]), listDroit, Convert.ToBoolean(dataRow[2]));
                list.Add(item);
            }
            return list;
        }

        // Token: 0x06004B09 RID: 19209 RVA: 0x0022DEE8 File Offset: 0x0022C0E8
        public int addDroits(Utilisateur utilisateur)
        {
            string text = "";
            foreach (Droit droit in utilisateur._droits)
            {
                object obj = text;
                text = string.Concat(new object[]
                {
                    obj,
                    "INSERT INTO droit(idutilisateur, iddroit, autoriser)VALUES (",
                    utilisateur._id,
                    ", ",
                    droit._id,
                    ",",
                    droit._droit,
                    ");"
                });
            }
            return Connexion.executeScalar(text);
        }

        // Token: 0x06004B0A RID: 19210 RVA: 0x0022DFB0 File Offset: 0x0022C1B0
        public string addDroit(Utilisateur utilisateur)
        {
            string text = "";
            foreach (Droit droit in utilisateur._droits)
            {
                object obj = text;
                text = string.Concat(new object[]
                {
                    obj,
                    "INSERT INTO droit(idutilisateur, iddroit, autoriser)VALUES (",
                    utilisateur._id,
                    ", ",
                    droit._id,
                    ",",
                    droit._droit,
                    ");"
                });
            }
            return text;
        }

        // Token: 0x06004B0B RID: 19211 RVA: 0x0022E06C File Offset: 0x0022C26C
        public string updateDroits(Utilisateur utilisateur)
        {
            string text = "";
            foreach (Droit droit in utilisateur._droits)
            {
                object obj = text;
                text = string.Concat(new object[]
                {
                    obj,
                    "UPDATE droit SET autoriser=",
                    droit._droit,
                    " WHERE idutilisateur=",
                    utilisateur._id,
                    " and iddroit=",
                    droit._id,
                    "; "
                });
            }
            return text;
        }
    }
}
