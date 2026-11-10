
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblBrand = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            pnlActions = new Panel();
            lblActions = new Label();
            lblInstructions = new Label();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblStudentGrade = new Label();
            txtStudentGrade = new TextBox();
            btnAddPair = new Button();
            btnSearchStudent = new Button();
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
            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colStudentGrade = new DataGridViewTextBoxColumn();
            lblStudentCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRecords.SuspendLayout();
            pnlSelectedPair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            pnlHeader.Size = new Size(1126, 125);
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
            lblTitle.Size = new Size(690, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Student ID and Grade System";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(24, 91, 57);
            btnBack.Location = new Point(994, 66);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 42);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;
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
            pnlActions.Location = new Point(30, 154);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(363, 490);
            pnlActions.TabIndex = 1;
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblActions.ForeColor = Color.FromArgb(24, 91, 57);
            lblActions.Location = new Point(22, 20);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(345, 46);
            lblActions.TabIndex = 0;
            lblActions.Text = "Student Pair Actions";
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Segoe UI", 9F);
            lblInstructions.ForeColor = Color.DimGray;
            lblInstructions.Location = new Point(23, 65);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(280, 44);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Enter a Student ID and Grade to create a pair. Use the ID to search or remove.";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentId.Location = new Point(23, 115);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(173, 28);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Student ID (Key):";
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 11F);
            txtStudentId.Location = new Point(23, 143);
            txtStudentId.MaxLength = 10;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.PlaceholderText = "Enter Student ID (e.g., 101)";
            txtStudentId.Size = new Size(280, 37);
            txtStudentId.TabIndex = 3;
            // 
            // lblStudentGrade
            // 
            lblStudentGrade.AutoSize = true;
            lblStudentGrade.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentGrade.Location = new Point(23, 191);
            lblStudentGrade.Name = "lblStudentGrade";
            lblStudentGrade.Size = new Size(224, 28);
            lblStudentGrade.TabIndex = 4;
            lblStudentGrade.Text = "Student Grade (Value):";
            // 
            // txtStudentGrade
            // 
            txtStudentGrade.Font = new Font("Segoe UI", 11F);
            txtStudentGrade.Location = new Point(23, 219);
            txtStudentGrade.MaxLength = 10;
            txtStudentGrade.Name = "txtStudentGrade";
            txtStudentGrade.PlaceholderText = "Enter grade (0 - 100)";
            txtStudentGrade.Size = new Size(280, 37);
            txtStudentGrade.TabIndex = 5;
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
            btnAddPair.Text = "Add Student Pair";
            btnAddPair.UseVisualStyleBackColor = false;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.BackColor = Color.FromArgb(34, 119, 73);
            btnSearchStudent.FlatAppearance.BorderSize = 0;
            btnSearchStudent.FlatStyle = FlatStyle.Flat;
            btnSearchStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchStudent.ForeColor = Color.White;
            btnSearchStudent.Location = new Point(23, 323);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(280, 43);
            btnSearchStudent.TabIndex = 7;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = false;
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
            btnRemovePair.Text = "Remove Student Pair";
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
            btnDisplayPairs.Text = "Display Student Pairs";
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
            pnlRecords.Controls.Add(dgvStudents);
            pnlRecords.Controls.Add(lblStudentCount);
            pnlRecords.Controls.Add(lblStatus);
            pnlRecords.Location = new Point(427, 154);
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
            lblRecordsTitle.Size = new Size(448, 46);
            lblRecordsTitle.TabIndex = 0;
            lblRecordsTitle.Text = "Student Key-Value Records";
            // 
            // lblRecordsDescription
            // 
            lblRecordsDescription.AutoSize = true;
            lblRecordsDescription.Font = new Font("Segoe UI", 9F);
            lblRecordsDescription.ForeColor = Color.DimGray;
            lblRecordsDescription.Location = new Point(25, 57);
            lblRecordsDescription.Name = "lblRecordsDescription";
            lblRecordsDescription.Size = new Size(484, 25);
            lblRecordsDescription.TabIndex = 1;
            lblRecordsDescription.Text = "Each student is represented by a KeyValuePair<int, double>.";
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
            lblPreviewKey.AutoEllipsis = true;
            lblPreviewKey.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPreviewKey.ForeColor = Color.FromArgb(24, 91, 57);
            lblPreviewKey.Location = new Point(17, 44);
            lblPreviewKey.Name = "lblPreviewKey";
            lblPreviewKey.Size = new Size(220, 28);
            lblPreviewKey.TabIndex = 1;
            lblPreviewKey.Text = "Key: None";
            // 
            // lblPreviewValue
            // 
            lblPreviewValue.AutoEllipsis = true;
            lblPreviewValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPreviewValue.ForeColor = Color.FromArgb(24, 91, 57);
            lblPreviewValue.Location = new Point(255, 44);
            lblPreviewValue.Name = "lblPreviewValue";
            lblPreviewValue.Size = new Size(335, 28);
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
            lblTableTitle.Text = "Stored Student Pairs:";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(242, 248, 244);
            dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(250, 252, 250);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(24, 91, 57);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvStudents.ColumnHeadersHeight = 40;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colStudentGrade });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(200, 235, 211);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle8;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Font = new Font("Segoe UI", 10F);
            dgvStudents.Location = new Point(24, 228);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.RowTemplate.Height = 32;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(620, 182);
            dgvStudents.TabIndex = 4;
            // 
            // colStudentId
            // 
            colStudentId.FillWeight = 50F;
            colStudentId.HeaderText = "Student ID (Key)";
            colStudentId.MinimumWidth = 8;
            colStudentId.Name = "colStudentId";
            colStudentId.ReadOnly = true;
            colStudentId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStudentGrade
            // 
            dataGridViewCellStyle7.Format = "N2";
            colStudentGrade.DefaultCellStyle = dataGridViewCellStyle7;
            colStudentGrade.FillWeight = 50F;
            colStudentGrade.HeaderText = "Student Grade (Value)";
            colStudentGrade.MinimumWidth = 8;
            colStudentGrade.Name = "colStudentGrade";
            colStudentGrade.ReadOnly = true;
            colStudentGrade.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStudentCount.ForeColor = Color.FromArgb(24, 91, 57);
            lblStudentCount.Location = new Point(24, 423);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(232, 30);
            lblStudentCount.TabIndex = 5;
            lblStudentCount.Text = "Total Student Pairs: 0";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(24, 454);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(620, 24);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "No student pairs stored.";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(35, 672);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(404, 25);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "Student ID and Grade | KeyValuePair<int, double>";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(1126, 710);
            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRecords);
            Controls.Add(lblFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student ID and Grade System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            pnlRecords.ResumeLayout(false);
            pnlRecords.PerformLayout();
            pnlSelectedPair.ResumeLayout(false);
            pnlSelectedPair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
