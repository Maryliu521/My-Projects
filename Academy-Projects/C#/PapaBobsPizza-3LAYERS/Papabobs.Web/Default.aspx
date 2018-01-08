<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Papabobs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container"> 

        <div class=" page-header">
           <h1>PapaBob's Pizza</h1>
           <p>Enjoy your pizza!</p>
         </div>

           <div class="form-group">
               <label>Size: </label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged ="RecalculateCost">
                    <asp:ListItem Text="Choose One ..." value ="" Selected="True" />
                    <asp:ListItem Text="Small (12inch - $12)" value="Small" />
                    <asp:ListItem Text="Medium (14inch - $14)" value="Medium" />
                    <asp:ListItem Text="Large (16inch - $16)" value="Large" />
                </asp:DropDownList>
           </div>

            <div class="form-group">
               <label>Crust: </label>
                <asp:DropDownList ID="pizzaCrustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true"  OnSelectedIndexChanged ="RecalculateCost">
                    <asp:ListItem Text="Choose One ..." value ="" Selected="True" />
                    <asp:ListItem Text="Regular" value="Regular" />
                    <asp:ListItem Text="Thin" value="Thin" />
                    <asp:ListItem Text="Thick(+ $2)" value="Thick" />
                </asp:DropDownList>
           </div>

           
          <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true"  OnCheckedChanged ="RecalculateCost" />Sausage</label></div>
          <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true"  OnCheckedChanged ="RecalculateCost"/>Pepperoni</label></div>
          <div class="checkbox"><label> <asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true"  OnCheckedChanged ="RecalculateCost"/>Onions</label></div>
          <div class="checkbox"><label>  <asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true"  OnCheckedChanged ="RecalculateCost"/>Green Peppers</label></div>
          
       
          
           <h3>Deliver To:</h3>

           <div class="form-group">
             <label>Name: </label>
             <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group">
             <label> Address: </label>
             <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group">
             <label>Zip: </label>
             <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
          <div class="form-group">
             <label>Phone: </label>
             <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" ></asp:TextBox>
           </div>

           <h3>Payment:</h3>
           <div class="radio">
             <label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentGroup" Checked ="true"/>Cash</label>
           </div>
           <div class="radio">
             <label><asp:RadioButton ID="creditCardRadioButton" runat="server" GroupName="paymentGroup"/>Credit Card</label>
            </div>

           <asp:Button ID="orderButton" runat="server" Text="Order"  CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click"/>
          <p>&nbsp</p>
           <asp:Label ID="ValidationLabel" runat="server" Text="" CssClass ="bg-danger" Visible ="false"></asp:Label>
         <h3>Total Cost: <asp:Label ID="totalCostLabel" runat="server" Text="" AutoPostBack ="true"></asp:Label></h3>

         <p>&nbsp</p>
         <p>&nbsp</p>
   </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
