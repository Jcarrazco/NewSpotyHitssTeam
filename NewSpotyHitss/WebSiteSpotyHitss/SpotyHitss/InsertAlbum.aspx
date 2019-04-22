<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="WebSiteSpotyHitss.SpotyHitss.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <style> 
         .CenterFields {
             text-align:center;
         }
    </style>
    <div class="jumbotron" >  
            <asp:Label ID="TitleLabel" runat="server" Text="Insert Album"/>
            <table class="table table-responsive">       
            <tr><th ><p class="CenterFields"><asp:Label  ID="AlbumNameLabel" runat="server" Text="Album´s Name"/></p></th>
                <th ><p class="CenterFields"><asp:Label  ID="AlbumYearLabel" runat="server" Text="Album´s Release Year"/></p></th>
            </tr>
            <tr><th ><p class="CenterFields"><asp:TextBox ID="AlbumNameTextBox" runat="server"/></p></th>
                <th class="CenterFields"><p ><asp:TextBox ID="AlbumYearTextBox" runat="server"/></p></th>
            </tr>             </table>
            <asp:LinkButton class="btn btn-default" Text="Insert" runat="server" OnClick="Insert_Click"/>  
    </div>
</asp:Content>
