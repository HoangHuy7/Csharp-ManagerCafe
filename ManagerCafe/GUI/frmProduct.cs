
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

    public partial class frmProduct : Form
    {

        #region Initial

        Product_BUS listProduct_Library;
        ProductODA_BUS listProduct_ODA;
        Product_LinkedList_BUS ListProduct_LinkedList;

        private static int indexRow = -1;
        private bool YesNo;
        private bool finded = false;
        
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            int using_Program = 0;
            bool finish = false;
            if (typeProgram_fLogin == "Library")
            {
                listProduct_Library = new Product_BUS();
                ;//so luong phan trong cbb
                if (listProduct_Library.count_Product() > 0)
                {
                    finish = true;
                    int n = 0;
                    string[] tmp = listProduct_Library.addTypeItem(ref n);
                    System.Object[] ItemObject = new System.Object[n];

                    for (int i = 0; i <= tmp.Length; i++)
                    {
                        if (tmp[i] == null)
                            break;
                        ItemObject[i] = tmp[i];

                    }
                    cbbType.Items.AddRange(ItemObject);
                }

                using_Program = 0;
            }
            else if (typeProgram_fLogin == "ODA")
            {
                listProduct_ODA = new ProductODA_BUS();
                if (listProduct_ODA.count_ODA_Product() > 0)
                {
                    finish = true;
                    int n = 0;//so luong phan trong cbb
                    string[] tmp = listProduct_ODA.addTypeItem_ODA(ref n);

                    cbbType.Items.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        cbbType.Items.Add(tmp[i]);
                    }
                }
                //finish = listProduct_ODA.ReadFile(namefile_ODA);
                using_Program = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                //
                ListProduct_LinkedList = new Product_LinkedList_BUS();
                if (ListProduct_LinkedList.countLinkedList() > 0)
                {
                    finish = true;
                    int n = 0;//so luong phan trong cbb
                    string[] tmp = ListProduct_LinkedList.getItem(ref n);

                    cbbType.Items.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        cbbType.Items.Add(tmp[i]);
                    }
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

        #region Show

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
        private void display(int type_Program)
        {
            if (type_Program == 0)
            {
                dgvListProduct.DataSource = listProduct_Library.getListProduct();
            }
            else if (type_Program == 1)
                dgvListProduct.DataSource = listProduct_ODA.getLishStaff_ODA_Product().ToList();
            else if (type_Program == 2)
                dgvListProduct.DataSource = ListProduct_LinkedList.getList_LinkedList().ToList();
        }

        private void dgvListProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvListProduct.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            txtName.Text = dgvListProduct.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            cbbType.Text = dgvListProduct.Rows[e.RowIndex].Cells["column4"].Value.ToString();
            txtPrice.Text = dgvListProduct.Rows[e.RowIndex].Cells["column5"].Value.ToString();
            if (dgvListProduct.Rows[e.RowIndex].Cells["Column3"].Value.ToString() == "True")
                rdbL.Checked = true;
            else
                rdbS.Checked = true;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        #endregion

        #region Function

        private void btnSave_Click(object sender, EventArgs e)
        {
            int using_Program = 0;
            bool finish = false;
            if (typeProgram_fLogin == "Library")
            {
                finish = ManagerCafe.UTIL.AccessData_UTIL.writeFileLibrary(frmLogin.FileName.fileNameLibrary);
                using_Program = 0;
            }
            else if (typeProgram_fLogin == "ODA")
            {
                listProduct_ODA.setN();
                finish = AccessDataODA_UTIL.writeFileODA(frmLogin.FileName.fileNameODA);
                using_Program = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                ListProduct_LinkedList.setN_PD();
                finish = AccessDataLinkedList_UTIL.writeFileNode(frmLogin.FileName.fileNameLinkedList, 1);
                using_Program = 2;
            }
            if (finish)
                showStatus("Save File Successfully !", frmAlert.enmType.Success);
            else
                showStatus("Save File Unsuccessfully !", frmAlert.enmType.Error);
            display(using_Program);
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            try
            {
                YesNo = false;
                int using_Program = 0;
                ShowAlertYesNo("Do you really repair it!", frmAlert.enmType.Warning, ref YesNo);
                if (YesNo)
                {
                    Product_DTO thucUong = new Product_DTO();
                    thucUong.Id = txtID.Text;
                    thucUong.Name = txtName.Text;
                    thucUong.Size = rdbL.Checked;
                    thucUong.Type = cbbType.Text;
                    thucUong.Price = double.Parse(txtPrice.Text);


                    bool finish = false;
                    if (typeProgram_fLogin == "Library")
                    {
                        finish = listProduct_Library.rePair(thucUong, indexRow);
                        using_Program = 0;
                    }
                    else if (typeProgram_fLogin == "ODA")
                    {
                        finish = listProduct_ODA.repair_ODA_Product(thucUong);
                        using_Program = 1;
                    }
                    else if (typeProgram_fLogin == "LinkedList")
                    {
                        finish = ListProduct_LinkedList.repair_LinkedList(thucUong);
                        using_Program = 2;
                    }
                    if (finish)
                        showStatus("Repair Product Successfully !", frmAlert.enmType.Success);
                    else
                        showStatus("Repair Product Unsuccessfully !", frmAlert.enmType.Error);
                }
                display(using_Program);
            }
            catch (Exception)
            {
                showStatus("Pls enter value correctly !", frmAlert.enmType.Warning);
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                YesNo = false;
                int using_Program = -1;
                ShowAlertYesNo("Do you really delete it!", frmAlert.enmType.Warning, ref YesNo);
                if (YesNo)
                {
                    //using_Program dùng để hiển thị lên dgv
                    // bằng 0 thì dùng thư viện, 1 thì mảng một chiều, 2 thì dslk
                    bool finish = false;
                    if (typeProgram_fLogin == "Library")
                    {
                        finish = listProduct_Library.removeIDProduct(txtID.Text);
                        using_Program = 0;
                    }
                    else if (typeProgram_fLogin == "ODA")
                    {
                        finish = listProduct_ODA.removeIDProduct(txtID.Text);
                        using_Program = 1;
                    }
                    else if (typeProgram_fLogin == "LinkedList")
                    {
                        finish = ListProduct_LinkedList.removePos_LinkedList(indexRow);
                        using_Program = 2;
                    }
                    if (finish)
                        showStatus("Delete Product Successfully !", frmAlert.enmType.Success);
                    else
                        showStatus("Delete Product Unsuccessfully !", frmAlert.enmType.Error);
                }



                display(using_Program);
            }
            catch (Exception)
            {
                showStatus("Pls enter value correctly !", frmAlert.enmType.Warning);
            }
           
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                Product_DTO thucUong = new Product_DTO();

                thucUong.Id = txtID.Text;
                thucUong.Name = txtName.Text;
                thucUong.Type = cbbType.Text;
                thucUong.Price = double.Parse(txtPrice.Text);
                thucUong.Size = rdbL.Checked;

                //using_Program dùng để hiển thị lên dgv
                // bằng 0 thì dùng thư viện, 1 thì mảng một chiều, 2 thì dslk
                int using_Program = 0;
                bool finish = false;
                if (typeProgram_fLogin == "Library")
                {
                    finish = listProduct_Library.add_Product(thucUong);
                    using_Program = 0;
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    int pos = indexRow + 1;
                    if (pos == 0)
                    {
                        finish = listProduct_ODA.addHead_ODA_Product(thucUong);
                        indexRow = -1;
                    }
                    else
                    {
                        finish = listProduct_ODA.addPos_ODA_Product(thucUong, pos);
                        indexRow = -1;
                    }

                    using_Program = 1;
                }
                else if (typeProgram_fLogin == "LinkedList")
                {
                    int pos = indexRow + 1;
                    if (pos == 0)
                    {
                        finish = ListProduct_LinkedList.addHead(thucUong);
                        indexRow = -1;
                    }
                    else
                    {
                        finish = ListProduct_LinkedList.addPos_LinkedList(thucUong, pos);
                        indexRow = -1;
                    }
                    using_Program = 2;
                }
                if (finish)
                    showStatus("ADD Product Successfully !", frmAlert.enmType.Success);
                else
                    showStatus("ADD Product Unsuccessfully !", frmAlert.enmType.Error);

                display(using_Program);
            }
            catch (Exception)
            {
                showStatus("Pls enter value correctly !", frmAlert.enmType.Warning);
            }
           
        }
        private void loadCombobox()
        {
            int typeDisplay = -1;
            if (typeProgram_fLogin == "Library")
            {
                int n = 0;//so luong phan trong cbb
                string[] tmp = listProduct_Library.addTypeItem(ref n);
                System.Object[] ItemObject = new System.Object[n];

                for (int i = 0; i <= tmp.Length; i++)
                {
                    if (tmp[i] == null)
                        break;
                    ItemObject[i] = tmp[i];

                }
                cbbType.Items.Clear();
                cbbType.Items.AddRange(ItemObject);
                typeDisplay = 0;
            }
            else if (typeProgram_fLogin == "ODA")
            {
                int n = 0;//so luong phan trong cbb
                string[] tmp = listProduct_ODA.addTypeItem_ODA(ref n);

                cbbType.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    cbbType.Items.Add(tmp[i]);
                }
                typeDisplay = 1;
            }
            else if (typeProgram_fLogin == "LinkedList")
            {
                int n = 0;//so luong phan trong cbb
                string[] tmp = ListProduct_LinkedList.getItem(ref n);

                cbbType.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    cbbType.Items.Add(tmp[i]);
                }
                typeDisplay = 2;
            }
            display(typeDisplay);
            showStatus("Refresh successfully !", frmAlert.enmType.Success);
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCombobox();
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool finish = false;

            switch (typeProgram_fLogin)
            {
                case "Library":
                    List<Product_DTO> product = listProduct_Library.getProductID(txtSearch.Text);
                    if (product != null)
                    {
                        dgvListProduct.DataSource = product.ToList();
                        finish = true;
                    }
                    break;
                case "ODA":
                    List<Product_DTO> productODA = listProduct_ODA.findProductID(txtSearch.Text);
                    if (productODA != null)
                    {
                        dgvListProduct.DataSource = productODA.ToList();
                        finish = true;
                    }

                    break;
                case "LinkedList":
                    List<Product_DTO> productLK = ListProduct_LinkedList.getProductID(txtSearch.Text);
                    if (productLK != null)
                    {
                        dgvListProduct.DataSource = productLK.ToList();
                        finish = true;
                    }
                    break;
                default:
                    break;
            }
            if (finish)
            {
                showStatus("Tìm thấy product", frmAlert.enmType.Success);
            }
            else
            {
                showStatus("Tìm không thấy product", frmAlert.enmType.Error);
            }
        }

        private void btnSortMax_Click(object sender, EventArgs e)
        {
            bool finish = false;
            switch (typeProgram_fLogin)
            {
                case "Library":
                    finish = listProduct_Library.sortPriceMax();
                    display(0);
                    break;
                case "ODA":
                    finish = listProduct_ODA.sortMax();
                    display(1);

                    break;
                case "LinkedList":
                    finish = ListProduct_LinkedList.sortMax();
                    display(2);
                    break;
                default:
                    break;
            }
            if (finish)
            {
                showStatus("Sort Max succesfully", frmAlert.enmType.Success);
            }
            else
            {
                showStatus("Sort Max unsuccesfully", frmAlert.enmType.Error);
            }
           
            
        }

        private void btnSortMin_Click(object sender, EventArgs e)
        {
            bool finish = false;
            switch (typeProgram_fLogin)
            {
                case "Library":
                    finish = listProduct_Library.sortPriceMin();
                    display(0);
                    break;
                case "ODA":
                    finish = listProduct_ODA.sortMin();
                    display(1);
                    break;
                case "LinkedList":
                    finish = ListProduct_LinkedList.sortMin();
                    display(2);
                    break;
                default:
                    break;
            }
            if (finish)
            {
                showStatus("Sort Max succesfully", frmAlert.enmType.Success);
            }
            else
            {
                showStatus("Sort Max unsuccesfully", frmAlert.enmType.Error);
            }

        }
    }
}
