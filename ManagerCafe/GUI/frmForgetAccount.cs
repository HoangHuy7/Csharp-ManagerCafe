using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCafe.BUS;
using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using static ManagerCafe.GUI.frmLogin;

namespace ManagerCafe.GUI
{
    public partial class frmForgetAccount : Form
    {
        Staff_BUS listStaff;
        StaffODA_BUS listStaffODA;
        Staff_LinkedList_BUS listStafLK;
        public frmForgetAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmForgetAccount_Load(object sender, EventArgs e)
        {
            switch (typeProgram_fLogin)
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
        private void showStatus(string smg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.showNoti(smg, type);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool finish = false;
            switch (typeProgram_fLogin)
            {
                case "Library":
                    Staff_DTO stff =listStaff.checkAccount(txtID.Text,txtPhones.Text,txtQuestion.Text);
                    if (stff != null)
                    {
                        stff.PassWord = txtNewPW.Text;
                        AccessData_UTIL.writeFileLibrary(frmLogin.FileName.fileNameLibrary);
                        finish = true;
                    }
                    else
                    {
                        finish = false;
                    }
                    break;
                case "ODA":
                    Staff_DTO staffODA = listStaffODA.checkAccount(txtID.Text, txtPhones.Text, txtQuestion.Text);
                    if (staffODA != null)
                    {
                        staffODA.PassWord = txtNewPW.Text;
                        AccessDataODA_UTIL.writeFileODA(frmLogin.FileName.fileNameODA);
                        finish = true;
                    }
                    else
                    {
                        finish = false;
                    }
                    break;
                case "LinkedList":
                    Staff_DTO staffLK = listStafLK.checkAccount(txtID.Text, txtPhones.Text, txtQuestion.Text);
                    if (staffLK != null)
                    {
                        staffLK.PassWord = txtNewPW.Text;
                        AccessDataLinkedList_UTIL.writeFileNode(frmLogin.FileName.fileNameLinkedList, 0);
                        finish = true;
                    }
                    else
                    {
                        finish = false;
                    }
                    break;
                default:
                    break;
            }
            if (finish)
                showStatus("Change Successfully !", frmAlert.enmType.Success);
            else
                showStatus("Change Unsuccessfully !", frmAlert.enmType.Error);
        }
    }
}
