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
    public class ProfileBUS
    {
        private static ProfileBUS instance;

        public static ProfileBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProfileBUS();
                return instance;
            }
        }

        private ProfileBUS() { }

        public DataTable DSProfile()
        {
            return ProfileDAO.Instance.DSProfile();
        }

        public bool ThemProfile(string Id, string Ten, string FalseLogin, string SessionUser, string ConnectTime, string IdleTime)
        {
            ProfileDTO profile = new ProfileDTO();
            try
            {
                profile.Id = Id;
                profile.Ten = Ten;
                profile.FalseLogin = FalseLogin;
                profile.SessionUser = SessionUser;
                profile.ConnectTime = ConnectTime;
                profile.IdleTime = IdleTime;
            }
            catch (Exception)
            {
                return false;
            }
            return ProfileDAO.Instance.ThemProfile(profile);
        }
        public bool SuaProfile(string Id, string Ten, string FalseLogin, string SessionUser, string ConnectTime, string IdleTime)
        {
            ProfileDTO profile = new ProfileDTO();
            try
            {
                profile.Id = Id;
                profile.Ten = Ten;
                profile.FalseLogin = FalseLogin;
                profile.SessionUser = SessionUser;
                profile.ConnectTime = ConnectTime;
                profile.IdleTime = IdleTime;
            }
            catch (Exception)
            {
                return false;
            }
            return ProfileDAO.Instance.SuaProfile(profile);
        }
        public bool XoaProfile(string Ten)
        {
            ProfileDTO profile = new ProfileDTO();
            profile.Ten = Ten;
            return ProfileDAO.Instance.XoaProfile(profile);
        }

    }
}
