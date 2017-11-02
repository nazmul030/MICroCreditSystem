<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="ManageLoan.aspx.cs" Inherits="LogIn.UI.ManageLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
                         <div class="row">
             
                              <div class="col-lg-12 col-md-12 col-sm-12">
                                <legend class="legend">Manage Loan</legend>
                                  <div class="row">
                                      <div class="col-md-offset-4 col-md-4">
                                          <div class="form-group">
                                              <asp:TextBox runat="server" placeholder="Search" ID="searchTextBox"></asp:TextBox>
                                              <asp:Button runat="server" CssClass="btn btn-primary" Text="Search"/>
                                          </div>
                                      </div>
                                  </div>
                                       <hr/>
                                  <div class="row">
                                      <div class="col-md-12">
                                          <div class="form-group">
                                              <asp:GridView runat="server" ID="manageLoanGridView" AutoGenerateColumns="false "  Height="155px" Width="718px"  ViewStateMode="Enabled" CssClass="table table-striped table-bordered table-hover" OnPageIndexChanging="manageLoanGridView_OnPageIndexChanging" AllowPaging="True" Font-Size="11px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="SL#">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text="<%#Container.DataItemIndex+1%>" ></asp:Label>
                                                  <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <%--<asp:TemplateField HeaderText="Loan Code">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("LoanCode") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>--%>

                                            <asp:TemplateField HeaderText="Customer Name">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Contact">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("ContactNo") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Branch Name">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("BranchName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Account No.">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("CustomerAccountNo") %>'></asp:Label>
                                               </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Loan Date">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("LoanDate") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Ending Date">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("EndDate") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                             <asp:TemplateField HeaderText="Principal Ammount">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("PrincipalAmmount") %>' ></asp:Label>
                                                  <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Interest Rate Per Year">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("InterestRate") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="File Charge">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("FileCharge") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time Period">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("Timeperiod") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Penalty Charge">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text='<%#Eval("Penalty") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                       <%--     <asp:TemplateField HeaderText="Interest Ammount Per Year">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("InterestAmmountPerYear") %>'></asp:Label>
                                               </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Interest Ammount Per Month">
                                                <ItemTemplate>
                                               <asp:Label runat="server" Text='<%#Eval("InterestAmmountPerMonth") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                              <asp:TemplateField HeaderText="Interest Rate Of Time Period">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("InterestAmmountOfTimePeriod") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>--%>
                                              <asp:TemplateField HeaderText="EMI Ammount">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("EMIAmmount") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="No Of EMI">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("NoOfEMI") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="No Of Paid Ammount">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("PaidAmmount") %>'></asp:Label>
                                                </ItemTemplate>
                                               
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="No Of EMI Paid">
                                                <ItemTemplate>
                                                 <asp:Label runat="server" Text='<%#Eval("PaidEMI") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Action">
                                                <ItemTemplate>
                                                <asp:HyperLink runat="server" NavigateUrl='#'>Invoice</asp:HyperLink>
                                                <asp:HyperLink runat="server" NavigateUrl="#">Delete</asp:HyperLink>
                                                <asp:HyperLink runat="server" NavigateUrl="#">View</asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>


                                    </asp:GridView>
                                          </div>
                                      </div>
                                  </div>
                             
                                         
                              </div>
                    </div>
              
                </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
