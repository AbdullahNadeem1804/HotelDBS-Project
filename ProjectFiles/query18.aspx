<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query18.aspx.cs" Inherits="Project.Query18" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 18: Guests Spending Above Average</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 18: Guests Who Have Spent More Than the Average Amount on Bookings</h2>
        <asp:Button ID="btnFetchGuests" runat="server" Text="Fetch Guests" OnClick="btnFetchGuests_Click" />
        <asp:GridView ID="GridView18" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
