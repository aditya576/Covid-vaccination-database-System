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
    public partial class student_vaccination_details : Form
    {
        private SqlConnection conn;
        public student_vaccination_details()
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
        private String first_date = null;
        private String second_date = null;
        private String infected_date = null;

        private void collect_details()
        {
            DB_connect();
            String name=Name.Text;
            int reg_no=int.Parse(reg.Text);
            String dep=department.Text;
            String col=college.Text;
            String phone_no=phone.Text;
            String email=e_mail.Text;
            String address = "@"+col;
            String query1= "insert into student values('"+reg_no+"','"+
            name+"','"+phone_no+"','"+dep+"','"+email+"','"+col+"')";
            String vacc_id=vaccination_id.Text;
            String vaccine=vaccines.Text;
            String is_vaccinated="not";         
            if (not_vaccinated.Checked) { vaccine="NULL"; first_date="";second_date=""; }
            else if(partially_vaccinated.Checked){is_vaccinated="partial";second_date="";}
            else if(fully_vaccinated.Checked)is_vaccinated="full";
            
            String query2= "insert into student_vaccination values('"+reg_no+"','"+
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
        private void DB_connect()
        {
            String connectionString = "Data Source=DESKTOP-O6PII7R\\SQL_COMPILER;Initial Catalog=dbs_lab;Integrated Security=True";
            conn=new SqlConnection(connectionString);
            conn.Open();
        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            this.collect_details();
            
            MessageBox.Show("entered details succesfuly");
            this.Close();
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {
            first_date = firstDate.Text;
        }

        private void secondDate_ValueChanged(object sender, EventArgs e)
        {
            second_date = secondDate.Text;
        }

        private void infectedDate_ValueChanged(object sender, EventArgs e)
        {
            infected_date = infectedDate.Text;
        }
    }
}
