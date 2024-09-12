
namespace QL_BenhVien
{
    partial class FrmQuanLyBenhNhan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtIdTK = new System.Windows.Forms.MaskedTextBox();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btn_editBN = new System.Windows.Forms.Button();
            this.btnTimTheoGT = new System.Windows.Forms.Button();
            this.btn_deleteBN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtenAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIdTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvBenhNhan);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.txtIdTK);
            this.groupBox2.Controls.Add(this.cmbGT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTimTheoTen);
            this.groupBox2.Controls.Add(this.btn_editBN);
            this.groupBox2.Controls.Add(this.btnTimTheoGT);
            this.groupBox2.Controls.Add(this.btn_deleteBN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1597, 555);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Bệnh Nhân";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(230, 39);
            this.txtId.Mask = "00000000000";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(209, 40);
            this.txtId.TabIndex = 20;
            this.txtId.ValidatingType = typeof(int);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(230, 260);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(209, 40);
            this.txtSDT.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(230, 95);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(209, 40);
            this.txtHo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Họ:";
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Location = new System.Drawing.Point(492, 29);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersWidth = 62;
            this.dgvBenhNhan.RowTemplate.Height = 28;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1099, 515);
            this.dgvBenhNhan.TabIndex = 15;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(230, 144);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(209, 40);
            this.txtTen.TabIndex = 14;
            // 
            // txtIdTK
            // 
            this.txtIdTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTK.Location = new System.Drawing.Point(230, 324);
            this.txtIdTK.Mask = "00000000000";
            this.txtIdTK.Name = "txtIdTK";
            this.txtIdTK.ReadOnly = true;
            this.txtIdTK.Size = new System.Drawing.Size(209, 40);
            this.txtIdTK.TabIndex = 12;
            this.txtIdTK.ValidatingType = typeof(int);
            this.txtIdTK.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // cmbGT
            // 
            this.cmbGT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Location = new System.Drawing.Point(230, 201);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(209, 41);
            this.cmbGT.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tài Khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimTheoTen.Location = new System.Drawing.Point(256, 387);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(183, 42);
            this.btnTimTheoTen.TabIndex = 1;
            this.btnTimTheoTen.Text = "Tìm theo tên";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btn_editBN
            // 
            this.btn_editBN.Location = new System.Drawing.Point(6, 459);
            this.btn_editBN.Name = "btn_editBN";
            this.btn_editBN.Size = new System.Drawing.Size(184, 42);
            this.btn_editBN.TabIndex = 1;
            this.btn_editBN.Text = "Sửa";
            this.btn_editBN.UseVisualStyleBackColor = true;
            this.btn_editBN.Click += new System.EventHandler(this.btn_editBN_Click);
            // 
            // btnTimTheoGT
            // 
            this.btnTimTheoGT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimTheoGT.Location = new System.Drawing.Point(6, 387);
            this.btnTimTheoGT.Name = "btnTimTheoGT";
            this.btnTimTheoGT.Size = new System.Drawing.Size(184, 42);
            this.btnTimTheoGT.TabIndex = 1;
            this.btnTimTheoGT.Text = "Tìm theo giới tính";
            this.btnTimTheoGT.UseVisualStyleBackColor = true;
            this.btnTimTheoGT.Click += new System.EventHandler(this.btnTimTheoGT_Click);
            // 
            // btn_deleteBN
            // 
            this.btn_deleteBN.Location = new System.Drawing.Point(256, 459);
            this.btn_deleteBN.Name = "btn_deleteBN";
            this.btn_deleteBN.Size = new System.Drawing.Size(183, 42);
            this.btn_deleteBN.TabIndex = 1;
            this.btn_deleteBN.Text = "Xóa";
            this.btn_deleteBN.UseVisualStyleBackColor = true;
            this.btn_deleteBN.Click += new System.EventHandler(this.btn_deleteBN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbtenAdmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbIdTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Admin";
            // 
            // lbtenAdmin
            // 
            this.lbtenAdmin.AutoSize = true;
            this.lbtenAdmin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenAdmin.Location = new System.Drawing.Point(178, 79);
            this.lbtenAdmin.Name = "lbtenAdmin";
            this.lbtenAdmin.Size = new System.Drawing.Size(43, 33);
            this.lbtenAdmin.TabIndex = 7;
            this.lbtenAdmin.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Admin:";
            // 
            // lbIdTK
            // 
            this.lbIdTK.AutoSize = true;
            this.lbIdTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdTK.Location = new System.Drawing.Point(178, 37);
            this.lbIdTK.Name = "lbIdTK";
            this.lbIdTK.Size = new System.Drawing.Size(169, 33);
            this.lbIdTK.TabIndex = 5;
            this.lbIdTK.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Tài Khoản :";
            // 
            // FrmQuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmQuanLyBenhNhan";
            this.Text = "FrmQuanLyBenhNhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuanLyBN_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuanLyBenhNhan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btn_editBN;
        private System.Windows.Forms.Button btnTimTheoGT;
        private System.Windows.Forms.Button btn_deleteBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtenAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIdTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.MaskedTextBox txtIdTK;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtId;
    }
}