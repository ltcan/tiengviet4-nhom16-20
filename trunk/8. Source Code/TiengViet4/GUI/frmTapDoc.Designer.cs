namespace TiengViet4
{
    partial class frmTapDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTapDoc));
            this.btnThanhDieuHuong = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuong = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHome = new DevComponents.DotNetBar.BubbleButton();
            this.btnThongTin = new DevComponents.DotNetBar.BubbleButton();
            this.btnAmThanh = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            this.lblTuMoi = new DevComponents.DotNetBar.LabelX();
            this.lblNoiDungBaiDoc = new DevComponents.DotNetBar.LabelX();
            this.pnlTracNghiem = new DevComponents.DotNetBar.ExpandablePanel();
            this.lblKetQua = new DevComponents.DotNetBar.LabelX();
            this.rdoDapAnD = new System.Windows.Forms.RadioButton();
            this.rdoDapAnB = new System.Windows.Forms.RadioButton();
            this.rdoDapAnC = new System.Windows.Forms.RadioButton();
            this.rdoDapAnA = new System.Windows.Forms.RadioButton();
            this.lblCauHoi = new DevComponents.DotNetBar.LabelX();
            this.btnThanhDieuHuongMatTroi = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnMatTroi = new DevComponents.DotNetBar.BubbleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuong)).BeginInit();
            this.pnlTracNghiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongMatTroi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhDieuHuong
            // 
            this.btnThanhDieuHuong.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.btnThanhDieuHuong.AntiAlias = true;
            this.btnThanhDieuHuong.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.PaddingBottom = 3;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.PaddingLeft = 3;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.PaddingRight = 3;
            this.btnThanhDieuHuong.ButtonBackAreaStyle.PaddingTop = 3;
            this.btnThanhDieuHuong.ButtonBackgroundStretch = false;
            this.btnThanhDieuHuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuong.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuong.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuong.Location = new System.Drawing.Point(127, 465);
            this.btnThanhDieuHuong.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuong.Name = "btnThanhDieuHuong";
            this.btnThanhDieuHuong.SelectedTab = this.btThanhDieuHuong;
            this.btnThanhDieuHuong.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuong.Size = new System.Drawing.Size(449, 76);
            this.btnThanhDieuHuong.TabIndex = 15;
            this.btnThanhDieuHuong.Tabs.Add(this.btThanhDieuHuong);
            this.btnThanhDieuHuong.TabsVisible = false;
            this.btnThanhDieuHuong.Text = "bubbleBar2";
            // 
            // btThanhDieuHuong
            // 
            this.btThanhDieuHuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuong.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuong.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHome,
            this.btnThongTin,
            this.btnAmThanh,
            this.btnThoat});
            this.btThanhDieuHuong.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btThanhDieuHuong.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhDieuHuong.Name = "btThanhDieuHuong";
            this.btThanhDieuHuong.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.btThanhDieuHuong.Text = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuong.TextColor = System.Drawing.Color.Black;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageLarge")));
            this.btnHome.Name = "btnHome";
            this.btnHome.TooltipText = "Về trang đầu";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThongTin.ImageLarge")));
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.TooltipText = "Thông tin trợ giúp";
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
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton7_Click);
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTuMoi.Location = new System.Drawing.Point(1, 215);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(190, 220);
            this.lblTuMoi.TabIndex = 16;
            this.lblTuMoi.Text = "TỪ MỚI TRONG BÀI";
            this.lblTuMoi.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblNoiDungBaiDoc
            // 
            this.lblNoiDungBaiDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiDungBaiDoc.Location = new System.Drawing.Point(211, 12);
            this.lblNoiDungBaiDoc.Name = "lblNoiDungBaiDoc";
            this.lblNoiDungBaiDoc.SingleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNoiDungBaiDoc.Size = new System.Drawing.Size(365, 313);
            this.lblNoiDungBaiDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblNoiDungBaiDoc.TabIndex = 17;
            this.lblNoiDungBaiDoc.Text = "NỘI DUNG BÀI ĐỌC";
            this.lblNoiDungBaiDoc.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // pnlTracNghiem
            // 
            this.pnlTracNghiem.AnimationTime = 1000;
            this.pnlTracNghiem.CanvasColor = System.Drawing.Color.Transparent;
            this.pnlTracNghiem.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.pnlTracNghiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlTracNghiem.Controls.Add(this.lblKetQua);
            this.pnlTracNghiem.Controls.Add(this.rdoDapAnD);
            this.pnlTracNghiem.Controls.Add(this.rdoDapAnB);
            this.pnlTracNghiem.Controls.Add(this.rdoDapAnC);
            this.pnlTracNghiem.Controls.Add(this.rdoDapAnA);
            this.pnlTracNghiem.Controls.Add(this.lblCauHoi);
            this.pnlTracNghiem.ExpandButtonVisible = false;
            this.pnlTracNghiem.Expanded = false;
            this.pnlTracNghiem.ExpandedBounds = new System.Drawing.Rectangle(198, 12, 582, 423);
            this.pnlTracNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTracNghiem.Location = new System.Drawing.Point(774, 12);
            this.pnlTracNghiem.Name = "pnlTracNghiem";
            this.pnlTracNghiem.Size = new System.Drawing.Size(6, 423);
            this.pnlTracNghiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlTracNghiem.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlTracNghiem.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlTracNghiem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlTracNghiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.pnlTracNghiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.pnlTracNghiem.Style.GradientAngle = 90;
            this.pnlTracNghiem.TabIndex = 18;
            this.pnlTracNghiem.TitleHeight = 0;
            this.pnlTracNghiem.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlTracNghiem.TitleStyle.BackColor1.Color = System.Drawing.Color.Coral;
            this.pnlTracNghiem.TitleStyle.BackColor2.Color = System.Drawing.Color.White;
            this.pnlTracNghiem.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.pnlTracNghiem.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTracNghiem.TitleStyle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pnlTracNghiem.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTracNghiem.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTracNghiem.TitleStyle.GradientAngle = 90;
            this.pnlTracNghiem.TitleText = "Câu hỏi";
            // 
            // lblKetQua
            // 
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(456, 365);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(85, 23);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Kết Quả";
            this.lblKetQua.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rdoDapAnD
            // 
            this.rdoDapAnD.AutoSize = true;
            this.rdoDapAnD.Location = new System.Drawing.Point(347, 305);
            this.rdoDapAnD.Name = "rdoDapAnD";
            this.rdoDapAnD.Size = new System.Drawing.Size(130, 30);
            this.rdoDapAnD.TabIndex = 5;
            this.rdoDapAnD.TabStop = true;
            this.rdoDapAnD.Text = "Đáp án D";
            this.rdoDapAnD.UseVisualStyleBackColor = true;
            // 
            // rdoDapAnB
            // 
            this.rdoDapAnB.AutoSize = true;
            this.rdoDapAnB.Location = new System.Drawing.Point(347, 239);
            this.rdoDapAnB.Name = "rdoDapAnB";
            this.rdoDapAnB.Size = new System.Drawing.Size(129, 30);
            this.rdoDapAnB.TabIndex = 4;
            this.rdoDapAnB.TabStop = true;
            this.rdoDapAnB.Text = "Đáp án B";
            this.rdoDapAnB.UseVisualStyleBackColor = true;
            // 
            // rdoDapAnC
            // 
            this.rdoDapAnC.AutoSize = true;
            this.rdoDapAnC.Location = new System.Drawing.Point(85, 305);
            this.rdoDapAnC.Name = "rdoDapAnC";
            this.rdoDapAnC.Size = new System.Drawing.Size(130, 30);
            this.rdoDapAnC.TabIndex = 3;
            this.rdoDapAnC.TabStop = true;
            this.rdoDapAnC.Text = "Đáp án C";
            this.rdoDapAnC.UseVisualStyleBackColor = true;
            // 
            // rdoDapAnA
            // 
            this.rdoDapAnA.AutoSize = true;
            this.rdoDapAnA.Location = new System.Drawing.Point(85, 239);
            this.rdoDapAnA.Name = "rdoDapAnA";
            this.rdoDapAnA.Size = new System.Drawing.Size(129, 30);
            this.rdoDapAnA.TabIndex = 2;
            this.rdoDapAnA.TabStop = true;
            this.rdoDapAnA.Text = "Đáp án A";
            this.rdoDapAnA.UseVisualStyleBackColor = true;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Location = new System.Drawing.Point(85, 29);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(391, 173);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu hỏi";
            this.lblCauHoi.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThanhDieuHuongMatTroi
            // 
            this.btnThanhDieuHuongMatTroi.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.btnThanhDieuHuongMatTroi.AntiAlias = true;
            this.btnThanhDieuHuongMatTroi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.PaddingBottom = 3;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.PaddingLeft = 3;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.PaddingRight = 3;
            this.btnThanhDieuHuongMatTroi.ButtonBackAreaStyle.PaddingTop = 3;
            this.btnThanhDieuHuongMatTroi.ButtonBackgroundStretch = false;
            this.btnThanhDieuHuongMatTroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuongMatTroi.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuongMatTroi.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuongMatTroi.Location = new System.Drawing.Point(250, 359);
            this.btnThanhDieuHuongMatTroi.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongMatTroi.Name = "btnThanhDieuHuongMatTroi";
            this.btnThanhDieuHuongMatTroi.SelectedTab = this.btThanhDieuHuongDuoi;
            this.btnThanhDieuHuongMatTroi.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongMatTroi.Size = new System.Drawing.Size(294, 76);
            this.btnThanhDieuHuongMatTroi.TabIndex = 19;
            this.btnThanhDieuHuongMatTroi.Tabs.Add(this.btThanhDieuHuongDuoi);
            this.btnThanhDieuHuongMatTroi.TabsVisible = false;
            this.btnThanhDieuHuongMatTroi.Text = "btnThanhDieuHuongDuoi";
            // 
            // btThanhDieuHuongDuoi
            // 
            this.btThanhDieuHuongDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuongDuoi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuongDuoi.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnMatTroi});
            this.btThanhDieuHuongDuoi.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btThanhDieuHuongDuoi.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhDieuHuongDuoi.Name = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.btThanhDieuHuongDuoi.Text = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.TextColor = System.Drawing.Color.Black;
            // 
            // btnMatTroi
            // 
            this.btnMatTroi.Image = ((System.Drawing.Image)(resources.GetObject("btnMatTroi.Image")));
            this.btnMatTroi.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnMatTroi.ImageLarge")));
            this.btnMatTroi.Name = "btnMatTroi";
            this.btnMatTroi.TooltipText = "Bắt đầu trả lời câu hỏi!";
            this.btnMatTroi.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton1_Click);
            // 
            // frmTapDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnThanhDieuHuongMatTroi);
            this.Controls.Add(this.lblTuMoi);
            this.Controls.Add(this.btnThanhDieuHuong);
            this.Controls.Add(this.pnlTracNghiem);
            this.Controls.Add(this.lblNoiDungBaiDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTapDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTapDoc";
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuong)).EndInit();
            this.pnlTracNghiem.ResumeLayout(false);
            this.pnlTracNghiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongMatTroi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuong;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuong;
        private DevComponents.DotNetBar.BubbleButton btnHome;
        private DevComponents.DotNetBar.BubbleButton btnThongTin;
        private DevComponents.DotNetBar.BubbleButton btnAmThanh;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
        private DevComponents.DotNetBar.LabelX lblTuMoi;
        private DevComponents.DotNetBar.LabelX lblNoiDungBaiDoc;
        private DevComponents.DotNetBar.ExpandablePanel pnlTracNghiem;
        private System.Windows.Forms.RadioButton rdoDapAnD;
        private System.Windows.Forms.RadioButton rdoDapAnB;
        private System.Windows.Forms.RadioButton rdoDapAnC;
        private System.Windows.Forms.RadioButton rdoDapAnA;
        private DevComponents.DotNetBar.LabelX lblCauHoi;
        private DevComponents.DotNetBar.LabelX lblKetQua;
        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuongMatTroi;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleButton btnMatTroi;
    }
}