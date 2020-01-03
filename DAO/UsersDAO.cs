using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersDAO();
                return instance;
            }
        }

        private UsersDAO() { }

        public DataTable DSUsers()
        {
            //string query = "Select p.ID, p.Ten, lp.Ten as LoaiPhong, tt.Ten as TrangThai " +
            //               "From Phong as p, LoaiPhong as lp, TrangThai as tt Where p.IDLoai=lp.ID and p.IDTrangThai=tt.ID";
            //return DataProvider.Instance.getDS(query);
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select * from Users";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return tbl;
        }

        public bool ThemUsers(UsersDTO users)
        {
            //string[] param = { "@ID", "@Ten", "@IDLoai", "@IdTrangThai" };
            //object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            //string query = "Insert Into Phong Values(@ID,@Ten,@IDLoai,@IDTrangThai)";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
        public bool SuaUsers(UsersDTO users)
        {
            //string[] param = { "@ID", "@Ten", "@IDLoai", "@IDTrangThai" };
            //object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            //string query = "Update Phong Set Ten=@Ten, IDLoai=@IDLoai, IDTrangThai=@IDTrangThai Where ID=@ID";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
        public bool XoaUsers(UsersDTO users)
        {
            //string[] param = { "@ID" };
            //object[] values = { phong.Id };
            //string query = "Delete Phong Where ID=@ID";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
        public int IdNhanVien(string nhanVien)
        {
            //string query = "Select ID From LoaiPhong Where Ten = N'" + loaiPhong + "'";
            //DataTable dtb = DataProvider.Instance.getDS(query);
            //return int.Parse(dtb.Rows[0]["ID"].ToString());
            return 1;
        }
        public int IdProfile(string profile)
        {
            //string query = "Select ID From TrangThai Where Ten = N'" + trangThai + "'";
            //DataTable dtb = DataProvider.Instance.getDS(query);
            //return int.Parse(dtb.Rows[0]["ID"].ToString());
            return 1;
        }
        public int IdRole(string role)
        {
            //string query = "Select ID From TrangThai Where Ten = N'" + trangThai + "'";
            //DataTable dtb = DataProvider.Instance.getDS(query);
            //return int.Parse(dtb.Rows[0]["ID"].ToString());
            return 1;
        }

    }
}
