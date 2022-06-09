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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserType.Items.Add("Student");
            UserType.Items.Add("Teacher");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String user= UserType.Text;
            
            if (user.Equals("Student"))
            {
                Form2 frm2=new Form2();
                frm2.Show();
            }
            else if (user.Equals("Teacher"))
            {   
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            {
                UserType.Text="Invalid UserType";
            }
        }
    }
}
