<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadCandidato.aspx.cs" Inherits="PesquisaEleitoral.CadCandidato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastro de Candidato</h2>
    <div class="form-inline">
        <label for="txtNome">Nome:</label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Nome do Candidato"/>
        <asp:Button ID="bntCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="Cadastrar"/>
    </div>

</asp:Content>


