using System;
using System.Collections.Generic;

using System.Text;
using System.Reflection;
using SM.ManageUI.Forms;
using System.Windows.Forms;
using System.Drawing;
using SM.ManageUI.Controls;
using System.Runtime.InteropServices;

namespace SM.ManageUI.Code
{
    public abstract class Shared
    {
        //private static SkinColor _currentSkinColor = SkinColor.Default;
        //private static BackgroundStripe _currentStripe = BackgroundStripe.Default;
        private static Assembly _assemblyWinUI = null;
        //private static Bitmap drawButton = null;
        //private static Bitmap scrollbarButton = null;

        public static Assembly AssemblyWinUI
        {
            get
            {
                if (_assemblyWinUI == null)
                {
                    _assemblyWinUI = Assembly.Load("SM.ManageUI");
                }

                return _assemblyWinUI;
            }
        }

        //public static SkinColor CurrentSkinColor
        //{
        //    get { return _currentSkinColor; }
        //    set { _currentSkinColor = value; }
        //}

        //public static BackgroundStripe CurrentBackgroundStripe
        //{
        //    get { return _currentStripe; }
        //    set { _currentStripe = value; }
        //}




        public static Color FontColor
        {
            get { return Color.FromArgb(22, 61, 101); }
        }


        //public static Bitmap ScrollBarButton
        //{
        //    get
        //    {
        //        if (scrollbarButton == null)
        //        {
        //            scrollbarButton = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.scroll.scroll.bmp"), true, false), new Size(114, 114));
        //        }
        //        return scrollbarButton;
        //    }
        //}

        //public static Image ScrollBarUpButton
        //{
        //    get { return ScrollBarButton.Clone(new Rectangle(0, 0, 16, 16), System.Drawing.Imaging.PixelFormat.Format32bppPArgb); }
        //}

        //public static Bitmap DrawButton
        //{
        //    get
        //    {
        //        if (drawButton == null)
        //        {
        //            drawButton = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.Common.button.arrow.bmp"), true, false), new Size(64, 16));
        //        }
        //        return drawButton;
        //    }
        //}

        //public static Image NomalDrawButton
        //{
        //    get { return DrawButton.Clone(new Rectangle(0, 0, 16, 16), System.Drawing.Imaging.PixelFormat.Format32bppPArgb); }
        //}

        //public static Image MouseDownDrawButton
        //{
        //    get { return DrawButton.Clone(new Rectangle(16, 0, 16, 16), System.Drawing.Imaging.PixelFormat.Format32bppPArgb); }
        //}

        //public static Image MouseMoveDrawButton
        //{
        //    get { return DrawButton.Clone(new Rectangle(32, 0, 16, 16), System.Drawing.Imaging.PixelFormat.Format32bppPArgb); }
        //}

        //public static Image NotEnableDrawButton
        //{
        //    get { return DrawButton.Clone(new Rectangle(48, 0, 16, 16), System.Drawing.Imaging.PixelFormat.Format32bppPArgb); }
        //}

        

       

        #region FlushMemory
        //public static void GarbageCollect()
        //{
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    GC.Collect();
        //}

        //public static void FlushMemory()
        //{
        //    GarbageCollect();

        //    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        //    {
        //        Win32.SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        //    }
        //}
        #endregion

        #region Suspend / Resume Redraw

        //internal static void SuspendRedraw(Control control)
        //{
        //    if (!control.IsHandleCreated) return;

        //    IntPtr hWnd = control.Handle;
        //    IntPtr eventMask = IntPtr.Zero;

        //    // Stop redrawing:
        //    Win32.SendMessage(hWnd, Win32.WM_SETREDRAW, 0, 0);

        //    // Stop sending of events:
        //    Win32.SendMessage(hWnd, Win32.EM_GETEVENTMASK, 0, 0);
        //}

        //internal static void ResumeRedraw(Control control)
        //{
        //    if (!control.IsHandleCreated) return;

        //    IntPtr hWnd = control.Handle;
        //    IntPtr eventMask = IntPtr.Zero;

        //    // turn on events
        //    Win32.SendMessage(hWnd, Win32.EM_SETEVENTMASK, 0, eventMask.ToInt32());

        //    // turn on redrawing
        //    Win32.SendMessage(hWnd, Win32.WM_SETREDRAW, 1, 0);

        //    control.Invalidate(true);
        //}

        //internal static void LockWindowUpdate(Form form, bool lockUpdate)
        //{
        //    if (lockUpdate)
        //    {
        //        Win32.LockWindowUpdate(form.Handle);
        //    }
        //    else
        //    {
        //        Win32.LockWindowUpdate(IntPtr.Zero);
        //        form.Invalidate(true);
        //        form.Update();
        //    }
        //}
        #endregion
        
    }

    public enum SkinColor
    {
        Default,
        草莓,
        橘子,
        青草,
        灰蓝,
        紫罗兰,
        巧克力,
        OFFICE,
        Undefault
    }

    public enum BackgroundStripe
    {
        Default,
        淡淡墨绿,
        芙蓉轻粉,
        荷叶嫩绿,
        橘黄雪花,
        清雅幽兰,
        空灵淡蓝,
        柔和雅灰,
        腊梅飘香
    }
}
