using Examination_System.MainForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.InstructorForms
{
    public partial class InstructorMenu : MaterialForm
    {
        public InstructorMenu()
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
        private void InstructorMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            InstructorDetails instructorDetails = new InstructorDetails();
            instructorDetails.Show();
            Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CouresFrom cf = new CouresFrom();
            cf.Show();
            Hide();
        }

        private void btnAssignStudent_Click(object sender, EventArgs e)
        {
            new ReportsMenu().Show();
            Hide();
        }
    }
}
