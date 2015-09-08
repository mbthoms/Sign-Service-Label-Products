<%@ Page Title="" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sign_Service_Label_Products.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container well-background">
        <div class="page-header">
            <h1>Dealer Login</h1>
        </div>
        <div class="row">
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center">
                <fieldset class="login-fields">
                    <asp:Label ID="lblEmailLogin" Text="Email:" runat="server" />
                    <asp:TextBox ID="txtEmailLogin" runat="server" CssClass="form-control" />
                    <br />
                    <asp:Label ID="lblPasswordLogin" Text="Password:" runat="server" />
                    <asp:TextBox ID="txtPasswordLogin" runat="server" CssClass="form-control" />
                    <br />
                    <!-- Sign Up Button trigger Modal -->
                    <button type="button" class="btn btn-primary signup-modal-button" data-toggle="modal" data-target="#myModal">Sign Up</button>
                    <!-- Login Submit button -->
                    <asp:Button ID="btnDealerLogin" Text="Login" OnClick="btnDealerLogin_Click" runat="server" CssClass="btn btn-success" />
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>

        </div>
        <!-- /.row -->
    </div>
    <!-- /.container -->

    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h1 class="modal-title" id="myModalLabel">Sign Up</h1>
                </div>
                <div class="modal-body">
                    <fieldset>
                        <legend>Contact Information</legend>
                        <asp:Label ID="lblContactNameSignUp" Text="Contact Name:" runat="server" />
                        <asp:TextBox ID="txtContactNameSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblContactEmailSignUp" Text="Contact Email:" runat="server" />
                        <asp:TextBox ID="txtContactEmailSignUp" runat="server" CssClass="form-control"/>
                        <br />
                        <asp:Label Text="Company Name:" runat="server" />
                        <asp:TextBox ID="txtCompanyNameSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblContactPhoneNumberSignUp" Text="Contact Phone Number:" runat="server" />
                        <asp:TextBox ID="txtContactPhoneNumberSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblContactFaxSignUp" Text="Fax:" runat="server" />
                        <asp:TextBox ID="txtContactFaxSignUp" runat="server" CssClass="form-control" />
                    </fieldset>

                    <fieldset>
                        <legend>Address</legend>
                        <asp:Label ID="lblAddressSignUp" Text="Address:" runat="server" />
                        <asp:TextBox ID="txtAddressSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblAddressLine2SignUp" Text="Address Line 2 (optional):" runat="server" />
                        <asp:TextBox ID="txtAddressLine2SignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblCitySignUp" Text="City:" runat="server" />
                        <asp:TextBox ID="txtCitySignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblStateProvinceSignUp" Text="State / Province:" runat="server" />
                        <asp:TextBox ID="txtStateProvinceSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label Text="Zip Code / Postal Code" runat="server" />
                        <asp:TextBox ID="txtZipPostalSignUp" runat="server" CssClass="form-control" />
                    </fieldset>
                    <fieldset>
                        <legend>Password</legend>
                        <asp:Label ID="lblPasswordSignUp" Text="Password:" runat="server" />
                        <asp:TextBox ID="txtPasswordSignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblConfirmPasswordSignUp" Text="Confirm Password:" runat="server" />
                        <asp:TextBox ID="txtConfirmPasswordSignUp" runat="server" CssClass="form-control" />
                    </fieldset>
                    
                    





                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <asp:Button ID="btnDealerSignUp" Text="Sign Up" OnClick="btnDealerSignUp_Click" runat="server" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
