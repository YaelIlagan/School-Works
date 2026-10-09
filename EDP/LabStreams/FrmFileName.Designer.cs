namespace LabStreams
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            label1 = new Label();
            btnSetFileName = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(12, 48);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(244, 29);
            txtFileName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter File Name:";
            // 
            // btnSetFileName
            // 
            btnSetFileName.BackColor = Color.DodgerBlue;
            btnSetFileName.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSetFileName.FlatStyle = FlatStyle.Flat;
            btnSetFileName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetFileName.ForeColor = Color.White;
            btnSetFileName.Location = new Point(80, 87);
            btnSetFileName.Name = "btnSetFileName";
            btnSetFileName.Size = new Size(109, 29);
            btnSetFileName.TabIndex = 2;
            btnSetFileName.Text = "Okay";
            btnSetFileName.UseVisualStyleBackColor = false;
            btnSetFileName.Click += btnSetFileName_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 140);
            Controls.Add(btnSetFileName);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Label label1;
        private Button btnSetFileName;
    }
}