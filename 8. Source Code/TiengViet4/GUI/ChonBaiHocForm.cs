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
            Close();
            Application.Exit();            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            TreeNode SelectedNode = treDanhSachTuan.SelectedNode;
            if (SelectedNode != null && SelectedNode.Level != 0)
            {
                lblNhacNho.Visible = false;
                string strMaLoaiMon = SelectedNode.Tag.ToString();
                switch (strMaLoaiMon)
                {
                    case "CT":
                        ChinhTaForm frmChinhTa = new ChinhTaForm(treDanhSachTuan.SelectedNode.Name);
                        frmChinhTa.ShowDialog();
                        break;
                }                
            }
            else 
            {
                lblNhacNho.Visible = true;
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
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
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}