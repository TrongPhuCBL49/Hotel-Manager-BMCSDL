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
    public class ProfileDAO
    {
        private static ProfileDAO instance;

        public static ProfileDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProfileDAO();
                return instance;
            }
        }

        private ProfileDAO() { }

        public DataTable DSProfile()
        {
            //string query = "Select p.ID, p.Ten, lp.Ten as LoaiPhong, tt.Ten as TrangThai " +
            //               "From Phong as p, LoaiPhong as lp, TrangThai as tt Where p.IDLoai=lp.ID and p.IDTrangThai=tt.ID";
            //return DataProvider.Instance.getDS(query);
            string sql2 = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true";
            OracleCommand cmd2 = DataProvider.conn.CreateCommand();
            cmd2.CommandText = sql2;
            cmd2.ExecuteNonQuery();
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select * from TTPROFILE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return tbl;
        }

        public bool ThemProfile(ProfileDTO profile)
        {
            // Câu lệnh Insert vào bảng
            string sql = "Insert into TTPROFILE " +
                         "values (" + profile.Id + ",'" + profile.Ten + "'," + profile.FalseLogin +
                         "," + profile.SessionUser + "," + profile.ConnectTime + "," + profile.IdleTime + ")";
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            // Insert Profile vào Oracle
            string sql2 = "create profile " + profile.Ten + " limit" +
                          " FAILED_LOGIN_ATTEMPTS " + profile.FalseLogin +
                          " SESSIONS_PER_USER     " + profile.SessionUser +
                          " CONNECT_TIME          " + profile.ConnectTime +
                          " IDLE_TIME             " + profile.IdleTime;
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
        public bool SuaProfile(ProfileDTO profile)
        {
            // Câu lệnh Update vào bảng
            string sql = "Update TTPROFILE " +
                         "set TEN = '" + profile.Ten +
                         "', FALSELOGIN = " + profile.FalseLogin +
                         ", SESSIONUSER = " + profile.SessionUser +
                         ", CONNECTTIME = " + profile.ConnectTime +
                         ", IDLETIME = " + profile.IdleTime +
                         " Where ID = " + profile.Id;
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            // Update Profile vào Oracle
            string sql2 = "Alter profile " + profile.Ten + " limit" +
                          " FAILED_LOGIN_ATTEMPTS " + profile.FalseLogin +
                          " SESSIONS_PER_USER     " + profile.SessionUser +
                          " CONNECT_TIME          " + profile.ConnectTime +
                          " IDLE_TIME             " + profile.IdleTime;
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
        public bool XoaProfile(ProfileDTO profile)
        {
            // Câu lệnh Update vào bảng
            string sql = "Delete From TTProfile where TEN='" + profile.Ten + "'";
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            // Update Profile vào Oracle
            string sql2 = "Drop Profile " + profile.Ten;
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
    }
}
