using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmMain : Form
    {
        public frmMain()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
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
    }
}
