using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dbs_Project
{
    public partial class Entry : Form
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Entry()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=museummanagementsystem;password=root";
            conn.Open();
            comm = new MySqlCommand();
            comm.CommandText = "select * from entry";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new MySqlDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_entry");
            dt = ds.Tables["Tbl_entry"];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tbl_entry";
            conn.Close();
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=museummanagementsystem;password=root";
            conn.Open();
            comm = new MySqlCommand();
            comm.CommandText = "select z_id from zone";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new MySqlDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_zone");
            dt = ds.Tables["Tbl_zone"];
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "z_id";
            comm.CommandText = "select v_id from visitor";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new MySqlDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_visitor");
            dt = ds.Tables["Tbl_visitor"];
            comboBox3.DataSource = dt.DefaultView;
            comboBox3.DisplayMember = "v_id";
            conn.Close();
        }
    }
}
