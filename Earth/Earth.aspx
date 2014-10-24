<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Earth.aspx.cs" Inherits="Earth.Earth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Earth</title>
</head>
<body>
    <form id="mainForm" runat="server">
        <h1>Continents</h1>

        <asp:EntityDataSource runat="server" ID="EntityDataSourceContinents"
            ConnectionString="name=Earth"
            DefaultContainerName="Earth"
            EntitySetName="Continents"
            EnableFlattening="false">
        </asp:EntityDataSource>

        <asp:ListBox ID="ListBoxContinents" runat="server" 
            DataSourceID="EntityDataSourceContinents" 
            DataTextField="Name" DataValueField="Id" 
            Rows="10" AutoPostBack="true">
        </asp:ListBox>
    </form>
</body>
</html>
