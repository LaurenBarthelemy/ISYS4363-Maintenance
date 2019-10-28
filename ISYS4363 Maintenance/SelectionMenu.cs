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
    public partial class SelectionMenu : Form
    {
        //Public Variables
        bool student = LogInScreen.student;
        bool faculty = LogInScreen.faculty;

        string ConnectionString = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void SelectionMenu_Load(object sender, EventArgs e)
        {
            if (student == true)
            {
                btnAdvising.Hide();
                btnStudentInformation.Hide();
                btnViewApplicants.Hide();
            } 
            else
            {
                btnYourInformation.Hide();
                btnEnrollment.Hide();
                btnClassInformation.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YourInfo openForm = new YourInfo();
            openForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LogInScreen openForm = new LogInScreen();
            openForm.Show();
            this.Hide();

            MessageBox.Show("Warning: You are logging out.");
        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            StudentInfo openForm = new StudentInfo();
            openForm.Show();
            this.Hide();
        }

        private void btnClassInformation_Click(object sender, EventArgs e)
        {
            ClassInformation openForm = new ClassInformation();
            openForm.Show();
            this.Hide();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            StudentEnrollment openForm = new StudentEnrollment();
            openForm.Show();
            this.Hide();
        }

        private void btnAdvising_Click(object sender, EventArgs e)
        {
            FacultyAdvisingView openForm = new FacultyAdvisingView();
            openForm.Show();
            this.Hide();
        }

        private void btnViewApplicants_Click(object sender, EventArgs e)
        {
            ViewApplication openForm = new ViewApplication();
            openForm.Show();
            this.Hide();
        }
    }
}
