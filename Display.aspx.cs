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
    public partial class Display : System.Web.UI.Page
    {

        public string decryptQueryString(string recordToBeEdited) {

            Encryption64 oES = 
            new Encryption64();

                return oES.Decrypt(recordToBeEdited,"!#$a54?3");
        }

        

        protected void Page_Load(object sender, EventArgs e)
        {
            string pat_id = "";
            string gender;

            if (!IsPostBack)
            {

                string queryID = decryptQueryString(Request.QueryString["ID"]); 


                if (String.IsNullOrEmpty(queryID))
                {
                    Response.Redirect("Table.aspx");
                }
                else if (queryID.Trim().ToUpper() == "NEW")
                {

                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "VIEW")
                {
                    GetPatient(queryID.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "EDIT")
                {
                    GetPatient(queryID.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else
                {
                    Response.Redirect("Table.aspx");
                }
            }
        }
        public void GetPatient(string pat_ID, string type)
        {
            PatientDataTier patDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string gender;

            //Home record = new Home();
            //DataSet recordTBE = new DataSet();
            //string recordToBeEdited = recordToBeEdited;

            //record.decryptQueryString(recordToBeEdited.ToString());

            ds = patDT.SHOWALLBYPATID(pat_ID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DateTime dateConvert = DateTime.Parse(ds.Tables[0].Rows[0]["dob"].ToString());

                txtStuID.Text = ds.Tables[0].Rows[0]["pat_ID"].ToString();
                txtFName.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                txtLName.Text = ds.Tables[0].Rows[0]["lname"].ToString();
                txtDOB.Text = dateConvert.ToShortDateString().ToString();
                //txtSalary.Text = ds.Tables[0].Rows[0]["salary"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["pat_address"].ToString();
                txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                textMiddleInitial.Text = ds.Tables[0].Rows[0]["midint"].ToString();
                textZipCode.Text = ds.Tables[0].Rows[0]["zip"].ToString();
                textInsurance.Text = ds.Tables[0].Rows[0]["insurance"].ToString();
                textEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                textPhone.Text = ds.Tables[0].Rows[0]["phone"].ToString();


                gender = ds.Tables[0].Rows[0]["gender"].ToString().Trim();
                if (gender.ToUpper() == "FEMALE")
                {
                    ddlGender.SelectedItem.Text = "Female";
                }
                else
                {
                    ddlGender.SelectedItem.Text = "Male";
                }
                //ddlGender.Enabled = false;
                ddlState.DataSource = StateManager.getStates();
                ddlState.DataTextField = "FullAndAbbrev";
                ddlState.DataValueField = "Abbreviation";
                ddlState.SelectedValue = "PA";
                ddlState.DataBind();

                ddlState.SelectedValue = ds.Tables[0].Rows[0]["pat_state"].ToString();
                if (type.ToUpper() == "VIEW" )
                {
                    txtStuID.Enabled = false;
                    txtFName.Enabled = false;
                    txtLName.Enabled = false;
                    txtDOB.Enabled = false;
                    txtAddress.Enabled = false;
                    txtCity.Enabled = false;
                    textEmail.Enabled = false;
                    textInsurance.Enabled = false;
                    textMiddleInitial.Enabled = false;
                    textPhone.Enabled = false;
                    textZipCode.Enabled = false;
                    //txtSalary.Enabled = false;
                    ddlGender.Enabled = false;
                    ddlState.Enabled = false;
                    btnSave.Visible = false;
                    btnClose.Visible = false;
                }
                else if (type.ToUpper() == "EDIT")
                {
                    txtStuID.Enabled = false;
                    txtFName.Enabled = true;
                    txtLName.Enabled = true;
                    txtDOB.Enabled = true;
                    txtAddress.Enabled = true;
                    txtCity.Enabled = true;
                   // txtSalary.Enabled = true;
                    ddlGender.Enabled = false;
                    ddlState.Enabled = true;
                    btnSave.Visible = true;
                    btnClose.Visible = true;
                    btnSave.Text = "UPDATE";
                    btnClose.Text = "REFRESH";
                    btnSave.ForeColor = Color.Red;
                    btnClose.ForeColor = Color.Blue;
                }
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {

            PatientDataTier patDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string pat_ID = txtStuID.Text;
            string fname = txtFName.Text;
            string midinit = textMiddleInitial.Text;
            string lname = txtLName.Text;
            //decimal salary = decimal.Parse(txtSalary.Text);
            string gender = ddlGender.Text;
            string pat_state = ddlState.Text;
            string dob = (DateTime.Parse(txtDOB.Text.ToString())).ToShortDateString();
            string pat_address = txtAddress.Text;
            string city = txtCity.Text;
            string zip = textZipCode.Text;
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string insurance = textInsurance.Text;

            

            try
            {
                if (btnClose.Text.ToUpper() == "REFRESH")
                {
                    patDT.addPatient(pat_ID,fname,midinit,lname,gender,dob,pat_address,city,pat_state,zip,phone,email,insurance); //add patient with args
                    Session["GRIDREFRESH"] = "REFRESHDGRID";
                    System.Text.StringBuilder cb = new System.Text.StringBuilder();
                    cb.Append(" opener.location.href = 'home.aspx';");
                    cb.Append("var ie7 = (document.all && !window.opera && window.XMLHttpRequest) ? true : false;");
                    cb.Append(" if (ie7)");
                    cb.Append(" { ");
                    cb.Append("window.open('','_parent','');");
                    cb.Append("window.close();");
                    cb.Append(" } ");
                    cb.Append(" else ");
                    cb.Append(" { ");
                    cb.Append(" this.focus();");
                    cb.Append(" self.opener = this;");
                    cb.Append(" self.close();");
                    cb.Append(" } ");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "CloseReloadScript", cb.ToString(), true);
                    
                }
                else //if (btnClose.Text.ToUpper() == "CLOSE")
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "closeform", "CloseMe()", true);
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message.ToString();
            }
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
            string gender = ddlGender.Text;
            string pat_state = ddlState.Text;
            string dob = (DateTime.Parse(txtDOB.Text.ToString())).ToShortDateString();
            string pat_address = txtAddress.Text;
            string city = txtCity.Text;
            string zip = textZipCode.Text;
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string insurance = textInsurance.Text;


            patDT.UPDATEPatient(pat_ID,fname,midinit,lname,gender,pat_state,dob,pat_address,city,zip,phone,email,insurance); //add patient with args
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message.ToString();
            }

        }


      

    }
}