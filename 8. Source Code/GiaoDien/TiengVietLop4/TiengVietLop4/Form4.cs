using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengVietLop4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        int flag;

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            flag = 1;
            expandablePanel2.Expanded = false;
            expandablePanel3.Expanded = false;
            labelX7.Text = "ĐIỀN VÀO CHỖ TRỐNG";
            imageButton1.Visible = true;
            labelX7.Visible = true;
        }

        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            flag = 2;
            expandablePanel1.Expanded = false;
            expandablePanel3.Expanded = false;
            labelX7.Text = "VIẾT CHÍNH TẢ";
            imageButton1.Visible = true;
            labelX7.Visible = true;
        }

        private void bubbleButton8_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            flag = 3;
            expandablePanel2.Expanded = false;
            expandablePanel1.Expanded = false;
            labelX7.Text = "GIẢI CÂU ĐỐ";
            imageButton1.Visible = true;
            labelX7.Visible = true;
        }

        private void imageButton1_Click_1(object sender, EventArgs e)
        {
            imageButton1.Visible = false;
            labelX7.Visible = false;
            if (flag==1)
            {

                expandablePanel1.AnimationTime = 1000;
                expandablePanel1.Expanded = true;
                expandablePanel1.AnimationTime = 100;
            }
            else
                if (flag==2)
                {
                    expandablePanel2.AnimationTime = 1000;
                    expandablePanel2.Expanded = true;
                    expandablePanel2.AnimationTime = 100;
                }
                else
                {

                    expandablePanel3.AnimationTime = 1000;
                    expandablePanel3.Expanded = true;
                    expandablePanel3.AnimationTime = 100;
                }
        }

    }
}