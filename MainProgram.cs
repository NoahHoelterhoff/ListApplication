using System;
using System.ComponentModel;
using System.Windows.Forms;
using ListApplication.Types;

namespace ListApplication
{
    internal static class MainProgram
    {
        private static readonly BindingList<Customer> customerList = [];

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PosForm(customerList));
        }

        public static double CalculateTotal(Customer customer)
        {
            return 0;
        }

        public static double FromEURToUSD(double eur)
        {
            return eur;
        }
    }
}