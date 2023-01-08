using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part6
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
            dataGridView1.DataSource = da.Employees.Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            comboBox1.DataSource = da.Employees.Select(emp => emp.Job).Distinct();
            comboBox1.SelectedIndex = -1;
            filter = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter)
            {
                dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == comboBox1.Text).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == comboBox1.Text).OrderByDescending(emp => emp.Salary).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
            dataGridView1.DataSource = da.Employees.Where(emp => emp.Job.Contains(comboBox1.Text)).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
        }

        private void buttonOrderBySalaryAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.OrderBy(emp => emp.Salary).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
        }

        private void buttonOrderByEmpNameDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.OrderByDescending(emp => emp.EmpName).Select(emp => new { emp.EmpNum, emp.EmpName, emp.Job, emp.HireDate, emp.Salary, emp.DeptNum });
        }

        private void buttonGetSelectedColumns_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.OrderByDescending(emp => emp.Salary).Select(emp => new { EmployeeNumber = emp.EmpNum, EmployeeName = emp.EmpName, emp.Job, emp.Salary });
        }

        private void buttonEmpCountGroupByDepNum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.DeptNum).Select(empGroup => new { DeptNum = empGroup.Key, EmpCount = empGroup.Count() });
        }

        private void buttonEmpCountGroupByJob_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.Job).Select(empGroup => new { Job = empGroup.Key, EmpCount = empGroup.Count() });
        }

        private void buttonEmpCountGroupByDeptNumGreaterThan4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.DeptNum).Where(empGroup => empGroup.Count() > 4).Select(empGroup => new { DeptNum = empGroup.Key, EmpCount = empGroup.Count() });
        }

        private void buttonEmpCountGroupByJobLessThan3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.Job).Where(empGroup => empGroup.Count() < 3).Select(empGroup => new { Job = empGroup.Key, EmpCount = empGroup.Count() });
        }

        private void buttonMultipleClausesInQuery_Click(object sender, EventArgs e)
        {
            // Number Of Clerk In Each Departement
            dataGridView1.DataSource = da.Employees.Where(emp => emp.Job == "Clerk").GroupBy(emp => emp.DeptNum).Where(empGroup => empGroup.Count() > 1).OrderByDescending(empGroup => empGroup.Key).Select(empGroup => new { DeptNum = empGroup.Key, ClerkCount = empGroup.Count() });
        }

        private void buttonMaxSalaryGroupByDeptNum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.DeptNum).Select(empGroup => new { DeptNum = empGroup.Key, MaxSalary = empGroup.Max(emp => emp.Salary) });
        }

        private void buttonMinSalaryGroupByJob_Click(object sender, EventArgs e)
        {
            // Min Salary Group By Job
            dataGridView1.DataSource = da.Employees.GroupBy(emp => emp.Job).Select(empGroup => new { Job = empGroup.Key, MinSalary = empGroup.Min(emp => emp.Salary) });
        }
    }
}
