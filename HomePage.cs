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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginPage = new LoginForm();
           LoginPage.Show();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RegisterPage = new RegisterForm();
            RegisterPage.Show();
        }

      
    }
}
