<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhysicianTable.aspx.cs" Inherits="DataBase.PhysicianTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function SelectAll(id) {
            var grid = document.getElementById("<%= grdStudent.ClientID %>");
            var cell;

            if (grid.rows.length > 0) {
                for (i = 1; i < grid.rows.length; i++) {
                    cell = grid.rows[i].cells[0];

                    for (j = 0; j = cell.childNodes.length; j++) {
                        if (cell.childNodes[j].type == "checkbox") {
                            cell.childNodes[j].checked = document.getElementById(id).checked;
                        }
                    }
                }
            }
        }
    </script>
    <style type="text/css">
        .auto-style2 {
            height: 20px;
            width: 707px;
        }
        .auto-style3 {
            width: 928px;
        }
        .auto-style4 {
            height: 20px;
            width: 928px;
        }
        .auto-style5 {
            width: 22%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="main.css"/>
        <table>
<tr>
<td rowspan="3" valign="middle" class="auto-style5"> &nbsp;<asp:HyperLink 
        ID="hplNew" runat="server" NavigateUrl="~/PhysicianAdd.aspx?ID=0">New 
   Physician</asp:HyperLink></td>

<td colspan="2" class="auto-style4" > 
    <asp:Label ID="Label1" runat="server" Text="Search criteria" Font-Bold="True" Font-Size="Medium"></asp:Label>

</td>
</tr>
<tr>
<td colspan="2" class="auto-style3" >
    <asp:Panel ID="pnlSearch" runat="server" Width="100%">
        <table border="1" cellpadding="1" style="width: 100%; border-top-style: ridge; border-right-style: ridge; border-left-style: ridge; border-bottom-style: ridge;">
            <tr>
                <td style="width: 25%; height: 26px;">
                    Physician ID:</td>
                <td style="border-style: ridge;" class="auto-style7">
        <asp:TextBox ID="txtPhysicianID" runat="server" MaxLength="7" Width="541px" Height="16px" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 25%">
                    First Name:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="border-style: ridge;" class="auto-style2">
      <asp:TextBox ID="txtFName" runat="server" Width="80%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 25%">
                    Last Name:</td>
                <td style="border-style: ridge;" class="auto-style2">
        <asp:TextBox ID="txtLName" runat="server" Width="80%"></asp:TextBox></td>
            </tr>
        </table>
    </asp:Panel>
</td>
</tr>
<tr >
<td colspan="2" align="center" class="auto-style3">
    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />
<asp:GridView ID="grdStudent" AutoGenerateColumns="False"  
    CssClass="GridView" runat="server" Width="100%" AllowPaging="True" 
        AllowSorting="True" OnSelectedIndexChanged="grdStudent_SelectedIndexChanged">
    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page"
      Position="Top" 
         />
    <Columns>
       <asp:TemplateField HeaderText="Physician ID" >
    
            <HeaderTemplate>
                <asp:CheckBox ID="cbSelectAll" runat="server"  OnClick="SelectAll"/>

                &nbsp;
                <asp:LinkButton ID="lbtnDelete" runat="server" OnCommand="Delete_Click" 
                    CommandName="lbtnDelete" CommandArgument='<%#Eval("phy_ID") %>'>Delete</asp:LinkButton>
            </HeaderTemplate>
           

    <ItemTemplate> 
<asp:CheckBox ID="chkStudentID" runat="server" AutoPostBack="false" /> 
        <asp:Label ID="hidStudentID" runat="server" Text='<%#Eval("phy_ID") %>' Visible="false"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
        <asp:BoundField DataField="phy_ID" HeaderText="Physician ID" SortExpression="phy_ID" />
        <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
        <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
        
        <asp:BoundField DataField="email" HeaderText="Email"  SortExpression="email"/>
  <%--<asp:HyperLinkField DataNavigateUrlFields="pat_ID" 
      DataNavigateUrlFormatString="Display.aspx?ID={0} &type=view"           
       HeaderText="View" Text="View" runat="server" Target="_blank" >  
                <HeaderStyle HorizontalAlign="Center" />
            </asp:HyperLinkField>--%>
        <asp:TemplateField HeaderText="View">
            <ItemTemplate>
                <asp:Button ID="btnView" text="View" runat="server" CommandArgument='<% # Eval  ("phy_ID") %>' OnCommand="btnView_Click"   
              CommandName="btnView"  />
                </ItemTemplate>
            </asp:TemplateField>

 <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:LinkButton ID="lbtnEdit" runat="server" 
                OnCommand="lbtnEdit_Click" CommandName="lbtnEdit" 
                CommandArgument='<% # Eval  ("phy_ID") %>'>Edit</asp:LinkButton>&nbsp;&nbsp;
                <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("phy_ID") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("phy_ID") %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.jpg" Height ="30"  Width ="30" />
           
           
                
                </ItemTemplate>
      <ItemTemplate>

          <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("phy_ID") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("phy_ID") %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.jpg" Height ="30"  Width ="30" />
           
           
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
            
            </asp:TemplateField>
            
       
               
    </Columns>
    
  

     <EmptyDataTemplate>
                No Records Found Matching Your Search!
            </EmptyDataTemplate>
    
    </asp:GridView>
 
     <div class="auto-style1">
            
            <asp:HyperLink ID="addLink" runat="server" Text="Add/Edit Patients" NavigateUrl="~/Table.aspx"></asp:HyperLink>
            <asp:HyperLink ID="staffDir" runat="server" Text="Staff Directory" NavigateUrl="~/PhysicianTable.aspx"></asp:HyperLink>
            <%--<asp:HyperLinkField DataNavigateUrlFields="pat_ID" 
      DataNavigateUrlFormatString="Display.aspx?ID={0} &type=view"           
       HeaderText="View" Text="View" runat="server" Target="_blank" >  
                <HeaderStyle HorizontalAlign="Center" />
            </asp:HyperLinkField>--%>
            <a href="mailto:techhelp@louisrx.com">Help</a>
            <a href="https://github.com/MLGeoff/CNSA-216-FinalProject/commits/main">About</a>
        </div>

    </td>  
  </tr>
  
<tr>
<td colspan="3">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblException" runat="server"></asp:Label>
    </td>

</tr>
</table>



    </form>
</body>
</html>




