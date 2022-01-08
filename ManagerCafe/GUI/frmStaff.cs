using ManagerCafe.BUS;
using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ManagerCafe.GUI.frmLogin;
using ManagerCafe.UTIL;



namespace ManagerCafe.GUI
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        #region Itinial
        Staff_BUS ListStaffLibrary;
        StaffODA_BUS listStaffODA;
        Staff_LinkedList_BUS ListStaff_LinkedList;

        private static int indexRow = -1; // khởi tạo vị trí khi click vào dgv
        private bool resultYesNo = true; // biến này dùng dể show câu hỏi yes no dùng để hỏi khi thực hiện gì đó quan trọng

        #endregion

        #region Fuction
        private void btnADDStaff_Click(object sender, EventArgs e)
        {
            try
            {
                resultYesNo = false;
                Staff_DTO nv = new Staff_DTO();
                //using_Program dùng để hiển thị lên dgv
                // bằng 0 thì dùng thư viện, 1 thì mảng một chiều, 2 thì dslk
                int using_Program = -1;
                bool finish = false;
                nv.Id = txtID.Text;
                nv.PassWord = txtPassword.Text;
                nv.Name = txtFullName.Text;
                nv.Sex = rdbFemale.Checked;
                nv.PhoneNumber = txtPhoneNumbers.Text;
                nv.Brithday = DateTime.Parse(dtpBirthdays.Text);
                nv.Address = txtAddress.Text;
                nv.NumberSecret = int.Parse(txtNumberSecret.Text);

                //typeProgram_fLogin là lấy biến tĩnh từ bên fLogin trong phần combobox
                if (typeProgram_fLogin == "Library")
                {
                    finish = ListStaffLibrary.add_Staff_Library(nv);
                    using_Program = 0;
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    int i = indexRow + 1;
                    if (i == 0)
                    {
                        finish = listStaffODA.addHead_ODA(nv);
                    }
                    else
                    {
                        finish = listStaffODA.addPos_ODA(nv, i);
                    }
                    indexRow = -1;
                    using_Program = 1;
                }
                else if (typeProgram_fLogin == "LinkedList")
                {
                    int i = indexRow + 1;
                    if (i == 0)
                    {
                        finish = ListStaff_LinkedList.addHead(nv);
                    }
                    else
                    {
                        finish = ListStaff_LinkedList.addPos_LinkedList(nv, i);
                    }
                    indexRow = -1;
                    using_Program = 2;
                }
                if (finish)
                    showStatus("Add Successfully !", frmAlert.enmType.Success);
                else
                    showStatus("Add Unsuccessfully !", frmAlert.enmType.Error);
                display(using_Program);
            }
            catch (Exception)
            {
                return;
            }
           
        }
        private void btnRepairStaff_Click(object sender, EventArgs e)
        {
            resultYesNo = false;
            try
            {
                ShowAlertYesNo("Do you reall repair it!", frmAlert.enmType.Warning, ref resultYesNo);
                if (resultYesNo)
                {
                    Staff_DTO nv = new Staff_DTO();
                    //using_Program dùng để hiển thị lên dgv
                    // bằng 0 thì dùng thư viện, 1 thì mảng một chiều, 2 thì dslk
                    int using_Program = 0;
                    bool finish = false;
                    nv.Id = txtID.Text;
                    nv.PassWord = txtPassword.Text;
                    nv.Name = txtFullName.Text;
                    nv.Sex = rdbFemale.Checked;
                    nv.PhoneNumber = txtPhoneNumbers.Text;
                    nv.Brithday = DateTime.Parse(dtpBirthdays.Text);
                    nv.Address = txtAddress.Text;
                    nv.NumberSecret = int.Parse(txtNumberSecret.Text);

                    //typeProgram_fLogin là lấy biến tĩnh từ bên fLogin trong phần combobox
                    if (typeProgram_fLogin == "Library")
                    {
                        finish = ListStaffLibrary.repairStaff_Library(indexRow, nv);
                        using_Program = 0;
                    }
                    else if (typeProgram_fLogin == "ODA")
                    {
                        finish = listStaffODA.repair_ODA(nv);
                        using_Program = 1;
                    }
                    else if (typeProgram_fLogin == "LinkedList")
                    {
                        finish = ListStaff_LinkedList.repair_LinkedList(nv);
                        using_Program = 2;
                    }
                    if (finish)
                        showStatus("Repair Successfully !", frmAlert.enmType.Success);
                    else
                        showStatus("Pepair Unsuccessfully !", frmAlert.enmType.Error);
                    display(using_Program);
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            //typeProgram_fLogin là lấy biến tĩnh từ bên fLogin trong phần combobox
            resultYesNo = false;
            try
            {
                ShowAlertYesNo("Do you reall delete it!", frmAlert.enmType.Warning, ref resultYesNo);
                if (resultYesNo)
                {
                    int using_Program = 0;
                    bool finish = false;
                    if (typeProgram_fLogin == "Library")
                    {
                        finish = ListStaffLibrary.removeIDStaff(txtID.Text);
                        using_Program = 0;
                    }
                    else if (typeProgram_fLogin == "ODA")
                    {
                        finish = listStaffODA.removeID(txtID.Text);
                        using_Program = 1;
                    }
                    else if (typeProgram_fLogin == "LinkedList")
                    {
                        finish = ListStaff_LinkedList.removeIDStaff(txtID.Text);
                        using_Program = 2;
                    }
                    if (finish)
                        showStatus("Remove Successfully !", frmAlert.enmType.Success);
                    else
                        showStatus("I don't finding it !", frmAlert.enmType.Error);
                    display(using_Program);
                }
            }
            catch (Exception)
            {

                return;
            }
           

        }
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            //typeProgram_fLogin là lấy biến tĩnh từ bên fLogin trong phần combobox
            resultYesNo = true;
            int using_Program = -1;
            bool finish = false;

            if (typeProgram_fLogin == "Library")
            {
                //finish = ListStaffLibrary.WriteFile(fileNameLibrary);
                finish = AccessData_UTIL.writeFileLibrary(frmLogin.FileName.fileNameLibrary);
                using_Program = 0;
            }
            else if (typeProgram_fLogin == "ODA")
            {
                listStaffODA.setN();
                finish = AccessDataODA_UTIL.writeFileODA(frmLogin.FileName.fileNameODA);
                using_Program = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                ListStaff_LinkedList.setListStaff();
                finish = AccessDataLinkedList_UTIL.writeFileNode(frmLogin.FileName.fileNameLinkedList, 0);
                using_Program = 2;
            }
            if (finish)
                showStatus("Save File Successfully !", frmAlert.enmType.Success);
            else
                showStatus("Save File Unsuccessfully !", frmAlert.enmType.Error);
            display(using_Program);
        }

        #endregion

        #region Event_And_Display

        // hàm display dùng để hiển thị data lên dgv
        public void display(int type_Program)
        {
            try
            {
                if (type_Program == 0)
                {
                    List<Staff_DTO> dp = new List<Staff_DTO>();
                    dgvStaff.DataSource = ListStaffLibrary.getListStaff_Library(dp).ToList();
                }
                else if (type_Program == 1)
                    dgvStaff.DataSource = listStaffODA.getLishStaff_ODA().ToList();
                else if (type_Program == 2)
                    dgvStaff.DataSource = ListStaff_LinkedList.getList_LinkedList().ToList();
            }
            catch (Exception)
            {

                return;
            }
           


        }

        private void showStatus(string smg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.showNoti(smg, type);

        }

        private void ShowAlertYesNo(string msg, frmAlert.enmType type, ref bool _YesNo)
        {
            frmAlert frm = new frmAlert();
            frm.showYesNO(msg, type, ref _YesNo);
        }

        //event này khi chúng ta click vào dgv thì hiển thị lên từng dòng 
        private void dgvStaff_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvStaff.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            txtPassword.Text = dgvStaff.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            txtFullName.Text = dgvStaff.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            if (dgvStaff.Rows[e.RowIndex].Cells["Column4"].Value.ToString() == "True")
                rdbFemale.Checked = true;
            else
                rdbMale.Checked = true;
            dtpBirthdays.Value = DateTime.Parse(dgvStaff.Rows[e.RowIndex].Cells["Column5"].Value.ToString());
            txtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
            txtPhoneNumbers.Text = dgvStaff.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            txtNumberSecret.Text = dgvStaff.Rows[e.RowIndex].Cells["Column8"].Value.ToString();
        }

        // event này khi chúng ta click vào 1 ô bất khì thì trả về giá trị là dòng
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        // khi chương trình load lên thì sẽ khởi tạo và đọc file
        private void fAdmin_Staff_Load(object sender, EventArgs e)
        {
            int using_Program = 0;
            bool finish = false;
            if (typeProgram_fLogin == "Library")
            {

                //finish = ListStaffLibrary.ReadFile(fileNameLibrary);

                ListStaffLibrary = new Staff_BUS();
                if (ListStaffLibrary != null)
                    finish = true;
            }
            else if (typeProgram_fLogin == "ODA")
            {

                listStaffODA = new StaffODA_BUS();
                if (listStaffODA.count_ODA() > 0)
                {
                    finish = true;
                }
                using_Program = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                //
                ListStaff_LinkedList = new Staff_LinkedList_BUS();
                if (ListStaff_LinkedList.countLinkedList() > 0)
                {
                    finish = true;
                }
                using_Program = 2;
            }

            if (finish)
                showStatus("Read File Successfully !", frmAlert.enmType.Success);
            else
                showStatus("Read File Unsuccessfully !", frmAlert.enmType.Error);
            display(using_Program);

        }
        #endregion

        private void frmStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int using_Program = -1;
            if (typeProgram_fLogin == "Library")
            {
                using_Program = 0;
            }
            else if (typeProgram_fLogin == "ODA")
            {
                using_Program = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                using_Program = 2;
            }
            switch (using_Program)
            {
                case -1:
                    showStatus("Error", frmAlert.enmType.Error);
                    break;
                default:
                    showStatus("Refresh Succesfully !", frmAlert.enmType.Success);
                    break;
            }
            display(using_Program);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool finish = false;
            
              
            
            switch (typeProgram_fLogin)
            {
                case "Library":
                    List<Staff_DTO> staffLibrary = ListStaffLibrary.getStaffID(txtSearch.Text);
                    if (staffLibrary != null)
                    {
                        dgvStaff.DataSource = staffLibrary.ToList();
                        finish = true;

                    }
                    break;
                case "ODA":
                    List<Staff_DTO> staff = listStaffODA.findStaff(txtSearch.Text);
                    if (staff != null)
                    {
                        dgvStaff.DataSource = staff.ToList();
                        finish = true;
                        
                    }
                    
                break;
                case "LinkedList":
                    List<Staff_DTO> staffLinkedList = ListStaff_LinkedList.getFindStaff(txtSearch.Text);
                    if (staffLinkedList != null)
                    {
                        dgvStaff.DataSource = staffLinkedList.ToList();
                        finish = true;
                        
                    }
                    break;
                default:
                    break;
            }
            if (finish)
            {
                showStatus("Tìm thấy Staff", frmAlert.enmType.Success);
            }
            else
            {
                showStatus("Tìm không thấy Staff", frmAlert.enmType.Error);
            }


        }
    }
}
