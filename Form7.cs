
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public partial class Form7 : Form
    {
        // Keep country pairs while the application runs
        private static readonly CountryPairManager manager =
            new CountryPairManager();

        public Form7()
        {
            InitializeComponent();

            // Automatically fit the form to the screen
            this.Load += (sender, e) =>
                ResponsiveForm.Fit(this);

            // Connect buttons
            btnAddPair.Click += btnAddPair_Click;
            btnSearchCountry.Click += btnSearchCountry_Click;
            btnRemovePair.Click += btnRemovePair_Click;
            btnDisplayPairs.Click += btnDisplayPairs_Click;
            btnBack.Click += btnBack_Click;

            // Connect DataGridView selection
            dgvCountries.CellClick += dgvCountries_CellClick;

            DisplayCountries();
        }

        // =====================================
        // VALIDATE COUNTRY CODE
        // =====================================
        private bool TryGetCountryCode(out string code)
        {
            code = txtCountryCode.Text.Trim()
                .ToUpperInvariant();

            if (!CountryPairManager.IsValidCountryCode(code))
            {
                MessageBox.Show(
                    "Please enter a valid country code." +
                    "\nThe code must contain exactly two letters." +
                    "\nExample: PH, JP, US",
                    "Invalid Country Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCountryCode.Focus();
                return false;
            }

            txtCountryCode.Text = code;
            return true;
        }

        // =====================================
        // ADD COUNTRY PAIR
        // =====================================
        private void btnAddPair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetCountryCode(out string code))
            {
                return;
            }

            string name = txtCountryName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show(
                    "Please enter a country name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCountryName.Focus();
                return;
            }

            if (manager.AddCountry(code, name))
            {
                MessageBox.Show(
                    "Country pair added successfully!" +
                    "\nCountry Code: " + code +
                    "\nCountry Name: " + name,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCountryCode.Clear();
                txtCountryName.Clear();

                DisplayCountries();
                SelectCountryRow(code);

                lblStatus.Text =
                    "Country " + code +
                    " added successfully.";

                txtCountryCode.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Country code " + code +
                    " already exists.",
                    "Duplicate Country Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =====================================
        // SEARCH COUNTRY
        // =====================================
        private void btnSearchCountry_Click(
            object sender, EventArgs e)
        {
            if (!TryGetCountryCode(out string code))
            {
                return;
            }

            KeyValuePair<string, string> country;

            if (manager.SearchCountry(code, out country))
            {
                // Display the country name
                txtCountryName.Text = country.Value;

                // Highlight the matching country
                SelectCountryRow(code);

                MessageBox.Show(
                    "Country Found!" +
                    "\nCountry Code: " + country.Key +
                    "\nCountry Name: " + country.Value,
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text =
                    "Country " + code + " found.";
            }
            else
            {
                dgvCountries.ClearSelection();
                txtCountryName.Clear();

                ClearPairPreview();

                MessageBox.Show(
                    "Country code " + code +
                    " was not found.",
                    "Country Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "Country not found.";
            }
        }

        // =====================================
        // REMOVE COUNTRY PAIR
        // =====================================
        private void btnRemovePair_Click(
            object sender, EventArgs e)
        {
            if (!TryGetCountryCode(out string code))
            {
                return;
            }

            KeyValuePair<string, string> country;

            if (!manager.SearchCountry(code, out country))
            {
                MessageBox.Show(
                    "Country code " + code +
                    " does not exist.",
                    "Country Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this pair?" +
                "\n\nCountry Code: " + country.Key +
                "\nCountry Name: " + country.Value,
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (manager.RemoveCountry(code))
            {
                MessageBox.Show(
                    "Country pair removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCountryCode.Clear();
                txtCountryName.Clear();

                DisplayCountries();

                lblStatus.Text =
                    "Country " + code +
                    " removed successfully.";
            }
        }

        // =====================================
        // DISPLAY ALL COUNTRY PAIRS
        // =====================================
        private void DisplayCountries()
        {
            // Clear previous table records
            dgvCountries.Rows.Clear();

            // Get countries from the manager
            List<KeyValuePair<string, string>> countries =
                manager.GetCountries();

            // Display each key-value pair
            foreach (KeyValuePair<string, string> country
                in countries)
            {
                dgvCountries.Rows.Add(
                    country.Key,
                    country.Value);
            }

            // Update total country count
            lblCountryCount.Text =
                "Total Country Pairs: " +
                manager.GetCountryCount();

            dgvCountries.ClearSelection();

            ClearPairPreview();

            if (manager.GetCountryCount() == 0)
            {
                lblStatus.Text =
                    "No country pairs stored.";
            }
            else
            {
                lblStatus.Text =
                    "Country pairs are ready.";
            }
        }

        // =====================================
        // DISPLAY COUNTRY PAIRS BUTTON
        // =====================================
        private void btnDisplayPairs_Click(
            object sender, EventArgs e)
        {
            DisplayCountries();

            if (manager.GetCountryCount() > 0)
            {
                lblStatus.Text =
                    "Country records refreshed.";
            }
        }

        // =====================================
        // UPDATE KEY-VALUE PREVIEW
        // =====================================
        private void UpdatePairPreview(
            string code, string name)
        {
            lblPreviewKey.Text =
                "Key: " + code;

            lblPreviewValue.Text =
                "Value: " + name;
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
        // SELECT COUNTRY ROW
        // =====================================
        private void SelectCountryRow(string code)
        {
            dgvCountries.ClearSelection();

            foreach (DataGridViewRow row in dgvCountries.Rows)
            {
                string rowCode =
                    row.Cells["colCountryCode"]
                    .Value?.ToString() ?? "";

                if (string.Equals(
                    rowCode,
                    code,
                    StringComparison.OrdinalIgnoreCase))
                {
                    dgvCountries.CurrentCell =
                        row.Cells["colCountryCode"];

                    row.Selected = true;

                    string name =
                        row.Cells["colCountryName"]
                        .Value?.ToString() ?? "";

                    UpdatePairPreview(code, name);

                    return;
                }
            }

            ClearPairPreview();
        }

        // =====================================
        // SELECT COUNTRY FROM DATAGRIDVIEW
        // =====================================
        private void dgvCountries_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvCountries.Rows[e.RowIndex];

            string code =
                row.Cells["colCountryCode"]
                .Value?.ToString() ?? "";

            string name =
                row.Cells["colCountryName"]
                .Value?.ToString() ?? "";

            // Display selected country in textboxes
            txtCountryCode.Text = code;
            txtCountryName.Text = name;

            // Update preview
            UpdatePairPreview(code, name);

            lblStatus.Text =
                "Country " + code + " selected.";
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
