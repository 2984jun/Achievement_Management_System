namespace Achievement_Management_System.College
{
    partial class CollegeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCollegeId = new System.Windows.Forms.TextBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.txtMajorNumber = new System.Windows.Forms.TextBox();
            this.txtClePpleTotle = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDean = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学院ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学院名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "学院人数：";
            // 
            // txtCollegeId
            // 
            this.txtCollegeId.Location = new System.Drawing.Point(167, 36);
            this.txtCollegeId.Name = "txtCollegeId";
            this.txtCollegeId.Size = new System.Drawing.Size(137, 21);
            this.txtCollegeId.TabIndex = 4;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(167, 74);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(137, 21);
            this.txtCollegeName.TabIndex = 5;
            // 
            // txtMajorNumber
            // 
            this.txtMajorNumber.Location = new System.Drawing.Point(167, 108);
            this.txtMajorNumber.Name = "txtMajorNumber";
            this.txtMajorNumber.Size = new System.Drawing.Size(137, 21);
            this.txtMajorNumber.TabIndex = 6;
            // 
            // txtClePpleTotle
            // 
            this.txtClePpleTotle.Location = new System.Drawing.Point(167, 145);
            this.txtClePpleTotle.Name = "txtClePpleTotle";
            this.txtClePpleTotle.Size = new System.Drawing.Size(137, 21);
            this.txtClePpleTotle.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(86, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(229, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDean
            // 
            this.txtDean.Location = new System.Drawing.Point(167, 184);
            this.txtDean.Name = "txtDean";
            this.txtDean.Size = new System.Drawing.Size(137, 21);
            this.txtDean.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "院长：";
            // 
            // CollegeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDean);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtClePpleTotle);
            this.Controls.Add(this.txtMajorNumber);
            this.Controls.Add(this.txtCollegeName);
            this.Controls.Add(this.txtCollegeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CollegeAdd";
            this.Text = "                                   添加学院信息";
            this.Load += new System.EventHandler(this.CollegeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCollegeId;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.TextBox txtMajorNumber;
        private System.Windows.Forms.TextBox txtClePpleTotle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDean;
        private System.Windows.Forms.Label label5;
    }
}