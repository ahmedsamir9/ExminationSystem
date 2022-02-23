using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    class InstructorInCourseManger
    {
        static DBManager dBmanager = new DBManager();
        public static InstructorCourseList selectAllInstructors(int Crs_id)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CrsID"] = Crs_id,
            };
            return dataTable2InsCrsList(dBmanager.ExecuteDataTable("GetAllInstructorsForCourse", Params));
        }
        public static int addStudentToCourse(int cID, int sID, int state)
        {

            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CID"] = cID,
                ["InsID"] = sID,
                ["STATE"] = state,
            };
            return dBmanager.ExecuteNonQuery("AddRelationInstructorToCourse", Params);
        }
        public static InstructorCourseList dataTable2InsCrsList(DataTable DT)
        {
            InstructorCourseList InsCrsList = new InstructorCourseList();

            try
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    InsCrsList.Add(dataRow2InsCrs(DT.Rows[i]));

                }
            }
            catch (Exception ex)
            {

            }

            return InsCrsList;
        }

        public static InstructorInCourse dataRow2InsCrs(DataRow DR)
        {
            InstructorInCourse insCrs = new InstructorInCourse();
            try
            {
                if (int.TryParse(DR["id"]?.ToString(), out int id))
                    insCrs.ID = id;

                insCrs.FullName = DR["fullName"].ToString();

                insCrs.Email = DR["email"].ToString();
                Console.WriteLine("sssssssssssssssssssssssssssss" + DR["Assign"]?.ToString());
                int satet = int.Parse(DR["Assign"]?.ToString());
                    insCrs.Assigned = satet == 1? true : false;

                insCrs.EntityState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {

            }
            return insCrs;
        }
    }
}
