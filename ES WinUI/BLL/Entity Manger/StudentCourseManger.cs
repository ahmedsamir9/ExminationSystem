using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    class StudentCourseManger
    {
        static DBManager dBmanager = new DBManager();
        public static StudentCourseList selectAllStudents(int Crs_id)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CrsID"] = Crs_id,
            };
            return dataTable2StdCrsList(dBmanager.ExecuteDataTable("GetAllStudentsForCourse", Params));
        }
        public static int addStudentToCourse(int cID ,int sID ,int state) {

            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CID"] = cID,
                ["StID"] = sID,
                ["STATE"] = state,
            };
            return dBmanager.ExecuteNonQuery("AddRelationStudentToCourse", Params);
        }
        public static StudentCourseList dataTable2StdCrsList(DataTable DT)
        {
            StudentCourseList StdCrsList = new StudentCourseList();

            try
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    StdCrsList.Add(dataRow2StdCrs(DT.Rows[i]));

                }
            }
            catch (Exception ex)
            {

            }

            return StdCrsList;
        }

        public static StudentInCourse dataRow2StdCrs(DataRow DR)
        {
            StudentInCourse stdCrs = new StudentInCourse();
            try
            {
                if (int.TryParse(DR["id"]?.ToString(), out int id))
                    stdCrs.ID = id;

                stdCrs.FullName = DR["fullName"].ToString();
                
                stdCrs.Email = DR["email"].ToString();
                Console.WriteLine("SSSSSSSSSSSSSSSSSSSSS"+ DR["enrolled"]?.ToString());
                int state = int.Parse(DR["enrolled"]?.ToString());
                stdCrs.Enrolled = state == 1 ? true : false;

                stdCrs.EntityState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {

            }
            return stdCrs;
        }
    }
}
