
using System.Configuration;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBManager : IDisposable
    {
        private SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable DT;

        public DBManager()
        {
            try
            {
                sqlCn = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSytem;Integrated Security = true;");
                sqlCmd = new SqlCommand("", sqlCn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new SqlDataAdapter(sqlCmd);
                DT = new DataTable();
            }
            catch (Exception ex)
            {
                //Log Exception
            }
        }

        #region Basic Methods
        public int ExecuteNonQuery(string SPName)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteNonQuery();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }
        public object ExecuteScaler(string SPName)
        {
            object R = new object();
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteScalar();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }
        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                DT.Clear();
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                sqlDA.Fill(DT);
                return DT;
            }
            catch (Exception ex)
            {

            }
            return new DataTable();
        }
        public int ExecuteNonQuery(string SPName, Dictionary<string, object> Parms)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();

                foreach (var item in Parms)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteNonQuery();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }
        public object ExecuteScaler(string SPName, Dictionary<string, object> Parms)
        {
            object R = new object();

            try
            {
                sqlCmd.Parameters.Clear();

                foreach (var item in Parms)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteScalar();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }


            return R;
        }
        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> Parms)
        {
            try
            {
                DT.Clear();
                sqlCmd.Parameters.Clear();

                foreach (var item in Parms)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = SPName;

                sqlDA.Fill(DT);
                return DT;
            }
            catch
            {

            }
            return new DataTable();
        }

        # endregion
        public void Dispose()
        {
            try
            {
                sqlCn?.Dispose();
            }
            catch
            {

            }
        }
    }
}