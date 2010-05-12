namespace TiengViet4
{
    partial class frmChonBaiHoc
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonBaiHoc));
            this.btnThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHome = new DevComponents.DotNetBar.BubbleButton();
            this.btnHuongDan = new DevComponents.DotNetBar.BubbleButton();
            this.btnAmThanh = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            this.btnEnter = new CustomButton.ImageButton();
            this.lblBaiHoc = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tvDanhSachBaiHoc = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.node6 = new DevComponents.AdvTree.Node();
            this.node7 = new DevComponents.AdvTree.Node();
            this.node8 = new DevComponents.AdvTree.Node();
            this.node9 = new DevComponents.AdvTree.Node();
            this.node10 = new DevComponents.AdvTree.Node();
            this.node11 = new DevComponents.AdvTree.Node();
            this.node12 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvDanhSachBaiHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhDieuHuongDuoi
            // 
            this.btnThanhDieuHuongDuoi.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.btnThanhDieuHuongDuoi.AntiAlias = true;
            this.btnThanhDieuHuongDuoi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingBottom = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingLeft = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingRight = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingTop = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackgroundStretch = false;
            this.btnThanhDieuHuongDuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuongDuoi.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuongDuoi.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuongDuoi.Location = new System.Drawing.Point(250, 492);
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Name = "btnThanhDieuHuongDuoi";
            this.btnThanhDieuHuongDuoi.SelectedTab = this.btThanhDieuHuongDuoi;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Size = new System.Drawing.Size(294, 76);
            this.btnThanhDieuHuongDuoi.TabIndex = 0;
            this.btnThanhDieuHuongDuoi.Tabs.Add(this.btThanhDieuHuongDuoi);
            this.btnThanhDieuHuongDuoi.TabsVisible = false;
            this.btnThanhDieuHuongDuoi.Text = "btnThanhDieuHuongDuoi";
            // 
            // btThanhDieuHuongDuoi
            // 
            this.btThanhDieuHuongDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuongDuoi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuongDuoi.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHome,
            this.btnHuongDan,
            this.btnAmThanh,
            this.btnThoat});
            this.btThanhDieuHuongDuoi.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btThanhDieuHuongDuoi.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhDieuHuongDuoi.Name = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.btThanhDieuHuongDuoi.Text = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.TextColor = System.Drawing.Color.Black;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageLarge")));
            this.btnHome.Name = "btnHome";
            this.btnHome.TooltipText = "Về trang đầu";
            this.btnHome.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnHome_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.ImageLarge")));
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.TooltipText = "Thông tin trợ giúp";
            // 
            // btnAmThanh
            // 
            this.btnAmThanh.Image = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.Image")));
            this.btnAmThanh.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.ImageLarge")));
            this.btnAmThanh.Name = "btnAmThanh";
            this.btnAmThanh.TooltipText = "Bật/Tắt nhạc";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageLarge")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TooltipText = "Thoát";
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnThoat_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BackgroundImage1 = null;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(349, 389);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(98, 97);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblBaiHoc
            // 
            this.lblBaiHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblBaiHoc.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBaiHoc.Location = new System.Drawing.Point(282, 4);
            this.lblBaiHoc.Name = "lblBaiHoc";
            this.lblBaiHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBaiHoc.Size = new System.Drawing.Size(217, 85);
            this.lblBaiHoc.TabIndex = 3;
            this.lblBaiHoc.Text = "<font color=\"#00C505\"><b><i><font color=\"#903C39\">Bài học</font></i></b></font>";
            // 
            // tvDanhSachBaiHoc
            // 
            this.tvDanhSachBaiHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvDanhSachBaiHoc.AllowDrop = true;
            this.tvDanhSachBaiHoc.BackColor = System.Drawing.Color.Turquoise;
            // 
            // 
            // 
            this.tvDanhSachBaiHoc.BackgroundStyle.Class = "TreeBorderKey";
            this.tvDanhSachBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDanhSachBaiHoc.Location = new System.Drawing.Point(132, 104);
            this.tvDanhSachBaiHoc.Name = "tvDanhSachBaiHoc";
            this.tvDanhSachBaiHoc.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1,
            this.node5,
            this.node8,
            this.node11});
            this.tvDanhSachBaiHoc.NodesConnector = this.nodeConnector1;
            this.tvDanhSachBaiHoc.NodeStyle = this.elementStyle1;
            this.tvDanhSachBaiHoc.PathSeparator = ";";
            this.tvDanhSachBaiHoc.Size = new System.Drawing.Size(552, 290);
            this.tvDanhSachBaiHoc.Styles.Add(this.elementStyle1);
            this.tvDanhSachBaiHoc.TabIndex = 6;
            this.tvDanhSachBaiHoc.Text = "advTree1";
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2,
            this.node3,
            this.node4});
            this.node1.Text = "Tuần 1";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Text = "Bài 1:.....";
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Text = "Bài 2:.....";
            // 
            // node4
            // 
            this.node4.Expanded = true;
            this.node4.Name = "node4";
            this.node4.Text = "Bài 3:.....";
            // 
            // node5
            // 
            this.node5.Expanded = true;
            this.node5.Name = "node5";
            this.node5.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node6,
            this.node7});
            this.node5.Text = "Tuần 2";
            // 
            // node6
            // 
            this.node6.Expanded = true;
            this.node6.Name = "node6";
            this.node6.Text = "Bài 4:.....";
            // 
            // node7
            // 
            this.node7.Expanded = true;
            this.node7.Name = "node7";
            this.node7.Text = "Bài 5:.....";
            // 
            // node8
            // 
            this.node8.Expanded = true;
            this.node8.Name = "node8";
            this.node8.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node9,
            this.node10});
            this.node8.Text = "Tuần 3";
            // 
            // node9
            // 
            this.node9.Expanded = true;
            this.node9.Name = "node9";
            this.node9.Text = "Bài 6:.....";
            // 
            // node10
            // 
            this.node10.Expanded = true;
            this.node10.Name = "node10";
            this.node10.Text = "Bài 7:.....";
            // 
            // node11
            // 
            this.node11.Expanded = true;
            this.node11.Name = "node11";
            this.node11.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node12});
            this.node11.Text = "Tuần 4";
            // 
            // node12
            // 
            this.node12.Expanded = true;
            this.node12.Name = "node12";
            this.node12.Text = "Bài 8:.....";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // frmChonBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tvDanhSachBaiHoc);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBaiHoc);
            this.Controls.Add(this.btnThanhDieuHuongDuoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonBaiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonBaiHoc";
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvDanhSachBaiHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleButton btnHome;
        private DevComponents.DotNetBar.BubbleButton btnHuongDan;
        private DevComponents.DotNetBar.BubbleButton btnAmThanh;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
        private CustomButton.ImageButton btnEnter;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblBaiHoc;
        private DevComponents.AdvTree.AdvTree tvDanhSachBaiHoc;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node5;
        private DevComponents.AdvTree.Node node6;
        private DevComponents.AdvTree.Node node7;
        private DevComponents.AdvTree.Node node8;
        private DevComponents.AdvTree.Node node9;
        private DevComponents.AdvTree.Node node10;
        private DevComponents.AdvTree.Node node11;
        private DevComponents.AdvTree.Node node12;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}