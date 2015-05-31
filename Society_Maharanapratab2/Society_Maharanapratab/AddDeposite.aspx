<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDeposite.aspx.cs" Inherits="Society_Maharanapratab.AddDeposite" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 60%;
        }
        .auto-style3 {
            width: 124px;
        }
        .auto-style4 {
            width: 131px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/jquery-1.8.0.min.js"></script>
    <script src="Scripts/jquery-ui.js"></script>
    <link href="Content/jquery-ui.css" rel="stylesheet" />
        <%--<div>
            <fieldset>
                <legend>Persnoal Information</legend>
                <table>
         <tr>
             <td>User Name</td>
             <td>
                 <asp:dropdownlist id="ddlUsername" runat="server"></asp:dropdownlist>
             </td>
           <%--</tr>
                    <tr>
            <td>
                    <script>
                        $(function () {
                            $("#datepicker").datepicker();
                        });
  </script>Date</td><td>
                       <p>  <input type="text" runat="server" id="datepicker"></p></td>
                  </tr>
                    </table>
                </fieldset>
        </div>
    <div>
        <fieldset>
            <legend>Action</legend>
            <table>
                <tr>
                    <td></td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input type="submit" id="btnADD" value="ADD" OnClick="btnADD_Click"></td>
                </tr>
                
            </table>
        </fieldset>
    </div>--%>
   <table>
       <tr>
             <td>User Name</td>
             <td>
                 <asp:dropdownlist id="ddlUsername" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlUsername_SelectedIndexChanged"></asp:dropdownlist>
                 <asp:RequiredFieldValidator id="RFVddlUsername" runat="server" ControlToValidate="ddlUsername"  
                   CssClass="failureNotification" ErrorMessage="User name By is required" ToolTip="User name By is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" initialvalue="0" ForeColor="Red" ValidationGroup="btnSave"></asp:RequiredFieldValidator>
                    
                
             </td>
           </tr>
        <tr>
            <td>
                    <script>
                        $(function () {
                            $("#<%=txtDate.ClientID %>").datepicker({ dateFormat: "dd/mm/yy" });
                        });
  </script>Date</td><td>
                       <p>  <%--<input type="text" runat="server" id="datepicker">--%>
                           <asp:TextBox id="txtDate" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator id="RFVtxtDate" runat="server" ControlToValidate="txtDate"  
                   CssClass="failureNotification" ErrorMessage="Date is required" ToolTip="Date is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSave"></asp:RequiredFieldValidator>
                  
                           <asp:RegularExpressionValidator ID="REVDate" runat="server" ControlToValidate="txtDate" Font-Bold="true" ForeColor="Red" ValidationGroup="btnSave"
    ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ErrorMessage="*Valid characters: date" />
                       </p></td>
                  </tr>
       <tr>
           <td>Loan Type</td><td>
               
               <div>
               <asp:dropdownlist runat="server" Id="ddlLoanType" AutoPostBack="True" OnSelectedIndexChanged="ddlLoanType_SelectedIndexChanged" ></asp:dropdownlist>
                    <asp:RequiredFieldValidator id="RFVDDlLoan" runat="server" ControlToValidate="ddlLoanType"  
                   CssClass="failureNotification" ErrorMessage="Please select Loan" ToolTip="Please select Loan"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" initialvalue="-1" ForeColor="Red" ValidationGroup="btnSave"></asp:RequiredFieldValidator>
                    
               </div>
               <div>
                        <asp:Textbox runat="server" ID="txtLoanType" MaxLength="20" Visible="False"></asp:Textbox>
                   <asp:RequiredFieldValidator id="RFVLoantype" runat="server" ControlToValidate="txtLoanType"  
                   CssClass="failureNotification" ErrorMessage="Enter Loan Type" ToolTip="Enter Loan Type"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSave"></asp:RequiredFieldValidator>
                    
                      <asp:RegularExpressionValidator id="REVLoanName" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSave"
                ErrorMessage="Don't Enter Numeric value" ControlToValidate="txtLoanType" ToolTip="Don't Enter Numeric value" ForeColor="Red"
                ValidationExpression="^[a-zA-Z0-9_\s]*$" />
                    </div>
           </td>
           <%--<td>
               
               
           </td>--%>
       <%--</tr>
       <tr>--%>
          <%-- <td>Loan type</td>--%>
           
       </tr>
       <%--<script>
           function Simple() {
               document.getElementById("#<%=txtLoanType.ClientID%>").style.display = "block";
               document.getElementById("#<%=ddlLoanType.ClientID%>").style.display = "none";
           }
           
                    </script> --%>
       <tr>
           <td>
               Remaining
           </td>
           <td>
               <asp:Label ID="lblRemaining" runat="server" Text=""></asp:Label>
           </td>
       </tr>
   </table>
    
   
    <table class="auto-style2">
         
        <tr>
            <td class="auto-style3">S.No</td>
            <td class="auto-style4">Description</td>
            <td>Rupees</td>
        </tr>
        <tr>
            <td class="auto-style3">1</td>
            <td class="auto-style4">Loan</td>
            <td>
                <asp:TextBox ID="txtLoan" runat="server" onblur="Loan();" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtLoan" runat="server" ControlToValidate="txtLoan"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            
            </td>
        </tr>
        <tr>
            <td class="auto-style3">2</td>
            <td class="auto-style4">Cash Loan</td>
            <td>
                <asp:TextBox ID="txtCashLoan" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtCashLoan" runat="server" ControlToValidate="txtCashLoan"
    ValidationExpression="[0-9]+"  Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">3</td>
            <td class="auto-style4">Consumer Loan</td>
            <td>
                <asp:TextBox ID="txtConsumerloan" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVConsumer" runat="server" ControlToValidate="txtConsumerloan"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">4</td>
            <td class="auto-style4">Vehicle Loan</td>
            <td>
                <asp:TextBox ID="txtVehicleLoan" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtVehicleLoan" runat="server" ControlToValidate="txtVehicleLoan"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">5</td>
            <td class="auto-style4">Help Loan</td>
            <td>
                <asp:TextBox ID="txtHelpLoan" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtHelpLoan" runat="server" ControlToValidate="txtHelpLoan"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>

            </td>
        </tr>
        <tr>
            <td class="auto-style3">6</td>
            <td class="auto-style4">Interest</td>
            <td>
                <asp:TextBox ID="txtInterest" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtInterest" runat="server" ControlToValidate="txtInterest"
    ValidationExpression="[0-9]+"  Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">7</td>
            <td class="auto-style4">Punishment Interest</td>
            <td>
                <asp:TextBox ID="txtPunishmentInterest" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtPunishmentInterest" runat="server" ControlToValidate="txtPunishmentInterest"
    ValidationExpression="[0-9]+" ForeColor="Red"  Font-Bold="true" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">8</td>
            <td class="auto-style4">Trust Fund</td>
            <td>
                <asp:TextBox ID="txtTrustfund" runat="server" onblur="Loan();"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="REVtxtTrustfund" runat="server" ControlToValidate="txtTrustfund"
    ValidationExpression="[0-9]+" ForeColor="Red"  Font-Bold="true" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">9</td>
            <td class="auto-style4">Entry Fee</td>
            <td>
                <asp:TextBox ID="txtEntryfee" runat="server" onblur="Loan();"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REVtxtEntryfee" runat="server" ControlToValidate="txtEntryfee"
    ValidationExpression="[0-9]+" ForeColor="Red"  Font-Bold="true" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                10
            </td>
            <td class="auto-style4">Other</td>
            <td>
                <asp:textbox ID="txtOther" runat="server" onblur="Loan();"></asp:textbox>
                 <asp:RegularExpressionValidator ID="REVtxtOther" runat="server" ControlToValidate="txtOther"
    ValidationExpression="[0-9]+" ForeColor="Red"  Font-Bold="true" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Total</td>
            <td class="auto-style4"></td>
            <td>
                <asp:Textbox ID="txtTotal" runat="server" ></asp:Textbox>
                 <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" 
 ControlToValidate="txtTotal" ErrorMessage="Value must be a whole number" Font-Bold="true" ForeColor="Red" ValidationGroup="btnSave" />

                <asp:RegularExpressionValidator ID="REVtxtTotal" runat="server" ControlToValidate="txtTotal"
    ValidationExpression="[0-9]+" Font-Bold="true" ForeColor="Red" ErrorMessage="Enter a Numeric value" ValidationGroup="btnSave"/>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Entry Done By</td>
            <td class="auto-style4">
                
            </td>
            <td><asp:textbox ID="txtEntryDoneBy" runat="server"></asp:textbox>
                <asp:RequiredFieldValidator id="RFVEntryName" runat="server" ControlToValidate="txtEntryDoneBy"  
                   CssClass="failureNotification" ErrorMessage="Entry Done By is required" ToolTip="Entry Done By is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSave"></asp:RequiredFieldValidator>
                    
                <asp:RegularExpressionValidator ID="REVEntryDoneBy" runat="server" ControlToValidate="txtEntryDoneBy"
    ValidationExpression="[a-zA-Z ]*$" ForeColor="Red"  Font-Bold="true" ErrorMessage="Enter Entry Done By Name" ValidationGroup="btnSave"/>
            </td>

            
        </tr>
        <tr>
            <td class="auto-style3"></td><td class="auto-style4"></td>
            <td>
                <asp:button ID="btnSave" runat="server" text="Save" OnClick="btnSave_Click" ValidationGroup="btnSave"/>
                <asp:button ID="btnbacktolist" runat="server"  text="Back To List" PostBackUrl="~/ListDepositeAdd.aspx" CausesValidation="False" />
            </td>
            <td></td>
        </tr>
         <%--<tr><td></td>
            <td></td>
            <td>
                <asp:Button ID="btnBCK" runat="server" CauseValidation="false" text="Back to list" OnClick="btnBCK_Click" PostBackUrl="~/ListDepositeAdd.aspx" />
            </td>
            
        </tr>--%>
    </table>
   <script>
       function Loan()
       {
         
     
           var a = document.getElementById('<%=txtLoan.ClientID %>').value;
           var b = document.getElementById('<%=txtCashLoan.ClientID %>').value;
           var c = document.getElementById('<%=txtConsumerloan.ClientID %>').value;
           var d = document.getElementById('<%=txtVehicleLoan.ClientID %>').value;
           var e = document.getElementById('<%=txtHelpLoan.ClientID %>').value;
           var f = document.getElementById('<%=txtInterest.ClientID %>').value;
           var g = document.getElementById('<%=txtPunishmentInterest.ClientID %>').value;
           var h = document.getElementById('<%=txtTrustfund.ClientID %>').value;
           var i = document.getElementById('<%=txtEntryfee.ClientID %>').value;
           var j = document.getElementById('<%=txtOther.ClientID %>').value;
           if (a == "")
               a = 0;
           if (b == "")
               b = 0;
           if (c == "")
               c = 0;
           if (d == "")
               d = 0;
           if (e == "")
               e = 0;
           if (f == "")
               f = 0;
           if (g == "")
               g = 0;
           if (h == "")
               h = 0;
           if (i == "")
               i = 0;
           if (j == "")
               j = 0;


           var z = parseInt (a) + parseInt (b) + parseInt (c) + parseInt (d) + parseInt (e) + parseInt (f) + parseInt (g) + parseInt (h) + parseInt (i) + parseInt (j);
          
               document.getElementById('<%=txtTotal.ClientID %>').value = z;
         
          }
          
       
   </script>
    
   
</asp:Content>
