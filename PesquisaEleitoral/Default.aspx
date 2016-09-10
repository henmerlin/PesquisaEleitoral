<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PesquisaEleitoral._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <div class="jumbotron">
        <h1>Pesquisa Eleitoral</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Apuração de Votos &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Trabalho Prático 1 – C2, C4 e C6</h2>
            <p>
               O trabalho prático 1 (TP1), servirá de avaliação para as competências C2(C), C4(N) e C6(C). 
                Além disso, o trabalho serve como única reconstrução para quem não atingiu as competências C1(N) e C3(N) na AV1 (prova escrita).
            </p>
        </div>
        <div class="col-md-4">
            <h2>Requisitos</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
