using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.DAL;

namespace AppDatLichKham.BLL
{
    internal class LichLamViecBLL
    {
        private static LichLamViecBLL instance;
        public static LichLamViecBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichLamViecBLL() { }


    }
}
