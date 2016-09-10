<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCandidato.aspx.cs" Inherits="PesquisaEleitoral.Candidato.CadastroCandidato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastro de Candidato</h2>
    <div class="form-group">
        <label for="txtNome">Nome:</label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Nome do Candidato"/>
    </div>
    <div class="form-group">
        <label for="txtNome">Número:</label>
        <asp:TextBox ID="txtNumero" runat ="server" CssClass="form-control"  placeholder="Número do Candidato"/>
    </div>
    <asp:Button ID="bntCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="Cadastrar"/>

</asp:Content>
