<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query11.aspx.cs" Inherits="Project.Query11" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 11: Most Popular Service Used by Guests</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 11: Most Popular Service Used by Guests</h2>
        <asp:Button ID="btnFetchPopularService" runat="server" Text="Fetch Most Popular Service" OnClick="btnFetchPopularService_Click" />
        <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
