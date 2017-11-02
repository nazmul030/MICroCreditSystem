<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="PayEMI.aspx.cs" Inherits="LogIn.UI.PayEMI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function() {
            $('#<%= noOfEMIToPayTextBox.ClientID %>').on
            change(function() {

                var noofemi = $('#<%=noOfEMITextBox.ClientID%>').val();
                var emiammount = $('#<%=emiToDepositeTextBox.ClientID%>').val();
                var totalammount = noofemi * emiammount;
                $('#<%=payEMIAmmountBalanceTextBox%>').val('totalammount');

            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
         <div class="row">
                        
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <legend class="legend">PAY EMI</legend>
                        <div class="col-lg-4 col-md-12 col-sm-12">
                          
                            <legend class="legend">Details</legend>
                            <div class="box-backgound box-body ">
					<div class="form-group">
					  <label for="">Customer Name</label>
                      <asp:TextBox ID="customeViewNameTextBox" runat="server" CssClass="form-control input-sm"  ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                    </div>
					<div class="form-group">
					  <label for="">Customer Account No.</label>
                      <asp:TextBox ID="customerViewAccNoTextBox" runat="server" CssClass="form-control input-sm"  Font-Size="Medium" ReadOnly="True"></asp:TextBox>
					</div>
					<div class="form-group">
					  <label for="">Customer Mobile No.</label>
                      <asp:TextBox ID="customerViewMobileNoTextBox" runat="server" CssClass="form-control input-sm"  ReadOnly="True" Font-Size="Medium"></asp:TextBox>	
					</div>
					<div class="form-group">
					  <label for="">Customer Address</label>
					    <asp:TextBox runat="server" ID="customerViewAddressTextBox" CssClass="form-control input-sm" TextMode="MultiLine" ReadOnly="True"/>

					</div>
				    </div>
                            
                        </div>
                        <div class="col-lg-8 col-md-12 col-sm-12">
                    
                     <div class="modal-header">
						<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
						<h4 class="modal-title">Payment Option</h4>
					  </div>
					  <div class="modal-body">
						<hr style="margin-top:10px; margin-bottom:10px;">
						
                            <div class="row">
						        <div class="col-md-6">
								    <label>Loan Code &nbsp;:&nbsp;</label>
                                 <asp:TextBox runat="server" ID="loanCodeTextBox" CssClass="form-control input-sm"  ReadOnly="false"/>
                                <br><br />
							    </div>
							</div>
						    <div class="row">
						        <div class="col-md-6">
								    <label>Principal Amount &nbsp;:&nbsp;</label>
                                 <asp:TextBox runat="server" ID="principalAmmountTextBox" CssClass="form-control input-sm"  ReadOnly="True"/>
                                <br><br />
							    </div>
							</div>
                            <div class="row">
                              <div class="col-md-6">
								<label>End Date&nbsp;:&nbsp;</label>
                               <asp:TextBox runat="server" ID="endDateTExtBox" CssClass="form-control input-sm"  ReadOnly="True"/>

							</div>
							
							<div class="col-md-6">
								<label>EMI To Deposite&nbsp;:&nbsp;</label>
								<asp:TextBox runat="server" ID="emiToDepositeTextBox" CssClass="form-control input-sm"  ReadOnly="True"/>
				            </div>
                           </div>
							<div class="row">
							<div class="col-md-6">
								<label>Penalty Amount:&nbsp; </label><span>0 (0 * 4% )</span>
                             <asp:TextBox runat="server" ID="penaltyAmmountTextBox" CssClass="form-control input-sm"  ReadOnly="True"/>

													</div>

							</div>
						
						<hr style="margin-top:10px; margin-bottom:10px;">
						
						<hr style="margin-top:10px; margin-bottom:10px;">
						
						
						<div class="row">
							<div class="col-md-4">
								<label>Total Remaining EMI&nbsp;:</label>
							</div>
							<div class="col-md-8">
								   <asp:TextBox runat="server" ID="noOfEMITextBox" CssClass="form-control input-sm" ReadOnly="True"/>

							</div>
						</div>
						
						<hr style="margin-top:10px; margin-bottom:10px;">
						
						<div class="row">
							<div class="col-md-4">
								<label>Payment Date:</label>
								</div>
                            <div class="col-md-8">
                            	   <asp:TextBox runat="server" ID="currentDateTextBox" CssClass="form-control input-sm"  ReadOnly="True"/>
          
							</div>
                          <hr style="margin-top:10px; margin-bottom:10px;">
                          <%--<div class="row">
							<div class="col-md-3">
								<label>EMI Amount:</label><br>
							</div>
                              <div class="col-md-2">
                   <asp:DropDownList AutoPostBack="true" ID="noofEMIPaySelectDropDownList"  runat="server" ViewStateMode="Enabled" CssClass="form-control" OnSelectedIndexChanged="noofEMIPaySelectDropDownList_SelectedIndexChanged" >
                        <asp:ListItem Enabled="true" Text="Select NO. Of EMI" Value="-1"></asp:ListItem>
                       <asp:ListItem Text="1" Value="1"></asp:ListItem>
                       <asp:ListItem Text="2" Value="2"></asp:ListItem>
                       <asp:ListItem Text="3" Value="3"></asp:ListItem>
                       <asp:ListItem Text="4" Value="4"></asp:ListItem>
                       <asp:ListItem  Text="5" Value="5"></asp:ListItem>
                       <asp:ListItem Text="6" Value="6"></asp:ListItem>
                       <asp:ListItem Text="7" Value="7"></asp:ListItem>
                       <asp:ListItem Text="8" Value="8"></asp:ListItem>
                       <asp:ListItem Text="9" Value="9"></asp:ListItem>
                        <asp:ListItem Text="10" Value="7"></asp:ListItem>
                       <asp:ListItem Text="11" Value="8"></asp:ListItem>
                       <asp:ListItem Text="12" Value="9"></asp:ListItem>

                  </asp:DropDownList>
                               </div>
                              <div class="col-md-5">
                                   <asp:TextBox runat="server" ID="emiTotalAmmountTextBox" CssClass="form-control input-sm"  />
                              </div>
                             
                   	</div>--%>
                <div class="row">
					 <div class="col-md-3">
								<label>No Of EMI:</label><br>
							</div>
                              <div class="col-md-4">
                                    <asp:TextBox runat="server" ID="noOfEMIToPayTextBox" CssClass="form-control input-sm" OnTextChanged="noOfEMIToPayTextBox_TextChanged" AutoPostBack="True"></asp:TextBox>
                               </div>
                              <div class="col-md-4">
                              <asp:TextBox runat="server" ID="payEMIAmmountBalanceTextBox" CssClass="form-control input-sm" AutoPostBack="True" ReadOnly="True" ></asp:TextBox>
                                </div>
                             
                   	</div>
						</div>
                          <hr style="margin-top:10px; margin-bottom:10px;">
                          <div class="row">
                              <div class="col-md-4">
								<label>Penalty Amount(%):</label>
											  
                              </div>
                               <div class="col-md-6">
							 <asp:TextBox runat="server" ID="setPenaltyAmmount" CssClass="form-control input-sm"  />		             
                               </div>
                              
                          </div>
                          <hr style="margin-top:10px; margin-bottom:10px;">
						 <div class="row">
							<div class="col-md-4">
								<label>Payment Mode:</label>
								
							</div>
                             <div class="col-md-8">
                                  <asp:DropDownList AutoPostBack="true" ID="paymentModeDropDownList"  runat="server" ViewStateMode="Enabled" CssClass="form-control">
                        <asp:ListItem Enabled="true" Text="CASH" Value="CASH"></asp:ListItem>
                        <asp:ListItem Text="CHEQUE" Value="CHEQUE"></asp:ListItem>
                       

                  </asp:DropDownList>
                             </div>
						 </div>
						<hr style="margin-top:10px; margin-bottom:10px;">	
							
						</div>
						
						
					   <div class="modal-footer">
					                   <asp:Button ID="clearButton" runat="server" Text="CLEAR" CssClass="btn btn-danger pull-right" />
						               <asp:Button ID="saveButton" runat="server" Text="SAVE" CssClass="btn btn-primary pull-right" OnClick="saveButton_Click" />

                           		       
					  </div>
					  <div class="overlay" style="display:none;">
						  <i class="fa fa-refresh fa-spin"></i>
						</div>
					
        
                        </div>
                        
                       
                    </div>
       
                    
                </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>



  