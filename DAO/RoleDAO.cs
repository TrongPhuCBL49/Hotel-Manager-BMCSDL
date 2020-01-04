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
            string sql2 = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true";
            OracleCommand cmd2 = DataProvider.conn.CreateCommand();
            cmd2.CommandText = sql2;
            cmd2.ExecuteNonQuery();
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = "select * from TTROLE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            return tbl;
        }
        
        public void grant_revoke_role(RoleDTO role)
        {
            string[] query = new string[10];
            if (role.SPhong == "1")
                query[1] = "Grant select on QLPHONG to " + role.Ten;
            else
                query[1] = "Revoke select on QLPHONG from " + role.Ten;

            if (role.IPhong == "1")
                query[2] = "Grant insert on QLPHONG to " + role.Ten;
            else
                query[2] = "Revoke insert on QLPHONG from " + role.Ten;

            if (role.UPhong == "1")
                query[3] = "Grant update on QLPHONG to " + role.Ten;
            else
                query[3] = "Revoke update on QLPHONG from " + role.Ten;

            if (role.DPhong == "1")
                query[4] = "Grant delete on QLPHONG to " + role.Ten;
            else
                query[4] = "Revoke delete on QLPHONG from " + role.Ten;

            if (role.UTen == "1")
                query[5] = "Grant update(TEN) on QLPHONG to " + role.Ten;
            else
                if (role.UPhong == "1")
                    query[5] = "Revoke update on QLPHONG from " + role.Ten;
                else
                    query[5] = "commit";

            if (role.ITen == "1")
                query[6] = "Grant insert(TEN) on QLPHONG to " + role.Ten;
            else
                if (role.IPhong == "1")
                    query[6] = "Revoke insert on QLPHONG from " + role.Ten;
                else
                    query[6] = "commit";

            if (role.UGia == "1")
                query[7] = "Grant update(GIA) on QLPHONG to " + role.Ten;
            else
                if (role.UPhong == "1")
                    query[7] = "Revoke update on QLPHONG from " + role.Ten;
                else
                    query[7] = "commit";

            if (role.IGia == "1")
                query[8] = "Grant insert(GIA) on QLPHONG to " + role.Ten;
            else
                if (role.IPhong == "1")
                    query[8] = "Revoke insert on QLPHONG from " + role.Ten;
                else
                    query[8] = "commit";

            for (int i = 1; i < 9; i++)
            {
                OracleCommand cmd3 = DataProvider.conn.CreateCommand();
                cmd3.CommandText = query[i];
                cmd3.ExecuteNonQuery();
            }
        }
        public bool ThemRole(RoleDTO role)
        {
            // Câu lệnh Insert vào bảng
            string sql = "Insert into TTROLE " +
                         "values (" + role.Id + ",'" + role.Ten + "'," + role.SPhong +
                         "," + role.IPhong + "," + role.UPhong + "," + role.DPhong +
                         "," + role.UTen + "," + role.ITen + "," + role.UGia + "," + role.IGia + ")";
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            // Insert Profile vào Oracle
            string sql2 = "create role " + role.Ten;
            OracleCommand cmd2 = DataProvider.conn.CreateCommand();
            cmd2.CommandText = sql2;
            //string[] plis = new string[] { role.SPhong, role.IPhong, role.UPhong, role.DPhong, role.STen, role.ITen, role.UGia, role.IGia };
            try
            {
                cmd2.ExecuteNonQuery();
                RoleDTO imgRole = new RoleDTO("1", role.Ten, "1", "1", "1", "1", "1", "1", "1", "1");
                grant_revoke_role(imgRole);
                grant_revoke_role(role);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool SuaRole(RoleDTO role)
        {
            // Câu lệnh Insert vào bảng
            string sql = "Update TTROLE " +
                         "set TEN = '" + role.Ten +
                         "', SPHONG = " + role.SPhong +
                         ", IPHONG = " + role.IPhong +
                         ", UPHONG = " + role.UPhong +
                         ", DPHONG = " + role.DPhong +
                         ", UTEN = " + role.UTen +
                         ", ITEN = " + role.ITen +
                         ", UGIA = " + role.UGia +
                         ", IGIA = " + role.IGia +
                         " Where ID = " + role.Id;
            OracleCommand cmd = DataProvider.conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                RoleDTO imgRole = new RoleDTO("1", role.Ten, "1", "1", "1", "1", "1", "1", "1", "1");
                grant_revoke_role(imgRole);
                grant_revoke_role(role);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        
        public bool XoaRole(RoleDTO role)
        {
        // Câu lệnh Update vào bảng
        string sql = "Delete From TTRole where TEN='" + role.Ten + "'";
        OracleCommand cmd = DataProvider.conn.CreateCommand();
        cmd.CommandText = sql;
        // Update Profile vào Oracle
        string sql2 = "Drop Role " + role.Ten;
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
