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
using DevExpress.XtraBars.ToastNotifications;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmMain : Form
    {
        private ToastNotificationsManager toastManager;
        public frmMain()
        {
            InitializeComponent();
            InitToastManager();
        }
        private Form currentFormChild;
        private void ToastManager_Activated(object sender, ToastNotificationEventArgs e)
        {
            // e.NotificationId sẽ là ID bạn đã gán khi tạo
            if ((string)e.NotificationID == "Thong_bao_cap_nhat_lich_hen")
            {
                OpenChildForm(new frmLichHen());
            }
        }
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
            OpenChildForm(new frmDatLich());
        }
        int soluongLichduoccheck ;
        private void frmMain_Load(object sender, EventArgs e)
        {
            Entity.BenhNhan bn = BenhNhanDAL.Instance.GetBenhNhanByID(StaticThing.idBenhNhanTaiKhoan);
            siticoneButton6.Text = bn.Hoten;
            toastManager.Activated += ToastManager_Activated;
            List<DatLich> danhsachdatlich = DatLichDAL.Instance.GetDatLichByBenhNhanID(StaticThing.idBenhNhanTaiKhoan);
            soluongLichduoccheck = danhsachdatlich.Count(llv => llv.TrangThai != null);
            if (soluongLichduoccheck > 0)
            {
                ShowToast("Thong_bao_cap_nhat_lich_hen", "Thông báo lịch hẹn", "Bạn có " + soluongLichduoccheck + " lịch hẹn đã được xác nhận");
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pnlMini_MouseEnter(object sender, EventArgs e)
        {
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatLichnew());
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichHen());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinBenhNhan());
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinBenhNhan());

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichKham());
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoiMk());
        }
    }
}
