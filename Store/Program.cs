using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Forms;
using Store.DataModel;

namespace Store
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new MainForm());
        }
    }

    public class GlobalVars
    {
        public static List<Product> ShoppingCartList = new List<Product>();
        public static List<Product> CurrentProductsList = new List<Product>();
        public static User CurrentUser = new User();
        public static bool userIsConnected;
        public static AutorizationForm autorizationForm = new AutorizationForm();
        public static RegistrationForm registrationForm = new RegistrationForm();
        public static CheckingOrderForm checkingOrderForm = new CheckingOrderForm();
    }
}
