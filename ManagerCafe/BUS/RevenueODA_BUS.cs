using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerCafe.DTO;
using ManagerCafe.UTIL;

namespace ManagerCafe.BUS
{
    class RevenueODA_BUS
    {
        private Revenue_DTO[] listRevenue_ODA;
        private File_UTIL handleFile;
        int all = 0;
        int n;
        public RevenueODA_BUS()
        {
            all = 1000;
            n = 0;
            listRevenue_ODA = new Revenue_DTO[all];
        }
        public int countItem()
        {
            return n;
        }
        public List<Revenue_DTO> findListStaff(string idStaff)
        {
            List<Revenue_DTO> listStaff = new List<Revenue_DTO>();
            for (int i = 0; i < n; i++)
            {
                if (idStaff == listRevenue_ODA[i].IdStaff)
                {
                    listStaff.Add(listRevenue_ODA[i]);
                }
            }
            return listStaff;
        }
        public List<Revenue_DTO> getList()
        {
            List<Revenue_DTO> l = new List<Revenue_DTO>();
            for (int i = 0; i < n; i++)
            {
                l.Add(listRevenue_ODA[i]);
            }
            return l;
        }
        public Revenue_DTO[] getArray()
        {
            return listRevenue_ODA;
        }
        public void addRangeMonth(RevenueODA_BUS listDay)
        {
            int quantityListDay = listDay.countItem();
            if (quantityListDay <=0)
            {
                return;
            }
            else
            {
                Revenue_DTO[] Lday = listDay.getArray();
                for (int i = 0; i < quantityListDay; i++)
                {
                    listRevenue_ODA[n++] = Lday[i];
                }
            }
        }
        public double totalMoney()
        {
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                total += listRevenue_ODA[i].Price * listRevenue_ODA[i].Quantity;
            }
            return total;
        }
        public bool addItem_ODA(Revenue_DTO rvn)
        {
            try
            {
                listRevenue_ODA[n++] = rvn;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool writeFile(string fileName)
        {
            bool iFlag = false;
            handleFile = new File_UTIL();
            handleFile.writeFileODA_Renueve(fileName, listRevenue_ODA, n);

            return iFlag;
        }
        public bool readFile(string fileName)
        {
            bool iFlag = false;
            handleFile = new File_UTIL();
            handleFile.ReadFileODA_Revenue(fileName, ref listRevenue_ODA, ref n);

            return iFlag;
        }
    }
}
