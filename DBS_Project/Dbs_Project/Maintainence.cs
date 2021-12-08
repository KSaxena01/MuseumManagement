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
    public partial class Maintainence : Form
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Maintainence()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=museummanagementsystem;password=root";
            conn.Open();
            comm = new MySqlCommand();
            comm.CommandText = "select * from maintenance";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new MySqlDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_maintenance");
            dt = ds.Tables["Tbl_maintenance"];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tbl_maintenance";
            conn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=museummanagementsystem;password=root";
            conn.Open();
            int v = int.Parse(textBox1.Text);
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = conn;
            cm.CommandText = "update maintenance set status='Completed' where m_id="+textBox1.Text;
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            conn.Close();
        }

        private void Maintainence_Load(object sender, EventArgs e)
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
            comm.CommandText = "select s_id from staff";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new MySqlDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_staff");
            dt = ds.Tables["Tbl_staff"];
            comboBox2.DataSource = dt.DefaultView;
            comboBox2.DisplayMember = "s_id";
            conn.Close();
        }
    }
}
