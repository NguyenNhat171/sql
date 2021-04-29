using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangForm
{
    class CungCap
    {

        DataConect dt = new DataConect();
        // Hàm này để kết nối bảng với datagridview
        public DataTable getView(SqlCommand command) 
        {
            command.Connection = dt.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       
      /*public bool insertCuaHang(string MaCh, string Dchi, string SDT, string ten) 
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhaCungCap  ( MaCongTy, TenCongTy, SDT,DiaChi)" + "VALUES(@mact,@tct,@sdt,@dc)", dt.getConnection);
            command.Parameters.Add("@mact", SqlDbType.VarChar).Value = MaCh;
            command.Parameters.Add("@tct", SqlDbType.VarChar).Value = Dchi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = ten;

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
        }*/


    // Hàm xóa nhà cung cấp
        public bool deleteManhacungcap(string MAcc)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhaCungCap  WHERE MaCongTy = @mact", dt.getConnection);
            command.Parameters.Add("@mact", SqlDbType.VarChar).Value = MAcc;
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

        // Hàm edit nhà cung cấp
        public bool UpdateNhaCungCap(string MaCh, string tencty, string Sdt, string diachi)
        {
            SqlCommand command = new SqlCommand("UPDATE NhaCungCap SET  MaCongTy=@mch,TenCongTy=@tct,SDT=@sdt, DiaChi=@dc WHERE MaCongTy=@mch", dt.getConnection);
            command.Parameters.Add("@mch", SqlDbType.VarChar).Value = MaCh;
            command.Parameters.Add("@tct", SqlDbType.VarChar).Value = tencty;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = Sdt;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi ;

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
