using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBillProject
{
    public partial class ElectricityBillForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ElectricityBoard board = new ElectricityBoard();
        BillValidator validator = new BillValidator();
        int BillCount
        {
            get { return ViewState["BillCount"] == null ? 0 : (int)ViewState["BillCount"]; }
            set { ViewState["BillCount"] = value; }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int totalBills = Convert.ToInt32(txtCount.Text);

            ElectricityBill eb = new ElectricityBill();
            eb.ConsumerNumber = txtNo.Text;
            eb.ConsumerName = txtName.Text;

            int units = Convert.ToInt32(txtUnits.Text);

            string msg = validator.ValidateUnitsConsumed(units);
            if (msg != "Valid")
            {
                lblOutput.Text = msg;
                txtUnits.Focus();
                return;
            }

            eb.UnitsConsumed = units;

            board.CalculateBill(eb);
            board.AddBill(eb);

            BillCount++;

            lblOutput.Text += $"{eb.ConsumerNumber} {eb.ConsumerName} " +
                             $"{eb.UnitsConsumed} Bill Amount : {eb.BillAmount}<br/>";

            txtNo.Text = "";
            txtName.Text = "";
            txtUnits.Text = "";

            if (BillCount == totalBills)
            {
                txtCount.Text = "";
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtLast.Text);
            gvBills.DataSource = board.Generate_N_BillDetails(n);
            gvBills.DataBind();
        }

        protected void txtNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Validate format using ElectricityBill model
                ElectricityBill bill = new ElectricityBill();
                bill.ConsumerNumber = txtNo.Text.Trim(); // validates EB + 5 digits

                string name = board.GetConsumerName(bill.ConsumerNumber);

                if (name != "")
                {
                    txtName.Text = name;
                    txtName.ReadOnly = true;
                    lblOutput.Text = "";
                }
                else
                {
                    txtName.Text = "";
                    lblOutput.Text = "Consumer number not found";
                    txtNo.Focus();
                }
            }
            catch (FormatException ex)
            {
                txtName.Text = "";
                lblOutput.Text = ex.Message;
                txtNo.Focus();
            }
        }

    }
}
