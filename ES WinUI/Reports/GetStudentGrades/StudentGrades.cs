using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.MainForms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System.Reports.GetStudentGrades
{
    public partial class StudentGrades : MaterialForm
    {
        public StudentGrades()
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

        private void StudentGradesDept_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbStudentID.Text))
            {
                new StudentGradesReportViewer(int.Parse(tbStudentID.Text)).Show();
            }
            else
            {
                MessageBox.Show("Please Enter Student ID");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new ReportsMenu().Show();
        }
    }
}
