namespace Achievement_Management_System.USER
{
    partial class User
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
            this.btnSign_In = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdentity = new System.Windows.Forms.ComboBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSign_In
            // 
            this.btnSign_In.Location = new System.Drawing.Point(66, 213);
            this.btnSign_In.Name = "btnSign_In";
            this.btnSign_In.Size = new System.Drawing.Size(75, 23);
            this.btnSign_In.TabIndex = 0;
            this.btnSign_In.Text = "登录";
            this.btnSign_In.UseVisualStyleBackColor = true;
            this.btnSign_In.Click += new System.EventHandler(this.btnSign_In_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(128, 276);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(199, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 21);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(86, 69);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(163, 21);
            this.txtPassWord.TabIndex = 4;
            this.txtPassWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "职位：";
            // 
            // cmbIdentity
            // 
            this.cmbIdentity.FormattingEnabled = true;
            this.cmbIdentity.Items.AddRange(new object[] {
            "老师",
            "学生"});
            this.cmbIdentity.Location = new System.Drawing.Point(85, 112);
            this.cmbIdentity.Name = "cmbIdentity";
            this.cmbIdentity.Size = new System.Drawing.Size(163, 20);
            this.cmbIdentity.TabIndex = 8;
            this.cmbIdentity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.ForeColor = System.Drawing.Color.Red;
            this.lblPrompt.Location = new System.Drawing.Point(109, 252);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(125, 12);
            this.lblPrompt.TabIndex = 9;
            this.lblPrompt.Text = "还没有账号？请先注册";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdentity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 163);
            this.panel1.TabIndex = 11;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSign_In);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                              用户登录";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSign_In;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdentity;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Panel panel1;
    }
}