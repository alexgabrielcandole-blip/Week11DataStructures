
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlDictionaryBase;
        private Panel pnlKeyValuePair;

        private Label lblBrand;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblDictionaryBaseTitle;
        private Label lblDictionaryBaseDescription;
        private Label lblKeyValuePairTitle;
        private Label lblKeyValuePairDescription;
        private Label lblFooter;

        private Button btnEmployeeDirectory;
        private Button btnLibraryRegistry;
        private Button btnProductCatalog;

        private Button btnProductID;
        private Button btnStudentGrade;
        private Button btnCountryCode;

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
            lblBrand = new Label();
            lblTitle = new Label();
            pnlDictionaryBase = new Panel();
            lblDictionaryBaseTitle = new Label();
            lblDictionaryBaseDescription = new Label();
            btnEmployeeDirectory = new Button();
            btnLibraryRegistry = new Button();
            btnProductCatalog = new Button();
            pnlKeyValuePair = new Panel();
            lblKeyValuePairTitle = new Label();
            lblKeyValuePairDescription = new Label();
            btnProductID = new Button();
            btnStudentGrade = new Button();
            btnCountryCode = new Button();
            lblDescription = new Label();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlDictionaryBase.SuspendLayout();
            pnlKeyValuePair.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 91, 57);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1158, 125);
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
            lblTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(926, 67);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Week 11 - Data Structure Applications";
            // 
            // pnlDictionaryBase
            // 
            pnlDictionaryBase.BackColor = Color.White;
            pnlDictionaryBase.BorderStyle = BorderStyle.FixedSingle;
            pnlDictionaryBase.Controls.Add(lblDictionaryBaseTitle);
            pnlDictionaryBase.Controls.Add(lblDictionaryBaseDescription);
            pnlDictionaryBase.Controls.Add(btnEmployeeDirectory);
            pnlDictionaryBase.Controls.Add(btnLibraryRegistry);
            pnlDictionaryBase.Controls.Add(btnProductCatalog);
            pnlDictionaryBase.Location = new Point(32, 232);
            pnlDictionaryBase.Name = "pnlDictionaryBase";
            pnlDictionaryBase.Size = new Size(542, 410);
            pnlDictionaryBase.TabIndex = 2;
            // 
            // lblDictionaryBaseTitle
            // 
            lblDictionaryBaseTitle.AutoSize = true;
            lblDictionaryBaseTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblDictionaryBaseTitle.ForeColor = Color.FromArgb(24, 91, 57);
            lblDictionaryBaseTitle.Location = new Point(22, 20);
            lblDictionaryBaseTitle.Name = "lblDictionaryBaseTitle";
            lblDictionaryBaseTitle.Size = new Size(524, 51);
            lblDictionaryBaseTitle.TabIndex = 0;
            lblDictionaryBaseTitle.Text = "DictionaryBase Applications";
            // 
            // lblDictionaryBaseDescription
            // 
            lblDictionaryBaseDescription.Font = new Font("Segoe UI", 9F);
            lblDictionaryBaseDescription.ForeColor = Color.DimGray;
            lblDictionaryBaseDescription.Location = new Point(25, 68);
            lblDictionaryBaseDescription.Name = "lblDictionaryBaseDescription";
            lblDictionaryBaseDescription.Size = new Size(435, 38);
            lblDictionaryBaseDescription.TabIndex = 1;
            lblDictionaryBaseDescription.Text = "Custom collections for storing and validating key-value records.";
            // 
            // btnEmployeeDirectory
            // 
            btnEmployeeDirectory.BackColor = Color.FromArgb(34, 119, 73);
            btnEmployeeDirectory.FlatAppearance.BorderSize = 0;
            btnEmployeeDirectory.FlatStyle = FlatStyle.Flat;
            btnEmployeeDirectory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmployeeDirectory.ForeColor = Color.White;
            btnEmployeeDirectory.Location = new Point(25, 114);
            btnEmployeeDirectory.Name = "btnEmployeeDirectory";
            btnEmployeeDirectory.Size = new Size(440, 72);
            btnEmployeeDirectory.TabIndex = 2;
            btnEmployeeDirectory.Text = "1. Custom Employee Directory";
            btnEmployeeDirectory.UseVisualStyleBackColor = false;
            // 
            // btnLibraryRegistry
            // 
            btnLibraryRegistry.BackColor = Color.FromArgb(34, 119, 73);
            btnLibraryRegistry.FlatAppearance.BorderSize = 0;
            btnLibraryRegistry.FlatStyle = FlatStyle.Flat;
            btnLibraryRegistry.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLibraryRegistry.ForeColor = Color.White;
            btnLibraryRegistry.Location = new Point(25, 203);
            btnLibraryRegistry.Name = "btnLibraryRegistry";
            btnLibraryRegistry.Size = new Size(440, 72);
            btnLibraryRegistry.TabIndex = 3;
            btnLibraryRegistry.Text = "2. Library Book Registry";
            btnLibraryRegistry.UseVisualStyleBackColor = false;
            // 
            // btnProductCatalog
            // 
            btnProductCatalog.BackColor = Color.FromArgb(34, 119, 73);
            btnProductCatalog.FlatAppearance.BorderSize = 0;
            btnProductCatalog.FlatStyle = FlatStyle.Flat;
            btnProductCatalog.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProductCatalog.ForeColor = Color.White;
            btnProductCatalog.Location = new Point(25, 292);
            btnProductCatalog.Name = "btnProductCatalog";
            btnProductCatalog.Size = new Size(440, 72);
            btnProductCatalog.TabIndex = 4;
            btnProductCatalog.Text = "3. Product Catalog";
            btnProductCatalog.UseVisualStyleBackColor = false;
            // 
            // pnlKeyValuePair
            // 
            pnlKeyValuePair.BackColor = Color.White;
            pnlKeyValuePair.BorderStyle = BorderStyle.FixedSingle;
            pnlKeyValuePair.Controls.Add(lblKeyValuePairTitle);
            pnlKeyValuePair.Controls.Add(lblKeyValuePairDescription);
            pnlKeyValuePair.Controls.Add(btnProductID);
            pnlKeyValuePair.Controls.Add(btnStudentGrade);
            pnlKeyValuePair.Controls.Add(btnCountryCode);
            pnlKeyValuePair.Location = new Point(618, 232);
            pnlKeyValuePair.Name = "pnlKeyValuePair";
            pnlKeyValuePair.Size = new Size(505, 410);
            pnlKeyValuePair.TabIndex = 3;
            // 
            // lblKeyValuePairTitle
            // 
            lblKeyValuePairTitle.AutoSize = true;
            lblKeyValuePairTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblKeyValuePairTitle.ForeColor = Color.FromArgb(24, 91, 57);
            lblKeyValuePairTitle.Location = new Point(22, 20);
            lblKeyValuePairTitle.Name = "lblKeyValuePairTitle";
            lblKeyValuePairTitle.Size = new Size(487, 51);
            lblKeyValuePairTitle.TabIndex = 0;
            lblKeyValuePairTitle.Text = "KeyValuePair Applications";
            // 
            // lblKeyValuePairDescription
            // 
            lblKeyValuePairDescription.Font = new Font("Segoe UI", 9F);
            lblKeyValuePairDescription.ForeColor = Color.DimGray;
            lblKeyValuePairDescription.Location = new Point(25, 68);
            lblKeyValuePairDescription.Name = "lblKeyValuePairDescription";
            lblKeyValuePairDescription.Size = new Size(435, 38);
            lblKeyValuePairDescription.TabIndex = 1;
            lblKeyValuePairDescription.Text = "Applications that represent information using associated key-value pairs.";
            // 
            // btnProductID
            // 
            btnProductID.BackColor = Color.FromArgb(34, 119, 73);
            btnProductID.FlatAppearance.BorderSize = 0;
            btnProductID.FlatStyle = FlatStyle.Flat;
            btnProductID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProductID.ForeColor = Color.White;
            btnProductID.Location = new Point(25, 114);
            btnProductID.Name = "btnProductID";
            btnProductID.Size = new Size(440, 72);
            btnProductID.TabIndex = 2;
            btnProductID.Text = "4. Product ID and Product Name";
            btnProductID.UseVisualStyleBackColor = false;
            // 
            // btnStudentGrade
            // 
            btnStudentGrade.BackColor = Color.FromArgb(34, 119, 73);
            btnStudentGrade.FlatAppearance.BorderSize = 0;
            btnStudentGrade.FlatStyle = FlatStyle.Flat;
            btnStudentGrade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStudentGrade.ForeColor = Color.White;
            btnStudentGrade.Location = new Point(25, 203);
            btnStudentGrade.Name = "btnStudentGrade";
            btnStudentGrade.Size = new Size(440, 72);
            btnStudentGrade.TabIndex = 3;
            btnStudentGrade.Text = "5. Student ID and Grade";
            btnStudentGrade.UseVisualStyleBackColor = false;
            // 
            // btnCountryCode
            // 
            btnCountryCode.BackColor = Color.FromArgb(34, 119, 73);
            btnCountryCode.FlatAppearance.BorderSize = 0;
            btnCountryCode.FlatStyle = FlatStyle.Flat;
            btnCountryCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCountryCode.ForeColor = Color.White;
            btnCountryCode.Location = new Point(25, 292);
            btnCountryCode.Name = "btnCountryCode";
            btnCountryCode.Size = new Size(440, 72);
            btnCountryCode.TabIndex = 4;
            btnCountryCode.Text = "6. Country Code and Country Name";
            btnCountryCode.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.ForeColor = Color.FromArgb(70, 80, 75);
            lblDescription.Location = new Point(35, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(708, 32);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Select an application to explore DictionaryBase and KeyValuePair.";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(35, 672);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(326, 25);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Data Structure and Algorithm | Week 11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(1156, 774);
            Controls.Add(pnlHeader);
            Controls.Add(lblDescription);
            Controls.Add(pnlDictionaryBase);
            Controls.Add(pnlKeyValuePair);
            Controls.Add(lblFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 11 - Data Structure Applications";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDictionaryBase.ResumeLayout(false);
            pnlDictionaryBase.PerformLayout();
            pnlKeyValuePair.ResumeLayout(false);
            pnlKeyValuePair.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
