namespace LINQ_To_SQL_Part3
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
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxDname = new System.Windows.Forms.TextBox();
            this.labelDname = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxEno = new System.Windows.Forms.TextBox();
            this.labelEno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmployeeDetails
            // 
            this.labelEmployeeDetails.AutoSize = true;
            this.labelEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeDetails.Location = new System.Drawing.Point(153, 25);
            this.labelEmployeeDetails.Name = "labelEmployeeDetails";
            this.labelEmployeeDetails.Size = new System.Drawing.Size(260, 36);
            this.labelEmployeeDetails.TabIndex = 0;
            this.labelEmployeeDetails.Text = "Employee Details";
            // 
            // labelEname
            // 
            this.labelEname.AutoSize = true;
            this.labelEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEname.Location = new System.Drawing.Point(35, 144);
            this.labelEname.Name = "labelEname";
            this.labelEname.Size = new System.Drawing.Size(94, 29);
            this.labelEname.TabIndex = 1;
            this.labelEname.Text = "Ename";
            // 
            // textBoxEname
            // 
            this.textBoxEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEname.Location = new System.Drawing.Point(258, 141);
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(258, 32);
            this.textBoxEname.TabIndex = 2;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJob.Location = new System.Drawing.Point(258, 194);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(258, 32);
            this.textBoxJob.TabIndex = 4;
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.Location = new System.Drawing.Point(35, 194);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(56, 29);
            this.labelJob.TabIndex = 3;
            this.labelJob.Text = "Job";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(258, 247);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(258, 32);
            this.textBoxSalary.TabIndex = 6;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(35, 250);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(86, 29);
            this.labelSalary.TabIndex = 5;
            this.labelSalary.Text = "Salary";
            // 
            // textBoxDname
            // 
            this.textBoxDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDname.Location = new System.Drawing.Point(258, 301);
            this.textBoxDname.Name = "textBoxDname";
            this.textBoxDname.Size = new System.Drawing.Size(258, 32);
            this.textBoxDname.TabIndex = 8;
            // 
            // labelDname
            // 
            this.labelDname.AutoSize = true;
            this.labelDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDname.Location = new System.Drawing.Point(35, 304);
            this.labelDname.Name = "labelDname";
            this.labelDname.Size = new System.Drawing.Size(95, 29);
            this.labelDname.TabIndex = 7;
            this.labelDname.Text = "Dname";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(38, 360);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(121, 44);
            this.buttonPrev.TabIndex = 9;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(223, 360);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(121, 44);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(415, 360);
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
            this.textBoxEno.Location = new System.Drawing.Point(258, 88);
            this.textBoxEno.Name = "textBoxEno";
            this.textBoxEno.Size = new System.Drawing.Size(258, 32);
            this.textBoxEno.TabIndex = 13;
            // 
            // labelEno
            // 
            this.labelEno.AutoSize = true;
            this.labelEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEno.Location = new System.Drawing.Point(35, 91);
            this.labelEno.Name = "labelEno";
            this.labelEno.Size = new System.Drawing.Size(59, 29);
            this.labelEno.TabIndex = 12;
            this.labelEno.Text = "Eno";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 416);
            this.Controls.Add(this.textBoxEno);
            this.Controls.Add(this.labelEno);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.textBoxDname);
            this.Controls.Add(this.labelDname);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.textBoxEname);
            this.Controls.Add(this.labelEname);
            this.Controls.Add(this.labelEmployeeDetails);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ActiveControl = textBoxEno;

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeDetails;
        private System.Windows.Forms.Label labelEname;
        private System.Windows.Forms.TextBox textBoxEname;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxDname;
        private System.Windows.Forms.Label labelDname;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxEno;
        private System.Windows.Forms.Label labelEno;
    }
}