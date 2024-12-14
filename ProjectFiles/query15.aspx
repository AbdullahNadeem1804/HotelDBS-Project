﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query15.aspx.cs" Inherits="Project.Query15" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Query 15: Hotels with Room Service Used</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Query 15: Hotels Where Guests Used Room Service</h2>
        <asp:Button ID="btnFetchHotels" runat="server" Text="Fetch Hotels" OnClick="btnFetchHotels_Click" />
        <asp:GridView ID="GridView15" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <div style="text-align:center; margin-top:20px;">
    <a href="Menu.aspx" style="text-decoration:none; font-size:16px; background-color:#007bff; color:white; padding:10px 15px; border-radius:5px;">Back to Menu</a>
</div>

    </form>
</body>
</html>
