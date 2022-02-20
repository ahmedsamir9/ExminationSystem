using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Examination_System.InstructorForms
{
    public partial class CouresFrom : MaterialForm
    {
        public CouresFrom()
        {
            InitializeComponent();
            InitForm();
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
        }
        SqlConnection sqlCn = new SqlConnection(
          "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true"
      );
        SqlCommand sqlCmd;
        SqlDataAdapter adapter;
        DataTable courseDt;
        BindingSource source;
        private void CouresFrom_Load(object sender, EventArgs e)
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GetCoursesOfInstructor";
            sqlCmd.Parameters.AddWithValue("ins_id", User.UserID);
            adapter = new SqlDataAdapter(sqlCmd);
            courseDt = new DataTable();
          
            source = new BindingSource(courseDt, "");
            adapter.Fill(courseDt);
            dataGridView1.DataSource = source;
            dataGridView1.ForeColor = Color.Black;
            addBtnsToGridView();
        }
        private void addBtnsToGridView() {
            DataGridViewButtonColumn addIns = new DataGridViewButtonColumn();
            addIns.HeaderText = "Instructors";
            addIns.Text = " Add Instructor";
            addIns.Name = "btnIns";
            addIns.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn addQuestion = new DataGridViewButtonColumn();
            addQuestion.HeaderText = "Questions";
            addQuestion.Text = " Add Question";
            addQuestion.Name = "btn";
          
            addQuestion.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn GenerateExam = new DataGridViewButtonColumn();
            GenerateExam.HeaderText = "Exams";
            GenerateExam.Text = " GenerateExam";
            GenerateExam.Name = "btnEx";
      
            GenerateExam.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn addStudents = new DataGridViewButtonColumn();
            addStudents.HeaderText = "Students";
            addStudents.Text = " Add Students";
            addStudents.Name = "btnstu";
            addStudents.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addIns);
            dataGridView1.Columns.Add(addQuestion);
            dataGridView1.Columns.Add(addStudents);
            dataGridView1.Columns.Add(GenerateExam);
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand updatecommand = new SqlCommand("updateCourse",sqlCn);
            updatecommand.CommandType = CommandType.StoredProcedure;
            SqlCommand insertCommand = new SqlCommand("insertCourse",sqlCn);
            insertCommand.CommandType = CommandType.StoredProcedure;

            //@cName nvarchar(20), @duration int
            DataRowCollection addedRows = ((DataTable)dataGridView1.DataSource).GetChanges(DataRowState.Added).Rows;
            foreach (DataRow item in addedRows) {
                insertCommand.Parameters.Clear();
                insertCommand.Parameters.AddWithValue("cName", item["cName"].ToString());
                insertCommand.Parameters.AddWithValue("duration",  int.Parse(item["duration"].ToString()));
                sqlCn.Open();
                insertCommand.ExecuteNonQuery();
                sqlCn.Close();
            }
            //adapter.Update(courseDt);
        }
    }
}
