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
using DevExpress.CodeParser;
using DevExpress.Utils.Gesture;
using DevExpress.XtraGrid.Views.Layout.Events;

namespace AppDatLichKham.GUI.BacSy
{
    public partial class frmLichLamViec : Form
    {
        public frmLichLamViec()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet1.PhongKham' table. You can move, or remove it, as needed.
            this.phongKhamTableAdapter.Fill(this.quanLyLichKhamDataSet1.PhongKham);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            LoadLichLamViec();
        }
        private void LoadDataLichLamViec(int bacSiID)
        {
            var lichLamViecs = LichLamViecDAL.Instance.GetLichLamViecByBacSiID(bacSiID);

            // Lấy danh sách ngày không trùng lặp
            var distinctDates = lichLamViecs.Select(l => l.Ngay.Date).Distinct().OrderBy(d => d).ToList();

            foreach (var ngay in distinctDates)
            {
                // Tạo dòng mới với ngày
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["NgayHen"].Value = ngay.ToString("dd/MM/yyyy");

                // Lấy danh sách lịch trong ngày đó
                var lichTrongNgay = lichLamViecs.Where(l => l.Ngay.Date == ngay.Date).ToList();

                foreach (var lich in lichTrongNgay)
                {
                    string columnName = "Btn_" + lich.GioBatDau.ToString(@"hh\:mm").Replace(":", "_");
                    if (dataGridView1.Columns.Contains(columnName))
                    {
                        var cell = dataGridView1.Rows[rowIndex].Cells[columnName] as DataGridViewButtonCell;
                        if (cell != null)
                        {
                            cell.Tag = lich; // đánh dấu để sự kiện CellPainting xử lý
                            cell.ToolTipText = "Click để xem lịch hẹn";
                        }
                    }
                }
            }
        }
        private void LoadLichLamViec()
        {
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            var col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Ngày hẹn";
            col.Name = "NgayHen"; // để tránh lỗi ký tự
            col.Width = 92;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(col);
            string[] newColumns = { "07:00", "07:15", "07:30", "07:45", "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15","16:30","16:45","17:00" };
       
            foreach (string colName in newColumns)
            {
                var buttonCol = new DataGridViewButtonColumn();
                buttonCol.HeaderText = colName;
                buttonCol.Name = "Btn_" + colName.Replace(":", "_");
                buttonCol.UseColumnTextForButtonValue = true;
                //buttonCol.Width = 54;
                buttonCol.Width = (StaticThing.chieudai-col.Width)/30;
                dataGridView1.Columns.Add(buttonCol);
            }
            LoadDataLichLamViec(StaticThing.idBacSiTaiKhoan);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Chỉ xử lý nếu là nút và có dữ liệu lịch
                if (cell is DataGridViewButtonCell && cell.Tag != null && cell.Tag is Entity.LichLamViec)
                {
                    var lich = (Entity.LichLamViec)cell.Tag;
                    LichHen lichhen = LichHenDAL.Instance.GetLichHenByLichID(lich.LichHenID);
                    lblTenBn.Text = lichhen.HoTenNguoiKham;
                    lblGioiTinh.Text = lichhen.GioiTinh? "Nam":"Nu";
                    lblSDT.Text = lichhen.SDT;
                    lblDiaChi.Text = lichhen.DiaChi;
                    lblNgayHen.Text  = lichhen.NgayHen.ToString("dd/MM/yyyy");
                    lblGioHen.Text = lichhen.GioHen.ToString(@"hh\:mm");
                    txtlichhenid.Text = lichhen.LichHenID.ToString();
                    if (lichhen.PhongKham == 0)
                    {
                        var danhSach = PhongKhamDAL.Instance.GetDanhSachPhongKhamRanh(lichhen.NgayHen, lichhen.GioHen);
                        cbcPhongKham.DataSource = danhSach;
                        cbcPhongKham.DisplayMember = "TenPhongKham";
                        cbcPhongKham.ValueMember = "PhongKham";
                        lblnahccapnhat.Visible = true;
                        cbcPhongKham.Visible = true;
                        siticoneButton1.Enabled = true;
                        lblTenPhongKham.Visible = false;
                    }
                    else
                    {
                        siticoneButton1.Enabled = false;
                        cbcPhongKham.Visible = false;
                        lblnahccapnhat.Visible = false;
                        lblTenPhongKham.Visible = true;
                        lblTenPhongKham.Text = PhongKhamDAL.Instance.GetTenPhongKhamByID(lichhen.PhongKham);
                    }
                    pnlLichhen.Visible = true;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Tag is LichLamViec lich)
                {
                    LichHen lichhen = LichHenDAL.Instance.GetLichHenByLichID(lich.LichHenID);
                    // Vẽ nền button màu xanh
                    if (lichhen.PhongKham != 0)
                    {
                        e.Graphics.FillRectangle(Brushes.LightGreen, e.CellBounds);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                    }
                        e.Graphics.DrawRectangle(Pens.Gray, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    // Vẽ nội dung text
                    TextRenderer.DrawText(e.Graphics,
                        cell.Value?.ToString() ?? "",
                        e.CellStyle.Font,
                        e.CellBounds,
                        e.CellStyle.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbcPhongKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnahccapnhat.Visible = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (LichHenDAL.Instance.UpdatePhongKhamOrGioDen(Convert.ToInt32(txtlichhenid.Text), Convert.ToInt32(cbcPhongKham.SelectedValue), null,null,null))
            {
                MessageBox.Show("Cập nhật thành công");
                pnlLichhen.Visible = false;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            pnlLichhen.Visible = false;
        }
    }
}
