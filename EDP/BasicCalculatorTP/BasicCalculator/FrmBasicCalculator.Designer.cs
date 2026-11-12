namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            panel1 = new Panel();
            txtnum2 = new TextBox();
            cbOperator = new ComboBox();
            txtnum1 = new TextBox();
            btnCompute = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 209, 247);
            panel1.Controls.Add(txtnum2);
            panel1.Controls.Add(cbOperator);
            panel1.Controls.Add(txtnum1);
            panel1.Location = new Point(8, 151);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(318, 116);
            panel1.TabIndex = 0;
            // 
            // txtnum2
            // 
            txtnum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnum2.Location = new Point(8, 78);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(302, 29);
            txtnum2.TabIndex = 3;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(8, 43);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(302, 29);
            cbOperator.TabIndex = 2;
            // 
            // txtnum1
            // 
            txtnum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnum1.Location = new Point(8, 8);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(302, 29);
            txtnum1.TabIndex = 1;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.DodgerBlue;
            btnCompute.FlatAppearance.BorderSize = 0;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.ForeColor = Color.White;
            btnCompute.Location = new Point(8, 277);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(318, 34);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(175, 30);
            label2.TabIndex = 5;
            label2.Text = "Basic Calculator";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(8, 36);
            label3.Name = "label3";
            label3.Size = new Size(318, 1);
            label3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(218, 233, 252);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 45);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(318, 100);
            panel2.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("AMORIA", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(0, 26);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(255, 69);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "00000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 319);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCompute);
            Controls.Add(panel1);
            Name = "FrmBasicCalculator";
            Padding = new Padding(5);
            Text = "Calculator";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtnum1;
        private ComboBox cbOperator;
        private Button btnCompute;
        private Label label2;
        private Label label3;
        private TextBox txtnum2;
        private Panel panel2;
        private Label label1;
        private Label lblTotal;
    }
}
