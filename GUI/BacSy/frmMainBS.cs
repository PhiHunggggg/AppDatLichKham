using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.GUI.BacSy;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmMainBS : Form
    {
        public frmMainBS()
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
            OpenChildForm(new frmXemLichDat());
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
        }
        private void frmMainBS_Load(object sender, EventArgs e)
        {
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichLamViec());
        }
    }
}
