using Examination_System.MainForms;
using Examination_System.Reports;
using Examination_System.Reports.GetStudentGrades;
using Examination_System.Reports.StDetailsInDeptReport;
using Examination_System.StudentForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }



        public static int userID;

    }
}
