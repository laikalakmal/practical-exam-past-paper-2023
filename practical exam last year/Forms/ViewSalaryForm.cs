using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical_exam_last_year
{
    public partial class ViewSalaryForm : Form
    {
        public ViewSalaryForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewSalaryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();// clear any existing columns
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NetSalary",
                HeaderText = "Net Salary",
            });


            dataGridView1.DataSource = Employee.Employee_List;


        }
    }
}
