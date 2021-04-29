
namespace CuaHangForm
{
    partial class CuaHangForm
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
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.machlabel = new System.Windows.Forms.Label();
            this.diachilabel = new System.Windows.Forms.Label();
            this.sodtlabel = new System.Windows.Forms.Label();
            this.tencuahanglabel = new System.Windows.Forms.Label();
            this.mach = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.tencuahang = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchlabel
            // 
            this.searchlabel.Location = new System.Drawing.Point(378, 46);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(180, 39);
            this.searchlabel.TabIndex = 0;
            this.searchlabel.Text = "Tìm kiếm theo MãCH, Mã Phiếu";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(585, 46);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(186, 22);
            this.searchtextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(477, 382);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(88, 472);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(102, 32);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Xóa";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(292, 472);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(104, 32);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Sửa";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // machlabel
            // 
            this.machlabel.AutoSize = true;
            this.machlabel.Location = new System.Drawing.Point(27, 136);
            this.machlabel.Name = "machlabel";
            this.machlabel.Size = new System.Drawing.Size(94, 17);
            this.machlabel.TabIndex = 6;
            this.machlabel.Text = "Mã Cửa Hàng";
            // 
            // diachilabel
            // 
            this.diachilabel.AutoSize = true;
            this.diachilabel.Location = new System.Drawing.Point(27, 184);
            this.diachilabel.Name = "diachilabel";
            this.diachilabel.Size = new System.Drawing.Size(53, 17);
            this.diachilabel.TabIndex = 7;
            this.diachilabel.Text = "Địa Chỉ";
            // 
            // sodtlabel
            // 
            this.sodtlabel.AutoSize = true;
            this.sodtlabel.Location = new System.Drawing.Point(27, 245);
            this.sodtlabel.Name = "sodtlabel";
            this.sodtlabel.Size = new System.Drawing.Size(98, 17);
            this.sodtlabel.TabIndex = 8;
            this.sodtlabel.Text = "Số Điện Thoại";
            // 
            // tencuahanglabel
            // 
            this.tencuahanglabel.AutoSize = true;
            this.tencuahanglabel.Location = new System.Drawing.Point(27, 307);
            this.tencuahanglabel.Name = "tencuahanglabel";
            this.tencuahanglabel.Size = new System.Drawing.Size(100, 17);
            this.tencuahanglabel.TabIndex = 9;
            this.tencuahanglabel.Text = "Tên Cửa Hàng";
            // 
            // mach
            // 
            this.mach.Location = new System.Drawing.Point(133, 134);
            this.mach.Name = "mach";
            this.mach.Size = new System.Drawing.Size(248, 22);
            this.mach.TabIndex = 11;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(133, 181);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(248, 22);
            this.diachi.TabIndex = 12;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(133, 243);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(247, 22);
            this.sdt.TabIndex = 13;
            // 
            // tencuahang
            // 
            this.tencuahang.Location = new System.Drawing.Point(133, 302);
            this.tencuahang.Name = "tencuahang";
            this.tencuahang.Size = new System.Drawing.Size(248, 22);
            this.tencuahang.TabIndex = 14;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(789, 38);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(107, 46);
            this.find.TabIndex = 16;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // CuaHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 553);
            this.Controls.Add(this.find);
            this.Controls.Add(this.tencuahang);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.mach);
            this.Controls.Add(this.tencuahanglabel);
            this.Controls.Add(this.sodtlabel);
            this.Controls.Add(this.diachilabel);
            this.Controls.Add(this.machlabel);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.searchlabel);
            this.Name = "CuaHangForm";
            this.Text = "CuaHangForm";
            this.Load += new System.EventHandler(this.CuaHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label machlabel;
        private System.Windows.Forms.Label diachilabel;
        private System.Windows.Forms.Label sodtlabel;
        private System.Windows.Forms.Label tencuahanglabel;
        private System.Windows.Forms.TextBox mach;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox tencuahang;
        private System.Windows.Forms.Button find;
    }
}

