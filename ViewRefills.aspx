<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRefills.aspx.cs" Inherits="DataBase.ViewRefills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="main.css"/>
        <div class="auto-style2">
        <asp:GridView ID="grdViewRefills" AutoGenerateColumns="False"  
    CssClass="GridView" runat="server" Width="100%"  >
    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page"
      Position="Top" 
         />
        
            <Columns>
       
        <asp:BoundField DataField="rx_number" HeaderText="RX Number" SortExpression="rx_number" />
        <asp:BoundField DataField="date_refill" HeaderText="Date Refilled" SortExpression="dat_refill" />
        <asp:BoundField DataField="amount" HeaderText="Amount" SortExpression="amount" />
        

  
 
      
    
    </Columns>
    <EmptyDataTemplate>
                No Records Found Matching Your Search!
            </EmptyDataTemplate>
    
    </asp:GridView>
        
        </div>
    </form>
</body>
</html>
