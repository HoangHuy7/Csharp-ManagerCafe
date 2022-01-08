using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    class Node_Product_DTO
    {
        private Product_DTO data;
        private Node_Product_DTO next;

        public Product_DTO Data { get => data; set => data = value; }
        public Node_Product_DTO Next { get => next; set => next = value; }

        public Node_Product_DTO(Product_DTO value)
        {
            data = value;
            next = null;
        }
        public Node_Product_DTO()
        {
            data = null;
            next = null;
        }
    }
}
