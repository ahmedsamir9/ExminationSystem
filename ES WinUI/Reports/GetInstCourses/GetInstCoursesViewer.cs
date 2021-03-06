using Examination_System.Reports.StDetailsInDeptReport;
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

namespace Examination_System.Reports.GetInstCourses
{
    public partial class GetCourseTopicsViewer : Form
    {
        SqlConnection sqlCn = new SqlConnection(
            "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true"
        );
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;
        public int InstID { get; set; }

        public GetCourseTopicsViewer(int _InstID)
        {
            InstID = _InstID;
            InitializeComponent();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETInstructorCourse";
            sqlCmd.Parameters.AddWithValue("insID", InstID);

            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();

            DA.Fill(DT);

            GetInstCoursesReport myReportDocument = new GetInstCoursesReport();
            myReportDocument.SetDataSource(DT);
            myReportDocument.SetDatabaseLogon("sa", "1234"); 
            crystalReportViewer1.ReportSource = myReportDocument;
            crystalReportViewer1.DisplayToolbar = true;
        }

        private void StudentDetailsinDeptViewer_Load(object sender, EventArgs e) { }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
