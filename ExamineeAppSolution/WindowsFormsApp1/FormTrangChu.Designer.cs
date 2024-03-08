namespace WindowsFormsApp1
{
    partial class FormTrangChu
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
            this.tabTTCaNhan = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.laa = new System.Windows.Forms.Label();
            this.tabCauHoi = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCauHoi = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTTCaNhan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCauHoi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCauHoi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTTCaNhan
            // 
            this.tabTTCaNhan.Controls.Add(this.label2);
            this.tabTTCaNhan.Controls.Add(this.panel3);
            this.tabTTCaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabTTCaNhan.Name = "tabTTCaNhan";
            this.tabTTCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTTCaNhan.Size = new System.Drawing.Size(1017, 527);
            this.tabTTCaNhan.TabIndex = 1;
            this.tabTTCaNhan.Text = "Thông tin cá nhân";
            this.tabTTCaNhan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin cá nhân";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtGioiTinh);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbID);
            this.panel3.Controls.Add(this.l);
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Controls.Add(this.laa);
            this.panel3.Location = new System.Drawing.Point(194, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 371);
            this.panel3.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightGray;
            this.btnCapNhat.Location = new System.Drawing.Point(17, 337);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 31);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(293, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 27);
            this.txtEmail.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(293, 226);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 27);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(293, 189);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "SDT :";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(293, 146);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(193, 27);
            this.txtGioiTinh.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(293, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 27);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa Chỉ :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(289, 55);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 24);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(161, 100);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(113, 24);
            this.l.TabIndex = 2;
            this.l.Text = "Họ và tên :";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGray;
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(561, 337);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 31);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // laa
            // 
            this.laa.AutoSize = true;
            this.laa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laa.Location = new System.Drawing.Point(232, 55);
            this.laa.Name = "laa";
            this.laa.Size = new System.Drawing.Size(42, 24);
            this.laa.TabIndex = 0;
            this.laa.Text = "ID :";
            // 
            // tabCauHoi
            // 
            this.tabCauHoi.Controls.Add(this.label7);
            this.tabCauHoi.Controls.Add(this.panel2);
            this.tabCauHoi.Controls.Add(this.panel1);
            this.tabCauHoi.Location = new System.Drawing.Point(4, 25);
            this.tabCauHoi.Name = "tabCauHoi";
            this.tabCauHoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabCauHoi.Size = new System.Drawing.Size(1017, 527);
            this.tabCauHoi.TabIndex = 0;
            this.tabCauHoi.Text = "Ngân hàng câu hỏi";
            this.tabCauHoi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Danh sách đề thi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(522, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(115, 7);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 31);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(226, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(248, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewCauHoi);
            this.panel1.Location = new System.Drawing.Point(3, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 385);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewCauHoi
            // 
            this.dataGridViewCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCauHoi.Location = new System.Drawing.Point(30, 9);
            this.dataGridViewCauHoi.Name = "dataGridViewCauHoi";
            this.dataGridViewCauHoi.RowHeadersWidth = 51;
            this.dataGridViewCauHoi.RowTemplate.Height = 24;
            this.dataGridViewCauHoi.Size = new System.Drawing.Size(956, 356);
            this.dataGridViewCauHoi.TabIndex = 0;
            this.dataGridViewCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCauHoi_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCauHoi);
            this.tabControl1.Controls.Add(this.tabTTCaNhan);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.tabTTCaNhan.ResumeLayout(false);
            this.tabTTCaNhan.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCauHoi.ResumeLayout(false);
            this.tabCauHoi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCauHoi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabTTCaNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label laa;
        private System.Windows.Forms.TabPage tabCauHoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCauHoi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
    }
}