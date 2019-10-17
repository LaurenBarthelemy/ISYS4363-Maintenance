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
    public partial class FillOutApplication2 : Form
    {
        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public FillOutApplication2()
        {
            InitializeComponent();
        }

        private void FillOutApplication2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string AdmissionYear;
            AdmissionYear = txtAdmissionYear.Text;
            string Program;
            Program = cmbProgram.SelectedItem.ToString();

            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";

            //sql = "UPDATE Class SET Name = @Name, Class_Time = @Class_Time, TID = @TID, Room = @Room WHERE Name = '" + class_choice + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Name", LastName);
            command.Parameters.AddWithValue("@Class_Time", FirstName);
            command.Parameters.AddWithValue("@TID", MI);
            command.Parameters.AddWithValue("@Room", Former);
            command.Parameters.AddWithValue("@Room", SSN);
            command.Parameters.AddWithValue("@Room", DOB);
            command.Parameters.AddWithValue("@Room", POB);
            command.Parameters.AddWithValue("@Room", Street);
            command.Parameters.AddWithValue("@Room", City);
            command.Parameters.AddWithValue("@Room", State);
            command.Parameters.AddWithValue("@Room", Zipcode);
            command.Parameters.AddWithValue("@Room", Country);
            command.Parameters.AddWithValue("@Room", Phone);
            command.Parameters.AddWithValue("@Room", Email);


            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in submitting part 2 of your application. ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FillOutApplication openForm = new FillOutApplication();
            openForm.Show();
            this.Hide();
        }
    }
}
