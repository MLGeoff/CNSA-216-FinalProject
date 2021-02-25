<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRefills.aspx.cs" Inherits="DataBase.ViewRefills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function SelectAll(id) {
            var grid = document.getElementById("<%= grdViewRefills.ClientID %>");
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
</head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="main.css"/>
        <div class="auto-style2">
        <asp:GridView ID="grdViewRefills" AutoGenerateColumns="False"  
    CssClass="GridView" runat="server" Width="100%"   >
    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page"
      Position="Top" 
         />
        
            <Columns>
                
                
       
        <asp:BoundField DataField="rx_number" HeaderText="RX Number" SortExpression="rx_number" />
        <asp:BoundField DataField="date_refill" HeaderText="Date Refilled" SortExpression="date_refill" />
        <asp:BoundField DataField="amount" HeaderText="Amount" SortExpression="amount" />
                <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:LinkButton ID="lbtnEdit" runat="server" 
                OnCommand="lbtnEdit_Click" CommandName="lbtnEdit" 
                CommandArgument='<% # Eval  ("Date_Refill") %>'>Edit</asp:LinkButton>&nbsp;&nbsp;
                <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("Date_Refill") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("Date_Refill")  %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.jpg" Height ="30"  Width ="30" />
           
           
                
                </ItemTemplate>
      <ItemTemplate>

          <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("Date_Refill") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("Date_Refill") %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.jpg" Height ="30"  Width ="30" />
           
           
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
            
            </asp:TemplateField>
        

  
 
      
    
    </Columns>
    <EmptyDataTemplate>
                No Records Found Matching Your Search!
            </EmptyDataTemplate>
    
    </asp:GridView>
        
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblException" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
