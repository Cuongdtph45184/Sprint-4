namespace DuAn
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
            btnDangnhap = new Button();
            lkbQuenMK = new LinkLabel();
            lkbDangKy = new LinkLabel();
            txtpassword = new TextBox();
            txtname = new TextBox();
            lbpassword = new Label();
            lbname = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ControlLight;
            btnDangnhap.Location = new Point(293, 197);
            btnDangnhap.Margin = new Padding(3, 2, 3, 2);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(92, 41);
            btnDangnhap.TabIndex = 17;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click_1;
            // 
            // lkbQuenMK
            // 
            lkbQuenMK.AutoSize = true;
            lkbQuenMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lkbQuenMK.Location = new Point(173, 151);
            lkbQuenMK.Name = "lkbQuenMK";
            lkbQuenMK.Size = new Size(125, 21);
            lkbQuenMK.TabIndex = 15;
            lkbQuenMK.TabStop = true;
            lkbQuenMK.Text = "Quên Mật Khẩu?";
            // 
            // lkbDangKy
            // 
            lkbDangKy.AutoSize = true;
            lkbDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lkbDangKy.Location = new Point(332, 151);
            lkbDangKy.Name = "lkbDangKy";
            lkbDangKy.Size = new Size(67, 21);
            lkbDangKy.TabIndex = 16;
            lkbDangKy.TabStop = true;
            lkbDangKy.Text = "Đăng Ký";
            lkbDangKy.LinkClicked += lkbDangKy_LinkClicked_1;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(208, 93);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(288, 27);
            txtpassword.TabIndex = 13;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(208, 32);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Name = "txtname";
            txtname.Size = new Size(288, 27);
            txtname.TabIndex = 14;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbpassword.Location = new Point(66, 95);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(79, 21);
            lbpassword.TabIndex = 11;
            lbpassword.Text = "Password";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbname.Location = new Point(66, 35);
            lbname.Name = "lbname";
            lbname.Size = new Size(86, 21);
            lbname.TabIndex = 12;
            lbname.Text = "UserName";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(426, 155);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(checkBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(lkbQuenMK);
            Controls.Add(lkbDangKy);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(lbpassword);
            Controls.Add(lbname);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangnhap;
        private LinkLabel lkbQuenMK;
        private LinkLabel lkbDangKy;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label lbpassword;
        private Label lbname;
        private CheckBox checkBox1;
    }
}