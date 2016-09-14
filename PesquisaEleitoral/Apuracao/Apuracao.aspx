﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Apuracao.aspx.cs" Inherits="PesquisaEleitoral.Apuracao.Apuracao" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Total de Votos</h2>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="994px" ShowToolBar="False" Height="201px">
        <LocalReport ReportPath="Apuracao\TotalCandidato.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ds1" Name="dsTotalCandidato" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ds1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral.ASP_PesquisaEleitoralDataSetTableAdapters.VotosTableAdapter"></asp:ObjectDataSource>

    <h2>Total de Votos Por Bairro</h2>
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="996px" ShowToolBar="False" Height="201px">
        <LocalReport ReportPath="Apuracao\TotalBairro.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ds2" Name="ds2" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ds2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral.ASP_PesquisaEleitoralDataSetTableAdapters.VotosTableAdapter"></asp:ObjectDataSource>
    
    <h2>Total de Votos Por Faixa Etária</h2>
        <rsweb:ReportViewer ID="ReportViewer3" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="993px" ShowToolBar="False" Height="169px">
            <LocalReport ReportPath="Apuracao\TotalFaixaEtaria.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ds3" Name="ds3" />
                </DataSources>
            </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ds3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral.ASP_PesquisaEleitoralDataSetTableAdapters.VotosTableAdapter"></asp:ObjectDataSource>

</asp:Content>
