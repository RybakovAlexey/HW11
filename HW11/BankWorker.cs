using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3
{
    abstract class BankWorker
    {
        public virtual void PrintClients()
        {
            Console.WriteLine($"{"ID",5}" +
                $"{"Имя",10}" +
                $"{" Фамилия",15} " +
                $"{"Отчество",15} " +
                $"{"паспорт",15}" +
                $"{"телефон",15}" +
                $"{"Дата",15}" +
                $"{"работник",15}" +
                $"{"Вид изменения",15}");
            foreach (Client client in Bank.Clients)
            {
                PrintClient(client.Id);
            }
        }
        public virtual void PrintClient(int id)
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
            $"{Bank.Clients[id].DataChange,15}" +
            $"{Bank.Clients[id].WhoChange,15}" +
            $"{Bank.Clients[id].WhatChange,15}"
            );
        }
    }
}
