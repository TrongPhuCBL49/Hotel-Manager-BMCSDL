using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class RoleBUS
    {
        private static RoleBUS instance;

        public static RoleBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleBUS();
                return instance;
            }
        }

        private RoleBUS() { }

        public DataTable DSRole()
        {
            return RoleDAO.Instance.DSRole();
        }

        public bool ThemRole(string Id, string Ten, string SPhong, string IPhong, string UPhong, string DPhong, string UTen, string ITen, string UGia, string IGia)
        {
            RoleDTO role = new RoleDTO();
            try
            {
                role.Id = Id;
                role.Ten = Ten;
                role.SPhong = SPhong;
                role.IPhong = IPhong;
                role.UPhong = UPhong;
                role.DPhong = DPhong;
                role.UTen = UTen;
                role.ITen = ITen;
                role.UGia = UGia;
                role.IGia = IGia;
            }
            catch (Exception)
            {
                return false;
            }
            return RoleDAO.Instance.ThemRole(role);
        }
        public bool SuaRole(string Id, string Ten, string SPhong, string IPhong, string UPhong, string DPhong, string UTen, string ITen, string UGia, string IGia)
        {
            RoleDTO role = new RoleDTO();
            try
            {
                role.Id = Id;
                role.Ten = Ten;
                role.SPhong = SPhong;
                role.IPhong = IPhong;
                role.UPhong = UPhong;
                role.DPhong = DPhong;
                role.UTen = UTen;
                role.ITen = ITen;
                role.UGia = UGia;
                role.IGia = IGia;
            }
            catch (Exception)
            {
                return false;
            }
            return RoleDAO.Instance.SuaRole(role);
        }
        public bool XoaRole(string Ten)
        {
            RoleDTO role = new RoleDTO();
            role.Ten = Ten;
            return RoleDAO.Instance.XoaRole(role);
        }

    }
}
