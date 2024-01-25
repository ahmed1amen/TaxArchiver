using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TaxArchiver.Models;

namespace TaxArchiver.DAL.DAO
{
    // Token: 0x020000E6 RID: 230
    public class Connexion
    {
        // Token: 0x06000F25 RID: 3877 RVA: 0x00090108 File Offset: 0x0008E308
        public Connexion()
        {
            Connexion.typeConnexion = Connexion.lines[0];
            Connexion.idInterface = Convert.ToInt32(Connexion.lines[8]);
            if (Connexion.typeConnexion == "npgsql")
            {
                Connexion._connstring = string.Format("Server={0};Port={1};User Id={2};Password=Admin****29311;Database={3};", new object[]
                {
                    Connexion.lines[1],
                    Connexion.lines[2],
                    Connexion.lines[3],
                    Connexion.lines[5]
                });
                Connexion.npgsqlconn = new NpgsqlConnection(Connexion._connstring);
                return;
            }
            if (Connexion.typeConnexion == "sqls")
            {
                Connexion._connstring = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password=Admin**29311", Connexion.lines[1], Connexion.lines[2], Connexion.lines[3]);
                Connexion.sqlconn = new SqlConnection(Connexion._connstring);
            }
        }

        // Token: 0x06000F26 RID: 3878 RVA: 0x000901DC File Offset: 0x0008E3DC
        public static DataTable executeQuery(string sql)
        {
            DataTable result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.npgsqlconn.Open();
                    Connexion.daNPGSQL = new NpgsqlDataAdapter(sql, Connexion.npgsqlconn);
                    Connexion.ds = new DataSet();
                    Connexion.ds.Reset();
                    Connexion.daNPGSQL.Fill(Connexion.ds);
                    Connexion.dtable = Connexion.ds.Tables[0];
                    Connexion.npgsqlconn.Close();
                    result = Connexion.dtable;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.sqlconn.Open();
                    Connexion.daSQL = new SqlDataAdapter(sql, Connexion.sqlconn);
                    Connexion.ds = new DataSet();
                    Connexion.ds.Reset();
                    Connexion.daSQL.Fill(Connexion.ds);
                    Connexion.dtable = Connexion.ds.Tables[0];
                    Connexion.sqlconn.Close();
                    result = Connexion.dtable;
                }
                else
                {
                    result = null;
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000F27 RID: 3879 RVA: 0x000902F0 File Offset: 0x0008E4F0
        public static int executeUpdate(string sql)
        {
            int result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    int num = Connexion.cmdNPGSQL.ExecuteNonQuery();
                    Connexion.npgsqlconn.Close();
                    result = num;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    int num2 = Connexion.cmdSQL.ExecuteNonQuery();
                    Connexion.sqlconn.Close();
                    result = num2;
                }
                else
                {
                    result = -1;
                }
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        // Token: 0x06000F28 RID: 3880 RVA: 0x000903A0 File Offset: 0x0008E5A0
        public static int executeNonQueryWithParametres(string sql, NpgsqlParameter param)
        {
            Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
            Connexion.cmdNPGSQL.Parameters.Add(param);
            Connexion.npgsqlconn.Open();
            int result = Connexion.cmdNPGSQL.ExecuteNonQuery();
            Connexion.npgsqlconn.Close();
            return result;
        }

        // Token: 0x06000F29 RID: 3881 RVA: 0x000903F0 File Offset: 0x0008E5F0
        public static int executeScalar(string sql)
        {
            int result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    int num = Convert.ToInt32(Connexion.cmdNPGSQL.ExecuteScalar());
                    Connexion.npgsqlconn.Close();
                    result = num;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    int num2 = Convert.ToInt32(Connexion.cmdSQL.ExecuteScalar());
                    Connexion.sqlconn.Close();
                    result = num2;
                }
                else
                {
                    result = -1;
                }
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        // Token: 0x06000F2A RID: 3882 RVA: 0x000904AC File Offset: 0x0008E6AC
        public static bool executeScalarBoolean(string sql)
        {
            bool result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    bool flag = Convert.ToBoolean(Connexion.cmdNPGSQL.ExecuteScalar());
                    Connexion.npgsqlconn.Close();
                    result = flag;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    bool flag2 = Convert.ToBoolean(Connexion.cmdSQL.ExecuteScalar());
                    Connexion.sqlconn.Close();
                    result = flag2;
                }
                else
                {
                    result = true;
                }
            }
            catch
            {
                result = true;
            }
            return result;
        }

