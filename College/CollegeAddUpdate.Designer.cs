namespace Achievement_Management_System.College
{
    partial class CollegeAddUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCleID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学院编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学院名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "学院人数：";
            // 
            // txtCollegeId
            // 
            this.txtCollegeId.Location = new System.Drawing.Point(111, 25);
            this.txtCollegeId.Name = "txtCollegeId";
            this.txtCollegeId.Size = new System.Drawing.Size(137, 21);
            this.txtCollegeId.TabIndex = 4;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(111, 63);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(137, 21);
            this.txtCollegeName.TabIndex = 5;
            // 
            // txtMajorNumber
            // 
            this.txtMajorNumber.Location = new System.Drawing.Point(111, 97);
            this.txtMajorNumber.Name = "txtMajorNumber";
            this.txtMajorNumber.Size = new System.Drawing.Size(137, 21);
            this.txtMajorNumber.TabIndex = 6;
            // 
            // txtClePpleTotle
            // 
            this.txtClePpleTotle.Location = new System.Drawing.Point(111, 134);
            this.txtClePpleTotle.Name = "txtClePpleTotle";
            this.txtClePpleTotle.Size = new System.Drawing.Size(137, 21);
            this.txtClePpleTotle.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(81, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(224, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出(&E)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDean
            // 
            this.txtDean.Location = new System.Drawing.Point(111, 173);
            this.txtDean.Name = "txtDean";
            this.txtDean.Size = new System.Drawing.Size(137, 21);
            this.txtDean.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "院长：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCleID);
            this.panel1.Controls.Add(this.txtMajorNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDean);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtClePpleTotle);
            this.panel1.Controls.Add(this.txtCollegeId);
            this.panel1.Controls.Add(this.txtCollegeName);
            this.panel1.Location = new System.Drawing.Point(50, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 217);
            this.panel1.TabIndex = 12;
            // 
            // lblCleID
            // 
            this.lblCleID.AutoSize = true;
            this.lblCleID.Location = new System.Drawing.Point(112, 28);
            this.lblCleID.Name = "lblCleID";
            this.lblCleID.Size = new System.Drawing.Size(17, 12);
            this.lblCleID.TabIndex = 12;
            this.lblCleID.Text = "ID";
            // 
            // CollegeAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Name = "CollegeAddUpdate";
            this.Text = "                                   添加学院信息";
            this.Load += new System.EventHandler(this.CollegeAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCollegeId;
        public System.Windows.Forms.TextBox txtCollegeName;
        public System.Windows.Forms.TextBox txtMajorNumber;
        public System.Windows.Forms.TextBox txtClePpleTotle;
        public System.Windows.Forms.TextBox txtDean;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblCleID;
    }
}