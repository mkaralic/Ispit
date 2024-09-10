<%@ Page Title="Cenzura" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cenzura.aspx.cs" Inherits="Zadatak4.Cenzura" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p>
            <textarea id="txtUlaz" cols="20" rows="2" runat="server"></textarea>
        </p>
        <p>
            <asp:TextBox runat="server" ID="txtRec"></asp:TextBox>&nbsp;
        </p>
        <p>
            <asp:Literal runat="server" ID="txtIzlaz"></asp:Literal>&nbsp;
        </p>
        <p>
            <asp:Button ID="btnCenzurisi" runat="server" Text="Cenzurisi" OnClick="btnCenzurisi_Click1" />
        </p>
    </main>
</asp:Content>
