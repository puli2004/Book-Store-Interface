using System;
using System.Windows.Forms;
using System.Configuration;

namespace BookStoreApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            string conn = ConfigurationManager.ConnectionStrings["BookStoreDb"]?.ConnectionString;

            Console.WriteLine("Connection string read from app.config:");
            Console.WriteLine(conn ?? "NULL (not found!)");
            Console.ReadLine();

            Application.Run(new LoginForm());
        }
    }
}
