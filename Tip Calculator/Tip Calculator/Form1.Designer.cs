namespace Tip_Calculator
{
    partial class tipCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peopleErrorLabel = new System.Windows.Forms.Label();
            this.tipErrorLabel = new System.Windows.Forms.Label();
            this.billErrorLabel = new System.Windows.Forms.Label();
            this.billAmtTextBox = new System.Windows.Forms.TextBox();
            this.tipPercentLabel = new System.Windows.Forms.Label();
            this.tipIncButton = new System.Windows.Forms.Button();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.billAmtLabel = new System.Windows.Forms.Label();
            this.peopleDecButton = new System.Windows.Forms.Button();
            this.peopleIncButton = new System.Windows.Forms.Button();
            this.tipDecButton = new System.Windows.Forms.Button();
            this.tipPercentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipCalcLabel = new System.Windows.Forms.Label();
            this.totalCalcLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.peopleErrorLabel);
            this.groupBox1.Controls.Add(this.tipErrorLabel);
            this.groupBox1.Controls.Add(this.billErrorLabel);
            this.groupBox1.Controls.Add(this.billAmtTextBox);
            this.groupBox1.Controls.Add(this.tipPercentLabel);
            this.groupBox1.Controls.Add(this.tipIncButton);
            this.groupBox1.Controls.Add(this.peopleTextBox);
            this.groupBox1.Controls.Add(this.peopleLabel);
            this.groupBox1.Controls.Add(this.billAmtLabel);
            this.groupBox1.Controls.Add(this.peopleDecButton);
            this.groupBox1.Controls.Add(this.peopleIncButton);
            this.groupBox1.Controls.Add(this.tipDecButton);
            this.groupBox1.Controls.Add(this.tipPercentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // peopleErrorLabel
            // 
            this.peopleErrorLabel.AutoSize = true;
            this.peopleErrorLabel.ForeColor = System.Drawing.Color.Orange;
            this.peopleErrorLabel.Location = new System.Drawing.Point(75, 344);
            this.peopleErrorLabel.Name = "peopleErrorLabel";
            this.peopleErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.peopleErrorLabel.TabIndex = 22;
            // 
            // tipErrorLabel
            // 
            this.tipErrorLabel.AutoSize = true;
            this.tipErrorLabel.ForeColor = System.Drawing.Color.Orange;
            this.tipErrorLabel.Location = new System.Drawing.Point(76, 222);
            this.tipErrorLabel.Name = "tipErrorLabel";
            this.tipErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.tipErrorLabel.TabIndex = 21;
            // 
            // billErrorLabel
            // 
            this.billErrorLabel.AutoSize = true;
            this.billErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.billErrorLabel.Location = new System.Drawing.Point(73, 106);
            this.billErrorLabel.Name = "billErrorLabel";
            this.billErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.billErrorLabel.TabIndex = 20;
            // 
            // billAmtTextBox
            // 
            this.billAmtTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billAmtTextBox.Location = new System.Drawing.Point(73, 60);
            this.billAmtTextBox.Name = "billAmtTextBox";
            this.billAmtTextBox.PlaceholderText = "0.00";
            this.billAmtTextBox.Size = new System.Drawing.Size(189, 34);
            this.billAmtTextBox.TabIndex = 16;
            this.billAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billAmtTextBox.TextChanged += new System.EventHandler(this.billAmtTextBox_TextChanged);
            // 
            // tipPercentLabel
            // 
            this.tipPercentLabel.AutoSize = true;
            this.tipPercentLabel.Location = new System.Drawing.Point(73, 155);
            this.tipPercentLabel.Name = "tipPercentLabel";
            this.tipPercentLabel.Size = new System.Drawing.Size(106, 15);
            this.tipPercentLabel.TabIndex = 15;
            this.tipPercentLabel.Text = "Tip Percentage (%)";
            // 
            // tipIncButton
            // 
            this.tipIncButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipIncButton.Location = new System.Drawing.Point(262, 173);
            this.tipIncButton.Name = "tipIncButton";
            this.tipIncButton.Size = new System.Drawing.Size(53, 40);
            this.tipIncButton.TabIndex = 14;
            this.tipIncButton.Text = "+";
            this.tipIncButton.UseVisualStyleBackColor = true;
            this.tipIncButton.Click += new System.EventHandler(this.tipIncButton_Click);
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.Enabled = false;
            this.peopleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peopleTextBox.Location = new System.Drawing.Point(73, 296);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.Size = new System.Drawing.Size(189, 34);
            this.peopleTextBox.TabIndex = 13;
            this.peopleTextBox.Text = "1";
            this.peopleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(73, 275);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(76, 15);
            this.peopleLabel.TabIndex = 12;
            this.peopleLabel.Text = "No of People";
            // 
            // billAmtLabel
            // 
            this.billAmtLabel.AutoSize = true;
            this.billAmtLabel.Location = new System.Drawing.Point(73, 41);
            this.billAmtLabel.Name = "billAmtLabel";
            this.billAmtLabel.Size = new System.Drawing.Size(70, 15);
            this.billAmtLabel.TabIndex = 2;
            this.billAmtLabel.Text = "Bill Amount";
            // 
            // peopleDecButton
            // 
            this.peopleDecButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peopleDecButton.Location = new System.Drawing.Point(20, 293);
            this.peopleDecButton.Name = "peopleDecButton";
            this.peopleDecButton.Size = new System.Drawing.Size(53, 40);
            this.peopleDecButton.TabIndex = 10;
            this.peopleDecButton.Text = "-";
            this.peopleDecButton.UseVisualStyleBackColor = true;
            this.peopleDecButton.Click += new System.EventHandler(this.peopleDecButton_Click);
            // 
            // peopleIncButton
            // 
            this.peopleIncButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peopleIncButton.Location = new System.Drawing.Point(262, 293);
            this.peopleIncButton.Name = "peopleIncButton";
            this.peopleIncButton.Size = new System.Drawing.Size(53, 40);
            this.peopleIncButton.TabIndex = 9;
            this.peopleIncButton.Text = "+";
            this.peopleIncButton.UseVisualStyleBackColor = true;
            this.peopleIncButton.Click += new System.EventHandler(this.peopleIncButton_Click);
            // 
            // tipDecButton
            // 
            this.tipDecButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipDecButton.Location = new System.Drawing.Point(20, 173);
            this.tipDecButton.Name = "tipDecButton";
            this.tipDecButton.Size = new System.Drawing.Size(53, 40);
            this.tipDecButton.TabIndex = 8;
            this.tipDecButton.Text = "-";
            this.tipDecButton.UseVisualStyleBackColor = true;
            this.tipDecButton.Click += new System.EventHandler(this.tipDecButton_Click);
            // 
            // tipPercentTextBox
            // 
            this.tipPercentTextBox.Enabled = false;
            this.tipPercentTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipPercentTextBox.Location = new System.Drawing.Point(73, 176);
            this.tipPercentTextBox.Name = "tipPercentTextBox";
            this.tipPercentTextBox.Size = new System.Drawing.Size(189, 34);
            this.tipPercentTextBox.TabIndex = 6;
            this.tipPercentTextBox.Text = "10";
            this.tipPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(428, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Per Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Per Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(414, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 41);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // tipCalcLabel
            // 
            this.tipCalcLabel.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipCalcLabel.Location = new System.Drawing.Point(560, 82);
            this.tipCalcLabel.Name = "tipCalcLabel";
            this.tipCalcLabel.Size = new System.Drawing.Size(215, 46);
            this.tipCalcLabel.TabIndex = 18;
            // 
            // totalCalcLabel
            // 
            this.totalCalcLabel.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCalcLabel.Location = new System.Drawing.Point(560, 245);
            this.totalCalcLabel.Name = "totalCalcLabel";
            this.totalCalcLabel.Size = new System.Drawing.Size(215, 46);
            this.totalCalcLabel.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 377);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(153, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "$";
            // 
            // tipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.totalCalcLabel);
            this.Controls.Add(this.tipCalcLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "tipCalculator";
            this.Text = "Tip Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Button tipDecButton;
        private TextBox tipPercentTextBox;
        private Button peopleDecButton;
        private Button peopleIncButton;
        private Label peopleLabel;
        private Label billAmtLabel;
        private TextBox peopleTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label tipCalcLabel;
        private Label totalCalcLabel;
        private Label tipPercentLabel;
        private Button tipIncButton;
        private GroupBox groupBox2;
        private TextBox billAmtTextBox;
        private Label billErrorLabel;
        private Label peopleErrorLabel;
        private Label tipErrorLabel;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}