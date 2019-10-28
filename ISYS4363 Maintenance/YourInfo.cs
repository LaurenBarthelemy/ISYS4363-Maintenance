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
    public partial class YourInfo : Form
    {
        string studentid = LogInScreen.studentid;
        

        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public YourInfo()
        {
            InitializeComponent();
        }

        private void YourInfo_Load(object sender, EventArgs e)
        {

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            sql = "SELECT Student_ID, First_Name, Last_Name, Email, Phone, Date_of_Birth, Street_Address, City, State, Zip_Code, Country, Hispanic, Ethnicity, Gender, Citizenship, Program, Major FROM MA_Students WHERE Student_ID = '" + studentid + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtStudentID.Text = dataReader[0].ToString();
                txtFirst.Text = dataReader[1].ToString();
                txtLast.Text = dataReader[2].ToString();
                txtEmail.Text = dataReader[3].ToString();
                txtPhone.Text = dataReader[4].ToString();
                txtDOB.Text = dataReader[5].ToString();
                txtStreet.Text = dataReader[6].ToString();
                txtCity.Text = dataReader[7].ToString();
                txtState.Text = dataReader[8].ToString();
                txtZipcode.Text = dataReader[9].ToString();
                txtCountry.Text = dataReader[10].ToString();
                txtHispanic.Text = dataReader[11].ToString();
                txtEthnicity.Text = dataReader[12].ToString();
                txtGender.Text = dataReader[13].ToString();
                txtCitizenship.Text = dataReader[14].ToString();
                txtProgram.Text = dataReader[15].ToString();
                txtMajor.Text = dataReader[16].ToString();

            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectionMenu openForm = new SelectionMenu();
            openForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string LastName;
            LastName = txtLast.Text;
            string FirstName;
            FirstName = txtFirst.Text;
            string StudentID;
            StudentID = txtStudentID.Text;
            string DOB;
            DOB = txtDOB.Text;
            string POB;
            POB = txtDOB.Text;
            string Street;
            Street = txtStreet.Text;
            string City;
            City = txtCity.Text;
            string State;
            State = txtState.Text;
            string Zipcode;
            Zipcode = txtZipcode.Text;
            string Country;
            Country = txtCountry.Text;
            string Phone;
            Phone = txtPhone.Text;
            string Email;
            Email = txtEmail.Text;
            string Hispanic;
            Hispanic = txtHispanic.Text;
            string Ethnicity;
            Ethnicity = txtEthnicity.Text;
            string Gender;
            Gender = txtGender.Text;
            string Citizenship;
            Citizenship = txtCitizenship.Text;
            string Program;
            Program = txtProgram.Text;
            string Major;
            Major = txtMajor.Text;

            sql = "UPDATE MA_Students SET First_Name = @First_Name, Last_Name = @Last_Name, Email = @Email, Phone = @Phone, Date_of_Birth = @Date_of_Birth, City = @City, State = @State, Zip_Code = @Zip_Code, Country = @Country,Hispanic = @Hispanic, Ethnicity = @Ethnicity, Gender = @Gender, Citizenship = @Citizenship, Major = @Major, Program = @Program WHERE Student_ID = '" + studentid + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@First_Name", FirstName);
            command.Parameters.AddWithValue("@Last_Name", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Date_of_Birth", DOB);
            command.Parameters.AddWithValue("@Street_Address", Street);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@State", State);
            command.Parameters.AddWithValue("@Zip_Code", Zipcode);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Hispanic", Hispanic);
            command.Parameters.AddWithValue("@Ethnicity", Ethnicity);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Citizenship", Citizenship);
            command.Parameters.AddWithValue("@Program", Program);
            command.Parameters.AddWithValue("@Major", Major);

            int answer = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in updating " + answer + " record");
        }
    }
}
