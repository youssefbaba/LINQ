using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part5
{
    public partial class Form1 : Form
    {
        AgencyDbDataContext da;
        bool filter = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new AgencyDbDataContext();
            dataGridView1.DataSource = da.Employees.OrderByDescending(emp => emp.Salary).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            //dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == "Clerk").Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            //dataGridView1.DataSource = da.Employees.Where(emp => emp.Salary >= 7000).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job , emp.Salary});
            comboBox1.DataSource = da.Employees.Select(emp => emp.Job).Distinct();
            comboBox1.SelectedIndex = -1;
            filter = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{comboBox1.SelectedIndex}"); // First : 0 , Second : - 1
            if (filter)
            {
                da = new AgencyDbDataContext();
                dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == comboBox1.Text).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            da = new AgencyDbDataContext();
            //dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == comboBox1.Text).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            dataGridView1.DataSource = da.Employees.Where(emp => emp.Job.Contains(comboBox1.Text)).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
        }
    }
}
