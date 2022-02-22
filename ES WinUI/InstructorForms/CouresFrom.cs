
using BL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
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
        CourseList clist ;
        BindingSource source;
        List<int> deletedItem = new List<int>();
        private void CouresFrom_Load(object sender, EventArgs e)
        {
           clist = CourseManger.selectAllCourseOfInstructor(User.UserID);
            source = new BindingSource();
            source.DataSource = clist;
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Columns["EntityState"].Visible = false;
            addBtnsToGridView();

            source.AddingNew += Source_AddingNew;

            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
          //  Console.WriteLine("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS"+ e.Row.Cells[0].Value.ToString());
            if (int.TryParse(e.Row.Cells[0].Value.ToString(), out int temp))
                if (temp != -1)
                    deletedItem.Add(temp);
        }

        private void Source_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            e.NewObject = new Course()
            {
                CId = -1,
                CName="NA",
                Duration = 14,
                EntityState =EntityState.Added
            };
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
                case 4:
                   
                    int cid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (cid != -1) {

                        AddStudentToCourse addStudentToCourse =new AddStudentToCourse();
                        addStudentToCourse.Show();
                        Hide();
                    }

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case  7:

                    break;
                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (clist[i].EntityState == EntityState.Modified)
                {
                    CourseManger.UpdateCourseByID(clist[i].CId, clist[i].CName, clist[i].Duration);
                }
                else if (clist[i].EntityState == EntityState.Added)
                {
                    CourseManger.InsertIntoCourse(clist[i].CName, clist[i].Duration);
                    CourseManger.InsertCourseIntoInstructor(clist[i].CId, User.UserID);
                }
                
                clist[i].EntityState = EntityState.Unchanged;
            }
            foreach (var id in deletedItem)
            {
                CourseManger.DeleteCourseByID(id);
            }

        }
    }
}
