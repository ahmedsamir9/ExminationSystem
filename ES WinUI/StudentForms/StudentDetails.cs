using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System
{
    public partial class StudentDetails : MaterialForm
    {
        SqlConnection sqlCn = new SqlConnection(
            "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true"
        );
        SqlCommand sqlCmd;

        public StudentDetails()
        {
            InitializeComponent();
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;

            FormClosed += (seneder, e) => Process.GetCurrentProcess().Kill();

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

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GetStudentDEtails";
            sqlCmd.Parameters.AddWithValue("st_id", User.UserID);

            sqlCn.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                tbID.Text = reader["id"].ToString();
                tbFirstName.Text = reader["firstName"].ToString();
                tbLastName.Text = reader["lastName"].ToString();
                tbEmail.Text = reader["email"].ToString();
                tbUsername.Text = reader["userName"].ToString();
                tbPassword.Text = reader["passKey"].ToString();
                tbSex.Text = reader["sex"].ToString();
                tbDeptID.Text = reader["depID"].ToString();
                tbGYear.Text = reader["gradYear"].ToString();
            }

            reader.Close();
            sqlCn.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "UpdateUser";

                sqlCmd.Parameters.AddWithValue("id", int.Parse(tbID.Text));
                sqlCmd.Parameters.AddWithValue("firstName", tbFirstName.Text);
                sqlCmd.Parameters.AddWithValue("lastName", tbLastName.Text);
                sqlCmd.Parameters.AddWithValue("email", tbEmail.Text);
                sqlCmd.Parameters.AddWithValue("userName", tbUsername.Text);
                sqlCmd.Parameters.AddWithValue("passKey", tbPassword.Text);
                sqlCmd.Parameters.AddWithValue("depID", int.Parse(tbDeptID.Text));

                sqlCn.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                sqlCn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentMenu().Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
