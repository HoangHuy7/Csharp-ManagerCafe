using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCafe.DTO;
using ManagerCafe.BUS;
using static ManagerCafe.GUI.frmLogin;

namespace ManagerCafe.GUI
{
    public partial class frmOrder : Form
    {

        //Library
        private Product_BUS listProduct;
        private Order_BUS listOrder;
        private Revenue_BUS listRevenue = new Revenue_BUS();
        public static string fileNameLibraryRevenue = "RevenueLibrary.dat";


        //ODA
        private OrderODA_BUS listOrder_ODA;
        private ProductODA_BUS listProduct_ODA;
        private RevenueODA_BUS listRevenue_ODA = new RevenueODA_BUS();
        int quantiti_Element_ODA = 50;
        public static string fileNameODARevenue = "RevenueODA.dat";
        private int indexItemDGV = -1;

        //LinkeList
        private OrderLinkedList_BUS listOrder_LinkedList;
        private Product_LinkedList_BUS listProduct_LinkedList;
        private RevenueLinkedList_BUS listRevenue_LinkedList = new RevenueLinkedList_BUS();
        public static string fileNameRevenue_LK = "RevenueLinkedList.dat";

        private string idProduct_Get = "This is id of product library";
        private double price = 0;

        public frmOrder()
        {
            InitializeComponent();
        }
        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (typeProgram_fLogin)
            {
                case "Library":
                    listRevenue.WriteFile_Day(frmLogin.FileName.fileNameRevenue);
                    break;
                case "ODA":
                    listRevenue_ODA.writeFile(frmLogin.FileName.fileNameRevenue);
                    break;
                case "LinkedList":

                    listRevenue_LinkedList.WriteFile(frmLogin.FileName.fileNameRevenue);
                    break;
            }
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                lblIDStaff.Text = powverAccess_fLogin;
                lblDayWorking.Text = dt.Day + " - " + dt.Month + " - " + dt.Year;
                lblTimeStart.Text = dt.Hour + " : " + dt.Minute;
                bool finish = false;
                if (typeProgram_fLogin == "Library")
                {
                    listProduct = new Product_BUS();
                    listOrder = new Order_BUS();
                    string fileNameRead_RVN = dt.Year + "Library/" + dt.Month + "/day" + dt.Day + frmLogin.FileName.fileNameRevenue;
                    finish = listRevenue.ReadFile(fileNameRead_RVN);
                    int n = 0;//so luong phan trong cbb
                    string[] tmp = listProduct.addTypeItem(ref n);
                    System.Object[] ItemObject = new System.Object[n];

                    for (int i = 0; i <= tmp.Length; i++)
                    {
                        if (tmp[i] == null)
                            break;
                        ItemObject[i] = tmp[i];

                    }
                    cbbTypeOrder.Items.AddRange(ItemObject);
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    listProduct_ODA = new ProductODA_BUS();
                    listOrder_ODA = new OrderODA_BUS();

                    string fileNameRead_RVN_ODA = dt.Year + "ODA/" + dt.Month + "/day" + dt.Day + frmLogin.FileName.fileNameRevenue;
                    listRevenue_ODA.readFile(fileNameRead_RVN_ODA);
                    int n = 0;
                    cbbTypeOrder.Items.Clear();
                    string[] tmp = listProduct_ODA.addTypeItem_ODA(ref n);

                    for (int i = 0; i < n; i++)
                    {
                        cbbTypeOrder.Items.Add(tmp[i]);
                    }
                }
                else
                {
                    listOrder_LinkedList = new OrderLinkedList_BUS();
                    listProduct_LinkedList = new Product_LinkedList_BUS();

                    string fileNameRead_RVN_LK = dt.Year + "LinkedList/" + dt.Month + "/day" + dt.Day + frmLogin.FileName.fileNameRevenue;
                    listRevenue_LinkedList.ReadFile(fileNameRead_RVN_LK);
                    int n = 0;
                    string[] tmp = listProduct_LinkedList.getItem(ref n);

                    for (int i = 0; i < n; i++)
                    {
                        cbbTypeOrder.Items.Add(tmp[i]);
                    }

                }
            }
            catch (Exception)
            {
                return;
            }
           

        }

        private void cbbTypeOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeProgram_fLogin == "Library")
                {
                    List<Product_DTO> l = listProduct.getListNameProduct(cbbTypeOrder.SelectedItem.ToString());
                    cbbProduct_Order.Items.Clear();
                    for (int i = 0; i < l.Count; i++)
                    {
                        cbbProduct_Order.Items.Add(l[i].Name);
                    }
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    int quantity_Name_ODA = 0;
                    Product_DTO[] l = new Product_DTO[quantiti_Element_ODA];
                    l = listProduct_ODA.getListNameProduct(cbbTypeOrder.SelectedItem.ToString(), ref quantity_Name_ODA);
                    cbbProduct_Order.Items.Clear();
                    for (int i = 0; i < quantity_Name_ODA; i++)
                    {
                        cbbProduct_Order.Items.Add(l[i].Name);
                    }
                }
                else if (typeProgram_fLogin == "LinkedList")
                {
                    Node_Product_DTO listGetInCBB = listProduct_LinkedList.getPD_To_CBB(cbbTypeOrder.SelectedItem.ToString());
                    cbbProduct_Order.Items.Clear();
                    while (listGetInCBB != null)
                    {
                        cbbProduct_Order.Items.Add(listGetInCBB.Data.Name);
                        listGetInCBB = listGetInCBB.Next;
                    }


                }
            }
            catch (Exception)
            {

                return;
            }
          


        }
        private void display()
        {

            if (typeProgram_fLogin == "Library")
            {
                List<Order_DTO> l = new List<Order_DTO>();
                bool finish = listOrder.getListOrder(ref l);
                if (finish)
                    dgvListProduct_Order.DataSource = l.ToList();
                lblTotalMoney_Order.Text = listOrder.totalMoney().ToString();

            }
            else if (typeProgram_fLogin == "ODA")
            {
                List<Order_DTO> l_1 = new List<Order_DTO>();
                bool finish = listOrder_ODA.getListOrder(ref l_1);
                if (finish)
                {
                    dgvListProduct_Order.DataSource = l_1.ToList();

                }
                lblTotalMoney_Order.Text = listOrder_ODA.totalMoney_ODA().ToString();

            }
            else
            {
                List<Order_DTO> l_2 = new List<Order_DTO>();
                bool finish = listOrder_LinkedList.getListOrder(ref l_2);
                if (finish || l_2.Count() == 0)
                {
                    dgvListProduct_Order.DataSource = l_2.ToList();

                }
                lblTotalMoney_Order.Text = listOrder_LinkedList.totalMoney().ToString();
            }

        }
        private void btnADDOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order_DTO odr = new Order_DTO();
                odr.IdPD = idProduct_Get;
                odr.NamePD = cbbProduct_Order.Text;

                odr.Quantity = int.Parse(txtQuantity_Order.Text);
                odr.Size = rdbSizeL.Checked;
                if (rdbSizeL.Checked)
                    odr.Price = price + 10000;
                else
                    odr.Price = price;
                odr.Type = cbbTypeOrder.Text;
                //
                if (typeProgram_fLogin == "Library")
                {
                    listOrder.addListOrder(odr);
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    listOrder_ODA.addItem(odr);
                }
                else
                {
                    listOrder_LinkedList.addHead(odr);
                }
                display();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void cbbProduct_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeProgram_fLogin == "Library")
                {
                    List<Product_DTO> l = listProduct.getID(cbbTypeOrder.SelectedItem.ToString());
                    int n = cbbProduct_Order.SelectedIndex;
                    idProduct_Get = l[n].Id;
                    price = l[n].Price;
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    Product_DTO[] l = new Product_DTO[quantiti_Element_ODA];
                    l = listProduct_ODA.getID(cbbTypeOrder.SelectedItem.ToString());
                    idProduct_Get = l[cbbProduct_Order.SelectedIndex].Id;
                    price = l[cbbProduct_Order.SelectedIndex].Price;
                }
                else
                {
                    Product_DTO l = listProduct_LinkedList.getValueProduct(cbbProduct_Order.SelectedItem.ToString());
                    idProduct_Get = l.Id;
                    price = l.Price;
                }
            }
            catch (Exception)
            {

                return;
            }
          



        }

        private void txtMoneyReceived_Order_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double ExcessCash = 0;
                ExcessCash = double.Parse(txtMoneyReceived_Order.Text) - double.Parse(lblTotalMoney_Order.Text);
                lblTotalMoney_ExcessCash_Order.Text = ExcessCash.ToString();
            }
            catch (Exception err)
            {
                return;
            }

        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeProgram_fLogin == "Library")
                {
                    listOrder.removeItem(indexItemDGV);
                }
                else if (typeProgram_fLogin == "ODA")
                {
                    listOrder_ODA.removePos_Item(indexItemDGV);
                }
                else
                {
                    listOrder_LinkedList.removePos_LinkedList(indexItemDGV);
                }

                display();
            }
            catch (Exception)
            {

                return;
            }

        }

        private void dgvListProduct_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexItemDGV = e.RowIndex;
        }
        private void btnPayOrder_Click(object sender, EventArgs e)
        {

            Revenue_DTO itemRVN;

            int n = 0;
            if (dgvListProduct_Order.Rows[0].Cells[0].Value == null)
                n = dgvListProduct_Order.Rows.Count - 1;
            else
                n = dgvListProduct_Order.Rows.Count;


            for (int i = 0; i < n; i++)
            {
                itemRVN = new Revenue_DTO();
                itemRVN.IdProduct = dgvListProduct_Order.Rows[i].Cells[0].Value.ToString();
                itemRVN.NameProduct = dgvListProduct_Order.Rows[i].Cells[1].Value.ToString();
                itemRVN.Size = bool.Parse(dgvListProduct_Order.Rows[i].Cells[2].Value.ToString());
                itemRVN.Quantity = Int32.Parse(dgvListProduct_Order.Rows[i].Cells[3].Value.ToString());
                itemRVN.Price = double.Parse(dgvListProduct_Order.Rows[i].Cells[4].Value.ToString());
                itemRVN.Type = dgvListProduct_Order.Rows[i].Cells[5].Value.ToString();
                itemRVN.IdStaff = powverAccess_fLogin;

                if (typeProgram_fLogin == "Library")
                    listRevenue.addItem(itemRVN);
                else if (typeProgram_fLogin == "ODA")
                    listRevenue_ODA.addItem_ODA(itemRVN);
                else
                {
                    listRevenue_LinkedList.addHead(itemRVN);
                }

            }
            switch (typeProgram_fLogin)
            {

                case "Library":
                    listOrder = new Order_BUS();
                    break;
                case "ODA":
                    listOrder_ODA = new OrderODA_BUS();
                    break;
                case "LinkedList":
                    listOrder_LinkedList = new OrderLinkedList_BUS();
                    break;

            }
            display();
        }

        private void btnDeletedgv_Click(object sender, EventArgs e)
        {

        }


    }
}
