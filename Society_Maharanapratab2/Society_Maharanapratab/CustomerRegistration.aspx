<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="Society_Maharanapratab.CustomerRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
    <script src="Scripts/jquery-1.8.0.min.js"></script>
    <script src="Scripts/jquery-ui.js"></script>
    <link href="Content/jquery-ui.css" rel="stylesheet" />
    <table>
        <tr>
            <td>
                Full Name
            </td>
            <td><asp:TextBox ID="txtName" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator id="RFVName" runat="server" ControlToValidate="txtName"  
                   CssClass="failureNotification" ErrorMessage="Enter Name" ToolTip="Enter Name"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    
                      <asp:RegularExpressionValidator id="REVName" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Don't Enter Numeric value" ControlToValidate="txtName" ToolTip="Don't Enter Numeric value" ForeColor="Red"
                ValidationExpression="[a-zA-Z ]*$" />
            </td>
        </tr>
        <tr>
            <td>
                Father Name
            </td>
            <td><asp:TextBox ID="txtFathername" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator id="REDtxtFathername" runat="server" ControlToValidate="txtFathername"  
                   CssClass="failureNotification" ErrorMessage="Enter Father Name" ToolTip="Enter FatherName"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    
                      <asp:RegularExpressionValidator id="REVtxtFathername" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Don't Enter Numeric value" ControlToValidate="txtFathername" ToolTip="Don't Enter Numeric value" ForeColor="Red"
                ValidationExpression="[a-zA-Z ]*$" />
            </td>
        </tr>
        <tr>
            <td>
               
                Address
            </td>
            <td><asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server" Width="300px" Height="50px" MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator id="RFVAdd" runat="server" ControlToValidate="txtAddress"  
                 CssClass="failureNotification" ErrorMessage="Enter Address" ToolTip="Enter Address"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>

               <%--   <asp:RegularExpressionValidator id="REVtxtAddress" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Proper Address Enter" ControlToValidate="txtAddress" ToolTip="Proper Address Enter " ForeColor="Red"
                ValidationExpression="^[a-zA-Z0-9_\s]*$"/>--%>
            </td>
        </tr>
        
        <tr>
            <td>
                Email
            </td>
            <td><asp:TextBox ID="txtEmail" runat="server"  MaxLength="50"></asp:TextBox>
                 
                <asp:RequiredFieldValidator id="RFVEmail" runat="server" ControlToValidate="txtEmail"  
                   CssClass="failureNotification" ErrorMessage="Email is required" ToolTip="Email is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator id="RegularExpressionValidator1" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Invalid Email Id" ControlToValidate="txtEmail" ToolTip="Proper Email Id" ForeColor="Red"
                ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />
            </td>
        </tr>
        <tr>
            <td>Date Of Birth</td>
            <td><script>
                    $(function () {
                        $("#<%=txtDOB.ClientID %>").datepicker({ dateFormat: "dd/mm/yy" });
                    });
  </script>
                       <p>  <%--<input type="text" runat="server" id="datepicker">--%>
                           <asp:TextBox ID="txtDOB" runat="server" MaxLength="10"  onchange="CalculateAge();"></asp:TextBox>
                       </p>
                
                <%--<cc1:calendarextender ID="txtDOB_CalendarExtender" runat="server" Enabled="true" TargetControlID="txtDOB" Format="yyyy-MM-dd"></cc1:calendarextender>--%>
            <asp:RequiredFieldValidator id="RFVDOB" runat="server" ControlToValidate="txtDOB"  
                   CssClass="failureNotification" ErrorMessage="Enter Date of birth " ToolTip="Enter Date of birth "
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator id="RegularExpressionValidator2" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Invalid Date of birth" ControlToValidate="txtDOB" ToolTip="Proper Date of birth" ForeColor="Red"
                ValidationExpression="^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$" />
           
           </td>
        </tr>
        <script type="text/javascript">
            function CalculateAge() {
                var date1 = new Date();
                var dob1 = document.getElementById('<%=txtDOB.ClientID %>').value;
                var date2 = new Date(dob1);
                var pattern = /^\d{1,2}\/\d{1,2}\/\d{4}$/;

                var y1 = date1.getFullYear();
                var y2 = date2.getFullYear();
                var age = y1 - y2;

                document.getElementById('<%=txtage.ClientID %>').value = age;
                    return true;


                }


