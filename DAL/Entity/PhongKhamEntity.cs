using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.DAL.Entity
{
    internal class PhongKhamEntity
    {
        public PhongKhamEntity() { }
        public PhongKhamEntity(int phongKham, string tenPhongKham)
        {
            this.PhongKham = phongKham;
            this.TenPhongKham = tenPhongKham;
        }
        private int phongkham;
        public int PhongKham { get { return phongkham; } set { phongkham = value; } }
        private string tenphongkham;
        public string TenPhongKham { get { return tenphongkham; } set { tenphongkham = value; } }

    }
}
