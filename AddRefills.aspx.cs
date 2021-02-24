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
    public partial class AddRefills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAdded.Text = "";
            txtRX_NUMBER.Text = Session["rx"].ToString();
            txtDATE_REFILL.Text = DateTime.Now.ToString();
            txtDATE_REFILL.Enabled = false;
            txtRX_NUMBER.Enabled = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try {

            PatientDataTier patDT = new PatientDataTier();
            DataSet ds = new DataSet();
            string rx_number = txtRX_NUMBER.Text;
            string date_refill = txtDATE_REFILL.Text;
            string amount = txtAMOUNT.Text;



            patDT.ADDREFILL(rx_number, date_refill, amount);
                lblAdded.Text = "Refill Added!";
            }
            catch (Exception ex){
                
    lblException.Text = ex.Message.ToString();
            }

        }
        

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Server.Transfer("Refills.aspx");
        }





    }
}