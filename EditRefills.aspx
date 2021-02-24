<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRefills.aspx.cs" Inherits="DataBase.EditRefills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="lblRXNumber" runat="server" Text="RX Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRXNumber" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            
         
            <br />
            <br />
            <asp:Label ID="lblDateRefill" runat="server" Text="Date Refilled:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateRefill" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <asp:Label ID="labelAmount" runat="server" Text="Amount:" />&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textAmount" runat="server" />
      
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" style="height: 26px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="Close" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblException" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
