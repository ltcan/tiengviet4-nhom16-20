using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengVietLop4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            expandablePanel1.TitleText = "Tiếng Việt";
            expandablePanel1.AnimationTime = 100;
            expandablePanel1.Expanded = false;
            expandablePanel1.Text = "PHẦN TIẾNG VIỆT";
            expandablePanel1.AnimationTime = 700;
            expandablePanel1.Expanded = true;
            panel1.Visible = true;
        }

        private void reflectionLabel2_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            expandablePanel1.TitleText = "Giải Trí";
            expandablePanel1.AnimationTime = 100;
            expandablePanel1.Expanded = false;
            expandablePanel1.Text = "PHẦN GIẢI TRÍ";
            expandablePanel1.AnimationTime = 700;
            expandablePanel1.Expanded = true;
            panel1.Visible = true;
        }

    }
}