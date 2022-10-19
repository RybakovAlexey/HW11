using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HW_11_2
{
    internal class Consultant
    {
        public void PrintClients()
        {
            Console.WriteLine($"{"ID",5}{"Имя",15}{" Фамилия",15} {"Отчество",15} {"номер паспорта",20}{"котактный телефон",20}");
            foreach (Client client in Bank.Clients)
            {
                PrintClient(client.Id);
            }
        }
        public void PrintClient(int id)
        {
            string pasport = "none";
            if (!String.IsNullOrEmpty(Bank.Clients[id].PasportNumber)) pasport = "**** ******";
            Console.WriteLine($"{id,5}" +
            $"{Bank.Clients[id].Name,15}" +
            $"{Bank.Clients[id].Surname,15}" +
            $"{Bank.Clients[id].Patronymic,15}" +
            $"{pasport,20}" +
            $"{Bank.Clients[id].TelefonNumber,20}");
        }
        public void ChangeTelefonNumber(int id, string number)
        {
            if (!String.IsNullOrEmpty(number))
            {
                Bank.Clients[id].TelefonNumber = number;
            }
        }
    }   
}
