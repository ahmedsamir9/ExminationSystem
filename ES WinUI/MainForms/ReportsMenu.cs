using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.InstructorForms;
using Examination_System.Reports.GetInstCourses;
using Examination_System.Reports.GetStudentGrades;
using Examination_System.Reports.StDetailsInDeptReport;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System.MainForms
{
    public partial class ReportsMenu : MaterialForm
    {
        public ReportsMenu()
        {
            InitializeComponent();
            InitForm();
            FormClosed += (seneder, e) => Process.GetCurrentProcess().Kill();
            ;
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

        private void ReportsMenu_Load(object sender, EventArgs e) { }

        private void BtnReport1_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentDetailsinDept().Show();
        }

        private void BtnReport2_Click(object sender, EventArgs e)
        {
            Hide();
            new Reports.GetStudentGrades.StudentGrades().Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new InstructorMenu().Show();
            Hide();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new GetInstCourses().Show();
        }

        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            Hide();
            new GetCourseTopics().Show();
        }

        private void MaterialButton4_Click(object sender, EventArgs e)
        {
            Hide();
            new GetExamQuestions().Show();
        }

        private void MaterialButton5_Click(object sender, EventArgs e)
        {
            Hide();
            new GetStudentAnswers().Show();
        }
    }
}
