
namespace Lab03_03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtDau = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinDonHang
            // 
            this.grbThongTinDonHang.Controls.Add(this.checkBox1);
            this.grbThongTinDonHang.Controls.Add(this.label2);
            this.grbThongTinDonHang.Controls.Add(this.label1);
            this.grbThongTinDonHang.Controls.Add(this.dtCuoi);
            this.grbThongTinDonHang.Controls.Add(this.dtDau);
            this.grbThongTinDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinDonHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDonHang.ForeColor = System.Drawing.Color.White;
            this.grbThongTinDonHang.Location = new System.Drawing.Point(10, 10);
            this.grbThongTinDonHang.Name = "grbThongTinDonHang";
            this.grbThongTinDonHang.Size = new System.Drawing.Size(780, 150);
            this.grbThongTinDonHang.TabIndex = 0;
            this.grbThongTinDonHang.TabStop = false;
            this.grbThongTinDonHang.Text = "Thông Tin Đơn Hàng";
            this.grbThongTinDonHang.Enter += new System.EventHandler(this.grbThongTinDonHang_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Xem tất cả trong tháng";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian giao hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "~";
            // 
            // dtCuoi
            // 
            this.dtCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCuoi.Location = new System.Drawing.Point(448, 89);
            this.dtCuoi.Name = "dtCuoi";
            this.dtCuoi.Size = new System.Drawing.Size(200, 28);
            this.dtCuoi.TabIndex = 1;
            this.dtCuoi.CloseUp += new System.EventHandler(this.dtCuoi_CloseUp);
            this.dtCuoi.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtDau
            // 
            this.dtDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDau.Location = new System.Drawing.Point(197, 89);
            this.dtDau.Name = "dtDau";
            this.dtDau.Size = new System.Drawing.Size(200, 28);
            this.dtDau.TabIndex = 0;
            this.dtDau.CloseUp += new System.EventHandler(this.dtDau_CloseUp);
            this.dtDau.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHD,
            this.NgayDat,
            this.NgayGiap,
            this.ThanhTIen});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // SoHD
            // 
            this.SoHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoHD.HeaderText = "SoHD";
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDat.HeaderText = "Ngay Dat Hang";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // NgayGiap
            // 
            this.NgayGiap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGiap.HeaderText = "Ngay Giao hang";
            this.NgayGiap.Name = "NgayGiap";
            this.NgayGiap.ReadOnly = true;
            // 
            // ThanhTIen
            // 
            this.ThanhTIen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTIen.HeaderText = "Thanh Tien";
            this.ThanhTIen.Name = "ThanhTIen";
            this.ThanhTIen.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongTinDonHang);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTinDonHang.ResumeLayout(false);
            this.grbThongTinDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinDonHang;
        private System.Windows.Forms.DateTimePicker dtDau;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtCuoi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTIen;
    }
}

