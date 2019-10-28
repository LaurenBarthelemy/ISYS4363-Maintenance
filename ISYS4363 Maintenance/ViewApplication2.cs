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
    public partial class ViewApplication2 : Form
    {
        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public ViewApplication2()
        {
            InitializeComponent();
        }

        private void ViewApplication2_Load(object sender, EventArgs e)
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

            cmbApplicationStatus.Items.Add("Denied");
            cmbApplicationStatus.Items.Add("Accepted");
            cmbApplicationStatus.Items.Add("Wait List");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewApplication openForm = new ViewApplication();
            openForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbSelectApplicant.SelectedItem.ToString();
            string Status;
            Status = cmbApplicationStatus.SelectedItem.ToString();

            sql = "UPDATE MA_Applicants SET Status = @Status WHERE SSN = '" + selectedstudent + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Status", Status);

            int answer = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in updating " + answer + " record");
        }

        private void cmbSelectApplicant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedstudent;
            selectedstudent = cmbSelectApplicant.SelectedItem.ToString();

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Year_of_admission_request, Program, Date_Previous_App, Date_Previous_enroll, Previous_Status, GMAT_Date, GMAT_Score, GRE_Date, GRE_Score, TOEFL_Date, TOEFL_Score, Previous_College_1, Previous_College_2, Start_Date_1, Start_Date_2, Finish_Date_1, Finish_Date_2, GPA_1, GPA_2, Hours_enrolled_1, Hours_enrolled_2, Major_1, Major_2, Hours_earned_1, Hours_earned_2 FROM MA_Applicants WHERE SSN = '" + selectedstudent + "'";

            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtAdmissionYear.Text = dataReader[0].ToString();
                txtProgram.Text = dataReader[1].ToString();
                txtAppliedWhen.Text = dataReader[2].ToString();
                txtEnrolledWhen.Text = dataReader[3].ToString();
                txtStatus.Text = dataReader[4].ToString();
                txtGMATDate.Text = dataReader[5].ToString();
                txtGMATScore.Text = dataReader[6].ToString();
                txtGREDate.Text = dataReader[7].ToString();
                txtGREScore.Text = dataReader[8].ToString();
                txtTOEFLDate.Text = dataReader[9].ToString();
                txtTOEFLScore.Text = dataReader[10].ToString();
                txtCollege1.Text = dataReader[11].ToString();
                txtCollege2.Text = dataReader[12].ToString();
                txtStart1.Text = dataReader[13].ToString();
                txtStart2.Text = dataReader[14].ToString();
                txtEnd1.Text = dataReader[15].ToString();
                txtEnd2.Text = dataReader[16].ToString();
                txtGPA1.Text = dataReader[17].ToString();
                txtGPA2.Text = dataReader[18].ToString();
                txtSemHrs1.Text = dataReader[19].ToString();
                txtSemHrs2.Text = dataReader[20].ToString();
                txtDegree1.Text = dataReader[21].ToString();
                txtDegree2.Text = dataReader[22].ToString();
                txtTtlHrs1.Text = dataReader[23].ToString();
                txtTtlHrs2.Text = dataReader[24].ToString();


            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtAdmissionYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAppliedWhen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnrolledWhen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtProgram_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtGMATDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtGMATScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtGREDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGREScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
