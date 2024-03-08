namespace WindowsFormsApp1
{
    partial class FormTracNghiem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbSec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmCount = new System.Windows.Forms.Timer(this.components);
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRadio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(219, 504);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelRadio
            // 
            this.panelRadio.Controls.Add(this.radioButton1);
            this.panelRadio.Controls.Add(this.radioButton2);
            this.panelRadio.Controls.Add(this.radioButton3);
            this.panelRadio.Controls.Add(this.radioButton4);
            this.panelRadio.Location = new System.Drawing.Point(47, 134);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(489, 259);
            this.panelRadio.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 202);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 143);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(81, 154);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(60, 42);
            this.lbSec.TabIndex = 2;
            this.lbSec.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian còn lại";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(994, 68);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(0, 42);
            this.lbMin.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1060, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 46);
            this.label6.TabIndex = 5;
            // 
            // tmCount
            // 
            this.tmCount.Interval = 1000;
            this.tmCount.Tick += new System.EventHandler(this.tmCount_Tick);
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNopBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(58, 328);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(101, 31);
            this.btnNopBai.TabIndex = 6;
            this.btnNopBai.Text = "Nộp Bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(316, 24);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(99, 34);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Câu tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(48, 24);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(105, 34);
            this.btnTruoc.TabIndex = 8;
            this.btnTruoc.Text = "Câu trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(619, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 539);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi?";
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Location = new System.Drawing.Point(24, 33);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(63, 16);
            this.lbCauHoi.TabIndex = 1;
            this.lbCauHoi.Text = "lbCauHoi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(47, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 89);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTruoc);
            this.panel1.Controls.Add(this.btnTiep);
            this.panel1.Location = new System.Drawing.Point(47, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNopBai);
            this.panel2.Controls.Add(this.lbSec);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(964, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 481);
            this.panel2.TabIndex = 12;
            // 
            // FormTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.panelRadio);
            this.Name = "FormTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTracNghiem";
            this.Load += new System.EventHandler(this.FormTracNghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmCount;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}