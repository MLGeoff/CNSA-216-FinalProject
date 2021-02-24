<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    
    
    <style type="text/css">
        
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 1013px;
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Logout<br />
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
            <a href="#">Help</a>
            <a href="#">About</a>
        </div>

<!-- Page content -->
<div class="main">
  ...
</div>


    </form>
</body>
</html>
