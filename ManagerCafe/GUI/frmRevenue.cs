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
using static ManagerCafe.GUI.frmLogin;

namespace ManagerCafe.GUI
{
    public partial class frmRevenue : Form
    {
        Revenue_BUS listRevenue;
        RevenueODA_BUS listRevenue_ODA;
        RevenueLinkedList_BUS listRevenue_LinkedList;
        public frmRevenue()
        {
            InitializeComponent();
        }

        private void cbbFinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbChoiceFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeDisplay = -1;
            if (cbbChoiceFind.Text == "Month")
            {
                lblNameTotal.Text = "Total Month:";
                typeDisplay = 1;
            }
            else
            {
                lblNameTotal.Text = "Total Day:";
                typeDisplay = 0;
            }
            display(typeDisplay);
        }
        private void display(int typeDisplay)
        {
            // 0 = day
            if (typeDisplay == 0)
            {
                if (typeProgram_fLogin == "Library")
                    dgvRevenueDay_Month.DataSource = listRevenue.getList().ToList();
                else if (typeProgram_fLogin == "ODA")
                {
                    dgvRevenueDay_Month.DataSource = listRevenue_ODA.getList();
                }
                else
                {
                    dgvRevenueDay_Month.DataSource = listRevenue_LinkedList.getListRevenue().ToList();
                }
            }


        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {
            switch (typeProgram_fLogin)
            {
                case "Library":
                    listRevenue = new Revenue_BUS();
                    listRevenue.ReadFile(dtpTabMonthChoice.Value.Year + "Library/" + dtpTabMonthChoice.Value.Month
                        + "/day" + dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue);
                    lblTotalMoney.Text = listRevenue.RevenueOfDay() + " vnd";
                    break;
                case "ODA":
                    listRevenue_ODA = new RevenueODA_BUS();
                    DateTime dp = DateTime.Now;
                    listRevenue_ODA.readFile(dtpTabMonthChoice.Value.Year + "ODA/" + dtpTabMonthChoice.Value.Month + "/day" +
                        dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue);
                    lblTotalMoney.Text = listRevenue_ODA.totalMoney() + "vnd";
                    break;
                case "LinkedList":
                    listRevenue_LinkedList = new RevenueLinkedList_BUS();
                    listRevenue_LinkedList.ReadFile(dtpTabMonthChoice.Value.Year + "LinkedList/" + dtpTabMonthChoice.Value.Month + "/day" +
                        dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue);
                    lblTotalMoney.Text = listRevenue_LinkedList.totalMoney() + "vnd";
                    break;
                default:
                    break;
            }

            display(0);
        }
        private Revenue_BUS readDay_Library(string fileName)
        {
            Revenue_BUS tmp = new Revenue_BUS();
            tmp.ReadFile(fileName);
            return tmp;
        }
        private Revenue_BUS readMonth_Library(string Month)
        {
            Revenue_BUS tmp_RevenueMonth = new Revenue_BUS();
            for (int i = 0; i < 31; i++)
            {
                int day = i + 1;
                string fileNameMonth = dtpTabMonthChoice.Value.Year + "Library/" + Month
                + "/day" + day + frmLogin.FileName.fileNameRevenue;
                Revenue_BUS tmp = readDay_Library(fileNameMonth);
                tmp_RevenueMonth.addRangeMonth(tmp.getList());
            }
            return tmp_RevenueMonth;
        }
        private RevenueODA_BUS readDay_ODA(string fileName)
        {
            RevenueODA_BUS tmp = new RevenueODA_BUS();
            tmp.readFile(fileName);
            return tmp;
        }
        private RevenueODA_BUS readMonth_ODA(string Month)
        {
            RevenueODA_BUS tmp_RevenueMonth = new RevenueODA_BUS();
            for (int i = 0; i < 31; i++)
            {
                int day = i + 1;
                string fileNameMonth = dtpTabMonthChoice.Value.Year + "ODA/" + Month
                + "/day" + day + frmLogin.FileName.fileNameRevenue;
                RevenueODA_BUS tmp = readDay_ODA(fileNameMonth);
                tmp_RevenueMonth.addRangeMonth(tmp);
            }
            return tmp_RevenueMonth;
        }
        private RevenueLinkedList_BUS readDay_LinkedList(string fileName)
        {
            RevenueLinkedList_BUS tmp = new RevenueLinkedList_BUS();
            tmp.ReadFile(fileName);
            return tmp;
        }
        private RevenueLinkedList_BUS readMonth_LinkedList(string month)
        {
            RevenueLinkedList_BUS tmp_RevenueMonth = new RevenueLinkedList_BUS();
            for (int i = 0; i < 31; i++)
            {
                int day = i + 1;
                string fileNameMonth = dtpTabMonthChoice.Value.Year + "LinkedList/" + month
                + "/day" + day + frmLogin.FileName.fileNameRevenue;
                RevenueLinkedList_BUS tmp = readDay_LinkedList(fileNameMonth);
                tmp_RevenueMonth.addRangeMonth(tmp.getNode());
            }
            return tmp_RevenueMonth;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int typeDL = -1;
            
            switch (typeProgram_fLogin)
            {
                case "Library":
                    if (cbbChoiceFind.Text == "Oneday")
                    {
                        listRevenue = new Revenue_BUS();
                        string fileName = dtpTabMonthChoice.Value.Year + "Library/" + dtpTabMonthChoice.Value.Month
                        + "/day" + dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue;
                        listRevenue = readDay_Library(fileName);
                        lblTotalMoney.Text = listRevenue.RevenueOfDay() + " vnd";
                        typeDL = 0;
                    }
                    else if (cbbChoiceFind.Text == "Month")
                    {
                        listRevenue = new Revenue_BUS();
                        Revenue_BUS tmp = readMonth_Library(dtpTabMonthChoice.Value.Month.ToString());
                        listRevenue = tmp;
                        typeDL = 0;

                    }
                    else
                    {
                        DateTime dt = DateTime.Now;
                        listRevenue = new Revenue_BUS();
                        if (dtpTabMonthChoice.Value.Year > dt.Year)
                            break;
                        for (int i = 0; i < 12; i++)
                        {
                            
                            int month = i + 1;
                            Revenue_BUS tmp = new Revenue_BUS();
                            tmp = readMonth_Library(month+"");
                            listRevenue.addRangeMonth(tmp.getList());
                        }
                        typeDL = 0;
                    }
                    break;
                case "ODA":
                    if (cbbChoiceFind.Text == "Oneday")
                    {
                        listRevenue_ODA = new RevenueODA_BUS();

                        string fileNameDay = dtpTabMonthChoice.Value.Year + "ODA/" + dtpTabMonthChoice.Value.Month + "/day" +
                            dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue;

                        listRevenue_ODA = readDay_ODA(fileNameDay);

                        lblTotalMoney.Text = listRevenue_ODA.totalMoney() + "vnd";

                        typeDL = 0;
                    }
                    else if (cbbChoiceFind.Text == "Month")
                    {
                        listRevenue_ODA = new RevenueODA_BUS();
                        listRevenue_ODA = readMonth_ODA(dtpTabMonthChoice.Value.Month.ToString());
                        lblTotalMoney.Text = listRevenue_ODA.totalMoney() + "vnd";
                       
                        typeDL = 0;

                    }
                    else
                    {
                        DateTime dt = DateTime.Now;
                        listRevenue_ODA = new RevenueODA_BUS();
                        if (dtpTabMonthChoice.Value.Year > dt.Year)
                            break;
                        for (int i = 0; i < 12; i++)
                        {
                            int month = i + 1;
                            RevenueODA_BUS tmp = new RevenueODA_BUS();
                            tmp = readMonth_ODA(month + "");
                            listRevenue_ODA.addRangeMonth(tmp);
                        }
                        lblTotalMoney.Text = listRevenue_ODA.totalMoney() + "vnd";
                        typeDL = 0;
                    }
                    
                    break;
                case "LinkedList":
                    if (cbbChoiceFind.Text == "Oneday")
                    {
                        listRevenue_LinkedList = new RevenueLinkedList_BUS();
                        listRevenue_LinkedList.ReadFile(dtpTabMonthChoice.Value.Year + "LinkedList/" + dtpTabMonthChoice.Value.Month + "/day" +
                            dtpTabMonthChoice.Value.Day + frmLogin.FileName.fileNameRevenue);
                        lblTotalMoney.Text = listRevenue_LinkedList.totalMoney() + "vnd";
                        typeDL = 0;
                    }
                    else if (cbbChoiceFind.Text == "Month")
                    {
                        listRevenue_LinkedList = new RevenueLinkedList_BUS();
                        listRevenue_LinkedList = readMonth_LinkedList(dtpTabMonthChoice.Value.Month.ToString());
                        typeDL = 0;

                    }
                    else
                    {
                        DateTime dt = DateTime.Now;
                        listRevenue_LinkedList = new RevenueLinkedList_BUS();
                        if (dtpTabMonthChoice.Value.Year > dt.Year)
                            break;
                        for (int i = 0; i < 12; i++)
                        {
                            int month = i + 1;
                            RevenueLinkedList_BUS tmp = new RevenueLinkedList_BUS();
                            tmp = readMonth_LinkedList(month + "");
                            listRevenue_LinkedList.addRangeMonth(tmp.getNode());
                        }
                        
                        typeDL = 0;
                    }
                  
                    break;
                default:
                    break;
            }
            display(typeDL);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (typeProgram_fLogin)
            {
                case "Library":
                    List<Revenue_DTO> listStaff = listRevenue.findStaffOrder(txtSearch.Text);
                    dgvRevenueDay_Month.DataSource = listStaff.ToList();
                    break;
                case "ODA":
                    List<Revenue_DTO> listStaffODA = listRevenue_ODA.findListStaff(txtSearch.Text);
                    dgvRevenueDay_Month.DataSource = listStaffODA.ToList();
                    break;
                case "LinkedList":
                    List<Revenue_DTO> listStaffLinkedList = listRevenue_LinkedList.findStaffRevenue(txtSearch.Text);
                    dgvRevenueDay_Month.DataSource = listStaffLinkedList.ToList();
                    break;
                default:
                    break;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            display(0);
        }
    }
}
