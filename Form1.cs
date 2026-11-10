namespace Week11DataStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += (sender, e) => ResponsiveForm.Fit(this);

            btnEmployeeDirectory.Click += btnEmployeeDirectory_Click;
            btnLibraryRegistry.Click += btnLibraryRegistry_Click;
        }


        private void btnEmployeeDirectory_Click(
            object sender, EventArgs e)
        {
            using (Form2 employeeForm = new Form2())
            {
                employeeForm.ShowDialog(this);
            }
        }

        private void btnLibraryRegistry_Click(
            object sender, EventArgs e)
        {
            using (Form3 libraryForm = new Form3())
            {
                libraryForm.ShowDialog(this);
            }
        }


    }
}
