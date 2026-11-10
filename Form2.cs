
using System;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form2 : Form
    {
        // Keep employee records while the application runs
        private static readonly EmployeeDirectory directory =
            new EmployeeDirectory();

        public Form2()
        {
            InitializeComponent();

            // Connect buttons to their functions
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnSearchEmployee.Click += btnSearchEmployee_Click;
            btnRemoveEmployee.Click += btnRemoveEmployee_Click;
            btnDisplayEmployees.Click += btnDisplayEmployees_Click;
            btnBack.Click += btnBack_Click;

            // Allow clicking a record to select its details
            dgvEmployees.CellClick += dgvEmployees_CellClick;

            DisplayEmployees();
        }

        // =====================================
        // VALIDATE EMPLOYEE ID
        // =====================================
        private bool TryGetEmployeeId(out int id)
        {
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out id)
                || id <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid positive numeric Employee ID.",
                    "Invalid Employee ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmployeeId.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // ADD EMPLOYEE
        // =====================================
        private void btnAddEmployee_Click(
            object sender, EventArgs e)
        {
            if (!TryGetEmployeeId(out int id))
            {
                return;
            }

            string name = txtEmployeeName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show(
                    "Please enter an employee name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmployeeName.Focus();
                return;
            }

            if (directory.AddEmployee(id, name))
            {
                MessageBox.Show(
                    "Employee " + name + " added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtEmployeeId.Clear();
                txtEmployeeName.Clear();

                DisplayEmployees();

                lblStatus.Text =
                    "Employee " + id + " added successfully.";

                txtEmployeeId.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Employee ID " + id + " already exists.",
                    "Duplicate Employee ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =====================================
        // SEARCH EMPLOYEE
        // =====================================
        private void btnSearchEmployee_Click(
            object sender, EventArgs e)
        {
            if (!TryGetEmployeeId(out int id))
            {
                return;
            }

            if (directory.SearchEmployee(id, out string name))
            {
                txtEmployeeName.Text = name;

                // Highlight the matching row
                dgvEmployees.ClearSelection();

                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    if (Convert.ToInt32(
                        row.Cells["colEmployeeId"].Value) == id)
                    {
                        row.Selected = true;

                        dgvEmployees.CurrentCell =
                            row.Cells["colEmployeeId"];

                        break;
                    }
                }

                MessageBox.Show(
                    "Employee Found!" +
                    "\nEmployee ID: " + id +
                    "\nEmployee Name: " + name,
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Employee " + id + " found.";
            }
            else
            {
                dgvEmployees.ClearSelection();
                txtEmployeeName.Clear();

                MessageBox.Show(
                    "Employee ID " + id + " was not found.",
                    "Employee Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Employee not found.";
            }
        }

        // =====================================
        // REMOVE EMPLOYEE
        // =====================================
        private void btnRemoveEmployee_Click(
            object sender, EventArgs e)
        {
            if (!TryGetEmployeeId(out int id))
            {
                return;
            }

            if (!directory.SearchEmployee(id, out string name))
            {
                MessageBox.Show(
                    "Employee ID " + id + " does not exist.",
                    "Employee Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove " +
                name + " (ID: " + id + ")?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (directory.RemoveEmployee(id))
            {
                MessageBox.Show(
                    "Employee removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtEmployeeId.Clear();
                txtEmployeeName.Clear();

                DisplayEmployees();

                lblStatus.Text =
                    "Employee " + id + " removed.";
            }
        }

        // =====================================
        // DISPLAY ALL EMPLOYEES
        // =====================================
        private void DisplayEmployees()
        {
            dgvEmployees.Rows.Clear();

            // Get employee records from DictionaryBase
            System.Collections.DictionaryEntry[] employees =
                directory.GetEmployees();

            foreach (System.Collections.DictionaryEntry entry
                in employees)
            {
                dgvEmployees.Rows.Add(
                    entry.Key,
                    entry.Value);
            }

            // Update employee count
            lblEmployeeCount.Text =
                "Total Employees: " +
                directory.GetEmployeeCount();

            dgvEmployees.ClearSelection();

            if (directory.GetEmployeeCount() == 0)
            {
                lblStatus.Text =
                    "Employee directory is empty.";
            }
            else
            {
                lblStatus.Text =
                    "Employee directory is ready.";
            }
        }

        // =====================================
        // DISPLAY EMPLOYEES BUTTON
        // =====================================
        private void btnDisplayEmployees_Click(
            object sender, EventArgs e)
        {
            DisplayEmployees();

            if (directory.GetEmployeeCount() > 0)
            {
                lblStatus.Text =
                    "Employee records refreshed.";
            }
        }

        // =====================================
        // SELECT EMPLOYEE FROM TABLE
        // =====================================
        private void dgvEmployees_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvEmployees.Rows[e.RowIndex];

            txtEmployeeId.Text =
                row.Cells["colEmployeeId"].Value.ToString();

            txtEmployeeName.Text =
                row.Cells["colEmployeeName"].Value.ToString();
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
