<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageCapitalReturn.aspx.cs" Inherits="LogIn.UI.ManageCapitalReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
         $(function () {
             $("#<%=returnDateTextBox.ClientID %>").datepicker(
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
                            <legend class="legend">Add Retund Capital</legend>
                           <div class=" box-body"  style="background-color:white;">
				
				<!--<div class="form-group">
				  <label >Account No.</label>
				  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
				</div>-->
				
				<div class="row">
				<div class="col-md-12">
				
					<div class="form-group">
					  <label for="loanDate">Return Date</label>
					  <div class="input-group">
						  <div class="input-group-addon">
							<i class="fa fa-calendar"></i>
						  </div>
					 <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="returnDateTextBox"  data-inputmask="'alias': 'dd/mm/yyyy'" data-mask=""></asp:TextBox>
					  </div>
					</div>
				 
				
				</div>
				</div>
				
				
				
			<div class="row">
				
				<div class="col-md-12">
					<div class="form-group">
					  <label for="fileCharge">Capital Ammount</label>
			  
					  <asp:TextBox runat="server"  CssClass="form-control input-sm" required="required" ID="capitalAmmountTextBox"  placeholder="Enter Capital Ammount" ></asp:TextBox>
                    </div>
				</div>
				
				
				</div>
				
				<div class="row">
				<div class="col-md-12">
				<div class="form-group">
				  <label for="timePeriods">Person Name</label>
				  <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="personNameTextBox"  placeholder="Person Name"></asp:TextBox>
                </div>
				</div>
				
				
				</div>
                
				<div class="row">
				<div class="col-md-12">
				<div class="form-group">
				  <label for="timePeriods">Branch Name</label>
				  <asp:DropDownList ID="brachNameDropDownList" runat="server" name="branchesDropDownList" CssClass="form-control input-sm">
                        <asp:ListItem Enabled="true" Text="Select Branch" Value="-1"></asp:ListItem>
                      <asp:ListItem Text="Dhaka" Value="1"></asp:ListItem>
                      <asp:ListItem Text="Chittagong" Value="2"></asp:ListItem>
                  </asp:DropDownList>
				</div>
				</div>

				</div>
				<div class="row">
				<div class="col-md-12">
				<div class="form-group">
				  <label for="timePeriods">Remark</label>
			      <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="remarkTextBox"  placeholder="Remark"></asp:TextBox>
				</div>
				</div>

				</div>
				
				<div class="col-md-offset-4 col-md-4">
					<div class="form-group">
					  <asp:Button runat="server" CssClass="btn btn-primary" Text="Save" ID="saveButton"/>
					</div>
				</div>
				
				
				</div>  
			   </div>


           </div>
          <div class="row">
              <div class="col-lg-12 col-md-12 col-sm-12">
                    <hr/>

                            <hr/>

                  <legend class="legend">Manage Capital Return</legend>
                  <div class="row">
                      <div class="form-group">
                        <div class="col-md-offset-8 col-md-4 ">
                            <asp:TextBox runat="server" ID="searchTextBox" ></asp:TextBox>
                              <asp:Button runat="server" Text="Search" CssClass="btn btn-primary" />
                      </div>
                  </div>
                 <div class="box-body">
			 <asp:GridView runat="server" ID="manageCapitalReturnGridview" AutoGenerateColumns="True">
                <Columns>
                    <asp:TemplateField HeaderText="SL. No">
                        <ItemTemplate>
                            <asp:Label runat="server" Text="Hello"></asp:Label>
                          <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Return Date">
                        <ItemTemplate>
                            <asp:Label runat="server" Text=''></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Person Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text=''></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Person Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text=''></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='Entry Date'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Remark">
                        <ItemTemplate>
       <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                       </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                       <!--    <asp:HyperLink runat="server" NavigateUrl=''>Edit</asp:HyperLink>-->
                        </ItemTemplate>
                    </asp:TemplateField>
                     
                </Columns>


            </asp:GridView>
						 </div>
              </div>
          </div>
                    
                </div>
            </div>
      <script src="../Scripts/jquery-3.2.1.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery-ui-1.12.1.js"></script>
  
     <script type="text/javascript">
         $(function () {
             $("#returnDateTextBox").datepicker(
                 {
                     changeMonth: true,
                     changeYear: true
                 }
                 );
         });
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
