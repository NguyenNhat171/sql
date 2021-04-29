
namespace CuaHangForm
{
    partial class NhaCungCap
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
            this.searchlabel = new System.Windows.Forms.Label();
            this.tenctlabel = new System.Windows.Forms.Label();
            this.sdtlabel = new System.Windows.Forms.Label();
            this.diachilabel = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.mct = new System.Windows.Forms.TextBox();
            this.mactlabel = new System.Windows.Forms.Label();
            this.tct = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchlabel
            // 
            this.searchlabel.Location = new System.Drawing.Point(272, 27);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(184, 39);
            this.searchlabel.TabIndex = 0;
            this.searchlabel.Text = "Tìm kiếm theo mã công ty, phiếu nhập";
            // 
            // tenctlabel
            // 
            this.tenctlabel.Location = new System.Drawing.Point(12, 140);
            this.tenctlabel.Name = "tenctlabel";
            this.tenctlabel.Size = new System.Drawing.Size(94, 22);
            this.tenctlabel.TabIndex = 2;
            this.tenctlabel.Text = "Tên Công Ty";
            // 
            // sdtlabel
            // 
            this.sdtlabel.Location = new System.Drawing.Point(12, 190);
            this.sdtlabel.Name = "sdtlabel";
            this.sdtlabel.Size = new System.Drawing.Size(94, 39);
            this.sdtlabel.TabIndex = 3;
            this.sdtlabel.Text = "Số Điện Thoại";
            // 
            // diachilabel
            // 
            this.diachilabel.Location = new System.Drawing.Point(12, 237);
            this.diachilabel.Name = "diachilabel";
            this.diachilabel.Size = new System.Drawing.Size(65, 22);
            this.diachilabel.TabIndex = 4;
            this.diachilabel.Text = "Địa Chỉ";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(65, 370);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(105, 45);
            this.edit.TabIndex = 7;
            this.edit.Text = "Sửa";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(302, 370);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 48);
            this.delete.TabIndex = 8;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 317);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(472, 44);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(275, 22);
            this.timkiem.TabIndex = 10;
            // 
            // mct
            // 
            this.mct.Location = new System.Drawing.Point(112, 95);
            this.mct.Name = "mct";
            this.mct.Size = new System.Drawing.Size(280, 22);
            this.mct.TabIndex = 11;
            // 
            // mactlabel
            // 
            this.mactlabel.Location = new System.Drawing.Point(12, 95);
            this.mactlabel.Name = "mactlabel";
            this.mactlabel.Size = new System.Drawing.Size(94, 24);
            this.mactlabel.TabIndex = 12;
            this.mactlabel.Text = "Mã Công Ty";
            // 
            // tct
            // 
            this.tct.Location = new System.Drawing.Point(112, 140);
            this.tct.Name = "tct";
            this.tct.Size = new System.Drawing.Size(279, 22);
            this.tct.TabIndex = 13;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(112, 195);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(278, 22);
            this.sdt.TabIndex = 14;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(112, 237);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(277, 22);
            this.dc.TabIndex = 15;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(776, 39);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(99, 40);
            this.find.TabIndex = 17;
            this.find.Text = "Tìm Kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.find);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.tct);
            this.Controls.Add(this.mactlabel);
            this.Controls.Add(this.mct);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.diachilabel);
            this.Controls.Add(this.sdtlabel);
            this.Controls.Add(this.tenctlabel);
            this.Controls.Add(this.searchlabel);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.DoubleClick += new System.EventHandler(this.NhaCungCap_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.Label tenctlabel;
        private System.Windows.Forms.Label sdtlabel;
        private System.Windows.Forms.Label diachilabel;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox timkiem;
        private System.Windows.Forms.TextBox mct;
        private System.Windows.Forms.Label mactlabel;
        private System.Windows.Forms.TextBox tct;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button find;
    }
}