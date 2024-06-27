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
            try
            {
                double total = 0;
                for (int i = 0; i < customer.Basket.Count; i++)
                {

                    if (customer.Basket[i].Quantity > 5)
                    {
                        total += customer.Basket[i].Product.Price * customer.Basket[i].Quantity * .9;
                    }
                    else
                    {
                        total += customer.Basket[i].Product.Price * customer.Basket[i].Quantity;
                    }


                }
                
                return total;
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return 0;
        }

        public static double FromEURToUSD(double eur)
        {
            return eur;
        }
    }
}