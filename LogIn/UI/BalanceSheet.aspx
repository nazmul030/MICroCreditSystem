<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="BalanceSheet.aspx.cs" Inherits="LogIn.UI.BalanceSheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       $(function () {
           $("#<%=fromSelectDateTextBox.ClientID %>").datepicker(
                {
                    changeMonth: true,
                    changeYear: true
                }
                );
      });
      $(function () {
          $("#<%=toSelectDateTextBox.ClientID %>").datepicker(
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
            <legend class="legend">Cash Book</legend>
            <div class=" box-body"  style="background-color:white;">
               <!--<div class="form-group">
                  <label >Account No.</label>
                  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
                  </div>-->
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="loanDate">From</label>
                        <div class="input-group">
                           <div class="input-group-addon">
                              <i class="fa fa-calendar"></i>
                           </div>
                           <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="fromSelectDateTextBox"  data-inputmask="'alias': 'dd/mm/yyyy'" data-mask=""></asp:TextBox>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="loanDate"> To</label>
                        <div class="input-group">
                           <div class="input-group-addon">
                              <i class="fa fa-calendar"></i>
                           </div>
                           <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="toSelectDateTextBox"  data-inputmask="'alias': 'dd/mm/yyyy'" data-mask=""></asp:TextBox>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="loanDate">Branches</label>
                        <div class="input-group">
                           <div class="input-group-addon">
                           </div>
                           <asp:DropDownList ID="loanDepositeOptionDropDownList" runat="server" name="groupDropDownList" CssClass="form-control">
                              <asp:ListItem Enabled="true" Text="Select Group" Value="-1"></asp:ListItem>
                              <asp:ListItem Text="Dhaka" Value="1"></asp:ListItem>
                              <asp:ListItem Text="Comilla" Value="2"></asp:ListItem>
                           </asp:DropDownList>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="col-md-offset-4 col-md-4">
                  <div class="form-group">
                     <asp:Button runat="server" Text="Search" ID="searchCashButton" CssClass="btn btn-behance"/>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <div class="row">
         <div class="col-lg-12 col-md-12 col-sm-12">
            <hr/>
            <hr/>
            <legend class="legend">Cash Sheet</legend>
            <div class="row">
               <div class="form-group">
                  <div class="col-md-offset-8 col-md-4 ">
                     <asp:TextBox runat="server" ID="searchTextBox" ></asp:TextBox>
                     <asp:Button runat="server" Text="Search" CssClass="btn btn-primary" />
                  </div>
               </div>
               <div class="box-body">
                  <asp:GridView runat="server" ID="cashBookGridView" AutoGenerateColumns="True">
                     <Columns>
                        <asp:TemplateField HeaderText="Particular">
                           <ItemTemplate>
                              <asp:Label runat="server" Text="Hello"></asp:Label>
                              <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Recieved">
                           <ItemTemplate>
                              <asp:Label runat="server" Text=''></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Payment">
                           <ItemTemplate>
                              <asp:Label runat="server" Text=''></asp:Label>
                           </ItemTemplate>
                        </asp:TemplateField>
                     </Columns>
                  </asp:GridView>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
   <script type="text/javascript">
       $(document).ready(function () {

           // Javascript method's body can be found in assets/js/demos.js
           demo.initDashboardPageCharts();

       });
   </script>
</asp:Content>