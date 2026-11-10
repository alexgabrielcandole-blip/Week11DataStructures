
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form5 : Form
    {
        // Keep product pairs while the application runs
        private static readonly ProductPairManager manager =
            new ProductPairManager();

        public Form5()
        {
            InitializeComponent();

            // Automatically fit the screen
            this.Load += (sender, e) =>
                ResponsiveForm.Fit(this);

            // Connect buttons
            btnAddPair.Click += btnAddPair_Click;
            btnSearchProduct.Click += btnSearchProduct_Click;
            btnRemovePair.Click += btnRemovePair_Click;
            btnDisplayPairs.Click += btnDisplayPairs_Click;
            btnBack.Click += btnBack_Click;

            // Connect table selection
            dgvProducts.CellClick += dgvProducts_CellClick;

            DisplayProducts();
        }

        // =====================================
        // VALIDATE PRODUCT ID
        // =====================================
        private bool TryGetProductId(out int id)
        {
            if (!int.TryParse(
                txtProductId.Text.Trim(), out id) ||
                id <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid positive numeric Product ID.",
                    "Invalid Product ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductId.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // ADD PRODUCT PAIR
        // =====================================
        private void btnAddPair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetProductId(out int id))
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

            if (manager.AddProduct(id, name))
            {
                MessageBox.Show(
                    "Product pair added successfully!" +
                    "\nKey (Product ID): " + id +
                    "\nValue (Product Name): " + name,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtProductId.Clear();
                txtProductName.Clear();

                DisplayProducts();
                SelectProductRow(id);

                lblStatus.Text =
                    "Product pair " + id +
                    " added successfully.";

                txtProductId.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Product ID " + id +
                    " already exists.",
                    "Duplicate Product ID",
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
            if (!TryGetProductId(out int id))
            {
                return;
            }

            KeyValuePair<int, string> product;

            if (manager.SearchProduct(id, out product))
            {
                txtProductName.Text = product.Value;

                // Highlight the matching product
                SelectProductRow(id);

                MessageBox.Show(
                    "Product Found!" +
                    "\nKey (Product ID): " + product.Key +
                    "\nValue (Product Name): " + product.Value,
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Product " + id + " found.";
            }
            else
            {
                dgvProducts.ClearSelection();
                txtProductName.Clear();

                ClearPairPreview();

                MessageBox.Show(
                    "Product ID " + id + " was not found.",
                    "Product Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Product not found.";
            }
        }

        // =====================================
        // REMOVE PRODUCT PAIR
        // =====================================
        private void btnRemovePair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetProductId(out int id))
            {
                return;
            }

            KeyValuePair<int, string> product;

            if (!manager.SearchProduct(id, out product))
            {
                MessageBox.Show(
                    "Product ID " + id + " does not exist.",
                    "Product Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this pair?" +
                "\n\nProduct ID: " + product.Key +
                "\nProduct Name: " + product.Value,
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (manager.RemoveProduct(id))
            {
                MessageBox.Show(
                    "Product pair removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtProductId.Clear();
                txtProductName.Clear();

                DisplayProducts();

                lblStatus.Text =
                    "Product pair " + id + " removed.";
            }
        }

        // =====================================
        // DISPLAY ALL PRODUCT PAIRS
        // =====================================
        private void DisplayProducts()
        {
            dgvProducts.Rows.Clear();

            List<KeyValuePair<int, string>> products =
                manager.GetProducts();

            foreach (KeyValuePair<int, string> product
                in products)
            {
                dgvProducts.Rows.Add(
                    product.Key,
                    product.Value);
            }

            lblProductCount.Text =
                "Total Product Pairs: " +
                manager.GetProductCount();

            dgvProducts.ClearSelection();

            ClearPairPreview();

            if (manager.GetProductCount() == 0)
            {
                lblStatus.Text =
                    "No product pairs stored.";
            }
            else
            {
                lblStatus.Text =
                    "Product pairs are ready.";
            }
        }

        // =====================================
        // DISPLAY PAIRS BUTTON
        // =====================================
        private void btnDisplayPairs_Click(
            object sender, EventArgs e)
        {
            DisplayProducts();

            if (manager.GetProductCount() > 0)
            {
                lblStatus.Text =
                    "Product pairs refreshed.";
            }
        }

        // =====================================
        // UPDATE SELECTED PAIR PREVIEW
        // =====================================
        private void UpdatePairPreview(
            int id, string name)
        {
            lblPreviewKey.Text = "Key: " + id;
            lblPreviewValue.Text = "Value: " + name;
        }

        // =====================================
        // CLEAR SELECTED PAIR PREVIEW
        // =====================================
        private void ClearPairPreview()
        {
            lblPreviewKey.Text = "Key: None";
            lblPreviewValue.Text = "Value: None";
        }

        // =====================================
        // SELECT AND HIGHLIGHT PRODUCT ROW
        // =====================================
        private void SelectProductRow(int id)
        {
            dgvProducts.ClearSelection();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                int rowId = Convert.ToInt32(
                    row.Cells["colProductId"].Value);

                if (rowId == id)
                {
                    dgvProducts.CurrentCell =
                        row.Cells["colProductId"];

                    row.Selected = true;

                    string name =
                        row.Cells["colProductName"]
                        .Value?.ToString() ?? "";

                    UpdatePairPreview(id, name);
                    return;
                }
            }

            ClearPairPreview();
        }

        // =====================================
        // SELECT PRODUCT FROM TABLE
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

            int id = Convert.ToInt32(
                row.Cells["colProductId"].Value);

            string name =
                row.Cells["colProductName"]
                .Value?.ToString() ?? "";

            txtProductId.Text = id.ToString();
            txtProductName.Text = name;

            UpdatePairPreview(id, name);

            lblStatus.Text =
                "Product pair " + id + " selected.";
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
