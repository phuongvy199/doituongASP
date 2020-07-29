<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sanpham.ascx.cs" Inherits="WEB.sanpham" %>
<asp:DropDownList ID ="drpSP" runat="server" OnSelectedIndexChanged="drpSP_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
<asp:Repeater ID ="rptNews" runat="server">
    <ItemTemplate>
        <%#:Eval("TENSP") %>
    </ItemTemplate>
</asp:Repeater>