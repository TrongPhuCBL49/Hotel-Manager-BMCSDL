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
    public class UsersBUS
    {
        private static UsersBUS instance;

        public static UsersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersBUS();
                return instance;
            }
        }

        private UsersBUS() { }

        public DataTable DSUsers()
        {
            return UsersDAO.Instance.DSUsers();
        }

        public bool ThemUsers(string NhanVien, string Username, string Password, string Profile, string Role, string Quota, string Active)
        {
            UsersDTO users = new UsersDTO();
            try
            {
                users.IdNhanVien = UsersDAO.Instance.IdNhanVien(NhanVien);
                users.Username = Username;
                users.Password = Password;
                users.IdProfile = UsersDAO.Instance.IdProfile(Profile);
                users.IdRole = UsersDAO.Instance.IdRole(Role);
                users.Quota = Quota;
                users.Active = Active;
            }
            catch (Exception)
            {
                return false;
            }
            return UsersDAO.Instance.ThemUsers(users);
        }
        public bool SuaUsers(string NhanVien, string Username, string Password, string Profile, string Role, string Quota, string Active)
        {
            UsersDTO users = new UsersDTO();
            try
            {
                users.IdNhanVien = UsersDAO.Instance.IdNhanVien(NhanVien);
                users.Username = Username;
                users.Password = Password;
                users.IdProfile = UsersDAO.Instance.IdProfile(Profile);
                users.IdRole = UsersDAO.Instance.IdRole(Role);
                users.Quota = Quota;
                users.Active = Active;
            }
            catch (Exception)
            {
                return false;
            }
            return UsersDAO.Instance.SuaUsers(users);
        }
        public bool XoaUsers(string Username)
        {
            UsersDTO users = new UsersDTO();
            users.Username = Username;
            return UsersDAO.Instance.XoaUsers(users);
        }

    }
}
