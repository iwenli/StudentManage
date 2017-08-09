using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SM.ManageUI.Controls
{
    public partial class Menu1 : UserControl
    { 
        public Menu1()
        {
            InitializeComponent();
        }

        private void qqButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好");
        }
    }
}
