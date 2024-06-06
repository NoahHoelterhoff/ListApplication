using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ListApplication.Types;

namespace ListApplication
{
    public partial class PosForm : Form
    {
        private readonly BindingList<Customer> customerList;

        public PosForm(BindingList<Customer> customers)
        {
            customerList = customers;
            InitializeComponent();

            // Customer Data Grid
            customerDataGrid.DataSource = customerList;
            customerDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Product Data Grid
            productDataGrid.DataSource = new BindingList<ProductOrder>();
            productDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Selection for Products
            productComboBox.DataSource = Product.availableProducts;

            // New User Input
            membershipComboBox.DataSource = Enum.GetValues(typeof(Membership));
            membershipComboBox.SelectedItem = Membership.Basic;
        }

        private void ShowTotal()
        {
            // Get the current customer
            if (customerDataGrid.CurrentRow == null) return;
            int index = customerDataGrid.CurrentRow.Index;
            if (index < 0) return;
            Customer currentCustomer = customerList[index];

            // Calculate the total and show it
            double total = MainProgram.CalculateTotal(currentCustomer);
            totalTextBox.Text = $"{total} €";
        }

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = customerList[e.RowIndex];
            productDataGrid.DataSource = customer.Basket;
            productDataGrid.Refresh();
            ShowTotal();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            // Get the selected product from the combo box
            Product selectedProduct = (Product)productComboBox.SelectedItem;
            if (selectedProduct == null) return;

            // Get the current customer
            if (customerDataGrid.CurrentRow == null) return;
            int index = customerDataGrid.CurrentRow.Index;
            if (index < 0) return;
            Customer currentCustomer = customerList[index];

            // Check if the product is already in the basket
            ProductOrder existingProductOrder = currentCustomer.Basket.FirstOrDefault(po => po.Product == selectedProduct);

            if (existingProductOrder != null)
            {
                // Increase the quantity of the existing product order
                existingProductOrder.Quantity++;
            }
            else
            {
                // Add the product to the basket with quantity 1
                currentCustomer.Basket.Add(new ProductOrder(selectedProduct, 1));
            }

            // Refresh the product data grid
            productDataGrid.Refresh();
            ShowTotal();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            // Get the name from the input
            string name = nameInput.Text;
            if (string.IsNullOrWhiteSpace(name)) return;

            // Get the selected membership from the combo box
            Membership membership = (Membership)membershipComboBox.SelectedItem;

            // Create a new customer
            Customer newCustomer = new(name, membership);

            // Add the new customer to the list
            customerList.Add(newCustomer);
            customerDataGrid.Refresh();
            customerDataGrid.CurrentCell = customerDataGrid.Rows[customerList.Count - 1].Cells[0];
            productDataGrid.DataSource = newCustomer.Basket;
            productDataGrid.Refresh();
            ShowTotal();
        }
    }
}
