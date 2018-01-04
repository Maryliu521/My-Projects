using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(firstValueTextBox.Text);
            int secondValue = int.Parse(secondValueTextBox.Text);
            int result = firstValue + secondValue;
            resultLabel.Text = result.ToString();

        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(firstValueTextBox.Text);
            int secondValue = int.Parse(secondValueTextBox.Text);
            int result = firstValue - secondValue;
            resultLabel.Text = result.ToString();

        }

        protected void Times_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(firstValueTextBox.Text);
            int secondValue = int.Parse(secondValueTextBox.Text);
            int result = firstValue * secondValue;
            resultLabel.Text = result.ToString();

        }

        protected void Divid_Click(object sender, EventArgs e)
        {
           int firstValue = int.Parse(firstValueTextBox.Text);
            int secondValue = int.Parse(secondValueTextBox.Text);
            double result = (double)firstValue / secondValue;
            resultLabel.Text = result.ToString();
            

        }
    }
}