
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form4 : Form
    {
        // Keep product records while the program runs
        private static readonly ProductCatalog catalog =
            new ProductCatalog();

        public Form4()
        {
            InitializeComponent();

            // Automatically fit the form to the screen
            this.Load += (sender, e) => ResponsiveForm.Fit(this);

            // Connect buttons
            btnAddProduct.Click += btnAddProduct_Click;
            btnSearchProduct.Click += btnSearchProduct_Click;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            btnDisplayProducts.Click += btnDisplayProducts_Click;
            btnBack.Click += btnBack_Click;

            // Select product from table
            dgvProducts.CellClick += dgvProducts_CellClick;

            DisplayProducts();
        }

        // =====================================
        // VALIDATE PRODUCT CODE
        // =====================================
        private bool TryGetProductCode(out string code)
        {
            code = txtProductCode.Text.Trim()
                .ToUpperInvariant();

            if (!ProductCatalog.IsValidProductCode(code))
            {
                MessageBox.Show(
                    "Please enter a valid product code." +
                    "\nRequired format: PRD-001",
                    "Invalid Product Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductCode.Focus();
                return false;
            }

            txtProductCode.Text = code;
            return true;
        }

        // =====================================
        // VALIDATE PRODUCT PRICE
        // =====================================
        private bool TryGetProductPrice(out decimal price)
        {
            string input = txtProductPrice.Text.Trim();

            if (!decimal.TryParse(
                input,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out price) ||
                price < 0)
            {
                MessageBox.Show(
                    "Please enter a valid non-negative price." +
                    "\nExample: 150.00",
                    "Invalid Product Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductPrice.Focus();
                return false;
            }

            if (decimal.Round(price, 2) != price)
            {
                MessageBox.Show(
                    "Price can have at most two decimal places.",
                    "Invalid Product Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductPrice.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // ADD PRODUCT
        // =====================================
        private void btnAddProduct_Click(
            object sender, EventArgs e)
        {
            if (!TryGetProductCode(out string code))
            {
                return;
            }

            string name = txtProductName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show(
                    "Please enter a product name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductName.Focus();
                return;
            }

            if (!TryGetProductPrice(out decimal price))
            {
                return;
            }

            if (catalog.AddProduct(code, name, price))
            {
                MessageBox.Show(
                    "Product registered successfully!" +
                    "\nProduct Code: " + code +
                    "\nProduct Name: " + name +
                    "\nPrice: PHP " + price.ToString("N2"),
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtProductCode.Clear();
                txtProductName.Clear();
                txtProductPrice.Clear();

                DisplayProducts();

                lblStatus.Text =
                    "Product " + code + " added successfully.";

                txtProductCode.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Unable to add this product." +
                    "\nCheck for duplicate codes or invalid details.",
                    "Product Not Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =====================================
        // SEARCH PRODUCT
        // =====================================
        private void btnSearchProduct_Click(
            object sender, EventArgs e)
        {
            if (!TryGetProductCode(out string code))
            {
                return;
            }

            if (catalog.SearchProduct(
                code, out ProductInfo? product) &&
                product != null)
            {
                txtProductName.Text = product.Name;

                txtProductPrice.Text =
                    product.Price.ToString(
                        "0.00", CultureInfo.CurrentCulture);

                // Highlight the product in the table
                dgvProducts.ClearSelection();

                foreach (DataGridViewRow row
                    in dgvProducts.Rows)
                {
                    string rowCode =
                        row.Cells["colProductCode"]
                        .Value?.ToString() ?? "";

                    if (string.Equals(
                        rowCode,
                        code,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        dgvProducts.CurrentCell =
                            row.Cells["colProductCode"];

                        row.Selected = true;
                        break;
                    }
                }

                MessageBox.Show(
                    "Product Found!" +
                    "\nProduct Code: " + code +
                    "\nProduct Name: " + product.Name +
                    "\nPrice: PHP " +
                    product.Price.ToString("N2"),
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Product " + code + " found.";
            }
            else
            {
                dgvProducts.ClearSelection();

                txtProductName.Clear();
                txtProductPrice.Clear();

                MessageBox.Show(
                    "Product code " + code +
                    " was not found.",
                    "Product Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Product not found.";
            }
        }

        // =====================================
        // REMOVE PRODUCT
        // =====================================
        private void btnRemoveProduct_Click(
            object sender, EventArgs e)
        {
            if (!TryGetProductCode(out string code))
            {
                return;
            }

            if (!catalog.SearchProduct(
                code, out ProductInfo? product) ||
                product == null)
            {
                MessageBox.Show(
                    "Product code " + code +
                    " does not exist.",
                    "Product Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this product?" +
                "\n\nProduct Code: " + code +
                "\nProduct Name: " + product.Name +
                "\nPrice: PHP " +
                product.Price.ToString("N2"),
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (catalog.RemoveProduct(code))
            {
                MessageBox.Show(
                    "Product removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtProductCode.Clear();
                txtProductName.Clear();
                txtProductPrice.Clear();

                DisplayProducts();

                lblStatus.Text =
                    "Product " + code + " removed successfully.";
            }
        }

        // =====================================
        // DISPLAY ALL PRODUCTS
        // =====================================
        private void DisplayProducts()
        {
            dgvProducts.Rows.Clear();

            // Get records from DictionaryBase
            System.Collections.DictionaryEntry[] products =
                catalog.GetProducts();

            foreach (System.Collections.DictionaryEntry entry
                in products)
            {
                ProductInfo product =
                    (ProductInfo)entry.Value;

                dgvProducts.Rows.Add(
                    entry.Key,
                    product.Name,
                    product.Price);
            }

            lblProductCount.Text =
                "Total Products: " +
                catalog.GetProductCount();

            dgvProducts.ClearSelection();

            if (catalog.GetProductCount() == 0)
            {
                lblStatus.Text =
                    "Product catalog is empty.";
            }
            else
            {
                lblStatus.Text =
                    "Product catalog is ready.";
            }
        }

        // =====================================
        // DISPLAY PRODUCTS BUTTON
        // =====================================
        private void btnDisplayProducts_Click(
            object sender, EventArgs e)
        {
            DisplayProducts();

            if (catalog.GetProductCount() > 0)
            {
                lblStatus.Text =
                    "Product catalog refreshed.";
            }
        }

        // =====================================
        // SELECT PRODUCT FROM DATAGRIDVIEW
        // =====================================
        private void dgvProducts_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvProducts.Rows[e.RowIndex];

            txtProductCode.Text =
                row.Cells["colProductCode"]
                .Value?.ToString() ?? "";

            txtProductName.Text =
                row.Cells["colProductName"]
                .Value?.ToString() ?? "";

            object? priceValue =
                row.Cells["colProductPrice"].Value;

            if (priceValue != null)
            {
                decimal price =
                    Convert.ToDecimal(priceValue);

                txtProductPrice.Text =
                    price.ToString(
                        "0.00", CultureInfo.CurrentCulture);
            }

            lblStatus.Text =
                "Product " + txtProductCode.Text +
                " selected.";
        }

        // =====================================
        // BACK TO MAIN MENU
        // =====================================
        private void btnBack_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
