using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
    [Serializable]
    class Staff_DTO
    {
        private string id;
        private string passWord;
        private string name;
        private bool sex;
        private DateTime brithday;
        private string address;
        private string phoneNumber;
        private int numberSecret;
        public Staff_DTO()
        {
            this.id = "";
            this.passWord = "";
            this.name = "";
            this.sex = false;
            this.brithday = DateTime.Today;
            this.address = "";
            this.phoneNumber = "";
            this.numberSecret = 0;
        }

        public string Id { get => id; set => id = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Name { get => name; set => name = value; }
        public bool Sex { get => sex; set => sex = value; }
        public DateTime Brithday { get => brithday; set => brithday = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int NumberSecret { get => numberSecret; set => numberSecret = value; }
    }
}
