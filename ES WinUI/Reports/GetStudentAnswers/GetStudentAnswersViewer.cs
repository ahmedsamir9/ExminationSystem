using Examination_System.Reports.GetStudentAnswers;
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

namespace Examination_System.Reports
{
    public partial class GetStudentAnswersViewer : Form
    {
        SqlConnection sqlCn = new SqlConnection(
            "Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security=true"
        );
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;
        public int ExamID { get; set; }
        public int StdID { get; set; }

        public GetStudentAnswersViewer(int _StdID, int _ExamID)
        {
            ExamID = _ExamID;
            StdID = _StdID;
            InitializeComponent();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "getQuestionWithStudentAnswer";
            sqlCmd.Parameters.AddWithValue("STD_ID", StdID);
            sqlCmd.Parameters.AddWithValue("EXAM_ID", ExamID);

            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();

            DA.Fill(DT);

            StudentAnswerReport myReportDocument = new StudentAnswerReport();
            myReportDocument.SetDataSource(DT);
            myReportDocument.SetDatabaseLogon("sa", "1234"); //
            crystalReportViewer1.ReportSource = myReportDocument;
            crystalReportViewer1.DisplayToolbar = true;
        }

        private void StudentDetailsinDeptViewer_Load(object sender, EventArgs e) { }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
