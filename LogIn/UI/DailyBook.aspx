<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="DailyBook.aspx.cs" Inherits="LogIn.UI.DailyBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
            <div class="row">
             
                  <div class="col-lg-6 col-md-10 col-sm-10">
                            <legend class="legend">Daily Book</legend>
                           <div class=" box-body"  style="background-color:white;">
				
				<!--<div class="form-group">
				  <label >Account No.</label>
				  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
				</div>-->
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
					   <asp:Button runat="server" Text="Search" ID="searchBranchButton" CssClass="btn btn-behance"/>
			
					 
					</div>
				</div>
				
				
				</div>  
			   </div>


           </div>
          <div class="row">
              <div class="col-lg-12 col-md-12 col-sm-12">
                    <hr/>

                            <hr/>

                  <legend class="legend">Day Book</legend>
                  <div class="row">
                      <div class="form-group">
                        <div class="col-md-offset-8 col-md-4 ">
                            <asp:TextBox runat="server" ID="searchTextBox" ></asp:TextBox>
                              <asp:Button runat="server" Text="Search" CssClass="btn btn-primary" />
                      </div>
                  </div>
                 <div class="box-body">
							 <asp:GridView runat="server" ID="dailyBookGridView" AutoGenerateColumns="True">
                <Columns>
                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label runat="server" Text="Hello"></asp:Label>
                          <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Branch Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='Total Rec.'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Total Credit.">
                        <ItemTemplate>
                            <asp:Label runat="server" Text=''></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>    
                </Columns>


            </asp:GridView>
						 </div>
              </div>
                  <div class="row">
                      <div class="form-group">
                      
                      <asp:Button runat="server" Text="Save" ID="printDailyBookButton" CssClass="btn btn-primary"></asp:Button>
                     
                    </div>
                  </div>
          </div>
                    
                </div>
            </div>
</asp:Content>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
