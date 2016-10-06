<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ViewStateUsingForeachLoop.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br/>
        Name<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox><br/>
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <asp:Button ID="showAllButton" runat="server" Text="Show All" OnClick="showAllButton_Click" />
    </div>
    </form>
</body>
</html>
