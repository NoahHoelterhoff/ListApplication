using System.Drawing;
using System.Windows.Forms;

namespace ListApplication
{
    partial class PosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            customerDataGrid = new DataGridView();
            productDataGrid = new DataGridView();
            totalLayout = new TableLayoutPanel();
            totalTextBox = new TextBox();
            totalLabel = new Label();
            customerBtnLayout = new TableLayoutPanel();
            addCustomerBtn = new Button();
            removeCustomerBtn = new Button();
            nameInput = new TextBox();
            membershipComboBox = new ComboBox();
            productBtnLayout = new TableLayoutPanel();
            addProductBtn = new Button();
            removeProductBtn = new Button();
            productComboBox = new ComboBox();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGrid).BeginInit();
            totalLayout.SuspendLayout();
            customerBtnLayout.SuspendLayout();
            productBtnLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.99999F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            mainLayout.Controls.Add(customerDataGrid, 0, 2);
            mainLayout.Controls.Add(productDataGrid, 1, 2);
            mainLayout.Controls.Add(totalLayout, 0, 3);
            mainLayout.Controls.Add(customerBtnLayout, 0, 1);
            mainLayout.Controls.Add(productBtnLayout, 1, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.Size = new Size(917, 361);
            mainLayout.TabIndex = 0;
            // 
            // customerDataGrid
            // 
            customerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGrid.Dock = DockStyle.Fill;
            customerDataGrid.Location = new Point(3, 38);
            customerDataGrid.MultiSelect = false;
            customerDataGrid.Name = "customerDataGrid";
            customerDataGrid.ReadOnly = true;
            customerDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGrid.Size = new Size(452, 285);
            customerDataGrid.TabIndex = 1;
            customerDataGrid.CellClick += CustomerDataGrid_CellClick;
            // 
            // productDataGrid
            // 
            productDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGrid.Dock = DockStyle.Fill;
            productDataGrid.Location = new Point(461, 38);
            productDataGrid.Name = "productDataGrid";
            productDataGrid.ReadOnly = true;
            productDataGrid.Size = new Size(453, 285);
            productDataGrid.TabIndex = 2;
            // 
            // totalLayout
            // 
            totalLayout.AutoSize = true;
            totalLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            totalLayout.ColumnCount = 4;
            mainLayout.SetColumnSpan(totalLayout, 2);
            totalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            totalLayout.ColumnStyles.Add(new ColumnStyle());
            totalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            totalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            totalLayout.Controls.Add(totalTextBox, 2, 0);
            totalLayout.Controls.Add(totalLabel, 1, 0);
            totalLayout.Dock = DockStyle.Fill;
            totalLayout.Location = new Point(3, 329);
            totalLayout.Name = "totalLayout";
            totalLayout.RowCount = 1;
            totalLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalLayout.Size = new Size(911, 29);
            totalLayout.TabIndex = 3;
            // 
            // totalTextBox
            // 
            totalTextBox.Dock = DockStyle.Fill;
            totalTextBox.Location = new Point(302, 3);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(343, 23);
            totalTextBox.TabIndex = 0;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Dock = DockStyle.Fill;
            totalLabel.Location = new Point(264, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(32, 29);
            totalLabel.TabIndex = 1;
            totalLabel.Text = "Total";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerBtnLayout
            // 
            customerBtnLayout.AutoSize = true;
            customerBtnLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customerBtnLayout.ColumnCount = 4;
            customerBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            customerBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            customerBtnLayout.ColumnStyles.Add(new ColumnStyle());
            customerBtnLayout.ColumnStyles.Add(new ColumnStyle());
            customerBtnLayout.Controls.Add(addCustomerBtn, 2, 0);
            customerBtnLayout.Controls.Add(removeCustomerBtn, 3, 0);
            customerBtnLayout.Controls.Add(nameInput, 0, 0);
            customerBtnLayout.Controls.Add(membershipComboBox, 1, 0);
            customerBtnLayout.Dock = DockStyle.Fill;
            customerBtnLayout.Location = new Point(3, 3);
            customerBtnLayout.Name = "customerBtnLayout";
            customerBtnLayout.RowCount = 1;
            customerBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            customerBtnLayout.Size = new Size(452, 29);
            customerBtnLayout.TabIndex = 4;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(293, 3);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(75, 23);
            addCustomerBtn.TabIndex = 0;
            addCustomerBtn.Text = "Add";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // removeCustomerBtn
            // 
            removeCustomerBtn.Location = new Point(374, 3);
            removeCustomerBtn.Name = "removeCustomerBtn";
            removeCustomerBtn.Size = new Size(75, 23);
            removeCustomerBtn.TabIndex = 1;
            removeCustomerBtn.Text = "Remove";
            removeCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Fill;
            nameInput.Location = new Point(3, 3);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(139, 23);
            nameInput.TabIndex = 2;
            // 
            // membershipComboBox
            // 
            membershipComboBox.Dock = DockStyle.Fill;
            membershipComboBox.FormattingEnabled = true;
            membershipComboBox.Location = new Point(148, 3);
            membershipComboBox.Name = "membershipComboBox";
            membershipComboBox.Size = new Size(139, 23);
            membershipComboBox.TabIndex = 3;
            // 
            // productBtnLayout
            // 
            productBtnLayout.AutoSize = true;
            productBtnLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productBtnLayout.ColumnCount = 3;
            productBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            productBtnLayout.ColumnStyles.Add(new ColumnStyle());
            productBtnLayout.ColumnStyles.Add(new ColumnStyle());
            productBtnLayout.Controls.Add(addProductBtn, 1, 0);
            productBtnLayout.Controls.Add(removeProductBtn, 2, 0);
            productBtnLayout.Controls.Add(productComboBox, 0, 0);
            productBtnLayout.Dock = DockStyle.Fill;
            productBtnLayout.Location = new Point(461, 3);
            productBtnLayout.Name = "productBtnLayout";
            productBtnLayout.RowCount = 1;
            productBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            productBtnLayout.Size = new Size(453, 29);
            productBtnLayout.TabIndex = 5;
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(294, 3);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(75, 23);
            addProductBtn.TabIndex = 0;
            addProductBtn.Text = "Add";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += AddProductBtn_Click;
            // 
            // removeProductBtn
            // 
            removeProductBtn.Location = new Point(375, 3);
            removeProductBtn.Name = "removeProductBtn";
            removeProductBtn.Size = new Size(75, 23);
            removeProductBtn.TabIndex = 1;
            removeProductBtn.Text = "Remove";
            removeProductBtn.UseVisualStyleBackColor = true;
            // 
            // productComboBox
            // 
            productComboBox.Dock = DockStyle.Fill;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(3, 3);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(285, 23);
            productComboBox.TabIndex = 2;
            // 
            // PosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 361);
            Controls.Add(mainLayout);
            Name = "PosForm";
            Text = "Pos System";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGrid).EndInit();
            totalLayout.ResumeLayout(false);
            totalLayout.PerformLayout();
            customerBtnLayout.ResumeLayout(false);
            customerBtnLayout.PerformLayout();
            productBtnLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private DataGridView customerDataGrid;
        private DataGridView productDataGrid;
        private TableLayoutPanel totalLayout;
        private TextBox totalTextBox;
        private Label totalLabel;
        private TableLayoutPanel customerBtnLayout;
        private Button addCustomerBtn;
        private Button removeCustomerBtn;
        private TableLayoutPanel productBtnLayout;
        private Button addProductBtn;
        private Button removeProductBtn;
        private ComboBox productComboBox;
        private TextBox nameInput;
        private ComboBox membershipComboBox;
    }
}
