<%@ Page Title="" Language="C#" MasterPageFile="~/UI/DashBoard.Master" AutoEventWireup="true" CodeBehind="TotalCapital.aspx.cs" Inherits="LogIn.UI.TotalCapital" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
                         <div class="row">
             
                              <div class="col-lg-12 col-md-12 col-sm-12">
                                <legend class="legend">Total Capital</legend>
                                  <div class="row">
                                      <div class="col-md-offset-8 col-md-4">
                                          <div class="form-group">
                                              <asp:TextBox runat="server" placeholder="Search" ID="searchTextBox"></asp:TextBox>
                                              <asp:Button runat="server" CssClass="btn btn-primary" Text="Search"/>
                                          </div>
                                      </div>
                                  </div>
                                  <hr/>
                                    <asp:GridView runat="server" ID="totalCpaitalGridView" AutoGenerateColumns="True" Height="155px" Width="718px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="SL No.">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text="Hello"></asp:Label>
                                                  <!-- <asp:Label runat="server" Text=''></asp:Label>-->
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Branch's Name">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text=''></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Total Capital">
                                                <ItemTemplate>
                                                    <asp:Label runat="server" Text=''></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                          
                                        </Columns>


                                    </asp:GridView>     
                              </div>
                    </div>
              
                </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="forJS" runat="server">
</asp:Content>
