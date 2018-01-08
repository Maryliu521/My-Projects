<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="postage_calculator_challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postage Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChanged"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChanged"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
