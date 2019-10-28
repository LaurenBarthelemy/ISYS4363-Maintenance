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
    public partial class ViewApplication : Form
    {
        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public ViewApplication()
        {
            InitializeComponent();
        }

        private void ViewApplication_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT SSN FROM MA_Applicants";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbSelectApplicant.Items.Add(dataReader[0].ToString());
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ViewApplication2 openForm = new ViewApplication2();
            openForm.Show();
            this.Hide();
        }

        private void cmbSelectApplicant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbSelectApplicant.SelectedItem.ToString();

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT SSN, Last_Name, First_Name, Middle_Initial, Former_Name, Date_of_Birth, Place_of_birth, Current_Employer, Length_of_Current_Employmet, Hispanic, Ethnicity, Gender, Citizenship FROM MA_Applicants WHERE SSN = '" + selectedstudent + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtLast.Text = dataReader[1].ToString();
                txtFirst.Text = dataReader[2].ToString();
                txtMI.Text = dataReader[3].ToString();
                txtFormer.Text = dataReader[4].ToString();
                txtSSN.Text = dataReader[0].ToString();
                txtDOB.Text = dataReader[5].ToString();
                txtPOB.Text = dataReader[6].ToString();
                txtCurrentEmployer.Text = dataReader[7].ToString();
                txtEmploymentLength.Text = dataReader[8].ToString();
                txtHispanic.Text = dataReader[9].ToString();
                txtEthnicity.Text = dataReader[10].ToString();
                txtGender.Text = dataReader[11].ToString();
                txtCitizenship.Text = dataReader[12].ToString();


            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
