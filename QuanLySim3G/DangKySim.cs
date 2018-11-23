using Model;
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
    public partial class DangKySim : Form
    {
        public DangKySim()
        {
            InitializeComponent();
        }

        void DataBindingTableHopDongDangKy()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Tên khách hàng", typeof(string));
            dataTable.Columns.Add("Địa chỉ khách hàng", typeof(string));
            dataTable.Columns.Add("Ngày đăng ký", typeof(DateTime));
            dataTable.Columns.Add("Chi phí", typeof(Decimal));
            dataTable.Columns.Add("Sim", typeof(string));

            using (var dbcontext = new Model1())
            {

                var listHoadDonDangKy = dbcontext.HoaDonDK.ToList();

                foreach (var hoadon in listHoadDonDangKy)
                {
                    dataTable.Rows.Add(hoadon.KhachHang.TenKH, hoadon.KhachHang.DiaChi, hoadon.NgayDK, hoadon.ChiPhi, hoadon.Sim.SoSim);
                }
            }

            dgvHopDongDangKy.DataSource = dataTable;
           
           
        }

        private void DangKySim_Load(object sender, EventArgs e)
        {
            DataBindingTableHopDongDangKy();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {


            DataBindingTableHopDongDangKy();
        }

    

       

  
    }
}
