using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.UTIL
{
    [Serializable]
    class AccessDataLinkedList_UTIL
    {
        private static volatile AccessDataLinkedList_UTIL instance = null;
        private Node_Staff listStaff;
        private Node_Product_DTO listProduct;

        public static AccessDataLinkedList_UTIL Intial()
        {
            if (instance == null)
            {
                instance = new AccessDataLinkedList_UTIL();
            }
            return instance;
        }
        private AccessDataLinkedList_UTIL()
        {
            listStaff = null;
            listProduct = null;
        }

        public Node_Staff getListStaffNode()
        {
            return listStaff;
        }
        public void setNodeStaff(Node_Staff l)
        {
            listStaff = l;
        }
        public Node_Product_DTO getListProductNode()
        {

            return listProduct;
        }
        public void setNodeProduct(Node_Product_DTO l)
        {
            listProduct = l;
        }
        private int CountStaff()
        {
            int n = 0;
            Node_Staff tmp = listStaff;
            while (tmp != null)
            {
                n++;
                tmp = tmp.Next;
            }
            return n;
        }
        private int CountProduct()
        {
            int n = 0;
            Node_Product_DTO tmp = listProduct;
            while (tmp != null)
            {
                n++;
                tmp = tmp.Next;
            }
            return n;
        }
        public static bool writeFileNode(string tenfile, int typeWrite)
        {
            try
            {
                if (typeWrite == 0)
                {
                    FileStream fs = new FileStream("Staff" + tenfile, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    Node_Staff l_Staff = instance.getListStaffNode();
                    bf.Serialize(fs, instance.CountStaff());
                    while (l_Staff != null)
                    {
                        bf.Serialize(fs, l_Staff.Data);
                        l_Staff = l_Staff.Next;
                    }
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream("Product" + tenfile, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    Node_Product_DTO l_Product = instance.getListProductNode();
                    bf.Serialize(fs, instance.CountProduct());
                    while (l_Product != null)
                    {
                        bf.Serialize(fs, l_Product.Data);
                        l_Product = l_Product.Next;
                    }
                    fs.Close();
                }
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public static bool ReadFileNode(string tenfile, int typeRead)
        {
            bool iFlag = false;
            try
            {
                if (typeRead == 0)
                {
                    FileStream fs = new FileStream("Staff" + tenfile, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    Staff_DTO tmp;
                    int n = (int)bf.Deserialize(fs);
                    Node_Staff head = null;
                    for (int i = 0; i < n; i++)
                    {
                        tmp = new Staff_DTO();
                        tmp = (Staff_DTO)bf.Deserialize(fs);
                        if (head == null)
                        {
                            head = new Node_Staff(tmp);
                        }
                        else
                        {
                            Node_Staff p = new Node_Staff(tmp);
                            Node_Staff tmpHead = head;
                            while (tmpHead.Next != null)
                            {
                                tmpHead = tmpHead.Next;
                            }
                            tmpHead.Next = p;
                        }
                    }

                    instance.listStaff = head;
                    fs.Close();
                }
                else
                {
                    FileStream fs2 = new FileStream("Product" + tenfile, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    Product_DTO tmp2;
                    int m = (int)bf.Deserialize(fs2);
                    Node_Product_DTO headPD = null;
                    for (int i = 0; i < m; i++)
                    {
                        tmp2 = new Product_DTO();
                        tmp2 = (Product_DTO)bf.Deserialize(fs2);
                        if (headPD == null)
                        {
                            headPD = new Node_Product_DTO(tmp2);
                        }
                        else
                        {
                            Node_Product_DTO p = new Node_Product_DTO(tmp2);
                            Node_Product_DTO tmpHead = headPD;
                            while (tmpHead.Next != null)
                            {
                                tmpHead = tmpHead.Next;
                            }
                            tmpHead.Next = p;
                        }
                    }
                    instance.listProduct = headPD;
                    fs2.Close();
                }
                return true;
            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
