using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_2
{
    internal class Manager:Consultant
    {
        public void AddClient(string fullName, string telefonNumber, string pasportNumber)
        {
            int id = Bank.Clients.Count;
            string[] subNames = fullName.Split(' ');
            Bank.Clients.Add(new Client(
                                        id,
                                        subNames[0],
                                        subNames[1],
                                        subNames[2],
                                        telefonNumber,
                                        pasportNumber));
        }

    }
}
