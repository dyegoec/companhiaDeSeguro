<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAcidenteForm.aspx.cs" Inherits="CompanhiaDeSeguro.RegistroAcidenteForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
        <asp:Label ID="lblLocal" runat="server" Text="Local do Acidente: "></asp:Label>
        <asp:TextBox ID="txtLocal" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblData" runat="server" Text="Data do Acidente: "></asp:Label>
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblValor" runat="server" Text="Valor do prejuizo: "></asp:Label>
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblCarro" runat="server" Text="Carro: "></asp:Label>
                <asp:DropDownList ID="ddlCarro" runat="server">
                </asp:DropDownList>
                <br />
        <br />
        <br />
        </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" 
                    onclick="btnSalvar_Click" />
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/Principal.aspx" 
                    Text="Voltar" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
