namespace BanHangDienTU
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.banHangDienTuDataSet = new BanHangDienTU.BanHangDienTuDataSet();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new BanHangDienTU.BanHangDienTuDataSetTableAdapters.SanPhamTableAdapter();
            this.tableAdapterManager = new BanHangDienTU.BanHangDienTuDataSetTableAdapters.TableAdapterManager();
            this.Hinh1 = new System.Windows.Forms.PictureBox();
            this.Ten1 = new System.Windows.Forms.Label();
            this.Hinh2 = new System.Windows.Forms.PictureBox();
            this.Hinh3 = new System.Windows.Forms.PictureBox();
            this.Ten2 = new System.Windows.Forms.Label();
            this.Ten3 = new System.Windows.Forms.Label();
            this.Gia1 = new System.Windows.Forms.Label();
            this.Gia3 = new System.Windows.Forms.Label();
            this.Gia2 = new System.Windows.Forms.Label();
            this.Hinh5 = new System.Windows.Forms.PictureBox();
            this.Hinh6 = new System.Windows.Forms.PictureBox();
            this.Hinh7 = new System.Windows.Forms.PictureBox();
            this.Ten5 = new System.Windows.Forms.Label();
            this.Gia5 = new System.Windows.Forms.Label();
            this.Ten6 = new System.Windows.Forms.Label();
            this.Gia6 = new System.Windows.Forms.Label();
            this.Ten7 = new System.Windows.Forms.Label();
            this.Gia7 = new System.Windows.Forms.Label();
            this.Hinh4 = new System.Windows.Forms.PictureBox();
            this.Hinh8 = new System.Windows.Forms.PictureBox();
            this.Hinh9 = new System.Windows.Forms.PictureBox();
            this.Ten4 = new System.Windows.Forms.Label();
            this.Gia4 = new System.Windows.Forms.Label();
            this.Ten8 = new System.Windows.Forms.Label();
            this.Gia8 = new System.Windows.Forms.Label();
            this.Ten9 = new System.Windows.Forms.Label();
            this.Gia9 = new System.Windows.Forms.Label();
            this.Hinh10 = new System.Windows.Forms.PictureBox();
            this.Ten10 = new System.Windows.Forms.Label();
            this.Gia10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDienTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Bán Lẻ Linh Kiện Điện Tử";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // banHangDienTuDataSet
            // 
            this.banHangDienTuDataSet.DataSetName = "BanHangDienTuDataSet";
            this.banHangDienTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.banHangDienTuDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SanPhamTableAdapter = this.sanPhamTableAdapter;
            this.tableAdapterManager.UpdateOrder = BanHangDienTU.BanHangDienTuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Hinh1
            // 
            this.Hinh1.Location = new System.Drawing.Point(90, 103);
            this.Hinh1.Name = "Hinh1";
            this.Hinh1.Size = new System.Drawing.Size(167, 153);
            this.Hinh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh1.TabIndex = 4;
            this.Hinh1.TabStop = false;
            this.Hinh1.Visible = false;
            this.Hinh1.Click += new System.EventHandler(this.Hinh1_Click);
            // 
            // Ten1
            // 
            this.Ten1.AutoSize = true;
            this.Ten1.Location = new System.Drawing.Point(138, 308);
            this.Ten1.Name = "Ten1";
            this.Ten1.Size = new System.Drawing.Size(41, 17);
            this.Ten1.TabIndex = 5;
            this.Ten1.Text = "Ten1";
            // 
            // Hinh2
            // 
            this.Hinh2.Location = new System.Drawing.Point(410, 103);
            this.Hinh2.Name = "Hinh2";
            this.Hinh2.Size = new System.Drawing.Size(167, 153);
            this.Hinh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh2.TabIndex = 4;
            this.Hinh2.TabStop = false;
            this.Hinh2.Visible = false;
            this.Hinh2.Click += new System.EventHandler(this.Hinh2_Click);
            // 
            // Hinh3
            // 
            this.Hinh3.Location = new System.Drawing.Point(771, 103);
            this.Hinh3.Name = "Hinh3";
            this.Hinh3.Size = new System.Drawing.Size(167, 153);
            this.Hinh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh3.TabIndex = 4;
            this.Hinh3.TabStop = false;
            this.Hinh3.Visible = false;
            this.Hinh3.Click += new System.EventHandler(this.Hinh3_Click);
            // 
            // Ten2
            // 
            this.Ten2.AutoSize = true;
            this.Ten2.Location = new System.Drawing.Point(462, 308);
            this.Ten2.Name = "Ten2";
            this.Ten2.Size = new System.Drawing.Size(41, 17);
            this.Ten2.TabIndex = 6;
            this.Ten2.Text = "Ten2";
            // 
            // Ten3
            // 
            this.Ten3.AutoSize = true;
            this.Ten3.Location = new System.Drawing.Point(826, 308);
            this.Ten3.Name = "Ten3";
            this.Ten3.Size = new System.Drawing.Size(41, 17);
            this.Ten3.TabIndex = 6;
            this.Ten3.Text = "Ten3";
            // 
            // Gia1
            // 
            this.Gia1.AutoSize = true;
            this.Gia1.Location = new System.Drawing.Point(141, 344);
            this.Gia1.Name = "Gia1";
            this.Gia1.Size = new System.Drawing.Size(38, 17);
            this.Gia1.TabIndex = 5;
            this.Gia1.Text = "Gia1";
            // 
            // Gia3
            // 
            this.Gia3.AutoSize = true;
            this.Gia3.Location = new System.Drawing.Point(826, 344);
            this.Gia3.Name = "Gia3";
            this.Gia3.Size = new System.Drawing.Size(46, 17);
            this.Gia3.TabIndex = 6;
            this.Gia3.Text = "label3";
            // 
            // Gia2
            // 
            this.Gia2.AutoSize = true;
            this.Gia2.Location = new System.Drawing.Point(462, 344);
            this.Gia2.Name = "Gia2";
            this.Gia2.Size = new System.Drawing.Size(46, 17);
            this.Gia2.TabIndex = 6;
            this.Gia2.Text = "label3";
            // 
            // Hinh5
            // 
            this.Hinh5.Location = new System.Drawing.Point(90, 385);
            this.Hinh5.Name = "Hinh5";
            this.Hinh5.Size = new System.Drawing.Size(167, 153);
            this.Hinh5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh5.TabIndex = 4;
            this.Hinh5.TabStop = false;
            this.Hinh5.Visible = false;
            this.Hinh5.Click += new System.EventHandler(this.Hinh5_Click);
            // 
            // Hinh6
            // 
            this.Hinh6.Location = new System.Drawing.Point(410, 385);
            this.Hinh6.Name = "Hinh6";
            this.Hinh6.Size = new System.Drawing.Size(167, 153);
            this.Hinh6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh6.TabIndex = 4;
            this.Hinh6.TabStop = false;
            this.Hinh6.Visible = false;
            this.Hinh6.Click += new System.EventHandler(this.Hinh6_Click);
            // 
            // Hinh7
            // 
            this.Hinh7.Location = new System.Drawing.Point(771, 385);
            this.Hinh7.Name = "Hinh7";
            this.Hinh7.Size = new System.Drawing.Size(167, 153);
            this.Hinh7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh7.TabIndex = 4;
            this.Hinh7.TabStop = false;
            this.Hinh7.Visible = false;
            this.Hinh7.Click += new System.EventHandler(this.Hinh7_Click);
            // 
            // Ten5
            // 
            this.Ten5.AutoSize = true;
            this.Ten5.Location = new System.Drawing.Point(126, 573);
            this.Ten5.Name = "Ten5";
            this.Ten5.Size = new System.Drawing.Size(41, 17);
            this.Ten5.TabIndex = 5;
            this.Ten5.Text = "Ten1";
            // 
            // Gia5
            // 
            this.Gia5.AutoSize = true;
            this.Gia5.Location = new System.Drawing.Point(121, 626);
            this.Gia5.Name = "Gia5";
            this.Gia5.Size = new System.Drawing.Size(46, 17);
            this.Gia5.TabIndex = 5;
            this.Gia5.Text = "label2";
            // 
            // Ten6
            // 
            this.Ten6.AutoSize = true;
            this.Ten6.Location = new System.Drawing.Point(462, 573);
            this.Ten6.Name = "Ten6";
            this.Ten6.Size = new System.Drawing.Size(41, 17);
            this.Ten6.TabIndex = 6;
            this.Ten6.Text = "Ten2";
            // 
            // Gia6
            // 
            this.Gia6.AutoSize = true;
            this.Gia6.Location = new System.Drawing.Point(457, 626);
            this.Gia6.Name = "Gia6";
            this.Gia6.Size = new System.Drawing.Size(46, 17);
            this.Gia6.TabIndex = 6;
            this.Gia6.Text = "label3";
            // 
            // Ten7
            // 
            this.Ten7.AutoSize = true;
            this.Ten7.Location = new System.Drawing.Point(826, 573);
            this.Ten7.Name = "Ten7";
            this.Ten7.Size = new System.Drawing.Size(41, 17);
            this.Ten7.TabIndex = 6;
            this.Ten7.Text = "Ten3";
            // 
            // Gia7
            // 
            this.Gia7.AutoSize = true;
            this.Gia7.Location = new System.Drawing.Point(821, 626);
            this.Gia7.Name = "Gia7";
            this.Gia7.Size = new System.Drawing.Size(46, 17);
            this.Gia7.TabIndex = 6;
            this.Gia7.Text = "label3";
            // 
            // Hinh4
            // 
            this.Hinh4.Location = new System.Drawing.Point(1087, 103);
            this.Hinh4.Name = "Hinh4";
            this.Hinh4.Size = new System.Drawing.Size(167, 153);
            this.Hinh4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh4.TabIndex = 4;
            this.Hinh4.TabStop = false;
            this.Hinh4.Visible = false;
            this.Hinh4.Click += new System.EventHandler(this.Hinh4_Click);
            // 
            // Hinh8
            // 
            this.Hinh8.Location = new System.Drawing.Point(1087, 385);
            this.Hinh8.Name = "Hinh8";
            this.Hinh8.Size = new System.Drawing.Size(167, 153);
            this.Hinh8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh8.TabIndex = 4;
            this.Hinh8.TabStop = false;
            this.Hinh8.Visible = false;
            this.Hinh8.Click += new System.EventHandler(this.Hinh8_Click);
            // 
            // Hinh9
            // 
            this.Hinh9.Location = new System.Drawing.Point(1476, 103);
            this.Hinh9.Name = "Hinh9";
            this.Hinh9.Size = new System.Drawing.Size(167, 153);
            this.Hinh9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh9.TabIndex = 4;
            this.Hinh9.TabStop = false;
            this.Hinh9.Visible = false;
            this.Hinh9.Click += new System.EventHandler(this.Hinh9_Click);
            // 
            // Ten4
            // 
            this.Ten4.AutoSize = true;
            this.Ten4.Location = new System.Drawing.Point(1132, 308);
            this.Ten4.Name = "Ten4";
            this.Ten4.Size = new System.Drawing.Size(41, 17);
            this.Ten4.TabIndex = 5;
            this.Ten4.Text = "Ten4";
            // 
            // Gia4
            // 
            this.Gia4.AutoSize = true;
            this.Gia4.Location = new System.Drawing.Point(1132, 344);
            this.Gia4.Name = "Gia4";
            this.Gia4.Size = new System.Drawing.Size(46, 17);
            this.Gia4.TabIndex = 5;
            this.Gia4.Text = "label2";
            // 
            // Ten8
            // 
            this.Ten8.AutoSize = true;
            this.Ten8.Location = new System.Drawing.Point(1132, 573);
            this.Ten8.Name = "Ten8";
            this.Ten8.Size = new System.Drawing.Size(41, 17);
            this.Ten8.TabIndex = 6;
            this.Ten8.Text = "Ten2";
            // 
            // Gia8
            // 
            this.Gia8.AutoSize = true;
            this.Gia8.Location = new System.Drawing.Point(1127, 626);
            this.Gia8.Name = "Gia8";
            this.Gia8.Size = new System.Drawing.Size(46, 17);
            this.Gia8.TabIndex = 6;
            this.Gia8.Text = "label3";
            // 
            // Ten9
            // 
            this.Ten9.AutoSize = true;
            this.Ten9.Location = new System.Drawing.Point(1533, 291);
            this.Ten9.Name = "Ten9";
            this.Ten9.Size = new System.Drawing.Size(41, 17);
            this.Ten9.TabIndex = 6;
            this.Ten9.Text = "Ten3";
            // 
            // Gia9
            // 
            this.Gia9.AutoSize = true;
            this.Gia9.Location = new System.Drawing.Point(1533, 344);
            this.Gia9.Name = "Gia9";
            this.Gia9.Size = new System.Drawing.Size(46, 17);
            this.Gia9.TabIndex = 6;
            this.Gia9.Text = "label3";
            // 
            // Hinh10
            // 
            this.Hinh10.Location = new System.Drawing.Point(1476, 385);
            this.Hinh10.Name = "Hinh10";
            this.Hinh10.Size = new System.Drawing.Size(167, 153);
            this.Hinh10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh10.TabIndex = 4;
            this.Hinh10.TabStop = false;
            this.Hinh10.Visible = false;
            this.Hinh10.Click += new System.EventHandler(this.Hinh10_Click);
            // 
            // Ten10
            // 
            this.Ten10.AutoSize = true;
            this.Ten10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten10.Location = new System.Drawing.Point(1528, 582);
            this.Ten10.Name = "Ten10";
            this.Ten10.Size = new System.Drawing.Size(43, 17);
            this.Ten10.TabIndex = 6;
            this.Ten10.Text = "Ten3";
            // 
            // Gia10
            // 
            this.Gia10.AutoSize = true;
            this.Gia10.Location = new System.Drawing.Point(1528, 641);
            this.Gia10.Name = "Gia10";
            this.Gia10.Size = new System.Drawing.Size(46, 17);
            this.Gia10.TabIndex = 6;
            this.Gia10.Text = "label3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1051);
            this.Controls.Add(this.Gia10);
            this.Controls.Add(this.Gia9);
            this.Controls.Add(this.Gia7);
            this.Controls.Add(this.Gia3);
            this.Controls.Add(this.Ten10);
            this.Controls.Add(this.Ten9);
            this.Controls.Add(this.Ten7);
            this.Controls.Add(this.Ten3);
            this.Controls.Add(this.Gia8);
            this.Controls.Add(this.Gia6);
            this.Controls.Add(this.Gia2);
            this.Controls.Add(this.Ten8);
            this.Controls.Add(this.Ten6);
            this.Controls.Add(this.Ten2);
            this.Controls.Add(this.Gia4);
            this.Controls.Add(this.Gia5);
            this.Controls.Add(this.Ten4);
            this.Controls.Add(this.Ten5);
            this.Controls.Add(this.Gia1);
            this.Controls.Add(this.Hinh10);
            this.Controls.Add(this.Hinh9);
            this.Controls.Add(this.Hinh7);
            this.Controls.Add(this.Ten1);
            this.Controls.Add(this.Hinh8);
            this.Controls.Add(this.Hinh6);
            this.Controls.Add(this.Hinh3);
            this.Controls.Add(this.Hinh4);
            this.Controls.Add(this.Hinh5);
            this.Controls.Add(this.Hinh2);
            this.Controls.Add(this.Hinh1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banHangDienTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BanHangDienTuDataSet banHangDienTuDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private BanHangDienTuDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private BanHangDienTuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox Hinh1;
        private System.Windows.Forms.Label Ten1;
        private System.Windows.Forms.PictureBox Hinh2;
        private System.Windows.Forms.PictureBox Hinh3;
        private System.Windows.Forms.Label Ten2;
        private System.Windows.Forms.Label Ten3;
        private System.Windows.Forms.Label Gia1;
        private System.Windows.Forms.Label Gia3;
        private System.Windows.Forms.Label Gia2;
        private System.Windows.Forms.PictureBox Hinh5;
        private System.Windows.Forms.PictureBox Hinh6;
        private System.Windows.Forms.PictureBox Hinh7;
        private System.Windows.Forms.Label Ten5;
        private System.Windows.Forms.Label Gia5;
        private System.Windows.Forms.Label Ten6;
        private System.Windows.Forms.Label Gia6;
        private System.Windows.Forms.Label Ten7;
        private System.Windows.Forms.Label Gia7;
        private System.Windows.Forms.PictureBox Hinh4;
        private System.Windows.Forms.PictureBox Hinh8;
        private System.Windows.Forms.PictureBox Hinh9;
        private System.Windows.Forms.Label Ten4;
        private System.Windows.Forms.Label Gia4;
        private System.Windows.Forms.Label Ten8;
        private System.Windows.Forms.Label Gia8;
        private System.Windows.Forms.Label Ten9;
        private System.Windows.Forms.Label Gia9;
        private System.Windows.Forms.PictureBox Hinh10;
        private System.Windows.Forms.Label Ten10;
        private System.Windows.Forms.Label Gia10;
    }
}