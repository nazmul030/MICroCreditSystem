<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="RunningLoan.aspx.cs" Inherits="LogIn.UI.RunningLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#selectDate").hide();
            $("#<%= selectedDateRadioButton.ClientID %>").click(function () {
                $("#selectDate").show();
            });
            $("#<%= allDateRadioButton.ClientID %>").click(function () {
                $("#selectDate").hide();
            });
            $("#<%= fromSelectDateTextBox.ClientID %>").datepicker(
                {
                    changeMonth: true,
                    changeYear: true
                }
                );
            $("#<%= toSelectDateTextBox.ClientID %>").datepicker(
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
                            <legend class="legend">All Running Loan</legend>
                           <div class=" box-body"  style="background-color:white;">
				
				<!--<div class="form-group">
				  <label >Account No.</label>
				  <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
				</div>-->
				<div class="row">
				<div class=" col-md-6">
				<div class="form-group">
				   <asp:RadioButton runat="server" GroupName="dateRadioButton" ID="allDateRadioButton" Text="All Date" CssClass="radio-inline"/>
                   <asp:RadioButton runat="server" GroupName="dateRadioButton" ID="selectedDateRadioButton" name="selectedDateRadioButton" Text="Select Date" CssClass="radio-inline"/>
				</div>
				</div>

				</div>
				<div class="row" id="selectDate">
				       
				        <div class="col-lg-6">
				          <div class="input-group">
						  <div class="input-group-addon">
							<i class="fa fa-calendar"></i>
						  </div>
					   <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="fromSelectDateTextBox"  data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="" placeholder="From"></asp:TextBox>
					  </div>
				        </div>
                    <div class="col-lg-6">
				          <div class="input-group">
						  <div class="input-group-addon">
							<i class="fa fa-calendar"></i>
						  </div>
					   <asp:TextBox runat="server" CssClass="form-control input-sm" required="required" ID="toSelectDateTextBox"  data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="" placeholder="To"></asp:TextBox>
					  </div>
				        </div>
                    </div>
				<div class="col-md-offset-4 col-md-4">
					   <div class="form-group">
					         <asp:Button runat="server" CssClass="btn btn-primary" ID="Search" Text="Search"/>
					 
					</div>
				</div>
				
				
				</div>  
			   </div>


           </div>
          <div class="row">
              <div class="col-lg-12 col-md-12 col-sm-12">
                    <hr/>

                            <hr/>

                  <legend class="legend">Manage Capital Recieved</legend>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
