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
    public partial class Form2 : Form
    {
        // Fields
        private readonly Action _ammountUpdater;
        CompanyDbDataContext dc;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Action ammountUpdater)
        {
            InitializeComponent();
            _ammountUpdater = ammountUpdater;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dc = new CompanyDbDataContext();
            Employee employee;
            if (!textBoxEno.Visible)
            {
                employee = new Employee();
                bool checkEname = string.IsNullOrEmpty(textBoxEname.Text);
                bool checkJob = string.IsNullOrEmpty(textBoxJob.Text);
                bool checkDname = string.IsNullOrEmpty(textBoxDname.Text);
                if (checkEname || checkJob || checkDname)
                {
                    MessageBox.Show("Please try to fill any empty field.");
                }
                else
                {
                    employee.Ename = textBoxEname.Text;
                    employee.Job = textBoxJob.Text;
                    employee.Salary = numericUpDownSalary.Value;
                    employee.Dname = textBoxDname.Text;
                    dc.Employees.InsertOnSubmit(employee);
                    dc.SubmitChanges();
                    MessageBox.Show("Record inserted into the table.");
                    _ammountUpdater();
                }
            }
            else
            {
                employee = dc.Employees.SingleOrDefault(emp => emp.Eno == int.Parse(textBoxEno.Text));
                if (employee != null)
                {
                    bool checkEname = string.IsNullOrEmpty(textBoxEname.Text);
                    bool checkJob = string.IsNullOrEmpty(textBoxJob.Text);
                    bool checkDname = string.IsNullOrEmpty(textBoxDname.Text);
                    if (checkEname || checkJob || checkDname)
                    {
                        MessageBox.Show("Please try to fill any empty field.");
                    }
                    else
                    {
                        employee.Ename = textBoxEname.Text;
                        employee.Job = textBoxJob.Text;
                        employee.Salary = numericUpDownSalary.Value;
                        employee.Dname = textBoxDname.Text;
                        dc.SubmitChanges();
                        MessageBox.Show("Record updated into the table.");
                        _ammountUpdater();
                    }
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                string type = control.GetType().Name;
                switch (type)
                {
                    case "TextBox":
                        TextBox textBox = control as TextBox;
                        textBox.Clear();
                        break;
                    case "NumericUpDown":
                        NumericUpDown numericUpDown = control as NumericUpDown;
                        numericUpDown.Value = 0;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
