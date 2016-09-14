<%@ Page Title="Apuração" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApuracaoBairro.aspx.cs" Inherits="PesquisaEleitoral.Apuracao.Apuracao" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Total de Votos Por Bairro</h2>
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="922px" ShowToolBar="False" style="margin-right: 0px">
        <LocalReport ReportPath="Apuracao\TotalBairro.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="obdsBairro" Name="dsTotalBairro" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="obdsBairro" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral.ASP_PesquisaEleitoralDataSetTableAdapters.VotosTableAdapter"></asp:ObjectDataSource>

</asp:Content>
