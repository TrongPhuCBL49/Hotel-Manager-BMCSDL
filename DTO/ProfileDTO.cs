using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProfileDTO
    {
        private string _id;
        private string _ten;
        private string _falseLogin;
        private string _sessionUser;
        private string _connectTime;
        private string _idleTime;

        public string Id { get => _id; set => _id = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string FalseLogin { get => _falseLogin; set => _falseLogin = value; }
        public string SessionUser { get => _sessionUser; set => _sessionUser = value; }
        public string ConnectTime { get => _connectTime; set => _connectTime = value; }
        public string IdleTime { get => _idleTime; set => _idleTime = value; }
    }
}
