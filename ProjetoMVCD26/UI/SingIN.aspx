<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingIN.aspx.cs" Inherits="ProjetoMVCD26.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <h1>Acesso ao Sistema</h1>
            <asp:Label ID="lblAlertaD26" Text="" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            <br />
            <asp:Label>Digite Seu CPF:</asp:Label>
            <asp:TextBox type="number" runat="server" class="form-control" ID="txtCpfD26"></asp:TextBox>
            <asp:Label>Digite Seu Nome Completo:</asp:Label>
            <asp:TextBox runat="server" class="form-control" ID="txtNomeD26"></asp:TextBox>
            <asp:Label>Digite o Nome de Sua Mãe:</asp:Label>
            <asp:TextBox runat="server" class="form-control" ID="txtNomeMaeD26"></asp:TextBox>
            <asp:Button runat="server" OnClick="btnSignin_Click" class="btn btn-primary btn-block" ID="btnSingIn" Text="Enviar"/>
        </div>
    </form>
</body>
</html>
