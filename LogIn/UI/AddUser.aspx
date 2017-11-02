<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="LogIn.UI.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid" >
               
                  <div class="row">
    <div class="col-md-8 col-md-offset-1">
      
       
         <fieldset>

          <!-- Form Name -->
          <legend>Add New Customer</legend>
         <form id="form1" CssClass="form-horizontal" role="form">
          <!-- Text input-->
          <div class="form-group">
           <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="First Name" ID="firstNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="col-md-6">
              <asp:TextBox runat="server" placeholder="Last Name" ID="lastNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
           </div>
          </div>

          <!-- Text input-->
          <div class="form-group">
           <div class="row">
                <div class="col-md-6">
              <asp:TextBox runat="server" placeholder="Date of Birth"   CssClass="form-control" ID="dateTextBox"></asp:TextBox>
            </div>
              <div class="col-md-6">
              <asp:TextBox runat="server" placeholder="+880: Contact Number" ID="contactTextBox" CssClass="form-control"></asp:TextBox>
            </div>
           </div>
          </div>

          <!-- Text input-->
             <label class="control-label"><u>Gender</u></label>

          <div class="form-group">
           <div class="row">
                  
            <div class="col-md-2">
               <asp:RadioButton runat="server" GroupName="genderRadioButton" ID="maleRadioButton" Text="Male" CssClass="radio-inline"/>

            </div>
               <div class="col-md-2">
              <asp:RadioButton runat="server" GroupName="genderRadioButton" ID="femaleRadioButton" Text="Female" CssClass="radio-inline"/>
            </div>
              <div class="col-md-2">
              <asp:RadioButton runat="server" GroupName="genderRadioButton" ID="otherRadioButton" Text="Other" CssClass="radio-inline"/>
            </div>
             
           </div>
          </div>
          <div class="form-group">
             <div class="row">
                  <label class="col-md-2">Upload Image:</label>
                 <div class="col-md-2">
                  <asp:FileUpload id="customerImageUploadFile" runat="server"  />
                    </div>
              <label class="col-md-offset-2 col-sm-2">Uoload NID:</label>
               <div class="col-md-2">
                  <asp:FileUpload id="customerIdUploadFile" runat="server"  />
               </div>
             </div>

          </div>    
          

<!-- Address Section -->
          <!-- Form Name -->
          <legend>Address Details</legend>
          <!-- Text input-->
          <div class="form-group">
            <div class="row">
                <div class="col-md-10">
              <asp:TextBox runat="server" placeholder="Present Address" ID="presentAddressTextBox" CssClass="form-control" TextMode="multiline"></asp:TextBox>
                  </div>
            </div>
          </div>
          <!-- Text input-->
          <div class="form-group">
            <div class="row">
                <div class="col-md-10">
                <asp:TextBox runat="server" placeholder="Permenent Address" ID="permenantAddressTextBox" CssClass="form-control" TextMode="multiline"></asp:TextBox>
                </div>
            </div>
          </div>
          <!-- Text input-->
          <div class="form-group">
            <div class="row">
                <div class="col-md-4">
                <asp:TextBox runat="server" placeholder="City" name="cityTextBox" CssClass="form-control"></asp:TextBox>
                </div>
                 <div class="col-md-4">
                <asp:TextBox runat="server" placeholder="State" ID="stateTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
               <asp:TextBox runat="server" placeholder="Postal Code" ID="postalCodeTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
           
          </div>
<!-- Parent/Guadian Contact Section -->
          <!-- Form Name -->
          <legend>Father/Husband Information</legend>
          <!-- Text input-->
          <div class="form-group">
            <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="Parent/Husband First Name" ID="parentFirstNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
              <asp:TextBox runat="server" placeholder="Parent/Husband Last Name" ID="parentLastNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
          
            </div>
          </div>
          <div class="form-group">
           <div class="row">
                <div class="col-md-4">
                <asp:TextBox runat="server" placeholder="Contact Number" ID="parentContactNoTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:TextBox runat="server" placeholder="Parent/Husband Email"  CssClass="form-control" ID="parentEmailTextTextBox"></asp:TextBox>
            </div>
           </div>
           </div>
           

