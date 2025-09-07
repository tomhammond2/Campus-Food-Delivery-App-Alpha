using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace UniEats_Alpha
{
  
    static class Program
    {
        private static string filePath = "Users.csv";
        public static List<string> userName  = new List<string>();
        public static List<string> userPassword = new List<string>();
        public static List<string> userType = new List<string>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

          

            using (StreamReader reader = new StreamReader(filePath))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();   //Reads each line of file 
                    var values = line.Split(',', ',');   //Splits the colums at the comma 

                    userName.Add(values[0]);       //Adds the values of the username colum to the list 
                    userPassword.Add(values[1]);          //Adds the values of the password colum to the list
                    userType.Add(values[2]);             //Adds the values of the user type colum to the list


                }

               

            }

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage()); // Opens Home Page 
            //Application.Run(new ViewRestaurants()); // Opens View Restaurants Page (Testing Purpose)
            //Application.Run(new LibraryCafe()); // Opens Library Restaurant Page (Testing Purpose)
           // Application.Run(new BasketForm()); // Opens Basket Page (Testing Purpose)

        }


    }
}
