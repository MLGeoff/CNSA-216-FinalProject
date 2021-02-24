<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPrescription.aspx.cs" Inherits="DataBase.AddPrescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPATID" runat="server" Text="Patient ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPATID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPHYID" runat="server" Text="Physician ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPHYID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRXNUMBER" runat="server" Text="RX Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRXNUMBER" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDosage" runat="server" Text="Dosage"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDOSAGE" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFrequency" runat="server" Text="Frequency"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFrequency" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblIntakeMethod" runat="server" Text="Intake Method"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtIntakeMethod" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAddPrescription" runat="server" OnClick="btnAddPrescription_Click" Text="Add Prescription" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="Close" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPrescriptionAdded" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblException" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
