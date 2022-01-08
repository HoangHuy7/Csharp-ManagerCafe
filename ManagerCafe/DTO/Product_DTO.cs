using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    [Serializable]
    class Product_DTO
    {

        protected string id;
        protected string name;
        protected bool size;
        protected string type;
        protected double price;

        public Product_DTO()
        {
            this.id = "";
            this.name = "";
            this.size =false;
            this.type = "";
            this.price = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Size { get => size; set => size = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
    }
}
