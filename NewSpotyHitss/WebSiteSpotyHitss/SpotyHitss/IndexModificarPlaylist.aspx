<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexModificarPlaylist.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.IndexModificarPlaylist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>INDEX</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <webopt:bundlereference runat="server" path="~/Content/css" />

</head>
<body>
 <form id="form1" runat="server">
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
    </div>
</form>
</body>
</html>
