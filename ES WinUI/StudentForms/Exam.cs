using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System
{
    public partial class Exam : MaterialForm
    {

        SqlConnection sqlCn = new SqlConnection(
          "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlDataAdapter DAQuestions;
        DataTable DTQuestions;
        DataRow row;
        string[] answers = new string [10];
        int quCounter = 0;

        public int examID { get; set; }

        public Exam(int _examID)
        {
            
            InitializeComponent();
            InitForm();
            examID = _examID;

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GetExamQuestions";
            sqlCmd.Parameters.AddWithValue("Exam_id", examID);

            DAQuestions = new SqlDataAdapter(sqlCmd);
            DTQuestions = new DataTable();
        }
        private void InitForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            btnFinishExam.Hide();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            DAQuestions.Fill(DTQuestions);

            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "setDegree";
            sqlCmd.Parameters.AddWithValue("St_id", User.UserID);
            sqlCmd.Parameters.AddWithValue("Exam_id", examID);
            sqlCmd.Parameters.AddWithValue("grade", 0);

            sqlCn.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCn.Close();



            row = DTQuestions.Rows[quCounter++];
            btnBack.Hide();

            if (row["qType"].ToString() == "T/F")
            {
                rbChoice3.Hide();
                rbChoice4.Hide();
                groupBox.Size = new Size(535, 90);
            }
            else
            {
                rbChoice3.Show();
                rbChoice4.Show();
                groupBox.Size = new Size(550, 170);
            }

            lQuestion.Text = $"{quCounter})  {row["questionText"].ToString()}"; ;
            rbChoice1.Text = row["choice1"].ToString();
            rbChoice2.Text = row["choice2"].ToString();
            rbChoice3.Text = row["choice3"].ToString();
            rbChoice4.Text = row["choice4"].ToString();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
        
             answers[quCounter - 1] = findChoosenAnswer();
        

            if (checkCheckdBoxes())
            {
                row = DTQuestions.Rows[quCounter];
                btnBack.Show();

                if (quCounter == 9)
                {
                    btnNext.Hide();
                    btnFinishExam.Show();
                }

                if (row["qType"].ToString() == "T/F")
                {
                    rbChoice3.Hide();
                    rbChoice4.Hide();
                    groupBox.Size = new Size(535, 90);
                }
                else
                {
                    rbChoice3.Show();
                    rbChoice4.Show();
                    groupBox.Size = new Size(550, 170);

                }

                lQuestion.Text = $"{++quCounter})  {row["questionText"].ToString()}"; ;
                rbChoice1.Text = row["choice1"].ToString();
                rbChoice2.Text = row["choice2"].ToString();
                rbChoice3.Text = row["choice3"].ToString();
                rbChoice4.Text = row["choice4"].ToString();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please Choose any choice to procced!");
            }

            resetCheckdBoxes();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if(quCounter == 2)
                btnBack.Hide();

            if (quCounter == 10)
            {
                btnNext.Show();
                btnFinishExam.Hide();
            }
            quCounter -= 2;
            row = DTQuestions.Rows[quCounter];

            if (row["qType"].ToString() == "T/F")
            {
                rbChoice3.Hide();
                rbChoice4.Hide();
                groupBox.Size = new Size(535, 90);
            }
            else
            {
                rbChoice3.Show();
                rbChoice4.Show();
                groupBox.Size = new Size(550, 170);

            }

            lQuestion.Text = $"{++quCounter})  {row["questionText"].ToString()}"; ;
            rbChoice1.Text = row["choice1"].ToString();
            rbChoice2.Text = row["choice2"].ToString();
            rbChoice3.Text = row["choice3"].ToString();
            rbChoice4.Text = row["choice4"].ToString();

        }

        internal bool checkCheckdBoxes() {

            return rbChoice1.Checked || rbChoice2.Checked || rbChoice3.Checked || rbChoice4.Checked;
        }
        internal void resetCheckdBoxes()
        {
            rbChoice1.Checked = false;
            rbChoice2.Checked = false;
            rbChoice3.Checked = false;
            rbChoice4.Checked = false;
        }
        internal string findChoosenAnswer()
        {
            if (rbChoice1.Checked)
                return "a";
            else if (rbChoice2.Checked)
                return "b";
            else if (rbChoice3.Checked)
                return "c";
            else
                return "d";

        }
  
        private void BtnFinishExam_Click(object sender, EventArgs e)
        {
            answers[quCounter - 1] = findChoosenAnswer();

            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "insertStdSolveRelation";
            sqlCn.Open();

            for (int i=0; i< 10; i++)
            {
                row = DTQuestions.Rows[i];

                sqlCmd.Parameters.AddWithValue("Std_ID", User.UserID);
                sqlCmd.Parameters.AddWithValue("Exam_id", examID);
                sqlCmd.Parameters.AddWithValue("questionID", Convert.ToInt32(row["questionID"].ToString()));
                sqlCmd.Parameters.AddWithValue("St_Answer", answers[i]);

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Parameters.Clear();
            }

            sqlCn.Close();

            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "CorrectExam";

            sqlCn.Open();

            SqlParameter outputPara;
            outputPara = new SqlParameter("GRADE", SqlDbType.Float);
            outputPara.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(outputPara);

            sqlCmd.Parameters.AddWithValue("ExamID", examID);
            sqlCmd.Parameters.AddWithValue("StuID", User.UserID);
            
                
            sqlCmd.ExecuteNonQuery();

            sqlCn.Close();

            System.Windows.Forms.MessageBox.Show($"You have successfully submited the exam! and you got {outputPara.Value.ToString()} out of 10");

            Hide();
            new StudentMenu().Show();
        }
    }
}
