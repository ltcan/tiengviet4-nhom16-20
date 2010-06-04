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
        MainForm frmParent;

        public ChonBaiHocForm(MainForm MyParent)
        {
            InitializeComponent();
            frmParent = MyParent;
            //frmParent.Hide();
        }

        private void BtnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
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

                        case "KC":
                            this.Cursor = Cursors.WaitCursor;
                            KeChuyenForm frmKeChuyen = new KeChuyenForm(treDanhSachTuan.SelectedNode.Name,this);
                             frmKeChuyen.Show();
                            break;

                        case "TD":
                            this.Cursor = Cursors.WaitCursor;
                            TapDocForm frmTapDoc = new TapDocForm(treDanhSachTuan.SelectedNode.Name, this);                            
                            frmTapDoc.Show();
                            break;
                    }
                }             
            }
            else if (sender.GetType() == typeof(CustomButton.ImageButton))
            {
                lblNhacNho.Visible = true;
            }
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
                        // Sort
                        //if (DanhSachBaiHoc.Count > 0)
                        //{
                        //    for (int i = 0; i < DanhSachBaiHoc.Count; i++)
                        //    {
                        //        for (int j = i + 1; j < DanhSachBaiHoc.Count; j++)
                        //        {
                        //            if (DanhSachBaiHoc[i].Ten[0] > DanhSachBaiHoc[j].Ten[0])
                        //            {
                        //                TreeNode tnTemp = new TreeNode();
                        //                tnTemp.Text = DanhSachBaiHoc[i].Ten;
                        //                tnTemp.Name = DanhSachBaiHoc[i].Ma;
                        //                tnTemp.Tag = DanhSachBaiHoc[i].MaLoaiMon;

                        //                DanhSachBaiHoc[i].Ten = DanhSachBaiHoc[j].Ten;
                        //                DanhSachBaiHoc[i].Ma = DanhSachBaiHoc[j].Ma;
                        //                DanhSachBaiHoc[i].MaLoaiMon = DanhSachBaiHoc[j].MaLoaiMon;

                        //                DanhSachBaiHoc[j].Ten = tnTemp.Text;
                        //                DanhSachBaiHoc[j].Ma = tnTemp.Name;
                        //                DanhSachBaiHoc[j].MaLoaiMon = tnTemp.Tag.ToString();
                        //            }
                        //        }
                        //    }
                            
                        //}

                        //add node

                        
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
                frmParent.Hide();
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

        private void btnThoat_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }

        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            HuongDanSuDungForm frm = new HuongDanSuDungForm();
            frm.Show();
        }

     
    }
}