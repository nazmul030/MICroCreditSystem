<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageBranches.aspx.cs" Inherits="LogIn.UI.ManageBranches" %>
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
            <asp:GridView runat="server" ID="branchesGridView" Height="155px" Width="718px" AutoGenerateColumns="false" ViewStateMode="Enabled" CssClass="table table-striped table-bordered table-hover" PageSize="2" OnPageIndexChanging="branchesGridView_PageIndexChanging" AllowPaging="True">
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Container.DataItemIndex+1%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Branch Code">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("BranchCode")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Branch Name">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("BranchName")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Address">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("Address")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField>
                           <ItemTemplate>
                               <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("AddNewBranches.aspx?BranchNo={0}",Eval("BranchCode")) %>'>Edit</asp:HyperLink>
                               <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("ManageBranches.aspx?BranchNo={0}",Eval("Id")) %>'>Delete</asp:HyperLink>
                  
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
