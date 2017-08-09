using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using SM.ManageUI.Code;


namespace SM.ManageUI.Controls
{
    public class Button : CommandButton
    {
        public Label lblText;
        private DialogResult _dialogResult = DialogResult.None;


      
        public virtual DialogResult DialogResult
        {
            get { return _dialogResult; }
            set { _dialogResult = value; }
        }

        public Button()
            : base()
        {
            //this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public void PerformClick()
        {
            this.OnClick(new EventArgs());
        }

        private void InitializeComponent()
        {
            this.lblText = new Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(78, 30);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.TextChanged += new System.EventHandler(this.lblText_TextChanged);
            this.lblText.MouseLeave += new System.EventHandler(this.lblText_MouseLeave);
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseUp);
            this.lblText.MouseEnter += new System.EventHandler(this.lblText_MouseEnter);
            this.lblText.ForeColor = Shared.FontColor;
            // 
            // Button
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblText);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(78, 30);
            this.ResumeLayout(false);

        }

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    this.Height = this.Width * 30 / 78;
        //}

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.NormalImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btnnomal.bmp"), true, false);
            this.MouseDownImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btndown.bmp"), true, false);
            this.MouseMoveImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btnfore.bmp"), true, false);
            
        }

        public void ResetBackGroundImage()
        {
            this.NormalImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btnnomal.bmp"), true, false);
            this.MouseDownImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btndown.bmp"), true, false);
            this.MouseMoveImage = Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.btnfore.bmp"), true, false);
        }

        private string _text = string.Empty;

        [Browsable(true)]
        public string Caption
        {
            get { return _text; }
            set
            {
                _text = value;

                if (lblText.Text != value)
                {
                    lblText.Text = value;
                }
            }
        }

        private void lblText_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblText.Text;
        }

        private void lblText_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void lblText_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void lblText_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            this.PerformClick();
        }

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);

        //    int Rgn = 0, height = 0, width = 0,rgn=0;

        //    height = Height > 40 ? Height - 1 : Height;
        //    width = Width > 110 ? Width - 1 : Width;
        //    rgn = Height > 40 ? 8 : 7;

        //    Rgn = Win32.CreateRoundRectRgn(1, 1, width, height, rgn, rgn);

        //    Win32.SetWindowRgn(this.Handle, Rgn, true);
        //}

    }

}
