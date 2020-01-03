using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        private int _idNhanVien;
        private string _username;
        private string _password;
        private string _quota;
        private int _idProfile;
        private int _idRole;
        private string _active;

        public int IdNhanVien { get => _idNhanVien; set => _idNhanVien = value; }
        public string Username { get => _username; set => _username = value; }
        public string Quota { get => _quota; set => _quota = value; }
        public int IdProfile { get => _idProfile; set => _idProfile = value; }
        public int IdRole { get => _idRole; set => _idRole = value; }
        public string Active { get => _active; set => _active = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
