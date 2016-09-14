<%@ Page Title="Votar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Votar.aspx.cs" Inherits="PesquisaEleitoral.Voto.Votar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-inline">
        <h2>Votar</h2>
        <br />

        <h3>Candidatos</h3>
        <table class="table table-striped table-bordered" style="width: 10%;">
            <asp:Repeater id="candidatos" runat="server" DataSourceID="dsCandidatos">
                <ItemTemplate>
                <tr>
                    <td><%# Eval("Numero") %></td> 
                    <td><%# Eval("Nome") %></td> 
                </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>



        <asp:Label runat="server" AssociatedControlID="ddpCandidatos" CssClass="col-md-2 control-label">Candidato:</asp:Label>
        <asp:DropDownList ID="ddpCandidatos" runat="server" DataSourceID="dsCandidatos" AppendDataBoundItems="True" CssClass="form-control" DataTextField="Nome" DataValueField="Id" Width="193px">
                <asp:ListItem Selected="True" Value="0" Text="Selecione" ></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="bntCadastrar" runat="server" Text="Votar" CssClass="btn btn-success" OnClick="Cadastrar"/>
        <asp:SqlDataSource ID="dsCandidatos" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_PesquisaEleitoralConnectionString %>" SelectCommand="SELECT [Id], [Nome], [Numero] FROM [Candidatos]"></asp:SqlDataSource>
        
    </div>

</asp:Content>
