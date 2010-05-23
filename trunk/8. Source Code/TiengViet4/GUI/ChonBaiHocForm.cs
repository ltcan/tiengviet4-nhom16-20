using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace TiengViet4
{
    public partial class ChonBaiHocForm : Form
    {
        public ChonBaiHocForm()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //Dispose();
            Close();
        }

        //protected override void OnClosed(EventArgs e)
        //{
        //    Parent.Dispose();
        //    base.OnClosed(e);
        //}

        private void btnEnter_Click(object sender, EventArgs e)
        {
            TreeNode SelectedNode = treDanhSachTuan.SelectedNode;
            if (SelectedNode != null)
            {
                if (SelectedNode.Level == 1)
                {
                    lblNhacNho.Visible = false;
                    string strMaLoaiMon = SelectedNode.Tag.ToString();
                    switch (strMaLoaiMon)
                    {
                        case "CT":
                            this.Cursor = Cursors.WaitCursor;
                            ChinhTaForm frmChinhTa = new ChinhTaForm(treDanhSachTuan.SelectedNode.Name, this);
                            frmChinhTa.Show();
                            break;
                        case "LTVC":
                            this.Cursor = Cursors.WaitCursor;
                            LuyenTuVaCauForm frmLuyenTuVaCau = new LuyenTuVaCauForm(treDanhSachTuan.SelectedNode.Name, this);
                            frmLuyenTuVaCau.Show();
                            break;
                        case "TLV":
                            this.Cursor = Cursors.WaitCursor;
                            TapLamVanForm frmTapLamVan = new TapLamVanForm(treDanhSachTuan.SelectedNode.Name, this);
                            frmTapLamVan.Show();
                            break;
                    }
                }             
            }
            else if (sender.GetType() == typeof(CustomButton.ImageButton))
            {
                lblNhacNho.Visible = true;
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
            //Parent.Show();
        }

        private void frmChonBaiHoc_Load(object sender, EventArgs e)
        {
            try
            {
                List<TuanHocDTO> DanhSachTuan = TuanHocBUS.LayDanhSachTuan();
                //int iNodeIndex = 0;

                // Add các nodes lấy từ CSDL vào tree view
                foreach (TuanHocDTO TuanHoc in DanhSachTuan)
                {
                    TreeNode tnNode = new TreeNode();
                    tnNode.Text = TuanHoc.TenTuan;
                    tnNode.Name = TuanHoc.MaTuan;
                    treDanhSachTuan.Nodes.Add(tnNode);

                    //tnNode.Index = iNodeIndex;
                    //iNodeIndex++;                
                    try
                    {
                        List<BaiHocDTO> DanhSachBaiHoc = BaiHocBUS.LayDanhSachBaiHocTheoTuan(tnNode.Name);
                        if (DanhSachBaiHoc.Count > 0)
                        {
                            foreach (BaiHocDTO BaiHoc in DanhSachBaiHoc)
                            {
                                TreeNode tnChildNode = new TreeNode();
                                tnChildNode.Text = BaiHoc.Ten;
                                tnChildNode.Name = BaiHoc.Ma;
                                tnChildNode.Tag = BaiHoc.MaLoaiMon;
                                treDanhSachTuan.Nodes[TuanHoc.MaTuan].Nodes.Add(tnChildNode);
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                //Parent.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void treDanhSachTuan_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.btnEnter_Click(sender, e);
        }

        // Region Le Van Long
        private void treDanhSachTuan_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode Node = treDanhSachTuan.GetNodeAt(e.Location);
            if (Node != null && Node.Level > 0)
            {
                this.Cursor = Cursors.Hand;
            }
            else 
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}