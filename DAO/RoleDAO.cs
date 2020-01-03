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
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleDAO();
                return instance;
            }
        }

        private RoleDAO() { }

        public DataTable DSRole()
        {
            //string query = "Select p.ID, p.Ten, lp.Ten as LoaiPhong, tt.Ten as TrangThai " +
            //               "From Phong as p, LoaiPhong as lp, TrangThai as tt Where p.IDLoai=lp.ID and p.IDTrangThai=tt.ID";
            //return DataProvider.Instance.getDS(query);
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select * from Role";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return tbl;
        }

        public bool ThemRole(RoleDTO Role)
        {
            //string[] param = { "@ID", "@Ten", "@IDLoai", "@IdTrangThai" };
            //object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            //string query = "Insert Into Phong Values(@ID,@Ten,@IDLoai,@IDTrangThai)";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
        public bool SuaRole(RoleDTO Role)
        {
            //string[] param = { "@ID", "@Ten", "@IDLoai", "@IDTrangThai" };
            //object[] values = { phong.Id, phong.Ten, phong.IdLoai, phong.IdTrangThai };
            //string query = "Update Phong Set Ten=@Ten, IDLoai=@IDLoai, IDTrangThai=@IDTrangThai Where ID=@ID";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
        public bool XoaRole(RoleDTO Role)
        {
            //string[] param = { "@ID" };
            //object[] values = { phong.Id };
            //string query = "Delete Phong Where ID=@ID";
            //return DataProvider.Instance.ExecuteNonQueryPara(query, param, values);
            return true;
        }
    }
}
