﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3_1
{
    internal class Manager: IbankWorker
    {
        public virtual void PrintClients()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"ID",5}" +
                $"{"Имя",10}" +
                $"{"Фамилия",15} " +
                $"{"Отчество",15} " +
                $"{"Паспорт",15}" +
                $"{"Телефон",15}" +
                $"{"Дата изменения",25}" +
                $"{"Работник",10}" +
                $"{"Измение",10}",
                Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Client client in Bank.Clients)
            {
                PrintClient(client.Id);
            }
        }
        public void PrintClient(int id)
        {
            Console.WriteLine($"{id,5}" +
            $"{Bank.Clients[id].Name,10}" +
            $"{Bank.Clients[id].Surname,15}" +
            $" {Bank.Clients[id].Patronymic,15}" +
            $" {Bank.Clients[id].PasportNumber,15}" +
            $"{Bank.Clients[id].TelefonNumber,15}" +
            $"{Bank.Clients[id].DataChange, 25}" +
            $"{Bank.Clients[id].WhoChange,10}" +
            $"{Bank.Clients[id].WhatChange,10}");
        }

        public void ChangePassportNumber(int id, string number)
        {
            Bank.Clients[id].PasportNumber = number;
            Bank.Clients[id].WhoChange = "Manager";
            Bank.Clients[id].WhatChange = "Pasport";
            Bank.Clients[id].DataChange = $"{DateTime.Now}";
        }

        public void ChangeFullName(int id, string fullName)
        {
            string[] subNames = fullName.Split(' ');
            Bank.Clients[id].Name = subNames[0];
            Bank.Clients[id].Surname = subNames[1];
            Bank.Clients[id].Patronymic = subNames[2];
            Bank.Clients[id].WhoChange = "Manager";
            Bank.Clients[id].WhatChange = "Name";
            Bank.Clients[id].DataChange = $"{DateTime.Now}";
        }
        public virtual void ChangeTelefonNumber(int id, string number)
        {
            Bank.Clients[id].TelefonNumber = number;
            Bank.Clients[id].WhoChange = "Manager";
            Bank.Clients[id].WhatChange = "Telefon";
            Bank.Clients[id].DataChange = $"{DateTime.Now}";
        }

        public void AddClient(string fullName,
            string telefonNumber,
            string pasportNumber)
        {
            int id = Bank.Clients.Count;
            string[] subNames = fullName.Split(' ');
            Bank.Clients.Add(new Client(
                                        id,
                                        subNames[0],
                                        subNames[1],
                                        subNames[2],
                                        telefonNumber,
                                        pasportNumber,
                                        $"{DateTime.Now}",
                                        "Manager",
                                        "Add"));
        }

        public void DelClient(int id)
        {
            Bank.Clients.RemoveAt(id);
        }
    }
}
