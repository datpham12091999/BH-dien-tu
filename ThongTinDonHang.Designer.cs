namespace BanHangDienTU
{
    partial class ThongTinDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDonHang));
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbMaDH = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbNgayDH = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Quả Tìm Kiếm Đơn Hàng";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(23, 146);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(187, 32);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã Đơn Hàng";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(23, 288);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(200, 32);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "Ngày Đặt Hàng";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(23, 222);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(110, 32);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Đơn giá";
            // 
            // lbMaDH
            // 
            this.lbMaDH.AutoSize = true;
            this.lbMaDH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDH.Location = new System.Drawing.Point(422, 146);
            this.lbMaDH.Name = "lbMaDH";
            this.lbMaDH.Size = new System.Drawing.Size(177, 32);
            this.lbMaDH.TabIndex = 0;
            this.lbMaDH.Text = "Mã đơn hàng";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(422, 222);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(154, 32);
            this.lbThanhTien.TabIndex = 0;
            this.lbThanhTien.Text = "Thành Tiền";
            // 
            // lbNgayDH
            // 
            this.lbNgayDH.Enabled = false;
            this.lbNgayDH.Location = new System.Drawing.Point(428, 297);
            this.lbNgayDH.Name = "lbNgayDH";
            this.lbNgayDH.Size = new System.Drawing.Size(222, 22);
            this.lbNgayDH.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(382, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 40);
            this.textBox1.TabIndex = 2;
            // 
            // TK
            // 
            this.TK.BackColor = System.Drawing.Color.Blue;
            this.TK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TK.Location = new System.Drawing.Point(925, 75);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(155, 55);
            this.TK.TabIndex = 3;
            this.TK.Text = "Tìm Kiếm";
            this.TK.UseVisualStyleBackColor = false;
            this.TK.Click += new System.EventHandler(this.TK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập Mã Đơn Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chi Tiết Đơn Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1214, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThongTinDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1344, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNgayDH);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbMaDH);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongTinDonHang";
            this.Text = "Thông tin đơn hàng";
            this.Load += new System.EventHandler(this.TKDH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbMaDH;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.DateTimePicker lbNgayDH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}