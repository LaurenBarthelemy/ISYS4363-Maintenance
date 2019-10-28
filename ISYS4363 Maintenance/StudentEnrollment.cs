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


namespace ISYS4363_Maintenance
{
    public partial class StudentEnrollment : Form
    {
        string studentid = LogInScreen.studentid;

        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public StudentEnrollment()
        {
            InitializeComponent();
        }

        private void StudentAdvising_Load(object sender, EventArgs e)
        {
            cmbSemester.Items.Add("Spring 2020");
            cmbSemester.Items.Add("Summer 2020");


            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Student_ID, First_Name, Last_Name, Program FROM MA_Students WHERE Student_ID = '" + studentid + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtStudentID.Text = dataReader[0].ToString();
                txtFirst.Text = dataReader[1].ToString();
                txtLast.Text = dataReader[2].ToString();
                txtProgram.Text = dataReader[3].ToString();


            }
            dataReader.Close();
            command.Dispose();
            connection.Close();

            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Course_Code FROM MA_Courses";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbClasses.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectionMenu openForm = new SelectionMenu();
            openForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string semester;
            semester = cmbSemester.SelectedIndex.ToString();
            string courseid;
            courseid = cmbClasses.SelectedIndex.ToString();
           

            connection = new SqlConnection(ConnectionString);
            string sql3 = "INSERT INTO MA_Enrollment (Student_ID, Course_Code, Semester, Status) VALUES (@Student_ID, @Course_Code, @Semester, 'Pending')";
            connection.Open();
            command = new SqlCommand(sql3, connection);
            
                command.Parameters.AddWithValue("@Student_ID", studentid);
                command.Parameters.AddWithValue("@Course_Code", courseid);
                command.Parameters.AddWithValue("@Semester", semester);
          
            int answer = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in updating " + answer + " record(s)");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string semester;
            semester = cmbSemester.SelectedIndex.ToString();

            lstPending.Items.Clear();

            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Course_Code FROM MA_Enrollment WHERE Student_ID = '" + studentid + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                lstPending.Items.Add(dataReader[0].ToString());

            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
