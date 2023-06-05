namespace Achievement_Management_System.Class
{
    partial class ClassAddUpdate
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
            this.txtClsId = new System.Windows.Forms.TextBox();
            this.txtClsName = new System.Windows.Forms.TextBox();
            this.txtMjrId = new System.Windows.Forms.TextBox();
            this.txtClsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeadTea = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClsId
            // 
            this.txtClsId.Location = new System.Drawing.Point(114, 14);
            this.txtClsId.Name = "txtClsId";
            this.txtClsId.Size = new System.Drawing.Size(100, 21);
            this.txtClsId.TabIndex = 0;
            // 
            // txtClsName
            // 
            this.txtClsName.Location = new System.Drawing.Point(112, 52);
            this.txtClsName.Name = "txtClsName";
            this.txtClsName.Size = new System.Drawing.Size(100, 21);
            this.txtClsName.TabIndex = 1;
            // 
            // txtMjrId
            // 
            this.txtMjrId.Location = new System.Drawing.Point(112, 87);
            this.txtMjrId.Name = "txtMjrId";
            this.txtMjrId.Size = new System.Drawing.Size(100, 21);
            this.txtMjrId.TabIndex = 2;
            // 
            // txtClsNum
            // 
            this.txtClsNum.Location = new System.Drawing.Point(114, 121);
            this.txtClsNum.Name = "txtClsNum";
            this.txtClsNum.Size = new System.Drawing.Size(100, 21);
            this.txtClsNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "班级ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "班级名称：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "专业ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "班级人数：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(67, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "班主任：";
            // 
            // txtHeadTea
            // 
            this.txtHeadTea.Location = new System.Drawing.Point(112, 156);
            this.txtHeadTea.Name = "txtHeadTea";
            this.txtHeadTea.Size = new System.Drawing.Size(100, 21);
            this.txtHeadTea.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtMjrId);
            this.panel1.Controls.Add(this.txtHeadTea);
            this.panel1.Controls.Add(this.txtClsId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClsName);
            this.panel1.Controls.Add(this.txtClsNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 199);
            this.panel1.TabIndex = 12;
            // 
            // ClassAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Name = "ClassAddUpdate";
            this.Text = "                              添加班级";
            this.Load += new System.EventHandler(this.ClassAdd_Load);
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
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtClsId;
        public System.Windows.Forms.TextBox txtClsName;
        public System.Windows.Forms.TextBox txtMjrId;
        public System.Windows.Forms.TextBox txtClsNum;
        public System.Windows.Forms.TextBox txtHeadTea;
        public System.Windows.Forms.Button btnOK;
    }
}