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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"ID",5}" +
                $"{"Имя",10}" +
                $"{"Фамилия",15} " +
                $"{"Отчество",15} " +
                $"{"Паспорт",15}" +
                $"{"Телефон",15}" +
                $"{"Дата",25}" +
                $"{"Работник",10}" +
                $"{"Измен",10}",
                Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
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
            $" {Bank.Clients[id].Patronymic,15}" +
            $" {passport,15}" +
            $"{Bank.Clients[id].TelefonNumber,15}" +
            $"{Bank.Clients[id].DataChange,25}" +
            $"{Bank.Clients[id].WhoChange,10}" +
            $"{Bank.Clients[id].WhatChange,10}"
            );
        }

        public void ChangePassportNumber(int id, string number)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void ChangeFullName(int id, string fullName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void AddClient(string fullName,
            string telefonNumber,
            string pasportNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }

        public void DelClient(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно прав для выполнения этой операции");
        }
    }
}
