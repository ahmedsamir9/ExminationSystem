using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.MainForms;
using Examination_System.Reports.GetCourseTopics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examination_System.Reports.StDetailsInDeptReport
{
    public partial class GetCourseTopics : MaterialForm
    {
        private MaterialTextBox tbDeptID;
        private MaterialButton btnBack;
        private MaterialButton btnShowReport;

        public GetCourseTopics()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitializeComponent()
        {
            this.tbDeptID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnShowReport = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tbDeptID
            // 
            this.tbDeptID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDeptID.Depth = 0;
            this.tbDeptID.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbDeptID.Hint = "Course ID";
            this.tbDeptID.Location = new System.Drawing.Point(204, 187);
            this.tbDeptID.MaxLength = 50;
            this.tbDeptID.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDeptID.Multiline = false;
            this.tbDeptID.Name = "tbDeptID";
            this.tbDeptID.Size = new System.Drawing.Size(515, 50);
            this.tbDeptID.TabIndex = 0;
            this.tbDeptID.Text = "";
            // 
            // btnShowReport
            // 
            this.btnShowReport.AutoSize = false;
            this.btnShowReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowReport.Depth = 0;
            this.btnShowReport.DrawShadows = true;
            this.btnShowReport.HighEmphasis = true;
            this.btnShowReport.Icon = null;
            this.btnShowReport.Location = new System.Drawing.Point(340, 368);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(243, 41);
            this.btnShowReport.TabIndex = 1;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowReport.UseAccentColor = false;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.DrawShadows = true;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(43, 426);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 43);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // GetCourseTopics
            // 
            this.ClientSize = new System.Drawing.Size(918, 495);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.tbDeptID);
            this.MaximizeBox = false;
            this.Name = "GetCourseTopics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topics in Coruse Report";
            this.Load += new System.EventHandler(this.StudentDetailsinDept_Load);
            this.ResumeLayout(false);

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

        private void StudentDetailsinDept_Load(object sender, EventArgs e) { }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbDeptID.Text))
            {
                new GetCourseTopicsViewer(int.Parse(tbDeptID.Text)).Show();
            }
            else
            {
                MessageBox.Show("Please Enter Department ID");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new ReportsMenu().Show();
        }
    }
}
