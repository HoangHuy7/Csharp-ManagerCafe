using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagerCafe.BUS
{
    class OrderLinkedList_BUS
    {
        Node_Order_DTO head;
        public OrderLinkedList_BUS()
        {
            head = null;
        }
        private bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
        public int countLinkedList()
        {
            Node_Order_DTO tmp = head;
            int count = 0;
            while (tmp != null)
            {
                count++;
                tmp = tmp.Next;
            }
            return count;
        }
        public double totalMoney()
        {
            Node_Order_DTO tmp = head;
            double total = 0;
            while (tmp != null)
            {
                total += tmp.Data.Price * tmp.Data.Quantity;
                tmp = tmp.Next;
            }
            return total;
        }
        public bool getListOrder(ref List<Order_DTO> l)
        {

            bool iFlag = false;
            if (isEmpty())
            {
                iFlag = false;
            }
            else
            {
                Node_Order_DTO tmp = head;
                while (tmp != null)
                {
                    l.Add(tmp.Data);
                    tmp = tmp.Next;
                }
                iFlag = true;
            }

            return iFlag;
        }
        private Node_Order_DTO timLinkedList(string id)
        {
            Node_Order_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.IdPD == id)
                    return tmp;
                tmp = tmp.Next;
            }
            return null;
        }

        public bool addHead(Order_DTO value)
        {
            try
            {
                if (isEmpty())
                {
                    head = new Node_Order_DTO(value);
                    return true;
                }
                else
                {
                    Node_Order_DTO odr = timLinkedList(value.IdPD);
                    if (odr != null && value.Size == odr.Data.Size)
                    {
                        odr.Data.Quantity += value.Quantity;
                        return true;

                    }
                    else if (odr == null || odr != null && odr.Data.Size != value.Size)
                    {
                        Node_Order_DTO p = new Node_Order_DTO(value);
                        p.Next = head;
                        head = p;
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception)
            {

                return false;
            }


        }
        public void removeHead_LinkedList()
        {
            if (countLinkedList() == 1)
                head = null;
            else
            {
                Node_Order_DTO tmp = head;
                head = head.Next;
                tmp = null;
            }
        }
        public void removeLast_LinkedList()
        {
            if (countLinkedList() == 1)
                head = null;
            else
            {
                Node_Order_DTO tmp = head;
                Node_Order_DTO fl = head;
                bool iFlag = false;
                while (tmp.Next != null)
                {

                    tmp = tmp.Next;
                    if (iFlag)
                    {
                        fl = fl.Next;
                    }
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
                    Node_Order_DTO tmp = head.Next;
                    Node_Order_DTO fl = head;
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
    }
}
