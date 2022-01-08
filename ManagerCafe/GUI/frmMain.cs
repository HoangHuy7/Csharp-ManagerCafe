using ManagerCafe.Properties;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ManagerCafe.GUI.frmLogin;

namespace ManagerCafe.GUI
{
    public partial class frmMain : Form
    {
        #region Initial

        bool valueImage = true;
        bool resultYesNo;
        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region ImportMoveForm

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        #endregion

        #region DisplayNotification

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void ShowAlertYesNo(string msg, frmAlert.enmType type)
        {
            resultYesNo = false;
            frmAlert frm = new frmAlert();
            frm.showYesNO(msg, type, ref resultYesNo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowAlertYesNo("Bạn thật sự muốn thoát ?", frmAlert.enmType.Info);
            if (resultYesNo)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                this.Close();
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {

            if (valueImage)
            {
                valueImage = false;
                btnGoBack.Image = Resources.back32;
                btnHome.Text = "Home";
                btnOrder.Text = "Order";
                lblManager.Text = "Manager:";
                btnManagerStaff.Text = "Staff";
                btnMangerProduct.Text = "Product";
                btnManagerRevenue.Text = "Revenue";
                btnBack.Text = "Log ouu";
                btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.ImageAlign = ContentAlignment.MiddleLeft;
                btnManagerStaff.ImageAlign = ContentAlignment.MiddleLeft;
                btnMangerProduct.ImageAlign = ContentAlignment.MiddleLeft;
                btnManagerRevenue.ImageAlign = ContentAlignment.MiddleLeft;
                btnBack.ImageAlign = ContentAlignment.MiddleLeft;

                panelMenu.Size = new Size(165, 733);
                panelContainer.Location = new Point(171, 12);
                this.Size = new Size(1487, 733);
            }
            else
            {
                valueImage = true;
                btnGoBack.Image = Resources.menu32;
                btnHome.Text = "";
                btnOrder.Text = "";
                lblManager.Text = "";
                btnManagerStaff.Text = "";
                btnMangerProduct.Text = "";
                btnManagerRevenue.Text = "";
                btnBack.Text = "";
                btnGoBack.ImageAlign = ContentAlignment.MiddleCenter;
                btnOrder.ImageAlign = ContentAlignment.MiddleCenter;
                btnHome.ImageAlign = ContentAlignment.MiddleCenter;
                btnManagerStaff.ImageAlign = ContentAlignment.MiddleCenter;
                btnMangerProduct.ImageAlign = ContentAlignment.MiddleCenter;
                btnManagerRevenue.ImageAlign = ContentAlignment.MiddleCenter;
                btnBack.ImageAlign = ContentAlignment.MiddleCenter;

                panelMenu.Size = new Size(90, 733);
                panelContainer.Location = new Point(90, 32);
                this.Size = new Size(1412, 733);
            }
        }


        private void showStatus(string smg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.showNoti(smg, type);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHeadedToolHelp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region formThis

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblOnline.Text = "Online: " + powverAccess_fLogin;
            if (powverAccess_fLogin != "Admin")
            {
                btnManagerRevenue.Enabled = false;
                btnManagerStaff.Enabled = false;
                btnMangerProduct.Enabled = false;
            }
            else
            {
                btnManagerRevenue.Enabled = true;
                btnManagerStaff.Enabled = true;
                btnMangerProduct.Enabled = true;
            }
            showStatus("Đăng nhập thành công !", frmAlert.enmType.Info);
        }
        private Form activeForm = null;
        private void openChildForm(Form frmChild)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = frmChild;
            frmChild.TopLevel = false;
            frmChild.Dock = DockStyle.Fill;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            panelContainer.Controls.Add(frmChild);
            panelContainer.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrder());
        }

        private void btnMangerProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduct());
        }

        private void btnManagerRevenue_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRevenue());
        }

        private void btnManagerStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStaff());
        }

        #endregion

    }
}
