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

namespace DataBase {

	public class PatientDataTier {
	
		static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;  //don't forget to change student_id to patient_id
		static SqlConnection myConn = new SqlConnection(connString);
		static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

		
		public DataSet GetAllPatients() {
		
			try {
			
				myConn.Open();
				cmdString.Parameters.Clear();
				cmdString.Connection = myConn;
				
				cmdString.CommandType = CommandType.StoredProcedure;
				cmdString.CommandTimeout = 1500;
				cmdString.CommandText = "GetAllPatients";
				
				SqlDataAdapter aAdapter = new SqlDataAdapter();
				aAdapter.SelectCommand = cmdString;
				DataSet aDataset = new DataSet();
				
				aAdapter.Fill(aDataset);
				
				return aDataset;
				
			} catch (Exception ex) {
			
				throw new ArgumentException(ex.Message);
				
			} finally {
			
				myConn.Close();
			
			}
		}
		
		public DataSet GetPatients(string pat_ID, string fname, string lname) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWPATIENT";

                cmdString.Parameters.Add("@pat_id", SqlDbType.VarChar, 6).Value = pat_ID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;

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
		
		public DataSet SHOWALLBYPATID(string pat_ID) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWALLBYPATID";

                cmdString.Parameters.Add("@pat_ID", SqlDbType.VarChar, 6).Value = pat_ID;
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
		
		public void deletePatients(string pat_ID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DELETEPATIENT";
                cmdString.Parameters.Add("@pat_ID", SqlDbType.VarChar, 6).Value = pat_ID;
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

        public void addPatient(string pat_ID,string fname, string midinit, string lname, string gender, string pat_state, string dob, string pat_address,
           string city, string zip, string phone, string email, string insurance)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "ADDPATIENT";

                cmdString.Parameters.Add("@pat_id", SqlDbType.VarChar, 6).Value = pat_ID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@midint", SqlDbType.Char, 1).Value = midinit;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                //cmdString.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                cmdString.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                cmdString.Parameters.Add("@pat_state", SqlDbType.Char, 2).Value = pat_state;
                cmdString.Parameters.Add("@dob", SqlDbType.Date).Value = dob;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@pat_address", SqlDbType.VarChar, 60).Value = pat_address;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmdString.Parameters.Add("@insurance", SqlDbType.VarChar, 50).Value = insurance;

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
        public void UPDATEPatient(string pat_ID,string fname, string midinit, string lname, string gender, string pat_state, string dob, string pat_address,
           string city, string zip, string phone, string email, string insurance)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "UPDATEPATIENT";

                cmdString.Parameters.Add("@pat_id", SqlDbType.VarChar, 6).Value = pat_ID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@midint", SqlDbType.Char, 1).Value = midinit;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                //cmdString.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                cmdString.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                cmdString.Parameters.Add("@pat_state", SqlDbType.Char, 2).Value = pat_state;
                cmdString.Parameters.Add("@dob", SqlDbType.Date).Value = dob;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@pat_address", SqlDbType.VarChar, 60).Value = pat_address;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmdString.Parameters.Add("@insurance", SqlDbType.VarChar, 50).Value = insurance;

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


        public DataSet SHOWREFILLSBYPATID(string pat_ID) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWREFILL";

                cmdString.Parameters.Add("@pat_ID", SqlDbType.VarChar, 6).Value = pat_ID;
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
        public DataSet VIEWREFILLSBYPATID(string rx_number) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "VIEWREFILL";

                cmdString.Parameters.Add("@rx_number", SqlDbType.VarChar, 20).Value = rx_number;
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
        public void ADDREFILL(string rx_number, string date_refill, string amount)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "ADDREFILL";

                cmdString.Parameters.Add("@rx_number", SqlDbType.VarChar, 20).Value = rx_number;
                cmdString.Parameters.Add("@date_refill", SqlDbType.Date).Value = date_refill;
                cmdString.Parameters.Add("@amount", SqlDbType.VarChar, 12).Value = amount;
                

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
        public void ADDPRESCRIPTION(string patid, string phyid, string rxnumber, string dosage, string frequency, string intakemethod)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "ADDPRESCRIPTION";

                cmdString.Parameters.Add("@pat_id", SqlDbType.VarChar, 12).Value = patid;
                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 12).Value = phyid;
                cmdString.Parameters.Add("@rx_number", SqlDbType.VarChar, 20).Value = rxnumber;
                cmdString.Parameters.Add("@dosage", SqlDbType.VarChar, 20).Value = dosage;
                cmdString.Parameters.Add("@frequency", SqlDbType.VarChar, 20).Value = frequency;
                cmdString.Parameters.Add("@intake_method", SqlDbType.VarChar, 20).Value = intakemethod;
                

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
        public void QUERYPHYSICIAN(string phyid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "QUERYPHYSICIAN";

                
                cmdString.Parameters.Add("@phy_id", SqlDbType.VarChar, 12).Value = phyid;
                
                

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
        public DataSet SHOWBYDATE(string date_refill) {
		
			try {
            
                myConn.Open();
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SHOWREFILLBYDATE";

                
                cmdString.Parameters.Add("@date_refill", SqlDbType.VarChar, 25).Value = date_refill;
              

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
        public void deleteRefill(string date)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DELETEREFILL";

                
                cmdString.Parameters.Add("@dare_refill", SqlDbType.VarChar, 12).Value = date;
                
                

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
		
		
		