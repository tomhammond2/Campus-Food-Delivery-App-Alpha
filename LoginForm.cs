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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();

        }

        private void RegisterTextLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)  //Used to log in user if the correct username and password have been used 
        {
            
            try
            {
                //Seraches through the usernames within th sysetm then checks to see if the user
                // has inputed one of the permitted usernames then unsures that the password provided also matches user details
                for (int user = 0; user < Program.userName.Count; user++)
                {
                    if (Program.userName[user] == UsernameTextBox.Text)
                    {
                        if (Program.userPassword[user] == PasswordTextBox.Text)
                        {
                            this.Hide();
                            ViewRestaurants ViewRestaurantsPage = new ViewRestaurants();
                            ViewRestaurantsPage.Show();
                            break;
                        }

                    }
                    else
                    {
                        //If a error occors or password or user name not matching or in sytem the user will be displayed a error message and ask if they want to register
                        InvaildUnameOrPword.Visible = true;
                        RegisterNowLabel.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                InvaildUnameOrPword.Visible = true;
                RegisterNowLabel.Visible = true;
            }
           

            
          
        }

        private void RegisterNowLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Register = new RegisterForm();
            Register.Show();
        }
    }
}