<!-- Emergency Contact Section -->
          <!-- Form Name -->
         
          <legend>Guarentor Information</legend>
         <!-- Text input-->
          <div class="form-group">
            <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder=" First Name" ID="guarentorFirstNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
              <asp:TextBox runat="server" placeholder=" Last Name" ID="guarentortLastNameTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
           
          </div>
          <div class="form-group">
          <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="Contact Number" ID="guarentorContactNoTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="Email" CssClass="form-control" ID="guarentorEmailTextTextBox"></asp:TextBox>
            </div>
          </div>
         </div>
              <div class="form-group">
               <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="Account Number" ID="guarentorAccountNoTextBox" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
           </div>
           <div class="form-group">
             <div class="row">
                  <label class="col-md-2">Upload Image:</label>
                 <div class="col-md-2">
                  <asp:FileUpload id="guarenterImageFileUpload" runat="server"  />
                    </div>
              <label class="col-md-offset-2 col-md-2">Uoload NID:</label>
               <div class="col-md-2">
                  <asp:FileUpload id="guarenterNidFileUpload" runat="server"  />
               </div>

             </div>
          </div>   
              
  <!-- Form Name -->
        

          <legend>Account Informetion</legend>
         <!-- Text input-->
           <div class="form-group">
               <div class="row">
                   <div class="col-md-6">
                   <asp:DropDownList ID="loanDepositeSelectDropDownList" runat="server" name="branchesDropDownList" CssClass="form-control">
                        <asp:ListItem Enabled="true" Text="Select Loan/Deposite" Value="-1"></asp:ListItem>
                      <asp:ListItem Text="Loan" Value="1"></asp:ListItem>
                      <asp:ListItem Text="Deposite" Value="2"></asp:ListItem>
                  </asp:DropDownList>
               </div>
               <div class="col-md-6">
                   <asp:DropDownList ID="loanDepositeOptionDropDownList" runat="server" name="groupDropDownList" CssClass="form-control">
                    <asp:ListItem Enabled="true" Text="Select Group" Value="-1"></asp:ListItem>
                     <asp:ListItem Text="F-1" Value="1"></asp:ListItem>
                      <asp:ListItem Text="F-2" Value="2"></asp:ListItem>
                  </asp:DropDownList>
               </div>
               </div>
           </div>
           
               <div class="form-group">
            <div class="row">
                <div class="col-md-6">
                <asp:TextBox runat="server" placeholder="Customer Account No." ID="accountNoTextBox" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
             
           </div>
           <div class="form-group">
             <div class="row">
                   <div class="col-md-6">
                   <asp:DropDownList ID="branchesDropDownList" runat="server" name="branchesDropDownList" CssClass="form-control">
                    <asp:ListItem Enabled="true" Text="Select Branches" Value="-1"></asp:ListItem>
                     <asp:ListItem Text="Dhaka" Value="1"></asp:ListItem>
                      <asp:ListItem Text="Barishal" Value="2"></asp:ListItem>
                  </asp:DropDownList>
               </div>
               <div class="col-md-6">
                   <asp:DropDownList ID="groupDropDownList" runat="server" name="groupDropDownList" CssClass="form-control">
                    <asp:ListItem Enabled="true" Text="Select Group" Value="-1"></asp:ListItem>
                     <asp:ListItem Text="F-1" Value="1"></asp:ListItem>
                      <asp:ListItem Text="F-2" Value="2"></asp:ListItem>
                  </asp:DropDownList>
               </div>
             </div>
           </div>
           
            
<!-- Command -->
          <div class="form-group">
            <div class="row">
                <div class="col-sm-5 col-sm-offset-1">
              <div class="pull-right">
               <asp:Button ID="cancelButton" runat="server" Text="Cancel" CssClass="btn btn-danger" OnClick="cancelButton_OnClick" />
                  <asp:Button ID="saveButton" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="saveButton_OnClick"/>
              </div>
            </div>
            </div>
          </div>
           </form>  
        </fieldset>
       
    </div><!-- /.col-lg-12 -->
</div><!-- /.row -->

           </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
