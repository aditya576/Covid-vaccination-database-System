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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void access_Click(object sender, EventArgs e)
        {
            Form4 form=new Form4();
            form.Show();
            this.Close();
        }

        private void vaccination_details_Click(object sender, EventArgs e)
        {
            Teacher_vaccination_details enter=new Teacher_vaccination_details();
            enter.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Teacher_update update=new Teacher_update();
            update.Show();
            this.Close();
        }
    }
}
