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
            string ssn;
            ssn = txtSSN.Text;
            string AdmissionYear;
            AdmissionYear = txtAdmissionYear.Text;
            string Program;
            Program = txtProgram.Text;
            string Applied;
            Applied = txtPreviosApp.Text;
            string AppliedWhen;
            AppliedWhen = txtAppliedWhen.Text;
            string Enrolled;
            Enrolled = txtPreviosEnroll.Text;
            string EnrollDate;
            EnrollDate = txtEnrolledWhen.Text;
            string EnrollStatus;
            EnrollStatus = txtEnrollStatus.Text;
            string GMATDate;
            GMATDate = txtGMATDate.Text;
            string GMATScore;
            GMATScore = txtGMATScore.Text;
            string GREDate;
            GREDate = txtGREDate.Text;
            string GREScore;
            GREScore = txtGREScore.Text;
            string TOEFLDate;
            TOEFLDate = txtTOEFLDate.Text;
            string TOEFLScore;
            TOEFLScore = txtTOEFLScore.Text;
            string College1;
            College1 = txtCollege1.Text;
            string College2;
            College2 = txtCollege2.Text;
            string College1Start;
            College1Start = txtStart1.Text;
            string College2Start;
            College2Start = txtStart2.Text;
            string College1End;
            College1End = txtEnd1.Text;
            string College2End;
            College2End = txtEnd2.Text;
            string College1GPA;
            College1GPA = txtGPA1.Text;
            string College2GPA;
            College2GPA = txtGPA2.Text;
            string College1Sem;
            College1Sem = txtSemHr1.Text;
            string College2Sem;
            College2Sem = txtSemHr2.Text;
            string College1Major;
            College1Major = txtDegree1.Text;
            string College2Major;
            College2Major = txtDegree2.Text;
            string College1Total;
            College1Total = txtTtlHr1.Text;
            string College2Total;
            College2Total = txtTtlHr2.Text;
            string GMATanswer = chkGMAT.Checked ? "Yes" : "No";
            string GREanswer = chkGRE.Checked ? "Yes" : "No";
            string TOEFLanswer = chkTOEFL.Checked ? "Yes" : "No";



            ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJF19135;" + "User ID=PROJF19135;Password=JX20stt$";

            //sql = "UPDATE MA_Applicants SET Year_of_admission_request = @Year_of_admission_request, Program = @Program, Previously_Applied = @Previously_Applied, Date_Previous_App = @Date_Previous_App, Previously_enrolled = @Previously_enrollend, Date_Previous_enroll = @Date_Previous_enroll, Previous_Status = @Previous_Status, GMAT_Date = @GMAT_Date, GMAT_Score = @GMAT_Score, GRE_Date = @GRE_Date, GRE_Score = @GRE_Score, TOEFL_Date = @TOEFL_Date, TOEFL_Score = @TOEFL_Score, Previous_College_1 = @Previous_College_1, Previous_College_2 = @Previous_College_2, Start_Date_1 = @Start_Date_1, Start_Date_2 = @Start_Date_2, Finish_Date_1 = @Finish_Date_1, Finish_Date_2 = @Finish_Date_2, GPA_1 = @GPA_1, GPA_2 = @GPA_2, Hours_enrolled_1 = @Hours_enrolled_1, Hours_enrolled_2 = @Hours_enrolled_2, @Major_1, @Major_2, @Hours_earned_1, @Hours_earned_2, @GMAT, @GRE, @TOEFL WHERE SSN = '" + ssn + "'";
            sql = "INSERT INTO MA_Applicants VALUES (@Year_of_admission_request, @Program, @Previously_Applied, @Date_Previous_App, Previously_enrolled = @Previously_enrollend, @Date_Previous_enroll, @Previous_Status, @GMAT_Date, @GMAT_Score, @GRE_Date, GRE_Score = @GRE_Score, @TOEFL_Date, @TOEFL_Score, @Previous_College_1,@Previous_College_2, @Start_Date_1, @Start_Date_2, @Finish_Date_1, @Finish_Date_2, @GPA_1, @GPA_2, @Hours_enrolled_1, @Hours_enrolled_2, @Major_1, @Major_2, @Hours_earned_1, @Hours_earned_2, @GMAT, @GRE, @TOEFL) WHERE SSN = '" + ssn + "'";

            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Year_of_admission_request", AdmissionYear);
            command.Parameters.AddWithValue("@Program", Program);
            command.Parameters.AddWithValue("@Previously_Applied", Applied);
            command.Parameters.AddWithValue("@Date_Previous_App", AppliedWhen);
            command.Parameters.AddWithValue("@Previously_enrollend", Enrolled);
            command.Parameters.AddWithValue("@Date_Previous_enroll", EnrollDate);
            command.Parameters.AddWithValue("@Previous_Status", EnrollStatus);
            command.Parameters.AddWithValue("@GMAT_Date", GMATDate);
            command.Parameters.AddWithValue("@GMAT_Score", GMATScore);
            command.Parameters.AddWithValue("@GRE_Date", GREDate);
            command.Parameters.AddWithValue("@GRE_Score", GREScore);
            command.Parameters.AddWithValue("@TOEFL_Date", TOEFLDate);
            command.Parameters.AddWithValue("@TOEFL_Score", TOEFLScore);
            command.Parameters.AddWithValue("@Previous_College_1", College1);
            command.Parameters.AddWithValue("@Previous_College_2", College2);
            command.Parameters.AddWithValue("@Start_Date_1", College1Start);
            command.Parameters.AddWithValue("@Start_Date_2", College2Start);
            command.Parameters.AddWithValue("@Finish_Date_1", College1End);
            command.Parameters.AddWithValue("@Finish_Date_2", College2End);
            command.Parameters.AddWithValue("@GPA_1", College1GPA);
            command.Parameters.AddWithValue("@GPA_2", College2GPA);
            command.Parameters.AddWithValue("@Hours_enrolled_1", College1Sem);
            command.Parameters.AddWithValue("@Hours_enrolled_2", College2Sem);
            command.Parameters.AddWithValue("@Major_1", College1Major);
            command.Parameters.AddWithValue("@Major_2", College2Major);
            command.Parameters.AddWithValue("@Hours_earned_1", College1Total);
            command.Parameters.AddWithValue("@Hours_earned_2", College2Total);
            command.Parameters.AddWithValue("@GMAT", GMATanswer);
            command.Parameters.AddWithValue("@GRE", GREanswer);
            command.Parameters.AddWithValue("@TOEFL", TOEFLanswer);

            
            command.Dispose();
            connection.Close();
            MessageBox.Show("Success in submitting part 2 of your application. Please mail in transcripts and proof of test scores. ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FillOutApplication openForm = new FillOutApplication();
            openForm.Show();
            this.Hide();
        }
    }
}
