<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Superomart.enquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <title> register</title>
    </head>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row w-screen d-flex justify-content-center">
                <div class="col-md-6 d-flex justify-content-center flex-column align-items-center w-100 p-3">
                    <img src="images/avtar.png" class="w-25 m-3 rounded-circle" />
                    <h1 class="font-weight-bold">Register Now</h1><br />
                    <asp:TextBox ID="TextBox1" runat="server" cssclass="form-control" placeholder="Enter your Name"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox2" runat="server" cssclass="form-control" placeholder="Enter your Email-ID"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox3" runat="server" cssclass="form-control" placeholder="Enter your Contact No"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox4" runat="server" cssclass="form-control" placeholder="Enter your password"></asp:TextBox><br />
                    <asp:Button runat="server" Text="Register" cssclass="btn btn-info font-weight-bold w-100" OnClick="Unnamed1_Click" /> <br /><br />
                    <p> <a href="signin.aspx" class="text-primary">Already have an account? sign in</a></p>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
                <%--<div class="row ">
                     <div class="mt-5">
                        <iframe frameborder="0" scrolling="no" marginheight="0" marginwidth="0"width="500" height="400" type="text/html" src="https://www.youtube.com/embed/8LoDjtWZW0s?autoplay=0&fs=0&iv_load_policy=3&showinfo=0&rel=0&cc_load_policy=0&start=0&end=0&origin=https://youtubeembedcode.com"><div><small><a href="https://youtubeembedcode.com/en">youtubeembedcode en</a></small></div><div><small><a href="https://youronlinecasino.org/">youronlinecasino.org</a></small></div><div><small><a href="https://youtubeembedcode.com/en">youtubeembedcode.com/en/</a></small></div><div><small><a href="https://youronlinecasino.org/">https://youronlinecasino.org/</a></small></div><div><small><a href="https://youtubeembedcode.com/en">youtubeembedcode.com/en/</a></small></div><div><small><a href="https://freebonusnodepositcasino.net/">https://freebonusnodepositcasino.net/</a></small></div><div><small><a href="https://youtubeembedcode.com/en">youtubeembedcode en</a></small></div><div><small><a href="https://casinoslotsonline.net/">casinoslotsonline.net</a></small></div></iframe>
                        <iframe class="ml-5" width="500" height="400" src="https://www.youtube.com/embed/T4YBUyIoyhI" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                    </div>
                </div>--%>
               
            </div>
        </div>
    </form>
</asp:Content>
