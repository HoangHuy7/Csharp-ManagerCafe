using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.BUS
{
    class Product_LinkedList_BUS
    {
        Node_Product_DTO head;
        public Product_LinkedList_BUS()
        {
            AccessDataLinkedList_UTIL data = AccessDataLinkedList_UTIL.Intial();
            head = data.getListProductNode();
        }
        private bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
        public void setN_PD()
        {
            AccessDataLinkedList_UTIL data = AccessDataLinkedList_UTIL.Intial();
            data.setNodeProduct(head);
        }
        public Node_Product_DTO getNodeLinkedList()
        {
            return head;
        }
        public int countLinkedList()
        {
            Node_Product_DTO tmp = head;
            int count = 0;
            while (tmp != null)
            {
                count++;
                tmp = tmp.Next;
            }
            return count;
        }



        private bool timLinkedList(string id)
        {
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == id)
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }
        public string[] getItem(ref int getN)
        {
            string[] item = new string[50];
            Node_Product_DTO tmp = head;
            if (tmp != null)
            {

                item[getN++] = tmp.Data.Type;
                while (tmp != null)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        if (item[i] == tmp.Data.Type)
                            break;
                        else if (item[i] == null)
                        {
                            item[i] = tmp.Data.Type;
                            getN++;
                            break;
                        }
                    }
                    tmp = tmp.Next;
                }
            }
            return item;
        }
        public bool addHead(Product_DTO value)
        {
            if (isEmpty())
            {
                head = new Node_Product_DTO(value);
                return true;
            }
            else
            {
                if (!timLinkedList(value.Id) && !timNameProduct(value.Name))
                {
                    Node_Product_DTO p = new Node_Product_DTO(value);
                    p.Next = head;
                    head = p;
                    return true;
                }
                return false;
            }
        }
        private void addLast_getPD_To_CBB(ref Node_Product_DTO l_Head, Product_DTO pd)
        {
            if (l_Head == null)
            {
                l_Head = new Node_Product_DTO(pd);
            }
            else
            {
                Node_Product_DTO p = new Node_Product_DTO(pd);
                Node_Product_DTO tmp = l_Head;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = p;
            }
        }
        public Product_DTO getValueProduct(string name)
        {
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Name == name)
                {
                    return tmp.Data;
                }
                tmp = tmp.Next;
            }
            return null;
        }
        public Node_Product_DTO getPD_To_CBB(string typePD)
        {
            Node_Product_DTO lPD = null;
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Type == typePD)
                {
                    addLast_getPD_To_CBB(ref lPD, tmp.Data);
                }
                tmp = tmp.Next;
            }
            return lPD;
        }
        public List<Product_DTO> getList_LinkedList()
        {
            List<Product_DTO> l = new List<Product_DTO>();
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                l.Add(tmp.Data);
                tmp = tmp.Next;
            }
            return l;
        }
        public bool repair_LinkedList(Product_DTO s)
        {
            bool iFlag = false;
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Id == s.Id)
                {
                    Node_Product_DTO vl = new Node_Product_DTO(s);
                    tmp.Data = vl.Data;
                    iFlag = true;
                    break;
                }
                tmp = tmp.Next;
            }
            return iFlag;
        }
        public bool addLast_LinkedList(Product_DTO value)
        {
            if (isEmpty())
            {
                head = new Node_Product_DTO(value);
                return true;
            }
            else
            {
                if (!timLinkedList(value.Id))
                {
                    Node_Product_DTO p = new Node_Product_DTO(value);
                    Node_Product_DTO tmp = head;
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
        public bool timNameProduct(string name)
        {
            Node_Product_DTO tmp = head;
            while (tmp != null)
            {
                if (tmp.Data.Name == name)
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }
        public bool addPos_LinkedList(Product_DTO value, int index)
        {
            if (timLinkedList(value.Id) == false && timNameProduct(value.Name) == false)
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
                        Node_Product_DTO tmp = head;
                        Node_Product_DTO vl = new Node_Product_DTO(value);
                        while (tmp != null && i != index)
                        {
                            tmp = tmp.Next;
                            i++;
                        }
                        vl.Next = tmp.Next;
                        tmp.Next = vl;
                        return true;
                    }
                    
                }
            }
            return false;
        }
        public void removeHead_LinkedList()
        {
            if (countLinkedList() == 1)
                head = null;
            else
            {
                Node_Product_DTO tmp = head;
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
                bool iFlag = false;
                Node_Product_DTO tmp = head;
                Node_Product_DTO fl = head;
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
                    Node_Product_DTO tmp = head.Next;
                    Node_Product_DTO fl = head;
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
        public List<Product_DTO> getProductID(string id)
        {
            Node_Product_DTO tmp = head;
            List<Product_DTO> l = new List<Product_DTO>();
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
        public void swap(Node_Product_DTO i, Node_Product_DTO j)
        {
            Node_Product_DTO tmp = new Node_Product_DTO(i.Data);
            i.Data = j.Data;
            j.Data = tmp.Data;

        }
        public bool sortMax()
        {
            try
            {
                Node_Product_DTO tmp = head;

                Node_Product_DTO tmp_max ;
                while (tmp != null)
                {
                    tmp_max = tmp;
                    Node_Product_DTO tmp2 = tmp.Next;
                    while (tmp2 != null)
                    {
                        if (tmp2.Data.Price > tmp_max.Data.Price)
                        {
                            tmp_max = tmp2;
                        }
                        tmp2 = tmp2.Next;
                    }
                    swap(tmp, tmp_max);
                    tmp = tmp.Next;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool sortMin()
        {
            try
            {
                Node_Product_DTO tmp = head;

                Node_Product_DTO tmp_max;
                while (tmp != null)
                {
                    tmp_max = tmp;
                    Node_Product_DTO tmp2 = tmp.Next;
                    while (tmp2 != null)
                    {
                        if (tmp2.Data.Price < tmp_max.Data.Price)
                        {
                            tmp_max = tmp2;
                        }
                        tmp2 = tmp2.Next;
                    }
                    swap(tmp, tmp_max);
                    tmp = tmp.Next;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
     
}
