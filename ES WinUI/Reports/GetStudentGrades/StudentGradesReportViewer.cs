using MaterialSkin.Controls;
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

namespace Examination_System.Reports.GetStudentGrades
{
    public partial class StudentGradesReportViewer : MaterialForm
    {

        SqlConnection sqlCn = new SqlConnection(
"Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;
        public int Std_ID { get; set; }

        public StudentGradesReportViewer(int _Std_ID)
        {
            Std_ID = _Std_ID;
            InitializeComponent();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETStudentGrades";
            sqlCmd.Parameters.AddWithValue("stuID", Std_ID);

            DA= new SqlDataAdapter(sqlCmd);
            DT= new DataTable();

            DA.Fill(DT);

            StudentGradesReport myReportDocument = new StudentGradesReport();
            myReportDocument.Load(@"StudentGradesDeptReport.rpt");
            myReportDocument.SetDataSource(DT);
            myReportDocument.SetDatabaseLogon("sa", "1234"); 
            crystalReportViewer2.ReportSource = myReportDocument;
            crystalReportViewer2.DisplayToolbar = true;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
