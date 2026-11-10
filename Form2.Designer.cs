
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlActions;
        private Panel pnlRecords;

        private Label lblBrand;
        private Label lblTitle;
        private Label lblActions;
        private Label lblInstructions;
        private Label lblEmployeeId;
        private Label lblEmployeeName;
        private Label lblRecordsTitle;
        private Label lblRecordsDescription;
        private Label lblEmployeeCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtEmployeeId;
        private TextBox txtEmployeeName;

        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn colEmployeeId;
        private DataGridViewTextBoxColumn colEmployeeName;

        private Button btnAddEmployee;
        private Button btnSearchEmployee;
        private Button btnRemoveEmployee;
        private Button btnDisplayEmployees;
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
            pnlRecords = new Panel();

            lblBrand = new Label();
            lblTitle = new Label();
            lblActions = new Label();
            lblInstructions = new Label();
            lblEmployeeId = new Label();
            lblEmployeeName = new Label();
            lblRecordsTitle = new Label();
            lblRecordsDescription = new Label();
            lblEmployeeCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();

            txtEmployeeId = new TextBox();
            txtEmployeeName = new TextBox();

            dgvEmployees = new DataGridView();
            colEmployeeId = new DataGridViewTextBoxColumn();
            colEmployeeName = new DataGridViewTextBoxColumn();

            btnAddEmployee = new Button();
            btnSearchEmployee = new Button();
            btnRemoveEmployee = new Button();
            btnDisplayEmployees = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRecords.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvEmployees).BeginInit();

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

            Name = "Form2";
            Text = "Custom Employee Directory";

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
            lblTitle.Text = "Custom Employee Directory";

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
            // EMPLOYEE ACTIONS PANEL
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

            lblActions.Location = new Point(22, 20);
            lblActions.Name = "lblActions";

            lblActions.Text = "Employee Actions";

            // INSTRUCTIONS
            lblInstructions.Font = new Font(
                "Segoe UI", 9F);

            lblInstructions.ForeColor = Color.DimGray;

            lblInstructions.Location = new Point(23, 66);
            lblInstructions.Size = new Size(280, 44);

            lblInstructions.Name = "lblInstructions";

            lblInstructions.Text =
                "Enter an Employee ID and Name to add a " +
                "record. Use the ID to search or remove.";

            // =====================================
            // EMPLOYEE ID LABEL
            // =====================================

            lblEmployeeId.AutoSize = true;

            lblEmployeeId.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblEmployeeId.Location = new Point(23, 115);
            lblEmployeeId.Name = "lblEmployeeId";

            lblEmployeeId.Text = "Employee ID:";

            // EMPLOYEE ID TEXTBOX
            txtEmployeeId.Location = new Point(23, 143);
            txtEmployeeId.Size = new Size(280, 30);

            txtEmployeeId.Font = new Font(
                "Segoe UI", 11F);

            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.MaxLength = 10;

            txtEmployeeId.PlaceholderText =
                "Enter Employee ID (e.g., 101)";

            // =====================================
            // EMPLOYEE NAME LABEL
            // =====================================

            lblEmployeeName.AutoSize = true;

            lblEmployeeName.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblEmployeeName.Location = new Point(23, 191);
            lblEmployeeName.Name = "lblEmployeeName";

            lblEmployeeName.Text = "Employee Name:";

            // EMPLOYEE NAME TEXTBOX
            txtEmployeeName.Location = new Point(23, 219);
            txtEmployeeName.Size = new Size(280, 30);

            txtEmployeeName.Font = new Font(
                "Segoe UI", 11F);

            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.MaxLength = 100;

            txtEmployeeName.PlaceholderText =
                "Enter employee name...";

            // =====================================
            // ADD EMPLOYEE BUTTON
            // =====================================

            btnAddEmployee.BackColor =
                Color.FromArgb(34, 119, 73);

            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;

            btnAddEmployee.FlatAppearance.BorderSize = 0;

            btnAddEmployee.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnAddEmployee.Location = new Point(23, 271);
            btnAddEmployee.Size = new Size(280, 43);

            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Text = "Add Employee";

            btnAddEmployee.UseVisualStyleBackColor = false;

            // =====================================
            // SEARCH EMPLOYEE BUTTON
            // =====================================

            btnSearchEmployee.BackColor =
                Color.FromArgb(34, 119, 73);

            btnSearchEmployee.ForeColor = Color.White;
            btnSearchEmployee.FlatStyle = FlatStyle.Flat;

            btnSearchEmployee.FlatAppearance.BorderSize = 0;

            btnSearchEmployee.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnSearchEmployee.Location = new Point(23, 323);
            btnSearchEmployee.Size = new Size(280, 43);

            btnSearchEmployee.Name = "btnSearchEmployee";
            btnSearchEmployee.Text = "Search Employee";

            btnSearchEmployee.UseVisualStyleBackColor = false;

            // =====================================
            // REMOVE EMPLOYEE BUTTON
            // =====================================

            btnRemoveEmployee.BackColor =
                Color.FromArgb(181, 65, 65);

            btnRemoveEmployee.ForeColor = Color.White;
            btnRemoveEmployee.FlatStyle = FlatStyle.Flat;

            btnRemoveEmployee.FlatAppearance.BorderSize = 0;

            btnRemoveEmployee.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnRemoveEmployee.Location = new Point(23, 375);
            btnRemoveEmployee.Size = new Size(280, 43);

            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Text = "Remove Employee";

            btnRemoveEmployee.UseVisualStyleBackColor = false;

            // =====================================
            // DISPLAY EMPLOYEES BUTTON
            // =====================================

            btnDisplayEmployees.BackColor =
                Color.FromArgb(24, 91, 57);

            btnDisplayEmployees.ForeColor = Color.White;
            btnDisplayEmployees.FlatStyle = FlatStyle.Flat;

            btnDisplayEmployees.FlatAppearance.BorderSize = 0;

            btnDisplayEmployees.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnDisplayEmployees.Location = new Point(23, 427);
            btnDisplayEmployees.Size = new Size(280, 43);

            btnDisplayEmployees.Name = "btnDisplayEmployees";
            btnDisplayEmployees.Text = "Display Employees";

            btnDisplayEmployees.UseVisualStyleBackColor = false;

            // =====================================
            // EMPLOYEE RECORDS PANEL
            // =====================================

            pnlRecords.BackColor = Color.White;

            pnlRecords.BorderStyle =
                BorderStyle.FixedSingle;

            pnlRecords.Location = new Point(380, 154);
            pnlRecords.Size = new Size(670, 490);

            pnlRecords.Name = "pnlRecords";

            // RECORDS TITLE
            lblRecordsTitle.AutoSize = true;

            lblRecordsTitle.Font = new Font(
                "Segoe UI", 17F, FontStyle.Bold);

            lblRecordsTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblRecordsTitle.Location = new Point(22, 20);
            lblRecordsTitle.Name = "lblRecordsTitle";

            lblRecordsTitle.Text = "Employee Records";

            // RECORDS DESCRIPTION
            lblRecordsDescription.AutoSize = true;

            lblRecordsDescription.Font = new Font(
                "Segoe UI", 9F);

            lblRecordsDescription.ForeColor = Color.DimGray;

            lblRecordsDescription.Location =
                new Point(25, 70);

            lblRecordsDescription.Name =
                "lblRecordsDescription";

            lblRecordsDescription.Text =
                "Employee information stored using DictionaryBase.";

            // =====================================
            // EMPLOYEE DATAGRIDVIEW
            // =====================================

            dgvEmployees.Location = new Point(24, 112);
            dgvEmployees.Size = new Size(620, 300);

            dgvEmployees.Name = "dgvEmployees";

            dgvEmployees.BackgroundColor =
                Color.FromArgb(250, 252, 250);

            dgvEmployees.BorderStyle =
                BorderStyle.FixedSingle;

            dgvEmployees.Font = new Font(
                "Segoe UI", 10F);

            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeRows = false;

            dgvEmployees.ReadOnly = true;
            dgvEmployees.MultiSelect = false;

            dgvEmployees.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEmployees.RowHeadersVisible = false;

            dgvEmployees.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployees.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvEmployees.ColumnHeadersHeight = 40;
            dgvEmployees.RowTemplate.Height = 32;

            dgvEmployees.EnableHeadersVisualStyles = false;

            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 91, 57);

            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEmployees.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvEmployees.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(200, 235, 211);

            dgvEmployees.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 248, 244);

            // EMPLOYEE ID COLUMN
            colEmployeeId.Name = "colEmployeeId";
            colEmployeeId.HeaderText = "Employee ID";

            colEmployeeId.ReadOnly = true;

            colEmployeeId.FillWeight = 35F;

            colEmployeeId.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // EMPLOYEE NAME COLUMN
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.HeaderText = "Employee Name";

            colEmployeeName.ReadOnly = true;

            colEmployeeName.FillWeight = 65F;

            colEmployeeName.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            dgvEmployees.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colEmployeeId,
                    colEmployeeName
                });

            // =====================================
            // EMPLOYEE COUNT
            // =====================================

            lblEmployeeCount.AutoSize = true;

            lblEmployeeCount.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblEmployeeCount.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblEmployeeCount.Location = new Point(24, 425);
            lblEmployeeCount.Name = "lblEmployeeCount";

            lblEmployeeCount.Text = "Total Employees: 0";

            // =====================================
            // STATUS LABEL
            // =====================================

            lblStatus.Font = new Font(
                "Segoe UI", 9F);

            lblStatus.ForeColor = Color.Gray;

            lblStatus.Location = new Point(24, 459);
            lblStatus.Size = new Size(620, 23);

            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Employee directory is empty.";

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
                "Employee Directory | DictionaryBase Implementation";

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

            pnlActions.Controls.Add(lblEmployeeId);
            pnlActions.Controls.Add(txtEmployeeId);

            pnlActions.Controls.Add(lblEmployeeName);
            pnlActions.Controls.Add(txtEmployeeName);

            pnlActions.Controls.Add(btnAddEmployee);
            pnlActions.Controls.Add(btnSearchEmployee);
            pnlActions.Controls.Add(btnRemoveEmployee);
            pnlActions.Controls.Add(btnDisplayEmployees);

            // =====================================
            // ADD CONTROLS TO RECORDS PANEL
            // =====================================

            pnlRecords.Controls.Add(lblRecordsTitle);
            pnlRecords.Controls.Add(lblRecordsDescription);

            pnlRecords.Controls.Add(dgvEmployees);

            pnlRecords.Controls.Add(lblEmployeeCount);
            pnlRecords.Controls.Add(lblStatus);

            // =====================================
            // ADD PANELS TO MAIN FORM
            // =====================================

            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRecords);
            Controls.Add(lblFooter);

            ((System.ComponentModel.ISupportInitialize)
                dgvEmployees).EndInit();

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();

            pnlRecords.ResumeLayout(false);
            pnlRecords.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
