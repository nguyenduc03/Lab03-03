using Lab03_03.ThucThe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        private QLHangHoaModel qLHangHoaModel;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            qLHangHoaModel = new QLHangHoaModel();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LayDSTheoNgay(dtDau.Value, dtCuoi.Value);
        }



        private void LayDSTheoNgay(DateTime NgayDau, DateTime NgayCuoi)
        {
            dataGridView1.Rows.Clear();
            count = 0;
            List<Invoice> DSDonDatHang = qLHangHoaModel.Invoices.ToList();
            foreach (var item in DSDonDatHang)
            {
                if (item.DeliveryDate >= NgayDau && item.DeliveryDate <= NgayCuoi)
                {
                    count++;
                    ThemPhanTu(dataGridView1, item);
                }
            }
        }
        

        private void ThemPhanTu(DataGridView dataGridView1, object input)
        {
            Invoice invoice = (Invoice)input;
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = count;
            dataGridView1.Rows[index].Cells[1].Value = invoice.InvoiceNo;
            dataGridView1.Rows[index].Cells[2].Value = (DateTime)invoice.OrderDate;
            dataGridView1.Rows[index].Cells[3].Value = (DateTime)invoice.DeliveryDate;
            dataGridView1.Rows[index].Cells[4].Value = TongGiaDonHang(invoice.InvoiceNo);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int Thang = dtDau.Value.Month;
                int Nam = dtDau.Value.Year;
                dtDau.Value=DateTime.Parse(Thang.ToString() + "/1" + "/" + Nam.ToString());
                dtCuoi.Value = PickNgayCuoiCuaThang(Thang, Nam);
                LayDSTheoThang(Thang, Nam);
            }
        }
        private DateTime PickNgayCuoiCuaThang (int thang , int nam)
        {
            string result = "";
            if(thang== 2&& nam % 4 == 0)
            {
                return DateTime.Parse("2/29/" + nam.ToString());
            }
            else
            {
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        result= (thang.ToString() + "/31/" + nam.ToString());
                        break;
                    case 6:
                    case 11:
                    case 4:
                    case 9:
                        result=(thang.ToString() + "/30/" + nam.ToString());
                        break;
                    case 2: 
                        result=(thang.ToString() + "/28/" + nam.ToString());
                        break;

                }
            }
            return DateTime.Parse(result);
        }
        private void LayDSTheoThang(int Thang, int Nam)
        {
            dataGridView1.Rows.Clear();
            count = 0;
            List<Invoice> DSDonDatHang = qLHangHoaModel.Invoices.ToList();
            foreach (var item in DSDonDatHang)
            {
                if (item.DeliveryDate.Month == Thang && item.DeliveryDate.Year == Nam)
                {
                    count++;
                    ThemPhanTu(dataGridView1, item);
                }
            }

        }

        private int TongGiaDonHang(string MaDH)
        {
            int sum = 0;
            List<Order> temp = qLHangHoaModel.Orders.Where(p => p.InvoiceNo == MaDH).ToList();
            foreach (Order item in temp)
            {
                sum += int.Parse(item.Price.ToString()) * item.Quantity;
            }
            return sum;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbThongTinDonHang_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtCuoi_CloseUp(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (dtCuoi.Value < dtDau.Value)
            {
                MessageBox.Show("Ngay phai lon hon hoac bang ngay truoc");
                dtCuoi.Value = dtDau.Value;
            }
            else
                LayDSTheoNgay(dtDau.Value, dtCuoi.Value);
        }

        private void dtDau_CloseUp(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (dtDau.Value > dtCuoi.Value)
            {
                MessageBox.Show("Ngay truoc phai lon hon hoac bang ngay sau");
                dtCuoi.Value = dtDau.Value;
            }
            else
                LayDSTheoNgay(dtDau.Value, dtCuoi.Value);
        }
    }
}
