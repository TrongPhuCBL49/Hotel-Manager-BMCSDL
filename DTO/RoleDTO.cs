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
        private string _uTen;
        private string _uGia;
        private string _iTen;
        private string _iGia;
        public RoleDTO()
        {

        }
        public RoleDTO(string id, string ten, string sphong, string iphong, string uphong, string dphong, string uten, string iten, string ugia, string igia)
        {
            Id = id;
            Ten = ten;
            SPhong = sphong;
            IPhong = iphong;
            UPhong = uphong;
            DPhong = dphong;
            UTen = uten;
            ITen = iten;
            UGia = ugia;
            IGia = igia;
        }
        public string Id { get => _id; set => _id = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string SPhong { get => _sPhong; set => _sPhong = value; }
        public string IPhong { get => _iPhong; set => _iPhong = value; }
        public string DPhong { get => _dPhong; set => _dPhong = value; }
        public string UPhong { get => _uPhong; set => _uPhong = value; }
        public string UTen { get => _uTen; set => _uTen = value; }
        public string UGia { get => _uGia; set => _uGia = value; }
        public string ITen { get => _iTen; set => _iTen = value; }
        public string IGia { get => _iGia; set => _iGia = value; }
    }
}
