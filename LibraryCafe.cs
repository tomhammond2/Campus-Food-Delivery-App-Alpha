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
    public partial class LibraryCafe : Form
    {
        BasketForm Basket = new BasketForm();
        public LibraryCafe()
        {
            InitializeComponent();
        }

        private void AllBoxNonVisable()
        {
            HotDrinksBox.Visible = false;
            HotSnacksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            ColdDrinksBox.Visible = false;

        }

        private void ColdDrinks_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            ColdDrinksBox.Show();
        }
        private void HotDrinks_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            HotDrinksBox.Show();
        }
        private void HotSnacks_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            HotSnacksBox.Show();

        }
        private void ColdSnacks_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            ColdSnacksBox.Show();
        }
        private void DessertsButton_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            DessertsBox.Show();
        }

        // Cold Drink Buttons 
        private void CokeLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Coka-Cola", 1.20m); 
        }
        private void DCokeLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Diet Coke", 1.10m);
        }
        private void FantaLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Fanta", 1.10m);
        }
        private void FTFantaLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Fanta Fruit Twist", 1.10m);
        }
        private void SpriteLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Sprite", 1.00m);
        }
        private void DrPepperLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Dr Pepper", 1.20m);
        }
        private void RibenaLabel_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Ribena", 1.00m);
        }

        // Hot Snacks Buttons 
        private void label21_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Cheese and Ham Toastie", 3.99m);
        }
        private void label20_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Chicken Fajita Wrap", 4.35m);
        }
        private void label19_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Mac n Cheese", 3.10m);
        }
        private void label18_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Tuna Melt", 2.60m);
        }
        private void label17_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Vegan BBQ Chick'n Panini", 2.35m);
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Sausage Roll", 1.80m);
        }
        private void label15_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Vegan Roll", 1.90m);
        }

        //Hot Drinks Labels
        private void label14_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Latte", 2.35m);
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Flate White", 2.35m);
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Americano", 2.00m);
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Mocha", 2.60m);
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Cappuccino", 2.35m);
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Basket.AddToBasket("Hot Chocolate", 2.60m);
        }

        // Desserts Buttons 
        private void label36_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Choclate Brownie", 1.99m);
        }
        private void label35_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Flapjack", 1.79m);
        }
        private void label34_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Choclate Cookie", 1.29m);
        }
        private void label33_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Millionair Shortbread", 2.49m);
        }
        private void label32_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Bakewell Tart", 1.35m);
        }
        private void label31_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Chocolate Conflake Cake", 0.60m);
        }
        private void label29_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Rolo Muffin", 2.00m);
        }

        //Cold Snacks
        private void label28_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("BLT Sandwich", 1.20m);
        }
        private void label27_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Prawn Mayo Sandwich", 2.79m);
        }
        private void label26_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Chicken Sandwich", 2.59m);
        }
        private void label25_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Tuna Sandwich", 2.49m);
        }
        private void label24_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Egg and Cress Sandwich", 2.35m);
        }
        private void label23_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Sausage Roll", 1.60m);
        }
        private void label8_Click_1(object sender, EventArgs e)
        {
            Basket.AddToBasket("Pineapple Chunks", 1.00m);
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Basket.Show(); 
        }
    }
}
