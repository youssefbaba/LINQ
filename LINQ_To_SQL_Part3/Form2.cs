using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part3
{
    public partial class Form2 : Form
    {
        CompanyDbDataContext dc;
        List<Employee> employees;
        int index = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new CompanyDbDataContext();
            employees = dc.Employees.ToList();
            if (employees.Count > 0)
            {
                ShowData();
                textBoxEno.Focus();
            }
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (employees.Count > 0)
            {
                if (index > 0)
                {
                    index--;
                    ShowData();
                }
                else
                {
                    MessageBox.Show("First record of the table.");
                }
            }
            else
            {
                MessageBox.Show("The table is empty.");
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (employees.Count > 0)
            {
                if (index < employees.Count - 1)
                {
                    index++;
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Last record of the table.");
                }
            }
            else
            {
                MessageBox.Show("The table is empty.");
            }
        }
        private void ShowData()
        {
            textBoxEno.Text = employees[index].Eno.ToString();
            textBoxEname.Text = employees[index].Ename;
            textBoxJob.Text = employees[index].Job;
            textBoxSalary.Text = employees[index].Salary.ToString();
            textBoxDname.Text = employees[index].Dname;
        }
    }
}
