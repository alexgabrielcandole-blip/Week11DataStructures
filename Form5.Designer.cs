
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlActions;
        private Panel pnlRecords;
        private Panel pnlSelectedPair;

        private Label lblBrand;
        private Label lblTitle;
        private Label lblActions;
        private Label lblInstructions;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblRecordsTitle;
        private Label lblRecordsDescription;
        private Label lblPreviewTitle;
        private Label lblPreviewKey;
        private Label lblPreviewValue;
        private Label lblTableTitle;
        private Label lblProductCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtProductId;
        private TextBox txtProductName;

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;

        private Button btnAddPair;
        private Button btnSearchProduct;
        private Button btnRemovePair;
        private Button btnDisplayPairs;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblBrand = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            pnlActions = new Panel();
            lblActions = new Label();
            lblInstructions = new Label();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnAddPair = new Button();
            btnSearchProduct = new Button();
            btnRemovePair = new Button();
            btnDisplayPairs = new Button();
            pnlRecords = new Panel();
            lblRecordsTitle = new Label();
            lblRecordsDescription = new Label();
            pnlSelectedPair = new Panel();
            lblPreviewTitle = new Label();
            lblPreviewKey = new Label();
            lblPreviewValue = new Label();
            lblTableTitle = new Label();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            lblProductCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRecords.SuspendLayout();
            pnlSelectedPair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 91, 57);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1110, 125);
            pnlHeader.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(200, 235, 211);
            lblBrand.Location = new Point(35, 18);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(218, 30);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "BENILDE ANTIPOLO";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(705, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Product ID and Product Name";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(24, 91, 57);
            btnBack.Location = new Point(977, 67);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 42);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;
            pnlActions.Controls.Add(lblActions);
            pnlActions.Controls.Add(lblInstructions);
            pnlActions.Controls.Add(lblProductId);
            pnlActions.Controls.Add(txtProductId);
            pnlActions.Controls.Add(lblProductName);
            pnlActions.Controls.Add(txtProductName);
            pnlActions.Controls.Add(btnAddPair);
            pnlActions.Controls.Add(btnSearchProduct);
            pnlActions.Controls.Add(btnRemovePair);
            pnlActions.Controls.Add(btnDisplayPairs);
            pnlActions.Location = new Point(30, 154);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(367, 490);
            pnlActions.TabIndex = 1;
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblActions.ForeColor = Color.FromArgb(24, 91, 57);
            lblActions.Location = new Point(22, 20);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(347, 46);
            lblActions.TabIndex = 0;
            lblActions.Text = "Product Pair Actions";
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Segoe UI", 9F);
            lblInstructions.ForeColor = Color.DimGray;
            lblInstructions.Location = new Point(23, 65);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(280, 44);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Enter a Product ID and Name to create a pair. Use the ID to search or remove.";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductId.Location = new Point(23, 115);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(173, 28);
            lblProductId.TabIndex = 2;
            lblProductId.Text = "Product ID (Key):";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 11F);
            txtProductId.Location = new Point(23, 143);
            txtProductId.MaxLength = 10;
            txtProductId.Name = "txtProductId";
            txtProductId.PlaceholderText = "Enter Product ID (e.g., 101)";
            txtProductId.Size = new Size(280, 37);
            txtProductId.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductName.Location = new Point(23, 191);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(224, 28);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Product Name (Value):";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 11F);
            txtProductName.Location = new Point(23, 219);
            txtProductName.MaxLength = 100;
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Enter product name...";
            txtProductName.Size = new Size(280, 37);
            txtProductName.TabIndex = 5;
            // 
            // btnAddPair
            // 
            btnAddPair.BackColor = Color.FromArgb(34, 119, 73);
            btnAddPair.FlatAppearance.BorderSize = 0;
            btnAddPair.FlatStyle = FlatStyle.Flat;
            btnAddPair.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddPair.ForeColor = Color.White;
            btnAddPair.Location = new Point(23, 271);
            btnAddPair.Name = "btnAddPair";
            btnAddPair.Size = new Size(280, 43);
            btnAddPair.TabIndex = 6;
            btnAddPair.Text = "Add Product Pair";
            btnAddPair.UseVisualStyleBackColor = false;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.FromArgb(34, 119, 73);
            btnSearchProduct.FlatAppearance.BorderSize = 0;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.Location = new Point(23, 323);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(280, 43);
            btnSearchProduct.TabIndex = 7;
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // btnRemovePair
            // 
            btnRemovePair.BackColor = Color.FromArgb(181, 65, 65);
            btnRemovePair.FlatAppearance.BorderSize = 0;
            btnRemovePair.FlatStyle = FlatStyle.Flat;
            btnRemovePair.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemovePair.ForeColor = Color.White;
            btnRemovePair.Location = new Point(23, 375);
            btnRemovePair.Name = "btnRemovePair";
            btnRemovePair.Size = new Size(280, 43);
            btnRemovePair.TabIndex = 8;
            btnRemovePair.Text = "Remove Product Pair";
            btnRemovePair.UseVisualStyleBackColor = false;
            // 
            // btnDisplayPairs
            // 
            btnDisplayPairs.BackColor = Color.FromArgb(24, 91, 57);
            btnDisplayPairs.FlatAppearance.BorderSize = 0;
            btnDisplayPairs.FlatStyle = FlatStyle.Flat;
            btnDisplayPairs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDisplayPairs.ForeColor = Color.White;
            btnDisplayPairs.Location = new Point(23, 427);
            btnDisplayPairs.Name = "btnDisplayPairs";
            btnDisplayPairs.Size = new Size(280, 43);
            btnDisplayPairs.TabIndex = 9;
            btnDisplayPairs.Text = "Display Product Pairs";
            btnDisplayPairs.UseVisualStyleBackColor = false;
            // 
            // pnlRecords
            // 
            pnlRecords.BackColor = Color.White;
            pnlRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlRecords.Controls.Add(lblRecordsTitle);
            pnlRecords.Controls.Add(lblRecordsDescription);
            pnlRecords.Controls.Add(pnlSelectedPair);
            pnlRecords.Controls.Add(lblTableTitle);
            pnlRecords.Controls.Add(dgvProducts);
            pnlRecords.Controls.Add(lblProductCount);
            pnlRecords.Controls.Add(lblStatus);
            pnlRecords.Location = new Point(416, 154);
            pnlRecords.Name = "pnlRecords";
            pnlRecords.Size = new Size(670, 490);
            pnlRecords.TabIndex = 2;
            // 
            // lblRecordsTitle
            // 
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.FromArgb(24, 91, 57);
            lblRecordsTitle.Location = new Point(22, 15);
            lblRecordsTitle.Name = "lblRecordsTitle";
            lblRecordsTitle.Size = new Size(450, 46);
            lblRecordsTitle.TabIndex = 0;
            lblRecordsTitle.Text = "Product Key-Value Records";
            // 
            // lblRecordsDescription
            // 
            lblRecordsDescription.AutoSize = true;
            lblRecordsDescription.Font = new Font("Segoe UI", 9F);
            lblRecordsDescription.ForeColor = Color.DimGray;
            lblRecordsDescription.Location = new Point(25, 57);
            lblRecordsDescription.Name = "lblRecordsDescription";
            lblRecordsDescription.Size = new Size(476, 25);
            lblRecordsDescription.TabIndex = 1;
            lblRecordsDescription.Text = "Each product is represented by a KeyValuePair<int, string>.";
            // 
            // pnlSelectedPair
            // 
            pnlSelectedPair.BackColor = Color.FromArgb(236, 246, 239);
            pnlSelectedPair.BorderStyle = BorderStyle.FixedSingle;
            pnlSelectedPair.Controls.Add(lblPreviewTitle);
            pnlSelectedPair.Controls.Add(lblPreviewKey);
            pnlSelectedPair.Controls.Add(lblPreviewValue);
            pnlSelectedPair.Location = new Point(24, 90);
            pnlSelectedPair.Name = "pnlSelectedPair";
            pnlSelectedPair.Size = new Size(620, 100);
            pnlSelectedPair.TabIndex = 2;
            // 
            // lblPreviewTitle
            // 
            lblPreviewTitle.AutoSize = true;
            lblPreviewTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPreviewTitle.ForeColor = Color.FromArgb(24, 91, 57);
            lblPreviewTitle.Location = new Point(15, 10);
            lblPreviewTitle.Name = "lblPreviewTitle";
            lblPreviewTitle.Size = new Size(256, 30);
            lblPreviewTitle.TabIndex = 0;
            lblPreviewTitle.Text = "Selected Key-Value Pair";
            // 
            // lblPreviewKey
            // 
            lblPreviewKey.AutoSize = true;
            lblPreviewKey.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPreviewKey.ForeColor = Color.FromArgb(24, 91, 57);
            lblPreviewKey.Location = new Point(17, 44);
            lblPreviewKey.Name = "lblPreviewKey";
            lblPreviewKey.Size = new Size(118, 30);
            lblPreviewKey.TabIndex = 1;
            lblPreviewKey.Text = "Key: None";
            // 
            // lblPreviewValue
            // 
            lblPreviewValue.AutoEllipsis = true;
            lblPreviewValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPreviewValue.ForeColor = Color.FromArgb(24, 91, 57);
            lblPreviewValue.Location = new Point(230, 44);
            lblPreviewValue.Name = "lblPreviewValue";
            lblPreviewValue.Size = new Size(370, 28);
            lblPreviewValue.TabIndex = 2;
            lblPreviewValue.Text = "Value: None";
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(24, 91, 57);
            lblTableTitle.Location = new Point(24, 201);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(211, 28);
            lblTableTitle.TabIndex = 3;
            lblTableTitle.Text = "Stored Product Pairs:";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 248, 244);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(250, 252, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 91, 57);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 235, 211);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Font = new Font("Segoe UI", 10F);
            dgvProducts.Location = new Point(24, 228);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 32;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(620, 182);
            dgvProducts.TabIndex = 4;
            // 
            // colProductId
            // 
            colProductId.FillWeight = 38F;
            colProductId.HeaderText = "Product ID (Key)";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colProductName
            // 
            colProductName.FillWeight = 62F;
            colProductName.HeaderText = "Product Name (Value)";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProductCount.ForeColor = Color.FromArgb(24, 91, 57);
            lblProductCount.Location = new Point(24, 423);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(234, 30);
            lblProductCount.TabIndex = 5;
            lblProductCount.Text = "Total Product Pairs: 0";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(24, 454);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(620, 24);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "No product pairs stored.";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(35, 672);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(394, 25);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "Product ID and Name | KeyValuePair<int, string>";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(1109, 710);
            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRecords);
            Controls.Add(lblFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product ID and Product Name";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            pnlRecords.ResumeLayout(false);
            pnlRecords.PerformLayout();
            pnlSelectedPair.ResumeLayout(false);
            pnlSelectedPair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
