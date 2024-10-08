namespace practical_exam_last_year
{
    partial class AddEmployeeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAllowanceRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseTransf = new System.Windows.Forms.CheckBox();
            this.cbDonotUse = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation/Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(216, 117);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(312, 22);
            this.txtPosition.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Basic Salary";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(216, 175);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(312, 22);
            this.txtBasicSalary.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Allowance Rate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAllowanceRate
            // 
            this.txtAllowanceRate.Location = new System.Drawing.Point(216, 290);
            this.txtAllowanceRate.Name = "txtAllowanceRate";
            this.txtAllowanceRate.Size = new System.Drawing.Size(312, 22);
            this.txtAllowanceRate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Staff Transport";
            // 
            // cbUseTransf
            // 
            this.cbUseTransf.AutoSize = true;
            this.cbUseTransf.Location = new System.Drawing.Point(216, 232);
            this.cbUseTransf.Name = "cbUseTransf";
            this.cbUseTransf.Size = new System.Drawing.Size(51, 20);
            this.cbUseTransf.TabIndex = 9;
            this.cbUseTransf.Text = "use";
            this.cbUseTransf.UseVisualStyleBackColor = true;
            // 
            // cbDonotUse
            // 
            this.cbDonotUse.AutoSize = true;
            this.cbDonotUse.Location = new System.Drawing.Point(433, 232);
            this.cbDonotUse.Name = "cbDonotUse";
            this.cbDonotUse.Size = new System.Drawing.Size(96, 20);
            this.cbDonotUse.TabIndex = 10;
            this.cbDonotUse.Text = "Do not Use";
            this.cbDonotUse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back to Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDonotUse);
            this.Controls.Add(this.cbUseTransf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAllowanceRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAllowanceRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbUseTransf;
        private System.Windows.Forms.CheckBox cbDonotUse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}