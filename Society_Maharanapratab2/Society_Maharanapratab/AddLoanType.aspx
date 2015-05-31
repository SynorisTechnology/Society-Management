<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddLoanType.aspx.cs" Inherits="Society_Maharanapratab.AddLoanType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Add Loan Type</h3>
            </td>
        </tr>
    </table>
    <div>
        <asp:GridView ID="GV_LoanType" runat="server" CssClass="dvtable" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AllowPaging="true" CellSpacing="1" PageSize="50" OnPageIndexChanging="GV_LoanType_PageIndexChanging" OnRowCommand="GV_LoanType_RowCommand" OnRowDeleting="GV_LoanType_RowDeleting" OnRowEditing="GV_LoanType_RowEditing" OnRowUpdating="GV_LoanType_RowUpdating"
             OnSelectedIndexChanged="GV_LoanType_SelectedIndexChanged" ShowFooter="True" OnRowCancelingEdit="GV_LoanType_RowCancelingEdit" ShowHeaderWhenEmpty="true">
            <%--<AlternatingRowStyle BackColor="#DCDCDC" />--%>
            <Columns>
                <asp:TemplateField HeaderText="LoanType">
                     <EditItemTemplate>
                                 <asp:TextBox ID="txtLoanType" runat="server" Text='<%# Eval("LoanType")%>'></asp:TextBox>  
                          <asp:RequiredFieldValidator id="RFVLoanType" runat="server" ControlToValidate="txtLoanType"  
                   CssClass="failureNotification" ErrorMessage="Enter Loan Type" ToolTip="Enter Loan Type"
                    Font-Bold="true" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationGroup="Add" ></asp:RequiredFieldValidator> 
                                </EditItemTemplate>
                    <ItemTemplate>
                    <asp:Label Id="lblLoantype" runat="server" Text='<%# Eval("LoanType")%>'></asp:Label> 
                        <asp:HiddenField id="hf_LoanId" Value='<%# Bind("LoanId") %>' runat="server"></asp:HiddenField>
                        
                    <%--<EditItemTemplate>
                        <asp:TextBox ID="txtLoanType" runat="server"Text='<%# Eval("LoanType")%>'></asp:TextBox>
                   </EditItemTemplate> --%>
                  <%--  <FooterTemplate>--%>
                     <%--<asp:TextBox ID="txtLoanType" runat="server"></asp:TextBox>--%>
                   <%-- </FooterTemplate>--%>
                        </ItemTemplate>
                     <FooterTemplate>
                        
                        <asp:TextBox ID="txtLoanTypeNew" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoanTypeNew" CssClass="failureNotification" ToolTip="Enter Loan Type"
                    Font-Bold="true" Display="Dynamic" ErrorMessage="<br>Enter Loan Type" SetFocusOnError="true" ForeColor="Red"  ValidationGroup="Add"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
               <asp:TemplateField HeaderText="Action">
                     <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" CommandArgument='<%# Bind("LoanId") %>' CommandName="Update"
                                         runat="server">Update</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton2" CommandArgument='<%# Bind("LoanId") %>' CommandName="Cancel"
                                        runat="server" CausesValidation="false" >Cancel</asp:LinkButton>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnEdit" CommandArgument='<%# Bind("LoanId") %>' CommandName="Edit"
                                         runat="server">Edit</asp:LinkButton>
                                    <asp:LinkButton ID="lbtnDelete" CommandArgument='<%# Bind("LoanId") %>' CommandName="Delete"
                                        OnClientClick="return confirm('Do you want to delete the record ? ');" runat="server" >Delete</asp:LinkButton>
                                    <%--<asp:LinkButton ID="lbtnDetail" CommandArgument='<%# Bind("LoanId") %>' CommandName="Detail"
                                        runat="server">Detail</asp:LinkButton>--%>
                                </ItemTemplate>
                   
                   <FooterTemplate>
                          <asp:Button ID="btnAdd" runat="server"  Text="Add" ValidationGroup="Add" CommandArgument='Add' CommandName="Add" />
                            </FooterTemplate>
                            </asp:TemplateField>
            </Columns>
            <%--<FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />--%>
            <PagerStyle CssClass="paging" HorizontalAlign="Center" />
           <%-- <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <sortedascendingcellstyle backcolor="#F1F1F1" />
            <sortedascendingheaderstyle backcolor="#0000A9" />
            <sorteddescendingcellstyle backcolor="#CAC9C9" />
            <sorteddescendingheaderstyle backcolor="#000065" />--%>
        </asp:GridView>
    </div>
</asp:Content>
