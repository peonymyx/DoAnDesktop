using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhanSV
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe(FrmTrangAdmin frmTrangAdmin, Panel pn_header)
        {
            InitializeComponent();

            cmb_tk.Items.Add("Số lượng Sinh Viên mỗi khoa");
            cmb_tk.Items.Add("Số lượng Sinh Viên mỗi lớp");
            cmb_tk.Items.Add("Số lượng Sinh Viên mỗi ngành");
            cmb_tk.Items.Add("Số lượng bài tập Sinh Viên đã làm");
            cmb_tk.Items.Add("Số lượng tín chỉ mỗi Sinh Viên đăng ký");
            cmb_tk.Items.Add("Số lượng lớp Giảng Viên đã nhận");
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xác định form cần hiển thị dựa trên mục được chọn trong ComboBox
            switch (cmb_tk.SelectedItem.ToString())
            {
                case "Số lượng Sinh Viên mỗi khoa":
                    FrmTKSoLgSVKhoa frmtkslSV_Khoa = new FrmTKSoLgSVKhoa();
                    frmtkslSV_Khoa.ShowDialog();
                    break;
                case "Số lượng Sinh Viên mỗi lớp":
                    FrmTKSoLgSVLop frmtkslSV_Lop = new FrmTKSoLgSVLop();
                    frmtkslSV_Lop.ShowDialog();
                    break;
                case "Số lượng Sinh Viên mỗi ngành":
                    FrmTKSoLgSVNganh frmtkslSV_Nganh = new FrmTKSoLgSVNganh();
                    frmtkslSV_Nganh.ShowDialog();
                    break;
                case "Số lượng bài tập Sinh Viên đã làm":
                    FrmTKSoLgBTNop frmtkslSV_NopBai = new FrmTKSoLgBTNop();
                    frmtkslSV_NopBai.ShowDialog();
                    break;
                case "Số lượng tín chỉ mỗi Sinh Viên đăng ký":
                    FrmTKSoLgTCSVDK frmtkslSVDK_TinChi = new FrmTKSoLgTCSVDK();
                    frmtkslSVDK_TinChi.ShowDialog();
                    break;
                case "Số lượng lớp Giảng Viên đã nhận":
                    FrmTKSoLgLopGVNhan frmtkslGVday_Lop = new FrmTKSoLgLopGVNhan();
                    frmtkslGVday_Lop.ShowDialog();
                    break;
                // Thêm các trường hợp khác nếu cần
                default:
                    break;
            }
        }
    }
}
