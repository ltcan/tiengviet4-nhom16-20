using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TiengViet4
{
    public partial class ChonGiaiTriForm : Form
    {
       
        public ChonGiaiTriForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
          
        }

        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Buzzle t = new Buzzle();
            t.Show();
            /*
            GAMEbuzzle BuzzleGameForm = new GAMEbuzzle();
            BuzzleGameForm.Show();*/
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "Jigsaw Deluxe.exe";
            proc.Start();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            Different DifferentGameForm = new Different();
            DifferentGameForm.Show();
        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            Logic LogicGameForm = new Logic();
          LogicGameForm.Show();
        }
    }
}
