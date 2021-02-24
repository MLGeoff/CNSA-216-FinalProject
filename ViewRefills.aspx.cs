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

namespace DataBase
{
    public partial class ViewRefills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            

            if (!IsPostBack)
            {

                string queryRX = Request.QueryString["ID"];


                if (String.IsNullOrEmpty(queryRX))
                {
                    Response.Redirect("Refills.aspx");
                }
                else if (queryRX.Trim().ToUpper() == "NEW")
                {

                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "VIEW")
                {
                    BindData(queryRX.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "EDIT")
                {
                    BindData(queryRX.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else
                {
                    Response.Redirect("Refills.aspx");
                }
            }
        }
        public void BindData(string rx_number, string type)
        {
            PatientDataTier patRX = new PatientDataTier();

            //string myID = Convert.ToString(Session["vPATID"]);
             DataSet aDataset = new DataSet();
                aDataset = patRX.VIEWREFILLSBYPATID(rx_number);
            

           
                if (aDataset.Tables[0].Rows.Count > 0)
                {
                    grdViewRefills.Visible = true;
                    grdViewRefills.DataSource = aDataset.Tables[0];
                    grdViewRefills.DataBind();
                }
                else
                {
                    grdViewRefills.Visible = false;
                }
           
        }




    }
}