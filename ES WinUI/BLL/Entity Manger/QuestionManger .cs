
using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class QuestionManger
    {
        static DBManager dBmanager = new DBManager();
        public static QuestionList selectAllQuestionsOfCourse(int cID)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CId"] = cID,
            };
            return dataTable2QuestionList(
                dBmanager.ExecuteDataTable("GetQuestionsWithChoices", Params));
        }
        public static QuestionList selectAllTFQuestionsOfCourse(int cID)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>()
            {
                ["CID"] = cID,
            };
            return dataTable2QuestionListTF(
                dBmanager.ExecuteDataTable("GetTFQuestionForCourse", Params));
        }
        public static int UpdateQuestion(Question question)
        {
            UpdateQuestionGeneric(question);
            Dictionary<string, object> ChParams = new Dictionary<string, object>()
            {
                ["q_ID"] = question.QID,
                ["choice1"] = question.Choice1,
                ["choice2"] = question.Choice2,
                ["choice3"] = question.Choice3,
                ["choice4"] = question.Choice4,
         
            };
       
            return dBmanager.ExecuteNonQuery("updateChoices", ChParams);

        }
        public static int UpdateQuestionGeneric(Question question)
        {

         
            Dictionary<string, object> QParams = new Dictionary<string, object>()
            {
                ["questionID"] = question.QID,
                ["questionText"] = question.QName,
                ["answer"] = question.Ans,
                ["qType"] = question.Type
            };
            
            return dBmanager.ExecuteNonQuery("updateQuestion", QParams);

        }

        public static int InsertIntoQuestion(Question question ,int cID)
        {
            InsertIntoQuestiongeneric(question,cID);

            Dictionary<string, object> ChParams = new Dictionary<string, object>()
            {
                ["q_ID"] = question.QID,
                ["choice1"] = question.Choice1,
                ["choice2"] = question.Choice2,
                ["choice3"] = question.Choice3,
                ["choice4"] = question.Choice4,

            };
            return dBmanager.ExecuteNonQuery("InsertChoices", ChParams);
        }
        public static int InsertIntoQuestiongeneric(Question question ,int cId)
        {
           
            Dictionary<string, object> QParams = new Dictionary<string, object>()
            {
                ["questionText"] = question.QName,
                ["answer"] = question.Ans,
                ["qType"] = question.Type,
                ["CID"] = cId,

            };
            return dBmanager.ExecuteNonQuery("insertQuestion", QParams);
        }


        public static int DeleteQuestionByID(int qID)
        {
            Dictionary<string, object> Params = new Dictionary<string, object>() { ["questionID"] = qID };
            return dBmanager.ExecuteNonQuery("deleteQuestion", Params);
        }
        public static QuestionList dataTable2QuestionList(DataTable DT)
        {
            QuestionList qLst = new QuestionList();

            try
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    qLst.Add(dataRow2Question(DT.Rows[i]));

                }
            }
            catch (Exception ex)
            {

            }

            return qLst;
        }

        public static Question dataRow2Question(DataRow DR)
        {
            Question question = new Question();
            try
            {

                question.Ans = DR["answer"].ToString()[0];
                question.Choice1 = DR["choice1"].ToString();
                question.Choice2 = DR["choice2"].ToString();
                question.Choice3 = DR["choice3"].ToString();
                question.Choice4 = DR["choice4"].ToString();
                question.QName = DR["questionText"].ToString();
                question.Type = DR["qType"].ToString();
            

                if (int.TryParse(DR["questionID"]?.ToString(), out int tmpMoney))
                    question.QID = tmpMoney;


                question.EntityState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {

            }
            return question;
        }
        public static QuestionList dataTable2QuestionListTF(DataTable DT)
        {
            QuestionList qLst = new QuestionList();

            try
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    qLst.Add(dataRow2QuestionTF(DT.Rows[i]));

                }
            }
            catch (Exception ex)
            {

            }

            return qLst;
        }

        public static Question dataRow2QuestionTF(DataRow DR)
        {
            Question question = new Question();
            try
            {

                question.Ans = DR["answer"].ToString()[0];
                question.QName = DR["questionText"].ToString();
                question.Type = DR["qType"].ToString();


                if (int.TryParse(DR["questionID"]?.ToString(), out int tmpMoney))
                    question.QID = tmpMoney;


                question.EntityState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {

            }
            return question;
        }
    }
}

