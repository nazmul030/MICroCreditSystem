<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="PasswordSetting.aspx.cs" Inherits="LogIn.UI.PassWordSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
            <div class="row">
             
                  <div class="col-lg-6 col-md-10 col-sm-10">
                            <legend class="legend">Password Setting</legend>
                           <div class="box-body" style="display: block;">
                    
										
					<div class="form-group">
                      <label >Current Password</label>
                      
                      <asp:TextBox runat="server" CssClass="form-control" required="required"  ID="passwordTextBox" placeholder="Enter Company Title" ></asp:TextBox>
                    </div>
					
					<div class="form-group">
                      <label>New PassWord</label>             
                        <asp:TextBox runat="server" placeholder="Enter Company Address" ID="newPassWordTextBox" CssClass="form-control" TextMode="Password"></asp:TextBox>
                  </div>
					</div>
					
					<div class="form-group">
                      <label>Confirm Password</label>
                       <asp:TextBox runat="server" placeholder="Re-type Password" ID="confirmPasswordTextBox" CssClass="form-control" TextMode="Password"></asp:TextBox>

                    </div>
					
					<div class="form-group">
                     <label>Hints</label>
                       <asp:TextBox runat="server" placeholder="Hints of the password" ID="hintsTextBox" CssClass="form-control"></asp:TextBox>
                        </div>
                      <div class="form-group">
                      
                      <asp:Button runat="server" Text="Save" ID="companySaveButtonText" CssClass="btn btn-primary"></asp:Button>
                           <asp:Button runat="server" Text="Edit" ID="companyEditTextBox" CssClass="btn btn-dribbble"></asp:Button>
       
                    </div>
					
                  </div>  
         </div>


           </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
