<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="Expenses.aspx.cs" Inherits="LogIn.UI.ExPenses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script>
       $(function () {
           $('#<%= searchDateTextBox.ClientID %>').datepicker(
             {
                 changeMonth: true,
                 changeYear: true
             }
             );
      });
   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid" >
      <div class="row">
         <div class="col-lg-6 col-md-10 col-sm-10">
            <legend class="legend">Expense</legend>
            <div class=" box-body"  style="background-color:white;">
               <!--<div class="form-group">
                  <label >Account No.</label>
                  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
                  </div>-->
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="loanDate">Search By Date</label>
                        <div class="input-group">
                           <div class="input-group-addon">
                              <i class="fa fa-calendar"></i>
                           </div>
                           <asp:TextBox runat="server" placeholder="Date "   CssClass="form-control" ID="searchDateTextBox"></asp:TextBox>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-6">
                     <div class="form-group">
                        <%--<asp:RadioButton ID="All Date" runat="server" GroupName="Date" Text="Male" />
                           <asp:RadioButton ID="Select Date" runat="server" GroupName="gender" Text="Female" />--%>
                     </div>
                  </div>
               </div>
               <div class="col-md-offset-4 col-md-4">
                  <div class="form-group">
                     <asp:Button runat="server" Text="Search" ID="searchDateButton" CssClass="btn btn-primary" />
                  </div>
               </div>
            </div>
         </div>
      </div>
      <div class="row">
         <div class="col-lg-12 col-md-12 col-sm-12">
            <hr/>
            <hr/>
            <legend class="legend">Expences</legend>
            <div class="row">
               <div class="form-group">
                  <div class="col-md-offset-8 col-md-4 ">
                     <asp:TextBox runat="server" ID="searchTextBox" placeholder="Search by branch name or code"></asp:TextBox>
                     <asp:Button runat="server" Text="Search" CssClass="btn btn-primary" ID="searchByNameTextBook" />
                  </div>
               </div>
               <div class="box-body">
                  <asp:GridView ID="manageCapitalReturnGridview" runat="server"  AutoGenerateColumns="false" ViewStateMode="Enabled" CssClass="table table-striped table-bordered table-hover" PageSize="2" OnPageIndexChanging="manageCapitalReturnGridview_PageIndexChanging" AllowPaging="True">
                     <Columns>
                        <asp:TemplateField HeaderText="SL#">
                           <ItemTemplate>
                              <asp:Label runat="server" Text='<%#Container.DataItemIndex+1%>'></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                           <ItemTemplate>
                              <asp:Label runat="server" Text='<%#Eval("Date")%>'></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ammount">
                           <ItemTemplate>
                              <asp:Label runat="server" Text='<%#Eval("Ammount")%>'></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                           <ItemTemplate>
                              <asp:Label runat="server" Text='<%#Eval("Description")%>'></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PaymentMode">
                           <ItemTemplate>
                              <asp:Label runat="server" Text='<%#Eval("PaymentMode")%>'></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <%--<asp:BoundField datafield="Date" headertext="Date"/>
                           <asp:BoundField datafield="Ammount" headertext="Ammount"/>
                           <asp:Boundfield datafield="Description" headertext="Description"/>
                           <asp:Boundfield datafield="PaymentMode" headertext="PaymentMode"/>--%>
                     </Columns>
                  </asp:GridView>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server"></asp:Content>