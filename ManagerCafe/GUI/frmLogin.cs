using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCafe.UTIL;
using ManagerCafe.BUS;

namespace ManagerCafe.GUI
{
    public partial class frmLogin : Form
    {
        #region Initial

        Staff_BUS listStaff;
        StaffODA_BUS listStaffODA;
        Staff_LinkedList_BUS listStafLK;
        public static string powverAccess_fLogin = "";//Get value ID staff login
        public static string typeProgram_fLogin = "";//type using 
        public static string nameStaffAccess = "";

        public struct FileName
        {
            public const string fileNameLibrary = "dataLibrary.dat";
            public const string fileNameODA = "dataODA.dat";
            public const string fileNameLinkedList = "dataLinkedList.dat";
            public const string fileNameRevenue = "dataRevenue.dat";
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Display&Show
        private void ShowAlertYesNo(string msg, frmAlert.enmType type)
        {
            bool result = false;
            frmAlert frm = new frmAlert();
            frm.showYesNO(msg, type, ref result);
        }

        private void showStatus(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.showNoti(msg, type);

        }
        private void loadTypeProgram(string type)
        {
            switch (type)
            {
                case "Library":
                    listStaff = new Staff_BUS();
                    break;
                case "ODA":
                    listStaffODA = new StaffODA_BUS();
                    break;
                case "LinkedList":
                    listStafLK = new Staff_LinkedList_BUS();
                    break;
                default:
                    break;
            }
        }
        private bool checkLogin(string type,string id,string password)
        {
            bool check = false;
            switch (type)
            {
                case "Library":
                    check = listStaff.checkAccountLogin(id, password);
                    break;
                case "ODA":
                    check = listStaffODA.checkAccountLogin(id, password);
                    break;
                case "LinkedList":
                    check = listStafLK.checkAccountLogin(id, password);
                    break;
                default:
                    break;
            }
            return check;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbbTypeProgram.Text == "")
            {
                showStatus("choice value combobox", frmAlert.enmType.Info);
            }
            else
            {
                string type = cbbTypeProgram.Text;
                loadTypeProgram(type);
                bool checkAccount = checkLogin(type, txtIDAcount.Text, txtPassword.Text);
                if (checkAccount)
                {
                    powverAccess_fLogin = txtIDAcount.Text;
                    typeProgram_fLogin = cbbTypeProgram.Text;
                    frmMain fMain = new frmMain();
                    this.Hide();
                    fMain.ShowDialog();
                    showStatus("Logged Out !", frmAlert.enmType.Warning);
                    this.Show();
                    txtIDAcount.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    showStatus("False infomation Account !", frmAlert.enmType.Error);
                }
                
            }
        }


        private void linkLabelForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbbTypeProgram.Text == "")
            {
                showStatus("choice value combobox", frmAlert.enmType.Info);
            }
            else
            {
                typeProgram_fLogin = cbbTypeProgram.Text;
                frmForgetAccount f = new frmForgetAccount();
                f.ShowDialog();
            }      
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void cbbTypeProgram_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbbTypeProgram.SelectedItem.ToString())
            {
                case "Library":
                    AccessData_UTIL.ReadFileLibrary(FileName.fileNameLibrary);
                    break;
                case "ODA":
                    AccessDataODA_UTIL.ReadFileODA(FileName.fileNameODA);
                    break;
                case "LinkedList":
                    
                    AccessDataLinkedList_UTIL data = AccessDataLinkedList_UTIL.Intial();
                    AccessDataLinkedList_UTIL.ReadFileNode(FileName.fileNameLinkedList, 0);
                    AccessDataLinkedList_UTIL.ReadFileNode(FileName.fileNameLinkedList, 1);
                    break;
                default:
                    break;
            }
        }

        private void cbbTypeProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
