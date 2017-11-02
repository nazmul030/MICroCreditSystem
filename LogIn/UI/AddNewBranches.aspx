<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="AddNewBranches.aspx.cs" Inherits="LogIn.UI.AddNewBranches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
      <div class="row">
         <div class="col-md-6">
            <div class="row">
               <div class="col-md-12">
                  <div class="form-group">
                     <label for="fileCharge">Branch Name</label>
                     <asp:TextBox ID="branchNameTextBox" CssClass="form-control input-sm"  placeholder="Enter the Branch Name" runat="server"></asp:TextBox>
                  </div>
               </div>
            </div>
            <div class="row">
               <div class="col-md-12">
                  <div class="form-group">
                     <label for="fileCharge">Code</label>
                     <asp:TextBox runat="server" ID="branchCodeTextBox" CssClass="form-control input-sm" placeholder="Enter the Branch Name"></asp:TextBox>
                  </div>
               </div>
            </div>
            <div class="row">
               <div class="col-md-12">
                  <div class="form-group">
                     <label for="fileCharge">Address</label>
                     <asp:TextBox runat="server" placeholder="Branch Address" ID="address_BranchesTextBox" CssClass="form-control" TextMode="multiline"></asp:TextBox>
                  </div>
               </div>
            </div>
            <div class="col-md-offset-4 col-md-4">
               <div class="form-group">
                  <asp:Button CssClass="btn btn-behance" ID="saveBranchesText"  runat="server" Text="Save" OnClick="saveBranchesText_Click" />
               </div>
            </div>
             <div class="row">
               <div class="col-md-12">
                  <div class="form-group">
                     <label for="fileCharge">Address</label>
                     <asp:TextBox runat="server"  ID="iDHiddenTextBox" CssClass="form-control" Visible="False"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server"></asp:Content>