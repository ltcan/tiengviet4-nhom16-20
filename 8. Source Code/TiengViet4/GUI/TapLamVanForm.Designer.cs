namespace TiengViet4
{
    partial class TapLamVanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TapLamVanForm));
            this.picCauHoi = new System.Windows.Forms.PictureBox();
            this.picCTCauTruoc = new System.Windows.Forms.PictureBox();
            this.picCTCauTiepTheo = new System.Windows.Forms.PictureBox();
            this.picDapAn = new CustomButton.ImageButton();
            this.btnThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHome = new DevComponents.DotNetBar.BubbleButton();
            this.btnHuongDan = new DevComponents.DotNetBar.BubbleButton();
            this.btnAmThanh = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            this.a = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnGhiNho = new DevComponents.DotNetBar.BubbleButton();
            this.btnTapLamVan = new DevComponents.DotNetBar.BubbleButton();
            this.rtbGhiNho = new System.Windows.Forms.RichTextBox();
            this.rtbCauHoi = new System.Windows.Forms.RichTextBox();
            this.rtbBaiLam = new System.Windows.Forms.RichTextBox();
            this.lblLamBai = new TiengViet4.TransparentRichTextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTCauTruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTCauTiepTheo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(9, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 600);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // picCauHoi
            // 
            this.picCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.picCauHoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCauHoi.BackgroundImage")));
            this.picCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCauHoi.Location = new System.Drawing.Point(462, 461);
            this.picCauHoi.Name = "picCauHoi";
            this.picCauHoi.Size = new System.Drawing.Size(45, 45);
            this.picCauHoi.TabIndex = 38;
            this.picCauHoi.TabStop = false;
            this.picCauHoi.Click += new System.EventHandler(this.picCTKetQua_Click);
            // 
            // picCTCauTruoc
            // 
            this.picCTCauTruoc.BackColor = System.Drawing.Color.Transparent;
            this.picCTCauTruoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCTCauTruoc.BackgroundImage")));
            this.picCTCauTruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCTCauTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCTCauTruoc.Location = new System.Drawing.Point(350, 463);
            this.picCTCauTruoc.Name = "picCTCauTruoc";
            this.picCTCauTruoc.Size = new System.Drawing.Size(45, 45);
            this.picCTCauTruoc.TabIndex = 37;
            this.picCTCauTruoc.TabStop = false;
            this.picCTCauTruoc.Visible = false;
            this.picCTCauTruoc.Click += new System.EventHandler(this.picCTCauTruoc_Click);
            // 
            // picCTCauTiepTheo
            // 
            this.picCTCauTiepTheo.BackColor = System.Drawing.Color.Transparent;
            this.picCTCauTiepTheo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCTCauTiepTheo.BackgroundImage")));
            this.picCTCauTiepTheo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCTCauTiepTheo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCTCauTiepTheo.Location = new System.Drawing.Point(573, 463);
            this.picCTCauTiepTheo.Name = "picCTCauTiepTheo";
            this.picCTCauTiepTheo.Size = new System.Drawing.Size(45, 45);
            this.picCTCauTiepTheo.TabIndex = 36;
            this.picCTCauTiepTheo.TabStop = false;
            this.picCTCauTiepTheo.Visible = false;
            this.picCTCauTiepTheo.Click += new System.EventHandler(this.picCTCauTiepTheo_Click);
            // 
            // picDapAn
            // 
            this.picDapAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDapAn.BackgroundImage")));
            this.picDapAn.BackgroundImage1 = ((System.Drawing.Image)(resources.GetObject("picDapAn.BackgroundImage1")));
            this.picDapAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDapAn.Location = new System.Drawing.Point(461, 460);
            this.picDapAn.Name = "picDapAn";
            this.picDapAn.Size = new System.Drawing.Size(48, 48);
            this.picDapAn.TabIndex = 35;
            this.picDapAn.UseVisualStyleBackColor = true;
            this.picDapAn.Visible = false;
            this.picDapAn.Click += new System.EventHandler(this.picBatDau_Click);
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
            this.btnThanhDieuHuongDuoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThanhDieuHuongDuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuongDuoi.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuongDuoi.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuongDuoi.Location = new System.Drawing.Point(291, 522);
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Name = "btnThanhDieuHuongDuoi";
            this.btnThanhDieuHuongDuoi.SelectedTab = this.bubbleBarTab2;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Size = new System.Drawing.Size(384, 76);
            this.btnThanhDieuHuongDuoi.TabIndex = 34;
            this.btnThanhDieuHuongDuoi.Tabs.Add(this.bubbleBarTab2);
            this.btnThanhDieuHuongDuoi.TabsVisible = false;
            this.btnThanhDieuHuongDuoi.Text = "bubbleBar2";
            // 
            // bubbleBarTab2
            // 
            this.bubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab2.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHome,
            this.btnHuongDan,
            this.btnAmThanh,
            this.btnThoat});
            this.bubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab2.Name = "bubbleBarTab2";
            this.bubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab2.Text = "btThanhDieuHuongDuoi";
            this.bubbleBarTab2.TextColor = System.Drawing.Color.Black;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageLarge")));
            this.btnHome.Name = "btnHome";
            this.btnHome.TooltipText = "Về trang đầu";
            this.btnHome.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnHome_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.ImageLarge")));
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.TooltipText = "Thông tin trợ giúp";
            // 
            // btnAmThanh
            // 
            this.btnAmThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmThanh.Image = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.Image")));
            this.btnAmThanh.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.ImageLarge")));
            this.btnAmThanh.Name = "btnAmThanh";
            this.btnAmThanh.TooltipText = "Bật/Tắt nhạc";
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageLarge")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TooltipText = "Thoát";
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnThoat_Click);
            // 
            // a
            // 
            this.a.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.a.AntiAlias = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.ButtonBackgroundStretch = false;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ImageSizeLarge = new System.Drawing.Size(72, 72);
            this.a.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.a.Location = new System.Drawing.Point(379, 12);
            this.a.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.a.Name = "a";
            this.a.SelectedTab = this.btThanhDieuHuongDuoi;
            this.a.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.a.Size = new System.Drawing.Size(201, 76);
            this.a.TabIndex = 40;
            this.a.Tabs.Add(this.btThanhDieuHuongDuoi);
            this.a.TabsVisible = false;
            this.a.Text = "btnThanhDieuHuongDuoi";
            // 
            // btThanhDieuHuongDuoi
            // 
            this.btThanhDieuHuongDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuongDuoi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuongDuoi.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnGhiNho,
            this.btnTapLamVan});
            this.btThanhDieuHuongDuoi.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btThanhDieuHuongDuoi.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhDieuHuongDuoi.Name = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.btThanhDieuHuongDuoi.Text = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.TextColor = System.Drawing.Color.Black;
            // 
            // btnGhiNho
            // 
            this.btnGhiNho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhiNho.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiNho.Image")));
            this.btnGhiNho.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnGhiNho.ImageLarge")));
            this.btnGhiNho.Name = "btnGhiNho";
            this.btnGhiNho.TooltipText = "Ghi Nhớ";
            this.btnGhiNho.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnNgheVaViet_Click);
            // 
            // btnTapLamVan
            // 
            this.btnTapLamVan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTapLamVan.Image = ((System.Drawing.Image)(resources.GetObject("btnTapLamVan.Image")));
            this.btnTapLamVan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnTapLamVan.ImageLarge")));
            this.btnTapLamVan.Name = "btnTapLamVan";
            this.btnTapLamVan.TooltipText = "Tập làm văn";
            this.btnTapLamVan.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnChinhTa_Click);
            // 
            // rtbGhiNho
            // 
            this.rtbGhiNho.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbGhiNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGhiNho.Location = new System.Drawing.Point(187, 94);
            this.rtbGhiNho.Name = "rtbGhiNho";
            this.rtbGhiNho.Size = new System.Drawing.Size(552, 264);
            this.rtbGhiNho.TabIndex = 55;
            this.rtbGhiNho.Text = "";
            // 
            // rtbCauHoi
            // 
            this.rtbCauHoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCauHoi.Location = new System.Drawing.Point(188, 94);
            this.rtbCauHoi.Name = "rtbCauHoi";
            this.rtbCauHoi.Size = new System.Drawing.Size(551, 153);
            this.rtbCauHoi.TabIndex = 56;
            this.rtbCauHoi.Text = "";
            // 
            // rtbBaiLam
            // 
            this.rtbBaiLam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbBaiLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBaiLam.Location = new System.Drawing.Point(188, 285);
            this.rtbBaiLam.Name = "rtbBaiLam";
            this.rtbBaiLam.Size = new System.Drawing.Size(551, 159);
            this.rtbBaiLam.TabIndex = 57;
            this.rtbBaiLam.Text = "";
            // 
            // lblLamBai
            // 
            this.lblLamBai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLamBai.Enabled = false;
            this.lblLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamBai.Location = new System.Drawing.Point(405, 253);
            this.lblLamBai.Name = "lblLamBai";
            this.lblLamBai.Size = new System.Drawing.Size(155, 26);
            this.lblLamBai.TabIndex = 54;
            this.lblLamBai.Text = "Nội Dung Bài Làm";
            // 
            // TapLamVanForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rtbBaiLam);
            this.Controls.Add(this.rtbCauHoi);
            this.Controls.Add(this.rtbGhiNho);
            this.Controls.Add(this.lblLamBai);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.picCauHoi);
            this.Controls.Add(this.picCTCauTruoc);
            this.Controls.Add(this.picCTCauTiepTheo);
            this.Controls.Add(this.picDapAn);
            this.Controls.Add(this.btnThanhDieuHuongDuoi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TapLamVanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TapLamVanForm";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTCauTruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTCauTiepTheo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCauHoi;
        private System.Windows.Forms.PictureBox picCTCauTruoc;
        private System.Windows.Forms.PictureBox picCTCauTiepTheo;
        private CustomButton.ImageButton picDapAn;
        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab2;
        private DevComponents.DotNetBar.BubbleButton btnHome;
        private DevComponents.DotNetBar.BubbleButton btnHuongDan;
        private DevComponents.DotNetBar.BubbleButton btnAmThanh;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
        private DevComponents.DotNetBar.BubbleBar a;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleButton btnGhiNho;
        private DevComponents.DotNetBar.BubbleButton btnTapLamVan;
        private TransparentRichTextBox lblLamBai;
        private System.Windows.Forms.RichTextBox rtbGhiNho;
        private System.Windows.Forms.RichTextBox rtbCauHoi;
        private System.Windows.Forms.RichTextBox rtbBaiLam;
    }
}