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
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }
        }
        private DangNhapDAO() { }

        public bool KiemTraUser(UserDTO userDTO)
        {
            //string query = "Select * From Users Where IDNhanVien = '" + userDTO.IdNhanVien + "' and Pass = '" + userDTO.Pass + "'";
            //DataTable dtb = DataProvider.Instance.getDS(query);
            //return (dtb.Rows.Count > 0);
            string host = "localhost";
            int port = 1521;
            string sid = "orcl";
            string user = userDTO.Username;
            string password = userDTO.Pass;
            OracleConnection conn = DataProvider.Instance.GetDBConnection(host, port, sid, user, password);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        public int IdChucDanh(string idNhanVien)
        {
            string query = "Select IDChucDanh From Users Where IDNhanVien = '" + idNhanVien + "'";
            DataTable dtb = DataProvider.Instance.getDS(query);
            return int.Parse(dtb.Rows[0]["IDChucDanh"].ToString());
        }
    }
}
