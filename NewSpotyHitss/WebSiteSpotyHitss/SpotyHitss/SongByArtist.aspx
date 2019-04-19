<%@ Page Title="Song By Artist" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SongByArtist.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.SongByArtist" %>

<asp:Content ID="ContentGame" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Mostrar Por Artista</h1>
    <div class="row">
        <asp:HiddenField ID="HiddenField" runat="server" />

        <div class="col-md-4">
            <h2>Canciones: </h2>
            <asp:DataGrid id="SongsGrid" AutoGenerateColumns="true" 
                BoderColor ="black"
                BoderWidth="3"
                ItemType=""
                runat="server" ></asp:DataGrid>

        </div>
        <div class="col-md-4">
            <h2>Buscar artista</h2>
            <p> Nombre </p>
            <p> <asp:TextBox ID="ArtistName" runat="server"></asp:TextBox> </p>
            <p><asp:LinkButton class="btn btn-default" 
                ID="btnSearch" 
                runat="server" 
                Text="Buscar" OnClick="Search_Click"/></p>
        </div>

    </div>

</asp:Content>
