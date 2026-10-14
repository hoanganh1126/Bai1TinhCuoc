namespace Bai1TinhCuoc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDonGia = new Label();
            lblSoLuong = new Label();
            lblGiamGia = new Label();
            lblTongTien = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(12, 23);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(113, 20);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá dịch vụ";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(12, 80);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(111, 20);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng khách";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(12, 161);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(95, 20);
            lblGiamGia.TabIndex = 2;
            lblGiamGia.Text = "Giảm giá (%)\r\n";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(21, 222);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(122, 20);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng tiền : 0VND\r\n";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(296, 20);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 4;
            txtDonGia.TextChanged += txtDongGia_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(296, 80);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 5;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(296, 154);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 6;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(189, 271);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 7;
            btnTinhTien.Text = "Tính tiền\r\n";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += button1_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(327, 271);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới\r\n";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lblTongTien);
            Controls.Add(lblGiamGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblDonGia);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tinh cuoc dich vu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonGia;
        private Label lblSoLuong;
        private Label lblGiamGia;
        private Label lblTongTien;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}
