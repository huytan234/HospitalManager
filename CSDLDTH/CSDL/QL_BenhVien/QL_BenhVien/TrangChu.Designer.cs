
namespace QL_BenhVien
{
    partial class TrangChu
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
            this.txt_bn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ad = new System.Windows.Forms.Button();
            this.btn_BS = new System.Windows.Forms.Button();
            this.btn_BN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_bn
            // 
            this.txt_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bn.Location = new System.Drawing.Point(32, 91);
            this.txt_bn.Name = "txt_bn";
            this.txt_bn.Size = new System.Drawing.Size(237, 44);
            this.txt_bn.TabIndex = 2;
            this.txt_bn.Text = "Bệnh Nhân";
            this.txt_bn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bác Sĩ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ad
            // 
            this.btn_ad.BackgroundImage = global::QL_BenhVien.Properties.Resources.admim;
            this.btn_ad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ad.Location = new System.Drawing.Point(626, 152);
            this.btn_ad.Name = "btn_ad";
            this.btn_ad.Size = new System.Drawing.Size(232, 186);
            this.btn_ad.TabIndex = 1;
            this.btn_ad.UseVisualStyleBackColor = true;
            this.btn_ad.Click += new System.EventHandler(this.btn_ad_Click);
            // 
            // btn_BS
            // 
            this.btn_BS.BackgroundImage = global::QL_BenhVien.Properties.Resources.doctor;
            this.btn_BS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BS.Location = new System.Drawing.Point(343, 152);
            this.btn_BS.Name = "btn_BS";
            this.btn_BS.Size = new System.Drawing.Size(232, 186);
            this.btn_BS.TabIndex = 1;
            this.btn_BS.UseVisualStyleBackColor = true;
            this.btn_BS.Click += new System.EventHandler(this.btn_BS_Click);
            // 
            // btn_BN
            // 
            this.btn_BN.BackgroundImage = global::QL_BenhVien.Properties.Resources.patient;
            this.btn_BN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BN.Location = new System.Drawing.Point(32, 152);
            this.btn_BN.Name = "btn_BN";
            this.btn_BN.Size = new System.Drawing.Size(237, 186);
            this.btn_BN.TabIndex = 0;
            this.btn_BN.UseVisualStyleBackColor = true;
            this.btn_BN.Click += new System.EventHandler(this.btn_BN_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bn);
            this.Controls.Add(this.btn_ad);
            this.Controls.Add(this.btn_BS);
            this.Controls.Add(this.btn_BN);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BN;
        private System.Windows.Forms.Button btn_BS;
        private System.Windows.Forms.Button btn_ad;
        private System.Windows.Forms.Label txt_bn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}