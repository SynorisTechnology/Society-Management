<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerActive.aspx.cs" Inherits="Society_Maharanapratab.CustomerActive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
        <table>
        <tr>
            <td>
                <h3>Customer ReActive</h3>
            </td>
        </tr>
            <tr>
                <td><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="dvtable" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" CellSpacing="1" PageSize="50" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                     <Columns>
                      
                        <asp:BoundField HeaderText="Name" DataField="Name" />
                        <asp:BoundField HeaderText="FatherName" DataField="FatherName" />
                        <asp:BoundField HeaderText="Address" DataField="Address" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Date Of Birth" DataField="DateOfBirth" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" />
                        <asp:BoundField HeaderText="Mobile No" DataField="MobileNo" />
                        <asp:BoundField HeaderText="Gender" DataField="Gender" />
                        <asp:BoundField HeaderText="Age" DataField="Age" />
                        <asp:BoundField HeaderText="Emergency Contact Name" DataField="EmergencyContactName" />
                        <asp:BoundField HeaderText="Emergency Contact No" DataField="EmergencyContactNo" />
                          <asp:TemplateField>
                                <ItemTemplate>
                          <asp:LinkButton ID="lbtnReActive" CommandArgument='<%# Bind("RegistrationID") %>' CommandName="ReActive"
                          OnClientClick="return confirm('Do you want to ReActive the record ? ');" runat="server" >ReActive</asp:LinkButton>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                    <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="1" PreviousPageText="Previous" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    
</asp:Content>
