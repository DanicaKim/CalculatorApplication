namespace CalculatorApplication
{
    partial class FrmCalculator
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
            btnEqual = new Button();
            txtBoxInput2 = new TextBox();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(199, 176);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(115, 31);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(193, 100);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(132, 26);
            txtBoxInput2.TabIndex = 14;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(194, 33);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(132, 26);
            txtBoxInput1.TabIndex = 13;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(199, 65);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 12;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(194, 136);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(46, 21);
            lblDisplayTotal.TabIndex = 11;
            lblDisplayTotal.Text = "0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(122, 136);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 10;
            label3.Text = "Answer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 9;
            label2.Text = "Enter second number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 8;
            label1.Text = "Enter first number:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 251);
            Controls.Add(btnEqual);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(cbOperator);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEqual;
        private TextBox txtBoxInput2;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}