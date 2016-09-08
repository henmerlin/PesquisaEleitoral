<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadBairro.aspx.cs" Inherits="PesquisaEleitoral.CadBairro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastro de Bairro</h2>
    <div class="form-inline">
        <label for="txtNome">Nome:</label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Nome do Bairro"/>
        <asp:Button ID="bntCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="Cadastrar"/>
    </div>

</asp:Content>


