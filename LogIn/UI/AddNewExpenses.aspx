<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="AddNewExpenses.aspx.cs" Inherits="LogIn.UI.AddNewExpenses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       $(function () {
           $("#<%=addExpenseDateTextBox.ClientID %>").datepicker(
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
            <legend class="legend">Add New Expenses</legend>
            <div class=" box-body"  style="background-color:white;">
               <!--<div class="form-group">
                  <label >Account No.</label>
                  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
                  </div>-->
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="loanDate">Date</label>
                        <div class="input-group">
                           <div class="input-group-addon">
                              <i class="fa fa-calendar"></i>
                           </div>
                           <asp:TextBox runat="server" CssClass="form-control input-sm" ID="addExpenseDateTextBox" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="fileCharge">Ammount</label>
                        <asp:TextBox runat="server" ID="ammountTextBox" CssClass="form-control input-sm" placeholder="Enter The Ammount"></asp:TextBox>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <label for="fileCharge">Payment  Mode</label>
                        <asp:RadioButton runat="server" GroupName="paymentModeRadioButton" ID="chequeRadioButton" Text="Cheque" CssClass="radio-inline"/>
                        <asp:RadioButton runat="server" GroupName="paymentModeRadioButton" ID="cashRadioButton" name="selectedDateRadioButton" Text="Cash" CssClass="radio-inline"/>
                     </div>
                  </div>
               </div>
               <div class="row">
                  <div class="col-md-12">
                     <div class="form-group">
                        <asp:TextBox runat="server" placeholder="description" ID="descriptionTextBox" CssClass="form-control" TextMode="multiline"></asp:TextBox>
                     </div>
                  </div>
               </div>
               <div class="col-md-offset-4 col-md-4">
                  <div class="form-group">
                     <asp:Button runat="server" Text="Save" ID="saveExpensesButton" CssClass="btn btn-behance" OnClick="saveExpensesButton_OnClick"/>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server"></asp:Content> 