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
    class CuaHang
    {
        DataConect dt = new DataConect();
        public DataTable getView(SqlCommand command)  // hàm này để kết nối bảng để in len datagridview
        {
            command.Connection = dt.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
     
        // Hàm này để xóa cửa hàng
        public bool deleteMaCuaHang(string MACH)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CuaHang  WHERE MaCuaHang = @mach", dt.getConnection);
            command.Parameters.Add("@mach", SqlDbType.VarChar).Value = MACH;
            dt.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
             dt.closeConnection(); return true;
            }
            else
            {
                dt.closeConnection(); return false;
            }
        }
        // Hàm này để edit cửa hàng
        public bool UpdateCuaHang(string MaCh, string diachi, string  Sdt, string Tencuahang)
        {
            SqlCommand command = new SqlCommand("UPDATE CuaHang SET  MaCuaHang=@mch,DiaChi=@dc,SDT=@sdt, TenCuaHang=@tch WHERE MaCuaHang=@mch", dt.getConnection);
            command.Parameters.Add("@mch", SqlDbType.VarChar).Value = MaCh;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = Sdt;
            command.Parameters.Add("@tch", SqlDbType.VarChar).Value = Tencuahang;
        
            dt.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dt.closeConnection();
                return true;
            }
            else
            {
                dt.closeConnection();
                return false;
            }
        }

    }
}
