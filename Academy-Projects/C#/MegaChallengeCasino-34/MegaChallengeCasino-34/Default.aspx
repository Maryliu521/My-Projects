<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeCasino_34.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: default;
        }
        .auto-style3 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Casino Game --Good Luck!</h2>
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ====================</h2>
            <h2>
                <br />
            <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
            <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
            <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
            </h2>
            <h4>
            <br />
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="betMoney" OnCheckedChanged="RadioButton_CheckedChanged" Text="$5.00" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="betMoney" OnCheckedChanged="RadioButton_CheckedChanged" Text="$10.00" />
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="betMoney" OnCheckedChanged="RadioButton_CheckedChanged" Text="$15.00" />
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="betMoney" OnCheckedChanged="RadioButton_CheckedChanged" Text="$20.00" />
            </h4>
            <br />
            Your Bet :
            <asp:TextBox ID="betTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <span class="auto-style1"><span class="auto-style3">(Select your bet from top)</span><br />
            <br />
            <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull The Lever" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            </span><span class="auto-style2">1 Cherry - x2 Your Bet<br />
            2 Cherries -x3 Your Bet<br />
            3Cherries - x4 Your Bet<br />
            3 7&#39;s- Jackpot - x100 Your Bet<br />
            HOWEVER ... if there is even one bar you win nothing.</span></div>
    </form>
</body>
</html>
