using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL_Part2
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
            using (dc = new CompanyDbDataContext())
            {
                dataGridView1.DataSource = dc.Employees;
            }
        }
    }
}
