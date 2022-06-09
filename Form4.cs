using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbs_lab_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (user_id.Text == "noobmasters" && password.Text=="noobmasters")
            {
                access form = new access();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid USername or Password");
            }
        }
    }
}
