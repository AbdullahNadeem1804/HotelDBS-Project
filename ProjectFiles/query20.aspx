<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query20.aspx.cs" Inherits="Project.Query20" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 20: Rooms Booked by Guests Using Two or More Services</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 20: Rooms Booked by Guests Who Used at Least Two Different Hotel Services</h2>
        <asp:Button ID="btnFetchRooms" runat="server" Text="Fetch Rooms" OnClick="btnFetchRooms_Click" />
        <asp:GridView ID="GridView20" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
