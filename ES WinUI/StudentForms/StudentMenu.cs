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
using Examination_System.StudentForms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System
{
    public partial class StudentMenu : MaterialForm
    {
        public StudentMenu()
        {
            InitializeComponent();
            InitForm();
            FormClosed += (seneder, e) => Process.GetCurrentProcess().Kill();
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

        private void StudentMenu_Load(object sender, EventArgs e) { }

        private void BtnShowDetails_Click(object sender, EventArgs e)
        {
            StudentDetails studentDetailsFrm = new StudentDetails();
            studentDetailsFrm.Show();
            Hide();
        }

        private void BtnTakeExam_Click(object sender, EventArgs e)
        {
            new ChooseExam().Show();
            Hide();
        }

        private void BtnShowGrades_Click(object sender, EventArgs e)
        {
            StudentGrades studentGradesFrm = new StudentGrades();
            studentGradesFrm.Show();
            Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
