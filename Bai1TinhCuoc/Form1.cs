namespace Bai1TinhCuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal donGia;
            int soLuong;
            decimal giamGia;

            if (!decimal.TryParse(txtDonGia.Text, out donGia)
                || donGia <= 0)
            {
                MessageBox.Show("Don gia phai lon hon 0!");
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show("So luong phai la so nguyen lon hon 0!");
                txtSoLuong.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiamGia.Text, out giamGia)
                || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Giam gia phai tu 0 den 100!");
                txtGiamGia.Focus();
                return;
            }

            decimal tongTien = donGia * soLuong * (100 - giamGia) / 100;

            lblTongTien.Text = "Tong tien: "
                + tongTien.ToString("N0") + " VNĐ";
        }

        private void txtDongGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
