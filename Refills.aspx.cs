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
    public partial class Refills : System.Web.UI.Page
    {
        public string EncryptQueryString(string recordToBeEdited) {

            Encryption64 oES = new Encryption64();

                return oES.Encrypt(recordToBeEdited,"!#$a54?3");
            
        }

        public string decryptQueryString(string recordToBeEdited) {

            Encryption64 oES = 
            new Encryption64();

                return oES.Decrypt(recordToBeEdited,"!#$a54?3");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        

            if (!IsPostBack)
            {

                string queryID = Request.QueryString["ID"];


                if (String.IsNullOrEmpty(queryID))
                {
                    Response.Redirect("Table.aspx");
                }
                else if (queryID.Trim().ToUpper() == "NEW")
                {

                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "VIEW")
                {
                    BindData(queryID.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else if (Request.QueryString["type"].Trim().ToUpper() == "EDIT")
                {
                    BindData(queryID.Trim(), Request.QueryString["type"].Trim().ToUpper());
                }
                else
                {
                    Response.Redirect("Table.aspx");
                }
            }
        }

       public void btnAdd_Click(object sender, CommandEventArgs e)
        {
                //string rx;
                //rx = (e.CommandArgument.ToString().Trim());

                Session["rx"] = (e.CommandArgument.ToString().ToString());
                Server.Transfer("AddRefills.aspx");
        }


        public void BindData(string pat_ID, string type)
        {
            PatientDataTier patDT = new PatientDataTier();

            //string myID = Convert.ToString(Session["vPATID"]);
             DataSet aDataset = new DataSet();
                aDataset = patDT.SHOWREFILLSBYPATID(pat_ID);
            

           
                if (aDataset.Tables[0].Rows.Count > 0)
                {
                    grdRefills.Visible = true;
                    grdRefills.DataSource = aDataset.Tables[0];
                    grdRefills.DataBind();
                }
                else
                {
                    grdRefills.Visible = false;
                }
           
        }

        protected void grdRefills_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        






    }
}