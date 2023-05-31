namespace Achievement_Management_System
{
    partial class Main_page
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学院管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Now_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.学院管理ToolStripMenuItem,
            this.专业管理ToolStripMenuItem,
            this.班级管理ToolStripMenuItem,
            this.个人信息管理ToolStripMenuItem,
            this.关于系统ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户登录ToolStripMenuItem.Text = "用户登录";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 学院管理ToolStripMenuItem
            // 
            this.学院管理ToolStripMenuItem.Name = "学院管理ToolStripMenuItem";
            this.学院管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学院管理ToolStripMenuItem.Text = "学院管理";
            // 
            // 专业管理ToolStripMenuItem
            // 
            this.专业管理ToolStripMenuItem.Name = "专业管理ToolStripMenuItem";
            this.专业管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.专业管理ToolStripMenuItem.Text = "专业管理";
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.个人信息管理ToolStripMenuItem.Text = "个人信息管理";
            // 
            // 关于系统ToolStripMenuItem
            // 
            this.关于系统ToolStripMenuItem.Name = "关于系统ToolStripMenuItem";
            this.关于系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于系统ToolStripMenuItem.Text = "关于系统";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Now_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Now_Time
            // 
            this.Now_Time.Name = "Now_Time";
            this.Now_Time.Size = new System.Drawing.Size(131, 17);
            this.Now_Time.Text = "toolStripStatusLabel1";
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 606);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                                                 " +
    "                                    成绩管理系统主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学院管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Now_Time;
    }
}

