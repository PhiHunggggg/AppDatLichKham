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
using Siticone.Desktop.UI.WinForms;

namespace AppDatLichKham.GUI.BacSy
{
    public partial class frmLichNghi : Form
    {
        public frmLichNghi()
        {
            InitializeComponent();
        }

        private void calendarControl1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void calendarControl1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
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
            if(LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, e.Date,true))
            {
                using (Brush backBrush = new SolidBrush(Color.LightGreen))
                using (Brush textBrush = new SolidBrush(Color.Black))
                using (Font font = new Font(e.Style.Font, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    string dayText = e.Date.Day.ToString();
                    SizeF textSize = e.Graphics.MeasureString(dayText, font);
                    PointF textPos = new PointF(
                        e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2,
                        e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(dayText, font, textBrush, textPos);
                }
                e.Handled = true; // Không cho DevExpress vẽ mặc định
            }
            if(LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, e.Date, false))
            {
                using (Brush backBrush = new SolidBrush(Color.Red))
                using (Brush textBrush = new SolidBrush(Color.Black))
                using (Font font = new Font(e.Style.Font, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    string dayText = e.Date.Day.ToString();
                    SizeF textSize = e.Graphics.MeasureString(dayText, font);
                    PointF textPos = new PointF(
                        e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2,
                        e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(dayText, font, textBrush, textPos);
                }
                e.Handled = true; // Không cho DevExpress vẽ mặc định
            }
        }
        private DateTime? lastValidDate = null;
        private bool isResettingDate = false;


        private void dtk_EditValueChanged(object sender, EventArgs e)
        {
            if (isResettingDate) return;

            if (calendarControl1.EditValue is DateTime selectedDate)
            {
                if (selectedDate < DateTime.Today ||
                    selectedDate.DayOfWeek == DayOfWeek.Saturday ||
                    selectedDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    isResettingDate = true;
                    // Reset ngày tạm
                    calendarControl1.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    calendarControl1.EditValue = lastValidDate ?? DateTime.Today;

                    isResettingDate = false;
                    lblLoi.Visible = true;
                    if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        lblLoi.Text = "Thứ 7, Chủ nhật được nghỉ rồi";
                    }
                    else if (selectedDate < DateTime.Today)
                    {
                        lblLoi.Text = "Không thể đặt lịch trước ngày hôm nay";
                    }
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                    return;
                }
                else if(LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, selectedDate,true))
                {
                    isResettingDate = true;
                    // Reset ngày tạm
                    calendarControl1.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    calendarControl1.EditValue = lastValidDate ?? DateTime.Today;
                    isResettingDate = false;
                    lblLoi.Visible = true;
                    lblLoi.Text = "Ngày này đã có lịch nghỉ";
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                }
                else if(LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, selectedDate, false))
                {
                    isResettingDate = true;
                    // Reset ngày tạm
                    calendarControl1.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    calendarControl1.EditValue = lastValidDate ?? DateTime.Today;
                    isResettingDate = false;
                    lblLoi.Visible = true;
                    lblLoi.Text = "Ngày này đang được check";
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                }
                else
                {
                    btnCapNhat.Enabled = true;
                    lblLoi.Visible = false;
                    lastValidDate = selectedDate;
                    pnlBtn.Visible = true;
                    btnCapNhat2.Enabled = true;
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            pnlNgaynghi.Visible = true;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = calendarControl1.EditValue as DateTime?;
            if (selectedDate.HasValue)
            {
                LichNghiDAL.Instance.InsertLichNghi(StaticThing.idBacSiTaiKhoan, selectedDate.Value, null, txtLyDo.Text, false);
                MessageBox.Show("Lịch nghỉ đã được thêm thành công. Vui lòng đợi Admin duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlBtn.Visible = false;
                pnlNgaynghi.Visible = false;
                btnCapNhat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoi_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            pnlNghitheoca.Visible = true;
        }

        private void dtk2_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
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
            if (LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, e.Date, true))
            {
                using (Brush backBrush = new SolidBrush(Color.LightGreen))
                using (Brush textBrush = new SolidBrush(Color.Black))
                using (Font font = new Font(e.Style.Font, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    string dayText = e.Date.Day.ToString();
                    SizeF textSize = e.Graphics.MeasureString(dayText, font);
                    PointF textPos = new PointF(
                        e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2,
                        e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(dayText, font, textBrush, textPos);
                }
                e.Handled = true; // Không cho DevExpress vẽ mặc định
            }
            if (LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, e.Date, false))
            {
                using (Brush backBrush = new SolidBrush(Color.Red))
                using (Brush textBrush = new SolidBrush(Color.Black))
                using (Font font = new Font(e.Style.Font, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    string dayText = e.Date.Day.ToString();
                    SizeF textSize = e.Graphics.MeasureString(dayText, font);
                    PointF textPos = new PointF(
                        e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2,
                        e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(dayText, font, textBrush, textPos);
                }
                e.Handled = true; // Không cho DevExpress vẽ mặc định
            }
        }
        private DateTime? lastValidDate2 = null;
        private bool isResettingDate2 = false;
        private void dtk2_EditValueChanged(object sender, EventArgs e)
        {
            if (isResettingDate2) return;

            if (dtk2.EditValue is DateTime selectedDate)
            {
                if (selectedDate < DateTime.Today ||
                    selectedDate.DayOfWeek == DayOfWeek.Saturday ||
                    selectedDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    isResettingDate2 = true;
                    // Reset ngày tạm
                    dtk2.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    dtk2.EditValue = lastValidDate ?? DateTime.Today;

                    isResettingDate2 = false;
                    lblLoi.Visible = true;
                    if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        lblLoi2.Text = "Thứ 7, Chủ nhật được nghỉ rồi";
                    }
                    else if (selectedDate < DateTime.Today)
                    {
                        lblLoi2.Text = "Không thể đặt lịch trước ngày hôm nay";
                    }
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                    return;
                }
                else if (LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, selectedDate, true))
                {
                    isResettingDate2 = true;
                    // Reset ngày tạm
                    dtk2.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    dtk2.EditValue = lastValidDate ?? DateTime.Today;
                    isResettingDate2 = false;
                    lblLoi2.Visible = true;
                    lblLoi2.Text = "Ngày này đã có lịch nghỉ";
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                }
                else if (LichNghiDAL.Instance.CheckLichNghiExistsNgay(StaticThing.idBacSiTaiKhoan, selectedDate, false))
                {
                    isResettingDate = true;
                    // Reset ngày tạm
                    dtk2.EditValue = DateTime.Today.AddDays(1);
                    // Reset lại giá trị hợp lệ
                    dtk2.EditValue = lastValidDate ?? DateTime.Today;
                    isResettingDate2 = false;
                    lblLoi2.Visible = true;
                    lblLoi2.Text = "Ngày này đang được check";
                    btnCapNhat.Enabled = false;
                    pnlBtn.Visible = false;
                    btnCapNhat2.Enabled = false;
                }
                else
                {
                    lblLoi2.Visible = false;
                    lastValidDate2 = selectedDate;
                    pnlBtn.Visible = true;
                    btnCapNhat2.Enabled = true;
                    CapNhatTrangThaiGio2(StaticThing.idBacSiTaiKhoan, selectedDate);
                }
            }
        }
        private List<Button> timeButtons;

        private void frmLichNghi_Load(object sender, EventArgs e)
        {

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
        }
        TimeSpan selectedTime;
        private void TimeButton_Click(object sender, EventArgs e)
        {
            Color defaultColor = Color.LightGray;
            Color selectedColor = Color.MediumPurple;

            foreach (var btn in timeButtons)
            {
                btn.BackColor = defaultColor;
            }

            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                clickedBtn.BackColor = selectedColor;
                clickedBtn.Tag = clickedBtn.Tag; // Lưu lại thời gian đã chọn
                selectedTime = (TimeSpan)clickedBtn.Tag;
            }
            txtGioHen.Text = clickedBtn.Tag.ToString();
        }
        private void CapNhatTrangThaiGio2(int bacSiID, DateTime ngay)
        {
            foreach (System.Windows.Forms.Control control in pnlBtn.Controls)
            {
                if (control is Button btn && btn.Tag is TimeSpan gio)
                {
                    bool isBusy;
                    if (!LichLamViecDAL.Instance.CheckCaTrung(bacSiID, ngay, gio) && !LichNghiDAL.Instance.CheckLichNghiExistsCa(bacSiID, ngay, gio, true)&& !LichNghiDAL.Instance.CheckLichNghiExistsCa(bacSiID, ngay, gio, false))
                    {
                        isBusy = false;
                    }
                    else
                    {
                        isBusy = true;
                    }

                    if (isBusy)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.DodgerBlue;
                    }
                }
            }
        }

        private void btnCapNhat2_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = dtk2.EditValue as DateTime?;
            if (selectedDate.HasValue)
            {
                TimeSpan gioHen = TimeSpan.Parse(txtGioHen.Text);
                LichNghiDAL.Instance.InsertLichNghi(StaticThing.idBacSiTaiKhoan, selectedDate.Value, gioHen, txtLyDo.Text, false);
                MessageBox.Show("Lịch nghỉ đã được thêm thành công. Vui lòng đợi Admin duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlBtn.Visible = false;
                btnCapNhat2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
