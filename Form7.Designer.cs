
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form7
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

        private Label lblCountryCode;
        private Label lblCountryName;

        private Label lblRecordsTitle;
        private Label lblRecordsDescription;

        private Label lblPreviewTitle;
        private Label lblPreviewKey;
        private Label lblPreviewValue;

        private Label lblTableTitle;
        private Label lblCountryCount;
        private Label lblStatus;
        private Label lblFooter;

        private TextBox txtCountryCode;
        private TextBox txtCountryName;

        private DataGridView dgvCountries;
        private DataGridViewTextBoxColumn colCountryCode;
        private DataGridViewTextBoxColumn colCountryName;

        private Button btnAddPair;
        private Button btnSearchCountry;
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

            lblCountryCode = new Label();
            lblCountryName = new Label();

            lblRecordsTitle = new Label();
            lblRecordsDescription = new Label();

            lblPreviewTitle = new Label();
            lblPreviewKey = new Label();
            lblPreviewValue = new Label();

            lblTableTitle = new Label();
            lblCountryCount = new Label();
            lblStatus = new Label();
            lblFooter = new Label();

            txtCountryCode = new TextBox();
            txtCountryName = new TextBox();

            dgvCountries = new DataGridView();
            colCountryCode = new DataGridViewTextBoxColumn();
            colCountryName = new DataGridViewTextBoxColumn();

            btnAddPair = new Button();
            btnSearchCountry = new Button();
            btnRemovePair = new Button();
            btnDisplayPairs = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlRecords.SuspendLayout();
            pnlSelectedPair.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvCountries).BeginInit();

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

            Name = "Form7";
            Text = "Country Code and Country Name";

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
            lblTitle.Text = "Country Code and Country Name";

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
            // COUNTRY ACTIONS PANEL
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

            lblActions.Text = "Country Pair Actions";

            // INSTRUCTIONS
            lblInstructions.Font = new Font(
                "Segoe UI", 9F);

            lblInstructions.ForeColor = Color.DimGray;

            lblInstructions.Location = new Point(23, 65);
            lblInstructions.Size = new Size(280, 44);

            lblInstructions.Name = "lblInstructions";

            lblInstructions.Text =
                "Enter a Country Code and Name to create " +
                "a pair. Use the code to search or remove.";

            // =====================================
            // COUNTRY CODE LABEL
            // =====================================

            lblCountryCode.AutoSize = true;

            lblCountryCode.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblCountryCode.Location = new Point(23, 115);
            lblCountryCode.Name = "lblCountryCode";

            lblCountryCode.Text = "Country Code (Key):";

            // =====================================
            // COUNTRY CODE TEXTBOX
            // =====================================

            txtCountryCode.Location = new Point(23, 143);
            txtCountryCode.Size = new Size(280, 30);

            txtCountryCode.Font = new Font(
                "Segoe UI", 11F);

            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.MaxLength = 2;

            txtCountryCode.CharacterCasing =
                CharacterCasing.Upper;

            txtCountryCode.PlaceholderText =
                "Enter country code (e.g., PH)";

            // =====================================
            // COUNTRY NAME LABEL
            // =====================================

            lblCountryName.AutoSize = true;

            lblCountryName.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblCountryName.Location = new Point(23, 191);
            lblCountryName.Name = "lblCountryName";

            lblCountryName.Text =
                "Country Name (Value):";

            // =====================================
            // COUNTRY NAME TEXTBOX
            // =====================================

            txtCountryName.Location = new Point(23, 219);
            txtCountryName.Size = new Size(280, 30);

            txtCountryName.Font = new Font(
                "Segoe UI", 11F);

            txtCountryName.Name = "txtCountryName";
            txtCountryName.MaxLength = 100;

            txtCountryName.PlaceholderText =
                "Enter country name...";

            // =====================================
            // ADD COUNTRY PAIR BUTTON
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
            btnAddPair.Text = "Add Country Pair";
            btnAddPair.UseVisualStyleBackColor = false;

            // =====================================
            // SEARCH COUNTRY BUTTON
            // =====================================

            btnSearchCountry.BackColor =
                Color.FromArgb(34, 119, 73);

            btnSearchCountry.ForeColor = Color.White;
            btnSearchCountry.FlatStyle = FlatStyle.Flat;
            btnSearchCountry.FlatAppearance.BorderSize = 0;

            btnSearchCountry.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnSearchCountry.Location = new Point(23, 323);
            btnSearchCountry.Size = new Size(280, 43);

            btnSearchCountry.Name = "btnSearchCountry";
            btnSearchCountry.Text = "Search Country";
            btnSearchCountry.UseVisualStyleBackColor = false;

            // =====================================
            // REMOVE COUNTRY PAIR BUTTON
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
            btnRemovePair.Text = "Remove Country Pair";
            btnRemovePair.UseVisualStyleBackColor = false;

            // =====================================
            // DISPLAY COUNTRY PAIRS BUTTON
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
            btnDisplayPairs.Text = "Display Country Pairs";
            btnDisplayPairs.UseVisualStyleBackColor = false;

            // =====================================
            // COUNTRY RECORDS PANEL
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

            lblRecordsTitle.Text = "Country Key-Value Records";

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
                "Each country uses a KeyValuePair<string, string>.";

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

            // =====================================
            // PREVIEW KEY
            // =====================================

            lblPreviewKey.AutoSize = false;

            lblPreviewKey.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblPreviewKey.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblPreviewKey.Location = new Point(17, 44);
            lblPreviewKey.Size = new Size(180, 28);

            lblPreviewKey.Name = "lblPreviewKey";
            lblPreviewKey.Text = "Key: None";
            lblPreviewKey.AutoEllipsis = true;

            // =====================================
            // PREVIEW VALUE
            // =====================================

            lblPreviewValue.AutoSize = false;

            lblPreviewValue.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblPreviewValue.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblPreviewValue.Location = new Point(205, 44);
            lblPreviewValue.Size = new Size(390, 28);

            lblPreviewValue.Name = "lblPreviewValue";
            lblPreviewValue.Text = "Value: None";
            lblPreviewValue.AutoEllipsis = true;

            // =====================================
            // COUNTRY TABLE TITLE
            // =====================================

            lblTableTitle.AutoSize = true;

            lblTableTitle.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            lblTableTitle.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblTableTitle.Location = new Point(24, 201);
            lblTableTitle.Name = "lblTableTitle";

            lblTableTitle.Text = "Stored Country Pairs:";

            // =====================================
            // COUNTRY DATAGRIDVIEW
            // =====================================

            dgvCountries.Location = new Point(24, 228);
            dgvCountries.Size = new Size(620, 182);

            dgvCountries.Name = "dgvCountries";

            dgvCountries.BackgroundColor =
                Color.FromArgb(250, 252, 250);

            dgvCountries.BorderStyle =
                BorderStyle.FixedSingle;

            dgvCountries.Font = new Font(
                "Segoe UI", 10F);

            dgvCountries.AllowUserToAddRows = false;
            dgvCountries.AllowUserToDeleteRows = false;
            dgvCountries.AllowUserToResizeRows = false;

            dgvCountries.ReadOnly = true;
            dgvCountries.MultiSelect = false;

            dgvCountries.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCountries.RowHeadersVisible = false;

            dgvCountries.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCountries.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCountries.ColumnHeadersHeight = 40;
            dgvCountries.RowTemplate.Height = 32;

            dgvCountries.EnableHeadersVisualStyles = false;

            dgvCountries.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 91, 57);

            dgvCountries.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvCountries.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvCountries.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(200, 235, 211);

            dgvCountries.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvCountries.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 248, 244);

            // =====================================
            // COUNTRY CODE COLUMN
            // =====================================

            colCountryCode.Name = "colCountryCode";
            colCountryCode.HeaderText = "Country Code (Key)";

            colCountryCode.ReadOnly = true;
            colCountryCode.FillWeight = 38F;

            colCountryCode.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            // =====================================
            // COUNTRY NAME COLUMN
            // =====================================

            colCountryName.Name = "colCountryName";
            colCountryName.HeaderText = "Country Name (Value)";

            colCountryName.ReadOnly = true;
            colCountryName.FillWeight = 62F;

            colCountryName.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            dgvCountries.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colCountryCode,
                    colCountryName
                });

            // =====================================
            // TOTAL COUNTRY COUNT
            // =====================================

            lblCountryCount.AutoSize = true;

            lblCountryCount.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            lblCountryCount.ForeColor =
                Color.FromArgb(24, 91, 57);

            lblCountryCount.Location = new Point(24, 423);
            lblCountryCount.Name = "lblCountryCount";

            lblCountryCount.Text = "Total Country Pairs: 0";

            // =====================================
            // STATUS LABEL
            // =====================================

            lblStatus.Font = new Font(
                "Segoe UI", 9F);

            lblStatus.ForeColor = Color.Gray;

            lblStatus.Location = new Point(24, 454);
            lblStatus.Size = new Size(620, 24);

            lblStatus.Name = "lblStatus";
            lblStatus.Text = "No country pairs stored.";

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
                "Country Code and Name | KeyValuePair<string, string>";

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

            pnlActions.Controls.Add(lblCountryCode);
            pnlActions.Controls.Add(txtCountryCode);

            pnlActions.Controls.Add(lblCountryName);
            pnlActions.Controls.Add(txtCountryName);

            pnlActions.Controls.Add(btnAddPair);
            pnlActions.Controls.Add(btnSearchCountry);
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
            pnlRecords.Controls.Add(dgvCountries);

            pnlRecords.Controls.Add(lblCountryCount);
            pnlRecords.Controls.Add(lblStatus);

            // =====================================
            // ADD CONTROLS TO MAIN FORM
            // =====================================

            Controls.Add(pnlHeader);
            Controls.Add(pnlActions);
            Controls.Add(pnlRecords);
            Controls.Add(lblFooter);

            ((System.ComponentModel.ISupportInitialize)
                dgvCountries).EndInit();

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
