<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query9.aspx.cs" Inherits="Project.Query9" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 9: Total Amount Spent by Guests on Services</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 9: Total Amount Spent by Each Guest on Services</h2>
        <asp:Button ID="btnFetchGuests" runat="server" Text="Fetch Guest Expenditures" OnClick="btnFetchGuests_Click" />
        <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
