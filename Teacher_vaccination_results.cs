using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbs_lab_project
{
    public partial class Teacher_vaccination_details : Form
    {
        public Teacher_vaccination_details()
        {
            InitializeComponent();
            department.Items.Add("IT");
            department.Items.Add("CSE");
            department.Items.Add("CCE");
            department.Items.Add("ECE");
            department.Items.Add("EEE");
            department.Items.Add("MECHANICAL");
            college.Items.Add("MIT");
            college.Items.Add("KMC");
            college.Items.Add("MIC");
            college.Items.Add("DOC");
            college.Items.Add("SOC");
            vaccines.Items.Add("COVAXIN");
            vaccines.Items.Add("COVISHIELD");            
        }
        private SqlConnection conn;
        private void DB_connect()
        {
            String connectionString = "Data Source=DESKTOP-O6PII7R\\SQL_COMPILER;Initial Catalog=dbs_lab;Integrated Security=True";
            conn=new SqlConnection(connectionString);
            conn.Open();
        }
        private void collect_details()
        {
            DB_connect();
            String name = stud_name.Text;
            int reg_no = int.Parse(reg.Text);
            String dep = department.Text;
            String col = college.Text;
            String phone_no = phone.Text;
            String email = e_mail.Text;
            String query1 = "insert into faculty values('"+reg_no+"','"+
            name+"','"+phone_no+"','"+dep+"','"+email+"','"+col+"')";
            String vacc_id = vaccination_id.Text;
            String vaccine = vaccines.Text;
            String is_vaccinated = "not";
            if (partially_vaccinated.Checked) is_vaccinated="partial";
            else if (fully_vaccinated.Checked) is_vaccinated="full";
            String first_date = firstDate.Text;
            String second_date = secondDate.Text;
            String infected_date = infectedDate.Text;
            String query2 = "insert into faculty_vaccination values('"+reg_no+"','"+
            vacc_id+"','"+is_vaccinated+"','"+vaccine+"','"+first_date+"','"+second_date+"','"+infected_date+"')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType=CommandType.Text;
            cmd.CommandText=query1;
            cmd.ExecuteNonQuery();
            cmd.CommandText=query2;
            cmd.ExecuteNonQuery();            
            conn.Close();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            this.collect_details();
            MessageBox.Show("entered details successfuly.");
            this.Close();
        }
    }
}
