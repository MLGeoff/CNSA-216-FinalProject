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
using MessageBox = System.Windows.Forms.MessageBox;


namespace DataBase
{
    public partial class PhysicianTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptInclude("Test", "MyScript.js");

            grdStudent.RowDataBound += new GridViewRowEventHandler(grdStudent_RowDataBound);
            grdStudent.PageIndexChanging += new GridViewPageEventHandler(grdStudent_PageIndexChanging);
            grdStudent.Sorting += new GridViewSortEventHandler(grdStudent_Sorting);

            if (!IsPostBack)
            {
                Cache.Remove("StudentData");
                BindData();
            }
            else
            {
                if (Convert.ToString(Session["GRIDREFRESH"]) !="") { 

                    BindData();

                }

            }
        }
        public string EncryptQueryString(string recordToBeEdited) {

            Encryption64 oES = new Encryption64();

                return oES.Encrypt(recordToBeEdited,"!#$a54?3");
            
        }

        public string decryptQueryString(string recordToBeEdited) {

            Encryption64 oES = 
            new Encryption64();

                return oES.Decrypt(recordToBeEdited,"!#$a54?3");
        }

        public void Delete_Click(object sender, CommandEventArgs e)
        {
            try
            {
                CheckBox chk = new CheckBox();
                Label lbl = new Label();
                string phyID = "";
                PhysicianDataTier ptd = new PhysicianDataTier();
                Cache.Remove("StudentData");
                if (grdStudent.Rows.Count > 0)           
                {
                    foreach (GridViewRow row in grdStudent.Rows)
                    {
                        chk = (CheckBox)row.FindControl("chkStudentID");
                        if (chk.Checked)
                        {
                            lbl = (Label)row.Controls[0].FindControl("hidStudentID");
                            phyID = lbl.Text.Trim();
                            ptd.deletePhysicians(phyID);
                        }
                    }
                    BindData();
                }
            }
            catch (Exception ex)
            {
                
                lblException.Text = ex.Message.ToString();
            }
        }
        public void lbtnEdit_Click(object sender, CommandEventArgs e)
        {
            string recordToBeEdited;
            Int64 myEditedRecord = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
                Session["vPhyID"] = txtPhysicianID.Text.Trim();
                Session["vFName"] = txtFName.Text.Trim();
                Session["vLName"] = txtLName.Text.Trim();

                recordToBeEdited = (e.CommandArgument.ToString().Trim()); //encrypt this

                //EncryptQueryString(recordToBeEdited);

                
                sb.Append("<script language='javascript'>");
                //EncryptQueryString(recordToBeEdited.ToString());
                sb.Append("window.open('PhysicianDisplay.aspx?ID=" + (recordToBeEdited) + "&type=Edit" + "' , 'DisplayEdit',");
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
        public void btnView_Click(object sender, CommandEventArgs e)
        {
            string recordToBeEdited;
            Int64 myEditedRecord = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
                Session["vPhyID"] = txtPhysicianID.Text.Trim();
                Session["vFName"] = txtFName.Text.Trim();
                Session["vLName"] = txtLName.Text.Trim();

                recordToBeEdited = (e.CommandArgument.ToString().Trim()); //encrypt this

                //EncryptQueryString(recordToBeEdited);

                
                sb.Append("<script language='javascript'>");
                //EncryptQueryString(recordToBeEdited.ToString());
                sb.Append("window.open('PhysicianDisplay.aspx?ID=" + (recordToBeEdited) + "&type=View" + "' , 'DisplayEdit',");
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
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if ((txtPhysicianID.Text.Trim() != "") || (txtFName.Text.Trim() != "") || (txtLName.Text.Trim() != ""))
            {
                try
                {
                    Session["vPhyID"] = txtPhysicianID.Text.Trim();
                    Session["vFName"] = txtFName.Text.Trim();
                    Session["vLName"] = txtLName.Text.Trim();

                    Cache.Remove("StudentData");
                    BindData();
                }
                catch (Exception ex)
                {
                    lblException.Text = ex.Message.ToString();
                }
            }
            else
            {
                grdStudent.Visible = false;
            }
        }
        protected void grdStudent_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            Int32 pageNum = 0;
            pageNum = e.NewPageIndex;
            Paging(pageNum);
        }
        protected void grdStudent_SelectedIndexChanged(object server, EventArgs e)
        {

        }
        protected void grdStudent_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            SortRecords(e.SortExpression);
        }
        protected void grdStudent_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                    ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "')");
            }
        }
        private void BindData()
        {
            PhysicianDataTier aDatatier = new PhysicianDataTier();

            string phyID = Convert.ToString(Session["vPhyID"]);
            string fname = Convert.ToString(Session["vFName"]);
            string lname = Convert.ToString(Session["vLName"]);

            txtPhysicianID.Text = phyID;
            txtFName.Text = fname;
            txtLName.Text = lname;

            if ((phyID.Length > 0) || (fname.Length > 0) || (lname.Length > 0))
            {
                DataSet aDataset = new DataSet();
                aDataset = aDatatier.GetAllPhysicians(phyID, fname, lname);
                if (aDataset.Tables[0].Rows.Count > 0)
                {
                    grdStudent.Visible = true;
                    grdStudent.DataSource = aDataset.Tables[0];


                    if (Cache["StudentData"] == null)
                    {
                        Cache.Add("StudentData", new DataView(aDataset.Tables[0]), null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                            System.TimeSpan.FromMinutes(10), System.Web.Caching.CacheItemPriority.Default, null);
                        grdStudent.DataBind();
                    }
                }
                else
                {
                    grdStudent.Visible = false;
                }
            }  
            else
            {
                grdStudent.Visible = false;
            }
        }
        private void Paging(Int32 page)
        {
            grdStudent.PageIndex = page;
            BindData();
        }
        private void SortRecords(string sortExpress)
        {
            string oldExpression = grdStudent.SortExpression;
            String newExpression = sortExpress;
            String lastValue, theSortField;
            String sortExpression;
            DataView source;
            String theDirection;
            string oldSortExp, newSortExp;
            string wildChar;

            theDirection = "";
            wildChar = " %";

            lastValue = (string)ViewState["sortValue"];
            sortExpression = sortExpress;

            oldSortExp = (string)ViewState["oldSortExpression"];

            if (oldSortExp == sortExpression)
            {
                if (this.sortDir == "desc")
                {
                    this.sortDir = "asc";
                }
                else if (this.sortDir == null)
                {
                    this.sortDir = "asc";
                }
                else if (this.sortDir == "asc")
                {
                    this.sortDir = "desc";
                }
                else
                {
                    this.sortDir = "asc";
                }
            }
            theSortField = (string)ViewState["sortField"];
            source = (DataView)Cache["StudentData"];
            source.Sort = (" " + sortExpression + " " + this.sortDir);

            ViewState["oldSortExpression"] = sortExpress;

            grdStudent.DataSource = source;
            grdStudent.DataBind();
        }
        public string sortDir
        {
            get => (string)ViewState["sortDir"];
            set => ViewState["sortDir"] = value;
        }
        //public void btnRefillView_Click(object sender, CommandEventArgs e)
        //{
        //    string recordToBeEdited;
        //    Int64 myEditedRecord = 0;
        //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //    try
        //    {
        //        Session["vPatID"] = txtPhysicianID.Text.Trim();
                

        //        recordToBeEdited = (e.CommandArgument.ToString().Trim()); //encrypt this

        //        //EncryptQueryString(recordToBeEdited);

                
        //        sb.Append("<script language='javascript'>");
        //        //EncryptQueryString(recordToBeEdited.ToString());
        //        sb.Append("window.open('Refills.aspx?ID=" + recordToBeEdited + "&type=View" + "' , 'DisplayEdit',");
        //        //decryptQueryString(recordToBeEdited);
        //        sb.Append("'width=525, height=525, menubar=no, resizable=yes, left=50, top=50, scrollbars=yes');<");
        //        sb.Append("/script>");
                
        //        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "PopupScript", sb.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex.InnerException);
        //    }
        //}
        //public void btnRefillAdd_Click(object sender, CommandEventArgs e)
        //{
        //    Session["patID"] = (e.CommandArgument.ToString().ToString());
        //    Server.Transfer("AddPrescription.aspx");
        //}

    }
}