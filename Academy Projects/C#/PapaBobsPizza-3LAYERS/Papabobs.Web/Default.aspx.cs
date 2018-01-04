using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobs.DTO.Enums;

namespace Papabobs.Web
{
    public partial class Default : System.Web.UI.Page
    { protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void orderButton_Click(object sender, EventArgs e)
        {
            validation();
            try
            {
                var order = buildOrder();
                PapaBobs.Domain.PizzaManager.CreateOrder(order);
                Response.Redirect("Success.aspx");
            }
            catch (Exception ex)
            {
                ValidationLabel.Text = ex.Message;
                ValidationLabel.Visible = true;
            }
            
          }

        private void validation()
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                ValidationLabel.Text = "Please enter a name!";
                ValidationLabel.Visible = true;
                return;
            }
            if (addressTextBox.Text.Trim().Length == 0)
            {
                ValidationLabel.Text = "Please enter an address!";
                ValidationLabel.Visible = true;
               return;
            }
            if (zipTextBox.Text.Trim().Length == 0)
            {
                ValidationLabel.Text = "Please enter a zip code!";
                ValidationLabel.Visible = true;
               return;
            }
            if (phoneTextBox.Text.Trim().Length == 0)
            {
                ValidationLabel.Text = "Please enter a phone number!";
                ValidationLabel.Visible = true;
                return;
            }

        }

        private PaymentType determindPaymentType()
        {
            PaymentType paymentType;
            if (cashRadioButton.Checked)
            {
                paymentType = PaymentType.Cash;
            }
            else 
            {
                paymentType = PaymentType.CreditCard;
            }
           
            return paymentType;
        }

        private CrustType detemindCrust()
        {
            CrustType crust;
            if (!Enum.TryParse(pizzaCrustDropDownList.Text, out crust))
            {
                throw new Exception("Couldn't determind Pizza Crust!");
            }
            return crust;
        }

        private PapaBobs.DTO.Enums.SizeType determindSize()
        {
            PapaBobs.DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.Text, out size))
            {
                throw new Exception("Could not determind Pizza's size!");
            }
            return size;

        }
       
           protected void RecalculateCost(object sender, EventArgs e)
          {
            if (sizeDropDownList.SelectedValue == string.Empty) return;
            if (pizzaCrustDropDownList.SelectedValue == string.Empty) return;
            try
            {
                var order = buildOrder();
                totalCostLabel.Text = PapaBobs.Domain.PizzaPriceManager.CalculateCost(order).ToString("C");
               
            }
            catch (Exception ex)
            {
                ValidationLabel.Text = ex.Message;
                ValidationLabel.Visible = true;
            }
          }
        private PapaBobs.DTO.Pizza buildOrder()
        {
            var order = new PapaBobs.DTO.Pizza();
            order.OrderId = Guid.NewGuid();
            order.Size = determindSize();
            order.Crust = detemindCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.Payment = determindPaymentType();
            return order;
        }
    }
}