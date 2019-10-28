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
    public partial class FacultyAdvisingView : Form
    {
        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public FacultyAdvisingView()
        {
            InitializeComponent();
        }

        private void FacultyAdivingView_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Student_ID FROM MA_Students";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbStudentID.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();


           
            cmbStatus.Items.Add("Denied");
            cmbStatus.Items.Add("Approved");
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

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbStudentID.SelectedItem.ToString();

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT s.First_Name, s.Last_Name, s.Program FROM MA_Students S JOIN MA_Enrollment E ON s.Student_ID = e.Student_ID WHERE e.Student_ID = '" + selectedstudent + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtLast.Text = dataReader[1].ToString();
                txtFirst.Text = dataReader[0].ToString();
                txtProgram.Text = dataReader[2].ToString();

            }
            dataReader.Close();
            command.Dispose();
            connection.Close();

            lstPending.Items.Clear();
            lstCompleted.Items.Clear();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbStudentID.SelectedItem.ToString();

            string Status;
            Status = cmbStatus.SelectedItem.ToString();


            sql = "UPDATE MA_Enrollment SET Status = @Status WHERE Student_ID = '" + selectedstudent + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Status", Status);

            int answer = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in updating " + answer + " student record");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbStudentID.SelectedItem.ToString();

            connection = new SqlConnection(ConnectionString);
            string sql1 = "SELECT Course_Code FROM MA_Enrollment WHERE Status = 'Completed' AND Student_ID = '" + selectedstudent + "' ";
            connection.Open();
            command = new SqlCommand(sql1, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lstCompleted.Items.Add(dataReader[0].ToString());

            }
            dataReader.Close();
            command.Dispose();
            connection.Close();

            connection = new SqlConnection(ConnectionString);
            string sql2 = "SELECT Course_Code FROM MA_Enrollment WHERE Status = 'Pending' AND Student_ID = '" + selectedstudent + "' ";
            connection.Open();
            command = new SqlCommand(sql2, connection);
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
