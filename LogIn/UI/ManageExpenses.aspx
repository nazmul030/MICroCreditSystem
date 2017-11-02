<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageExpenses.aspx.cs" Inherits="LogIn.UI.ManageExpenses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
                 <div>
    <div class="row">
    <div class="col-md-8 col-md-offset-1">
      
        <form class="form-control" id="manageCustomerForm" role="form">
            <div class="form-group">
                <div class="col-sm-12">
                    <asp:GridView runat="server" ID="manageExpensesGridView" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Account Number">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text="Hello"></asp:Label>
                                  <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Customer Name">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text=''></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Loan Date">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text=''></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="End Date">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text=''></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Principal">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text=''></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="File Charge">
                                <ItemTemplate>
               <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                               </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Interest">
                                <ItemTemplate>
                               <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Time Period">
                                <ItemTemplate>
                                 <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Penalty">
                                <ItemTemplate>
                                   <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Total EMI">
                                <ItemTemplate>
                                     <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Due">
                                <ItemTemplate>
                                     <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="PenalTy Charge">
                                <ItemTemplate>
                                  <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                    </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="OutStanding">
                                <ItemTemplate>
                                <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:HyperLink runat="server" NavigateUrl='#'>Edit</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>


            </asp:GridView>
                     </div>
                 </div>
                   </form>
    </div><!-- /.col-lg-12 -->
</div><!-- /.row -->
</div>
             </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
