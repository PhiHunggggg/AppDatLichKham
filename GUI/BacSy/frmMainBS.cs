using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;
using AppDatLichKham.Entity;
using AppDatLichKham.GUI.All;
using AppDatLichKham.GUI.BacSy;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.ToastNotifications;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmMainBS : Form
    {
        private ToastNotificationsManager toastManager;

        public frmMainBS()
        {
            InitializeComponent();
            InitToastManager();

        }
        private void ToastManager_Activated(object sender, ToastNotificationEventArgs e)
        {
            // e.NotificationId sẽ là ID bạn đã gán khi tạo
            if ((string)e.NotificationID == "Thong_bao_cap_nhat_phong_kham")
            {
                OpenChildForm(new frmLichLamViec());
            }
            else if ((string)e.NotificationID == "Thong_bao_cap_nhat_lich_hen"|| (string)e.NotificationID == "Thong_bao_cap_nhat" )
            {
                OpenChildForm(new frmXemLichDat());
             }
        }
        private Form currentFormChild;
        private void InitToastManager()
        {
            toastManager = new ToastNotificationsManager
            {
                ApplicationId = "JT APP",
            };
        }
        Image img = Properties.Resources.ChatGPT_Image_10_40_43_27_thg_4__2025_removebg_preview;

        public void ShowToast(string notificationID, string caption, string body)
        {
            var toast = new ToastNotification(
                notificationID, // luôn dùng ID mới để toast không bị trùng
                img,     
                caption,
                body,
                "",
                ToastNotificationTemplate.ImageAndText01
            );

            toastManager.ShowNotification(toast);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlShow.Controls.Add(childForm);
            pnlShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXemLichDat());
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
        }
        int soluongLichDat;
        int soLuongLichLamViec;
        private void frmMainBS_Load(object sender, EventArgs e)
        {
            StaticThing.chieudai = pnlShow.Width;
            BacSi bs = BacSiDAL.Instance.GetBacSiByID(StaticThing.idBacSiTaiKhoan);
            siticoneButton6.Text = bs.HoTen;
            toastManager.Activated += ToastManager_Activated;
            List<DatLich> danhsachlichdat = DatLichDAL.Instance.GetDatLichByBacSiID(StaticThing.idBacSiTaiKhoan);
            soluongLichDat = danhsachlichdat.Count(lh => lh.TrangThai == null);
            
            List<LichHen> danhsachLichLamViec = LichHenDAL.Instance.GetLichHenByBacSiID(StaticThing.idBacSiTaiKhoan);
            soLuongLichLamViec = danhsachLichLamViec.Count(llv => llv.PhongKham == 0);
            if (soLuongLichLamViec > 0&&soluongLichDat==0)
            {
                ShowToast("Thong_bao_cap_nhat_phong_kham","Thông báo mới", $"Bạn có {soLuongLichLamViec} lịch làm việc chưa cập nhật phòng khám.");
            }
            if (soluongLichDat > 0 && soLuongLichLamViec==0)
            {
                ShowToast("Thong_bao_cap_nhat_lich_hen","Thông báo mới", $"Bạn có {soluongLichDat} lịch hẹn chờ xác nhận.");
            }
            if (soluongLichDat > 0 && soLuongLichLamViec > 0)
            {
                ShowToast("Thong_bao_cap_nhat","Thông báo mới", $"Bạn có {soluongLichDat} lịch hẹn chờ xác nhận và {soLuongLichLamViec} lịch làm việc cần cập nhật phòng khám");
            }
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichLamViec());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoiMk());
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCaKham());
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichSuKhamBacSy());
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichNghi());   
        }
    }
}
