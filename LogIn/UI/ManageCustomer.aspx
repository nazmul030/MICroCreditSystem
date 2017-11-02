

<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="LogIn.UI.ManageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
      <div class="row">
         <legend class="legend">Manage Customer</legend>
         <div class=" col-lg-offset-3 col-lg-9 col-md-12 col-sm-12">
            <div class="form-group">
               <div class="col-md-offset-4 col-md-8 ">
                  <div class="form-group">
                     <asp:TextBox runat="server" ID="searchTextBox" placeholder="Search by branch name or code" CssClass="form-control"></asp:TextBox>
                     <asp:Button runat="server" Text="Search" CssClass="btn btn-primary" ID="searchByNameTextBook" />
                  </div>
               </div>
            </div>
         </div>
      </div>
      <div class="row" >
         <div class="col-lg-6 col-md-12 col-sm-12">
            <asp:GridView runat="server" ID="customerManageGridview" Height="155px" Width="718px" AutoGenerateColumns="false" ViewStateMode="Enabled" CssClass="table table-striped table-bordered table-hover" PageSize="2" OnPageIndexChanging="customerManagerGridview_PageIndexChanging" AllowPaging="True" >
               <Columns>
                  <asp:TemplateField HeaderText="SL#">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Container.DataItemIndex+1%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="First Name">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("FirstName")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Last Name">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("LastName")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Date Of Birth">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("DateOfBirth")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Gender">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Gender")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Contact NO.">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("ContactNo")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Branch Name">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("BranchName")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Present Address">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("PresentAddress")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Permanent Address">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("PermanentAddress")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Account NO.">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("AccountNo")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Guarantor ACC. NO.">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("GuarantorAccount")%>'></asp:Label>
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="LOAN">
                     <ItemTemplate>
                        <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("AddNewCustomer.aspx?AccountNo={0}",Eval("AccountNo")) %>' >Edit</asp:HyperLink>
                        <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("AddPersonalLoan.aspx?AccountNo={0}",Eval("AccountNo")) %>' >Add Loan</asp:HyperLink>
                        <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("AddPersonalLoan.aspx?AccountNo={0}",Eval("AccountNo")) %>' >Delete</asp:HyperLink>
                     </ItemTemplate>
                  </asp:TemplateField>
               </Columns>
            </asp:GridView>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server"></asp:Content>

