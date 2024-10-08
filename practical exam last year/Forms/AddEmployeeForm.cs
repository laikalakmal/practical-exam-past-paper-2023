using System;
using System.Windows.Forms;

namespace practical_exam_last_year
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            cbUseTransf.CheckedChanged += new EventHandler(checkbox_checked);
            cbDonotUse.CheckedChanged += new EventHandler(checkbox_checked);
        }

        private void checkbox_checked(object sender, EventArgs e)
        {
            if (sender == cbDonotUse && cbDonotUse.Checked)
            {
                cbUseTransf.Checked = false;

            }
            if (sender == cbUseTransf && cbUseTransf.Checked)
            {
                cbDonotUse.Checked = false;

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string position = txtPosition.Text.Trim();
                int basicSalary = int.Parse(txtBasicSalary.Text.Trim());
                decimal allowanceRate = decimal.Parse(txtAllowanceRate.Text.Trim());
                bool useTransport;
                if (cbUseTransf.Checked)
                {
                    useTransport = true;
                }
                else
                {
                    useTransport = false;
                }
                Employee employee = new Employee(name, position, basicSalary, allowanceRate, useTransport);
                Employee.Employee_List.Add(employee);
                this.Hide();
                new AddEmployeeForm().Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               // this.Hide();
               // new AddEmployeeForm().Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }


    }
}
