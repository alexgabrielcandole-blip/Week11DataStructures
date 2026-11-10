
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlActions;
        private Panel pnlRegistry;

        private Label lblBrand;
        private Label lblTitle;
        private Label lblActions;
        private Label lblInstructions;
        private Label lblBookCode;
        private Label lblBookTitle;
        private Label lblRegistryTitle;
        private Label lblRegistryDescription;
        private Label lblBookCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtBookCode;
        private TextBox txtBookTitle;

        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn colBookCode;
        private DataGridViewTextBoxColumn colBookTitle;

        private Button btnAddBook;
        private Button btnSearchBook;
        private Button btnRemoveBook;
        private Button btnDisplayBooks;
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
            pnlRegistry = new Panel();

            lblBrand = new Label();
            lblTitle = new Label();
            lblActions = new Label();
            lblInstructions = new Label();
            lblBookCode = new Label();
            lblBookTitle = new Label();
            lblRegistryTitle = new Label();
            lblRegistryDescription = new Label();
            lblBookCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();

            txtBookCode = new TextBox();
            txtBookTitle = new TextBox();

            dgvBooks = new DataGridView();
            colBookCode = new DataGridViewTextBoxColumn();
            colBookTitle = new DataGridViewTextBoxColumn();

            btnAddBook = new Button();
            btnSearchBook = new Button();
            btnRemoveBook = new Button();
            btnDisplayBooks = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRegistry.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvBooks).BeginInit();

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

            Name = "Form3";
            Text = "Library Book Registry";

            // =====================================
            // HEADER PANEL
            // =====================================

            pnlHeader.BackColor =
                Color.FromArgb(24, 91, 57);

            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1080, 125);
            pnlHeader.Name = "pnlHeader";

            // BRAND LABEL
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

            lblTitle.Text = "Library Book Registry";

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
            // BOOK ACTIONS PANEL
            // =====================================

            pnlActions.BackColor = Color.White;

            pnlActions.BorderStyle =
                BorderStyle.FixedSingle;

            pnlActions.Location = new Point(30, 154);
            pnlActions.Size = new Size(328, 490);

            pnlActions.Name = "pnlActions";

            // ACTIONS TITLE
            lblActions.AutoSize = true;

            lblActions.Font = new Font(
                "Segoe UI", 17F, FontStyle.Bold);

            lblActions.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblActions.Location = new Point(22, 20);
            lblActions.Name = "lblActions";

            lblActions.Text = "Book Actions";

            // INSTRUCTIONS
            lblInstructions.Font = new Font(
                "Segoe UI", 9F);

            lblInstructions.ForeColor = Color.DimGray;

            lblInstructions.Location = new Point(23, 66);
            lblInstructions.Size = new Size(280, 44);

            lblInstructions.Name = "lblInstructions";

            lblInstructions.Text =
                "Enter a book code and title to register. " +
                "Use the code to search or remove books.";

            // =====================================
            // BOOK CODE LABEL
            // =====================================

            lblBookCode.AutoSize = true;

            lblBookCode.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblBookCode.Location = new Point(23, 115);
            lblBookCode.Name = "lblBookCode";

            lblBookCode.Text = "Book Code:";

            // BOOK CODE TEXTBOX
            txtBookCode.Location = new Point(23, 143);
            txtBookCode.Size = new Size(280, 30);

            txtBookCode.Font = new Font(
                "Segoe UI", 11F);

            txtBookCode.Name = "txtBookCode";
            txtBookCode.MaxLength = 20;

            txtBookCode.PlaceholderText =
                "Enter book code (e.g., BK-001)";

            // =====================================
            // BOOK TITLE LABEL
            // =====================================

            lblBookTitle.AutoSize = true;

            lblBookTitle.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblBookTitle.Location = new Point(23, 191);
            lblBookTitle.Name = "lblBookTitle";

            lblBookTitle.Text = "Book Title:";

            // BOOK TITLE TEXTBOX
            txtBookTitle.Location = new Point(23, 219);
            txtBookTitle.Size = new Size(280, 30);

            txtBookTitle.Font = new Font(
                "Segoe UI", 11F);

            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.MaxLength = 150;

            txtBookTitle.PlaceholderText =
                "Enter book title...";

            // =====================================
            // ADD BOOK BUTTON
            // =====================================

            btnAddBook.BackColor =
                Color.FromArgb(34, 119, 73);

            btnAddBook.ForeColor = Color.White;
            btnAddBook.FlatStyle = FlatStyle.Flat;

            btnAddBook.FlatAppearance.BorderSize = 0;

            btnAddBook.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnAddBook.Location = new Point(23, 271);
            btnAddBook.Size = new Size(280, 43);

            btnAddBook.Name = "btnAddBook";
            btnAddBook.Text = "Add Book";

            btnAddBook.UseVisualStyleBackColor = false;

            // =====================================
            // SEARCH BOOK BUTTON
            // =====================================

            btnSearchBook.BackColor =
                Color.FromArgb(34, 119, 73);

            btnSearchBook.ForeColor = Color.White;
            btnSearchBook.FlatStyle = FlatStyle.Flat;

            btnSearchBook.FlatAppearance.BorderSize = 0;

            btnSearchBook.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnSearchBook.Location = new Point(23, 323);
            btnSearchBook.Size = new Size(280, 43);

            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Text = "Search Book";

            btnSearchBook.UseVisualStyleBackColor = false;

            // =====================================
            // REMOVE BOOK BUTTON
            // =====================================

            btnRemoveBook.BackColor =
                Color.FromArgb(181, 65, 65);

            btnRemoveBook.ForeColor = Color.White;
            btnRemoveBook.FlatStyle = FlatStyle.Flat;

            btnRemoveBook.FlatAppearance.BorderSize = 0;

            btnRemoveBook.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnRemoveBook.Location = new Point(23, 375);
            btnRemoveBook.Size = new Size(280, 43);

            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Text = "Remove Book";

            btnRemoveBook.UseVisualStyleBackColor = false;

            // =====================================
            // DISPLAY BOOKS BUTTON
            // =====================================

            btnDisplayBooks.BackColor =
                Color.FromArgb(24, 91, 57);

            btnDisplayBooks.ForeColor = Color.White;
            btnDisplayBooks.FlatStyle = FlatStyle.Flat;

            btnDisplayBooks.FlatAppearance.BorderSize = 0;

            btnDisplayBooks.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnDisplayBooks.Location = new Point(23, 427);
            btnDisplayBooks.Size = new Size(280, 43);

            btnDisplayBooks.Name = "btnDisplayBooks";
            btnDisplayBooks.Text = "Display Books";

            btnDisplayBooks.UseVisualStyleBackColor = false;

            // =====================================
            // BOOK REGISTRY PANEL
            // =====================================

            pnlRegistry.BackColor = Color.White;

            pnlRegistry.BorderStyle =
                BorderStyle.FixedSingle;

            pnlRegistry.Location = new Point(380, 154);
            pnlRegistry.Size = new Size(670, 490);

            pnlRegistry.Name = "pnlRegistry";

            // REGISTRY TITLE
            lblRegistryTitle.AutoSize = true;

            lblRegistryTitle.Font = new Font(
                "Segoe UI", 17F, FontStyle.Bold);

            lblRegistryTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblRegistryTitle.Location = new Point(22, 20);
            lblRegistryTitle.Name = "lblRegistryTitle";

            lblRegistryTitle.Text = "Registered Books";

            // REGISTRY DESCRIPTION
            lblRegistryDescription.AutoSize = true;

            lblRegistryDescription.Font = new Font(
                "Segoe UI", 9F);

            lblRegistryDescription.ForeColor =
                Color.DimGray;

            lblRegistryDescription.Location =
                new Point(25, 70);

            lblRegistryDescription.Name =
                "lblRegistryDescription";

            lblRegistryDescription.Text =
                "Books stored using a custom DictionaryBase collection.";

            // =====================================
            // BOOK DATAGRIDVIEW
            // =====================================

            dgvBooks.Location = new Point(24, 112);
            dgvBooks.Size = new Size(620, 300);

            dgvBooks.Name = "dgvBooks";

            dgvBooks.BackgroundColor =
                Color.FromArgb(250, 252, 250);

            dgvBooks.BorderStyle =
                BorderStyle.FixedSingle;

            dgvBooks.Font = new Font(
                "Segoe UI", 10F);

            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeRows = false;

            dgvBooks.ReadOnly = true;
            dgvBooks.MultiSelect = false;

            dgvBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBooks.RowHeadersVisible = false;

            dgvBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooks.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvBooks.ColumnHeadersHeight = 40;
            dgvBooks.RowTemplate.Height = 32;

            dgvBooks.EnableHeadersVisualStyles = false;

            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 91, 57);

            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvBooks.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvBooks.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(200, 235, 211);

            dgvBooks.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 248, 244);

            // =====================================
            // BOOK CODE COLUMN
            // =====================================

            colBookCode.Name = "colBookCode";
            colBookCode.HeaderText = "Book Code";

            colBookCode.ReadOnly = true;
            colBookCode.FillWeight = 35F;

            colBookCode.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // =====================================
            // BOOK TITLE COLUMN
            // =====================================

            colBookTitle.Name = "colBookTitle";
            colBookTitle.HeaderText = "Book Title";

            colBookTitle.ReadOnly = true;
            colBookTitle.FillWeight = 65F;

            colBookTitle.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            dgvBooks.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colBookCode,
                    colBookTitle
                });

            // =====================================
            // BOOK COUNT
            // =====================================

            lblBookCount.AutoSize = true;

            lblBookCount.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblBookCount.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblBookCount.Location = new Point(24, 425);
            lblBookCount.Name = "lblBookCount";

            lblBookCount.Text = "Total Registered Books: 0";

            // =====================================
            // STATUS LABEL
            // =====================================

            lblStatus.Font = new Font(
                "Segoe UI", 9F);

            lblStatus.ForeColor = Color.Gray;

            lblStatus.Location = new Point(24, 459);
            lblStatus.Size = new Size(620, 23);

            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Book registry is empty.";

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
                "Library Book Registry | DictionaryBase Implementation";

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

            pnlActions.Controls.Add(lblBookCode);
            pnlActions.Controls.Add(txtBookCode);

            pnlActions.Controls.Add(lblBookTitle);
            pnlActions.Controls.Add(txtBookTitle);

            pnlActions.Controls.Add(btnAddBook);
            pnlActions.Controls.Add(btnSearchBook);
            pnlActions.Controls.Add(btnRemoveBook);
            pnlActions.Controls.Add(btnDisplayBooks);

            // =====================================
            // ADD CONTROLS TO REGISTRY PANEL
            // =====================================

            pnlRegistry.Controls.Add(lblRegistryTitle);
            pnlRegistry.Controls.Add(lblRegistryDescription);

            pnlRegistry.Controls.Add(dgvBooks);

            pnlRegistry.Controls.Add(lblBookCount);
            pnlRegistry.Controls.Add(lblStatus);

            // =====================================
            // ADD PANELS TO FORM
            // =====================================

            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRegistry);
            Controls.Add(lblFooter);

            ((System.ComponentModel.ISupportInitialize)
                dgvBooks).EndInit();

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();

            pnlRegistry.ResumeLayout(false);
            pnlRegistry.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
