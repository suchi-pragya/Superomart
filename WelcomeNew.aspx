<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WelcomeNew.aspx.cs" Inherits="Superomart.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row w-screen d-flex justify-content-center">
                <div class="col-md-6 d-flex justify-content-center flex-column align-items-center w-100 p-3">
                    <img src="images/avtar.png" class="w-25 m-3 rounded-circle" />
                    <h1 class="font-weight-bold">Welcome to user Home</h1><br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>          
            </div>
        </div>
    </form>
    
</asp:Content>
