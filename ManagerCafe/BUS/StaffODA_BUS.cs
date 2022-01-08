using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagerCafe.UTIL.AccessDataODA_UTIL;

namespace ManagerCafe.BUS
{
    class StaffODA_BUS
    {
        private Staff_DTO[] ListStaff_ODA_BUS;
        //File_UTIL handleFile;
        private int n = 0;
        int all = all_Data;
        //int all;
        public static int allElement = 20;
        public StaffODA_BUS()
        {
            AccessDataODA_UTIL data = AccessDataODA_UTIL.Intial();
            ListStaff_ODA_BUS = data.getListStaffLibrary();
            n = data.get_N_ListStaff();
        }
        public int count_ODA()
        {
            return n;
        }
        public void setN()
        {
            AccessDataODA_UTIL data = AccessDataODA_UTIL.Intial();
            data.setN_ListStaff(n);
        }
        public bool find_ODA(string id)
        {
            for (int i = 0; i < n; i++)
            {
                if (id == ListStaff_ODA_BUS[i].Id)
                    return false;
            }
            return true;
        }
        public List<Staff_DTO> findStaff(string id)
        {
            List<Staff_DTO> staff = new List<Staff_DTO>();
            for (int i = 0; i < n; i++)
            {
                if (id == ListStaff_ODA_BUS[i].Id)
                {
                    staff.Add(ListStaff_ODA_BUS[i]);
                    return staff;
                }
            }
            return null;
        }
        public bool addHead_ODA(Staff_DTO staff)
        {
            bool iFlag = false;
            if (find_ODA(staff.Id))
            {
                if (n - 1 < all)
                {
                    for (int i = n; i > 0; i--)
                        ListStaff_ODA_BUS[i] = ListStaff_ODA_BUS[i - 1];
                    ListStaff_ODA_BUS[0] = staff;
                    n++;
                    iFlag = true;
                }
            }
           
            return iFlag;
        }
        public Staff_DTO checkAccount(string id, string phones, string numberSecret)
        {
            for (int i = 0; i < n; i++)
            {
                if (ListStaff_ODA_BUS[i].Id == id && ListStaff_ODA_BUS[i].PhoneNumber == phones && ListStaff_ODA_BUS[i].NumberSecret == int.Parse(numberSecret))
                {
                    return ListStaff_ODA_BUS[i];
                }
            }
            return null;
        }
        public bool checkAccountLogin(string id, string passWord)
        {
            for (int i = 0; i < n; i++)
            {
                if (ListStaff_ODA_BUS[i].Id == id && ListStaff_ODA_BUS[i].PassWord == passWord)
                {
                    return true;
                }
            }
            return false;
        }
        public bool addLast_ODA(Staff_DTO hs)
        {
            if (find_ODA(hs.Id))
            {
                if (n - 1 < all)
                {
                    ListStaff_ODA_BUS[n++] = hs;
                    return true;
                }
            }
            return false;
        }
        public bool addPos_ODA(Staff_DTO hs, int index)
        {
            bool iFlag = false;
            if (find_ODA(hs.Id))
            {
                if (n - 1 < all)
                {
                    for (int i = n; i > index; i--)
                        ListStaff_ODA_BUS[i] = ListStaff_ODA_BUS[i - 1];
                    ListStaff_ODA_BUS[index] = hs;
                    n++;
                    iFlag = true;
                }
            }
            
            return iFlag;
        }
        public bool removeHead_ODA()
        {
            bool iFlag = false;
            if (n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                    ListStaff_ODA_BUS[i] = ListStaff_ODA_BUS[i + 1];
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removeLast_ODA()
        {
            bool iFlag = false;
            if (n > 0)
            {
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removeID(string id)
        {
     
            if (n == 0)
            {
                return false;
            }
            else
            {
                bool iFlag = false;
                for (int i = 0; i < n; i++)
                {
                    if (ListStaff_ODA_BUS[i].Id == id)
                    {
                        removePos_ODA(i);
                        iFlag = true;
                        break;
                    }
                }
                return iFlag;
            } 
        }
        public bool removePos_ODA(int pos)
        {
            bool iFlag = false;
            if (n > 0)
            {
                for (int i = pos; i < n - 1; i++)
                    ListStaff_ODA_BUS[i] = ListStaff_ODA_BUS[i + 1];
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public List<Staff_DTO> getLishStaff_ODA()
        {
            List<Staff_DTO> getlist = new List<Staff_DTO>();
            for (int i = 0; i < n; i++)
                getlist.Add(ListStaff_ODA_BUS[i]);
            return getlist;
        }
        public bool repair_ODA(Staff_DTO new_Staff)
        {
            bool iFlag = false;
            for (int i = 0; i < n; i++)
            {
                if (ListStaff_ODA_BUS[i].Id == new_Staff.Id)
                {
                    ListStaff_ODA_BUS[i] = new_Staff;
                    iFlag = true;
                    break;
                }
            }
            return iFlag;
        }

    }
}
