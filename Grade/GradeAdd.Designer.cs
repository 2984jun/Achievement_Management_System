namespace Achievement_Management_System.Grade
{
    partial class GradeAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGaeID = new System.Windows.Forms.TextBox();
            this.txtSdtID = new System.Windows.Forms.TextBox();
            this.txtSdtName = new System.Windows.Forms.TextBox();
            this.txtCueID = new System.Windows.Forms.TextBox();
            this.txtCueGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "成绩ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "学生学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "学生姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "课程ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "课程成绩：";
            // 
            // txtGaeID
            // 
            this.txtGaeID.Location = new System.Drawing.Point(138, 71);
            this.txtGaeID.Name = "txtGaeID";
            this.txtGaeID.Size = new System.Drawing.Size(102, 21);
            this.txtGaeID.TabIndex = 7;
            // 
            // txtSdtID
            // 
            this.txtSdtID.Location = new System.Drawing.Point(136, 107);
            this.txtSdtID.Name = "txtSdtID";
            this.txtSdtID.Size = new System.Drawing.Size(104, 21);
            this.txtSdtID.TabIndex = 8;
            // 
            // txtSdtName
            // 
            this.txtSdtName.Location = new System.Drawing.Point(136, 146);
            this.txtSdtName.Name = "txtSdtName";
            this.txtSdtName.Size = new System.Drawing.Size(104, 21);
            this.txtSdtName.TabIndex = 9;
            // 
            // txtCueID
            // 
            this.txtCueID.Location = new System.Drawing.Point(138, 36);
            this.txtCueID.Name = "txtCueID";
            this.txtCueID.Size = new System.Drawing.Size(102, 21);
            this.txtCueID.TabIndex = 10;
            // 
            // txtCueGrade
            // 
            this.txtCueGrade.Location = new System.Drawing.Point(136, 182);
            this.txtCueGrade.Name = "txtCueGrade";
            this.txtCueGrade.Size = new System.Drawing.Size(104, 21);
            this.txtCueGrade.TabIndex = 11;
            // 
            // GradeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 292);
            this.Controls.Add(this.txtCueGrade);
            this.Controls.Add(this.txtCueID);
            this.Controls.Add(this.txtSdtName);
            this.Controls.Add(this.txtSdtID);
            this.Controls.Add(this.txtGaeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GradeAdd";
            this.Text = "                     添加学生成绩";
            this.Load += new System.EventHandler(this.GradeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGaeID;
        private System.Windows.Forms.TextBox txtSdtID;
        private System.Windows.Forms.TextBox txtSdtName;
        private System.Windows.Forms.TextBox txtCueID;
        private System.Windows.Forms.TextBox txtCueGrade;
    }
}