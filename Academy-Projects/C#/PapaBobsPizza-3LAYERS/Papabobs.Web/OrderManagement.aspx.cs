using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Papabobs.Web
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridOrder();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            var value = row.Cells[1].ToString();
            var orderId = Guid.Parse(value);

            PapaBobs.Domain.PizzaManager.CompleteOrder(orderId);
            refreshGridOrder();
        }
        private void refreshGridOrder()
        {
            var orders = PapaBobs.Domain.PizzaManager.GetOrder();
            GridView1.DataSource = orders;
            GridView1.DataBind();
        }
    }
}