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
    public partial class ExamGenerator : MaterialForm
    {
        public ExamGenerator()
        {
            InitializeComponent();
            InitForm();
        }
        public int CID { get; set; }
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
        private void ExamGenerator_Load(object sender, EventArgs e)
        {

        }
        int mcqCount = -1, tfCount = -1;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMCQNum.Text.ToString(), out int temp))
                mcqCount = temp;
            if (int.TryParse(txtMCQNum.Text.ToString(), out temp))
                tfCount = temp;
            if (mcqCount == -1 || tfCount== -1 || ((mcqCount + tfCount) > 10 || (mcqCount + tfCount) < 10))
            {
                MessageBox.Show("enter valid values"
                                , "Generate Exam Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                CourseManger.geneterateExamForCourse(CID, mcqCount, tfCount);
                new CouresFrom().Show();
                Hide();
            }
        }
        }
    }