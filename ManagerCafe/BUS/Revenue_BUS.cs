using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerCafe.DTO;
using ManagerCafe.UTIL;

namespace ManagerCafe.BUS
{
    class Revenue_BUS
    {
        private List<Revenue_DTO> listRevenue;
        private File_UTIL handleFile;
        public Revenue_BUS()
        {
            listRevenue = new List<Revenue_DTO>();
        }
        public List<Revenue_DTO> getList()
        {
            return listRevenue;
        }
        public void addRangeMonth(List<Revenue_DTO> l1)
        {
            if (l1.Count() == 0)
                return;
            listRevenue.AddRange(l1);
        }
        public double RevenueOfDay()
        {
            double sum = 0;
            foreach (Revenue_DTO item in listRevenue)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }
        public List<Revenue_DTO> findStaffOrder(string idStaff)
        {
            List<Revenue_DTO> listStaff = new List<Revenue_DTO>();
            foreach (Revenue_DTO item in listRevenue)
            {
                if (idStaff == item.IdStaff)
                {
                    listStaff.Add(item);
                }
            }
            return listStaff;
        }
        public bool addItem(Revenue_DTO rvn)
        {
            try
            {
                listRevenue.Add(rvn);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool WriteFile_Day(string fileName)
        {
            bool iFlag = false;
            try
            {

                handleFile = new File_UTIL();
                iFlag = handleFile.writeFileLibrary_Day_Renueve(fileName, listRevenue);
                return true;
            }
            catch (Exception)
            {

                return iFlag;
            }
        }

        public bool ReadFile(string fileName)
        {

            try
            {
                bool iFlag = false;
                handleFile = new File_UTIL();
                iFlag = handleFile.ReadFileLibrary_Revenue(fileName, ref listRevenue);
                return iFlag;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
