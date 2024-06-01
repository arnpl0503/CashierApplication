
using ItemNameSpace;

namespace CashierApplication02
{
    public partial class Form1 : Form
    {


        private double total_amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string item_name = ItemtextBox.Text;
            double item_price = Convert.ToDouble(ItemPricetextBox.Text);
            double item_discount = Convert.ToDouble(ItemDiscounttextBox.Text);
            int item_quantity = Convert.ToInt32(QuantitytextBox.Text);

            DiscountedItem discountedItem = new DiscountedItem(item_name, item_price, item_quantity, item_discount);
            total_amount = discountedItem.getTotalPrice();
            TotalAmountlabel.Text = total_amount.ToString("0.00");

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {

            double paymentRecieved = Convert.ToDouble(PaymentReceivedtextBox.Text);

            DiscountedItem discountedItem = new DiscountedItem("", 0, 0, 0);
            discountedItem.setPayment(paymentRecieved);
            double change = discountedItem.getChange(total_amount);
            ChangeLabel.Text = change.ToString("0.00");

        }
    }
}










               
