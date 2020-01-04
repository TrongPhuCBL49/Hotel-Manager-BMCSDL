using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return instance;
            }
        }

        private PhongDAO() { }

        public DataTable DSPhong()
        {
            //string query = "Select p.ID, p.Ten, lp.Ten as LoaiPhong, tt.Ten as TrangThai " +
            //               "From Phong as p, LoaiPhong as lp, TrangThai as tt Where p.IDLoai=lp.ID and p.IDTrangThai=tt.ID";
            //return DataProvider.Instance.getDS(query);
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select * from myboss.QLPHONG";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            MessageBox.Show("đã chạy");
            return tbl;
        }

        public bool ThemPhong(PhongDTO phong)
        {
            string[] param = { "@ID", "@Ten", "@IDLoai", "@IdTrangThai" };
            object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            string query = "Insert Into Phong Values(@ID,@Ten,@IDLoai,@IDTrangThai)";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaPhong(PhongDTO phong)
        {
            string[] param = { "@ID", "@Ten", "@IDLoai", "@IDTrangThai" };
            object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            string query = "Update Phong Set Ten=@Ten, IDLoai=@IDLoai, IDTrangThai=@IDTrangThai Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaPhong(PhongDTO phong)
        {
            string[] param = { "@ID" };
            object[] values = { phong.Id };
            string query = "Delete Phong Where ID=@ID";
            return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
        }
        public int IdLoaiPhong(string loaiPhong)
        {
            string query = "Select ID From LoaiPhong Where Ten = N'" + loaiPhong + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["ID"].ToString());
        }
        public int IdTrangThai(string trangThai)
        {
            string query = "Select ID From TrangThai Where Ten = N'" + trangThai + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["ID"].ToString());
        }

    }
}
