namespace Achievement_Management_System.Course
{
    partial class CourseAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtCueNum = new System.Windows.Forms.TextBox();
            this.txtCueName = new System.Windows.Forms.TextBox();
            this.txtCueID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "授课老师：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "选课人数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "课程名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "课程ID：";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(102, 140);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(120, 21);
            this.txtTeacher.TabIndex = 15;
            // 
            // txtCueNum
            // 
            this.txtCueNum.Location = new System.Drawing.Point(102, 99);
            this.txtCueNum.Name = "txtCueNum";
            this.txtCueNum.Size = new System.Drawing.Size(120, 21);
            this.txtCueNum.TabIndex = 14;
            // 
            // txtCueName
            // 
            this.txtCueName.Location = new System.Drawing.Point(102, 57);
            this.txtCueName.Name = "txtCueName";
            this.txtCueName.Size = new System.Drawing.Size(120, 21);
            this.txtCueName.TabIndex = 13;
            // 
            // txtCueID
            // 
            this.txtCueID.Location = new System.Drawing.Point(102, 17);
            this.txtCueID.Name = "txtCueID";
            this.txtCueID.Size = new System.Drawing.Size(120, 21);
            this.txtCueID.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(43, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCueName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCueID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCueNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTeacher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 181);
            this.panel1.TabIndex = 20;
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Name = "CourseAdd";
            this.Text = "                           添加课程信息";
            this.Load += new System.EventHandler(this.CourseAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtTeacher;
        public System.Windows.Forms.TextBox txtCueNum;
        public System.Windows.Forms.TextBox txtCueName;
        public System.Windows.Forms.TextBox txtCueID;
    }
}