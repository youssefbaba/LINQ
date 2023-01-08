using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part4
{
    public partial class Form1 : Form
    {
        CompanyDbDataContext dc;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(LoadData);
            form2.labelEno.Visible = false;
            form2.textBoxEno.Visible = false;
            form2.ShowDialog();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                Form2 form2 = new Form2(LoadData);
                form2.textBoxEno.Enabled = false;
                form2.buttonSave.Text = "Change";
                form2.buttonClear.Enabled = false;
                form2.textBoxEno.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                form2.textBoxEname.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                form2.textBoxJob.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                form2.numericUpDownSalary.Value = Convert.ToDecimal(dgView.SelectedRows[0].Cells[3].Value);
                form2.textBoxDname.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a record for updation.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                dc = new CompanyDbDataContext();
                var answer = MessageBox.Show("Are you sure for deleting the selected record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    Employee employee = dc.Employees.SingleOrDefault(emp => emp.Eno == Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value));
                    if (employee != null)
                    {
                        dc.Employees.DeleteOnSubmit(employee);
                        dc.SubmitChanges();
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadData()
        {
            dc = new CompanyDbDataContext();
            dgView.DataSource = dc.Employees;
        }
    }
}
