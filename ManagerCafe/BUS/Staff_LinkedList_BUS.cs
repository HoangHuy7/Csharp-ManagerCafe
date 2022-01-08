using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.BUS
{
    class Staff_LinkedList_BUS
    {
        Node_Staff head;
        public Staff_LinkedList_BUS()
        {
            AccessDataLinkedList_UTIL data = AccessDataLinkedList_UTIL.Intial();
            head = data.getListStaffNode();
        }
        private bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }

        public int countLinkedList()
        {
            Node_Staff tmp = head;
            int count = 0;
            while (tmp != null)
            {
                count++;
                tmp = tmp.Next;
            }
            return count;
        }
        public void setListStaff()
        {
            AccessDataLinkedList_UTIL data = AccessDataLinkedList_UTIL.Intial();
            data.setNodeStaff(head);
        }
        private bool timLinkedList(string id)
        {
            Node_Staff tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == id)
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }
        public Staff_DTO checkAccount(string id, string phones, string numberSecret)
        {
            Node_Staff tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == id && tmp.Data.PhoneNumber == phones && tmp.Data.NumberSecret == int.Parse(numberSecret))
                {
                    return tmp.Data;
                }
                tmp = tmp.Next;
            }
            return null;
        }
        public bool checkAccountLogin(string id, string passWord)
        {
            Node_Staff tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == id && tmp.Data.PassWord == passWord )
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }
        public bool addHead(Staff_DTO value)
        {
            if (isEmpty())
            {
                head = new Node_Staff(value);
                return true;
            }
            else
            {
                if (!timLinkedList(value.Id))
                {
                    Node_Staff p = new Node_Staff(value);
                    p.Next = head;
                    head = p;
                    return true;
                }
                return false;
            }
        }
        public List<Staff_DTO> getList_LinkedList()
        {
            List<Staff_DTO> l = new List<Staff_DTO>();
            Node_Staff tmp = head;
            while (tmp != null)
            {
                l.Add(tmp.Data);
                tmp = tmp.Next;
            }
            return l;
        }
        public bool repair_LinkedList(Staff_DTO s)
        {
            bool iFlag = false;
            Node_Staff tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == s.Id)
                {
                    Node_Staff vl = new Node_Staff(s);
                    tmp.Data = vl.Data;
                    iFlag = true;
                    break;
                }
                tmp = tmp.Next;
            }
            return iFlag;
        }
        public bool addLast_LinkedList(Staff_DTO value)
        {
            if (isEmpty())
            {
                head = new Node_Staff(value);
                return true;
            }
            else
            {
                if (!timLinkedList(value.Id))
                {
                    Node_Staff p = new Node_Staff(value);
                    Node_Staff tmp = head;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = p;
                    return true;
                }
                return false;
            }
        }
        public bool addPos_LinkedList(Staff_DTO value, int index)
        {

            if (index == 0)
            {
                if (addHead(value))
                    return true;
                return false;
            }
            else if (countLinkedList() - 1 < index)
            {
                if (addLast_LinkedList(value))
                    return true;
                return false;
            }
            else
            {
                if (!timLinkedList(value.Id))
                {
                    int i = 1;
                    Node_Staff tmp = head;
                    Node_Staff vl = new Node_Staff(value);
                    while (tmp != null && i != index)
                    {
                        tmp = tmp.Next;
                        i++;
                    }
                    vl.Next = tmp.Next;
                    tmp.Next = vl;
                    return true;
                }
                return false;
            }
        }
        public void removeHead_LinkedList()
        {
            int len = countLinkedList();
            if (len == 1)
                head = null;
            else if (len == 0)
            {
                return;
            }
            else
            {
                Node_Staff tmp = head;
                head = head.Next;
                tmp = null;
            }
        }
        public void removeLast_LinkedList()
        {
            int len = countLinkedList();
            if (len == 1)
                head = null;
            else if (len == 0)
            {
                return;
            }
            else
            {
                bool iFlag = false;
                Node_Staff tmp = head;
                Node_Staff fl = head;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                    if (iFlag == true)
                        fl = fl.Next;
                    iFlag = true;
                }
                fl.Next = null;
            }

        }
        public bool removePos_LinkedList(int index)
        {
            bool iFlag = false;
            if (!isEmpty())
            {
                if (index == 0)
                {
                    removeHead_LinkedList();
                    iFlag = true;
                }
                else if (countLinkedList() - 1 <= index)
                {
                    removeLast_LinkedList();
                    iFlag = true;
                }
                else
                {
                    int i = 1;
                    Node_Staff tmp = head.Next;
                    Node_Staff fl = head;
                    while (tmp != null && i != index)
                    {
                        fl = fl.Next;
                        tmp = tmp.Next;
                        i++;
                    }
                    fl.Next = tmp.Next;
                    iFlag = true;
                }
            }
            return iFlag;
        }
        public List<Staff_DTO> getFindStaff(string id)
        {
            Node_Staff tmp = head;
            List<Staff_DTO> l = new List<Staff_DTO>();
            while (tmp != null)
            {
                if (tmp.Data.Id == id)
                {
                    l.Add(tmp.Data);
                    return l;
                }
                tmp = tmp.Next;
            }
            return null;
        }
        public bool removeIDStaff(string id)
        {
            Node_Staff tmp = head;
            bool iFlag = false;
            if (tmp != null)
            {
                for (int i = 0; i < countLinkedList(); i++)
                {
                    if (tmp.Data.Id == id)
                    {
                        removePos_LinkedList(i);
                        iFlag = true;
                        break;
                    }
                    tmp = tmp.Next;
                }
            }
            return iFlag;
            
        }

    }

}
