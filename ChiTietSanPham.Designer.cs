namespace BanHangDienTU
{
    partial class ChiTietSanPham
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
            this.Gia1 = new System.Windows.Forms.Label();
            this.Ten1 = new System.Windows.Forms.Label();
            this.Hinh1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gia1
            // 
            this.Gia1.AutoSize = true;
            this.Gia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia1.ForeColor = System.Drawing.Color.Red;
            this.Gia1.Location = new System.Drawing.Point(1040, 358);
            this.Gia1.Name = "Gia1";
            this.Gia1.Size = new System.Drawing.Size(80, 32);
            this.Gia1.TabIndex = 8;
            this.Gia1.Text = "Gia1";
            // 
            // Ten1
            // 
            this.Ten1.AutoSize = true;
            this.Ten1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten1.Location = new System.Drawing.Point(855, 183);
            this.Ten1.Name = "Ten1";
            this.Ten1.Size = new System.Drawing.Size(98, 43);
            this.Ten1.TabIndex = 7;
            this.Ten1.Text = "Ten1";
            // 
            // Hinh1
            // 
            this.Hinh1.Location = new System.Drawing.Point(376, 133);
            this.Hinh1.Name = "Hinh1";
            this.Hinh1.Size = new System.Drawing.Size(438, 397);
            this.Hinh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh1.TabIndex = 6;
            this.Hinh1.TabStop = false;
            this.Hinh1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đặt Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(703, 635);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 87);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1146, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 81);
            this.button3.TabIndex = 11;
            this.button3.Text = "Giỏ Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(857, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Giá Bán";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(848, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 87);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1323, 843);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gia1);
            this.Controls.Add(this.Ten1);
            this.Controls.Add(this.Hinh1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "ChiTietSanPham";
            this.Text = "Chi Tiết Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTSP_FormClosing);
            this.Load += new System.EventHandler(this.CTSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hinh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gia1;
        private System.Windows.Forms.Label Ten1;
        private System.Windows.Forms.PictureBox Hinh1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}