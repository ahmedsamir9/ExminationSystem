using BL;
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
    public partial class CourseInstrctorFrom : MaterialForm
    {
        public CourseInstrctorFrom()
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
        InstructorCourseList ICList;
        BindingSource source;
        public int CID { get; set; }
        private void CourseInstrctorFrom_Load(object sender, EventArgs e)
        {
            ICList = InstructorInCourseManger.selectAllInstructors(CID);
            source = new BindingSource();

            source.DataSource = ICList;

            dataGridView1.DataSource = source;

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns["EntityState"].Visible = false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (ICList[i].EntityState == EntityState.Modified)
                {
                    int state = ICList[i].Assigned ? 1 : 0;
                    StudentCourseManger.addStudentToCourse(CID, ICList[i].ID, state);
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            new CouresFrom().Show();
            Hide();
        }
    }
}
