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
    public partial class RegisterForm : Form
    {

      

        public RegisterForm()
        {
            InitializeComponent();
           


        }


        private void SignupBotton_Click(object sender, EventArgs e)
        {
            bool DuplicateUname = false;
            if (UsernameTextBox.Text != "")
            {
                foreach (string username in Program.userName)
                { 
                    if (UsernameTextBox.Text == username)
                    {
                        InvaildUname.Visible = true;
                        DuplicateUname = true;
                        break;
                    }
                }
                if (DuplicateUname == false)
                {
                    if (PasswordTextBox.Text != "")
                    {
                        if (PasswordTextBox.Text == textBox1.Text)
                        {
                            if (UserTypeDropDown.Text != "")
                            {
                                this.Hide();
                                ViewRestaurants ViewRestaurantsPage = new ViewRestaurants();
                                ViewRestaurantsPage.Show();
                            }
                        }
                    }
                }
                
            }
        }

        private void PasswordHide_Click(object sender, EventArgs e)
        {
            //if (PasswordHide.Enabled == true)
            //{
            //    //PasswordTextBox.PasswordChar = default;
            //    //if (MouseUp == MouseButtonState.Pressed)
            //    //{
            //    //    UpdateSampleResults("Left Button Pressed");
            //    //}
            //}
            //else
            //{
            //    PasswordTextBox.PasswordChar = '*';
            //}
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }

     
    }
}
