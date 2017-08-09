namespace SM.ManageUI
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnSandeng = new CCWin.SkinControl.SkinButtom();
            this.btnDuoId = new CCWin.SkinControl.SkinButtom();
            this.btnDl = new CCWin.SkinControl.SkinButtom();
            this.chkZdLogin = new CCWin.SkinControl.SkinCheckBox();
            this.pnlId = new CCWin.SkinControl.SkinPanel();
            this.txtId = new CCWin.SkinControl.WaterTextBox();
            this.btnId = new CCWin.SkinControl.SkinButtom();
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkMima = new CCWin.SkinControl.SkinCheckBox();
            this.labLoading = new System.Windows.Forms.Label();
            this.prbLoading = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.comBoId = new CCWin.SkinControl.SkinComboBox();
            this.lblMsg = new CCWin.SkinControl.SkinLabel();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.pnlId.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSandeng
            // 
            this.btnSandeng.BackColor = System.Drawing.Color.Transparent;
            this.btnSandeng.BaseColor = System.Drawing.Color.Red;
            this.btnSandeng.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSandeng.DownBack = global::SM.ManageUI.Properties.Resources.btnSandeng_DownBack;
            this.btnSandeng.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSandeng.Location = new System.Drawing.Point(344, 256);
            this.btnSandeng.Margin = new System.Windows.Forms.Padding(0);
            this.btnSandeng.MouseBack = global::SM.ManageUI.Properties.Resources.btnSandeng_MouseBack;
            this.btnSandeng.Name = "btnSandeng";
            this.btnSandeng.NormlBack = global::SM.ManageUI.Properties.Resources.btnSandeng_NormlBack;
            this.btnSandeng.Size = new System.Drawing.Size(26, 27);
            this.btnSandeng.TabIndex = 7;
            this.btnSandeng.UseVisualStyleBackColor = false;
            this.btnSandeng.Click += new System.EventHandler(this.btnSandeng_Click);
            // 
            // btnDuoId
            // 
            this.btnDuoId.BackColor = System.Drawing.Color.Transparent;
            this.btnDuoId.BaseColor = System.Drawing.Color.Red;
            this.btnDuoId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDuoId.DownBack = global::SM.ManageUI.Properties.Resources.corner_back_press;
            this.btnDuoId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDuoId.Location = new System.Drawing.Point(1, 251);
            this.btnDuoId.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuoId.MouseBack = global::SM.ManageUI.Properties.Resources.corner_back_hover;
            this.btnDuoId.Name = "btnDuoId";
            this.btnDuoId.NormlBack = global::SM.ManageUI.Properties.Resources.corner_back;
            this.btnDuoId.Size = new System.Drawing.Size(40, 40);
            this.btnDuoId.TabIndex = 6;
            this.btnDuoId.UseVisualStyleBackColor = false;
            // 
            // btnDl
            // 
            this.btnDl.BackColor = System.Drawing.Color.Transparent;
            this.btnDl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDl.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnDl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDl.Create = true;
            this.btnDl.DownBack = global::SM.ManageUI.Properties.Resources.button_login_down;
            this.btnDl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDl.ForeColor = System.Drawing.Color.Black;
            this.btnDl.Location = new System.Drawing.Point(99, 244);
            this.btnDl.Margin = new System.Windows.Forms.Padding(0);
            this.btnDl.MouseBack = global::SM.ManageUI.Properties.Resources.button_login_hover;
            this.btnDl.Name = "btnDl";
            this.btnDl.NormlBack = global::SM.ManageUI.Properties.Resources.button_login_normal;
            this.btnDl.Palace = true;
            this.btnDl.Size = new System.Drawing.Size(185, 49);
            this.btnDl.TabIndex = 5;
            this.btnDl.Text = "登        录";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // chkZdLogin
            // 
            this.chkZdLogin.AutoSize = true;
            this.chkZdLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkZdLogin.BaseColor = System.Drawing.Color.Red;
            this.chkZdLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkZdLogin.DefaultCheckButtonWidth = 15;
            this.chkZdLogin.DownBack = global::SM.ManageUI.Properties.Resources.checkbox_pushed;
            this.chkZdLogin.Enabled = false;
            this.chkZdLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkZdLogin.ForeColor = System.Drawing.Color.Black;
            this.chkZdLogin.LightEffect = false;
            this.chkZdLogin.Location = new System.Drawing.Point(221, 190);
            this.chkZdLogin.MouseBack = global::SM.ManageUI.Properties.Resources.checkbox_hightlight;
            this.chkZdLogin.Name = "chkZdLogin";
            this.chkZdLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.NormlBack")));
            this.chkZdLogin.SelectedDownBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_pushed;
            this.chkZdLogin.SelectedMouseBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_highlight;
            this.chkZdLogin.SelectedNormlBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_normal;
            this.chkZdLogin.Size = new System.Drawing.Size(75, 21);
            this.chkZdLogin.TabIndex = 4;
            this.chkZdLogin.Text = "自动登录";
            this.chkZdLogin.UseVisualStyleBackColor = false;
            this.chkZdLogin.CheckedChanged += new System.EventHandler(this.chkZdLogin_CheckedChanged);
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.BackgroundImage = global::SM.ManageUI.Properties.Resources.frameBorderEffect_normalDraw;
            this.pnlId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.btnId);
            this.pnlId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlId.DownBack = global::SM.ManageUI.Properties.Resources.frameBorderEffect_mouseDownDraw;
            this.pnlId.Location = new System.Drawing.Point(140, 121);
            this.pnlId.MouseBack = global::SM.ManageUI.Properties.Resources.frameBorderEffect_mouseDownDraw;
            this.pnlId.Name = "pnlId";
            this.pnlId.NormlBack = global::SM.ManageUI.Properties.Resources.frameBorderEffect_normalDraw;
            this.pnlId.Palace = true;
            this.pnlId.Size = new System.Drawing.Size(185, 28);
            this.pnlId.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtId.Location = new System.Drawing.Point(5, 5);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 18);
            this.txtId.TabIndex = 2;
            this.txtId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.WaterText = "请在此输入您的登陆账号";
            this.txtId.WordWrap = false;
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.Leave += new System.EventHandler(this.txtId_Enter);
            this.txtId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.Transparent;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.BaseColor = System.Drawing.Color.Red;
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.DownBack = global::SM.ManageUI.Properties.Resources.login_inputbtn_down;
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.Location = new System.Drawing.Point(161, 2);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = global::SM.ManageUI.Properties.Resources.login_inputbtn_highlight;
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = global::SM.ManageUI.Properties.Resources.login_inputbtn_normal;
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 13;
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnId_MouseDown);
            this.btnId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.btnId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.Icon = global::SM.ManageUI.Properties.Resources.imgRjp_BackgroundImage;
            this.txtPwd.IconIsButton = true;
            this.txtPwd.IsPasswordChat = '●';
            this.txtPwd.IsSystemPasswordChar = true;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(140, 156);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtPwd.MouseBack = null;
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = null;
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtPwd.ReadOnly = false;
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.Size = new System.Drawing.Size(185, 28);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "密码";
            this.txtPwd.WordWrap = true;
            this.txtPwd.IconClick += new System.EventHandler(this.txtPwd_IconClick);
            // 
            // tuopan
            // 
            this.tuopan.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Visible = true;
            this.tuopan.DoubleClick += new System.EventHandler(this.tuopan_DoubleClick);
            // 
            // chkMima
            // 
            this.chkMima.AutoSize = true;
            this.chkMima.BackColor = System.Drawing.Color.Transparent;
            this.chkMima.BaseColor = System.Drawing.Color.Red;
            this.chkMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkMima.DefaultCheckButtonWidth = 15;
            this.chkMima.DownBack = global::SM.ManageUI.Properties.Resources.checkbox_pushed;
            this.chkMima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMima.ForeColor = System.Drawing.Color.Black;
            this.chkMima.LightEffect = false;
            this.chkMima.Location = new System.Drawing.Point(140, 190);
            this.chkMima.MouseBack = global::SM.ManageUI.Properties.Resources.checkbox_hightlight;
            this.chkMima.Name = "chkMima";
            this.chkMima.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkMima.NormlBack")));
            this.chkMima.SelectedDownBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_pushed;
            this.chkMima.SelectedMouseBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_highlight;
            this.chkMima.SelectedNormlBack = global::SM.ManageUI.Properties.Resources.checkbox_tick_normal;
            this.chkMima.Size = new System.Drawing.Size(75, 21);
            this.chkMima.TabIndex = 3;
            this.chkMima.Text = "记住密码";
            this.chkMima.UseVisualStyleBackColor = false;
            // 
            // labLoading
            // 
            this.labLoading.AutoSize = true;
            this.labLoading.BackColor = System.Drawing.Color.Transparent;
            this.labLoading.Font = new System.Drawing.Font("宋体", 9F);
            this.labLoading.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labLoading.Location = new System.Drawing.Point(347, 227);
            this.labLoading.Name = "labLoading";
            this.labLoading.Size = new System.Drawing.Size(59, 12);
            this.labLoading.TabIndex = 16;
            this.labLoading.Text = "loading  ";
            this.labLoading.Visible = false;
            // 
            // prbLoading
            // 
            this.prbLoading.BackColor = System.Drawing.Color.DarkRed;
            this.prbLoading.ForeColor = System.Drawing.Color.Red;
            this.prbLoading.Location = new System.Drawing.Point(1, 242);
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(378, 3);
            this.prbLoading.TabIndex = 15;
            this.prbLoading.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Show,
            this.TSMI_Hide,
            this.TSMI_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // TSMI_Show
            // 
            this.TSMI_Show.Image = global::SM.ManageUI.Properties.Resources.show;
            this.TSMI_Show.Name = "TSMI_Show";
            this.TSMI_Show.Size = new System.Drawing.Size(117, 22);
            this.TSMI_Show.Text = "显示(&S)";
            this.TSMI_Show.Click += new System.EventHandler(this.tuopan_DoubleClick);
            // 
            // TSMI_Hide
            // 
            this.TSMI_Hide.Image = global::SM.ManageUI.Properties.Resources.hide;
            this.TSMI_Hide.Name = "TSMI_Hide";
            this.TSMI_Hide.Size = new System.Drawing.Size(117, 22);
            this.TSMI_Hide.Text = "隐藏(&H)";
            this.TSMI_Hide.Click += new System.EventHandler(this.tuopan_Hide);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Image = global::SM.ManageUI.Properties.Resources.close;
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(117, 22);
            this.TSMI_Exit.Text = "退出(&E)";
            this.TSMI_Exit.Click += new System.EventHandler(this.tuopan_Close);
            // 
            // comBoId
            // 
            this.comBoId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoId.FormattingEnabled = true;
            this.comBoId.Location = new System.Drawing.Point(142, 125);
            this.comBoId.Name = "comBoId";
            this.comBoId.Size = new System.Drawing.Size(181, 22);
            this.comBoId.TabIndex = 17;
            this.comBoId.WaterText = "";
            this.comBoId.DropDownClosed += new System.EventHandler(this.MenuId_Closing);
            // 
            // lblMsg
            // 
            this.lblMsg.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.BorderColor = System.Drawing.Color.White;
            this.lblMsg.BorderSize = 4;
            this.lblMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMsg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMsg.Location = new System.Drawing.Point(124, 49);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(246, 37);
            this.lblMsg.TabIndex = 104;
            this.lblMsg.Text = "学生信息管理系统 v 1.0";
            // 
            // timerColor
            // 
            this.timerColor.Enabled = true;
            this.timerColor.Interval = 4000;
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackColor = System.Drawing.Color.Red;
            this.BackPalace = global::SM.ManageUI.Properties.Resources.texture;
            this.BorderPalace = global::SM.ManageUI.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::SM.ManageUI.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::SM.ManageUI.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::SM.ManageUI.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.labLoading);
            this.Controls.Add(this.prbLoading);
            this.Controls.Add(this.chkMima);
            this.Controls.Add(this.chkZdLogin);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.btnDuoId);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.btnSandeng);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.comBoId);
            this.EffectBack = System.Drawing.Color.Red;
            this.EffectCaption = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::SM.ManageUI.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::SM.ManageUI.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::SM.ManageUI.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::SM.ManageUI.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::SM.ManageUI.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::SM.ManageUI.Properties.Resources.btn_mini_normal;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "FrmLogin";
            this.RestoreDownBack = global::SM.ManageUI.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::SM.ManageUI.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::SM.ManageUI.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SysBottomDown = global::SM.ManageUI.Properties.Resources.btn_set_press;
            this.SysBottomMouse = global::SM.ManageUI.Properties.Resources.btn_set_hover;
            this.SysBottomNorml = global::SM.ManageUI.Properties.Resources.btn_set_normal;
            this.SysBottomToolTip = "设置";
            this.Text = "SM.ManageUI";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FrmLogin_DeacTivate);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButtom btnSandeng;
        private CCWin.SkinControl.SkinButtom btnDl;
        private CCWin.SkinControl.SkinCheckBox chkZdLogin;
        private CCWin.SkinControl.SkinPanel pnlId;
        private CCWin.SkinControl.WaterTextBox txtId;
        private CCWin.SkinControl.SkinButtom btnId;
        private CCWin.SkinControl.SkinTextBox txtPwd;
        public System.Windows.Forms.NotifyIcon tuopan;
        private CCWin.SkinControl.SkinCheckBox chkMima;
        private CCWin.SkinControl.SkinButtom btnDuoId;
        private System.Windows.Forms.Label labLoading;
        private System.Windows.Forms.ProgressBar prbLoading;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Show;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Hide;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private CCWin.SkinControl.SkinComboBox comBoId;
        private CCWin.SkinControl.SkinLabel lblMsg;
        private System.Windows.Forms.Timer timerColor;

        
    }
}