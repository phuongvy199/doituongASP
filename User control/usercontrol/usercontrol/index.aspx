<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="usercontrol.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="?id=1">Tin tức</a>
            <a href="?id=2">Sản Phẩm</a>
        </div>
        <div>
            <asp:PlaceHolder ID="plLoat" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
