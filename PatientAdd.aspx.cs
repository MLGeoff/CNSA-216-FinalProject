using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using Test;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Web.Configuration;
using System.Web.Security;
using System.Windows.Forms;


namespace DataBase
{
    public partial class PatientAdd : System.Web.UI.Page
    {
        //public string decryptQueryString(string recordToBeEdited) {

        //    Encryption64 oES = 
        //    new Encryption64();

        //        return oES.Decrypt(recordToBeEdited,"!#$a54?3");
        //}

        

        protected void Page_Load(object sender, EventArgs e)
        {
            lblComplete.Text = "";
            if (!Page.IsPostBack)
            {
           ddlState.DataSource = StateManager.getStates();
                ddlState.DataTextField = "FullAndAbbrev";
                ddlState.DataValueField = "Abbreviation";
                ddlState.SelectedValue = "PA";
                ddlState.DataBind();
            }

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("Table.aspx");
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            try {

            PatientDataTier patDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string pat_ID = txtStuID.Text;
            string fname = txtFName.Text;
            string midinit = textMiddleInitial.Text;
            string lname = txtLName.Text;
            //decimal salary = decimal.Parse(txtSalary.Text);
            string gender = ddlGender.SelectedValue.ToString();
            string pat_state = ddlState.SelectedValue.ToString();
            string dob = calendarDOB.SelectedDate.ToString();
            string pat_address = txtAddress.Text;
            string city = txtCity.Text;
            string zip = textZipCode.Text;
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string insurance = textInsurance.Text;



            patDT.addPatient(pat_ID,fname,midinit,lname,gender,pat_state,dob,pat_address,city,zip,phone,email,insurance); //add patient with args
                lblComplete.Text = "Patient Added!";
            }
            catch (Exception ex){
                lblException.Text = ex.Message.ToString();
            }

        }

    }
}