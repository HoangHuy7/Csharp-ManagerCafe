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
    class AccessDataODA_UTIL
    {
        private static volatile AccessDataODA_UTIL instance = null;
        private Staff_DTO[] listStaff;
        private int n_listStaff;
        private Product_DTO[] listProduct;
        private int n_listProduct;
        public static int all_Data = 100;


        public static AccessDataODA_UTIL Intial()
        {
            if (instance == null)
            {
                instance = new AccessDataODA_UTIL();
            }
            return instance;
        }
        private AccessDataODA_UTIL()
        {
            listStaff = new Staff_DTO[all_Data];
            n_listStaff = new int();
            listProduct = new Product_DTO[all_Data];
            n_listProduct = new int();
        }

        public Staff_DTO[] getListStaffLibrary()
        {
            return listStaff;
        }
        public void setN_ListStaff(int n)
        {
            n_listStaff = n;
        }
        public int get_N_ListStaff()
        {
            return n_listStaff;
        }

        public Product_DTO[] getListProductLibrary()
        {
            return listProduct;
        }
        public void setN_Product(int n)
        {
            n_listProduct = n;
        }
        public int get_N_ListProduct()
        {
            return n_listProduct;
        }
        public static bool writeFileODA(string tenfile)
        {
            try
            {

                FileStream fs = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, instance);
                fs.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public static bool ReadFileODA(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (AccessDataODA_UTIL)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

    }
}

