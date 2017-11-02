<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="AddPersonalLoan.aspx.cs" Inherits="LogIn.UI.AddPersonalLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {

            // Javascript method's body can be found in assets/js/demos.js

            $("#<%=loanDateTextBox.ClientID %>").datepicker(
                  {
                      changeMonth: true,
                      changeYear: true
                  }
                  );

        });

  function Calculation() {
        
           var principalammount = document.getElementById("#<%=loanDateTextBox.ClientID %>").value;
            var interestrate= document.getElementById("#<%=interestRateTextBox.ClientID%>").value;
            var timeperiod = document.getElementById("#<%=timePeriodTextBox.ClientID%>").value;
            var filecharge = (document.getElementById("#<%=fileChargeTextBox%>").value * pricipalammount) / 100;
             
              var  InterestAmmountPerMonth = (((pricipalammount * interestrate) / 100) / 12);
               var InterestAmmountInTimePeriod = InterestAmmountPerMonth * timeperiod;
              var  InterestAmmountPerYear = InterestAmmountPerMonth * 12;
               var TotalAmmount = pricipalammount + InterestAmmountInTimePeriod + filecharge;
               var TotalInstallPerMonth = TotalAmmount / timeperiod;
           
            document.getElementById("#<%=totalAmmountTextBox.ClientID%>").value = "TotalAmmount";
            document.getElementById("#<%=interestAmtperMonthTextBox.ClientID%>").value = "InterestAmmountPerMonth";
            document.getElementById("#<%=interestAmtPerYearTextBox.ClientID%>").value = "InterestAmmountPerYear";
            document.getElementById("#<%=emiAmmountTextBox.ClientID%>").value = "TotalInstallPerMonth";
      alert("Done");
  }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" >
         <div class="row">
                        <div class="col-lg-4 col-md-12 col-sm-12">
                          
                        <legend class="legend">Details</legend>
                        <div class="box-backgound box-body ">
					<div class="form-group">
					  <label for="">Customer Name</label>
                      <asp:TextBox ID="customeViewNameTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>
                    </div>
					<div class="form-group">
					  <label for="">Customer Account No.</label>
                      <asp:TextBox ID="customerViewAccNoTextBox" runat="server" CssClass="form-control input-sm"  Font-Size="Medium"></asp:TextBox>
					</div>
					<div class="form-group">
					  <label for="">Customer Mobile No.</label>
                      <asp:TextBox ID="customerViewMobileNoTextBox" runat="server" CssClass="form-control input-sm"  disabled="disabled" Font-Size="Medium"></asp:TextBox>	
					</div>
					<div class="form-group">
					  <label for="">Customer Permenant Address</label>
					    <asp:TextBox runat="server" ID="customerViewAddressTextBox" CssClass="form-control input-sm" TextMode="MultiLine" disabled="disabled"/>

					</div>
				    </div>
                            
                        </div>
                        <div class="col-lg-8 col-md-12 col-sm-1">
                            <legend class="legend">Loan Details</legend>
                           <div class=" box-body"  style="background-color:white;">
				
				        <!--<div class="form-group">
				          <label >Account No.</label>
				          <input type="text" class="form-control input-sm" value="1729" disabled="disabled">
				        </div>-->
				
				        <div class="row">
				        <div class="col-md-6">
				
					        <div class="form-group">
					          <label for="loanDate">Loan Date</label>
					          <div class="input-group">
						          <div class="input-group-addon">
							        <i class="fa fa-calendar"></i>
						          </div>
					              <asp:TextBox ID="loanDateTextBox" runat="server" CssClass="form-control input-sm" required="required" name="loanDate" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="" Font-Size="Medium"></asp:TextBox>
					          </div>
					        </div>
                            <%--<input type="hidden" name="customer_ID" class="form-control input-sm" value="32bb90e848" readonly="readonly">--%>
				        </div>
				
				            <div class="col-md-6">
					            <div class="form-group">
					              <label for="principalAmt">Principal Amount</label>
                                    <asp:TextBox ID="principalAmmountTextBox" runat="server" CssClass="form-control input-sm" required="required" name="principalAmt" placeholder="Enter Principal Amount" Font-Size="Medium" OnTextChanged="principalAmmountTextBox_TextChanged"></asp:TextBox>
					            </div>
				            </div>
				            </div>
				
				                    <div class="row">
				
				        <div class="col-md-6">
					        <div class="form-group">
					          <label for="fileCharge">File Charge(%)</label>
                                <asp:TextBox ID="fileChargeTextBox" runat="server" CssClass="form-control input-sm" required="required" name="fileCharge" placeholder="Enter File Charge" Font-Size="Medium"></asp:TextBox>
                            </div>
				        </div>
				
				        <div class="col-md-6">
					        <div class="form-group">
					          <label for="interestRate">Interest Rate ( % per year)</label>
                                <asp:TextBox ID="interestRateTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestRate" placeholder="Enter Interest Rate, 18 per year" Font-Size="Medium"></asp:TextBox>
                                    </div>
				                </div>
				
				                </div>
				
				                <div class="row">
				                <div class="col-md-6">
				                <div class="form-group">
				                  <label for="timePeriods">Time Period (i.e. in months)</label>
                                  <asp:TextBox ID="timePeriodTextBox" runat="server" CssClass="form-control input-sm" required="required" name="timePeriods" placeholder="Enter Time Period, 20 or so" Font-Size="Medium"></asp:TextBox>
				                </div>
				                </div>
					                <div class="col-md-6">
					                <div class="form-group">
					                  <label for="interestRate">NO. Of  EMI</label>
                                                        <asp:TextBox ID="noOfEMIInputTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestRate" placeholder="Enter Total No. Of EMI" Font-Size="Medium"></asp:TextBox>
                                    </div>
				                </div>
                    	                <div class="col-md-6">
					                <div class="form-group">
					                  <label for="interestRate">EMI Ammount</label>
                                        <asp:TextBox ID="emiAmmountInputTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestRate" placeholder="Enter the ammount of EMI" Font-Size="Medium"></asp:TextBox>
                                    </div>
				                </div>
				                <div class="col-md-6">
				                    <div class="form-group">
					                  <label for="penalty">Penalty(%)</label>
                                      <asp:TextBox ID="penaltyTextBox" runat="server" CssClass="form-control input-sm" required="required" name="penalty" placeholder="Enter Penalty" Font-Size="Medium"></asp:TextBox>
					                </div>
				                </div>
				                </div>
				                <div class="row">
				                    <div class="col-md-4">
				                        <div class="form-group">
				                            <asp:Button runat="server" Text="Check" CssClass="btn btn-instagram" ID="checkButton" OnClick="checkButton_Click"/>
				                        </div>
                                        </div>
                   
                                        <div class="col-md-4">
                                            <div class="form-group">
                                            <asp:Button runat="server" Text="Clear" ID="clearButton" CssClass="btn btn-danger" OnClick="clearButton_Click" />
                                                </div>
                                        </div>
                   
				                </div>
                 	
				                <div class="row">
					                <div class="col-md-6">
						                <div class="form-group">
						                  <label for="interestAmtperMonth">Interest Amount per Month</label>
                                          <asp:TextBox ID="interestAmtperMonthTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestAmtPerMonth" ReadOnly="true" Font-Size="Medium" ClientIDMode="Static"></asp:TextBox>
						                </div>
					                </div>
					
					                <div class="col-md-6">
						                <div class="form-group">
						                  <label for="interestAmtperYear">Interest Amount per Year</label>
                                          <asp:TextBox ID="interestAmtPerYearTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestAmtPeryear" ReadOnly="true" Font-Size="Medium"></asp:TextBox>
						                </div>
					                </div>
                                    </div>
				
				
				                <div class="row">
					                        <div class="col-md-6">
						        <div class="form-group">
						          <label for="interestAmt">Total Interest of Time Period</label>
                                  <asp:TextBox ID="interestAmntTimePeriodTextBox" runat="server" CssClass="form-control input-sm" required="required" name="interestAmt" ReadOnly="True" Font-Size="Medium" disabled="disabled"></asp:TextBox>
						          </div>
					        </div>
					
					        <div class="col-md-6">
						        <div class="form-group">
						          <label for="totalAmt">Total Amount</label>
                                  <asp:TextBox ID="totalAmmountTextBox" runat="server" CssClass="form-control input-sm" required="required" name="totalAmt" ReadOnly="True" Font-Size="Medium" disabled="disabled"></asp:TextBox>
						        </div>
					        </div>
				        </div>
				
				            <div class="row">
					            <div class="col-md-6">
						            <div class="form-group">
						              <label for="emiAmt">EMI Amount</label>
                                      <asp:TextBox ID="emiAmmountTextBox" runat="server" CssClass="form-control input-sm" required="required"  name="emiAmt" ReadOnly="True" Font-Size="Medium" disabled="disabled"></asp:TextBox>
				                    </div>
					            </div>
		
					            <div class="col-md-6">
						            <div class="form-group">
						              <label for="netAmt">No. Of EMI</label>
                                      <asp:TextBox ID="noOfEMITextBox" runat="server" CssClass="form-control input-sm" required="required" name="netAmt" ReadOnly="True" Font-Size="Medium" disabled="disabled"></asp:TextBox>
						            </div>
					            </div>
				            </div>
				                <div class="row">
					                <div class="col-md-6">
						                <div class="form-group">
						                    <label for="timePeriods">EMI Type</label><br/>
                                            <asp:RadioButton ID="flatEmiRadioButton" runat="server" CssClass="minimal" name="emi_type" GroupName="emiMethodTextBox" value="flat_emi" Font-Size="Medium" />
						                    <label for="emi_type_flat">Flat EMI </label><br/>
                                            <asp:RadioButton ID="reducingEmiRadioButton" runat="server" CssClass="minimal" name="emi_type" GroupName="emiMethodTextBox" value="reducing_emi" Font-Size="Medium" />
						                    <label for="emi_type_reducing">Reducing Balance EMI</label>
						                </div>
					                </div>
					
					                <div class="col-md-3">
						                <div class="form-group">
						                    <label for="">Payment Mode</label><br/>
                                            <asp:RadioButton ID="chequePaymentModeRadioButton" GroupName="payMentMethod" runat="server" name="payment_mode" value="cheque" Font-Size="Medium" />
						                    <label for="cheque">Cheque</label><br/>
                                            <asp:RadioButton ID="cashPaymentModeRadioButton" runat="server" GroupName="payMentMethod" name="payment_mode" value="cash" Font-Size="Medium" />
						                    <label for="cash">Cash </label>
						                  <p>(File Charge + Advanced EMI)</p>
						                </div>
					                </div>
				                </div>
                                                  <div class="row">
                              <div class="col-lg-6 col-md-12 col-sm-12">
                                    <hr/>
                                            <hr/>
                           <legend class="legend">Cheque Info</legend>
                                 <div class="box-body">
							                <div class="form-group">
							                  <label for="">Cheque No.</label>
                                              <asp:TextBox ID="chequeNoTextBox" runat="server" CssClass="form-control input-sm" name="comp_cheque_no" placeholder="Enter Company Cheque No." Font-Size="Medium" ReadOnly="True"></asp:TextBox>
							                </div>
							
							                <div class="form-group">
							                  <label for="">Bank Name</label>
                                              <asp:TextBox ID="bankNameTextBox" runat="server" CssClass="form-control input-sm" name="comp_bank_name" placeholder="Enter Company Bank Name" Font-Size="Medium" ReadOnly="True" ></asp:TextBox>
							                </div>
				                </div>
              </div>
          </div>
			
				
			  </div>
                            <div class="box-footer">
                             <asp:Button ID="saveButton" runat="server" Text="SAVE" CssClass="btn btn-primary pull-right" OnClick="saveButton_Click"/>
				           </div>
                        </div>
                        
                       
                    </div>
       
                    
                </div>
     
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
    
</asp:Content>
