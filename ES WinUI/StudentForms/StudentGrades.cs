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

namespace Examination_System
{
    public partial class StudentGrades : MaterialForm
    {

        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;

        public StudentGrades()
        {
            InitializeComponent();
            InitForm();

            SqlCN = new SqlConnection(
             "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true");
           

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = SqlCN;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "getGradesWithID";
            sqlCmd.Parameters.AddWithValue("std_id", User.UserID);

            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();

            DA.Fill(DT);

            dataGridView1.DataSource = DT;
            dataGridView1.Columns["cName"].HeaderText = "Course Name";
            dataGridView1.Columns["grade"].HeaderText = "Grade";

            dataGridView1.Columns["grade"].ReadOnly= true;
            dataGridView1.Columns["cName"].ReadOnly = true;

            dataGridView1.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.ForeColor = Color.Black;
                col.DefaultCellStyle.ForeColor = Color.Black;
            }
            

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


        private void StudentGrades_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentMenu().Show();
        }
    }
}
