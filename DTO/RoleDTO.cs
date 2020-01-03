using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private string _id;
        private string _ten;
        private string _sPhong;
        private string _iPhong;
        private string _dPhong;
        private string _uPhong;
        private string _sTen;
        private string _sGia;
        private string _iTen;
        private string _iGia;

        public string Id { get => _id; set => _id = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string SPhong { get => _sPhong; set => _sPhong = value; }
        public string IPhong { get => _iPhong; set => _iPhong = value; }
        public string DPhong { get => _dPhong; set => _dPhong = value; }
        public string UPhong { get => _uPhong; set => _uPhong = value; }
        public string STen { get => _sTen; set => _sTen = value; }
        public string SGia { get => _sGia; set => _sGia = value; }
        public string ITen { get => _iTen; set => _iTen = value; }
        public string IGia { get => _iGia; set => _iGia = value; }
    }
}
