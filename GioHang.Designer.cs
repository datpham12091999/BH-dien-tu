namespace BanHangDienTU
{
    partial class GioHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComeBack = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btthanhtoan = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Thongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 343);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // ComeBack
            // 
            this.ComeBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComeBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComeBack.ForeColor = System.Drawing.Color.Snow;
            this.ComeBack.Location = new System.Drawing.Point(1167, 492);
            this.ComeBack.Name = "ComeBack";
            this.ComeBack.Size = new System.Drawing.Size(126, 38);
            this.ComeBack.TabIndex = 3;
            this.ComeBack.Text = "Back";
            this.ComeBack.UseVisualStyleBackColor = false;
            this.ComeBack.Click += new System.EventHandler(this.ComeBack_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(455, 492);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(134, 38);
            this.btcapnhat.TabIndex = 4;
            this.btcapnhat.Text = "Cập Nhật ";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá";
            // 
            // Btthanhtoan
            // 
            this.Btthanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btthanhtoan.Location = new System.Drawing.Point(648, 492);
            this.Btthanhtoan.Name = "Btthanhtoan";
            this.Btthanhtoan.Size = new System.Drawing.Size(149, 38);
            this.Btthanhtoan.TabIndex = 4;
            this.Btthanhtoan.Text = "Thanh Toán";
            this.Btthanhtoan.UseVisualStyleBackColor = true;
            this.Btthanhtoan.Click += new System.EventHandler(this.button2_Click);
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TT.Location = new System.Drawing.Point(212, 492);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(0, 32);
            this.TT.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(857, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Thongbao
            // 
            this.Thongbao.AutoSize = true;
            this.Thongbao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thongbao.Location = new System.Drawing.Point(176, 58);
            this.Thongbao.Name = "Thongbao";
            this.Thongbao.Size = new System.Drawing.Size(138, 35);
            this.Thongbao.TabIndex = 8;
            this.Thongbao.Text = "Giỏ Hàng";
            this.Thongbao.Click += new System.EventHandler(this.Thongbao_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1319, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Thongbao);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btthanhtoan);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.ComeBack);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "GioHang";
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cart_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ComeBack;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btthanhtoan;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Thongbao;
    }
}