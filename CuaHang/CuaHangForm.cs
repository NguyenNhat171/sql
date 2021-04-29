using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CuaHangForm
{
    public partial class CuaHangForm : Form
    {
        CuaHang ch = new CuaHang();
        public CuaHangForm()
        {
            InitializeComponent();
        }

        private void CuaHangForm_Load(object sender, EventArgs e)
        {

            string connect = "Select CuaHang.MaCuaHang, CuaHang.DiaChi,CuaHang.SDT, CuaHang.TenCuaHang From CuaHang";
            SqlCommand command = new SqlCommand(connect);
            DataTable table = ch.getView(command);
            dataGridView1.DataSource = table;
        }

       /* private void insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string maCH = mach.Text;
                string Diachi = diachi.Text;
                string sdth = sdt.Text;
                string ten = tencuahang.Text;
             
                if (ch.insertCuaHang(maCH, Diachi, sdth, ten) )
                    MessageBox.Show("New CuaHang Added", "Add CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error", "Add CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Add CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }*/

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {

                string MaCuaH = mach.Text;


                if ((MessageBox.Show("Are You Sure You Want To Delete Cửa Hàng", "Xóa Cửa Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if ( ch.deleteMaCuaHang(MaCuaH))
                    {
                        MessageBox.Show("Xóa Cửa Hàng", "Delete Xóa Cửa Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mach.Text = "";
                        diachi.Text = "";
                        sdt.Text = "";
                        tencuahang.Text = "";
               
                    }
                    else
                    {
                        MessageBox.Show("CuaHang Not Deleted", "Delete CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            string Mach = mach.Text;
            string dc = diachi.Text;
            string Sdt = sdt.Text;
            string tch = tencuahang.Text;
        


            if (   ch.UpdateCuaHang(Mach, dc, Sdt, tch)   )
            {

                MessageBox.Show("New CuaHang update", "Edit CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("CuaHang Not update", "Edit CuaHang", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

   
     


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            mach.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() ;
            diachi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tencuahang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
         
        }
        public void fillGrid(SqlCommand command)
        {

           dataGridView1.ReadOnly = true;
         
           dataGridView1.RowTemplate.Height = 70;
           dataGridView1.DataSource = ch.getView(command);
          


        }
      
        
        private void find_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select CuaHang.MaCuaHang, CuaHang.DiaChi, CuaHang.SDT, CuaHang.TenCuaHang, PhieuXuat.MaPhieuXuat From CuaHang  Where CONCAT(CuaHang.MaCuaHang) LIKE'%" + searchtextBox.Text + "%'");
            fillGrid(command);
        }
    }
}
