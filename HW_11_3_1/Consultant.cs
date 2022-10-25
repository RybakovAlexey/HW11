using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3_1
{
    internal class Consultant:IbankWorker
    {
        public void ChangeTelefonNumber(int id, string number)
        {
            Bank.Clients[id].TelefonNumber = number;
            Bank.Clients[id].WhoChange = "Consultant";
            Bank.Clients[id].WhatChange = "Telefon";
            Bank.Clients[id].DataChange = $"{DateTime.Now}";
        }

        public void PrintClients()
        {
            Console.WriteLine($"{"ID",5}" +
                $"{"Имя",10}" +
                $"{" Фамилия",15} " +
                $"{"Отчество",15} " +
                $"{"паспорт",20}" +
                $"{"телефон",15}" +
                $"{"Дата",20}" +
                $"{"работник",10}" +
                $"{"Вид изменения",15}");
            foreach (Client client in Bank.Clients)
            {
                PrintClient(client.Id);
            }
        }
        public void PrintClient(int id)
        {
            string passport = "none";
            if (Bank.Clients[id].PasportNumber != null)
            {
                passport = "**** ******";
            }
            Console.WriteLine($"{Bank.Clients[id].Id,5}" +
            $"{Bank.Clients[id].Name,10}" +
            $"{Bank.Clients[id].Surname,15}" +
            $"{Bank.Clients[id].Patronymic,15}" +
            $"{passport,20}" +
            $"{Bank.Clients[id].TelefonNumber,15}" +
            $"{Bank.Clients[id].DataChange,20}" +
            $"{Bank.Clients[id].WhoChange,10}" +
            $"{Bank.Clients[id].WhatChange,15}"
            );
        }

        public void ChangePassportNumber(int id, string number)
        {
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void ChangeFullName(int id, string fullName)
        {
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void AddClient(string fullName,
            string telefonNumber,
            string pasportNumber)
        {
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void DelClient(int id)
        {
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }
    }
}
