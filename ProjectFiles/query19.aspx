<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query19.aspx.cs" Inherits="Project.Query19" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 19: Employee with Most Bookings</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 19: Employees Who Handled the Most Bookings</h2>
        <asp:Button ID="btnFetchEmployees" runat="server" Text="Fetch Top Employee" OnClick="btnFetchEmployees_Click" />
        <asp:GridView ID="GridView19" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
