
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form6
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

        private Label lblStudentId;
        private Label lblStudentGrade;

        private Label lblRecordsTitle;
        private Label lblRecordsDescription;

        private Label lblPreviewTitle;
        private Label lblPreviewKey;
        private Label lblPreviewValue;

        private Label lblTableTitle;
        private Label lblStudentCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtStudentId;
        private TextBox txtStudentGrade;

        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colStudentGrade;

        private Button btnAddPair;
        private Button btnSearchStudent;
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
            pnlHeader = new Panel();
            pnlActions = new Panel();
            pnlRecords = new Panel();
            pnlSelectedPair = new Panel();

            lblBrand = new Label();
            lblTitle = new Label();
            lblActions = new Label();
            lblInstructions = new Label();

            lblStudentId = new Label();
            lblStudentGrade = new Label();

            lblRecordsTitle = new Label();
            lblRecordsDescription = new Label();

            lblPreviewTitle = new Label();
            lblPreviewKey = new Label();
            lblPreviewValue = new Label();

            lblTableTitle = new Label();
            lblStudentCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();

            txtStudentId = new TextBox();
            txtStudentGrade = new TextBox();

            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colStudentGrade = new DataGridViewTextBoxColumn();

            btnAddPair = new Button();
            btnSearchStudent = new Button();
            btnRemovePair = new Button();
            btnDisplayPairs = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRecords.SuspendLayout();
            pnlSelectedPair.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvStudents).BeginInit();

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

            Name = "Form6";
            Text = "Student ID and Grade System";

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
                "Segoe UI", 24F, FontStyle.Bold);

            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 55);

            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Student ID and Grade System";

            // =====================================
            // BACK BUTTON
            // =====================================

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
            // STUDENT ACTIONS PANEL
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

            lblActions.Text = "Student Pair Actions";

            // INSTRUCTIONS
            lblInstructions.Font = new Font(
                "Segoe UI", 9F);

            lblInstructions.ForeColor = Color.DimGray;

            lblInstructions.Location = new Point(23, 65);
            lblInstructions.Size = new Size(280, 44);

            lblInstructions.Name = "lblInstructions";

            lblInstructions.Text =
                "Enter a Student ID and Grade to create a pair. " +
                "Use the ID to search or remove.";

            // =====================================
            // STUDENT ID LABEL
            // =====================================

            lblStudentId.AutoSize = true;

            lblStudentId.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblStudentId.Location = new Point(23, 115);
            lblStudentId.Name = "lblStudentId";

            lblStudentId.Text = "Student ID (Key):";

            // STUDENT ID TEXTBOX
            txtStudentId.Location = new Point(23, 143);
            txtStudentId.Size = new Size(280, 30);

            txtStudentId.Font = new Font(
                "Segoe UI", 11F);

            txtStudentId.Name = "txtStudentId";
            txtStudentId.MaxLength = 10;

            txtStudentId.PlaceholderText =
                "Enter Student ID (e.g., 101)";

            // =====================================
            // STUDENT GRADE LABEL
            // =====================================

            lblStudentGrade.AutoSize = true;

            lblStudentGrade.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblStudentGrade.Location = new Point(23, 191);
            lblStudentGrade.Name = "lblStudentGrade";

            lblStudentGrade.Text =
                "Student Grade (Value):";

            // STUDENT GRADE TEXTBOX
            txtStudentGrade.Location = new Point(23, 219);
            txtStudentGrade.Size = new Size(280, 30);

            txtStudentGrade.Font = new Font(
                "Segoe UI", 11F);

            txtStudentGrade.Name = "txtStudentGrade";
            txtStudentGrade.MaxLength = 10;

            txtStudentGrade.PlaceholderText =
                "Enter grade (0 - 100)";

            // =====================================
            // ADD STUDENT PAIR BUTTON
            // =====================================

            btnAddPair.BackColor =
                Color.FromArgb(34, 119, 73);

            btnAddPair.ForeColor = Color.White;
            btnAddPair.FlatStyle = FlatStyle.Flat;
            btnAddPair.FlatAppearance.BorderSize = 0;

            btnAddPair.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnAddPair.Location = new Point(23, 271);
            btnAddPair.Size = new Size(280, 43);

            btnAddPair.Name = "btnAddPair";
            btnAddPair.Text = "Add Student Pair";
            btnAddPair.UseVisualStyleBackColor = false;

            // =====================================
            // SEARCH STUDENT BUTTON
            // =====================================

            btnSearchStudent.BackColor =
                Color.FromArgb(34, 119, 73);

            btnSearchStudent.ForeColor = Color.White;
            btnSearchStudent.FlatStyle = FlatStyle.Flat;
            btnSearchStudent.FlatAppearance.BorderSize = 0;

            btnSearchStudent.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnSearchStudent.Location = new Point(23, 323);
            btnSearchStudent.Size = new Size(280, 43);

            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = false;

            // =====================================
            // REMOVE STUDENT PAIR BUTTON
            // =====================================

            btnRemovePair.BackColor =
                Color.FromArgb(181, 65, 65);

            btnRemovePair.ForeColor = Color.White;
            btnRemovePair.FlatStyle = FlatStyle.Flat;
            btnRemovePair.FlatAppearance.BorderSize = 0;

            btnRemovePair.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnRemovePair.Location = new Point(23, 375);
            btnRemovePair.Size = new Size(280, 43);

            btnRemovePair.Name = "btnRemovePair";
            btnRemovePair.Text = "Remove Student Pair";
            btnRemovePair.UseVisualStyleBackColor = false;

            // =====================================
            // DISPLAY STUDENT PAIRS BUTTON
            // =====================================

            btnDisplayPairs.BackColor =
                Color.FromArgb(24, 91, 57);

            btnDisplayPairs.ForeColor = Color.White;
            btnDisplayPairs.FlatStyle = FlatStyle.Flat;
            btnDisplayPairs.FlatAppearance.BorderSize = 0;

            btnDisplayPairs.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnDisplayPairs.Location = new Point(23, 427);
            btnDisplayPairs.Size = new Size(280, 43);

            btnDisplayPairs.Name = "btnDisplayPairs";
            btnDisplayPairs.Text = "Display Student Pairs";
            btnDisplayPairs.UseVisualStyleBackColor = false;

            // =====================================
            // STUDENT RECORDS PANEL
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

            lblRecordsTitle.Location = new Point(22, 15);
            lblRecordsTitle.Name = "lblRecordsTitle";

            lblRecordsTitle.Text = "Student Key-Value Records";

            // RECORDS DESCRIPTION
            lblRecordsDescription.AutoSize = true;

            lblRecordsDescription.Font = new Font(
                "Segoe UI", 9F);

            lblRecordsDescription.ForeColor =
                Color.DimGray;

            lblRecordsDescription.Location =
                new Point(25, 57);

            lblRecordsDescription.Name =
                "lblRecordsDescription";

            lblRecordsDescription.Text =
                "Each student is represented by a KeyValuePair<int, double>.";

            // =====================================
            // SELECTED PAIR PREVIEW PANEL
            // =====================================

            pnlSelectedPair.BackColor =
                Color.FromArgb(236, 246, 239);

            pnlSelectedPair.BorderStyle =
                BorderStyle.FixedSingle;

            pnlSelectedPair.Location = new Point(24, 90);
            pnlSelectedPair.Size = new Size(620, 100);

            pnlSelectedPair.Name = "pnlSelectedPair";

            // PREVIEW TITLE
            lblPreviewTitle.AutoSize = true;

            lblPreviewTitle.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblPreviewTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblPreviewTitle.Location = new Point(15, 10);
            lblPreviewTitle.Name = "lblPreviewTitle";

            lblPreviewTitle.Text = "Selected Key-Value Pair";

            // PREVIEW KEY
            lblPreviewKey.AutoSize = false;

            lblPreviewKey.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblPreviewKey.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblPreviewKey.Location = new Point(17, 44);
            lblPreviewKey.Size = new Size(220, 28);

            lblPreviewKey.Name = "lblPreviewKey";
            lblPreviewKey.Text = "Key: None";
            lblPreviewKey.AutoEllipsis = true;

            // PREVIEW VALUE
            lblPreviewValue.AutoSize = false;

            lblPreviewValue.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblPreviewValue.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblPreviewValue.Location = new Point(255, 44);
            lblPreviewValue.Size = new Size(335, 28);

            lblPreviewValue.Name = "lblPreviewValue";
            lblPreviewValue.Text = "Value: None";
            lblPreviewValue.AutoEllipsis = true;

            // =====================================
            // STUDENT TABLE TITLE
            // =====================================

            lblTableTitle.AutoSize = true;

            lblTableTitle.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblTableTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblTableTitle.Location = new Point(24, 201);
            lblTableTitle.Name = "lblTableTitle";

            lblTableTitle.Text = "Stored Student Pairs:";

            // =====================================
            // STUDENT DATAGRIDVIEW
            // =====================================

            dgvStudents.Location = new Point(24, 228);
            dgvStudents.Size = new Size(620, 182);

            dgvStudents.Name = "dgvStudents";

            dgvStudents.BackgroundColor =
                Color.FromArgb(250, 252, 250);

            dgvStudents.BorderStyle =
                BorderStyle.FixedSingle;

            dgvStudents.Font = new Font(
                "Segoe UI", 10F);

            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;

            dgvStudents.ReadOnly = true;
            dgvStudents.MultiSelect = false;

            dgvStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.RowHeadersVisible = false;

            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvStudents.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvStudents.ColumnHeadersHeight = 40;
            dgvStudents.RowTemplate.Height = 32;

            dgvStudents.EnableHeadersVisualStyles = false;

            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 91, 57);

            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvStudents.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvStudents.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(200, 235, 211);

            dgvStudents.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 248, 244);

            // =====================================
            // STUDENT ID COLUMN
            // =====================================

            colStudentId.Name = "colStudentId";
            colStudentId.HeaderText = "Student ID (Key)";

            colStudentId.ReadOnly = true;
            colStudentId.FillWeight = 50F;

            colStudentId.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // =====================================
            // STUDENT GRADE COLUMN
            // =====================================

            colStudentGrade.Name = "colStudentGrade";
            colStudentGrade.HeaderText = "Student Grade (Value)";

            colStudentGrade.ReadOnly = true;
            colStudentGrade.FillWeight = 50F;

            colStudentGrade.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            colStudentGrade.DefaultCellStyle.Format = "N2";

            dgvStudents.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colStudentId,
                    colStudentGrade
                });

            // =====================================
            // TOTAL STUDENT COUNT
            // =====================================

            lblStudentCount.AutoSize = true;

            lblStudentCount.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblStudentCount.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblStudentCount.Location = new Point(24, 423);
            lblStudentCount.Name = "lblStudentCount";

            lblStudentCount.Text = "Total Student Pairs: 0";

            // =====================================
            // STATUS LABEL
            // =====================================

            lblStatus.Font = new Font(
                "Segoe UI", 9F);

            lblStatus.ForeColor = Color.Gray;

            lblStatus.Location = new Point(24, 454);
            lblStatus.Size = new Size(620, 24);

            lblStatus.Name = "lblStatus";
            lblStatus.Text = "No student pairs stored.";

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
                "Student ID and Grade | KeyValuePair<int, double>";

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

            pnlActions.Controls.Add(lblStudentId);
            pnlActions.Controls.Add(txtStudentId);

            pnlActions.Controls.Add(lblStudentGrade);
            pnlActions.Controls.Add(txtStudentGrade);

            pnlActions.Controls.Add(btnAddPair);
            pnlActions.Controls.Add(btnSearchStudent);
            pnlActions.Controls.Add(btnRemovePair);
            pnlActions.Controls.Add(btnDisplayPairs);

            // =====================================
            // ADD CONTROLS TO PREVIEW PANEL
            // =====================================

            pnlSelectedPair.Controls.Add(lblPreviewTitle);
            pnlSelectedPair.Controls.Add(lblPreviewKey);
            pnlSelectedPair.Controls.Add(lblPreviewValue);

            // =====================================
            // ADD CONTROLS TO RECORDS PANEL
            // =====================================

            pnlRecords.Controls.Add(lblRecordsTitle);
            pnlRecords.Controls.Add(lblRecordsDescription);
            pnlRecords.Controls.Add(pnlSelectedPair);
            pnlRecords.Controls.Add(lblTableTitle);
            pnlRecords.Controls.Add(dgvStudents);
            pnlRecords.Controls.Add(lblStudentCount);
            pnlRecords.Controls.Add(lblStatus);

            // =====================================
            // ADD CONTROLS TO MAIN FORM
            // =====================================

            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRecords);
            Controls.Add(lblFooter);

            ((System.ComponentModel.ISupportInitialize)
                dgvStudents).EndInit();

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();

            pnlSelectedPair.ResumeLayout(false);
            pnlSelectedPair.PerformLayout();

            pnlRecords.ResumeLayout(false);
            pnlRecords.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
