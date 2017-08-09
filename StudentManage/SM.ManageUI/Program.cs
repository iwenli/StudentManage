using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SM.BaseControls;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SM.ManageUI
{
    static class Program
    {
        static System.Threading.Mutex _mutex;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bl;
            Attribute guid_attr = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute));
            string guid = ((GuidAttribute)guid_attr).Value;
            _mutex = new System.Threading.Mutex(true, guid, out bl);

            if (bl)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin());
            }
            else
            {
                MessageBox.Show("当前程序已经跑起来了，快去看吧！", "天商科技", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mutex.ReleaseMutex();
            }
        }
    }
}
