using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class Different : Form
    {
        public Different()
        {
            InitializeComponent();
        }

        private void Different_Load(object sender, EventArgs e)
        {
            string PATH = Application.StartupPath + "\\5differences.swf";
            this.axShockwaveFlash1.LoadMovie(0, PATH);
        }
    }
}
