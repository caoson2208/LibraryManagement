namespace Quan_ly_thu_vien
{
    partial class FormManageBook
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comCodeAuthor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comCodeCategory = new System.Windows.Forms.ComboBox();
            this.comCodepublishingCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublishingYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdCodeBook = new System.Windows.Forms.RadioButton();
            this.rdNameBook = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(643, 156);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(792, 156);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.Location = new System.Drawing.Point(481, 156);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 38);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(309, 156);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(165, 156);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comCodeAuthor
            // 
            this.comCodeAuthor.FormattingEnabled = true;
            this.comCodeAuthor.Items.AddRange(new object[] {
            "TG01\t",
            "TG02",
            "TG03",
            "TG04",
            "TG05",
            "TG06",
            "TG07",
            "TG08",
            "TG09"});
            this.comCodeAuthor.Location = new System.Drawing.Point(868, 108);
            this.comCodeAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.comCodeAuthor.Name = "comCodeAuthor";
            this.comCodeAuthor.Size = new System.Drawing.Size(176, 28);
            this.comCodeAuthor.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.comCodeAuthor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comCodeCategory);
            this.groupBox2.Controls.Add(this.comCodepublishingCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPublishingYear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNameBook);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodeBook);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(36, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1060, 202);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(725, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã tác giả";
            // 
            // comCodeCategory
            // 
            this.comCodeCategory.FormattingEnabled = true;
            this.comCodeCategory.Items.AddRange(new object[] {
            "TL01\t",
            "TL02",
            "TL03",
            "TL04\t",
            "TL05"});
            this.comCodeCategory.Location = new System.Drawing.Point(868, 46);
            this.comCodeCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comCodeCategory.Name = "comCodeCategory";
            this.comCodeCategory.Size = new System.Drawing.Size(176, 28);
            this.comCodeCategory.TabIndex = 9;
            // 
            // comCodepublishingCompany
            // 
            this.comCodepublishingCompany.FormattingEnabled = true;
            this.comCodepublishingCompany.Items.AddRange(new object[] {
            "XB01",
            "XB02",
            "XB03",
            "XB04",
            "XB05"});
            this.comCodepublishingCompany.Location = new System.Drawing.Point(519, 102);
            this.comCodepublishingCompany.Margin = new System.Windows.Forms.Padding(4);
            this.comCodepublishingCompany.Name = "comCodepublishingCompany";
            this.comCodepublishingCompany.Size = new System.Drawing.Size(160, 28);
            this.comCodepublishingCompany.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(355, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhà XB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(725, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã thể loại";
            // 
            // txtPublishingYear
            // 
            this.txtPublishingYear.Location = new System.Drawing.Point(519, 46);
            this.txtPublishingYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublishingYear.Name = "txtPublishingYear";
            this.txtPublishingYear.Size = new System.Drawing.Size(160, 26);
            this.txtPublishingYear.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(341, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(147, 101);
            this.txtNameBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(163, 26);
            this.txtNameBook.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtCodeBook
            // 
            this.txtCodeBook.Location = new System.Drawing.Point(147, 44);
            this.txtCodeBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeBook.Name = "txtCodeBook";
            this.txtCodeBook.Size = new System.Drawing.Size(163, 26);
            this.txtCodeBook.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rdCodeBook);
            this.groupBox1.Controls.Add(this.rdNameBook);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(36, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(892, 118);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(263, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(389, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // rdCodeBook
            // 
            this.rdCodeBook.AutoSize = true;
            this.rdCodeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdCodeBook.Location = new System.Drawing.Point(80, 31);
            this.rdCodeBook.Margin = new System.Windows.Forms.Padding(4);
            this.rdCodeBook.Name = "rdCodeBook";
            this.rdCodeBook.Size = new System.Drawing.Size(99, 28);
            this.rdCodeBook.TabIndex = 1;
            this.rdCodeBook.TabStop = true;
            this.rdCodeBook.Text = "Mã sách";
            this.rdCodeBook.UseVisualStyleBackColor = true;
            // 
            // rdNameBook
            // 
            this.rdNameBook.AutoSize = true;
            this.rdNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNameBook.Location = new System.Drawing.Point(80, 75);
            this.rdNameBook.Margin = new System.Windows.Forms.Padding(4);
            this.rdNameBook.Name = "rdNameBook";
            this.rdNameBook.Size = new System.Drawing.Size(107, 28);
            this.rdNameBook.TabIndex = 2;
            this.rdNameBook.Text = "Tên sách";
            this.rdNameBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 384);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 230);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormManageBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLySach";
            this.Load += new System.EventHandler(this.FormQuanLySach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comCodeAuthor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comCodeCategory;
        private System.Windows.Forms.ComboBox comCodepublishingCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublishingYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdCodeBook;
        private System.Windows.Forms.RadioButton rdNameBook;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}