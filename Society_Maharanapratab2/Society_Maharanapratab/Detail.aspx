<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Society_Maharanapratab.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div>
       
        <fieldset>
            <legend>Detail Loan</legend>
        <table>       
                 <table class="auto-style1">
                     <tr>
                         <td>
                <b>ReciptId
                </b>
                         </td>
                         <td>
                <asp:Label id="lblReciptId" runat="server" Text='<%# Bind("DepositeID") %>'></asp:Label>
                         </td>
                    <%-- </tr>
                     <tr>--%>
                         <td>
                <b>Date
                </b>
                         </td>
                         <td>
                <asp:Label id="lblDate" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
       
        <b>Name</b></td>
                         <td>
               
                 <asp:Label id="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                <%--<br />--%>
         <b>&nbsp;</b></td>
                     <%--</tr>
                     <tr>--%>
                         <td><b>Father Name
                </b></td>
                         <td>
               
                 <asp:Label id="lblFathername" runat="server" Text='<%# Bind("FatherName") %>'></asp:Label>
                <%--<br />--%>
                         </td>
                     </tr>
                     <tr>
                         <td><b>Address</b> </td>
                         <td>
         <asp:Label id="lblAddress" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                         </td>
                     <%--</tr>
                    
                     <tr>--%><td>
                         <b>
                             LoanType
                         </b></td>
                         <td><asp:Label id="lblLoanType" runat="server" Text='<%# Bind("LoanType") %>'></asp:Label></td>
                     </tr>
                     </table>
           </fieldset>
                 </div> 
    <div>
        <fieldset>
            <table>
                     <tr>
                         <td>
                <b>Loan</b></td>
                         <td>
                <asp:Label ID="lblLoan" runat="server" Text='<%# Bind("Loan") %>'></asp:Label>
                <%--<br />--%>
                         </td>
                     </tr>
                     <tr>
                         <td>
                <b>Cash Loan</b></td>
                         <td>
                <asp:Label ID="lblCashLoan" runat="server"  Text='<%# Bind("CashLoan") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                <b>Consumer Loan
                </b>
                         </td>
                         <td>
                 <asp:Label ID="lblConsumerLoan" runat="server" Text='<%# Bind("ConsumerLoan") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td><b>Vehicle Loan</b></td>
                         <td>
                <asp:Label ID="lblVehicleLoan" runat="server" Text='<%# Bind("VehicleLoan") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td><b>Help Loan
                </b>
                         </td>
                         <td>
                <asp:Label ID="lblHelpLoan" runat="server" Text='<%# Bind("HelpLoan") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                <b>Interest</b></td>
                         <td>
                <asp:Label ID="lblInterest" runat="server" Text='<%# Bind("Interest") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                <b>Punishment Interest</b></td>
                         <td>
                <asp:Label ID="lblPunishmentInterest" runat="server" Text='<%# Bind("PunishmentInterest") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>

       <b>Trust Fund</b></td>
                         <td><asp:Label ID="lblTrustFund" runat="server" Text='<%# Bind("TrustFund") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td><b>Entry Fee</b></td>
                         <td>

           <asp:Label ID="lblEntryFee" runat="server" Text='<%# Bind("EntryFee") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>

       <b>Other</b></td>
                         <td>

           <asp:Label ID="lblOther" runat="server" Text='<%# Bind("Other")%>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>

       <b>Total</b>
       </td>
                         <td>

       <asp:Label ID="lblTotal" runat="server" Text='<%# Bind("Total") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>

       <b>Enter Done By</b>
       </td>
                         <td>

       <asp:Label ID="lblEntryDoneBy" runat="server" Text='<%# Bind("EntryDoneBy") %>'></asp:Label>
                         </td>
                     </tr>
                      </table>
            </fieldset>
                 </div>
    <div>
        <fieldset>
            
              <legend>Action</legend>
            <table>
                     <tr>
                         <td>

                         </td>
                         <td>

                             <b>
                    <%--<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>--%>
                &nbsp;
                        <asp:Button ID="btnBackToList" runat="server" Text="BackToList" PostBackUrl="~/ListDepositeAdd.aspx"  />
                </b> 

                         </td>
                     </tr>
         </table>
            </fieldset>
                 </div>
</asp:Content>
