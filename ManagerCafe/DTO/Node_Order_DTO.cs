using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    class Node_Order_DTO
    {
        private Order_DTO data;
        private Node_Order_DTO next;

        public Node_Order_DTO(Order_DTO data)
        {
            this.data = data;
            this.next = null;
        }
        public Node_Order_DTO()
        {
            this.data = null;
            this.next = null;
        }


        public Order_DTO Data { get => data; set => data = value; }
        public Node_Order_DTO Next { get => next; set => next = value; }
    }
}
