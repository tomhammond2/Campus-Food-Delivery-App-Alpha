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
    public partial class ViewRestaurants : Form
    {
        public ViewRestaurants()
        {
            InitializeComponent();
        }


        private void SparButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SparShop Shop = new SparShop();
            Shop.Show();
        }

        private void WetherSpoonsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            WetherSpoons Restaurant = new WetherSpoons();
            Restaurant.Show();
        }

        private void PantryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Pantry Restaurant = new Pantry();
            Restaurant.Show();
        }

        private void LibraryCafeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LibraryCafe Shop = new LibraryCafe();
            Shop.Show();
        }
    }


}
