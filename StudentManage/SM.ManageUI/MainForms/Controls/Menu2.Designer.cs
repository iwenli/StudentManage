namespace SM.ManageUI.Controls
{
    partial class Menu2
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qqButton1 = new ControlExs.QQButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.qqButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 529);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // qqButton1
            // 
            this.qqButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.qqButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqButton1.Location = new System.Drawing.Point(124, 72);
            this.qqButton1.Name = "qqButton1";
            this.qqButton1.Size = new System.Drawing.Size(159, 75);
            this.qqButton1.TabIndex = 0;
            this.qqButton1.Text = "学生信息";
            this.qqButton1.UseVisualStyleBackColor = false;
            // 
            // Menu2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu2";
            this.Size = new System.Drawing.Size(978, 529);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ControlExs.QQButton qqButton1;


    }
}
