namespace Quan_ly_thu_vien
{
    partial class FormPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comDocGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.comMaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.ghiChu = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ngayTra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.comMaSach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(107, 398);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn:";
            // 
            // comNhanVien
            // 
            this.comNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comNhanVien.FormattingEnabled = true;
            this.comNhanVien.Items.AddRange(new object[] {
            "NV01",
            "NV02",
            "NV03",
            "NV04",
            "NV05"});
            this.comNhanVien.Location = new System.Drawing.Point(280, 209);
            this.comNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.comNhanVien.Name = "comNhanVien";
            this.comNhanVien.Size = new System.Drawing.Size(160, 26);
            this.comNhanVien.TabIndex = 8;
            this.comNhanVien.SelectedIndexChanged += new System.EventHandler(this.comNhanVien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người lập phiếu";
            // 
            // comDocGia
            // 
            this.comDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDocGia.FormattingEnabled = true;
            this.comDocGia.Items.AddRange(new object[] {
            "DG01",
            "DG02",
            "DG03",
            "DG04",
            "DG05",
            "DG06",
            "DG07",
            "DG08"});
            this.comDocGia.Location = new System.Drawing.Point(280, 139);
            this.comDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.comDocGia.Name = "comDocGia";
            this.comDocGia.Size = new System.Drawing.Size(160, 26);
            this.comDocGia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã độc giả";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(280, 69);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Multiline = true;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(160, 28);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(377, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TẠO PHIẾU MƯỢN";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lbTotal2);
            this.tab2.Controls.Add(this.comMaPhieuMuon);
            this.tab2.Controls.Add(this.dataGridView2);
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.btnSave1);
            this.tab2.Controls.Add(this.btnRemove1);
            this.tab2.Controls.Add(this.btnEdit1);
            this.tab2.Controls.Add(this.btnAdd1);
            this.tab2.Controls.Add(this.ghiChu);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.ngayTra);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.ngayMuon);
            this.tab2.Controls.Add(this.comMaSach);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4);
            this.tab2.Size = new System.Drawing.Size(934, 681);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Chi tiết mượn-trả";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lbTotal2
            // 
            this.lbTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal2.ForeColor = System.Drawing.Color.Red;
            this.lbTotal2.Location = new System.Drawing.Point(382, 396);
            this.lbTotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(25, 24);
            this.lbTotal2.TabIndex = 50;
            // 
            // comMaPhieuMuon
            // 
            this.comMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMaPhieuMuon.FormattingEnabled = true;
            this.comMaPhieuMuon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comMaPhieuMuon.Location = new System.Drawing.Point(219, 99);
            this.comMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.comMaPhieuMuon.Name = "comMaPhieuMuon";
            this.comMaPhieuMuon.Size = new System.Drawing.Size(160, 28);
            this.comMaPhieuMuon.TabIndex = 49;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(110, 432);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(663, 230);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(626, 315);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(100, 39);
            this.btnSave1.TabIndex = 22;
            this.btnSave1.Text = "Lưu";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove1.Location = new System.Drawing.Point(481, 315);
            this.btnRemove1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(100, 39);
            this.btnRemove1.TabIndex = 21;
            this.btnRemove1.Text = "Trả sách";
            this.btnRemove1.UseVisualStyleBackColor = false;
            this.btnRemove1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit1.Location = new System.Drawing.Point(333, 315);
            this.btnEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(100, 39);
            this.btnEdit1.TabIndex = 20;
            this.btnEdit1.Text = "Gia hạn";
            this.btnEdit1.UseVisualStyleBackColor = false;
            this.btnEdit1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.Location = new System.Drawing.Point(171, 315);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(100, 39);
            this.btnAdd1.TabIndex = 19;
            this.btnAdd1.Text = "Thêm ";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // ghiChu
            // 
            this.ghiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghiChu.ForeColor = System.Drawing.Color.Red;
            this.ghiChu.Location = new System.Drawing.Point(223, 225);
            this.ghiChu.Margin = new System.Windows.Forms.Padding(4);
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(548, 57);
            this.ghiChu.TabIndex = 17;
            this.ghiChu.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(8, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // ngayTra
            // 
            this.ngayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayTra.Location = new System.Drawing.Point(601, 172);
            this.ngayTra.Margin = new System.Windows.Forms.Padding(4);
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.Size = new System.Drawing.Size(160, 26);
            this.ngayTra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(424, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // ngayMuon
            // 
            this.ngayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayMuon.Location = new System.Drawing.Point(219, 170);
            this.ngayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Size = new System.Drawing.Size(160, 26);
            this.ngayMuon.TabIndex = 13;
            this.ngayMuon.Value = new System.DateTime(2020, 8, 11, 23, 36, 38, 0);
            // 
            // comMaSach
            // 
            this.comMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMaSach.FormattingEnabled = true;
            this.comMaSach.Items.AddRange(new object[] {
            "A01",
            "A02",
            "A03",
            "A04",
            "A05"});
            this.comMaSach.Location = new System.Drawing.Point(601, 106);
            this.comMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.comMaSach.Name = "comMaSach";
            this.comMaSach.Size = new System.Drawing.Size(160, 28);
            this.comMaSach.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(424, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(4, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(364, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chi tiết mượn - trả  sách";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(563, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(28, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 707);
            this.tabControl1.TabIndex = 2;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.lbTotal);
            this.tab1.Controls.Add(this.label13);
            this.tab1.Controls.Add(this.dataGridView1);
            this.tab1.Controls.Add(this.btnSave);
            this.tab1.Controls.Add(this.btnExit);
            this.tab1.Controls.Add(this.btnRemove);
            this.tab1.Controls.Add(this.btnEdit);
            this.tab1.Controls.Add(this.btnAdd);
            this.tab1.Controls.Add(this.comNhanVien);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comDocGia);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.txtMaPhieu);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4);
            this.tab1.Size = new System.Drawing.Size(934, 681);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Lập phiếu mượn";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(427, 278);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(2, 20);
            this.lbTotal.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(152, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Tổng số quyển sách độc giả đang mượn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 230);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(708, 59);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(708, 127);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(561, 199);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 38);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(561, 129);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 817);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMuonTra";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.RichTextBox ghiChu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ngayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngayMuon;
        private System.Windows.Forms.ComboBox comMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comMaPhieuMuon;
        private System.Windows.Forms.Label lbTotal2;
    }
}