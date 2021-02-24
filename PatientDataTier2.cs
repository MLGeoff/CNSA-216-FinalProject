using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;

namespace DataBase
{
    public class StudentDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public DataSet GetAllStudents()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllStudents";

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        public DataSet GetStudents(string myid, string fname, string lname)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SEARCHSTUDENTS";

                cmdString.Parameters.Add("@student_id", SqlDbType.VarChar, 6).Value = myid;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        public DataSet GetStudentByID(string studentid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetByStudentID";

                cmdString.Parameters.Add("@student_id", SqlDbType.VarChar, 6).Value = studentid;
                //cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                //cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        public void deleteStudents(string studentID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeleteStudentByID";
                cmdString.Parameters.Add("@student_id", SqlDbType.VarChar, 6).Value = studentID;
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        public void SaveStudent(string student_id, string fname, string lname, decimal salary, string gender, string state, string dob)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "UpdateByStudentID";

                cmdString.Parameters.Add("@student_id", SqlDbType.VarChar, 6).Value = student_id;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                cmdString.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                cmdString.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                cmdString.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
                cmdString.Parameters.Add("@dob", SqlDbType.Date).Value = dob;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }








    }
}