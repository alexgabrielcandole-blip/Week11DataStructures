
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form6 : Form
    {
        // Keep student records while the application runs
        private static readonly StudentGradeManager manager =
            new StudentGradeManager();

        public Form6()
        {
            InitializeComponent();

            // Automatically fit Form6 to the screen
            this.Load += (sender, e) =>
                ResponsiveForm.Fit(this);

            // Connect buttons
            btnAddPair.Click += btnAddPair_Click;
            btnSearchStudent.Click += btnSearchStudent_Click;
            btnRemovePair.Click += btnRemovePair_Click;
            btnDisplayPairs.Click += btnDisplayPairs_Click;
            btnBack.Click += btnBack_Click;

            // Connect DataGridView selection
            dgvStudents.CellClick += dgvStudents_CellClick;

            DisplayStudents();
        }

        // =====================================
        // VALIDATE STUDENT ID
        // =====================================
        private bool TryGetStudentId(out int id)
        {
            if (!int.TryParse(
                txtStudentId.Text.Trim(), out id)
                || id <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid positive numeric Student ID.",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentId.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // VALIDATE STUDENT GRADE
        // =====================================
        private bool TryGetStudentGrade(out double grade)
        {
            grade = 0;

            string input = txtStudentGrade.Text.Trim();

            if (!decimal.TryParse(
                input,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal parsedGrade))
            {
                MessageBox.Show(
                    "Please enter a valid numeric grade.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentGrade.Focus();
                return false;
            }

            if (parsedGrade < 0 || parsedGrade > 100)
            {
                MessageBox.Show(
                    "Student grade must be between 0 and 100.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentGrade.Focus();
                return false;
            }

            if (decimal.Round(parsedGrade, 2) != parsedGrade)
            {
                MessageBox.Show(
                    "Grade must have at most two decimal places.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentGrade.Focus();
                return false;
            }

            grade = (double)parsedGrade;
            return true;
        }

        // =====================================
        // ADD STUDENT PAIR
        // =====================================
        private void btnAddPair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetStudentId(out int id))
            {
                return;
            }

            if (!TryGetStudentGrade(out double grade))
            {
                return;
            }

            if (manager.AddStudent(id, grade))
            {
                MessageBox.Show(
                    "Student pair added successfully!" +
                    "\nStudent ID: " + id +
                    "\nStudent Grade: " + grade.ToString("F2"),
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtStudentId.Clear();
                txtStudentGrade.Clear();

                DisplayStudents();
                SelectStudentRow(id);

                lblStatus.Text =
                    "Student " + id + " added successfully.";

                txtStudentId.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Student ID " + id + " already exists.",
                    "Duplicate Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =====================================
        // SEARCH STUDENT
        // =====================================
        private void btnSearchStudent_Click(
            object sender, EventArgs e)
        {
            if (!TryGetStudentId(out int id))
            {
                return;
            }

            KeyValuePair<int, double> student;

            if (manager.SearchStudent(id, out student))
            {
                txtStudentGrade.Text =
                    student.Value.ToString("F2");

                // Highlight matching row
                SelectStudentRow(id);

                MessageBox.Show(
                    "Student Found!" +
                    "\nStudent ID: " + student.Key +
                    "\nStudent Grade: " +
                    student.Value.ToString("F2"),
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Student " + id + " found.";
            }
            else
            {
                dgvStudents.ClearSelection();
                txtStudentGrade.Clear();

                ClearPairPreview();

                MessageBox.Show(
                    "Student ID " + id + " was not found.",
                    "Student Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Student not found.";
            }
        }

        // =====================================
        // REMOVE STUDENT PAIR
        // =====================================
        private void btnRemovePair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetStudentId(out int id))
            {
                return;
            }

            KeyValuePair<int, double> student;

            if (!manager.SearchStudent(id, out student))
            {
                MessageBox.Show(
                    "Student ID " + id + " does not exist.",
                    "Student Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this student?" +
                "\n\nStudent ID: " + student.Key +
                "\nGrade: " + student.Value.ToString("F2"),
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (manager.RemoveStudent(id))
            {
                MessageBox.Show(
                    "Student pair removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtStudentId.Clear();
                txtStudentGrade.Clear();

                DisplayStudents();

                lblStatus.Text =
                    "Student " + id + " removed successfully.";
            }
        }

        // =====================================
        // DISPLAY ALL STUDENT PAIRS
        // =====================================
        private void DisplayStudents()
        {
            dgvStudents.Rows.Clear();

            List<KeyValuePair<int, double>> students =
                manager.GetStudents();

            foreach (KeyValuePair<int, double> student
                in students)
            {
                dgvStudents.Rows.Add(
                    student.Key,
                    student.Value);
            }

            lblStudentCount.Text =
                "Total Student Pairs: " +
                manager.GetStudentCount();

            dgvStudents.ClearSelection();

            ClearPairPreview();

            if (manager.GetStudentCount() == 0)
            {
                lblStatus.Text =
                    "No student pairs stored.";
            }
            else
            {
                lblStatus.Text =
                    "Student pairs are ready.";
            }
        }

        // =====================================
        // DISPLAY STUDENT PAIRS BUTTON
        // =====================================
        private void btnDisplayPairs_Click(
            object sender, EventArgs e)
        {
            DisplayStudents();

            if (manager.GetStudentCount() > 0)
            {
                lblStatus.Text =
                    "Student records refreshed.";
            }
        }

        // =====================================
        // UPDATE KEY-VALUE PREVIEW
        // =====================================
        private void UpdatePairPreview(
            int id, double grade)
        {
            lblPreviewKey.Text =
                "Key: " + id;

            lblPreviewValue.Text =
                "Value: " + grade.ToString("F2");
        }

        // =====================================
        // CLEAR KEY-VALUE PREVIEW
        // =====================================
        private void ClearPairPreview()
        {
            lblPreviewKey.Text = "Key: None";
            lblPreviewValue.Text = "Value: None";
        }

        // =====================================
        // SELECT STUDENT ROW
        // =====================================
        private void SelectStudentRow(int id)
        {
            dgvStudents.ClearSelection();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                int rowId = Convert.ToInt32(
                    row.Cells["colStudentId"].Value);

                if (rowId == id)
                {
                    dgvStudents.CurrentCell =
                        row.Cells["colStudentId"];

                    row.Selected = true;

                    double grade = Convert.ToDouble(
                        row.Cells["colStudentGrade"].Value);

                    UpdatePairPreview(id, grade);

                    return;
                }
            }

            ClearPairPreview();
        }

        // =====================================
        // SELECT STUDENT FROM DATAGRIDVIEW
        // =====================================
        private void dgvStudents_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvStudents.Rows[e.RowIndex];

            int id = Convert.ToInt32(
                row.Cells["colStudentId"].Value);

            double grade = Convert.ToDouble(
                row.Cells["colStudentGrade"].Value);

            txtStudentId.Text = id.ToString();

            txtStudentGrade.Text =
                grade.ToString("F2");

            UpdatePairPreview(id, grade);

            lblStatus.Text =
                "Student " + id + " selected.";
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
