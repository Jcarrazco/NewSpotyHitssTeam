<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListGenre.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.ListGenre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .Title{
            font-family:'Arial Rounded MT';
            text-align:center;
        }
    </style>
    <div class="Title">
        <asp:Label ID="Label2" runat="server" Text="Busqueda de Canciones por Genero"></asp:Label>
    </div>
        <div>
            <asp:Image ID="Image1" runat="server" Height="165px" ImageAlign="Top" ImageUrl="~/Content/Logo.jpg" />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduzca el Genero a Buscar:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TxbGenre" runat="server"></asp:TextBox>
            <asp:Button ID="BtnGenre" runat="server" Text="Buscar" onclick="BtnGenre_Click"/>
        </div>
        <div class="ListaSong">
            <asp:GridView 
                ID="GridView1" 
                runat="server"
                ItemType="SpotyHitss.Data.Objects.Song" DataKeyNames="ID"
                AutoGenerateColumns="False" BackColor="#66FF33" Height="83px" Width="569px">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id"/>
                    <asp:BoundField DataField="Name" HeaderText="Name"/>
                    <asp:BoundField DataField="Year" HeaderText="Year"/>
                    <asp:BoundField DataField="Genre" HeaderText="Genre"/>
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
