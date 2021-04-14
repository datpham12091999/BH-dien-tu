namespace BanHangDienTU
{
    partial class CTSP
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
            ((System.ComponentModel.ISupportInitialize)(this.Hinh1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gia1
            // 
            this.Gia1.AutoSize = true;
            this.Gia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia1.ForeColor = System.Drawing.Color.Red;
            this.Gia1.Location = new System.Drawing.Point(665, 246);
            this.Gia1.Name = "Gia1";
            this.Gia1.Size = new System.Drawing.Size(80, 32);
            this.Gia1.TabIndex = 8;
            this.Gia1.Text = "Gia1";
            // 
            // Ten1
            // 
            this.Ten1.AutoSize = true;
            this.Ten1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten1.Location = new System.Drawing.Point(504, 81);
            this.Ten1.Name = "Ten1";
            this.Ten1.Size = new System.Drawing.Size(84, 32);
            this.Ten1.TabIndex = 7;
            this.Ten1.Text = "Ten1";
            // 
            // Hinh1
            // 
            this.Hinh1.Location = new System.Drawing.Point(46, 81);
            this.Hinh1.Name = "Hinh1";
            this.Hinh1.Size = new System.Drawing.Size(438, 374);
            this.Hinh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh1.TabIndex = 6;
            this.Hinh1.TabStop = false;
            this.Hinh1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đặt Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1044, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Giỏ Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Giá Bán";
            // 
            // CTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 793);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gia1);
            this.Controls.Add(this.Ten1);
            this.Controls.Add(this.Hinh1);
            this.Name = "CTSP";
            this.Text = "CTSP";
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
    }
}