using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

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

        private void btnLogin_Click(object sender, EventArgs e) { }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.textBox2.Size = new System.Drawing.Size(142, 27);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerFrm = new Register();

            registerFrm.Show();
            Hide();
        }
    }
}
