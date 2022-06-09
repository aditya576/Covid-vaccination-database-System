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
    public partial class Teacher_update : Form
    {
        public Teacher_update()
        {
            InitializeComponent();
            
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
        private void update()
        {
            DB_connect();
            //String name = fac_name.Text;
            int faculty_id = int.Parse(reg.Text);
            //String dep = department.Text;
            //String col = college.Text;
            //String phone_no = phone.Text;
            //String email=email.Text;
            String vacc_id = vaccination_id.Text;
            String vaccine=vaccines.Text;
            String is_vaccinated = "not";
            if (partially_vaccinated.Checked) is_vaccinated="partial";
            else if (fully_vaccinated.Checked) is_vaccinated="full";
            String first_date = firstDate.Text;
            String second_date = secondDate.Text;
            String infected_date = infectedDate.Text;
            if (first_date.Equals("1900-01-01")) first_date=null;
            if (second_date.Equals("1900-01-01")) second_date=null;
            if (infected_date.Equals("1900-01-01")) infected_date=null;
            String query1 = "update faculty_vaccination set vaccination_status =@vxn,vaccination_id=@id,vaccine_name=@name,first_vaccine_date=@first,second_vaccine_date=@second,last_infected_date=@last where faculty_id =@rg";
            SqlCommand command = new SqlCommand();            
            command.Connection = conn;
            command.CommandText = query1;
            command.CommandType= CommandType.Text;
            command.Parameters.AddWithValue("@vxn", is_vaccinated);
            command.Parameters.AddWithValue("@rg", faculty_id);
            command.Parameters.AddWithValue("@id", vacc_id);
            command.Parameters.AddWithValue("@name", vaccine);
            command.Parameters.AddWithValue("@first", first_date);
            command.Parameters.AddWithValue("@second", second_date);
            command.Parameters.AddWithValue("@last", infected_date);
            command.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            conn.Close();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            this.update();
            MessageBox.Show("updated details succesfuly");
            this.Close();
        }
    }
}
