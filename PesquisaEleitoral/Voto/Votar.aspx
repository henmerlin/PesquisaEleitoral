<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Votar.aspx.cs" Inherits="PesquisaEleitoral.Voto.Votar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource ID="CandidadosDS" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_PesquisaEleitoralConnectionString %>" SelectCommand="SELECT [Numero], [Id], [Nome] FROM [Candidatos]"></asp:SqlDataSource>
    <asp:Repeater id="someRep" runat="server" DataSourceID="CandidadosDS">
        <ItemTemplate>
            <tr>
                <td><%# Eval("Numero") %></td> 
                <td><%# Eval("Nome") %></td> 
            </tr>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
