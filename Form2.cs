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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void vaccination_details_Click(object sender, EventArgs e)
        {
            student_vaccination_details enter=new student_vaccination_details();
            enter.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Student_Update update = new Student_Update();
            update.Show();
            this.Close();
        }
    }
}
