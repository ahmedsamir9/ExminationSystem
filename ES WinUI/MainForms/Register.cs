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
    public partial class Register : MaterialForm
    {
        SqlConnection sqlCn = new SqlConnection(
         "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true"
        );

        SqlCommand sqlCmd;
        public Register()
        {
            InitializeComponent();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;

            InitForm();
            var materialSkinManager = MaterialSkinManager.Instance;
   
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


        private void Register_Load(object sender, EventArgs e) { }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "insertUser";


                sqlCmd.Parameters.AddWithValue("fName", tbFirstName.Text);
                sqlCmd.Parameters.AddWithValue("lfName", tbLastName.Text);
                sqlCmd.Parameters.AddWithValue("email", tbEmail.Text);
                sqlCmd.Parameters.AddWithValue("userName", tbUsername.Text);
                sqlCmd.Parameters.AddWithValue("password", tbPassword.Text);

                if (rbMale.Checked)
                {
                    sqlCmd.Parameters.AddWithValue("sex", "M");
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("sex", "F");
                }

                sqlCn.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCn.Close();

                MessageBox.Show("You Registered successfully!");

            } catch(Exception E)
            {
                MessageBox.Show("Error");
                sqlCn.Close();
            }


        }
    }
}
