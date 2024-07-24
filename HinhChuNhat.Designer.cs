namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDai = new TextBox();
            txtRong = new TextBox();
            label4 = new Label();
            lblKQ = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            btnDienTich = new Button();
            btnChuVi = new Button();
            groupBox1 = new GroupBox();
            rdoDT = new RadioButton();
            rdoCV = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            New = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(789, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 1;
            label2.Text = "Chiều dài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(22, 142);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 2;
            label3.Text = "Chiều rộng";
            // 
            // txtDai
            // 
            txtDai.Location = new Point(186, 79);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(219, 40);
            txtDai.TabIndex = 3;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(186, 139);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(219, 40);
            txtRong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 2;
            label4.Text = "Kết quả";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Tahoma", 20F);
            lblKQ.Location = new Point(186, 202);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(22, 267);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(144, 56);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(625, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(22, 344);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(168, 56);
            btnDienTich.TabIndex = 6;
            btnDienTich.Text = "DIỆN TÍCH";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(237, 344);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(168, 56);
            btnChuVi.TabIndex = 6;
            btnChuVi.Text = "CHU VI";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDT);
            groupBox1.Controls.Add(rdoCV);
            groupBox1.Location = new Point(501, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 154);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn chức năng";
            // 
            // rdoDT
            // 
            rdoDT.AutoSize = true;
            rdoDT.Location = new Point(20, 98);
            rdoDT.Name = "rdoDT";
            rdoDT.Size = new Size(136, 37);
            rdoDT.TabIndex = 0;
            rdoDT.TabStop = true;
            rdoDT.Text = "Diện tích";
            rdoDT.UseVisualStyleBackColor = true;
            // 
            // rdoCV
            // 
            rdoCV.AutoSize = true;
            rdoCV.Location = new Point(20, 49);
            rdoCV.Name = "rdoCV";
            rdoCV.Size = new Size(106, 37);
            rdoCV.TabIndex = 0;
            rdoCV.TabStop = true;
            rdoCV.Text = "Chu vi";
            rdoCV.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(255, 192, 192);
            New.ForeColor = Color.Black;
            New.Location = new Point(437, 344);
            New.Name = "New";
            New.Size = new Size(155, 56);
            New.TabIndex = 5;
            New.Text = "TÍNH NEW";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // button2
            // 
            button2.Location = new Point(625, 344);
            button2.Name = "button2";
            button2.Size = new Size(168, 56);
            button2.TabIndex = 5;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(501, 82);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 40);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 412);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox1);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(button2);
            Controls.Add(btnThoat);
            Controls.Add(New);
            Controls.Add(btnTinh);
            Controls.Add(lblKQ);
            Controls.Add(txtRong);
            Controls.Add(txtDai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhChuNhat";
            Text = "HÌNH CHỮ NHẬT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDai;
        private TextBox txtRong;
        private Label label4;
        private Label lblKQ;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnDienTich;
        private Button btnChuVi;
        private GroupBox groupBox1;
        private RadioButton rdoDT;
        private RadioButton rdoCV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button New;
        private Button button2;
        private NumericUpDown numericUpDown1;
    }
}
