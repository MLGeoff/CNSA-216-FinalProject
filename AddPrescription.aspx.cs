using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Xml;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Web.Configuration;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DataBase
{
    public partial class AddPrescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPATID.Text = Session["patID"].ToString();
            txtPATID.Enabled = false;
            //txtPHYID.Text = "";
            //txtRXNUMBER.Text = "";
            //txtIntakeMethod.Text = "";
            //txtFrequency.Text = "";
            //txtDOSAGE.Text = "";
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Server.Transfer("Table.aspx");
        }

        protected void btnAddPrescription_Click(object sender, EventArgs e)
        {
            
            try {

            PatientDataTier patDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string patid = txtPATID.Text;
            string phyid = txtPHYID.Text;
            string rxnumber = txtRXNUMBER.Text;
            string dosage = txtDOSAGE.Text;
            string frequency = txtFrequency.Text;
            string intakemethod = txtIntakeMethod.Text;

            
            //ds = patDT.QUERYPHYSICIAN(phyid);

                //if (ds !=null) 
                    //{
                    patDT.ADDPRESCRIPTION(patid, phyid, rxnumber, dosage, frequency, intakemethod);
                lblPrescriptionAdded.Text = "Prescription Added!";
                //}
                //else 
                    //{
                    //MessageBox.Show("Please use a valid Physician ID");
                //}
                
                

            
            }
            catch (Exception ex){
                
               lblException.Text = ex.Message.ToString();
            }

        }





    }
}