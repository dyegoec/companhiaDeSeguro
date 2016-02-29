<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarroForm.aspx.cs" Inherits="CompanhiaDeSeguro.CarroForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Carro</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
        <asp:Label ID="lblMarca" runat="server" Text="Marca: "></asp:Label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblModelo" runat="server" Text="Modelo: "></asp:Label>
        <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAno" runat="server" Text="Ano: "></asp:Label>
        <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCor" runat="server" Text="Cor: "></asp:Label>
        <asp:TextBox ID="txtCor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblRenavam" runat="server" Text="Renavam: "></asp:Label>
        <asp:TextBox ID="txtRenavam" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
                <asp:DropDownList ID="ddlCliente" runat="server">
                </asp:DropDownList>
        <br />
        <br />
        </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" 
                    onclick="btnSalvar_Click" />
                <asp:Button ID="Button1" runat="server" EnableTheming="True" 
                    PostBackUrl="~/Principal.aspx" Text="Voltar" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
