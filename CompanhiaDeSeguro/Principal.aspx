<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="CompanhiaDeSeguro.Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/ClienteForm.aspx">Cadastro Cliente</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/CarroForm.aspx">Cadastro 
        Carro</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" 
            PostBackUrl="~/RegistroAcidenteForm.aspx">Cadastro Registro de Acidente</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" 
            PostBackUrl="~/VisualizarCliente.aspx">Visualizar Clientes</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" 
            PostBackUrl="~/VisualizarCarro.aspx">Visualizar Carros</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton6" runat="server" 
            PostBackUrl="~/VisualizarRegistro.aspx">Visualizar Registros de 
        Acidentes</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
