namespace LINQ_To_SQL_Part6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOrderBySalaryAsc = new System.Windows.Forms.Button();
            this.buttonOrderByEmpNameDesc = new System.Windows.Forms.Button();
            this.buttonGetSelectedColumns = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByDepNum = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByJob = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByDeptNumGreaterThan4 = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByJobLessThan3 = new System.Windows.Forms.Button();
            this.buttonMultipleClausesInQuery = new System.Windows.Forms.Button();
            this.buttonMaxSalaryGroupByDeptNum = new System.Windows.Forms.Button();
            this.buttonMinSalaryGroupByJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(657, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 34);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // buttonOrderBySalaryAsc
            // 
            this.buttonOrderBySalaryAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderBySalaryAsc.Location = new System.Drawing.Point(676, 81);
            this.buttonOrderBySalaryAsc.Name = "buttonOrderBySalaryAsc";
            this.buttonOrderBySalaryAsc.Size = new System.Drawing.Size(346, 33);
            this.buttonOrderBySalaryAsc.TabIndex = 2;
            this.buttonOrderBySalaryAsc.Text = "Order By Salary Asc";
            this.buttonOrderBySalaryAsc.UseVisualStyleBackColor = true;
            this.buttonOrderBySalaryAsc.Click += new System.EventHandler(this.buttonOrderBySalaryAsc_Click);
            // 
            // buttonOrderByEmpNameDesc
            // 
            this.buttonOrderByEmpNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderByEmpNameDesc.Location = new System.Drawing.Point(676, 141);
            this.buttonOrderByEmpNameDesc.Name = "buttonOrderByEmpNameDesc";
            this.buttonOrderByEmpNameDesc.Size = new System.Drawing.Size(346, 33);
            this.buttonOrderByEmpNameDesc.TabIndex = 3;
            this.buttonOrderByEmpNameDesc.Text = "Order By EmpName Desc";
            this.buttonOrderByEmpNameDesc.UseVisualStyleBackColor = true;
            this.buttonOrderByEmpNameDesc.Click += new System.EventHandler(this.buttonOrderByEmpNameDesc_Click);
            // 
            // buttonGetSelectedColumns
            // 
            this.buttonGetSelectedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetSelectedColumns.Location = new System.Drawing.Point(676, 201);
            this.buttonGetSelectedColumns.Name = "buttonGetSelectedColumns";
            this.buttonGetSelectedColumns.Size = new System.Drawing.Size(346, 33);
            this.buttonGetSelectedColumns.TabIndex = 4;
            this.buttonGetSelectedColumns.Text = "Get Selected Columns";
            this.buttonGetSelectedColumns.UseVisualStyleBackColor = true;
            this.buttonGetSelectedColumns.Click += new System.EventHandler(this.buttonGetSelectedColumns_Click);
            // 
            // buttonEmpCountGroupByDepNum
            // 
            this.buttonEmpCountGroupByDepNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByDepNum.Location = new System.Drawing.Point(676, 261);
            this.buttonEmpCountGroupByDepNum.Name = "buttonEmpCountGroupByDepNum";
            this.buttonEmpCountGroupByDepNum.Size = new System.Drawing.Size(346, 33);
            this.buttonEmpCountGroupByDepNum.TabIndex = 5;
            this.buttonEmpCountGroupByDepNum.Text = "Emp Count Group By DeptNum";
            this.buttonEmpCountGroupByDepNum.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByDepNum.Click += new System.EventHandler(this.buttonEmpCountGroupByDepNum_Click);
            // 
            // buttonEmpCountGroupByJob
            // 
            this.buttonEmpCountGroupByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByJob.Location = new System.Drawing.Point(676, 320);
            this.buttonEmpCountGroupByJob.Name = "buttonEmpCountGroupByJob";
            this.buttonEmpCountGroupByJob.Size = new System.Drawing.Size(346, 33);
            this.buttonEmpCountGroupByJob.TabIndex = 6;
            this.buttonEmpCountGroupByJob.Text = "Emp Count Group By Job";
            this.buttonEmpCountGroupByJob.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByJob.Click += new System.EventHandler(this.buttonEmpCountGroupByJob_Click);
            // 
            // buttonEmpCountGroupByDeptNumGreaterThan4
            // 
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Location = new System.Drawing.Point(676, 381);
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Name = "buttonEmpCountGroupByDeptNumGreaterThan4";
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Size = new System.Drawing.Size(346, 33);
            this.buttonEmpCountGroupByDeptNumGreaterThan4.TabIndex = 7;
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Text = "Emp Count Group By DeptNum > 4";
            this.buttonEmpCountGroupByDeptNumGreaterThan4.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByDeptNumGreaterThan4.Click += new System.EventHandler(this.buttonEmpCountGroupByDeptNumGreaterThan4_Click);
            // 
            // buttonEmpCountGroupByJobLessThan3
            // 
            this.buttonEmpCountGroupByJobLessThan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByJobLessThan3.Location = new System.Drawing.Point(676, 438);
            this.buttonEmpCountGroupByJobLessThan3.Name = "buttonEmpCountGroupByJobLessThan3";
            this.buttonEmpCountGroupByJobLessThan3.Size = new System.Drawing.Size(346, 33);
            this.buttonEmpCountGroupByJobLessThan3.TabIndex = 8;
            this.buttonEmpCountGroupByJobLessThan3.Text = "Emp Count Group By Job < 3";
            this.buttonEmpCountGroupByJobLessThan3.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByJobLessThan3.Click += new System.EventHandler(this.buttonEmpCountGroupByJobLessThan3_Click);
            // 
            // buttonMultipleClausesInQuery
            // 
            this.buttonMultipleClausesInQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultipleClausesInQuery.Location = new System.Drawing.Point(676, 498);
            this.buttonMultipleClausesInQuery.Name = "buttonMultipleClausesInQuery";
            this.buttonMultipleClausesInQuery.Size = new System.Drawing.Size(346, 33);
            this.buttonMultipleClausesInQuery.TabIndex = 9;
            this.buttonMultipleClausesInQuery.Text = "Multiple Clauses In A Query";
            this.buttonMultipleClausesInQuery.UseVisualStyleBackColor = true;
            this.buttonMultipleClausesInQuery.Click += new System.EventHandler(this.buttonMultipleClausesInQuery_Click);
            // 
            // buttonMaxSalaryGroupByDeptNum
            // 
            this.buttonMaxSalaryGroupByDeptNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxSalaryGroupByDeptNum.Location = new System.Drawing.Point(676, 559);
            this.buttonMaxSalaryGroupByDeptNum.Name = "buttonMaxSalaryGroupByDeptNum";
            this.buttonMaxSalaryGroupByDeptNum.Size = new System.Drawing.Size(346, 33);
            this.buttonMaxSalaryGroupByDeptNum.TabIndex = 10;
            this.buttonMaxSalaryGroupByDeptNum.Text = "Max Salary Group By DeptNum";
            this.buttonMaxSalaryGroupByDeptNum.UseVisualStyleBackColor = true;
            this.buttonMaxSalaryGroupByDeptNum.Click += new System.EventHandler(this.buttonMaxSalaryGroupByDeptNum_Click);
            // 
            // buttonMinSalaryGroupByJob
            // 
            this.buttonMinSalaryGroupByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinSalaryGroupByJob.Location = new System.Drawing.Point(676, 614);
            this.buttonMinSalaryGroupByJob.Name = "buttonMinSalaryGroupByJob";
            this.buttonMinSalaryGroupByJob.Size = new System.Drawing.Size(346, 33);
            this.buttonMinSalaryGroupByJob.TabIndex = 11;
            this.buttonMinSalaryGroupByJob.Text = "Min Salary Group By Job";
            this.buttonMinSalaryGroupByJob.UseVisualStyleBackColor = true;
            this.buttonMinSalaryGroupByJob.Click += new System.EventHandler(this.buttonMinSalaryGroupByJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 693);
            this.Controls.Add(this.buttonMinSalaryGroupByJob);
            this.Controls.Add(this.buttonMaxSalaryGroupByDeptNum);
            this.Controls.Add(this.buttonMultipleClausesInQuery);
            this.Controls.Add(this.buttonEmpCountGroupByJobLessThan3);
            this.Controls.Add(this.buttonEmpCountGroupByDeptNumGreaterThan4);
            this.Controls.Add(this.buttonEmpCountGroupByJob);
            this.Controls.Add(this.buttonEmpCountGroupByDepNum);
            this.Controls.Add(this.buttonGetSelectedColumns);
            this.Controls.Add(this.buttonOrderByEmpNameDesc);
            this.Controls.Add(this.buttonOrderBySalaryAsc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonOrderBySalaryAsc;
        private System.Windows.Forms.Button buttonOrderByEmpNameDesc;
        private System.Windows.Forms.Button buttonGetSelectedColumns;
        private System.Windows.Forms.Button buttonEmpCountGroupByDepNum;
        private System.Windows.Forms.Button buttonEmpCountGroupByJob;
        private System.Windows.Forms.Button buttonEmpCountGroupByDeptNumGreaterThan4;
        private System.Windows.Forms.Button buttonEmpCountGroupByJobLessThan3;
        private System.Windows.Forms.Button buttonMultipleClausesInQuery;
        private System.Windows.Forms.Button buttonMaxSalaryGroupByDeptNum;
        private System.Windows.Forms.Button buttonMinSalaryGroupByJob;
    }
}

