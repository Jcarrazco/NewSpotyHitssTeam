<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearPlaylist.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="nombrePlaylist" runat="server"></asp:TextBox>
            <asp:TextBox ID="descripcionPlaylist" runat="server"></asp:TextBox>
            <asp:Button ID="crearPlaylist" runat="server" Text="Crear Playlist" />
        </div>
    </form>
</body>
</html>
