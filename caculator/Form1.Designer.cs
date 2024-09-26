namespace caculator
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 62);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 0;
            label1.Text = "Số a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 175);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 1;
            label2.Text = "Số b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 282);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(213, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 39);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(213, 168);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 39);
            txtB.TabIndex = 4;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(213, 282);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(200, 39);
            txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(263, 380);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(150, 46);
            btnCong.TabIndex = 6;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 482);
            Controls.Add(btnCong);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
    }
}
