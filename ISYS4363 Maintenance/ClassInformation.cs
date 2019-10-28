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
    public partial class ClassInformation : Form
    {
        string studentid = LogInScreen.studentid;

        //Start here
        //Private variables for SQL
        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;


        public ClassInformation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectionMenu openForm = new SelectionMenu();
            openForm.Show();
            this.Hide();
        }

        private void ClassInformation_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            string sql = "SELECT Student_ID, First_Name, Last_Name, Program FROM MA_Students WHERE Student_ID = '" + studentid + "'";
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

          

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM MA_Enrollment WHERE Student_ID = '" + studentid + "'";
            var dataadapter = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            dgvClassInfo.DataSource = ds.Tables[0];

            connection.Close();

        }
    }
}
