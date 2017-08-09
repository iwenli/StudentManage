namespace SM.ManageUI
{
    partial class FrmPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopup));
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButtom1 = new CCWin.SkinControl.SkinButtom();
            this.pnlTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Interval = 6000;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(7, 136);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(0, 17);
            this.skinLabel1.TabIndex = 0;
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.pnlImgTx);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.DownBack")));
            this.pnlTx.Location = new System.Drawing.Point(14, 52);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.MouseBack")));
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.NormlBack")));
            this.pnlTx.Palace = true;
            this.pnlTx.Size = new System.Drawing.Size(57, 57);
            this.pnlTx.TabIndex = 21;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = global::SM.ManageUI.Properties.Resources._9;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(2, 2);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 3;
            this.pnlImgTx.Size = new System.Drawing.Size(53, 53);
            this.pnlImgTx.TabIndex = 6;
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(90, 44);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(163, 90);
            this.skinLabel2.TabIndex = 22;
            this.skinLabel2.Text = "上午好：\r\n     恭喜您登陆成功！";
            // 
            // skinButtom1
            // 
            this.skinButtom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButtom1.BackColor = System.Drawing.Color.Transparent;
            this.skinButtom1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButtom1.DownBack = null;
            this.skinButtom1.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.skinButtom1.Image = ((System.Drawing.Image)(resources.GetObject("skinButtom1.Image")));
            this.skinButtom1.Location = new System.Drawing.Point(226, 136);
            this.skinButtom1.Margin = new System.Windows.Forms.Padding(0);
            this.skinButtom1.MouseBack = null;
            this.skinButtom1.Name = "skinButtom1";
            this.skinButtom1.NormlBack = null;
            this.skinButtom1.Size = new System.Drawing.Size(16, 16);
            this.skinButtom1.TabIndex = 127;
            this.skinButtom1.UseVisualStyleBackColor = false;
            this.skinButtom1.Click += new System.EventHandler(this.skinButtom1_Click);
            // 
            // FrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::SM.ManageUI.Properties.Resources.infoBg;
            this.BackLayout = false;
            this.BorderPalace = ((System.Drawing.Image)(resources.GetObject("$this.BorderPalace")));
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::SM.ManageUI.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::SM.ManageUI.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::SM.ManageUI.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.skinButtom1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.skinLabel1);
            this.DropBack = false;
            this.EffectWidth = 2;
            this.MaxDownBack = global::SM.ManageUI.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::SM.ManageUI.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::SM.ManageUI.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::SM.ManageUI.Properties.Resources.btn_mini_down;
            this.MinimizeBox = false;
            this.MiniMouseBack = global::SM.ManageUI.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::SM.ManageUI.Properties.Resources.btn_mini_normal;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "FrmPopup";
            this.RestoreDownBack = global::SM.ManageUI.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::SM.ManageUI.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::SM.ManageUI.Properties.Resources.btn_restore_normal;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "提示信息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.pnlTx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timShow;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinButtom skinButtom1;
    }
}