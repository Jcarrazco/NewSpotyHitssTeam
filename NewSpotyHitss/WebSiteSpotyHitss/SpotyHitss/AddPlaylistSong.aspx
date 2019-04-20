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
                     <a class="navbar-brand" runat="server" >PLAYLIST AND SONG</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="IndexModificarPlaylist.aspx">HOME</a></li>
                        <li><a runat="server" href="AddPlaylistSong.aspx">ADD-SONG</a></li>
                        <li><a runat="server" href="DeletePlaylistSong.aspx">DELETE-SONG</a></li>
                         <li><a runat="server" href="~/About">GABY-1</a></li>
                        <li><a runat="server" href="~/About">GABY-2</a></li>
                    </ul>               
              </div>
          </div>

 <div class="row">  
        <div class="col-md-5">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Use a local account to log in.</h4>                 
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">ID OR NAME PLAYLIST</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtPlaylist" CssClass="form-control" TextMode="SingleLine" />                         
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">ID OR NAME SONG</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtSong" TextMode="SingleLine" CssClass="form-control" />
                           <asp:Label ID="lblValidacion1" runat="server" Text=""></asp:Label>
                        </div>
                    </div>                
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Click" Text="Log in" CssClass="btn btn-default" />
                            <asp:Label ID="lblValidacion2" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>             
            </section>
        </div>
         <div class="col-md-6">
            <section id="socialLoginForm">
                <div style="overflow:auto; width:100%; height:700px">
                    <asp:GridView ID="View" runat="server"></asp:GridView>
               </div>
            </section>
        </div>
 </div>
</form>

</body>
</html>

