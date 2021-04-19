namespace BanHangDienTU
{
    partial class Cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComeBack = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btthanhtoan = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.Label();
            this.Thongbao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giỏ Hàng ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 343);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // ComeBack
            // 
            this.ComeBack.BackColor = System.Drawing.Color.Black;
            this.ComeBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComeBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComeBack.Location = new System.Drawing.Point(13, 26);
            this.ComeBack.Name = "ComeBack";
            this.ComeBack.Size = new System.Drawing.Size(147, 53);
            this.ComeBack.TabIndex = 3;
            this.ComeBack.Text = "Quay Lại";
            this.ComeBack.UseVisualStyleBackColor = false;
            this.ComeBack.Click += new System.EventHandler(this.ComeBack_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BackColor = System.Drawing.Color.Teal;
            this.btcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcapnhat.Location = new System.Drawing.Point(686, 502);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(134, 38);
            this.btcapnhat.TabIndex = 4;
            this.btcapnhat.Text = "Cập Nhật ";
            this.btcapnhat.UseVisualStyleBackColor = false;
            this.btcapnhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thành Tiền";
            // 
            // Btthanhtoan
            // 
            this.Btthanhtoan.BackColor = System.Drawing.Color.Teal;
            this.Btthanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btthanhtoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btthanhtoan.Location = new System.Drawing.Point(879, 502);
            this.Btthanhtoan.Name = "Btthanhtoan";
            this.Btthanhtoan.Size = new System.Drawing.Size(149, 38);
            this.Btthanhtoan.TabIndex = 4;
            this.Btthanhtoan.Text = "Thanh Toán";
            this.Btthanhtoan.UseVisualStyleBackColor = false;
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
            // Thongbao
            // 
            this.Thongbao.AutoSize = true;
            this.Thongbao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thongbao.Location = new System.Drawing.Point(200, 83);
            this.Thongbao.Name = "Thongbao";
            this.Thongbao.Size = new System.Drawing.Size(74, 26);
            this.Thongbao.TabIndex = 8;
            this.Thongbao.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1088, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1319, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Thongbao);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btthanhtoan);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.ComeBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cart_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ComeBack;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btthanhtoan;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Label Thongbao;
        private System.Windows.Forms.Button button1;
    }
}