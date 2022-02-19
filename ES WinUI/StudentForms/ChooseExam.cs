using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System.StudentForms
{
    public partial class ChooseExam : MaterialForm
    {

        SqlConnection sqlCn = new SqlConnection(
        "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlDataAdapter DAExams;
        DataTable DTExams;
        public ChooseExam()
        {
            InitializeComponent();

            InitForm();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GetAviExams";
            sqlCmd.Parameters.AddWithValue("STD_ID", User.UserID);// edit this with the exam ID after then.

            DAExams = new SqlDataAdapter(sqlCmd);
            DTExams = new DataTable();

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

        private void ChooseExam_Load(object sender, EventArgs e)
        {
            DAExams.Fill(DTExams);

            foreach (DataRow i in DTExams.Rows)
            {
                cbExams.Items.Add(i["cName"].ToString());
            }
        }

        private void BtnTakeExam_Click(object sender, EventArgs e)
        {
            Hide();

            
            DataRow row = DTExams.Rows[int.Parse(cbExams.SelectedIndex.ToString())];
            var exam = new Exam(Convert.ToInt32(row["Exam_ID"]));
            exam.Show();
        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
