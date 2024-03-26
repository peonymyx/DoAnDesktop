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
        private Panel _panel;
        FrmLopHocGV lhgv;
        public FrmGiaoDienLopHoc(/*string tenmonhoc, */string malophoc, string tenphong, string thu, string tietbd, string tietkt, string sosinhvien, Panel panel)
        {
            InitializeComponent();
            /*lbl_tenlophoc.Text = tenmonhoc;*/
            lbl_malhInfo.Text = malophoc;
            lbl_sosinhvienInfo.Text = sosinhvien;
            lbl_tietbdInfo.Text = tietbd;
            lbl_tietktInfo.Text = tietkt;
            lbl_tenphongInfo.Text = tenphong;
            lbl_thuInfo.Text = thu;
            _panel = panel;
            lhgv = new FrmLopHocGV(malophoc);
        }

        public Button GetButton()
        {
            return this.btn_vaohoc;
        }

        private void btn_vaohoc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
