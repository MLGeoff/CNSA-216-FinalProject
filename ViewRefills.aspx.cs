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

        protected void lbtnEdit_Click(object sender, CommandEventArgs e)
        {
            
            string recordToBeEdited;
            Int64 myEditedRecord = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
               
                

                recordToBeEdited = (e.CommandArgument.ToString().Trim()); //encrypt this

                //EncryptQueryString(recordToBeEdited);

                
                sb.Append("<script language='javascript'>");
                //EncryptQueryString(recordToBeEdited.ToString());
                sb.Append("window.open('EditRefills.aspx?ID=" + recordToBeEdited + "&type=Edit" + "' , 'DisplayEdit',");
                //decryptQueryString(recordToBeEdited);
                sb.Append("'width=525, height=525, menubar=no, resizable=yes, left=50, top=50, scrollbars=yes');<");
                sb.Append("/script>");
                
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "PopupScript", sb.ToString());
            }
            catch (Exception ex)
            {
               lblException.Text = ex.Message.ToString();
            }
        }
        protected void Delete_Click(object sender, CommandEventArgs e)
        {
            try
            {
               
                string date = "";
                date = (e.CommandArgument.ToString().Trim());
                PatientDataTier ptd = new PatientDataTier();
                Cache.Remove("StudentData");
               
                            ptd.deleteRefill(date);
              
              
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message.ToString();
            }
        }
        private void BindData()
        {
            PatientDataTier aDatatier = new PatientDataTier();

            string date = Convert.ToString(Session["date"]);
           

            

            if ((date.Length > 0))
            {
                DataSet aDataset = new DataSet();
                aDataset = aDatatier.SHOWBYDATE(date);
                if (aDataset.Tables[0].Rows.Count > 0)
                {
                    grdViewRefills.Visible = true;
                    grdViewRefills.DataSource = aDataset.Tables[0];


                    if (Cache["StudentData"] == null)
                    {
                        Cache.Add("StudentData", new DataView(aDataset.Tables[0]), null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                            System.TimeSpan.FromMinutes(10), System.Web.Caching.CacheItemPriority.Default, null);
                        grdViewRefills.DataBind();
                    }
                }
                else
                {
                    grdViewRefills.Visible = false;
                }
            }  
            else
            {
                grdViewRefills.Visible = false;
            }
        }

    }
}