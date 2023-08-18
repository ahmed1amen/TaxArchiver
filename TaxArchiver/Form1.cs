using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TaxArchiver
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }

        protected NpgsqlConnection npgsqlconn;

        private void Form1_Load(object sender, EventArgs e)
        {
           // string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Admin****29311;Database=nv1";
            string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=nv1";
            npgsqlconn = new NpgsqlConnection(connstring);
        }

        private void OpenConnection()
        {
            try
            {
                if (npgsqlconn.State != ConnectionState.Open)
                    npgsqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening connection: " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            if (npgsqlconn.State == ConnectionState.Open)
                npgsqlconn.Close();
        }




        private DataTable GetArchive(DateTime du, DateTime au)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                using (NpgsqlCommand cmdNPGSQL = new NpgsqlCommand())
                {
                    cmdNPGSQL.Connection = npgsqlconn;
                    cmdNPGSQL.CommandText = "SELECT * FROM archfacture WHERE datesystem <= @endDate AND datesystem >= @startDate ORDER BY id";


                    cmdNPGSQL.Parameters.Add(new NpgsqlParameter("@startDate", NpgsqlDbType.Date));
                    cmdNPGSQL.Parameters["@startDate"].Value = du;

                    cmdNPGSQL.Parameters.Add(new NpgsqlParameter("@endDate", NpgsqlDbType.Date));
                    cmdNPGSQL.Parameters["@endDate"].Value = au;

                    using (NpgsqlDataAdapter daNPGSQL = new NpgsqlDataAdapter(cmdNPGSQL))
                    {
                        daNPGSQL.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dataTable;
        }


        private void addToListView(string l)
        {
            this.ligne = new ListViewItem(new string[]
            {
       /*         string.Concat(l._id),
                l._table ?? "",
                l._utilisateur._login,
                l._serveur,
                string.Concat(l._totalFacture),
                string.Concat(l._service._id),
                l._dateSystem.ToShortDateString() ?? ""*/
            });
            this.listView1.Items.Add(this.ligne);
        }


        private void InitList()
        {
            this.listView1.Items.Clear();
            this._totalPaiement = 0m;


            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2");
            lvi.SubItems.Add("3");
            lvi.SubItems.Add("4");
            lvi.SubItems.Add("5");
            lvi.SubItems.Add("6");
            listView1.Items.Add(lvi);

            foreach (object obj in this.listView1.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;


            }




            this.textBox2.Text = string.Concat(this._totalPaiement);
        }


        private void ArchiveFactureGUI_Load(object sender, EventArgs e)
        {
        }




        private void button13_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.listView1.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.Checked)
                {
                   // listViewItem.SubItems[5].Text;
                }
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = string.Concat(Convert.ToDecimal(this.textBox2.Text) - Convert.ToDecimal(this.textBox3.Text));
        }


        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this._totalSelection = 0m;
            foreach (object obj in this.listView1.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.Checked)
                {
                    this._totalSelection += Convert.ToDecimal(listViewItem.SubItems[4].Text);
                }
            }
            this.textBox3.Text = string.Concat(this._totalSelection);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dataTable = GetArchive(dateTimePicker1.Value, dateTimePicker2.Value);
            listView1.Items.Clear();
            lbl_result.Text = "Found : " + dataTable.Rows.Count.ToString();

            foreach (DataRow row in dataTable.Rows)
            {

                ListViewItem item = new ListViewItem(row[0].ToString());
       
                item.SubItems.Add(row[1].ToString()); //table
                item.SubItems.Add(row[4].ToString()); // Total Facture
                item.SubItems.Add(row[10].ToString());
                item.SubItems.Add(row[10].ToString());



                listView1.Items.Add(item);
            }






        } 
    }
}
