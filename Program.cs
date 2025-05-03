using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;
using AppDatLichKham.GUI.All;
using AppDatLichKham.GUI.BacSy;
using AppDatLichKham.GUI.BenhNhan;

namespace AppDatLichKham
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**/
            while (true)
            {
                using (frmLogin lg = new frmLogin())
                {
                    DialogResult result = lg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (StaticThing.LoaiTaiKhoan == "BenhNhan")
                        {
                            using (frmMain mf = new frmMain())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else if (StaticThing.LoaiTaiKhoan == "Admin")
                        {
                            using (frmMainAD mf = new frmMainAD())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else if (StaticThing.LoaiTaiKhoan == "BacSi")
                        {
                            using (frmMainBS mf = new frmMainBS())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không hợp lệ.");
                            continue;
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }

            }
            //  Application.Run(new frmXemLichDat());;
        }
    }
}
