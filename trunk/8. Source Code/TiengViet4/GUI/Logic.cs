using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class Logic : Form
    {
        public Logic()
        {
            InitializeComponent();
        }

        private void Logic_Load(object sender, EventArgs e)
        {
            string PATH = Application.StartupPath + "\\diamonds.swf";
            this.axShockwaveFlash1.LoadMovie(0, PATH);
        }
    }
}
