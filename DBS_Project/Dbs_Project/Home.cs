using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbs_Project
{
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void maintainence_Click(object sender, EventArgs e)
        {
            Maintainence main = new Maintainence();
            this.Hide();
            main.Show();
        }

        private void visitor_list_Click(object sender, EventArgs e)
        {
            Visitor_List v = new Visitor_List();
            this.Hide();
            v.Show();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.Show();
        }

        private void zones_Click(object sender, EventArgs e)
        {
            Zones zone = new Zones();
            this.Hide();
            zone.Show();
        }

        private void artifacts_Click(object sender, EventArgs e)
        {
            Artifacts ar = new Artifacts();
            this.Hide();
            ar.Show();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            Entry en = new Entry();
            this.Hide();
            en.Show();
        }
    }
}
