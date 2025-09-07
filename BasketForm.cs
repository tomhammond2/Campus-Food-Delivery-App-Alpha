using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniEats_Alpha
{
    
    public partial class BasketForm : Form
    {
        public static List<string> itemName = new List<string>();
        public static List<decimal> ItemPrice = new List<decimal>();

        public BasketForm()
        {
            InitializeComponent();
        }

        public void AddToBasket(string item, decimal price)
        {

            itemName.Add(item);
            ItemPrice.Add(price);

        }

        private void BasketForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in itemName)
            {
                label1.Text = item.ToString();
            }

            foreach (int price in ItemPrice)
            {
                label1.Text = label1 + price.ToString();
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            FinsihedCheckout checkoutPage = new FinsihedCheckout();
            this.Hide();
            checkoutPage.Show();
        }
    }
}
