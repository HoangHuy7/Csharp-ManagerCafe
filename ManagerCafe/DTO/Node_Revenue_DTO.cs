using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    class Node_Revenue_DTO
    {
        private Revenue_DTO data;
        private Node_Revenue_DTO next;

        public Node_Revenue_DTO(Revenue_DTO dt)
        {
            data = dt;
            next = null;
        }
        public Node_Revenue_DTO()
        {
            data = null;
            next = null;
        }
        public Revenue_DTO Data { get => data; set => data = value; }
        public Node_Revenue_DTO Next { get => next; set => next = value; }
    }
}
