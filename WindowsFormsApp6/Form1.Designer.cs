namespace WindowsFormsApp6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btbAnh = new Bunifu.Framework.UI.BunifuImageButton();
            this.qLSinhVienDataSet = new WindowsFormsApp6.QLSinhVienDataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new WindowsFormsApp6.QLSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.qLSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_save = new Guna.UI.WinForms.GunaGradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.qLSinhVienDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new WindowsFormsApp6.QLSinhVienDataSetTableAdapters.LopTableAdapter();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(325, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí sinh viên ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_lop);
            this.groupBox1.Controls.Add(this.txt_ho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mssv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tất cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(124, 90);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(188, 26);
            this.txt_mssv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên ";
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(422, 46);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(188, 26);
            this.txt_ho.TabIndex = 2;
            // 
            // cbo_lop
            // 
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Location = new System.Drawing.Point(422, 86);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(187, 28);
            this.cbo_lop.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lớp";
            // 
            // btbAnh
            // 
            this.btbAnh.BackColor = System.Drawing.Color.Transparent;
            this.btbAnh.Image = ((System.Drawing.Image)(resources.GetObject("btbAnh.Image")));
            this.btbAnh.ImageActive = null;
            this.btbAnh.Location = new System.Drawing.Point(23, 84);
            this.btbAnh.Name = "btbAnh";
            this.btbAnh.Size = new System.Drawing.Size(116, 132);
            this.btbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbAnh.TabIndex = 3;
            this.btbAnh.TabStop = false;
            this.btbAnh.Zoom = 10;
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // qLSinhVienDataSetBindingSource
            // 
            this.qLSinhVienDataSetBindingSource.DataSource = this.qLSinhVienDataSet;
            this.qLSinhVienDataSetBindingSource.Position = 0;
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_save.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_save.Location = new System.Drawing.Point(808, 485);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_save.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Size = new System.Drawing.Size(93, 26);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Lưu";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.btn_save;
            // 
            // qLSinhVienDataSetBindingSource1
            // 
            this.qLSinhVienDataSetBindingSource1.DataSource = this.qLSinhVienDataSet;
            this.qLSinhVienDataSetBindingSource1.Position = 0;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLSinhVienDataSetBindingSource;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.AutoGenerateColumns = false;
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_thongtin.DataSource = this.sinhVienBindingSource;
            this.dgv_thongtin.Location = new System.Drawing.Point(2, 275);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.Size = new System.Drawing.Size(938, 210);
            this.dgv_thongtin.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MSSV";
            this.Column2.HeaderText = "MSSV";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ho";
            this.Column3.HeaderText = "Họ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ten";
            this.Column4.HeaderText = "Tên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(943, 514);
            this.Controls.Add(this.dgv_thongtin);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btbAnh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_lop;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuImageButton btbAnh;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource;
        private Guna.UI.WinForms.GunaGradientButton btn_save;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLSinhVienDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

