using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCafe.UTIL;

namespace ManagerCafe.BUS
{
    class Product_BUS
    {
        private List<Product_DTO> ListProduct;
        public Product_BUS()
        {
            AccessData_UTIL data = AccessData_UTIL.Intial();
            ListProduct = data.getListProductLibrary();
        }
        public bool findProduct(string id)
        {
            foreach (Product_DTO item in ListProduct)
            {
                if (item.Id == id)
                    return true;
            }
            return false;
        }
        public List<Product_DTO> getListProduct()
        {
            return ListProduct.ToList();
        }
        public bool rePair(Product_DTO tu, int index)
        {
            try
            {
                this.ListProduct[index] = tu;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public string[] addTypeItem(ref int n)
        {
            string[] item = new string[50];

            if (ListProduct.Count > 0)
            {
                item[0] = ListProduct[0].Type;
                
                n = 1;
                for (int i = 1; i < ListProduct.Count; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (item[j] == ListProduct[i].Type)
                            break;
                        else if (item[j] == null)
                        {
                            item[j] = ListProduct[i].Type;
                            n++;
                            break;
                        }
                    }
                }
            }
            return item;
        }
        public List<Product_DTO> getID(string name)
        {
            List<Product_DTO> tmp = new List<Product_DTO>();
            bool iFlag = false;
            for (int i = 0; i < ListProduct.Count; i++)
            {
                if (name == ListProduct[i].Type)
                {
                    tmp.Add(ListProduct[i]);
                    iFlag = true;
                }

            }
            if (iFlag)
                return tmp;
            else
                return null;

        }
        public List<Product_DTO> getListNameProduct(string name)
        {
            List<Product_DTO> tmp = new List<Product_DTO>();
            for (int i = 0; i < ListProduct.Count; i++)
            {
                if (name == ListProduct[i].Type)
                {
                    tmp.Add(ListProduct[i]);
                }

            }
            return tmp;
        }
        public bool add_Product(Product_DTO tu)
        {
            bool iFlag = false;
            if (!findProduct(tu.Id))
            {
                this.ListProduct.Add(tu);
                iFlag = true;
            }
            return iFlag;
        }
        public int count_Product()
        {
            return ListProduct.Count();
        }
        public bool delete_Product(int index)
        {
            try
            {
                this.ListProduct.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool removeIDProduct(string id)
        {
            foreach (Product_DTO item in ListProduct)
            {
                if (item.Id == id)
                {
                    ListProduct.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public List<Product_DTO> getProductID(string id)
        {
            List<Product_DTO> l = new List<Product_DTO>();
            foreach (Product_DTO item in ListProduct)
            {
                if (item.Id == id)
                {
                    l.Add(item);
                    return l;
                }
            }
            return null;
        }
        public bool sortPriceMax()
        {
            try
            {
                ListProduct = ListProduct.OrderByDescending(x => x.Price).ToList();
                return true;
            }
            catch (Exception)
            {

                return false; ;
            }
          
        }
        public bool sortPriceMin()
        {
            try
            {
                ListProduct = ListProduct.OrderBy(x => x.Price).ToList();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}

