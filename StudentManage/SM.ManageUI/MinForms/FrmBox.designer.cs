namespace SM.ManageUI
{
    partial class FrmBox
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
            this.lblMsg = new CCWin.SkinControl.SkinLabel();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.BorderColor = System.Drawing.Color.White;
            this.lblMsg.BorderSize = 4;
            this.lblMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMsg.Location = new System.Drawing.Point(84, 60);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(145, 64);
            this.lblMsg.TabIndex = 103;
            this.lblMsg.Text = "用户名不为空";
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.BackgroundImage = global::SM.ManageUI.Properties.Resources._16;
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBox.Location = new System.Drawing.Point(10, 53);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(68, 75);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 102;
            this.iconBox.TabStop = false;
            // 
            // timerHide
            // 
            this.timerHide.Enabled = true;
            this.timerHide.Interval = 2000;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // FrmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::SM.ManageUI.Properties.Resources.BoxBack;
            this.BackLayout = false;
            this.BorderPalace = global::SM.ManageUI.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(233, 161);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::SM.ManageUI.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::SM.ManageUI.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::SM.ManageUI.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.iconBox);
            this.DropBack = false;
            this.EffectBack = System.Drawing.Color.WhiteSmoke;
            this.EffectWidth = 3;
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
            this.Name = "FrmBox";
            this.RestoreDownBack = global::SM.ManageUI.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::SM.ManageUI.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::SM.ManageUI.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提示信息";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        public System.Windows.Forms.Timer timerHide;
        public CCWin.SkinControl.SkinLabel lblMsg;
    }
}