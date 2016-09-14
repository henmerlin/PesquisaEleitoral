<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PesquisaEleitoral._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Pesquisa Eleitoral</h1>
        <p class="lead">Trabalho Prático 1 – C2, C4 e C6</p>
        
        <asp:LoginView runat="server" ViewStateMode="Disabled">
            <LoggedInTemplate>
                <p><a href="/Apuracao/ApuracaoTotal" class="btn btn-primary btn-lg">Apuração de Votos &raquo;</a></p>
            </LoggedInTemplate>
             <AnonymousTemplate>
                 <p><a href="/Account/Register" class="btn btn-primary btn-lg">Registre-se &raquo;</a></p>
             </AnonymousTemplate>
        </asp:LoginView> 
        
       
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Trabalho Prático 1 – C2, C4 e C6</h2>
            <p>
               O trabalho prático 1 (TP1), servirá de avaliação para as competências C2(C), C4(N) e C6(C). 
                Além disso, o trabalho serve como única reconstrução para quem não atingiu as competências C1(N) e C3(N) na AV1 (prova escrita).
            </p>
        </div>
    </div>

</asp:Content>
