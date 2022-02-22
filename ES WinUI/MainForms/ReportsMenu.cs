﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.InstructorForms;
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


        private void ReportsMenu_Load(object sender, EventArgs e)
        {

        }

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

        }
    }
}
