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
    public partial class SparShop : Form
    {
        BasketForm Basket = new BasketForm();

        public SparShop()
        {
            InitializeComponent();
        }
        private void AllBoxNonVisable()
        {
            HotDrinksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            ColdDrinksBox.Visible = false;
            FrozenBox.Visible = false;
            Chilledbox.Visible = false;

        }


        private void SparShop_Load(object sender, EventArgs e)
        {

        }

        private void ColdDrinks_Click_1(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            ColdDrinksBox.Show();
        }

        private void HotDrinks_Click_1(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            HotDrinksBox.Show();
        }

        private void ColdSnacks_Click_1(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            ColdSnacksBox.Show();
        }

        private void DessertsButton_Click_1(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            DessertsBox.Show();
        }

        private void Frozenbutton_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            FrozenBox.Show();
        }

        private void ChilledFoodbutton_Click(object sender, EventArgs e)
        {
            AllBoxNonVisable();
            Chilledbox.Show();
        }
    }
}
