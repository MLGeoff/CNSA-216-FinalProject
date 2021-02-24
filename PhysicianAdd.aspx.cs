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
    public partial class PhysicianAdd : System.Web.UI.Page
    {
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
            Response.Redirect("PhysicianTable.aspx");
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            try {

            PhysicianDataTier patDT = new PhysicianDataTier();
            DataSet ds = new DataSet();
            string phy_ID = txtPhyID.Text;
            string fname = txtFName.Text;
          
            string lname = txtLName.Text;
            //decimal salary = decimal.Parse(txtSalary.Text);
            string gender = ddlGender.SelectedValue.ToString();
            string phy_state = ddlState.SelectedValue.ToString();
            
            string phy_address = txtAddress.Text;
            string city = txtCity.Text;
            string zip = textZipCode.Text;
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string office = textOffice.Text;



            patDT.addPhysician(phy_ID,fname,lname,gender,phy_state,phy_address,city,zip,phone,email,office); 
                lblComplete.Text = "Physician Added!";
            }
            catch (Exception ex){
                lblException.Text = ex.Message.ToString();
            }

        }
    }
}