namespace Achievement_Management_System.Grade
{
    partial class Change_Grade_Information
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
            this.txtCueGrade = new System.Windows.Forms.TextBox();
            this.txtCueName = new System.Windows.Forms.TextBox();
            this.txtSdtName = new System.Windows.Forms.TextBox();
            this.txtSdtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCueGrade
            // 
            this.txtCueGrade.Location = new System.Drawing.Point(129, 185);
            this.txtCueGrade.Name = "txtCueGrade";
            this.txtCueGrade.Size = new System.Drawing.Size(104, 21);
            this.txtCueGrade.TabIndex = 23;
            // 
            // txtCueName
            // 
            this.txtCueName.Location = new System.Drawing.Point(129, 74);
            this.txtCueName.Name = "txtCueName";
            this.txtCueName.Size = new System.Drawing.Size(102, 21);
            this.txtCueName.TabIndex = 22;
            // 
            // txtSdtName
            // 
            this.txtSdtName.Location = new System.Drawing.Point(129, 149);
            this.txtSdtName.Name = "txtSdtName";
            this.txtSdtName.Size = new System.Drawing.Size(104, 21);
            this.txtSdtName.TabIndex = 21;
            // 
            // txtSdtID
            // 
            this.txtSdtID.Location = new System.Drawing.Point(129, 110);
            this.txtSdtID.Name = "txtSdtID";
            this.txtSdtID.Size = new System.Drawing.Size(104, 21);
            this.txtSdtID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "课程成绩：";
            // 
            // lblcue
            // 
            this.lblcue.AutoSize = true;
            this.lblcue.Location = new System.Drawing.Point(58, 77);
            this.lblcue.Name = "lblcue";
            this.lblcue.Size = new System.Drawing.Size(65, 12);
            this.lblcue.TabIndex = 17;
            this.lblcue.Text = "课程名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "学生姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "学生学号：";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "编号：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(36, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 24;
            // 
            // Change_Grade_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 306);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCueGrade);
            this.Controls.Add(this.txtCueName);
            this.Controls.Add(this.txtSdtName);
            this.Controls.Add(this.txtSdtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Change_Grade_Information";
            this.Text = "                        修改学生成绩";
            this.Load += new System.EventHandler(this.Change_Grade_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCueGrade;
        private System.Windows.Forms.TextBox txtCueName;
        private System.Windows.Forms.TextBox txtSdtName;
        private System.Windows.Forms.TextBox txtSdtID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblcue;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label label5;
    }
}