using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmDatLichnew : Form
    {
        public frmDatLichnew()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm,FlyoutPanel pnl)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBacsy_Click(object sender, EventArgs e)
        {
            frmDatLich formCon = new frmDatLich(this); // Truyền chính form cha (this)
            OpenChildForm(formCon, fpnlbacsy);
            fpnlbacsy.ShowPopup();
        }

        private void frmDatLichnew_Load(object sender, EventArgs e)
        {
            frmDatLich formCon = new frmDatLich(this); // Truyền chính form cha (this)
            OpenChildForm(formCon, fpnlbacsy);
            frmDatLich2 formCon2 = new frmDatLich2(this); // Truyền chính form cha (this)
            OpenChildForm(formCon2, fpnlchuyenkhoa);

        }
        public void setFlyPanel()
        {
            fpnlbacsy.HidePopup();
        }

        private void pnlChuyenkhoa_Click(object sender, EventArgs e)
        {
            frmDatLich2 formCon2 = new frmDatLich2(this); // Truyền chính form cha (this)
            OpenChildForm(formCon2, fpnlchuyenkhoa);
            fpnlchuyenkhoa.ShowPopup();
        }
        public void setFlyPanelChuyenkhoa()
        {
            fpnlchuyenkhoa.HidePopup();
        }

        private void flyoutPanelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
