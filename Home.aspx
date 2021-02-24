<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Louis Pharmacy</title>
    
    
    <style type="text/css">
        
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 1013px;
        }
        
        .auto-style4 {
            margin-left: 226px;
        }
        
        </style>
</head>
  =

<body>
    <link rel="stylesheet" href="main.css" />
    <form id="form1" runat="server">
        
        <div>
            <h1>
                Welcome,
                <asp:Label ID="labelDoctorName" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
                            
                            <asp:TextBox ID="txtUsername" runat="server"  ></asp:TextBox> <%--OnTextChanged="txtUsername_TextChanged"--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox> <%--OnTextChanged="txtPassword_TextChanged"--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"  /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                     
                            
                        </td>
                    </tr>
                </table>
            </h1>

        </div>

        <div class="auto-style1">
            
            <asp:HyperLink ID="addLink" runat="server" Text="Add/Edit Patients" NavigateUrl="~/Table.aspx"></asp:HyperLink>
            <asp:HyperLink ID="staffDir" runat="server" Text="Staff Directory" NavigateUrl="~/PhysicianTable.aspx"></asp:HyperLink>
            <%--<a href="#">Staff Directory</a>--%>
            <a href="mailto:techhelp@louisrx.com">Help</a>
            <a href="https://github.com/MLGeoff/CNSA-216-FinalProject/commits/main">About</a>
        </div>

<!-- Page content -->
<div class="main">
  ...
</div>
         <div>
             <asp:ScriptManager runat="server"></asp:ScriptManager>
             <p style="font-size:18px;" class="auto-style4">Louis Pharmacy Tweets</p>
             <ajaxToolkit:Twitter ID="Twitter1" runat="server" ScreenName="LouisPharmacy" CssClass="auto-style7" style="margin-left: 227px">
            <EmptyDataTemplate>
There are no matching tweets.
</EmptyDataTemplate>
<LayoutTemplate>
<div runat="server" class="ajax__twitter_header"><asp:Image runat="server"
        ImageUrl="mvwres://AjaxControlToolkit, Version=4.1.51116.0, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e/Twitter.Twitter32.png"></asp:Image>
<h3 runat="server">Ajax Control Toolkit</h3>
<h4 runat="server">ajaxcontroltoolkit</h4>
</div>
<ul runat="server" class="ajax__twitter_itemlist" style="margin:0px;"><asp:PlaceHolder runat="server" ID="ItemPlaceholder"></asp:PlaceHolder>
</ul>
<div runat="server" class="ajax__twitter_footer"><asp:Image runat="server" ImageUrl="mvwres://AjaxControlToolkit, Version=4.1.51116.0, Culture=neutral,
PublicKeyToken=28f01b0e84b6d53e/Twitter.Twitter24.png"></asp:Image>
</div>
</LayoutTemplate>
        </ajaxToolkit:Twitter>
    </div>
    </form>
</body>
</html>
