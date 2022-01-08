using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCafe.BUS
{
    class Order_BUS
    {
        private List<Order_DTO> listOrder;
        public Order_BUS()
        {
            listOrder = new List<Order_DTO>();
        }
        public Order_DTO findOrder(string id)
        {
            Order_DTO tmp = null;
            foreach (Order_DTO item in listOrder)
            {
                if (item.IdPD == id)
                {
                    tmp = item;
                    break;
                }
            }
            return tmp;
        }
        public bool addListOrder(Order_DTO odr)
        {
            try
            {
                Order_DTO tmp = findOrder(odr.IdPD);
                if (tmp != null && odr.Size == tmp.Size)
                {
                    tmp.Quantity += odr.Quantity;
                }
                else if (tmp == null || tmp != null && odr.Size != tmp.Size)
                {
                    listOrder.Add(odr);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public double totalMoney()
        {
            double total = 0;
            foreach (Order_DTO item in listOrder)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
        public bool getListOrder(ref List<Order_DTO> l)
        {
            if (listOrder == null)
                return false;
            l = listOrder;
            return true;
        }
        public bool removeItem(int index)
        {
            bool iFlag = false;
            if (index != -1)
            {
                listOrder.RemoveAt(index);
                iFlag = true;
            }
            return iFlag;

        }

    }
}
