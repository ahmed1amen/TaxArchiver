using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TaxArchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        public void sqlfunc()
        {

            NpgsqlDataAdapter daNPGSQL;
            NpgsqlCommand cmdNPGSQL;
            NpgsqlConnection npgsqlconn;
            DataSet ds = new DataSet();
            DataTable dtable = new DataTable();
            DataTable result;
            string sql = "select * from parametrage";

            string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=Admin****29311;Database=gend;";
            string connstring2 = "Server=localhost;Port=5432;User Id=postgres;Password=Admin****29311;Database=gend;";

            npgsqlconn = new NpgsqlConnection(connstring);
            npgsqlconn.Open();


            daNPGSQL = new NpgsqlDataAdapter(sql, npgsqlconn);

            ds = new DataSet();

            ds.Reset();
            daNPGSQL.Fill(ds);
            dtable = ds.Tables[0];
            npgsqlconn.Close();
            result = dtable;


            DataTable dt = new DataTable();
            dt = result;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings settings = new settings();

            settings.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
