<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query16.aspx.cs" Inherits="Project.Query16" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 16: Bookings in Pet-Friendly Rooms</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 16: Bookings in Pet-Friendly Rooms</h2>
        <asp:Button ID="btnFetchBookings" runat="server" Text="Fetch Bookings" OnClick="btnFetchBookings_Click" />
        <asp:GridView ID="GridView16" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
