using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace postage_calculator_challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) return;
        }

        protected void handleChanged(object sender, EventArgs e)
        {
            if (!valueEnter()) return;
            int volume = 0; 
            if (!tryGetVolume( out volume)) return;
            double multiplier = shippingMethodMultiplier();
            double cost = volume * multiplier;
            resultLabel.Text = string.Format("Your parcel cost {0:C} to ship!", cost);
        }

        private double shippingMethodMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            if (airRadioButton.Checked) return .25;
            if (nextDayRadioButton.Checked) return .45;

            return 0;
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length))  length = 1;

            volume = width * height * length;

            return true;
        }

       
        private bool valueEnter()
        {
            if (!groundRadioButton.Checked &&
                !airRadioButton.Checked &&
                !nextDayRadioButton.Checked) return false;
            if (widthTextBox.Text.Trim().Length == 0 ||
                heightTextBox.Text.Trim().Length == 0) return false;
            return true;
        }
        
    }
}