        // Token: 0x06000F2B RID: 3883 RVA: 0x00090568 File Offset: 0x0008E768
        public static DateTime executeScalarDateTime(string sql)
        {
            DateTime result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    DateTime dateTime = Convert.ToDateTime(Connexion.cmdNPGSQL.ExecuteScalar());
                    Connexion.npgsqlconn.Close();
                    result = dateTime;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    DateTime dateTime2 = Convert.ToDateTime(Connexion.cmdSQL.ExecuteScalar());
                    Connexion.sqlconn.Close();
                    result = dateTime2;
                }
                else
                {
                    result = DateTime.Now;
                }
            }
            catch
            {
                result = DateTime.Now;
            }
            return result;
        }

        // Token: 0x06000F2C RID: 3884 RVA: 0x0009062C File Offset: 0x0008E82C
        public static decimal executeScalarDecimal(string sql)
        {
            decimal result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    decimal num = Convert.ToDecimal(Connexion.cmdNPGSQL.ExecuteScalar());
                    Connexion.npgsqlconn.Close();
                    result = num;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    decimal num2 = Convert.ToDecimal(Connexion.cmdSQL.ExecuteScalar());
                    Connexion.sqlconn.Close();
                    result = num2;
                }
                else
                {
                    result = -1m;
                }
            }
            catch
            {
                result = -1m;
            }
            return result;
        }

        // Token: 0x06000F2D RID: 3885 RVA: 0x000906F0 File Offset: 0x0008E8F0
        public static DbDataReader executeReader(string sql)
        {
            DbDataReader result;
            try
            {
                if (Connexion.typeConnexion == "npgsql")
                {
                    Connexion.cmdNPGSQL = new NpgsqlCommand(sql, Connexion.npgsqlconn);
                    Connexion.npgsqlconn.Open();
                    DbDataReader dbDataReader = Connexion.cmdNPGSQL.ExecuteReader();
                    Connexion.npgsqlconn.Close();
                    result = dbDataReader;
                }
                else if (Connexion.typeConnexion == "sqls")
                {
                    Connexion.cmdSQL = new SqlCommand(sql, Connexion.sqlconn);
                    Connexion.sqlconn.Open();
                    DbDataReader dbDataReader = Connexion.cmdSQL.ExecuteReader();
                    Connexion.sqlconn.Close();
                    result = dbDataReader;
                }
                else
                {
                    result = null;
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000F2E RID: 3886 RVA: 0x000907A0 File Offset: 0x0008E9A0
        public static bool testConnexion()
        {
            bool result;
            try
            {
                int num = Connexion.executeScalar("select count(*) from ipara");
                if (num != -1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000F2F RID: 3887 RVA: 0x000907DC File Offset: 0x0008E9DC
        public void PostgreSqlDump()
        {
            string text = Connexion.lines[1];
            string text2 = Connexion.lines[2];
            string text3 = Connexion.lines[5];
            string text4 = Connexion.lines[3];
            string text5 = Connexion.lines[4];
            string text6 = Connexion.lines[6];
            int year = Parametrage._date.Year;
            int month = Parametrage._date.Month;
            int day = Parametrage._date.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            int millisecond = DateTime.Now.Millisecond;
            string text7 = string.Concat(new object[]
            {
                Connexion.lines[7],
                year,
                "-",
                month,
                "-",
                day,
                "-",
                hour,
                "-",
                minute,
                ".odeo"
            });
            string text8 = string.Concat(new string[]
            {
                "\"",
                text6,
                "\" -Fc  -U ",
                text4,
                " -h ",
                text,
                " -p ",
                text2,
                " ",
                text3
            });
            string contents = string.Concat(new string[]
            {
                text,
                ":",
                text2,
                ":",
                text3,
                ":",
                text4,
                ":",
                text5
            });
            string fileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".bat");
            string str = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".conf");
            try
            {
                string text9 = "";
                text9 = text9 + "@set PGPASSFILE=" + str + "\n";
                string text10 = text9;
                text9 = string.Concat(new string[]
                {
                    text10,
                    "@",
                    text8,
                    "  > \"",
                    text7,
                    "\"\n"
                });
                Console.WriteLine(text9);
                File.WriteAllText(fileName, text9, Encoding.ASCII);
                File.WriteAllText(str, contents, Encoding.ASCII);
                if (File.Exists(text7))
                {
                    File.Delete(text7);
                }
                using (Process process = Process.Start(new ProcessStartInfo(fileName)
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                }))
                {
                    process.WaitForExit();
                    process.Close();
                }
            }
            finally
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                if (File.Exists(str))
                {
                    File.Delete(str);
                }
            }
        }

        // Token: 0x06000F30 RID: 3888 RVA: 0x00090B18 File Offset: 0x0008ED18
        public void PostgresProductCopy()
        {
            string text = Connexion.lines[1];
            string text2 = Connexion.lines[2];
            string text3 = Connexion.lines[5];
            string text4 = Connexion.lines[3];
            string text5 = Connexion.lines[4];
            string text6 = Connexion.lines[6];
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            int millisecond = DateTime.Now.Millisecond;
            string text7 = string.Concat(new object[]
            {
                Connexion.lines[7],
                year,
                "-",
                month,
                "-",
                day,
                "-",
                hour,
                "-",
                minute,
                ".odeo"
            });
            Directory.CreateDirectory(Connexion.lines[7]);
            string text8 = string.Concat(new string[]
            {
                "\"",
                text6,
                "\" -Fc  -U ",
                text4,
                " -h ",
                text,
                " -p ",
                text2,
                " ",
                text3
            });
            string contents = string.Concat(new string[]
            {
                text,
                ":",
                text2,
                ":",
                text3,
                ":",
                text4,
                ":",
                text5
            });
            string fileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".bat");
            string str = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".conf");
            try
            {
                string text9 = "";
                text9 = text9 + "@set PGPASSFILE=" + str + "\n";
                string text10 = text9;
                text9 = string.Concat(new string[]
                {
                    text10,
                    "@",
                    text8,
                    "  > \"",
                    text7,
                    "\"\n"
                });
                Console.WriteLine(text9);
                File.WriteAllText(fileName, text9, Encoding.ASCII);
                File.WriteAllText(str, contents, Encoding.ASCII);
                if (File.Exists(text7))
                {
                    File.Delete(text7);
                }
                using (Process process = Process.Start(new ProcessStartInfo(fileName)
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                }))
                {
                    process.WaitForExit();
                    process.Close();
                }
            }
            finally
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                if (File.Exists(str))
                {
                    File.Delete(str);
                }
            }
        }

        // Token: 0x04000C14 RID: 3092
        public static string _connstring;

        // Token: 0x04000C15 RID: 3093
        private static DataSet ds = new DataSet();

        // Token: 0x04000C16 RID: 3094
        private static DataTable dtable = new DataTable();

        // Token: 0x04000C17 RID: 3095
        public static NpgsqlConnection npgsqlconn;

        // Token: 0x04000C18 RID: 3096
        public static SqlConnection sqlconn;

        // Token: 0x04000C19 RID: 3097
        public static string typeConnexion;

        // Token: 0x04000C1A RID: 3098
        public static string path = "..\\..\\";

        // Token: 0x04000C1B RID: 3099
        public static int id = 0;

        // Token: 0x04000C1C RID: 3100
        public static int idInterface = 0;

        // Token: 0x04000C1D RID: 3101
        public static string[] lines = File.ReadAllLines(Connexion.path + "DAL\\DAO\\Init");

        // Token: 0x04000C1E RID: 3102
        public static SqlDataAdapter daSQL;

        // Token: 0x04000C1F RID: 3103
        public static NpgsqlDataAdapter daNPGSQL;

        // Token: 0x04000C20 RID: 3104
        public static NpgsqlCommand cmdNPGSQL;

        // Token: 0x04000C21 RID: 3105
        public static SqlCommand cmdSQL;
    }
}
