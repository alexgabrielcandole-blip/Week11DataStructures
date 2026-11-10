
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week11DataStructures
{
    public static class ResponsiveForm
    {
        public static void Fit(Form form)
        {
            // Get available screen space excluding taskbar
            Rectangle screen =
                Screen.FromControl(form).WorkingArea;

            // Leave a small margin around the window
            int margin = 20;

            int availableWidth = screen.Width - margin;
            int availableHeight = screen.Height - margin;

            // Get current form dimensions
            int originalWidth = form.Width;
            int originalHeight = form.Height;

            // Calculate the required scale
            float scaleWidth =
                (float)availableWidth / originalWidth;

            float scaleHeight =
                (float)availableHeight / originalHeight;

            // Use the smaller scale to prevent clipping
            float scale = Math.Min(
                1f,
                Math.Min(scaleWidth, scaleHeight));

            // Resize only when the form is too large
            if (scale < 1f && scale > 0f)
            {
                form.SuspendLayout();

                // Scale all nested controls
                ScaleControls(form, scale);

                // Resize the main form
                form.Size = new Size(
                    (int)(originalWidth * scale),
                    (int)(originalHeight * scale));

                form.ResumeLayout(true);
            }

            // Center the form in the working area
            form.StartPosition =
                FormStartPosition.Manual;

            form.Location = new Point(
                screen.Left + (screen.Width - form.Width) / 2,
                screen.Top + (screen.Height - form.Height) / 2);
        }

        // =====================================
        // SCALE ALL CONTROLS
        // =====================================
        private static void ScaleControls(
            Control parent, float scale)
        {
            foreach (Control control in parent.Controls)
            {
                control.SuspendLayout();

                // Scale position and dimensions
                control.Bounds = new Rectangle(
                    (int)Math.Round(control.Left * scale),
                    (int)Math.Round(control.Top * scale),
                    Math.Max(1,
                        (int)Math.Round(control.Width * scale)),
                    Math.Max(1,
                        (int)Math.Round(control.Height * scale)));

                // Scale font size
                float newFontSize =
                    Math.Max(6f, control.Font.SizeInPoints * scale);

                control.Font = new Font(
                    control.Font.FontFamily,
                    newFontSize,
                    control.Font.Style,
                    GraphicsUnit.Point);

                // Scale DataGridView-specific heights
                if (control is DataGridView grid)
                {
                    grid.ColumnHeadersHeight = Math.Max(
                        20,
                        (int)(grid.ColumnHeadersHeight * scale));

                    grid.RowTemplate.Height = Math.Max(
                        18,
                        (int)(grid.RowTemplate.Height * scale));

                    if (grid.ColumnHeadersDefaultCellStyle.Font
                        is Font headerFont)
                    {
                        grid.ColumnHeadersDefaultCellStyle.Font =
                            new Font(
                                headerFont.FontFamily,
                                Math.Max(6f,
                                    headerFont.SizeInPoints * scale),
                                headerFont.Style);
                    }
                }

                // Scale controls inside panels and containers
                ScaleControls(control, scale);

                control.ResumeLayout(false);
            }
        }
    }
}
