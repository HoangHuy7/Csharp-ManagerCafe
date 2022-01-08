using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static ManagerCafe.UTIL.AccessDataODA_UTIL;

namespace ManagerCafe.BUS
{
    class ProductODA_BUS
    {
        private Product_DTO[] ListProduct_ODA_BUS;

        int n = 0;
        int all = all_Data;
        public static int allElement_Product = 50;
        public ProductODA_BUS()
        {
            AccessDataODA_UTIL data = AccessDataODA_UTIL.Intial();
            ListProduct_ODA_BUS = data.getListProductLibrary();
            n = data.get_N_ListProduct();
        }
        public int count_ODA_Product()
        {
            return n;
        }
        public void setN()
        {
            AccessDataODA_UTIL data = AccessDataODA_UTIL.Intial();
            data.setN_Product(n);
        }
        public string[] addTypeItem_ODA(ref int quantity_Elenment)
        {
            string[] item = new string[50];
            if (ListProduct_ODA_BUS != null)
            {
                item[0] = ListProduct_ODA_BUS[0].Type;
                quantity_Elenment = 1;
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        if (item[j] == ListProduct_ODA_BUS[i].Type)
                            break;
                        else if (item[j] == null)
                        {
                            item[j] = ListProduct_ODA_BUS[i].Type;
                            quantity_Elenment++;
                            break;
                        }
                    }
                }
            }
            return item;
        }
        public List<Product_DTO> findProductID(string id)
        {
            List<Product_DTO> listProduct = new List<Product_DTO>();
            for (int i = 0; i < n; i++)
            {
                if (id == ListProduct_ODA_BUS[i].Id)
                {
                    listProduct.Add(ListProduct_ODA_BUS[i]);
                    return listProduct;
                }
            }
            return null;
        }
        public Product_DTO[] getID(string type)
        {
            Product_DTO[] tmp = new Product_DTO[all];
            int elementGet = 0;
            for (int i = 0; i < n; i++)
            {
                if (ListProduct_ODA_BUS[i].Type == type)
                {
                    tmp[elementGet++] = ListProduct_ODA_BUS[i];
                }
            }
            return tmp;
        }
        public Product_DTO[] getListNameProduct(string name, ref int qtt_Name_ODA)
        {
            Product_DTO[] tmp = new Product_DTO[all];
            qtt_Name_ODA = 0;
            for (int i = 0; i < n; i++)
            {
                if (name == ListProduct_ODA_BUS[i].Type)
                    tmp[qtt_Name_ODA++] = ListProduct_ODA_BUS[i];
            }
            return tmp;
        }
        public bool find_ODA_Product(string id)
        {
            for (int i = 0; i < n; i++)
            {
                if (id == ListProduct_ODA_BUS[i].Id)
                    return false;
            }
            return true;
        }

        public bool addHead_ODA_Product(Product_DTO pd)
        {
            bool iFlag = false;
            if (find_ODA_Product(pd.Id) && findNameProduct(pd.Name) && n - 1 < all)
            {
                for (int i = n; i > 0; i--)
                    ListProduct_ODA_BUS[i] = ListProduct_ODA_BUS[i - 1];
                ListProduct_ODA_BUS[0] = pd;
                n++;
                iFlag = true;
            }
            return iFlag;
        }
        public bool findNameProduct(string name)
        {
            for (int i = 0; i < n; i++)
            {
                if (ListProduct_ODA_BUS[i].Name == name)
                {
                    return false;
                }
            }
            return true ;
        }
        public bool addLast_ODA_Product(Product_DTO hs)
        {
            if (find_ODA_Product(hs.Id))
            {
                if (n - 1 < all)
                {
                    ListProduct_ODA_BUS[n++] = hs;
                    return true;
                }
            }
            return false;
        }
        public bool addPos_ODA_Product(Product_DTO pd, int index)
        {
            bool iFlag = false;
            if (find_ODA_Product(pd.Id) && findNameProduct(pd.Name) && n - 1 < all)
            {
                for (int i = n; i > index; i--)
                    ListProduct_ODA_BUS[i] = ListProduct_ODA_BUS[i - 1];
                ListProduct_ODA_BUS[index] = pd;
                n++;
                iFlag = true;
            }

            return iFlag;
        }
        public bool removeHead_ODA_Product()
        {
            bool iFlag = false;
            if (n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                    ListProduct_ODA_BUS[i] = ListProduct_ODA_BUS[i + 1];
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removeLast_ODA_Product()
        {
            bool iFlag = false;
            if (n > 0)
            {
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removePos_ODA_Product(int pos)
        {
            bool iFlag = false;
            if (n > 0)
            {
                for (int i = pos; i < n - 1; i++)
                    ListProduct_ODA_BUS[i] = ListProduct_ODA_BUS[i + 1];
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removeIDProduct(string id)
        {
            if (n  == 0)
            {
                return false;
            }
            else
            {
                bool iFlag = false;
                for (int i = 0; i < n; i++)
                {
                    if (ListProduct_ODA_BUS[i].Id == id)
                    {
                        removePos_ODA_Product(i);
                        iFlag = true;
                        break;
                    }
                }
                return iFlag;
            }
            
        }
        public List<Product_DTO> getLishStaff_ODA_Product()
        {
            List<Product_DTO> getlist = new List<Product_DTO>();
            for (int i = 0; i < n; i++)
                getlist.Add(ListProduct_ODA_BUS[i]);
            return getlist;
        }
        public bool repair_ODA_Product(Product_DTO new_Staff)
        {
            bool iFlag = false;
            for (int i = 0; i < n; i++)
            {
                if (ListProduct_ODA_BUS[i].Id == new_Staff.Id)
                {
                    ListProduct_ODA_BUS[i] = new_Staff;
                    iFlag = true;
                    break;
                }
            }
            return iFlag;
        }
        public void swapODA(int i,int j)
        {
            var tmp = ListProduct_ODA_BUS[i];
            ListProduct_ODA_BUS[i] = ListProduct_ODA_BUS[j];
            ListProduct_ODA_BUS[j] = tmp;
        }
        public bool sortMin()
        {
            try
            {
                int i, j, min_idx;

                for (i = 0; i < n - 1; i++)
                {
                    min_idx = i;
                    for (j = i; j < n; j++)
                        if (ListProduct_ODA_BUS[j].Price < ListProduct_ODA_BUS[min_idx].Price)
                            min_idx = j;
                    swapODA(min_idx, i);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool sortMax()
        {
            try
            {
                int i, j, max_idx;

                for (i = 0; i < n - 1; i++)
                {
                    max_idx = i;
                    for (j = i; j < n; j++)
                        if (ListProduct_ODA_BUS[j].Price > ListProduct_ODA_BUS[max_idx].Price)
                            max_idx = j;
                    swapODA(max_idx, i);
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