</script>
      <tr>
            <td>Mobile No</td>
            <td><asp:TextBox ID="txtMbl" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator id="RFVMbl" runat="server" ControlToValidate="txtMbl"  
                   CssClass="failureNotification" ErrorMessage="Mobile no is required" ToolTip="Mobile no is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    
                <asp:RegularExpressionValidator id="REVmbl" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Invalid Numeric Number" ControlToValidate="txtMbl" ToolTip="Proper Numeric Number" ForeColor="Red"
                ValidationExpression="[0-9]+" />
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>               
                <asp:RadioButton id="rdomale" runat="server" GroupName="GN" Text=""></asp:RadioButton>&nbsp;Male &nbsp;&nbsp;<asp:RadioButton id="rdoFemale" runat="server"  GroupName="GN"></asp:RadioButton>&nbsp;Female&nbsp;&nbsp;
               <%--<asp:RequiredFieldValidator ID="RFVGender" runat="server" 
                    InitialValue="-1" ErrorMessage="*" Display="Dynamic" ValidationGroup="btnSave"
                    ForeColor="Red" Font-Bold="true" SetFocusOnError="true" ToolTip="Please Select Gender "></asp:RequiredFieldValidator>--%>
                <%--<asp:RegularExpressionValidator id="REVGN" ControlToValidate="GN" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Select Gender" ToolTip="Select Gender" ForeColor="Red" />--%>

                <%--<asp:CustomValidator runat="server" ID="CVGender" EnableClientScript="true" OnServerValidate="CVGender_ServerValidate" ValidationGroup="btnSubmit"></asp:CustomValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Age</td>
            <td><asp:TextBox ID="txtage" runat="server"  MaxLength="2" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><span id="spimage" runat="server"> Photo </span></td>
            <td><asp:FileUpload ID="fuPhoto" runat="server" />
                
            </td>
        </tr>
        <tr>
            <td>Emergency Contact Name</td>
            <td><asp:TextBox ID="txtECName" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator id="RFVECN" runat="server" ControlToValidate="txtECName"  
                   CssClass="failureNotification" ErrorMessage="Emergency Contact Name is required" ToolTip="Emergency Contact Name is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    
                      <asp:RegularExpressionValidator id="REVEmergencyContactName" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Invalid Emergency Contact value" ControlToValidate="txtECName" ToolTip="Proper Emergency Contact value" ForeColor="Red"
                ValidationExpression="[a-zA-Z ]*$" />
            </td>
        </tr>
        <tr>
            <td>          
                  Emergency Contact NO
                </td>
                <td><asp:TextBox ID="txtECNo" runat="server" MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RFVEmergencyContactNO" runat="server" ControlToValidate="txtECNo"  
                   CssClass="failureNotification" ErrorMessage="Emergency Contact NO is required" ToolTip="Emergency Contact NO is required"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                    
                    <asp:RegularExpressionValidator id="RegularExpressionValidator3" SetFocusOnError="true" runat="server" Font-Bold="true" ValidationGroup="btnSubmit"
                ErrorMessage="Invalid Emergency Contact NO" ControlToValidate="txtECNo" ToolTip="Proper Emergency Contact NO" ForeColor="Red"
                ValidationExpression="[0-9]+" />
                </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="btnSubmit" />
               <%-- <asp:button ID="btnCancle" runat="server" text="Cancle" OnClick="btnCancle_Click"  />--%>
                <asp:button ID="btnBackToList" runat="server" text="Back to list" PostBackUrl="~/RegistrationList_Society.aspx" />
            </td>
          
        </tr>
    </table>
       
</asp:Content>
