namespace Quan_ly_thu_vien
{
    partial class FormStatisticalBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Statistical = new System.Windows.Forms.Button();
            this.comStatistical = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.Statistical);
            this.groupBox1.Controls.Add(this.comStatistical);
            this.groupBox1.Location = new System.Drawing.Point(58, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(568, 53);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.LightGray;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(374, 10);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 32);
            this.btnExportExcel.TabIndex = 44;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(490, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 32);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Statistical
            // 
            this.Statistical.BackColor = System.Drawing.Color.LightGray;
            this.Statistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistical.Location = new System.Drawing.Point(273, 10);
            this.Statistical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Statistical.Name = "Statistical";
            this.Statistical.Size = new System.Drawing.Size(90, 33);
            this.Statistical.TabIndex = 42;
            this.Statistical.Text = "Thống kê";
            this.Statistical.UseVisualStyleBackColor = false;
            this.Statistical.Click += new System.EventHandler(this.button2_Click);
            // 
            // comStatistical
            // 
            this.comStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatistical.FormattingEnabled = true;
            this.comStatistical.Items.AddRange(new object[] {
            "Tất cả sách",
            "Sách đang mượn",
            "Sách quá hạn"});
            this.comStatistical.Location = new System.Drawing.Point(94, 15);
            this.comStatistical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comStatistical.Name = "comStatistical";
            this.comStatistical.Size = new System.Drawing.Size(154, 26);
            this.comStatistical.TabIndex = 40;
            this.comStatistical.Tag = "";
            this.comStatistical.Text = "Tất cả sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(211, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "BÁO CÁO THỐNG KÊ SÁCH TRONG THƯ VIỆN";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 154);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(580, 214);
            this.dataGridView2.TabIndex = 50;
            // 
            // FormStatisticalBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 389);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStatisticalBook";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKeSach";
            this.Load += new System.EventHandler(this.FormThongKeSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comStatistical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Statistical;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}