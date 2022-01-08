using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerCafe.DTO;
using ManagerCafe.UTIL;

namespace ManagerCafe.BUS
{
    class RevenueLinkedList_BUS
    {
        Node_Revenue_DTO head;
        File_UTIL handleFile;
        public RevenueLinkedList_BUS()
        {
            head = null;

        }
        private bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
        public List<Revenue_DTO> findStaffRevenue(string idStaff)
        {
            Node_Revenue_DTO tmp = head;
            List<Revenue_DTO> listStaff = new List<Revenue_DTO>();
            while (tmp != null)
            {
                if (tmp.Data.IdStaff == idStaff)
                {
                    listStaff.Add(tmp.Data);
                }
                tmp = tmp.Next;
            }
            return listStaff;
        }
        public List<Revenue_DTO> getListRevenue()
        {
            List<Revenue_DTO> l = new List<Revenue_DTO>();
            Node_Revenue_DTO tmp = head;
            while (tmp != null)
            {
                l.Add(tmp.Data);
                tmp = tmp.Next;
            }
            return l;
        }
        public Node_Revenue_DTO getNode()
        {
            return head;
        }
        public void addRangeMonth(Node_Revenue_DTO tmp_Node)
        {
            if (tmp_Node == null)
            {
                return;
            }
            else
            {
                if (head == null)
                {
                    head = tmp_Node;
                }
                else
                {
                    Node_Revenue_DTO tmp = head;
                    while (tmp.Next != null)
                        tmp = tmp.Next;
                    tmp.Next = tmp_Node;
                }
            }
        }
        public int countLinkedList()
        {
            Node_Revenue_DTO tmp = head;
            int count = 0;
            while (tmp != null)
            {
                count++;
                tmp = tmp.Next;
            }
            return count;
        }
        public bool WriteFile(string filename)
        {
            bool iFlag = false;
            handleFile = new File_UTIL();
            iFlag = handleFile.writeFileLinhkedList_Renueve(filename, head, countLinkedList());
            return iFlag;
        }
        public bool ReadFile(string filename)
        {
            bool iFlag = false;
            handleFile = new File_UTIL();
            handleFile.readFileLinhkedList_Renueve(filename, ref head);
            return iFlag;
        }
        private Revenue_DTO timLinkedList(string id)
        {
            Node_Revenue_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.IdProduct == id)
                    return tmp.Data;
                tmp = tmp.Next;
            }
            return null;
        }
        public double totalMoney()
        {
            double total = 0;
            Node_Revenue_DTO tmp = head;
            while (tmp != null)
            {
                total += tmp.Data.Price * tmp.Data.Quantity;
                tmp = tmp.Next;
            }
            return total;
        }
        public bool addHead(Revenue_DTO value)
        {
            if (isEmpty())
            {
                head = new Node_Revenue_DTO(value);
                return true;
            }
            else
            {
                Revenue_DTO rvn = timLinkedList(value.IdProduct);
                if (rvn == null || (rvn != null && rvn.Size != value.Size))
                {
                    Node_Revenue_DTO p = new Node_Revenue_DTO(value);
                    p.Next = head;
                    head = p;
                    return true;
                }
                return false;
            }
        }

    }
}
