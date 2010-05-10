using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengVietLop4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            bubbleBar1.Visible = false;
            expandablePanel1.Expanded = true;
        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }
    }
}