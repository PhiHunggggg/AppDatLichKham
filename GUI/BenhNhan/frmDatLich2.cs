using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.BLL;
using AppDatLichKham.DAL;
using AppDatLichKham.Entity;
using Siticone.Desktop.UI.WinForms;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmDatLich2 : Form
    {
        public frmDatLich2()
        {
            InitializeComponent();

        }
        private List<Button> timeButtons;
        int n = 0;

        private frmDatLichnew parentForm;
        public frmDatLich2(frmDatLichnew frmCha)
        {
            InitializeComponent();
            parentForm = frmCha;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            parentForm.setFlyPanelChuyenkhoa();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneComboBox1.SelectedValue == null)
            {
                return;
            }
            if (siticoneComboBox1.SelectedValue is int selectedValue)
            {
                txtChuyenkhoaid.Text = siticoneComboBox1.SelectedValue.ToString();
                dtk.Visible = true;
                pnlBtn.Visible = false;
                btnDangKi.Enabled = false;

            }
        }

        private void frmDatLich2_Load(object sender, EventArgs e)
        {
            dtk.EditValue = DateTime.Now;
            n++;
            pnlBtn.Visible = false;
            List<ChuyenKhoa> danhsachchuyenkhoa = ChuyenKhoaDAL.Instance.GetAllChuyenKhoa();
            siticoneComboBox1.DataSource = danhsachchuyenkhoa;
            siticoneComboBox1.DisplayMember = "TenChuyenKhoa";
            siticoneComboBox1.ValueMember = "ChuyenKhoaID";
            siticoneComboBox1.SelectedIndex = 1;
            siticoneComboBox1.BorderRadius = 19;
            timeButtons = new List<Button>()
            {
                 btn7h, btn7h15, btn7h30, btn7h45,
                 btn8h, btn8h15, btn8h30, btn8h45,
                 btn9h, btn9h15, btn9h30, btn9h45,
                 btn10h, btn10h15, btn10h30, btn10h45,
                 btn11h,
                  btn14h, btn14h15, btn14h30, btn14h45,
                 btn15h, btn15h15, btn15h30, btn15h45,
                 btn16h, btn16h15, btn16h30, btn16h45,
                  btn17h
            };
            foreach (var btn in timeButtons)
            {
                btn.Click += TimeButton_Click;
            }
            btn7h.Tag = new TimeSpan(7, 0, 0);
            btn7h15.Tag = new TimeSpan(7, 15, 0);
            btn7h30.Tag = new TimeSpan(7, 30, 0);
            btn7h45.Tag = new TimeSpan(7, 45, 0);
            btn8h.Tag = new TimeSpan(8, 0, 0);
            btn8h15.Tag = new TimeSpan(8, 15, 0);
            btn8h30.Tag = new TimeSpan(8, 30, 0);
            btn8h45.Tag = new TimeSpan(8, 45, 0);
            btn9h.Tag = new TimeSpan(9, 0, 0);
            btn9h15.Tag = new TimeSpan(9, 15, 0);
            btn9h30.Tag = new TimeSpan(9, 30, 0);
            btn9h45.Tag = new TimeSpan(9, 45, 0);
            btn10h.Tag = new TimeSpan(10, 0, 0);
            btn10h15.Tag = new TimeSpan(10, 15, 0);
            btn10h30.Tag = new TimeSpan(10, 30, 0);
            btn10h45.Tag = new TimeSpan(10, 45, 0);
            btn11h.Tag = new TimeSpan(11, 0, 0);
            btn14h.Tag = new TimeSpan(14, 0, 0);
            btn14h15.Tag = new TimeSpan(14, 15, 0);
            btn14h30.Tag = new TimeSpan(14, 30, 0);
            btn14h45.Tag = new TimeSpan(14, 45, 0);
            btn15h.Tag = new TimeSpan(15, 0, 0);
            btn15h15.Tag = new TimeSpan(15, 15, 0);
            btn15h30.Tag = new TimeSpan(15, 30, 0);
            btn15h45.Tag = new TimeSpan(15, 45, 0);
            btn16h.Tag = new TimeSpan(16, 0, 0);
            btn16h15.Tag = new TimeSpan(16, 15, 0);
            btn16h30.Tag = new TimeSpan(16, 30, 0);
            btn16h45.Tag = new TimeSpan(16, 45, 0);
            btn17h.Tag = new TimeSpan(17, 0, 0);
            AppDatLichKham.Entity.BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(StaticThing.idBenhNhanTaiKhoan);
            txtTenBenhNhan.Text = bn.Hoten;
            dtkNgaysinh.Value = bn.Ngaysinh;
            txtSdt.Text = bn.Sdt;
            txtDiachi.Text = bn.Diachi;
            if (bn.Gioitinh == true)
            {
                Nam.Checked = true;
                Nu.Checked = false;
            }
            else
            {
                Nam.Checked = false;
                Nu.Checked = true;
            }
        }
        int check = -1;
        private void TimeButton_Click(object sender, EventArgs e)
        {
            Color defaultColor = Color.FromArgb(24, 26, 27);
            Color selectedColor = Color.FromArgb(17, 102, 49);

            foreach (var btn in timeButtons)
            {
                btn.BackColor = defaultColor;
            }

            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                clickedBtn.BackColor = selectedColor;
                txtGioHen.Text = clickedBtn.Tag.ToString();
                if (check == 1)
                {
                    btnDangKi.Enabled = true;
                }
                txtGioHen.Text = clickedBtn.Tag.ToString();
            }

        }
        private bool CheckTrungNgay(int benhNhanID, DateTime ngay)
        {
            if (DatLichDAL.Instance.CheckDaDatLich(benhNhanID, ngay))
            {
                if (ngay == DateTime.Today && n < 1)
                {
                    pnlBtn.Visible = false;
                    return true;

                }
                pnlBtn.Visible = false;
                return true;
            }
            return false;
        }
        private void CapNhatTrangThaiGio(int chuyenKhoaID, DateTime ngay)
        {
            foreach (System.Windows.Forms.Control control in pnlBtn.Controls)
            {
                if (control is Button btn && btn.Tag is TimeSpan gio)
                {

                    List<BacSi> danhSachBacSyranh = BacSiDAL.Instance.GetDanhSachBacSiRanh(chuyenKhoaID, ngay, gio);

                    if (danhSachBacSyranh == null || danhSachBacSyranh.Count == 0)
                    {
                        btn.BackColor = Color.FromArgb(24, 26, 27);
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Enabled = true;
                    }
                }
            }
        }
        private DateTime? lastValidDate = null;
        private bool isResettingDate = false;
        private void dtk_EditValueChanged(object sender, EventArgs e)
        {
            if (isResettingDate) return;

            if (dtk.EditValue is DateTime selectedDate)
            {
                if (selectedDate < DateTime.Today ||
                    selectedDate.DayOfWeek == DayOfWeek.Saturday ||
                    selectedDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    isResettingDate = true;
                    pnlBtn.Visible = false;
                    // Reset ngày tạm
                    dtk.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    dtk.EditValue = lastValidDate ?? DateTime.Today;

                    isResettingDate = false;
                    lblLoi.Visible = true;
                    if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        lblLoi.Text = "Không thể đặt lịch vào thứ 7 và chủ nhật";
                    }
                    else if (selectedDate < DateTime.Today)
                    {
                        lblLoi.Text = "Không thể đặt lịch trước ngày hôm nay";
                    }
                    return;
                }
                else if(CheckTrungNgay(StaticThing.idBenhNhanTaiKhoan, dtk.SelectedRanges[0].StartDate.Date))
                {
                    pnlBtn.Visible = false;
                    btnDangKi.Enabled = false;
                    lblLoi.Visible = true;
                    lblLoi.Text = "Bạn đã có lịch hẹn vào ngày này.";
                    return;
                }
                else
                {
                    pnlBtn.Visible = true;
                    btnDangKi.Enabled = false;
                    lblLoi.Visible = false;
                    lastValidDate = selectedDate;
                }
            }
        }

        private void dtk_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date < DateTime.Today || e.Date.DayOfWeek == DayOfWeek.Saturday || e.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime day = e.Date;

                if (day < DateTime.Today || day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    using (Brush backBrush = new SolidBrush(Color.Gray))
                    using (Brush textBrush = new SolidBrush(Color.Black))
                    using (Font font = new Font(e.Style.Font, FontStyle.Regular))
                    {
                        e.Graphics.FillRectangle(backBrush, e.Bounds);
                        string dayText = day.Day.ToString();

                        SizeF textSize = e.Graphics.MeasureString(dayText, font);
                        PointF textPos = new PointF(
                            e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2,
                            e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2);

                        e.Graphics.DrawString(dayText, font, textBrush, textPos);
                    }

                    e.Handled = true; // Không cho DevExpress vẽ mặc định
                }
            }
        }

        private void dtk_SelectionChanged(object sender, EventArgs e)
        {
            check = 1;
            if (dtk.SelectedRanges.Count == 0 || dtk.SelectedRanges[0] == null)
            {
                return;
            }

            else if (CheckTrungNgay(StaticThing.idBenhNhanTaiKhoan, dtk.SelectedRanges[0].StartDate.Date))
            {
                return;
            }
            else if (txtChuyenkhoaid.Text == "")
            {
                return;
            }
            else
            {
                DateTime ngay = dtk.SelectedRanges[0].StartDate.Date;
                CapNhatTrangThaiGio(Convert.ToInt32(txtChuyenkhoaid.Text), ngay);
                pnlBtn.Visible = true;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            TimeSpan gioHen = Convert.ToDateTime(txtGioHen.Text).TimeOfDay;
            List<BacSi> danhsachbacsyaranh = BacSiDAL.Instance.GetDanhSachBacSiRanh(Convert.ToInt32(txtChuyenkhoaid.Text), dtk.SelectedRanges[0].StartDate.Date, gioHen);
            cbbBacsy.DataSource = danhsachbacsyaranh;
            cbbBacsy.DisplayMember = "HoTen";
            cbbBacsy.ValueMember = "BacSiID";
            cbbBacsy.SelectedIndex = 0;
            pnlDatLich.Visible = true;
            lblThoigianhen.Text = txtGioHen.Text;
            lblNgayhen.Text = dtk.SelectedRanges[0].StartDate.Date.ToString("dd/MM/yyyy");
            txtNgay.Text =dtk.SelectedRanges[0].StartDate.Date.ToString();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            pnlDatLich.Visible = false;
        }

        private void Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (Nam.Checked)
            {
                Nu.Checked = false;
            }
            else
            {
                Nu.Checked = true;
            }
        }

        private void Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (Nu.Checked)
            {
                Nam.Checked = false;
            }
            else
            {
                Nam.Checked = true;
            }
        }

        private void btnDatlich_Click(object sender, EventArgs e)
        {
            if (DatLichBLL.Instance.ThemDatLich(cbbBacsy.SelectedValue.ToString(), StaticThing.idBenhNhanTaiKhoan, txtTenBenhNhan.Text, Nam.Checked, txtSdt.Text, txtDiachi.Text, txtghichu.Text, txtNgay.Text, txtGioHen.Text))
            {
                MessageBox.Show("Đăng ký thành công, vui lòng chờ xác nhận của bác sỹ .");
                pnlDatLich.Visible = false;
                pnlBtn.Visible = false;
                btnDangKi.Enabled = false;  
            }
            else
            {
                MessageBox.Show("Đặt lịch thất bại");
            }
        }
    }

}
