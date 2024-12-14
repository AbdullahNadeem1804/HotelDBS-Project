<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="Project.Query1" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 1: Guests Staying More Than 2 Days</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 1: Guests Staying More Than 2 Days</h2>
        <asp:Button ID="btnExecuteQuery" runat="server" Text="Execute Query" OnClick="btnExecuteQuery_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>


    </form>
</body>
</html>
