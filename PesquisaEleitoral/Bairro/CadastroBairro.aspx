<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroBairro.aspx.cs" Inherits="PesquisaEleitoral.Bairro.CadastroBairro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastro de Bairro</h2>
    <div class="form-group">
        <label for="txtNome">Nome:</label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Nome do Bairro"/>
    </div>
    <asp:Button ID="bntCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="Cadastrar"/>
</asp:Content>
