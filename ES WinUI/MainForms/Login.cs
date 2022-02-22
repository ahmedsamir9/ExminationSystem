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
using Examination_System.InstructorForms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System
{
    public partial class Login : MaterialForm
    {

        SqlConnection sqlCn = new SqlConnection(
          "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlParameter outputPara;
        SqlParameter userTypeOutputPara = new SqlParameter("userType", SqlDbType.NVarChar, 1);

        public Login()
        {
            InitializeComponent();


            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "CheckCredential";
            sqlCmd.Parameters.AddWithValue("userName", tbUsername.Text.ToString());
            sqlCmd.Parameters.AddWithValue("passKey", tbPassword.Text.ToString());

            outputPara = new SqlParameter("isAuth", SqlDbType.Int);
            outputPara.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(outputPara);
            if (sqlCn.State != ConnectionState.Open)
                sqlCn.Open();
            sqlCmd.ExecuteNonQuery();

            if (outputPara.Value.ToString() == "1")
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "GetUserIDAndType";
                sqlCmd.Parameters.AddWithValue("userName", tbUsername.Text.ToString());
                outputPara.ParameterName = "id";
                sqlCmd.Parameters.Add(outputPara);

                userTypeOutputPara.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(userTypeOutputPara);

                sqlCmd.ExecuteNonQuery();
                sqlCn.Close();
                User.UserID = int.Parse(outputPara.Value.ToString());
                User.UserType = userTypeOutputPara.Value.ToString();

                if (User.UserType == "s")
                {
                    StudentMenu studentMenuFrm = new StudentMenu();
                    studentMenuFrm.Show();
                }
                else if (User.UserType == "i")
                {
                    InstructorMenu instructorMenu = new InstructorMenu();
                    instructorMenu.Show();
                }
                Hide();

            }
            else
            {
                MessageBox.Show("The username or the password is incoorect!");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            Hide();
        }
    }
}
