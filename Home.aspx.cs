using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Home : System.Web.UI.Page
    {

        //static string loginConnectionString = @"Data source=WERNER-SERVER; initial catalog=LouisUsers; Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            addLink.Enabled = false;
            staffDir.Enabled = false;
            btnClear.Enabled = true;
            btnLogin.Enabled = true;
        }

        //public static void Show(this Page Page, String Message) {

        //    Page.ClientScript.RegisterStartupScript(
        //        Page.GetType(),
        //        "MessageBox",
        //        "<script language='javascript'>alert('" + Message + "');</script>"
        //        );

        //}

        protected void buttonLogIn_Click(object sender, EventArgs e)   //checks the LouisUsers database for username and password to log in with
        {
            

        }

        //protected void txtUsername_TextChanged(object sender, EventArgs e)
        //{

        //    if(String.IsNullOrEmpty(txtUsername.Text))
        //    {
        //        btnLogin.Enabled = false;
        //    }
        //    else
        //    {
        //        btnLogin.Enabled = true;
        //    }


        //    // if (txtusername.text.trim().length > 0)
        //    //{

        //    //    btnclear.enabled = true;
        //    //    btnlogin.enabled = true;



        //    //}
        //    //else
        //    //{
        //    //    btnclear.enabled = false;
        //    //    btnlogin.enabled = false;


        //    //}
        //}

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Login" && txtPassword.Text == "Password")
            {

                addLink.Enabled = true;
                staffDir.Enabled = true;
                //showbox("Login Successful! Welcome to the Louis Pharmacy System.");
                //Show(this ,"test");
                string message = "Login Successful! Welcome to the Louis Pharmacy System.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                 sb.Append("<script type = 'text/javascript'>");
                 sb.Append("window.onload=function(){");
                 sb.Append("alert('");
                 sb.Append(message);
                 sb.Append("')};");
                 sb.Append("</script>");
                 ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
            else
            {

                //MessageBox.Show("Username or Password is Incorrect Please try again", "Pharmacy Management System");
                string message = "Username or Password is Incorrect Please try again.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                 sb.Append("<script type = 'text/javascript'>");
                 sb.Append("window.onload=function(){");
                 sb.Append("alert('");
                 sb.Append(message);
                 sb.Append("')};");
                 sb.Append("</script>");
                 ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtUsername.Focus();

            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "" ;
            txtPassword.Text = "" ;
            txtUsername.Focus();

            addLink.Enabled = false;
            
        }

        //protected void txtPassword_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtPassword.Text.Trim().Length > 0)
        //    {

        //        btnClear.Enabled = true;
        //        btnLogin.Enabled = true;



        //    }
        //    else
        //    {
        //        btnClear.Enabled = false;
        //        btnLogin.Enabled = false;


        //    }
        //}

        //protected void btnExit_Click(object sender, EventArgs e)
        //{
        //    DialogResult Exit;

        //    Exit = MessageBox.Show("Are you sure you want to Exit?", "Pharmacy Management Sytem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (Exit == DialogResult.Yes)
        //    {

        //        System.Web.HttpContext.Current.Response.Write("<script>self.close();</script>");  //maybe possibly hopefully close?
                

        //    }
        //}

        
    }
    }
