<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="DataBase.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<asp:Label ID="lblStuID" runat="server" Text="Student ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStuID" runat="server" MaxLength="12"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            
            <asp:Label ID="Label1" runat="server" Text="Middle Initial:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="textMiddleInitial" runat="server" MaxLength="1"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFName" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFName" runat="server" MaxLength="30"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <asp:Label ID="labelZip" runat="server" Text="Zip Code:" />&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textZipCode" runat="server" MaxLength="5" />
            <br />
            <br />
            <asp:Label ID="lblLName" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLName" runat="server" MaxLength="30"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelEmail" runat="server" Text="Primary E-mail Address:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textEmail" runat="server" MaxLength="100" />
            <br />
            <br />
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelPhone" runat="server" Text="Primary Phone Number:" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textPhone" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelInsurance" runat="server" Text="Insurance:" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textInsurance" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            
            <br />
            <br />
            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlState" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="Close" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblException" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
