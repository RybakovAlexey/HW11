using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3
{
    internal class Manager:BankWorker,InterfaceConsultant,InterfaceManager
    {
        public override void PrintClient(int id)
        {
            Console.WriteLine($"{id,5}" +
            $"{Bank.Clients[id].Name,15}" +
            $"{Bank.Clients[id].Surname,15}" +
            $"{Bank.Clients[id].Patronymic,15}" +
            $"{Bank.Clients[id].PasportNumber,20}" +
            $"{Bank.Clients[id].TelefonNumber,20}");
        }

        public void ChangePassportNumber(int id, string number)
        {
            Bank.Clients[id].PasportNumber = number;
        }

        public void ChangeFullName(int id, string fullName)
        {
            string[] subNames = fullName.Split(' ');
            Bank.Clients[id].Name = subNames[0];
            Bank.Clients[id].Surname = subNames[1];
            Bank.Clients[id].Patronymic = subNames[2];
        }
        public virtual void ChangeTelefonNumber(int id, string number)
        {
            Bank.Clients[id].TelefonNumber = number;
        }

        public void AddClient(string fullName,
            string telefonNumber,
            string pasportNumber,
            string dataChange,
            string whoChange,
            string whatChange)
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
                                        dataChange,
                                        whoChange,
                                        whatChange));
        }

        public void DelClient(int id)
        {
            Bank.Clients.RemoveAt(id);
        }
    }
}
