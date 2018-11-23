using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySim3G
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }


        void showContentTongQuan()
        {
            TongQuan tongquan = new TongQuan();
            tongquan.TopLevel = false;

            pnContent.Controls.Clear();
            pnContent.Controls.Add(tongquan);

            tongquan.Show();
            
        }

        void showContentDangKySim()
        {
            DangKySim dangkysim = new DangKySim();
            dangkysim.TopLevel = false;

            pnContent.Controls.Clear();
            pnContent.Controls.Add(dangkysim);

            dangkysim.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDangKySim_Click(object sender, EventArgs e)
        {
            showContentDangKySim();
        }

        private void pnTongQuan_Click(object sender, EventArgs e)
        {
            showContentTongQuan();
        }

        private void lblTongQuan_Click(object sender, EventArgs e)
        {
            showContentTongQuan();
        }

        private void lblThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhtoan = new ThanhToan();
            thanhtoan.TopLevel = false;

            pnContent.Controls.Clear();
            pnContent.Controls.Add(thanhtoan);

            thanhtoan.Show();
        }

 
     

       
    }
}
