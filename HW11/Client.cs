using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3
{
    internal class Client
    {
        private string pasportNumber;
        public string Surname { get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string TelefonNumber { get; set; }
        public string PasportNumber {
            get 
            { 
                return pasportNumber;
            }
            set 
            { 
                pasportNumber = value; 
            } 
        }
        public string DataChange { get; set; }
        public string WhoChange { get; set; }
        public string WhatChange { get; set; }



        public Client(int Id,
            string Surname,
            string Name,
            string Patronymic,
            string TelefonNumber,
            string PasportNumber,
            string DataChange,
            string WhoChange,
            string WhatChange
            )
        {
            this.Id = Id;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.TelefonNumber = TelefonNumber;
            this.PasportNumber = PasportNumber;
            this.DataChange = DataChange;
            this.WhoChange = WhoChange;
            this.WhatChange = WhatChange;
        }


    }
}
