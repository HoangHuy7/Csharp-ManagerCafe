using ManagerCafe.DTO;
using ManagerCafe.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.BUS
{
    class OrderODA_BUS
    {
        private Order_DTO[] listOrder;
        int n;
        int all;
        public static int allElement_Product = 50;
        public OrderODA_BUS()
        {
            n = 0;
            all = 50;
            listOrder = new Order_DTO[all];
        }
        public Order_DTO find_ItemOrder(string id)
        {
            for (int i = 0; i < n; i++)
            {
                if (id == listOrder[i].IdPD)
                    return listOrder[i];
            }
            return null;
        }
        public bool addItem(Order_DTO odr)
        {
            Order_DTO tmp = find_ItemOrder(odr.IdPD);
            bool iFlag = false;
            if (tmp != null && odr.Size == tmp.Size)
            {
                tmp.Quantity += odr.Quantity;
                iFlag = true;
            }
            else if (null == tmp && n - 1 < all || tmp != null && n - 1 < all)
            {
                listOrder[n++] = odr;
                iFlag = true;
            }
            return iFlag;
        }
        public bool removePos_Item(int pos)
        {
            bool iFlag = false;
            if (n > 0)
            {
                for (int i = pos; i < n - 1; i++)
                    listOrder[i] = listOrder[i + 1];
                n--;
                iFlag = true;
            }
            return iFlag;
        }
        public double totalMoney_ODA()
        {
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                total += listOrder[i].Price * listOrder[i].Quantity;
            }
            return total;
        }
        public bool getListOrder(ref List<Order_DTO> l)
        {

            if (listOrder == null)
                return false;
            for (int i = 0; i < n; i++)
            {
                l.Add(listOrder[i]);
            }
            return true;
        }


    }
}
