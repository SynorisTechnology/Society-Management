<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLoan.aspx.cs" Inherits="Society_Maharanapratab.UserLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 60%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblError" runat="server" style="font-weight:bold;color:red;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>User</td>
            <td>
                <asp:DropDownList ID="ddlUser" runat="server">
                </asp:DropDownList>
                 <asp:RequiredFieldValidator id="RFVddlUser" runat="server" ControlToValidate="ddlUser"  
                   CssClass="failureNotification" ErrorMessage="User name By is required" ToolTip="User name By is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true"  ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                    
            </td>
        </tr>
        <tr>
            <td>Loan Type</td>
            <td>
                <div>
               <asp:dropdownlist runat="server" Id="ddlLoanType" AutoPostBack="True" OnSelectedIndexChanged="ddlLoanType_SelectedIndexChanged" ></asp:dropdownlist>
                    <asp:RequiredFieldValidator id="RFVDDlLoan" runat="server" ControlToValidate="ddlLoanType"  
                   CssClass="failureNotification" ErrorMessage="Please select Loan" ToolTip="Please select Loan"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" initialvalue="-1" ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                    
               </div>
               <div>
                        <asp:Textbox runat="server" ID="txtLoanType" MaxLength="20" Visible="False"></asp:Textbox>
                   <asp:RequiredFieldValidator id="RFVLoantype" runat="server" ControlToValidate="txtLoanType"  
                   CssClass="failureNotification" ErrorMessage="Enter Loan Type" ToolTip="Enter Loan Type"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                    
                      <asp:RegularExpressionValidator id="REVLoanName" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnInsert"
                ErrorMessage="Don't Enter Numeric value" ControlToValidate="txtLoanType" ToolTip="Don't Enter Numeric value" ForeColor="Red"
                ValidationExpression="^[a-zA-Z0-9_\s]*$" />
                    </div>
                    
            </td>
        </tr>
        <tr>
            <td>Amount</td>
            <td>
                <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RtxtAmount" runat="server" ControlToValidate="txtAmount"  
                   CssClass="failureNotification" ErrorMessage="Amount By is required" ToolTip="Amount By is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true"  ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
              
                <asp:RegularExpressionValidator ID="REFtxtAmount" runat="server" ControlToValidate="txtAmount"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Invalid Number" ValidationGroup="btnInsert" />
            </td>
        </tr>
        <tr>
            <td>Duration</td>
            <td>
                <asp:DropDownList ID="ddlDuration" runat="server">
                     <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="3" Text="3 Month"></asp:ListItem>
                    <asp:ListItem Value="6" Text="6 Month"></asp:ListItem>
                    <asp:ListItem Value="9" Text="9 Month"></asp:ListItem>
                    <asp:ListItem Value="12" Text="12 Month"></asp:ListItem>
                    <asp:ListItem Value="15" Text="15 Month"></asp:ListItem>
                    <asp:ListItem Value="18" Text="18 Month"></asp:ListItem>
                    <asp:ListItem Value="21" Text="21 Month"></asp:ListItem>
                    <asp:ListItem Value="24" Text="24 Month"></asp:ListItem>
                </asp:DropDownList>
           
            <asp:RequiredFieldValidator id="RFVddlDuration" runat="server" ControlToValidate="ddlDuration"  
                   CssClass="failureNotification" ErrorMessage="Duration By is required" ToolTip="Duration By is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true"  ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                 </td>   
        </tr>
        <tr>
            <td>Amount Unit Intrest</td>
            <td>
                <asp:TextBox ID="txtAmountUnitInterest" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator id="REFtxtAmountUnitInterest" runat="server" ControlToValidate="txtAmountUnitInterest"  
                   CssClass="failureNotification" ErrorMessage="Amount Unit Interest is required" ToolTip="Amount Unit Interest  is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true"  ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                
            </td>
        </tr>
        <tr>
            <td>
               <%--<script>
                   $(function () {
                       $("#<%=txtDate1.ClientID %>").datepicker();
                        });
  </script>--%>Date</td><td>
                       <p> <asp:TextBox ID="txtDate1" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator id="RFVtxtDate" runat="server" ControlToValidate="txtDate1"  
                   CssClass="failureNotification" ErrorMessage="Date is required" ToolTip="Date is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnInsert"></asp:RequiredFieldValidator>
                  
                           <asp:RegularExpressionValidator ID="REVDate" runat="server" ControlToValidate="txtDate1" Font-Bold="true" ForeColor="Red" ValidationGroup="btnSave"
    ValidationExpression="^(((0?[1-9]|1[012])/(0?[1-9]|1\d|2[0-8])|(0?[13456789]|1[012])/(29|30)|(0?[13578]|1[02])/31)/(19|[2-9]\d)\d{2}|0?2/29/((19|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$" ErrorMessage="InValid characters: date" />
                       </p>
            </td>
            
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert"  ValidationGroup="btnInsert" OnClick="btnInsert_Click" />
            <asp:Button ID="btnBTL" runat="server" Text="Back To List" PostBackUrl="~/UserLoanList.aspx" />
            </td>
        </tr>
    </table>
    
</asp:Content>
