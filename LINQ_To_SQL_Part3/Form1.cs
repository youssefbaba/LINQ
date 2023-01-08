using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part3
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
            /*
            dc = new CompanyDbDataContext();
            Table<Employee> tableEmployee = dc.Employees;
            dataGridView1.DataSource = tableEmployee;
            */

            dc = new CompanyDbDataContext();
            dataGridView1.DataSource = dc.Employees;
        }
    }
}
