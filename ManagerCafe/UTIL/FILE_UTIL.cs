using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static ManagerCafe.BUS.StaffODA_BUS;

namespace ManagerCafe.UTIL
{
    class File_UTIL
    {

        #region Revenue

        #region Library
        public bool writeFileLibrary_Day_Renueve(string tenfile, List<Revenue_DTO> listRevenue)
        {

            try
            {

                DateTime dp = DateTime.Now;
                Directory.CreateDirectory(@dp.Year + "Library/" + dp.Month);
                string fileNameWrite = dp.Year + "Library/" + dp.Month + "/day" + dp.Day + tenfile;
                FileStream fs = new FileStream(fileNameWrite, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listRevenue);
                fs.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
        public bool ReadFileLibrary_Revenue(string tenfile, ref List<Revenue_DTO> listRevenue)
        {
            bool iFlag = false;
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);// nônnônnôn
                BinaryFormatter bf = new BinaryFormatter();
                listRevenue = (List<Revenue_DTO>)bf.Deserialize(fs);
                fs.Close();
                return true;


            }
            catch (Exception error)
            {
                return iFlag;
            }
        }
        #endregion

        #region ODA
        public bool writeFileODA_Renueve(string tenfile, Revenue_DTO[] listRevenue_ODA, int n)
        {

            try
            {

                DateTime dp = DateTime.Now;
                Directory.CreateDirectory(@dp.Year + "ODA/" + dp.Month);

                string fileNameWrite = dp.Year + "ODA/" + dp.Month + "/day" + dp.Day + tenfile;
                FileStream fs = new FileStream(fileNameWrite, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, n);
                bf.Serialize(fs, listRevenue_ODA);
                fs.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;


            }
        }

        public bool ReadFileODA_Revenue(string tenfile, ref Revenue_DTO[] listRevenue_ODA, ref int n)
        {

            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);// nônnônnôn
                BinaryFormatter bf = new BinaryFormatter();
                n = (int)bf.Deserialize(fs);
                listRevenue_ODA = (Revenue_DTO[])bf.Deserialize(fs);
                fs.Close();
                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }
        #endregion
        #endregion
        #region LinkedList
        public bool writeFileLinhkedList_Renueve(string tenfile, Node_Revenue_DTO listRevenue_LinhkedList, int n)
        {

            try
            {

                DateTime dp = DateTime.Now;
                Directory.CreateDirectory(@dp.Year + "LinkedList/" + dp.Month);
                string fileNameWrite = dp.Year + "LinkedList/" + dp.Month + "/day" + dp.Day + tenfile;
                FileStream fs = new FileStream(fileNameWrite, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, n);
                while (listRevenue_LinhkedList != null)
                {
                    bf.Serialize(fs, listRevenue_LinhkedList.Data);
                    listRevenue_LinhkedList = listRevenue_LinhkedList.Next;
                }
                fs.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;


            }
        }

        public bool readFileLinhkedList_Renueve(string tenfile, ref Node_Revenue_DTO listRevenue_LinhkedList)
        {

            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);// nônnônnôn
                BinaryFormatter bf = new BinaryFormatter();
                int n = (int)bf.Deserialize(fs);
                for (int i = 0; i < n; i++)
                {
                    if (listRevenue_LinhkedList == null)
                    {
                        Revenue_DTO tmp = (Revenue_DTO)bf.Deserialize(fs);
                        listRevenue_LinhkedList = new Node_Revenue_DTO(tmp);
                    }
                    else
                    {
                        Revenue_DTO tmp = (Revenue_DTO)bf.Deserialize(fs);
                        Node_Revenue_DTO tmpHead = listRevenue_LinhkedList;
                        while (tmpHead.Next != null)
                        {
                            tmpHead = tmpHead.Next;
                        }
                        tmpHead.Next = new Node_Revenue_DTO(tmp);
                    }
                }
                fs.Close();
                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }
        #endregion


    }
}
