
using System;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form3 : Form
    {
        // Keep registered books while the application runs
        private static readonly BookRegistry registry =
            new BookRegistry();

        public Form3()
        {
            InitializeComponent();
            this.Load += (sender, e) => ResponsiveForm.Fit(this);

            // Connect buttons to their functions
            btnAddBook.Click += btnAddBook_Click;
            btnSearchBook.Click += btnSearchBook_Click;
            btnRemoveBook.Click += btnRemoveBook_Click;
            btnDisplayBooks.Click += btnDisplayBooks_Click;
            btnBack.Click += btnBack_Click;

            // Allow selecting books from the table
            dgvBooks.CellClick += dgvBooks_CellClick;

            DisplayBooks();
        }

        // =====================================
        // VALIDATE BOOK CODE
        // =====================================
        private bool TryGetBookCode(out string code)
        {
            code = txtBookCode.Text.Trim().ToUpperInvariant();

            if (!BookRegistry.IsValidBookCode(code))
            {
                MessageBox.Show(
                    "Please enter a valid book code." +
                    "\nRequired format: BK-001",
                    "Invalid Book Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBookCode.Focus();
                return false;
            }

            txtBookCode.Text = code;
            return true;
        }

        // =====================================
        // ADD BOOK
        // =====================================
        private void btnAddBook_Click(
            object sender, EventArgs e)
        {
            if (!TryGetBookCode(out string code))
            {
                return;
            }

            string title = txtBookTitle.Text.Trim();

            if (title == "")
            {
                MessageBox.Show(
                    "Please enter a book title.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBookTitle.Focus();
                return;
            }

            if (registry.AddBook(code, title))
            {
                MessageBox.Show(
                    "Book registered successfully!" +
                    "\nBook Code: " + code +
                    "\nBook Title: " + title,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBookCode.Clear();
                txtBookTitle.Clear();

                DisplayBooks();

                lblStatus.Text =
                    "Book " + code + " registered successfully.";

                txtBookCode.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Book code " + code +
                    " is already registered.",
                    "Duplicate Book Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =====================================
        // SEARCH BOOK
        // =====================================
        private void btnSearchBook_Click(
            object sender, EventArgs e)
        {
            if (!TryGetBookCode(out string code))
            {
                return;
            }

            if (registry.SearchBook(code, out string title))
            {
                txtBookTitle.Text = title;

                // Highlight the matching row
                dgvBooks.ClearSelection();

                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    string rowCode =
                        row.Cells["colBookCode"].Value.ToString()!;

                    if (string.Equals(rowCode, code,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        dgvBooks.CurrentCell =
                            row.Cells["colBookCode"];

                        row.Selected = true;
                        break;
                    }
                }

                MessageBox.Show(
                    "Book Found!" +
                    "\nBook Code: " + code +
                    "\nBook Title: " + title,
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Book " + code + " found.";
            }
            else
            {
                dgvBooks.ClearSelection();
                txtBookTitle.Clear();

                MessageBox.Show(
                    "Book code " + code + " was not found.",
                    "Book Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Book not found.";
            }
        }

        // =====================================
        // REMOVE BOOK
        // =====================================
        private void btnRemoveBook_Click(
            object sender, EventArgs e)
        {
            if (!TryGetBookCode(out string code))
            {
                return;
            }

            if (!registry.SearchBook(code, out string title))
            {
                MessageBox.Show(
                    "Book code " + code + " does not exist.",
                    "Book Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this book?" +
                "\n\nBook Code: " + code +
                "\nBook Title: " + title,
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (registry.RemoveBook(code))
            {
                MessageBox.Show(
                    "Book removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBookCode.Clear();
                txtBookTitle.Clear();

                DisplayBooks();

                lblStatus.Text =
                    "Book " + code + " removed successfully.";
            }
        }

        // =====================================
        // DISPLAY ALL BOOKS
        // =====================================
        private void DisplayBooks()
        {
            dgvBooks.Rows.Clear();

            System.Collections.DictionaryEntry[] books =
                registry.GetBooks();

            foreach (System.Collections.DictionaryEntry book
                in books)
            {
                dgvBooks.Rows.Add(
                    book.Key,
                    book.Value);
            }

            // Update the total book count
            lblBookCount.Text =
                "Total Registered Books: " +
                registry.GetBookCount();

            dgvBooks.ClearSelection();

            if (registry.GetBookCount() == 0)
            {
                lblStatus.Text = "Book registry is empty.";
            }
            else
            {
                lblStatus.Text = "Book registry is ready.";
            }
        }

        // =====================================
        // DISPLAY BOOKS BUTTON
        // =====================================
        private void btnDisplayBooks_Click(
            object sender, EventArgs e)
        {
            DisplayBooks();

            if (registry.GetBookCount() > 0)
            {
                lblStatus.Text =
                    "Book registry refreshed.";
            }
        }

        // =====================================
        // SELECT BOOK FROM DATAGRIDVIEW
        // =====================================
        private void dgvBooks_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvBooks.Rows[e.RowIndex];

            txtBookCode.Text =
                row.Cells["colBookCode"].Value.ToString();

            txtBookTitle.Text =
                row.Cells["colBookTitle"].Value.ToString();

            lblStatus.Text =
                "Book " + txtBookCode.Text + " selected.";
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
