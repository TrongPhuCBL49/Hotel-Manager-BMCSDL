using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private string _id;
        private string _pass;
        private string _username;
        private int _idChucDanh;

        public string Id { get => _id; set => _id = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Username { get => _username; set => _username = value; }
        public int IdChucDanh { get => _idChucDanh; set => _idChucDanh = value; }
    }
}
