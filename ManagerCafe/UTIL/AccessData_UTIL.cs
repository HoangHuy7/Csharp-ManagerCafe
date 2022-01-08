using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ManagerCafe.DTO;

namespace ManagerCafe.UTIL
{
    [Serializable]
    class AccessData_UTIL //singleton
    {
        private static volatile AccessData_UTIL instance = null;
        private List<Staff_DTO> listStaff;
        private List<Product_DTO> listProduct;



        public static AccessData_UTIL Intial()
        {
            if (instance == null)
            {
                instance = new AccessData_UTIL();
            }
            return instance;
        }
        private AccessData_UTIL()
        {
            listStaff = new List<Staff_DTO>();
            listProduct = new List<Product_DTO>();
        }

        public List<Staff_DTO> getListStaffLibrary()
        {
            return listStaff;
        }
        public List<Product_DTO> getListProductLibrary()
        {
            return listProduct;
        }
        public static bool writeFileLibrary(string tenfile)
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

        public static bool ReadFileLibrary(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (AccessData_UTIL)bf.Deserialize(fs);
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
