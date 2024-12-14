<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query6.aspx.cs" Inherits="Project.Query6" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 6: Bookings with Discounts</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 6: Bookings with Discounts Applied</h2>
        <asp:Button ID="btnFetchDiscountedBookings" runat="server" Text="Fetch Discounted Bookings" OnClick="btnFetchDiscountedBookings_Click" />
        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
