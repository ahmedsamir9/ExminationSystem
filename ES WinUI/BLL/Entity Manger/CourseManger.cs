
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CourseManger
    {
        static DBManager dBmanager = new DBManager();
        public static CourseList selectAllCourseOfInstructor(int ins_id)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            { 
                ["ins_id"] = ins_id,
            };
            return dataTable2CourseList(
                dBmanager.ExecuteDataTable("GetCoursesOfInstructor",Params));
        }

        public static int UpdateCourseByID(int id, string name,int duration)
        {

            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["cID"] = id,
                ["cName"] = name,
                ["duration"] = duration,
            };

            return dBmanager.ExecuteNonQuery("updateCourse", Params);

        }

        public static int InsertIntoCourse(string name,int duration)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["cName"] = name,
                ["duration"] = duration,
            };

            return dBmanager.ExecuteNonQuery("insertCourse", Params);
        }
        public static int InsertCourseIntoInstructor(int cId, int insId)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["crs_ID"] = cId,
                ["ins_ID"] = insId,
            };

            return dBmanager.ExecuteNonQuery("insertIns_Crs", Params);
        }

        public static int DeleteCourseByID(int course_id)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>() { ["courseID"] = course_id };
            return dBmanager.ExecuteNonQuery("deleteCourse", Params);
        }
        public static CourseList dataTable2CourseList(DataTable DT)
        {
            CourseList cLst = new CourseList();

            try
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cLst.Add(dataRow2Course(DT.Rows[i]));

                }
            }
            catch (Exception ex)
            {

            }

            return cLst;
        }

        public static Course dataRow2Course(DataRow DR)
        {
            Course course = new Course();
            try
            {
             
                course.CName = DR["cName"].ToString();

                if (int.TryParse(DR["cID"]?.ToString(), out int tmpMoney))
                    course.CId = tmpMoney;

                if (int.TryParse(DR["duration"]?.ToString(), out tmpMoney))
                    course.Duration = tmpMoney;

                course.EntityState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {

            }
            return course;
        }
    }
}
