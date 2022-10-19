using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_1
{
    internal class Client
    {
        public string Surname { get; }
        public int Id { get; }
        public string Name { get; }
        public string Patronymic { get;}
        public string TelefonNumber { get; set; }

        public string PasportNumber { get; }


        public Client(int Id, string Surname, string Name, string Patronymic, string TelefonNumber, string PasportNumber)
        {
            this.Id = Id;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.TelefonNumber = TelefonNumber;
            this.PasportNumber = PasportNumber;
        }

    }
}
