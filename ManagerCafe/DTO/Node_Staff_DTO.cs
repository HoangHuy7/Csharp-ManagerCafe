using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    class Node_Staff
    {
        private Staff_DTO data;
        private Node_Staff next;

        public Staff_DTO Data { get => data; set => data = value; }
        public Node_Staff Next { get => next; set => next = value; }

        public Node_Staff(Staff_DTO value)
        {
            data = value;
            next = null;
        }
        public Node_Staff()
        {
            data = null;
            next =null;
        }
    }
}
