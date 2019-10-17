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
    public partial class LogInScreen : Form
    {
        public static string studentid;
        public static string facultyid;
        public static bool faculty;
        public static bool student;


        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public LogInScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //This should work when we have data
            if (rdoStudent.Checked == true)
            {
                ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
                connection = new SqlConnection(ConnectionString);
                sql = "SELECT * FROM Student WHERE /*Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";*/
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dtbl1 = new DataTable();
                adapter.Fill(dtbl1);
                if (dtbl1.Rows.Count == 1)
                {
                    SelectionMenu Check = new SelectionMenu();
                    Check.Show();
                    this.Hide();

                    studentid = txtUsername.Text;
                    
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                }
            }
            else if (rdoFaculty.Checked == true)
            {

                ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";
                connection = new SqlConnection(ConnectionString);
                sql = "SELECT * FROM Faculty WHERE /*Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'"; */
                 connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dtbl1 = new DataTable();
                adapter.Fill(dtbl1);
                if (dtbl1.Rows.Count == 1)
                {
                    SelectionMenu Check = new SelectionMenu();
                    Check.Show();
                    this.Hide();

                    facultyid = txtUsername.Text;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                }
            }
        }

        private void rdoFaculty_CheckedChanged(object sender, EventArgs e)
        {
            faculty = rdoFaculty.Checked == true;
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            student = rdoStudent.Checked == true;
        }
}
}
