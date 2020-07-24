<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="sever_control.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl" runat="server" Text="họ và tên"></asp:Label>
            <asp:TextBox ID ="txthoten" runat="server"></asp:TextBox>
            <asp:TextBox ID ="txtpass" runat="server" textMode="Password"></asp:TextBox>
            <asp:button ID ="btnnhap" runat="server" text="cập nhật"></asp:button>
            
        </div>
    </form>
</body>
</html>
