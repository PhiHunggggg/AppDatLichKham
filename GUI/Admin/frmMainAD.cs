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
using AppDatLichKham.GUI.Admin;
using AppDatLichKham.GUI.All;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmMainAD : Form
    {
        public frmMainAD()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
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
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoiMk());
        }

        private void frmMainAD_Load(object sender, EventArgs e)
        {
            siticoneButton6.Text = StaticThing.TenDangNhap;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDuyetLichNghi());
        }
    }
}
