<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPlaylistSong.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.AddPlaylistSong" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> ADD SONG TO PLAYLIST</title>
     <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body>
<form id="form1" runat="server">
<h2><%: Title %>.</h2>
 <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Application name</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Home</a></li>
                        <li><a runat="server" href="~/About">About</a></li>
                        <li><a runat="server" href="~/Contact">Contact</a></li>
                    </ul>               
                </div>
            </div>
        </div>

 <div class="row">  
        <div class="col-md-5">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Use a local account to log in.</h4>                 
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">ID OR NAME PLAYLIST</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />                         
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">ID OR NAME SONG</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Email" CssClass="form-control" />
                        </div>
                    </div>                
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Click" Text="Log in" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>             
            </section>
        </div>
         <div class="col-md-6">
            <section id="socialLoginForm">
                <div style="overflow:auto; width:700px; height:700px">
                    <asp:GridView ID="View" runat="server"></asp:GridView>
               </div>
            </section>
        </div>
 </div>
</form>

</body>
</html>

