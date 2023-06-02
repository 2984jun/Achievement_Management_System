namespace Achievement_Management_System.Class
{
    partial class Change_Class_Information
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
            this.txtHeadTea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClsNum = new System.Windows.Forms.TextBox();
            this.txtMjrId = new System.Windows.Forms.TextBox();
            this.txtClsName = new System.Windows.Forms.TextBox();
            this.txtClsId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHeadTea
            // 
            this.txtHeadTea.Location = new System.Drawing.Point(147, 180);
            this.txtHeadTea.Name = "txtHeadTea";
            this.txtHeadTea.Size = new System.Drawing.Size(100, 21);
            this.txtHeadTea.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "班主任：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(66, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "班级人数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "专业ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "班级名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "班级ID：";
            // 
            // txtClsNum
            // 
            this.txtClsNum.Location = new System.Drawing.Point(149, 145);
            this.txtClsNum.Name = "txtClsNum";
            this.txtClsNum.Size = new System.Drawing.Size(98, 21);
            this.txtClsNum.TabIndex = 15;
            // 
            // txtMjrId
            // 
            this.txtMjrId.Location = new System.Drawing.Point(147, 111);
            this.txtMjrId.Name = "txtMjrId";
            this.txtMjrId.Size = new System.Drawing.Size(100, 21);
            this.txtMjrId.TabIndex = 14;
            // 
            // txtClsName
            // 
            this.txtClsName.Location = new System.Drawing.Point(147, 76);
            this.txtClsName.Name = "txtClsName";
            this.txtClsName.Size = new System.Drawing.Size(100, 21);
            this.txtClsName.TabIndex = 13;
            // 
            // txtClsId
            // 
            this.txtClsId.Location = new System.Drawing.Point(149, 38);
            this.txtClsId.Name = "txtClsId";
            this.txtClsId.Size = new System.Drawing.Size(100, 21);
            this.txtClsId.TabIndex = 12;
            // 
            // Change_Class_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 288);
            this.Controls.Add(this.txtHeadTea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClsNum);
            this.Controls.Add(this.txtMjrId);
            this.Controls.Add(this.txtClsName);
            this.Controls.Add(this.txtClsId);
            this.Name = "Change_Class_Information";
            this.Text = "                             修改班级信息";
            this.Load += new System.EventHandler(this.Change_Class_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeadTea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClsNum;
        private System.Windows.Forms.TextBox txtMjrId;
        private System.Windows.Forms.TextBox txtClsName;
        private System.Windows.Forms.TextBox txtClsId;
    }
}