using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;


namespace DataBase
{
    public class PhysicianDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;  //don't forget to change student_id to patient_id
		static SqlConnection myConn = new SqlConnection(connString);
		static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();
		
        public DataSet GetAllPhysicians(string phyid, string fname, string lname) {

            try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWPHYSICIAN";

                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 6).Value = phyid;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                //cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                //cmdString.Parameters.Add("@office_name", SqlDbType.VarChar, 70).Value = office;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
				
            } catch (Exception ex) {
            
                throw new ArgumentException(ex.Message);
            }
			
            finally {
            
                myConn.Close();
            }

        }

        public DataSet DeletePhysicians(string phy_id) {

            try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DELETEPHYSICIAN";

                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 6).Value = phy_id;
                
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
				
            } catch (Exception ex) {
            
                throw new ArgumentException(ex.Message);
            }
			
            finally {
            
                myConn.Close();
            }

        }

        public DataSet UpdatePhysician(string phy_id, string fname, string lname, string phone, string office) {

            try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "UPDATEPHYSICIAN";

                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 6).Value = phy_id;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@office_name", SqlDbType.VarChar, 70).Value = office;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
				
            } catch (Exception ex) {
            
                throw new ArgumentException(ex.Message);
            }
			
            finally {
            
                myConn.Close();
            }

        }
        public DataSet SHOWALLBYPHYID(string phy_ID) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWALLBYPHYID";

                cmdString.Parameters.Add("@phy_ID", SqlDbType.VarChar, 6).Value = phy_ID;
                //cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                //cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                aAdapter.Fill(aDataSet);

                return aDataSet;
				
            } catch (Exception ex) {
            
                throw new ArgumentException(ex.Message);
            }
			
            finally {
            
                myConn.Close();
            }
		}
        public void addPhysician(string phy_ID,string fname, string lname, string gender, string phy_state, string phy_address, string city, string zip, string phone, string email, string office)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "ADDPHYSICIAN";

                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 6).Value = phy_ID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                //cmdString.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                cmdString.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                cmdString.Parameters.Add("@phy_state", SqlDbType.Char, 2).Value = phy_state;
               
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@phy_address", SqlDbType.VarChar, 60).Value = phy_address;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmdString.Parameters.Add("@office_name", SqlDbType.VarChar, 50).Value = office;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                myConn.Close();
            }
        }
        public void UPDATEPhysician(string phy_ID,string fname, string lname, string gender, string phy_address, string city, string phy_state, string zip, string phone, string email, string office)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "UPDATEPhysician";

                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 6).Value = phy_ID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                //cmdString.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                cmdString.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                cmdString.Parameters.Add("@phy_state", SqlDbType.Char, 2).Value = phy_state;
               
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@phy_address", SqlDbType.VarChar, 60).Value = phy_address;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmdString.Parameters.Add("@office_name", SqlDbType.VarChar, 50).Value = office;

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
        public void deletePhysicians(string phy_ID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DELETEPhysician";
                cmdString.Parameters.Add("@phy_ID", SqlDbType.VarChar, 6).Value = phy_ID;
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