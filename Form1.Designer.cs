namespace CSharp_Bai17
{
    partial class Form1
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
            this.rad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.cbnienkhoa = new System.Windows.Forms.ComboBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.btndangky = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chklbmonhoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // rad
            // 
            this.rad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rad.Location = new System.Drawing.Point(-1, -3);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(626, 69);
            this.rad.TabIndex = 0;
            this.rad.Text = "Đăng Ký Môn Học";
            this.rad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Và Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Niên Khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Học Kỳ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Môn Học:";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(222, 93);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(119, 20);
            this.txtmssv.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(222, 130);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(313, 20);
            this.txthoten.TabIndex = 3;
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbnienkhoa.Location = new System.Drawing.Point(221, 175);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(189, 21);
            this.cbnienkhoa.TabIndex = 5;
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Items.AddRange(new object[] {
            "TH01",
            "TH02",
            "TH03"});
            this.cblop.Location = new System.Drawing.Point(222, 216);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(189, 21);
            this.cblop.TabIndex = 7;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(221, 269);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(28, 17);
            this.rad1.TabIndex = 9;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(277, 270);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(31, 17);
            this.rad2.TabIndex = 10;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(383, 269);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(35, 17);
            this.rad4.TabIndex = 12;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(333, 270);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(34, 17);
            this.rad3.TabIndex = 11;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(174, 408);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 23);
            this.btndangky.TabIndex = 13;
            this.btndangky.Text = "Đăng &Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(277, 408);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "&Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(374, 408);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Th&oát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // chklbmonhoc
            // 
            this.chklbmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbmonhoc.FormattingEnabled = true;
            this.chklbmonhoc.Items.AddRange(new object[] {
            "LT Windows",
            "LT Internet",
            "Mạng Máy Tính",
            "UML"});
            this.chklbmonhoc.Location = new System.Drawing.Point(221, 304);
            this.chklbmonhoc.Name = "chklbmonhoc";
            this.chklbmonhoc.Size = new System.Drawing.Size(242, 58);
            this.chklbmonhoc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 460);
            this.Controls.Add(this.chklbmonhoc);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbnienkhoa);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad);
            this.Name = "Form1";
            this.Text = "frmDangKyMonHoc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.ComboBox cbnienkhoa;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckedListBox chklbmonhoc;
    }
}

