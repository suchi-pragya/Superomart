<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="Superomart.sign_in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <title> sign in</title>
    </head>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row w-screen d-flex justify-content-center">
                <div class="col-md-6 d-flex justify-content-center flex-column align-items-center w-100 p-3">
                    <img src="images/avtar.png" class="w-25 m-3 rounded-circle" />
                    <h1 class="font-weight-bold">Sign in</h1><br />
                    <asp:TextBox ID="TextBox2" runat="server" cssclass="form-control" placeholder="Enter your Email-ID"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox4" runat="server" cssclass="form-control" placeholder="Enter your password"></asp:TextBox><br />
                    <asp:Button runat="server" Text="Sign in" cssclass="btn btn-info font-weight-bold w-100" /> <br /><br />
                    <p> <a href="register.aspx" class="text-primary">Don't have an account? sign Up</a></p>

                </div>          
            </div>
        </div>
    </form>
</asp:Content>
