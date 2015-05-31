<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLoanList.aspx.cs" Inherits="Society_Maharanapratab.UserLoanList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>User Loan List</h3>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td style="float:right;">
                <asp:Button ID="btnUserLoan" runat="server" Text="Add User Loan" PostBackUrl="~/UserLoan.aspx" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" CssClass="dvtable" AutoGenerateColumns="false" AllowPaging="True" CellSpacing="1" PageSize="50" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="Name" />
                        <asp:BoundField HeaderText="Loan Type" DataField="LoanType" />
                        <asp:BoundField HeaderText="Amount" DataField="Amount" />
                        <asp:BoundField HeaderText="Duration" DataField="Duration" />
                        <asp:BoundField HeaderText="AmountUnitInterest" DataField="AmountUnitInterest" />
                    <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false"  />
                    <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnEdit" CommandArgument='<%# Bind("UserLoanId") %>' CommandName="Edit"
                                         runat="server">Edit</asp:LinkButton>
                                    <asp:LinkButton ID="lbtnDelete" CommandArgument='<%# Bind("UserLoanId") %>' CommandName="Delete"
                                        OnClientClick="return confirm('Do you want to delete the record ? ');" runat="server" >Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                </Columns>
                    </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
