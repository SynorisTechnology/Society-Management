<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDepositeAdd.aspx.cs" Inherits="Society_Maharanapratab.ListDepositeAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <script src="Scripts/jquery-1.7.1.min.js" type="text/javascript"></script>


  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
 <%--   <div>--%>

        <table>
             <tr>
                <%--<td></td>--%>
                    <td>
                           <asp:Button ID="btnadd" runat="server" Text="Add Installment" PostBackUrl="~/AddDeposite.aspx" />
                        <%--<asp:Button ID="btnLoan" runat="server" Text="Add LoanType" PostBackUrl="~/AddLoanType.aspx" />--%>
                </td>
            </tr>
            <tr>
                <td>
                    User Name
                </td>
                <td>
                    <asp:dropdownlist ID="ddlUName" runat="server" AutoPostBack="false" OnSelectedIndexChanged="ddlUName_SelectedIndexChanged" onchange="return BindData(this.value);"></asp:dropdownlist>
                </td>
            </tr>
            
        </table>
       <%-- <table>--%>
            
            
            <%--<tr>
                <td>
                    <h3>List Recipt</h3>
                </td>
            </tr>--%>
           
            <%--<tr>
                <td>
                     
                    <asp:GridView ID="GV_list" AutoGenerateColumns="False" runat="server" OnRowCommand="GV_list_RowCommand" OnRowDeleting="GV_list_RowDeleting" OnRowEditing="GV_list_RowEditing" OnRowUpdating="GV_list_RowUpdating" OnSelectedIndexChanged="GV_list_SelectedIndexChanged" AllowPaging="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="2px" CellPadding="4" CellSpacing="1" GridLines="None" PageSize="50" OnPageIndexChanging="GV_list_PageIndexChanging">
                        <Columns>
                           
                            <asp:BoundField HeaderText="Customer Name" DataField="Name" />
                            <asp:BoundField HeaderText="Father's Name" DataField="FatherName" />
                            <asp:BoundField HeaderText="Loan Date" DataField="Date" DataFormatString="{0:MM/dd/yyyy}" HtmlEncode="false"/>--%>
                           <%-- <asp:BoundField HeaderText="" DataField="Loan" />
                            <asp:BoundField HeaderText="" DataField="CashLoan" />
                            <asp:BoundField HeaderText="" DataField="ConsumerLoan" />
                            <asp:BoundField HeaderText="" DataField="VehicleLoan" />
                            <asp:BoundField HeaderText="" DataField="HelpLoan" />
                            <asp:BoundField HeaderText="" DataField="Interest" />
                            <asp:BoundField HeaderText="" DataField="PunishmentInterest" />
                            <asp:BoundField HeaderText="" DataField="TrustFund" />
                            <asp:BoundField HeaderText="" DataField="EntryFee" />
                            <asp:BoundField HeaderText="" DataField="Other" />--%>
                           <%-- <asp:BoundField HeaderText="Total Paid" DataField="Total" />
                            <asp:BoundField HeaderText="Entred By" DataField="EntryDoneBy" />
                             <asp:BoundField HeaderText="Mobile Number" DataField="MobileNo" />
                            <asp:BoundField HeaderText="Gender" DataField="Gender" />
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnEdit" CommandArgument='<%# Bind("DepositeID") %>' CommandName="Edit"
                                         runat="server">Edit</asp:LinkButton>
                                    <asp:LinkButton ID="lbtnDelete" CommandArgument='<%# Bind("DepositeID") %>' CommandName="Delete"
                                        OnClientClick="return confirm('Do you want to delete the record ? ');" runat="server" >Delete</asp:LinkButton>
                                  <asp:LinkButton ID="lbtnDetail" CommandArgument='<%# Bind("DepositeID") %>' CommandName ="Detail"
                                        runat="server">Detail</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast" NextPageText="1" PageButtonCount="4" PreviousPageText="Previous" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                         
                </td>
            </tr>
            
        </table>
    </div>--%>
                <div id="divtable">
                    
                <%--</div>
     <div style="width:100%;">
                 <fieldset border: 1px solid black;margin: 0;padding: 0;><legend display: block;>LoanType</legend>
                <table class='dvtable'><tr><th>Customer Name</th><th>Father's Name</th><th>Loan Date</th><th>Total Paid</th><th>Entered By</th><th>Mobile Number</th><th>Gender</th></tr><tr><td>Chinky solanki</td><td>Mohan solanki</td><td>10/15/2014 12:00:00 AM</td><td>180000</td><td>Bhupendra</td><td>9825874487</td><td>Female</td></tr> </table></fieldset><br><fieldset><legend>LoanType</legend><table class='dvtable'><tr><th>Customer Name</th><th>Father's Name</th><th>Loan Date</th><th>Total Paid</th><th>Entered By</th><th>Mobile Number</th><th>Gender</th></tr><tr><td>Chinky solanki</td><td>Mohan solanki</td><td>10/15/2014 12:00:00 AM</td><td>180000</td><td>Bhupendra</td><td>9825874487</td><td>Female</td></tr><tr><td>Chinky solanki</td><td>Mohan solanki</td><td>10/15/2014 12:00:00 AM</td><td>180000</td><td>Bhupendra</td><td>9825874487</td><td>Female</td></tr> </table></fieldset>
               
               --%>
            </div>
           <script>
               $(function () {
                   var ddlValue = document.getElementById('<%=ddlUName.ClientID%>').value;
                   BindData(ddlValue);
               });

               function Edit()
               {
                   window.Location = "~/AddDeposite.aspx";
               }

               function Delete(DepositeID) {
                   var ddlValue = document.getElementById('<%=ddlUName.ClientID%>').value;
                   if (confirm("Do you want to delete this account record?")) {
                       //alert(DepositeID);
                       $.ajax({
                           type: "Post",
                           url: "ListDepositeAdd.aspx/GetDeleteData",
                           data: '{DepositeID: "' + DepositeID + '" }',
                           contentType: "application/json; charset=utf-8",
                           dataType: "json",
                           success: function (response) {
                               if (response.d) {
                                   BindData(ddlValue);
                               }
                           }
                       });
                   }
                   else {
                       alert(response.d);
                   }
               }

               function BindData(ddlValue) {
                       $.ajax({
                           type: "Post",
                           url: "ListDepositeAdd.aspx/BindData",
                           data: "{'ddlValue' : '" + ddlValue + "'}",
                           contentType: "application/json; charset=utf-8",
                           dataType: "json",
                           success: function (data) {
                               $('#divtable').html(data.d)
                              
                           }
                       }); 
               }
                   function Detail() {
                       window.Location = "~/Detail.aspx";
                   }
            
                 </script>

           <%-- success: function (r) {
                    if (r.d) {
                        //Remove the row from the GridView.
                        row.remove();
                        //If the GridView has no records then display no records message.
                        if ($("[id*=GridView1] td").length == 0) {
                            $("[id*=GridView1] tbody").append("<tr><td colspan = '4' align = 'center'>No records found.</td></tr>")
                        }
                        alert("Customer record has been deleted.");
                    }--%>
                
</asp:Content>
