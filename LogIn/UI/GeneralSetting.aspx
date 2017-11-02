<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="GeneralSetting.aspx.cs" Inherits="LogIn.UI.GeneralSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
            <div class="row">
             
                  <div class="col-lg-6 col-md-10 col-sm-10">
                            <legend class="legend">General Setting</legend>
                           <div class="box-body" style="display: block;">
                    
										
					<div class="form-group">
                      <label >Company Title</label>
                      
                      <asp:TextBox runat="server" CssClass="form-control" ID="companyTitleTextBox" placeholder="Enter Company Title" ></asp:TextBox>
                    </div>
					
					<div class="form-group">
                      <label>Company Address</label>             
                        <asp:TextBox runat="server" placeholder="Enter Company Address" ID="companyAddressTextBox" CssClass="form-control" TextMode="multiline"></asp:TextBox>
                  </div>
					</div>
					
					<div class="form-group">
                      <label>Mobile No.</label>
                       <asp:TextBox runat="server" placeholder="+880: Contact Number" ID="mobileNoTextBox" CssClass="form-control"></asp:TextBox>

                    </div>
					
					<div class="form-group">
                     <label>Telephone No.</label>
                       <asp:TextBox runat="server" placeholder="+880: Contact Number" ID="telephoneNoTextBox" CssClass="form-control"></asp:TextBox>
                        </div>
					
					<div class="form-group">
                      <label>Company Website</label>
                       <asp:TextBox runat="server" placeholder="Company Website" ID="companyWebsiteTextBox" CssClass="form-control"></asp:TextBox>
                        
                        </div>
					 
					<div class="form-group">
                      <label >Company E-mail</label>
                      <asp:TextBox runat="server" placeholder="Company Website" ID="companyEmailTextBox" CssClass="form-control"></asp:TextBox>
                    </div>
                      <div class="form-group">
                      
                      <asp:Button runat="server" Text="Save" ID="companySaveButtonText" CssClass="btn btn-primary" OnClick="companySaveButtonText_OnClick"></asp:Button>
                      <asp:Button runat="server" Text="Edit" ID="companyEditTextBox" CssClass="btn btn-dribbble" OnClick="companyEditTextBox_OnClick"></asp:Button>
       
                    </div>
					
                  </div>  
                <div class="col-lg-6 col-md-12 col-sm-12">
                          
                    <legend class="legend">Details</legend>
                    <div class="box-backgound box-body " style="border: 1px groove #66cdaa; padding: 5px;">
					<div class="form-group">
					  <label>Company Title</label>
                      <asp:TextBox ID="companyCurrentNameTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>
                    </div>
					<div class="form-group">
					  <label for="">Company Address</label>
                      <asp:TextBox ID="companyCurrentAddressTextBox" runat="server" CssClass="form-control input-sm"  Font-Size="Medium" disabled="disabled" TextMode="MultiLine"></asp:TextBox>
					</div>
					<div class="form-group">
					  <label >Mobile No.</label>
                      <asp:TextBox ID="companyCurrentMobileNoTextBox" runat="server" CssClass="form-control input-sm" disabled="disabled" Font-Size="Medium"></asp:TextBox>	
					</div>
					<div class="form-group">
					  <label for="">Telephone No.</label>
					  <asp:TextBox ID="companyCurrentTelephoneTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>	
					</div>
				  
                       <div class="form-group">
					  <label for="">Company Website</label>
					  <asp:TextBox ID="companyCurrentWebsiteTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>	
					</div>     
                    <div class="form-group">
					  <label for="">Company Email</label>
					  <asp:TextBox ID="companyCurrentEmailTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>	
					</div>
                        </div>
                    </div>
         </div>


           </div>
  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
