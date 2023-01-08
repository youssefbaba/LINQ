namespace LINQ_To_SQL_Part4
{
    partial class Form2
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
            this.labelEmployeeDetails = new System.Windows.Forms.Label();
            this.labelEname = new System.Windows.Forms.Label();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.labelJob = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxDname = new System.Windows.Forms.TextBox();
            this.labelDname = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxEno = new System.Windows.Forms.TextBox();
            this.labelEno = new System.Windows.Forms.Label();
            this.labelSalaryValidation = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployeeDetails
            // 
            this.labelEmployeeDetails.AutoSize = true;
            this.labelEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeDetails.Location = new System.Drawing.Point(174, 9);
            this.labelEmployeeDetails.Name = "labelEmployeeDetails";
            this.labelEmployeeDetails.Size = new System.Drawing.Size(260, 36);
            this.labelEmployeeDetails.TabIndex = 0;
            this.labelEmployeeDetails.Text = "Employee Details";
            // 
            // labelEname
            // 
            this.labelEname.AutoSize = true;
            this.labelEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEname.Location = new System.Drawing.Point(35, 141);
            this.labelEname.Name = "labelEname";
            this.labelEname.Size = new System.Drawing.Size(94, 29);
            this.labelEname.TabIndex = 1;
            this.labelEname.Text = "Ename";
            // 
            // textBoxEname
            // 
            this.textBoxEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEname.Location = new System.Drawing.Point(246, 141);
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(310, 32);
            this.textBoxEname.TabIndex = 2;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJob.Location = new System.Drawing.Point(246, 215);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(310, 32);
            this.textBoxJob.TabIndex = 4;
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.Location = new System.Drawing.Point(34, 215);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(56, 29);
            this.labelJob.TabIndex = 3;
            this.labelJob.Text = "Job";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(35, 287);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(86, 29);
            this.labelSalary.TabIndex = 5;
            this.labelSalary.Text = "Salary";
            // 
            // textBoxDname
            // 
            this.textBoxDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDname.Location = new System.Drawing.Point(246, 357);
            this.textBoxDname.Name = "textBoxDname";
            this.textBoxDname.Size = new System.Drawing.Size(310, 32);
            this.textBoxDname.TabIndex = 8;
            // 
            // labelDname
            // 
            this.labelDname.AutoSize = true;
            this.labelDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDname.Location = new System.Drawing.Point(34, 357);
            this.labelDname.Name = "labelDname";
            this.labelDname.Size = new System.Drawing.Size(95, 29);
            this.labelDname.TabIndex = 7;
            this.labelDname.Text = "Dname";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(26, 418);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 44);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(222, 418);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 44);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(435, 418);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 44);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxEno
            // 
            this.textBoxEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEno.Location = new System.Drawing.Point(246, 70);
            this.textBoxEno.Name = "textBoxEno";
            this.textBoxEno.Size = new System.Drawing.Size(310, 32);
            this.textBoxEno.TabIndex = 13;
            // 
            // labelEno
            // 
            this.labelEno.AutoSize = true;
            this.labelEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEno.Location = new System.Drawing.Point(43, 70);
            this.labelEno.Name = "labelEno";
            this.labelEno.Size = new System.Drawing.Size(59, 29);
            this.labelEno.TabIndex = 12;
            this.labelEno.Text = "Eno";
            // 
            // labelSalaryValidation
            // 
            this.labelSalaryValidation.AutoSize = true;
            this.labelSalaryValidation.BackColor = System.Drawing.SystemColors.Control;
            this.labelSalaryValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryValidation.ForeColor = System.Drawing.Color.Red;
            this.labelSalaryValidation.Location = new System.Drawing.Point(246, 326);
            this.labelSalaryValidation.Name = "labelSalaryValidation";
            this.labelSalaryValidation.Size = new System.Drawing.Size(0, 18);
            this.labelSalaryValidation.TabIndex = 14;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSalary.Location = new System.Drawing.Point(249, 287);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownSalary.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(310, 32);
            this.numericUpDownSalary.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 484);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.labelSalaryValidation);
            this.Controls.Add(this.textBoxEno);
            this.Controls.Add(this.labelEno);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDname);
            this.Controls.Add(this.labelDname);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.textBoxEname);
            this.Controls.Add(this.labelEname);
            this.Controls.Add(this.labelEmployeeDetails);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeDetails;
        private System.Windows.Forms.Label labelEname;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDname;
        private System.Windows.Forms.Button buttonClose;
        internal System.Windows.Forms.TextBox textBoxEname;
        internal System.Windows.Forms.TextBox textBoxJob;
        internal System.Windows.Forms.TextBox textBoxDname;
        internal System.Windows.Forms.TextBox textBoxEno;
        internal System.Windows.Forms.Label labelEno;
        private System.Windows.Forms.Label labelSalaryValidation;
        internal System.Windows.Forms.NumericUpDown numericUpDownSalary;
        internal System.Windows.Forms.Button buttonSave;
        internal System.Windows.Forms.Button buttonClear;
    }
}