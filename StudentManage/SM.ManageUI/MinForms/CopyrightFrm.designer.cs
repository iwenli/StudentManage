namespace SM.ManageUI
{
    partial class CopyrightFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyrightFrm));
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.imageButton1 = new ControlExs.ImageButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerHide
            // 
            this.timerHide.Enabled = true;
            this.timerHide.Interval = 30000;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.Transparent;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = global::SM.ManageUI.Properties.Resources.exit_wirte_bg_down;
            this.imageButton1.HoverImage = global::SM.ManageUI.Properties.Resources.exit_wirte_bg_down;
            this.imageButton1.Location = new System.Drawing.Point(310, 243);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = global::SM.ManageUI.Properties.Resources.exit_wirte_bg;
            this.imageButton1.Size = new System.Drawing.Size(75, 37);
            this.imageButton1.TabIndex = 0;
            this.imageButton1.TabStop = false;
            this.imageButton1.ToolTipText = null;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(10, 263);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Author:234486036(qq)";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.Click += new System.EventHandler(this.qqGlassButton1_Click);
            // 
            // CopyrightFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackLayout = false;
            this.BorderPalace = global::SM.ManageUI.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(376, 282);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::SM.ManageUI.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::SM.ManageUI.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::SM.ManageUI.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.imageButton1);
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
            this.Name = "CopyrightFrm";
            this.RestoreDownBack = global::SM.ManageUI.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::SM.ManageUI.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::SM.ManageUI.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CopyrightFrm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CopyrightFrm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerHide;
        private ControlExs.ImageButton imageButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}