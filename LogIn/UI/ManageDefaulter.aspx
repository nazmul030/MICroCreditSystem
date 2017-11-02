<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageDefaulter.aspx.cs" Inherits="LogIn.UI.ManageDefaulter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
                         <div class="row">
                            <legend class="legend">Manage Defaulter</legend>
                              <div class="col-lg-6 col-md-12 col-sm-12">
                                         <asp:GridView runat="server" ID="manageDefaulterGridView" AutoGenerateColumns="True" Height="155px" Width="718px">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Acc. No.">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text="Hello"></asp:Label>
                                                      <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Name">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField HeaderText="Contact">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Branch">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Loan Type">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text='Entry Date'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Loan Date">
                                                    <ItemTemplate>
                                   <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                                   </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Principle">
                                                    <ItemTemplate>
                                                   <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Interest %">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text="Hello"></asp:Label>
                                                      <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="EMI">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField HeaderText="Remaining  EMI">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Loans">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Pay EMI">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text="Hello"></asp:Label>
                                                      <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Action">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text=''></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                               
                     
                                            </Columns>


                                        </asp:GridView>     
                              </div>
                    </div>
              
                </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
