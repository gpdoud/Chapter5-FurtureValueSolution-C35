namespace FurtureValueProject {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(194, 29);
            this.txtMonthlyInvestment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(114, 27);
            this.txtMonthlyInvestment.TabIndex = 4;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(194, 80);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(114, 27);
            this.txtInterestRate.TabIndex = 5;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(194, 131);
            this.txtYears.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(114, 27);
            this.txtYears.TabIndex = 6;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(194, 181);
            this.txtFutureValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(114, 27);
            this.txtFutureValue.TabIndex = 7;
            this.txtFutureValue.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 256);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(85, 256);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 31);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(351, 323);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
    }
}
