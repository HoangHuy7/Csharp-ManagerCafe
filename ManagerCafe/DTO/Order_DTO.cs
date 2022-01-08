using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{

    [Serializable]
    class Order_DTO
    {
        private string idPD;
        private string namePD;
        private bool size;
        private int quantity;
        private double price;
        private string type;

        public Order_DTO()
        {
            this.idPD = null;
            this.namePD = null;
            this.size = false;
            this.quantity = 1;
            this.price = 0;
            this.Type = null;
        }

        public string IdPD { get => idPD; set => idPD = value; }
        public string NamePD { get => namePD; set => namePD = value; }
        public bool Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
    }
}
