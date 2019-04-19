<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertSong.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.InsertSong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row col-md-6 col-md-offset-3">
            <h1>Insert Song</h1>
            <asp:Table runat="server" CssClass="table">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label Text="Song Name:" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="txtSongName" CssClass="form-control"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:label text="Release year:" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:textbox runat="server" ID="txtReleaseYear" CssClass="form-control"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:label text="Artist Name:" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:textbox runat="server" ID="txtArtistName" CssClass="form-control"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:label text="Song" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell></asp:TableCell><asp:TableCell>
                        <asp:linkbutton text="Insert" CssClass="btn btn-default" OnClick="InsertSong_Click" runat="server" />
                    </asp:TableCell></asp:TableRow></asp:Table></div></div></asp:Content>