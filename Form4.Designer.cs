
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlActions;
        private Panel pnlCatalog;

        private Label lblBrand;
        private Label lblTitle;
        private Label lblActions;
        private Label lblInstructions;
        private Label lblProductCode;
        private Label lblProductName;
        private Label lblProductPrice;
        private Label lblCatalogTitle;
        private Label lblCatalogDescription;
        private Label lblProductCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtProductCode;
        private TextBox txtProductName;
        private TextBox txtProductPrice;

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colProductPrice;

        private Button btnAddProduct;
        private Button btnSearchProduct;
        private Button btnRemoveProduct;
        private Button btnDisplayProducts;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pnlActions = new Panel();
            pnlCatalog = new Panel();

            lblBrand = new Label();
            lblTitle = new Label();
            lblActions = new Label();
            lblInstructions = new Label();
            lblProductCode = new Label();
            lblProductName = new Label();
            lblProductPrice = new Label();
            lblCatalogTitle = new Label();
            lblCatalogDescription = new Label();
            lblProductCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();

            txtProductCode = new TextBox();
            txtProductName = new TextBox();
            txtProductPrice = new TextBox();

            dgvProducts = new DataGridView();
            colProductCode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductPrice = new DataGridViewTextBoxColumn();

            btnAddProduct = new Button();
            btnSearchProduct = new Button();
            btnRemoveProduct = new Button();
            btnDisplayProducts = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlCatalog.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvProducts).BeginInit();

            SuspendLayout();

            // =====================================
            // MAIN FORM
            // =====================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1080, 710);
            BackColor = Color.FromArgb(244, 247, 245);
            Font = new Font("Segoe UI", 10F);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            Name = "Form4";
            Text = "Product Catalog System";

            // =====================================
            // HEADER PANEL
            // =====================================

            pnlHeader.BackColor =
                Color.FromArgb(24, 91, 57);

            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1080, 125);
            pnlHeader.Name = "pnlHeader";

            // BRAND
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblBrand.ForeColor =
                Color.FromArgb(200, 235, 211);

            lblBrand.Location = new Point(35, 18);
            lblBrand.Name = "lblBrand";
            lblBrand.Text = "BENILDE ANTIPOLO";

            // MAIN TITLE
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font(
                "Segoe UI", 25F, FontStyle.Bold);

            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Product Catalog System";

            // BACK BUTTON
            btnBack.BackColor = Color.White;
            btnBack.ForeColor =
                Color.FromArgb(24, 91, 57);

            btnBack.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.Location = new Point(925, 55);
            btnBack.Size = new Size(120, 42);

            btnBack.Name = "btnBack";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;

            // =====================================
            // PRODUCT ACTIONS PANEL
            // =====================================

            pnlActions.BackColor = Color.White;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;

            pnlActions.Location = new Point(30, 154);
            pnlActions.Size = new Size(328, 490);
            pnlActions.Name = "pnlActions";

            // ACTIONS TITLE
            lblActions.AutoSize = true;
            lblActions.Font = new Font(
                "Segoe UI", 17F, FontStyle.Bold);

            lblActions.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblActions.Location = new Point(22, 17);
            lblActions.Name = "lblActions";
            lblActions.Text = "Product Actions";

            // INSTRUCTIONS
            lblInstructions.Font = new Font(
                "Segoe UI", 9F);

            lblInstructions.ForeColor = Color.DimGray;
            lblInstructions.Location = new Point(23, 60);
            lblInstructions.Size = new Size(280, 36);

            lblInstructions.Name = "lblInstructions";
            lblInstructions.Text =
                "Enter product details to register. " +
                "Use the code to search or remove.";

            // =====================================
            // PRODUCT CODE
            // =====================================

            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblProductCode.Location = new Point(23, 104);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Text = "Product Code:";

            txtProductCode.Location = new Point(23, 127);
            txtProductCode.Size = new Size(280, 30);
            txtProductCode.Font = new Font(
                "Segoe UI", 11F);

            txtProductCode.Name = "txtProductCode";
            txtProductCode.MaxLength = 20;
            txtProductCode.PlaceholderText =
                "Enter code (e.g., PRD-001)";

            // =====================================
            // PRODUCT NAME
            // =====================================

            lblProductName.AutoSize = true;
            lblProductName.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblProductName.Location = new Point(23, 164);
            lblProductName.Name = "lblProductName";
            lblProductName.Text = "Product Name:";

            txtProductName.Location = new Point(23, 189);
            txtProductName.Size = new Size(280, 30);
            txtProductName.Font = new Font(
                "Segoe UI", 11F);

            txtProductName.Name = "txtProductName";
            txtProductName.MaxLength = 100;
            txtProductName.PlaceholderText =
                "Enter product name...";

            // =====================================
            // PRODUCT PRICE
            // =====================================

            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblProductPrice.Location = new Point(23, 227);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Text = "Product Price (PHP):";

            txtProductPrice.Location = new Point(23, 251);
            txtProductPrice.Size = new Size(280, 30);
            txtProductPrice.Font = new Font(
                "Segoe UI", 11F);

            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.MaxLength = 12;
            txtProductPrice.PlaceholderText =
                "Enter price (e.g., 150.00)";

            // =====================================
            // ADD PRODUCT BUTTON
            // =====================================

            btnAddProduct.BackColor =
                Color.FromArgb(34, 119, 73);

            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.FlatAppearance.BorderSize = 0;

            btnAddProduct.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnAddProduct.Location = new Point(23, 298);
            btnAddProduct.Size = new Size(280, 38);

            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;

            // =====================================
            // SEARCH PRODUCT BUTTON
            // =====================================

            btnSearchProduct.BackColor =
                Color.FromArgb(34, 119, 73);

            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.FlatAppearance.BorderSize = 0;

            btnSearchProduct.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnSearchProduct.Location = new Point(23, 343);
            btnSearchProduct.Size = new Size(280, 38);

            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.UseVisualStyleBackColor = false;

            // =====================================
            // REMOVE PRODUCT BUTTON
            // =====================================

            btnRemoveProduct.BackColor =
                Color.FromArgb(181, 65, 65);

            btnRemoveProduct.ForeColor = Color.White;
            btnRemoveProduct.FlatStyle = FlatStyle.Flat;
            btnRemoveProduct.FlatAppearance.BorderSize = 0;

            btnRemoveProduct.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnRemoveProduct.Location = new Point(23, 388);
            btnRemoveProduct.Size = new Size(280, 38);

            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.UseVisualStyleBackColor = false;

            // =====================================
            // DISPLAY PRODUCTS BUTTON
            // =====================================

            btnDisplayProducts.BackColor =
                Color.FromArgb(24, 91, 57);

            btnDisplayProducts.ForeColor = Color.White;
            btnDisplayProducts.FlatStyle = FlatStyle.Flat;
            btnDisplayProducts.FlatAppearance.BorderSize = 0;

            btnDisplayProducts.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnDisplayProducts.Location = new Point(23, 433);
            btnDisplayProducts.Size = new Size(280, 38);

            btnDisplayProducts.Name = "btnDisplayProducts";
            btnDisplayProducts.Text = "Display Products";
            btnDisplayProducts.UseVisualStyleBackColor = false;

            // =====================================
            // PRODUCT CATALOG PANEL
            // =====================================

            pnlCatalog.BackColor = Color.White;
            pnlCatalog.BorderStyle = BorderStyle.FixedSingle;

            pnlCatalog.Location = new Point(380, 154);
            pnlCatalog.Size = new Size(670, 490);
            pnlCatalog.Name = "pnlCatalog";

            // CATALOG TITLE
            lblCatalogTitle.AutoSize = true;
            lblCatalogTitle.Font = new Font(
                "Segoe UI", 17F, FontStyle.Bold);

            lblCatalogTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblCatalogTitle.Location = new Point(22, 20);
            lblCatalogTitle.Name = "lblCatalogTitle";
            lblCatalogTitle.Text = "Product Records";

            // CATALOG DESCRIPTION
            lblCatalogDescription.AutoSize = true;
            lblCatalogDescription.Font = new Font(
                "Segoe UI", 9F);

            lblCatalogDescription.ForeColor =
                Color.DimGray;

            lblCatalogDescription.Location = new Point(25, 70);
            lblCatalogDescription.Name =
                "lblCatalogDescription";

            lblCatalogDescription.Text =
                "Products stored using a custom DictionaryBase collection.";

            // =====================================
            // PRODUCT DATAGRIDVIEW
            // =====================================

            dgvProducts.Location = new Point(24, 112);
            dgvProducts.Size = new Size(620, 300);
            dgvProducts.Name = "dgvProducts";

            dgvProducts.BackgroundColor =
                Color.FromArgb(250, 252, 250);

            dgvProducts.BorderStyle =
                BorderStyle.FixedSingle;

            dgvProducts.Font = new Font(
                "Segoe UI", 10F);

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;

            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.RowHeadersVisible = false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.RowTemplate.Height = 32;
            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 91, 57);

            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvProducts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(200, 235, 211);

            dgvProducts.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 248, 244);

            // =====================================
            // PRODUCT CODE COLUMN
            // =====================================

            colProductCode.Name = "colProductCode";
            colProductCode.HeaderText = "Product Code";
            colProductCode.ReadOnly = true;
            colProductCode.FillWeight = 30F;

            colProductCode.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // =====================================
            // PRODUCT NAME COLUMN
            // =====================================

            colProductName.Name = "colProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.ReadOnly = true;
            colProductName.FillWeight = 45F;

            colProductName.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // =====================================
            // PRODUCT PRICE COLUMN
            // =====================================

            colProductPrice.Name = "colProductPrice";
            colProductPrice.HeaderText = "Price (PHP)";
            colProductPrice.ReadOnly = true;
            colProductPrice.FillWeight = 25F;

            colProductPrice.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            colProductPrice.DefaultCellStyle.Format = "N2";

            colProductPrice.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // ADD COLUMNS
            dgvProducts.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colProductCode,
                    colProductName,
                    colProductPrice
                });

            // =====================================
            // TOTAL PRODUCT COUNT
            // =====================================

            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblProductCount.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblProductCount.Location = new Point(24, 425);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Text = "Total Products: 0";

            // =====================================
            // STATUS LABEL
            // =====================================

            lblStatus.Font = new Font(
                "Segoe UI", 9F);

            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(24, 459);
            lblStatus.Size = new Size(620, 23);

            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Product catalog is empty.";

            // =====================================
            // FOOTER
            // =====================================

            lblFooter.AutoSize = true;
            lblFooter.Font = new Font(
                "Segoe UI", 9F);

            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(35, 672);
            lblFooter.Name = "lblFooter";

            lblFooter.Text =
                "Product Catalog | DictionaryBase Implementation";

            // =====================================
            // ADD CONTROLS TO HEADER
            // =====================================

            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            // =====================================
            // ADD CONTROLS TO ACTION PANEL
            // =====================================

            pnlActions.Controls.Add(lblActions);
            pnlActions.Controls.Add(lblInstructions);

            pnlActions.Controls.Add(lblProductCode);
            pnlActions.Controls.Add(txtProductCode);

            pnlActions.Controls.Add(lblProductName);
            pnlActions.Controls.Add(txtProductName);

            pnlActions.Controls.Add(lblProductPrice);
            pnlActions.Controls.Add(txtProductPrice);

            pnlActions.Controls.Add(btnAddProduct);
            pnlActions.Controls.Add(btnSearchProduct);
            pnlActions.Controls.Add(btnRemoveProduct);
            pnlActions.Controls.Add(btnDisplayProducts);

            // =====================================
            // ADD CONTROLS TO CATALOG PANEL
            // =====================================

            pnlCatalog.Controls.Add(lblCatalogTitle);
            pnlCatalog.Controls.Add(lblCatalogDescription);
            pnlCatalog.Controls.Add(dgvProducts);
            pnlCatalog.Controls.Add(lblProductCount);
            pnlCatalog.Controls.Add(lblStatus);

            // =====================================
            // ADD PANELS TO MAIN FORM
            // =====================================

            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlCatalog);
            Controls.Add(lblFooter);

            ((System.ComponentModel.ISupportInitialize)
                dgvProducts).EndInit();

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();

            pnlCatalog.ResumeLayout(false);
            pnlCatalog.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
