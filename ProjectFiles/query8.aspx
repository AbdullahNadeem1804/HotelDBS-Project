<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query8.aspx.cs" Inherits="Project.Query8" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 8: Employees in the Same City as Their Assigned Hotel</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 8: Employees Working in the Same City as Their Hotel</h2>
        <asp:Button ID="btnFetchEmployees" runat="server" Text="Fetch Employees" OnClick="btnFetchEmployees_Click" />
        <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
