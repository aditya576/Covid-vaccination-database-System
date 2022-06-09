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
using System.Data.SqlTypes;

namespace dbs_lab_project
{
    public partial class access : Form
    {
        public access()
        {
            InitializeComponent();            
            tables.Items.Add("student_vaccination");            
            tables.Items.Add("faculty_vaccination");
            filter.Items.Add("NOT VACCINATED");
            filter.Items.Add("PARTIAL VACCINATED");
            filter.Items.Add("MIT");
            filter.Items.Add("KMC");
            filter.Items.Add("MIC");
            filter.Items.Add("DOC");
            filter.Items.Add("SOC");
            filter.Items.Add("COVAXIN");
            filter.Items.Add("COVISHIELD");
        }
        private SqlConnection conn;
        private void connect()
        {
            String connectionString = "Data Source=DESKTOP-O6PII7R\\SQL_COMPILER;Initial Catalog=dbs_lab;Integrated Security=True";
            conn=new SqlConnection(connectionString);
            conn.Open();
        }
        private void show_tables(String obj)
        {
            this.connect();
            String query="";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if(tables.Text.Equals("student_vaccination"))
            {
                if (filter.Text.Equals("NOT VACCINATED"))
                {
                    query = "select s.student_name,s.regno,s.college,v.vaccination_status,v.vaccine_name from student s inner " +
                        "join student_vaccination v on s.regno=v.regno where s.regno in(select regno" +
                        " from student_vaccination where vaccination_status='not') ";
                }
                else if(filter.Text.Equals("PARTIAL VACCINATED"))
                {
                    query = "select s.student_name,s.regno,s.college,v.vaccination_status,v.vaccine_name from student s inner " +
                        "join student_vaccination v on s.regno=v.regno where s.regno in(select regno" +
                        " from student_vaccination where vaccination_status='partial') ";
                }
                else if(filter.Text.Equals("MIT") || filter.Text.Equals("KMC") || filter.Text.Equals("MIC") || filter.Text.Equals("DOC") || filter.Text.Equals("SOC"))
                {                    
                    query = "select s.student_name,s.college,v.vaccination_status,v.vaccine_name from student s inner join student_vaccination v on s.regno=v.regno where s.regno in (select regno from student where college='"+filter.Text+"')";
                }
                else
                {
                    query="select s.student_name,s.college,v.vaccination_status,v.vaccine_name from student s inner join student_vaccination v on s.regno=v.regno where s.regno in (select regno from student where vaccine_name='"+filter.Text+"')";
                }
            }
            else
            {
                if (filter.Text.Equals("NOT VACCINATED"))
                {
                    query = "select s.faculty_name,s.faculty_id,s.college,v.vaccination_status,v.vaccine_name from faculty s inner " +
                        "join faculty_vaccination v on s.faculty_id=v.faculty_id where s.faculty_id in(select faculty_id" +
                        " from faculty_vaccination where vaccination_status='not') ";
                }
                else if (filter.Text.Equals("PARTIAL VACCINATED"))
                {
                    query = "select s.faculty_name,s.faculty_id,s.college,v.vaccination_status,v.vaccine_name from faculty s inner " +
                        "join faculty_vaccination v on s.faculty_id=v.faculty_id where s.faculty_id in(select faculty_id" +
                        " from faculty_vaccination where vaccination_status='partial') ";
                }
                else if (filter.Text.Equals("MIT") || filter.Text.Equals("KMC") || filter.Text.Equals("MIC") || filter.Text.Equals("DOC") || filter.Text.Equals("SOC"))
                {                    
                    query = "select s.faculty_name,s.college,v.vaccination_status,v.vaccine_name from faculty s inner join faculty_vaccination v on s.faculty_id=v.faculty_id where s.faculty_id in (select faculty_id from faculty where college='"+filter.Text+"')";
                }
                else
                {
                    query ="select s.faculty_name,s.college,v.vaccination_status,v.vaccine_name from faculty s inner join faculty_vaccination v on s.faculty_id=v.faculty_id where s.faculty_id in (select faculty_id from faculty where vaccine_name='"+filter.Text+"')";
                }
            }
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@college", filter.Text);            
            SqlDataAdapter da=new SqlDataAdapter(cmd.CommandText,conn);
            DataSet ds=new DataSet();
            da.Fill(ds, "Tbl_"+obj);
            
            dataGridView1.DataSource = ds;
            dataGridView1.Show();
            dataGridView1.DataMember="Tbl_"+obj;
            conn.Close();
        }
        private void enter_Click(object sender, EventArgs e)
        {
            this.show_tables(tables.Text);
            
            dataGridView1.Show();
        }

        
    }
}
