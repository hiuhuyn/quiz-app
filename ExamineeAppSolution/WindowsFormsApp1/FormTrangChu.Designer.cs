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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCauHoi = new System.Windows.Forms.TabPage();
            this.tabTTCaNhan = new System.Windows.Forms.TabPage();
            this.tabKetQua = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.laa = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCauHoi.SuspendLayout();
            this.tabTTCaNhan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCauHoi);
            this.tabControl1.Controls.Add(this.tabTTCaNhan);
            this.tabControl1.Controls.Add(this.tabKetQua);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCauHoi
            // 
            this.tabCauHoi.Controls.Add(this.panel2);
            this.tabCauHoi.Controls.Add(this.panel1);
            this.tabCauHoi.Location = new System.Drawing.Point(4, 25);
            this.tabCauHoi.Name = "tabCauHoi";
            this.tabCauHoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabCauHoi.Size = new System.Drawing.Size(1094, 527);
            this.tabCauHoi.TabIndex = 0;
            this.tabCauHoi.Text = "Ngân hàng câu hỏi";
            this.tabCauHoi.UseVisualStyleBackColor = true;
            // 
            // tabTTCaNhan
            // 
            this.tabTTCaNhan.Controls.Add(this.panel3);
            this.tabTTCaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabTTCaNhan.Name = "tabTTCaNhan";
            this.tabTTCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTTCaNhan.Size = new System.Drawing.Size(1094, 527);
            this.tabTTCaNhan.TabIndex = 1;
            this.tabTTCaNhan.Text = "Thông tin cá nhân";
            this.tabTTCaNhan.UseVisualStyleBackColor = true;
            // 
            // tabKetQua
            // 
            this.tabKetQua.Location = new System.Drawing.Point(4, 25);
            this.tabKetQua.Name = "tabKetQua";
            this.tabKetQua.Size = new System.Drawing.Size(1094, 527);
            this.tabKetQua.TabIndex = 2;
            this.tabKetQua.Text = "Xem kết quả thi";
            this.tabKetQua.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 469);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.lbTimKiem);
            this.panel2.Location = new System.Drawing.Point(33, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 39);
            this.panel2.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(150, 6);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 21);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(247, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(449, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.lbID);
            this.panel3.Controls.Add(this.l);
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Controls.Add(this.laa);
            this.panel3.Location = new System.Drawing.Point(100, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 446);
            this.panel3.TabIndex = 0;
            // 
            // laa
            // 
            this.laa.AutoSize = true;
            this.laa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laa.Location = new System.Drawing.Point(244, 43);
            this.laa.Name = "laa";
            this.laa.Size = new System.Drawing.Size(42, 24);
            this.laa.TabIndex = 0;
            this.laa.Text = "ID :";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(355, 304);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 31);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(210, 110);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(76, 24);
            this.l.TabIndex = 2;
            this.l.Text = "Name :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(321, 43);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 24);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(321, 110);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(27, 24);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "ID";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTrangChu";
            this.Text = "TrangChu";
            this.tabControl1.ResumeLayout(false);
            this.tabCauHoi.ResumeLayout(false);
            this.tabTTCaNhan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCauHoi;
        private System.Windows.Forms.TabPage tabTTCaNhan;
        private System.Windows.Forms.TabPage tabKetQua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label laa;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label l;
    }
}