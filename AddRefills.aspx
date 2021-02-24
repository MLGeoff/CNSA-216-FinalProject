<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRefills.aspx.cs" Inherits="DataBase.AddRefills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRX_NUMBER" runat="server" Text="RX_Number"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtRX_NUMBER" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDate_Refill" runat="server" Text="Date Refilled"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDATE_REFILL" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAMOUNT" runat="server" Text="Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAMOUNT" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Refill" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="Close" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAdded" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblException" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
