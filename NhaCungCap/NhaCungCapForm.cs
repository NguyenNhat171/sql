using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangForm
{
    public partial class NhaCungCap : Form
    {
        CungCap ch = new CungCap();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            string connect = "Select NhaCungCap.MaCongTy, NhaCungCap.TenCongTy,NhaCungCap.SDT, NhaCungCap.DiaChi From NhaCungCap ";
            SqlCommand command = new SqlCommand(connect);
            DataTable table = ch.getView(command);
            dataGridView1.DataSource = table;
        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.ReadOnly = true;

            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.DataSource = ch.getView(command);

        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string mact = mct.Text;
                string tencty = tct.Text;
                string sdth = sdt.Text;
                string diachi= dc.Text;
       
                if (ch.insertCuaHang(mact, tencty, sdth, diachi))
                    MessageBox.Show("New NhaCungCap Added", "Add NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error", "Add NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Add NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void find_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select NhaCungCap.MaCongTy, NhaCungCap.TenCongTy,NhaCungCap.SDT, NhaCungCap.DiaChi From NhaCungCap  Where CONCAT(NhaCungCap.MaCongTy) LIKE'%" + find.Text + "%'");
            fillGrid(command);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string Mact = mct.Text;
            string tcty = tct.Text;
            string Sdt = sdt.Text;
            string dchi = dc.Text;
          


            if (ch.UpdateNhaCungCap(Mact, tcty, Sdt, dchi))
            {

                MessageBox.Show("New NhaCungCap update", "Edit NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("NhaCungCap Not update", "Edit NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                string Macc= mct.Text;
               

                if ((MessageBox.Show("Are You Sure You Want To Delete Nhà Cung Cấp", "Xóa Mã Phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if ( ch.deleteManhacungcap(Macc))
                    {
                        MessageBox.Show("Xóa NhaCungCap", "Delete NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mct.Text = "";
                        tct.Text = "";
                        sdt.Text = "";
                        dc.Text = "";
                   

                    }
                    else
                    {
                        MessageBox.Show(" NhaCungCap Not Deleted", "Delete NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete NhaCungCap", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhaCungCap_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            mct.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tct.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
    }

