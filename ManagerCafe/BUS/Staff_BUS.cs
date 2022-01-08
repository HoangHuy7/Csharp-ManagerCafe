using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using ManagerCafe.UTIL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCafe.BUS
{
    class Staff_BUS
    {
        private List<Staff_DTO> listStaff;
        public Staff_BUS()
        {
            AccessData_UTIL data = AccessData_UTIL.Intial();
            this.listStaff = data.getListStaffLibrary();
        }
        public bool find(string id)
        {
            foreach (Staff_DTO item in listStaff)
            {
                if (item.Id == id)
                    return true;
            }
            return false;
        }
        public bool add_Staff_Library(Staff_DTO nv)
        {
            bool iFlag = false;
            if (find(nv.Id))
                return false;
            else
            {
                listStaff.Add(nv);
                iFlag = true;
            }
            return iFlag;
        }
        public List<Staff_DTO> getListStaff_Library(List<Staff_DTO> s)
        {
            foreach (Staff_DTO item in listStaff)
            {
                s.Add(item);
            }
            return s;
        }
        public bool repairStaff_Library(int index, Staff_DTO nv)
        {
            try
            {
                this.listStaff[index] = nv;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool deleteStaff_Library(int index)
        {
            bool iFlag = false;
            try
            {
                this.listStaff.RemoveAt(index);
                iFlag = true;
                return iFlag;
            }
            catch (Exception)
            {

                return iFlag;
            }


        }
        public bool removeIDStaff(string id)
        {
            foreach (Staff_DTO item in listStaff)
            {
                if (item.Id == id)
                {
                    listStaff.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public List<Staff_DTO> getStaffID(string id)
        {
            List<Staff_DTO> l = new List<Staff_DTO>();
            foreach (Staff_DTO item in listStaff)
            {
                if (item.Id == id)
                {
                    l.Add(item);
                    return l;
                }
            }
            return null;
        }
        public int countStaff_Library()
        {
            return listStaff.Count();
        }
        public Staff_DTO checkAccount(string id,string phones,string numberSecret)
        {
            foreach (Staff_DTO item in listStaff)
            {
                if (item.Id == id && item.PhoneNumber == phones && item.NumberSecret == int.Parse( numberSecret))
                {
                    return item;
                }
            }
            return null;
        }
        public bool checkAccountLogin(string id, string passWord)
        {
            foreach (Staff_DTO item in listStaff)
            {
                if (item.Id == id && item.PassWord == passWord)
                {
                    return true;
                }
            }
            return false;
        }
        public bool changePassWord(string id,string pw)
        {
            foreach (Staff_DTO item in listStaff)
            {
                if (id == item.Id)
                {
                    item.PassWord = pw;
                    return true;
                }
            }
            return false;
        }
    }
}
