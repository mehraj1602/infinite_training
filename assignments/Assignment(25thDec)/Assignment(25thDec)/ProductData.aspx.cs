using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_25thDec_
{
    public partial class ProductData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlProducts.SelectedItem.Text)
            {
                case "hairdryer":
                    imgProduct.ImageUrl = "~/Images/hairdryer.jpg";
                    break;

                case "DysonAirstraight":
                    imgProduct.ImageUrl = "~/Images/DysonAirstraight.jpg";
                    break;

                case "ElectricKettle":
                    imgProduct.ImageUrl = "~/Images/ElectricKettle.jpg";
                    break;

                default:
                    imgProduct.ImageUrl = "";
                    lblPrice.Text = "";
                    break;
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedIndex > 0)
            {
                lblPrice.Text = "Price : ₹ " + ddlProducts.SelectedValue;
            }
            else
            {
                lblPrice.Text = "Please select a product";
            }
        }

    }
}