<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
        </div>
        <p>
            <span class="auto-style1">First Value</span> :
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style1">Second Value</span> :
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="+" />
&nbsp;
            <asp:Button ID="Minus" runat="server" OnClick="Minus_Click" Text="-" />
&nbsp;
            <asp:Button ID="Times" runat="server" OnClick="Times_Click" Text="*" />
&nbsp;
            <asp:Button ID="Divid" runat="server" OnClick="Divid_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" BackColor="#3399FF" Font-Bold="True" Font-Size="Larger" ForeColor="Black"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
