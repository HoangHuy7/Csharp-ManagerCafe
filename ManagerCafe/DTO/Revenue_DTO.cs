using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    [Serializable]
    class Revenue_DTO
    {
        private string idStaff;
        private string idProduct;
        private string nameProduct;
        private bool size;
        private int quantity;
        private double price;
        private string type;
        private DateTime dayOrder;

        public Revenue_DTO()
        {
            this.idStaff = null;
            this.idProduct = null;
            this.nameProduct = null;
            this.size = false;
            this.quantity = 1;
            this.price = 0;
            this.type = null;
            this.dayOrder = DateTime.Now;
        }

        public string IdStaff { get => idStaff; set => idStaff = value; }
        public string IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public bool Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public DateTime DayOrder { get => dayOrder; set => dayOrder = value; }
        public string Type { get => type; set => type = value; }
    }
}
