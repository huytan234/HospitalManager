namespace QL_BenhVien
{
    partial class FrmBenhNhanDangNhap
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
            this.mTBSo1 = new System.Windows.Forms.MaskedTextBox();
            this.lnkDangki = new System.Windows.Forms.LinkLabel();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTBSo1
            // 
            this.mTBSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mTBSo1.Location = new System.Drawing.Point(290, 145);
            this.mTBSo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mTBSo1.Name = "mTBSo1";
            this.mTBSo1.Size = new System.Drawing.Size(259, 39);
            this.mTBSo1.TabIndex = 18;
            // 
            // lnkDangki
            // 
            this.lnkDangki.AutoSize = true;
            this.lnkDangki.BackColor = System.Drawing.Color.White;
            this.lnkDangki.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDangki.Location = new System.Drawing.Point(132, 345);
            this.lnkDangki.Name = "lnkDangki";
            this.lnkDangki.Size = new System.Drawing.Size(122, 37);
            this.lnkDangki.TabIndex = 17;
            this.lnkDangki.TabStop = true;
            this.lnkDangki.Text = "Đăng kí";
            this.lnkDangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangki_LinkClicked);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(337, 336);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(163, 60);
            this.btnDangnhap.TabIndex = 15;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSo2.Location = new System.Drawing.Point(290, 251);
            this.txtSo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(259, 39);
            this.txtSo2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(243, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImage = global::QL_BenhVien.Properties.Resources.images;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(707, 345);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(49, 38);
            this.btnback.TabIndex = 16;
            this.btnback.Text = " ";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // FrmBenhNhanDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mTBSo1);
            this.Controls.Add(this.lnkDangki);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBenhNhanDangNhap";
            this.Text = "FrmBenhNhanDangNhap";
            this.Load += new System.EventHandler(this.FrmBenhNhanDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mTBSo1;
        private System.Windows.Forms.LinkLabel lnkDangki;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}