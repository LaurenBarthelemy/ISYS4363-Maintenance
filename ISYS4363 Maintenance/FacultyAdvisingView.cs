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
    }
}
