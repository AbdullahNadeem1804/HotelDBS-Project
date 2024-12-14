<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query3.aspx.cs" Inherits="Project.Query3" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 3: Hotels with More Than 150 Rooms</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 3: Hotels with More Than 150 Rooms</h2>
        <asp:Button ID="btnFetchHotels" runat="server" Text="Fetch Hotels" OnClick="btnFetchHotels_Click" />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
