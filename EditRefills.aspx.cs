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
    public partial class EditRefills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string phy_id = "";
            string gender;

            if (!IsPostBack)
            {

                
                string queryDate = (Request.QueryString["Date"]);


                if (String.IsNullOrEmpty(queryDate))
                {
                    Response.Redirect("ViewRefills.aspx");
                }
                else if (queryDate.Trim().ToUpper() == "NEW")
                {

                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "VIEW")
                {
                    GetRefill(queryDate.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "EDIT")
                {
                    GetRefill(queryDate.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else
                {
                    Response.Redirect("ViewRefills.aspx");
                }
            }
        }
        public void GetRefill(string date_refill, string type)
        {
            PatientDataTier phyDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string gender;

            //Home record = new Home();
            //DataSet recordTBE = new DataSet();
            //string recordToBeEdited = recordToBeEdited;

            //record.decryptQueryString(recordToBeEdited.ToString());

            ds = phyDT.SHOWBYDATE(date_refill);

            if (ds.Tables[0].Rows.Count > 0)
            {
              

                txtRXNumber.Text = ds.Tables[0].Rows[0]["rx_number"].ToString();
                txtDateRefill.Text = ds.Tables[0].Rows[0]["date_refill"].ToString();
                textAmount.Text = ds.Tables[0].Rows[0]["amount"].ToString();
                


                
                
                if (type.ToUpper() == "EDIT")
                {
                    txtRXNumber.Enabled = false;
                    txtDateRefill.Enabled = true;
                    textAmount.Enabled = true;
                    
                    
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
            Server.Transfer("ViewRefills.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}