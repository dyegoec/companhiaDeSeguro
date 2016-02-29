<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteForm.aspx.cs" Inherits="CompanhiaDeSeguro.CarroForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Cliente</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEndereco" runat="server" Text="Endereco: "></asp:Label>
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCarteira" runat="server" Text="Cateira de motorista: "></asp:Label>
        <asp:TextBox ID="txtCarteira" runat="server"></asp:TextBox>
        <br />
        <br />
        </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
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
