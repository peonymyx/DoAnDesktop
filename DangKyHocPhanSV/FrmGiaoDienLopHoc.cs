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
    public partial class FrmGiaoDienLopHoc : Form
    {
        public FrmGiaoDienLopHoc(/*string tenmonhoc, */string malophoc, string tenphong, string thu, string tietbd, string tietkt, string sosinhvien)
        {
            InitializeComponent();
            /*lbl_tenlophoc.Text = tenmonhoc;*/
            lbl_malhInfo.Text = malophoc;
            lbl_sosinhvienInfo.Text = sosinhvien;
            lbl_tietbdInfo.Text = tietbd;
            lbl_tietktInfo.Text = tietkt;
            lbl_tenphongInfo.Text = tenphong;
            lbl_thuInfo.Text = thu;
        }
    }
}
