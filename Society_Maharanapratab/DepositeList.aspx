
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepositeList.aspx.cs" Inherits="Society_Maharanapratab.DepositeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>DepositeList</h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnEdit" CommandArgument='<%# Bind("DepositeID") %>' CommandName="Edit"
                                         runat="server">Edit</asp:LinkButton>
                                    <asp:LinkButton ID="lbtnDelete" CommandArgument='<%# Bind("DepositeID") %>' CommandName="Delete"
                                        OnClientClick="return alert('Do you want to delete the record ? ');" runat="server" >Delete</asp:LinkButton>
                                    <asp:LinkButton ID="lbtnView" CommandArgument='<%# Bind("DepositeID") %>' CommandName ="View"
                                        runat="server">View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                         <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                        <asp:BoundField HeaderText="Last Name" DataField="LastName" />
                        <asp:BoundField HeaderText="Father Name" DataField="FatherName" />
                        <asp:BoundField HeaderText="Address" DataField="Address" />
                        <asp:BoundField HeaderText="Date" DataField="Date" />
                        <asp:BoundField HeaderText="Description" DataField="Description" />
                        <asp:BoundField HeaderText="Rupees" DataField="Rupees" />
                        <asp:BoundField HeaderText="Total" DataField="Total"/>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
