using System;
using System.Windows.Forms;

namespace practical_exam_last_year
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ViewSalaryForm().Show();
            this.Hide();
        }
    }
}
