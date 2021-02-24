<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Refills.aspx.cs" Inherits="DataBase.Refills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="main.css"/>
        <td colspan="2" align="center" style="width: 700px">
    
        <div class="auto-style2">
    
<asp:GridView ID="grdRefills" AutoGenerateColumns="False"  
    CssClass="GridView" runat="server" Width="100%"  >
    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page"
      Position="Top" 
         />
        
            <Columns>
       
        <asp:BoundField DataField="pat_ID" HeaderText="Patient ID" SortExpression="pat_ID" />
        <asp:BoundField DataField="phy_ID" HeaderText="Physician ID" SortExpression="phy_ID" />
        <asp:BoundField DataField="rx_number" HeaderText="RX Number" SortExpression="rx_number" />
        <asp:BoundField DataField="dosage" HeaderText="Dosage"  SortExpression="dosage"/>
        <asp:BoundField DataField="frequency" HeaderText="Frequency"  SortExpression="frequency"/>
        <asp:BoundField DataField="intake_method" HeaderText="Intake Method"  SortExpression="intake_method"/>

  
 <asp:TemplateField HeaderText="Add Refills" >
            <ItemTemplate>
                
                
           <asp:Button ID="btnAdd" Text="Add" runat="server" CommandArgument='<% # Eval  ("rx_number") %>'    
              CommandName="btnAdd"  OnCommand="btnAdd_Click"  /> 
                
    
    
           <%--<asp:linkbutton DataNavigateUrlFields="rx_number" 
      DataNavigateUrlFormatString="ViewRefills.aspx?ID={0} &type=view"           
       HeaderText="View" Text="View" runat="server" Target="_blank" >              
            </asp:linkbutton>--%>
    </ItemTemplate>
      <HeaderStyle HorizontalAlign="Center" />
     </asp:TemplateField>
                <asp:Hyperlinkfield DataNavigateUrlFields="rx_number" 
      DataNavigateUrlFormatString="ViewRefills.aspx?ID={0} &type=view"           
       HeaderText="View Refills" Text="View" runat="server" Target="_blank" >              
            </asp:Hyperlinkfield>
           
           
                
                
     
      
    
    </Columns>
    <EmptyDataTemplate>
                No Records Found Matching Your Search!
            </EmptyDataTemplate>
    
    </asp:GridView>
        
        </div>
        
    </form>
</body>
</html>
