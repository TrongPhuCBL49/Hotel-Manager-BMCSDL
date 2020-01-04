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
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select TTNHANVIEN.TEN, USERNAME, QUOTA, TTPROFILE.TEN PROFILE, TTROLE.TEN ROLE, ACTIVE " +
                              "from TTUSER, TTPROFILE, TTROLE, TTNHANVIEN " +
                              "where TTNHANVIEN.ID = TTUSER.IDNHANVIEN and TTPROFILE.ID = TTUSER.IDPROFILE and TTROLE.ID = TTUSER.IDROLE ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return tbl;
        }

        public bool ThemUsers(UsersDTO users)
        {
            List<string> query = new List<string>();
            // Câu lệnh Insert vào bảng
            string sql = "Insert into TTUSER " +
                         "values (" + IdNhanVien(users.IdNhanVien) + ",'" + users.Username + "','" + users.Quota +
                         "'," + IdProfile(users.IdProfile) + "," + IdRole(users.IdRole) + "," + users.Active + ")";
            query.Add(sql);
            // Insert User vào Oracle
            string sql1 = "create user " + users.Username + " identified by " + users.Password;
            query.Add(sql1);
            // Them Profile
            string sql2 = "ALTER USER " + users.Username + " PROFILE " + users.IdProfile;
            query.Add(sql2);
            // Them Role
            string sql3 = "GRANT " + users.IdRole + " TO " + users.Username;
            query.Add(sql3);
            // Cap Quota
            string sql4 = "ALTER USER " + users.Username + " QUOTA " + users.Quota + " ON QLKhachSan";
            query.Add(sql4);
            // Active
            if (users.Active == "1")
            {
                string sql5 = "ALTER USER " + users.Username + " ACCOUNT UNLOCK";
                query.Add(sql5);
            }
            else
            {
                string sql5 = "ALTER USER " + users.Username + " ACCOUNT LOCK";
                query.Add(sql5);
            }
            try
            {
                foreach (var qr in query)
                {
                    OracleCommand cmd3 = DataProvider.conn.CreateCommand();
                    cmd3.CommandText = qr;
                    cmd3.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool SuaUsers(UsersDTO users)
        {
            List<string> query = new List<string>();
            // Câu lệnh Insert vào bảng
            string sql = "Update TTUSER " +
                         "set IDNHANVIEN = " + IdNhanVien(users.IdNhanVien) +
                         ", QUOTA = '" + users.Quota +
                         "', IDPROFILE = " + IdProfile(users.IdProfile) +
                         ", IDROLE = " + IdRole(users.IdRole) +
                         ", ACTIVE = " + users.Active +
                         " Where USERNAME = '" + users.Username + "'";
            query.Add(sql);
            // Them Profile
            string sql2 = "ALTER USER " + users.Username + " PROFILE " + users.IdProfile;
            query.Add(sql2);
            // Them Role
            string sql3 = "GRANT " + users.IdRole + " TO " + users.Username;
            query.Add(sql3);
            // Cap Quota
            string sql4 = "ALTER USER " + users.Username + " QUOTA " + users.Quota + " ON QLKhachSan";
            query.Add(sql4);
            // Active
            if (users.Active == "1")
            {
                string sql5 = "ALTER USER " + users.Username + " ACCOUNT UNLOCK";
                query.Add(sql5);
            }
            else
            {
                string sql5 = "ALTER USER " + users.Username + " ACCOUNT LOCK";
                query.Add(sql5);
            }
            try
            {
                foreach (var qr in query)
                {
                    OracleCommand cmd3 = DataProvider.conn.CreateCommand();
                    cmd3.CommandText = qr;
                    cmd3.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool XoaUsers(UsersDTO users)
        {
            // Câu lệnh Update vào bảng
            string sql = "Delete From TTUser where USERNAME='" + users.Username + "'";
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            // Update Profile vào Oracle
            string sql2 = "Drop User " + users.Username;
            OracleCommand cmd2 = DataProvider.conn.CreateCommand();
            cmd2.CommandText = sql2;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public int IdNhanVien(string nhanVien)
        {
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select ID " +
                              "from TTNHANVIEN " +
                              "where TEN='" + nhanVien + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return int.Parse(tbl.Rows[0]["ID"].ToString());
        }
        public int IdProfile(string profile)
        {
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select ID " +
                              "from TTPROFILE " +
                              "where TEN='" + profile +"'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return int.Parse(tbl.Rows[0]["ID"].ToString());
        }
        public int IdRole(string role)
        {
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select ID " +
                              "from TTROLE " +
                              "where TEN='" + role +"'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return int.Parse(tbl.Rows[0]["ID"].ToString());
        }

    }
}
