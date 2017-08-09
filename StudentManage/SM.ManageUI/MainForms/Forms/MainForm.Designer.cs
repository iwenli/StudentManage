using SM.BaseControls;

namespace SM.ManageUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbTopMenu = new System.Windows.Forms.Panel();
            this.btnMenu10 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu09 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu08 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu07 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu06 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu05 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu04 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu03 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu02 = new SM.ManageUI.Controls.CommandButton();
            this.btnMenu01 = new SM.ManageUI.Controls.CommandButton();
            this.btnClose = new SM.ManageUI.Controls.CommandButton();
            this.btnMaxResore = new SM.ManageUI.Controls.CommandButton();
            this.btnMin = new SM.ManageUI.Controls.CommandButton();
            this.lblTopText = new System.Windows.Forms.Label();
            this.ptbTopRight = new System.Windows.Forms.PictureBox();
            this.ptbTopLeft = new System.Windows.Forms.PictureBox();
            this.ptbTopRightLogo = new System.Windows.Forms.Panel();
            this.btnSet = new SM.ManageUI.Controls.CommandButton();
            this.ptbTopMiddle = new System.Windows.Forms.PictureBox();
            this.labUserGroup = new System.Windows.Forms.Label();
            this.labTitleGroup = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labTitleUser = new System.Windows.Forms.Label();
            this.labCopyRight = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.ptbBottomRight = new System.Windows.Forms.PictureBox();
            this.ptbBottomLeft = new System.Windows.Forms.PictureBox();
            this.ptbBottomMiddle = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.ptbLeft = new System.Windows.Forms.PictureBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.ptbRight = new System.Windows.Forms.PictureBox();
            this.GCtimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.ptbTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopLeft)).BeginInit();
            this.ptbTopRightLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopMiddle)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomMiddle)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ptbTopMenu);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMaxResore);
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.lblTopText);
            this.pnlTop.Controls.Add(this.ptbTopRight);
            this.pnlTop.Controls.Add(this.ptbTopLeft);
            this.pnlTop.Controls.Add(this.ptbTopRightLogo);
            this.pnlTop.Controls.Add(this.ptbTopMiddle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(980, 111);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.DoubleClick += new System.EventHandler(this.Win_WindosMax);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // ptbTopMenu
            // 
            this.ptbTopMenu.BackColor = System.Drawing.Color.Transparent;
            this.ptbTopMenu.Controls.Add(this.btnMenu10);
            this.ptbTopMenu.Controls.Add(this.btnMenu09);
            this.ptbTopMenu.Controls.Add(this.btnMenu08);
            this.ptbTopMenu.Controls.Add(this.btnMenu07);
            this.ptbTopMenu.Controls.Add(this.btnMenu06);
            this.ptbTopMenu.Controls.Add(this.btnMenu05);
            this.ptbTopMenu.Controls.Add(this.btnMenu04);
            this.ptbTopMenu.Controls.Add(this.btnMenu03);
            this.ptbTopMenu.Controls.Add(this.btnMenu02);
            this.ptbTopMenu.Controls.Add(this.btnMenu01);
            this.ptbTopMenu.Location = new System.Drawing.Point(9, 25);
            this.ptbTopMenu.Name = "ptbTopMenu";
            this.ptbTopMenu.Size = new System.Drawing.Size(745, 79);
            this.ptbTopMenu.TabIndex = 7;
            this.ptbTopMenu.DoubleClick += new System.EventHandler(this.Win_WindosMax);
            this.ptbTopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // btnMenu10
            // 
            this.btnMenu10.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu10.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu10.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu10.Location = new System.Drawing.Point(621, 0);
            this.btnMenu10.MouseDownImage = null;
            this.btnMenu10.MouseMoveImage = null;
            this.btnMenu10.Name = "btnMenu10";
            this.btnMenu10.NormalImage = null;
            this.btnMenu10.Size = new System.Drawing.Size(69, 79);
            this.btnMenu10.TabIndex = 23;
            this.btnMenu10.ToolTip = null;
            this.btnMenu10.Click += new System.EventHandler(this.btnMenu10_Click);
            // 
            // btnMenu09
            // 
            this.btnMenu09.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu09.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu09.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu09.Location = new System.Drawing.Point(552, 0);
            this.btnMenu09.MouseDownImage = null;
            this.btnMenu09.MouseMoveImage = null;
            this.btnMenu09.Name = "btnMenu09";
            this.btnMenu09.NormalImage = null;
            this.btnMenu09.Size = new System.Drawing.Size(69, 79);
            this.btnMenu09.TabIndex = 22;
            this.btnMenu09.ToolTip = null;
            this.btnMenu09.Click += new System.EventHandler(this.btnMenu09_Click);
            // 
            // btnMenu08
            // 
            this.btnMenu08.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu08.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu08.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu08.Location = new System.Drawing.Point(483, 0);
            this.btnMenu08.MouseDownImage = null;
            this.btnMenu08.MouseMoveImage = null;
            this.btnMenu08.Name = "btnMenu08";
            this.btnMenu08.NormalImage = null;
            this.btnMenu08.Size = new System.Drawing.Size(69, 79);
            this.btnMenu08.TabIndex = 21;
            this.btnMenu08.ToolTip = null;
            this.btnMenu08.Click += new System.EventHandler(this.btnMenu08_Click);
            // 
            // btnMenu07
            // 
            this.btnMenu07.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu07.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu07.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu07.Location = new System.Drawing.Point(414, 0);
            this.btnMenu07.MouseDownImage = null;
            this.btnMenu07.MouseMoveImage = null;
            this.btnMenu07.Name = "btnMenu07";
            this.btnMenu07.NormalImage = null;
            this.btnMenu07.Size = new System.Drawing.Size(69, 79);
            this.btnMenu07.TabIndex = 20;
            this.btnMenu07.ToolTip = null;
            this.btnMenu07.Click += new System.EventHandler(this.btnMenu07_Click);
            // 
            // btnMenu06
            // 
            this.btnMenu06.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu06.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu06.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu06.Location = new System.Drawing.Point(345, 0);
            this.btnMenu06.MouseDownImage = null;
            this.btnMenu06.MouseMoveImage = null;
            this.btnMenu06.Name = "btnMenu06";
            this.btnMenu06.NormalImage = null;
            this.btnMenu06.Size = new System.Drawing.Size(69, 79);
            this.btnMenu06.TabIndex = 19;
            this.btnMenu06.ToolTip = null;
            this.btnMenu06.Click += new System.EventHandler(this.btnMenu06_Click);
            // 
            // btnMenu05
            // 
            this.btnMenu05.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu05.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu05.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu05.Location = new System.Drawing.Point(276, 0);
            this.btnMenu05.MouseDownImage = null;
            this.btnMenu05.MouseMoveImage = null;
            this.btnMenu05.Name = "btnMenu05";
            this.btnMenu05.NormalImage = null;
            this.btnMenu05.Size = new System.Drawing.Size(69, 79);
            this.btnMenu05.TabIndex = 18;
            this.btnMenu05.ToolTip = null;
            this.btnMenu05.Click += new System.EventHandler(this.btnMenu05_Click);
            // 
            // btnMenu04
            // 
            this.btnMenu04.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu04.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu04.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu04.Location = new System.Drawing.Point(207, 0);
            this.btnMenu04.MouseDownImage = null;
            this.btnMenu04.MouseMoveImage = null;
            this.btnMenu04.Name = "btnMenu04";
            this.btnMenu04.NormalImage = null;
            this.btnMenu04.Size = new System.Drawing.Size(69, 79);
            this.btnMenu04.TabIndex = 17;
            this.btnMenu04.ToolTip = null;
            this.btnMenu04.Click += new System.EventHandler(this.btnMenu04_Click);
            // 
            // btnMenu03
            // 
            this.btnMenu03.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu03.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu03.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu03.Location = new System.Drawing.Point(138, 0);
            this.btnMenu03.MouseDownImage = null;
            this.btnMenu03.MouseMoveImage = null;
            this.btnMenu03.Name = "btnMenu03";
            this.btnMenu03.NormalImage = null;
            this.btnMenu03.Size = new System.Drawing.Size(69, 79);
            this.btnMenu03.TabIndex = 16;
            this.btnMenu03.ToolTip = null;
            this.btnMenu03.Click += new System.EventHandler(this.btnMenu03_Click);
            // 
            // btnMenu02
            // 
            this.btnMenu02.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu02.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu02.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu02.Location = new System.Drawing.Point(69, 0);
            this.btnMenu02.MouseDownImage = null;
            this.btnMenu02.MouseMoveImage = null;
            this.btnMenu02.Name = "btnMenu02";
            this.btnMenu02.NormalImage = null;
            this.btnMenu02.Size = new System.Drawing.Size(69, 79);
            this.btnMenu02.TabIndex = 9;
            this.btnMenu02.ToolTip = null;
            this.btnMenu02.Click += new System.EventHandler(this.btnMenu02_Click);
            // 
            // btnMenu01
            // 
            this.btnMenu01.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu01.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu01.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMenu01.Location = new System.Drawing.Point(0, 0);
            this.btnMenu01.MouseDownImage = null;
            this.btnMenu01.MouseMoveImage = null;
            this.btnMenu01.Name = "btnMenu01";
            this.btnMenu01.NormalImage = null;
            this.btnMenu01.Size = new System.Drawing.Size(69, 79);
            this.btnMenu01.TabIndex = 9;
            this.btnMenu01.ToolTip = null;
            this.btnMenu01.Click += new System.EventHandler(this.btnMenu01_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(942, 1);
            this.btnClose.MouseDownImage = null;
            this.btnClose.MouseMoveImage = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalImage = null;
            this.btnClose.Size = new System.Drawing.Size(33, 19);
            this.btnClose.TabIndex = 3;
            this.btnClose.ToolTip = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaxResore
            // 
            this.btnMaxResore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxResore.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMaxResore.Location = new System.Drawing.Point(910, 1);
            this.btnMaxResore.MouseDownImage = null;
            this.btnMaxResore.MouseMoveImage = null;
            this.btnMaxResore.Name = "btnMaxResore";
            this.btnMaxResore.NormalImage = null;
            this.btnMaxResore.Size = new System.Drawing.Size(33, 19);
            this.btnMaxResore.TabIndex = 3;
            this.btnMaxResore.ToolTip = "最大化";
            this.btnMaxResore.Click += new System.EventHandler(this.btnMaxResore_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnMin.Location = new System.Drawing.Point(879, 1);
            this.btnMin.MouseDownImage = null;
            this.btnMin.MouseMoveImage = null;
            this.btnMin.Name = "btnMin";
            this.btnMin.NormalImage = null;
            this.btnMin.Size = new System.Drawing.Size(33, 19);
            this.btnMin.TabIndex = 3;
            this.btnMin.ToolTip = "最小化";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblTopText
            // 
            this.lblTopText.BackColor = System.Drawing.Color.Transparent;
            this.lblTopText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTopText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(82)))));
            this.lblTopText.Location = new System.Drawing.Point(10, 3);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(283, 22);
            this.lblTopText.TabIndex = 0;
            this.lblTopText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // ptbTopRight
            // 
            this.ptbTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbTopRight.Location = new System.Drawing.Point(976, 0);
            this.ptbTopRight.Name = "ptbTopRight";
            this.ptbTopRight.Size = new System.Drawing.Size(4, 111);
            this.ptbTopRight.TabIndex = 2;
            this.ptbTopRight.TabStop = false;
            // 
            // ptbTopLeft
            // 
            this.ptbTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbTopLeft.Location = new System.Drawing.Point(0, 0);
            this.ptbTopLeft.Name = "ptbTopLeft";
            this.ptbTopLeft.Size = new System.Drawing.Size(3, 111);
            this.ptbTopLeft.TabIndex = 0;
            this.ptbTopLeft.TabStop = false;
            // 
            // ptbTopRightLogo
            // 
            this.ptbTopRightLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbTopRightLogo.Controls.Add(this.btnSet);
            this.ptbTopRightLogo.Location = new System.Drawing.Point(547, 0);
            this.ptbTopRightLogo.Name = "ptbTopRightLogo";
            this.ptbTopRightLogo.Size = new System.Drawing.Size(431, 104);
            this.ptbTopRightLogo.TabIndex = 6;
            this.ptbTopRightLogo.DoubleClick += new System.EventHandler(this.Win_WindosMax);
            this.ptbTopRightLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // btnSet
            // 
            this.btnSet.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSet.Location = new System.Drawing.Point(301, 1);
            this.btnSet.MouseDownImage = null;
            this.btnSet.MouseMoveImage = null;
            this.btnSet.Name = "btnSet";
            this.btnSet.NormalImage = null;
            this.btnSet.Size = new System.Drawing.Size(33, 19);
            this.btnSet.TabIndex = 7;
            this.btnSet.ToolTip = "设置";
            // 
            // ptbTopMiddle
            // 
            this.ptbTopMiddle.BackColor = System.Drawing.SystemColors.Control;
            this.ptbTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbTopMiddle.Location = new System.Drawing.Point(0, 0);
            this.ptbTopMiddle.Name = "ptbTopMiddle";
            this.ptbTopMiddle.Size = new System.Drawing.Size(980, 111);
            this.ptbTopMiddle.TabIndex = 1;
            this.ptbTopMiddle.TabStop = false;
            this.ptbTopMiddle.DoubleClick += new System.EventHandler(this.Win_WindosMax);
            this.ptbTopMiddle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // labUserGroup
            // 
            this.labUserGroup.AutoSize = true;
            this.labUserGroup.BackColor = System.Drawing.Color.Transparent;
            this.labUserGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(82)))));
            this.labUserGroup.Location = new System.Drawing.Point(176, 8);
            this.labUserGroup.Name = "labUserGroup";
            this.labUserGroup.Size = new System.Drawing.Size(53, 12);
            this.labUserGroup.TabIndex = 11;
            this.labUserGroup.Text = "高级用户";
            // 
            // labTitleGroup
            // 
            this.labTitleGroup.AutoSize = true;
            this.labTitleGroup.BackColor = System.Drawing.Color.Transparent;
            this.labTitleGroup.ForeColor = System.Drawing.Color.White;
            this.labTitleGroup.Location = new System.Drawing.Point(140, 8);
            this.labTitleGroup.Name = "labTitleGroup";
            this.labTitleGroup.Size = new System.Drawing.Size(41, 12);
            this.labTitleGroup.TabIndex = 10;
            this.labTitleGroup.Text = "权限：";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(82)))));
            this.labUserName.Location = new System.Drawing.Point(71, 8);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(53, 12);
            this.labUserName.TabIndex = 9;
            this.labUserName.Text = "haiyabtx";
            // 
            // labTitleUser
            // 
            this.labTitleUser.AutoSize = true;
            this.labTitleUser.BackColor = System.Drawing.Color.Transparent;
            this.labTitleUser.ForeColor = System.Drawing.Color.White;
            this.labTitleUser.Location = new System.Drawing.Point(21, 8);
            this.labTitleUser.Name = "labTitleUser";
            this.labTitleUser.Size = new System.Drawing.Size(53, 12);
            this.labTitleUser.TabIndex = 8;
            this.labTitleUser.Text = "欢迎您：";
            // 
            // labCopyRight
            // 
            this.labCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.labCopyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.labCopyRight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labCopyRight.ForeColor = System.Drawing.Color.White;
            this.labCopyRight.Location = new System.Drawing.Point(676, 0);
            this.labCopyRight.Name = "labCopyRight";
            this.labCopyRight.Size = new System.Drawing.Size(300, 28);
            this.labCopyRight.TabIndex = 4;
            this.labCopyRight.Text = "版权：天津商业大学高职学院 ";
            this.labCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labCopyRight.Click += new System.EventHandler(this.labCopyRight_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.labUserName);
            this.pnlBottom.Controls.Add(this.labUserGroup);
            this.pnlBottom.Controls.Add(this.labCopyRight);
            this.pnlBottom.Controls.Add(this.labTitleUser);
            this.pnlBottom.Controls.Add(this.labTitleGroup);
            this.pnlBottom.Controls.Add(this.ptbBottomRight);
            this.pnlBottom.Controls.Add(this.ptbBottomLeft);
            this.pnlBottom.Controls.Add(this.ptbBottomMiddle);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 640);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(980, 28);
            this.pnlBottom.TabIndex = 2;
            // 
            // ptbBottomRight
            // 
            this.ptbBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbBottomRight.Location = new System.Drawing.Point(976, 0);
            this.ptbBottomRight.Name = "ptbBottomRight";
            this.ptbBottomRight.Size = new System.Drawing.Size(4, 28);
            this.ptbBottomRight.TabIndex = 1;
            this.ptbBottomRight.TabStop = false;
            this.ptbBottomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // ptbBottomLeft
            // 
            this.ptbBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.ptbBottomLeft.Name = "ptbBottomLeft";
            this.ptbBottomLeft.Size = new System.Drawing.Size(4, 28);
            this.ptbBottomLeft.TabIndex = 0;
            this.ptbBottomLeft.TabStop = false;
            this.ptbBottomLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // ptbBottomMiddle
            // 
            this.ptbBottomMiddle.BackColor = System.Drawing.Color.Transparent;
            this.ptbBottomMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBottomMiddle.Location = new System.Drawing.Point(0, 0);
            this.ptbBottomMiddle.Name = "ptbBottomMiddle";
            this.ptbBottomMiddle.Size = new System.Drawing.Size(980, 28);
            this.ptbBottomMiddle.TabIndex = 2;
            this.ptbBottomMiddle.TabStop = false;
            this.ptbBottomMiddle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.ptbLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 111);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1, 529);
            this.pnlLeft.TabIndex = 3;
            // 
            // ptbLeft
            // 
            this.ptbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLeft.Location = new System.Drawing.Point(0, 0);
            this.ptbLeft.Name = "ptbLeft";
            this.ptbLeft.Size = new System.Drawing.Size(1, 529);
            this.ptbLeft.TabIndex = 0;
            this.ptbLeft.TabStop = false;
            this.ptbLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.ptbRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(979, 111);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1, 529);
            this.pnlRight.TabIndex = 4;
            // 
            // ptbRight
            // 
            this.ptbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbRight.Location = new System.Drawing.Point(0, 0);
            this.ptbRight.Name = "ptbRight";
            this.ptbRight.Size = new System.Drawing.Size(1, 529);
            this.ptbRight.TabIndex = 0;
            this.ptbRight.TabStop = false;
            // 
            // GCtimer
            // 
            this.GCtimer.Interval = 2000;
            this.GCtimer.Tick += new System.EventHandler(this.GCtimer_Tick);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.ForeColor = System.Drawing.Color.Black;
            this.pnlBody.Location = new System.Drawing.Point(1, 111);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(978, 529);
            this.pnlBody.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 668);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.ptbTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopLeft)).EndInit();
            this.ptbTopRightLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopMiddle)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomMiddle)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlTop;
        internal System.Windows.Forms.PictureBox ptbTopRight;
        internal System.Windows.Forms.PictureBox ptbTopMiddle;
        internal System.Windows.Forms.PictureBox ptbTopLeft;
        internal System.Windows.Forms.Panel pnlBottom;
        internal System.Windows.Forms.PictureBox ptbBottomMiddle;
        internal System.Windows.Forms.PictureBox ptbBottomRight;
        internal System.Windows.Forms.PictureBox ptbBottomLeft;
        internal System.Windows.Forms.Panel pnlLeft;
        internal System.Windows.Forms.PictureBox ptbLeft;
        internal System.Windows.Forms.Panel pnlRight;
        internal System.Windows.Forms.PictureBox ptbRight;
        internal SM.ManageUI.Controls.CommandButton btnClose;
        internal SM.ManageUI.Controls.CommandButton btnMin;
        internal System.Windows.Forms.Timer GCtimer;
        internal System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.Panel ptbTopRightLogo;
        internal Controls.CommandButton btnSet;
        private System.Windows.Forms.Panel ptbTopMenu;
        private System.Windows.Forms.Label labCopyRight;
        private System.Windows.Forms.Label labTitleUser;
        private System.Windows.Forms.Label labTitleGroup;
        protected System.Windows.Forms.Label labUserName;
        protected System.Windows.Forms.Label labUserGroup;
        //private Controls.panel pnlBody;
        private System.Windows.Forms.Panel pnlBody;
        protected Controls.CommandButton btnMenu01;
        protected Controls.CommandButton btnMenu02;
        protected Controls.CommandButton btnMenu10;
        protected Controls.CommandButton btnMenu09;
        protected Controls.CommandButton btnMenu08;
        protected Controls.CommandButton btnMenu07;
        protected Controls.CommandButton btnMenu06;
        protected Controls.CommandButton btnMenu05;
        protected Controls.CommandButton btnMenu04;
        protected Controls.CommandButton btnMenu03;
        public Controls.CommandButton btnMaxResore;

    }
}