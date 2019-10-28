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
    public partial class FillOutApplication : Form
    {
        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public FillOutApplication()
        {
            InitializeComponent();
        }

        private void FillOutApplication_Load(object sender, EventArgs e)
        {

            cmbEthnicity.Items.Add("American Indian");
            cmbEthnicity.Items.Add("Alaska Native");
            cmbEthnicity.Items.Add("Asian");
            cmbEthnicity.Items.Add("Black or African American");
            cmbEthnicity.Items.Add("Native Hawaiian");
            cmbEthnicity.Items.Add("Other Pacific Islander");
            cmbEthnicity.Items.Add("White");
           

            cmbCitizenship.Items.Add("US Citizen");
            cmbCitizenship.Items.Add( "Resident Alien");
            cmbCitizenship.Items.Add( "Non Resident Alien");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string LastName;
            LastName = txtLast.Text;
            string FirstName;
            FirstName = txtFirst.Text;
            string MI;
            MI = txtMI.Text;
            string Former;
            Former = txtFormer.Text;
            string SSN;
            SSN = txtSSN.Text;
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
            string CurrentEmployer;
            CurrentEmployer = txtCurrentEmployer.Text;
            string EmploymentLength;
            EmploymentLength = txtEmploymentLength.Text;
            string Hispanic;
            Hispanic = txtHispanic.Text;
            string Ethnicity;
            Ethnicity = cmbEthnicity.SelectedItem.ToString();
            string Gender;
            Gender = txtGender.Text;
            string Citizenship;
            Citizenship = cmbCitizenship.SelectedItem.ToString();

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            //sql = "UPDATE MA_Applicants SET SSN = @SSN, Last_Name = @Last_Name, First_Name = @First_Name, Middle_Initial = @Middle_Initial, Former_Name = @Former_Name, Date_of_Birth = @Date_of_Birth, Place_of_Birth = @Place_of_Birth, Street_Address = @Street_Address, City = @City, State = @State, Zip_Code = @Zip_Code, Country = @Country, Cell_Phone = @Cell_Phone, Email = @Email, Hispanic = @Hispanic, Ethnicity = @Ethnicity, Gender = @Gender, Citizenship = @Citizenship WHERE SSN = '" + SSN + "'";
            sql = "INSERT INTO MA_Applicants VALUES (@SSN, @Last_Name, @First_Name, @Middle_Initial, @Former_Name, @Date_of_Birth, @Place_of_Birth, @Street_Address, @City, @State, @Zip_Code, @Country, @Cell_Phone, @Email, @Hispanic, @Ethnicity, @Gender, @Citizenship WHERE SSN = '" + SSN + "'";

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SSN", SSN);
            command.Parameters.AddWithValue("@Last_Name", LastName);
            command.Parameters.AddWithValue("@First_Name", FirstName);
            command.Parameters.AddWithValue("@Middle_Initial", MI);
            command.Parameters.AddWithValue("@Former_Name", Former);
            command.Parameters.AddWithValue("@Date_of_Birth", DOB);
            command.Parameters.AddWithValue("@Place_of_Birth", POB);
            command.Parameters.AddWithValue("@Street_Address", Street);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@State", State);
            command.Parameters.AddWithValue("@Zip_Code", Zipcode);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Cell_Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Hispanic", Hispanic);
            command.Parameters.AddWithValue("Ethnicity", Ethnicity);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Citizenship", Citizenship);


            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in submitting part 1 of your application. ");

            FillOutApplication2 openForm = new FillOutApplication2();
            openForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInScreen openForm = new LogInScreen();
            openForm.Show();
            this.Hide();
        }
    }
}
